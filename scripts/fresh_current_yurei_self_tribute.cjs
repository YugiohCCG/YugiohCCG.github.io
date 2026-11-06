'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto');
const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport(),{candidateCard}=require('./fresh_installed_card.cjs');
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=259844716,spirit=900009531,victim=900009532,spell=900009533,filler=900009534,counter=900009535,results=[];
 const control=process.argv.includes('--prior-source')?'prior-source':process.argv.includes('--no-negate')?'no-negate':null;
 for(const test of [{selfOnly:true},{selfOnly:true,negated:true},{selfOnly:true,effectNegated:true},{selfOnly:true,endPhase:true},{},{hand:true},{resourceGone:true},{immune:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:1,race:1n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[boss,candidateCard(boss)],[spirit,{...base,code:spirit,type:0x221}],[victim,{...base,code:victim}],[spell,{...base,code:spell,type:2}],[filler,{...base,code:filler,type:2}],[counter,{...base,code:counter,type:test.resourceGone?0x10002:0x100004}]]);
 const reader=name=>{
  if(name==='c0.lua')return '';
  if(name==='c'+spell+'.lua')return `local s,id=GetID() function s.initial_effect(c) local x=Effect.CreateEffect(c) x:SetType(EFFECT_TYPE_ACTIVATE) x:SetCode(EVENT_FREE_CHAIN) x:SetCategory(CATEGORY_DESTROY) x:SetProperty(EFFECT_FLAG_CARD_TARGET) x:SetTarget(function(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(Card.IsCode,tp,0,LOCATION_MZONE,1,nil,${victim}) end local g=Duel.GetMatchingGroup(Card.IsCode,tp,0,LOCATION_MZONE,nil,${victim}) Duel.SetTargetCard(g) Duel.SetOperationInfo(0,CATEGORY_DESTROY,g,1,0,0) end) x:SetOperation(function(e,tp) local tc=Duel.GetFirstTarget() if tc and tc:IsRelateToEffect(e) then Duel.Destroy(tc,REASON_EFFECT) end end) c:RegisterEffect(x) end`;
  if(name==='c'+spirit+'.lua')return `local s,id=GetID() function s.initial_effect(c) ${test.immune?'local z=Effect.CreateEffect(c) z:SetType(EFFECT_TYPE_SINGLE) z:SetCode(EFFECT_IMMUNE_EFFECT) z:SetValue(function(e,re) return re:GetHandler():IsCode('+boss+') end) c:RegisterEffect(z)':''} end`;
  if(name==='c'+counter+'.lua')return `local s,id=GetID() function s.initial_effect(c) local a=Effect.CreateEffect(c) a:SetType(EFFECT_TYPE_SINGLE) a:SetCode(EFFECT_TRAP_ACT_IN_SET_TURN) a:SetProperty(EFFECT_FLAG_SET_AVAILABLE) c:RegisterEffect(a) local x=Effect.CreateEffect(c) x:SetType(EFFECT_TYPE_ACTIVATE) x:SetCode(EVENT_CHAINING) x:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${boss}) end) x:SetOperation(function(e,tp,eg,ep,ev) ${test.resourceGone?'Duel.Remove(Duel.GetMatchingGroup(Card.IsCode,1-tp,LOCATION_HAND+LOCATION_MZONE,0,nil,'+spirit+'),POS_FACEUP,REASON_EFFECT)':test.effectNegated?'Duel.NegateEffect(ev)':'Duel.NegateActivation(ev)'} end) c:RegisterEffect(x) end`;
  if([victim,filler].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';
  const p=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(p=>fs.existsSync(p));assert(p);let lua=fs.readFileSync(p,'utf8');if(name==='c'+boss+'.lua'){lua=fs.readFileSync(path.join(OUT,'yurei-before-self-tribute-repair',name),'utf8');if(control!=='prior-source')lua=require('./fresh_yurei_self_tribute_repair.cjs').corrected(lua);if(control==='no-negate')lua=lua.replace('then Duel.NegateEffect(ev) end','then do end end');}return lua;
 };
 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,spiritAtYureiActivation=null,releaseReason=null,firstResolution=false,returned=false;
 const tributeCode=(test.selfOnly||test.immune||test.resourceGone)?boss:spirit;
 try{
  for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
  const add=(code,location,player=0,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position:code===counter?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK});
  add(boss,L.HAND);add(victim,L.MZONE);if(!test.selfOnly)add(spirit,test.hand?L.HAND:L.MZONE,0,1);add(spell,L.HAND,1);if(test.negated||test.effectNegated||test.resourceGone)add(counter,L.SZONE,1);for(const p of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,p);
  core.startDuel(duel);const query=loc=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,controller:0,location:loc}).filter(Boolean);
  for(let step=0;step<130&&!done;step++){
   const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);
   if(messages.some(m=>m.type===M.CHAINED&&m.chain_size===2))spiritAtYureiActivation=query(tributeCode===boss||test.hand?L.HAND:L.MZONE).some(c=>c.code===tributeCode);
   if(logs.some(l=>l.type===0))throw Error(logs.map(l=>l.message).join('; '));if(state===S.END)throw Error('Unexpected duel end');if(state!==S.WAITING)continue;const p=messages.at(-1);
   if(p.type===M.SELECT_IDLECMD){if(firstResolution&&test.endPhase){assert(query(L.HAND).some(c=>c.code===boss),'Original Tributed Yurei returns during native End Phase');returned=true;done=true;continue;}if(!activated){if(p.player===0){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}const index=p.activates.findIndex(c=>c.code===spell);assert(index>=0);activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
    const eligible=true,success=!test.negated&&!test.effectNegated;
    assert.equal(trace.some(m=>m.type===M.CHAINING&&m.code===boss&&m.chain_size===2),eligible,'Original Hand Quick Effect CL2 eligibility');assert.equal(query(L.MZONE).some(c=>c.code===victim),success,'Destruction negated only after actual effect Tribute');
    const release=trace.find(m=>m.type===M.MOVE&&m.card===tributeCode&&m.to.location===L.GRAVE);assert.equal(!!release,success,'Only successful resolution Tributes Spirit');if(eligible)assert.equal(spiritAtYureiActivation,true,'Printed post-semicolon Tribute remains until the built chain resolves');
    if(release){releaseReason=query(L.GRAVE).find(c=>c.code===tributeCode)?.reason;assert((releaseReason&0x40)!==0&&(releaseReason&0x80)===0,'Printed Tribute is an effect, not a cost');}
    firstResolution=true;if(test.endPhase){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}done=true;}
   else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===(p.player===0?boss:counter));core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:null});}
   else if(p.type===M.SELECT_CARD){const i=p.selects.findIndex(c=>c.code===tributeCode);assert(i>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[i]});}
   else if(p.type===M.SELECT_EFFECTYN){assert.equal(p.code,boss);core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});}
   else if(p.type===M.SELECT_PLACE){const shift=[0,8,16,24].find(v=>[0,1,2,3,4].some(i=>(p.field_mask&(1<<(v+i)))===0)),seq=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:shift>=16?1-p.player:p.player,location:shift%16===8?L.SZONE:L.MZONE,sequence:seq}]});}
   else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
  }
  assert(done,'Step limit');
 }catch(e){failure=e.message}finally{core.destroyDuel(duel)}
 results.push({test,failure,spiritAtYureiActivation,releaseReason,returned,trace,logs});console.log((failure?'FAIL ':'PASS ')+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const source=path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c259844716.lua');fs.writeFileSync(path.join(OUT,'current-yurei-self-tribute'+(control?'-'+control:'')+'.json'),JSON.stringify({control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(source)).digest('hex'),scope:'Full original Yurei/current installed metadata/corrected transport/no Lua API mapping. Actual opponent neutral destruction Spell CL1/original private-Hand Yurei CL2. Actual source as its own Spirit Tribute, activation/effect negation, removed/immune alternative resources and original Tributed End Phase return. Complete original effects; no Lua API mapping. Not full-card/live Omega.',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
