'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,SelectBattleCMDAction:B,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),terrarium=284636586,pendulum=900000371,attacker1=900000372,attacker2=900000373,filler=900000374,pendulum2=900000375;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),r=db.prepare('select * from datas where id=?').get(terrarium);db.close();
 const base={alias:0,setcodes:[],type:17,level:4,attribute:2,race:0x400n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const field={...base,code:terrarium,setcodes:[0xA122],type:Number(r.type),level:0,attribute:0,race:0n,attack:0,defense:0};
 const tests=[{mode:'boost',attack:1500,two:false},{mode:'first-only',attack:2500,two:true},{mode:'each',attack:2500,two:true}];
 const results=[];
 for(const test of tests){
  const cards=new Map([[terrarium,field],[pendulum,{...base,code:pendulum,setcodes:[0xA122],type:0x1000021}],[pendulum2,{...base,code:pendulum2,setcodes:[0xA122],type:0x1000021}],[attacker1,{...base,code:attacker1,attack:test.attack}],[attacker2,{...base,code:attacker2,attack:test.attack}],[filler,{...base,code:filler}]]);
  const trace=[],logs=[];
  const reader=name=>{if([`c${pendulum}.lua`,`c${pendulum2}.lua`,`c${attacker1}.lua`,`c${attacker2}.lua`,`c${filler}.lua`].includes(name))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8')};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{if(!cards.has(code))throw Error('Missing card '+code);return cards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,attacks=0,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
   const add=(code,location,player=0,seq=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:seq,position:P.FACEUP_ATTACK});
   add(terrarium,L.SZONE,0,5);add(pendulum,L.MZONE);if(test.mode==='each')add(pendulum2,L.MZONE,0,1);add(attacker1,L.MZONE,1,0);if(test.two)add(attacker2,L.MZONE,1,1);
   for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<170&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);
    if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));
    if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(p.type===M.SELECT_IDLECMD){if(p.player===1&&p.to_bp)core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_BP});else core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});}
    else if(p.type===M.SELECT_BATTLECMD){const own=core.duelQueryLocation(duel,{flags:Q.CODE|Q.ATTACK,controller:0,location:L.MZONE}).find(c=>c?.code===pendulum);
     if(attacks===0){if(!own||own.attack!==1000)throw Error('Attack boost active outside damage calculation');const index=p.attacks.findIndex(c=>c.code===attacker1);if(index<0)throw Error('First attack unavailable');attacks++;core.duelSetResponse(duel,{type:R.SELECT_BATTLECMD,action:B.SELECT_BATTLE,index});}
     else if(attacks===1&&test.two){if(!own)throw Error('First battle destruction not prevented');const index=p.attacks.findIndex(c=>c.code===attacker2);if(index<0)throw Error('Second attack unavailable');attacks++;core.duelSetResponse(duel,{type:R.SELECT_BATTLECMD,action:B.SELECT_BATTLE,index});}
     else{const ownM=core.duelQueryCount(duel,0,L.MZONE),oppM=core.duelQueryCount(duel,1,L.MZONE);if(test.mode==='boost'&&(ownM!==1||oppM!==0))throw Error(`Damage-calculation boost failed: own=${ownM} opp=${oppM}`);if(test.mode==='first-only'&&(ownM!==0||oppM!==2))throw Error(`First-only battle protection failed: own=${ownM} opp=${oppM}`);if(test.mode==='each'&&(ownM!==2||oppM!==2))throw Error(`Per-monster battle protection failed: own=${ownM} opp=${oppM}`);done=true;break;}
    }else if(p.type===M.SELECT_CARD){const expected=test.mode==='each'&&attacks===2?pendulum2:pendulum,index=p.selects.findIndex(c=>c.code===expected);if(index<0)throw Error('Terrarumian battle target missing');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:null});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:true});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  results.push({test,status:failure?'FAIL':'PASS',failure,attacks,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${test.mode}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/terrarumian-terrarium-battle.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
