'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=247755873,target=900001001,filler=900001002,loss=900001003,msg=133755868,results=[];
 for(const test of [{},{removed:true},{extra:true},{wrongattribute:true},{nonxyz:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:3,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[target,{...base,code:target,setcodes:test.unrelated?[]:[0xa121],type:test.nonxyz?33:0x800021,level:4,attribute:test.wrongattribute?2:4}],[filler,{...base,code:filler}]]);
  cards.set(loss,{...base,code:loss});
  for(let i=0;i<4;i++)for(let kali=0;kali<2;kali++)cards.set(900001010+i*2+kali,{...base,code:900001010+i*2+kali,type:[0x41,0x2001,0x800001,0x4000021][i],level:8,setcodes:kali?[0xa121]:[],link_marker:i===3?2:0});
  const reader=name=>{
   if(name==='c'+loss+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_GRAVE+LOCATION_REMOVED+LOCATION_EXTRA,0,nil,${target}):GetFirst() tc:CompleteProcedure() Duel.SpecialSummon(tc,0,tp,tp,true,true,POS_FACEUP_ATTACK) end) c:RegisterEffect(e) local p=e:Clone() p:SetDescription(1) p:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,${target}):GetFirst() local ok=c${boss}.altfilter(tc,e,tp) Duel.Hint(HINT_NUMBER,tp,ok and 701 or 700) end) c:RegisterEffect(p) end`;
   if(name.match(/^c90000101[0-7]\.lua$/))return 'local s,id=GetID() function s.initial_effect(c) end';
   if([target,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);
   let source=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-history-reset'))source=source.replace('c:RegisterFlagEffect(id,RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END,0,1)','c:RegisterFlagEffect(id,RESET_EVENT+RESETS_STANDARD,0,1)');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--any-origin'))source=source.replace('and c:IsPreviousLocation(LOCATION_GRAVE+LOCATION_REMOVED)','');
   return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,probed=0,done=false,turn=0;
  const eligible=!(test.extra||test.wrongattribute||test.nonxyz);
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position});
   add(boss,L.GRAVE);add(target,test.extra?L.EXTRA:test.removed?L.REMOVED:L.GRAVE);add(loss,L.MZONE);
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.LEVEL|Q.REASON,controller:0,location}).filter(Boolean);
   for(let step=0;step<160&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));
    if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(p.player===1){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
     if(!activated){const index=p.activates.findIndex(x=>x.code===loss&&String(x.description)==='0');assert(index>=0,'Summon fixture missing');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert(query(L.MZONE).some(x=>x.code===target),'Fixture did not Summon material');
     if(probed!==turn){const pi=p.activates.findIndex(x=>x.code===loss&&String(x.description)==='1');assert(pi>=0,'Probe unavailable');probed=turn;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index:pi});continue;}
     const values=trace.filter(x=>x.type===M.HINT&&x.hint_type===9&&[700,701].includes(Number(x.hint))).map(x=>Number(x.hint));
     assert.equal(values.at(-1),turn===1&&eligible?701:700,'Revived material eligibility/expiry mismatch');
     if(turn<3){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}done=true;
    }else if(p.type===M.SELECT_CHAIN){const index=test.lost&&activated?p.selects.findIndex(x=>x.code===loss):-1;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(x=>x.code===target);assert(index>=0,'Target not offered');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.ANNOUNCE_NUMBER){assert.deepEqual(p.options.map(Number),[4,5,6,7,8],'Declaration range mismatch');core.duelSetResponse(duel,{type:R.ANNOUNCE_NUMBER,value:test.level-4});}
    else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<i))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:L.MZONE,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const control=process.argv.includes('--no-history-reset')?'no-history-reset':process.argv.includes('--any-origin')?'any-origin':null;
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/kali-ahimsaka-history'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public OCGCore, full production Ahimsaka loaded from seeded GY candidate source; neutral fixture actually Summons material then separate ignition calls production altfilter, native event history flags and End Phase advance; not an actual Xyz Summon/procedure proof, native Omega untested',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});

