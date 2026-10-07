"use strict";
// Actual Lua callbacks, explicit action results. No permissive API stubs.
const fs=require('node:fs'),path=require('node:path');
const {pathToFileURL}=require('node:url');
const {execFileSync}=require('node:child_process');
const constants=fs.readFileSync(path.join(__dirname,'../tmp/omega_scripts/constant.lua'),'utf8');
async function main(){
 const entry=require.resolve('@n1xx1/ocgcore-wasm');
 const {default:createCore}=await import(pathToFileURL(path.join(path.dirname(entry),'dist/index.js')).href);
 const core=await createCore({sync:true,print(){},printErr(){}});
 let failed=0,total=0;
 for(const id of [212837324,236473882,253520299,256005703])
 for(const choice of [0,1]) for(const success of [0,1])
 for(const [canDeck,canRemove] of [[true,true],[true,false],[false,true],[false,false]]){
  total++;
  const logs=[];
  const duel=core.createDuel({flags:0n,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:1},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:1},cardReader:()=>null,scriptReader:()=>'',errorHandler:(type,message)=>logs.push({type,message})});
  try{
   const fixture=`
local script={}
function GetID() return script,${id} end
aux={Stringid=function(_,i) return i end,NecroValleyFilter=function(f) return f end}
local sent,removed,followup=0,0,0
local c={IsRelateToEffect=function() return true end,IsAbleToDeck=function() return ${canDeck} end,IsAbleToRemove=function() return ${canRemove} end}
local e={GetHandler=function() return c end}
Duel={
 SelectOption=function() return ${choice} end,
 SendtoDeck=function() sent=sent+1 return ${success} end,
 Remove=function() removed=removed+1 return ${success} end,
 GetLocationCount=function() return 1 end,
 GetMZoneCount=function() return 1 end,
 IsExistingMatchingCard=function() return true end,
 Hint=function() end,
 SelectMatchingCard=function() followup=followup+1 return {GetFirst=function() return nil end} end
}
`;
   const relative=`public/CCG Downloads/CCG_Scripts/c${id}.lua`;
   const source=process.argv.includes('--baseline')
    ? execFileSync('git',['show',`HEAD:${relative}`],{cwd:path.join(__dirname,'..'),encoding:'utf8'})
    : fs.readFileSync(path.join(__dirname,'..',relative),'utf8');
   const selected=canDeck&&canRemove?choice:canDeck?0:canRemove?1:-1;
   const test=`\nassert(script.${id===253520299?'rmtg':'sptg'}(e,0,nil,0,0,nil,0,0,0)==${canDeck||canRemove},'activation must require a legal exit')
script.${id===253520299?'rmop':'spop'}(e,0)
assert(sent==${selected===0?1:0},'unexpected return-to-deck attempts: '..sent)
assert(removed==${selected===1?1:0},'unexpected banish attempts: '..removed)
assert(followup==${selected<0?0:success},'follow-up must depend on chosen action success')`;
   const ok=core.loadScript(duel,`choice-${id}-${choice}-${success}`,constants+'\n'+fixture+source+test);
   if(!ok||logs.some(x=>x.type===0)){failed++;console.error('FAIL',id,{choice,success,canDeck,canRemove},logs);}
  }finally{core.destroyDuel(duel);}
 }
 if(failed)throw new Error(`${failed}/${total} scenarios failed`);
 console.log(`PASS all ${total} Galactica choice scenarios`);
}
main().catch(e=>{console.error(e);process.exitCode=1;});
