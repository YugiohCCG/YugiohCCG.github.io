'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),clyp=284636664,fusion=250339529,aqua=900000251,mat1=900000252,mat2=900000253,filler=900000254;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),query=db.prepare('select * from datas where id=?');
 const base={alias:0,setcodes:[],type:17,level:4,attribute:2,race:64n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[aqua,{...base,code:aqua,setcodes:[0xf3c]}],[mat1,{...base,code:mat1,setcodes:[0xf3c]}],[mat2,{...base,code:mat2,setcodes:[0xf3c]}],[filler,{...base,code:filler}]]);
 for(const code of [clyp,fusion]){const r=query.get(code),b=r.setcode;cards.set(code,{...base,code,setcodes:Array.from({length:b.length/2},(_,i)=>b[i*2]|b[i*2+1]<<8).filter(Boolean),type:Number(r.type),level:Number(r.level)&255,attribute:Number(r.attribute),race:BigInt(r.race),attack:Number(r.atk),defense:Number(r.def)});}db.close();
 const results=[];
 for(const test of [{control:false,materials:false},{control:true,materials:false},{control:true,materials:true}]){
  const trace=[],logs=[];
  const reader=name=>{if([`c${aqua}.lua`,`c${mat1}.lua`,`c${mat2}.lua`,`c${filler}.lua`].includes(name))return 'local s,id=GetID() function s.initial_effect(c) end';if(name===`c${fusion}.lua`)return 'local s,id=GetID() function s.initial_effect(c) c:EnableReviveLimit() aux.AddFusionProcMixRep(c,true,true,aux.FilterBoolFunction(Card.IsSetCard,0xf3c),2,2) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8')};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{if(!cards.has(code))throw Error('Missing card '+code);return cards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,fused=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
   if(!core.loadScript(duel,'fresh-fusion-compat.lua','function Auxiliary.MustMaterialCheck(v,tp,code) return true end'))throw Error('Fusion material compatibility adapter');
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   add(clyp,L.HAND);if(test.control)add(aqua,L.MZONE);if(test.materials){add(mat1,L.REMOVED);add(mat2,L.REMOVED);add(fusion,L.EXTRA);}
   for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<110&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);
    if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));
    if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(p.type===M.SELECT_IDLECMD){
     if(!test.control){if(p.activates.some(c=>c.code===clyp))throw Error('Hand effect offered without Aquamarine control');done=true;break;}
     if(!activated){const index=p.activates.findIndex(c=>c.code===clyp&&c.location===L.HAND);if(index<0)throw Error('Hand effect unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}
     else{const m=core.duelQueryCount(duel,0,L.MZONE),b=core.duelQueryCount(duel,0,L.REMOVED),g=core.duelQueryCount(duel,0,L.GRAVE);
      if(test.materials){if(m!==3||b!==0||g!==2)throw Error(`Fusion/material move incorrect: M=${m} B=${b} G=${g}`);}else if(m!==2)throw Error('Hand Special Summon failed');done=true;break;}
    }else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===clyp&&c.location===L.MZONE);if(index>=0)fused=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:null});}
    else if(p.type===M.SELECT_EFFECTYN){if(p.code===clyp)fused=true;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});}
    else if(p.type===M.SELECT_CARD)core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[0]});
    else if(p.type===M.SELECT_UNSELECT_CARD)core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index:p.can_finish?null:0});
    else if(p.type===M.SELECT_PLACE){let seq=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<i))===0),location=L.MZONE;if(seq===undefined){location=L.SZONE;seq=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}if(seq===undefined)throw Error('No zone');core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence:seq}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:true});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');if(test.materials&&!fused)throw Error('Fusion trigger was not offered');
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  results.push({test,status:failure?'FAIL':'PASS',failure,activated,fused,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/clypeasteria-duels.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',adapter:'Test-only Auxiliary.MustMaterialCheck=true because public core lacks Duel.GetMustMaterial; no mandatory-material effects present. Planktonites keeps its original Fusion material procedure, but unrelated summon triggers are omitted because its IsFaceupEx is unavailable in public core.',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
