'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),source=231088629,spell=900003811,target=900003812;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const sourceFile=path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+source+'.lua');
 for(const removeRelation of [false,true]){
  const trace=[],logs=[],neutral={alias:0,setcodes:[],type:17,level:1,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[source,candidateCard(source)],[spell,{...neutral,code:spell,type:2}],[target,{...neutral,code:target}]]);
  const reader=name=>{
   if(name==='c0.lua')return '';
   if(name==='c'+spell+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_HAND,0,nil,${target}) assert(Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)==1,"Actual recipient summon") end) c:RegisterEffect(e) end`;
   if(name==='c'+target+'.lua')return 'local s,id=GetID() function s.initial_effect(c) end';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(p=>fs.existsSync(p));assert(file,'Missing '+name);let lua=fs.readFileSync(file,'utf8');
   if(name==='c'+source+'.lua'&&removeRelation){assert(lua.includes('and tc:IsRelateToEffect(e) and Duel.MoveToField'));lua=lua.replace('and tc:IsRelateToEffect(e) and Duel.MoveToField','and Duel.MoveToField');}
   return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,done=false,activated=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,sequence=0,position=P.FACEDOWN_DEFENSE)=>core.duelNewCard(duel,{team:0,duelist:0,code,controller:0,location,sequence,position});
   add(source,L.MZONE,0,P.FACEUP_ATTACK);add(spell,L.HAND);add(target,L.HAND);for(let i=0;i<6;i++)add(spell,L.DECK);core.startDuel(duel);
   for(let step=0;step<150&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);assert(!logs.some(l=>l.type===0),JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!activated){const index=p.activates.findIndex(c=>c.code===spell);assert(index>=0);activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     const field=core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:0,location:L.SZONE}).filter(Boolean);
     logs.push({type:1,message:'Final SZONE '+JSON.stringify(field,(_,v)=>typeof v==='bigint'?String(v):v)});
     assert(trace.some(m=>m.type===M.SPSUMMONED),'Actual Special Summon processing');
     assert(field.some(c=>c.code===target),'Newly summoned monster must be placed in S/T Zone');done=true;
    }else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x7f)!==0x7f,shift=isMonster?0:8;const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(shift+i)))===0);assert(sequence!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({removeRelation,failure,logs,trace});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify({removeRelation,failure}));
 }
 const sha=file=>crypto.createHash('sha256').update(fs.readFileSync(file)).digest('hex');
 const runtime_dependencies_sha256=Object.fromEntries(['tmp/omega_scripts/constant.lua','tmp/omega_scripts/utility.lua','tmp/omega_scripts/procedure.lua','scripts/fresh_candidate_card.cjs','output/fresh-ccg-september/candidate-CCG_v1.db',...fs.readdirSync(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist')).filter(f=>f==='index.js'||f.endsWith('.wasm')).map(f=>path.relative(ROOT,path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist',f)))].map(f=>[f,sha(path.join(ROOT,f))]));
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/spherix-interception-diagnostic.json'),JSON.stringify({scope:'Full canonical Spherix initially fielded; actual neutral Spell Special Summons a neutral normal monster. Source and isolated removal of relation clause compared. Not full procedure or native Omega certification.',source_sha256:sha(sourceFile),harness_sha256:sha(__filename),runtime_dependencies_sha256,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
}main().catch(e=>{console.error(e);process.exitCode=1;});
