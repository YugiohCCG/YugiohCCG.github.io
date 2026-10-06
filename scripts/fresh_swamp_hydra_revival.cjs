'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=239935098,token=239935103,victim=900001161,spell=900001162,filler=900001163,results=[];
 const control=process.argv.includes('--no-revival')?'no-revival':process.argv.includes('--any-zone')?'any-zone':process.argv.includes('--no-token')?'no-token':process.argv.includes('--ignore-procedure')?'ignore-procedure':null;
 for(const test of [{},{removed:true},{blocked:true},{facedown:true},{improper:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:2,race:524288n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[token,candidateCard(token)],[victim,{...base,code:victim,race:test.wrongRace?1n:524288n}],[spell,{...base,code:spell,type:2}],[filler,{...base,code:filler,race:1n}]]);
  const reader=name=>{
   if(name==='c'+spell+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local c=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE+LOCATION_EXTRA,0,nil,'+boss+'):GetFirst() '+(test.improper?'':'c:CompleteProcedure() ')+(test.removed||test.facedown?'Duel.Remove(c,'+(test.facedown?'POS_FACEDOWN':'POS_FACEUP')+',REASON_EFFECT)':'Duel.SendtoGrave(c,REASON_EFFECT)')+' local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,'+victim+') Duel.Destroy(g,REASON_EFFECT) end) c:RegisterEffect(e) end';
   if([victim,filler,token].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){if(control==='ignore-procedure')lua=lua.replaceAll('false,false,POS_FACEUP','true,true,POS_FACEUP');if(control==='no-revival')lua=lua.replace('Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP,0x4)','0');if(control==='any-zone')lua=lua.replaceAll('LOCATION_REASON_TOFIELD,0x4','LOCATION_REASON_TOFIELD,0x1f').replaceAll('POS_FACEUP,tp,0x4','POS_FACEUP,tp,0x1f').replaceAll('POS_FACEUP,0x4','POS_FACEUP,0x1f');if(control==='no-token')lua=lua.replace('Duel.SpecialSummonStep(token,0,tp,tp,false,false,POS_FACEUP)','do end');}return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position:P.FACEUP_ATTACK});
   add(boss,test.improper?L.EXTRA:L.MZONE);add(victim,L.MZONE,0,1);if(test.blocked)add(filler,L.MZONE,0,2);add(spell,L.HAND);for(const p of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,p);core.startDuel(duel);
   const query=()=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.ATTACK|Q.DEFENSE,controller:0,location:L.MZONE}).filter(Boolean);
   for(let step=0;step<160&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END,'Unexpected duel end');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){const field=query(),b=field.find(c=>c.code===boss);if(activated){const eligible=!test.blocked&&!test.facedown&&!test.improper;assert.equal(!!b,eligible,'Revival availability');assert.equal(field.filter(c=>c.code===token).length,eligible?1:0,'Follow-up token count');if(eligible){const moves=trace.filter(m=>m.type===M.MOVE&&m.card===boss&&m.to.location===L.MZONE);assert.equal(moves.length,1,'Actual source revival');assert.equal(moves[0].to.sequence,2,'Center zone');assert.equal(b.attack,1800,'Revived ATK');assert.equal(b.defense,1800,'Revived DEF');}assert(!field.some(c=>c.code===victim),'Victim destroyed');done=true;continue;}const stats=1800;if(!test.improper){assert.equal(b.attack,stats,'Initial ATK');assert.equal(b.defense,stats,'Initial DEF');}const index=p.activates.findIndex(c=>c.code===spell);assert(index>=0);activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===boss);core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
    else if(p.type===M.SELECT_PLACE){const mz=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0),location=mz===undefined?L.SZONE:L.MZONE,sequence=mz===undefined?[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0):mz;core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/swamp-hydra-revival'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public OCGCore, complete production Hydra/candidate metadata and Hydra Head token. Neutral fixture explicitly CompleteProcedure then moves full source to GY/banishment before actual victim destruction. Actual center revival and follow-up token, blocked center/face-down exclusions. Actual first Fusion/native Omega unverified.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(c=>c.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
