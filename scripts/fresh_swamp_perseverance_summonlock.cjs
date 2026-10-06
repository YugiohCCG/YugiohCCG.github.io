'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=239935100,ally=900001051,top=900001022,filler=900001023,refill=900001024,greetings=238276575,results=[];
 for(const test of [{},{place:true},{prior:true},{prior:true,wrongattribute:true},{prior:true,wrongrace:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[greetings,candidateCard(greetings)],[ally,{...base,code:ally,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2}],[top,{...base,code:top,race:test.nonplant?1n:1024n}],[filler,{...base,code:filler}]]);
  cards.set(top,{...base,code:top,type:33,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2});cards.set(17228909,{...base,code:17228909,type:0x4011,race:65536n,attribute:1,level:1,attack:0,defense:0});cards.set(ally,{...base,code:ally,type:33,race:524288n,attribute:2});cards.set(refill,{...base,code:refill});for(let i=0;i<3;i++)cards.set(900001030+i,{...base,code:900001030+i,attribute:i===2?4:2,race:i===1?1024n:524288n});
  const reader=name=>{
   if(name==='c'+refill+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,'+top+'):GetFirst() Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP_ATTACK) end) c:RegisterEffect(e) local p=e:Clone() p:SetDescription(1) p:SetOperation(function(e,tp) '+(test.removeSource?'local src=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_SZONE,0,nil,'+boss+'):GetFirst() if src then Duel.SendtoGrave(src,REASON_EFFECT) end ':'')+'local mask=0 for i=0,2 do local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_GRAVE,0,nil,900001030+i):GetFirst() if tc:IsCanBeSpecialSummoned(e,0,tp,false,false) then mask=mask+2^i end end Duel.Hint(HINT_NUMBER,tp,700+mask) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_GRAVE,0,nil,900001030):GetFirst() Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP_ATTACK) Duel.SendtoGrave(tc,REASON_EFFECT) end) c:RegisterEffect(p) end';
   if(/^c90000103[0-2]\.lua$/.test(name))return 'local s,id=GetID() function s.initial_effect(c) end';
   if([ally,top,filler,17228909].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');

   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-summon-count'))source=source.replace('e1:SetCountLimit(1,id)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-redirect'))source=source.replace('c:RegisterEffect(redirect,true)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-detach'))source=source.replace('e1:SetCost(s.placecost)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-type-change'))source=source.replace('c:RegisterEffect(change)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-redirect'))source=source.replace('c:RegisterEffect(redirect,true)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-history'))source=source.replace('return Duel.GetCustomActivityCount(id,tp,ACTIVITY_SPSUMMON)==0','return true');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-lock'))source=source.replace('Duel.RegisterEffect(lock,tp)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-lock-reset'))source=source.replace('lock:SetReset(RESET_PHASE+PHASE_END)','do end');
   return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:test.lowLP?1000:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,prepared=false,refilled=false,repeated=false,turn=0,probed=0,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   add(boss,L.HAND);add(refill,L.MZONE);add(ally,L.GRAVE);if(test.prior)add(top,L.HAND);for(let i=0;i<3;i++)add(900001030+i,L.GRAVE);
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(p.player===1){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
     if(test.prior&&!prepared){const pi=p.activates.findIndex(x=>x.code===refill&&String(x.description)==='0');assert(pi>=0);prepared=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index:pi});continue;}
     const index=p.activates.findIndex(x=>x.code===boss&&String(x.description)===String(133935100*16));
     if(test.prior){assert(query(L.MZONE).some(x=>x.code===top),'Prior monster not actually Summoned');if(test.wrongrace||test.wrongattribute){assert.equal(index,-1,'Forbidden earlier Summon did not prevent Heart');done=true;continue;}}
     if(!activated){assert(index>=0,'Legal prior history blocked Heart');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert(query(L.GRAVE).some(x=>x.code===boss),'Activated Spell did not reach GY');assert(query(L.GRAVE).some(x=>x.code===ally&&(x.reason&1)&&(x.reason&0x40)),'Recipient not destroyed after movement');
     if(probed!==turn){const pi=p.activates.findIndex(x=>x.code===refill&&String(x.description)==='1');assert(pi>=0);probed=turn;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index:pi});continue;}
     const masks=trace.filter(x=>x.type===M.HINT&&x.hint_type===9&&Number(x.hint)>=700&&Number(x.hint)<=707).map(x=>Number(x.hint));assert.equal(masks.at(-1),turn===1?701:707,'Summon restriction or reset mismatch');
     assert(trace.some(x=>x.type===M.MOVE&&x.card===900001030&&x.from.location===L.GRAVE&&x.to.location===L.MZONE),'Allowed WATER Reptile not actually Summoned');
     if(turn<3){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}done=true;
    }else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(x=>x.code===ally);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.place?1:0});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}assert(sequence!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const control=process.argv.includes('--no-history')?'no-history':process.argv.includes('--no-lock')?'no-lock':process.argv.includes('--no-lock-reset')?'no-lock-reset':null;
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/swamp-perseverance-summonlock'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public OCGCore, full production Perseverance/candidate metadata; actual neutral prior Summon and source activation, recipient movement/destruction; native summon-eligibility checks for WATER Reptile/WATER non-Reptile/non-WATER Reptile, actual allowed Summon, End Phase reset; native Omega untested',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});



