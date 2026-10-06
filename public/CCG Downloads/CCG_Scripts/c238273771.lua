--Symphonic Warrior Mettronomo
--Omega: c43210483 Amplifire condition; utility.lua subgroup selection.
local s,id=GetID()
local SET_SYMPHONIC=0x1066
local MSG_ID=132273771
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetType(EFFECT_TYPE_FIELD)
 e1:SetCode(EFFECT_SPSUMMON_PROC)
 e1:SetProperty(EFFECT_FLAG_UNCOPYABLE)
 e1:SetRange(LOCATION_HAND)
 e1:SetCountLimit(1,id)
 e1:SetCondition(s.spcon)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,0))
 e2:SetCategory(CATEGORY_SPECIAL_SUMMON)
 e2:SetType(EFFECT_TYPE_IGNITION)
 e2:SetRange(LOCATION_MZONE)
 e2:SetCountLimit(1,id+100)
 e2:SetCost(s.tribute)
 e2:SetTarget(s.decktg)
 e2:SetOperation(s.deckop)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetDescription(aux.Stringid(MSG_ID,1))
 e3:SetType(EFFECT_TYPE_IGNITION)
 e3:SetRange(LOCATION_GRAVE)
 e3:SetProperty(EFFECT_FLAG_CARD_TARGET)
 e3:SetCountLimit(1,id+200)
 e3:SetCost(aux.bfgcost)
 e3:SetTarget(s.leveltg)
 e3:SetOperation(s.levelop)
 c:RegisterEffect(e3)
end
function s.amplifire(c)
 return c:IsFaceup() and c:IsCode(75304793)
end
function s.spcon(e,c)
 if c==nil then return true end
 local tp=c:GetControler()
 return Duel.GetLocationCount(tp,LOCATION_MZONE)>0
  and Duel.IsExistingMatchingCard(s.amplifire,tp,LOCATION_ONFIELD,0,1,nil)
end
function s.deckfilter(c,e,tp)
 return c:IsSetCard(SET_SYMPHONIC) and c:GetLevel()>0
  and c:IsCanBeSpecialSummoned(e,0,tp,false,false)
end
function s.maxcount(tp,rc)
 local n=Duel.GetMZoneCount(tp,rc,tp)
 if Duel.IsPlayerAffectedByEffect(tp,59822133) then n=math.min(n,1) end
 return math.min(n,5)
end
function s.sumcheck(g,lv)
 return g:GetClassCount(Card.GetCode)==#g and g:GetSum(Card.GetLevel)==lv
end
function s.tributefilter(c,e,tp)
 if not c:IsSetCard(SET_SYMPHONIC) or not c:IsReleasable() or c:GetLevel()<=0 then return false end
 local max=s.maxcount(tp,c)
 if max<1 then return false end
 local g=Duel.GetMatchingGroup(s.deckfilter,tp,LOCATION_DECK,0,nil,e,tp)
 return g:CheckSubGroup(s.sumcheck,1,max,c:GetLevel())
end
function s.tribute(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.tributefilter,tp,LOCATION_MZONE,0,1,nil,e,tp) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RELEASE)
 local tc=Duel.SelectMatchingCard(tp,s.tributefilter,tp,LOCATION_MZONE,0,1,1,nil,e,tp):GetFirst()
 e:SetLabel(tc:GetLevel())
 Duel.Release(tc,REASON_COST)
end
function s.decktg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return true end
 Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_DECK)
end
function s.deckop(e,tp)
 local max=s.maxcount(tp,nil)
 if max<1 then return end
 local g=Duel.GetMatchingGroup(s.deckfilter,tp,LOCATION_DECK,0,nil,e,tp)
 local lv=e:GetLabel()
 if not g:CheckSubGroup(s.sumcheck,1,max,lv) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
 local sg=g:SelectSubGroup(tp,s.sumcheck,false,1,max,lv)
 if sg and #sg>0 then Duel.SpecialSummon(sg,0,tp,tp,false,false,POS_FACEUP) end
end
function s.leveltarget(c)
 return c:IsFaceup() and c:IsSetCard(SET_SYMPHONIC) and c:GetLevel()>0
end
function s.leveltg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and s.leveltarget(chkc) end
 if chk==0 then return Duel.IsExistingTarget(s.leveltarget,tp,LOCATION_MZONE,0,1,nil) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
 Duel.SelectTarget(tp,s.leveltarget,tp,LOCATION_MZONE,0,1,1,nil)
end
function s.levelop(e,tp)
 local tc=Duel.GetFirstTarget()
 if not tc or not tc:IsRelateToEffect(e) or not tc:IsFaceup() then return end
 local n=1
 if tc:GetLevel()>1 and Duel.SelectOption(tp,aux.Stringid(MSG_ID,2),aux.Stringid(MSG_ID,3))==1 then n=-1 end
 local lv=Effect.CreateEffect(e:GetHandler())
 lv:SetType(EFFECT_TYPE_SINGLE)
 lv:SetCode(EFFECT_UPDATE_LEVEL)
 lv:SetValue(n)
 lv:SetReset(RESET_EVENT+RESETS_STANDARD)
 tc:RegisterEffect(lv)
end
