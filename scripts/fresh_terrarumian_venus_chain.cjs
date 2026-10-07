'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=284639726,ally=900001021,top=900001022,filler=900001023,refill=900001024,greetings=238276575,results=[];
 for(const test of [{chain:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[greetings,candidateCard(greetings)],[ally,{...base,code:ally,setcodes:test.unrelated?[]:[0xa122]}],[top,{...base,code:top,race:test.nonplant?1n:1024n}],[filler,{...base,code:filler}]]);
  cards.set(refill,{...base,code:refill,type:65538,level:0});
  const reader=name=>{
   if(name==='c'+refill+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) Duel.Recover(tp,100,REASON_EFFECT) end) c:RegisterEffect(e) end';
   if([ally,top,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-chain-lock'))source=source.replace('return e:GetHandler():GetFlagEffect(id)==0','return true');
   if(name==='c'+boss+'.lua')source=source.replace('CHAININFO_TARGET_CARDS','8');
   return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{const c=cards.get(code);return c&&(c.type&0x4000000)?{...c,rscale:c.link_marker}:c;},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,refilled=false,repeated=false,turn=0,done=false,chainOpen=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   core.duelNewCard(duel,{team:0,duelist:0,code:boss,controller:0,location:L.MZONE,sequence:5,position:P.FACEUP_ATTACK});core.duelNewCard(duel,{team:0,duelist:0,code:filler,controller:0,location:L.MZONE,sequence:2,position:P.FACEUP_ATTACK});core.duelNewCard(duel,{team:0,duelist:0,code:ally,controller:0,location:L.MZONE,sequence:1,position:P.FACEUP_ATTACK});if(!test.empty)for(let i=0;i<8;i++)add(filler,L.DECK);for(let i=0;i<8;i++)add(filler,L.DECK,1);add(refill,L.HAND);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,controller:0,location}).filter(Boolean);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages){if(m.type===M.NEW_TURN)turn++;if(m.type===M.CHAINING)chainOpen=true;if(m.type===M.CHAIN_END)chainOpen=false;}
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     const index=p.activates.findIndex(x=>x.code===boss&&String(x.description)===String(132639726*16+1));
     if(!activated){const source=core.duelQueryLocation(duel,{flags:Q.CODE|Q.LINK,controller:0,location:L.MZONE}).filter(Boolean).find(x=>x.code===boss);assert.equal(source.link.marker,candidateCard(boss).link_marker,'Candidate arrows not transferred');assert(index>=0,'Linked destruction unavailable '+JSON.stringify(core.duelQueryLocation(duel,{flags:Q.CODE|Q.LINK|Q.LINK_MARKER|Q.POSITION,controller:0,location:L.MZONE})));activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert(refilled,'Response did not join chain');assert(query(L.GRAVE).some(x=>x.code===ally),'Linked ally not destroyed');assert(query(L.GRAVE).some(x=>x.code===filler),'Second target not destroyed');
     assert(p.activates.some(x=>x.code===boss&&String(x.description)===String(132639726*16)),'Quick effect not restored after chain');done=true;
    }else if(p.type===M.SELECT_CHAIN){if(chainOpen)assert(!p.selects.some(x=>x.code===boss),'Venus Quick effect offered in own destruction chain');const index=chainOpen&&activated&&!refilled?p.selects.findIndex(x=>x.code===refill):-1;if(index>=0)refilled=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(x=>x.code===ally);const second=p.selects.findIndex(x=>x.code===filler);assert(index>=0||second>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index>=0?index:second]});}
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});
    else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:L.SZONE,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const control=process.argv.includes('--no-chain-lock')?'no-chain-lock':null;
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/terrarumian-venus-chain'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public OCGCore, production Venus and candidate metadata; seeded EMZ Link, neutral targets and chained Quick-Play; no Link procedure/native Omega certification',adapters:['Public package 32-bit card writer puts rscale at offset 48, the core link-marker slot: Link-only fixture sets rscale to candidate arrows; queried marker asserted equal to database','CHAININFO_TARGET_CARDS public flag 8 instead of pinned Omega 0x40'],control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});



