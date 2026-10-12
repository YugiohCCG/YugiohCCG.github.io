'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),source=259869259,left=259033429,right=259405917,spell=900004001,target=900004002,blocker=900004003,interrupt=900004004;
async function main(){
 const mod=await import(pathToFileURL(path.join(ROOT,'output/fresh-ccg-september/public-core-card-data-adapter.mjs')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(x){if(process.argv.includes('--probe'))console.log(x)},printErr(){}}),control=['no-control','no-relation','no-colink-recheck'].find(c=>process.argv.includes('--'+c))||null,results=[];
 for(const test of [{},{decline:true},{noGraph:true},{linkedZoneOccupied:true},{noSupport:true},{noTarget:true},{trap:true},{ownSpell:true},{targetLost:true},{targetReturned:true},{graphBroken:true},{zoneFilled:true},{sourceRemoved:true}]){
  const logs=[],trace=[],neutral={alias:0,setcodes:[],type:17,level:1,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[source,candidateCard(source)],[left,candidateCard(left)],[right,candidateCard(right)],[spell,{...neutral,code:spell,type:test.trap?4:2}],[target,{...neutral,code:target}],[blocker,{...neutral,code:blocker}],[interrupt,{...neutral,code:interrupt,type:4}]]);
  if(test.noSupport)for(const code of [left,right])cards.set(code,{...cards.get(code),setcodes:[]});
  const eligible=!test.noGraph&&!test.linkedZoneOccupied&&!test.noSupport&&!test.noTarget&&!test.trap&&!test.ownSpell,chained=eligible&&!test.decline,interrupted=!!(test.targetLost||test.targetReturned||test.graphBroken||test.zoneFilled||test.sourceRemoved),stolen=chained&&!interrupted;
  const reader=name=>{
   if(name==='c0.lua')return '';
   if(name==='c'+interrupt+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_CHAINING) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${source}) end) e:SetOperation(function(e,tp) ${test.targetLost?`Duel.SendtoGrave(Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_MZONE,0,nil,${target}),REASON_EFFECT)`:test.targetReturned?`local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_MZONE,0,nil,${target}) assert(Duel.SendtoHand(tc,nil,REASON_EFFECT)==1) assert(Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)==1)`:test.graphBroken?`Duel.MoveSequence(Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_MZONE,nil,${right}),4)`:test.zoneFilled?`assert(Duel.SpecialSummon(Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_GRAVE,nil,${blocker}),0,tp,1-tp,false,false,POS_FACEUP)==1)`:test.sourceRemoved?`assert(Duel.SendtoGrave(Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_SZONE,nil,${source}),REASON_EFFECT)==1,"Surge actually sent to GY")`:''} end) c:RegisterEffect(e) end`;
   if(name==='c'+spell+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) ${test.noTarget?'':test.targetLost?`assert(not Duel.GetFirstMatchingCard(Card.IsCode,0,LOCATION_MZONE,LOCATION_MZONE,nil,${target}),"Recipient actually left field")`:`local tc=Duel.GetFirstMatchingCard(Card.IsCode,0,LOCATION_MZONE,LOCATION_MZONE,nil,${target}) assert(tc,"Recipient present") assert(tc:IsControler(${stolen?0:1}),"Actual resulting controller") ${stolen?'assert(tc:GetSequence()==0,"Recipient in linked MMZ0")':''}`} end) c:RegisterEffect(e) end`;
   if([target,blocker].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(p=>fs.existsSync(p));assert(file,'Missing '+name);let lua=fs.readFileSync(file,'utf8');
   if(name==='c'+source+'.lua'&&process.argv.includes('--probe'))lua+=`\nlocal old=s.control_con s.control_con=function(e,tp,eg,ep,ev,re,r,rp) Debug.Message('controlcon rp='..rp..' tp='..tp..' spell='..tostring(re:IsActiveType(TYPE_SPELL))..' result='..tostring(old(e,tp,eg,ep,ev,re,r,rp))) return old(e,tp,eg,ep,ev,re,r,rp) end local oldtg=s.control_tg s.control_tg=function(e,tp,eg,ep,ev,re,r,rp,chk,chkc) if chk==0 then local g=Duel.GetMatchingGroup(Card.IsFaceup,tp,LOCATION_MZONE,0,nil) for c in aux.Next(g) do Debug.Message('code='..c:GetCode()..' mutual='..c:GetMutualLinkedGroupCount()..' zone='..c:GetLinkedZone(tp)) end Debug.Message('tg='..tostring(oldtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc))) end return oldtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc) end` ;
   if(name==='c'+source+'.lua'&&control==='no-relation')lua=lua.replace('not tc or not tc:IsRelateToEffect(e) or not tc:IsControlerCanBeChanged()', 'not tc or not tc:IsControlerCanBeChanged()');
   if(name==='c'+source+'.lua'&&control==='no-colink-recheck'){const at=lua.indexOf('function s.control_op');lua=lua.slice(0,at)+lua.slice(at).replace('tc:GetMutualLinkedGroupCount() > 0','true');}
   if(name==='c'+source+'.lua'&&control==='no-control')lua=lua.replace('Duel.GetControl(tc, tp, 0, 0, s_field)','do end');
   return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,done=false,activated=false,offered=false,turn=0;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   const add=(code,location,player=0,sequence=0,position=P.FACEDOWN_DEFENSE)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(source,L.SZONE,0,0,P.FACEUP_ATTACK);add(left,L.MZONE,0,1,P.FACEUP_ATTACK);add(right,L.MZONE,0,test.noGraph?4:2,P.FACEUP_ATTACK);
   if(test.linkedZoneOccupied)add(blocker,L.MZONE,0,0,P.FACEUP_ATTACK);
   if(!test.noTarget)add(target,L.MZONE,1,2,P.FACEUP_ATTACK);
   if(interrupted)add(interrupt,L.SZONE,1,1);if(test.zoneFilled)add(blocker,L.GRAVE);add(spell,test.trap?L.SZONE:L.HAND,test.ownSpell?0:1);
   for(const player of [0,1])for(let i=0;i<5;i++)add(blocker,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<180&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    assert(!logs.some(l=>l.type===0),JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!activated){if(turn<(test.ownSpell?1:2)){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
      const index=p.activates.findIndex(c=>c.code===spell);assert(index>=0,'Actual test Spell/Trap activation');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert(trace.some(m=>m.type===M.CHAINING&&m.code===spell),'Actual response chain');assert.equal(offered,eligible,'Surge response availability');
     const chains=trace.filter(m=>m.type===M.CHAINING&&m.code===source);assert.equal(chains.length,chained?1:0,'Actual Surge control chain');if(interrupted)assert(trace.some(m=>m.type===M.CHAINING&&m.code===interrupt),'Actual CL3 interruption');
     const own=core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:0,location:L.MZONE}).filter(Boolean);assert.equal(own.some(c=>c.code===target),stolen,'Final recipient controller');done=true;
    }else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===source);if(index>=0)offered=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.player===1&&interrupted?p.selects.findIndex(c=>c.code===interrupt)>=0?p.selects.findIndex(c=>c.code===interrupt):p.forced?0:null:index>=0&&!test.decline?index:p.forced?0:null});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===target);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_DISFIELD){assert((p.field_mask&1)===0,'Only intended linked destination offered');core.duelSetResponse(duel,{type:R.SELECT_DISFIELD,places:[{player:0,location:L.MZONE,sequence:0}]});}
    else if(p.type===M.SELECT_PLACE){let place;for(const side of [0,1])for(const zone of [L.MZONE,L.SZONE]){const shift=side*16+(zone===L.MZONE?0:8);const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(shift+i)))===0);if(!place&&sequence!==undefined)place={player:p.player^side,location:zone,sequence};}assert(place);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[place]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const sha=p=>crypto.createHash('sha256').update(fs.readFileSync(p)).digest('hex');
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/surge-control'+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Canonical Surge/Carcel/Conductor initially fielded; actual opponent Spell chain and native resulting controller/linked MMZ0. Public card-data adapter, altered set metadata in noSupport, initial Link placement are bounded fixtures. CL3 target loss/return, graph break, linked destination fill and source removal verified; no proper Link procedure or native Omega certification.',control,script_sha256:sha(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+source+'.lua')),harness_sha256:sha(__filename),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
