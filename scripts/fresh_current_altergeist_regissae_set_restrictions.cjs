'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=211873618,lab=900001191,filler=900001192,spellCost=900001193,recipient=900001194,results=[];
 const control=['no-set','no-lock','no-response'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{full:true},{necro:true},{interrupt:'capacity'},{interrupt:'necro'}]){
  const targetCode=test.selfTarget?boss:lab;
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:test.spell?2:test.monster?33:4,setcodes:test.wrongSet?[]:[0x103]}],[filler,{...base,code:filler,type:2}]]);
  cards.set(spellCost,{...base,code:spellCost,type:0x100004});
  cards.set(recipient,{...base,code:recipient,type:33});
  const reader=name=>{
   if(name==='c'+spellCost+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_CHAINING) e:SetCondition(function(e,tp,eg,ep,ev,re) return re and re:GetHandler():IsCode(${boss}) and re:GetHandler():IsLocation(LOCATION_GRAVE) end) e:SetOperation(function(e,tp,eg,ep,ev) ${test.interrupt==='capacity'?'local g=Duel.SelectMatchingCard(0,Card.IsCode,0,LOCATION_DECK,0,5,5,nil,'+filler+') for tc in aux.Next(g) do Duel.SSet(0,tc) end':control==='no-lock'?'Duel.Hint(HINT_MESSAGE,tp,880)':'local l=Effect.CreateEffect(e:GetHandler()) l:SetType(EFFECT_TYPE_FIELD) l:SetCode(EFFECT_NECRO_VALLEY) l:SetTargetRange(LOCATION_GRAVE,0) Duel.RegisterEffect(l,0)'} end) c:RegisterEffect(e) end`;
   if(name==='c'+recipient+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) local c=Duel.GetMatchingGroup(Card.IsCode,tp,'+(test.fromRemoved?'LOCATION_REMOVED':'LOCATION_MZONE')+',0,nil,'+boss+')'+(test.count?'':':GetFirst()')+(control==='no-removal'?' do end':' Duel.SendtoGrave(c,REASON_EFFECT)')+' end) c:RegisterEffect(e) '+(test.necro&&control!=='no-lock'?'local l=Effect.CreateEffect(c) l:SetType(EFFECT_TYPE_FIELD) l:SetCode(EFFECT_NECRO_VALLEY) l:SetRange(LOCATION_MZONE) l:SetTargetRange(LOCATION_GRAVE,0) c:RegisterEffect(l)':'')+' end';
   if([lab,filler,spellCost,recipient].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){

    
    if(control==='ignore-relation')lua=lua.replace('tc:IsRelateToEffect(e)','true');if(control==='no-set')lua=lua.replace('Duel.SSet(tp,tc)','do end');if(control==='allow-set')lua=lua.replace('c:IsSetCard(0x103) and c:IsType(TYPE_TRAP) and c:IsSSetable()','c:IsType(TYPE_TRAP) and c:IsSSetable()');if(control==='allow-type')lua=lua.replace('c:IsSetCard(0x103) and c:IsType(TYPE_TRAP) and c:IsSSetable()','c:IsSetCard(0x103) and c:IsSSetable()');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false,turn=0,secondary=false,placementStarted=false,placementFinished=false,responded=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   if(test.interrupt)add(spellCost,L.SZONE,1,P.FACEDOWN_DEFENSE);
   add(boss,test.fromRemoved?L.REMOVED:L.MZONE,0,P.FACEUP_ATTACK);add(recipient,L.MZONE,0,P.FACEUP_ATTACK,1);if(test.full)for(let i=0;i<5;i++)add(filler,L.SZONE,0,P.FACEDOWN_DEFENSE,i);add(targetCode,L.GRAVE,0,test.facedown?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK);if(test.independent)add(lab,L.DECK);if(test.count){add(boss,L.GRAVE,0,P.FACEUP_ATTACK);add(lab,L.REMOVED,0,P.FACEUP_ATTACK);}for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(test.independent&&!secondary){const index=p.activates.findIndex(c=>c.code===boss);assert(index>=0,'Actual Tribute effect available');secondary=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}if(!activated){if(test.independent){const cost=query(L.GRAVE).find(c=>c.code===boss);assert(cost&&(cost.reason&0x80),'First effect actually Tributes source as cost');assert(query(L.MZONE).some(c=>c.code===lab),'First effect actually summons Deck target');}const index=p.activates.findIndex(c=>c.code===recipient);assert(index>=0,'Actual removal effect available');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}assert(query(L.GRAVE).some(c=>c.code===boss));const offered=trace.some(m=>m.type===M.CHAINING&&m.code===boss&&m.location===L.GRAVE);assert.equal(offered,!test.full&&!test.necro,'Native target eligibility under capacity/NC');assert.equal(query(L.SZONE).some(c=>c.code===lab),!test.full&&!test.necro&&!test.interrupt,'Native actual Trap setting');if(test.full||test.necro||test.interrupt)assert(query(L.GRAVE).some(c=>c.code===lab),'Restricted actual target retained');if(test.full||test.interrupt==='capacity')assert.equal(query(L.SZONE).filter(c=>c.code===filler).length,5,'Actual five occupied SZONE');if(test.interrupt)assert(responded,'Actual CL2 restriction');done=true;}
    else if(p.type===M.SELECT_CARD){const indices=p.selects.map((c,i)=>c.code===(p.min===5?filler:lab)?i:-1).filter(i=>i>=0).slice(0,p.min||1);assert(indices.length>0,'Actual recovery target');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:indices});}
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const monsterZone=test.independent&&!activated;const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<((monsterZone?0:8)+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:monsterZone?L.MZONE:L.SZONE,sequence}]});}
    else if(p.type===M.SELECT_CHAIN){let index=null;const own=p.selects.findIndex(c=>c.code===boss&&c.location===L.GRAVE);if(own>=0)index=own;else if(test.interrupt&&!responded&&control!=='no-response'){const i=p.selects.findIndex(c=>c.code===spellCost);if(i>=0){responded=true;index=i;}}core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index??(p.forced?0:null)});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-altergeist-regissae-set-restrictions'+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:null,engine:'Full current Regissae initially field, actual native SendGY/target setting with initial or actual CL2 five SZONE occupancy or native NecroValley field effect. Neutral ignition/CounterTrap fixtures, no adapters; native Link arrival/Omega/fullcard open.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(c=>c.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
