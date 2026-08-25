--Aerocat Recon
--Omega references: Reinforcement of the Army (c32807846), Pot of Acquisitiveness (c64014615)
local s,id=GetID()
local MSG_ID=133391738
local SET_AEROCAT=0x3de1
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH)
 e1:SetType(EFFECT_TYPE_ACTIVATE); e1:SetCode(EVENT_FREE_CHAIN); e1:SetCountLimit(1,id)
 e1:SetTarget(s.thtg); e1:SetOperation(s.thop); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_TODECK+CATEGORY_DRAW)
 e2:SetType(EFFECT_TYPE_IGNITION); e2:SetRange(LOCATION_GRAVE); e2:SetProperty(EFFECT_FLAG_CARD_TARGET)
 e2:SetCountLimit(1,id+100); e2:SetCost(aux.bfgcost); e2:SetTarget(s.tdtg); e2:SetOperation(s.tdop); c:RegisterEffect(e2)
end
function s.af(c) return c:IsSetCard(SET_AEROCAT) and c:IsType(TYPE_MONSTER) and c:IsAbleToHand() end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.af),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,nil) end Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK+LOCATION_GRAVE) end
function s.thop(e,tp) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND) local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.af),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,1,nil) if #g>0 then Duel.SendtoHand(g,nil,REASON_EFFECT); Duel.ConfirmCards(1-tp,g) end end
function s.rdf(c,e) return c~=e:GetHandler() and c:IsSetCard(SET_AEROCAT) and c:IsAbleToDeck() and (c:IsLocation(LOCATION_REMOVED) or aux.NecroValleyFilter(Card.IsAbleToDeck)(c,e)) end
function s.one(c) return c:IsFaceup() and c:IsType(TYPE_XYZ) and c:GetOverlayCount()==1 end
function s.tdtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc) if chkc then return s.rdf(chkc,e) end if chk==0 then return Duel.IsExistingTarget(s.rdf,tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,nil,e) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK) local g=Duel.SelectTarget(tp,s.rdf,tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,3,nil,e) Duel.SetOperationInfo(0,CATEGORY_TODECK,g,#g,0,0) end
function s.tdop(e,tp) local g=Duel.GetTargetCards(e):Filter(s.rdf,nil,e) if #g>0 and Duel.SendtoDeck(g,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)>0 and Duel.IsExistingMatchingCard(s.one,tp,LOCATION_MZONE,0,1,nil) and Duel.IsPlayerCanDraw(tp,1) and Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,2)) then Duel.BreakEffect(); Duel.Draw(tp,1,REASON_EFFECT) end end
