'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=213849997,lab=900001210,filler=900001211,helper=900001212,helper2=process.argv.includes('--official')?Number(process.argv.find(a=>a.startsWith('--recipient='))?.split('=')[1]||15989522):900001213,helper3=900001214;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-relation','no-interruption'].find(c=>process.argv.includes('--'+c));
 for(const test of [{mode:'leave'},{mode:'return'},{mode:'facedown'},{mode:'negate'}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:test.spell?2:33,attribute:2,setcodes:test.wrongSet?[]:[0xc1c]}],[filler,{...base,code:filler,type:2}],[helper,{...base,code:helper,type:2}],[helper2,{...base,code:helper2,type:65,attack:1000,setcodes:[]}],[helper3,{...base,code:helper3,type:2}]]);
 cards.set(helper2,{...base,code:helper2,type:33,attack:1000});cards.set(lab,{...base,code:lab,type:33,setcodes:[0xc1c],attack:test.tie?2000:test.opponentHighest?100:3000});cards.set(helper3,{...base,code:helper3,type:33,attack:2000});
 cards.set(helper,{...base,code:helper,type:4});
 const reader=name=>{
 if(name==='c'+helper+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_CHAINING) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${boss}) end) e:SetOperation(function(e,tp,eg,ep,ev) ${control==='no-interruption'?'do end':test.mode==='negate'?'Duel.NegateEffect(ev)':`local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_MZONE,0,nil,${helper2}) ${test.mode==='facedown'?'Duel.ChangePosition(tc,POS_FACEDOWN_DEFENSE)':`Duel.Remove(tc,POS_FACEUP,REASON_EFFECT+REASON_TEMPORARY) ${test.mode==='return'?'Duel.ReturnToField(tc)':''}`}`} end) c:RegisterEffect(e) end`;

 if([240299293,246380598].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';
 if(name==='c'+helper2+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_UPDATE_ATTACK) e:SetProperty(EFFECT_FLAG_SINGLE_RANGE) e:SetRange(LOCATION_MZONE) e:SetValue(500) c:RegisterEffect(e) end';
 if([lab,filler,helper3].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
 const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,'Missing '+name);let lua=fs.readFileSync(file,'utf8');
 if(name==='c'+boss+'.lua'&&control==='no-relation')lua=lua.replace('tc:IsRelateToEffect(e)','true');

 // TEST ONLY public-engine adapter for Omega faceup banishment API, needed for post-activation GY availability checks.
 if(name==='c'+boss+'.lua')lua=lua.replaceAll('c:IsFaceupEx()','(not c:IsLocation(LOCATION_REMOVED) or c:IsFaceup())');
 return lua;
 };
 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 add(helper,L.SZONE,1);add(boss,L.SZONE);add(helper2,L.MZONE,test.ownTarget?0:1,P.FACEUP_ATTACK,0);add(lab,L.MZONE,0,P.FACEUP_ATTACK,2);add(helper3,L.MZONE,1,test.facedownOther?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK,1);

 for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.ATTACK|Q.LEVEL|Q.POSITION,controller,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 if(!activated){const index=p.activates.findIndex(c=>c.code===boss&&Number(c.description)===133849997*16);assert(index>=0,'Trap activation');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 assert(third,'Interruption activated');assert(trace.some(m=>m.type===M.CHAINING&&m.code===helper&&m.chain_size===2),'Native Trap CL2');
 const target=query(L.MZONE,1).find(c=>c.code===helper2);
 if(test.mode==='leave')assert(!target&&query(L.REMOVED,1).some(c=>c.code===helper2),'Target removed');
 else if(test.mode==='facedown')assert(target.position&P.FACEDOWN_DEFENSE,'Target turned facedown');
 else assert.equal(target.attack,1500,'Target effect remains active');
 assert(query(L.MZONE,1).some(c=>c.code===helper3),'Follow-up destruction blocked');assert(!query(L.GRAVE,1).some(c=>c.code===helper3),'Other enemy not destroyed');done=true;

 }

 else if(p.type===M.SELECT_UNSELECT_CARD){const index=p.select_cards.findIndex(c=>c.code===240299293);core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index:index>=0?index:null});}
 else if(p.type===M.SELECT_CARD){let index=p.selects.findIndex(c=>c.code===helper2);if(index<0)index=p.selects.findIndex(c=>c.code===helper2);if(index<0)index=0;core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
 else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});
 else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.send?1:0});
 else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});
 else if(p.type===M.SELECT_CHAIN){let index=-1;if(activated&&p.player===1&&!third){index=p.selects.findIndex(c=>c.code===helper);if(index>=0)third=true;}core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
 else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x7f)!==0x7f,shift=isMonster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/checkmate-aldrez-interrupt'+(process.argv.includes('--official')?'-official-'+helper2:'')+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Full Checkmate native Trap CL1/opponent Trap CL2 removes/returns target, turns facedown, or negates effect. Negation/follow-up massdestroy blocked. Test-only IsFaceupEx adapter. Count/native Omega open',recipient:process.argv.includes('--official')?helper2:null,control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});


