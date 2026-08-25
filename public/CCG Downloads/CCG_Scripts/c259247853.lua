--Machina X-Krawler
--Omega references: Ghostrick Festival (c35871958), Grapha, Dragon Overlord of Dark World (c39552584)
local s,id=GetID(); local SET_KRAWLER=0x104; local MSG_ID=133247853
function s.initial_effect(c)
 local e0=aux.AddLinkProcedure(c,function(x) return x:IsLinkSetCard(SET_KRAWLER) end,2,4); e0:SetProperty(e0:GetProperty()|EFFECT_FLAG_SET_AVAILABLE); c:EnableReviveLimit()
 local e1=Effect.CreateEffect(c); e1:SetType(EFFECT_TYPE_FIELD); e1:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON); e1:SetRange(LOCATION_MZONE); e1:SetProperty(EFFECT_FLAG_PLAYER_TARGET); e1:SetTargetRange(1,0); e1:SetTarget(function(e,c) return not c:IsSetCard(SET_KRAWLER) end); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetType(EFFECT_TYPE_SINGLE); e2:SetCode(EFFECT_CANNOT_BE_EFFECT_TARGET); e2:SetProperty(EFFECT_FLAG_SINGLE_RANGE); e2:SetRange(LOCATION_MZONE); e2:SetValue(aux.tgoval); c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c); e3:SetDescription(aux.Stringid(MSG_ID,0)); e3:SetCategory(CATEGORY_TOGRAVE); e3:SetType(EFFECT_TYPE_QUICK_O); e3:SetCode(EVENT_CHAINING); e3:SetRange(LOCATION_MZONE); e3:SetCountLimit(1,id); e3:SetCondition(s.chcon); e3:SetCost(s.chcost); e3:SetTarget(s.chtg); e3:SetOperation(s.chop); c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c); e4:SetDescription(aux.Stringid(MSG_ID,1)); e4:SetCategory(CATEGORY_SPECIAL_SUMMON); e4:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O); e4:SetCode(EVENT_LEAVE_FIELD); e4:SetProperty(EFFECT_FLAG_DELAY); e4:SetCountLimit(1,id+100); e4:SetCondition(s.lvcon); e4:SetTarget(s.sptg); e4:SetOperation(s.spop); c:RegisterEffect(e4)
 c:SetUniqueOnField(1,0,id)
end
function s.chcon(e,tp,eg,ep,ev,re,r,rp) return rp==1-tp and re:IsActiveType(TYPE_SPELL+TYPE_TRAP) end
function s.cf(c) return c:IsSetCard(SET_KRAWLER) and c:IsType(TYPE_MONSTER) and c:IsAbleToRemoveAsCost() end
function s.chcost(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.cf,tp,LOCATION_GRAVE,0,2,nil) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE); local g=Duel.SelectMatchingCard(tp,s.cf,tp,LOCATION_GRAVE,0,2,2,nil); Duel.Remove(g,POS_FACEUP,REASON_COST) end
function s.chtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(Card.IsAbleToGrave,tp,LOCATION_MZONE,0,1,nil) end end
function s.chop(e,tp,eg,ep,ev) Duel.ChangeTargetCard(ev,Group.CreateGroup()); Duel.ChangeChainOperation(ev,function(e,tp) local g=Duel.GetMatchingGroup(Card.IsAbleToGrave,tp,0,LOCATION_MZONE,nil); if #g>0 then Duel.Hint(HINT_SELECTMSG,1-tp,HINTMSG_TOGRAVE); local sg=g:Select(1-tp,1,1,nil); Duel.SendtoGrave(sg,REASON_EFFECT) end end) end
function s.lvcon(e,tp,eg,ep,ev,re,r,rp) local c=e:GetHandler(); return c:IsPreviousControler(tp) and c:IsPreviousLocation(LOCATION_MZONE) and c:IsPreviousPosition(POS_FACEUP) and (c:IsReason(REASON_BATTLE) or c:IsReason(REASON_EFFECT) and rp==1-tp) end
function s.spf(c,e,tp) return c:IsSetCard(SET_KRAWLER) and c:IsType(TYPE_LINK) and not c:IsCode(id) and c:IsCanBeSpecialSummoned(e,SUMMON_TYPE_LINK,tp,false,false) end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetLocationCountFromEx(tp)>1 and Duel.GetMatchingGroup(s.spf,tp,LOCATION_EXTRA,0,nil,e,tp):GetClassCount(Card.GetCode)>=2 end Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,2,tp,LOCATION_EXTRA) end
function s.spop(e,tp) if Duel.GetLocationCountFromEx(tp)<2 then return end local g=Duel.GetMatchingGroup(s.spf,tp,LOCATION_EXTRA,0,nil,e,tp); local sg=aux.SelectUnselectGroup(g,e,tp,2,2,aux.dncheck,1,tp,HINTMSG_SPSUMMON); if #sg==2 then for tc in aux.Next(sg) do Duel.SpecialSummonStep(tc,SUMMON_TYPE_LINK,tp,tp,false,false,POS_FACEUP); tc:CompleteProcedure() end Duel.SpecialSummonComplete() end end
