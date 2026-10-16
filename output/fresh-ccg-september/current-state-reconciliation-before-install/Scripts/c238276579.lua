--Gink, the Sylvan High Champion
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
local s,id=GetID()
local MSG_ID=132276579
function s.initial_effect(c)
 aux.AddXyzProcedure(c,nil,6,2,nil,nil,99)
 c:EnableReviveLimit()
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH+CATEGORY_DECKDES)
 e1:SetType(EFFECT_TYPE_IGNITION)
 e1:SetRange(LOCATION_MZONE)
 e1:SetCountLimit(1,id)
 e1:SetTarget(s.thtg)
 e1:SetOperation(s.thop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_DISABLE+CATEGORY_DESTROY+CATEGORY_DECKDES)
 e2:SetType(EFFECT_TYPE_QUICK_O)
 e2:SetCode(EVENT_CHAINING)
 e2:SetRange(LOCATION_MZONE)
 e2:SetCountLimit(1,id+100)
 e2:SetCondition(s.negcon)
 e2:SetCost(s.negcost)
 e2:SetTarget(s.negtg)
 e2:SetOperation(s.negop)
 c:RegisterEffect(e2)
end
s.listed_series={0x90}
function s.thfilter(c)
 return c:IsSetCard(0x90) and c:IsType(TYPE_MONSTER) and c:IsAbleToHand()
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.thfilter,tp,LOCATION_DECK,0,1,nil)
  and Duel.GetFieldGroupCount(tp,LOCATION_DECK,0)>=2 end
 Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK)
end
function s.thop(e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
 local g=Duel.SelectMatchingCard(tp,s.thfilter,tp,LOCATION_DECK,0,1,1,nil)
 if #g==0 or Duel.SendtoHand(g,nil,REASON_EFFECT)==0 then return end
 Duel.ConfirmCards(1-tp,g)
 Duel.ShuffleDeck(tp)
 if Duel.IsPlayerCanDiscardDeck(tp,1) then CCGSylvan.Excavate(e,tp,1) end
end
function s.negcon(e,tp,eg,ep,ev,re,r,rp)
 return rp~=tp and re:IsActiveType(TYPE_SPELL+TYPE_TRAP) and Duel.IsChainDisablable(ev)
end
function s.negcost(e,tp,eg,ep,ev,re,r,rp,chk)
 local c=e:GetHandler()
 if chk==0 then return c:CheckRemoveOverlayCard(tp,1,REASON_COST) and Duel.IsPlayerCanDiscardDeck(tp,1) end
 local max=math.min(c:GetOverlayCount(),Duel.GetFieldGroupCount(tp,LOCATION_DECK,0))
 e:SetLabel(c:RemoveOverlayCard(tp,1,max,REASON_COST))
end
function s.negtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return true end
 Duel.SetOperationInfo(0,CATEGORY_DISABLE,eg,1,0,0)
 Duel.SetOperationInfo(0,CATEGORY_DESTROY,eg,1,0,0)
end
function s.negop(e,tp,eg,ep,ev,re)
 local ct=math.min(e:GetLabel(),Duel.GetFieldGroupCount(tp,LOCATION_DECK,0))
 if ct==0 then return end
 Duel.ConfirmDecktop(tp,ct)
 local g=Duel.GetDecktopGroup(tp,ct)
 local plants=g:Filter(CCGSylvan.Plant,nil)
 local sends=plants:Clone()
 sends:Merge(g:Filter(CCGSylvan.ForcedSend,nil,e))
 if #plants>0 and Duel.NegateEffect(ev) then
  local rc=re:GetHandler()
  if rc:IsRelateToEffect(re) then Duel.Destroy(rc,REASON_EFFECT) end
 end
 if #sends>0 then Duel.DisableShuffleCheck() Duel.SendtoGrave(sends,REASON_EFFECT+REASON_REVEAL) end
 --The printed otherwise clause applies when no Plant was excavated.
 if #plants==0 then
  local rest=g:Filter(Card.IsLocation,nil,LOCATION_DECK)
  if #rest>1 then Duel.SortDecktop(tp,tp,#rest) end
  for i=1,#rest do Duel.MoveSequence(Duel.GetDecktopGroup(tp,1):GetFirst(),SEQ_DECKBOTTOM) end
 end
end
