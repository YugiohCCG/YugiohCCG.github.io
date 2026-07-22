local s,id=GetID()
local STRING_ID=133230000
local SET_ELDORA=0x738
local ELDORA=214552846
local STATION=258934904
function s.initial_effect(c)
	local e0=Effect.CreateEffect(c) e0:SetType(EFFECT_TYPE_SINGLE) e0:SetCode(EFFECT_ADD_SETCODE) e0:SetValue(SET_ELDORA) c:RegisterEffect(e0)
	local e1=Effect.CreateEffect(c) e1:SetDescription(aux.Stringid(STRING_ID,0)) e1:SetCategory(CATEGORY_SPECIAL_SUMMON) e1:SetType(EFFECT_TYPE_ACTIVATE) e1:SetCode(EVENT_FREE_CHAIN) e1:SetProperty(EFFECT_FLAG_CARD_TARGET) e1:SetTarget(s.target) e1:SetOperation(s.activate) c:RegisterEffect(e1)
	local e2=Effect.CreateEffect(c) e2:SetDescription(aux.Stringid(STRING_ID,1)) e2:SetCategory(CATEGORY_RELEASE) e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O) e2:SetCode(EVENT_DESTROYED) e2:SetRange(LOCATION_MZONE) e2:SetCondition(s.stcon) e2:SetCost(s.stcost) e2:SetTarget(s.sttg) e2:SetOperation(s.stop) c:RegisterEffect(e2)
end
function s.tgfilter(c) return c:IsFaceup() and c:IsType(TYPE_EFFECT) and c:IsType(TYPE_MONSTER) end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk,chkc) if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and s.tgfilter(chkc) end if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and Duel.IsExistingTarget(s.tgfilter,tp,LOCATION_MZONE,0,1,nil) and Duel.IsExistingMatchingCard(Card.IsCode,tp,LOCATION_DECK,0,1,nil,ELDORA) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET) Duel.SelectTarget(tp,s.tgfilter,tp,LOCATION_MZONE,0,1,1,nil) end
function s.activate_card(e,tp,code,loc)
	local filter=loc&LOCATION_GRAVE~=0 and aux.NecroValleyFilter(Card.IsCode) or Card.IsCode
	local tc=Duel.SelectMatchingCard(tp,filter,tp,loc,0,1,1,nil,code):GetFirst() if not tc then return false end local te=tc:GetActivateEffect() if not te then return false end
	if Duel.MoveToField(tc,tp,tp,tc:IsType(TYPE_FIELD) and LOCATION_FZONE or LOCATION_SZONE,POS_FACEUP,true) then te:UseCountLimit(tp) local op=te:GetOperation() if op then op(te,tp,Group.CreateGroup(),PLAYER_NONE,0,nil,0,PLAYER_NONE) end return true end return false
end
function s.activate(e,tp)
	local tc=Duel.GetFirstTarget() local c=e:GetHandler() if not tc or not tc:IsRelateToEffect(e) or not s.activate_card(e,tp,ELDORA,LOCATION_DECK) or not c:IsRelateToEffect(e) or not tc:IsRelateToEffect(e) then return end
	if Duel.SpecialSummon(c,0,tp,tp,true,false,POS_FACEUP)>0 then
		local typ=tc:GetRace() local att=tc:GetAttribute() local lv=tc:GetLevel() local atk=tc:GetAttack() local def=tc:GetDefense()
		local props={{EFFECT_CHANGE_TYPE,TYPE_TRAP+TYPE_MONSTER+TYPE_EFFECT},{EFFECT_CHANGE_RACE,typ},{EFFECT_CHANGE_ATTRIBUTE,att},{EFFECT_CHANGE_LEVEL,lv},{EFFECT_SET_ATTACK_FINAL,atk},{EFFECT_SET_DEFENSE_FINAL,def},{EFFECT_INDESTRUCTABLE_EFFECT,1}}
		for _,p in ipairs(props) do local te=Effect.CreateEffect(c) te:SetType(EFFECT_TYPE_SINGLE) te:SetCode(p[1]) te:SetValue(p[2]) te:SetReset(RESET_EVENT+RESETS_STANDARD) c:RegisterEffect(te,true) end
	end
end
function s.stcon(e,tp,eg) return eg:IsExists(function(c,p) return c:IsCode(ELDORA) and c:IsPreviousControler(p) and c:IsReason(REASON_EFFECT) and c:GetReasonPlayer()==1-p end,1,nil,tp) end
function s.stcost(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return e:GetHandler():IsReleasable() end Duel.Release(e:GetHandler(),REASON_COST) end
function s.stfilter(c) return c:IsCode(STATION) and not c:IsForbidden() end
function s.sttg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.stfilter),tp,LOCATION_HAND+LOCATION_DECK+LOCATION_GRAVE,0,1,nil) end end
function s.stop(e,tp) s.activate_card(e,tp,STATION,LOCATION_HAND+LOCATION_DECK+LOCATION_GRAVE) end
