'use strict';
const fs=require('fs'),path=require('path'),assert=require('assert/strict');
const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport(),{OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),mode=process.argv[2]||'old',boss=259073666,monster=900011071,filler=900011072,protector=24221739,results=[];
 for(const test of [{count:4},{count:4,lock:true},{count:1,lock:true},{count:1},{count:0}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:4,attribute:1,race:0x800n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[boss,require('./fresh_installed_card.cjs').candidateCard(boss)],[monster,{...base,code:monster}],[filler,{...base,code:filler,type:2}],[protector,{...base,code:protector,race:8n,attack:1100,defense:1900}]]);
 const reader=n=>{if(n==='c0.lua')return '';if([monster,filler].some(c=>n===`c${c}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';const p=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',n),path.join(ROOT,'tmp/omega_scripts',n)].find(fs.existsSync);assert(p,n);let s=fs.readFileSync(p,'utf8');if(n===`c${boss}.lua`){const old=path.join(OUT,'wyvernal-draw-permission-before-repair',n);if(fs.existsSync(old))s=fs.readFileSync(old,'utf8');if(mode!=='old')s=require('./fresh_wyvernal_draw_permission_repair.cjs').corrected(s);if(mode==='too-strict')s=s.replace('local max=4','local max=1');if(mode==='no-limit')s=s.replace('then max=1','then max=4');}return s;};
 const d=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});let failure=null,activated=false,done=false;
 try{
 for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(d,n,reader(n));
 const add=(code,location,p=0,sequence=0)=>core.duelNewCard(d,{team:p,duelist:0,code,controller:p,location,sequence,position:P.FACEUP_ATTACK});add(boss,L.GRAVE);for(let i=0;i<test.count;i++)add(monster,L.GRAVE);if(test.lock)add(protector,L.MZONE,1);for(const p of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,p);core.startDuel(d);
 const query=loc=>core.duelQueryLocation(d,{flags:Q.CODE|Q.REASON,controller:0,location:loc}).filter(Boolean);
 for(let step=0;step<100&&!done;step++){
 const state=core.duelProcess(d),messages=core.duelGetMessage(d);trace.push(...messages);assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){assert(!activated);const index=p.activates.findIndex(c=>c.code===boss);assert.equal(index>=0,test.count>0,'At least one target required');if(!test.count){assert(query(L.GRAVE).some(c=>c.code===boss),'Unavailable effect pays no cost');done=true;continue;}activated=true;core.duelSetResponse(d,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}
 else if(p.type===M.SELECT_CARD){assert(query(L.REMOVED).some(c=>c.code===boss),'Original native source banishment cost');assert(p.selects.every(c=>c.code===monster));assert.equal(p.min,1);assert.equal(p.max,test.lock?1:test.count,'Target count excludes known prohibited mandatory draws');done=true;}
 else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(d,{type:R.SELECT_CHAIN,index:p.forced?0:null});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(d);}results.push({test,failure,logs,trace});console.log(JSON.stringify(test),failure||'PASS');
 }
 fs.writeFileSync(path.join(OUT,`current-wyvernal-draw-permission-${mode}.json`),JSON.stringify({mode,scope:'Original Wyvernal GY cost and native target-selection boundary, full stock Protector. Stops at selection; no original operation/draw claim, no CHAININFO mapping. Typed Insect GY recipients, no Lua API mapping. Existing operation evidence with explicit legacy mapping retained separately; other clauses/live open.',results},(_,v)=>typeof v==='bigint'?String(v):v,2));
}
main().catch(e=>{console.error(e);process.exitCode=1});
