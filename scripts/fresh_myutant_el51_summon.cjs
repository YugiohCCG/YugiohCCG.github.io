'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=255283389,m05=62201847,st46=8200556,cost=900001182,filler=900001181,results=[];
 const control=process.argv.includes('--wrong-branch')?'wrong-branch':process.argv.includes('--no-cost')?'no-cost':process.argv.includes('--hand-only')?'hand-only':process.argv.includes('--allow-facedown')?'allow-facedown':process.argv.includes('--no-count')?'no-count':null;
 for(const test of [{},{spell:true},{trap:true},{field:true},{field:true,spell:true},{field:true,full:true},{spell:true,full:true},{noMatching:true},{field:true,spell:true,facedown:true},{count:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
  const wanted=test.spell||test.trap?st46:m05,other=wanted===m05?st46:m05;
  const cards=new Map([[boss,candidateCard(boss)],[m05,{...base,code:m05}],[st46,{...base,code:st46}],[cost,{...base,code:cost,type:test.spell?2:test.trap?4:17}],[filler,{...base,code:filler}]]);
  const reader=name=>{
   if([m05,st46,cost,filler].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){
    if(control==='no-count')lua=lua.replace('e2:SetCountLimit(1,id+100)','do end');if(control==='wrong-branch')lua=lua.replace('local code=(e:GetLabel()&TYPE_MONSTER)~=0 and M05 or ST46','local code=(e:GetLabel()&TYPE_MONSTER)~=0 and ST46 or M05');if(control==='no-cost')lua=lua.replace('Duel.Remove(tc,POS_FACEUP,REASON_COST)','do end');if(control==='hand-only')lua=lua.replaceAll('LOCATION_HAND+LOCATION_ONFIELD','LOCATION_HAND');if(control==='allow-facedown')lua=lua.replace('(c:IsLocation(LOCATION_HAND) or c:IsFaceup())','true');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false,turn=0;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(boss,L.MZONE,0,P.FACEUP_ATTACK);if(test.count){add(boss,L.MZONE,0,P.FACEUP_ATTACK,1);add(cost,L.HAND);add(wanted,L.DECK);}add(cost,test.field?(test.spell||test.trap?L.SZONE:L.MZONE):L.HAND,0,test.facedown?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK,test.field&&!test.spell&&!test.trap?1:0);if(test.full)for(let i=test.field&&!test.spell&&!test.trap?2:1;i<5;i++)add(filler,L.MZONE,0,P.FACEUP_ATTACK,i);add(test.noMatching?other:wanted,L.DECK);if(!test.noMatching&&!test.facedown&&!(test.full&&!test.field))add(other,L.DECK);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,controller:0,location}).filter(Boolean);
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(!activated){const index=p.activates.findIndex(c=>c.code===boss);assert.equal(index>=0,!test.noMatching&&!test.facedown&&!(test.full&&!test.field),'Summon availability');if(index<0){assert(query(L.MZONE).some(c=>c.code===boss),'Unused source retained');done=true;continue;}activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}assert(query(L.MZONE).some(c=>c.code===wanted),'Correct actual recipient summoned');assert(!query(L.MZONE).some(c=>c.code===other),'Wrong branch not summoned');const paid=query(L.REMOVED).find(c=>c.code===cost);assert(paid,'Selected card actually banished');assert(paid.reason&0x80,'Banishment COST');const move=trace.find(m=>m.type===M.MOVE&&m.card===cost&&m.to.location===L.REMOVED);assert.equal(move.from.location,test.field?(test.spell||test.trap?L.SZONE:L.MZONE):L.HAND,'Actual cost origin');if(test.count){assert.equal(query(L.MZONE).filter(c=>c.code===boss).length,2,'Both full production sources retained');assert(query(L.HAND).some(c=>c.code===cost),'Second legal hand cost retained');assert(query(L.DECK).some(c=>c.code===wanted),'Second legal recipient retained');if(turn===1)assert(!p.activates.some(c=>c.code===boss),'Shared summon HOPT blocks second copy');if(turn<3){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}assert(p.activates.some(c=>c.code===boss),'Summon renewed next own turn');}done=true;}
    else if(p.type===M.SELECT_CARD){let index=p.selects.findIndex(c=>c.code===cost||c.code===wanted);if(index<0)index=p.selects.findIndex(c=>c.code===other);assert(index>=0,'Legal branch or cost selection');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/myutant-el51-summon'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public OCGCore, full production EL-51/candidate metadata; neutral recipient/cost scripts. Actual hand/field cost banishment, M-05 versus ST-46 and full-zone legality. Native Omega/HOPT/recipient production effects unverified.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(c=>c.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
