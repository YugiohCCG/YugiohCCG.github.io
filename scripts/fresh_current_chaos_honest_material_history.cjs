'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict');
const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport(),{candidateCard}=require('./fresh_installed_card.cjs');
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,SelectBattleCMDAction:B,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),mode=process.argv.includes('--prior-source')?'prior-source':process.argv.includes('--marker-only')?'marker-only':process.argv.includes('--attributes-only')?'attributes-only':'candidate',results=[];
 const tests=[];for(const kind of ['light','dark','mixed'])for(const drain of ['none','removed','kept'])tests.push({kind,drain});tests.push({kind:'mixed',drain:'none',change:true},{kind:'light',drain:'none',change:true});
 if(!process.argv.includes('--public-link-fixture-adapter'))tests.splice(1);
 for(const test of tests){
  const boss=248638801,drain=82732705,mat1=900009761,mat2=900009762,ally=900009763,enemy=900009764,observer=900009765,filler=900009766,changer=900009767,logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:16,race:1n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
  const light=test.kind!=='dark',dark=test.kind!=='light',a=light?16:32,b=dark?32:16;
  const cards=new Map([[boss,candidateCard(boss)],[drain,{...base,code:drain,type:0x20004}],[mat1,{...base,code:mat1,attribute:test.change?(test.kind==='mixed'?1:32):a}],[mat2,{...base,code:mat2,attribute:b}],[ally,{...base,code:ally}],[enemy,{...base,code:enemy,attribute:1,attack:2000}],[observer,{...base,code:observer,type:2}],[filler,{...base,code:filler,type:2}],[changer,{...base,code:changer,type:0x20002}]]);
  const reader=name=>{
   if(name==='c0.lua')return '';
   if(name==='c'+boss+'.lua'){let lua=fs.readFileSync(path.join(OUT,'chaos-honest-before-material-history-repair',name),'utf8');if(mode!=='prior-source')lua=require('./fresh_chaos_honest_material_history_repair.cjs')[mode==='marker-only'?'marker':mode==='attributes-only'?'attributes':'corrected'](lua);return lua;}
   if([mat1,mat2,ally,enemy,filler].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c'+changer+'.lua')return `local s,id=GetID() function s.initial_effect(c) local x=Effect.CreateEffect(c) x:SetType(EFFECT_TYPE_FIELD) x:SetCode(EFFECT_CHANGE_ATTRIBUTE) x:SetRange(LOCATION_SZONE) x:SetTargetRange(LOCATION_MZONE,0) x:SetTarget(function(e,c) return c:IsCode(${mat1}) end) x:SetValue(ATTRIBUTE_LIGHT) c:RegisterEffect(x) end`;
   if(name==='c'+observer+'.lua')return `local s,id=GetID() function s.initial_effect(c) local x=Effect.CreateEffect(c) x:SetType(EFFECT_TYPE_ACTIVATE) x:SetCode(EVENT_FREE_CHAIN) x:SetOperation(function(e,tp) Duel.SendtoGrave(Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_SZONE,LOCATION_SZONE,nil,${drain}),REASON_EFFECT) end) c:RegisterEffect(x) local y=Effect.CreateEffect(c) y:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS) y:SetCode(EVENT_CHAIN_SOLVED) y:SetOperation(function(e,tp,eg,ep,ev,re) if not re:GetHandler():IsCode(${boss}) then return end local a=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,${ally}):GetFirst() local b=Duel.GetMatchingGroup(Card.IsCode,tp,0,LOCATION_MZONE,nil,${enemy}):GetFirst() assert(a and b,'Original battle bodies') assert(a:GetAttack()==${light?3000:1000},'Material LIGHT ATK outcome') assert(b:GetAttack()==${dark?0:2000},'Material DARK ATK outcome') assert(re:GetHandler():IsLocation(LOCATION_GRAVE),'Source paid actual GY cost') Duel.Recover(tp,1,REASON_EFFECT) end) Duel.RegisterEffect(y,0) end`;
   const p=path.join(ROOT,'tmp/omega_scripts',name);assert(fs.existsSync(p),name);return fs.readFileSync(p,'utf8');
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,done=false,linked=false,removed=false,attacked=false,turn=0,accepted=false;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   if(process.argv.includes('--public-link-fixture-adapter'))core.loadScript(duel,'existing-public-link-fixture-mappings.lua','assert(Duel.GetMustMaterial==nil) Duel.GetMustMaterial=function() return Group.CreateGroup() end assert(Card.IsLinkType==nil) Card.IsLinkType=function(c,t) return c:IsType(t) end');
   const add=(code,location,player=0,sequence=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,position,sequence});
   add(boss,L.EXTRA,0,0,P.FACEDOWN_DEFENSE);add(mat1,L.MZONE,0,1);add(mat2,L.MZONE,0,3);add(ally,L.MZONE);add(enemy,L.MZONE,1);add(observer,L.HAND);if(test.drain!=='none')add(drain,L.SZONE,1);if(test.change)add(changer,L.SZONE,0,4);for(const p of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,p,0,P.FACEDOWN_DEFENSE);core.startDuel(duel);
   const query=(loc,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.SUMMON_TYPE|Q.REASON|Q.LINK|Q.ATTACK,controller,location:loc}).filter(Boolean);
   for(let step=0;step<320&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(messages.some(m=>m.type===M.NEW_TURN))turn++;assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(trace.some(m=>m.type===M.RECOVER)){assert(accepted,'Original source effect activated');assert(query(L.GRAVE).some(c=>c.code===boss),'Actual source GY payment');for(const code of [mat1,mat2])assert(query(L.GRAVE).some(c=>c.code===code),'Actual selected Link materials sent to GY');done=true;break;}if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(p.player===0&&!linked){const index=p.special_summons.findIndex(c=>c.code===boss);assert(index>=0,'Original Link procedure available');linked=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SPECIAL_SUMMON,index});continue;}
     if(p.player===0&&test.drain==='removed'&&!removed){const index=p.activates.findIndex(c=>c.code===observer);assert(index>=0);removed=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:p.player===0&&turn>1&&p.to_bp?A.TO_BP:A.TO_EP});
    }else if(p.type===M.SELECT_UNSELECT_CARD){const i=p.select_cards.findIndex(c=>[mat1,mat2].includes(c.code));core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index:p.can_finish?null:i});}
    else if(p.type===M.SELECT_CARD){const indices=p.selects.map((c,i)=>[mat1,mat2,enemy].includes(c.code)?i:-1).filter(i=>i>=0);assert(indices.length>=p.min);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:indices.slice(0,p.min)});}
    else if(p.type===M.SELECT_CHAIN){const i=p.selects.findIndex(c=>c.code===boss);if(i>=0)accepted=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:i>=0?i:p.forced?0:null});}
    else if(p.type===M.SELECT_BATTLECMD){assert(!attacked,'Original battle effect must resolve before another attack');const index=p.attacks.findIndex(c=>c.code===ally);assert(index>=0);attacked=true;core.duelSetResponse(duel,{type:R.SELECT_BATTLECMD,action:B.SELECT_BATTLE,index});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:true});
    else if(p.type===M.SELECT_PLACE){const shift=[0,8,16,24].find(v=>[0,1,2,3,4,5,6].some(i=>(p.field_mask&(1<<(v+i)))===0)),sequence=(shift%16===0?[5,0,1,2,3,4,6]:[0,1,2,3,4]).find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:shift>=16?1-p.player:p.player,location:shift%16===8?L.SZONE:L.MZONE,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,logs,trace});console.log((failure?'FAIL ':'PASS ')+JSON.stringify(test)+(failure?' '+failure:''));
 }
 fs.writeFileSync(path.join(OUT,'current-chaos-honest-material-history-'+mode+(process.argv.includes('--public-link-fixture-adapter')?'-public-link-fixture-adapter':'')+'.json'),JSON.stringify({scope:'Original Chaos Honest Link procedure, real selected material payment, original Skill Drain/removal and original linked-monster battle Quick Effect/cost/ATK outcomes. Neutral material/battle/removal/attribute-change/observer supports. Original Lua recipe retained; optional existing GetMustMaterial empty-group/Card.IsLinkType fixture mappings explicitly qualified, not original-runtime proof. Not full-card/live Omega certification.',mode,public_link_fixture_adapter:process.argv.includes('--public-link-fixture-adapter'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
