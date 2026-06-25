--Branching to Guidance
local s,id=GetID()
local TOKEN_GUIDANCE=222257686
s.listed_names={TOKEN_GUIDANCE}
function s.initial_effect(c)
	--Reveal 1 monster; Special Summon 1 "Guidance Token"
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(id,0))
	e1:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_TOKEN)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e1:SetTarget(s.tktg)
	e1:SetOperation(s.tkop)
	c:RegisterEffect(e1)
	--Banish this card; Special Summon 1 "Guidance Token"
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(id,1))
	e2:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_TOKEN)
	e2:SetType(EFFECT_TYPE_IGNITION)
	e2:SetRange(LOCATION_GRAVE)
	e2:SetProperty(EFFECT_FLAG_CARD_TARGET)
	e2:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
	e2:SetCost(aux.bfgcost)
	e2:SetTarget(s.gytg)
	e2:SetOperation(s.gyop)
	c:RegisterEffect(e2)
end
function s.copyfilter(c)
	return c:IsType(TYPE_MONSTER) and c:IsSummonableCard()
end
function s.cantoken(tp,c)
	return c and Duel.GetLocationCount(tp,LOCATION_MZONE)>0
		and Duel.IsPlayerCanSpecialSummonMonster(tp,TOKEN_GUIDANCE,0,TYPES_TOKEN_MONSTER,
			c:GetAttack(),c:GetDefense(),c:GetLevel(),c:GetRace(),c:GetAttribute(),POS_FACEUP_DEFENSE)
end
function s.handfilter(c,tp)
	return s.copyfilter(c) and not c:IsPublic() and s.cantoken(tp,c)
end
function s.tktg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsExistingMatchingCard(s.handfilter,tp,LOCATION_HAND,0,1,nil,tp) end
	Duel.SetOperationInfo(0,CATEGORY_TOKEN,nil,1,tp,0)
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,0)
end
function s.registercopy(e,token,code,race,attr,lv,atk,def)
	local c=e:GetHandler()
	local e1=Effect.CreateEffect(c)
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
	e1:SetCode(EFFECT_ADD_CODE)
	e1:SetValue(code)
	e1:SetReset(RESET_EVENT+RESETS_STANDARD)
	token:RegisterEffect(e1,true)
	local e2=e1:Clone()
	e2:SetCode(EFFECT_CHANGE_RACE)
	e2:SetValue(race)
	token:RegisterEffect(e2,true)
	local e3=e1:Clone()
	e3:SetCode(EFFECT_CHANGE_ATTRIBUTE)
	e3:SetValue(attr)
	token:RegisterEffect(e3,true)
	local e4=e1:Clone()
	e4:SetCode(EFFECT_CHANGE_LEVEL)
	e4:SetValue(lv)
	token:RegisterEffect(e4,true)
	local e5=e1:Clone()
	e5:SetCode(EFFECT_SET_BASE_ATTACK)
	e5:SetValue(atk)
	token:RegisterEffect(e5,true)
	local e6=e1:Clone()
	e6:SetCode(EFFECT_SET_BASE_DEFENSE)
	e6:SetValue(def)
	token:RegisterEffect(e6,true)
end
function s.summontoken(e,tp,code,race,attr,lv,atk,def)
	if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end
	if not Duel.IsPlayerCanSpecialSummonMonster(tp,TOKEN_GUIDANCE,0,TYPES_TOKEN_MONSTER,atk,def,lv,race,attr,POS_FACEUP_DEFENSE) then return end
	local token=Duel.CreateToken(tp,TOKEN_GUIDANCE)
	s.registercopy(e,token,code,race,attr,lv,atk,def)
	Duel.SpecialSummon(token,0,tp,tp,false,false,POS_FACEUP_DEFENSE)
end
function s.tkop(e,tp,eg,ep,ev,re,r,rp)
	if not Duel.IsExistingMatchingCard(s.handfilter,tp,LOCATION_HAND,0,1,nil,tp) then return end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_CONFIRM)
	local g=Duel.SelectMatchingCard(tp,s.handfilter,tp,LOCATION_HAND,0,1,1,nil,tp)
	local tc=g:GetFirst()
	if not tc then return end
	Duel.ConfirmCards(1-tp,g)
	Duel.ShuffleHand(tp)
	s.summontoken(e,tp,tc:GetCode(),tc:GetRace(),tc:GetAttribute(),tc:GetLevel(),tc:GetAttack(),tc:GetDefense())
end
function s.gyfilter(c,e,tp)
	return s.copyfilter(c) and c:IsCanBeEffectTarget(e) and s.cantoken(tp,c)
end
function s.gytg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_GRAVE)
		and aux.NecroValleyFilter(s.gyfilter)(chkc,e,tp) end
	if chk==0 then return Duel.IsExistingTarget(aux.NecroValleyFilter(s.gyfilter),tp,LOCATION_GRAVE,0,1,nil,e,tp) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
	local g=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.gyfilter),tp,LOCATION_GRAVE,0,1,1,nil,e,tp)
	Duel.SetOperationInfo(0,CATEGORY_TOKEN,nil,1,tp,0)
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,0)
end
function s.gyop(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if not (tc and tc:IsRelateToEffect(e) and aux.NecroValleyFilter(s.gyfilter)(tc,e,tp)) then return end
	s.summontoken(e,tp,tc:GetCode(),tc:GetRace(),tc:GetAttribute(),tc:GetLevel(),tc:GetAttack(),tc:GetDefense())
end
