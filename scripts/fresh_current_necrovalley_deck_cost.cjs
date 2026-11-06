'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto');
const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport(),{candidateCard}=require('./fresh_installed_card.cjs');
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),mode=process.argv.includes('--prior')?'prior':process.argv.includes('--no-payment')?'no-payment':'candidate',results=[];
 for(const [boss,cost,setcode,count] of [[218142234,'pcost',0xb47,3],[256287781,'chcost',0x11f,4],[256462992,'thcost',0xba8,0],[259360287,'spcost',0xf78,1]])for(const test of [{},{necro:true},{necro:true,absent:true}]){
  const resource=900009700,filler=900009710,nv=47355498,logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:1,race:1n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[nv,{...base,code:nv,type:0x80002}],[filler,{...base,code:filler,type:2}]]);
  for(let i=0;i<count;i++)cards.set(resource+i,{...base,code:resource+i,setcodes:[setcode],type:boss===259360287?2:33});
  const reader=name=>{
   if(name==='c0.lua')return '';
   if(name==='c'+filler+'.lua'||/^c90000970\d\.lua$/.test(name))return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c'+boss+'.lua'){
    let lua=fs.readFileSync(path.join(OUT,'necrovalley-deck-cost-before-repair','c'+boss+'.lua'),'utf8');
    if(mode!=='prior')lua=require('./fresh_necrovalley_deck_cost_repair.cjs').corrected(lua,boss);
    lua=lua.replace('function s.initial_effect(c)','function s.original_initial_effect(c)');
    return lua+`\nfunction s.initial_effect(c) local x=Effect.CreateEffect(c) x:SetType(EFFECT_TYPE_IGNITION) x:SetRange(${boss===218142234?'LOCATION_MZONE':'LOCATION_HAND+LOCATION_GRAVE'}) x:SetCost(${mode==='no-payment'?'function(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end end':'s.'+cost}) x:SetOperation(function(e,tp) Duel.Recover(tp,100,REASON_EFFECT) end) c:RegisterEffect(x) end`;
   }
   const p=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(p=>fs.existsSync(p));assert(p,name);return fs.readFileSync(p,'utf8');
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   if(boss===259360287)core.loadScript(duel,'bounded-faceup-ex-compat.lua','Card.IsFaceupEx=function(c) return c:IsFaceup() or c:IsLocation(LOCATION_HAND+LOCATION_GRAVE+LOCATION_DECK) end');
   const add=(code,location,player=0,position=P.FACEUP_ATTACK,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,position,sequence});
   add(boss,boss===218142234?L.MZONE:boss===256462992?(test.absent?L.MZONE:L.GRAVE):L.HAND);
   for(let i=0;i<count-(test.absent?1:0);i++)add(resource+i,L.GRAVE);
   if(test.necro)add(nv,L.SZONE,1,P.FACEUP_ATTACK,5);
   for(const p of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,p,P.FACEDOWN_DEFENSE);
   core.startDuel(duel);
   const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,location,controller}).filter(Boolean);
   for(let step=0;step<160&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!activated){const index=p.activates.findIndex(c=>c.code===boss);assert.equal(index>=0,!test.absent,'Original cost availability');if(test.absent){done=true;continue;}activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}
     else {if(boss===256462992)assert(query(L.EXTRA).some(c=>c.code===boss&&(c.reason&128)),'Source returned to Extra as actual cost');else for(let i=0;i<count;i++)assert(query(L.DECK).some(c=>c.code===resource+i&&(c.reason&128)),'Every selected card returned to Deck as actual cost');done=true;}
    }else if(p.type===M.SELECT_CARD)core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:p.selects.map((c,i)=>i).slice(0,p.min)});
    else if(p.type===M.SELECT_UNSELECT_CARD){const i=p.select_cards.findIndex(c=>c.code>=resource&&c.code<resource+count);core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index:i>=0?i:null});}
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:true});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({boss,test,failure,logs,trace});console.log((failure?'FAIL ':'PASS ')+boss+' '+JSON.stringify(test)+(failure?' '+failure:''));
 }
 const artifact=path.join(OUT,'current-necrovalley-deck-cost-'+mode+'.json');fs.writeFileSync(artifact,JSON.stringify({scope:'Exact original cost callbacks in isolated registered ignition effects, original installed boss metadata, actual official Necrovalley script and native payment. Wrapper omits original target/operation/summon procedure: not full effect or native Omega certification. Sorceress alone uses the previously documented test-only Card.IsFaceupEx mapping; no production API change.',mode,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
