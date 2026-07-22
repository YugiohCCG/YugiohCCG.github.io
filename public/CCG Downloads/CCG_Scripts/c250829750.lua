local s,id=GetID()
local STRING_ID=132829750
local SET_GALACTICA=0x9c9
local STATION=258934904
function s.initial_effect(c)
	local e1=Effect.CreateEffect(c) e1:SetDescription(aux.Stringid(STRING_ID,0)) e1:SetCategory(CATEGORY_LEAVE_GRAVE) e1:SetType(EFFECT_TYPE_ACTIVATE) e1:SetCode(EVENT_FREE_CHAIN) e1:SetTarget(s.acttg) e1:SetOperation(s.actop) c:RegisterEffect(e1)
	local e2=Effect.CreateEffect(c) e2:SetType(EFFECT_TYPE_FIELD) e2:SetCode(EFFECT_CANNOT_ACTIVATE) e2:SetRange(LOCATION_FZONE) e2:SetProperty(EFFECT_FLAG_PLAYER_TARGET) e2:SetTargetRange(0,1) e2:SetCondition(s.actcon) e2:SetValue(1) c:RegisterEffect(e2)
	local e3=Effect.CreateEffect(c) e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS) e3:SetCode(EFFECT_DESTROY_REPLACE) e3:SetRange(LOCATION_FZONE) e3:SetTarget(s.reptg) e3:SetValue(s.repval) e3:SetOperation(s.repop) c:RegisterEffect(e3)
	local e4=Effect.CreateEffect(c) e4:SetDescription(aux.Stringid(STRING_ID,1)) e4:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS) e4:SetCode(EVENT_PRE_BATTLE_DAMAGE) e4:SetRange(LOCATION_FZONE) e4:SetCondition(function(e,tp,eg,ep) return ep==tp and e:GetHandler():IsAbleToRemove() end) e4:SetOperation(s.bdop) c:RegisterEffect(e4)
end
function s.stfilter(c) return c:IsFaceupEx() and c:IsCode(STATION) and not c:IsForbidden() end
function s.acttg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.stfilter),tp,LOCATION_DECK+LOCATION_GRAVE+LOCATION_REMOVED,0,1,nil) end end
function s.actop(e,tp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOFIELD) local tc=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.stfilter),tp,LOCATION_DECK+LOCATION_GRAVE+LOCATION_REMOVED,0,1,1,nil):GetFirst() if not tc then return end
	local te=tc:GetActivateEffect() if not te then return end
	if Duel.MoveToField(tc,tp,tp,LOCATION_SZONE,POS_FACEUP,true) then te:UseCountLimit(tp) local op=te:GetOperation() if op then op(te,tp,Group.CreateGroup(),PLAYER_NONE,0,nil,0,PLAYER_NONE) end end
end
function s.actcon(e,tp) local a=Duel.GetAttacker() local d=Duel.GetAttackTarget() return (a and a:IsControler(tp) and a:IsSetCard(SET_GALACTICA)) or (d and d:IsControler(tp) and d:IsSetCard(SET_GALACTICA)) end
function s.repfilter(c,tp) return c:IsFaceup() and c:IsSetCard(SET_GALACTICA) and c:IsControler(tp) and c:IsOnField() and c:IsReason(REASON_EFFECT) and c:GetReasonPlayer()==1-tp and not c:IsReason(REASON_REPLACE) end
function s.reptg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return e:GetHandler():IsAbleToRemove() and eg:IsExists(s.repfilter,1,nil,tp) end return Duel.SelectEffectYesNo(tp,e:GetHandler(),96) end
function s.repval(e,c) return s.repfilter(c,e:GetHandlerPlayer()) end
function s.repop(e) Duel.Remove(e:GetHandler(),POS_FACEUP,REASON_EFFECT+REASON_REPLACE) end
function s.bdop(e,tp) if Duel.SelectEffectYesNo(tp,e:GetHandler(),aux.Stringid(STRING_ID,1)) and Duel.Remove(e:GetHandler(),POS_FACEUP,REASON_EFFECT)>0 then Duel.ChangeBattleDamage(tp,0) end end
