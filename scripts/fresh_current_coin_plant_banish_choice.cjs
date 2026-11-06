'use strict';const fs=require('fs'),path=require('path'),assert=require('assert/strict'),ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september');
async function main(){const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport(),{OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod,core=await mod.default({sync:true,print(){},printErr(){}}),mode=process.argv[2]||'original',target=900011271,responder=900011272,observer=900011273,defender=900011278,gyCard=900011277,filler=900011274,results=[];
for(const boss of [284639718])for(const scenario of ['gy-only','choose-gy','choose-hand']){const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:4,attribute:1,race:1n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0},cards=new Map([[boss,require('./fresh_installed_card.cjs').candidateCard(boss)],[target,{...base,code:target,type:boss===259926839?0x10002:33,attribute:16,setcodes:[0xf2f4,0x11b]}],[responder,{...base,code:responder}],[observer,{...base,code:observer}],[filler,{...base,code:filler,type:2}],[defender,{...base,code:defender,setcodes:[0xA122]}],[gyCard,{...base,code:gyCard,type:2}],[222257686,{...base,code:222257686,type:0x4011}]]);
const reader=n=>{if(n==='c0.lua')return '';if([target,filler,222257686,defender,gyCard].some(c=>n===`c${c}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';if(n===`c${observer}.lua`)return `local s,id=GetID()
function s.initial_effect(c)
 local e=Effect.CreateEffect(c)
 e:SetType(EFFECT_TYPE_IGNITION)
 e:SetRange(LOCATION_MZONE)
 e:SetCountLimit(1)
 e:SetOperation(function(e,tp) local tc=Duel.GetFieldCard(tp,LOCATION_MZONE,2) assert(Duel.Destroy(tc,REASON_EFFECT)==1) end)
 c:RegisterEffect(e)
end`;
const p=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',n),path.join(ROOT,'tmp/omega_scripts',n)].find(fs.existsSync);assert(p,n);let s=fs.readFileSync(p,'utf8');if(n===`c${boss}.lua`&&mode==='ignore-choice'){
 const choose='local fromhand=handok and (not gyok or Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,2)))';
 assert.equal(s.split(choose).length,2);
 s=s.replace(choose,'local fromhand=handok');
}return s;};
const d=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});let failure=null,placed=false,triggered=false,ended=false,choices=0,started=false,responded=false,done=false;
try{for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(d,n,reader(n));const add=(code,location,p=0,seq=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(d,{team:p,duelist:0,code,controller:p,location,sequence:seq,position});add(boss,L.MZONE,0,2);add(observer,L.MZONE,0,4);add(defender,L.MZONE,0,0,P.FACEUP_DEFENSE);if(scenario!=='gy-only')add(defender,L.MZONE,0,1,P.FACEUP_DEFENSE);add(target,L.HAND,1);add(filler,L.HAND,1);add(gyCard,L.GRAVE,1);for(const p of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,p);core.startDuel(d);const query=(location,controller=0)=>core.duelQueryLocation(d,{flags:Q.CODE|Q.LEVEL,controller,location}).filter(Boolean);
for(let step=0;step<170&&!done;step++){const state=core.duelProcess(d),ms=core.duelGetMessage(d);trace.push(...ms);if(ms.some(m=>m.type===M.CHAINING&&m.code===boss))triggered=true;assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=ms.at(-1);if(p.type===M.SELECT_IDLECMD){if(!started){const index=p.activates.findIndex(c=>c.code===observer);assert(index>=0);started=true;core.duelSetResponse(d,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}const handBranch=scenario==='choose-hand';
const removed=query(L.REMOVED,1).map(c=>c.code);
const hand=query(L.HAND,1).map(c=>c.code);
assert(trace.some(m=>m.type===M.CHAINING&&m.code===boss),'Original destruction trigger');
assert.equal(choices,scenario==='gy-only'?0:1,'Branch choice when both options are legal');
assert.equal(removed.includes(gyCard),!handBranch,'GY card banished only on the GY branch');
if(!handBranch){assert.equal(hand.filter(c=>[target,filler].includes(c)).length,2,'Both hand cards retained');done=true;continue;}
if(!ended){assert.equal(removed.filter(c=>[target,filler].includes(c)).length,1,'One random hand card banished');assert.equal(hand.filter(c=>[target,filler].includes(c)).length,1);ended=true;core.duelSetResponse(d,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
assert(trace.some(m=>m.type===M.NEW_TURN&&m.player===1),'Natural End Phase completed');
assert.equal(hand.filter(c=>[target,filler].includes(c)).length,2,'Selected card returned to opponent hand');
assert(query(L.GRAVE,1).some(c=>c.code===gyCard),'GY alternative untouched');
done=true;}

else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===boss||c.code===responder);core.duelSetResponse(d,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
else if(p.type===M.SELECT_CARD){core.duelSetResponse(d,{type:R.SELECT_CARD,indicies:Array.from({length:p.min},(_,i)=>i)});}
else if(p.type===M.SELECT_PLACE){const places=[];for(const rel of [0,1])for(const location of [L.MZONE,L.SZONE])for(let sequence=0;sequence<6;sequence++)if((p.field_mask&(1<<(16*rel+(location===L.SZONE?8:0)+sequence)))===0)places.push({player:rel?1-p.player:p.player,location,sequence});assert(places.length);core.duelSetResponse(d,{type:R.SELECT_PLACE,places:places.slice(0,p.count)});}
else if(p.type===M.SELECT_YESNO){choices++;core.duelSetResponse(d,{type:R.SELECT_YESNO,yes:scenario==='choose-hand'});}
else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(d,{type:R.SELECT_EFFECTYN,yes:true});
else if(p.type===M.SELECT_POSITION)core.duelSetResponse(d,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));}assert(done,'Step limit');}catch(e){failure=e.message;}finally{core.destroyDuel(d);}results.push({boss,scenario,failure,logs,trace});console.log(boss,scenario,failure||'PASS');}fs.writeFileSync(path.join(OUT,'current-coin-plant-banish-choice-'+mode+'.json'),JSON.stringify({mode,scope:'Original Coin Plant destruction trigger with opponent GY branch and both choices. Hand branch has two eligible cards and verifies one actual banishment and return.',results},(_,v)=>typeof v==='bigint'?String(v):v,2));}main().catch(e=>{console.error(e);process.exitCode=1});
