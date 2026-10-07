'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=211699737,lab=900001210,filler=900001211,helper=900001212,helper2=900001213,helper3=900001214;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['raw-omega','no-set','no-count','any-summon','allow-facedown'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{trap:true},{grave:true},{removed:true},{removed:true,trap:true},{removed:true,facedown:true},{wrongSet:true},{monster:true},{absent:true},{full:true},{nonFusion:true},{count:true},{count:true,renewal:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:test.monster?17:test.trap?4:2,setcodes:test.wrongSet?[]:[0x157]}],[filler,{...base,code:filler,type:2}],[helper,{...base,code:helper,type:2}],[helper2,{...base,code:helper2,type:2}],[helper3,{...base,code:helper3,type:2}]]);
 const reader=name=>{
 if([helper,helper2,helper3].some(c=>name==='c'+c+'.lua'))return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) ${test.full?'e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_GRAVE)':'e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN)'} e:SetOperation(function(e,tp) local c=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_EXTRA,0,nil,${boss}):GetFirst() Duel.SpecialSummon(c,${test.nonFusion?'0':'SUMMON_TYPE_FUSION'},tp,tp,true,true,POS_FACEUP) c:CompleteProcedure() end) c:RegisterEffect(e) end`;
 if([lab,filler].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
 const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,'Missing '+name);let lua=fs.readFileSync(file,'utf8');
 if(name==='c'+boss+'.lua'){
 if(control!=='raw-omega')lua=lua.replace('c:IsFaceupEx()','(not c:IsLocation(LOCATION_REMOVED) or c:IsFaceup())');
 if(control==='no-set')lua=lua.replace('Duel.SSet(tp,tc)','do end');
 if(control==='no-count')lua=lua.replace('e1:SetCountLimit(1,id)','do end');
 if(control==='any-summon')lua=lua.replace('e:GetHandler():IsSummonType(SUMMON_TYPE_FUSION)','true');
 if(control==='allow-facedown')lua=lua.replace('(not c:IsLocation(LOCATION_REMOVED) or c:IsFaceup())','true');
 }return lua;
 };
 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 add(boss,L.EXTRA);add(helper,test.full?L.GRAVE:L.HAND);
 if(!test.absent)add(lab,test.removed?L.REMOVED:test.grave?L.GRAVE:L.DECK,0,test.facedown?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK);
 if(test.count){add(boss,L.EXTRA);add(helper2,L.HAND);add(lab,L.DECK);}if(test.renewal){add(boss,L.EXTRA);add(helper3,L.HAND);}
 if(test.full)for(let i=0;i<5;i++)add(filler,L.SZONE,0,P.FACEDOWN_DEFENSE,i);
 for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:0,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 if(!activated){const index=p.activates.findIndex(c=>c.code===helper);assert(index>=0,'Summon helper available');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 const eligible=!test.absent&&!test.monster&&!test.wrongSet&&!test.facedown&&!test.full&&!test.nonFusion;
 assert(query(L.MZONE).some(c=>c.code===boss),'Source actually Special Summoned');assert.equal(trace.filter(m=>m.type===M.CHAINING&&m.code===boss).length,eligible?(third?2:1):0,'Printed Fusion trigger and shared limit');
 assert.equal(query(L.SZONE).filter(c=>c.code===lab).length,eligible?(third?2:1):0,'Actual card Set');
 if(eligible){const movement=trace.find(m=>m.type===M.MOVE&&m.card===lab&&m.to.location===L.SZONE);assert(movement,'Set movement');assert.equal(movement.from.location,test.removed?L.REMOVED:test.grave?L.GRAVE:L.DECK,'Printed source location');assert(movement.to.position&P.FACEDOWN,'Actual face-down Set');}
 if(test.count&&!second){const index=p.activates.findIndex(c=>c.code===helper2);assert(index>=0,'Second summon helper');second=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 if(test.count){assert.equal(query(L.MZONE).filter(c=>c.code===boss).length,third?3:2,'Actual summoned copies');assert.equal(query(L.DECK).some(c=>c.code===lab),!third,'Legal target retention/renewal Set');}if(test.renewal&&!third){if(turn<3){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}const index=p.activates.findIndex(c=>c.code===helper3);assert(index>=0,'Next own turn summon helper');third=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}done=true;
 }
 else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===lab);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
 else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});
 else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===boss);core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
 else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x7f)!==0x7f,shift=isMonster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/myutant-amalgamate-set'+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Actual production summon trigger and SSet in public OCGCore, candidate metadata; neutral summon helper uses SUMMON_TYPE_FUSION and ignore checks, not material procedure certification. Explicit in-memory IsFaceupEx translation unless raw-omega. No native Omega/full card certification.',control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
