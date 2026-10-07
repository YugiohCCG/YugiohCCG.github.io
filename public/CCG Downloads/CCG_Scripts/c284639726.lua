--Terrarumian Venus Flytrap
local s,id=GetID()
local SET_TERRARUMIAN=0xa122
local MSG_ID=132639726
function s.initial_effect(c)
 aux.AddLinkProcedure(c,aux.FilterBoolFunction(Card.IsRace,RACE_PLANT),2,99,s.matcheck)
 c:EnableReviveLimit()
 local e0=Effect.CreateEffect(c)
 e0:SetType(EFFECT_TYPE_SINGLE)
 e0:SetCode(EFFECT_CANNOT_BE_BATTLE_TARGET)
 e0:SetProperty(EFFECT_FLAG_SINGLE_RANGE)
 e0:SetRange(LOCATION_MZONE)
 e0:SetCondition(s.protect)
 e0:SetValue(aux.imval1)
 c:RegisterEffect(e0)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_DESTROY+CATEGORY_DRAW)
 e1:SetType(EFFECT_TYPE_QUICK_O)
 e1:SetCode(EVENT_FREE_CHAIN)
 e1:SetRange(LOCATION_MZONE)
 e1:SetProperty(EFFECT_FLAG_CARD_TARGET)
 e1:SetCountLimit(1,id)
 e1:SetCondition(s.drawcon)
 e1:SetTarget(s.drawtg)
 e1:SetOperation(s.drawop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_DESTROY)
 e2:SetType(EFFECT_TYPE_IGNITION)
 e2:SetRange(LOCATION_MZONE)
 e2:SetProperty(EFFECT_FLAG_CARD_TARGET)
 e2:SetCountLimit(1,id+100)
 e2:SetCondition(s.chaincon)
 e2:SetTarget(s.destg)
 e2:SetOperation(s.desop)
 c:RegisterEffect(e2)
end
s.listed_series={SET_TERRARUMIAN}
function s.matcheck(g)
 return g:IsExists(function(c) return c:IsSetCard(SET_TERRARUMIAN) and c:IsType(TYPE_PENDULUM) end,1,nil)
end
function s.protect(e)
 return e:GetHandler():GetLinkedGroup():IsExists(function(c)
  return c:IsFaceup() and c:IsDefensePos() and c:IsSetCard(SET_TERRARUMIAN) and c:IsType(TYPE_PENDULUM)
 end,1,nil)
end
function s.chaincon(e)
 return e:GetHandler():GetFlagEffect(id)==0
end
function s.drawcon(e)
 return s.chaincon(e) and (Duel.GetCurrentPhase()==PHASE_MAIN1 or Duel.GetCurrentPhase()==PHASE_MAIN2)
end
function s.drawfilter(c)
 return c:IsSetCard(SET_TERRARUMIAN) and c:IsDestructable()
end
function s.drawtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_ONFIELD) and s.drawfilter(chkc) end
 if chk==0 then return Duel.IsPlayerCanDraw(tp,1)
  and Duel.IsExistingTarget(s.drawfilter,tp,LOCATION_ONFIELD,0,1,nil) end
 e:GetHandler():RegisterFlagEffect(id,RESET_CHAIN,0,1)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
 local g=Duel.SelectTarget(tp,s.drawfilter,tp,LOCATION_ONFIELD,0,1,1,nil)
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,g,1,0,0)
 Duel.SetOperationInfo(0,CATEGORY_DRAW,nil,1,tp,1)
end
function s.drawop(e,tp)
 local tc=Duel.GetFirstTarget()
 if tc and tc:IsRelateToEffect(e) and Duel.Destroy(tc,REASON_EFFECT)>0 then Duel.Draw(tp,1,REASON_EFFECT) end
end
function s.linkfilter(c)
 return c:IsFaceup() and c:IsType(TYPE_MONSTER) and c:IsSetCard(SET_TERRARUMIAN) and c:IsDestructable()
end
function s.destg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 local linked=e:GetHandler():GetLinkedGroup():Filter(function(c) return s.linkfilter(c) and c:IsCanBeEffectTarget(e) end,nil)
 if chkc then return chkc:IsOnField() and chkc:IsDestructable() end
 if chk==0 then return linked:IsExists(function(c)
  return Duel.IsExistingTarget(Card.IsDestructable,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,c)
 end,1,nil) end
 e:GetHandler():RegisterFlagEffect(id,RESET_CHAIN,0,1)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
 local first=linked:Select(tp,1,1,nil)
 Duel.SetTargetCard(first)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY)
 local second=Duel.SelectTarget(tp,Card.IsDestructable,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,1,first:GetFirst())
 first:Merge(second)
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,first,2,0,0)
end
function s.desop(e,tp)
 local g=Duel.GetChainInfo(0,CHAININFO_TARGET_CARDS):Filter(Card.IsRelateToEffect,nil,e)
 if #g>0 then Duel.Destroy(g,REASON_EFFECT) end
end
