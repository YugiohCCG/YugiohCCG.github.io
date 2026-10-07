'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=211682274,lab=900001191,filler=900001192,spellCost=900001193,recipient=900001194,results=[];
 const control=process.argv.includes('--no-cost')?'no-cost':process.argv.includes('--no-count')?'no-count':null;
 for(const test of [{},{full:true},{wrongSet:true},{absent:true},{selfTarget:true},{count:true}]){
  const targetCode=test.selfTarget?boss:lab;
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:33,setcodes:test.wrongSet?[]:[0xf3c]}],[filler,{...base,code:filler}]]);
  const reader=name=>{
   if([lab,filler,spellCost,recipient].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){
    if(control==='no-count')lua=lua.replace('e2:SetCountLimit(1,id+1)','do end');
    if(control==='no-cost')lua=lua.replace('Duel.Release(e:GetHandler(),REASON_COST)','do end');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false,turn=0,secondary=false,placementStarted=false,placementFinished=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(boss,L.MZONE,0,P.FACEUP_ATTACK,0);if(!test.absent)add(targetCode,L.DECK);if(test.count){add(boss,L.MZONE,0,P.FACEUP_ATTACK,1);add(lab,L.DECK);}if(test.full)for(let i=1;i<5;i++)add(filler,L.MZONE,0,P.FACEUP_ATTACK,i);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,controller:0,location}).filter(Boolean);
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(!activated){if(test.full)assert.equal(query(L.MZONE).length,5,'Full board before activation');const index=p.activates.findIndex(c=>c.code===boss);assert.equal(index>=0,!test.wrongSet&&!test.absent&&!test.selfTarget,'Tribute effect availability');if(index<0){done=true;continue;}activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}const cost=query(L.GRAVE).find(c=>c.code===boss);assert(cost,'Actual source Tributed to GY');assert(cost.reason&2,'Native release reason');assert(cost.reason&0x80,'Tribute as COST');assert(query(L.MZONE).some(c=>c.code===lab),'Actual target summoned from Deck');assert.equal(query(L.DECK).filter(c=>c.code===lab).length,test.count?1:0,'Deck target remainder');if(test.full)assert.equal(query(L.MZONE).length,5,'Freed source zone filled by target');if(test.count){assert.equal(query(L.MZONE).filter(c=>c.code===boss).length,1,'Second full-production source retained');if(turn===1)assert(!p.activates.some(c=>c.code===boss),'Shared Tribute limit blocks second copy with legal Deck target');if(turn<3){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}assert(p.activates.some(c=>c.code===boss),'Tribute available next own turn');}done=true;}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===lab);assert(index>=0,'Actual Deck summon choice');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_CHAIN){const index=-1;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/aquamarine-pisaster-tribute'+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:null,engine:'Public OCGCore, full production Pisaster Giga/candidate metadata; neutral supporting cards. Actual production Tribute cost then Deck summon, neutral target; native Omega unverified; no native Omega certification.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(c=>c.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
