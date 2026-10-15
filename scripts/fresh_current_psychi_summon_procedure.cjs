'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=217332244,partner=900001191,cost=900001193,original=900001195,filler=900001192;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-cost','wrong-set','allow-down'].find(c=>process.argv.includes('--'+c));
 const tests=[{},{full:true},{wrong:true},{down:true},{opponent:true},{absent:true},{locked:true}];
 for(const test of tests){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:1000,defense:1200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[partner,{...base,code:partner,setcodes:test.wrong?[]:[0xe80d]}],[filler,{...base,code:filler}]]);
  const reader=name=>{
   if(name==='c0.lua')return '';
   if(name==='c'+partner+'.lua'&&test.locked)return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_FIELD) e:SetRange(LOCATION_MZONE) e:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON) e:SetProperty(EFFECT_FLAG_PLAYER_TARGET) e:SetTargetRange(1,0) c:RegisterEffect(e) end';
   if(name==='c'+partner+'.lua'||name==='c'+filler+'.lua')return 'local s,id=GetID() function s.initial_effect(c) end';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'){
    if(control==='no-cost')lua=lua.replace('Duel.Remove(g,POS_FACEUP,REASON_COST)','do end');
    if(control==='wrong-set')lua=lua.replace('c:IsSetCard(SET_TO_PROTO) and c:IsType(TYPE_MONSTER)','c:IsType(TYPE_MONSTER)');
    if(control==='allow-down')lua=lua.replace('return c:IsFaceup() and c:IsSetCard','return c:IsSetCard');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,done=false,activated=false;
  const eligible=!(test.wrong||test.down||test.opponent||test.absent||test.locked);
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(boss,L.HAND);if(!test.absent)add(partner,L.MZONE,test.opponent?1:0,test.down?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK,0);
   if(test.full)for(let i=1;i<5;i++)add(filler,L.MZONE,0,P.FACEUP_ATTACK,i);
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     assert(!p.summons.some(c=>c.code===boss),'Normal Summon forbidden');assert(!p.monster_sets.some(c=>c.code===boss),'Normal Set forbidden');
     if(!activated){const index=p.special_summons.findIndex(c=>c.code===boss);assert.equal(index>=0,eligible,'Native procedure eligibility');if(!eligible){done=true;continue;}activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SPECIAL_SUMMON,index});continue;}
     assert(query(L.MZONE).some(c=>c.code===boss),'Actual source summon');assert(!query(L.HAND).some(c=>c.code===boss));assert(query(L.REMOVED).some(c=>c.code===partner&&(c.reason&0x80)),'Actual faceup banish cost');assert.equal(query(L.MZONE).length,test.full?5:1);done=true;
    }else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===partner);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-psychi-summon-procedure'+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:null,scope:'Full current Psychi native Hand procedure, actual own faceup To Proto banish cost, full field frees material zone; wrong set/down/opposing/absent/player summon lock exclude. Native Normal Summon/Set forbidden. Neutral materials, no adapters; other effects/proper revival/fullcard OPEN',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
