'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=236744343,lab=900001210,filler=900001211,helper=900001212,helper2=process.argv.includes('--official')?Number(process.argv.find(a=>a.startsWith('--recipient='))?.split('=')[1]||15989522):900001213,helper3=900001214;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,SelectBattleCMDAction:B,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-attack-all','no-attack-reset','no-restore'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{three:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const search2=241868535;
 const cards=new Map([[boss,candidateCard(boss)],[search2,candidateCard(search2)],[lab,{...base,code:lab,type:test.wrongType?2:17,setcodes:test.wrongType?[0x39e2]:[]}],[helper2,{...base,code:helper2,attack:1000}],[helper3,{...base,code:helper3,type:0x20004,setcodes:[0x6167]}],[filler,{...base,code:filler,type:2}]]);
 const reader=name=>{if(name==='c0.lua')return '';if(name==='c'+helper2+'.lua')return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c'+lab+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) '+(control==='no-restore'?'do end':'local g=Duel.GetMatchingGroup(Card.IsCode,tp,0,LOCATION_GRAVE,nil,'+helper2+') assert(Duel.SpecialSummon(g,0,tp,1-tp,false,false,POS_FACEUP)==g:GetCount())')+' end) c:RegisterEffect(e) end';if([helper3,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){if(control==='no-boost')lua=lua.replace('e1:SetValue(atk*2)','e1:SetValue(atk)');if(control==='no-attack-all')lua=lua.replace('tc:RegisterEffect(e2)','do end');if(control==='no-attack-reset')lua=lua.replace('e2:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)','e2:SetReset(RESET_EVENT+RESETS_STANDARD)');}return lua;};

 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:test.lowLP?999:test.exactLP?1000:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let attackCount=0,restored=false,nextBattle=false,firstBattleAttacks=0;
 let failure=null,activated=false,done=false,second=false,third=false,turn=0,attached=false,offered=0;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 for(let i=0;i<(test.three?3:2);i++)add(helper2,L.MZONE,1,P.FACEUP_ATTACK,i);add(lab,L.MZONE,0,P.FACEUP_ATTACK,1);add(boss,L.SZONE,0,P.FACEUP_ATTACK,5);add(test.wrongSet?lab:search2,L.MZONE,test.opponent?1:0,test.facedown?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.ATTACK|Q.POSITION,controller,location}).filter(Boolean);
 for(let step=0;step<520&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 if(!activated&&turn<3){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP,index:0});continue;}
 if(!activated){const index=p.activates.findIndex(c=>c.code===boss);assert(index>=0);activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 if(!second){assert.equal(query(L.MZONE).find(c=>c.code===search2).attack,cards.get(search2).attack*2,'Actual doubled ATK before battle');second=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_BP,index:0});continue;}
 if(turn===3){const n=test.three?3:2;assert.equal(trace.filter(m=>m.type===M.ATTACK).length,n,'Actual attacks on every monster');assert.equal(query(L.GRAVE,1).filter(c=>c.code===helper2&&(c.reason&0x21)===0x21).length,n,'Every opponent destroyed by battle');assert(query(L.MZONE).some(c=>c.code===search2),'Papa survives');firstBattleAttacks=n;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP,index:0});continue;}
 if(turn===4){assert.equal(query(L.MZONE).find(c=>c.code===search2).attack,cards.get(search2).attack,'EndPhase ATK expiry');core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP,index:0});continue;}
 assert.equal(turn,5);
 if(!restored){const index=p.activates.findIndex(c=>c.code===lab);assert(index>=0);restored=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 if(!nextBattle){assert.equal(query(L.MZONE,1).filter(c=>c.code===helper2).length,test.three?3:2,'Actual fresh opponent targets');nextBattle=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_BP,index:0});continue;}
 assert.equal(trace.filter(m=>m.type===M.ATTACK).length-firstBattleAttacks,1,'Extra attack permission expires');assert.equal(query(L.MZONE,1).filter(c=>c.code===helper2).length,test.three?2:1,'Unattacked fresh targets remain');done=true;

 }

 else if(p.type===M.SELECT_BATTLECMD){const index=p.attacks.findIndex(c=>c.code===search2);if(query(L.MZONE,1).some(c=>c.code===helper2)&&index>=0){third=true;attackCount++;assert(attackCount<=6);core.duelSetResponse(duel,{type:R.SELECT_BATTLECMD,action:B.SELECT_BATTLE,index});}else core.duelSetResponse(duel,{type:R.SELECT_BATTLECMD,action:B.TO_M2,index:0});}
 else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:false});
 else if(p.type===M.SELECT_CARD){assert(p.selects.every(c=>c.code===(third?helper2:search2)),'Expected actual target');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[0]});}
 else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.both&&test.send?1:0});
 else if(p.type===M.SELECT_EFFECTYN){offered++;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});}
 else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
 else if(p.type===M.SELECT_PLACE){const opposite=(p.field_mask&0x7f)===0x7f;const shift=opposite?16:0;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);assert(sequence!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:opposite?1-p.player:p.player,location:L.MZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-estate-attack-reset'+(process.argv.includes('--official')?'-official-'+helper2:'')+(process.argv.includes('--spell-target-candidate')?'-spell-target-candidate':'')+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Estate attack-all permission expiry: full Papa defeats two/three neutral1000 opponents on turn3; neutral helper actually revives them on turn5, unboosted Papa attacks only once with remaining targets. No second Estate activation; optional triggers declined. No adapters; actual placement interaction/nativeOmega/fullcard OPEN',legacy_chaininfo_adapter:false,recipient:process.argv.includes('--official')?helper2:null,control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});


