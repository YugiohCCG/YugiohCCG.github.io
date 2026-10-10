'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=252513554,lab=900001210,filler=900001211,helper=900001212,helper2=process.argv.includes('--official')?Number(process.argv.find(a=>a.startsWith('--recipient='))?.split('=')[1]||15989522):900001213,helper3=900001214;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-level','no-response'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{interrupt:true,remove:true},{interrupt:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:33,attack:test.lowAttack?2499:2500,setcodes:test.wrongSet?[]:[0x6f4]}],[helper2,{...base,code:helper2}],[helper3,{...base,code:helper3,type:2,setcodes:[0x191]}],[filler,{...base,code:filler,type:2}]]);
 const reader=name=>{if(name==='c'+lab+'.lua'&&test.blocked)return 'local s,id=GetID() function s.initial_effect(c) local z=Effect.CreateEffect(c) z:SetType(EFFECT_TYPE_SINGLE) z:SetCode(EFFECT_CANNOT_TO_HAND) c:RegisterEffect(z) end';if(name==='c0.lua')return '';if(name==='c'+helper2+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_QUICK_O) e:SetCode(EVENT_FREE_CHAIN) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetOperation(function(e,tp) local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,'+boss+') assert('+(test.remove?'Duel.SendtoGrave(g,REASON_EFFECT)':'Duel.ChangePosition(g,POS_FACEDOWN_DEFENSE)')+'==1,"Native interruption changes Guardian") end) c:RegisterEffect(e) end';if([lab,helper2,helper3,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){if(control==='no-level')lua=lua.replace('e1:SetCode(EFFECT_UPDATE_LEVEL)','e1:SetCode(EFFECT_UPDATE_ATTACK)');if(control==='persistent-level')lua=lua.replace('e1:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END)','do end');if(control==='wrong-decrease')lua=lua.replace('e1:SetValue(-2)','e1:SetValue(2)');}return lua;};

 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0,attached=false;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 add(helper2,L.MZONE,0,P.FACEUP_ATTACK,1);add(boss,test.grave?L.GRAVE:L.HAND,0,P.FACEUP_ATTACK);add(lab,L.MZONE,test.opponent?1:0,test.facedown?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK);if(test.full)for(let i=1;i<5;i++)add(helper3,L.MZONE,0,P.FACEUP_ATTACK,i);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.LEVEL|Q.REASON|Q.ATTACK|Q.POSITION,controller,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 if(!activated){const index=p.special_summons.findIndex(c=>c.code===boss);assert(index>=0);activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SPECIAL_SUMMON,index});continue;}assert(trace.some(m=>m.type===M.MOVE&&m.card===boss&&m.to.location===L.MZONE),'Actual Guardian inherent summon');if(test.interrupt){assert(second,'Actual chain response selected');assert(trace.some(m=>m.type===M.CHAINING&&m.code===helper2),'Response chained');const c=query(test.remove?L.GRAVE:L.MZONE).find(c=>c.code===boss);assert(c,'Guardian reached interrupted location');if(!test.remove)assert.equal(c.position,P.FACEDOWN_DEFENSE);assert.equal(c.level,cards.get(boss).level,'Interrupted Guardian level unchanged');done=true;continue;}const c=query(L.MZONE).find(c=>c.code===boss);assert(c);const initial=cards.get(boss).level;if(turn===1){assert.equal(c.level,initial+(test.decline?0:test.lower?-2:2),'Chosen native level change');assert.equal(trace.filter(m=>m.type===M.CHAINING&&m.code===boss).length,test.decline?0:1,'Optional level trigger activation');core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP,index:0});continue;}assert.equal(turn,2);assert.equal(c.level,initial,'Level expires after EndPhase');done=true;

 }

 else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});
 else if(p.type===M.SELECT_CARD){assert.equal(p.min,1);assert.equal(p.max,Math.min(2,test.pair||test.split||test.single?2:1));assert(p.selects.every(c=>c.code===lab||c.code===helper3),'Only intended effect choices');const indicies=test.single?[p.selects.findIndex(c=>c.code===lab)]:p.selects.map((c,i)=>i).slice(0,2);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies});}
 else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.lower?1:0});
 else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:!test.decline});
 else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:activated&&test.interrupt&&control!=='no-response'&&!second&&p.selects.some(c=>c.code===helper2)?(second=true,p.selects.findIndex(c=>c.code===helper2)):p.forced?0:null});
 else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x7f)!==0x7f,shift=isMonster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-guardian-crying-level-interruption'+(process.argv.includes('--official')?'-official-'+helper2:'')+(process.argv.includes('--spell-target-candidate')?'-spell-target-candidate':'')+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Guardian actual inherent summon and level trigger with actual chained removal or facedown interruption; reference +2 and expiry. No adapters; native Omega OPEN',recipient:process.argv.includes('--official')?helper2:null,control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});


