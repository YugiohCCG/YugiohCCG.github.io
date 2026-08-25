--Lord of the Pyre
--Omega references: Link Disciple (c32995276), Decode Talker (c01861629)
local s,id=GetID(); local SET_PYRE=0x3135
function s.initial_effect(c)
 c:EnableReviveLimit(); aux.AddLinkProcedure(c,aux.FilterBoolFunction(Card.IsRace,RACE_PYRO),2,2)
 c:SetUniqueOnField(1,0,id)
 local e1=Effect.CreateEffect(c); e1:SetType(EFFECT_TYPE_FIELD); e1:SetCode(EFFECT_UNRELEASABLE_SUM); e1:SetRange(LOCATION_MZONE); e1:SetTargetRange(LOCATION_MZONE,0); e1:SetTarget(s.protected); e1:SetValue(s.limit); c:RegisterEffect(e1)
 local e2=e1:Clone(); e2:SetCode(EFFECT_UNRELEASABLE_NONSUM); e2:SetValue(1); c:RegisterEffect(e2)
 local e3=e1:Clone(); e3:SetCode(EFFECT_CANNOT_BE_LINK_MATERIAL); c:RegisterEffect(e3)
 local e3b=Effect.CreateEffect(c); e3b:SetType(EFFECT_TYPE_FIELD); e3b:SetCode(EFFECT_CANNOT_SELECT_BATTLE_TARGET); e3b:SetRange(LOCATION_MZONE); e3b:SetTargetRange(LOCATION_MZONE,0); e3b:SetTarget(s.linked); e3b:SetValue(s.atklimit); c:RegisterEffect(e3b)
 local e4=Effect.CreateEffect(c); e4:SetType(EFFECT_TYPE_SINGLE); e4:SetCode(EFFECT_UPDATE_ATTACK); e4:SetCondition(s.atkcon); e4:SetValue(s.atkval); c:RegisterEffect(e4)
 local e5=Effect.CreateEffect(c); e5:SetType(EFFECT_TYPE_SINGLE); e5:SetCode(EFFECT_INDESTRUCTABLE_BATTLE); e5:SetCondition(s.atkcon); e5:SetValue(1); c:RegisterEffect(e5)
 local e6=Effect.CreateEffect(c); e6:SetCategory(CATEGORY_DESTROY); e6:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O); e6:SetCode(EVENT_REMOVE); e6:SetRange(LOCATION_MZONE); e6:SetProperty(EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY); e6:SetCondition(s.descon); e6:SetTarget(s.destg); e6:SetOperation(s.desop); c:RegisterEffect(e6)
end
function s.linked(e,c) return e:GetHandler():GetLinkedGroup():IsContains(c) end
function s.protected(e,c) return c==e:GetHandler() or s.linked(e,c) end
function s.limit(e,c) return not c:IsRace(RACE_PYRO) end
function s.atklimit(e,c) return c:IsRace(RACE_PYRO) end
function s.atkcon(e) return e:GetHandler():GetLinkedGroup():IsExists(Card.IsRace,1,nil,RACE_PYRO) end
function s.atkval(e) return e:GetHandler():GetLinkedGroupCount()*1000 end
function s.descon(e,tp,eg) return eg:IsExists(function(c) return c:IsSetCard(SET_PYRE) and c:IsSpell() end,1,nil) end
function s.df(c) return c:IsDestructable() end
function s.destg(e,tp,eg,ep,ev,re,r,rp,chk,chkc) if chkc then return chkc:IsControler(1-tp) and chkc:IsLocation(LOCATION_ONFIELD) and s.df(chkc) end if chk==0 then return Duel.IsExistingTarget(s.df,tp,0,LOCATION_ONFIELD,1,nil) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY); local g=Duel.SelectTarget(tp,s.df,tp,0,LOCATION_ONFIELD,1,1,nil); Duel.SetOperationInfo(0,CATEGORY_DESTROY,g,1,0,0) end
function s.desop(e) local tc=Duel.GetFirstTarget(); if tc:IsRelateToEffect(e) then Duel.Destroy(tc,REASON_EFFECT) end end
