'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=212429024,lab=900001191,filler=900001192,spellCost=900001193,recipient=900001194,results=[];
 const control=['no-append','no-original','no-response'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{interrupt:'activation'},{interrupt:'effect'},{interrupt:'source'},{interrupt:'resource'}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:1000,defense:1200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:test.spell?2:17,setcodes:test.wrongSet?[]:[0x760]}],[filler,{...base,code:filler}],[recipient,{...base,code:recipient,type:test.monsterTrigger?33:2,setcodes:test.wrongTrigger?[]:[0x760]}]]);
  cards.set(spellCost,{...base,code:spellCost,type:17,setcodes:[0x103]});
  cards.set(900001196,{...base,code:900001196,type:0x100004});
  const reader=name=>{
   if(name==='c900001196.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_CHAINING) e:SetCondition(function(e,tp,eg,ep,ev,re) return re and re:GetHandler():IsCode(${recipient}) end) e:SetOperation(function(e,tp,eg,ep,ev) ${test.interrupt==='activation'?'Duel.NegateActivation(ev)':test.interrupt==='effect'?'Duel.NegateEffect(ev)':'local tc=Duel.GetFirstMatchingCard(Card.IsCode,0,'+(test.interrupt==='source'?'LOCATION_MZONE':'LOCATION_DECK')+',0,nil,'+(test.interrupt==='source'?boss:lab)+') Duel.Remove(tc,POS_FACEUP,REASON_EFFECT)'} end) c:RegisterEffect(e) end`;
   if(name==='c'+recipient+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(${test.monsterTrigger?'EFFECT_TYPE_IGNITION':'EFFECT_TYPE_ACTIVATE'}) ${test.monsterTrigger?'e:SetRange(LOCATION_MZONE)':'e:SetCode(EVENT_FREE_CHAIN)'} e:SetOperation(function(e,tp) Duel.Hint(HINT_NUMBER,tp,905) end) c:RegisterEffect(e) end`;if(name==='c'+spellCost+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_SZONE,0,nil,${lab}) Duel.Hint(HINT_NUMBER,tp,tc and tc:IsType(TYPE_TRAP) and tc:IsType(TYPE_CONTINUOUS) and 901 or 900) end) c:RegisterEffect(e) end`;if([lab,filler].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){if(control!=='no-append'){lua=lua.replace('e2:SetCode(EVENT_CHAIN_SOLVED)','e2:SetCode(EVENT_CHAIN_SOLVING)').replace('e2:SetOperation(s.addop)','e2:SetOperation(s.wrapop)');lua+=`
function s.wrapop(e,tp,eg,ep,ev,re,r,rp) local original=re:GetOperation() local owner=tp Duel.ChangeChainOperation(ev,function(ce,cp,cg,cep,cev,cre,cr,crp) ${control==='no-original'?'':'if original then original(ce,cp,cg,cep,cev,cre,cr,crp) end'} s.addop(ce,owner) end) end
`;}
    
    
    
    if(control==='no-trap-type')lua=lua.replace('e1:SetValue(TYPE_TRAP+TYPE_CONTINUOUS)','e1:SetValue(TYPE_MONSTER+TYPE_EFFECT)');if(control==='no-operation')lua=lua.replace('e2:SetOperation(s.addop)','e2:SetOperation(function() end)');if(control==='ignore-set')lua=lua.replace('return c:IsSetCard(SET_GRAVINITY) and c:IsType(TYPE_MONSTER)','return c:IsCode('+lab+') and c:IsType(TYPE_MONSTER)');if(control==='ignore-type')lua=lua.replace('return c:IsSetCard(SET_GRAVINITY) and c:IsType(TYPE_MONSTER)','return c:IsSetCard(SET_GRAVINITY)');if(control==='allow-trigger')lua=lua.replace('return rc:IsSetCard(SET_GRAVINITY) and re:IsActiveType(TYPE_SPELL+TYPE_TRAP)','return true');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false,turn=0,secondary=false,placementStarted=false,placementFinished=false,responded=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   if(test.interrupt)add(900001196,L.SZONE,1,P.FACEDOWN_DEFENSE);add(boss,L.MZONE,0,P.FACEUP_ATTACK,0);add(spellCost,L.MZONE,0,P.FACEUP_ATTACK,2);add(recipient,test.monsterTrigger?L.MZONE:L.HAND,0,P.FACEUP_ATTACK,1);add(lab,test.gy?L.GRAVE:L.DECK,0,P.FACEUP_ATTACK);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION|Q.ATTACK|Q.DEFENSE,controller,location}).filter(Boolean);let placements=0,placed=false;
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(!activated){const index=p.activates.findIndex(c=>c.code===recipient);assert(index>=0);activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}const eligible=!test.interrupt;assert.equal(trace.some(m=>m.type===M.HINT&&String(m.hint)==='905'),test.interrupt!=='activation'&&test.interrupt!=='effect','Original Spell resolution');assert.equal(query(L.MZONE).filter(c=>c.code===lab).length,eligible?1:0,'Actual additional summon');assert.equal(query(test.interrupt==='resource'?L.REMOVED:L.DECK).filter(c=>c.code===lab).length,eligible?0:1,'Resource final position');assert.equal(query(test.interrupt==='source'?L.REMOVED:L.MZONE).filter(c=>c.code===boss).length,1,'Source final position');assert.equal(trace.some(m=>m.type===M.SELECT_YESNO),eligible,'Additional offer');if(test.interrupt){assert(responded);assert(trace.some(m=>m.type===M.CHAINING&&m.code===900001196&&m.chain_size===2),'Actual CL2 response');}done=true;}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===lab);const chosen=index>=0?index:p.selects.findIndex(c=>c.code===spellCost);assert(chosen>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[chosen]});}
    else if(p.type===M.SELECT_UNSELECT_CARD){const index=p.can_finish?null:p.select_cards.findIndex(c=>c.code===spellCost);assert(index===null||index>=0);core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});
    else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.trap?1:0});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x1f)!==0x1f;const shift=isMonster?0:8;const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
    else if(p.type===M.SELECT_CHAIN){let index=null;if(test.interrupt&&activated&&!responded&&control!=='no-response'){const i=p.selects.findIndex(c=>c.code===900001196);if(i>=0){responded=true;index=i;}}core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index??(p.forced?0:null)});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-gravinity-nebulix-append-interruption-candidate'+(control?'-'+control:'')+'.json'),JSON.stringify({classification:'In-memory true resolution append candidate; production unchanged',adapter:null,scope:'Full current initial-field Nebulix actual native Gravinity Spell CL1 and CounterTrap CL2 activation/effect negation or source/resource banish. No adapters; proper Synchro arrival/recycle/Omega/fullcard open.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(c=>c.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
