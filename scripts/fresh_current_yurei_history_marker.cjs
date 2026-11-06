'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict');
const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport(),{candidateCard}=require('./fresh_installed_card.cjs');
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),prior=process.argv.includes('--prior-source'),results=[];
 for(const reference of [false,true])for(const test of [{},{disabled:true},{flip:true},{disabled:true,flip:true},{disabled:true,keep:true}]){
  const boss=259844716,drain=82732705,remover=900009741,filler=900009742,logs=[],trace=[],base={alias:0,setcodes:[],type:2,level:0,attribute:0,race:0n,attack:0,defense:0,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[drain,{...base,code:drain,type:0x20004}],[remover,{...base,code:remover}],[filler,{...base,code:filler}]]);
  const reader=name=>{
   if(name==='c0.lua')return '';
   if(name==='c'+boss+'.lua'){
    if(reference)return 'local s,id=GetID() function s.initial_effect(c) aux.EnableSpiritReturn(c,EVENT_SUMMON_SUCCESS,EVENT_FLIP) end';
    let lua=fs.readFileSync(path.join(OUT,'yurei-before-history-marker-repair',name),'utf8');if(!prior)lua=require('./fresh_yurei_history_marker_repair.cjs').corrected(lua);if(process.argv.includes('--unnegatable-return'))lua=lua.replace('e3:SetCountLimit(1);','e3:SetProperty(EFFECT_FLAG_CANNOT_DISABLE); e3:SetCountLimit(1);');return lua;
   }
   if(name==='c'+filler+'.lua')return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c'+remover+'.lua')return `local s,id=GetID() function s.initial_effect(c) local x=Effect.CreateEffect(c) x:SetType(EFFECT_TYPE_ACTIVATE) x:SetCode(EVENT_FREE_CHAIN) x:SetOperation(function(e,tp) Duel.SendtoGrave(Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_SZONE,LOCATION_SZONE,nil,${drain}),REASON_EFFECT) end) c:RegisterEffect(x) end`;
   const p=path.join(ROOT,'tmp/omega_scripts',name);assert(fs.existsSync(p),name);return fs.readFileSync(p,'utf8');
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,done=false,summoned=false,removed=false;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   const add=(code,location,player=0,position=P.FACEUP_ATTACK,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,position,sequence});
   add(boss,test.flip?L.MZONE:L.HAND,0,test.flip?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK);if(test.disabled)add(drain,L.SZONE,1);add(remover,L.HAND);for(const p of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,p,P.FACEDOWN_DEFENSE);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<160&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(p.player===1){assert.equal(query(L.HAND).some(c=>c.code===boss),!test.keep,'Return after native End Phase');assert.equal(trace.some(m=>m.type===M.CHAINING&&m.code===boss),true,'Original mandatory End Phase effect activates even when resolution is negated');done=true;continue;}
     if(!summoned){const list=test.flip?p.pos_changes:p.summons,index=list.findIndex(c=>c.code===boss);assert(index>=0,'Original native Normal/Flip Summon available');summoned=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:test.flip?A.SELECT_POS_CHANGE:A.SELECT_SUMMON,index});continue;}
     if(test.disabled&&!test.keep&&!removed){const index=p.activates.findIndex(c=>c.code===remover);assert(index>=0);removed=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});
    }else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});
    else if(p.type===M.SELECT_PLACE){const shift=[0,8,16,24].find(v=>[0,1,2,3,4].some(i=>(p.field_mask&(1<<(v+i)))===0)),sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:shift>=16?1-p.player:p.player,location:shift%16===8?L.SZONE:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({reference,test,failure,trace,logs});console.log((failure?'FAIL ':'PASS ')+(reference?'reference ':'original ')+JSON.stringify(test)+(failure?' '+failure:''));
 }
 fs.writeFileSync(path.join(OUT,'current-yurei-history-marker'+(prior?'-prior-source':process.argv.includes('--unnegatable-return')?'-unnegatable-return':'')+'.json'),JSON.stringify({scope:'Full original Yurei native Normal/Flip Summon and mandatory End Phase return, actual bundled Skill Drain and native removal. Separate standard bundled Spirit-return helper reference using identical source metadata. No Lua API mapping; neutral removal Spell. Not full-card/live Omega certification.',prior,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
