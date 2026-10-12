'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=210923192,lab=900001191,filler=900001192,spellCost=900001193,recipient=900001194,results=[];
 const control=['no-boost','no-departure'].find(c=>process.argv.includes('--'+c));
 for(const test of [{destination:'hand'},{destination:'removed'},{destination:'hand',copies:2}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:1000,defense:1200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:17,setcodes:test.wrongSet?[]:[0xc1c]}],[filler,{...base,code:filler}],[recipient,{...base,code:recipient,type:2}]]);
  cards.set(spellCost,{...base,code:spellCost,type:33});
  const reader=name=>{
   if(name==='c'+spellCost+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_SZONE,0,nil,${boss}) ${control==='no-departure'?'Duel.Hint(HINT_MESSAGE,tp,880)':test.destination==='hand'?'Duel.SendtoHand(tc,nil,REASON_EFFECT)':'Duel.Remove(tc,POS_FACEUP,REASON_EFFECT)'} end) c:RegisterEffect(e) end`;if([lab,filler,recipient].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){
    
    if(control==='no-boost')lua=lua.replace('e2:SetValue(500)','e2:SetValue(0)');if(control==='allow-any')lua=lua.replace('c:IsFaceup() and c:IsSetCard(SET_ALDREZ)','c:IsFaceup()');if(control==='both-players')lua=lua.replace('e2:SetTargetRange(LOCATION_MZONE,0)','e2:SetTargetRange(LOCATION_MZONE,LOCATION_MZONE)');if(control==='allow-facedown')lua=lua.replace('c:IsFaceup() and c:IsSetCard(SET_ALDREZ)','c:IsSetCard(SET_ALDREZ)');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false,turn=0,secondary=false,placementStarted=false,placementFinished=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   for(let i=0;i<(test.copies||1);i++)add(boss,L.HAND);add(lab,L.MZONE,0,P.FACEUP_ATTACK);add(spellCost,L.MZONE,0,P.FACEUP_ATTACK,1);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION|Q.ATTACK|Q.DEFENSE,controller,location}).filter(Boolean);let placements=0,departed=false;
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(placements<(test.copies||1)){const index=p.activates.findIndex(c=>c.code===boss&&c.location===L.HAND);assert(index>=0,'Actual full Continuous Spell activation');placements++;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}const tc=query(L.MZONE).find(c=>c.code===lab);assert(tc);if(!departed){assert.equal(tc.attack,1000+500*(test.copies||1),'Initial native boost');assert.equal(tc.defense,1200+500*(test.copies||1));const index=p.activates.findIndex(c=>c.code===spellCost);assert(index>=0);departed=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}assert(query(test.destination==='hand'?L.HAND:L.REMOVED).some(c=>c.code===boss),'Actual source departure');assert.equal(query(L.SZONE).filter(c=>c.code===boss).length,(test.copies||1)-1);assert.equal(tc.attack,1000+500*((test.copies||1)-1),'Native ATK after source departure');assert.equal(tc.defense,1200+500*((test.copies||1)-1),'Native DEF after source departure');done=true;}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===lab);assert(index>=0,'Actual recycle target choice');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!!test.draw});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x1f)!==0x1f;const shift=isMonster?0:8;const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
    else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===boss);core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-aldrez-opening-source-departure'+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:null,scope:'Full current Opening actual Continuous Spell activation, initial native ATK/DEF boost, actual neutral effect Hand/banish departure, and native boost reset or remaining-copy boost. No adapters. Native Omega/recycle and response reset remain open.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(c=>c.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
