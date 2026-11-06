'use strict';
const assert=require('node:assert/strict');
exports.corrected=s=>{
 const old='\tlocal te=Effect.CreateEffect(e:GetHandler()) te:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS) te:SetCode(EVENT_PHASE+PHASE_BATTLE) te:SetLabelObject(tc) te:SetReset(RESET_PHASE+PHASE_BATTLE) te:SetOperation(function(te) local rc=te:GetLabelObject() if rc and rc:IsLocation(LOCATION_MZONE) then Duel.SendtoHand(rc,nil,REASON_EFFECT) end end) Duel.RegisterEffect(te,tp)';
 const next=`\tlocal fid=tc:GetFieldID()
\ttc:RegisterFlagEffect(id,RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_BATTLE,0,1,fid)
\tlocal te=Effect.CreateEffect(e:GetHandler())
\tte:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
\tte:SetCode(EVENT_PHASE+PHASE_BATTLE)
\tte:SetCountLimit(1)
\tte:SetLabel(fid)
\tte:SetLabelObject(tc)
\tte:SetReset(RESET_PHASE+PHASE_BATTLE)
\tte:SetOperation(function(te)
\t\tlocal rc=te:GetLabelObject()
\t\tif rc and rc:IsLocation(LOCATION_MZONE) and rc:GetFieldID()==te:GetLabel()
\t\t\tand rc:GetFlagEffect(id)>0 then
\t\t\tDuel.SendtoHand(rc,nil,REASON_EFFECT)
\t\tend
\tend)
\tDuel.RegisterEffect(te,tp)`;
 assert.equal(s.split(old).length,2,'Exact original delayed-return helper');return s.replace(old,next);
};
