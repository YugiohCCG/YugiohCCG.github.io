--World Legacy Calamities
--Omega references: World Legacy Succession (c99674361), World Legacy Pawns (c89320376)
local s,id=GetID(); local SET_WORLD_LEGACY=0xfe; local SET_KRAWLER=0x104; local MSG_ID=133187643
function s.initial_effect(c)
 Duel.AddCustomActivityCounter(id,ACTIVITY_CHAIN,s.chainfilter)
 local e=Effect.CreateEffect(c); e:SetDescription(aux.Stringid(MSG_ID,0)); e:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH+CATEGORY_TOGRAVE); e:SetType(EFFECT_TYPE_ACTIVATE); e:SetCode(EVENT_FREE_CHAIN); e:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH); e:SetTarget(s.acttg); e:SetOperation(s.actop); c:RegisterEffect(e)
 local e2=Effect.CreateEffect(c); e2:SetDescription(aux.Stringid(MSG_ID,1)); e2:SetCategory(CATEGORY_POSITION); e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O); e2:SetCode(EVENT_SPSUMMON_SUCCESS); e2:SetRange(LOCATION_SZONE); e2:SetProperty(EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY); e2:SetCountLimit(1,id+100); e2:SetTarget(s.postg); e2:SetOperation(s.posop); c:RegisterEffect(e2)
 local e3=e2:Clone(); e3:SetCode(EVENT_MSET); c:RegisterEffect(e3)
end
function s.chainfilter(re) return not re:IsActiveType(TYPE_SPELL+TYPE_TRAP) or re:GetHandler():IsSetCard(SET_WORLD_LEGACY) end
function s.wlf(c) return c:IsSetCard(SET_WORLD_LEGACY) and c:IsSpellTrap() and not c:IsCode(id) and (c:IsAbleToHand() or c:IsAbleToGrave()) end
function s.lock(e,tp) local ex=Effect.CreateEffect(e:GetHandler()); ex:SetType(EFFECT_TYPE_FIELD); ex:SetCode(EFFECT_CANNOT_ACTIVATE); ex:SetProperty(EFFECT_FLAG_PLAYER_TARGET); ex:SetTargetRange(1,0); ex:SetValue(function(e,re) return re:IsActiveType(TYPE_SPELL+TYPE_TRAP) and not re:GetHandler():IsSetCard(SET_WORLD_LEGACY) end); ex:SetReset(RESET_PHASE+PHASE_END); Duel.RegisterEffect(ex,tp) end
function s.acttg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetCustomActivityCount(id,tp,ACTIVITY_CHAIN)==0 and Duel.IsExistingMatchingCard(s.wlf,tp,LOCATION_DECK,0,1,nil) end s.lock(e,tp) end
function s.actop(e,tp) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SELECT); local g=Duel.SelectMatchingCard(tp,s.wlf,tp,LOCATION_DECK,0,1,1,nil); local tc=g:GetFirst(); if not tc then return end local op=0; if tc:IsAbleToHand() and tc:IsAbleToGrave() then op=Duel.SelectOption(tp,1190,1191) elseif tc:IsAbleToGrave() then op=1 end if op==0 then Duel.SendtoHand(tc,nil,REASON_EFFECT); Duel.ConfirmCards(1-tp,tc) else Duel.SendtoGrave(tc,REASON_EFFECT) end end
function s.pf(c) return c:IsFacedown() and c:IsCanChangePosition() end
function s.postg(e,tp,eg,ep,ev,re,r,rp,chk,chkc) if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and s.pf(chkc) end if chk==0 then return Duel.IsExistingTarget(s.pf,tp,LOCATION_MZONE,0,1,nil) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_POSCHANGE); local g=Duel.SelectTarget(tp,s.pf,tp,LOCATION_MZONE,0,1,1,nil); Duel.SetOperationInfo(0,CATEGORY_POSITION,g,1,0,0) end
function s.posop(e,tp) local tc=Duel.GetFirstTarget(); if tc:IsRelateToEffect(e) and Duel.ChangePosition(tc,POS_FACEUP_DEFENSE)>0 and not tc:IsSetCard(SET_KRAWLER) then local ex=Effect.CreateEffect(e:GetHandler()); ex:SetType(EFFECT_TYPE_SINGLE); ex:SetCode(EFFECT_CANNOT_TRIGGER); ex:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END); tc:RegisterEffect(ex) end end
