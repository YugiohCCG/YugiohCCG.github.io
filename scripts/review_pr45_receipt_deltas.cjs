// Conservative AST comparison of reveal-only receipt guards against reviewed Git blobs.
// This does not approve unrelated effect changes or replace live engine testing.
const fs=require('node:fs'),path=require('node:path'),cp=require('node:child_process'),crypto=require('node:crypto');
const lua=require('luaparse');
const digest=s=>crypto.createHash('sha256').update(s.replace(/\r\n/g,'\n')).digest('hex');
const clean=n=>Array.isArray(n)?n.map(clean):n&&typeof n==='object'?Object.fromEntries(Object.entries(n).filter(([k])=>(!['raw','comments','loc','range'].includes(k)||k==='raw'&&n.type==='StringLiteral')).map(([k,v])=>[k,clean(v)])):n;
const equal=(a,b)=>JSON.stringify(clean(a))===JSON.stringify(clean(b));
const ident=(n,name)=>n?.type==='Identifier'&&(!name||n.name===name);
const numeric=(n,v)=>n?.type==='NumericLiteral'&&n.value===v;
const member=(n,base,name)=>n?.type==='CallExpression'&&n.base?.type==='MemberExpression'&&equal(n.base.base,base)&&n.base.identifier.name===name;
const duel=(n,name)=>member(n,{type:'Identifier',name:'Duel'},name);
const call=s=>s?.type==='CallStatement'?s.expression:null;
const parts=n=>n?.type==='LogicalExpression'&&n.operator==='and'?[...parts(n.left),...parts(n.right)]:[n];
const tp={type:'Identifier',name:'tp'};
const opponent=n=>n?.type==='BinaryExpression'&&n.operator==='-'&&numeric(n.left,1)&&ident(n.right,'tp');
function confirmation(s,card){const c=call(s);return duel(c,'ConfirmCards')&&c.arguments.length===2&&opponent(c.arguments[0])&&equal(c.arguments[1],card)?c:null;}
function handCheck(n,card){return member(n,card,'IsLocation')&&n.arguments.length===1&&ident(n.arguments[0],'LOCATION_HAND');}
function controllerCheck(n,card){return member(n,card,'IsControler')&&n.arguments.length===1&&ident(n.arguments[0],'tp');}
function filterConfirmation(body,card){
 if(body?.length!==2)return null;
 const local=body[0],branch=body[1];
 if(local.type!=='LocalStatement'||local.variables.length!==1||local.init.length!==1)return null;
 const filtered=local.variables[0],fc=local.init[0];
 if(!member(fc,card,'Filter')||fc.arguments.length!==2||fc.arguments[1].type!=='NilLiteral')return null;
 const fn=fc.arguments[0];
 if(fn.type!=='FunctionDeclaration'||fn.parameters.length!==1||fn.body.length!==1||fn.body[0].type!=='ReturnStatement'||fn.body[0].arguments.length!==1)return null;
 const conditions=parts(fn.body[0].arguments[0]),parameter=fn.parameters[0];
 if(conditions.length!==2||!conditions.some(x=>handCheck(x,parameter))||!conditions.some(x=>controllerCheck(x,parameter)))return null;
 if(branch.type!=='IfStatement'||branch.clauses.length!==1)return null;
 const clause=branch.clauses[0],c=clause.condition;
 if(c?.type!=='BinaryExpression'||c.operator!=='>'||!numeric(c.right,0)||c.left.type!=='UnaryExpression'||c.left.operator!=='#'||!equal(c.left.argument,filtered)||clause.body.length!==1)return null;
 const confirmed=confirmation(clause.body[0],filtered);
 return confirmed?confirmed.arguments[0]:null;
}
function compare(source){
 let guarded=0,receipts=0;
 function marker(send,player,safe,prefix=[]){receipts++;if(safe)guarded++;return {type:'ReviewedHandReceipt',send:normalize(send),player:normalize(player),prefix:normalize(prefix)};}
 function conditional(n){
  if(n.type!=='IfStatement'||n.clauses.length!==1)return null;
  const clause=n.clauses[0],conditions=parts(clause.condition);
  const movement=conditions.find(c=>c?.type==='BinaryExpression'&&c.operator==='>'&&numeric(c.right,0)&&duel(c.left,'SendtoHand'));
  if(!movement)return null;
  const send=movement.left,card=send.arguments[0],index=conditions.indexOf(movement),prefix=conditions.slice(0,index),rest=conditions.slice(index+1);
  if(!ident(card))return null;
  const safe=rest.length===2&&rest.some(c=>handCheck(c,card))&&rest.some(c=>controllerCheck(c,card));
  if(rest.length&&!safe)return null;
  const direct=clause.body.length===1?confirmation(clause.body[0],card):null;
  if(direct)return marker(send,direct.arguments[0],safe,prefix);
  const player=filterConfirmation(clause.body,card);
  return player&&rest.length===0?marker(send,player,true,prefix):null;
 }
 function normalize(n){
  if(Array.isArray(n)){
   const result=[];
   for(let i=0;i<n.length;i++){
    const send=call(n[i]),confirmed=duel(send,'SendtoHand')&&ident(send.arguments[0])?confirmation(n[i+1],send.arguments[0]):null;
    if(confirmed){result.push(marker(send,confirmed.arguments[0],false));i++;}else result.push(normalize(n[i]));
   }
   return result;
  }
  if(!n||typeof n!=='object')return n;
  const replacement=conditional(n);if(replacement)return replacement;
  return Object.fromEntries(Object.entries(n).filter(([k])=>(!['raw','comments','loc','range'].includes(k)||k==='raw'&&n.type==='StringLiteral')).map(([k,v])=>[k,normalize(v)]));
 }
 const ast=normalize(lua.parse(source,{luaVersion:'5.3',comments:false}));return {ast,guarded,receipts};
}
if(process.argv[2]==='--self-test'){
 const assert=require('node:assert/strict');
 const before='function s.op(e,tp) Duel.SendtoHand(g,nil,REASON_EFFECT) Duel.ConfirmCards(1-tp,g) end';
 const guarded='function s.op(e,tp) if Duel.SendtoHand(g,nil,REASON_EFFECT)>0 then local received=g:Filter(function(c) return c:IsLocation(LOCATION_HAND) and c:IsControler(tp) end,nil) if #received>0 then Duel.ConfirmCards(1-tp,received) end end end';
 assert(equal(compare(before).ast,compare(guarded).ast),'Receipt-only guard must preserve remaining AST');
 for(const changed of [guarded.replace('REASON_EFFECT','REASON_COST'),guarded.replace('IsControler(tp)','IsControler(1-tp)'),guarded.replace('end end end','end end Duel.Draw(tp,1,REASON_EFFECT) end')])assert(!equal(compare(before).ast,compare(changed).ast),'Effect/cost/recipient changes must require review');
 assert(!equal(compare('return "old"').ast,compare('return "new"').ast),'String changes must remain visible');
 assert(!equal(compare('return 1').ast,compare('return 2').ast),'Numeric changes must remain visible');
 const prior='function s.op(e,tp) if #g>0 and Duel.SendtoHand(g,nil,REASON_EFFECT)>0 then Duel.ConfirmCards(1-tp,g) end end';
 const checked=guarded.replace('if Duel.SendtoHand','if #g>0 and Duel.SendtoHand');
 assert(equal(compare(prior).ast,compare(checked).ast),'Existing activation predicates must be retained exactly');
 assert(!equal(compare(prior).ast,compare(checked.replace('#g>0','#g>1')).ast),'Changed prefix predicate must require review');
 assert(!equal(compare(before).ast,compare(guarded.replace('if Duel.SendtoHand','if g:IsLocation(LOCATION_HAND) and Duel.SendtoHand')).ast),'A pre-movement Hand check changes movement eligibility');
 console.log('PASS conservative receipt delta classifier positive/negative cases');process.exit(0);
}
const entries=JSON.parse(fs.readFileSync(process.argv[2],'utf8'));
const printedText=new Map(JSON.parse(fs.readFileSync('src/data/cards.json','utf8')).map(c=>[Number(c.passcode),digest(c.text)]));
const results=[],manual=[];
for(const e of entries){
 if(e.text_changed||!e.prior_blob||!e.prior_text_sha256||printedText.get(e.code)!==e.prior_text_sha256){manual.push(e.code);continue;}
 if(!/^[0-9a-f]{40}$/.test(e.prior_blob))throw Error('Invalid Git blob');
 const before=cp.execFileSync('git',['cat-file','blob',e.prior_blob],{encoding:'utf8'}).replace(/\r\n/g,'\n');
 const after=fs.readFileSync(path.join('public/CCG Downloads/CCG_Scripts',`c${e.code}.lua`),'utf8').replace(/\r\n/g,'\n');
 const old=compare(before),current=compare(after);
 if(equal(old.ast,current.ast)&&current.guarded>=old.guarded){
  results.push({passcode:e.code,prior_blob:e.prior_blob,prior_sha256:digest(before),script_sha256:digest(after),receipt_guards_before:old.guarded,receipt_guards_after:current.guarded,method:'AST identity after narrowly normalizing only own-Hand receipt/reveal guards; printed text unchanged. No other executable change accepted.'});
 }else manual.push(e.code);
}
process.stdout.write(JSON.stringify({verified:results,manual},null,2)+'\n');
