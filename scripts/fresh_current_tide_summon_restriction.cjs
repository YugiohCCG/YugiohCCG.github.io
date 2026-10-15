'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=217645912,partner=900001191,cost=900001193,original=900001195,filler=900001192;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['old-source','no-lock','ignore-history'].find(c=>process.argv.includes('--'+c));
 const tests=[{prior:true},{prior:true,crewal:true},{},{crewal:true},{decline:true},{absent:true}];
 for(const test of tests){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:1000,defense:1200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[partner,{...base,code:partner,race:test.wrongRace?1n:16n,level:test.level5?5:4}],[cost,{...base,code:cost,setcodes:test.crewal?[0xe2f]:[]}],[original,{...base,code:original,type:33}],[filler,{...base,code:filler}]]);
  const reader=name=>{
   if(name==='c0.lua')return '';
   if(name==='c'+original+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetTarget(s.tg) e:SetOperation(s.op) c:RegisterEffect(e) end function s.filter(c,e,tp) return c:IsCode(900001193) and c:IsCanBeSpecialSummoned(e,0,tp,false,false) end function s.tg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and Duel.IsExistingMatchingCard(s.filter,tp,LOCATION_HAND,0,1,nil,e,tp) end end function s.op(e,tp) local c=Duel.GetFirstMatchingCard(s.filter,tp,LOCATION_HAND,0,nil,e,tp) if c then Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP) end end';
   if(name==='c'+cost+'.lua')return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c'+partner+'.lua'&&test.locked)return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_FIELD) e:SetRange(LOCATION_MZONE) e:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON) e:SetProperty(EFFECT_FLAG_PLAYER_TARGET) e:SetTargetRange(1,0) c:RegisterEffect(e) end';
   if(name==='c'+partner+'.lua'||name==='c'+filler+'.lua')return 'local s,id=GetID() function s.initial_effect(c) end';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8'); if(name==='c'+boss+'.lua'&&process.argv.includes('--candidate'))lua=fs.readFileSync(path.join(ROOT,'output/fresh-ccg-september/tide-optional-candidate.lua'),'utf8');
   if(name==='c'+boss+'.lua'){
    if(control==='old-source')lua=fs.readFileSync(path.join(ROOT,'output/fresh-ccg-september/tide-before-optional-activation-repair/c217645912.lua'),'utf8');
    if(control==='no-lock')lua=lua.replace('Duel.RegisterEffect(e1,tp)','do end'); if(control==='ignore-history')lua=lua.replaceAll('Duel.GetCustomActivityCount(id,tp,ACTIVITY_SPSUMMON)==0','true');   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,done=false,activated=false,helperUsed=false,optional=0;
  const eligible=true;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(boss,L.HAND);add(original,L.MZONE,0,P.FACEUP_ATTACK);add(cost,L.HAND);if(!test.absent)add(partner,L.DECK);
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(test.prior&&!helperUsed){const index=p.activates.findIndex(c=>c.code===original);assert(index>=0);helperUsed=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(!activated){if(test.prior)assert(query(L.MZONE).some(c=>c.code===cost),'Actual prior summon');const index=p.activates.findIndex(c=>c.code===boss);assert(index>=0,'Basic Field activation always allowed');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     const mill=!(test.decline||test.absent||(test.prior&&!test.crewal));
     assert(query(L.SZONE).some(c=>c.code===boss),'Actual Field placement');assert.equal(query(L.GRAVE).some(c=>c.code===partner),mill,'Optional mill history');assert.equal(optional,test.absent||(test.prior&&!test.crewal)?0:1,'Optional choice availability');
     if(!test.prior){const allowed=!!(!mill||test.crewal);const index=p.activates.findIndex(c=>c.code===original);if(!helperUsed){assert.equal(index>=0,allowed,'Actual post-activation summon legality');if(allowed){helperUsed=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}}assert.equal(query(L.MZONE).some(c=>c.code===cost),allowed,'Actual post-activation summon');}
     done=true;
    }else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===partner);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_YESNO){optional++;core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const isField=(p.field_mask&(1<<13))===0;const sequence=isField?5:[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:isField?L.SZONE:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-tide-summon-restriction'+(process.argv.includes('--candidate')?'-candidate':'')+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:null,scope:'Actual neutral monster special summon before/after full Tide activation: prior nonCrewal suppresses optional mill only; prior Crewal allowed; chosen mill restricts later nonCrewal but permits Crewal; declined/absent mill permits later nonCrewal. No adapters; use/reset/trigger/fullcard OPEN',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
