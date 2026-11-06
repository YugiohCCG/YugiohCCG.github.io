'use strict';
const assert=require('node:assert/strict');exports.corrected=s=>{const p=/^([ \t]*)Duel.Hint\(HINT_SELECTMSG,tp,HINTMSG_ATOHAND\)$/gm;assert.equal([...s.matchAll(p)].length,1);return s.replace(p,(_,i)=>i+'Duel.BreakEffect()\n'+i+'Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)');};
