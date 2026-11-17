'use strict';
const assert=require('node:assert/strict');
exports.corrected=lua=>{
 const old='function s.spgroup(tp,e) return Duel.GetMatchingGroup(s.spf,tp,LOCATION_HAND+LOCATION_GRAVE+LOCATION_OVERLAY,0,nil,e,tp) end';
 const replacement=`function s.spgroup(tp,e)
 local g=Duel.GetMatchingGroup(s.spf,tp,LOCATION_HAND+LOCATION_GRAVE,0,nil,e,tp)
 local hosts=Duel.GetMatchingGroup(Card.IsType,tp,LOCATION_MZONE,0,nil,TYPE_XYZ)
 for xc in aux.Next(hosts) do
  g:Merge(xc:GetOverlayGroup():Filter(s.spf,nil,e,tp))
 end
 return g
end`;
 assert.equal(lua.split(old).length,2);return lua.replace(old,replacement);
};
