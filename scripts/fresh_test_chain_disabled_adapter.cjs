'use strict';
// Test-only query compatibility. Observes actual core events; changes no effect.
exports.lua=`assert(Duel.IsChainDisabled==nil)
local disabled={}
local mark=Effect.GlobalEffect()
mark:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
mark:SetCode(EVENT_CHAIN_DISABLED)
mark:SetOperation(function(e,tp,eg,ep,ev) disabled[ev]=true end)
Duel.RegisterEffect(mark,0)
local clear=Effect.GlobalEffect()
clear:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
clear:SetCode(EVENT_CHAIN_END)
clear:SetOperation(function() disabled={} end)
Duel.RegisterEffect(clear,0)
Duel.IsChainDisabled=function(ev) return disabled[ev] or false end`;
