--Teleum Mortis
local s,id=GetID()
local SET_VIR_PEDICAE_MORTIS=0x39e2
local CARD_BEAR_TRAP=251699681
function s.initial_effect(c)
	--Equip only to a "Vir Pedicae Mortis" monster
	local e1=Effect.CreateEffect(c)
	e1:SetCategory(CATEGORY_EQUIP)
	e1:SetType(EFFECT_TYPE_ACTIVATE)
	e1:SetCode(EVENT_FREE_CHAIN)
	e1:SetProperty(EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_CONTINUOUS_TARGET)
	e1:SetTarget(s.target)
	e1:SetOperation(s.operation)
	c:RegisterEffect(e1)
	--ATK gain
	local e2=Effect.CreateEffect(c)
	e2:SetType(EFFECT_TYPE_EQUIP)
	e2:SetCode(EFFECT_UPDATE_ATTACK)
	e2:SetValue(s.atkval)
	c:RegisterEffect(e2)
	--Destroy substitute
	local e3=Effect.CreateEffect(c)
	e3:SetType(EFFECT_TYPE_EQUIP)
	e3:SetCode(EFFECT_DESTROY_SUBSTITUTE)
	e3:SetProperty(EFFECT_FLAG_IGNORE_IMMUNE)
	e3:SetValue(s.repval)
	c:RegisterEffect(e3)
	--Equip limit
	local e4=Effect.CreateEffect(c)
	e4:SetType(EFFECT_TYPE_SINGLE)
	e4:SetCode(EFFECT_EQUIP_LIMIT)
	e4:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
	e4:SetValue(s.eqlimit)
	c:RegisterEffect(e4)
end
s.listed_series={SET_VIR_PEDICAE_MORTIS}
s.listed_names={CARD_BEAR_TRAP}
function s.filter(c)
	return c:IsFaceup() and c:IsSetCard(SET_VIR_PEDICAE_MORTIS) and c:IsType(TYPE_MONSTER)
end
function s.target(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and s.filter(chkc) end
	if chk==0 then return Duel.IsExistingTarget(s.filter,tp,LOCATION_MZONE,0,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_EQUIP)
	Duel.SelectTarget(tp,s.filter,tp,LOCATION_MZONE,0,1,1,nil)
	Duel.SetOperationInfo(0,CATEGORY_EQUIP,e:GetHandler(),1,0,0)
end
function s.operation(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	local tc=Duel.GetFirstTarget()
	if c:IsRelateToEffect(e) and tc and tc:IsRelateToEffect(e) and s.filter(tc) then
		Duel.Equip(tp,c,tc)
	end
end
function s.eqlimit(e,c)
	return s.filter(c)
end
function s.atkval(e,c)
	return (Duel.GetFlagEffect(0,CARD_BEAR_TRAP)+Duel.GetFlagEffect(1,CARD_BEAR_TRAP))*500
end
function s.repval(e,re,r,rp)
	return r&(REASON_BATTLE+REASON_EFFECT)~=0
end
