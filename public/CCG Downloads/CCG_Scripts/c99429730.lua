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
--森羅の番人 オーク
function c99429730.initial_effect(c)
	--deck
	local e1=Effect.CreateEffect(c)
	e1:SetDescription(aux.Stringid(99429730,0))
	e1:SetCategory(CATEGORY_DECKDES)
	e1:SetType(EFFECT_TYPE_IGNITION)
	e1:SetCountLimit(1)
	e1:SetRange(LOCATION_MZONE)
	e1:SetTarget(c99429730.target)
	e1:SetOperation(c99429730.operation)
	c:RegisterEffect(e1)
	--to deck
	local e2=Effect.CreateEffect(c)
	e2:SetDescription(aux.Stringid(99429730,2))
	e2:SetCategory(CATEGORY_TODECK)
	e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
	e2:SetProperty(EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY)
	e2:SetCode(EVENT_TO_GRAVE)
	e2:SetCondition(c99429730.tdcon)
	e2:SetTarget(c99429730.tdtg)
	e2:SetOperation(c99429730.tdop)
	c:RegisterEffect(e2)
end
function c99429730.target(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsPlayerCanDiscardDeck(tp,1) end
end
function c99429730.operation(e,tp,eg,ep,ev,re,r,rp)
	if not Duel.IsPlayerCanDiscardDeck(tp,1) then return end
	local ct=math.min(3,Duel.GetFieldGroupCount(tp,LOCATION_DECK,0))
	if ct==0 then return end
	local t={}
	for i=1,ct do t[i]=i end
	Duel.Hint(HINT_SELECTMSG,tp,aux.Stringid(99429730,1))
	local ac=Duel.AnnounceNumber(tp,table.unpack(t))
	CCGSylvan.Excavate(e,tp,ac)
end
function c99429730.tdcon(e,tp,eg,ep,ev,re,r,rp)
	local c=e:GetHandler()
	return c:IsPreviousLocation(LOCATION_DECK) and c:IsReason(REASON_REVEAL)
end
function c99429730.filter(c)
	return c:IsRace(RACE_PLANT) and c:IsAbleToDeck()
end
function c99429730.tdtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_GRAVE) and c99429730.filter(chkc) end
	if chk==0 then return Duel.IsExistingTarget(c99429730.filter,tp,LOCATION_GRAVE,0,1,e:GetHandler()) end
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
	local g=Duel.SelectTarget(tp,c99429730.filter,tp,LOCATION_GRAVE,0,1,1,e:GetHandler())
	Duel.SetOperationInfo(0,CATEGORY_TODECK,g,1,0,0)
end
function c99429730.tdop(e,tp,eg,ep,ev,re,r,rp)
	local tc=Duel.GetFirstTarget()
	if tc:IsRelateToEffect(e) then
		Duel.SendtoDeck(tc,nil,SEQ_DECKTOP,REASON_EFFECT)
	end
end
