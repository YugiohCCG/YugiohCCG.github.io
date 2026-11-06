'use strict';
const assert=require('node:assert/strict');
exports.corrected=s=>{
 const watcher=' local e1=Effect.CreateEffect(c); e1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS); e1:SetCode(EVENT_SUMMON_SUCCESS); e1:SetRange(LOCATION_FZONE); e1:SetOperation(s.lockop); c:RegisterEffect(e1); local e2=e1:Clone(); e2:SetCode(EVENT_SPSUMMON_SUCCESS); c:RegisterEffect(e2)';
 const start=s.indexOf('function s.source_active(e)');const end=s.indexOf('function s.chcon(',start);assert(start>=0&&end>start);assert.equal(s.split(watcher).length,2);
 const replacement=` local e1=Effect.CreateEffect(c)
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
 end`;
 const functions=`function s.track_hand_summon(e,tp,eg)
 for tc in aux.Next(eg) do
  if tc:IsAttackPos() and tc:IsPreviousLocation(LOCATION_HAND) then
   tc:RegisterFlagEffect(id,RESET_EVENT+RESETS_STANDARD,EFFECT_FLAG_CANNOT_DISABLE,1)
  end
 end
end
function s.hand_lock(e,c)
 return c:GetFlagEffect(id)>0 and not c:IsImmuneToEffect(e)
end
`;
 return (s.slice(0,start)+functions+s.slice(end)).replace(watcher,replacement);
};
