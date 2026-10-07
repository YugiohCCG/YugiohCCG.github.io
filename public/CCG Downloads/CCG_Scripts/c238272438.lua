--Terror Blossom from Underroot
--Omega patterns: c101204038 (alternate Extra Deck procedure), c100245006 (Fusion restriction).
local s,id=GetID()
local SET_RROOT=0xA110
local SET_UNDERROOT=0xA111
local MSG_ID=132272438
function s.initial_effect(c)
 c:EnableReviveLimit()
 aux.AddFusionProcMixRep(c,true,true,aux.FilterBoolFunction(Card.IsSetCard,SET_RROOT),2,2)
 local p=Effect.CreateEffect(c)
 p:SetType(EFFECT_TYPE_FIELD)
 p:SetCode(EFFECT_SPSUMMON_PROC)
 p:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
 p:SetRange(LOCATION_EXTRA)
 p:SetCondition(s.altcon)
 p:SetOperation(s.altop)
 c:RegisterEffect(p)
 local limit=Effect.CreateEffect(c)
 limit:SetType(EFFECT_TYPE_SINGLE)
 limit:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
 limit:SetCode(EFFECT_SPSUMMON_CONDITION)
 limit:SetValue(aux.fuslimit)
 c:RegisterEffect(limit)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH)
 e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e1:SetProperty(EFFECT_FLAG_DELAY)
 e1:SetCode(EVENT_SPSUMMON_SUCCESS)
 e1:SetCountLimit(1,id)
 e1:SetTarget(s.thtg)
 e1:SetOperation(s.thop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_REMOVE+CATEGORY_TOGRAVE)
 e2:SetType(EFFECT_TYPE_QUICK_O)
 e2:SetCode(EVENT_FREE_CHAIN)
 e2:SetRange(LOCATION_MZONE)
 e2:SetProperty(EFFECT_FLAG_CARD_TARGET)
 e2:SetCountLimit(1,id+100)
 e2:SetTarget(s.swaptg)
 e2:SetOperation(s.swapop)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetDescription(aux.Stringid(MSG_ID,2))
 e3:SetCategory(CATEGORY_TOGRAVE+CATEGORY_SPECIAL_SUMMON)
 e3:SetType(EFFECT_TYPE_QUICK_O)
 e3:SetCode(EVENT_FREE_CHAIN)
 e3:SetRange(LOCATION_MZONE)
 e3:SetProperty(EFFECT_FLAG_CARD_TARGET)
 e3:SetHintTiming(0,TIMING_ATTACK)
 e3:SetCondition(s.batcon)
 e3:SetTarget(s.battg)
 e3:SetOperation(s.batop)
 c:RegisterEffect(e3)
end
function s.altfilter(c,fc)
 return c:IsSetCard(SET_RROOT) and c:IsType(TYPE_MONSTER)
  and c:IsCanBeFusionMaterial(fc,SUMMON_TYPE_SPECIAL) and c:IsAbleToRemoveAsCost()
end
function s.altcon(e,c)
 if c==nil then return true end
 local tp=c:GetControler()
 return Duel.GetFlagEffect(tp,id)==0 and Duel.GetLocationCountFromEx(tp)>0
  and Duel.IsExistingMatchingCard(s.altfilter,tp,LOCATION_GRAVE,0,2,nil,c)
end
function s.altop(e,tp,eg,ep,ev,re,r,rp,c)
 local g=Duel.GetMatchingGroup(s.altfilter,tp,LOCATION_GRAVE,0,nil,c)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
 local sg=g:Select(tp,2,2,nil)
 c:SetMaterial(sg)
 Duel.Remove(sg,POS_FACEUP,REASON_COST+REASON_MATERIAL)
 Duel.RegisterFlagEffect(tp,id,RESET_PHASE+PHASE_END,0,1)
