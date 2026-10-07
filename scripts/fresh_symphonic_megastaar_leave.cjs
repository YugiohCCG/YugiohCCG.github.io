'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=238273772,amp=75304793,holder=900000851,target=900000852,grave=900000853,setup=900000854,filler=900000855;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),row=db.prepare('select * from datas where id=?').get(boss);db.close();
 const base={alias:0,setcodes:[],type:33,level:3,attribute:8,race:32n,attack:5000,defense:4000,lscale:0,rscale:0,link_marker:0},results=[];
 for(const test of [{move:'grave'},{move:'banish'},{move:'hand'},{move:'grave',own:true},{move:'grave',decline:true},{move:'grave',full:true},{move:'destroy'},{move:'destroy',own:true}]){
  const legal=!test.own&&!test.decline&&!test.full&&test.move!=='destroy',logs=[],trace=[],cards=new Map([[boss,{...base,code:boss,setcodes:[0x1066],type:Number(row.type),level:Number(row.level)&255,attribute:Number(row.attribute),race:BigInt(row.race),attack:Number(row.atk),defense:Number(row.def)}],[amp,{...base,code:amp,type:0x80002,level:0}],[holder,{...base,code:holder,type:0x20002,level:0}],[target,{...base,code:target}],[grave,{...base,code:grave,type:0x10002,level:0}],[setup,{...base,code:setup,type:2,level:0}],[filler,{...base,code:filler}]]);
  const action=test.move==='banish'?'Duel.Remove(b,POS_FACEUP,REASON_EFFECT)':test.move==='hand'?'Duel.SendtoHand(b,nil,REASON_EFFECT)':test.move==='destroy'?'Duel.Destroy(b,REASON_EFFECT)':'Duel.SendtoGrave(b,REASON_EFFECT)';
  const reader=name=>{
   if(name===`c${setup}.lua`||name===`c${grave}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp)
    ${test.own?'':"if tp==0 then return end"}
    local b=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,LOCATION_MZONE,nil,${boss}):GetFirst()
    assert(b:IsCanBeEffectTarget(e)==(tp==0),'Effect-target immunity mismatch')
    ${action}
   end) c:RegisterEffect(e) end`;
   if([holder,target,filler].some(c=>name===`c${c}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8');
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,prepared=false,activated=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,sequence=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});add(boss,L.MZONE);add(setup,L.HAND);if(!test.own)add(grave,L.SZONE,1,2,P.FACEDOWN_DEFENSE);if(test.full){add(holder,L.SZONE,0,0);add(holder,L.SZONE,0,4);}for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<120&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!prepared){const index=p.activates.findIndex(c=>c.code===setup);if(index<0)throw Error('Setup missing');prepared=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     const zone=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.SZONE}),field=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.MZONE});
     if(zone.some(c=>c?.code===boss)!==legal)throw Error('Pendulum placement mismatch');
     if(test.move==='destroy'&&field.some(c=>c?.code===boss)!==!test.own)throw Error('Effect destruction immunity mismatch');
     if(!test.own&&!activated)throw Error('Opponent fixture did not activate');done=true;
    }
    else if(p.type===M.SELECT_CHAIN){let index=p.selects.findIndex(c=>c.code===grave);if(index>=0){if(activated)index=-1;else activated=true;}else{index=p.selects.findIndex(c=>c.code===boss&&String(c.description)===String(132273772*16+2));if(index>=0&&(test.own||test.full||test.move==='destroy'))throw Error('Ineligible placement trigger offered');if(test.decline)index=-1;}core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index<0?null:index});}
    else if(p.type===M.SELECT_EFFECTYN){if(test.own||test.full||test.move==='destroy')throw Error('Ineligible placement trigger offered');core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:!test.decline});}
    else if(p.type===M.SELECT_PLACE){const sequence=[0,4,2,3].find(i=>(p.field_mask&(1<<(8+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:L.SZONE,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(e){failure=e.message}finally{core.destroyDuel(duel)}
  results.push({...test,failure,activated,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/symphonic-megastaar-leave.json'),JSON.stringify({engine:'public OCGCore with full Mega Staar and official Amplifire; not native Omega',qualifiers:['Mega Staar seeded on field; own Spell and opponent chained Quick-Play perform actual moves/destruction','IsCanBeEffectTarget probes targeting protection; no actual targeted effect is activated','Proper Synchro procedure, battle destruction, and native Omega remain unverified'],results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
