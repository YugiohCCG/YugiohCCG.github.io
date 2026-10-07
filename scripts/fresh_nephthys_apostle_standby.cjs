'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=238276249,target=900000811,filler=900000812,search=900000881,setup=900000882,phoenix=61441708,msg=132276249;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),row=db.prepare('select * from datas where id=?').get(boss),prompts=db.prepare('select * from texts where id=?').get(msg);db.close();
 for(let i=1;i<=4;i++)if(!prompts?.['str'+i])throw Error('Missing staged prompt '+i);
 const base={alias:0,setcodes:[],type:33,level:3,attribute:8,race:32n,attack:300,defense:200,lscale:0,rscale:0,link_marker:0},results=[];
 for(const test of [{},{sendOnly:true},{decline:true},{full:true}]){
  const legal=!test.sendOnly&&!test.decline&&!test.full,logs=[],trace=[],cards=new Map([[boss,{...base,code:boss,setcodes:[0x11f],type:Number(row.type),level:Number(row.level)&255,attribute:Number(row.attribute),race:BigInt(row.race),attack:Number(row.atk),defense:Number(row.def)}],[target,{...base,code:target,setcodes:[0x11f]}],[filler,{...base,code:filler}],[search,{...base,code:search,setcodes:[0x11f],level:8}],[setup,{...base,code:setup,type:2,level:0}],[phoenix,{...base,code:phoenix,setcodes:[0x11f],type:33,level:8,attribute:4,race:512n,attack:2400,defense:1600}]]);
  const reader=name=>{if(name===`c${setup}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local c=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,${boss}):GetFirst() ${test.phoenix?`c=Group.FromCards(c,Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,${phoenix}):GetFirst())`:''} ${test.sendOnly?'Duel.SendtoGrave(c,REASON_EFFECT)':'Duel.Destroy(c,REASON_EFFECT)'} ${test.full?`local f=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,${filler}):GetFirst() Duel.SpecialSummon(f,0,tp,tp,false,false,POS_FACEUP)`:''} end) c:RegisterEffect(e) end`;if([target,filler,search].some(c=>name===`c${c}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8')};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,searched=false,done=false,turn=0,phase=0;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position:P.FACEUP_ATTACK});
   add(boss,L.MZONE);if(test.phoenix)core.duelNewCard(duel,{team:0,duelist:0,code:phoenix,controller:0,location:L.MZONE,sequence:1,position:P.FACEUP_ATTACK});add(setup,L.HAND);if(!test.selfRecover)add(target,L.GRAVE);if(test.full){for(let i=1;i<5;i++)core.duelNewCard(duel,{team:0,duelist:0,code:filler,controller:0,location:L.MZONE,sequence:i,position:P.FACEUP_ATTACK});add(filler,L.HAND);}for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<120&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages){if(m.type===M.NEW_TURN)turn++;if(m.type===M.NEW_PHASE)phase=m.phase;}if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!activated){const index=p.activates.findIndex(c=>c.code===setup);if(index<0)throw Error('Destruction setup missing');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(turn>=5){const h=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.HAND}),g=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.GRAVE});if(core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.MZONE}).some(c=>c?.code===boss)!==legal)throw Error('Recovery outcome mismatch');if(!test.selfRecover&&g.some(c=>c?.code===boss)!==!legal)throw Error('Apostle revival state mismatch');if(test.phoenix&&!test.declineSummon&&!test.scionFirst){const field=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.MZONE});if(!field.some(c=>c?.code===boss)||!field.some(c=>c?.code===phoenix))throw Error('Actual Phoenix/Apostle revival missing');}if(searched!==(!test.sendOnly&&!test.full))throw Error('Delayed trigger registration mismatch');done=true;}
     else core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});
    }
    else if(p.type===M.SELECT_EFFECTYN){if(test.sendOnly||test.full||turn!==3||phase!==mod.OcgPhase.STANDBY||p.player!==0)throw Error('Recovery at wrong turn/phase');searched=true;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:!test.decline});}
    else if(p.type===M.SELECT_CHAIN){const phoenixIndex=p.selects.findIndex(c=>c.code===phoenix);if(test.phoenix&&!test.scionFirst&&phoenixIndex>=0){core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:phoenixIndex});continue;}const index=p.selects.findIndex(c=>c.code===boss&&String(c.description)===String(msg*16+2));if(index>=0){if(test.sendOnly||turn!==3||phase!==mod.OcgPhase.STANDBY||p.player!==0)throw Error('Recovery at wrong turn/phase');searched=true;}core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index<0?(p.forced?0:null):test.decline?null:index});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===(test.selfRecover?boss:target));if(index<0)throw Error('Recovery candidate missing');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.declineSummon});
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(e){failure=e.message}finally{core.destroyDuel(duel)}
  results.push({...test,failure,activated,searched,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/nephthys-apostle-standby.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',qualifiers:['Complete Apostle production Lua; fixture Spell actually destroys/sends Apostle','Actual turns/phases advance through two own Standby Phases; Full-zone fixture fills the space freed by destruction with a real Summon'],results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
