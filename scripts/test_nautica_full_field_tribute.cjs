'use strict';
// Original Evander/Adventures effects; initially seeded source, neutral Link target/recipient.
// Adventures needs the existing explicit public-core target-card flag mapping.
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict');
const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport();
 const {candidateCard}=require('./fresh_installed_card.cjs');
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),patched=process.argv.includes('--candidate'),results=[];
 for(const boss of [225109525,218905439])for(const test of [{tribute:true},{tribute:true,full:true},{full:true}]){
  const own=900008701,target=900008702,recipient=900008703,body=900008704,setup=900008705,filler=900008706;
  const base={alias:0,setcodes:[],type:33,level:2,attribute:2,race:64n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[own,{...base,code:own,setcodes:[0x8f0]}],[target,{...base,code:target,type:0x4000021,level:1,link_marker:2}],[recipient,{...base,code:recipient,level:test.tribute?5:2}],[body,{...base,code:body}],[setup,{...base,code:setup,type:2}],[filler,{...base,code:filler,type:2}]]);
  const logs=[],trace=[];
  const reader=name=>{
   if(name==='c0.lua')return '';
   if([own,target,recipient,body,filler].some(code=>name===`c${code}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name===`c${setup}.lua`)return `local s,id=GetID() function s.initial_effect(c) local x=Effect.CreateEffect(c) x:SetType(EFFECT_TYPE_ACTIVATE) x:SetCode(EVENT_FREE_CHAIN) x:SetOperation(function(e,tp) local c=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,${boss}):GetFirst() local m=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_GRAVE,0,nil,${own}):GetFirst() assert(c and m) Duel.Overlay(c,Group.FromCards(m)) end) c:RegisterEffect(x) end`;
   const p=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(fs.existsSync);assert(p,'Missing '+name);
   let lua=fs.readFileSync(p,'utf8');if(name===`c${boss}.lua`&&patched)lua=lua.replace('or (ft>0 and Duel.IsPlayerCanSummon(p)','or (Duel.IsPlayerCanSummon(p)');return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,turn=0,prepared=false,activated=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   if(boss===218905439)core.loadScript(duel,'explicit-target-card-flag.lua','CHAININFO_TARGET_CARDS=8');
   const add=(code,location,player=0,sequence=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   if(boss===225109525){add(boss,L.MZONE);add(own,L.GRAVE);add(setup,L.HAND);}else{add(boss,L.SZONE,0,0,P.FACEDOWN_DEFENSE);add(own,L.MZONE);prepared=true;}
   add(target,L.MZONE,1,5);add(recipient,L.HAND,1);
   for(let j=0;j<(test.full?5:1);j++)add(body,L.MZONE,1,j);
   for(const p of [0,1])for(let j=0;j<10;j++)add(filler,L.DECK,p);
   core.startDuel(duel);
   const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.ATTACK|Q.REASON,controller,location}).filter(Boolean);
   for(let step=0;step<240&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);turn+=messages.filter(m=>m.type===M.NEW_TURN).length;
    if(logs.some(l=>l.type===0))throw Error(logs.map(l=>l.message).join('; '));assert.notEqual(state,S.END,'Unexpected duel end');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(turn<3||p.player!==0){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
     if(!prepared){const index=p.activates.findIndex(c=>c.code===setup);assert(index>=0);prepared=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(!activated){const index=p.activates.findIndex(c=>c.code===boss);assert(index>=0,'Original activation available through main-zone return alternative');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert(trace.some(m=>m.type===M.MOVE&&m.card===target&&m.from.location===L.MZONE&&m.to.location===L.EXTRA),'Actual Extra Monster Zone target returned to Extra Deck');
     const tc=query(L.MZONE,1).find(c=>c.code===recipient);assert(tc,'Actual recipient Normal Summon');assert.equal(tc.attack,0,'Followup ATK zero');
     assert.equal(query(L.GRAVE,1).filter(c=>c.code===body).length,1,'One original monster actually Tributed');
     if(boss===225109525)assert(query(L.GRAVE).some(c=>c.code===own),'Original detach cost paid');else assert(query(L.HAND).some(c=>c.code===own),'Original own Nautica returned');done=true;
    }else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:true});
    else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:0});
    else if(p.type===M.SELECT_CARD){if(p.selects.some(c=>c.code===body)){const available=p.selects.some(c=>c.code===target);assert.equal(available,!!test.tribute,'Extra Zone target eligibility accounts for legal Tribute Summon');if(!test.tribute){done=true;continue;}}const wanted=p.selects.some(c=>c.code===target)?target:p.selects.some(c=>c.code===own)?own:recipient;const indices=p.selects.map((c,i)=>c.code===wanted?i:-1).filter(i=>i>=0);assert(indices.length,'Expected source target or summon recipient offered');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[indices[0]]});}
    else if(p.type===M.SELECT_UNSELECT_CARD)core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index:p.can_finish?null:0});
    else if(p.type===M.SELECT_TRIBUTE)core.duelSetResponse(duel,{type:R.SELECT_TRIBUTE,indicies:[0]});
    else if(p.type===M.SELECT_PLACE){let place;for(const side of [0,1])for(const zone of [L.MZONE,L.SZONE])for(let seq=0;seq<5;seq++)if(!place&&(p.field_mask&(1<<(side*16+(zone===L.SZONE?8:0)+seq)))===0)place={player:p.player^side,location:zone,sequence:seq};assert(place);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[place]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({boss,test,failure,logs,trace});console.log((failure?'FAIL ':'PASS ')+boss+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(OUT,`nautica-full-field-tribute-${patched?'candidate':'source'}.json`),JSON.stringify({qualification:'Original full effects, initially field-seeded source and neutral Extra Monster Zone Link/tribute recipient. Evander paid native Overlay setup; Adventures explicit target-card flag8 mapping. No live Omega or full-card certification.',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
