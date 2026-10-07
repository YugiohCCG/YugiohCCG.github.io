"use strict";
// Executes actual card callbacks in the core's Lua VM with explicit fixtures.
// This tests resolution decisions, not full engine timing or UI behavior.
const fs = require('node:fs');
const path = require('node:path');
const {pathToFileURL} = require('node:url');
async function main() {
  const entry = require.resolve('@n1xx1/ocgcore-wasm');
  const {default:createCore} = await import(pathToFileURL(path.join(path.dirname(entry),'dist/index.js')).href);
  const core = await createCore({sync:true,print(){},printErr(){}});
  let failed=0;
  for(const id of [259391738,259944344]) for(const relations of [[true],[false],[true,false],[false,false]]) {
    const logs=[];
    const duel=core.createDuel({flags:0n,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:1},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:1},cardReader:()=>null,scriptReader:()=>'',errorHandler:(type,message)=>logs.push({type,message})});
    try {
      const fixture=`
local script={}
function GetID() return script,${id} end
Card={IsAbleToDeck=function() return true end,IsRelateToEffect=function(c) return c.related end}
aux={NecroValleyFilter=function(f) return f end}
local group={}
function group:Filter(f,except,...)
 local result=setmetatable({},{__index=group})
 for _,c in ipairs(self) do if c~=except and f(c,...) then result[#result+1]=c end end
 return result
end
local targets=setmetatable({},{__index=group})
for _,related in ipairs({${relations.join(',')}}) do
 targets[#targets+1]={related=related,IsSetCard=function() return true end,IsType=function() return true end,IsAbleToHand=function() return true end,IsAbleToDeck=function() return true end,IsLocation=function() return true end}
end
local moved=0
Duel={GetChainInfo=function() return targets end,SendtoDeck=function(g) moved=#g return #g end,SendtoHand=function(g) moved=#g return #g end,IsExistingMatchingCard=function() return false end}
local effect={GetHandler=function() return {} end,GetLabel=function() return 10698416 end}
`;
      const source=fs.readFileSync(path.join(__dirname,'../public/CCG Downloads/CCG_Scripts',`c${id}.lua`),'utf8');
      const assertion=`\nscript.${id===259391738?'tdop':'cpop'}(effect,0)\nassert(moved==${relations.filter(Boolean).length},'expected only related targets to move; got '..moved)\n`;
      const ok=core.loadScript(duel,`resolution-${id}-${relations.join('-')}`,fixture+'\n'+source+assertion);
      if(!ok || logs.some(x=>x.type===0)) { failed++; console.error('FAIL',id,relations,logs); }
      else console.log('PASS',id,relations);
    } finally {core.destroyDuel(duel);}
  }
  if(failed) throw new Error(`${failed} resolution scenarios failed`);
}
main().catch(error=>{console.error(error);process.exitCode=1;});
