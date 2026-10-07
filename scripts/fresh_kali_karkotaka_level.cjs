'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=247755868,target=900001001,filler=900001002,loss=900001003,msg=133755868,results=[];
 for(const test of [{level:4},{level:8},{level:8,lost:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:3,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[target,{...base,code:target,setcodes:test.unrelated?[]:[0xa121],type:test.link?0x4000021:33,level:test.link?1:3,link_marker:test.link?2:0}],[filler,{...base,code:filler}]]);
  cards.set(loss,{...base,code:loss,type:0x10002,level:0});
  const reader=name=>{
   if(name==='c'+loss+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetCondition(function() return Duel.GetCurrentChain()>0 end) e:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,'+target+'):GetFirst() Duel.SendtoHand(tc,nil,REASON_EFFECT) end) c:RegisterEffect(e) end';
   if([target,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);
   let source=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-end-reset'))source=source.replace('change:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)','change:SetReset(RESET_EVENT+RESETS_STANDARD)');
   return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false,turn=0;
  const illegal=test.unrelated||test.link||test.facedown||test.opponent;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position});
   core.duelNewCard(duel,{team:0,duelist:0,code:boss,controller:0,location:L.MZONE,sequence:1,position:P.FACEUP_ATTACK});add(target,L.MZONE,test.opponent?1:0,test.facedown?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK);
   if(test.lost)add(loss,L.HAND);
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.LEVEL|Q.REASON,controller:0,location}).filter(Boolean);
   for(let step=0;step<160&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));
    if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     const index=p.activates.findIndex(x=>x.code===boss&&String(x.description)===String(msg*16+1));
     if(illegal){assert.equal(index,-1,'Illegal Level target allowed');done=true;continue;}
     if(!activated){assert(index>=0,'GY effect unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}

     if(test.lost){assert.equal(query(L.MZONE).some(x=>x.code===target),false,'Lost target still on field');assert.equal(query(L.HAND).find(x=>x.code===target)?.level,3,'Unrelated target Level changed');assert(trace.some(x=>x.type===M.CHAINING&&x.code===loss&&x.chain_size===2),'Target loss not chained');done=true;continue;}
     assert.equal(query(L.MZONE).find(x=>x.code===target)?.level,turn===1?test.level:3,'Declared Level/reset mismatch');
     if(turn<3){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}done=true;
    }else if(p.type===M.SELECT_CHAIN){const index=test.lost&&activated?p.selects.findIndex(x=>x.code===loss):-1;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(x=>x.code===target);assert(index>=0,'Target not offered');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.ANNOUNCE_NUMBER){assert.deepEqual(p.options.map(Number),[4,5,6,7,8],'Declaration range mismatch');core.duelSetResponse(duel,{type:R.ANNOUNCE_NUMBER,value:test.level-4});}
    else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:L.SZONE,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const control=process.argv.includes('--no-end-reset')?'no-end-reset':null;
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/kali-karkotaka-level'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public OCGCore, full production Karkotaka and candidate metadata; seeded field source and neutral Kali targets, actual level/reset; material restriction and destruction-history summon untested; native Omega untested',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});

