--Nautica Musicale
--Omega references: Fire Formation - Tenki (c57103969), Shared Ride (c01372887)
local s,id=GetID(); local STRING_ID=133797813; local SET_NAUTICA=0x8f0
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c); e1:SetDescription(aux.Stringid(STRING_ID,0)); e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH); e1:SetType(EFFECT_TYPE_ACTIVATE); e1:SetCode(EVENT_FREE_CHAIN); e1:SetTarget(s.thtg); e1:SetOperation(s.thop); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetDescription(aux.Stringid(STRING_ID,1)); e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O); e2:SetCode(EVENT_CHAIN_SOLVED); e2:SetRange(LOCATION_SZONE); e2:SetCondition(s.chcon); e2:SetTarget(s.chtg); e2:SetOperation(s.chop); c:RegisterEffect(e2)
 c:SetUniqueOnField(1,0,id)
end
function s.nf(c) return c:IsSetCard(SET_NAUTICA) and c:IsType(TYPE_MONSTER) and c:IsAbleToHand() end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end if Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.nf),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,nil) then Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK+LOCATION_GRAVE) end end
function s.thop(e,tp)
 local filter=aux.NecroValleyFilter(s.nf)
 local locations=LOCATION_DECK+LOCATION_GRAVE
 if not Duel.IsExistingMatchingCard(filter,tp,locations,0,1,nil)
  or not Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,0)) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
 local tc=Duel.SelectMatchingCard(tp,filter,tp,locations,0,1,1,nil):GetFirst()
 if tc and Duel.SendtoHand(tc,nil,REASON_EFFECT)>0 and tc:IsLocation(LOCATION_HAND) and tc:IsControler(tp) then
  Duel.ConfirmCards(1-tp,tc)
 end
end
function s.chcon(e,tp,eg,ep,ev,re,r,rp)
 if rp~=tp then return false end
 local ex,g,_,p,loc=Duel.GetOperationInfo(ev,CATEGORY_SPECIAL_SUMMON)
 return ex and g and p==tp and loc and loc&LOCATION_HAND~=0
  and g:IsExists(function(c) return c:IsSetCard(SET_NAUTICA) and c:IsType(TYPE_MONSTER) end,1,nil)
end
function s.oppmf(c) return c:IsType(TYPE_MONSTER) and c:IsAbleToHand() end
function s.chtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsPlayerCanDraw(tp,1) and Duel.IsExistingMatchingCard(s.oppmf,tp,0,LOCATION_DECK,1,nil) end Duel.SetOperationInfo(0,CATEGORY_DRAW,nil,0,tp,1); Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,1-tp,LOCATION_DECK) end
function s.chop(e,tp)
 local p=1-tp
 -- The draw and opponent's search are joined by "and".
 if Duel.IsPlayerCanDraw(tp,1) and Duel.IsExistingMatchingCard(s.oppmf,p,LOCATION_DECK,0,1,nil)
  and Duel.Draw(tp,1,REASON_EFFECT)>0 then
  Duel.Hint(HINT_SELECTMSG,p,HINTMSG_ATOHAND)
  local tc=Duel.SelectMatchingCard(p,s.oppmf,p,LOCATION_DECK,0,1,1,nil):GetFirst()
  if tc and Duel.SendtoHand(tc,nil,REASON_EFFECT)>0 and tc:IsLocation(LOCATION_HAND) and tc:IsControler(p) then
   Duel.ConfirmCards(tp,tc)
   Duel.BreakEffect()
   if Duel.IsExistingMatchingCard(Card.IsAbleToDeck,tp,LOCATION_HAND,0,1,nil) then
    Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
    local bg=Duel.SelectMatchingCard(tp,Card.IsAbleToDeck,tp,LOCATION_HAND,0,1,1,nil)
    Duel.SendtoDeck(bg,nil,SEQ_DECKBOTTOM,REASON_EFFECT)
   end
   local code=tc:GetCode()
   local ex=Effect.CreateEffect(e:GetHandler())
   ex:SetType(EFFECT_TYPE_FIELD)
   ex:SetCode(EFFECT_CANNOT_ACTIVATE)
   ex:SetProperty(EFFECT_FLAG_PLAYER_TARGET)
   ex:SetTargetRange(0,1)
   ex:SetValue(function(_,re) return re:GetHandler():IsCode(code) end)
   ex:SetReset(RESET_PHASE+PHASE_END,2)
   Duel.RegisterEffect(ex,tp)
  end
 end
 Duel.Recover(tp,200,REASON_EFFECT)
end
