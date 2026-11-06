'use strict';
const assert=require('node:assert/strict');
exports.yurei=s=>{
const old='function s.sumop(e,tp) local c=e:GetHandler(); local tc=Duel.GetAttacker(); if not (tc:IsControler(tp) and tc:IsType(TYPE_SPIRIT)) then tc=Duel.GetAttackTarget() end if c:IsRelateToEffect(e) and Duel.Summon(tp,c,true,nil)>0 and tc and tc:IsFaceup() then local ex=Effect.CreateEffect(c); ex:SetType(EFFECT_TYPE_SINGLE); ex:SetCode(EFFECT_SET_ATTACK_FINAL); ex:SetValue(tc:GetAttack()*2); ex:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END); tc:RegisterEffect(ex) end end';
assert.equal(s.split(old).length,2);
return s.replace(old,`function s.sumop(e,tp)
 local c=e:GetHandler(); local tc=Duel.GetAttacker()
 if not (tc and tc:IsControler(tp) and tc:IsType(TYPE_SPIRIT)) then tc=Duel.GetAttackTarget() end
 if not c:IsRelateToEffect(e) then return end
 local fid=tc and tc:GetFieldID()
 --Normal Summon is performed after this resolving effect has finished.
 local se=Effect.CreateEffect(c)
 se:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_CONTINUOUS)
 se:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
 se:SetCode(EVENT_SUMMON_SUCCESS)
 se:SetOperation(function(te) s.double(e,tc,fid) te:Reset() end)
 se:SetReset(RESET_EVENT+RESETS_STANDARD-RESET_TOFIELD+RESET_PHASE+PHASE_END)
 c:RegisterEffect(se)
 Duel.Summon(tp,c,true,nil)
end
function s.double(e,tc,fid)
 if not (tc and tc:IsFaceup() and tc:IsLocation(LOCATION_MZONE) and tc:GetFieldID()==fid) then return end
 local ex=Effect.CreateEffect(e:GetHandler())
 ex:SetType(EFFECT_TYPE_SINGLE); ex:SetCode(EFFECT_SET_ATTACK_FINAL); ex:SetValue(tc:GetAttack()*2)
 ex:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END); tc:RegisterEffect(ex)
end`);
};
exports.handmeta=s=>{const a='Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,0,0)';assert.equal(s.split(a).length,2);return s.replace(a,'Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,tp,LOCATION_HAND)');};
exports.oceanica=s=>{
 const a='done=Duel.Summon(p,tc,true,nil)',b='if done>0 then local ea=Effect.CreateEffect(e:GetHandler()); ea:SetType(EFFECT_TYPE_SINGLE); ea:SetCode(EFFECT_SET_ATTACK_FINAL); ea:SetValue(0); ea:SetReset(RESET_EVENT+RESETS_STANDARD); tc:RegisterEffect(ea); local ei=Effect.CreateEffect(e:GetHandler()); ei:SetType(EFFECT_TYPE_SINGLE); ei:SetCode(EFFECT_IMMUNE_EFFECT); ei:SetValue(function(e,re) return re:GetOwner()==e:GetOwner() end); ei:SetReset(RESET_EVENT+RESETS_STANDARD); tc:RegisterEffect(ei) end';
 assert.equal(s.split(a).length,2);assert.equal(s.split(b).length,2);
 s=s.replace(a,'s.normalfollowup(e,tc) Duel.Summon(p,tc,true,nil)').replace(b,'if done>0 then s.followup(e,tc) end');
 const active='fc:GetFieldID()==e:GetLabel() end';assert.equal(s.split(active).length,2);s=s.replace(active,'fc:GetFieldID()==e:GetLabel() and not e:GetHandler():IsImmuneToEffect(e) end');
 return s+`
--Apply the additional outcomes only after the reserved Normal Summon succeeds.
function s.normalfollowup(e,tc)
 local se=Effect.CreateEffect(e:GetHandler())
 se:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_CONTINUOUS)
 se:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
 se:SetCode(EVENT_SUMMON_SUCCESS)
 se:SetOperation(function(te) s.followup(e,te:GetHandler()) te:Reset() end)
 se:SetReset(RESET_EVENT+RESETS_STANDARD-RESET_TOFIELD+RESET_PHASE+PHASE_END)
 tc:RegisterEffect(se)
end
function s.followup(e,tc)
 local ea=Effect.CreateEffect(e:GetHandler()); ea:SetType(EFFECT_TYPE_SINGLE); ea:SetCode(EFFECT_SET_ATTACK_FINAL); ea:SetValue(0); ea:SetReset(RESET_EVENT+RESETS_STANDARD); tc:RegisterEffect(ea)
 local ei=Effect.CreateEffect(e:GetHandler()); ei:SetType(EFFECT_TYPE_SINGLE); ei:SetCode(EFFECT_IMMUNE_EFFECT); ei:SetValue(function(e,re) return re:GetOwner()==e:GetOwner() end); ei:SetReset(RESET_EVENT+RESETS_STANDARD); tc:RegisterEffect(ei)
end
`;
};
