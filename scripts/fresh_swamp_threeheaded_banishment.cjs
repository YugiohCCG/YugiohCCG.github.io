'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=239935097,top=900001022,filler=900001023,refill=900001024,greetings=238276575,results=[];
 for(const test of [{},{place:true},{full:true},{sameName:true},{sameName:true,place:true},{wrongFusionAttribute:true},{wrongFusionRace:true},{noFusionReason:true},{noMaterialReason:true},{facedownRecipient:true},{wrongRecipientAttribute:true},{wrongRecipientRace:true},{onlySource:true}]){
  const ally=test.sameName?boss:900001021;
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[greetings,candidateCard(greetings)],[ally,{...base,code:ally,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2}],[top,{...base,code:top,race:test.nonplant?1n:1024n}],[filler,{...base,code:filler}]]);
  if(test.sameName)cards.set(boss,candidateCard(boss));
  cards.set(top,{...base,code:top,type:test.spell?2:33,level:test.highlevel?4:2});if(!test.sameName)cards.set(ally,{...base,code:ally,attribute:test.wrongRecipientAttribute?4:2,race:test.wrongRecipientRace?1024n:524288n});cards.set(900001030,{...base,code:900001030});cards.set(refill,{...base,code:refill,type:0x61,attribute:test.wrongFusionAttribute?4:2,race:test.wrongFusionRace?1024n:524288n,level:8});
  cards.set(900001031,{...base,code:900001031,type:0x20002});
  const reader=name=>{
   if(name==='c900001031.lua')return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c'+refill+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_FIELD) e:SetProperty(EFFECT_FLAG_UNCOPYABLE+EFFECT_FLAG_CANNOT_DISABLE) e:SetCode(EFFECT_SPSUMMON_PROC) e:SetRange(LOCATION_EXTRA) e:SetValue(SUMMON_TYPE_FUSION) e:SetCondition(function(e,c) if c==nil then return true end local tp=c:GetControler() return Duel.GetLocationCountFromEx(tp,tp,nil,c)>0 and Duel.IsExistingMatchingCard(Card.IsCode,tp,LOCATION_HAND,0,1,nil,'+boss+') end) e:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,'+boss+'):GetFirst() local g=Group.FromCards(tc) e:GetHandler():SetMaterial(g) Duel.Remove(g,POS_FACEUP,'+(test.noFusionReason?'REASON_COST+REASON_MATERIAL':test.noMaterialReason?'REASON_EFFECT+REASON_FUSION':'REASON_COST+REASON_MATERIAL+REASON_FUSION')+') end) c:RegisterEffect(e) local r=Effect.CreateEffect(c) r:SetDescription(2) r:SetType(EFFECT_TYPE_IGNITION) r:SetRange(LOCATION_MZONE) r:SetOperation(function(e,tp) '+(test.place?'local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_SZONE,0,nil,'+ally+'):GetFirst() Duel.Hint(HINT_NUMBER,tp,tc and tc:IsType(TYPE_SPELL) and tc:IsType(TYPE_CONTINUOUS) and not tc:IsType(TYPE_MONSTER) and 701 or 700) ':'')+'Duel.SendtoGrave(e:GetHandler(),REASON_EFFECT) end) c:RegisterEffect(r) end';

   if(name==='c'+top+'.lua')return 'local s,id=GetID() function s.initial_effect(c) '+(test.nomention?'':'aux.AddCodeList(c,239935101) ')+'end';
   if(name==='c900001030.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_SZONE,0,nil,'+(test.selfplace?boss:ally)+'):GetFirst() Duel.Hint(HINT_NUMBER,tp,tc and tc:IsType(TYPE_SPELL) and tc:IsType(TYPE_CONTINUOUS) and not tc:IsType(TYPE_MONSTER) and 701 or 700) end) c:RegisterEffect(e) end';
   if([...(test.sameName?[]:[ally]),filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');

   if(name==='c'+boss+'.lua'&&test.self)source=source.replace('aux.AddCodeList(c,SWAMP)', 'aux.AddCodeList(c,SWAMP) local f=Effect.CreateEffect(c) f:SetType(EFFECT_TYPE_IGNITION) f:SetCode(EVENT_FREE_CHAIN) f:SetRange(LOCATION_MZONE) f:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,'+boss+'):GetFirst() Duel.SendtoGrave(tc,REASON_EFFECT) end) c:RegisterEffect(f)');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--allow-self'))source=source.replace('return mentions and not rc:IsCode(id)','return mentions');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--any-source'))source=source.replace('return re and s.mentions(re:GetHandler())','return re~=nil');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--any-level'))source=source.replace('and c:GetLevel()<=3','');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-type-change'))source=source.replace('c:RegisterEffect(change)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-count'))source=source.replace('e1:SetCountLimit(1,id)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--duel-count'))source=source.replace('e1:SetCountLimit(1,id)','e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_DUEL)');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-duel-flag'))source=source.replace('Duel.RegisterFlagEffect(tp,id+100,0,0,1)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--any-fusion-type'))source=source.replace('and rc:IsType(TYPE_FUSION) and rc:IsAttribute(ATTRIBUTE_WATER) and rc:IsRace(RACE_REPTILE)','and rc:IsType(TYPE_FUSION)');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--require-space'))source=source.replace('(c:IsAbleToHand() or (Duel.GetLocationCount(tp,LOCATION_SZONE)>0 and not c:IsForbidden()))', '(Duel.GetLocationCount(tp,LOCATION_SZONE)>0 and c:IsAbleToHand())');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--exclude-same-name'))source=source.replace('c~=e:GetHandler() and c:IsFaceup()', 'not c:IsCode(id) and c:IsFaceup()');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--allow-source'))source=source.replace('c~=e:GetHandler() and c:IsFaceup()','c:IsFaceup()');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--allow-facedown'))source=source.replace('c~=e:GetHandler() and c:IsFaceup()','c~=e:GetHandler()');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--any-reason'))source=source.replace('return c:IsReason(REASON_MATERIAL) and c:IsReason(REASON_FUSION) and rc','return rc');
   return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,refilled=false,repeated=false,turn=0,done=false;
  const negative=test.wrongFusionAttribute||test.wrongFusionRace||test.noFusionReason||test.noMaterialReason||test.facedownRecipient||test.wrongRecipientAttribute||test.wrongRecipientRace||test.onlySource;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   if(test.full)for(let sequence=0;sequence<5;sequence++)core.duelNewCard(duel,{team:0,duelist:0,code:900001031,controller:0,location:L.SZONE,sequence,position:P.FACEUP_ATTACK});
   add(boss,L.HAND);add(boss,L.HAND);add(refill,L.EXTRA);add(refill,L.EXTRA);if(!test.onlySource)for(let i=0;i<2;i++)core.duelNewCard(duel,{team:0,duelist:0,code:ally,controller:0,location:L.REMOVED,sequence:0,position:test.facedownRecipient?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK});for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,controller:0,location}).filter(Boolean);
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!activated){const index=p.special_summons.findIndex(x=>x.code===refill);assert(index>=0,'Neutral Fusion procedure unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SPECIAL_SUMMON,index});continue;}
     if(negative){const src=query(L.REMOVED).find(x=>x.code===boss);assert(src,'Source not actually removed');assert.equal(!!(src.reason&0x8),!test.noMaterialReason,'Material reason fixture mismatch');assert.equal(!!(src.reason&0x40000),!test.noFusionReason,'Fusion reason fixture mismatch');assert(query(L.MZONE).some(x=>x.code===refill),'Neutral procedure did not Summon');assert(query(L.REMOVED).some(x=>x.code===boss),'Source not actually banished');assert.equal(trace.filter(x=>x.type===M.CHAINING&&x.code===boss).length,0,'Invalid banishment trigger activated');assert(!query(L.SZONE).some(x=>x.code===ally),'Invalid recipient placed');assert(!query(L.HAND).some(x=>x.code===ally),'Invalid recipient added');done=true;continue;}
     if(!refilled){if(test.full){assert.equal(query(L.SZONE).filter(x=>x.code===900001031).length,5,'Full-zone fixture missing');assert.equal(trace.filter(x=>x.type===M.SELECT_OPTION).length,0,'Placement choice offered with full SZONE');}assert(query(L.MZONE).some(x=>x.code===refill),'Neutral Fusion not actually summoned');assert(query(L.REMOVED).some(x=>x.code===boss),'Source not banished');assert.equal(query(test.place?L.SZONE:L.HAND).filter(x=>x.code===ally).length,test.sameName&&!test.place?2:1,'First recipient not recovered/placed');assert.equal(query(L.REMOVED).filter(x=>x.code===ally).length,test.sameName?2:1,'Second legal recipient missing');const index=p.activates.findIndex(x=>x.code===refill&&String(x.description)==='2');assert(index>=0);refilled=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(test.place)assert(trace.some(x=>x.type===M.HINT&&Number(x.hint)===701),'Banished recipient not Continuous Spell');
     if(turn<3){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
     if(!repeated){const index=p.special_summons.findIndex(x=>x.code===refill);assert(index>=0,'Second neutral Fusion unavailable');repeated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SPECIAL_SUMMON,index});continue;}
     assert.equal(query(L.REMOVED).filter(x=>x.code===boss).length,test.sameName?3:2,'Second copy not actually material-banished');assert.equal(query(test.place?L.SZONE:L.HAND).filter(x=>x.code===ally).length,1,'Once-per-Duel effect used again');assert.equal(trace.filter(x=>x.type===M.CHAINING&&x.code===boss).length,1,'More than one source activation');done=true;
    }else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(x=>x.code===boss&&String(x.description)===String(133935097*16+1));if(negative)assert.equal(index,-1,'Ineligible banishment trigger offered');if(repeated)assert.equal(index,-1,'Second copy offered once-per-Duel effect');core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(x=>x.code===(ally));assert(index>=0,'Destruction target absent');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.place?1:0});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_EFFECTYN){if(negative&&p.code===boss)assert.fail('Ineligible banishment trigger offered');if(repeated&&p.code===boss)assert.fail('Second copy offered once-per-Duel effect');core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:p.code===boss});}
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}assert(sequence!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const control=process.argv.includes('--require-space')?'require-space':process.argv.includes('--exclude-same-name')?'exclude-same-name':process.argv.includes('--no-duel-flag')?'no-duel-flag':process.argv.includes('--any-fusion-type')?'any-fusion-type':process.argv.includes('--allow-source')?'allow-source':process.argv.includes('--allow-facedown')?'allow-facedown':process.argv.includes('--any-reason')?'any-reason':null;
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/swamp-threeheaded-banishment'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public OCGCore, full production Three-Headed/candidate metadata, actual neutral custom Fusion procedure banishes source as material and supplies real Fusion reason card; not certification of pinned Hydra recipe/helpers; cross-copy/new-turn once-per-Duel flag; native Omega untested',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});



