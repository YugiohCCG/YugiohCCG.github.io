--Land of the Pyre
--Omega references: Offerings to the Doomed (c19230407), Return of the Dragon Lords (c06853254)
local s,id=GetID()
function s.initial_effect(c)
 local e=Effect.CreateEffect(c); e:SetCategory(CATEGORY_DESTROY); e:SetType(EFFECT_TYPE_ACTIVATE); e:SetCode(EVENT_FREE_CHAIN); e:SetProperty(EFFECT_FLAG_CARD_TARGET); e:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH); e:SetTarget(s.tg); e:SetOperation(s.op); c:RegisterEffect(e)
 local e2=Effect.CreateEffect(c); e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS); e2:SetCode(EFFECT_DESTROY_REPLACE); e2:SetRange(LOCATION_GRAVE); e2:SetTarget(s.reptg); e2:SetValue(s.repval); e2:SetOperation(s.repop); c:RegisterEffect(e2)
end
function s.pyro(c) return c:IsFaceup() and c:IsRace(RACE_PYRO) end
function s.opp(c) return c:IsDestructable() end
function s.tg(e,tp,eg,ep,ev,re,r,rp,chk,chkc) if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and s.pyro(chkc) or chkc:IsControler(1-tp) and chkc:IsLocation(LOCATION_ONFIELD) and s.opp(chkc) end if chk==0 then return Duel.IsExistingTarget(s.pyro,tp,LOCATION_MZONE,0,1,nil) and Duel.IsExistingTarget(s.opp,tp,0,LOCATION_ONFIELD,1,nil) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY); local a=Duel.SelectTarget(tp,s.pyro,tp,LOCATION_MZONE,0,1,1,nil); Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY); local b=Duel.SelectTarget(tp,s.opp,tp,0,LOCATION_ONFIELD,1,1,nil); a:Merge(b); Duel.SetOperationInfo(0,CATEGORY_DESTROY,a,2,0,0) end
function s.op(e) local g=Duel.GetTargetCards(e):Filter(Card.IsRelateToEffect,nil,e); Duel.Destroy(g,REASON_EFFECT) end
function s.repfilter(c,tp) return c:IsFaceup() and c:IsControler(tp) and c:IsLocation(LOCATION_MZONE) and c:IsRace(RACE_PYRO) and c:IsReason(REASON_BATTLE+REASON_EFFECT) and not c:IsReason(REASON_REPLACE) end
function s.reptg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return eg:IsExists(s.repfilter,1,nil,tp) and e:GetHandler():IsAbleToRemove() end return Duel.SelectYesNo(tp,96) end
function s.repval(e,c) return s.repfilter(c,e:GetHandlerPlayer()) end
function s.repop(e) Duel.Remove(e:GetHandler(),POS_FACEUP,REASON_EFFECT+REASON_REPLACE) end
