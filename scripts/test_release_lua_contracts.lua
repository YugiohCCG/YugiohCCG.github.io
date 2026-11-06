-- Regression contracts for printed mandatory triggers and persistent material restrictions.
local root=arg[1] or '.'
dofile(root..'/tmp/ohmen-reference/constant.lua')
local current,code
function GetID() current={} return current,code end
local function effect(handler)
 local e={handler=handler,values={}}
 return setmetatable(e,{__index=function(t,k)
  if k=='GetHandler' then return function(self) return self.handler end end
  if k=='Clone' then return function(self) local n=effect(self.handler) for a,b in pairs(self.values) do n.values[a]=b end return n end end
  if k:sub(1,3)=='Set' then return function(self,...) self.values[k]={...} end end
 end})
end
Effect={CreateEffect=effect}
Card={IsSetCard=function() return true end}
aux={Stringid=function(id,n) return id*16+n end,AddSynchroProcedure=function() end,AddXyzProcedure=function() end,AddFusionProcMixRep=function() end,
 FilterBoolFunction=function() return function() return true end end,NonTuner=function() return function() return true end end}
Duel={RegisterEffect=function() end}
local function loadcard(id)
 code=id;dofile(root..'/public/CCG Downloads/CCG_Scripts/c'..id..'.lua')
 local c={effects={},EnableReviveLimit=function() end,SetUniqueOnField=function() end,IsRelateToEffect=function() return true end}
 function c:RegisterEffect(e) self.effects[#self.effects+1]=e return true end
 current.initial_effect(c)
 return current,c
end
local _,soprana=loadcard(239934743)
assert(soprana.effects[1].values.SetType[1]&EFFECT_TYPE_TRIGGER_F~=0,'Soprana summon send is mandatory')
local _,terror=loadcard(238272434)
assert(terror.effects[4].values.SetType[1]&EFFECT_TYPE_TRIGGER_F~=0,'Terror Skull recovery is mandatory')
local _,jakarta=loadcard(247756272)
local proc=jakarta.effects[2]
proc.GetLabel=function() return 0 end
local summon,zone=proc.values.SetValue[1](proc)
assert(summon==SUMMON_TYPE_SYNCHRO and zone==0xff,'Jakarta alternate summon must count as Synchro')
proc.GetLabel=function() return 1 end
local _,failedzone=proc.values.SetValue[1](proc)
assert(failedzone==0,'Failed material payment cannot place Jakarta')
local s,c=loadcard(247755868)
local target={IsRelateToEffect=function() return true end,IsFaceup=function() return true end,GetLevel=function() return 4 end,RegisterEffect=function() return true end}
Duel.GetFirstTarget=function() return target end
local before=#c.effects
s.lvop({GetHandler=function() return c end,GetLabel=function() return 6 end},0)
assert(#c.effects==before+4,'All four Extra Deck material types must be restricted')
for i=before+1,#c.effects do
 assert(c.effects[i].values.SetReset[1]&RESET_PHASE==0,'Karkotaka material restriction has no unprinted End Phase expiration')
end
print('PASS release Lua regression contracts')
