-- Bounded source callbacks/legacy registration only, not native chain proof.
dofile('tmp/omega_scripts/constant.lua')
local s,id={},213611313;GetID=function() return s,id end
Card={};aux={AddLinkProcedure=function() end,FilterBoolFunction=function() return function() end end,Stringid=function(_,n) return n end}
local effects={};Effect={CreateEffect=function() local e={} return setmetatable(e,{__index=function(t,k) return function(self,...) self[k]={...} end end}) end}
local c={EnableReviveLimit=function() end,SetUniqueOnField=function() end,RegisterEffect=function(_,e) effects[#effects+1]=e end}
local f=assert(io.open('public/CCG Downloads/CCG_Scripts/c213611313.lua'));local body=f:read('*a');f:close()
if arg[1]=='--no-chain-flag' then body=body:gsub('id%+100%+EFFECT_COUNT_CODE_CHAIN','id+100') end
if arg[1]=='--low-threshold' then body=body:gsub('ev>=5','ev>=1') end
assert(load(body))();s.initial_effect(c)
local passed=0;local function check(x,message) assert(x,message);passed=passed+1 end
check(#effects==3,'Three declared effects')
check(effects[2].SetCountLimit[1]==1 and effects[2].SetCountLimit[2]==id,'Named Hand summon turn count')
local count=effects[3].SetCountLimit
check(count[1]==1 and (count[2]&EFFECT_COUNT_CODE_CHAIN)~=0,'Legacy chain count flag')
check((count[2]&~EFFECT_COUNT_CODE_CHAIN)==id+100,'Separate named GY count key')
check(effects[3].SetRange[1]==LOCATION_GRAVE,'GY effect range')
check(effects[3].SetCode[1]==EVENT_CHAINING,'Chain response event')
for link=0,8 do check(effects[3].SetCondition[1](nil,0,nil,0,link)==(link>=5),'Exact Chain Link5 threshold') end
local e={GetHandler=function() return c end}
for n=1,3 do s.atkop(e);local update=effects[#effects];check(update.SetCode[1]==EFFECT_UPDATE_ATTACK and update.SetValue[1]==300,'Each resolution adds300') end
print('PASS '..passed..' bounded Crawler assertions')
