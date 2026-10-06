'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=212413422,lab=900001210,filler=900001211,helper=900001212,helper2=900001213,helper3=900001214;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-summon','any-race','allow-facedown','own-only','no-count'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{opponent:true},{facedown:true},{opponent:true,facedown:true},{wrongRace:true},{absent:true},{full:true},{count:true},{count:true,renewal:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:33,race:test.wrongRace?1n:8192n,setcodes:[]}],[filler,{...base,code:filler,type:2}],[helper,{...base,code:helper,type:2}],[helper2,{...base,code:helper2,type:33}],[helper3,{...base,code:helper3,type:2}]]);
 const reader=name=>{
 if([lab,filler,helper2].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
 const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,'Missing '+name);let lua=fs.readFileSync(file,'utf8');
 if(name==='c'+boss+'.lua'){
 if(control==='no-count')lua=lua.replace('e1:SetCountLimit(1,id)','do end');
 if(control==='no-summon')lua=lua.replace('Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)','do end');
 if(control==='any-race')lua=lua.replace('c:IsFaceup() and c:IsRace(RACE_DRAGON)','c:IsFaceup()');
 if(control==='allow-facedown')lua=lua.replace('c:IsFaceup() and c:IsRace(RACE_DRAGON)','c:IsRace(RACE_DRAGON)');
 if(control==='own-only')lua=lua.replace('s.drgfilter,tp,LOCATION_MZONE,LOCATION_MZONE','s.drgfilter,tp,LOCATION_MZONE,0');
 }return lua;
 };
 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 add(boss,L.HAND);if(test.count)add(boss,L.HAND);if(!test.absent)add(lab,L.MZONE,test.opponent?1:0,test.facedown?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK);
 if(test.full)for(let i=1;i<5;i++)add(helper2,L.MZONE,0,P.FACEUP_ATTACK,i);
 for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:0,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 const eligible=!test.facedown&&!test.wrongRace&&!test.absent&&!test.full;
 if(!activated){const index=p.activates.findIndex(c=>c.code===boss);assert.equal(index>=0,eligible,'Face-up Dragon on either field and free zone');if(!eligible){assert(query(L.HAND).some(c=>c.code===boss));done=true;continue;}activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 assert(trace.some(m=>m.type===M.CHAINING&&m.code===boss),'Actual Gaia effect activation');assert.equal(query(L.MZONE).filter(c=>c.code===boss).length,third?2:1,'Actual hand Special Summon');assert.equal(query(L.HAND).filter(c=>c.code===boss).length,test.count&&!third?1:0);const move=trace.find(m=>m.type===M.MOVE&&m.card===boss&&m.to.location===L.MZONE);assert.equal(move.from.location,L.HAND);assert(move.to.position&P.FACEUP);
 if(test.count&&!third){const index=p.activates.findIndex(c=>c.code===boss);if(turn===1){assert.equal(index,-1,'Shared HOPT blocks second copy');if(!test.renewal){done=true;continue;}}
 if(turn<3){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}assert(index>=0,'HOPT renews next own turn');third=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 done=true;
 }

 else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===lab);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
 else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});
 else if(p.type===M.SELECT_CHAIN){const index=-1;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
 else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x7f)!==0x7f,shift=isMonster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/gaia-iron-hand'+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Full production Gaia/canonical metadata hand ignition with native actual Special Summon, face-up Dragon on either field/full zone negatives. Neutral supporting monsters, no Extra Deck, no adapters. Other effects/count/native Omega unverified',control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});


