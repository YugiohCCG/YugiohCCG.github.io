-- c210628767.lua (Morbydrip the Crewal Whale)
local s,id=GetID()
local STRING_ID=132628767

function s.initial_effect(c)
	c:SetUniqueOnField(1,0,id)
	-- Place in S/T Zone as Continuous Trap
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,0))
	e1:SetCategory(CATEGORY_DESTROY)
	e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e1:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_CARD_TARGET)
	e1:SetCode(EVENT_SUMMON_SUCCESS)
	e1:SetTarget(s.pltg)
	e1:SetOperation(s.plop)
	c:RegisterEffect(e1)
	local e2=e1:Clone()
	e2:SetCode(EVENT_SPSUMMON_SUCCESS)
	c:RegisterEffect(e2)
	-- Special Summon from S/T Zone
	local e3=Effect.CreateEffect(c)
	e3:SetDescription(aux.Stringid(STRING_ID,1))
	e3:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_REMOVE)
	e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
	e3:SetProperty(EFFECT_FLAG_DELAY)
	e3:SetCode(EVENT_SPSUMMON_SUCCESS)
	e3:SetRange(LOCATION_SZONE)
	e3:SetCountLimit(1,id)
	e3:SetCondition(s.spcon)
	e3:SetTarget(s.sptg)
	e3:SetOperation(s.spop)
	c:RegisterEffect(e3)
end

function s.tgfilter(c)
	return c:IsFaceup() and (c:GetOriginalType()&TYPE_MONSTER)~=0 and not c:IsForbidden()
end
function s.pltg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(1-tp) and chkc:IsLocation(LOCATION_MZONE) and s.tgfilter(chkc) end
	if chk==0 then return Duel.IsExistingTarget(s.tgfilter,tp,0,LOCATION_MZONE,1,nil) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOFIELD)
	Duel.SelectTarget(tp,s.tgfilter,tp,0,LOCATION_MZONE,1,1,nil)
end
function s.get_column_szone_seq(c,p)
	local seq=c:GetSequence()
	if c:IsLocation(LOCATION_MZONE) then
		if seq==5 then seq=1
		elseif seq==6 then seq=3 end
	end
	if c:GetControler()~=p then
		seq=4-seq
	end
	return seq
end
function s.move_to_szone_column(c,tp,col_seq)
	local p=c:GetOwner()
	local sq=(c:GetControler()==p) and col_seq or (4-col_seq)
	local oc=Duel.GetFieldCard(p,LOCATION_SZONE,sq)
	if oc then
		Duel.Destroy(oc,REASON_EFFECT)
	end
	if not Duel.MoveToField(c,tp,p,LOCATION_SZONE,POS_FACEUP,true) then return false end
	Duel.MoveSequence(c,sq)
	local e1=Effect.CreateEffect(c)
	e1:SetCode(EFFECT_CHANGE_TYPE)
	e1:SetType(EFFECT_TYPE_SINGLE)
	e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
	e1:SetReset(RESET_EVENT+RESETS_STANDARD-RESET_TURN_SET)
	e1:SetValue(TYPE_TRAP+TYPE_CONTINUOUS)
	c:RegisterEffect(e1)
	return true
end
function s.plop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	local tc=Duel.GetFirstTarget()
	if not c:IsRelateToEffect(e) or not tc or not tc:IsRelateToEffect(e) then return end
	local cs=s.get_column_szone_seq(c,c:GetControler())
	local ts=s.get_column_szone_seq(tc,tc:GetControler())
	s.move_to_szone_column(tc,tp,ts)
	s.move_to_szone_column(c,tp,cs)
end

function s.colfilter(c,tp,g)
	return c:IsSummonPlayer(1-tp) and g:IsContains(c)
end
function s.spcon(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	return c:GetType()==TYPE_TRAP+TYPE_CONTINUOUS and eg:IsExists(s.colfilter,1,nil,tp,c:GetColumnGroup())
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and c:IsCanBeSpecialSummoned(e,0,tp,false,false) end
	Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,0,0)
end
function s.epfilter(c)
	return (c:GetOriginalType()&TYPE_MONSTER)~=0 and not c:IsCode(id) and c:IsAbleToRemove()
end
function s.epop(e,tp)
	local g=Duel.GetMatchingGroup(s.epfilter,tp,LOCATION_SZONE,LOCATION_SZONE,nil)
	if #g>0 then
		Duel.Remove(g,POS_FACEUP,REASON_EFFECT)
	end
end
function s.spop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if not c:IsRelateToEffect(e) or Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)==0 then return end
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(STRING_ID,2))
	e1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
	e1:SetCode(EVENT_PHASE+PHASE_END)
	e1:SetCountLimit(1)
	e1:SetReset(RESET_PHASE+PHASE_END)
	e1:SetOperation(s.epop)
	Duel.RegisterEffect(e1,tp)
end
