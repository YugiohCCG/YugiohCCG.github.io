'use strict';
const {sylvanCard}=require('./fresh_sylvan_metadata.cjs');
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=238276574,ally=900000961,target=900000962,setup=900000963,filler=900000964,plant=900000965,msg=132276574,results=[];
 for(const test of [{},{grave:true},{searchGY:true},{opponent:true},{unrelated:true},{full:true,opponent:true},{twoCopies:true},{excavate:1},{excavate:2},{excavate:3}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,{...base,code:boss,setcodes:[0x90],level:6,attack:2400,defense:1500}],[ally,{...base,code:ally,setcodes:test.unrelated?[]:[0x90]}],[target,{...base,code:target,type:2,setcodes:[0x90],level:0}],[setup,{...base,code:setup,type:2,level:0}],[filler,{...base,code:filler,race:1n}],[plant,{...base,code:plant}]]);
  cards.set(boss,sylvanCard(boss));
  const reader=name=>{
   if(name===`c${setup}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) ${test.excavate?`local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_DECK,0,nil,${plant}) for tc in aux.Next(g) do Duel.MoveSequence(tc,SEQ_DECKTOP) end`:`local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_GRAVE,0,nil,${ally}):GetFirst() Duel.SpecialSummon(tc,0,tp,${test.opponent?'1-tp':'tp'},false,false,POS_FACEUP)`} end) c:RegisterEffect(e) end`;
   if([ally,target,filler,plant].some(id=>name===`c${id}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');if(name===`c${boss}.lua`&&process.argv.includes('--no-self-count'))source=source.replace('e2:SetCountLimit(1,id)','--no count');return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,excavated=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position:P.FACEUP_ATTACK});
   add(setup,L.HAND);add(boss,test.excavate?L.MZONE:test.grave?L.GRAVE:L.HAND);if(test.twoCopies)add(boss,L.HAND);if(test.excavate){for(let i=0;i<3;i++)add(plant,L.DECK);}else{add(ally,L.GRAVE);add(target,test.searchGY?L.GRAVE:L.DECK);}if(test.full)for(let i=0;i<5;i++)add(filler,L.MZONE,0,i);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,controller:0,location});
   for(let step=0;step<130&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!activated){const index=p.activates.findIndex(c=>c.code===setup);if(index<0)throw Error('Setup unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(test.excavate){const index=p.activates.findIndex(c=>c.code===boss&&String(c.description)===String(msg*16));if(!excavated){if(index<0)throw Error('Excavation unavailable');excavated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}if(index>=0)throw Error('Soft count failed');const g=query(L.GRAVE).filter(c=>c?.code===plant);if(g.length!==test.excavate||g.some(c=>(c.reason&0x8000000)===0||(c.reason&0x40)===0))throw Error('Chosen excavation count/reasons mismatch');}
     else{const legal=!test.full&&!test.unrelated;if(query(L.MZONE).filter(c=>c?.code===boss).length!==(legal?1:0))throw Error('Actual self-Summon/count mismatch');if(query(L.HAND).some(c=>c?.code===target)!==legal)throw Error('Actual on-Summon search mismatch');}done=true;
    }else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===boss);core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===target);if(index<0)throw Error('Search target missing');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.ANNOUNCE_NUMBER)core.duelSetResponse(duel,{type:R.ANNOUNCE_NUMBER,value:test.excavate-1});
    else if(p.type===M.SELECT_PLACE){let place;for(const player of [0,1])for(const location of [L.MZONE,L.SZONE])for(let sequence=0;sequence<5;sequence++){const offset=player*16+(location===L.SZONE?8:0)+sequence;if(!place&&(p.field_mask&(1<<offset))===0)place={player,location,sequence};}if(!place)throw Error('No legal placement');core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[place]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }if(!done)throw Error('Step limit');
  }catch(e){failure=e.message}finally{core.destroyDuel(duel)}
  results.push({...test,failure,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,`output/fresh-ccg-september/sylvan-flamioak${process.argv.includes('--no-self-count')?'-no-self-count':''}.json`),JSON.stringify({engine:'Public OCGCore with complete Flamioak; neutral cards and actual Summon/top-order fixture Spell; no helper adapter; native Omega untested',control:process.argv.includes('--no-self-count')?'Self-Summon shared count removed in memory':null,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1});
