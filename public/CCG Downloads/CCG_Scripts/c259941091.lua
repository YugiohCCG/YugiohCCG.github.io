--Nautica Oceanica
--Omega references: Amano-Iwato (c32181268), Summon Over (c48032131)
local s,id=GetID(); local STRING_ID=133941091; local SET_NAUTICA=0x8f0
function s.initial_effect(c)
 local e0=Effect.CreateEffect(c); e0:SetType(EFFECT_TYPE_ACTIVATE); e0:SetCode(EVENT_FREE_CHAIN); c:RegisterEffect(e0)
 local e1=Effect.CreateEffect(c); e1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS); e1:SetCode(EVENT_SUMMON_SUCCESS); e1:SetRange(LOCATION_FZONE); e1:SetOperation(s.lockop); c:RegisterEffect(e1); local e2=e1:Clone(); e2:SetCode(EVENT_SPSUMMON_SUCCESS); c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c); e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS); e3:SetCode(EVENT_CHAIN_SOLVED); e3:SetRange(LOCATION_FZONE); e3:SetCondition(s.chcon); e3:SetOperation(s.chop); c:RegisterEffect(e3)
end
function s.source_active(e) local fc=e:GetOwner(); return fc:IsFaceup() and fc:IsLocation(LOCATION_FZONE) and fc:GetFieldID()==e:GetLabel() end
function s.lockop(e,tp,eg) local fc=e:GetHandler(); for tc in aux.Next(eg) do if tc:IsAttackPos() and tc:IsPreviousLocation(LOCATION_HAND) then local ex=Effect.CreateEffect(fc); ex:SetType(EFFECT_TYPE_SINGLE); ex:SetCode(EFFECT_CANNOT_TRIGGER); ex:SetCondition(s.source_active); ex:SetLabel(fc:GetFieldID()); ex:SetReset(RESET_EVENT+RESETS_STANDARD); tc:RegisterEffect(ex) end end end
function s.chcon(e,tp,eg,ep,ev,re,r,rp) if rp~=tp or not re:GetHandler():IsSetCard(SET_NAUTICA) then return false end local ex,_,_,p,loc=Duel.GetOperationInfo(ev,CATEGORY_SPECIAL_SUMMON); if not ex then ex,_,_,p,loc=Duel.GetOperationInfo(ev,CATEGORY_SUMMON) end if ex and loc and loc&LOCATION_HAND~=0 then e:SetLabel(p); return true end return false end
function s.nf(c) return c:IsSetCard(SET_NAUTICA) and c:IsType(TYPE_MONSTER) and c:IsAbleToHand() end
function s.chop(e,tp)
 if not Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,0)) then return end
 if e:GetLabel()==tp then
  local p=1-tp; if Duel.GetLocationCount(p,LOCATION_MZONE)<=0 then return end
  local normal=function(c) return c:IsSummonable(true,nil) end
  local special=function(c,e,p) return c:IsCanBeSpecialSummoned(e,0,p,false,false,POS_FACEUP_ATTACK) end
  local b1=Duel.IsExistingMatchingCard(normal,p,LOCATION_HAND,0,1,nil); local b2=Duel.IsExistingMatchingCard(special,p,LOCATION_HAND,0,1,nil,e,p)
  if not (b1 or b2) then return end
  local choice=b1 and b2 and Duel.SelectOption(p,1151,1152) or (b1 and 0 or 1)
  Duel.Hint(HINT_SELECTMSG,p,choice==0 and HINTMSG_SUMMON or HINTMSG_SPSUMMON)
  local g=Duel.SelectMatchingCard(p,choice==0 and normal or special,p,LOCATION_HAND,0,1,1,nil,e,p); local tc=g:GetFirst(); local done=0
  if tc then if choice==0 then done=Duel.Summon(p,tc,true,nil) else done=Duel.SpecialSummon(tc,0,p,p,false,false,POS_FACEUP_ATTACK) end end
  if done>0 then local ea=Effect.CreateEffect(e:GetHandler()); ea:SetType(EFFECT_TYPE_SINGLE); ea:SetCode(EFFECT_SET_ATTACK_FINAL); ea:SetValue(0); ea:SetReset(RESET_EVENT+RESETS_STANDARD); tc:RegisterEffect(ea); local ei=Effect.CreateEffect(e:GetHandler()); ei:SetType(EFFECT_TYPE_SINGLE); ei:SetCode(EFFECT_IMMUNE_EFFECT); ei:SetValue(function(e,re) return re:GetOwner()==e:GetOwner() end); ei:SetReset(RESET_EVENT+RESETS_STANDARD); tc:RegisterEffect(ei) end
 elseif Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.nf),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,nil) then
  Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND); local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.nf),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,1,nil)
  if Duel.SendtoHand(g,nil,REASON_EFFECT)>0 then Duel.ConfirmCards(1-tp,g); if Duel.GetFieldGroupCount(tp,LOCATION_HAND,0)>0 then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK); local bg=Duel.SelectMatchingCard(tp,Card.IsAbleToDeck,tp,LOCATION_HAND,0,1,1,nil); Duel.SendtoDeck(bg,nil,SEQ_DECKBOTTOM,REASON_EFFECT) end end
 end
end
