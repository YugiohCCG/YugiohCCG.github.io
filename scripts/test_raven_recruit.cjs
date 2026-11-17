'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict');
const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport(),{candidateCard}=require('./fresh_installed_card.cjs');
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=259454809,host=900008801,recruit=900008802,setup=900008803,filler=900008804,results=[];
 for(const test of [{origin:'hand'},{origin:'grave'},{origin:'overlay'},{origin:'overlay',opponentOwned:true},{origin:'overlay',opponent:true},{origin:'overlay',wrongSet:true},{origin:'hand',full:true}]){
  const base={alias:0,setcodes:[],type:33,level:6,attribute:8,race:0x4000n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[host,{...base,code:host,type:0x800021}],[recruit,{...base,code:recruit,setcodes:test.wrongSet?[]:[0x3de1]}],[setup,{...base,code:setup,type:2}],[filler,{...base,code:filler,type:2}]]);
  const logs=[],trace=[];
  const reader=name=>{
   if(name==='c0.lua')return '';
   if([host,recruit,filler].some(code=>name===`c${code}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name===`c${setup}.lua`)return `local s,id=GetID() function s.initial_effect(c) local x=Effect.CreateEffect(c) x:SetType(EFFECT_TYPE_ACTIVATE) x:SetCode(EVENT_FREE_CHAIN) x:SetOperation(function(e,tp) local c=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,LOCATION_MZONE,nil,${host}):GetFirst() local m=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_GRAVE,LOCATION_GRAVE,nil,${recruit}):GetFirst() assert(c and m) Duel.Overlay(c,Group.FromCards(m)) end) c:RegisterEffect(x) end`;
   const file=[process.argv.includes('--installed')&&process.env.CCG_OMEGA_SCRIPTS&&path.join(process.env.CCG_OMEGA_SCRIPTS,name),path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].filter(Boolean).find(fs.existsSync);assert(file,'Missing '+name);let lua=fs.readFileSync(file,'utf8');if(name===`c${boss}.lua`&&process.argv.includes('--candidate'))lua=require('./raven_recruit_repair.cjs').corrected(lua);return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,prepared=test.origin!=='overlay',activated=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position:P.FACEUP_ATTACK});
   add(boss,L.MZONE);add(host,L.MZONE,test.opponent?1:0,1);
   add(recruit,test.origin==='hand'?L.HAND:L.GRAVE,test.opponentOwned?1:0);if(!prepared)add(setup,L.HAND);
   if(test.full)for(let seq=2;seq<5;seq++)add(recruit,L.MZONE,0,seq);
   for(const p of [0,1])for(let j=0;j<10;j++)add(filler,L.DECK,p);
   core.startDuel(duel);
   const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.OVERLAY_CARD,controller,location}).filter(Boolean);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(l=>l.type===0))throw Error(logs.map(l=>l.message).join('; '));assert.notEqual(state,S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!prepared){const index=p.activates.findIndex(c=>c.code===setup);assert(index>=0);prepared=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(!activated){const index=p.activates.findIndex(c=>c.code===boss&&Number(c.description)===133454809*16+1);const legal=!test.full&&!test.opponent&&!test.wrongSet;assert.equal(index>=0,legal,'Original Raven recruitment availability by material host/controller');if(!legal){done=true;continue;}activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert(query(L.MZONE).some(c=>c.code===recruit),'Recruit actually summoned');assert(trace.some(m=>m.type===M.MOVE&&m.card===recruit&&m.to.location===L.MZONE),'Native recruit move');if(test.origin==='overlay')assert(trace.some(m=>m.type===M.MOVE&&m.card===recruit&&m.to.overlay_sequence!==undefined),'Actual prior native Overlay setup');done=true;
    }else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===recruit);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_PLACE){let place;for(const side of [0,1])for(const zone of [L.MZONE,L.SZONE])for(let seq=0;seq<5;seq++)if(!place&&(p.field_mask&(1<<(side*16+(zone===L.SZONE?8:0)+seq)))===0)place={player:p.player^side,location:zone,sequence:seq};assert(place);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[place]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,logs,trace});console.log((failure?'FAIL ':'PASS ')+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(OUT,'current-raven-recruit'+(process.argv.includes('--candidate')?'-candidate':'')+'.json'),JSON.stringify({qualification:'Full original Raven source and installed metadata; initially field Raven and neutral seeded Xyz host with actual native Overlay setup. No Lua API mapping; card-data transport correction retained. No original Xyz recipe/full-card/live Omega certification.',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
