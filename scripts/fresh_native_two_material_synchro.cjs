'use strict';
// Neutral fixed two-card recipe using native summon-procedure effects. No global Lua API adapters.
exports.recipe=(tuner,nonTuner)=>`local s,id=GetID()
function s.materials(c,smat,mg)
 local tp=c:GetControler() local g=mg or Duel.GetMatchingGroup(Card.IsFaceup,tp,LOCATION_MZONE,0,nil)
 local t=g:Filter(Card.IsCode,nil,${tuner}):GetFirst() local n=g:Filter(Card.IsCode,nil,${nonTuner}):GetFirst()
 if not t or not n or not t:IsType(TYPE_TUNER) or n:IsType(TYPE_TUNER) or not t:IsCanBeSynchroMaterial(c) or not n:IsCanBeSynchroMaterial(c) or t:GetLevel()+n:GetLevel()~=c:GetLevel() or smat and smat:IsExists(function(mc) return mc~=t and mc~=n end,1,nil) then return nil end
 return Group.FromCards(t,n)
end
function s.initial_effect(c)
 c:EnableReviveLimit() local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_FIELD) e:SetCode(EFFECT_SPSUMMON_PROC) e:SetProperty(EFFECT_FLAG_UNCOPYABLE+EFFECT_FLAG_CANNOT_DISABLE) e:SetRange(LOCATION_EXTRA) e:SetValue(SUMMON_TYPE_SYNCHRO)
 e:SetCondition(function(e,c,smat,mg) return c==nil or s.materials(c,smat,mg)~=nil end)
 e:SetTarget(function(e,tp,eg,ep,ev,re,r,rp,chk,c,smat,mg) local g=s.materials(c,smat,mg) if not g then return false end g:KeepAlive() e:SetLabelObject(g) return true end)
 e:SetOperation(function(e,tp,eg,ep,ev,re,r,rp,c) local g=e:GetLabelObject() c:SetMaterial(g) Duel.SendtoGrave(g,REASON_MATERIAL+REASON_SYNCHRO) g:DeleteGroup() end) c:RegisterEffect(e)
end`;
