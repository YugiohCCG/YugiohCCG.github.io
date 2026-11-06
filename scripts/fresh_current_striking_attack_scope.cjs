'use strict';
const fs=require('fs'),path=require('path'),assert=require('assert/strict');
const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport(),{OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,SelectBattleCMDAction:B,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),mode=process.argv[2]||'old',boss=250902476,attacker=900011121,victim=900011122,filler=900011123,results=[];
 for(const test of [{owner:0,extra:false},{owner:0,extra:true},{owner:1,extra:false},{owner:1,extra:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:4,attribute:1,race:1n,attack:2000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[boss,require('./fresh_installed_card.cjs').candidateCard(boss)],[attacker,{...base,code:attacker}],[victim,{...base,code:victim,attack:1000}],[filler,{...base,code:filler,type:2}]]);
 const reader=n=>{
 if(n==='c0.lua')return '';
 if([attacker,victim,filler].some(c=>n===`c${c}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';
 const p=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',n),path.join(ROOT,'tmp/omega_scripts',n)].find(fs.existsSync);assert(p,n);let s=fs.readFileSync(p,'utf8');if(n===`c${boss}.lua`){const old=path.join(OUT,'striking-attack-scope-before-repair',n);if(fs.existsSync(old))s=fs.readFileSync(old,'utf8');if(mode!=='old')s=require('./fresh_striking_attack_scope_repair.cjs').corrected(s);if(mode==='no-destroy')s=s.replace('Duel.Destroy(a,REASON_EFFECT)>0','false');if(mode==='no-extra')s=s.replaceAll('Duel.Destroy(sg,REASON_EFFECT)','do end');}return s;};
 const d=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});let failure=null,turn=0,attacked=false,activated=false,optional=false,done=false;
 try{
 for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(d,n,reader(n));
 const add=(code,location,p=0,sequence=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(d,{team:p,duelist:0,code,controller:p,location,sequence,position});add(boss,L.SZONE,test.owner,0,P.FACEDOWN_DEFENSE);add(attacker,L.MZONE,1);add(victim,L.MZONE,1-test.owner,1);for(const p of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,p);core.startDuel(d);
 const query=(loc,controller)=>core.duelQueryLocation(d,{flags:Q.CODE|Q.REASON,controller,location:loc}).filter(Boolean);
 for(let step=0;step<240&&!done;step++){
 const state=core.duelProcess(d),messages=core.duelGetMessage(d);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
 assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){core.duelSetResponse(d,{type:R.SELECT_IDLECMD,action:turn<2?A.TO_EP:A.TO_BP});}
 else if(p.type===M.SELECT_BATTLECMD){if(attacked){assert(activated,'Original trap offered on declared attack');assert(optional,'Actual optional second destruction prompt');assert(query(L.GRAVE,1).some(c=>c.code===attacker),'Attacker destroyed by original operation');assert.equal(query(L.GRAVE,1-test.owner).some(c=>c.code===victim),test.extra,'Optional destruction follows player choice');assert(trace.some(m=>m.type===M.ATTACK),'Actual attack');assert(trace.some(m=>m.type===M.CHAINING&&m.code===boss),'Actual trap chain');done=true;continue;}const index=p.attacks.findIndex(c=>c.code===attacker);assert(index>=0);attacked=true;core.duelSetResponse(d,{type:R.SELECT_BATTLECMD,action:B.SELECT_BATTLE,index});}
 else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===boss);if(index>=0)activated=true;core.duelSetResponse(d,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
 else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===victim);assert(index>=0);core.duelSetResponse(d,{type:R.SELECT_CARD,indicies:[index]});}
 else if(p.type===M.SELECT_YESNO){optional=true;core.duelSetResponse(d,{type:R.SELECT_YESNO,yes:test.extra});}
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(d);}results.push({test,failure,logs,trace});console.log(JSON.stringify(test),failure||'PASS');
 }
 fs.writeFileSync(path.join(OUT,`current-striking-attack-scope-${mode}.json`),JSON.stringify({mode,scope:'Original seeded set trap, actual own/opponent native turn2 attacks and original attacker destruction followed by optional opponent attack-position destruction accepted/declined. Neutral combatants; no API mapping. Card/effect branch, negation, protection, named activation limit and live/full-card remain open.',results},(_,v)=>typeof v==='bigint'?String(v):v,2));
}
main().catch(e=>{console.error(e);process.exitCode=1});

