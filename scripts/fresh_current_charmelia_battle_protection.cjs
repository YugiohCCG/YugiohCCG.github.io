'use strict';
const fs=require('fs'),path=require('path'),assert=require('assert/strict');
const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport(),{OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,SelectBattleCMDAction:B,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),mode=process.argv[2]||'current',boss=259226799,attacker=900011091,first=900011092,second=900011093,filler=900011094,results=[];
 for(const kind of ['battle','effect-first','battle-first','non-charm-first','facedown-first']){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:4,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[boss,require('./fresh_installed_card.cjs').candidateCard(boss)],[attacker,{...base,code:attacker,attack:2000}],[first,{...base,code:first,setcodes:kind==='non-charm-first'?[]:[0x12b1]}],[second,{...base,code:second,setcodes:[0x12b1]}],[filler,{...base,code:filler,type:2}]]);
 const reader=n=>{
 if(n==='c0.lua')return '';
 if([first,second,filler].some(c=>n===`c${c}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';
 if(n===`c${attacker}.lua`)return `local s,id=GetID() function s.initial_effect(c) local x=Effect.CreateEffect(c) x:SetType(EFFECT_TYPE_SINGLE) x:SetCode(EFFECT_EXTRA_ATTACK) x:SetValue(1) c:RegisterEffect(x) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetOperation(function(e,tp) local tc=Duel.GetFirstMatchingCard(Card.IsCode,0,LOCATION_MZONE,0,nil,${kind==='effect-first'?first:second}) assert(tc) Duel.Destroy(tc,REASON_EFFECT) end) c:RegisterEffect(e) end`;
 const p=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',n),path.join(ROOT,'tmp/omega_scripts',n)].find(fs.existsSync);assert(p,n);let s=fs.readFileSync(p,'utf8');if(n===`c${boss}.lua`){if(mode==='no-protection')s=s.replace('c:RegisterEffect(e3)','do end');if(mode==='unlimited')s=s.replace('e3:SetCountLimit(1)','do end');if(mode==='split-limits')s=s.replace('c:RegisterEffect(e3)','e3:SetValue(function(e,re,r,rp) return r&REASON_BATTLE~=0 end) c:RegisterEffect(e3) local split=e3:Clone() split:SetValue(function(e,re,r,rp) return r&REASON_EFFECT~=0 end) c:RegisterEffect(split)');}return s;};
 const d=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});let failure=null,turn=0,phase=0,attacks=0,effectUsed=false,done=false;
 try{
 for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(d,n,reader(n));
 const add=(code,location,player=0,sequence=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(d,{team:player,duelist:0,code,controller:player,location,sequence,position});add(boss,L.SZONE);add(first,L.MZONE,0,0,kind==='facedown-first'?P.FACEDOWN_DEFENSE:P.FACEUP_DEFENSE);add(second,L.MZONE,0,1,P.FACEUP_DEFENSE);add(attacker,L.MZONE,1);for(const p of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,p);core.startDuel(d);
 const query=loc=>core.duelQueryLocation(d,{flags:Q.CODE|Q.REASON|Q.POSITION,controller:0,location:loc}).filter(Boolean);
 const firstCheck=()=>{assert.equal(query(L.MZONE).some(c=>c.code===first),kind!=='non-charm-first','First qualifying battle destruction is prevented');if(kind==='facedown-first')assert.equal(query(L.MZONE).find(c=>c.code===first).position,P.FACEUP_DEFENSE,'Actual battle flip before protection');};
 const finish=()=>{assert(trace.filter(m=>m.type===M.ATTACK).length===(kind==='effect-first'||kind==='battle-first'?1:2),'Actual native attack count');const survivor=kind==='non-charm-first';assert.equal(query(L.MZONE).some(c=>c.code===second),survivor,'Battle and effect destruction share one allowance across recipients');if(!survivor){const c=query(L.GRAVE).find(c=>c.code===second);assert(c,'Second recipient actually destroyed');assert((c.reason&(kind==='battle-first'?0x40:0x20))!==0,'Actual destruction reason');}done=true;};
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(d),messages=core.duelGetMessage(d);trace.push(...messages);for(const m of messages){if(m.type===M.NEW_TURN)turn++;if(m.type===M.NEW_PHASE)phase=m.phase;}
 assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){if(turn<2){core.duelSetResponse(d,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
 if(kind==='effect-first'&&!effectUsed||kind==='battle-first'&&phase===256&&!effectUsed){const index=p.activates.findIndex(c=>c.code===attacker);assert(index>=0);effectUsed=true;core.duelSetResponse(d,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 if(kind==='battle-first'&&phase===256&&effectUsed){finish();continue;}
 if(kind==='effect-first')assert(query(L.MZONE).some(c=>c.code===first),'Effect destruction consumes first prevention before battle');core.duelSetResponse(d,{type:R.SELECT_IDLECMD,action:A.TO_BP});
 }else if(p.type===M.SELECT_BATTLECMD){if(attacks){if(kind!=='effect-first')firstCheck();if(kind==='battle-first'){core.duelSetResponse(d,{type:R.SELECT_BATTLECMD,action:B.TO_M2});continue;}if(attacks===(kind==='effect-first'?1:2)){finish();continue;}}
 const index=p.attacks.findIndex(c=>c.code===attacker);assert(index>=0);attacks++;core.duelSetResponse(d,{type:R.SELECT_BATTLECMD,action:B.SELECT_BATTLE,index});
 }else if(p.type===M.SELECT_CARD){const wanted=kind==='effect-first'||attacks===2?second:first,index=p.selects.findIndex(c=>c.code===wanted);assert(index>=0);core.duelSetResponse(d,{type:R.SELECT_CARD,indicies:[index]});}
 else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(d,{type:R.SELECT_CHAIN,index:p.forced?0:null});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(d);}results.push({kind,failure,logs,trace});console.log(kind,failure||'PASS');
 }
 fs.writeFileSync(path.join(OUT,`current-charmelia-battle-protection-${mode}.json`),JSON.stringify({mode,scope:'Original continuous Beast protection with seeded source and neutral combatants. Native attacks/damage-step battle flip/destruction, mixed battle/effect ordering and non-archetype exclusion. No Lua API mapping. Simultaneous destruction and recovery named limits/full-card/live open.',results},(_,v)=>typeof v==='bigint'?String(v):v,2));
}
main().catch(e=>{console.error(e);process.exitCode=1});
