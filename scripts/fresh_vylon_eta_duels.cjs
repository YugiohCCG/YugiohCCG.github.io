'use strict';
// Actual core activation and destruction tests for Vylon Eta's grave/equip path.
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite'),{createHash}=require('node:crypto');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}});
 const id=238274863,target=900000031,blast=900000032,filler=900000033;
 const dbpath=path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),db=new DatabaseSync(dbpath,{readOnly:true});
 const row=db.prepare('select * from datas where id=?').get(id);db.close();
 if(!row)throw Error('Eta is absent from candidate database');
 const bytes=row.setcode;
 const setcodes=bytes instanceof Uint8Array?Array.from({length:bytes.length/2},(_,i)=>bytes[i*2]|(bytes[i*2+1]<<8)).filter(Boolean):[Number(BigInt(bytes)&65535n)];
 const common={alias:0,lscale:0,rscale:0,link_marker:0};
 const results=[];
 for(const choice of ['no-target','decline','accept']){
  const logs=[],trace=[];
  const data=new Map([[id,{...common,code:id,setcodes,type:Number(row.type),level:Number(row.level)&255,attribute:Number(row.attribute),race:BigInt(row.race),attack:Number(row.atk),defense:Number(row.def)}],
   [target,{...common,code:target,setcodes:choice==='no-target'?[]:[0x30],type:0x2021,level:5,attribute:16,race:0x1000n,attack:2000,defense:1500}],
   [blast,{...common,code:blast,setcodes:[],type:2,level:0,attribute:0,race:0n,attack:0,defense:0}],
   [filler,{...common,code:filler,setcodes:[],type:17,level:4,attribute:1,race:1n,attack:1000,defense:1000}]]);
  const reader=name=>{
   if(name===`c${target}.lua`)return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c0.lua'||name===`c${filler}.lua`)return '';
   if(name===`c${blast}.lua`)return `local s,id=GetID()
function s.initial_effect(c)
 local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN)
 e:SetOperation(function(e,tp)
  local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_MZONE,0,nil,${target})
  if tc then Duel.Destroy(tc,REASON_EFFECT) end
 end)
 c:RegisterEffect(e)
end`;
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));
   if(!file)throw Error('Missing script '+name);
   return fs.readFileSync(file,'utf8');
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],
   team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},
   cardReader:code=>{if(!data.has(code))throw Error('Missing metadata '+code);return data.get(code)},scriptReader:reader,
   errorHandler:(type,message)=>logs.push({type,message})});
  let activated=false,destroyed=false,done=false,optional=false,failure=null;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support failed '+name);
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   add(id,L.GRAVE);add(target,L.MZONE);if(choice!=='no-target')add(blast,L.HAND);
   for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<120&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);
    if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));
    if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(p.type===M.SELECT_IDLECMD){
     if(choice==='no-target'){
      if(p.activates.some(c=>c.code===id))throw Error('GY equip offered without a Vylon Synchro');
      done=true;break;
     }
     if(destroyed){
      if(!optional)throw Error('Replacement choice was not offered');
      if(core.duelQueryCount(duel,0,L.MZONE)!==(choice==='accept'?1:0))throw Error('Wrong protected monster state');
      if(core.duelQueryCount(duel,0,L.GRAVE)<(choice==='accept'?1:0))throw Error('Eta not destroyed as replacement');
      done=true;break;
     }
     if(activated){
      if(core.duelQueryCount(duel,0,L.SZONE)!==1)throw Error('Eta not equipped');
      const index=p.activates.findIndex(c=>c.code===blast);
      if(index<0)throw Error('Destruction spell unavailable');
      destroyed=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});
     }else{
      const index=p.activates.findIndex(c=>c.code===id);
      if(index<0)throw Error('Eta GY equip unavailable');
      activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});
     }
    }else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:null});
    else if(p.type===M.SELECT_CARD)core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[0]});
    else if(p.type===M.SELECT_YESNO){optional=true;core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:choice==='accept'});}
    else if(p.type===M.SELECT_PLACE){
     const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);
     if(sequence===undefined)throw Error('No free Spell zone in prompt');
     core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:L.SZONE,sequence}]});
    }
    else throw Error('Unhandled prompt '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit reached');
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  results.push({choice,status:failure?'FAIL':'PASS',failure,trace,logs});
  console.log(`${failure?'FAIL':'PASS'} ${choice}${failure?': '+failure:''}`);
 }
 const hash=file=>createHash('sha256').update(fs.readFileSync(file)).digest('hex');
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/vylon-eta-duels.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',script_sha256:hash(path.join(CUSTOM,`c${id}.lua`)),database_sha256:hash(dbpath),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
