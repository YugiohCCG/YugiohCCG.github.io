const fs=require('fs'),path=require('path'),lua=require('./lua_parser/node_modules/luaparse');
const repo=path.resolve(__dirname,'..'),cards=JSON.parse(fs.readFileSync(path.join(repo,'src/data/cards.json'),'utf8'));
const dir=path.join(repo,'public/CCG Downloads/CCG_Scripts');
const mut=new Set(['Duel.SendtoHand','Duel.SendtoDeck','Duel.SendtoGrave','Duel.Remove','Duel.Destroy','Duel.Release','Duel.SpecialSummon','Duel.Draw','Duel.Damage','Duel.Recover','Duel.SSet','Duel.Overlay','Duel.ChangePosition','Duel.MoveToField','Duel.FusionSummon','Duel.SynchroSummon','Duel.XyzSummon','Duel.LinkSummon','Duel.DiscardHand']);
function name(n){if(!n)return null;if(n.type==='Identifier')return n.name;if(n.type==='MemberExpression'){const b=name(n.base),k=n.identifier&&(n.identifier.name||n.identifier.value);return b&&k?b+'.'+k:null}return null}
function walk(n,anc,cb){if(!n||typeof n!=='object')return;cb(n,anc);for(const [k,v] of Object.entries(n)){if(k==='loc'||k==='range')continue;if(Array.isArray(v))for(const c of v)walk(c,anc.concat(n),cb);else if(v&&typeof v==='object')walk(v,anc.concat(n),cb)}}
for(let i=390;i<577;i++){
 const c=cards[i]; if(!/(and if you do|then|also,? after that|and after that|and if they do|and if it does)/i.test(c.text))continue;
 const p=path.join(dir,`c${c.passcode}.lua`),src=fs.readFileSync(p,'utf8'),ops=new Set([...src.matchAll(/SetOperation\s*\(\s*s\.([A-Za-z_]\w*)/g)].map(m=>m[1]));
 const ast=lua.parse(src,{luaVersion:'5.3',locations:true,ranges:true});
 walk(ast,[],(n,a)=>{if(n.type!=='FunctionDeclaration'||!n.identifier)return;const fn=name(n.identifier);if(!fn||!ops.has(fn.slice(2)))return;const calls=[];walk(n.body||n,[],(x,xa)=>{if(x.type==='CallExpression'){const nm=name(x.base);if(mut.has(nm))calls.push({nm,line:x.loc.start.line,guard:xa.some(q=>q.type==='IfStatement')})}});if(calls.length>=2)console.log(`${i+1}\t${c.passcode}\t${c.name}\t${fn}\t${calls.map(x=>`${x.line}:${x.nm}:${x.guard?'G':'U'}`).join('|')}`)});
}
