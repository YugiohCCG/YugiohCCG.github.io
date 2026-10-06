'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=211964444,lab=900001210,filler=900001211,helper=900001212,helper2=900001213,helper3=900001214;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['old-query','wrong-handler','no-destroy','no-relation','any-event'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{wrongSet:true},{spell:true},{absent:true},{official:true},{official:true,noSpace:true},{otherEffect:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const target=test.official?52904476:lab;
 const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:test.spell?2:33,setcodes:test.wrongSet?[]:[0x11f]}],[filler,{...base,code:filler,type:2}],[helper,{...base,code:helper,type:2}],[helper2,{...base,code:helper2,type:2}],[helper3,{...base,code:helper3,type:2}]]);
 cards.set(52904476,{...base,code:52904476,type:33,setcodes:[0x11f]});cards.set(helper2,{...base,code:helper2,type:33});
 const reader=name=>{
 if([helper,helper2,helper3].some(c=>name==='c'+c+'.lua'))return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) ${test.full?'e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_GRAVE)':'e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN)'} e:SetOperation(function(e,tp) local c=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,${boss}):GetFirst() Duel.SpecialSummon(c,0,tp,tp,true,true,POS_FACEUP) c:CompleteProcedure() end) c:RegisterEffect(e) end`;
 if(name==='c'+lab+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) ${test.otherEffect?'e:SetType(EFFECT_TYPE_IGNITION) e:SetCode(EVENT_FREE_CHAIN)':'e:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O) e:SetCode(EVENT_PHASE+PHASE_STANDBY)'} e:SetRange(LOCATION_GRAVE) e:SetCondition(function() return Duel.GetCurrentPhase()==PHASE_STANDBY end) e:SetTarget(function(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end Duel.Hint(HINT_NUMBER,tp,6401) end) e:SetOperation(function(e,tp) Duel.Hint(HINT_NUMBER,tp,e:GetHandler():GetCode()) end) c:RegisterEffect(e) end`;
 if([lab,filler,helper2].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
 const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,'Missing '+name);let lua=fs.readFileSync(file,'utf8');
 if(name==='c'+boss+'.lua'){
 if(control==='old-query')lua=lua.replace('tc:GetCardEffect()','tc:CheckActivateEffect(true,true,true)');
 if(control==='wrong-handler')lua=lua.replaceAll('tg(te,tp,eg,ep,ev,re,r,rp','tg(e,tp,eg,ep,ev,re,r,rp').replace('op(te,tp,eg,ep,ev,re,r,rp)','op(e,tp,eg,ep,ev,re,r,rp)');
 if(control==='no-relation')lua=lua.replace('tc:CreateEffectRelation(te)','do end');
 if(control==='any-event')lua=lua.replace('te:GetCode()==EVENT_PHASE+PHASE_STANDBY','true');
 if(control==='no-destroy')lua=lua.replace('Duel.Destroy(tc,REASON_EFFECT,LOCATION_GRAVE)==0','false');
 }return lua;
 };
 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 add(boss,L.HAND);add(helper,L.HAND);if(!test.absent)add(target,L.DECK);if(test.noSpace)for(let i=0;i<4;i++)add(helper2,L.MZONE,0,P.FACEUP_ATTACK,i);
 for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,controller:0,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 if(!activated){const index=p.activates.findIndex(c=>c.code===helper);assert(index>=0,'Summon helper available');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 const eligible=!test.absent&&!test.spell&&!test.wrongSet;
 assert(query(L.MZONE).some(c=>c.code===boss),'Source actually Special Summoned');assert.equal(trace.some(m=>m.type===M.CHAINING&&m.code===boss),eligible,'Printed Special Summon trigger');
 if(eligible){assert(trace.some(m=>m.type===M.MOVE&&m.card===target&&m.to.location===L.GRAVE),'Revealed Deck monster actually destroyed to GY');if(test.official){assert.equal(query(L.MZONE).some(c=>c.code===target),!test.noSpace,'Actual official Standby self-summon with its own handler/zone gate');if(test.noSpace)assert(query(L.GRAVE).some(c=>c.code===target),'Unusable Standby target remains in GY');}else{const destroyed=query(L.GRAVE).find(c=>c.code===target);assert(destroyed&&(destroyed.reason&1)&&(destroyed.reason&0x40),'Revealed Deck monster actually destroyed by effect');assert.equal(trace.some(m=>m.type===M.HINT&&String(m.hint)==='6401'),!test.otherEffect,'Only Standby target callback applied');assert.equal(trace.some(m=>m.type===M.HINT&&String(m.hint)===String(lab)),!test.otherEffect,'Only Standby operation applies with destroyed-card handler');}}done=true;
 }
 else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===target);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
 else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});
 else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===boss);core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
 else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x7f)!==0x7f,shift=isMonster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/priestess-nephthys-standby'+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Actual full Priestess summon trigger and Deck destruction, neutral monster with real registered Standby Phase target/operation. Experimental phase-query controls are test-only, no production adaptation or native Omega certification',control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
