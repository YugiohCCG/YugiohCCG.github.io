'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=238276248,target=900000811,filler=900000812,search=900000881,msg=132276248;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),row=db.prepare('select * from datas where id=?').get(boss),prompts=db.prepare('select * from texts where id=?').get(msg);db.close();
 for(let i=1;i<=4;i++)if(!prompts?.['str'+i])throw Error('Missing staged prompt '+i);
 const base={alias:0,setcodes:[],type:33,level:3,attribute:8,race:32n,attack:300,defense:200,lscale:0,rscale:0,link_marker:0},results=[];
 for(const test of [{ritual:true},{},{noSearch:true,level:9},{noSearch:true,nonMember:true},{full:true},{normal:true}]){
  const legal=true,logs=[],trace=[],cards=new Map([[boss,{...base,code:boss,setcodes:[0x11f],type:Number(row.type),level:Number(row.level)&255,attribute:Number(row.attribute),race:BigInt(row.race),attack:Number(row.atk),defense:Number(row.def)}],[target,{...base,code:target,setcodes:[0x11f]}],[filler,{...base,code:filler}],[search,{...base,code:search,setcodes:test.nonMember?[]:[0x11f],type:test.ritual?0xa1:33,level:test.ritual?2:test.level||8}]]);
  const reader=name=>{if([target,filler,search].some(c=>name===`c${c}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8')};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,searched=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position:P.FACEUP_ATTACK});
   add(boss,L.HAND);add(boss,L.HAND);add(target,L.MZONE);if(test.full)for(let i=1;i<5;i++)add(filler,L.MZONE,0,i);add(search,L.DECK);
   for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<120&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     const index=p.activates.findIndex(c=>c.code===boss&&String(c.description)===String(msg*16));
     if(legal&&!activated){activated=true;if(test.normal){const n=p.summons.findIndex(c=>c.code===boss);if(n<0)throw Error('Normal Summon unavailable');core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SUMMON,index:n});}else{if(index<0)throw Error('Quick Summon unavailable');core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}continue;}
     if(!test.normal&&index>=0)throw Error(legal?'Second copy bypasses shared Quick count':'Illegal hand activation offered');
     if(legal){const m=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.MZONE}),h=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.HAND});if(!test.normal){const grave=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.GRAVE});if(!grave.some(c=>c?.code===target))throw Error('Nephthys victim was not destroyed');if(!trace.some(t=>t.type===M.CONFIRM_CARDS&&t.cards?.some(c=>c.code===boss)))throw Error('Reveal cost not observed');}if(m.filter(c=>c?.code===boss).length!==1)throw Error('Scion Summon mismatch');if(searched===!!test.noSearch)throw Error('Search availability mismatch');if(!test.noSearch&&!h.some(c=>c?.code===search))throw Error('Search result missing');if(test.searchSelf&&h.filter(c=>c?.code===boss).length!==2)throw Error('Self-name search failed');}done=true;
    }
    else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===boss&&String(c.description)===String(msg*16+1));if(index>=0){if(test.noSearch)throw Error('Search without candidate');searched=true;}core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index<0?null:index});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===(p.selects.some(c=>c.code===search)?search:target));if(index<0)throw Error('Search candidate missing');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_EFFECTYN){searched=true;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});}
    else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(e){failure=e.message}finally{core.destroyDuel(duel)}
  results.push({...test,failure,activated,searched,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/nephthys-scion-hand.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',qualifiers:['Complete Scion production script loaded; neutral destruction/search candidates','Delayed Standby recovery/Phoenix tracking is not covered'],results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
