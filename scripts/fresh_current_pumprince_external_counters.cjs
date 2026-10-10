'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=239028111,lab=900001210,filler=900001211,helper=900001212,helper2=process.argv.includes('--official')?Number(process.argv.find(a=>a.startsWith('--recipient='))?.split('=')[1]||15989522):900001213,helper3=900001214;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['own-only','self-only','no-removal'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{opponent:true},{removeBoss:true},{opponent:true,removeBoss:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:0x20002}],[17601919,{...base,code:17601919,type:test.spellzone?0x20002:33}],[helper2,{...base,code:helper2,attack:2000,defense:1500}],[helper3,{...base,code:helper3,type:33,attack:2000,defense:1500}],[filler,{...base,code:filler,type:2}]]);
 const eligible=!(test.opponent||test.facedown||test.absent);
 const reader=name=>{if(name==='c0.lua')return '';if(name==='c'+lab+'.lua')return 'local s,id=GetID() function s.initial_effect(c) c:EnableCounterPermit(0x2f) end';if(name==='c'+helper3+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,nil,'+lab+') assert(tc) if c:GetFlagEffect(id)==0 then assert(tc:AddCounter(0x2f,3)) assert(tc:GetCounter(0x2f)==3,"Native external counters") c:RegisterFlagEffect(id,0,0,1) else '+(control==='no-removal'?'do end':test.removeBoss?'local bc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_MZONE,0,nil,'+boss+') assert(Duel.SendtoGrave(bc,REASON_EFFECT)==1)':'assert(Duel.SendtoGrave(tc,REASON_EFFECT)==1)')+' end end) c:RegisterEffect(e) end';if([17601919,helper2,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){if(control==='own-only')lua=lua.replace('Duel.GetCounter(0,1,1,COUNTER_PUMPKIN)','Duel.GetCounter(0,1,0,COUNTER_PUMPKIN)');if(control==='self-only')lua=lua.replace('function s.atkval()','function s.atkval(e)').replace('Duel.GetCounter(0,1,1,COUNTER_PUMPKIN)','e:GetHandler():GetCounter(COUNTER_PUMPKIN)');}return lua;};
 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0,attached=false;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 add(boss,L.MZONE,0,P.FACEUP_ATTACK);add(helper3,L.MZONE,0,P.FACEUP_ATTACK,1);add(helper2,L.MZONE,1,P.FACEUP_ATTACK);add(lab,L.SZONE,test.opponent?1:0,P.FACEUP_ATTACK);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.LEVEL|Q.REASON|Q.ATTACK|Q.DEFENSE|Q.POSITION,controller,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 const enemy=query(L.MZONE,1).find(c=>c.code===helper2),own=query(L.MZONE).find(c=>c.code===helper3);assert.equal(own.attack,2000);assert.equal(own.defense,1500);
 const reduction=!activated?100:!second?400:test.removeBoss?0:100;assert.equal(enemy.attack,2000-reduction,'Aggregate counters dynamically update attack');assert.equal(enemy.defense,1500-reduction,'Aggregate counters dynamically update defense');
 if(second){assert(query(L.GRAVE,test.removeBoss?0:test.opponent?1:0).some(c=>c.code===(test.removeBoss?boss:lab)),'Actual selected counter source or aura reaches GY');done=true;continue;}
 if(activated)second=true;else activated=true;const index=p.activates.findIndex(c=>c.code===helper3);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});

 }

 else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});
 else if(p.type===M.SELECT_CARD){assert.equal(p.min,1);assert.equal(p.max,Math.min(2,test.pair||test.split||test.single?2:1));assert(p.selects.every(c=>c.code===helper2),'Only intended effect choices');const indicies=test.single?[p.selects.findIndex(c=>c.code===lab)]:p.selects.map((c,i)=>i).slice(0,2);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies});}
 else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.lower?1:0});
 else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:!test.decline});
 else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
 else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x7f)!==0x7f,shift=isMonster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-pumprince-external-counters'+(process.argv.includes('--official')?'-official-'+helper2:'')+(process.argv.includes('--spell-target-candidate')?'-spell-target-candidate':'')+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Pumprince counts native3 Pumpkin counters on neutral external ContinuousSpell on own/opponent field plus own Standby1; actual counter source or aura removal dynamically restores opponent ATK DEF. Own stats unchanged. No adapters; real Pumprincess/native Omega OPEN',recipient:process.argv.includes('--official')?helper2:null,control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});


