'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=212184534,lab=900001191,filler=900001192,spellCost=900001193,recipient=900001194,results=[];
 const control=['no-destroy','no-detach'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{spell:true},{facedown:true},{own:true},{noMaterial:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:1000,defense:1200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:test.spellTarget?0x20002:33,setcodes:[]}],[filler,{...base,code:filler}],[recipient,{...base,code:recipient,type:17}]]);
  cards.set(900001195,{...base,code:900001195,type:test.spell?2:17});cards.set(spellCost,{...base,code:spellCost,type:17,setcodes:[0x103]});
  const reader=name=>{
   if(name==='c'+recipient+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_MZONE,0,nil,${boss}) local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,${lab}) if #g>0 then Duel.Overlay(tc,g) end Duel.Hint(HINT_NUMBER,tp,900+tc:GetOverlayCount()) end) c:RegisterEffect(e) end`;if([lab,filler,spellCost,900001195].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){
    
    if(control==='no-destroy')lua=lua.replace('Duel.Destroy(tc,REASON_EFFECT)','do end');if(control==='no-detach')lua=lua.replace('e:GetHandler():RemoveOverlayCard(tp,1,1,REASON_COST)','do end');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false,turn=0,secondary=false,placementStarted=false,placementFinished=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   if(!test.noMaterial)add(lab,L.HAND);add(900001195,test.spell?L.SZONE:L.MZONE,test.own?0:1,test.facedown?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK,test.own?2:0);add(boss,L.MZONE,0,P.FACEUP_ATTACK,0);add(recipient,L.MZONE,0,P.FACEUP_ATTACK,1);for(const player of [0,1])for(let i=0;i<(test.emptyDeck&&player===0?0:8);i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION|Q.ATTACK|Q.DEFENSE,controller,location}).filter(Boolean);let placements=0,attached=false;
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(!attached){const index=p.activates.findIndex(c=>c.code===recipient);assert(index>=0);attached=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}if(!activated){assert(trace.some(m=>m.type===M.HINT&&String(m.hint)===(test.noMaterial?'900':'901')),'Actual native overlay count');const index=p.activates.findIndex(c=>c.code===boss&&String(c.description)==='2114952545');assert.equal(index>=0,!test.noMaterial,'Native material-cost availability');if(test.noMaterial){done=true;continue;}activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}const cost=query(L.GRAVE).find(c=>c.code===lab);assert(cost&&(cost.reason&0x80),'Actual material detached as cost');assert(query(L.GRAVE,test.own?0:1).some(c=>c.code===900001195),'Actual targeted card destroyed');assert(query(L.MZONE).some(c=>c.code===boss));done=true;}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===900001195||c.code===lab);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_UNSELECT_CARD){const index=p.can_finish?null:p.select_cards.findIndex(c=>c.code===spellCost);assert(index===null||index>=0);core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:true});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x1f)!==0x1f;const shift=isMonster?0:8;const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
    else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===boss);core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-stellaer-flames-destroy'+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:null,scope:'Full current Stellaer Flames initially MZONE; actual native neutral helper Overlay of Hand material, actual printed detach-cost and targeted destruction. Monster/Spell/down/own targets, no-material exclusion. No adapters; Overlay fixture does not certify Xyz arrival/Omega/fullcard.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(c=>c.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
