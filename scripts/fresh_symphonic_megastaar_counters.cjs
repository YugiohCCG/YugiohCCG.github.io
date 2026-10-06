'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=238273772,amp=75304793,holder=900000851,target=900000852,grave=900000853,setup=900000854,filler=900000855;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),row=db.prepare('select * from datas where id=?').get(boss);db.close();
 const base={alias:0,setcodes:[],type:33,level:3,attribute:8,race:32n,attack:5000,defense:4000,lscale:0,rscale:0,link_marker:0},results=[];
 for(const test of [{remove:2,take:2},{remove:3,take:1},{pendulum:true},{absent:true},{opponent:true},{facedown:true},{zero:true}]){
  const legal=!test.pendulum&&!test.absent&&!test.opponent&&!test.facedown&&!test.zero,logs=[],trace=[],cards=new Map([[boss,{...base,code:boss,setcodes:[0x1066],type:Number(row.type),level:Number(row.level)&255,attribute:Number(row.attribute),race:BigInt(row.race),attack:Number(row.atk),defense:Number(row.def)}],[amp,{...base,code:amp,type:0x80002,level:0}],[holder,{...base,code:holder,type:0x20002,level:0}],[target,{...base,code:target}],[grave,{...base,code:grave}],[setup,{...base,code:setup,type:2,level:0}],[filler,{...base,code:filler}]]);
  const reader=name=>{
   if(name===`c${holder}.lua`)return 'local s,id=GetID() function s.initial_effect(c) c:EnableCounterPermit(0x35) end';
   if(name===`c${setup}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp)
    ${test.zero?'':`local h=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_ONFIELD,0,nil,${holder}):GetFirst() h:AddCounter(0x35,2) local o=Duel.GetMatchingGroup(Card.IsCode,tp,0,LOCATION_ONFIELD,nil,${holder}):GetFirst() o:AddCounter(0x35,1)`}
    ${test.pendulum?`local b=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,${boss}):GetFirst() Duel.MoveToField(b,tp,tp,LOCATION_PZONE,POS_FACEUP,true)`:''}
   end) c:RegisterEffect(e) end`;
   if([target,grave,filler].some(c=>name===`c${c}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8');
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,prepared=false,activated=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,sequence=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});add(boss,L.MZONE);add(setup,L.HAND);add(holder,L.SZONE,0,1);add(holder,L.SZONE,1,1);add(target,L.MZONE,1);add(grave,L.GRAVE,1);if(!test.absent)add(amp,L.SZONE,test.opponent?1:0,5,test.facedown?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK);for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<120&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!prepared){const index=p.activates.findIndex(c=>c.code===setup);if(index<0)throw Error('Setup missing');prepared=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     const index=p.activates.findIndex(c=>c.code===boss&&String(c.description)===String(132273772*16+1));
     if(!activated){const field=core.duelQueryLocation(duel,{flags:Q.CODE|Q.ATTACK|Q.DEFENSE,controller:1,location:L.MZONE}),t=field.find(c=>c?.code===target),reduction=test.zero?0:test.pendulum?900:600;if(t?.attack!==5000-reduction||t?.defense!==4000-reduction)throw Error('Counter-based ATK/DEF mismatch '+JSON.stringify(t));}
     if(legal&&!activated){if(index<0)throw Error('Banish unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(index>=0)throw Error(activated?'Soft once-per-turn bypass':'Illegal banish offered');
     if(legal){const removed=core.duelQueryLocation(duel,{flags:Q.CODE,controller:1,location:L.REMOVED});if(removed.filter(c=>[target,grave].includes(c?.code)).length!==test.take)throw Error('Banish count mismatch');if(trace.some(t=>t.type===M.BECOME_TARGET))throw Error('Non-targeting banish targeted');const cost=trace.filter(t=>t.type===M.REMOVE_COUNTER&&t.counter_type===0x35).reduce((n,t)=>n+t.count,0);if(cost!==test.remove)throw Error('Counter cost mismatch '+cost);}
     done=true;
    }
    else if(p.type===M.ANNOUNCE_NUMBER){const index=p.options.findIndex(n=>Number(n)===test.remove);if(index<0)throw Error('Counter choice missing');core.duelSetResponse(duel,{type:R.ANNOUNCE_NUMBER,value:index});}
    else if(p.type===M.SELECT_COUNTER){let left=p.count;const counters=p.cards.map(c=>{const n=Math.min(left,c.count);left-=n;return n;});if(left)throw Error('Insufficient selectable counters');core.duelSetResponse(duel,{type:R.SELECT_COUNTER,counters});}
    else if(p.type===M.SELECT_CARD){const indicies=p.selects.map((c,i)=>[target,grave].includes(c.code)?i:-1).filter(i=>i>=0).slice(0,test.take);if(indicies.length!==test.take)throw Error('Banish candidates missing');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies});}
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:null});
    else if(p.type===M.SELECT_PLACE){const sequence=[0,4,2,3].find(i=>(p.field_mask&(1<<(8+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:L.SZONE,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(e){failure=e.message}finally{core.destroyDuel(duel)}
  results.push({...test,failure,activated,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/symphonic-megastaar-counters.json'),JSON.stringify({engine:'public OCGCore with full Mega Staar and official Amplifire; not native Omega',qualifiers:['Fixture holders permit actual Counters; setup Spell adds Counters on both fields','Mega Staar is seeded on field; proper Synchro procedure is not verified','Pendulum case uses real MoveToField setup'],results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
