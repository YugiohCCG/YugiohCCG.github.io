--Ashened Face Off
--Omega references: Fire Formation - Tenki (c57103969), Salamangreat Balelynx (c14812471)
local s,id=GetID(); local SET_ASHENED=0x1ad
function s.initial_effect(c)
 Duel.AddCustomActivityCounter(id,ACTIVITY_SPSUMMON,s.spactivity)
 local e=Effect.CreateEffect(c); e:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH); e:SetType(EFFECT_TYPE_ACTIVATE); e:SetCode(EVENT_FREE_CHAIN); e:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH); e:SetTarget(s.thtg); e:SetOperation(s.thop); c:RegisterEffect(e)
 local e2=Effect.CreateEffect(c); e2:SetType(EFFECT_TYPE_FIELD); e2:SetCode(EFFECT_CHANGE_RACE); e2:SetRange(LOCATION_SZONE); e2:SetTargetRange(0,LOCATION_MZONE); e2:SetCondition(function() return Duel.GetTurnPlayer()==1-c:GetControler() end); e2:SetTarget(function(e,c) return c:IsFaceup() and c:IsSummonType(SUMMON_TYPE_SPECIAL) end); e2:SetValue(RACE_PYRO); c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c); e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS); e3:SetCode(EFFECT_DESTROY_REPLACE); e3:SetRange(LOCATION_SZONE); e3:SetCountLimit(1); e3:SetTarget(s.reptg); e3:SetValue(s.repval); e3:SetOperation(s.repop); c:RegisterEffect(e3)
end
function s.spactivity(c) return c:IsRace(RACE_PYRO) end
function s.splock(e,tp) local ex=Effect.CreateEffect(e:GetHandler()); ex:SetType(EFFECT_TYPE_FIELD); ex:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON); ex:SetProperty(EFFECT_FLAG_PLAYER_TARGET); ex:SetTargetRange(1,0); ex:SetTarget(function(e,c) return not c:IsRace(RACE_PYRO) end); ex:SetReset(RESET_PHASE+PHASE_END); Duel.RegisterEffect(ex,tp) end
function s.thf(c) return c:IsSetCard(SET_ASHENED) and c:IsAbleToHand() end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetCustomActivityCount(id,tp,ACTIVITY_SPSUMMON)==0 and Duel.IsExistingMatchingCard(s.thf,tp,LOCATION_DECK,0,1,nil) end s.splock(e,tp); Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK) end
function s.thop(e,tp) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND); local g=Duel.SelectMatchingCard(tp,s.thf,tp,LOCATION_DECK,0,1,1,nil); if #g>0 then Duel.SendtoHand(g,nil,REASON_EFFECT); Duel.ConfirmCards(1-tp,g) end end
function s.rf(c,tp) return c:IsFaceup() and c:IsControler(tp) and c:IsLocation(LOCATION_MZONE) and c:IsSetCard(SET_ASHENED) and c:IsReason(REASON_BATTLE+REASON_EFFECT) and not c:IsReason(REASON_REPLACE) end
function s.costf(c) return c:IsRace(RACE_PYRO) and c:IsAttribute(ATTRIBUTE_DARK) and c:IsAbleToRemove() end
function s.reptg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return eg:IsExists(s.rf,1,nil,tp) and Duel.IsExistingMatchingCard(s.costf,tp,LOCATION_GRAVE,0,1,nil) end if not Duel.SelectYesNo(tp,96) then return false end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE); local g=Duel.SelectMatchingCard(tp,s.costf,tp,LOCATION_GRAVE,0,1,1,nil); Duel.Remove(g,POS_FACEUP,REASON_EFFECT+REASON_REPLACE); return true end
function s.repval(e,c) return s.rf(c,e:GetHandlerPlayer()) end
function s.repop() end
