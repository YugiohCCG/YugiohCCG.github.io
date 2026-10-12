'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=236744343,lab=900001210,filler=900001211,helper=900001212,helper2=process.argv.includes('--official')?Number(process.argv.find(a=>a.startsWith('--recipient='))?.split('=')[1]||15989522):900001213,helper3=900001214;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,SelectBattleCMDAction:B,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-banish','allow-wrong','no-attack'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{victim:true},{warden:true},{wrongSet:true},{decline:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const search2=test.wrongSet?lab:test.warden?243144691:241868535;
 const cards=new Map([[boss,candidateCard(boss)],[241868535,candidateCard(241868535)],[243144691,candidateCard(243144691)],[lab,{...base,code:lab,attack:2000,type:test.wrongType?2:17,setcodes:test.wrongType?[0x39e2]:[]}],[helper2,{...base,code:helper2,attack:1000}],[helper3,{...base,code:helper3,type:0x20004,setcodes:[0x6167]}],[filler,{...base,code:filler,type:2}]]);
 const reader=name=>{if(name==='c0.lua')return '';if(name==='c'+helper2+'.lua')return 'local s,id=GetID() function s.initial_effect(c) end';if([lab,helper3,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){if(control==='no-banish')lua=lua.replace('Duel.Remove(tc,POS_FACEUP,REASON_EFFECT)','do end');if(control==='allow-wrong')lua=lua.replace('rc:IsSetCard(SET_VIR_PEDICAE_MORTIS)','true');}return lua;};

 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:test.lowLP?999:test.exactLP?1000:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let attackCount=0;
 let failure=null,activated=false,done=false,second=false,third=false,turn=0,attached=false,offered=0;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 add(helper2,L.MZONE,1,P.FACEUP_ATTACK);add(boss,L.SZONE,0,P.FACEUP_ATTACK,5);add(search2,L.MZONE,0,P.FACEUP_ATTACK);if(!test.victim)add(helper3,L.GRAVE,1);add(filler,L.GRAVE,0);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.ATTACK|Q.POSITION,controller,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 if(turn<3){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP,index:0});continue;}
 if(!second){second=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_BP,index:0});continue;}
 assert.equal(turn,3);assert.equal(trace.filter(m=>m.type===M.ATTACK).length,1,'Actual battle attack');assert(trace.some(m=>m.type===M.MOVE&&m.card===helper2&&m.to.location===L.GRAVE),'Native battle destruction before trigger');
 if(!test.victim){const victim=query(L.GRAVE,1).find(c=>c.code===helper2);assert(victim&&(victim.reason&0x21)===0x21,'Native battle destruction reason');}const expected=!(test.wrongSet||test.decline),target=test.victim?helper2:helper3;assert.equal(query(L.REMOVED,1).some(c=>c.code===target),expected,'Expected opponent GY banish');assert.equal(trace.filter(m=>m.type===M.CHAINING&&m.code===boss).length,expected?1:0,'Actual Estate trigger');assert(query(L.GRAVE).some(c=>c.code===filler),'Own GY untouched');if(expected){const tc=query(L.REMOVED,1).find(c=>c.code===target);assert((tc.reason&0x40)!==0&&(tc.position&0x5)!==0,'Faceup effect banish');}done=true;

 }

 else if(p.type===M.SELECT_BATTLECMD){const index=p.attacks.findIndex(c=>c.code===search2);if(!third&&control!=='no-attack'&&query(L.MZONE,1).some(c=>c.code===helper2)&&index>=0){third=true;attackCount++;assert(attackCount<=3);core.duelSetResponse(duel,{type:R.SELECT_BATTLECMD,action:B.SELECT_BATTLE,index});}else core.duelSetResponse(duel,{type:R.SELECT_BATTLECMD,action:B.TO_M2,index:0});}
 else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:p.code===boss&&!test.decline});
 else if(p.type===M.SELECT_CARD){const target=query(L.MZONE,1).some(c=>c.code===helper2)?helper2:test.victim?helper2:helper3;const index=p.selects.findIndex(c=>c.code===target&&c.controller===1);assert(index>=0,'Opponent battle or GY target');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
 else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.both&&test.send?1:0});
 else if(p.type===M.SELECT_EFFECTYN){offered++;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:p.code===boss&&!test.decline});}
 else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:(!test.decline&&p.selects.some(c=>c.code===boss)?p.selects.findIndex(c=>c.code===boss):null)});
 else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x7f)!==0x7f,shift=isMonster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-estate-battle-banish'+(process.argv.includes('--official')?'-official-'+helper2:'')+(process.argv.includes('--spell-target-candidate')?'-spell-target-candidate':'')+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Estate actual battle destruction trigger with full Papa/Warden; opponent existing GY Spell or newly battle-destroyed monster banished faceup by effect. Own GY untouched, wrong archetype and decline excluded. No adapters; limits/interruption/negation/nativeOmega/fullcard OPEN',legacy_chaininfo_adapter:false,recipient:process.argv.includes('--official')?helper2:null,control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});


