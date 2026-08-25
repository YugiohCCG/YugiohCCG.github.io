--Dinomorphia Hideout
--Omega references: Temple of the Kings (c29762407), Transaction Rollback (c6351147)
local s,id=GetID(); local SET_DINOMORPHIA=0x173; local MSG_ID=133935441
function s.initial_effect(c)
 Duel.AddCustomActivityCounter(id,ACTIVITY_SPSUMMON,function(c) return c:IsSetCard(SET_DINOMORPHIA) end)
 local ea=Effect.CreateEffect(c); ea:SetType(EFFECT_TYPE_ACTIVATE); ea:SetCode(EVENT_FREE_CHAIN); c:RegisterEffect(ea)
 local e0=Effect.CreateEffect(c); e0:SetType(EFFECT_TYPE_SINGLE); e0:SetCode(EFFECT_TRAP_ACT_IN_SET_TURN); e0:SetCondition(function(e) return Duel.GetFieldGroupCount(e:GetHandlerPlayer(),0,LOCATION_ONFIELD)>0 end); c:RegisterEffect(e0)
 local e1=Effect.CreateEffect(c); e1:SetDescription(aux.Stringid(MSG_ID,0)); e1:SetType(EFFECT_TYPE_IGNITION); e1:SetRange(LOCATION_SZONE); e1:SetCountLimit(1,id); e1:SetCost(s.cpcost); e1:SetTarget(s.cptg); e1:SetOperation(s.cpop); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetType(EFFECT_TYPE_FIELD); e2:SetCode(EFFECT_TRAP_ACT_IN_HAND); e2:SetRange(LOCATION_SZONE); e2:SetTargetRange(LOCATION_HAND,0); e2:SetCondition(function(e) local tp=e:GetHandlerPlayer(); return Duel.GetTurnPlayer()==tp and Duel.GetFlagEffect(tp,id+300)==0 end); e2:SetTarget(function(e,c) return c:IsSetCard(SET_DINOMORPHIA) end); c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c); e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS); e3:SetCode(EVENT_CHAINING); e3:SetRange(LOCATION_SZONE); e3:SetCondition(s.handcon); e3:SetOperation(s.handop); c:RegisterEffect(e3)
end
function s.cpf(c) return c:IsSetCard(SET_DINOMORPHIA) and c:IsNormalTrap() and c:IsAbleToGrave() and c:CheckActivateEffect(false,true,false)~=nil end
function s.lock(e,tp) local ex=Effect.CreateEffect(e:GetHandler()); ex:SetType(EFFECT_TYPE_FIELD); ex:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON); ex:SetProperty(EFFECT_FLAG_PLAYER_TARGET); ex:SetTargetRange(1,0); ex:SetTarget(function(e,c) return not c:IsSetCard(SET_DINOMORPHIA) end); ex:SetReset(RESET_PHASE+PHASE_END); Duel.RegisterEffect(ex,tp) end
function s.cpcost(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetCustomActivityCount(id,tp,ACTIVITY_SPSUMMON)==0 and Duel.IsExistingMatchingCard(s.cpf,tp,LOCATION_DECK,0,1,nil) end Duel.PayLPCost(tp,math.floor(Duel.GetLP(tp)/2)); Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE); local tc=Duel.SelectMatchingCard(tp,s.cpf,tp,LOCATION_DECK,0,1,1,nil):GetFirst(); local te=tc:CheckActivateEffect(false,true,true); Duel.SendtoGrave(tc,REASON_COST); e:SetLabelObject(te); s.lock(e,tp) end
function s.cptg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end local te=e:GetLabelObject(); if not te then return end e:SetProperty(te:GetProperty()); local tg=te:GetTarget(); if tg then tg(e,tp,eg,ep,ev,re,r,rp,1) end; te:SetLabelObject(e:GetLabelObject()); e:SetLabelObject(te); Duel.ClearOperationInfo(0) end
function s.cpop(e,tp,eg,ep,ev,re,r,rp) local te=e:GetLabelObject(); if te then e:SetLabelObject(te:GetLabelObject()); local op=te:GetOperation(); if op then op(e,tp,eg,ep,ev,re,r,rp) end end end
function s.handcon(e,tp,eg,ep,ev,re,r,rp) local rc=re:GetHandler(); return rp==tp and re:IsActiveType(TYPE_TRAP) and re:IsHasType(EFFECT_TYPE_ACTIVATE) and re:GetActivateLocation()==LOCATION_HAND and rc:IsSetCard(SET_DINOMORPHIA) end
function s.handop(e,tp) Duel.RegisterFlagEffect(tp,id+300,RESET_PHASE+PHASE_END,0,1) end
