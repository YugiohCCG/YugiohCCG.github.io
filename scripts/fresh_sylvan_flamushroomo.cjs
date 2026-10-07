'use strict';
const {sylvanCard}=require('./fresh_sylvan_metadata.cjs');
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=238276572,plant=900000941,nonplant=900000942,deckspell=900000943,handspell=900000944,ally=900000945,setup=900000946,filler=900000947,msg=132276572,results=[];
 const tests=[{},{normal:true},{three:true},{three:true,reverse:true},{three:true,allPlants:true},{three:true,decline:true},{noHand:true},{recruit:true},{recruit:true,hand:true},{recruit:true,self:true},{recruit:true,ordinary:true},{recruit:true,cost:true},{recruit:true,fromHand:true},{recruit:true,full:true},{recruit:true,twoCopies:true}];
 for(const test of tests){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,{...base,code:boss,setcodes:[0x90],defense:2000}],[plant,{...base,code:plant}],[nonplant,{...base,code:nonplant,race:1n}],[deckspell,{...base,code:deckspell,type:2,level:0}],[handspell,{...base,code:handspell,type:2,setcodes:[0x90],level:0}],[ally,{...base,code:ally,setcodes:[0x90]}],[setup,{...base,code:setup,type:2,level:0}],[filler,{...base,code:filler,race:1n}]]);
  cards.set(boss,sylvanCard(boss));
  const reader=name=>{
   if(name===`c${setup}.lua`){
    const order=test.recruit?[boss]:test.three&&!test.allPlants?[plant,nonplant,deckspell]:[plant];
    const prep=test.allPlants||test.twoCopies?`local pg=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_DECK,0,nil,${test.twoCopies?boss:plant}) for tc in aux.Next(pg) do Duel.MoveSequence(tc,SEQ_DECKTOP) end`:!test.fromHand?order.slice().reverse().map(code=>`local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_DECK,0,nil,${code}):GetFirst() Duel.MoveSequence(tc,SEQ_DECKTOP)`).join(' '):'';
    const action=test.recruit?`local g=Duel.GetMatchingGroup(Card.IsCode,tp,${test.fromHand?'LOCATION_HAND':'LOCATION_DECK'},0,nil,${boss}) ${!test.ordinary&&!test.fromHand?`Duel.ConfirmDecktop(tp,${test.twoCopies?2:1})`:''} Duel.SendtoGrave(g,${test.cost?'REASON_COST+REASON_REVEAL':test.ordinary?'REASON_EFFECT':'REASON_EFFECT+REASON_REVEAL'})`:test.normal?'':`local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,${boss}):GetFirst() Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)`;
    return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) ${prep} ${action} end) c:RegisterEffect(e) end`;
   }
   if([plant,nonplant,deckspell,handspell,ally,filler].some(id=>name===`c${id}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');if(name===`c${boss}.lua`){if(process.argv.includes('--no-count'))source=source.replace('e3:SetCountLimit(1,id)','--no count limit');if(process.argv.includes('--no-effect-reason'))source=source.replace(' and c:IsReason(REASON_EFFECT)','');}return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,normal=false,offered=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position:P.FACEUP_ATTACK});
   add(setup,L.HAND);add(boss,test.recruit&&!test.fromHand?L.DECK:L.HAND);if(test.twoCopies){add(boss,L.DECK);add(ally,L.GRAVE);}
   if(test.recruit){if(!test.self)add(ally,test.hand?L.HAND:L.GRAVE);if(test.full)for(let i=0;i<5;i++)add(filler,L.MZONE,0,i);}
   else{if(!test.noHand)add(handspell,L.HAND);if(test.three){add(ally,L.HAND);add(handspell,L.HAND);}add(plant,L.DECK);if(test.three){if(test.allPlants){add(plant,L.DECK);add(plant,L.DECK);}else{add(nonplant,L.DECK);add(deckspell,L.DECK);}}}
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,controller:0,location});
   for(let step=0;step<120&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!activated){const index=p.activates.findIndex(c=>c.code===setup);if(index<0)throw Error('Setup unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(test.normal&&!normal){const index=p.summons.findIndex(c=>c.code===boss);if(index<0)throw Error('Normal Summon unavailable');normal=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SUMMON,index});continue;}
     if(test.recruit){const legal=!test.ordinary&&!test.cost&&!test.fromHand&&!test.full;if(offered!==legal)throw Error('Excavation trigger legality mismatch');if(query(L.MZONE).filter(c=>c?.code===(test.self?boss:ally)).length!==(legal?1:0))throw Error('Actual recruitment/count-limit mismatch');if(!test.self&&!query(L.GRAVE).some(c=>c?.code===boss))throw Error('Excavated handler left GY');}
     else{const expected=!test.noHand&&!test.decline;if(offered!==!test.noHand)throw Error('Summon trigger legality mismatch');const sent=query(L.GRAVE).filter(c=>c?.code===plant);if(sent.length!==(expected?(test.allPlants?3:1):0)||sent.some(c=>(c.reason&0x40)===0||(c.reason&0x8000000)===0))throw Error('Actual excavated Plant sending mismatch');if(test.three&&!test.allPlants&&expected){const codes=query(L.DECK).filter(Boolean).map(c=>c.code);const bottom=test.reverse?[nonplant,deckspell]:[deckspell,nonplant];if(JSON.stringify(codes.slice(0,2))!==JSON.stringify(bottom))throw Error('Bottom order mismatch '+JSON.stringify(codes));if(!trace.some(m=>m.type===M.SORT_CARD))throw Error('Bottom ordering prompt missing');}}
     done=true;
    }else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===boss&&String(c.description)===String(msg*16+(test.recruit?1:0)));if(index>=0)offered=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?(test.decline?null:index):p.forced?0:null});}
    else if(p.type===M.SELECT_EFFECTYN){if(test.recruit&&String(p.description)===String(msg*16))core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});else{offered=true;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:!test.decline});}}
    else if(p.type===M.SELECT_CARD){const indices=p.selects.map((c,i)=>(test.recruit?c.code===(test.self?boss:ally):[handspell,ally].includes(c.code))?i:-1).filter(i=>i>=0).slice(0,test.recruit?1:test.three?3:1);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:indices});}
    else if(p.type===M.SORT_CARD){const order=p.cards.map((_,i)=>i);if(test.reverse)order.reverse();if(process.argv.includes('--wrapper-sort'))core.duelSetResponse(duel,{type:R.SORT_CARD,order});else{const encoded={length:order[0],*[Symbol.iterator](){yield* order.slice(1);}};core.duelSetResponse(duel,{type:R.SORT_CARD,order:encoded});}}
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }if(!done)throw Error('Step limit');
  }catch(e){failure=e.message}finally{core.destroyDuel(duel)}
  results.push({...test,failure,offered,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 const control=['--wrapper-sort','--no-count','--no-effect-reason'].find(flag=>process.argv.includes(flag));
 fs.writeFileSync(path.join(ROOT,`output/fresh-ccg-september/sylvan-flamushroomo${control?control.slice(1):''}.json`),JSON.stringify({engine:'Public OCGCore; full production Flamushroomo; actual ordering/Summon/excavation/send fixture Spell and neutral cards; native Omega untested',control:control||null,adapter:process.argv.includes('--wrapper-sort')?null:'SORT_CARD wrapper prepends array length, but core expects only permutation bytes. Iterable length emits first permutation byte and iterator emits remaining bytes; no Lua/core effect changed. Primary playerop.cpp SortCard validates bytes directly.',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1});
