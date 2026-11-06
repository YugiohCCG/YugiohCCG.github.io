'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{candidateCard}=require('./fresh_installed_card.cjs');
const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september'),boss=253934904,dark=900005301,light=900005302,probe=900005303,filler=900005304,response=900005305;
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport(),{OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod,core=await mod.default({sync:true,print(){},printErr(){}}),results=[],control=process.argv[2]||'old';
 for(const scenario of ['mixedPair','openExtraPair','lateFullPair']){
  const trace=[],logs=[],base={alias:0,setcodes:[],type:0x4000021,level:8,attribute:1,race:1n,attack:1000,defense:0,lscale:0,rscale:0,link_marker:0x1ef},cards=new Map([[boss,candidateCard(boss)],[dark,{...base,code:dark,attribute:32}],[light,{...base,code:light}],[probe,{...base,code:probe,type:2,level:0,link_marker:0}],[filler,{...base,code:filler,type:17,level:4,link_marker:0}],[response,{...base,code:response,type:0x100004}]]);
  const reader=name=>{
   if(name==='c0.lua')return '';
   if([dark,light,filler].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c'+response+'.lua')return `local s,id=GetID()
function s.initial_effect(c)
 local e=Effect.CreateEffect(c)
 e:SetType(EFFECT_TYPE_ACTIVATE)
 e:SetCode(EVENT_CHAINING)
 e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${boss}) end)
 e:SetOperation(function(e,tp)
  local g=Duel.GetMatchingGroup(Card.IsCode,1-tp,LOCATION_DECK,0,nil,${filler}):Select(tp,2,2,nil)
  assert(Duel.SpecialSummon(g,0,1-tp,1-tp,false,false,POS_FACEUP_ATTACK)==2)
 end)
 c:RegisterEffect(e)
end`;
   if(name==='c'+probe+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local g=Duel.GetMatchingGroup(function(c) return c:IsCode(${dark}) end,tp,LOCATION_MZONE,0,nil) assert(#g==${scenario==='mixedPair'?3:2}) ${['mixedPair','openExtraPair','lateFullPair'].includes(scenario)?'local first=Duel.GetFieldCard(tp,LOCATION_MZONE,5) local last=Duel.GetFieldCard(tp,LOCATION_MZONE,6) assert(first and last and first:GetFieldID()~=last:GetFieldID()) local queue={first} local seen={} local found=false while #queue>0 do local cur=table.remove(queue,1) local k=cur:GetFieldID() if not seen[k] then seen[k]=true if k==last:GetFieldID() then found=true end for tc in aux.Next(cur:GetMutualLinkedGroup()) do if tc:IsControler(tp) and tc:IsFaceup() and tc:IsType(TYPE_LINK) then table.insert(queue,tc) end end end end assert(found,"Native mutual-link path connects both own Extra Zones")':''} assert(Duel.GetMZoneCount(tp,g)${scenario==='extraOnly'?'==0':'>0'},"Native projected Main Zone count") Duel.Hint(HINT_NUMBER,tp,701) end) c:RegisterEffect(e) end`;
   const p=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(fs.existsSync);assert(p,name);let s=fs.readFileSync(p,'utf8');if(name==='c'+boss+'.lua'){
 const backup=path.join(OUT,'remaining-zone-choice-before-repair',name);
 if(fs.existsSync(backup))s=fs.readFileSync(backup,'utf8');
 if(control==='candidate')s=require('./fresh_remaining_zone_choice_repair.cjs').corrected(s,boss);
}return s;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{assert(cards.has(code),code);return cards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,prepared=false,activated=false,responded=false,done=false;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])assert(core.loadScript(duel,n,reader(n)));
   const add=(code,location,sequence=0,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position:P.FACEUP_ATTACK});add(boss,L.GRAVE);add(probe,L.HAND);if(scenario==='lateFullPair')core.duelNewCard(duel,{team:1,duelist:0,code:response,controller:1,location:L.SZONE,sequence:0,position:P.FACEDOWN_DEFENSE});
   if(['mixedPair','openExtraPair','lateFullPair'].includes(scenario)){for(const seq of scenario==='mixedPair'?[0,1,2,3,4]:[1,2,3])add(scenario==='mixedPair'&&seq===2?dark:light,L.MZONE,seq);add(dark,L.MZONE,5);add(dark,L.MZONE,6);}else{for(let seq=0;seq<5;seq++)add(seq===2?dark:light,L.MZONE,seq);if(scenario==='mainPair')add(dark,L.MZONE,5);}
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,0,player);core.startDuel(duel);const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,controller:0,location}).filter(Boolean);
   for(let step=0;step<180&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(!prepared){prepared=true;const index=p.activates.findIndex(c=>c.code===probe);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert(trace.some(m=>m.type===M.HINT&&Number(m.hint)===701),'Native board/projection observation');if(!activated){const index=p.activates.findIndex(c=>c.code===boss&&c.location===L.GRAVE);const eligible=true;assert.equal(index>=0,eligible,'Two-card projected Main capacity activation');if(!eligible){done=true;continue;}activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(scenario==='lateFullPair')assert(responded&&query(L.MZONE).filter(c=>c.code===filler).length===2,'Actual late full zones');assert.equal(query(L.MZONE).some(c=>c.code===boss),scenario!=='lateFullPair','Actual GY revival');assert.equal(query(L.GRAVE).filter(c=>c.code===dark&&(c.reason&1)&&(c.reason&0x40)).length,2,'Both DARK resources actually destroyed');assert.equal(trace.filter(m=>m.type===M.MOVE&&m.card===boss&&m.from.location===L.GRAVE&&m.to.location===L.MZONE).length,scenario==='lateFullPair'?0:1,'Native source revival movement');done=true;
    }else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===response);if(index>=0)responded=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
    else if(p.type===M.SELECT_CARD){
      if(p.selects.every(c=>c.code===filler)){core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[0,1]});continue;}
      const indices=p.selects.map((c,i)=>c.code===dark&&c.sequence>=5?i:-1).filter(i=>i>=0).slice(0,p.min);
      assert.equal(indices.length,p.min);
      core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:indices});
    }
    else if(p.type===M.SELECT_UNSELECT_CARD){
      if(p.can_finish){core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index:null});continue;}
      if(p.unselect_cards?.length)assert(p.select_cards.every(c=>c.sequence<5),'Second choice must open a Main Monster Zone');
      const index=p.select_cards.findIndex(c=>c.code===dark&&(p.unselect_cards?.length?c.sequence<5:c.sequence>=5));
      assert(index>=0,'Native legal pair selection');
      core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index});
    }
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:false});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const shift=[0,8,16,24].find(v=>[0,1,2,3,4].some(i=>(p.field_mask&(1<<(v+i)))===0)),sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(shift+i)))===0);assert(shift!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:shift>=16?1-p.player:p.player,location:shift%16===8?L.SZONE:L.MZONE,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p));
   }assert(done,'Step limit');
  }catch(e){failure=e.message}finally{core.destroyDuel(duel)}results.push({scenario,failure,trace,logs});console.log((failure?'FAIL ':'PASS ')+scenario+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(OUT,'current-stagger-zone-pair-'+control+'.json'),JSON.stringify({scope:'Original Stagger revival with seeded Extra Link and three DARK candidates at full Main zones, or an open-zone Extra pair. Native mutual-link and projected capacity checked.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
}
if(require.main===module)main().catch(e=>{console.error(e);process.exitCode=1});
