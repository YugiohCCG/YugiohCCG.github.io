--Aerocat Lightning Shot
--Omega references: Solemn Strike (c40605147), Madolche Promenade (c68159562)
local s,id=GetID(); local SET_AEROCAT=0x3de1; local MSG_ID=133446105
function s.initial_effect(c) local e=Effect.CreateEffect(c); e:SetDescription(aux.Stringid(MSG_ID,0)); e:SetCategory(CATEGORY_NEGATE+CATEGORY_TODECK); e:SetType(EFFECT_TYPE_ACTIVATE); e:SetCode(EVENT_CHAINING); e:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH); e:SetCondition(s.con); e:SetTarget(s.tg); e:SetOperation(s.op); c:RegisterEffect(e) end
function s.one(c) return c:IsFaceup() and c:IsType(TYPE_XYZ) and c:IsRank(6) and c:IsAttribute(ATTRIBUTE_WIND) and c:GetOverlayCount()==1 end
function s.detach(c,tp) return c:IsFaceup() and c:IsType(TYPE_XYZ) and c:IsSetCard(SET_AEROCAT) and c:CheckRemoveOverlayCard(tp,1,REASON_EFFECT) end
function s.con(e,tp,eg,ep,ev,re,r,rp) return rp==1-tp and Duel.IsChainNegatable(ev) and Duel.IsExistingMatchingCard(s.one,tp,LOCATION_MZONE,0,1,nil) end
function s.tg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end Duel.SetOperationInfo(0,CATEGORY_NEGATE,eg,1,0,0) end
function s.op(e,tp,eg,ep,ev,re) if not Duel.NegateActivation(ev) then return end local g=Duel.GetMatchingGroup(s.detach,tp,LOCATION_MZONE,0,nil,tp); if #g>0 and Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,1)) then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVEXYZ); local tc=g:Select(tp,1,1,nil):GetFirst(); if tc:RemoveOverlayCard(tp,1,1,REASON_EFFECT)>0 then local rc=re:GetHandler(); if rc:IsRelateToEffect(re) then Duel.SendtoDeck(rc,nil,SEQ_DECKSHUFFLE,REASON_EFFECT) end end end end
