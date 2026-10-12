'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=236744343,lab=900001210,filler=900001211,helper=900001212,helper2=process.argv.includes('--official')?Number(process.argv.find(a=>a.startsWith('--recipient='))?.split('=')[1]||15989522):900001213,helper3=900001214;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-response','no-search'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{sourceGY:true},{removeDeck:true},{removeGY:true},{lockSearch:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const search2=241868535;
 const cards=new Map([[boss,candidateCard(boss)],[search2,candidateCard(search2)],[lab,{...base,code:lab,type:test.wrongType?2:17,setcodes:test.wrongType?[0x39e2]:[]}],[helper2,{...base,code:helper2}],[helper3,{...base,code:helper3,type:0x20004,setcodes:[0x6167]}],[filler,{...base,code:filler,type:2}]]);
 const reader=name=>{if(name==='c0.lua')return '';if(name==='c'+helper2+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_QUICK_O) e:SetCode(EVENT_FREE_CHAIN) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetOperation(function(e,tp) '+(control==='no-response'?'do end':test.sourceGY?'Duel.SendtoGrave(Duel.GetMatchingGroup(Card.IsCode,tp,0,LOCATION_SZONE,nil,'+boss+'),REASON_EFFECT)':(test.removeDeck||test.removeGY)?'Duel.Remove(Duel.GetMatchingGroup(Card.IsCode,tp,0,'+(test.removeGY?'LOCATION_GRAVE':'LOCATION_DECK')+',nil,'+search2+'),POS_FACEUP,REASON_EFFECT)':'local d=Effect.CreateEffect(e:GetHandler()) d:SetType(EFFECT_TYPE_FIELD) d:SetCode(EFFECT_CANNOT_TO_HAND) d:SetTargetRange(0,LOCATION_DECK) d:SetTarget(function(e,c) return c:IsCode('+search2+') end) d:SetReset(RESET_PHASE+PHASE_END) Duel.RegisterEffect(d,tp) assert(not Duel.GetFirstMatchingCard(Card.IsCode,tp,0,LOCATION_DECK,nil,'+search2+'):IsAbleToHand(),"Native search lock")')+' end) c:RegisterEffect(e) end';if([lab,helper3,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){if(control==='unconditional-discard')lua=lua.replace('if #g>0 and Duel.SendtoHand(g,nil,REASON_EFFECT)>0 then','if Duel.SendtoHand(g,nil,REASON_EFFECT)>=0 then');if(control==='no-search')lua=lua.replace('Duel.SendtoHand(g,nil,REASON_EFFECT)','0');if(control==='no-discard')lua=lua.replace('Duel.DiscardHand(tp,Card.IsDiscardable,1,1,REASON_EFFECT+REASON_DISCARD)','do end');if(control==='allow-any')lua=lua.replace('c:IsSetCard(SET_VIR_PEDICAE_MORTIS) and c:IsType(TYPE_MONSTER)','true');}return lua;};

 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0,attached=false,offered=0;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 add(boss,L.HAND);add(filler,L.HAND);if(Object.keys(test).length)add(helper2,L.MZONE,1,P.FACEUP_ATTACK);if(!(test.noResource||test.wrongSet||test.wrongType))add(search2,test.removeGY?L.GRAVE:L.DECK);add(lab,L.DECK);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.ATTACK|Q.POSITION,controller,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 if(!activated){const index=p.activates.findIndex(c=>c.code===boss);assert(index>=0,'Legal before response');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}const searched=Object.keys(test).length===0;assert.equal(query(L.HAND).some(c=>c.code===search2),searched,'Search respects source/resources/lock');assert(query(L.HAND).some(c=>c.code===filler),'Existing Hand retained');assert.equal(query(L.HAND).length,searched?2:1,'Exactly one addition or none');if(Object.keys(test).length)assert(trace.some(m=>m.type===M.CHAINING&&m.code===helper2),'Native CL2');if(test.sourceGY){assert(query(L.GRAVE).some(c=>c.code===boss),'Actual sourceGY');const departure=trace.findIndex(t=>t.type===50&&t.card===boss&&t.to.location===L.GRAVE),resolution=trace.findIndex(t=>t.type===72&&t.chain_size===1);assert(departure>=0&&departure<resolution,'Source leaves before Estate resolution');}if(test.removeDeck||test.removeGY)assert(query(L.REMOVED).some(c=>c.code===search2),'Actual Deck resource removal');if(test.lockSearch)assert(query(L.DECK).some(c=>c.code===search2),'Locked resource remainsDeck');done=true;

 }

 else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});
 else if(p.type===M.SELECT_CARD){assert(p.selects.every(c=>c.code===search2),'Eligible resource only');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[0]});}
 else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.both&&test.send?1:0});
 else if(p.type===M.SELECT_EFFECTYN){offered++;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:!test.decline});}
 else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:activated&&!attached&&p.selects.some(c=>c.code===helper2)?(attached=true,p.selects.findIndex(c=>c.code===helper2)):p.forced?0:null});
 else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x7f)!==0x7f,shift=isMonster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-estate-search-interruption'+(process.argv.includes('--official')?'-official-'+helper2:'')+(process.argv.includes('--spell-target-candidate')?'-spell-target-candidate':'')+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Estate full activation search interruption: native CL2 Field sourceGY, sole Deck/GY Papa banish, or cannot-to-Hand Deck lock each suppresses search; existing Hand retained. Reference actually adds full Papa. Neutral response explicitly bounded; no adapters; activationlimit/nativeOmega/fullcard OPEN',legacy_chaininfo_adapter:false,recipient:process.argv.includes('--official')?helper2:null,control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});


