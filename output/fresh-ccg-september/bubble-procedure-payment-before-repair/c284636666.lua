--Aquamarine Bubble Colony
--Omega references: c12381100 (custom Fusion material condition),
-- c41685633 (Extra Deck alternate Summon by banishing materials).
local s,id=GetID()
local SET_AQUAMARINE=0x0f3c
local MSG_ID=132636666
function s.initial_effect(c)
 c:EnableReviveLimit()
 c:SetUniqueOnField(1,0,id)
 local e0=Effect.CreateEffect(c)
 e0:SetType(EFFECT_TYPE_SINGLE)
 e0:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
 e0:SetCode(EFFECT_FUSION_MATERIAL)
 e0:SetCondition(s.fusioncon)
 e0:SetOperation(s.fusionop)
 c:RegisterEffect(e0)
 local e1=Effect.CreateEffect(c)
 e1:SetType(EFFECT_TYPE_SINGLE)
 e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
 e1:SetCode(EFFECT_SPSUMMON_CONDITION)
 e1:SetValue(aux.fuslimit)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,0))
 e2:SetType(EFFECT_TYPE_FIELD)
 e2:SetCode(EFFECT_SPSUMMON_PROC)
 e2:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE)
 e2:SetRange(LOCATION_EXTRA)
 e2:SetCondition(s.altcon)
 e2:SetTarget(s.alttg)
 e2:SetOperation(s.altop)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetType(EFFECT_TYPE_SINGLE)
 e3:SetCode(EFFECT_INDESTRUCTABLE_BATTLE)
 e3:SetCondition(s.battlecon)
 e3:SetValue(1)
 c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c)
 e4:SetType(EFFECT_TYPE_FIELD)
 e4:SetCode(EFFECT_EXTRA_ATTACK)
 e4:SetRange(LOCATION_MZONE)
 e4:SetTargetRange(LOCATION_MZONE,0)
 e4:SetTarget(s.attacktarget)
 e4:SetValue(s.attackvalue)
 c:RegisterEffect(e4)
end
function s.fusionfilter(c,fc)
 return c:IsType(TYPE_MONSTER) and c:IsSetCard(SET_AQUAMARINE)
  and c:IsCanBeFusionMaterial(fc)
end
function s.namecheck(g,fc,tp,gc,chkf)
 if gc and not g:IsContains(gc) then return false end
 if g:GetClassCount(Card.GetCode)~=#g then return false end
 if g:IsExists(aux.TuneMagicianCheckX,1,nil,g,EFFECT_TUNE_MAGICIAN_F) then return false end
 if not aux.MustMaterialCheck(g,tp,EFFECT_MUST_BE_FMATERIAL) then return false end
 if chkf~=PLAYER_NONE and Duel.GetLocationCountFromEx(tp,tp,g,fc)<=0 then return false end
 if aux.FCheckAdditional and not aux.FCheckAdditional(tp,g,fc) then return false end
 if aux.FGoalCheckAdditional and not aux.FGoalCheckAdditional(tp,g,fc) then return false end
 return true
end
function s.fusioncon(e,g,gc,chkf)
 local tp=e:GetHandlerPlayer()
 if g==nil then return aux.MustMaterialCheck(nil,tp,EFFECT_MUST_BE_FMATERIAL) end
 local fc=e:GetHandler()
 local mg=g:Filter(s.fusionfilter,nil,fc)
 if gc and not mg:IsContains(gc) then return false end
 return mg:CheckSubGroup(s.namecheck,2,#mg,fc,tp,gc,chkf)
end
function s.fusionop(e,tp,eg,ep,ev,re,r,rp,gc,chkf)
 local fc=e:GetHandler()
 local mg=eg:Filter(s.fusionfilter,nil,fc)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_FMATERIAL)
 local g=mg:SelectSubGroup(tp,s.namecheck,false,2,#mg,fc,tp,gc,chkf)
 if g then Duel.SetFusionMaterial(g) end
end
function s.altfilter(c,fc)
 return c:IsType(TYPE_MONSTER) and c:IsSetCard(SET_AQUAMARINE)
  and c:IsAbleToRemoveAsCost() and c:IsCanBeFusionMaterial(fc,SUMMON_TYPE_SPECIAL)
end
function s.altcheck(g,tp,fc)
 return g:GetClassCount(Card.GetCode)==#g
  and Duel.GetLocationCountFromEx(tp,tp,nil,fc)>0
end
function s.altcon(e,c)
 if c==nil then return true end
 local tp=c:GetControler()
 local g=Duel.GetMatchingGroup(s.altfilter,tp,LOCATION_GRAVE,0,nil,c)
 return #g>=2 and g:CheckSubGroup(s.altcheck,2,#g,tp,c)
end
function s.alttg(e,tp,eg,ep,ev,re,r,rp,chk,c)
 local g=Duel.GetMatchingGroup(s.altfilter,tp,LOCATION_GRAVE,0,nil,c)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE)
 local sg=g:SelectSubGroup(tp,s.altcheck,true,2,#g,tp,c)
 if not sg then return false end
 sg:KeepAlive()
 e:SetLabelObject(sg)
 return true
end
function s.altop(e,tp,eg,ep,ev,re,r,rp,c)
 local g=e:GetLabelObject()
 if not g then return end
 c:SetMaterial(g)
 Duel.Remove(g,POS_FACEUP,REASON_SPSUMMON)
 g:DeleteGroup()
end
function s.otheraqua(c,handler)
 return c~=handler and c:IsFaceup() and c:IsSetCard(SET_AQUAMARINE)
end
function s.battlecon(e)
 local c=e:GetHandler()
 return Duel.IsExistingMatchingCard(s.otheraqua,c:GetControler(),LOCATION_MZONE,0,1,c,c)
end
function s.attacktarget(e,c)
 return c:IsFaceup() and c:IsType(TYPE_FUSION)
  and c:IsSetCard(SET_AQUAMARINE) and c:IsLevelAbove(7)
end
function s.otherfusion(c,attacker)
 return c~=attacker and c:IsFaceup() and c:IsType(TYPE_FUSION)
  and c:IsSetCard(SET_AQUAMARINE) and c:IsLevelAbove(7)
  and not c:IsCode(attacker:GetCode())
end
function s.attackvalue(e,c)
 local g=Duel.GetMatchingGroup(s.otherfusion,c:GetControler(),LOCATION_MZONE,0,nil,c)
 return math.max(0,g:GetClassCount(Card.GetCode)-1)
end
