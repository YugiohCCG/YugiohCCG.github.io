'use strict';
const assert=require('node:assert/strict');
function corrected(s){if(s.includes('function s.ritmatfilter(c,rc)'))return require('./fresh_current_mage_monster_zone.cjs').corrected(s);const a='\tif Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 and not mg:IsExists(s.hasfieldmat,1,nil) then return false end';assert.equal(s.split(a).length-1,1);return s.replace(a+(s.includes('\r\n')?'\r\n':'\n'),'');}
module.exports={corrected};
