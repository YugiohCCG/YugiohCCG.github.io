--Hannya
--Omega references: Nikitama (c24701235), Shinobaroness Shade Peacock (c33325951)
local s,id=GetID(); local STRING_ID=133560506
function s.initial_effect(c)
 if not s.global_check then s.global_check=true; local ge=Effect.CreateEffect(c); ge:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS); ge:SetCode(EVENT_SUMMON_SUCCESS); ge:SetOperation(s.count); Duel.RegisterEffect(ge,0) end
 local e0=Effect.CreateEffect(c); e0:SetType(EFFECT_TYPE_SINGLE); e0:SetCode(EFFECT_SPSUMMON_CONDITION); e0:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE); e0:SetValue(aux.FALSE); c:RegisterEffect(e0)
 local e1=Effect.CreateEffect(c); e1:SetDescription(aux.Stringid(STRING_ID,0)); e1:SetCategory(CATEGORY_SUMMON); e1:SetType(EFFECT_TYPE_QUICK_O); e1:SetCode(EVENT_FREE_CHAIN); e1:SetRange(LOCATION_HAND); e1:SetCountLimit(1,id); e1:SetCondition(s.nscon); e1:SetCost(s.relcost); e1:SetTarget(s.nstg); e1:SetOperation(s.nsop); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetDescription(aux.Stringid(STRING_ID,1)); e2:SetCategory(CATEGORY_TOHAND); e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O); e2:SetCode(EVENT_RELEASE); e2:SetRange(LOCATION_GRAVE); e2:SetCountLimit(1,id+100); e2:SetCondition(s.thcon); e2:SetCost(aux.bfgcost); e2:SetTarget(s.thtg); e2:SetOperation(s.thop); c:RegisterEffect(e2)
 aux.EnableSpiritReturn(c,EVENT_SUMMON_SUCCESS,EVENT_FLIP)
end
function s.count(e,tp,eg) local p=Duel.GetTurnPlayer(); local old=Duel.GetFlagEffectLabel(p,id+500) or 0; Duel.ResetFlagEffect(p,id+500); Duel.RegisterFlagEffect(p,id+500,RESET_PHASE+PHASE_END,0,1,old+#eg) end
function s.nscon(e,tp) return (Duel.GetFlagEffectLabel(tp,id+500) or 0)>=2 end
function s.relcost(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return e:GetHandler():IsReleasable() end Duel.Release(e:GetHandler(),REASON_COST) end
function s.nsf(c) return c:IsType(TYPE_SPIRIT) and c:IsSummonable(true,nil) end
function s.nstg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.nsf,tp,LOCATION_HAND,0,1,nil) end end
function s.nsop(e,tp) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SUMMON); local g=Duel.SelectMatchingCard(tp,s.nsf,tp,LOCATION_HAND,0,1,1,nil); local tc=g:GetFirst(); if tc then Duel.Summon(tp,tc,true,nil) end end
function s.thcon(e,tp,eg) return eg:IsExists(Card.IsType,1,nil,TYPE_SPIRIT) end
function s.thf(c) return c:IsType(TYPE_SPIRIT) and c:IsAbleToHand() end
function s.compatible(c,g) return g:IsExists(function(x,c) return x~=c and x:GetLevel()~=c:GetLevel() and x:GetAttribute()~=c:GetAttribute() end,1,nil,c) end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk) local g=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.thf),tp,LOCATION_GRAVE,0,nil); if chk==0 then return g:IsExists(s.compatible,1,nil,g) end Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,2,tp,LOCATION_GRAVE) end
function s.thop(e,tp) local g=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.thf),tp,LOCATION_GRAVE,0,nil); local first=g:Filter(s.compatible,nil,g); if #first==0 then return end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND); local a=first:Select(tp,1,1,nil):GetFirst(); local rest=g:Filter(function(c,a) return c~=a and c:GetLevel()~=a:GetLevel() and c:GetAttribute()~=a:GetAttribute() end,nil,a); if #rest==0 then return end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND); local b=rest:Select(tp,1,1,nil):GetFirst(); Duel.SendtoHand(Group.FromCards(a,b),nil,REASON_EFFECT) end
