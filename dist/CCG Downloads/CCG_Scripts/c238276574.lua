--Sylvan Flamioak
Duel.LoadScript("ccg_sylvan.lua")
local s,id=GetID()
local SET_SYLVAN=0x90
local MSG_ID=132276574
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_DECKDES)
 e1:SetType(EFFECT_TYPE_IGNITION)
 e1:SetRange(LOCATION_MZONE)
 e1:SetCountLimit(1)
 e1:SetTarget(s.exctg)
 e1:SetOperation(s.excop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
 e2:SetCode(EVENT_SPSUMMON_SUCCESS)
 e2:SetRange(LOCATION_HAND+LOCATION_GRAVE)
 e2:SetProperty(EFFECT_FLAG_DELAY)
 e2:SetCountLimit(1,id)
 e2:SetCondition(s.spcon)
 e2:SetTarget(s.sptg)
 e2:SetOperation(s.spop)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetDescription(aux.Stringid(MSG_ID,2))
 e3:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH)
 e3:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e3:SetCode(EVENT_SUMMON_SUCCESS)
 e3:SetProperty(EFFECT_FLAG_DELAY)
 e3:SetCountLimit(1,id+100)
 e3:SetTarget(s.thtg)
 e3:SetOperation(s.thop)
 c:RegisterEffect(e3)
 local e4=e3:Clone()
 e4:SetCode(EVENT_SPSUMMON_SUCCESS)
 c:RegisterEffect(e4)
end
s.listed_series={SET_SYLVAN}
function s.exctg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsPlayerCanDiscardDeck(tp,1) end
end
function s.excop(e,tp)
 if not Duel.IsPlayerCanDiscardDeck(tp,1) then return end
 local max=math.min(3,Duel.GetFieldGroupCount(tp,LOCATION_DECK,0))
 if max==0 then return end
 local numbers={}
 for i=1,max do numbers[i]=i end
 Duel.Hint(HINT_SELECTMSG,tp,aux.Stringid(MSG_ID,0))
 local ct=Duel.AnnounceNumber(tp,table.unpack(numbers))
 CCGSylvan.Excavate(e,tp,ct)
end
function s.spcon(e,tp,eg)
 return eg:IsExists(function(c) return c:IsSetCard(SET_SYLVAN) and c:IsType(TYPE_MONSTER) end,1,nil)
end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and e:GetHandler():IsCanBeSpecialSummoned(e,0,tp,false,false) end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,e:GetHandler(),1,tp,LOCATION_HAND+LOCATION_GRAVE)
end
function s.spop(e,tp)
 local c=e:GetHandler()
 if c:IsRelateToEffect(e) then Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP) end
end
function s.thfilter(c)
 return c:IsSetCard(SET_SYLVAN) and c:IsType(TYPE_SPELL+TYPE_TRAP) and c:IsAbleToHand()
end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.thfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK+LOCATION_GRAVE)
end
function s.thop(e,tp)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
 local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.thfilter),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,1,nil)
 if #g>0 then Duel.SendtoHand(g,nil,REASON_EFFECT) Duel.ConfirmCards(1-tp,g) end
end
