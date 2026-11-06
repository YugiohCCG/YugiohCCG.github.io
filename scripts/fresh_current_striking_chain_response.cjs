'use strict';
const fs=require('fs'),path=require('path'),assert=require('assert/strict');
const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport(),{OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),mode=process.argv[2]||'current',boss=250902476,actor=900011131,victim=900011132,protector=900011133,filler=900011134,results=[];
 for(const test of [{kind:'monster',extra:false},{kind:'monster',extra:true},{kind:'spell',extra:true},{kind:'own',extra:false},{kind:'protected',extra:true},{kind:'no-followup',extra:false}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:4,attribute:1,race:1n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[boss,require('./fresh_installed_card.cjs').candidateCard(boss)],[actor,{...base,code:actor,type:test.kind==='spell'?2:33}],[victim,{...base,code:victim}],[protector,{...base,code:protector}],[filler,{...base,code:filler,type:2}]]);
 const reader=n=>{
 if(n==='c0.lua')return '';
 if([victim,filler].some(c=>n===`c${c}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';
 if(n===`c${actor}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(${test.kind==='spell'?'EFFECT_TYPE_ACTIVATE':'EFFECT_TYPE_IGNITION'}) ${test.kind==='spell'?'e:SetCode(EVENT_FREE_CHAIN)':'e:SetRange(LOCATION_MZONE)'} e:SetCountLimit(1) e:SetOperation(function(e,tp) Duel.Hint(HINT_NUMBER,tp,731) end) c:RegisterEffect(e) end`;
 if(n===`c${protector}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_QUICK_O) e:SetCode(EVENT_CHAINING) e:SetRange(LOCATION_MZONE) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${boss}) end) e:SetOperation(function(e,tp) local tc=Duel.GetFirstMatchingCard(Card.IsCode,0,0,LOCATION_MZONE,nil,${actor}) assert(tc) local x=Effect.CreateEffect(e:GetHandler()) x:SetType(EFFECT_TYPE_SINGLE) x:SetCode(EFFECT_INDESTRUCTABLE_EFFECT) x:SetValue(1) x:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END) tc:RegisterEffect(x) end) c:RegisterEffect(e) end`;
 const p=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',n),path.join(ROOT,'tmp/omega_scripts',n)].find(fs.existsSync);assert(p,n);let s=fs.readFileSync(p,'utf8');if(n===`c${boss}.lua`){if(mode==='no-destroy')s=s.replace('Duel.Destroy(eg,REASON_EFFECT)>0','false');if(mode==='no-extra')s=s.replaceAll('Duel.Destroy(sg,REASON_EFFECT)','do end');if(mode==='own-allowed')s=s.replace('return rp~=tp','return true');if(mode==='independent-extra')s=s.replace('rc:IsRelateToEffect(re) and Duel.Destroy(eg,REASON_EFFECT)>0','(function() Duel.Destroy(eg,REASON_EFFECT) return true end)()');}return s;};
 const d=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});let failure=null,turn=0,started=false,activated=false,protectedOnce=false,optional=false,done=false;
 try{
 for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(d,n,reader(n));
 const add=(code,location,p=0,sequence=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(d,{team:p,duelist:0,code,controller:p,location,sequence,position});add(boss,L.SZONE,0,0,P.FACEDOWN_DEFENSE);add(actor,test.kind==='spell'?L.HAND:L.MZONE,test.kind==='own'?0:1);if(test.kind!=='no-followup')add(victim,L.MZONE,1,1);if(test.kind==='protected')add(protector,L.MZONE,0,1);for(const p of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,p);core.startDuel(d);
 const query=(loc,controller)=>core.duelQueryLocation(d,{flags:Q.CODE|Q.REASON,controller,location:loc}).filter(Boolean);
 for(let step=0;step<220&&!done;step++){
 const state=core.duelProcess(d),messages=core.duelGetMessage(d);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
 assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){if(!started){if(turn<(test.kind==='own'?1:2)){core.duelSetResponse(d,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}const index=p.activates.findIndex(c=>c.code===actor);assert(index>=0);started=true;core.duelSetResponse(d,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 assert.equal(activated,test.kind!=='own','Only opponent activation permits original trap');assert.equal(optional,!['own','protected','no-followup'].includes(test.kind),'Then follow-up requires successful destruction and an eligible monster');assert.equal(query(L.GRAVE,test.kind==='own'?0:1).some(c=>c.code===actor),!['own','protected'].includes(test.kind),'Original primary destruction result');assert.equal(query(L.GRAVE,1).some(c=>c.code===victim),test.extra&&test.kind!=='protected','Optional second destruction obeys choice and dependency');if(test.kind==='protected')assert(protectedOnce&&trace.some(m=>m.type===M.CHAINING&&m.code===protector&&m.chain_size===3),'Native late CL3 protection');assert(trace.some(m=>m.type===M.HINT&&String(m.hint)==='731'),'Original actor effect still resolves: destruction is not negation');done=true;
 }else if(p.type===M.SELECT_CHAIN){let index=p.selects.findIndex(c=>c.code===boss);if(index>=0)activated=true;else if(activated&&test.kind==='protected'&&!protectedOnce){index=p.selects.findIndex(c=>c.code===protector);if(index>=0)protectedOnce=true;}core.duelSetResponse(d,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
 else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);assert(sequence!==undefined);core.duelSetResponse(d,{type:R.SELECT_PLACE,places:[{player:p.player,location:L.SZONE,sequence}]});}
 else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===victim);assert(index>=0);core.duelSetResponse(d,{type:R.SELECT_CARD,indicies:[index]});}
 else if(p.type===M.SELECT_YESNO){optional=true;core.duelSetResponse(d,{type:R.SELECT_YESNO,yes:test.extra});}
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(d);}results.push({test,failure,logs,trace});console.log(JSON.stringify(test),failure||'PASS');
 }
 fs.writeFileSync(path.join(OUT,`current-striking-chain-response-${mode}.json`),JSON.stringify({mode,scope:'Original seeded set-trap response to actual monster/Spell activations and native late protection, optional second destruction and own-player exclusion. Neutral actors; no API mapping. GY activation legality, departure, negation and named activation count/live/full-card open.',results},(_,v)=>typeof v==='bigint'?String(v):v,2));
}
main().catch(e=>{console.error(e);process.exitCode=1});
