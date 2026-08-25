--Divinity to Infinity
--Omega references: Transaction Rollback (c6351147)
local s,id=GetID(); local STRING_ID=133384841
function s.initial_effect(c)
 local e=Effect.CreateEffect(c); e:SetDescription(aux.Stringid(STRING_ID,0)); e:SetType(EFFECT_TYPE_ACTIVATE); e:SetCode(EVENT_FREE_CHAIN); e:SetProperty(EFFECT_FLAG_CARD_TARGET); e:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH); e:SetTarget(s.tg); e:SetOperation(s.op); c:RegisterEffect(e)
 local e2=Effect.CreateEffect(c); e2:SetType(EFFECT_TYPE_SINGLE); e2:SetCode(EFFECT_TRAP_ACT_IN_HAND); e2:SetCondition(function(e) return Duel.GetTurnPlayer()==e:GetHandlerPlayer() end); c:RegisterEffect(e2)
end
function s.filter(c) return c:IsSpellTrap() and c:GetTurnID()~=Duel.GetTurnCount() and c:IsAbleToRemove() and c:CheckActivateEffect(false,true,false)~=nil end
function s.tg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 if chkc then local te=e:GetLabelObject(); local tg=te and te:GetTarget(); return tg and tg(e,tp,eg,ep,ev,re,r,rp,0,chkc) end
 if chk==0 then return Duel.IsExistingTarget(s.filter,tp,0,LOCATION_GRAVE,1,nil) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE); local g=Duel.SelectTarget(tp,s.filter,tp,0,LOCATION_GRAVE,1,1,nil); local tc=g:GetFirst(); local te,ceg,cep,cev,cre,cr,crp=tc:CheckActivateEffect(false,true,true)
 Duel.ClearTargetCard(); tc:CreateEffectRelation(e); e:SetProperty(te:GetProperty()); local tg=te:GetTarget(); if tg then tg(e,tp,ceg,cep,cev,cre,cr,crp,1) end; te:SetLabelObject(e:GetLabelObject()); e:SetLabelObject(te); Duel.ClearOperationInfo(0); Duel.SetOperationInfo(0,CATEGORY_REMOVE,tc,1,0,0)
end
function s.op(e,tp,eg,ep,ev,re,r,rp) local te=e:GetLabelObject(); if not te then return end local tc=te:GetHandler(); if not tc:IsRelateToEffect(e) or Duel.Remove(tc,POS_FACEUP,REASON_EFFECT)==0 or not tc:IsLocation(LOCATION_REMOVED) then return end e:SetLabelObject(te:GetLabelObject()); local op=te:GetOperation(); if op then op(e,tp,eg,ep,ev,re,r,rp) end end
