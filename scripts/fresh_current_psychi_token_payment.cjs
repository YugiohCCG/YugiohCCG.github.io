'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=217332244,partner=240299293,cost=900001193,original=900001195,filler=900001192;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-pay','no-atk','no-def'].find(c=>process.argv.includes('--'+c));
 const tests=[{pay:100},{pay:7999},{pay:1,lp:2},{pay:777},{wrong:true,pay:100},{absent:true,pay:100},{lp:1,pay:1},{lp:101,pay:99},{lp:10,pay:9},{lp:1000,pay:999},{lp:10000,pay:1},{lp:10001,pay:10000},{pay:7777}];
 for(const test of tests){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:1000,defense:1200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[partner,{...base,code:partner,type:0x4011}],[filler,{...base,code:filler}],[900001191,{...base,code:900001191,type:0x4011}]]);
  const reader=name=>{
   if(name==='c0.lua')return '';
   if([partner,filler,900001191].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'){
    if(process.argv.includes('--candidate'))lua=fs.readFileSync(path.join(ROOT,'output/fresh-ccg-september/psychi-payment-candidate.lua'),'utf8');
    if(control==='no-pay')lua=lua.replace('Duel.PayLPCost(tp,pay)','do end');
    if(control==='no-atk')lua=lua.replace('e1:SetValue(val)','e1:SetValue(0)');
    if(control==='no-def')lua=lua.replace('e2:SetCode(EFFECT_UPDATE_DEFENSE)','e2:SetCode(EFFECT_UPDATE_ATTACK)');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:test.lp||8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,done=false,activated=false,digitStep=0;
  const eligible=!(test.wrong||test.absent||test.lp===1);
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(boss,L.MZONE,0,P.FACEUP_ATTACK,0);if(!test.absent)add(test.wrong?900001191:partner,L.MZONE,0,P.FACEUP_ATTACK,1);
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION|Q.ATTACK|Q.DEFENSE,controller:0,location}).filter(Boolean);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!activated){const index=p.activates.findIndex(c=>c.code===boss);assert.equal(index>=0,eligible,'Token and payable LP required');if(!eligible){done=true;continue;}activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     const c=query(L.MZONE).find(c=>c.code===boss),baseCard=candidateCard(boss);assert.equal(c.attack,baseCard.attack+test.pay,'Exact ATK gain');assert.equal(c.defense,baseCard.defense+test.pay,'Exact DEF gain');assert(!query(L.MZONE).some(c=>c.code===partner),'Actual Token tribute');assert(trace.some(m=>m.type===M.PAY_LPCOST&&m.player===0&&Number(m.amount)===test.pay),'Actual LP payment');done=true;

    }else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===partner);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.ANNOUNCE_NUMBER){const digits=String(test.pay).padStart(String((test.lp||8000)-1).length,'0');const wanted=Number(digits[digitStep++]);const index=p.options.findIndex(n=>Number(n)===wanted);assert(index>=0,'Printed any-amount LP choice '+test.pay+' unavailable');core.duelSetResponse(duel,{type:R.ANNOUNCE_NUMBER,value:index});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-psychi-token-payment'+(process.argv.includes('--candidate')?'-candidate':'')+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:null,scope:'Full initial-MZONE Psychi actual Token tribute and native LP declaration/payment, exact permanent ATK DEF gain. Includes arbitrary printed payment777, low LP2 and LP1 boundaries. No proper summon history/adapters; fullcard OPEN',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
