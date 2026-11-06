'use strict';
const assert=require('node:assert/strict');
exports.corrected=(s,id)=>{
 const replace=(a,b)=>{assert.equal(s.split(a).length,2);s=s.replace(a,b);};
 if(id===220749574){const a='\tDuel.SendtoDeck(g,nil,SEQ_DECKBOTTOM,REASON_COST)';replace(a,a+'\n\tDuel.SortDeckbottom(tp,tp,2)');}
 else{assert.equal(id,223158720);replace('return c:IsRace(RACE_AQUA) and aux.NecroValleyFilter(Card.IsAbleToDeck)(c)','return c:IsRace(RACE_AQUA) and not c:IsType(TYPE_FUSION+TYPE_SYNCHRO+TYPE_XYZ+TYPE_LINK) and aux.NecroValleyFilter(Card.IsAbleToDeck)(c)');const a='\tif #g==3 and Duel.SendtoDeck(g,nil,SEQ_DECKBOTTOM,REASON_EFFECT)==3 then';replace(a,a+'\n\t\tDuel.SortDeckbottom(tp,tp,3)');}
 return s;
};
