--Nautica Oceanica
--Omega references: Amano-Iwato (c32181268), Summon Over (c48032131)
local s,id=GetID(); local STRING_ID=133941091; local SET_NAUTICA=0x8f0
function s.initial_effect(c)
 local e0=Effect.CreateEffect(c); e0:SetType(EFFECT_TYPE_ACTIVATE); e0:SetCode(EVENT_FREE_CHAIN); c:RegisterEffect(e0)
 local e1=Effect.CreateEffect(c)
 e1:SetType(EFFECT_TYPE_FIELD)
 e1:SetCode(EFFECT_CANNOT_TRIGGER)
 e1:SetRange(LOCATION_FZONE)
 e1:SetTargetRange(LOCATION_MZONE,LOCATION_MZONE)
 e1:SetTarget(s.hand_lock)
 c:RegisterEffect(e1)
 --Summon history is a fact even before this Field Spell becomes active.
 if not s.global_check then
  s.global_check=true
  local ge=Effect.CreateEffect(c)
  ge:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
  ge:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
  ge:SetCode(EVENT_SUMMON_SUCCESS)
  ge:SetOperation(s.track_hand_summon)
  Duel.RegisterEffect(ge,0)
  local ge2=ge:Clone()
  ge2:SetCode(EVENT_SPSUMMON_SUCCESS)
  Duel.RegisterEffect(ge2,0)
 end
 local e3=Effect.CreateEffect(c); e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS); e3:SetCode(EVENT_CHAIN_SOLVED); e3:SetRange(LOCATION_FZONE); e3:SetCondition(s.chcon); e3:SetOperation(s.chop); c:RegisterEffect(e3)
end
function s.track_hand_summon(e,tp,eg)
 for tc in aux.Next(eg) do
  if tc:IsAttackPos() and tc:IsPreviousLocation(LOCATION_HAND) then
   tc:RegisterFlagEffect(id,RESET_EVENT+RESETS_STANDARD,EFFECT_FLAG_CANNOT_DISABLE,1)
  end
 end
end
function s.hand_lock(e,c)
 return c:GetFlagEffect(id)>0 and not c:IsImmuneToEffect(e)
end
function s.hand_origins(ev,category,tp)
 local exists,_,_,player,locations=Duel.GetOperationInfo(ev,category)
 if not exists or not locations or locations&LOCATION_HAND==0 then return 0 end
 if player==PLAYER_ALL then return 3 end
 if player==tp then return 1 end
 if player==1-tp then return 2 end
 return 0
end
function s.chcon(e,tp,eg,ep,ev,re,r,rp)
 if Duel.IsChainDisabled(ev) or rp~=tp or not re:GetHandler():IsSetCard(SET_NAUTICA) then return false end
 local origins=s.hand_origins(ev,CATEGORY_SPECIAL_SUMMON,tp)|s.hand_origins(ev,CATEGORY_SUMMON,tp)
 e:SetLabel(origins)
 return origins~=0
end
function s.nf(c) return c:IsSetCard(SET_NAUTICA) and c:IsType(TYPE_MONSTER) and c:IsAbleToHand() end
function s.chop(e,tp,eg,ep,ev,re)
 if not Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,0)) then return end
 local origins=e:GetLabel()
 local own_hand=origins==1 or (origins==3 and Duel.SelectOption(tp,aux.Stringid(STRING_ID,1),aux.Stringid(STRING_ID,2))==1)
 if own_hand then
  local pending=re:GetHandler():IsCode(259114562) and re:GetLabelObject()
  if pending then s.after_pending(e,tp,pending)
  else s.summon_choice(e,tp) end
 elseif Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.nf),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,nil) then
  Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
  local tc=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.nf),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,1,nil):GetFirst()
  if not tc or Duel.SendtoHand(tc,nil,REASON_EFFECT)==0
   or not tc:IsLocation(LOCATION_HAND) or not tc:IsControler(tp) then return end
  Duel.ConfirmCards(1-tp,tc)
  Duel.BreakEffect()
  if Duel.IsExistingMatchingCard(Card.IsAbleToDeck,tp,LOCATION_HAND,0,1,nil) then
   Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
   local bg=Duel.SelectMatchingCard(tp,Card.IsAbleToDeck,tp,LOCATION_HAND,0,1,1,nil)
   Duel.SendtoDeck(bg,nil,SEQ_DECKBOTTOM,REASON_EFFECT)
  end
 end
