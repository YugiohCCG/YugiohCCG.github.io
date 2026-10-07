'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=Number(process.argv.find(a=>a.startsWith('--source='))?.split('=')[1]),lab=259479044,filler=900001211,helper=Number(process.argv.find(a=>a.startsWith('--target='))?.split('=')[1]),helper2=process.argv.includes('--official')?Number(process.argv.find(a=>a.startsWith('--recipient='))?.split('=')[1]||15989522):259405917,helper3=900001214;
async function main(){
 assert.equal(boss,259650969,'Beacon hand summon profile');
 assert.equal(candidateCard(helper).type&(0x40|0x2000|0x800000|0x4000000),0,'Deck search fixture target must be a main-deck card');
 
 const mod=await import(pathToFileURL(process.argv.includes('--card-data-adapter')?path.join(ROOT,'output/fresh-ccg-september/public-core-card-data-adapter.mjs'):path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 assert.equal(A.SELECT_SPECIAL_SUMMON,1,'Special summon action must exist');
 const targetLocationName=process.argv.find(a=>a.startsWith('--location='))?.split('=')[1]||'deck',targetLocation={deck:L.DECK,grave:L.GRAVE,removed:L.REMOVED}[targetLocationName];assert(targetLocation,'Unsupported search fixture location');
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-movement','no-post-move-counters'].find(c=>process.argv.includes('--'+c));
 const hasDiscard=[211086520,258590942].includes(boss);
 const optionalSearch=[259679619,247831166,255953418,244816828,258590942,284636586].includes(boss);
 for(const test of [{},{noCoLink:true},{fullField:true},{allFacedown:true}]){
 const invalidTarget=test.wrongSet||test.wrongField||test.facedownField||test.opponentField;
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:test.spell?2:33,attribute:test.wrongAttribute?1:2,setcodes:[]}],[filler,{...base,code:filler,type:2}],[helper,{...base,code:helper,type:2}],[helper2,{...base,code:helper2,type:65,attack:1000,setcodes:[]}],[helper3,{...base,code:helper3,type:2}]]);
 cards.set(lab,{...base,code:lab,setcodes:test.wrongSet?[]:[0x7a34],type:2,attribute:test.wrongAttribute?1:2,attack:test.atkHigher?2300:1200,defense:1800});
 cards.set(helper2,candidateCard(helper2));if(test.wrongSupportSet)cards.set(helper2,{...cards.get(helper2),setcodes:[]});cards.set(helper3,{...base,code:helper3,type:17});cards.set(lab,candidateCard(259479044));
 cards.set(helper,candidateCard(helper));if(test.sameName)cards.set(helper,{...cards.get(helper),alias:boss});if(test.wrongRace)cards.set(helper,{...cards.get(helper),race:1n});if(test.wrongSet)cards.set(helper,{...cards.get(helper),setcodes:[]});if(test.monster||test.trap)cards.set(helper,{...cards.get(helper),type:test.monster?17:4});
 const reader=name=>{
 if(name==='c'+filler+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local a=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_MZONE,0,nil,${lab}) local b=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_MZONE,0,nil,${helper2}) local moved=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_MZONE,0,nil,${helper}) assert(a:GetCounter(0x18f0)==${test.noCoLink?0:1},"Intensity exact post-move counter") assert(b:GetCounter(0x18f0)==${test.noCoLink?0:1},"Conductor exact post-move counter") assert(moved:GetCounter(0x18f0)==0,"Moved non-Link receives no counter") end) c:RegisterEffect(e) end`;
 if(name==='c'+helper3+'.lua')return `local s,id=GetID() function s.initial_effect(c) end`;
 if(name==='c'+helper3+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) Duel.SpecialSummon(Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_HAND,0,nil,${boss}),0,tp,tp,false,false,POS_FACEUP) end) c:RegisterEffect(e) end`;



 if(false)return `local s,id=GetID() s.material_setcode=${test.wrongMaterial?'0x8d':'0xbd'} function s.initial_effect(c) c:EnableCounterPermit(0x18f0) end`;

 if([filler].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
 const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,'Missing '+name);let lua=fs.readFileSync(file,'utf8');
 if(name==='c'+boss+'.lua'&&control){const old=control==='no-movement'?'e3:SetOperation(s.mvop)':'mc:AddCounter(COUNTER_CURRENT, 1)';assert.equal(lua.split(old).length,2);lua=lua.replace(old,control==='no-movement'?'e3:SetOperation(function() end)':'do end');}if(name==='c'+boss+'.lua'&&process.argv.includes('--probe'))lua+=`
local old=s.bfscon s.bfscon=function(e,tp,...) local c=e:GetHandler() Debug.Message("bfscon seq="..c:GetSequence().." linkedzone="..Duel.GetLinkedZone(tp)) local g=Duel.GetMatchingGroup(Card.IsType,tp,LOCATION_MZONE,LOCATION_MZONE,nil,TYPE_LINK) for tc in aux.Next(g) do Debug.Message("link markers="..tc:GetLinkMarker().." contains="..tostring(tc:GetLinkedGroup():IsContains(c))) end local v=old(e,tp,...) Debug.Message("bfscon="..tostring(v)) return v end
`;return lua;
 };
 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,probed=false,activated=false,done=false,second=false,third=false,turn=0;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 add(boss,L.HAND);add(filler,L.HAND);add(helper,L.MZONE,0,test.allFacedown?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK,0);add(lab,L.MZONE,0,test.allFacedown?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK,1);add(helper2,L.MZONE,0,test.allFacedown?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK,test.noCoLink?3:2);if(test.fullField){add(helper3,L.MZONE,0,P.FACEUP_ATTACK,3);add(helper3,L.MZONE,0,P.FACEUP_ATTACK,4);}

 for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.ATTACK|Q.POSITION,controller,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 const index=p.activates.findIndex(c=>c.code===boss);if(!activated){assert(index>=0,'Beacon activation is legal even without optional summon');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}assert(query(L.SZONE).some(c=>c.code===boss),'Beacon remains on field');if(!second){const i=p.activates.findIndex(c=>c.code===boss);assert.equal(i>=0,!test.fullField&&!test.allFacedown,'Movement needs face-up own monster and free zone');if(test.fullField||test.allFacedown){done=true;continue;}second=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index:i});continue;}assert(trace.some(m=>m.type===M.MOVE&&m.card===helper&&m.from.location===L.MZONE&&m.to.sequence===(test.noCoLink?2:3)),'Actual Farad movement');if(!probed){const i=p.activates.findIndex(c=>c.code===filler);assert(i>=0);probed=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index:i});continue;}assert(trace.some(m=>m.type===M.CHAINING&&m.code===filler),'Native counter probe resolved');done=true;
 }
 else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});
 else if(p.type===M.SELECT_CARD){let index=hasDiscard&&p.selects.every(c=>c.location===L.HAND)?p.selects.findIndex(c=>c.code===filler):p.selects.findIndex(c=>c.code===helper);if(index<0)index=0;core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
 else if(p.type===M.SELECT_UNSELECT_CARD){const index=p.select_cards.findIndex(c=>c.code===helper);assert(p.can_finish||index>=0,'Shared subgroup needs canonical target');core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index:p.can_finish?null:index});}
 else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.bothModes?1:0});
 else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:!test.decline});
 else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
 else if(p.type===M.SELECT_DISFIELD){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);assert.equal(sequence,test.noCoLink?2:3);core.duelSetResponse(duel,{type:R.SELECT_DISFIELD,places:[{player:p.player,location:L.MZONE,sequence}]});}
 else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x7f)!==0x7f,shift=isMonster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/beacon-movement-counters-'+boss+'-'+helper+(process.argv.includes('--card-data-adapter')?'-card-data-adapter':'')+(targetLocationName!=='deck'?'-'+targetLocationName:'')+(process.argv.includes('--public-target-param')?'-public-target-param':'')+(process.argv.includes('--official')?'-official-'+helper2:'')+(control?'-'+control:'')+(process.argv.includes('--probe')?'-probe':'')+'.json'),JSON.stringify({scope:'Canonical Beacon actual Farad movement and native counter totals on canonical co-linked Intensity/Conductor, broken graph/full-field/all-face-down controls. Initial field placement, no proper Link summons; targeting protection/HOPT/responses/native Omega open',card_data_adapter:process.argv.includes('--card-data-adapter'),public_target_param_adapter:process.argv.includes('--public-target-param'),supporting_script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+helper+'.lua'))).digest('hex'),recipient:process.argv.includes('--official')?helper2:null,control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});




