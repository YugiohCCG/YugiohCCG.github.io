'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=212052682,lab=900001210,filler=900001211,helper=900001212,helper2=900001213,helper3=900001214;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['raw-omega','no-level','any-set'].find(c=>process.argv.includes('--'+c));
 for(const test of [{level:1},{level:4},{level:2,multiple:true},{level:3,wrongSet:true},{level:3,xyz:true},{level:3,link:true},{level:3,facedown:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const wanted=test.spell?61089209:test.trap?7574904:34695290,other=wanted===34695290?61089209:34695290;
 const revealed=test.selfReveal?wanted:lab;
 const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:test.xyz?0x800021:test.link?0x4000021:33,level:test.xyz?4:test.link?1:2,link_marker:test.link?2:0,setcodes:test.wrongSet?[]:[0x8d]}],[filler,{...base,code:filler,type:2}],[helper,{...base,code:helper,type:2}],[helper2,{...base,code:helper2,type:33}],[helper3,{...base,code:helper3,type:2}]]);
 const reader=name=>{
 if(name==='c'+helper+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) Duel.ChangePosition(Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,${boss}),POS_FACEUP_DEFENSE) end) c:RegisterEffect(e) end`;
 if([lab,filler,helper2].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
 const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,'Missing '+name);let lua=fs.readFileSync(file,'utf8');
 if(name==='c'+boss+'.lua'){
 if(control!=='raw-omega')lua=lua.replace('c:IsHasLevel()','(not c:IsType(TYPE_XYZ+TYPE_LINK) and not c:IsStatus(STATUS_NO_LEVEL))').replace('Duel.AnnounceLevel(tp,1,4)','Duel.AnnounceNumber(tp,1,2,3,4)').replace('Duel.GetChainInfo(0,CHAININFO_TARGET_CARDS)','Duel.GetChainInfo(0,8)');
 if(control==='no-level')lua=lua.replace('tc:RegisterEffect(e1)','do end');
 if(control==='any-set')lua=lua.replace('c:IsFaceup() and c:IsSetCard(SET_GHOSTRICK) and (not c:IsType(TYPE_XYZ+TYPE_LINK) and not c:IsStatus(STATUS_NO_LEVEL))','c:IsFaceup() and (not c:IsType(TYPE_XYZ+TYPE_LINK) and not c:IsStatus(STATUS_NO_LEVEL))');
 }return lua;
 };
 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 add(boss,L.MZONE,0,P.FACEDOWN_DEFENSE);add(helper,L.HAND);add(lab,L.MZONE,0,test.facedown?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK,1);
 for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.LEVEL,controller:0,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 if(!activated){const index=p.activates.findIndex(c=>c.code===helper);assert(index>=0,'Actual flip fixture');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 const eligible=!test.wrongSet&&!test.xyz&&!test.link&&!test.facedown;
 assert(trace.some(m=>m.type===M.CHAINING&&m.code===boss),'Actual flip trigger activates');assert.equal(query(L.MZONE).find(c=>c.code===boss).level,test.level,'Source can be selected and changed');assert.equal(query(L.MZONE).find(c=>c.code===lab).level,eligible&&test.multiple?test.level:test.xyz||test.link?0:2,'Only selected legal Ghostrick level changes');done=true;
 }

 else if(p.type===M.SELECT_CARD){const eligible=!test.wrongSet&&!test.xyz&&!test.link&&!test.facedown;assert.equal(p.selects.some(c=>c.code===lab),eligible,'Face-up Ghostrick with Level target eligibility');const indices=p.selects.map((c,i)=>c.code===boss||test.multiple&&c.code===lab?i:-1).filter(i=>i>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:indices});}
 else if(p.type===M.ANNOUNCE_NUMBER){const index=p.options.findIndex(n=>Number(n)===test.level);assert(index>=0,'Declared Level allowed');core.duelSetResponse(duel,{type:R.ANNOUNCE_NUMBER,value:index});}

 else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});
 else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===boss);core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
 else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x7f)!==0x7f,shift=isMonster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/ghostrick-djinn-flip'+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Full Djinn flip effect after actual position change; neutral Ghostrick candidates/native queried levels. Test-only IsHasLevel->explicit non-Xyz/non-Link/no-level-status check for these fixtures, AnnounceLevel->AnnounceNumber and target group enum8 translations unless raw-omega. Production Omega APIs preserved. Native Omega/unselected interruptions unverified',control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});


