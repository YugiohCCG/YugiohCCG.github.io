'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),krait=284636662,fusion=250339529,helper=900000281,trap=900000282,opp=900000283,filler=900000284;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),query=db.prepare('select * from datas where id=?');
 const base={alias:0,setcodes:[],type:17,level:4,attribute:2,race:64n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[helper,{...base,code:helper,type:2}],[trap,{...base,code:trap,type:0x20004}],[opp,{...base,code:opp}],[filler,{...base,code:filler}]]);
 for(const code of [krait,fusion]){const r=query.get(code),b=r.setcode;cards.set(code,{...base,code,setcodes:Array.from({length:b.length/2},(_,i)=>b[i*2]|b[i*2+1]<<8).filter(Boolean),type:Number(r.type),level:Number(r.level)&255,attribute:Number(r.attribute),race:BigInt(r.race),attack:Number(r.atk),defense:Number(r.def)});}db.close();
 const helperScript=`local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetTarget(s.tg) e:SetOperation(s.op) c:RegisterEffect(e) end function s.tg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(Card.IsCode,tp,LOCATION_EXTRA,0,1,nil,${krait}) end end function s.op(e,tp) local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_EXTRA,0,nil,${krait}) local c=g:GetFirst() if c and Duel.SpecialSummon(c,SUMMON_TYPE_FUSION,tp,tp,true,true,POS_FACEUP)>0 then c:CompleteProcedure() end end`;
 const trapScript=`local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_F) e:SetCode(EVENT_SPSUMMON_SUCCESS) e:SetRange(LOCATION_SZONE) e:SetCondition(s.con) e:SetOperation(s.op) c:RegisterEffect(e) end function s.con(e,tp,eg) return eg:IsExists(Card.IsCode,1,nil,${krait}) end function s.op(e,tp) local g=Duel.GetMatchingGroup(Card.IsCode,tp,0,LOCATION_MZONE,nil,${krait}) if #g>0 then Duel.SendtoGrave(g,REASON_EFFECT) end end`;
 const results=[];
 for(const test of [{nonWater:false,fusionSummoned:true},{nonWater:true,fusionSummoned:true},{nonWater:true,fusionSummoned:false}]){
  const {nonWater,fusionSummoned}=test;
  const trace=[],logs=[];
  const localCards=new Map(cards);localCards.set(opp,{...base,code:opp,attribute:nonWater?16:2});
  const reader=name=>{if(name===`c${helper}.lua`)return fusionSummoned?helperScript:helperScript.replace('Duel.SpecialSummon(c,SUMMON_TYPE_FUSION,tp,tp,true,true','Duel.SpecialSummon(c,0,tp,tp,true,true');if(name===`c${trap}.lua`)return trapScript;if(name===`c${fusion}.lua`)return 'local s,id=GetID() function s.initial_effect(c) c:EnableReviveLimit() aux.AddFusionProcMixRep(c,true,true,aux.FilterBoolFunction(Card.IsSetCard,0xf3c),2,2) end';if([`c${opp}.lua`,`c${filler}.lua`].includes(name))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8')};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{if(!localCards.has(code))throw Error('Missing card '+code);return localCards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,replaced=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
   const add=(code,location,player=0,seq=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:seq,position:P.FACEUP_ATTACK});
   add(helper,L.HAND);add(krait,L.EXTRA);add(fusion,L.EXTRA);add(trap,L.SZONE,1);add(opp,L.MZONE,1);
   for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<120&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);
    if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));
    if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(p.type===M.SELECT_IDLECMD){
     if(!activated){const index=p.activates.findIndex(c=>c.code===helper);if(index<0)throw Error('Fusion Summon helper unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}
     else{const m=core.duelQueryCount(duel,0,L.MZONE),g=core.duelQueryCount(duel,0,L.GRAVE),shouldReplace=nonWater&&fusionSummoned;if(g!==2||m!==(shouldReplace?1:0)||replaced!==shouldReplace)throw Error(`Leave-field replacement incorrect: M=${m} G=${g} offered=${replaced}`);done=true;break;}
    }else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===krait);if(index>=0)replaced=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:null});}
    else if(p.type===M.SELECT_EFFECTYN){if(p.code===krait)replaced=true;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===fusion);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index>=0?index:0]});}
    else if(p.type===M.SELECT_PLACE){let seq=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<i))===0),location=L.MZONE;if(seq===undefined){location=L.SZONE;seq=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}if(seq===undefined)throw Error('No zone');core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence:seq}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:true});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  results.push({test,status:failure?'FAIL':'PASS',failure,activated,replaced,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/coral-krait-leave.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',helpers:'Test-only own Spell Fusion Summons Krait; opponent Continuous Trap sends it to GY; Planktonites material procedure retained but unrelated triggers omitted',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
