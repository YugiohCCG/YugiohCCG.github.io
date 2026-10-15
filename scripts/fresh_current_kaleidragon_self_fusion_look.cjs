'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=217174535,partner=900001191,cost=900001193,original=900001195,filler=900001192;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-hand','no-field','no-self'].find(c=>process.argv.includes('--'+c));
 const tests=[{}];
 for(const test of tests){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:1000,defense:1200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[partner,{...base,code:partner,setcodes:test.wrongSet?[]:[0xf3c]}],[cost,{...base,code:cost,setcodes:test.wrongSet?[]:[0xbc5]}],[original,{...base,code:original,setcodes:test.ownStain?[0xbc5]:[]}],[filler,{...base,code:filler}]]);
  for(const code of [900001197,900001198,900001199,900001200,900001201])cards.set(code,{...base,code,type:code===900001198?2:17});
  cards.set(218685316,candidateCard(218685316));
  const reader=name=>{
   if(name==='c218685316.lua')return 'local s,id=GetID() function s.initial_effect(c) end';
   if([900001197,900001198,900001199,900001200,900001201].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c'+original+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) local fc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_EXTRA,0,nil,${boss}) local sg=Duel.GetMatchingGroup(function(c) return c:IsCode(218685316,${cost}) end,tp,LOCATION_HAND,0,nil) assert(#sg==3 and sg:IsExists(Card.IsCode,1,nil,218685316) and sg:FilterCount(Card.IsSetCard,nil,0xbc5)==3) fc:SetMaterial(sg) Duel.SendtoGrave(sg,REASON_EFFECT+REASON_MATERIAL+REASON_FUSION) Duel.BreakEffect() assert(Duel.SpecialSummon(fc,SUMMON_TYPE_FUSION,tp,tp,false,false,POS_FACEUP)==1) fc:CompleteProcedure() assert(fc:IsSummonType(SUMMON_TYPE_FUSION) and fc:IsSummonLocation(LOCATION_EXTRA)) Duel.Hint(HINT_NUMBER,tp,701) end) c:RegisterEffect(e) end`;
   if([partner,cost,filler].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,'Missing '+name);let lua=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'){
    if(control==='no-hand')lua=lua.replace('Duel.ConfirmCards(tp,hg)','do end');if(control==='no-field')lua=lua.replace('Duel.ConfirmCards(tp,fg)','do end');
    if(control==='no-self')lua=lua.replace('return c==sc or','return false or');if(control==='ignore-owner')lua=lua.replace('c:IsControler(tp) and c:IsSetCard(SET_STAIN)','c:IsSetCard(SET_STAIN)');if(control==='ignore-set')lua=lua.replace('c:IsControler(tp) and c:IsSetCard(SET_STAIN)','c:IsControler(tp)');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,done=false,activated=false,responded=false;
  const eligible=!(test.wrongSet||test.opponent);let turn=0;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   const controller=0;add(boss,L.EXTRA);add(218685316,L.HAND);add(cost,L.HAND);add(cost,L.HAND);add(original,L.MZONE,0,P.FACEUP_ATTACK,1);add(partner,L.MZONE,0,P.FACEDOWN_DEFENSE,2);if(!test.noDown){add(900001197,L.MZONE,1,P.FACEDOWN_DEFENSE,0);add(900001198,L.SZONE,1,P.FACEDOWN_DEFENSE,0);}add(900001199,L.MZONE,1,P.FACEUP_ATTACK,1);if(!test.emptyHand){add(900001200,L.HAND,1);add(900001201,L.HAND,1);}for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller,location}).filter(Boolean);
   for(let step=0;step<160&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!activated){const index=p.activates.findIndex(c=>c.code===original);assert(index>=0);activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert(query(L.MZONE).some(c=>c.code===boss),'Actual native Fusion self summon');assert.equal(query(L.GRAVE).filter(c=>c.code===cost||c.code===218685316).length,3,'Actual three Fusion materials');assert(trace.some(m=>m.type===M.HINT&&m.hint_type===9&&String(m.hint)==='701'),'Actual Fusion/Extra history');assert.equal(trace.some(m=>m.type===M.CHAINING&&m.code===boss),eligible,'Native reveal trigger qualification');
     const confirms=trace.filter(m=>m.type===M.CONFIRM_CARDS);const revealed=confirms.flatMap(m=>m.cards.map(c=>c.code)).sort((a,b)=>a-b);const expected=eligible?[...(!test.emptyHand?[900001200,900001201]:[]),...(!test.noDown?[900001197,900001198]:[])].sort((a,b)=>a-b):[];assert.deepEqual(revealed,expected,'Exactly opponent Hand and facedown field cards revealed');assert(confirms.every(m=>m.player===0),'Owner observes opponent cards');done=true;
    }else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===boss);if(index>=0){responded=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index});}else core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===cost);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const shift=(p.field_mask&31)===31?16:0;const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:shift?1-p.player:p.player,location:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:true});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-kaleidragon-self-fusion-look'+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:null,scope:'Full Kaleidragon from Extra, neutral helper explicitly checks known printed three materials including actual Stargazer metadata with neutral material Lua and two Stain monsters, moves all real Hand materials/sets material group/native non-bypass FusionSummon then CompleteProcedure. Full self summon trigger reveals exact opponent Hand/facedown field. No seeded procedure status/API adapters; helper does not certify production Fusion material-selection path, separately IsFusionCode compatibility blocked. NativeOmega/fullcard OPEN.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
