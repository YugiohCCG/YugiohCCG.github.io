--World Legacy Surfacing
--Omega references: Transaction Rollback (c6351147), Krawler Spine (c88316955), Krawler Axon (c15710054), Krawler Glial (c51205763), Krawler Receptor (c83293307), Krawler Dendrite (c46083111), Krawler Ranvier (c10698416)
local s,id=GetID(); local SET_KRAWLER=0x104; local SET_WORLD_LEGACY=0xfe; local MSG_ID=133944344
function s.initial_effect(c)
 Duel.AddCustomActivityCounter(id,ACTIVITY_CHAIN,s.chainfilter)
 local e1=Effect.CreateEffect(c); e1:SetDescription(aux.Stringid(MSG_ID,0)); e1:SetType(EFFECT_TYPE_ACTIVATE); e1:SetCode(EVENT_FREE_CHAIN); e1:SetCountLimit(1,id); e1:SetTarget(s.cptg); e1:SetOperation(s.cpop); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetDescription(aux.Stringid(MSG_ID,1)); e2:SetCategory(CATEGORY_TOHAND); e2:SetType(EFFECT_TYPE_IGNITION); e2:SetRange(LOCATION_GRAVE); e2:SetCountLimit(1,id+100); e2:SetCost(aux.bfgcost); e2:SetTarget(s.thtg); e2:SetOperation(s.thop); c:RegisterEffect(e2)
end
function s.chainfilter(re) return not re:IsActiveType(TYPE_SPELL+TYPE_TRAP) or re:GetHandler():IsSetCard(SET_WORLD_LEGACY) end
function s.glial(c,e,tp) return c:IsSetCard(SET_KRAWLER) and not c:IsCode(51205763) and c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEUP_ATTACK+POS_FACEDOWN_DEFENSE) end
function s.receptor(c) return c:IsSetCard(SET_KRAWLER) and c:IsType(TYPE_MONSTER) and c:IsAbleToHand() end
function s.dendrite(c) return c:IsType(TYPE_MONSTER) and c:IsAbleToGrave() end
function s.ranvier(c) return c:IsSetCard(SET_KRAWLER) and c:IsType(TYPE_MONSTER) and c:IsAbleToHand() end
function s.flipok(c,e,tp)
 local code=c:GetCode()
 if code==88316955 then return Duel.IsExistingMatchingCard(aux.TRUE,tp,LOCATION_MZONE,LOCATION_MZONE,1,nil) end
 if code==15710054 then return Duel.IsExistingMatchingCard(Card.IsSpellTrap,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,nil) end
 if code==51205763 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.glial),tp,LOCATION_HAND+LOCATION_GRAVE,0,1,nil,e,tp) end
 if code==83293307 then return Duel.IsExistingMatchingCard(s.receptor,tp,LOCATION_DECK,0,1,nil) end
 if code==46083111 then return Duel.IsExistingMatchingCard(s.dendrite,tp,LOCATION_DECK,0,1,nil) end
 if code==10698416 then return Duel.IsExistingTarget(aux.NecroValleyFilter(s.ranvier),tp,LOCATION_GRAVE,0,1,nil) end
 return false
