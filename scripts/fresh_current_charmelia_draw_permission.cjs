'use strict';
const fs=require('fs'),path=require('path'),assert=require('assert/strict');
const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport(),{OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),mode=process.argv[2]||'old',boss=259226799,actor=900011061,ritual=900011062,responder=900011063,filler=900011064,protector=24221739,results=[];
 for(const kind of ['normal','pre-lock','zero-lock','late-lock','ritual-departure','source-departure']){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:4,attribute:1,race:1n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[boss,require('./fresh_installed_card.cjs').candidateCard(boss)],[actor,{...base,code:actor,setcodes:[0x12b1]}],[ritual,{...base,code:ritual,type:161,setcodes:[0x12b1]}],[responder,{...base,code:responder}],[filler,{...base,code:filler,type:2}],[protector,{...base,code:protector,attribute:1,race:8n,attack:1100,defense:1900}]]);
 const reader=n=>{
 if(n==='c0.lua')return '';
 if([ritual,filler].some(c=>n===`c${c}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';
 if(n===`c${actor}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetOperation(function(e,tp) local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_HAND,0,nil,${boss}) assert(Duel.SendtoGrave(tc,REASON_EFFECT)>0) end) c:RegisterEffect(e) end`;
 if(n===`c${responder}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_QUICK_O) e:SetCode(EVENT_CHAINING) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${boss}) end) e:SetOperation(function(e,tp) ${kind==='late-lock'?`local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_HAND,0,nil,${protector}) assert(Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP_ATTACK)>0)`:kind==='ritual-departure'?`local tc=Duel.GetFirstMatchingCard(Card.IsCode,0,LOCATION_MZONE,0,nil,${ritual}) assert(Duel.SendtoGrave(tc,REASON_EFFECT)>0)`:`local tc=Duel.GetFirstMatchingCard(Card.IsCode,0,LOCATION_GRAVE,0,nil,${boss}) assert(Duel.Remove(tc,POS_FACEUP,REASON_EFFECT)>0)`} end) c:RegisterEffect(e) end`;
 const p=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',n),path.join(ROOT,'tmp/omega_scripts',n)].find(fs.existsSync);assert(p,n);let s=fs.readFileSync(p,'utf8');if(n===`c${boss}.lua`){const old=path.join(OUT,'charmelia-draw-permission-before-repair',n);if(fs.existsSync(old))s=fs.readFileSync(old,'utf8');if(mode!=='old')s=require('./fresh_charmelia_draw_permission_repair.cjs').corrected(s);if(mode==='no-zero-exception')s=s.replace('(ct==0 or Duel.IsPlayerCanDraw(tp,ct))','(ct>0 and Duel.IsPlayerCanDraw(tp,ct))');if(mode==='no-recovery')s=s.replace('Duel.SendtoHand(c,nil,REASON_EFFECT)','0');if(mode==='no-draw')s=s.replace('Duel.Draw(tp,ct,REASON_EFFECT)','do end');}return s;};
 const d=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});let failure=null,sent=false,used=false,responded=false,done=false;
 try{
 for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(d,n,reader(n));
 const add=(code,location,player=0,sequence=0)=>core.duelNewCard(d,{team:player,duelist:0,code,controller:player,location,sequence,position:P.FACEUP_ATTACK});
 add(boss,L.HAND);add(actor,L.MZONE);if(kind!=='zero-lock')add(ritual,L.MZONE,0,1);if(['pre-lock','zero-lock'].includes(kind))add(protector,L.MZONE,1);if(['late-lock','ritual-departure','source-departure'].includes(kind))add(responder,L.MZONE,1,1);if(kind==='late-lock')add(protector,L.HAND,1);for(const p of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,p);core.startDuel(d);
 const query=loc=>core.duelQueryLocation(d,{flags:Q.CODE|Q.REASON,controller:0,location:loc}).filter(Boolean);
 for(let step=0;step<180&&!done;step++){
 const state=core.duelProcess(d),messages=core.duelGetMessage(d);trace.push(...messages);assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){if(!sent){sent=true;const index=p.activates.findIndex(c=>c.code===actor);assert(index>=0);core.duelSetResponse(d,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 assert.equal(used,kind!=='pre-lock','Recovery cannot activate when its known mandatory draw is prohibited');assert.equal(query(L.HAND).some(c=>c.code===boss),!['pre-lock','source-departure'].includes(kind),'Actual GY recovery result');assert.equal(query(L.HAND).filter(c=>c.code===filler).length,kind==='normal'?1:0,'Actual draw result at resolution');if(['late-lock','ritual-departure','source-departure'].includes(kind))assert(responded&&trace.some(m=>m.type===M.CHAINING&&m.code===responder&&m.chain_size===2),'Actual CL2 change');done=true;
 }else if(p.type===M.SELECT_CHAIN){let index=p.selects.findIndex(c=>c.code===boss);if(index>=0){assert.notEqual(kind,'pre-lock','Known forbidden draw must suppress offer');used=true;}else if(!responded){index=p.selects.findIndex(c=>c.code===responder);if(index>=0)responded=true;}core.duelSetResponse(d,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
 else if(p.type===M.SELECT_EFFECTYN){assert.notEqual(kind,'pre-lock','Known forbidden draw must suppress offer');used=true;core.duelSetResponse(d,{type:R.SELECT_EFFECTYN,yes:true});}
 else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);assert(sequence!==undefined);core.duelSetResponse(d,{type:R.SELECT_PLACE,places:[{player:p.player,location:L.MZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(d,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(d);}results.push({kind,failure,used,responded,logs,trace});console.log(kind,failure||'PASS');
 }
 fs.writeFileSync(path.join(OUT,`current-charmelia-draw-permission-${mode}.json`),JSON.stringify({mode,scope:'Original Beast recovery and full stock Protector of the Sanctuary script with official EARTH/Fiend/Level4/1100/1900 metadata. Native Charmelia send-to-GY actor, typed Ritual and CL2 actual Protector summon/Ritual departure/source banishment. No Lua API mapping or forced permission returns; original Ritual history, named limits/full-card/live open.',results},(_,v)=>typeof v==='bigint'?String(v):v,2));
}
main().catch(e=>{console.error(e);process.exitCode=1});
