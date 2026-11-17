--Terror Blossom from Overroot
--Omega references: c63086455 (Set from GY), c100259001 (activate Set Trap), c101204073 (overlay).
local s,id=GetID()
local SET_OVERROOT=0xA112
local SET_RROOT=0xA110
local MSG_ID=132272439
function s.initial_effect(c)
 c:EnableReviveLimit()
 aux.AddXyzProcedure(c,nil,1,2)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_SSET)
 e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O)
 e1:SetProperty(EFFECT_FLAG_DELAY)
 e1:SetCode(EVENT_SPSUMMON_SUCCESS)
 e1:SetCountLimit(1,id)
 e1:SetTarget(s.settg)
 e1:SetOperation(s.setop)
 c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_SSET+CATEGORY_MSET)
 e2:SetType(EFFECT_TYPE_QUICK_O)
 e2:SetCode(EVENT_FREE_CHAIN)
 e2:SetRange(LOCATION_MZONE)
 e2:SetProperty(EFFECT_FLAG_CARD_TARGET)
 e2:SetCountLimit(1,id+100)
 e2:SetTarget(s.attachtg)
 e2:SetOperation(s.attachop)
 c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c)
 e3:SetDescription(aux.Stringid(MSG_ID,2))
 e3:SetCategory(CATEGORY_TOGRAVE+CATEGORY_SPECIAL_SUMMON)
 e3:SetType(EFFECT_TYPE_QUICK_O)
 e3:SetCode(EVENT_FREE_CHAIN)
 e3:SetRange(LOCATION_MZONE)
 e3:SetProperty(EFFECT_FLAG_CARD_TARGET)
 e3:SetHintTiming(0,TIMING_ATTACK)
 e3:SetCondition(s.batcon)
 e3:SetTarget(s.battg)
 e3:SetOperation(s.batop)
 c:RegisterEffect(e3)
end
function s.setfilter(c)
 return (c:IsSetCard(SET_OVERROOT) or c:IsCode(63086455)) and c:IsType(TYPE_TRAP) and c:IsSSetable()
end
function s.settg(e,tp,eg,ep,ev,re,r,rp,chk)
 if chk==0 then return Duel.IsExistingMatchingCard(s.setfilter,tp,LOCATION_DECK,0,1,nil) end
 Duel.SetOperationInfo(0,CATEGORY_SSET,nil,1,tp,LOCATION_DECK)
end
function s.setop(e,tp)
 if not Duel.IsExistingMatchingCard(s.setfilter,tp,LOCATION_DECK,0,1,nil) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SET)
 local g=Duel.SelectMatchingCard(tp,s.setfilter,tp,LOCATION_DECK,0,1,1,nil)
 local tc=g:GetFirst()
 if tc and Duel.SSet(tp,tc)>0 then
  local act=Effect.CreateEffect(e:GetHandler())
  act:SetType(EFFECT_TYPE_SINGLE)
  act:SetProperty(EFFECT_FLAG_SET_AVAILABLE)
  act:SetCode(EFFECT_TRAP_ACT_IN_SET_TURN)
  act:SetReset(RESET_EVENT+RESETS_STANDARD)
  tc:RegisterEffect(act)
 end
end
function s.placeoptions(c,e,tp,player,fc)
 local mz=Duel.GetMZoneCount(player,fc,tp)>0
 local sz=Duel.GetSZoneCount(player,fc,tp)>0 or c:IsType(TYPE_FIELD)
 local set=mz and c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEDOWN_DEFENSE,player)
  or sz and c:IsSSetable(true)
 local summon=mz and c:IsType(TYPE_MONSTER) and c:IsSetCard(SET_RROOT)
  and c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEUP,player)
 return set,summon
end
function s.placefilter(c,e,tp,player,fc)
 if not c:IsCanBeEffectTarget(e) then return false end
 local set,summon=s.placeoptions(c,e,tp,player,fc)
 return set or summon
end
function s.fieldfilter(c,e,tp)
 if c==e:GetHandler() or not c:IsCanOverlay() or not c:IsCanBeEffectTarget(e) then return false end
 local player=c:GetControler()
 return Duel.IsExistingTarget(s.placefilter,player,LOCATION_GRAVE+LOCATION_REMOVED,0,1,nil,e,tp,player,c)