end
function s.rf(c,e,tp) return c:IsSetCard(SET_KRAWLER) and c:IsLevelBelow(2) and c:IsType(TYPE_FLIP) and s.flipok(c,e,tp) end
function s.lock(e,tp) local ex=Effect.CreateEffect(e:GetHandler()); ex:SetType(EFFECT_TYPE_FIELD); ex:SetCode(EFFECT_CANNOT_ACTIVATE); ex:SetProperty(EFFECT_FLAG_PLAYER_TARGET); ex:SetTargetRange(1,0); ex:SetValue(function(e,re) return re:IsActiveType(TYPE_SPELL+TYPE_TRAP) and not re:GetHandler():IsSetCard(SET_WORLD_LEGACY) end); ex:SetReset(RESET_PHASE+PHASE_END); Duel.RegisterEffect(ex,tp) end
function s.cptg(e,tp,eg,ep,ev,re,r,rp,chk)
 local loc=LOCATION_HAND+LOCATION_GRAVE; if Duel.GetFieldGroupCount(tp,0,LOCATION_ONFIELD)>0 then loc=loc+LOCATION_DECK end
 if chk==0 then return Duel.GetCustomActivityCount(id,tp,ACTIVITY_CHAIN)==0 and Duel.IsExistingMatchingCard(s.rf,tp,loc,0,1,nil,e,tp) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_CONFIRM); local g=Duel.SelectMatchingCard(tp,s.rf,tp,loc,0,1,1,nil,e,tp); Duel.ConfirmCards(1-tp,g)
 local code=g:GetFirst():GetCode(); e:SetLabel(code); s.lock(e,tp)
 if code==88316955 then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY); local tg=Duel.SelectTarget(tp,aux.TRUE,tp,LOCATION_MZONE,LOCATION_MZONE,1,1,nil); Duel.SetOperationInfo(0,CATEGORY_DESTROY,tg,1,0,0)
 elseif code==15710054 then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY); local tg=Duel.SelectTarget(tp,Card.IsSpellTrap,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,1,nil); Duel.SetOperationInfo(0,CATEGORY_DESTROY,tg,1,0,0)
 elseif code==10698416 then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND); local tg=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.ranvier),tp,LOCATION_GRAVE,0,1,2,nil); Duel.SetOperationInfo(0,CATEGORY_TOHAND,tg,#tg,0,0) end
end
function s.cpop(e,tp)
 local code=e:GetLabel()
 if code==88316955 or code==15710054 then local tc=Duel.GetFirstTarget(); if tc and tc:IsRelateToEffect(e) then Duel.Destroy(tc,REASON_EFFECT) end
 elseif code==51205763 then if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON); local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.glial),tp,LOCATION_HAND+LOCATION_GRAVE,0,1,1,nil,e,tp); local tc=g:GetFirst(); if tc then local pos=Duel.SelectPosition(tp,tc,POS_FACEUP_ATTACK+POS_FACEDOWN_DEFENSE); if Duel.SpecialSummon(tc,0,tp,tp,false,false,pos)>0 and tc:IsFacedown() then Duel.ConfirmCards(1-tp,tc) end end
 elseif code==83293307 then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND); local g=Duel.SelectMatchingCard(tp,s.receptor,tp,LOCATION_DECK,0,1,1,nil); if #g>0 then Duel.SendtoHand(g,nil,REASON_EFFECT); Duel.ConfirmCards(1-tp,g) end
 elseif code==46083111 then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE); local g=Duel.SelectMatchingCard(tp,s.dendrite,tp,LOCATION_DECK,0,1,1,nil); Duel.SendtoGrave(g,REASON_EFFECT)
 elseif code==10698416 then local g=Duel.GetTargetCards(e):Filter(aux.NecroValleyFilter(s.ranvier),nil); if #g>0 then Duel.SendtoHand(g,nil,REASON_EFFECT) end end
end
function s.thf(c) return (c:IsSetCard(SET_KRAWLER) and c:IsType(TYPE_MONSTER) or c:IsSetCard(SET_WORLD_LEGACY) and c:IsSpellTrap()) and not c:IsCode(id) and c:IsAbleToHand() end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.thf),tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,nil) end Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_GRAVE+LOCATION_REMOVED) end
function s.thop(e,tp) local g=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.thf),tp,LOCATION_GRAVE+LOCATION_REMOVED,0,nil); if #g==0 then return end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND); local sg=g:Select(tp,1,1,nil); local first=sg:GetFirst(); local other=g:Filter(function(c,krawler) return krawler and c:IsSetCard(SET_WORLD_LEGACY) and c:IsSpellTrap() or not krawler and c:IsSetCard(SET_KRAWLER) and c:IsType(TYPE_MONSTER) end,nil,first:IsSetCard(SET_KRAWLER) and first:IsType(TYPE_MONSTER)); if #other>0 and Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,2)) then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND); sg:Merge(other:Select(tp,1,1,nil)) end Duel.SendtoHand(sg,nil,REASON_EFFECT) end
