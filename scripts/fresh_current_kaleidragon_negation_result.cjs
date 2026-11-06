'use strict';
const fs=require('fs'),path=require('path'),assert=require('assert/strict');
const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport(),{OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),mode=process.argv[2]||'old',results=[],boss=217174535,actor=900011041,blocker=900011042,recipient=900011043,filler=900011044;
 for(const kind of ['success','already-negated','late-protection','source-departure']){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:4,attribute:1,race:1n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[boss,require('./fresh_installed_card.cjs').candidateCard(boss)],...[actor,blocker,recipient,filler].map(c=>[c,{...base,code:c}])]);
 const reader=n=>{
 if(n==='c0.lua')return '';
 if([recipient,filler].some(c=>n===`c${c}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';
 if(n===`c${actor}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCategory(CATEGORY_SPECIAL_SUMMON) e:SetCountLimit(1) e:SetTarget(function(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_DECK) end) e:SetOperation(function(e,tp) local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_DECK,0,nil,${recipient}) Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP_ATTACK) end) c:RegisterEffect(e) end`;
 if(n===`c${blocker}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_QUICK_O) e:SetCode(EVENT_CHAINING) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${boss}) end) e:SetOperation(function(e,tp) ${kind==='already-negated'?'assert(Duel.NegateEffect(1))':kind==='late-protection'?'local ex=Effect.CreateEffect(e:GetHandler()) ex:SetType(EFFECT_TYPE_FIELD) ex:SetCode(EFFECT_CANNOT_DISEFFECT) ex:SetValue(function(e,ct) return ct==1 end) ex:SetReset(RESET_CHAIN) Duel.RegisterEffect(ex,tp)':kind==='source-departure'?`local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_MZONE,0,nil,${actor}) assert(Duel.SendtoHand(tc,nil,REASON_EFFECT)>0)`:'do end'} end) c:RegisterEffect(e) end`;
 const p=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',n),path.join(ROOT,'tmp/omega_scripts',n)].find(fs.existsSync);assert(p,n);let s=fs.readFileSync(p,'utf8');if(n===`c${boss}.lua`){const old=path.join(OUT,'kaleidragon-negation-result-before-repair',n);if(fs.existsSync(old))s=fs.readFileSync(old,'utf8');if(mode!=='old')s=require('./fresh_kaleidragon_negation_result_repair.cjs').corrected(s);if(mode==='no-destroy')s=s.replace('Duel.Destroy(rc,REASON_EFFECT)','do end');if(mode==='no-relation')s=s.replace('if rc:IsRelateToEffect(re) then Duel.Destroy(rc,REASON_EFFECT) end','Duel.Destroy(rc,REASON_EFFECT)');if(mode==='no-negation')s=s.replace('if Duel.NegateEffect(ev) then','if false then');}return s;};
 const d=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});let failure=null,turn=0,activated=false,responded=false,done=false;
 try{
 for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(d,n,reader(n));
 const add=(code,location,player=0,sequence=0)=>core.duelNewCard(d,{team:player,duelist:0,code,controller:player,location,sequence,position:P.FACEUP_ATTACK});
 add(boss,L.MZONE);add(actor,L.MZONE,1);if(kind!=='success')add(blocker,L.MZONE,1,1);add(recipient,L.DECK,1);for(const p of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,p);core.startDuel(d);
 const query=loc=>core.duelQueryLocation(d,{flags:Q.CODE|Q.REASON,controller:1,location:loc}).filter(Boolean);
 for(let step=0;step<220&&!done;step++){
 const state=core.duelProcess(d),messages=core.duelGetMessage(d);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
 assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){if(turn<2){core.duelSetResponse(d,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}if(!activated){const index=p.activates.findIndex(c=>c.code===actor);assert(index>=0);activated=true;core.duelSetResponse(d,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}assert(trace.some(m=>m.type===M.CHAINING&&m.code===boss&&m.chain_size===2),'Original Kaleidragon CL2');if(kind!=='success')assert(responded&&trace.some(m=>m.type===M.CHAINING&&m.code===blocker&&m.chain_size===3),'Actual CL3 response');assert.equal(query(L.GRAVE).some(c=>c.code===actor),kind==='success','Destruction requires actual successful negation and source relation');assert.equal(query(L.MZONE).some(c=>c.code===recipient),kind==='late-protection','Original summon effect result');if(kind==='source-departure')assert(query(L.HAND).some(c=>c.code===actor),'Departed actor preserved in Hand');done=true;
 }else if(p.type===M.SELECT_CHAIN){let index=p.selects.findIndex(c=>c.code===boss);if(index<0&&kind!=='success'&&!responded){index=p.selects.findIndex(c=>c.code===blocker);if(index>=0)responded=true;}core.duelSetResponse(d,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
 else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);core.duelSetResponse(d,{type:R.SELECT_PLACE,places:[{player:p.player,location:L.MZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(d,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(d);}results.push({kind,failure,logs,trace});console.log(kind,failure||'PASS');
 }
 fs.writeFileSync(path.join(OUT,`current-kaleidragon-negation-result-${mode}.json`),JSON.stringify({mode,scope:'Original Kaleidragon negate/destroy effect with seeded source (original Fusion recipe not certified). Native CL1 summon actor and actual CL3 already-disabled/late-protection/source-departure responses; no return substitution or Lua API mapping. Named locks/other clauses/full-card/live remain open.',results},(_,v)=>typeof v==='bigint'?String(v):v,2));
}
main().catch(e=>{console.error(e);process.exitCode=1});