end
function s.attachtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 if chkc then return false end
 if chk==0 then return Duel.IsExistingTarget(s.fieldfilter,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,nil,e,tp) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_XMATERIAL)
 local fg=Duel.SelectTarget(tp,s.fieldfilter,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,1,nil,e,tp)
 local fc=fg:GetFirst()
 local player=fc:GetControler()
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TARGET)
 local rg=Duel.SelectTarget(tp,s.placefilter,player,LOCATION_GRAVE+LOCATION_REMOVED,0,1,1,nil,e,tp,player,fc)
 fg:Merge(rg)
 fg:KeepAlive()
 e:SetLabelObject(fg)
 e:SetLabel(player)
end
function s.attachop(e,tp)
 local kept=e:GetLabelObject()
 if not kept then return end
 e:SetLabelObject(nil)
 local g=kept:Filter(Card.IsRelateToEffect,nil,e)
 kept:DeleteGroup()
 local fc=g:Filter(Card.IsLocation,nil,LOCATION_ONFIELD):GetFirst()
 local tc=g:Filter(Card.IsLocation,nil,LOCATION_GRAVE+LOCATION_REMOVED):GetFirst()
 local c=e:GetHandler()
 if not c:IsRelateToEffect(e) or not c:IsFaceup() or not c:IsLocation(LOCATION_MZONE)
  or not fc or fc:IsImmuneToEffect(e) or not fc:IsCanOverlay() then return end
 local og=fc:GetOverlayGroup()
 if #og>0 then Duel.SendtoGrave(og,REASON_RULE) end
 Duel.Overlay(c,Group.FromCards(fc))
 if not fc:IsLocation(LOCATION_OVERLAY) or not tc then return end
 local player=e:GetLabel()
 local set,summon=s.placeoptions(tc,e,tp,player,nil)
 if summon and (not set or Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,3))) then
  Duel.SpecialSummon(tc,0,tp,player,false,false,POS_FACEUP)
 elseif set then
  if tc:IsType(TYPE_MONSTER) then Duel.SpecialSummon(tc,0,tp,player,false,false,POS_FACEDOWN_DEFENSE)
  else Duel.SSet(tp,tc,player) end
 end
end
function s.battlemonster(c,tp)
 local a,d=Duel.GetAttacker(),Duel.GetAttackTarget()
 local other=a==c and d or d==c and a or nil
 if other and other:IsControler(1-tp) then return other end
end
function s.batcon(e,tp)
 return Duel.IsBattlePhase() and s.battlemonster(e:GetHandler(),tp)~=nil
end
function s.revivefilter(c,e,tp,oldcode)
 return not c:IsCode(oldcode) and c:IsType(TYPE_MONSTER)
  and c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEUP_DEFENSE,1-tp)
end
function s.battg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 local tc=s.battlemonster(e:GetHandler(),tp)
 if chkc then return chkc==tc and tc:IsCanBeEffectTarget(e) and tc:IsAbleToGrave() end
 if chk==0 then return tc and tc:IsCanBeEffectTarget(e) and tc:IsAbleToGrave()
  and Duel.IsExistingMatchingCard(s.revivefilter,1-tp,LOCATION_GRAVE,0,1,nil,e,tp,tc:GetCode()) end
 Duel.SetTargetCard(tc)
 Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,tc,1,1-tp,LOCATION_MZONE)
end
function s.batop(e,tp)
 local tc=Duel.GetFirstTarget()
 if not tc or not tc:IsRelateToEffect(e) then return end
 local oldcode=tc:GetCode()
 if Duel.SendtoGrave(tc,REASON_EFFECT)==0 then return end
 local opp=1-tp
 if Duel.GetLocationCount(opp,LOCATION_MZONE)<=0
  or not Duel.IsExistingMatchingCard(s.revivefilter,opp,LOCATION_GRAVE,0,1,nil,e,tp,oldcode) then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON)
 local g=Duel.SelectMatchingCard(tp,s.revivefilter,opp,LOCATION_GRAVE,0,1,1,nil,e,tp,oldcode)
 local sc=g:GetFirst()
 if sc then Duel.SpecialSummon(sc,0,tp,opp,false,false,POS_FACEUP_DEFENSE) end
end
