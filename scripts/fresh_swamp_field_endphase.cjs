'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=239935101,ally=900001021,top=900001022,filler=900001023,refill=900001024,greetings=238276575,results=[];
 for(const test of [{},{one:true},{decline:true},{wrongattribute:true},{wrongrace:true},{facedown:true},{none:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[greetings,candidateCard(greetings)],[ally,{...base,code:ally,setcodes:test.unrelated?[]:[0xa121]}],[top,{...base,code:top,race:test.nonplant?1n:1024n}],[filler,{...base,code:filler}]]);
  cards.set(ally,{...cards.get(ally),attribute:test.wrongattribute?4:2,race:test.wrongrace?1024n:524288n});cards.set(top,{...base,code:top,type:0x20002,level:0});if(test.full)cards.set(ally,{...cards.get(ally),type:0x20002,level:0});cards.set(refill,{...base,code:refill,type:33,level:2});
  const reader=name=>{
   if(name==='c'+refill+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_SZONE,0,nil,'+boss+'):GetFirst() Duel.SendtoGrave(tc,REASON_EFFECT) end) c:RegisterEffect(e) end';
   if([ally,top,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-redirect'))source=source.replace('c:RegisterEffect(e1,true)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--own-phase'))source=source.replace('return Duel.GetTurnPlayer()~=tp','return true');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-shuffle'))source=source.replace('Duel.SendtoDeck(g,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-count'))source=source.replace('e3:SetCountLimit(1,id+200)','do end');
   return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,refilled=false,repeated=false,turn=0,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   core.duelNewCard(duel,{team:0,duelist:0,code:boss,controller:0,location:L.SZONE,sequence:5,position:P.FACEUP_ATTACK});
   if(!test.none)for(let i=0;i<3;i++)core.duelNewCard(duel,{team:0,duelist:0,code:ally,controller:0,location:L.REMOVED,sequence:0,position:test.facedown?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK});
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(turn<3){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
     const count=test.decline||test.wrongattribute||test.wrongrace||test.facedown||test.none?0:test.one?1:2;
     assert.equal(query(L.DECK).filter(x=>x.code===ally).length,count,'Selected cards not returned to Deck');assert.equal(query(L.REMOVED).filter(x=>x.code===ally).length,(test.none?0:3)-count,'Unselected banished resources changed');
     const chains=trace.filter(x=>x.type===M.CHAINING&&x.code===boss);assert.equal(chains.length,count?1:0,'End Phase activation count mismatch');done=true;
    }else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(x=>x.code===boss&&String(x.description)===String(133935101*16+3));if(index>=0){assert.equal(turn,2,'Own End Phase trigger offered');assert(!(test.wrongattribute||test.wrongrace||test.facedown||test.none),'Invalid banished resource offered');assert(!activated,'Second same-turn trigger offered');if(!test.decline)activated=true;}core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0&&!test.decline?index:p.forced?0:null});}
    else if(p.type===M.SELECT_CARD){const indices=p.selects.map((x,i)=>x.code===ally?i:-1).filter(i=>i>=0);assert.equal(p.min,1);assert.equal(p.max,2);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:indices.slice(0,test.one?1:2)});}
    else if(p.type===M.SELECT_EFFECTYN){assert(!activated,'Second same-turn End Phase trigger offered');assert.equal(turn,2,'Own End Phase trigger offered');assert(!(test.wrongattribute||test.wrongrace||test.facedown||test.none),'Invalid trigger offered');if(!test.decline)activated=true;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:!test.decline});}
    else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:L.SZONE,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const control=process.argv.includes('--own-phase')?'own-phase':process.argv.includes('--no-shuffle')?'no-shuffle':process.argv.includes('--no-count')?'no-count':null;
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/swamp-field-endphase'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public OCGCore, full production Terrifying Dark Swamp with candidate metadata seeded field slot; actual own/opponent End Phase advancement and banished neutral monsters returned to Deck; battle and native Omega untested',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});



