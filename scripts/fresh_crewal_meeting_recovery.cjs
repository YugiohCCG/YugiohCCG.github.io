'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=210366076,lab=900001191,filler=900001192,spellCost=900001193,recipient=900001194,results=[];
 const control=process.argv.includes('--shared-effects')?'shared-effects':process.argv.includes('--no-cost')?'no-cost':process.argv.includes('--zombie-only')?'zombie-only':process.argv.includes('--any-card')?'any-card':process.argv.includes('--allow-self')?'allow-self':process.argv.includes('--no-count')?'no-count':null;
 for(const test of [{},{crewal:true},{crewal:true,spell:true},{wrongRace:true},{absent:true},{secondCopy:true},{count:true},{independent:true}]){
  const targetCode=test.secondCopy?boss:lab;
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:test.spell?2:33,level:test.spell?0:test.independent?5:2,race:test.crewal||test.wrongRace?1n:16n,setcodes:test.crewal?[0xe2f]:[]}],[filler,{...base,code:filler}]]);
  cards.set(spellCost,{...base,code:spellCost,type:test.costSpell?0x20002:test.normalTrap?4:0x20004});cards.set(recipient,{...base,code:recipient});
  const reader=name=>{
   if([lab,filler,spellCost,recipient].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){
    if(control==='shared-effects')lua=lua.replace('e2:SetCountLimit(1,id+100)','e2:SetCountLimit(1,id)');if(control==='no-count')lua=lua.replace('e2:SetCountLimit(1,id+100)','do end');if(control==='allow-self')lua=lua.replace('LOCATION_GRAVE,0,1,e:GetHandler())','LOCATION_GRAVE,0,1,nil)');if(control==='no-cost')lua=lua.replace('e2:SetCost(aux.bfgcost)','do end');if(control==='zombie-only')lua=lua.replace('(c:IsSetCard(SET_CREWAL) or c:IsRace(RACE_ZOMBIE))','c:IsRace(RACE_ZOMBIE)');if(control==='any-card')lua=lua.replace('(c:IsSetCard(SET_CREWAL) or c:IsRace(RACE_ZOMBIE))','true');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false,turn=0,secondary=false,placementStarted=false,placementFinished=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position});
   add(boss,test.independent?L.HAND:L.GRAVE,0,P.FACEUP_ATTACK);if(test.independent){add(spellCost,L.SZONE,0,P.FACEUP_ATTACK);add(lab,L.DECK);}if(test.count){add(boss,L.GRAVE,0,P.FACEUP_ATTACK);add(lab,L.GRAVE,0,P.FACEUP_ATTACK);}if(!test.absent)add(targetCode,L.GRAVE,0,P.FACEUP_ATTACK);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,controller:0,location}).filter(Boolean);
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(test.independent&&!placementFinished){if(!placementStarted){const index=p.activates.findIndex(c=>c.code===boss&&c.location===L.HAND);assert(index>=0,'Placement initially available');placementStarted=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}assert(query(L.SZONE).some(c=>c.code===lab),'Actual first placement');assert(query(L.GRAVE).some(c=>c.code===spellCost&&(c.reason&0x80)),'Actual placement cost');assert(query(L.GRAVE).some(c=>c.code===boss),'Resolved Meeting in GY');placementFinished=true;}if(!activated){const index=p.activates.findIndex(c=>c.code===boss);assert.equal(index>=0,!test.wrongRace&&!test.absent,'Recovery availability');if(index<0){done=true;continue;}activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}if(test.independent)assert.equal(turn,1,'Both effects resolve same own turn');assert(query(L.HAND).some(c=>c.code===targetCode),'Actual target recovered to hand');const source=query(L.REMOVED).find(c=>c.code===boss);assert(source,'Meeting banished from GY');assert(source.reason&0x80,'Actual banishment cost');if(test.count){assert.equal(query(L.GRAVE).filter(c=>c.code===boss).length,1,'Second full Meeting retained');assert(query(L.GRAVE).some(c=>c.code===lab),'Second legal target retained');if(turn===1)assert(!p.activates.some(c=>c.code===boss),'Shared recovery HOPT blocks second copy');if(turn<3){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}assert(p.activates.some(c=>c.code===boss),'Recovery renewed next own turn');}else assert(!query(L.GRAVE).some(c=>c.code===boss),'Meeting left GY');done=true;}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===(test.independent&&!placementFinished? (p.selects.some(c=>c.code===spellCost)?spellCost:lab):targetCode));assert(index>=0,'Lab selection');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:L.SZONE,sequence}]});}
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/crewal-meeting-recovery'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public OCGCore, full production Crewal Meeting/candidate metadata; neutral recovery targets. Actual source GY banishment cost and Crewal/Zombie targeting/recovery; no native Omega certification.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(c=>c.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
