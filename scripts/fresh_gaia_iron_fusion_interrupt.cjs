'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=212413422,lab=900001210,filler=900001211,helper=900001212,helper2=process.argv.includes('--official')?Number(process.argv.find(a=>a.startsWith('--recipient='))?.split('=')[1]||15989522):900001213,helper3=900001214;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['ignore-target','ignore-source','ignore-instance'].find(c=>process.argv.includes('--'+c));
 for(const test of [{mode:'target-leave'},{mode:'target-return'},{mode:'source-leave'},{mode:'source-return'},{mode:'negate'}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:33,race:test.wrongRace?1n:8192n,setcodes:[]}],[filler,{...base,code:filler,type:2}],[helper,{...base,code:helper,type:2}],[helper2,{...base,code:helper2,type:65,attack:1000,setcodes:[]}],[helper3,{...base,code:helper3,type:33}]]);
 const reader=name=>{
 if(name==='c'+helper+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) Duel.SpecialSummon(Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_HAND,0,nil,${boss}),0,tp,tp,false,false,POS_FACEUP) end) c:RegisterEffect(e) end`;
 if(name==='c'+helper2+'.lua'&&!process.argv.includes('--official'))return `local s,id=GetID() s.material_setcode=${test.wrongMaterial?'0x8d':'0xbd'} function s.initial_effect(c) end`;
 if(name==='c'+helper3+'.lua'){
 const moved=test.mode.startsWith('source')?boss:lab;
 const op=test.mode==='negate'?'Duel.NegateEffect(ev)':`local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_MZONE,nil,${moved}) Duel.SendtoHand(tc,nil,REASON_EFFECT) ${test.mode.endsWith('return')?'Duel.SpecialSummon(tc,0,1-tp,1-tp,false,false,POS_FACEUP_ATTACK)':''}`;
 return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_QUICK_O) e:SetCode(EVENT_CHAINING) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${boss}) end) e:SetOperation(function(e,tp,eg,ep,ev,re) ${op} end) c:RegisterEffect(e) end`;
 }
 if([lab,filler].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
 const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,'Missing '+name);let lua=fs.readFileSync(file,'utf8');
 if(name==='c'+boss+'.lua'){
 if(control==='ignore-instance')lua=lua.replace(' and c:GetFieldID()==e:GetLabel()','');
 if(control==='ignore-target')lua=lua.replace('tc and tc:IsRelateToEffect(e) and aux.NecroValleyFilter()(tc)','tc and aux.NecroValleyFilter()(tc)');
 if(control==='ignore-source')lua=lua.replace('c:IsRelateToEffect(e) and tc and tc:IsRelateToEffect(e)','tc and tc:IsRelateToEffect(e)');
 if(control==='no-legacy')lua=lua.replace(' or code==15989522 or code==2519690 or code==66889139','');
 if(control==='no-banish')lua=lua.replace('Duel.Remove(rg,POS_FACEUP,REASON_EFFECT)==2','true');
 if(control==='no-summon')lua=lua.replace('Duel.SpecialSummon(sc,0,tp,tp,false,false,POS_FACEUP)>0','false');
 if(control==='no-boost')lua=lua.replace('e1:SetValue(2600)','e1:SetValue(0)');
 if(control==='no-expiry')lua=lua.replace('RESETS_STANDARD+RESET_PHASE+PHASE_END','RESETS_STANDARD');
 if(control==='any-fusion')lua=lua.replace('and s.gaiafusion(c)','and true');
 }return lua;
 };
 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 add(boss,L.HAND);add(helper,L.HAND);add(helper3,L.MZONE,1,P.FACEUP_ATTACK,2);add(lab,test.grave?L.GRAVE:L.MZONE,test.opponent?1:0,test.facedown?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK);if(!test.noFusion)add(helper2,L.EXTRA);
 for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.ATTACK,controller,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 if(!activated){const index=p.activates.findIndex(c=>c.code===helper);assert(index>=0,'Actual flip fixture');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 assert(third,'Actual interruption selected');assert(trace.some(m=>m.type===M.CHAINING&&m.code===helper3&&m.chain_size===2),'Actual CL2 interruption');
 assert(!query(L.MZONE).some(c=>c.code===helper2),'No Fusion after lost relation/negation');assert(!query(L.REMOVED).some(c=>c.code===boss||c.code===lab),'No partial banish after interruption');
 if(test.mode==='negate')assert(trace.some(m=>m.type===M.CHAIN_DISABLED),'Effect actually negated');
 done=true;
 }

 else if(p.type===M.SELECT_CARD){let index=p.selects.findIndex(c=>c.code===lab);if(index<0)index=p.selects.findIndex(c=>c.code===helper2);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
 else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});
 else if(p.type===M.SELECT_CHAIN){let index=-1;if(p.player===1&&!third){index=p.selects.findIndex(c=>c.code===helper3);if(index>=0)third=true;}core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
 else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x7f)!==0x7f,shift=isMonster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/gaia-iron-fusion-interrupt'+(process.argv.includes('--official')?'-official-'+helper2:'')+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Gaia actual SpecialSummon trigger interrupted by actual opponent CL2 target/source departure-and-return or negation; neutral Fusion metadata/supporting monsters. No adapters. Native Omega/sharedcount open',recipient:process.argv.includes('--official')?helper2:null,control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});


