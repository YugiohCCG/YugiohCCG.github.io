'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict');
const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport(),{candidateCard}=require('./fresh_installed_card.cjs');
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,SelectBattleCMDAction:B,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=259844716,spirit=900009501,enemy=900009502,filler=900009503,counter=900009504;
 const control=['candidate','no-double','prior-source'].find(x=>process.argv.includes('--'+x)),results=[];
 for(const test of [{attack:true},{},{decline:true},{wrongSpirit:true},{immune:true},{negated:true},{spiritGone:true},{sourceGone:true},{reset:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:1,race:1n,attack:1000,defense:1200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[spirit,{...base,code:spirit,type:test.wrongSpirit?33:0x221}],[enemy,{...base,code:enemy,attack:500}],[filler,{...base,code:filler,type:2}],[counter,{...base,code:counter,type:test.negated?0x100004:0x10002}]]);
  const reader=name=>{
   if(name==='c0.lua')return '';
   if(name==='c'+spirit+'.lua')return `local s,id=GetID() function s.initial_effect(c) ${test.immune?'local x=Effect.CreateEffect(c) x:SetType(EFFECT_TYPE_SINGLE) x:SetCode(EFFECT_IMMUNE_EFFECT) x:SetValue(function(e,re) return re:GetHandler():IsCode('+boss+') end) c:RegisterEffect(x)':''} end`;
   if([enemy,filler].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c'+counter+'.lua')return `local s,id=GetID() function s.initial_effect(c) local a=Effect.CreateEffect(c) a:SetType(EFFECT_TYPE_SINGLE) a:SetCode(EFFECT_TRAP_ACT_IN_SET_TURN) a:SetProperty(EFFECT_FLAG_SET_AVAILABLE) c:RegisterEffect(a) local x=Effect.CreateEffect(c) x:SetType(EFFECT_TYPE_ACTIVATE) x:SetCode(${test.negated?'EVENT_SUMMON':'EVENT_CHAINING'}) ${test.negated?'x:SetCondition(function(e,tp,eg) return eg:IsExists(Card.IsCode,1,nil,'+boss+') end)':'x:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode('+boss+') end)'} x:SetOperation(function(e,tp,eg,ep,ev,re) ${test.negated?'Duel.NegateSummon(eg) Duel.SendtoGrave(eg,REASON_EFFECT)':'local g=Duel.GetMatchingGroup(Card.IsCode,1-tp,LOCATION_HAND+LOCATION_MZONE,0,nil,'+(test.sourceGone?boss:spirit)+') Duel.Remove(g,POS_FACEUP,REASON_EFFECT)'} end) c:RegisterEffect(x) end`;
   const p=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(p=>fs.existsSync(p));assert(p,'Missing '+name);let lua=fs.readFileSync(p,'utf8');if(name==='c'+boss+'.lua'&&control)lua=fs.readFileSync(path.join(OUT,'remaining-normal-summon-before-repair',name),'utf8');if(name==='c'+boss+'.lua'&&control&&control!=='prior-source')lua=require('./fresh_remaining_normal_summon_repair.cjs').yurei(lua);if(name==='c'+boss+'.lua'&&control==='no-double')lua=lua.replace('s.double(e,tc,fid) te:Reset()','te:Reset()');return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,attacked=false,accepted=false,done=false,turn=0,waitingReset=false;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   const add=(code,location,player=0,position=P.FACEUP_ATTACK,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(boss,L.HAND);add(spirit,L.MZONE);add(enemy,L.MZONE,1);if(test.negated||test.spiritGone||test.sourceGone)add(counter,L.SZONE,1,P.FACEDOWN_DEFENSE);for(const p of [0,1])for(let i=0;i<10;i++)add(filler,L.DECK,p);
   core.startDuel(duel);const query=(loc,p=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.ATTACK|Q.POSITION,controller:p,location:loc}).filter(Boolean);
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);turn+=messages.filter(m=>m.type===M.NEW_TURN).length;
    if(logs.some(l=>l.type===0))throw Error(logs.map(l=>l.message).join('; '));if(state===S.END)throw Error('Unexpected duel end');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(waitingReset){const tc=query(L.MZONE).find(c=>c.code===spirit);assert(tc&&tc.attack===1000,'ATK doubling expires at End Phase');assert(query(L.HAND).some(c=>c.code===boss),'Original Yurei End Phase return');done=true;continue;}core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:!attacked&&p.player===(test.attack?0:1)&&turn>1&&p.to_bp?A.TO_BP:A.TO_EP});}
    else if(p.type===M.SELECT_BATTLECMD){if(!attacked){const index=p.attacks.findIndex(c=>c.code===(test.attack?spirit:enemy));assert(index>=0,'Original native attacker');attacked=true;core.duelSetResponse(duel,{type:R.SELECT_BATTLECMD,action:B.SELECT_BATTLE,index});}else{
      const eligible=!test.wrongSpirit&&!test.decline;assert.equal(accepted,eligible,'Original Hand trigger eligibility/decline');assert.equal(query(L.MZONE).some(c=>c.code===boss),eligible&&!test.negated&&!test.sourceGone,'Successful original deferred Normal Summon');const tc=query(L.MZONE).find(c=>c.code===spirit);if(!test.spiritGone){assert(tc,'Spirit remains on field');assert.equal(tc.attack,eligible&&!test.negated&&!test.sourceGone&&!test.immune?2000:1000,'Original Spirit ATK doubling after successful Normal Summon');}else assert(!tc,'Spirit removed by CL2');assert(trace.some(m=>m.type===M.ATTACK),'Actual native attack announcement');if(eligible&&!test.negated&&!test.sourceGone)assert(trace.some(m=>m.type===M.SUMMONED),'Actual Normal Summon success');if(test.reset){waitingReset=true;core.duelSetResponse(duel,{type:R.SELECT_BATTLECMD,action:B.TO_EP});continue;}done=true;}}
    else if(p.type===M.SELECT_CARD){let index=p.selects.findIndex(c=>c.code===(test.attack?enemy:spirit));if(index<0&&test.spiritGone)index=p.selects.findIndex(c=>c.code===boss);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_CHAIN){const i=p.selects.findIndex(c=>c.code===(p.player===0?boss:counter));if(i>=0&&!(p.player===0&&test.decline)){if(p.player===0)accepted=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:i});}else core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:null});}
    else if(p.type===M.SELECT_EFFECTYN){assert.equal(p.code,boss);accepted=!test.decline;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:!test.decline});}
    else if(p.type===M.SELECT_PLACE){const seq=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);assert.notEqual(seq,undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:L.MZONE,sequence:seq}]});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.spiritGone});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   assert(done,'Step limit');
  }catch(e){failure=e.message}finally{core.destroyDuel(duel)}
  results.push({test,failure,accepted,trace,logs});console.log((failure?'FAIL ':'PASS ')+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(OUT,'current-yurei-summon-followup'+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Original Yurei Hand battle trigger/current installed metadata/corrected transport/no Lua API mapping. Neutral Spirit/native attacker and actual attack events; no full-card/live Omega claim.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
