'use strict';
const assert=require('node:assert/strict');
exports.corrected=(s,id)=>{
 const filter=id===240511702?'thstfilter':'setfilter',tg=id===259578863?'settg':'thtg',op=id===259578863?'setop':'thop';assert([240511702,259578863,238711686].includes(id));
 const names=[...s.matchAll(/^function s\.(\w+)\(/gm)];
 for(const name of [filter,tg,op].sort((a,b)=>names.find(x=>x[1]===b).index-names.find(x=>x[1]===a).index)){
  const at=s.indexOf('function s.'+name+'('),end=s.indexOf('\nfunction ',at+1),to=end<0?s.length:end;let body=s.slice(at,to);
  if(name===filter){assert.equal(body.split('c:IsSSetable()').length,2);body=body.replace('function s.'+filter+'(c)','function s.'+filter+'(c,tp)').replace('c:IsSSetable()','c:IsSSetable() and (c:IsType(TYPE_FIELD) or Duel.GetLocationCount(tp,LOCATION_SZONE)>0)');}
  else {const re=/Duel.GetLocationCount\(tp,LOCATION_SZONE\)>0\s+and /;assert(re.test(body));body=body.replace(re,'');let n=0;body=body.replace(new RegExp('s\\.'+filter+',tp,([^\\n)]*?)nil(?=\\))','g'),(_,a)=>{n++;return 's.'+filter+',tp,'+a+'nil,tp'});assert(n>0);}
  s=s.slice(0,at)+body+s.slice(to);
 }
 return s;
};
