local s,id=GetID()
local STRING_ID=133827483
local SET_GALACTICA=0x9c9
local FUSION_INTERGALACTICA=245395343
function s.initial_effect(c)
	local e00=Effect.CreateEffect(c) e00:SetType(EFFECT_TYPE_SINGLE) e00:SetCode(EFFECT_ADD_SETCODE) e00:SetValue(SET_GALACTICA) c:RegisterEffect(e00)
	aux.AddFusionProcFun2(c,function(mc) return mc:IsFusionSetCard(SET_GALACTICA) and mc:IsLevel(2) end,function(mc) return mc:IsFusionAttribute(ATTRIBUTE_LIGHT) and mc:IsRace(RACE_GALAXY) end,true) c:EnableReviveLimit()
	local e0=Effect.CreateEffect(c) e0:SetType(EFFECT_TYPE_SINGLE) e0:SetCode(EFFECT_SPSUMMON_CONDITION) e0:SetRange(LOCATION_EXTRA) e0:SetProperty(EFFECT_FLAG_SINGLE_RANGE+EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE) e0:SetValue(s.splimit) c:RegisterEffect(e0)
	local e1=Effect.CreateEffect(c) e1:SetType(EFFECT_TYPE_FIELD) e1:SetCode(EFFECT_CANNOT_ATTACK_ANNOUNCE) e1:SetRange(LOCATION_MZONE) e1:SetTargetRange(0,1) c:RegisterEffect(e1)
	local e2=Effect.CreateEffect(c) e2:SetDescription(aux.Stringid(STRING_ID,0)) e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O) e2:SetCode(EVENT_BATTLE_DESTROYING) e2:SetCondition(aux.bdocon) e2:SetCost(s.btcost) e2:SetOperation(s.immop) c:RegisterEffect(e2)
	local e3=e2:Clone() e3:SetCode(EVENT_BATTLE_DAMAGE) e3:SetCondition(function(e,tp,eg,ep) return ep==1-tp end) c:RegisterEffect(e3)
	local e4=Effect.CreateEffect(c) e4:SetDescription(aux.Stringid(STRING_ID,1)) e4:SetCategory(CATEGORY_REMOVE+CATEGORY_SPECIAL_SUMMON) e4:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O) e4:SetCode(EVENT_REMOVE) e4:SetProperty(EFFECT_FLAG_DELAY) e4:SetCondition(function(e) return e:GetHandler():IsPreviousLocation(LOCATION_ONFIELD) end) e4:SetTarget(s.rmtg) e4:SetOperation(s.rmop) c:RegisterEffect(e4)
end
function s.splimit(e,se,sp,st) return st&SUMMON_TYPE_FUSION==SUMMON_TYPE_FUSION and se and se:GetHandler():IsCode(FUSION_INTERGALACTICA) end
function s.btcost(e,tp,eg,ep,ev,re,r,rp,chk) local c=e:GetHandler() if chk==0 then return c:GetFlagEffect(id)==0 end c:RegisterFlagEffect(id,RESET_PHASE+PHASE_DAMAGE,0,1) end
function s.immop(e) local c=e:GetHandler() local te=Effect.CreateEffect(c) te:SetType(EFFECT_TYPE_SINGLE) te:SetCode(EFFECT_IMMUNE_EFFECT) te:SetValue(function(e,re) return re:GetOwnerPlayer()~=e:GetHandlerPlayer() end) te:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_BATTLE_START,2) c:RegisterEffect(te) end
function s.rmfilter(c) return c:IsAbleToRemove() end
function s.rmtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.rmfilter,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,nil) end Duel.SetOperationInfo(0,CATEGORY_REMOVE,nil,1,0,LOCATION_ONFIELD) end
function s.delcon(e,tp) return Duel.IsTurnPlayer(tp) end
function s.delop(e,tp) local c=e:GetLabelObject() if c and c:IsLocation(LOCATION_REMOVED) and aux.NecroValleyFilter(Card.IsCanBeSpecialSummoned)(c,e,0,tp,false,false) and Duel.GetLocationCount(tp,LOCATION_MZONE)>0 then Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP) end e:Reset() end
function s.rmop(e,tp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE) local tc=Duel.SelectMatchingCard(tp,s.rmfilter,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,1,nil):GetFirst() if tc then Duel.Remove(tc,POS_FACEUP,REASON_EFFECT) end
	local c=e:GetHandler() if not c:IsLocation(LOCATION_REMOVED) then return end local ge=Effect.CreateEffect(c) ge:SetDescription(aux.Stringid(STRING_ID,2)) ge:SetCategory(CATEGORY_SPECIAL_SUMMON) ge:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O) ge:SetCode(EVENT_PHASE+PHASE_STANDBY) ge:SetCountLimit(1) ge:SetLabelObject(c) ge:SetCondition(s.delcon) ge:SetOperation(s.delop) ge:SetReset(RESET_PHASE+PHASE_STANDBY,2) Duel.RegisterEffect(ge,tp)
end
