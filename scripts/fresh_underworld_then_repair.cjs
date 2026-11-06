'use strict';
const assert=require('node:assert/strict');exports.corrected=s=>{const before="\tlocal g=eg:Filter(function(c,tp)\n\t\treturn s.tdfilter(c,tp) and Duel.IsExistingMatchingCard(s.addfilter,tp,LOCATION_DECK,0,1,nil,c:GetCode())\n\tend,nil,tp)",after="\tlocal g=eg:Filter(s.tdfilter,nil,tp)";assert.equal(s.split(before).length,2);return s.replace(before,after);};
