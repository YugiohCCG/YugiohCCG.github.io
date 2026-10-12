'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=257549955,lab=900001210,filler=900001211,helper=900001212,helper2=process.argv.includes('--official')?Number(process.argv.find(a=>a.startsWith('--recipient='))?.split('=')[1]||15989522):900001213,helper3=900001214;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['ignore-relation','no-response'].find(c=>process.argv.includes('--'+c));
 for(const test of [{returning:false},{returning:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:test.spell?2:33,setcodes:test.wrongSet?[]:[0xe40d]}],[helper2,{...base,code:helper2}],[helper3,{...base,code:helper3,type:2}],[filler,{...base,code:filler,type:2}]]);
 cards.set(900004603,{...base,code:900004603,type:33});const reader=name=>{if(name==='c900004603.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_QUICK_O) e:SetRange(LOCATION_MZONE) e:SetCode(EVENT_CHAINING) e:SetCountLimit(1) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(257549955) end) e:SetOperation(function(e,tp) local tc=Duel.GetFirstMatchingCard(Card.IsCode,0,LOCATION_GRAVE,0,nil,900001210) assert(Duel.SendtoHand(tc,nil,REASON_EFFECT)==1) ${test.returning?'assert(Duel.SendtoGrave(tc,REASON_EFFECT)==1)':''} end) c:RegisterEffect(e) end`;if(name==='c0.lua')return '';if([lab,helper2,helper3,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){if(control==='ignore-relation')lua=lua.replace('tc:IsRelateToEffect(e) and ','');if(control==='no-summon'){assert(lua.includes('Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)'));lua=lua.replace('Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)','do end');}if(control==='ignore-set')lua=lua.replace('c:IsSetCard(SET_STELLAER)','true');if(control==='no-shuffle'){assert(lua.includes('Duel.SendtoDeck(g,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)'));lua=lua.replace('Duel.SendtoDeck(g,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)','do end');}if(control==='any-type'){assert(lua.includes('c:IsType(TYPE_MONSTER) and '));lua=lua.replace('c:IsType(TYPE_MONSTER) and ','');}}return lua;};

 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0,attached=false;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 add(900004603,L.MZONE,1,P.FACEUP_ATTACK,4);add(boss,L.SZONE,0,P.FACEDOWN_DEFENSE);add(lab,L.GRAVE,test.opponent?1:0);if(test.full)for(let i=0;i<5;i++)add(helper2,L.MZONE,0,P.FACEUP_ATTACK,i);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.ATTACK|Q.POSITION,controller,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 const eligible=!(test.wrongSet||test.spell||test.opponent||test.full);if(!activated){const index=p.activates.findIndex(c=>c.code===boss);assert.equal(index>=0,eligible,'Own Stellaer monster and free zone required');if(!eligible){done=true;continue;}activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}assert(query(L.GRAVE).some(c=>c.code===boss),'Actual Normal Spell resolves Grave');assert(second,'Actual opposing CL2 response selected');assert(!query(L.MZONE).some(c=>c.code===lab),'Interrupted target not revived');assert(query(test.returning?L.GRAVE:L.HAND).some(c=>c.code===lab),'Target actual final destination');assert(!trace.some(m=>m.type===M.SPSUMMONED),'No summon completes');assert(trace.some(m=>m.type===M.CHAINING&&m.code===900004603),'Native CL2 response');done=true;

 }

 else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});
 else if(p.type===M.SELECT_CARD){assert.equal(p.min,1);assert.equal(p.max,Math.min(2,test.pair||test.split||test.single?2:1));assert(p.selects.every(c=>c.code===lab||c.code===helper2),'Only monsters selectable');const indicies=test.single?[p.selects.findIndex(c=>c.code===lab)]:p.selects.map((c,i)=>i).slice(0,2);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies});}
 else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.send?1:0});
 else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});
 else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===900004603);const choose=index>=0&&!second&&control!=='no-response';if(choose)second=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:choose?index:p.forced?0:null});}
 else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x7f)!==0x7f,shift=isMonster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-stellaer-reborn-revival-relation'+(process.argv.includes('--official')?'-official-'+helper2:'')+(process.argv.includes('--spell-target-candidate')?'-spell-target-candidate':'')+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Native initially-set Normal Spell CL1 targets own Stellaer; opposing actual CL2 sends target to Hand, optionally back GY; relation lost so no revival. No adapters; native Omega open',recipient:process.argv.includes('--official')?helper2:null,control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});


