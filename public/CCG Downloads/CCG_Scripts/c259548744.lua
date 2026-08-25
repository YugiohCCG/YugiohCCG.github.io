--Navi the NAV Hawk Aerocat
--Omega references: Daigusto Emeral (c581014), Cyber Dragon Infinity (c10443957)
local s,id=GetID(); local STRING_ID=133548744
function s.initial_effect(c)
 c:EnableReviveLimit(); aux.AddXyzProcedure(c,aux.FilterBoolFunction(Card.IsRace,RACE_BEAST),6,2,nil,nil,99)
 local e1=Effect.CreateEffect(c); e1:SetDescription(aux.Stringid(STRING_ID,0)); e1:SetCategory(CATEGORY_TODECK); e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O); e1:SetCode(EVENT_SPSUMMON_SUCCESS); e1:SetProperty(EFFECT_FLAG_DELAY); e1:SetCountLimit(1,id); e1:SetCondition(function(e) return e:GetHandler():IsSummonType(SUMMON_TYPE_XYZ) end); e1:SetOperation(s.xyzop); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetDescription(aux.Stringid(STRING_ID,1)); e2:SetCategory(CATEGORY_NEGATE+CATEGORY_DESTROY); e2:SetType(EFFECT_TYPE_QUICK_O); e2:SetCode(EVENT_CHAINING); e2:SetRange(LOCATION_MZONE); e2:SetProperty(EFFECT_FLAG_DAMAGE_STEP+EFFECT_FLAG_DAMAGE_CAL); e2:SetCountLimit(1,id+100); e2:SetCondition(s.negcon); e2:SetTarget(s.negtg); e2:SetOperation(s.negop); c:RegisterEffect(e2)
end
function s.tdf(c) return c:IsAbleToDeck() end
function s.ovf(c) return c:IsAbleToOverlay() end
function s.xyzop(e,tp) local c=e:GetHandler(); local max=math.min(c:GetOverlayCount(),Duel.GetMatchingGroupCount(s.tdf,tp,LOCATION_GRAVE,LOCATION_GRAVE,nil)); if max>0 and Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,2)) then local opts={}; for i=1,max do opts[#opts+1]=i end local n=Duel.AnnounceNumber(tp,table.unpack(opts)); if c:RemoveOverlayCard(tp,n,n,REASON_EFFECT)==n then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK); local g=Duel.SelectMatchingCard(tp,s.tdf,tp,LOCATION_GRAVE,LOCATION_GRAVE,n,n,nil); Duel.SendtoDeck(g,nil,SEQ_DECKSHUFFLE,REASON_EFFECT) end end if c:IsRelateToEffect(e) and Duel.IsExistingMatchingCard(s.ovf,tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,nil) and Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,3)) then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_XMATERIAL); local g=Duel.SelectMatchingCard(tp,s.ovf,tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,1,nil); Duel.Overlay(c,g) end end
function s.one(c) return c:IsFaceup() and c:IsType(TYPE_XYZ) and c:GetOverlayCount()==1 end
function s.negcon(e,tp,eg,ep,ev,re,r,rp) return rp==1-tp and re:IsActiveType(TYPE_MONSTER) and Duel.IsChainNegatable(ev) and Duel.IsExistingMatchingCard(s.one,tp,LOCATION_MZONE,0,1,nil) end
function s.negtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end Duel.SetOperationInfo(0,CATEGORY_NEGATE,eg,1,0,0) end
function s.negop(e,tp,eg,ep,ev,re) if Duel.NegateActivation(ev) and re:GetHandler():IsRelateToEffect(re) then Duel.Destroy(re:GetHandler(),REASON_EFFECT) end end
