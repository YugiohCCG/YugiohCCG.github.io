'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=212413422,lab=900001210,filler=900001211,helper=900001212,helper2=900001213,helper3=900001214;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['raw-omega','no-cost','no-return','any-set','allow-facedown','any-type'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{opponent:true},{multiple:true},{wrongSet:true},{spell:true},{facedown:true},{selfOnly:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:test.spell?2:33,setcodes:test.wrongSet?[]:[0xbd]}],[filler,{...base,code:filler,type:2}],[helper,{...base,code:helper,type:2}],[helper2,{...base,code:helper2,type:33,setcodes:[0xbd]}],[helper3,{...base,code:helper3,type:2}]]);
 const reader=name=>{
 if(name==='c'+helper+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local g=Duel.GetMatchingGroup(function(c) return c:IsCode(${test.selfOnly?boss:lab}) ${test.multiple?'or c:IsCode('+helper2+')':''} end,tp,LOCATION_GRAVE,LOCATION_GRAVE,nil) Duel.Remove(g,${test.facedown?'POS_FACEDOWN':'POS_FACEUP'},REASON_EFFECT) end) c:RegisterEffect(e) end`;
 if([lab,filler,helper2].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
 const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,'Missing '+name);let lua=fs.readFileSync(file,'utf8');
 if(name==='c'+boss+'.lua'){
 if(control!=='raw-omega')lua=lua.replace('Duel.GetTargetsRelateToChain()','Duel.GetChainInfo(0,8):Filter(Card.IsRelateToEffect,nil,e)');
 if(control==='no-cost')lua=lua.replace('Duel.SendtoDeck(c,tp,SEQ_DECKSHUFFLE,REASON_COST)','do end');
 if(control==='no-return')lua=lua.replace('Duel.SendtoGrave(g,REASON_EFFECT+REASON_RETURN)','do end');
 if(control==='any-set')lua=lua.replace('c:IsSetCard(0xbd) and c~=hc','c~=hc');
 if(control==='allow-facedown')lua=lua.replace('c:IsFaceup() and c:IsType(TYPE_MONSTER) and c:IsSetCard(0xbd) and c~=hc','c:IsType(TYPE_MONSTER) and c:IsSetCard(0xbd) and c~=hc');
 if(control==='any-type')lua=lua.replace('c:IsFaceup() and c:IsType(TYPE_MONSTER) and c:IsSetCard(0xbd) and c~=hc','c:IsFaceup() and c:IsSetCard(0xbd) and c~=hc');
 }return lua;
 };
 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 add(boss,test.selfOnly?L.GRAVE:L.REMOVED,0,P.FACEUP_ATTACK);add(helper,L.HAND);if(!test.selfOnly)add(lab,L.GRAVE,test.opponent?1:0,P.FACEUP_ATTACK);if(test.multiple)add(helper2,L.GRAVE,1,P.FACEUP_ATTACK);
 for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,controller,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 if(!activated){const index=p.activates.findIndex(c=>c.code===helper);assert(index>=0,'Actual flip fixture');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 const eligible=!test.wrongSet&&!test.spell&&!test.facedown&&!test.selfOnly;
 assert.equal(trace.some(m=>m.type===M.CHAINING&&m.code===boss),eligible,'Other Gaia monster banish event only');
 if(eligible){const source=query(L.DECK).find(c=>c.code===boss);assert(source,'Source shuffled into Deck');assert(source.reason&128,'Shuffle paid as cost');const target=query(L.GRAVE,test.opponent?1:0).find(c=>c.code===lab);assert(target,'Event target returned to GY');assert(target.reason&64,'Return as effect');if(test.multiple)assert(query(L.GRAVE,1).some(c=>c.code===helper2),'All newly banished Gaia monsters returned');}
 else assert(query(L.REMOVED).some(c=>c.code===boss),'Source stays banished');done=true;
 }

 else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});
 else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===boss);core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
 else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x7f)!==0x7f,shift=isMonster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/gaia-iron-return'+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Gaia banished recovery after actual native helper banishes own/opponent/multiple cards; native Deck/GY moves and reasons. Test-only GetTargetsRelateToChain->native related target group enum8 unless raw-omega. Production Omega API retained. Native Omega/count/interruptions open',control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});


