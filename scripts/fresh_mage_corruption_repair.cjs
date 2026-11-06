'use strict';
const assert=require('node:assert/strict');
exports.corrected=lua=>{
 const nl=lua.includes('\r\n')?'\r\n':'\n';const change=(a,b)=>{assert.equal(lua.split(a).length,2,'Exact Mage patch anchor: '+a);lua=lua.replace(a,b)};
 change('local SET_GLITCHLING=0x9894','local SET_GLITCHLING=0x9894'+nl+'local COUNTER_CORRUPTION=0x1994'+nl+'local CARD_CORRUPTION=259546637');
 change('s.listed_series={SET_GLITCHLING}','s.listed_series={SET_GLITCHLING}'+nl+'s.counter_add_list={COUNTER_CORRUPTION}');
 change('function s.otherpzone(c,pc)',[
 'function s.corruptionfilter(c)','\treturn c:IsFaceup() and c:IsCode(CARD_CORRUPTION)','end','function s.countercap(tp,lv)','\tif not Duel.IsExistingMatchingCard(s.corruptionfilter,tp,LOCATION_SZONE,0,1,nil) then return 0 end','\treturn math.min(lv,Duel.GetCounter(tp,1,1,COUNTER_CORRUPTION))','end','function s.otherpzone(c,pc)'].join(nl));
 change('return g:GetSum(Card.GetLevel)>=lv and Duel.GetMZoneCount(tp,g)>=ct','return g:GetSum(Card.GetLevel)+s.countercap(tp,lv)>=lv and Duel.GetMZoneCount(tp,g)>=ct');
 change('\tfor tc in aux.Next(rituals) do'+nl+'\t\ttc:SetMaterial(mat)',[
 '\tlocal deficit=lv-mat:GetSum(Card.GetLevel)','\tif deficit>0 and not Duel.RemoveCounter(tp,1,1,COUNTER_CORRUPTION,deficit,REASON_EFFECT+REASON_MATERIAL+REASON_RITUAL) then return end','\tfor tc in aux.Next(rituals) do','\t\ttc:SetMaterial(mat)'].join(nl));
 change('function s.ritcheck(g,lv)'+nl+'\treturn g:GetSum(Card.GetLevel)>=lv','function s.ritcheck(g,lv,ct)'+nl+'\tlocal counters=not g:IsExists(Card.IsLocation,1,nil,LOCATION_DECK) and ct or 0'+nl+'\treturn g:GetSum(Card.GetLevel)+counters>=lv');
 change('mg:CheckSubGroup(s.ritcheck,1,#mg,c:GetLevel())','mg:CheckSubGroup(s.ritcheck,1,#mg,c:GetLevel(),s.countercap(tp,c:GetLevel()))');
 change('mg:SelectSubGroup(tp,s.ritcheck,true,1,#mg,rc:GetLevel())','mg:SelectSubGroup(tp,s.ritcheck,true,1,#mg,rc:GetLevel(),s.countercap(tp,rc:GetLevel()))');
 change('\trc:SetMaterial(mat)'+nl+'\tlocal handmat=',[
 '\tlocal deficit=rc:GetLevel()-mat:GetSum(Card.GetLevel)','\tif deficit>0 and not Duel.RemoveCounter(tp,1,1,COUNTER_CORRUPTION,deficit,REASON_EFFECT+REASON_MATERIAL+REASON_RITUAL) then return end','\trc:SetMaterial(mat)','\tlocal handmat='].join(nl));
 return lua;
};
