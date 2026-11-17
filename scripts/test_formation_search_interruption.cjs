'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_installed_card.cjs'),{loadCorrectedTransport}=require('./fresh_corrected_card_data_transport.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=239127930,lab=900001210,filler=900001211,helper=900001212,helper2=process.argv.includes('--official')?Number(process.argv.find(a=>a.startsWith('--recipient='))?.split('=')[1]||15989522):900001213,helper3=900001214;
async function main(){
 const mod=await loadCorrectedTransport();
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-add','ignore-set','ignore-type','include-opponent'].find(c=>process.argv.includes('--'+c));
 for(const test of [{grave:true},{grave:true,interrupt:true},{grave:true,interrupt:true,alternate:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:test.spell?2:33,setcodes:test.wrongSet?[]:[0x9c9]}],[helper2,{...base,code:helper2}],[helper3,{...base,code:helper3,type:2,setcodes:[0x191]}],[filler,{...base,code:filler,type:2}]]);
 const reader=name=>{if(name==='c'+helper2+'.lua'&&test.interrupt)return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_QUICK_O) e:SetCode(EVENT_CHAINING) e:SetRange(LOCATION_MZONE) e:SetCondition(function(e,tp,eg,ep,ev,re,r,rp) return rp~=tp and re:GetHandler():IsCode(239127930) end) e:SetOperation(function(e,tp) local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_GRAVE,nil,900001210) if tc then '+(process.argv.includes('--no-interrupt')?'Duel.GetCurrentChain()':'Duel.Remove(tc,POS_FACEUP,REASON_EFFECT)')+' end end) c:RegisterEffect(e) end';if(name==='c'+lab+'.lua'&&test.blocked)return 'local s,id=GetID() function s.initial_effect(c) local z=Effect.CreateEffect(c) z:SetType(EFFECT_TYPE_SINGLE) z:SetCode(EFFECT_CANNOT_TO_HAND) c:RegisterEffect(z) end';if(name==='c0.lua')return '';if([lab,helper2,helper3,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';const file=[process.env.CCG_OMEGA_SCRIPTS&&path.join(process.env.CCG_OMEGA_SCRIPTS,name),path.join(ROOT,'tmp/omega_scripts',name)].filter(Boolean).find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){if(control==='include-opponent')lua=lua.replace('LOCATION_DECK+LOCATION_GRAVE,0,1,nil','LOCATION_DECK+LOCATION_GRAVE,LOCATION_DECK+LOCATION_GRAVE,1,nil');if(control==='no-add')lua=lua.replace('Duel.SendtoHand(tc,nil,REASON_EFFECT)','0');if(control==='ignore-set')lua=lua.replace('c:IsSetCard(SET_GALACTICA) and c:IsType(TYPE_MONSTER)','c:IsType(TYPE_MONSTER)');if(control==='ignore-type')lua=lua.replace('c:IsSetCard(SET_GALACTICA) and c:IsType(TYPE_MONSTER)','c:IsSetCard(SET_GALACTICA)');}return lua;};

 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0,attached=false,responded=false;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 add(boss,L.SZONE,0,P.FACEDOWN_DEFENSE);if(test.interrupt)add(helper2,L.MZONE,1,P.FACEUP_ATTACK);add(lab,test.grave?L.GRAVE:L.DECK,test.opponent?1:0);if(test.alternate)add(lab,L.GRAVE,0,P.FACEUP_ATTACK,1);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.ATTACK|Q.POSITION,controller,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 const eligible=!(test.wrongSet||test.spell||test.blocked||test.opponent);if(!activated){const index=p.activates.findIndex(c=>c.code===boss);assert.equal(index>=0,eligible,'Eligible Galactica monster pool required');if(!eligible){done=true;continue;}activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}assert(query(L.GRAVE).some(c=>c.code===boss),'Normal Spell resolvesGY');assert.equal(query(L.HAND).some(c=>c.code===lab),(!test.interrupt||!!test.alternate),'search after interruption mismatch');if(test.interrupt){assert(responded,'opponent response unavailable');assert(query(L.REMOVED).some(c=>c.code===lab),'opponent failed to banish only candidate')}done=true;

 }

 else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});
 else if(p.type===M.SELECT_CARD){assert.equal(p.min,1);assert.equal(p.max,Math.min(2,test.pair||test.split||test.single?2:1));assert(p.selects.every(c=>c.code===lab||c.code===helper3),'Only intended effect choices');const indicies=test.single?[p.selects.findIndex(c=>c.code===lab)]:p.selects.map((c,i)=>i).slice(0,1);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies});}
 else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.send?1:0});
 else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});
 else if(p.type===M.SELECT_CHAIN){const i=p.player===1&&test.interrupt&&!responded?p.selects.findIndex(c=>c.code===helper2):-1;if(i>=0)responded=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:i>=0?i:p.forced?0:null});}
 else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x7f)!==0x7f,shift=isMonster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/formation-search-interruption'+(process.argv.includes('--no-interrupt')?'-no-interrupt':'')+''+(process.argv.includes('--official')?'-official-'+helper2:'')+(process.argv.includes('--spell-target-candidate')?'-spell-target-candidate':'')+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Actual Formation activation Galactica monster Deck/GYHand search; wrongset/Spell/nativeCANNOT_TO_HAND excludes. No adapters. SummontriggerLink/delayedBattleSS/interruption/countlimits/nativeOmegaOPEN',recipient:process.argv.includes('--official')?helper2:null,control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(process.env.CCG_OMEGA_SCRIPTS,'c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});




