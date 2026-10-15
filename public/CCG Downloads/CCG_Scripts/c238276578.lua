--Sylvan Duchessprout
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
local MSG_ID=132276578
function s.initial_effect(c)
 aux.AddLinkProcedure(c,aux.FilterBoolFunction(Card.IsSetCard,0x90),1,1)
 c:EnableReviveLimit()
 c:SetSPSummonOnce(id)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_DECKDES)
 e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e1:SetCode(EVENT_SPSUMMON_SUCCESS)
 e1:SetProperty(EFFECT_FLAG_DELAY)
 e1:SetCondition(s.excon)
 e1:SetTarget(s.extg)
 e1:SetOperation(s.exop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetType(EFFECT_TYPE_IGNITION)
 e2:SetRange(LOCATION_GRAVE)
 e2:SetProperty(EFFECT_FLAG_CARD_TARGET)
 e2:SetCost(aux.bfgcost)
 e2:SetTarget(s.lvtg)
 e2:SetOperation(s.lvop)
 c:RegisterEffect(e2)
end
s.listed_series={0x90}
function s.excon(e)
 return e:GetHandler():IsSummonType(SUMMON_TYPE_LINK)
end
function s.extg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsPlayerCanDiscardDeck(tp,2) end
end
function s.exop(e,tp)
 if Duel.IsPlayerCanDiscardDeck(tp,2) then CCGSylvan.Excavate(e,tp,2) end
end
function s.lvfilter(c)
 return c:IsFaceup() and c:IsSetCard(0x90) and c:GetLevel()>0
end
function s.lvtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and s.lvfilter(chkc) end
 if chk==0 then return Duel.IsExistingTarget(s.lvfilter,tp,LOCATION_MZONE,0,1,nil) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_FACEUP)
 Duel.SelectTarget(tp,s.lvfilter,tp,LOCATION_MZONE,0,1,1,nil)
 e:SetLabel(Duel.AnnounceNumber(tp,1,2,3,4,5,6,7,8))
end
function s.lvop(e,tp)
 local tc=Duel.GetFirstTarget()
 if not tc or not tc:IsRelateToEffect(e) or not tc:IsFaceup() then return end
 local change=Effect.CreateEffect(e:GetHandler())
 change:SetType(EFFECT_TYPE_SINGLE)
 change:SetCode(EFFECT_CHANGE_LEVEL)
 change:SetValue(e:GetLabel())
 change:SetReset(RESET_EVENT+RESETS_STANDARD)
 tc:RegisterEffect(change)
end
