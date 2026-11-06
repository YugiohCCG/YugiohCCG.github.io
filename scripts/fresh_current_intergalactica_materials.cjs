'use strict';
const fs=require('fs'),path=require('path'),assert=require('assert/strict');
const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport(),{OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),mode='old',results=[],spell=245395343,boss=221827483,galactica=234179728,galaxy=217332244,filler=900011031;
 for(const kind of ['banished','optional-cost','no-galactica','no-galaxy']){
 const logs=[],trace=[],cards=new Map([spell,boss,galactica,galaxy].map(c=>[c,require('./fresh_installed_card.cjs').candidateCard(c)]));cards.set(filler,{code:filler,alias:0,setcodes:[],type:2,level:0,attribute:0,race:0n,attack:0,defense:0,lscale:0,rscale:0,link_marker:0});
 const reader=n=>{if(n==='c0.lua')return '';if(n===`c${filler}.lua`)return 'local s,id=GetID() function s.initial_effect(c) end';const p=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',n),path.join(ROOT,'tmp/omega_scripts',n)].find(fs.existsSync);assert(p,n);let s=fs.readFileSync(p,'utf8');if(n===`c${spell}.lua`){const old=path.join(OUT,'intergalactica-materials-before-repair',n);if(fs.existsSync(old))s=fs.readFileSync(old,'utf8');if(mode==='no-payment')s=s.replace('Duel.SendtoDeck(mat,nil,SEQ_DECKSHUFFLE,REASON_EFFECT+REASON_MATERIAL+REASON_FUSION)','0');}if(n===`c${boss}.lua`&&process.argv.includes('--map-predicates'))s=s.replace('mc:IsFusionSetCard(SET_GALACTICA)','mc:IsSetCard(SET_GALACTICA)').replace('mc:IsFusionAttribute(ATTRIBUTE_LIGHT)','mc:IsAttribute(ATTRIBUTE_LIGHT)');return s;};
 const d=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});let failure=null,activated=false,done=false;
 try{
 for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(d,n,reader(n));
 const add=(code,location,player=0,sequence=0)=>core.duelNewCard(d,{team:player,duelist:0,code,controller:player,location,sequence,position:P.FACEUP_ATTACK});
 add(spell,L.HAND);add(boss,L.EXTRA);if(kind!=='no-galactica')add(galactica,kind==='optional-cost'?L.MZONE:L.REMOVED);if(kind!=='no-galaxy')add(galaxy,L.REMOVED);for(const p of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,p);core.startDuel(d);
 const query=loc=>core.duelQueryLocation(d,{flags:Q.CODE|Q.REASON|Q.SUMMON_TYPE|Q.STATUS,controller:0,location:loc}).filter(Boolean);
 for(let step=0;step<200&&!done;step++){
 const state=core.duelProcess(d),messages=core.duelGetMessage(d);trace.push(...messages);assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){if(!activated){const index=p.activates.findIndex(c=>c.code===spell),eligible=!kind.startsWith('no-');assert.equal(index>=0,eligible,'Original recipient recipe can use its non-Galactica LIGHT Galaxy material');if(!eligible){done=true;continue;}activated=true;core.duelSetResponse(d,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}assert(query(L.MZONE).some(c=>c.code===boss),'Actual original Fusion Summon');assert(!query(L.REMOVED).some(c=>[galactica,galaxy].includes(c.code)),'Both materials actually shuffled from banishment');assert(query(L.DECK).some(c=>c.code===galactica)&&query(L.DECK).some(c=>c.code===galaxy),'Both real material identities in Deck');if(kind==='optional-cost')assert(trace.some(m=>m.type===M.MOVE&&m.card===galactica&&m.from.location===L.MZONE&&m.to.location===L.REMOVED),'Original optional field banishment cost');done=true;
 }else if(p.type===M.SELECT_CARD)core.duelSetResponse(d,{type:R.SELECT_CARD,indicies:p.selects.map((_,i)=>i).slice(0,p.min)});
 else if(p.type===M.SELECT_UNSELECT_CARD)core.duelSetResponse(d,{type:R.SELECT_UNSELECT_CARD,index:p.can_finish?null:0});
 else if(p.type===M.SELECT_YESNO)core.duelSetResponse(d,{type:R.SELECT_YESNO,yes:false});
 else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(d,{type:R.SELECT_EFFECTYN,yes:false});
 else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(d,{type:R.SELECT_CHAIN,index:p.forced?0:null});
 else if(p.type===M.SELECT_PLACE){const entries=[];for(const [location,offset] of [[L.MZONE,0],[L.SZONE,8]])for(let sequence=0;sequence<7;sequence++)if((p.field_mask&(1<<(offset+sequence)))===0)entries.push({player:0,location,sequence});assert(entries.length);core.duelSetResponse(d,{type:R.SELECT_PLACE,places:[entries[0]]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(d,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(d);}results.push({kind,failure,logs,trace});console.log(kind,failure?failure.slice(0,240):'PASS');
 }
 fs.writeFileSync(path.join(OUT,`current-intergalactica-materials-${mode}${process.argv.includes('--map-predicates')?'-mapped':''}.json`),JSON.stringify({mode,predicate_mapping:process.argv.includes('--map-predicates')?'TEST_MAPPED original recipe predicates to base set/attribute for these unchanged-metadata materials; no production API change':null,scope:'Original Fusion Intergalactica and Intergalataxiakos recipe using installed real Galacticarina/To Proto Psychi metadata and original scripts. Initially banished materials (prior banishment histories not certified), optional original cost, native material selection/payment/summon. No Lua API mappings; other clauses/live open.',results},(_,v)=>typeof v==='bigint'?String(v):v,2));
}
main().catch(e=>{console.error(e);process.exitCode=1});
