'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=238273770,target=82735249,filler=900000812,msg=132273770;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),row=db.prepare('select * from datas where id=?').get(boss),prompts=db.prepare('select * from texts where id=?').get(msg);db.close();
 for(let i=1;i<=4;i++)if(!prompts?.['str'+i])throw Error('Missing staged prompt '+i);
 const base={alias:0,setcodes:[],type:33,level:3,attribute:8,race:32n,attack:300,defense:200,lscale:0,rscale:0,link_marker:0},results=[];
 for(const test of [{member:true,normal:true},{member:false,normal:true,counter:true},{member:true,normal:true,searchSelf:true,noSearch:true},{member:true,normal:true,noSearch:true}]){
  const legal=test.normal||(test.member&&!test.full),logs=[],trace=[],cards=new Map([[boss,{...base,code:boss,setcodes:[0x1066],type:Number(row.type),level:Number(row.level)&255,attribute:Number(row.attribute),race:BigInt(row.race),attack:Number(row.atk),defense:Number(row.def)}],[target,{...base,code:target,setcodes:test.member?[0x1066]:[],type:test.counter?2:33}],[filler,{...base,code:filler}]]);
  const reader=name=>{if([target,filler].some(c=>name===`c${c}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8')};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,searched=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position:P.FACEUP_ATTACK});
   add(boss,L.HAND);add(boss,L.HAND);if(test.full)for(let i=1;i<5;i++)add(filler,L.MZONE,0,i);if(!test.noSearch||test.searchSelf)add(test.searchSelf?boss:target,L.DECK);
   for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<120&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     const index=p.activates.findIndex(c=>c.code===boss&&String(c.description)===String(msg*16+3));
     if(legal&&!activated){activated=true;if(test.normal){const n=p.summons.findIndex(c=>c.code===boss);if(n<0)throw Error('Normal Summon unavailable');core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SUMMON,index:n});}else{if(index<0)throw Error('Quick Summon unavailable');core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}continue;}
     if(!test.normal&&index>=0)throw Error(legal?'Second copy bypasses shared Quick count':'Illegal hand activation offered');
     if(legal){const m=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.MZONE}),h=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.HAND});if(m.filter(c=>c?.code===boss).length!==1)throw Error('Disccs Summon mismatch');if(searched===!!test.noSearch)throw Error('Search availability mismatch');if(!test.noSearch&&!h.some(c=>c?.code===(test.searchSelf?boss:target)))throw Error('Search result missing');if(test.searchSelf&&!test.noSearch&&h.filter(c=>c?.code===boss).length!==2)throw Error('Self-name search failed');}done=true;
    }
    else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===boss&&String(c.description)===String(msg*16+1));if(index>=0){if(test.noSearch)throw Error('Search without candidate');searched=true;}core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index<0?null:index});}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===(test.searchSelf?boss:target));if(index<0)throw Error('Search candidate missing');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_EFFECTYN){searched=true;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});}
    else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(e){failure=e.message}finally{core.destroyDuel(duel)}
  results.push({...test,failure,activated,searched,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/symphonic-disccs-search.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',qualifiers:['Complete DDJ production script loaded; neutral companion monsters have no effects','No Synchro candidate: optional Synchro branch is not verified'],results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
