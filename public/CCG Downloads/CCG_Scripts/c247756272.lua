--Kali Yuga - Jakarta
--User clarified "take 2000 LP" as taking 2000 damage.
local s,id=GetID()
local MSG_ID=133756272
function s.initial_effect(c)
 c:EnableReviveLimit()
 aux.AddSynchroProcedure(c,aux.FilterBoolFunction(Card.IsAttribute,ATTRIBUTE_FIRE),aux.NonTuner(Card.IsSetCard,0xa121),1,1)
 local e1=Effect.CreateEffect(c)
 e1:SetType(EFFECT_TYPE_SINGLE)
 e1:SetCode(EFFECT_SPSUMMON_CONDITION)
 e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
 e1:SetValue(function(e,se,sp,st) return not e:GetHandler():IsLocation(LOCATION_EXTRA) or bit.band(st,SUMMON_TYPE_SYNCHRO)==SUMMON_TYPE_SYNCHRO end)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetType(EFFECT_TYPE_FIELD)
 e2:SetCode(EFFECT_SPSUMMON_PROC)
 e2:SetProperty(EFFECT_FLAG_UNCOPYABLE)
 e2:SetRange(LOCATION_EXTRA)
 e2:SetValue(SUMMON_TYPE_SYNCHRO)
 e2:SetCondition(s.proccon)
 e2:SetOperation(s.procop)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetDescription(aux.Stringid(MSG_ID,1))
 e3:SetCategory(CATEGORY_REMOVE)
 e3:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e3:SetCode(EVENT_DESTROYED)
 e3:SetProperty(EFFECT_FLAG_DELAY+EFFECT_FLAG_CARD_TARGET)
 e3:SetCountLimit(1,id+100)
 e3:SetCondition(function(e) return e:GetHandler():IsReason(REASON_BATTLE+REASON_EFFECT) end)
 e3:SetTarget(s.remtg)
 e3:SetOperation(s.remop)
 c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c)
 e4:SetDescription(aux.Stringid(MSG_ID,0))
 e4:SetCategory(CATEGORY_NEGATE+CATEGORY_DAMAGE+CATEGORY_REMOVE)
 e4:SetType(EFFECT_TYPE_QUICK_O)
 e4:SetCode(EVENT_CHAINING)
 e4:SetRange(LOCATION_MZONE)
 e4:SetCountLimit(1,id)
 e4:SetCondition(s.negcon)
 e4:SetTarget(s.negtg)
 e4:SetOperation(s.negop)
 c:RegisterEffect(e4)
end
s.listed_series={0xa121}
function s.material(c)
 return c:IsType(TYPE_MONSTER) and c:GetLevel()>0 and c:IsAbleToRemove()
end
function s.pair(g)
 if #g~=2 then return false end
 local a=g:GetFirst()
 local b=g:GetNext()
 if a:GetLevel()+b:GetLevel()~=8 then return false end
 return (a:IsSetCard(0xa121) and b:IsType(TYPE_TUNER) and b:IsAttribute(ATTRIBUTE_FIRE))
  or (b:IsSetCard(0xa121) and a:IsType(TYPE_TUNER) and a:IsAttribute(ATTRIBUTE_FIRE))
end
function s.proccon(e,c)
 if c==nil then return true end
 local tp=c:GetControler()
 if Duel.GetFlagEffect(tp,id)>0 or Duel.GetLocationCountFromEx(tp,tp,nil,c)<=0 then return false end
 local g=Duel.GetMatchingGroup(s.material,tp,LOCATION_GRAVE,0,nil)
 return g:CheckSubGroup(s.pair,2,2)
end
function s.procop(e,tp,eg,ep,ev,re,r,rp,c)
 local g=Duel.GetMatchingGroup(s.material,tp,LOCATION_GRAVE,0,nil)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
 local sg=g:SelectSubGroup(tp,s.pair,false,2,2)
 if not sg then return end
 c:SetMaterial(sg)
 Duel.Remove(sg,POS_FACEUP,REASON_MATERIAL+REASON_SYNCHRO)
 Duel.RegisterFlagEffect(tp,id,RESET_PHASE+PHASE_END,0,1)
end
function s.remtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 if chkc then return chkc:IsLocation(LOCATION_GRAVE) and chkc:IsAbleToRemove() end
 if chk==0 then return Duel.IsExistingTarget(Card.IsAbleToRemove,tp,LOCATION_GRAVE,LOCATION_GRAVE,1,nil) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
 local g=Duel.SelectTarget(tp,Card.IsAbleToRemove,tp,LOCATION_GRAVE,LOCATION_GRAVE,1,1,nil)
 Duel.SetOperationInfo(0,CATEGORY_REMOVE,g,1,0,0)
end
function s.remop(e,tp)
 local tc=Duel.GetFirstTarget()
 if tc and tc:IsRelateToEffect(e) then Duel.Remove(tc,POS_FACEUP,REASON_EFFECT) end
end

function s.negcon(e,tp,eg,ep,ev,re,r,rp)
 return rp==1-tp and re:IsActiveType(TYPE_SPELL+TYPE_TRAP) and Duel.IsChainDisablable(ev)
end
function s.negtg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return true end
 Duel.SetOperationInfo(0,CATEGORY_NEGATE,eg,1,0,0)
end
function s.negop(e,tp,eg,ep,ev)
 if not Duel.NegateEffect(ev) then return end
 local c=e:GetHandler()
 local opt=0
 if c:IsRelateToEffect(e) and c:IsAbleToRemove() then
  opt=Duel.SelectOption(tp,aux.Stringid(MSG_ID,2),aux.Stringid(MSG_ID,3))
 end
 if opt==0 then Duel.Damage(tp,2000,REASON_EFFECT)
 else Duel.Remove(c,POS_FACEDOWN,REASON_EFFECT) end
end
