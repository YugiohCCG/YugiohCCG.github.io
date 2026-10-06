'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=210716547,lab=900001191,filler=900001192,spellCost=900001193,recipient=900001194,results=[];
 const control=process.argv.includes('--no-send')?'no-send':process.argv.includes('--no-count')?'no-count':null;
 for(const test of [{},{normal:true},{spell:true},{trap:true},{wrongSet:true},{absent:true},{count:true},{count:true,normalFirst:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:test.spell?2:test.trap?4:33,setcodes:test.wrongSet?[]:[0xc1c]}],[filler,{...base,code:filler}],[recipient,{...base,code:recipient,type:2}]]);
  cards.set(spellCost,{...base,code:spellCost,type:2});
  const reader=name=>{
   if(name==='c'+spellCost+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local c=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,'+boss+'):GetFirst() '+(test.normalFirst?'Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)':'Duel.Summon(tp,c,true,nil)')+' end) c:RegisterEffect(e) end';
   if(name==='c'+recipient+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local c=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,'+boss+'):GetFirst() '+(test.normal||test.normalFirst?'Duel.Summon(tp,c,true,nil)':'Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)')+' end) c:RegisterEffect(e) end';
   if([lab,filler,spellCost,recipient].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){
    if(control==='no-count')lua=lua.replace('e1:SetCountLimit(1,id)','do end');
    if(control==='no-send')lua=lua.replace('Duel.SendtoGrave(g,REASON_EFFECT)','do end');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false,turn=0,secondary=false,placementStarted=false,placementFinished=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(boss,L.HAND);add(recipient,L.HAND);if(!test.absent)add(lab,L.DECK);if(test.count){add(boss,L.HAND);add(spellCost,L.HAND);add(lab,L.DECK);}if(test.normal||test.count)add(filler,L.MZONE,0,P.FACEUP_ATTACK);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,controller:0,location}).filter(Boolean);
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(!activated){const index=p.activates.findIndex(c=>c.code===recipient);assert(index>=0,'Actual summon helper');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}assert(query(L.MZONE).some(c=>c.code===boss),'Actual source Summoned');assert(trace.some(m=>m.type===(test.normal||test.normalFirst?M.SUMMONED:M.SPSUMMONED)),'Native printed summon route');const eligible=!test.wrongSet&&!test.absent;assert.equal(trace.some(m=>m.type===M.CHAINING&&m.code===boss),eligible,'Native production summon trigger');if(eligible){const sent=query(L.GRAVE).find(c=>c.code===lab);assert(sent&&(sent.reason&0x40),'Actual selected Aldrez sent Deck to GY as effect');assert(!(sent.reason&0x80),'Deck send is not cost');assert.equal(query(L.DECK).filter(c=>c.code===lab).length,test.count?1:0,'Legal Deck remainder after send');}if(test.normal||test.count&&secondary||test.normalFirst){const tribute=query(L.GRAVE).find(c=>c.code===filler);assert(tribute&&(tribute.reason&2)&&(tribute.reason&0x10),'Native Normal Summon Tribute');}if(test.count){if(!secondary){assert.equal(query(L.HAND).filter(c=>c.code===boss).length,1,'Second source retained before second summon');const index=p.activates.findIndex(c=>c.code===spellCost);assert(index>=0,'Second actual summon helper');secondary=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}assert.equal(query(L.MZONE).filter(c=>c.code===boss).length,2,'Both full-production sources actually summoned');assert(trace.some(m=>m.type===M.SUMMONED)&&trace.some(m=>m.type===M.SPSUMMONED),'Actual Normal and Special Summon routes');assert.equal(trace.filter(m=>m.type===M.CHAINING&&m.code===boss).length,1,'Shared limit across summon clones/copies');assert.equal(query(L.GRAVE).filter(c=>c.code===lab).length,1,'Only first Deck send resolves');}done=true;}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===lab);assert(index>=0,'Actual Deck card choice');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_TRIBUTE){const index=p.selects.findIndex(c=>c.code===filler);assert(index>=0,'Actual Normal Summon Tribute choice');core.duelSetResponse(duel,{type:R.SELECT_TRIBUTE,indicies:[index]});}
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x1f)!==0x1f;const shift=isMonster?0:8;const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
    else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===boss);core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/clock-aldrez-summon'+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:null,engine:'Public OCGCore, full production Clock of Aldrez/candidate metadata; neutral supporting cards. Actual Normal/Special Summon then production Aldrez Deck send, neutral Deck card; native Omega unverified; no native Omega certification.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(c=>c.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
