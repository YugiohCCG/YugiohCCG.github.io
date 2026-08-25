--World Legacy Crusadia Counter
--Omega references: Dogmatika Punishment (c82956214), Crusadia Krawler (c55838342)
local s,id=GetID(); local SET_WORLD_LEGACY=0xfe; local SET_CRUSADIA=0x116
function s.initial_effect(c)
 Duel.AddCustomActivityCounter(id,ACTIVITY_CHAIN,s.chainfilter)
 local e=Effect.CreateEffect(c); e:SetCategory(CATEGORY_NEGATE+CATEGORY_DESTROY); e:SetType(EFFECT_TYPE_ACTIVATE); e:SetCode(EVENT_CHAINING); e:SetCountLimit(1,id); e:SetCondition(s.con); e:SetTarget(s.tg); e:SetOperation(s.op); c:RegisterEffect(e)
 local e2=Effect.CreateEffect(c); e2:SetType(EFFECT_TYPE_SINGLE); e2:SetCode(EFFECT_TRAP_ACT_IN_HAND); e2:SetCondition(function(e) return not Duel.IsExistingMatchingCard(Card.IsFaceup,e:GetHandlerPlayer(),LOCATION_ONFIELD,0,1,nil) end); c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c); e3:SetCategory(CATEGORY_SPECIAL_SUMMON); e3:SetType(EFFECT_TYPE_IGNITION); e3:SetRange(LOCATION_GRAVE); e3:SetCountLimit(1,id); e3:SetCost(aux.bfgcost); e3:SetTarget(s.sptg); e3:SetOperation(s.spop); c:RegisterEffect(e3)
end
function s.chainfilter(re) return not re:IsActiveType(TYPE_SPELL+TYPE_TRAP) or re:GetHandler():IsSetCard(SET_WORLD_LEGACY) or re:GetHandler():IsSetCard(SET_CRUSADIA) end
function s.con(e,tp,eg,ep,ev,re,r,rp) local rc=re:GetHandler(); return rc:IsType(TYPE_LINK) and rc:IsLocation(LOCATION_MZONE) and rc:GetSequence()>4 and Duel.IsChainNegatable(ev) end
function s.exf(c,atk) return c:IsType(TYPE_LINK) and c:IsAttackAbove(atk+1) end
function s.tg(e,tp,eg,ep,ev,re,r,rp,chk) local rc=re:GetHandler(); if chk==0 then return Duel.IsExistingMatchingCard(s.exf,tp,LOCATION_EXTRA,0,1,nil,rc:GetAttack()) end e:SetLabel(rc:GetAttack(),rc:GetLink()); Duel.SetOperationInfo(0,CATEGORY_NEGATE,eg,1,0,0) end
function s.op(e,tp,eg,ep,ev,re) local atk,link=e:GetLabel(); local g=Duel.GetMatchingGroup(s.exf,tp,LOCATION_EXTRA,0,nil,atk); if #g==0 then return end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_CONFIRM); local tc=g:Select(tp,1,1,nil):GetFirst(); Duel.ConfirmCards(1-tp,tc); Duel.ShuffleExtra(tp); if Duel.NegateEffect(ev) and re:GetHandler():IsRelateToEffect(re) and tc:GetLink()<link then Duel.Destroy(re:GetHandler(),REASON_EFFECT) end end
function s.wlm(c,e,tp) return c:IsSetCard(SET_WORLD_LEGACY) and c:IsType(TYPE_MONSTER) and c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEUP_DEFENSE) end
function s.stlock(e,tp) local ex=Effect.CreateEffect(e:GetHandler()); ex:SetType(EFFECT_TYPE_FIELD); ex:SetCode(EFFECT_CANNOT_ACTIVATE); ex:SetProperty(EFFECT_FLAG_PLAYER_TARGET); ex:SetTargetRange(1,0); ex:SetValue(function(e,re) return re:IsActiveType(TYPE_SPELL+TYPE_TRAP) and not (re:GetHandler():IsSetCard(SET_WORLD_LEGACY) or re:GetHandler():IsSetCard(SET_CRUSADIA)) end); ex:SetReset(RESET_PHASE+PHASE_END); Duel.RegisterEffect(ex,tp) end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetCustomActivityCount(id,tp,ACTIVITY_CHAIN)==0 and Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and Duel.IsExistingMatchingCard(s.wlm,tp,LOCATION_DECK,0,1,nil,e,tp) end s.stlock(e,tp); Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_DECK) end
function s.spop(e,tp) if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON); local g=Duel.SelectMatchingCard(tp,s.wlm,tp,LOCATION_DECK,0,1,1,nil,e,tp); if #g>0 then Duel.SpecialSummon(g,0,tp,tp,false,false,POS_FACEUP_DEFENSE) end end
