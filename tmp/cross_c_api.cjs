const fs=require('fs'),path=require('path');
const repo=path.resolve(__dirname,'..');
const cards=JSON.parse(fs.readFileSync(path.join(repo,'src/data/cards.json'),'utf8'));
function files(dir,out=[]){for(const ent of fs.readdirSync(dir,{withFileTypes:true})){const p=path.join(dir,ent.name);if(ent.isDirectory())files(p,out);else if(ent.name.endsWith('.lua'))out.push(p)}return out}
const official=files(path.join(repo,'tmp/omega_scripts')).map(p=>fs.readFileSync(p,'utf8')).join('\n');
const lane=cards.slice(390,577).map(c=>fs.readFileSync(path.join(repo,'public/CCG Downloads/CCG_Scripts',`c${c.passcode}.lua`),'utf8')).join('\n');
function set(re,s){return new Set([...s.matchAll(re)].map(m=>m[1]))}
const offColon=set(/:([A-Za-z_]\w*)\s*\(/g,official),laneColon=set(/:([A-Za-z_]\w*)\s*\(/g,lane);
const badColon=[...laneColon].filter(x=>!offColon.has(x)).sort();
console.log(`official_colon=${offColon.size} lane_colon=${laneColon.size} unsupported_colon=${badColon.length} ${badColon.join(',')}`);
for(const ns of ['Duel','Card','Group','Effect','aux','Fusion','Synchro','Xyz','Link','Pendulum','Ritual','Spirit']){
 const off=set(new RegExp(`\\b${ns}\\.([A-Za-z_]\\w*)\\s*\\(`,'g'),official),cur=set(new RegExp(`\\b${ns}\\.([A-Za-z_]\\w*)\\s*\\(`,'g'),lane),bad=[...cur].filter(x=>!off.has(x)).sort();
 console.log(`${ns}: lane=${cur.size} unsupported=${bad.length} ${bad.join(',')}`);
}
