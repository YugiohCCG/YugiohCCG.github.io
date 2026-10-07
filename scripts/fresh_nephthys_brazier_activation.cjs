'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=238276251,low=900000861,high=900000862,victim=900000863,enemy=900000864,filler=900000865;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),row=db.prepare('select * from datas where id=?').get(boss);db.close();
 const base={alias:0,setcodes:[],type:33,level:2,attribute:8,race:2n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0},results=[];
 for(const test of [{},{grave:true},{decline:true},{wrongLow:true},{wrongHigh:true},{noVictim:true},{recoverVictim:true},{noHigh:true}]){
  const offer=!test.wrongLow&&!test.wrongHigh&&!test.noVictim&&!test.noHigh,resolve=offer&&!test.decline,logs=[],trace=[],cards=new Map([[boss,{...base,code:boss,setcodes:[0x11f],type:Number(row.type),level:0}],[low,{...base,code:low,setcodes:[0x11f],level:test.wrongLow?3:2}],[high,{...base,code:high,setcodes:[0x11f],level:test.wrongHigh?7:8}],[victim,{...base,code:victim,setcodes:test.recoverVictim?[0x11f]:[]}],[enemy,{...base,code:enemy}],[filler,{...base,code:filler}]]);
  const reader=name=>{if([low,high,victim,enemy,filler].some(c=>name===`c${c}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8')};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,optional=false,triggered=false,done=false,selections=0;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});add(boss,L.HAND);if(!test.noVictim)add(boss,L.HAND);if(!test.noVictim)add(victim,L.HAND);if(!test.recoverVictim)add(low,test.grave?L.GRAVE:L.DECK);if(!test.noHigh)add(high,test.grave?L.GRAVE:L.DECK);add(enemy,L.MZONE,1);for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<120&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){const index=p.activates.findIndex(c=>c.code===boss&&c.location===L.HAND);if(!activated){if(index<0)throw Error('Continuous Spell activation missing');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}if(index>=0)throw Error('Second activation bypassed shared count');if(optional!==offer)throw Error('Optional search legality mismatch');const h=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.HAND}),g=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.GRAVE}),opp=core.duelQueryLocation(duel,{flags:Q.CODE,controller:1,location:L.GRAVE});if(resolve){if(!h.some(c=>c?.code===(test.recoverVictim?victim:low))||!h.some(c=>c?.code===high))throw Error('Required two-card search failed');if(!test.recoverVictim&&!g.some(c=>c?.code===victim))throw Error('Victim not destroyed');if(test.recoverVictim&&!opp.some(c=>c?.code===enemy))throw Error('Destruction trigger did not resolve');}else if(!test.noVictim&&!h.some(c=>c?.code===victim))throw Error('Victim destroyed without optional effect');done=true;}
    else if(p.type===M.SELECT_YESNO){if(optional)throw Error('Repeated optional prompt');optional=true;core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});}
    else if(p.type===M.SELECT_EFFECTYN){triggered=true;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});}
    else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===boss&&String(c.description)===String(132276251*16+1));if(index>=0)triggered=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index<0?null:index});}
    else if(p.type===M.SELECT_CARD){const wanted=triggered?enemy:selections===0?victim:selections===1?(test.recoverVictim?victim:low):high,index=p.selects.findIndex(c=>c.code===wanted);if(index<0)throw Error('Candidate missing '+wanted);selections++;core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:L.SZONE,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(e){failure=e.message}finally{core.destroyDuel(duel)}
  results.push({...test,failure,optional,triggered,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/nephthys-brazier-activation.json'),JSON.stringify({engine:'public OCGCore with complete production Brazier; neutral companion monsters; not native Omega',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
