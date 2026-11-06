'use strict';
const assert=require('assert/strict');
exports.corrected=(s,code)=>{
 const rep=(a,b)=>{assert.equal(s.split(a).length,2,a);s=s.replace(a,b);};
 if(code===259911246){
 rep('function s.retfilter(c)\n\treturn c:IsLocation(LOCATION_MZONE) and c:IsFacedown()','function s.retfilter(c,fid)\n\treturn c:IsLocation(LOCATION_MZONE) and c:IsFacedown() and c:GetFlagEffectLabel(id)==fid');
 rep('local sg=g:Filter(s.retfilter,nil)','local pos,fid=e:GetLabel()\n\t\tlocal sg=g:Filter(s.retfilter,nil,fid)');
 rep('Duel.ChangePosition(sg,e:GetLabel())','Duel.ChangePosition(sg,pos)');
 rep('function s.registerend(c,tp,g,pos)\n\tif #g==0 then return end','function s.registerend(c,tp,g,pos)\n\tg=g:Filter(Card.IsFacedown,nil)\n\tif #g==0 then return end\n\tlocal fid=c:GetFieldID()\n\tfor tc in aux.Next(g) do\n\t\ttc:RegisterFlagEffect(id,RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END,0,1,fid)\n\tend');
 rep('e1:SetLabel(pos)','e1:SetLabel(pos,fid)');
 }else if(code===259303191){
 rep('function s.retfilter(c)\n\treturn c:IsLocation(LOCATION_REMOVED) and c:IsFaceup() and c:IsAbleToGrave()','function s.retfilter(c,fid)\n\treturn c:IsLocation(LOCATION_REMOVED) and c:IsFaceup() and c:IsAbleToGrave() and c:GetFlagEffectLabel(id)==fid');
 rep('if #og>0 then\n\t\tog:KeepAlive()','if #og>0 then\n\t\tlocal fid=e:GetHandler():GetFieldID()\n\t\tfor tc in aux.Next(og) do\n\t\t\ttc:RegisterFlagEffect(id,RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END,0,1,fid)\n\t\tend\n\t\tog:KeepAlive()');
 rep('e1:SetLabelObject(og)','e1:SetLabel(fid)\n\t\te1:SetLabelObject(og)');
 rep('g:Filter(aux.NecroValleyFilter(s.retfilter),nil)','g:Filter(aux.NecroValleyFilter(s.retfilter),nil,e:GetLabel())');
 }else throw Error('Unexpected card '+code);
 return s;
};
