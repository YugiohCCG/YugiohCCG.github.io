'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=212413422,lab=900001210,filler=900001211,helper=900001212,helper2=900001213,helper3=900001214;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-count','no-renewal'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{renewal:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:test.spell?2:33,setcodes:test.wrongSet?[]:[0xbd]}],[filler,{...base,code:filler,type:2}],[helper,{...base,code:helper,type:2}],[helper2,{...base,code:helper2,type:33,setcodes:[0xbd]}],[helper3,{...base,code:helper3,type:2}]]);
 const reader=name=>{
 if(name==='c'+helper+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local g=Duel.GetMatchingGroup(function(c) return c:IsCode(${test.selfOnly?boss:lab}) ${test.multiple?'or c:IsCode('+helper2+')':''} end,tp,LOCATION_GRAVE,LOCATION_GRAVE,nil) Duel.Remove(g,${test.facedown?'POS_FACEDOWN':'POS_FACEUP'},REASON_EFFECT) end) c:RegisterEffect(e) end`;
 if([lab,filler,helper2].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
 const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,'Missing '+name);let lua=fs.readFileSync(file,'utf8');
 if(name==='c'+boss+'.lua'){
 if(control!=='raw-omega')lua=lua.replace('Duel.GetTargetsRelateToChain()','Duel.GetChainInfo(0,8):Filter(Card.IsRelateToEffect,nil,e)');
 if(control==='no-count')lua=lua.replace('e3:SetCountLimit(1,id+2)','do end');
 if(control==='no-renewal')lua=lua.replace('e3:SetCountLimit(1,id+2)','e3:SetCountLimit(1,id+2,2)');
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
 add(boss,test.selfOnly?L.GRAVE:L.REMOVED,0,P.FACEUP_ATTACK);add(boss,L.REMOVED,0,P.FACEUP_ATTACK);add(helper,L.HAND);add(helper,L.HAND);if(!test.selfOnly)add(lab,L.GRAVE,test.opponent?1:0,P.FACEUP_ATTACK);if(test.multiple)add(helper2,L.GRAVE,1,P.FACEUP_ATTACK);
 for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,controller,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 if(!activated){const index=p.activates.findIndex(c=>c.code===helper);assert(index>=0,'Actual flip fixture');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 const activations=trace.filter(m=>m.type===M.CHAINING&&m.code===boss).length;
 if(!second){assert.equal(activations,1,'First recovery trigger');assert.equal(query(L.DECK).filter(c=>c.code===boss).length,1);assert.equal(query(L.REMOVED).filter(c=>c.code===boss).length,1,'Second copy stays banished');assert(query(L.GRAVE).some(c=>c.code===lab),'First event card recovered');second=true;}
 if(!third){if(test.renewal&&turn<3){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}const index=p.activates.findIndex(c=>c.code===helper);assert(index>=0,'Second actual banish event');third=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 assert.equal(activations,test.renewal?2:1,'Recovery shared HOPT and next-own-turn refresh');const costs=query(L.DECK).filter(c=>c.code===boss);assert.equal(costs.length,test.renewal?2:1);assert(costs.every(c=>c.reason&128),'All source shuffles are costs');assert.equal(query(L.GRAVE).some(c=>c.code===lab),!!test.renewal,'Second banish event recovered only after renewal');done=true;
 }

 else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});
 else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===boss);core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
 else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x7f)!==0x7f,shift=isMonster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/gaia-iron-return-count'+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Gaia recovery shared HOPT with two actual source copies and separate native banish events; next own turn3 refresh. Test-only Omega related-target group enum8 adapter, native costs. No-renewal mutation uses public core third-argument flag2 for once-per-duel, test-only. Native Omega/effect independence open',control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});


