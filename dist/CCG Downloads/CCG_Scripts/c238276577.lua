--Sylvan Blast
Duel.LoadScript("ccg_sylvan.lua")
local s,id=GetID()
local MSG_ID=132276577
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_TODECK)
 e1:SetType(EFFECT_TYPE_ACTIVATE)
 e1:SetCode(EVENT_FREE_CHAIN)
 e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
 e1:SetOperation(s.topop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_DECKDES)
 e2:SetType(EFFECT_TYPE_QUICK_O)
 e2:SetCode(EVENT_FREE_CHAIN)
 e2:SetRange(LOCATION_SZONE)
 e2:SetCountLimit(1)
 e2:SetCost(s.cost)
 e2:SetOperation(s.excavate)
 c:RegisterEffect(e2)
end
s.listed_series={0x90}
function s.plant(c)
 return c:IsFaceup() and c:IsType(TYPE_MONSTER) and c:IsRace(RACE_PLANT)
end
function s.topfilter(c)
 return c:IsSetCard(0x90) and c:IsType(TYPE_MONSTER) and c:IsAbleToDeck()
end
function s.topop(e,tp)
 local c=e:GetHandler()
 if not c:IsRelateToEffect(e) or not c:IsFaceup() then return end
 local plants=Duel.GetMatchingGroup(s.plant,tp,LOCATION_MZONE,0,nil)
 local ct=plants:GetClassCount(Card.GetAttribute)
 local g=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.topfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,nil)
 if ct==0 or #g==0 or not Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,0)) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
 local sg=g:Select(tp,1,math.min(ct,#g),nil)
 Duel.DisableShuffleCheck()
 local inDeck=sg:Filter(Card.IsLocation,nil,LOCATION_DECK)
 for tc in aux.Next(inDeck) do Duel.MoveSequence(tc,SEQ_DECKTOP) end
 local fromGY=sg:Clone()
 fromGY:Sub(inDeck)
 if #fromGY>0 then Duel.SendtoDeck(fromGY,nil,SEQ_DECKTOP,REASON_EFFECT) end
 local returned=sg:Filter(Card.IsLocation,nil,LOCATION_DECK)
 if #returned>1 then Duel.SortDecktop(tp,tp,#returned) end
end
function s.rating(c)
 if c:IsType(TYPE_LINK) then return c:GetLink() end
 if c:IsType(TYPE_XYZ) then return c:GetRank() end
 return c:GetLevel()
end
function s.costfilter(c,tp)
 local ct=s.rating(c)
 return s.plant(c) and c:IsReleasable() and ct>0 and Duel.IsPlayerCanDiscardDeck(tp,ct)
end
function s.cost(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.costfilter,tp,LOCATION_MZONE,0,1,nil,tp) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RELEASE)
 local tc=Duel.SelectMatchingCard(tp,s.costfilter,tp,LOCATION_MZONE,0,1,1,nil,tp):GetFirst()
 e:SetLabel(s.rating(tc))
 Duel.Release(tc,REASON_COST)
end
function s.excavate(e,tp)
 local c=e:GetHandler()
 if not c:IsRelateToEffect(e) or not c:IsFaceup() then return end
 local ct=math.min(e:GetLabel(),Duel.GetFieldGroupCount(tp,LOCATION_DECK,0))
 if ct>0 then CCGSylvan.Excavate(e,tp,ct) end
end
