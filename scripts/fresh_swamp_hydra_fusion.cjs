'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=239935098,heart=239935093,mats=[900001171,900001172,900001173,900001174],blocker=900001175,probe=900001176,results=[];
 const control=process.argv.includes('--same-name')?'same-name':process.argv.includes('--no-heart')?'no-heart':process.argv.includes('--any-zone')?'any-zone':process.argv.includes('--no-banish')?'no-banish':process.argv.includes('--early-zone')?'early-zone':null;
 for(const test of [{},{duplicate:true},{wrongRace:true},{missingHeart:true},{blocked:true},{centerMaterial:true},{heartSpell:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:2,race:524288n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
  const cards=new Map(mats.map(code=>[code,{...base,code}]));cards.set(boss,candidateCard(boss));cards.set(heart,{...candidateCard(heart),type:test.heartSpell?0x20002:33});cards.set(blocker,{...base,code:blocker,race:1n});cards.set(probe,{...base,code:probe,type:2});if(test.wrongRace)cards.set(mats[3],{...cards.get(mats[3]),race:1n});
  const reader=name=>{
   if(name==='c'+probe+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local c=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,'+boss+'):GetFirst() if c:IsSummonType(SUMMON_TYPE_FUSION) and c:IsSummonLocation(LOCATION_EXTRA) then Duel.Hint(HINT_NUMBER,tp,701) end end) c:RegisterEffect(e) end';
   if([heart,blocker,...mats].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){
    if(control==='early-zone')lua=lua.replace('e:GetLabel()==1 and 0x4 or 0xff','0x4');if(control==='same-name')lua=lua.replace('others:GetClassCount(Card.GetCode)==4','true');
    if(control==='no-heart')lua=lua.replace('local hearts=g:Filter(Card.IsCode,nil,HEART)','local hearts=g:Clone()');
    if(control==='any-zone')lua=lua.replaceAll('LOCATION_REASON_TOFIELD,0x4','LOCATION_REASON_TOFIELD,0x1f').replace('e:GetLabel()==1 and 0x4 or 0xff','0xff');
    if(control==='no-banish')lua=lua.replace('Duel.Remove(sg,POS_FACEUP,REASON_COST+REASON_MATERIAL+REASON_FUSION)','do end');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,summoned=false,probed=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position:location===L.EXTRA?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK});
   add(boss,L.EXTRA);add(test.missingHeart?mats[0]:heart,test.heartSpell?L.SZONE:L.GRAVE);for(let i=0;i<4;i++)add(test.duplicate&&i===3?mats[2]:mats[i],test.centerMaterial&&i===0?L.MZONE:L.GRAVE,0,test.centerMaterial&&i===0?2:0);if(test.blocked)add(blocker,L.MZONE,0,2);add(probe,L.HAND);for(const p of [0,1])for(let i=0;i<8;i++)add(blocker,L.DECK,p);core.startDuel(duel);
   const query=(location)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.ATTACK|Q.DEFENSE,controller:0,location}).filter(Boolean);
   for(let step=0;step<180&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END,'Unexpected duel end');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){const eligible=!test.duplicate&&!test.wrongRace&&!test.missingHeart&&!test.blocked;if(!summoned){const index=p.special_summons.findIndex(c=>c.code===boss);assert.equal(index>=0,eligible,'Contact procedure eligibility');if(!eligible){done=true;continue;}summoned=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SPECIAL_SUMMON,index});continue;}const b=query(L.MZONE).find(c=>c.code===boss);assert(b,'Actual Fusion on field');const move=trace.find(m=>m.type===M.MOVE&&m.card===boss&&m.to.location===L.MZONE);assert(move,'Actual Extra-to-field movement');assert.equal(move.to.sequence,2,'Center zone');const removed=query(L.REMOVED);assert.equal(removed.length,5,'Five banished materials');for(const c of removed){assert(c.reason&0x80,'Material COST');assert(c.reason&8,'Material reason');assert(c.reason&0x40000,'Fusion material reason');}if(!probed){const index=p.activates.findIndex(c=>c.code===probe);assert(index>=0);probed=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}assert(trace.some(m=>m.type===M.HINT&&String(m.hint)==='701'),'Native Fusion summon type/Extra origin');done=true;}
    else if(p.type===M.SELECT_UNSELECT_CARD)core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index:p.can_finish?null:0});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else if(p.type===M.SELECT_PLACE){const mz=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0),location=mz===undefined?L.SZONE:L.MZONE,sequence=mz===undefined?[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0):mz;core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/swamp-hydra-fusion'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public OCGCore, complete production Hydra/candidate source; neutral materials/Heart script and probe. Actual contact Fusion selection, material banishment, center placement and native summon type. Native Omega unverified.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(c=>c.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
