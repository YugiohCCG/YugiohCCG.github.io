'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,SelectBattleCMDAction:B,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=284639726,ally=900001041,attacker=900001042,filler=900001043,results=[];
 const control=process.argv.includes('--always-protect')?'always-protect':process.argv.includes('--never-protect')?'never-protect':null;
 for(const test of [{},{attack:true},{facedown:true},{unrelated:true},{nonpendulum:true},{unlinked:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:4,race:1024n,attack:2500,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[ally,{...base,code:ally,setcodes:test.unrelated?[]:[0xa122],type:test.nonpendulum?33:0x1000021}],[attacker,{...base,code:attacker}],[filler,{...base,code:filler}]]);
  const reader=name=>{
   if([ally,attacker,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));assert(file,'Missing '+name);let source=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'&&control)source=source.replace('e0:SetCondition(s.protect)','e0:SetCondition(function() return '+(control==='always-protect'?'true':'false')+' end)');
   return source;
  };
  // Public package's 32-bit writer puts rscale in core's marker slot (48).
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{const c=cards.get(code);return c&&(c.type&0x4000000)?{...c,rscale:c.link_marker}:c;},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,turn=0,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,controller,sequence=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(duel,{team:controller,duelist:0,code,controller,location,sequence,position});
   add(boss,L.MZONE,0,5);add(ally,L.MZONE,0,test.unlinked?4:1,test.attack?P.FACEUP_ATTACK:test.facedown?P.FACEDOWN_DEFENSE:P.FACEUP_DEFENSE);add(attacker,L.MZONE,1);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    assert(!logs.some(x=>x.type===0),logs.map(x=>x.message).join('; '));assert.notEqual(state,S.END,'Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD)core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:turn===2?A.TO_BP:A.TO_EP});
    else if(p.type===M.SELECT_BATTLECMD){assert.equal(p.player,1);const index=p.attacks.findIndex(x=>x.code===attacker);assert(index>=0,'Opponent attack unavailable');const source=core.duelQueryLocation(duel,{flags:Q.CODE|Q.LINK,controller:0,location:L.MZONE}).filter(Boolean).find(x=>x.code===boss);assert.equal(source.link.marker,candidateCard(boss).link_marker);core.duelSetResponse(duel,{type:R.SELECT_BATTLECMD,action:B.SELECT_BATTLE,index});}
    else if(p.type===M.SELECT_CARD){assert.equal(p.player,1);assert(p.selects.some(x=>x.code===ally),'Other battle target missing');assert.equal(p.selects.some(x=>x.code===boss),Object.keys(test).length>0,'Venus battle-target protection mismatch');done=true;}
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/terrarumian-venus-protection'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public OCGCore, production Venus and candidate metadata; seeded Link, neutral opponent attacker and Pendulum ally; actual battle target prompts, no full battle/procedure/native Omega certification',adapters:['Link-only rscale-to-marker transfer, queried marker equals database'],control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
