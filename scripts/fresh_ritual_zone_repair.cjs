'use strict';
const assert=require('node:assert/strict');
function corrected(s){
 const pairs=[['function s.matcheck(g,lv,ct)','function s.matcheck(g,lv,ct,tp,rc)'],['return g:GetSum(Card.GetLevel)+ct>=lv','return g:GetSum(Card.GetLevel)+ct>=lv and s.zonecheck(tp,rc,g)'],['mg:CheckSubGroup(s.matcheck,1,#mg,lv,s.countercap(tp,lv))','mg:CheckSubGroup(s.matcheck,1,#mg,lv,s.countercap(tp,lv),tp,c)'],['mg:SelectSubGroup(tp,s.matcheck,true,1,#mg,lv,s.countercap(tp,lv))','mg:SelectSubGroup(tp,s.matcheck,true,1,#mg,lv,s.countercap(tp,lv),tp,rc)']];
 for(const [a,b] of pairs){assert.equal(s.split(a).length-1,1,a);s=s.replace(a,b);}return s;
}
module.exports={corrected};
