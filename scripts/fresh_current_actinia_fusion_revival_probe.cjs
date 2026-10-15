'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=216258796,first=900001191,second=900001193,probe=900001195,water=900001197,filler=900001192;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 for(const test of [{},{level6:true},{wrongSet:true},{wrongRace:true},{wrongAttribute:true},{oneMaterial:true}]){
  const trace=[],logs=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:1000,defense:1200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[first,{...base,code:first,setcodes:test.wrongSet?[]:[0xf3c],level:test.level6?6:7}],[second,{...base,code:second,race:test.wrongRace?1n:64n,attribute:test.wrongAttribute?1:2}],[probe,{...base,code:probe,type:2}],[water,{...base,code:water,race:64n,attribute:2}],[filler,{...base,code:filler}]]);
  const reader=name=>{
   if(name==='c'+probe+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local fc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_EXTRA,0,nil,${boss}) local mg=Duel.GetFusionMaterial(tp) if not fc:CheckFusionMaterial(mg,nil,tp) then Duel.Hint(HINT_NUMBER,tp,700) return end local sg=Duel.SelectFusionMaterial(tp,fc,mg,nil,tp) fc:SetMaterial(sg) Duel.SendtoGrave(sg,REASON_EFFECT+REASON_MATERIAL+REASON_FUSION) Duel.BreakEffect() if Duel.SpecialSummon(fc,SUMMON_TYPE_FUSION,tp,tp,false,false,POS_FACEUP)>0 then fc:CompleteProcedure() if fc:IsSummonType(SUMMON_TYPE_FUSION) and fc:IsSummonLocation(LOCATION_EXTRA) then Duel.Hint(HINT_NUMBER,tp,701) end Duel.Destroy(fc,REASON_EFFECT) end end) c:RegisterEffect(e) end`;
   if([first,second,water,filler].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,'Missing '+name);return fs.readFileSync(file,'utf8');
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,done=false,activated=false,revived=false;const eligible=!Object.keys(test).length;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   const add=(code,location,sequence=0)=>core.duelNewCard(duel,{team:0,duelist:0,code,controller:0,location,sequence,position:location===L.EXTRA?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK});
   add(boss,L.EXTRA);add(first,L.HAND);if(!test.oneMaterial)add(second,L.HAND);add(probe,L.HAND);add(water,L.MZONE);for(const player of [0,1])for(let i=0;i<8;i++)core.duelNewCard(duel,{team:player,duelist:0,code:filler,controller:player,location:L.DECK,sequence:0,position:P.FACEDOWN_DEFENSE});core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,controller:0,location}).filter(Boolean);
   for(let step=0;step<160&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(!activated){const index=p.activates.findIndex(c=>c.code===probe);assert(index>=0);activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert.equal(trace.some(m=>m.type===M.HINT&&m.hint_type===9&&String(m.hint)==='701'),eligible,'Actual proper Fusion/Extra origin');if(!eligible){assert(query(L.EXTRA).some(c=>c.code===boss));done=true;continue;}
     assert.equal(query(L.GRAVE).filter(c=>c.code===first||c.code===second).length,2,'Real Fusion materials sent GY');
     if(!revived){assert(query(L.GRAVE).some(c=>c.code===boss));const index=p.special_summons.findIndex(c=>c.code===boss);assert(index>=0,'Properly Fusion Summoned source revival procedure');revived=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SPECIAL_SUMMON,index});continue;}
     assert(query(L.MZONE).some(c=>c.code===boss));assert.equal(trace.filter(m=>m.type===M.SPSUMMONED).length,2,'Actual Fusion then GY procedure');done=true;
    }else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else if(p.type===M.SELECT_UNSELECT_CARD)core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index:p.can_finish?null:0});
    else if(p.type===M.SELECT_CARD)core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:p.selects.map((_,i)=>i).slice(0,p.min)});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const mz=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<i))===0),location=mz===undefined?L.SZONE:L.MZONE,sequence=mz===undefined?[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0):mz;core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const sha=p=>crypto.createHash('sha256').update(fs.readFileSync(p)).digest('hex');
 const deps=[__filename,path.join(ROOT,'scripts/fresh_current_card.cjs'),path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'),path.join(ROOT,'output/fresh-ccg-september/current-spec-CCG_v1.db'),...['constant.lua','utility.lua','procedure.lua'].map(n=>path.join(ROOT,'tmp/omega_scripts',n)),...fs.readdirSync(path.join(ROOT,'node_modules/@n1xx1/ocgcore-wasm/dist')).filter(n=>n.endsWith('.js')).map(n=>path.join(ROOT,'node_modules/@n1xx1/ocgcore-wasm/dist',n))];
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-actinia-fusion-revival-probe.json'),JSON.stringify({adapter:null,scope:'Full current Actinia native CheckFusionMaterial/SelectFusionMaterial, real two neutral printed-category materials and actual FusionSummon before CompleteProcedure, native destruction then GY procedure. No seeded proper history or API adapters. Diagnostic until all native results inspected.',runtime_dependencies_sha256:Object.fromEntries(deps.map(p=>[path.relative(ROOT,p).replaceAll('\\','/'),sha(p)])),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
