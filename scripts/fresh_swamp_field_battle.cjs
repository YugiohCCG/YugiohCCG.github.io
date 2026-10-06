'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,SelectBattleCMDAction:B,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=239935101,ally=900001041,attacker=900001042,filler=900001043,results=[];
 const control=process.argv.includes('--no-zero')?'no-zero':process.argv.includes('--any-monster')?'any-monster':null;
 for(const test of [{},{opponentHydra:true},{decline:true},{unrelated:true},{ownattack:true},{ownattack:true,direct:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:4,race:1024n,attack:2500,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[ally,{...base,code:ally,setcodes:test.unrelated||test.opponentHydra?[]:[0xa124],type:33,attack:3000,defense:3000}],[attacker,{...base,code:attacker,attack:1000,defense:1500,setcodes:test.opponentHydra?[0xa124]:[]}],[filler,{...base,code:filler}]]);
  const reader=name=>{
   if([ally,attacker,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));assert(file,'Missing '+name);let source=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'&&control==='no-zero')source=source.replace('zero:SetValue(0)','zero:SetValue(777)');
   if(name==='c'+boss+'.lua'&&control==='any-monster')source=source.replace('c:IsSetCard(SET_HYDRA)','c:IsType(TYPE_MONSTER)');
   return source;
  };
  // No summon-procedure or geometry adapters.
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,turn=0,done=false,attacked=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,controller,sequence=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(duel,{team:controller,duelist:0,code,controller,location,sequence,position});
   add(boss,L.SZONE,0,5);add(ally,L.MZONE,0,0,test.ownattack?P.FACEUP_ATTACK:P.FACEUP_DEFENSE);if(!test.direct)add(attacker,L.MZONE,1,0,test.ownattack?P.FACEUP_DEFENSE:P.FACEUP_ATTACK);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.ATTACK|Q.DEFENSE,controller,location}).filter(Boolean);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    assert(!logs.some(x=>x.type===0),logs.map(x=>x.message).join('; '));assert.notEqual(state,S.END,'Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD)core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:turn===(test.ownattack?3:2)?A.TO_BP:A.TO_EP});
    else if(p.type===M.SELECT_BATTLECMD){
     if(!attacked){assert.equal(p.player,test.ownattack?0:1);const index=p.attacks.findIndex(x=>x.code===(test.ownattack?ally:attacker));assert(index>=0);attacked=true;core.duelSetResponse(duel,{type:R.SELECT_BATTLECMD,action:B.SELECT_BATTLE,index});continue;}
     assert(trace.some(x=>x.type===M.ATTACK),'Actual attack missing');
     const destroyed=query(L.GRAVE,test.opponentHydra?1:0).some(x=>x.code===(test.opponentHydra?attacker:ally)&&(x.reason&1)&&(x.reason&0x40));assert.equal(destroyed,!test.unrelated,'Hydra effect destruction mismatch');
     const chains=trace.filter(x=>x.type===M.CHAINING&&x.code===boss);assert.equal(chains.length,test.unrelated?0:1,'Battle trigger mismatch');
     if(test.opponentHydra){const own=query(L.MZONE).find(x=>x.code===ally);assert(own,'Own opposing monster lost');assert.equal(own.attack,3000);assert.equal(own.defense,3000);}
     else if(!test.direct){const other=query(L.MZONE,1).find(x=>x.code===attacker);assert(other,'Opposing monster unexpectedly lost');const zero=!test.unrelated&&!test.decline;assert.equal(other.attack,zero?0:1000,'Opponent ATK mismatch');assert.equal(other.defense,zero?0:1500,'Opponent DEF mismatch');}done=true;
    }
    else if(p.type===M.SELECT_CARD){const code=p.player===1?ally:attacker;const index=p.selects.findIndex(x=>x.code===code||x.code===ally);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(x=>x.code===boss);if(test.unrelated)assert.equal(index,-1,'Unrelated battle trigger offered');core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
    else if(p.type===M.SELECT_EFFECTYN){assert(!test.unrelated,'Unrelated trigger offered');core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/swamp-field-battle'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public OCGCore, full production Terrifying Dark Swamp/candidate metadata seeded actual field slot; neutral Hydra and opponent; actual attacks and Damage Step trigger, effect destruction and optional stat-zero; native Omega untested',adapters:[],control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
