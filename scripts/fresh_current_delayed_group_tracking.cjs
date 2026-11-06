'use strict';
const fs=require('fs'),path=require('path'),assert=require('assert/strict');
const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport();
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),mode=process.argv[2]||'old',results=[];
 for(const boss of [259911246,259303191])for(const kind of boss===259911246?['stable','leave-return','flip-set','unaffected']:['stable','rebanish-hand','rebanish-grave']){
 const mylo=boss===259911246,actor=900011021,target=900011022,stable=900011023,filler=900011024,logs=[],trace=[];
 const base={alias:0,setcodes:[],type:33,level:4,attribute:1,race:1n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[boss,require('./fresh_installed_card.cjs').candidateCard(boss)],[actor,{...base,code:actor}],[target,{...base,code:target,type:mylo?33:4}],[stable,{...base,code:stable,type:mylo?33:4}],[filler,{...base,code:filler,type:2}]]);
 const reader=n=>{
 if(n==='c0.lua')return '';
 if(n===`c${actor}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_GRAVE) e:SetCountLimit(1) e:SetOperation(function(e,tp) local tc=Duel.GetFirstMatchingCard(Card.IsCode,1,0xff,0xff,nil,${target}) ${mylo?(kind==='leave-return'?'assert(Duel.SendtoHand(tc,nil,REASON_EFFECT)>0) Duel.BreakEffect() assert(Duel.SpecialSummon(tc,0,tp,1,false,false,POS_FACEDOWN_DEFENSE)>0)':kind==='flip-set'?'assert(Duel.ChangePosition(tc,POS_FACEUP_ATTACK)>0) assert(Duel.ChangePosition(tc,POS_FACEDOWN_DEFENSE)>0)':kind==='unaffected'?'assert(tc:IsFaceup()) tc:ResetEffect(EFFECT_IMMUNE_EFFECT,RESET_CODE) assert(Duel.ChangePosition(tc,POS_FACEDOWN_DEFENSE)>0)':''):(kind==='rebanish-hand'?'assert(Duel.SendtoHand(tc,nil,REASON_EFFECT)>0) assert(Duel.Remove(tc,POS_FACEUP,REASON_EFFECT)>0)':kind==='rebanish-grave'?'assert(Duel.SendtoGrave(tc,REASON_EFFECT)>0) assert(Duel.Remove(tc,POS_FACEUP,REASON_EFFECT)>0)':'')} end) c:RegisterEffect(e) end`;
 if([target,stable,filler].some(c=>n===`c${c}.lua`))return `local s,id=GetID() function s.initial_effect(c) ${kind==='unaffected'&&n===`c${target}.lua`?`local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_IMMUNE_EFFECT) e:SetValue(function(e,re) return re:GetHandler():IsCode(${boss}) end) c:RegisterEffect(e)`:''} end`;
 const p=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',n),path.join(ROOT,'tmp/omega_scripts',n)].find(fs.existsSync);assert(p,n);let s=fs.readFileSync(p,'utf8');
 if(n===`c${boss}.lua`){const old=path.join(OUT,'delayed-group-tracking-before-repair',n);if(fs.existsSync(old))s=fs.readFileSync(old,'utf8');if(mode!=='old'){s=require('./fresh_delayed_group_tracking_repair.cjs').corrected(s,boss);if(mode==='no-tracking')s=s.replace(' and c:GetFlagEffectLabel(id)==fid','');if(mode==='no-outcome')s=s.replace(mylo?'Duel.ChangePosition(sg,pos)':'Duel.SendtoGrave(sg,REASON_EFFECT+REASON_RETURN)','do end');if(mode==='include-unaffected'&&mylo)s=s.replace('g=g:Filter(Card.IsFacedown,nil)','do end');}}
 return s;};
 const d=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,changed=false,checked=false,done=false,turn=0;
 try{
 for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(d,n,reader(n));
 const add=(code,location,player=0,sequence=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(d,{team:player,duelist:0,code,controller:player,location,sequence,position});
 add(boss,mylo?L.MZONE:L.HAND);add(actor,L.GRAVE);add(target,mylo?L.MZONE:L.SZONE,1,0);add(stable,mylo?L.MZONE:L.SZONE,1,1,mylo?P.FACEUP_DEFENSE:P.FACEUP_ATTACK);for(const p of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,p);core.startDuel(d);
 const query=(loc,p=1)=>core.duelQueryLocation(d,{flags:Q.CODE|Q.POSITION|Q.REASON,controller:p,location:loc}).filter(Boolean);
 for(let step=0;step<250&&!done;step++){
 const state=core.duelProcess(d),messages=core.duelGetMessage(d);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
 assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 if(!activated){const index=p.activates.findIndex(c=>c.code===boss);assert(index>=0,'Original source effect offered');activated=true;core.duelSetResponse(d,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 if(!checked){assert(trace.some(m=>m.type===M.CHAINING&&m.code===boss),'Original source activated');if(mylo){assert(trace.some(m=>m.type===M.MOVE&&m.card===boss&&m.to.location===L.GRAVE),'Actual source Tribute cost');assert(query(L.MZONE).find(c=>c.code===stable).position===P.FACEDOWN_DEFENSE,'Original position effect applied');}else{assert.equal(query(L.REMOVED).length,2,'Original banishment of two opposing cards');assert.equal(query(L.HAND).length,2,'Original exact draw');}checked=true;}
 if(kind!=='stable'&&!changed){const index=p.activates.findIndex(c=>c.code===actor);assert(index>=0);changed=true;core.duelSetResponse(d,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 if(turn===1){core.duelSetResponse(d,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
 if(mylo){const t=query(L.MZONE).find(c=>c.code===target),u=query(L.MZONE).find(c=>c.code===stable);assert(t&&u);assert.equal(u.position,P.FACEUP_DEFENSE,'Unchanged group member restores original defense');assert.equal(t.position,kind==='stable'?P.FACEUP_ATTACK:P.FACEDOWN_DEFENSE,'Only the original changed instance restores position');}
 else{assert(query(L.GRAVE).some(c=>c.code===stable),'Unchanged group member returns to GY');assert.equal(query(L.GRAVE).some(c=>c.code===target),kind==='stable','Only originally banished instance returns');assert.equal(query(L.REMOVED).some(c=>c.code===target),kind!=='stable','Rebanished instance stays banished');}
 done=true;
 }else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(d,{type:R.SELECT_CHAIN,index:p.forced?0:null});
 else if(p.type===M.SELECT_PLACE){const places=[];for(const side of [0,1])for(const [location,offset] of [[L.MZONE,0],[L.SZONE,8]])for(let sequence=0;sequence<5;sequence++)if((p.field_mask&(1<<(side*16+offset+sequence)))===0)places.push({player:(p.player+side)%2,location,sequence});assert(places.length);core.duelSetResponse(d,{type:R.SELECT_PLACE,places:[places[0]]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(d,{type:R.SELECT_POSITION,position:P.FACEDOWN_DEFENSE});
 else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(d,{type:R.SELECT_EFFECTYN,yes:false});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(d);}
 results.push({boss,kind,failure,logs,trace});console.log(boss,kind,failure||'PASS');
 }
 fs.writeFileSync(path.join(OUT,`current-delayed-group-tracking-${mode}.json`),JSON.stringify({mode,scope:'Original Mylo Tribute/position operation (seeded source; original Fusion procedure not certified) and original Tome activation/banish/draw. Native neutral movements and position resets, mixed unaffected group member retained. No Lua API mapping. Full-card/live Omega open.',results},(_,v)=>typeof v==='bigint'?String(v):v,2));
}
main().catch(e=>{console.error(e);process.exitCode=1});
