'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const pendulum=process.argv.includes('--pendulum');
 const mettronomo=process.argv.includes('--mettronomo-level'),decrease=process.argv.includes('--decrease');
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=mettronomo?238273771:238273768,target=900000781,filler=900000782;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),r=db.prepare('select * from datas where id=?').get(boss);db.close();
 const base={alias:0,setcodes:[],type:33,level:3,attribute:1,race:1n,attack:300,defense:200,lscale:0,rscale:0,link_marker:0},results=[];
 const tests=[{member:true,full:false},{member:false,full:false},{member:true,full:true}];
 if(pendulum)tests.push({member:true,full:false,sameName:true},{member:true,full:false,otherZone:true});
 for(const test of tests){
  const {member,full,sameName,otherZone}=test,legal=member&&(mettronomo||!full)&&!sameName,logs=[],trace=[];
  const cards=new Map([[boss,{...base,code:boss,setcodes:[0x1066],type:Number(r.type),level:Number(r.level)&255,attribute:Number(r.attribute),race:BigInt(r.race),attack:Number(r.atk),defense:Number(r.def),lscale:(Number(r.level)>>>24)&255,rscale:(Number(r.level)>>>16)&255}],[target,{...base,code:target,setcodes:member?[0x1066]:[]}],[filler,{...base,code:filler}]]);
  const reader=name=>{if([target,filler].some(c=>name===`c${c}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8')};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  if(pendulum&&!full)cards.get(target).type|=0x1000000;
  if(mettronomo)cards.get(target).level=full?1:3;
  let failure=null,activated=false,placed=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position:P.FACEUP_ATTACK});add(boss,mettronomo?L.GRAVE:L.HAND);add(sameName?boss:target,pendulum?L.DECK:L.MZONE);if(otherZone)add(filler,L.SZONE,0,4);if(full&&!pendulum)for(let i=1;i<5;i++)add(filler,L.MZONE,0,i);for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<90&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(mettronomo&&p.type===M.SELECT_IDLECMD){
     const index=p.activates.findIndex(c=>c.code===boss&&String(c.description)===String(132273771*16+1));
     if(legal&&!activated){if(index<0)throw Error('GY adjustment unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(!legal&&index>=0)throw Error('GY adjustment offered without archetype target');
     if(legal){const m=core.duelQueryLocation(duel,{flags:Q.CODE|Q.LEVEL,controller:0,location:L.MZONE}),x=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.REMOVED});if(!x.some(c=>c?.code===boss)||!m.some(c=>c?.code===target&&c.level===(full?2:decrease?2:4)))throw Error('Banish cost/Level change mismatch');}
     done=true;continue;
    }
    if(pendulum&&p.type===M.SELECT_IDLECMD){
     if(!placed){const index=p.activates.findIndex(c=>c.code===boss&&c.location===L.HAND);if(index<0)throw Error('Pendulum placement unavailable');placed=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     const index=p.activates.findIndex(c=>c.code===boss&&String(c.description)===String(132273768*16));
     if(legal&&!activated){if(index<0)throw Error('Replacement unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(!legal&&index>=0)throw Error('Replacement offered for ineligible Deck card');
     if(legal){const z=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.SZONE}),x=core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:0,location:L.EXTRA});if(!z.some(c=>c?.code===target)||!x.some(c=>c?.code===boss&&(c.position&(P.FACEUP_ATTACK|P.FACEUP_DEFENSE))!==0))throw Error('Destruction/replacement mismatch');if(otherZone&&!z.some(c=>c?.code===filler))throw Error('Other occupied zone changed');}
     done=true;continue;
    }
    if(p.type===M.SELECT_IDLECMD){const index=p.activates.findIndex(c=>c.code===boss&&String(c.description)===String(132273768*16+1));if(legal&&!activated){if(index<0)throw Error('Hand effect unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}else{if(!legal&&index>=0)throw Error('Illegal hand effect offered');if(legal){const m=core.duelQueryLocation(duel,{flags:Q.CODE|Q.LEVEL,controller:0,location:L.MZONE});if(!m.some(c=>c?.code===boss)||!m.some(c=>c?.code===target&&c.level===4))throw Error('Level increase/Summon failed');}done=true;}}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===target);if(index<0)throw Error('Target unavailable');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:null});
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,4,1,2,3].find(i=>(p.field_mask&(1<<(8+i)))===0);}core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_OPTION&&mettronomo){if(full)throw Error('Level 1 target offered decrease');core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:decrease?1:0});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(e){failure=e.message}finally{core.destroyDuel(duel)}
  results.push({...test,failure,activated,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,`output/fresh-ccg-september/symphonic-${mettronomo?'mettronomo-level-'+(decrease?'down':'up'):'speeaker-'+(pendulum?'pendulum':'hand')}.json`),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',pendulum,mettronomo,decrease,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
