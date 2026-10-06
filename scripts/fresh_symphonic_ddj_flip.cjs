'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=238273769,target=900000821,filler=900000822,flip=900000823,probe=900000824,wind=900000825,dark=900000826;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),row=db.prepare('select * from datas where id=?').get(boss);db.close();
 const base={alias:0,setcodes:[],type:33,level:3,attribute:8,race:32n,attack:300,defense:200,lscale:0,rscale:0,link_marker:0},results=[];
 for(const test of [{level:4},{level:5},{level:4,self:true},{level:4,member:false},{level:4,full:true}]){
  const eligible=test.level<=4&&!test.self&&test.member!==false&&!test.full,logs=[],trace=[],cards=new Map([[boss,{...base,code:boss,setcodes:[0x1066],type:Number(row.type),level:Number(row.level)&255,attribute:Number(row.attribute),race:BigInt(row.race),attack:Number(row.atk),defense:Number(row.def)}],[target,{...base,code:target,level:test.level,setcodes:test.member===false?[]:[0x1066]}],[filler,{...base,code:filler}]]);
  for(const code of [flip,probe])cards.set(code,{...base,code,type:2,level:0});
  for(const code of [wind,dark])cards.set(code,{...base,code,type:0x2041,level:6,attribute:code===wind?8:32});
  const reader=name=>{
   if(name===`c${flip}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local c=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,${boss}):GetFirst() Duel.ChangePosition(c,POS_FACEUP_DEFENSE) end) c:RegisterEffect(e) end`;
   if(name===`c${probe}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local function card(code) return Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_EXTRA,0,nil,code):GetFirst() end assert(not card(${dark}):IsCanBeSpecialSummoned(e,0,tp,true,true),'Non-WIND Extra Deck monster allowed') ${test.full?'':`assert(card(${wind}):IsCanBeSpecialSummoned(e,0,tp,true,true),'WIND Extra Deck monster blocked')`} Duel.Damage(tp,777,REASON_EFFECT) end) c:RegisterEffect(e) end`;
   if([target,filler,wind,dark].some(c=>name===`c${c}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8');
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,stage=0,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,sequence=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(boss,L.MZONE,0,0,P.FACEDOWN_DEFENSE);add(test.self?boss:target,L.DECK);add(flip,L.HAND);add(probe,L.HAND);add(wind,L.EXTRA);add(dark,L.EXTRA);if(test.full)for(let i=1;i<5;i++)add(filler,L.MZONE,0,i);for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<120&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(stage<2){const index=p.activates.findIndex(c=>c.code===(stage===0?flip:probe));if(index<0)throw Error('Fixture activation unavailable');stage++;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}else{const field=core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:0,location:L.MZONE});if(field.some(c=>c?.code===target)!==eligible)throw Error('Deck Summon eligibility mismatch');if(eligible&&!field.some(c=>c?.code===target&&c.position===P.FACEDOWN_DEFENSE))throw Error('Deck monster not face-down Defense');if(!trace.some(t=>t.type===M.DAMAGE))throw Error('Restriction probe did not finish');if(!trace.some(t=>t.type===M.CHAINING&&t.code===boss))throw Error('Mandatory FLIP did not activate');done=true;}}
    else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===boss);core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index<0?null:index});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===target);if(index<0)throw Error('Deck candidate missing');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEDOWN_DEFENSE});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(e){failure=e.message}finally{core.destroyDuel(duel)}
  results.push({...test,failure,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/symphonic-ddj-flip.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',qualifiers:['Complete production DDJ loaded; fixture Spell flips it through actual position change','Extra Deck restriction checked via real engine eligibility, not actual Extra Deck Summons','Full-zone case cannot independently distinguish the restriction from zone rejection'],results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
