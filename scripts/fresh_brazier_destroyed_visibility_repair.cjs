'use strict';
const assert=require('node:assert/strict');
exports.corrected=s=>{const old='eg:IsExists(Card.IsSetCard,1,nil,SET_NEPHTHYS)';assert.equal(s.split(old).length,2);return s.replace(old,'eg:IsExists(function(c) return c:IsSetCard(SET_NEPHTHYS) and (not c:IsPreviousLocation(LOCATION_ONFIELD) or c:IsPreviousPosition(POS_FACEUP)) end,1,nil)');};
