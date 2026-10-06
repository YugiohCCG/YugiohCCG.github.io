'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,SelectBattleCMDAction:B,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),trumpet=284639724,attacker=900000621,victim=900000622,trap=900000623,filler=900000624,secondVictim=900000625;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),r=db.prepare('select * from datas where id=?').get(trumpet);db.close();
 const base={alias:0,setcodes:[],type:33,level:4,attribute:2,race:0x400n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const results=[];
 for(const battle of [false,true,'direct','shared']){
  const direct=battle==='direct'||battle==='shared',shared=battle==='shared';
  const trace=[],logs=[],cards=new Map([[trumpet,{...base,code:trumpet,setcodes:[0xA122],type:Number(r.type),level:Number(r.level)&255,lscale:(Number(r.level)>>>24)&255,rscale:(Number(r.level)>>>16)&255,attribute:Number(r.attribute),race:BigInt(r.race),attack:Number(r.atk),defense:Number(r.def)}],[attacker,{...base,code:attacker,setcodes:direct?[0xA122]:[],type:direct?0x1000021:33,attack:500}],[victim,{...base,code:victim,defense:1300}],[secondVictim,{...base,code:secondVictim,defense:1700}],[trap,{...base,code:trap,type:4,level:0,attribute:0,race:0n,attack:0,defense:0}],[filler,{...base,code:filler}]]);
  const reader=name=>{if(name===`c${trap}.lua`)return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) c:RegisterEffect(e) end';if(name===`c${attacker}.lua`)return direct?'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_DIRECT_ATTACK) c:RegisterEffect(e) end':'local s,id=GetID() function s.initial_effect(c) end';if([`c${victim}.lua`,`c${secondVictim}.lua`,`c${filler}.lua`].includes(name))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8')};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{if(!cards.has(code))throw Error('Missing card '+code);return cards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,trapUsed=false,triggered=false,attacked=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
   const add=(code,location,player=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:(code===attacker||code===secondVictim)&&location===L.MZONE?1:0,position});
   add(trumpet,L.MZONE);add(attacker,L.MZONE);add(victim,L.MZONE,1);if(shared)add(secondVictim,L.MZONE,1);add(trap,L.SZONE,1,P.FACEDOWN);for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<160&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);
    if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));
    if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(p.type===M.SELECT_IDLECMD){const ownTurns=trace.filter(m=>m.type===M.NEW_TURN&&m.player===0).length;if(p.player===0&&ownTurns>=2&&p.to_bp)core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_BP});else core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});}
    else if(p.type===M.SELECT_BATTLECMD){if(!attacked){const index=p.attacks.findIndex(c=>c.code===attacker);if(index<0)throw Error('Attacker unavailable');attacked=true;core.duelSetResponse(duel,{type:R.SELECT_BATTLECMD,action:B.SELECT_BATTLE,index});}else if(shared){const recovered=trace.filter(m=>m.type===M.RECOVER&&m.player===0).reduce((n,m)=>n+m.amount,0),damage=trace.filter(m=>m.type===M.DAMAGE&&m.player===1).reduce((n,m)=>n+m.amount,0),zone=core.duelQueryLocation(duel,{flags:Q.CODE,controller:1,location:L.MZONE});if(!triggered||recovered!==1300||damage!==500||zone.some(c=>c?.code===victim)||!zone.some(c=>c?.code===secondVictim))throw Error(`Shared-count mismatch recover=${recovered} damage=${damage}`);done=true;}else core.duelSetResponse(duel,{type:R.SELECT_BATTLECMD,action:B.TO_EP});}
    else if(p.type===M.SELECT_CHAIN){const ti=(!direct||shared)&&p.player===1&&!trapUsed&&(!battle||attacked)?p.selects.findIndex(c=>c.code===trap):-1;const ci=p.player===0?p.selects.findIndex(c=>c.code===trumpet):-1;if(ti>=0){trapUsed=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:ti});}else if(ci>=0){if(shared&&triggered)throw Error('Second Trumpet trigger offered');triggered=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:ci});}else core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:null});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===victim);if(index<0)throw Error('Victim unavailable');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:direct});
    else if(p.type===M.SELECT_EFFECTYN){const yes=battle&&(trapUsed||direct)&&p.code===trumpet;if(yes){if(shared&&triggered)throw Error('Second Trumpet trigger offered');triggered=true;}core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
    if(!shared&&(trapUsed||direct&&triggered)&&trace.filter(m=>m.type===M.CHAIN_END).length>=(battle===true?2:1)){
     const recovered=trace.filter(m=>m.type===M.RECOVER&&m.player===0).reduce((n,m)=>n+m.amount,0);
     const zone=core.duelQueryLocation(duel,{flags:Q.CODE,controller:1,location:L.MZONE});
     if(battle){const directDamage=trace.filter(m=>m.type===M.DAMAGE&&m.player===1).reduce((n,m)=>n+m.amount,0);if(!triggered||recovered!==1300||zone.some(c=>c?.code===victim)||direct&&(directDamage!==500||trapUsed))throw Error(`Battle trigger mismatch triggered=${triggered} recover=${recovered} directDamage=${directDamage}`)}
     else if(triggered||recovered!==0||!zone.some(c=>c?.code===victim))throw Error(`Outside-BP mismatch triggered=${triggered} recover=${recovered}`);
     done=true;
    }
   }
   if(!done)throw Error('Step limit');
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  results.push({battle,status:failure?'FAIL':'PASS',failure,triggered,trace,logs});console.log(`${failure?'FAIL':'PASS'} battle=${battle}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/terrarumian-trumpet-battle-chain.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