end
function s.thfilter(c)
 return (c:IsSetCard(SET_UNDERROOT) or c:IsCode(11110218)) and c:IsAbleToHand()
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.thfilter,tp,LOCATION_DECK,0,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
end
function s.thop(e,tp)
 if not Duel.IsExistingMatchingCard(s.thfilter,tp,LOCATION_DECK,0,1,nil) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
 local g=Duel.SelectMatchingCard(tp,s.thfilter,tp,LOCATION_DECK,0,1,1,nil)
 if #g>0 and Duel.SendtoHand(g,nil,REASON_EFFECT)>0 then Duel.ConfirmCards(1-tp,g) end
end
function s.swapfilter(c,e)
 return c:IsCanBeEffectTarget(e)
  and (c:IsLocation(LOCATION_GRAVE) and c:IsAbleToRemove()
   or c:IsLocation(LOCATION_REMOVED) and c:IsAbleToGrave())
end
function s.swaptg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 if chkc then return chkc:IsControler(1-tp) and chkc:IsLocation(LOCATION_GRAVE+LOCATION_REMOVED) and s.swapfilter(chkc,e) end
 if chk==0 then return Duel.IsExistingTarget(s.swapfilter,tp,0,LOCATION_GRAVE+LOCATION_REMOVED,1,nil,e) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
 local g=Duel.SelectTarget(tp,s.swapfilter,tp,0,LOCATION_GRAVE+LOCATION_REMOVED,1,3,nil,e)
 g:KeepAlive()
 e:SetLabelObject(g)
 Duel.SetOperationInfo(0,CATEGORY_REMOVE,g,g:GetCount(),1-tp,LOCATION_GRAVE)
end
function s.swapop(e,tp)
 local kept=e:GetLabelObject()
 if not kept then return end
 e:SetLabelObject(nil)
 local g=kept:Filter(Card.IsRelateToEffect,nil,e)
 kept:DeleteGroup()
 local fromGY=g:Filter(Card.IsLocation,nil,LOCATION_GRAVE)
 local fromBanish=g:Filter(Card.IsLocation,nil,LOCATION_REMOVED)
 if #fromGY>0 then Duel.Remove(fromGY,POS_FACEUP,REASON_EFFECT) end
 if #fromBanish>0 then Duel.SendtoGrave(fromBanish,REASON_EFFECT+REASON_RETURN) end
end
function s.battlemonster(c,tp)
 local a=Duel.GetAttacker()
 local d=Duel.GetAttackTarget()
 local other=a==c and d or d==c and a or nil
 if other and other:IsControler(1-tp) then return other end
end
function s.batcon(e,tp)
 return Duel.IsBattlePhase() and s.battlemonster(e:GetHandler(),tp)~=nil
end
function s.battg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 local tc=s.battlemonster(e:GetHandler(),tp)
 if chkc then return chkc==tc and tc:IsCanBeEffectTarget(e) and tc:IsAbleToGrave() end
 if chk==0 then return tc and tc:IsCanBeEffectTarget(e) and tc:IsAbleToGrave()
  and Duel.IsExistingMatchingCard(s.revivefilter,1-tp,LOCATION_GRAVE,0,1,nil,e,tp,tc:GetCode()) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
 Duel.SetTargetCard(tc)
 Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,tc,1,1-tp,LOCATION_MZONE)
end
function s.revivefilter(c,e,tp,oldcode)
 return not c:IsCode(oldcode) and c:IsType(TYPE_MONSTER)
  and c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEUP_DEFENSE,1-tp)
end
function s.batop(e,tp)
 local tc=Duel.GetFirstTarget()
 if not tc or not tc:IsRelateToEffect(e) then return end
 local oldcode=tc:GetCode()
 if Duel.SendtoGrave(tc,REASON_EFFECT)==0 then return end
 local opp=1-tp
 if Duel.GetLocationCount(opp,LOCATION_MZONE)<=0
  or not Duel.IsExistingMatchingCard(s.revivefilter,opp,LOCATION_GRAVE,0,1,nil,e,tp,oldcode) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
 local g=Duel.SelectMatchingCard(tp,s.revivefilter,opp,LOCATION_GRAVE,0,1,1,nil,e,tp,oldcode)
 local sc=g:GetFirst()
 if sc then Duel.SpecialSummon(sc,0,tp,opp,false,false,POS_FACEUP_DEFENSE) end
end
