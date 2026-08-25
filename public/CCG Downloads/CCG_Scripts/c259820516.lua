--Expulsion of the Pyre
--Omega references: Foolish Burial Goods (c35726888), Pot of Acquisitiveness (c64014615)
local s,id=GetID(); local SET_PYRE=0x3135
function s.initial_effect(c)
 local e=Effect.CreateEffect(c); e:SetCategory(CATEGORY_TOGRAVE); e:SetType(EFFECT_TYPE_ACTIVATE); e:SetCode(EVENT_FREE_CHAIN); e:SetCountLimit(1,id); e:SetCost(s.cost); e:SetTarget(s.settg); e:SetOperation(s.setop); c:RegisterEffect(e)
 local e2=Effect.CreateEffect(c); e2:SetCategory(CATEGORY_TODECK+CATEGORY_DRAW); e2:SetType(EFFECT_TYPE_IGNITION); e2:SetRange(LOCATION_GRAVE); e2:SetProperty(EFFECT_FLAG_CARD_TARGET); e2:SetCountLimit(1,id+100); e2:SetCost(aux.bfgcost); e2:SetTarget(s.tdtg); e2:SetOperation(s.tdop); c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c); e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS); e3:SetCode(EFFECT_DESTROY_REPLACE); e3:SetRange(LOCATION_GRAVE); e3:SetTarget(s.reptg); e3:SetValue(s.repval); e3:SetOperation(s.repop); c:RegisterEffect(e3)
end
function s.cf(c) return c:IsRace(RACE_PYRO) and c:IsAbleToGraveAsCost() end
function s.cost(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.cf,tp,LOCATION_MZONE,0,1,nil) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE); local g=Duel.SelectMatchingCard(tp,s.cf,tp,LOCATION_MZONE,0,1,1,nil); Duel.SendtoGrave(g,REASON_COST) end
function s.sf(c) return c:IsSetCard(SET_PYRE) and c:IsSpell() and c:IsSSetable() end
function s.settg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.sf),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,nil) end end
function s.setop(e,tp) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SET); local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.sf),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,1,nil); if #g>0 then Duel.SSet(tp,g) end end
function s.rdf(c) return not c:IsCode(id) and (c:IsSetCard(SET_PYRE) and c:IsSpell() or c:IsRace(RACE_PYRO)) and c:IsAbleToDeck() end
function s.tdtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc) if chkc then return s.rdf(chkc) end if chk==0 then return Duel.IsExistingTarget(s.rdf,tp,LOCATION_REMOVED,0,3,nil) and Duel.IsPlayerCanDraw(tp,1) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK); local g=Duel.SelectTarget(tp,s.rdf,tp,LOCATION_REMOVED,0,3,3,nil); Duel.SetOperationInfo(0,CATEGORY_TODECK,g,3,0,0); Duel.SetOperationInfo(0,CATEGORY_DRAW,nil,0,tp,1) end
function s.tdop(e,tp) local g=Duel.GetChainInfo(0,CHAININFO_TARGET_CARDS):Filter(Card.IsRelateToEffect,nil,e); if #g==3 and Duel.SendtoDeck(g,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)==3 then Duel.BreakEffect(); Duel.Draw(tp,1,REASON_EFFECT) end end
function s.rf(c,tp) return c:IsFaceup() and c:IsControler(tp) and c:IsLocation(LOCATION_MZONE) and c:IsRace(RACE_PYRO) and c:IsReason(REASON_BATTLE+REASON_EFFECT) and not c:IsReason(REASON_REPLACE) end
function s.reptg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return eg:IsExists(s.rf,1,nil,tp) and e:GetHandler():IsAbleToRemove() end return Duel.SelectYesNo(tp,96) end
function s.repval(e,c) return s.rf(c,e:GetHandlerPlayer()) end
function s.repop(e) Duel.Remove(e:GetHandler(),POS_FACEUP,REASON_EFFECT+REASON_REPLACE) end
