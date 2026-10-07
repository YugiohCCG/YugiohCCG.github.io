'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,SelectBattleCMDAction:B}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),field=284636665,fusion=900000181,aqua=900000182,attacker=900000183,helper=900000184,filler=900000185;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),r=db.prepare('select * from datas where id=?').get(field);db.close();
 const base={alias:0,setcodes:[],type:17,level:4,attribute:16,race:0x20n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[field,{...base,code:field,setcodes:[0x0f3c],type:Number(r.type),level:0,attribute:0,race:0n,attack:0,defense:0}],[fusion,{...base,code:fusion,setcodes:[0x0f3c],type:97,level:8,attribute:2,race:64n,attack:1500,defense:1000}],[aqua,{...base,code:aqua,setcodes:[0x0f3c],type:33,level:4,attribute:2,race:64n}],[attacker,{...base,code:attacker,attack:1200}],[helper,{...base,code:helper,type:2,level:0,attribute:0,race:0n,attack:0,defense:0}],[filler,{...base,code:filler}]]);
 const helperScript=`local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(s.op) c:RegisterEffect(e) end function s.op(e,tp) local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_EXTRA,0,nil,${fusion}) local tc=g:GetFirst() if tc and Duel.SpecialSummon(tc,SUMMON_TYPE_FUSION,tp,tp,true,true,POS_FACEUP)>0 then tc:CompleteProcedure() end end`;
 const trace=[],logs=[];
 const reader=name=>{if(name===`c${helper}.lua`)return helperScript;if([`c${fusion}.lua`,`c${aqua}.lua`,`c${attacker}.lua`,`c${filler}.lua`].includes(name))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8')};
 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{if(!cards.has(code))throw Error('Missing card '+code);return cards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,revived=false,attacked=false,done=false;
 try{
  for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
  const add=(code,location,player=0,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position:P.FACEUP_ATTACK});
  add(field,L.SZONE,0,5);add(fusion,L.EXTRA);add(aqua,L.GRAVE);add(helper,L.HAND);add(attacker,L.MZONE,1);
  for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
  core.startDuel(duel);
  for(let step=0;step<190&&!done;step++){
   const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);
   if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));
   if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
   const p=messages.at(-1);if(!p)throw Error('Missing prompt');
   if(p.type===M.SELECT_IDLECMD){
    if(p.player===0&&!activated){const index=p.activates.findIndex(c=>c.code===helper);if(index<0)throw Error('Fusion test helper unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}
    else if(p.player===0){if(!revived||core.duelQueryCount(duel,0,L.MZONE)!==2)throw Error('GY Aquamarine not revived');core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});}
    else core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:p.to_bp?A.TO_BP:A.TO_EP});
   }else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===field);if(index>=0)revived=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:null});}
   else if(p.type===M.SELECT_EFFECTYN){if(p.code===field)revived=true;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});}
   else if(p.type===M.SELECT_CARD){
    if(attacked){if(p.selects.some(c=>c.code===aqua))throw Error('Low-Level Aquamarine offered as attack target');if(!p.selects.some(c=>c.code===fusion))throw Error('Fusion not offered as attack target');done=true;break;}
    const index=p.selects.findIndex(c=>c.code===aqua);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index>=0?index:0]});
   }else if(p.type===M.SELECT_BATTLECMD){const index=p.attacks.findIndex(c=>c.code===attacker);if(index<0)throw Error('Opponent attack unavailable');attacked=true;core.duelSetResponse(duel,{type:R.SELECT_BATTLECMD,action:B.SELECT_BATTLE,index});}
   else if(p.type===M.SELECT_PLACE){let player=0,location=L.MZONE,seq=[5,6,0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(seq===undefined){seq=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);location=L.SZONE;}if(seq===undefined)throw Error('No place');core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player,location,sequence:seq}]});}
   else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
   else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
  }
  if(!done)throw Error('Step limit');
 }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/aquasanctuary-field.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; Fusion Summon driven by test-only helper',status:failure?'FAIL':'PASS',failure,activated,revived,attacked,trace,logs},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 console.log(`${failure?'FAIL':'PASS'} Aquasanctuary field effects${failure?': '+failure:''}`);if(failure)process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
