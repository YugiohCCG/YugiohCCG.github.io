'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=255283389,lab=34572613,filler=900001181,spellCost=900001182,recipient=8200556,results=[];
 const control=process.argv.includes('--faceup-only')?'faceup-only':process.argv.includes('--allow-facedown')?'allow-facedown':process.argv.includes('--no-cost')?'no-cost':process.argv.includes('--no-count')?'no-count':process.argv.includes('--shared-effects')?'shared-effects':null;
 for(const test of [{},{removed:true},{facedown:true},{absent:true},{count:true},{independent:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:0x80002,level:0}],[filler,{...base,code:filler}]]);
  cards.set(spellCost,{...base,code:spellCost,type:2});cards.set(recipient,{...base,code:recipient});
  const reader=name=>{
   if([lab,filler,spellCost,recipient].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){
    if(control==='faceup-only')lua=lua.replace('(c:IsLocation(LOCATION_DECK) or c:IsFaceup())','c:IsFaceup()');
    if(control==='allow-facedown')lua=lua.replace('(c:IsLocation(LOCATION_DECK) or c:IsFaceup())','true');
    if(control==='shared-effects')lua=lua.replace('e2:SetCountLimit(1,id+100)','e2:SetCountLimit(1,id)');if(control==='no-count')lua=lua.replace('e1:SetCountLimit(1,id)','do end');if(control==='no-cost')lua=lua.replace('e1:SetCost(aux.bfgcost)','do end');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false,turn=0,secondary=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position});
   add(boss,L.HAND);if(test.independent){add(boss,L.MZONE,0,P.FACEUP_ATTACK);add(spellCost,L.HAND);add(recipient,L.DECK);}if(test.count){add(boss,L.HAND);if(test.independent){add(boss,L.MZONE,0,P.FACEUP_ATTACK);add(spellCost,L.HAND);add(recipient,L.DECK);}add(lab,L.DECK);}if(!test.absent)add(lab,test.removed||test.facedown?L.REMOVED:L.DECK,0,test.removed?P.FACEUP_ATTACK:P.FACEDOWN_DEFENSE);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,controller:0,location}).filter(Boolean);
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(!activated){const index=p.activates.findIndex(c=>c.code===boss);assert.equal(index>=0,!test.facedown&&!test.absent,'Search availability');if(index<0){assert(query(L.HAND).some(c=>c.code===boss),'Unused source retained');done=true;continue;}activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}assert(query(L.HAND).some(c=>c.code===lab),'Actual Lab added to hand');const source=query(L.REMOVED).find(c=>c.code===boss);assert(source,'Source banished from hand');assert(source.reason&0x80,'Banishment is cost');if(test.independent){if(!secondary){const index=p.activates.findIndex(c=>c.code===boss);assert(index>=0,'Separate summon count remains available after search');secondary=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}assert(query(L.MZONE).some(c=>c.code===recipient),'Actual separate ST-46 summon');const paid=query(L.REMOVED).find(c=>c.code===spellCost);assert(paid,'Separate summon cost paid');assert(paid.reason&0x80,'Separate summon COST');}if(test.count){assert.equal(query(L.HAND).filter(c=>c.code===boss).length,1,'Second full source retained');assert(query(L.DECK).some(c=>c.code===lab),'Second legal Lab remains');if(turn===1)assert(!p.activates.some(c=>c.code===boss),'Shared search HOPT blocks second copy');if(turn<3){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}assert(p.activates.some(c=>c.code===boss),'Search renewed next own turn');}else assert(!query(L.HAND).some(c=>c.code===boss),'Source left hand');done=true;}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===spellCost||c.code===lab||c.code===recipient);assert(index>=0,'Lab selection');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/myutant-el51-search'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public OCGCore, full production EL-51/candidate metadata; neutral Evolution Lab script. Actual hand banishment cost and Deck/face-up banishment recovery. Native Omega/full second effect unverified.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(c=>c.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
