'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=255977900,lab=900001210,filler=900001211,helper=900001212,helper2=process.argv.includes('--official')?Number(process.argv.find(a=>a.startsWith('--recipient='))?.split('=')[1]||15989522):900001213,helper3=900001214;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-counter','no-boundary','original-guard'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{disabled:true},{facedown:true},{sourceGY:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const search2=test.wrong?helper2:250262550;
 const cards=new Map([[boss,candidateCard(boss)],[250262550,candidateCard(250262550)],[lab,{...base,code:lab,type:test.wrongType?2:17,setcodes:test.zero?[0x39e2]:[],attack:test.zero?0:100}],[helper2,{...base,code:helper2}],[helper3,{...base,code:helper3,type:0x20004,setcodes:[0x6167]}],[filler,{...base,code:filler,type:2}]]);
 const reader=name=>{if(name==='c0.lua')return '';if(name==='c'+lab+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetOperation(function(e,tp) ${test.sourceGY&&control!=='no-boundary'?`assert(Duel.SendtoGrave(Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_SZONE,0,nil,${boss}),REASON_EFFECT)==1)`:''} local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,${search2}) assert(Duel.SpecialSummon(g,0,tp,tp,false,false,POS_FACEUP)==${test.group?2:1}) end) c:RegisterEffect(e) end`;if(name==='c'+helper3+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCondition(function(e,tp) local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_SZONE+LOCATION_GRAVE,0,nil,${boss}) return tc and tc:GetCounter(0x1c1)==${test.disabled||test.facedown||test.sourceGY?0:1} end) c:RegisterEffect(e) end`;if(name==='c'+helper2+'.lua')return `local s,id=GetID() function s.initial_effect(c) ${control==='no-boundary'?'do end':`local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_FIELD) e:SetCode(EFFECT_DISABLE) e:SetRange(LOCATION_MZONE) e:SetTargetRange(LOCATION_SZONE,0) e:SetTarget(function(e,tc) return tc:IsCode(${boss}) end) c:RegisterEffect(e)`} end`;if([lab,helper3,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){if(control==='original-guard')lua=lua.replace('if c:IsFaceup() then','if c:IsFaceup() and c:IsRelateToEffect(e) then');if(control==='no-counter')lua=lua.replace('c:AddCounter(COUNTER_HALLOWEEN,1)','do end');if(control==='allow-any')lua=lua.replace('s.hallo_ween_monster_codes[c:GetCode()]','true');}return lua;};

 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:test.lowLP?999:test.exactLP?1000:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0,attached=false,offered=0;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 if(test.disabled)add(helper2,L.MZONE,0,P.FACEUP_ATTACK,3);add(boss,L.SZONE,0,test.facedown&&control!=='no-boundary'?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK);add(lab,L.MZONE,test.opponent?1:0,P.FACEUP_ATTACK,1);add(helper3,L.MZONE,0,P.FACEUP_ATTACK,2);add(search2,L.HAND,test.opponent?1:0);if(test.group)add(search2,L.HAND);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.ATTACK|Q.POSITION,controller,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 if(test.opponent&&turn<2){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP,index:0});continue;}if(!activated){const pool=test.normal?p.summons:p.activates;const index=pool.findIndex(c=>c.code===(test.normal?search2:lab));assert(index>=0);activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:test.normal?A.SELECT_SUMMON:A.SELECT_ACTIVATE,index});continue;}
 if(test.opponent&&turn===2){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP,index:0});continue;}
 assert(p.activates.some(c=>c.code===helper3),'Native exact Halloween counter count');assert(trace.some(m=>m.type===(test.normal?M.SUMMONED:M.SPSUMMONED)),'Actual summon event');assert.equal(query(L.MZONE,test.opponent?1:0).filter(c=>c.code===search2).length,test.group?2:1,'Actual summoned cards');if(test.sourceGY&&control!=='no-boundary'){assert(query(L.GRAVE).some(c=>c.code===boss),'Source actually departed');const dep=trace.findIndex(m=>m.type===M.MOVE&&m.card===boss&&m.to.location===L.GRAVE),ss=trace.findIndex(m=>m.type===M.SPSUMMONED);assert(dep>=0&&ss>dep,'Departure precedes actual summon');}done=true;

 }

 else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:false});
 else if(p.type===M.SELECT_CARD){assert(p.selects.every(c=>c.code===search2&&c.controller===0&&c.position!==P.FACEDOWN_DEFENSE),'Only own eligible faceup target');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[0]});}
 else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.both&&test.send?1:0});
 else if(p.type===M.SELECT_EFFECTYN){offered++;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});}
 else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
 else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x7f)!==0x7f,shift=isMonster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-happy-halloween-counter-boundary-repaired'+(process.argv.includes('--official')?'-official-'+helper2:'')+(process.argv.includes('--spell-target-candidate')?'-spell-target-candidate':'')+(control?'-'+control:'')+'.json'),JSON.stringify({relation_guard_comparison:false,scope:'Production repaired counter boundaries: full Ween actual SpecialSummon accrues1 in reference; native disabled source/facedown source/actual sourceGY before summon accrues0. Exact GetCounter probe, no seeded counters. NativeOmega/fullcard OPEN',legacy_chaininfo_adapter:false,recipient:process.argv.includes('--official')?helper2:null,control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});


