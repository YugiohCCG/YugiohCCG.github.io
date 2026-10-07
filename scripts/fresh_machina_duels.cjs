'use strict';
// Engine scenarios for new Machina scripts using the staged Omega database.
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url');
const {DatabaseSync}=require('node:sqlite'),{createHash}=require('node:crypto');
const ROOT=path.resolve(__dirname,'..'), OMEGA=path.join(ROOT,'tmp/omega_scripts');
const CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}});
 const megaframe=process.argv.includes('--megaframe');
 const code=megaframe?244163508:244163509, support=900000021, spell=900000022, filler=900000023, levelTen=900000024;
 const baseline=JSON.parse(fs.readFileSync(path.join(ROOT,'output/fresh-ccg-september/baseline-remote.json'),'utf8'));
 const spec=baseline.cards.find(c=>c.passcode===code).specification;
 const dbPath=path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db');
 const db=new DatabaseSync(dbPath,{readOnly:true});
 const query=db.prepare('select * from datas where id=?');query.setReadBigInts(true);
 const row=query.get(code);db.close();
 if(!row||Number(row.atk)!==spec.atk||Number(row.def)!==spec.def||Number(row.level)!==spec.level)throw Error('Candidate metadata does not match printed stats');
 const setcodes=row.setcode instanceof Uint8Array
  ? Array.from({length:row.setcode.length/2},(_,i)=>row.setcode[i*2]|(row.setcode[i*2+1]<<8)).filter(Boolean)
  : [Number(BigInt(row.setcode)&65535n)];
 const base={alias:0,setcodes:[],type:17,level:4,attribute:1,race:0x20n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const results=[];
 for(const test of megaframe?[
  {name:'Revive and search another Megaframe',machina:true,level:10,revives:true,expectTrigger:true},
  {name:'Deck monster redirected to banishment: no revival',machina:true,level:10,redirect:true,revives:false,expectTrigger:true},
  {name:'No controlled Machina: no revival trigger',machina:false,level:10,revives:false,expectTrigger:false},
  {name:'Level 9 cannot satisfy Level 10 requirement',machina:true,level:9,revives:false,expectTrigger:false}
 ]:[
  {name:'EARTH Machine, decline destruction',attribute:1,race:0x20n,destroy:false,canSummon:true},
  {name:'DARK Machine, accept destruction',attribute:32,race:0x20n,destroy:true,canSummon:true},
  {name:'WATER Machine is insufficient',attribute:2,race:0x20n,canSummon:false},
  {name:'EARTH Warrior is insufficient',attribute:1,race:1n,canSummon:false}
 ]){
  const trace=[],logs=[],requests=[];
  const data=new Map([[code,{...base,code,setcodes,type:Number(row.type),level:Number(row.level),attribute:Number(row.attribute),race:BigInt(row.race),attack:Number(row.atk),defense:Number(row.def)}],
   [support,{...base,code:support,attribute:test.attribute??1,race:test.race??0x20n,setcodes:test.machina?[0x36]:[]}],
   [spell,{...base,code:spell,type:megaframe?2:4,setcodes:[0x36]}],[filler,{...base,code:filler}],
   [levelTen,{...base,code:levelTen,level:test.level??10,setcodes:[0x36]}]]);
  const reader=name=>{
   requests.push(name);
   if(megaframe&&name===`c${spell}.lua`)return `local s,id=GetID()
function s.initial_effect(c)
 local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN)
 e:SetOperation(function(e,tp) local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,${code}) Duel.SendtoGrave(g,REASON_EFFECT) end)
 c:RegisterEffect(e)
 ${test.redirect?`local r=Effect.CreateEffect(c) r:SetType(EFFECT_TYPE_FIELD) r:SetCode(EFFECT_TO_GRAVE_REDIRECT)
 r:SetProperty(EFFECT_FLAG_SET_AVAILABLE+EFFECT_FLAG_IGNORE_RANGE+EFFECT_FLAG_IGNORE_IMMUNE)
 r:SetTargetRange(LOCATION_DECK,0) r:SetTarget(function(e,c) return c:IsCode(${levelTen}) end)
 r:SetValue(LOCATION_REMOVED) Duel.RegisterEffect(r,0)`:''}
end`;
   if(name===`c${spell}.lua`)return 'local s,id=GetID() function s.initial_effect(c) end';
   if(['c0.lua',`c${support}.lua`,`c${spell}.lua`,`c${filler}.lua`,`c${levelTen}.lua`].includes(name))return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(p=>fs.existsSync(p));
   if(!file)throw Error('Missing script '+name);
   return fs.readFileSync(file,'utf8');
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],
   team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},
   cardReader:id=>{if(!data.has(id))throw Error('Missing metadata '+id);return data.get(id)},scriptReader:reader,
   errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,triggerAccepted=false,completed=false,optionalAsked=false,triggerCount=0;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support failed '+name);
   const add=(id,player,location)=>core.duelNewCard(duel,{team:player,duelist:0,code:id,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   add(code,0,L.HAND);add(support,0,L.MZONE);add(spell,0,megaframe?L.HAND:L.DECK);
   if(megaframe){add(levelTen,0,L.DECK);add(code,0,L.DECK);}
   for(const player of [0,1])for(let i=0;i<5;i++)add(filler,player,L.DECK);
   core.startDuel(duel);
   for(let step=0;step<150&&!completed;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);
    if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));
    if(state===S.END)throw Error('Unexpected duel end');
    if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(p.type===M.SELECT_IDLECMD){
     if(activated){
      if(megaframe){
       if(triggerAccepted!==test.expectTrigger)throw Error('Wrong GY trigger availability');
       if(core.duelQueryCount(duel,0,L.MZONE)!==(test.revives?2:1))throw Error('Wrong field count after revival');
       if(core.duelQueryCount(duel,0,L.HAND)!==(test.revives?1:0))throw Error('Search did not match expected result');
       if(test.revives&&triggerCount!==2)throw Error('Revival and search triggers were not both exercised');
       if(core.duelQueryCount(duel,0,L.REMOVED)!==(test.redirect?1:0))throw Error('Wrong redirected card count');
       completed=true;break;
      }
      if(!triggerAccepted||!optionalAsked)throw Error('Summon trigger or optional destruction was not exercised');
      if(core.duelQueryCount(duel,0,L.MZONE)!==(test.destroy?1:2))throw Error('Wrong monster count after destruction choice');
      if(core.duelQueryCount(duel,0,L.SZONE)!==1)throw Error('Machina Trap was not Set');
      completed=true;break;
     }
     const index=p.activates.findIndex(c=>c.code===(megaframe?spell:code));
     if((index>=0)!==(megaframe?true:test.canSummon))throw Error('Wrong hand summon availability');
     if(index<0){completed=true;break;}
     activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});
    }else if(p.type===M.SELECT_CHAIN){
     const index=p.selects.findIndex(c=>c.code===code&&(megaframe||c.location===L.MZONE));
     if(index>=0){triggerAccepted=true;triggerCount++;}
     core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:null});
    }else if(p.type===M.SELECT_EFFECTYN){triggerAccepted=true;triggerCount++;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});}
    else if(p.type===M.SELECT_YESNO){optionalAsked=true;core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:test.destroy});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){
     let place;
     for(const location of [L.MZONE,L.SZONE])for(let i=0;i<5;i++)if(!place&&(p.field_mask&(1<<((location===L.SZONE?8:0)+i)))===0)place={player:0,location,sequence:i};
     if(!place)throw Error('No legal zone');
     core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[place]});
    }else if(p.type===M.SELECT_CARD){
     const index=p.selects?.findIndex(c=>c.code===(megaframe?code:support))??-1;
     core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index>=0?index:0]});
    }else throw Error('Unhandled prompt '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!completed)throw Error('Step limit');
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  console.log(`${failure?'FAIL':'PASS'} ${test.name}${failure?': '+failure:''}`);
  results.push({name:test.name,status:failure?'FAIL':'PASS',failure,logs,trace,requests});
 }
 const hash=file=>createHash('sha256').update(fs.readFileSync(file)).digest('hex');
 fs.writeFileSync(path.join(ROOT,`output/fresh-ccg-september/${megaframe?'megaframe':'machina'}-duels.json`),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',script_sha256:hash(path.join(CUSTOM,`c${code}.lua`)),database_sha256:hash(dbPath),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
