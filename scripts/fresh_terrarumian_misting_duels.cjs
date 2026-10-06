'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),misting=284636588,p1=900000351,p2=900000352,o1=900000353,o2=900000354,filler=900000355;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),r=db.prepare('select * from datas where id=?').get(misting);db.close();
 const base={alias:0,setcodes:[],type:33,level:4,attribute:2,race:0x400n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[misting,{...base,code:misting,setcodes:[0xA122],type:Number(r.type),level:0,attribute:0,race:0n,attack:0,defense:0}],[p1,{...base,code:p1,setcodes:[0xA122],type:0x1000021}],[p2,{...base,code:p2,setcodes:[0xA122],type:0x1000021}],[o1,{...base,code:o1}],[o2,{...base,code:o2}],[filler,{...base,code:filler}]]);
 const boost='local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_UPDATE_ATTACK) e:SetValue(500) c:RegisterEffect(e) end';
 const protect='local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_CONTINUOUS) e:SetProperty(EFFECT_FLAG_SINGLE_RANGE) e:SetRange(LOCATION_MZONE) e:SetCode(EFFECT_DESTROY_REPLACE) e:SetTarget(s.tg) c:RegisterEffect(e) end function s.tg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return not e:GetHandler():IsReason(REASON_REPLACE) and e:GetHandler():IsReason(REASON_EFFECT) end return true end';
 const tests=[{own:0,select:0,protected:false},{own:1,select:1,protected:false},{own:2,select:1,protected:false,secondCopy:true},{own:2,select:2,protected:false},{own:2,select:2,protected:true}];
 const results=[];
 for(const test of tests){
  const trace=[],logs=[];
  const reader=name=>{if(name===`c${p2}.lua`)return test.protected?protect:'local s,id=GetID() function s.initial_effect(c) end';if(name===`c${o1}.lua`||name===`c${o2}.lua`)return boost;if([`c${p1}.lua`,`c${filler}.lua`].includes(name))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8')};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{if(!cards.has(code))throw Error('Missing card '+code);return cards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
   const add=(code,location,player=0,seq=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:seq,position:P.FACEUP_ATTACK});
   add(misting,L.HAND);if(test.secondCopy)add(misting,L.HAND);if(test.own>=1)add(p1,L.MZONE,0,0);if(test.own>=2)add(p2,L.MZONE,0,1);add(o1,L.MZONE,1,0);add(o2,L.MZONE,1,1);
   for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<120&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);
    if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));
    if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(p.type===M.SELECT_IDLECMD){const index=p.activates.findIndex(c=>c.code===misting);
     if(test.own===0){if(index>=0)throw Error('Activation offered without Pendulum monster');done=true;break;}
     if(!activated){if(index<0)throw Error('Misting activation unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}
     else{const ownM=core.duelQueryCount(duel,0,L.MZONE),ownX=core.duelQueryCount(duel,0,L.EXTRA),q=core.duelQueryLocation(duel,{flags:Q.CODE|Q.ATTACK,controller:1,location:L.MZONE});const attacks=q.filter(c=>c&&[o1,o2].includes(c.code)).map(c=>c.attack).sort((a,b)=>a-b);const expected=test.protected?[1500,1500]:test.select===1?[1000,1500]:[1000,1000];if(ownM!==(test.own-test.select+(test.protected?1:0))||ownX!==(test.protected?test.select-1:test.select)||JSON.stringify(attacks)!==JSON.stringify(expected))throw Error(`Destroy/negate mismatch: ownM=${ownM} ownX=${ownX} attacks=${attacks}`);if(test.secondCopy&&index>=0)throw Error('Second Misting copy offered in the same turn');done=true;break;}
    }else if(p.type===M.SELECT_CARD){const own=p.selects.filter(c=>c.controller===0);const count=own.length?Math.min(test.select,own.length):test.select;const indices=p.selects.map((c,i)=>({c,i})).filter(x=>own.length?x.c.controller===0:x.c.controller===1).slice(0,count).map(x=>x.i);if(indices.length<1)throw Error('No cards selectable');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:indices});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:true});
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:null});
    else if(p.type===M.SELECT_PLACE){const seq=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);if(seq===undefined)throw Error('No Spell zone');core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:L.SZONE,sequence:seq}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  results.push({test,status:failure?'FAIL':'PASS',failure,activated,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/terrarumian-misting-duels.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',synthetic:'Opponent continuous +500 ATK effects expose negation; one own Pendulum has test-only destruction replacement in protected scenario',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
