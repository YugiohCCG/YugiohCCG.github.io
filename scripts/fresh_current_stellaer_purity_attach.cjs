'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=214226989,lab=900001191,filler=900001192,spellCost=900001193,recipient=900001194,results=[];
 const control=['no-attach','no-transfer','ignore-type'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{noMaterial:true},{wrongType:true},{facedown:true},{opponent:true},{noTarget:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:1000,defense:1200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:test.spellTarget?0x20002:33,setcodes:[]}],[filler,{...base,code:filler}],[recipient,{...base,code:recipient,type:17}]]);
  cards.set(900001195,{...base,code:900001195,type:test.wrongType?17:0x800011});cards.set(spellCost,{...base,code:spellCost,type:17,setcodes:[0x103]});
  const reader=name=>{
   if(name==='c'+recipient+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_MZONE,LOCATION_MZONE,nil,900001195) local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,${lab}) if tc and #g>0 then Duel.Overlay(tc,g) end Duel.Hint(HINT_NUMBER,tp,900+(tc and tc:GetOverlayCount() or 0)) end) c:RegisterEffect(e) end`;if([lab,filler,spellCost,900001195].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){
    
    if(control==='no-attach')lua=lua.replace('Duel.Overlay(c,Group.FromCards(tc))','do end');if(control==='no-transfer')lua=lua.replace('Duel.Overlay(c,og)','do end');if(control==='ignore-type')lua=lua.replace('c:IsFaceup() and c:IsType(TYPE_XYZ) and c:IsCanOverlay()','c:IsFaceup() and c:IsCanOverlay()');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false,turn=0,secondary=false,placementStarted=false,placementFinished=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   if(!test.noMaterial&&!test.noTarget){add(lab,L.HAND);add(lab,L.HAND);}if(!test.noTarget)add(900001195,L.MZONE,test.opponent?1:0,test.facedown?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK,2);add(boss,L.MZONE,0,P.FACEUP_ATTACK,0);add(recipient,L.MZONE,0,P.FACEUP_ATTACK,1);for(const player of [0,1])for(let i=0;i<(test.emptyDeck&&player===0?0:8);i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION|Q.ATTACK|Q.DEFENSE|Q.OVERLAY_CARD,controller,location}).filter(Boolean);let placements=0,attached=false;
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(!attached){const index=p.activates.findIndex(c=>c.code===recipient);assert(index>=0);attached=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}if(!activated){const index=p.activates.findIndex(c=>c.code===boss&&String(c.description)===String(132226989*16));const eligible=!(test.wrongType||test.facedown||test.opponent||test.noTarget);assert.equal(index>=0,eligible,'Actual own other faceup Xyz eligibility');if(!eligible){done=true;continue;}activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}const source=query(L.MZONE).find(c=>c.code===boss);assert(source,'Source stays field');assert(!query(L.MZONE).some(c=>c.code===900001195),'Target leaves field');assert.deepEqual([...source.overlayCards].sort((a,b)=>a-b),[900001195,...(test.noMaterial?[]:[lab,lab])].sort((a,b)=>a-b),'Actual target plus all transferred materials');assert(!query(L.GRAVE).some(c=>c.code===lab||c.code===900001195),'No transferred material sent GY');done=true;}
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
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-stellaer-purity-attach'+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:null,scope:'Full current initial-field Stellaer of Purity actual printed targeted attachment of other own faceup Xyz and its zero/two native helper Overlay materials. Wrongtype/facedown/opponent/self-only exclude activation. Actual material identities/destinations; no adapters or proper Xyz history. Negation/revival/use/interruption/Omega/fullcard open',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(c=>c.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
