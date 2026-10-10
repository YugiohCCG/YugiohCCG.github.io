'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=215984744,lab=900001210,filler=900001211,helper=900001212,helper2=process.argv.includes('--official')?Number(process.argv.find(a=>a.startsWith('--recipient='))?.split('=')[1]||15989522):900001213,helper3=900001214;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-protection','no-disable','no-removal'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{sendGY:true},{returnHand:true},{banish:true},{disableServant:true},{disablePapa:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const target=test.neutralRec||test.wrong?lab:231872299,papa=241868535;
 const cards=new Map([[boss,candidateCard(boss)],[papa,candidateCard(papa)],[231872299,candidateCard(231872299)],[lab,{...base,code:lab,type:0x20002,setcodes:test.wrong?[]:[0x6167]}],[helper2,{...base,code:helper2}],[filler,{...base,code:filler,type:2}]]);
 const reader=name=>{if(name==='c0.lua')return '';if(name==='c'+helper2+'.lua')return 'local s,id=GetID() function s.initial_effect(c) '+((test.disableServant||test.disablePapa)&&control!=='no-disable'?'local d=Effect.CreateEffect(c) d:SetType(EFFECT_TYPE_FIELD) d:SetCode(EFFECT_DISABLE) d:SetRange(LOCATION_MZONE) d:SetTargetRange(0,LOCATION_MZONE) d:SetTarget(function(e,tc) return tc:IsCode('+(test.disableServant?boss:papa)+') end) c:RegisterEffect(d) local d2=d:Clone() d2:SetCode(EFFECT_DISABLE_EFFECT) c:RegisterEffect(d2) ':'')+'local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetOperation(function(e,tp) '+(test.disableServant||test.disablePapa?'local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_MZONE,nil,'+(test.disableServant?boss:papa)+') assert(tc:IsDisabled(),"Actual native disable state") ':'')+'local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_SZONE,LOCATION_SZONE,nil,'+target+') '+(control==='no-removal'&&(test.sendGY||test.returnHand||test.banish)?'do end':test.sendGY?'Duel.SendtoGrave(g,REASON_EFFECT)':test.returnHand?'Duel.SendtoHand(g,nil,REASON_EFFECT)':test.banish?'Duel.Remove(g,POS_FACEUP,REASON_EFFECT)':'Duel.Destroy(g,REASON_EFFECT)')+' end) c:RegisterEffect(e) end';if([lab,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){if(control==='no-protection')lua=lua.replace('c:RegisterEffect(e3)','do end');if(control==='no-papa-gate')lua=lua.replace('e3:SetCondition(s.indcon)','do end');if(control==='allow-own')lua=lua.replace('return rp==1-e:GetHandlerPlayer()','return true');}return lua;};

 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0,attached=false,offered=0;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 add(boss,L.MZONE,0,P.FACEUP_ATTACK);if(!test.noPapa)add(papa,test.papaGY?L.GRAVE:L.MZONE,test.opponentPapa?1:0,test.papaDown?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK,1);add(target,L.SZONE,test.opponentTarget?1:0,P.FACEUP_ATTACK,target===231872299?5:0);add(helper2,L.MZONE,test.ownEffect?0:1,P.FACEUP_ATTACK,2);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.ATTACK|Q.POSITION,controller,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 if(!activated){if(turn===1&&!test.ownEffect){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP,index:0});continue;}const index=p.activates.findIndex(c=>c.code===helper2);assert(index>=0);activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 const protectedTarget=!(test.sendGY||test.returnHand||test.banish||test.disableServant);const destination=test.returnHand?L.HAND:test.banish?L.REMOVED:L.GRAVE;assert(trace.some(m=>m.type===M.CHAINING&&m.code===helper2),'Actual opposing removal effect activated');assert.equal(query(L.SZONE).some(c=>c.code===target),protectedTarget,'Only effect destruction protected, disabled source loses protection');assert.equal(query(destination).some(c=>c.code===target),!protectedTarget,'Actual expected removal destination');if(!protectedTarget){const card=query(destination).find(c=>c.code===target);assert((card.reason&0x40)!==0,'Native effect reason');assert.equal((card.reason&1)!==0,!!test.disableServant,'Native destruction reason only on destruction route');}done=true;

 }

 else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});
 else if(p.type===M.SELECT_CARD){const priority=[test.send?helper3:filler,lab,search2];const index=priority.map(code=>p.selects.findIndex(c=>c.code===code)).find(i=>i>=0);assert(index!==undefined,'Expected cost/search card');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
 else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.both&&test.send?1:0});
 else if(p.type===M.SELECT_EFFECTYN){offered++;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:!test.decline});}
 else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
 else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x7f)!==0x7f,shift=isMonster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-happy-servant-protection-boundary'+(process.argv.includes('--official')?'-official-'+helper2:'')+(process.argv.includes('--spell-target-candidate')?'-spell-target-candidate':'')+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'HappyServant full Papa/Mine interaction: actual opposing non-destruction GY/Hand/banish removal bypasses protection; native field disable on Servant ends protection, disabled Papa still satisfies faceup named-card condition. No adapters; nativeOmega/fullcard OPEN',legacy_chaininfo_adapter:false,recipient:process.argv.includes('--official')?helper2:null,control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});