end

--Apply the additional outcomes only after the reserved Normal Summon succeeds.
function s.summon_choice(e,tp)
  local p=1-tp
  local normal=function(c) return c:IsSummonable(true,nil) end
  local special=function(c,e,p) return c:IsCanBeSpecialSummoned(e,0,p,false,false,POS_FACEUP_ATTACK) end
  local b1=Duel.IsExistingMatchingCard(normal,p,LOCATION_HAND,0,1,nil); local b2=Duel.IsExistingMatchingCard(special,p,LOCATION_HAND,0,1,nil,e,p)
  if not (b1 or b2) then return end
  local choice=b1 and b2 and Duel.SelectOption(p,1151,1152) or (b1 and 0 or 1)
  Duel.Hint(HINT_SELECTMSG,p,choice==0 and HINTMSG_SUMMON or HINTMSG_SPSUMMON)
  local g=Duel.SelectMatchingCard(p,choice==0 and normal or special,p,LOCATION_HAND,0,1,1,nil,e,p); local tc=g:GetFirst()
  if tc then
   if choice==0 then s.normalfollowup(e,tc) Duel.Summon(p,tc,true,nil)
   else s.specialprocedure(e,p,tc) end
  end
end
function s.after_pending(e,tp,pending)
 local listener=Effect.CreateEffect(e:GetHandler())
 listener:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_CONTINUOUS)
 listener:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
 listener:SetCode(EVENT_SUMMON_SUCCESS)
 listener:SetReset(RESET_EVENT+RESETS_STANDARD-RESET_TOFIELD+RESET_PHASE+PHASE_END)
 local special=listener:Clone()
 special:SetCode(EVENT_SPSUMMON_SUCCESS)
 local function resume()
  listener:Reset()
  special:Reset()
  s.summon_choice(e,tp)
 end
 listener:SetOperation(resume)
 special:SetOperation(resume)
 pending:RegisterEffect(listener)
 pending:RegisterEffect(special)
end
function s.normalfollowup(e,tc,event)
 local se=Effect.CreateEffect(e:GetHandler())
 se:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_CONTINUOUS)
 se:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
 se:SetCode(event or EVENT_SUMMON_SUCCESS)
 se:SetOperation(function(te) s.followup(e,te:GetHandler()) te:Reset() end)
 se:SetReset(RESET_EVENT+RESETS_STANDARD-RESET_TOFIELD+RESET_PHASE+PHASE_END)
 tc:RegisterEffect(se)
 return se
end
function s.specialprocedure(e,p,tc)
 local procedureType=0x5740
 local proc=Effect.CreateEffect(e:GetHandler())
 proc:SetType(EFFECT_TYPE_FIELD)
 proc:SetCode(EFFECT_SPSUMMON_PROC)
 proc:SetProperty(EFFECT_FLAG_SPSUM_PARAM)
 proc:SetRange(LOCATION_HAND)
 proc:SetTargetRange(POS_FACEUP_ATTACK,0)
 proc:SetValue(procedureType)
 proc:SetOperation(function(pe) pe:Reset() end)
 proc:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)
 tc:RegisterEffect(proc)
 local followup=s.normalfollowup(e,tc,EVENT_SPSUMMON_SUCCESS)
 local cleanup=Effect.CreateEffect(e:GetHandler())
 cleanup:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
 cleanup:SetCode(EVENT_CHAIN_END)
 cleanup:SetOperation(function(ce)
  proc:Reset()
  followup:Reset()
  ce:Reset()
 end)
 Duel.RegisterEffect(cleanup,p)
 Duel.SpecialSummonRule(p,tc,procedureType)
end
function s.followup(e,tc)
 local ea=Effect.CreateEffect(e:GetHandler()); ea:SetType(EFFECT_TYPE_SINGLE); ea:SetCode(EFFECT_SET_ATTACK_FINAL); ea:SetValue(0); ea:SetReset(RESET_EVENT+RESETS_STANDARD); tc:RegisterEffect(ea)
 local ei=Effect.CreateEffect(e:GetHandler()); ei:SetType(EFFECT_TYPE_SINGLE); ei:SetCode(EFFECT_IMMUNE_EFFECT); ei:SetValue(function(e,re) return re:GetOwner():IsCode(id) end); ei:SetReset(RESET_EVENT+RESETS_STANDARD); tc:RegisterEffect(ei)
end
