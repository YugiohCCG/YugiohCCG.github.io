--The Intergalataxian
--Omega references: Predaplant Verte Anaconda (c70369116), Battle Fader (c19665973), Yamato-no-Kami (c82841979)
local s,id=GetID(); local STRING_ID=133792415; local SET_GALACTICA=0x9c9
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c); e1:SetDescription(aux.Stringid(STRING_ID,0)); e1:SetCategory(CATEGORY_TOGRAVE+CATEGORY_SPECIAL_SUMMON); e1:SetType(EFFECT_TYPE_QUICK_O); e1:SetCode(EVENT_FREE_CHAIN); e1:SetRange(LOCATION_HAND); e1:SetHintTiming(0,TIMING_BATTLE_PHASE); e1:SetCountLimit(1,id); e1:SetCondition(function() return Duel.IsBattlePhase() end); e1:SetCost(s.cpcost); e1:SetTarget(s.cptg); e1:SetOperation(s.cpop); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetDescription(aux.Stringid(STRING_ID,1)); e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O); e2:SetCode(EVENT_BATTLE_DESTROYING); e2:SetRange(LOCATION_MZONE); e2:SetCountLimit(1,id+100); e2:SetCondition(s.bpcon); e2:SetOperation(s.endbp); c:RegisterEffect(e2)
 local e3=e2:Clone(); e3:SetCode(EVENT_BATTLE_DAMAGE); e3:SetCondition(s.bdcon); c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c); e4:SetDescription(aux.Stringid(STRING_ID,2)); e4:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_F); e4:SetCode(EVENT_PHASE+PHASE_END); e4:SetRange(LOCATION_MZONE); e4:SetCountLimit(1); e4:SetCondition(function(e,tp) return Duel.GetTurnPlayer()==1-tp end); e4:SetTarget(s.rtg); e4:SetOperation(s.rop); c:RegisterEffect(e4)
end
s.listed_series={SET_GALACTICA}
function s.cpf(c) return c:IsSetCard(SET_GALACTICA) and c:IsSpell() and c:IsAbleToGraveAsCost() and c:CheckActivateEffect(true,true,false)~=nil end
function s.cpcost(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.cpf,tp,LOCATION_DECK,0,1,nil) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE); local tc=Duel.SelectMatchingCard(tp,s.cpf,tp,LOCATION_DECK,0,1,1,nil):GetFirst(); local te=tc:CheckActivateEffect(true,true,true); Duel.SendtoGrave(tc,REASON_COST); e:SetLabelObject(te) end
function s.cptg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end local te=e:GetLabelObject(); if not te then return end e:SetProperty(te:GetProperty()); local tg=te:GetTarget(); if tg then tg(e,tp,eg,ep,ev,re,r,rp,1) end; te:SetLabelObject(e:GetLabelObject()); e:SetLabelObject(te); Duel.ClearOperationInfo(0) end
function s.cpop(e,tp,eg,ep,ev,re,r,rp) local te=e:GetLabelObject(); if te then e:SetLabelObject(te:GetLabelObject()); local op=te:GetOperation(); if op then op(e,tp,eg,ep,ev,re,r,rp) end end local c=e:GetHandler(); if Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and c:IsRelateToEffect(e) then Duel.BreakEffect(); Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP) end end
function s.bpcon(e,tp,eg,ep,ev,re,r,rp) local bc=e:GetHandler():GetBattleTarget(); return Duel.GetTurnPlayer()==1-tp and bc~=nil and eg:IsContains(bc) end
function s.bdcon(e,tp,eg,ep) return Duel.GetTurnPlayer()==1-tp and ep==1-tp and eg:IsExists(function(c) return c:IsControler(tp) end,1,nil) end
function s.endbp(e,tp) Duel.SkipPhase(1-tp,PHASE_BATTLE,RESET_PHASE+PHASE_BATTLE,1) end
function s.rtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return e:GetHandler():IsAbleToHand() end Duel.SetOperationInfo(0,CATEGORY_TOHAND,e:GetHandler(),1,0,0) end
function s.rop(e) local c=e:GetHandler(); if c:IsRelateToEffect(e) then Duel.SendtoHand(c,nil,REASON_EFFECT) end end
