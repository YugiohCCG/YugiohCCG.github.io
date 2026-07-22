local s,id=GetID()
local STRING_ID=133002796
local SET_GALACTICA=0x9c9
local AURIGA=220148485
local FUSION_INTERGALACTICA=245395343
function s.initial_effect(c)
	aux.AddFusionProcFun2(c,function(mc) return mc:IsFusionSetCard(SET_GALACTICA) and mc:IsLevel(2) end,aux.FilterBoolFunction(Card.IsRace,RACE_MACHINE),true) c:EnableReviveLimit()
	local e0=Effect.CreateEffect(c) e0:SetType(EFFECT_TYPE_SINGLE) e0:SetCode(EFFECT_SPSUMMON_CONDITION) e0:SetRange(LOCATION_EXTRA) e0:SetProperty(EFFECT_FLAG_SINGLE_RANGE+EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE) e0:SetValue(s.splimit) c:RegisterEffect(e0)
	local e1=Effect.CreateEffect(c) e1:SetType(EFFECT_TYPE_SINGLE) e1:SetCode(EFFECT_IMMUNE_EFFECT) e1:SetProperty(EFFECT_FLAG_SINGLE_RANGE) e1:SetRange(LOCATION_MZONE) e1:SetValue(s.immval) c:RegisterEffect(e1)
	local e2=Effect.CreateEffect(c) e2:SetType(EFFECT_TYPE_FIELD) e2:SetCode(EFFECT_CANNOT_ATTACK_ANNOUNCE) e2:SetRange(LOCATION_MZONE) e2:SetTargetRange(0,1) c:RegisterEffect(e2)
	local e3=Effect.CreateEffect(c) e3:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_CONTINUOUS) e3:SetCode(EVENT_SPSUMMON_SUCCESS) e3:SetCondition(s.atkcon) e3:SetOperation(s.atkop) c:RegisterEffect(e3)
	local e4=Effect.CreateEffect(c) e4:SetDescription(aux.Stringid(STRING_ID,0)) e4:SetCategory(CATEGORY_REMOVE) e4:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O) e4:SetCode(EVENT_BATTLE_DESTROYING) e4:SetCondition(aux.bdocon) e4:SetCost(s.btcost) e4:SetTarget(s.rmtg) e4:SetOperation(s.rmop) c:RegisterEffect(e4)
	local e5=e4:Clone() e5:SetCode(EVENT_BATTLE_DAMAGE) e5:SetCondition(function(e,tp,eg,ep) return ep==1-tp end) c:RegisterEffect(e5)
end
function s.splimit(e,se,sp,st) return st&SUMMON_TYPE_FUSION==SUMMON_TYPE_FUSION and se and se:GetHandler():IsCode(FUSION_INTERGALACTICA) end
function s.immval(e,re) return re:GetOwnerPlayer()~=e:GetHandlerPlayer() and not Duel.IsBattlePhase() end
function s.atkcon(e) return e:GetHandler():IsSummonType(SUMMON_TYPE_FUSION) and e:GetHandler():GetMaterial():IsExists(Card.IsCode,1,nil,AURIGA) end
function s.atkop(e) local te=Effect.CreateEffect(e:GetHandler()) te:SetType(EFFECT_TYPE_SINGLE) te:SetCode(EFFECT_UPDATE_ATTACK) te:SetValue(1000) te:SetReset(RESET_EVENT+RESETS_STANDARD) e:GetHandler():RegisterEffect(te) end
function s.btcost(e,tp,eg,ep,ev,re,r,rp,chk) local c=e:GetHandler() if chk==0 then return c:GetFlagEffect(id)==0 end c:RegisterFlagEffect(id,RESET_PHASE+PHASE_DAMAGE,0,1) end
function s.rmfilter(c) return c:IsAbleToRemove() end
function s.rmtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.rmfilter,tp,0,LOCATION_ONFIELD,1,nil) end end
function s.rmop(e,tp) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE) local tc=Duel.SelectMatchingCard(tp,s.rmfilter,tp,0,LOCATION_ONFIELD,1,1,nil):GetFirst() if tc then Duel.Remove(tc,POS_FACEUP,REASON_EFFECT) end end
