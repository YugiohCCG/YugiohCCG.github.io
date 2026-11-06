'use strict';
const fs=require('fs'),path=require('path'),assert=require('assert/strict');
const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport();
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,SelectBattleCMDAction:B,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[],mode=process.argv[2]||'old';
 for(const branch of process.argv.includes('--main1-diagnostic')?['hand']:['hand-battle','grave'])for(const kind of ['stable','leave-return','facedown','facedown-up']){
 const boss=236898203,actor=900011011,resource=900011012,filler=900011013,logs=[],trace=[];
 const base={alias:0,setcodes:[],type:33,level:4,attribute:1,race:1n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[boss,require('./fresh_installed_card.cjs').candidateCard(boss)],[actor,{...base,code:actor}],[resource,{...base,code:resource,race:65536n}],[filler,{...base,code:filler,type:2}]]);
 const reader=n=>{
 if(n==='c0.lua')return '';
 if([resource,filler].some(c=>n===`c${c}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';
 if(n===`c${actor}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_QUICK_O) e:SetCode(EVENT_FREE_CHAIN) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetCondition(function(e,tp) return Duel.IsExistingMatchingCard(Card.IsCode,tp,LOCATION_MZONE,0,1,nil,${boss}) end) e:SetOperation(function(e,tp) local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_MZONE,0,nil,${boss}) ${kind==='leave-return'?'assert(Duel.SendtoHand(tc,nil,REASON_EFFECT)>0) Duel.BreakEffect() assert(Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP_ATTACK)>0)':kind==='facedown'||kind==='facedown-up'?`assert(Duel.ChangePosition(tc,POS_FACEDOWN_DEFENSE)>0) ${kind==='facedown-up'?'assert(Duel.ChangePosition(tc,POS_FACEUP_ATTACK)>0)':''}`:''} end) c:RegisterEffect(e) end`;
 const p=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',n),path.join(ROOT,'tmp/omega_scripts',n)].find(fs.existsSync);assert(p,n);let s=fs.readFileSync(p,'utf8');
 if(n===`c${boss}.lua`){const old=path.join(OUT,'rex-delayed-destruction-before-repair',n);if(fs.existsSync(old))s=fs.readFileSync(old,'utf8');if(mode!=='old'){s=require('./fresh_rex_delayed_destruction_repair.cjs').corrected(s);if(mode==='no-tracking')s=s.replace(' and tc:GetFieldID()==e:GetLabel()\n\t\tand tc:GetFlagEffect(id+200)>0','');if(mode==='no-destroy')s=s.replace('Duel.Destroy(tc,REASON_EFFECT)','do end');}}
 return s;};
 const d=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,turn=0,phase=0,activated=false,attacked=false,changed=false,done=false;
 try{
 for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(d,n,reader(n));
 const add=(code,location,player=0,sequence=0)=>core.duelNewCard(d,{team:player,duelist:0,code,controller:player,location,sequence,position:P.FACEUP_ATTACK});
 add(boss,branch.startsWith('hand')?L.HAND:L.GRAVE);add(actor,L.MZONE);add(resource,L.MZONE,0,1);for(const p of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,p);core.startDuel(d);
 const query=loc=>core.duelQueryLocation(d,{flags:Q.CODE|Q.POSITION|Q.REASON,controller:0,location:loc}).filter(Boolean);
 const check=()=>{assert(trace.some(m=>m.type===M.CHAINING&&m.code===boss),'Original Rex effect activation');assert(trace.some(m=>m.type===M.SPSUMMONED),'Actual native Special Summon');if(branch.startsWith('hand'))assert(query(L.GRAVE).some(c=>c.code===resource),'Original dinosaur actually destroyed');assert.equal(query(L.MZONE).some(c=>c.code===boss),kind!=='stable','Delayed destruction follows only the original face-up field instance');assert.equal(query(L.GRAVE).some(c=>c.code===boss),kind==='stable','Stable Rex actually destroyed at phase end');if(kind!=='stable')assert(changed,'Actual native movement/position operation');done=true;};
 for(let step=0;step<300&&!done;step++){
 const state=core.duelProcess(d),messages=core.duelGetMessage(d);trace.push(...messages);for(const m of messages){if(m.type===M.NEW_TURN)turn++;if(m.type===M.NEW_PHASE)phase=m.phase;}
 assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 if(turn<3){core.duelSetResponse(d,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
 if(branch!=='hand'&&phase===256){check();continue;}
 if(branch==='hand'&&!activated){const index=p.activates.findIndex(x=>x.code===boss);assert(index>=0,'Original Hand summon offered');activated=true;core.duelSetResponse(d,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 if(branch==='hand'&&kind!=='stable'&&!changed){assert(query(L.MZONE).some(c=>c.code===boss));const index=p.activates.findIndex(x=>x.code===actor);assert(index>=0);changed=true;core.duelSetResponse(d,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 core.duelSetResponse(d,{type:R.SELECT_IDLECMD,action:A.TO_BP});
 }else if(p.type===M.SELECT_BATTLECMD){
 if(branch==='hand'){check();continue;}
 if(branch==='hand-battle'&&!activated){const index=p.chains.findIndex(x=>x.code===boss);assert(index>=0,'Original Hand summon during Battle Phase');activated=true;attacked=true;core.duelSetResponse(d,{type:R.SELECT_BATTLECMD,action:B.SELECT_CHAIN,index});continue;}
 if(!attacked){const index=p.attacks.findIndex(x=>x.code===actor);assert(index>=0);attacked=true;core.duelSetResponse(d,{type:R.SELECT_BATTLECMD,action:B.SELECT_BATTLE,index});continue;}
 if(kind!=='stable'&&!changed){assert(query(L.MZONE).some(c=>c.code===boss));const index=p.chains.findIndex(x=>x.code===actor);assert(index>=0);changed=true;core.duelSetResponse(d,{type:R.SELECT_BATTLECMD,action:B.SELECT_CHAIN,index});continue;}
 core.duelSetResponse(d,{type:R.SELECT_BATTLECMD,action:B.TO_M2});
 }else if(p.type===M.SELECT_CHAIN){const index=branch==='grave'&&attacked&&!activated?p.selects.findIndex(c=>c.code===boss):-1;if(index>=0)activated=true;core.duelSetResponse(d,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
 else if(p.type===M.SELECT_EFFECTYN){activated=true;core.duelSetResponse(d,{type:R.SELECT_EFFECTYN,yes:true});}
 else if(p.type===M.SELECT_YESNO)core.duelSetResponse(d,{type:R.SELECT_YESNO,yes:true});
 else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(x=>x.code===resource);assert(index>=0);core.duelSetResponse(d,{type:R.SELECT_CARD,indicies:[index]});}
 else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);assert(sequence!==undefined);core.duelSetResponse(d,{type:R.SELECT_PLACE,places:[{player:0,location:L.MZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(d,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(d);}
 results.push({branch,kind,failure,logs,trace});console.log(branch,kind,failure||'PASS');
 }
 fs.writeFileSync(path.join(OUT,`current-rex-delayed-destruction-${mode}${process.argv.includes('--main1-diagnostic')?'-main1-diagnostic':''}.json`),JSON.stringify({mode,scope:'Original Rex Hand destruction/summon and GY attack-trigger summon, current installed metadata. Native phase progression, source destruction and movement/position changes by neutral actor; no Lua API mapping. Remaining clauses/full-card/live Omega open.',results},(_,v)=>typeof v==='bigint'?String(v):v,2));
}
main().catch(e=>{console.error(e);process.exitCode=1});
