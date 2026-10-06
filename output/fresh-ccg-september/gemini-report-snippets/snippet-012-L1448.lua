-- c212052682.lua (Ghostrick Djinn)
-- Turn face-down (enforced across flip-resets via FlagEffect)
local e2=Effect.CreateEffect(c)
e2:SetDescription(aux.Stringid(STRING_ID,0))
e2:SetCategory(CATEGORY_POSITION+CATEGORY_MSET)
e2:SetType(EFFECT_TYPE_IGNITION)
e2:SetRange(LOCATION_MZONE)
e2:SetTarget(s.postg)
e2:SetOperation(s.posop)
c:RegisterEffect(e2)

function s.postg(e,tp,eg,ep,ev,re,r,rp,chk)
	local c=e:GetHandler()
	if chk==0 then return c:IsCanTurnSet() and c:GetFlagEffect(id)==0 end
	c:RegisterFlagEffect(id,RESET_EVENT+RESETS_STANDARD-RESET_TURN_SET+RESET_PHASE+PHASE_END,0,1)
	Duel.SetOperationInfo(0,CATEGORY_POSITION,c,1,0,0)
end
function s.posop(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	if c:IsRelateToEffect(e) and c:IsFaceup() then
		Duel.ChangePosition(c,POS_FACEDOWN_DEFENSE)
	end
end

-- Flip trigger: optional IF effect with EFFECT_FLAG_DELAY
local e5=Effect.CreateEffect(c)
e5:SetDescription(aux.Stringid(STRING_ID,2))
e5:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_FLIP+EFFECT_TYPE_TRIGGER_O)
e5:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_CARD_TARGET)
e5:SetTarget(s.lvtg)
e5:SetOperation(s.lvop)
c:RegisterEffect(e5)

function s.lvfilter(c)
	return c:IsFaceup() and c:IsSetCard(SET_GHOSTRICK) and c:IsHasLevel()
end
function s.lvtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and s.lvfilter(chkc) end
	if chk==0 then return Duel.IsExistingTarget(s.lvfilter,tp,LOCATION_MZONE,0,1,nil) end
	local lv=Duel.AnnounceLevel(tp,1,4)
	e:SetLabel(lv)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_FACEUP)
	Duel.SelectTarget(tp,s.lvfilter,tp,LOCATION_MZONE,0,1,99,nil)
end
function s.lvop(e,tp,eg,ep,ev,re,r,rp)
	local g=Duel.GetTargetCards(e):Filter(Card.IsFaceup,nil)
	for tc in aux.Next(g) do
		local e1=Effect.CreateEffect(e:GetHandler())
		e1:SetType(EFFECT_TYPE_SINGLE)
		e1:SetCode(EFFECT_CHANGE_LEVEL)
		e1:SetValue(e:GetLabel())
		e1:SetReset(RESET_EVENT+RESETS_STANDARD)
		tc:RegisterEffect(e1)
	end
end
