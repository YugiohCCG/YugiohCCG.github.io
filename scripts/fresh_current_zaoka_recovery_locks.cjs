'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=215629896,lab=900001210,filler=900001211,helper=900001212,helper2=process.argv.includes('--official')?Number(process.argv.find(a=>a.startsWith('--recipient='))?.split('=')[1]||15989522):900001213,helper3=900001214;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-search','no-lock','ignore-necro'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{banished:true},{necro:true},{necro:true,banished:true},{handLock:true},{handLock:true,banished:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const search2=test.wrong?lab:test.treasure?236542835:232232676;
 const cards=new Map([[boss,candidateCard(boss)],[232232676,candidateCard(232232676)],[236542835,candidateCard(236542835)],[lab,{...base,code:lab,type:0x80002}],[helper2,{...base,code:helper2}],[helper3,{...base,code:helper3,type:0x20004,setcodes:[0x6167]}],[filler,{...base,code:filler,type:2}]]);
 const reader=name=>{if(name==='c0.lua')return '';if(name==='c'+helper2+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetOperation(function(e,tp) local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_HAND,0,nil,'+boss+') assert(Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)>0) end) c:RegisterEffect(e) end';if(name==='c'+helper3+'.lua')return `local s,id=GetID() function s.initial_effect(c) ${control==='no-lock'?'do end':test.necro?'local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_FIELD) e:SetCode(EFFECT_NECRO_VALLEY) e:SetRange(LOCATION_MZONE) e:SetTargetRange(LOCATION_GRAVE,0) c:RegisterEffect(e)':'local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_FIELD) e:SetCode(EFFECT_CANNOT_TO_HAND) e:SetRange(LOCATION_MZONE) e:SetTargetRange(LOCATION_GRAVE+LOCATION_REMOVED,0) c:RegisterEffect(e)'} end`;if([lab,helper3,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){if(control==='ignore-necro')lua=lua.replace('(not c:IsLocation(LOCATION_GRAVE) or aux.NecroValleyFilter()(c))','true');if(control==='no-search')lua=lua.replace('Duel.SendtoHand(tc,nil,REASON_EFFECT)','do end');if(control==='allow-any')lua=lua.replace('s.niucard(c) and c:IsAbleToHand()','c:IsAbleToHand()').replace('(not c:IsLocation(LOCATION_REMOVED) or c:IsFaceup())','true');}return lua;};

 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0,attached=false,offered=0;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 if(test.necro||test.handLock)add(helper3,L.MZONE,0,P.FACEUP_ATTACK,3);add(boss,L.HAND);if(test.special)add(helper2,L.MZONE,0,P.FACEUP_ATTACK);if(!test.noResource)add(search2,test.banished?L.REMOVED:L.GRAVE,test.opponent?1:0,test.down?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK);add(lab,L.GRAVE);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.ATTACK|Q.POSITION,controller,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 if(!activated){const pool=test.special?p.activates:p.summons,index=pool.findIndex(c=>c.code===(test.special?helper2:boss));assert(index>=0);activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:test.special?A.SELECT_ACTIVATE:A.SELECT_SUMMON,index});continue;}
 assert(trace.some(m=>m.type===M.MOVE&&m.card===boss&&m.to.location===L.MZONE),'Actual Zaoka summon');const eligible=!(test.handLock||(test.necro&&!test.banished));assert.equal(offered,eligible?1:0,'Recovery eligibility');const resolved=eligible&&!test.decline;assert.equal(query(L.HAND).some(c=>c.code===search2),resolved,'Actual own eligible recovery');assert(!query(L.HAND).some(c=>c.code===lab),'Wrong set excluded');assert.equal(query(L.HAND).length,resolved?1:0,'Exactly one recovery');if(resolved)assert(trace.some(m=>m.type===M.MOVE&&m.card===search2&&m.from.location===(test.banished?L.REMOVED:L.GRAVE)&&m.to.location===L.HAND),'Actual recovery movement');done=true;

 }

 else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});
 else if(p.type===M.SELECT_CARD){const priority=[lab,filler,search2];const index=priority.map(code=>p.selects.findIndex(c=>c.code===code)).find(i=>i>=0);assert(index!==undefined,'Expected cost/search card');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
 else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.both&&test.send?1:0});
 else if(p.type===M.SELECT_EFFECTYN){offered++;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:!test.decline});}
 else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
 else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x7f)!==0x7f,shift=isMonster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-zaoka-recovery-locks'+(process.argv.includes('--official')?'-official-'+helper2:'')+(process.argv.includes('--spell-target-candidate')?'-spell-target-candidate':'')+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Zaoka actual NormalSummon recovery GY/banished references; native NecroValley excludes GY but allows faceupbanished; native CannotToHand excludes both. Neutral restrictions bounded; no adapters; fullcard/nativeOmega OPEN',legacy_chaininfo_adapter:false,recipient:process.argv.includes('--official')?helper2:null,control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});


