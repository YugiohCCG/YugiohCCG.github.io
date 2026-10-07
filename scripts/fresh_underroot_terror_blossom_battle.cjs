'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,SelectBattleCMDAction:B,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),blossom=process.argv.includes('--afterroot')?238272440:process.argv.includes('--overroot')?238272439:238272438,msg=blossom-106000000,attacker=900000741,revive=900000742,filler=900000743;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),r=db.prepare('select * from datas where id=?').get(blossom);db.close();
 const base={alias:0,setcodes:[],type:33,level:3,attribute:1,race:1n,attack:300,defense:200,lscale:0,rscale:0,link_marker:0},results=[];
 for(const scenario of [{hasCard:true,restricted:false},{hasCard:false,restricted:false},{hasCard:true,restricted:true}]){
  const {hasCard,restricted}=scenario,eligible=hasCard&&!restricted;
  const trace=[],logs=[],cards=new Map([[blossom,{...base,code:blossom,setcodes:[0xA110,0xA111],type:Number(r.type),level:Number(r.level)&255,attribute:Number(r.attribute),race:BigInt(r.race),attack:Number(r.atk),defense:Number(r.def)}],[attacker,{...base,code:attacker,attack:1200}],[revive,{...base,code:revive,attack:500}],[filler,{...base,code:filler}]]);
  const reader=name=>{if(restricted&&name===`c${revive}.lua`)return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE) e:SetCode(EFFECT_SPSUMMON_CONDITION) e:SetValue(function(e,se,sp,st) return sp==1 end) c:RegisterEffect(e) end';if([`c${attacker}.lua`,`c${revive}.lua`,`c${filler}.lua`].includes(name))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);const source=fs.readFileSync(file,'utf8');return process.argv.includes('--old-summoner-control')&&name===`c${blossom}.lua`?source.replace('nil,e,tp,tc:GetCode())','nil,e,1-tp,tc:GetCode())').replace('POS_FACEUP_DEFENSE,1-tp)','POS_FACEUP_DEFENSE)'):source};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{if(!cards.has(code))throw Error('Missing card '+code);return cards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,attacked=false,triggered=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
   const add=(code,location,player=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position});add(blossom,L.MZONE);add(attacker,L.MZONE,1);if(hasCard)add(revive,L.GRAVE,1);for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<155&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(p.type===M.SELECT_IDLECMD){if(p.player===0)core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});else if(p.to_bp)core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_BP});else core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});}
    else if(p.type===M.SELECT_BATTLECMD){if(!attacked){const index=p.attacks.findIndex(c=>c.code===attacker);if(index<0)throw Error('Attack unavailable');attacked=true;core.duelSetResponse(duel,{type:R.SELECT_BATTLECMD,action:B.SELECT_BATTLE,index});}else{const m=core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:1,location:L.MZONE}),g=core.duelQueryLocation(duel,{flags:Q.CODE,controller:1,location:L.GRAVE});if(eligible){if(!triggered||!m.some(c=>c?.code===revive&&c.position===P.FACEUP_DEFENSE)||!g.some(c=>c?.code===attacker))throw Error(`Battle send/revive mismatch triggered=${triggered}`);}else if(triggered)throw Error('Battle effect activated with no different-name GY monster');done=true;}}
    else if(p.type===M.SELECT_CHAIN){const index=attacked&&p.player===0?p.selects.findIndex(c=>c.code===blossom&&String(c.description)===String(msg*16+2)):-1;if(index>=0&&!eligible)throw Error('Battle effect offered without revival target');const use=index>=0&&!triggered;if(use)triggered=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:use?index:null});}
    else if(p.type===M.SELECT_EFFECTYN){const yes=p.code===blossom&&eligible;if(p.code===blossom&&!eligible)throw Error('Battle effect offered without revival target');if(yes)triggered=true;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes});}
    else if(p.type===M.SELECT_CARD){const code=p.selects.some(c=>c.code===blossom)?blossom:revive,index=p.selects.findIndex(c=>c.code===code);if(index<0)throw Error('Battle/revival target unavailable');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_PLACE){const seq=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(16+i)))===0);if(seq===undefined)throw Error('No zone');core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:1,location:L.MZONE,sequence:seq}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_DEFENSE});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:false});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  results.push({...scenario,eligible,status:failure?'FAIL':'PASS',failure,triggered,trace,logs});console.log(`${failure?'FAIL':'PASS'} hasCard=${hasCard} restricted=${restricted}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,`output/fresh-ccg-september/underroot-terror-blossom-${blossom===238272440?'afterroot-':blossom===238272439?'overroot-':''}battle${process.argv.includes('--old-summoner-control')?'-old-summoner-control':''}.json`),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
