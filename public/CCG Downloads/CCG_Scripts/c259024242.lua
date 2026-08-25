--Devotee of the Pyre
--Omega references: Scapegoat (c73915051), Return of the Dragon Lords (c06853254)
local s,id=GetID(); local MSG_ID=133024242; local SET_PYRE=0x3135; local TOKEN_PYRE=239823001; local LORD=259542408
function s.initial_effect(c)
 aux.AddCodeList(c,259542408)
 local e=Effect.CreateEffect(c); e:SetCategory(CATEGORY_TOGRAVE+CATEGORY_TOKEN+CATEGORY_SPECIAL_SUMMON+CATEGORY_TOHAND+CATEGORY_SEARCH); e:SetType(EFFECT_TYPE_ACTIVATE); e:SetCode(EVENT_FREE_CHAIN); e:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH); e:SetCost(s.cost); e:SetTarget(s.tg); e:SetOperation(s.op); c:RegisterEffect(e)
 local e2=Effect.CreateEffect(c); e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS); e2:SetCode(EFFECT_DESTROY_REPLACE); e2:SetRange(LOCATION_GRAVE); e2:SetTarget(s.reptg); e2:SetValue(s.repval); e2:SetOperation(s.repop); c:RegisterEffect(e2)
end
s.listed_names={259542408}
function s.cf(c) return c:IsRace(RACE_PYRO) and c:IsAbleToGraveAsCost() end
function s.cost(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.cf,tp,LOCATION_HAND+LOCATION_MZONE,0,1,nil) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE); local g=Duel.SelectMatchingCard(tp,s.cf,tp,LOCATION_HAND+LOCATION_MZONE,0,1,1,nil); Duel.SendtoGrave(g,REASON_COST) end
function s.search(c) return c:IsSetCard(SET_PYRE) and c:IsSpell() and c:IsAbleToHand() end
function s.tg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>1 and Duel.IsPlayerCanSpecialSummonMonster(tp,239823001,SET_PYRE,TYPES_TOKEN,0,0,1,RACE_PYRO,ATTRIBUTE_FIRE) end Duel.SetOperationInfo(0,CATEGORY_TOKEN,nil,2,tp,0) end
function s.lord(c) return c:IsFaceup() and c:IsCode(LORD) end
function s.op(e,tp) if Duel.GetLocationCount(tp,LOCATION_MZONE)<2 or not Duel.IsPlayerCanSpecialSummonMonster(tp,TOKEN_PYRE,SET_PYRE,TYPES_TOKEN,0,0,1,RACE_PYRO,ATTRIBUTE_FIRE) then return end for i=1,2 do local tc=Duel.CreateToken(tp,TOKEN_PYRE); Duel.SpecialSummonStep(tc,0,tp,tp,false,false,POS_FACEUP); local ex=Effect.CreateEffect(e:GetHandler()); ex:SetType(EFFECT_TYPE_SINGLE); ex:SetCode(EFFECT_UNRELEASABLE_SUM); ex:SetValue(function(e,c) return not c:IsRace(RACE_PYRO) end); ex:SetReset(RESET_EVENT+RESETS_STANDARD); tc:RegisterEffect(ex); local exn=ex:Clone(); exn:SetCode(EFFECT_UNRELEASABLE_NONSUM); exn:SetValue(1); tc:RegisterEffect(exn); local ex2=Effect.CreateEffect(e:GetHandler()); ex2:SetType(EFFECT_TYPE_SINGLE); ex2:SetCode(EFFECT_CANNOT_BE_LINK_MATERIAL); ex2:SetValue(function(e,c) return not c:IsRace(RACE_PYRO) end); ex2:SetReset(RESET_EVENT+RESETS_STANDARD); tc:RegisterEffect(ex2) end Duel.SpecialSummonComplete(); if Duel.IsExistingMatchingCard(s.lord,tp,LOCATION_MZONE,0,1,nil) and Duel.IsExistingMatchingCard(s.search,tp,LOCATION_DECK,0,1,nil) and Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,0)) then Duel.BreakEffect(); Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND); local g=Duel.SelectMatchingCard(tp,s.search,tp,LOCATION_DECK,0,1,1,nil); Duel.SendtoHand(g,nil,REASON_EFFECT); Duel.ConfirmCards(1-tp,g) end end
function s.rf(c,tp) return c:IsFaceup() and c:IsControler(tp) and c:IsLocation(LOCATION_MZONE) and c:IsRace(RACE_PYRO) and c:IsReason(REASON_BATTLE+REASON_EFFECT) and not c:IsReason(REASON_REPLACE) end
function s.reptg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return eg:IsExists(s.rf,1,nil,tp) and e:GetHandler():IsAbleToRemove() end return Duel.SelectYesNo(tp,96) end
function s.repval(e,c) return s.rf(c,e:GetHandlerPlayer()) end
function s.repop(e) Duel.Remove(e:GetHandler(),POS_FACEUP,REASON_EFFECT+REASON_REPLACE) end
