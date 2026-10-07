'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),spores=284636587,pendulum=900000341,helper=900000342,filler=900000343;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),r=db.prepare('select * from datas where id=?').get(spores);db.close();
 const base={alias:0,setcodes:[],type:17,level:4,attribute:2,race:0x400n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[spores,{...base,code:spores,setcodes:[0xA122],type:Number(r.type),level:0,attribute:0,race:0n,attack:0,defense:0}],[pendulum,{...base,code:pendulum,setcodes:[0xA122],type:0x1000021}],[helper,{...base,code:helper,type:2,level:0,attribute:0,race:0n,attack:0,defense:0}],[filler,{...base,code:filler}]]);
 const helperScripts={card:'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) c:RegisterEffect(e) end',monster:'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) c:RegisterEffect(e) end','spell-effect':'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_SZONE) c:RegisterEffect(e) end'};
 const results=[];
 for(const test of [{control:false,chooseDestroy:false,kind:'card'},{control:true,chooseDestroy:false,kind:'card'},{control:true,chooseDestroy:true,kind:'card'},{control:true,chooseDestroy:false,kind:'monster'},{control:true,chooseDestroy:false,kind:'spell-effect'}]){
  const trace=[],logs=[];
  const localCards=new Map(cards);localCards.set(helper,{...cards.get(helper),type:test.kind==='monster'?33:test.kind==='spell-effect'?0x20002:2});
  const reader=name=>{if(name===`c${helper}.lua`)return helperScripts[test.kind];if([`c${pendulum}.lua`,`c${filler}.lua`].includes(name))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8')};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{if(!localCards.has(code))throw Error('Missing card '+code);return localCards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,negated=false,offeredSelfDestroy=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
   const add=(code,location,player=0,seq=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:seq,position});
   add(spores,L.SZONE,0,0,P.FACEDOWN);if(test.control)add(pendulum,L.MZONE);add(helper,test.kind==='monster'?L.MZONE:test.kind==='spell-effect'?L.SZONE:L.HAND,1);
   for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<120&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);
    if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));
    if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(p.type===M.SELECT_IDLECMD){
     if(p.player===0)core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});
     else if(!activated){const index=p.activates.findIndex(c=>c.code===helper);if(index<0)throw Error('Opponent Spell unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}
     else{const shouldNegate=test.control&&test.kind!=='spell-effect',ownM=core.duelQueryCount(duel,0,L.MZONE),ownG=core.duelQueryCount(duel,0,L.GRAVE),oppG=core.duelQueryCount(duel,1,L.GRAVE),expectedOppG=test.kind==='card'||shouldNegate?1:0;if(negated!==shouldNegate||ownM!==(test.control&&test.chooseDestroy?0:test.control?1:0)||ownG!==(shouldNegate?1:0)||oppG!==expectedOppG)throw Error(`Negate/destruction mismatch: negated=${negated} ownM=${ownM} ownG=${ownG} oppG=${oppG}`);if(offeredSelfDestroy!==shouldNegate)throw Error('Optional own destruction offered incorrectly');done=true;break;}
    }else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===spores);if(index>=0)negated=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:null});}
    else if(p.type===M.SELECT_YESNO){offeredSelfDestroy=true;core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:test.chooseDestroy});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===pendulum);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index>=0?index:0]});}
    else if(p.type===M.SELECT_PLACE){const seq=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);if(seq===undefined)throw Error('No Spell zone');core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:1,location:L.SZONE,sequence:seq}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  results.push({test,status:failure?'FAIL':'PASS',failure,activated,negated,offeredSelfDestroy,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/terrarumian-spores-negate.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
