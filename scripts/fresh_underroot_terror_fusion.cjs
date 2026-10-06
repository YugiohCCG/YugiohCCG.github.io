'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),blossom=process.argv.includes('--blossom'),boss=process.argv.includes('--boss'),terror=blossom?238272435:238272434,mat=900000681,fusion=boss?238272438:900000682,filler=900000683,mat2=900000684;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),r=db.prepare('select * from datas where id=?').get(terror),fr=boss?db.prepare('select * from datas where id=?').get(fusion):null;db.close();
 const base={alias:0,setcodes:[],type:33,level:3,attribute:1,race:1n,attack:300,defense:200,lscale:0,rscale:0,link_marker:0},results=[];
 for(const mode of ['fusion','fusion_level','none']){
  const hasFusion=mode!=='none',levelCase=mode==='fusion_level';
  const trace=[],logs=[],cards=new Map([[terror,{...base,code:terror,setcodes:[0xA110,0xA111],type:Number(r.type),level:Number(r.level)&255,attribute:Number(r.attribute),race:BigInt(r.race),attack:Number(r.atk),defense:Number(r.def)}],[mat,{...base,code:mat,setcodes:[0xA110]}],[mat2,{...base,code:mat2,setcodes:[0xA110]}],[fusion,{...base,code:fusion,setcodes:[0xA110],type:0x21|0x40,level:1,attack:1000,defense:1000}],[filler,{...base,code:filler}]]);
  if(boss)cards.set(fusion,{...base,code:fusion,setcodes:[0xA110,0xA111],type:Number(fr.type),level:Number(fr.level)&255,attribute:Number(fr.attribute),race:BigInt(fr.race),attack:Number(fr.atk),defense:Number(fr.def)});
  const reader=name=>{if(name===`c${fusion}.lua`)return boss?fs.readFileSync(path.join(CUSTOM,name),'utf8'):'local s,id=GetID() function s.initial_effect(c) c:EnableReviveLimit() aux.AddFusionProcMixRep(c,true,true,aux.FilterBoolFunction(Card.IsSetCard,0xA110),2,2) end';if([`c${mat}.lua`,`c${mat2}.lua`,`c${filler}.lua`].includes(name))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8')};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{if(!cards.has(code))throw Error('Missing card '+code);return cards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
   if(!core.loadScript(duel,'public-core-compat.lua','if not Duel.GetMustMaterial then Duel.GetMustMaterial=function() return Group.CreateGroup() end end if not Duel.CheckMustMaterial then Duel.CheckMustMaterial=function() return true end end'))throw Error('Compatibility binding');
   const add=(code,location)=>core.duelNewCard(duel,{team:0,duelist:0,code,controller:0,location,sequence:code===mat&&location===L.MZONE?1:0,position:P.FACEUP_ATTACK});add(terror,L.MZONE);add(mat,levelCase?L.MZONE:L.HAND);if(levelCase)add(mat2,L.HAND);if(hasFusion)add(fusion,L.EXTRA);for(const player of [0,1])for(let i=0;i<5;i++)core.duelNewCard(duel,{team:player,duelist:0,code:filler,controller:player,location:L.DECK,sequence:0,position:P.FACEUP_ATTACK});
   core.startDuel(duel);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(p.type===M.SELECT_IDLECMD){const index=p.activates.findIndex(c=>c.code===terror);if(!activated&&hasFusion){if(index<0)throw Error('Quick Effect unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}else{if(!hasFusion&&index>=0)throw Error('Quick Effect offered without rroot Extra Deck target');const m=core.duelQueryLocation(duel,{flags:Q.CODE|Q.LEVEL,controller:0,location:L.MZONE}),g=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.GRAVE});if(hasFusion&&(!m.some(c=>c?.code===fusion)||!g.some(c=>c?.code===mat)||!levelCase&&!g.some(c=>c?.code===terror)))throw Error('Summon/material mismatch');if(levelCase&&(!g.some(c=>c?.code===mat2)||m.find(c=>c?.code===terror)?.level!==1))throw Error('Level reduction/material mismatch');done=true;}}
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:null});
    else if(p.type===M.ANNOUNCE_NUMBER)core.duelSetResponse(duel,{type:R.ANNOUNCE_NUMBER,value:levelCase?2:0});
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===fusion);if(index>=0)core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});else{const picks=p.selects.map((c,i)=>[c,i]).filter(([c])=>levelCase?c.code===mat||c.code===mat2:c.code===terror||c.code===mat).map(([,i])=>i);if(picks.length!==2)throw Error('Fusion materials unavailable');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:picks});}}
    else if(p.type===M.SELECT_UNSELECT_CARD){const index=levelCase?p.select_cards.findIndex(c=>c.code===mat||c.code===mat2):0;core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index:p.can_finish?null:index>=0?index:0});}
    else if(p.type===M.SELECT_PLACE){const seq=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<i))===0);if(seq===undefined)throw Error('No zone');core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:L.MZONE,sequence:seq}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:false});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  results.push({mode,status:failure?'FAIL':'PASS',failure,trace,logs});console.log(`${failure?'FAIL':'PASS'} mode=${mode}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,`output/fresh-ccg-september/underroot-${blossom?'blossom':'terror'}-fusion${boss?'-boss':''}.json`),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega; neutral mandatory-material bindings',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
