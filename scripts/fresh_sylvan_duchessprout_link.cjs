'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{sylvanCard}=require('./fresh_sylvan_metadata.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=238276578,mat=900001011,plant=900001012,other=900001013,setup=900001014,filler=900001015,results=[];
 for(const test of [{},{unrelated:true},{decline:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([mat,plant,other,setup,filler].map(code=>[code,{...base,code}]));
  cards.set(mat,{...cards.get(mat),setcodes:test.unrelated?[]:[0x90]});cards.set(other,{...cards.get(other),race:1n});cards.set(setup,{...cards.get(setup),type:2,level:0});cards.set(boss,sylvanCard(boss));
  const reader=name=>{
   if(name==='c'+setup+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) '+[other,plant].map(code=>'local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_DECK,0,nil,'+code+'):GetFirst() Duel.MoveSequence(tc,SEQ_DECKTOP)').join(' ')+' end) c:RegisterEffect(e) end';
   if([mat,plant,other,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8');
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,prepared=false,summoned=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position:P.FACEUP_ATTACK});
   add(boss,L.EXTRA);add(mat,L.MZONE);add(setup,L.HAND);add(plant,L.DECK);add(other,L.DECK);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.SUMMON_TYPE,controller:0,location}).filter(Boolean);
   for(let step=0;step<120&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!prepared){const index=p.activates.findIndex(x=>x.code===setup);assert(index>=0);prepared=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     const index=p.special_summons.findIndex(x=>x.code===boss);
     if(test.unrelated){assert.equal(index,-1,'Unrelated Link material accepted');done=true;continue;}
     if(!summoned){assert(index>=0,'Link Summon unavailable');summoned=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SPECIAL_SUMMON,index});continue;}
     assert(query(L.MZONE).some(x=>x.code===boss),'Link monster not on field');
     assert(query(L.GRAVE).some(x=>x.code===mat&&(x.reason&0x8)),'Material reason missing');
     assert.equal(trace.some(x=>x.type===M.CONFIRM_DECKTOP&&x.cards.length===2&&x.cards[0].code===plant),!test.decline,'Link excavation trigger mismatch');
     assert.equal(query(L.GRAVE).some(x=>x.code===plant&&(x.reason&0x8000000)),!test.decline,'Excavated Plant result mismatch');
     if(!test.decline)assert.equal(query(L.DECK)[0].code,other,'Remaining card not on bottom');done=true;
    }else if(p.type===M.SELECT_UNSELECT_CARD)core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index:p.can_finish?null:p.select_cards.findIndex(x=>x.code===mat)});
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(x=>x.code===mat);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(x=>x.code===boss);core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:!test.decline&&index>=0?index:p.forced?0:null});}
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:!test.decline});
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[5,6,0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/sylvan-duchessprout-link.json'),JSON.stringify({engine:'Public OCGCore with pinned Omega helpers, full production Duchessprout and candidate metadata; actual Link Summon attempt, neutral material/top cards; native Omega untested',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});

