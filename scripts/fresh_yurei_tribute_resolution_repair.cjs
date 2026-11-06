'use strict';
const assert=require('node:assert/strict');
exports.corrected=s=>{
 const filter='function s.spirit(c) return c:IsType(TYPE_SPIRIT) and c:IsReleasable() end';
 const cost='function s.negcost(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return not e:GetHandler():IsPublic() and Duel.IsExistingMatchingCard(s.spirit,tp,LOCATION_HAND+LOCATION_MZONE,0,1,e:GetHandler()) end Duel.ConfirmCards(1-tp,e:GetHandler()); Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RELEASE); local g=Duel.SelectMatchingCard(tp,s.spirit,tp,LOCATION_HAND+LOCATION_MZONE,0,1,1,e:GetHandler()); Duel.Release(g,REASON_COST) end';
 const target='function s.negtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end Duel.SetOperationInfo(0,CATEGORY_NEGATE,eg,1,0,0) end';
 const op='function s.negop(e,tp,eg,ep,ev) Duel.NegateEffect(ev) end';
 for(const n of [filter,cost,target,op])assert.equal(s.split(n).length,2);
 return s.replace(filter,'function s.spirit(c,e) return c:IsType(TYPE_SPIRIT) and c:IsReleasableByEffect() and not c:IsImmuneToEffect(e) end')
 .replace(cost,'function s.negcost(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return not e:GetHandler():IsPublic() end Duel.ConfirmCards(1-tp,e:GetHandler()) end')
 .replace(target,'function s.negtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.spirit,tp,LOCATION_HAND+LOCATION_MZONE,0,1,e:GetHandler(),e) end Duel.SetOperationInfo(0,CATEGORY_NEGATE,eg,1,0,0) end')
 .replace(op,`function s.negop(e,tp,eg,ep,ev)
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RELEASE)
 local g=Duel.SelectMatchingCard(tp,s.spirit,tp,LOCATION_HAND+LOCATION_MZONE,0,1,1,e:GetHandler(),e)
 if #g>0 and Duel.Release(g,REASON_EFFECT)>0 then Duel.NegateEffect(ev) end
end`);
};
