'use strict';
const assert=require('assert/strict');
exports.corrected=s=>{
 const replace=(a,b,n=1)=>{assert.equal(s.split(a).length,n+1,a);s=s.split(a).join(b);};
 replace('local end_phase=Duel.IsBattlePhase() and PHASE_BATTLE or PHASE_MAIN1','local end_phase=Duel.IsBattlePhase() and PHASE_BATTLE or PHASE_MAIN1\n\t\t\tlocal fid=c:GetFieldID()\n\t\t\tc:RegisterFlagEffect(id+200,RESET_EVENT+RESETS_STANDARD+RESET_PHASE+end_phase,0,1)');
 replace('e1:SetLabel(Duel.GetCurrentPhase())','e1:SetLabel(fid)');
 replace('\t\tlocal e1=Effect.CreateEffect(c)\n\t\te1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)','\t\tlocal fid=c:GetFieldID()\n\t\tc:RegisterFlagEffect(id+200,RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_BATTLE,0,1)\n\t\tlocal e1=Effect.CreateEffect(c)\n\t\te1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)');
 replace('\n\t\te1:SetLabelObject(c)','\n\t\te1:SetLabel(fid)\n\t\te1:SetLabelObject(c)');
 replace('if tc and tc:IsLocation(LOCATION_MZONE) then','if tc and tc:IsLocation(LOCATION_MZONE) and tc:GetFieldID()==e:GetLabel()\n\t\tand tc:GetFlagEffect(id+200)>0 then');
 return s;
};
