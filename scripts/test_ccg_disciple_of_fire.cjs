"use strict";
const fs = require('node:fs');
const path = require('node:path');
const {pathToFileURL} = require('node:url');
const root=path.resolve(__dirname,'..');
const source=fs.readFileSync(path.join(root,'public/CCG Downloads/CCG_Scripts/c259023461.lua'),'utf8');
const constants=fs.readFileSync(path.join(root,'tmp/omega_scripts/constant.lua'),'utf8');
const fixture=`
local script={}
function GetID() return script,259023461 end
local id=259023461
local flags,cardflags={},{}
local choice=0
local allowDiscard=true
local allowSummon=true
local acceptRecovery=false
local recovery,questions=0,0
local successfulDiscard=false
local added,discarded=0,0
local c={}
function c:GetFlagEffect(k) return cardflags[k] or 0 end
function c:RegisterFlagEffect(k) cardflags[k]=1 end
function c:IsCanBeSpecialSummoned() return allowSummon end
function c:IsRelateToEffect() return true end
function c:RegisterEffect() end
local e={label=0}
function e:GetHandler() return c end
function e:SetLabel(v) self.label=v end
function e:GetLabel() return self.label end
Card={IsDiscardable=function() return true end}
aux={NecroValleyFilter=function(f) return f or function() return true end end,Stringid=function(_,v) return v end}
local setters={SetType=true,SetCode=true,SetProperty=true,SetReset=true,SetValue=true}
Effect={CreateEffect=function() return setmetatable({},{__index=function(_,k) assert(setters[k],k) return function() end end}) end}
Duel={
 GetFlagEffect=function(_,k) return flags[k] or 0 end,
 RegisterFlagEffect=function(_,k) flags[k]=1 end,
 IsExistingMatchingCard=function() return allowDiscard end,
 GetLocationCount=function() return 1 end,
 SelectOption=function() return choice end,
 SetOperationInfo=function() end,
 Hint=function() end,
 SelectMatchingCard=function() return successfulDiscard and {{}} or {} end,
 SendtoGrave=function(g) discarded=discarded+#g return #g end,
 SendtoHand=function(g) added=added+#g return #g end,
 ConfirmCards=function() end,
 SpecialSummon=function() return 1 end,
 SelectYesNo=function() questions=questions+1 return acceptRecovery end,
 Recover=function(_,v) recovery=recovery+v end
}
`;
const setup='\nscript[0]=1000; script[1]=0\n';
const scenarios=[
 ['discard use consumed on activation',`choice=0; script.paytg(e,0,nil,0,0,nil,0,0,1); assert(flags[id+100]==1,'discard use not consumed'); assert(cardflags[id]==1,'once in GY not consumed')`],
 ['summon use consumed on activation',`choice=1; script.paytg(e,0,nil,0,0,nil,0,0,1); assert(flags[id+101]==1,'summon use not consumed')`],
 ['discard cannot queue twice',`allowSummon=false; script.paytg(e,0,nil,0,0,nil,0,0,1); assert(not script.paytg(e,0,nil,0,0,nil,0,0,0),'second discard activation allowed')`],
 ['summon cannot queue twice',`allowDiscard=false; script.paytg(e,0,nil,0,0,nil,0,0,1); assert(not script.paytg(e,0,nil,0,0,nil,0,0,0),'second summon activation allowed')`],
 ['failed discard still consumes use',`allowSummon=false; script.paytg(e,0,nil,0,0,nil,0,0,1); script.payop(e,0); assert(flags[id+100]==1 and cardflags[id]==1,'failed resolution refunded use')`],
 ['decline recovery',`e.label=1; script.payop(e,0); assert(recovery==0,'optional recovery forced'); assert(questions==1,'recovery choice missing')`],
 ['accept recovery',`acceptRecovery=true; e.label=1; script.payop(e,0); assert(recovery==500,'wrong recovery'); assert(questions==1,'recovery choice missing')`],
 ['zero recovery gives no prompt',`script[0]=0; e.label=1; script.payop(e,0); assert(recovery==0 and questions==0)`],
 ['legality check does not consume use',`assert(script.paytg(e,0,nil,0,0,nil,0,0,0)); assert(next(flags)==nil and next(cardflags)==nil)`],
 ['reserved discard still resolves',`successfulDiscard=true; allowSummon=false; script.paytg(e,0,nil,0,0,nil,0,0,1); script.payop(e,0); assert(discarded==1 and added==1,'reservation prevented resolution')`],
 ['discard use persists during same GY stay next turn',`allowSummon=false; script.paytg(e,0,nil,0,0,nil,0,0,1); flags={}; assert(not script.paytg(e,0,nil,0,0,nil,0,0,0),'once in GY reset at end of turn')`],
 ['GY reentry does not refund same-turn discard use',`allowSummon=false; script.paytg(e,0,nil,0,0,nil,0,0,1); cardflags={}; assert(not script.paytg(e,0,nil,0,0,nil,0,0,0),'same-turn usage refunded on reentry')`],
 ['new turn and GY stay allow discard again',`allowSummon=false; script.paytg(e,0,nil,0,0,nil,0,0,1); flags={}; cardflags={}; assert(script.paytg(e,0,nil,0,0,nil,0,0,0))`],
 ['branches have separate uses',`choice=0; script.paytg(e,0,nil,0,0,nil,0,0,1); assert(script.paytg(e,0,nil,0,0,nil,0,0,0)); script.paytg(e,0,nil,0,0,nil,0,0,1); assert(e.label==1 and flags[id+100]==1 and flags[id+101]==1); assert(not script.paytg(e,0,nil,0,0,nil,0,0,0))`],
];
async function main(){
 const entry=require.resolve('@n1xx1/ocgcore-wasm');
 const {default:createCore}=await import(pathToFileURL(path.join(path.dirname(entry),'dist/index.js')).href);
 const core=await createCore({sync:true,print(){},printErr(){}});
 let failed=0;
 for(const [name,test] of scenarios){
  const logs=[];
  const duel=core.createDuel({flags:0n,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:1},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:1},cardReader:()=>null,scriptReader:()=>'',errorHandler:(type,message)=>logs.push({type,message})});
  try{
   const ok=core.loadScript(duel,name,constants+'\n'+fixture+'\n'+source+setup+test);
   if(!ok||logs.some(x=>x.type===0)){failed++;console.error('FAIL',name,logs);}else console.log('PASS',name);
  }finally{core.destroyDuel(duel);}
 }
 if(failed)throw new Error(`${failed}/${scenarios.length} scenarios failed`);
}
main().catch(e=>{console.error(e);process.exitCode=1;});
