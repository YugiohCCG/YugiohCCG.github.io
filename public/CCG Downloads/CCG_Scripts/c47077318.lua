--森羅の蜜柑子 シトラ
Duel.LoadScript("ccg_sylvan.lua")
--Omega may not load non-card helper filenames; keep the exact shared fallback.
if not (CCGSylvan and CCGSylvan.Excavate and CCGSylvan.Plant and CCGSylvan.ForcedSend) then
--Shared handling for the custom Sylvan excavation instructions.
CCGSylvan=CCGSylvan or {}
function CCGSylvan.Plant(c)
 return c:IsType(TYPE_MONSTER) and c:IsRace(RACE_PLANT)
end
function CCGSylvan.ForcedSend(c,e)
 return e:GetHandler():IsSetCard(0x90) and c:IsCode(238276575,238276576,238276577)
end
function CCGSylvan.Excavate(e,tp,ct,addmax)
 Duel.ConfirmDecktop(tp,ct)
 local g=Duel.GetDecktopGroup(tp,ct)
 local first=g:GetFirst()
 local lv=first and CCGSylvan.Plant(first) and first:GetLevel() or 0
 local sends=g:Filter(function(c) return CCGSylvan.Plant(c) or CCGSylvan.ForcedSend(c,e) end,nil)
 local rest=g:Clone()
 rest:Sub(sends)
 if addmax and addmax>0 then
  local choices=rest:Filter(function(c) return c:IsSetCard(0x90) and c:IsType(TYPE_SPELL+TYPE_TRAP) and c:IsAbleToHand() end,nil)
  if #choices>0 and Duel.SelectYesNo(tp,aux.Stringid(132276575,1)) then
   Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
   local adds=choices:Select(tp,1,math.min(addmax,#choices),nil)
   Duel.SendtoHand(adds,nil,REASON_EFFECT)
   Duel.ConfirmCards(1-tp,adds)
   rest:Sub(adds)
  end
 end
 if #sends>0 then Duel.DisableShuffleCheck() Duel.SendtoGrave(sends,REASON_EFFECT+REASON_REVEAL) end
 local remaining=rest:Filter(Card.IsLocation,nil,LOCATION_DECK)
 if #remaining>0 then
  if #remaining>1 then Duel.SortDecktop(tp,tp,#remaining) end
  for i=1,#remaining do Duel.MoveSequence(Duel.GetDecktopGroup(tp,1):GetFirst(),SEQ_DECKBOTTOM) end
 end
 return lv
end
end
function c47077318.initial_effect(c)
	--deck check
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(47077318,0))
	e1:SetCategory(CATEGORY_DECKDES)
	e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e1:SetProperty(EFFECT_FLAG_DAMAGE_STEP)
	e1:SetCode(EVENT_TO_GRAVE)
	e1:SetCondition(c47077318.condition)
	e1:SetTarget(c47077318.target)
	e1:SetOperation(c47077318.operation)
	c:RegisterEffect(e1)
	--boost
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(47077318,1))
	e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_F)
	e2:SetCategory(CATEGORY_ATKCHANGE+CATEGORY_DEFCHANGE)
	e2:SetCode(EVENT_TO_GRAVE)
	e2:SetProperty(EFFECT_FLAG_DELAY)
	e2:SetCondition(c47077318.tdcon)
	e2:SetOperation(c47077318.tdop)
	c:RegisterEffect(e2)
end
function c47077318.condition(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	return c:IsReason(REASON_DESTROY) and c:GetReasonPlayer()==1-tp
		and c:IsPreviousControler(tp)
end
function c47077318.target(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsPlayerCanDiscardDeck(tp,1) end
end
function c47077318.operation(e,tp,eg,ep,ev,re,r,rp)
	if not Duel.IsPlayerCanDiscardDeck(tp,1) then return end
	CCGSylvan.Excavate(e,tp,1)
end
function c47077318.tdcon(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	return c:IsPreviousLocation(LOCATION_DECK) and c:IsReason(REASON_REVEAL)
end
function c47077318.filter(c)
	return c:IsFaceup() and c:IsRace(RACE_PLANT)
end
function c47077318.tdop(e,tp,eg,ep,ev,re,r,rp)
	local g=Duel.GetMatchingGroup(c47077318.filter,tp,LOCATION_MZONE,0,nil)
	local tc=g:GetFirst()
	while tc do
		local e1=Effect.CreateEffect(e:GetHandler())
		e1:SetType(EFFECT_TYPE_SINGLE)
		e1:SetCode(EFFECT_UPDATE_ATTACK)
		e1:SetValue(300)
		e1:SetReset(RESET_EVENT+RESETS_STANDARD)
		tc:RegisterEffect(e1)
		local e2=e1:Clone()
		e2:SetCode(EFFECT_UPDATE_DEFENSE)
		tc:RegisterEffect(e2)
		tc=g:GetNext()
	end
end


