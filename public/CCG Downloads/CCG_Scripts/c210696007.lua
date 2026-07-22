local s,id=GetID()
local STRING_ID=132696007
local SET_GALACTICA=0x9c9
function s.initial_effect(c)
	local e0=Effect.CreateEffect(c) e0:SetType(EFFECT_TYPE_SINGLE) e0:SetCode(EFFECT_ADD_SETCODE) e0:SetValue(SET_GALACTICA) c:RegisterEffect(e0)
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0)) e1:SetCategory(CATEGORY_SSET) e1:SetType(EFFECT_TYPE_ACTIVATE) e1:SetCode(EVENT_FREE_CHAIN) e1:SetProperty(EFFECT_FLAG_CARD_TARGET) e1:SetCountLimit(1,id) e1:SetTarget(s.settg) e1:SetOperation(s.setop) c:RegisterEffect(e1)
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(STRING_ID,1)) e2:SetCategory(CATEGORY_REMOVE+CATEGORY_TOHAND+CATEGORY_SEARCH+CATEGORY_TOGRAVE) e2:SetType(EFFECT_TYPE_IGNITION) e2:SetRange(LOCATION_GRAVE) e2:SetCountLimit(1,id) e2:SetCost(s.cost) e2:SetTarget(s.dectg) e2:SetOperation(s.decop) c:RegisterEffect(e2)
end
function s.setfilter(c) return c:IsFaceup() and c:IsSetCard(SET_GALACTICA) and c:IsType(TYPE_SPELL+TYPE_TRAP) and not c:IsCode(id) and c:IsSSetable() end
function s.settg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_REMOVED) and s.setfilter(chkc) end
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_SZONE)>0 and Duel.IsExistingTarget(s.setfilter,tp,LOCATION_REMOVED,0,1,nil) end
	local ft=Duel.GetLocationCount(tp,LOCATION_SZONE) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SET) local g=Duel.SelectTarget(tp,s.setfilter,tp,LOCATION_REMOVED,0,1,math.min(3,ft),nil) Duel.SetOperationInfo(0,CATEGORY_SSET,g,#g,0,0)
end
function s.setop(e,tp)
	local g=Duel.GetChainInfo(0,CHAININFO_TARGET_CARDS):Filter(function(c,te) return c:IsRelateToEffect(te) and c:IsSSetable() end,nil,e)
	for tc in aux.Next(g) do if Duel.SSet(tp,tc)>0 and (tc:IsType(TYPE_TRAP) or tc:IsType(TYPE_QUICKPLAY)) then local te=Effect.CreateEffect(e:GetHandler()) te:SetType(EFFECT_TYPE_SINGLE) te:SetProperty(EFFECT_FLAG_SET_AVAILABLE) te:SetCode(tc:IsType(TYPE_TRAP) and EFFECT_TRAP_ACT_IN_SET_TURN or EFFECT_QP_ACT_IN_SET_TURN) te:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END) tc:RegisterEffect(te) end end
end
function s.costfilter(c,ec) return c~=ec and c:IsType(TYPE_SPELL+TYPE_TRAP) and c:IsAbleToRemoveAsCost() end
function s.selfcostfilter(c) return c:IsAbleToRemoveAsCost() end
function s.cost(e,tp,eg,ep,ev,re,r,rp,chk) local c=e:GetHandler() if chk==0 then return aux.NecroValleyFilter(s.selfcostfilter)(c) and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.costfilter),tp,LOCATION_GRAVE,0,1,c,c) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE) local tc=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.costfilter),tp,LOCATION_GRAVE,0,1,1,c,c):GetFirst() Duel.Remove(Group.FromCards(c,tc),POS_FACEUP,REASON_COST) end
function s.decfilter(c) return c:IsSetCard(SET_GALACTICA) and c:IsType(TYPE_SPELL+TYPE_TRAP) and not c:IsCode(id) and (c:IsAbleToHand() or c:IsAbleToGrave()) end
function s.dectg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.decfilter,tp,LOCATION_DECK,0,1,nil) end end
function s.decop(e,tp) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_OPERATECARD) local tc=Duel.SelectMatchingCard(tp,s.decfilter,tp,LOCATION_DECK,0,1,1,nil):GetFirst() if not tc then return end local b1=tc:IsAbleToHand() local b2=tc:IsAbleToGrave() local op=b1 and b2 and Duel.SelectOption(tp,aux.Stringid(STRING_ID,2),aux.Stringid(STRING_ID,3)) or (b1 and 0 or 1) if op==0 and Duel.SendtoHand(tc,nil,REASON_EFFECT)>0 then Duel.ConfirmCards(1-tp,tc) else Duel.SendtoGrave(tc,REASON_EFFECT) end end
