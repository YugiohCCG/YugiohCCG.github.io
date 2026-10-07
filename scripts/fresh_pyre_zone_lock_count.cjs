'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=Number(process.argv.find(a=>a.startsWith('--source='))?.split('=')[1]),lab=900001210,filler=900001211,helper=Number(process.argv.find(a=>a.startsWith('--target='))?.split('=')[1]),helper2=process.argv.includes('--official')?Number(process.argv.find(a=>a.startsWith('--recipient='))?.split('=')[1]||15989522):900001213,helper3=900001214;
async function main(){
 assert.equal(boss,259883230,'Release-only zone-lock profile');
 assert.equal(candidateCard(helper).type&(0x40|0x2000|0x800000|0x4000000),0,'Deck search fixture target must be a main-deck card');
 assert((candidateCard(boss).level&255)<=4,'This shared Normal Summon fixture has no tribute material');
 const mod=await import(pathToFileURL(process.argv.includes('--card-data-adapter')?path.join(ROOT,'output/fresh-ccg-september/public-core-card-data-adapter.mjs'):path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const targetLocationName=process.argv.find(a=>a.startsWith('--location='))?.split('=')[1]||'deck',targetLocation={deck:L.DECK,grave:L.GRAVE,removed:L.REMOVED}[targetLocationName];assert(targetLocation,'Unsupported search fixture location');
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-search','any-search-filter','no-special-trigger','no-discard','no-destroy','old-field-condition','old-lock-limit'].find(c=>process.argv.includes('--'+c));
 const hasDiscard=[211086520,258590942].includes(boss);
 const optionalSearch=[259679619,247831166,255953418,244816828,258590942,284636586].includes(boss);
 for(const test of [{}]){
 const invalidTarget=test.wrongSet||test.wrongField||test.facedownField||test.opponentField;
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:test.spell?2:33,attribute:test.wrongAttribute?1:2,setcodes:[]}],[filler,{...base,code:filler,type:2}],[helper,{...base,code:helper,type:2}],[helper2,{...base,code:helper2,type:65,attack:1000,setcodes:[]}],[helper3,{...base,code:helper3,type:2}]]);
 cards.set(lab,{...base,code:lab,setcodes:test.wrongSet?[]:[0x7a34],type:2,attribute:test.wrongAttribute?1:2,attack:test.atkHigher?2300:1200,defense:1800});
 cards.set(helper2,{...base,code:helper2,type:0x4000021,level:1,race:128n,link_marker:128,setcodes:[0x3135]});
 cards.set(helper,candidateCard(helper));if(test.wrongRace)cards.set(helper,{...cards.get(helper),race:1n});if(test.wrongSet)cards.set(helper,{...cards.get(helper),setcodes:[]});if(test.monster||test.trap)cards.set(helper,{...cards.get(helper),type:test.monster?17:4});
 const reader=name=>{
 if(name==='c'+helper3+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) Duel.SpecialSummon(Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_HAND,0,nil,${boss}),0,tp,tp,false,false,POS_FACEUP) end) c:RegisterEffect(e) end`;



 if(name==='c'+helper2+'.lua'&&!process.argv.includes('--official'))return `local s,id=GetID() s.material_setcode=${test.wrongMaterial?'0x8d':'0xbd'} function s.initial_effect(c) end`;
 if(name==='c'+lab+'.lua')return 'local s,id=GetID() function s.initial_effect(c) end';
 if([filler].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
 const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,'Missing '+name);let lua=fs.readFileSync(file,'utf8');
 if(name==='c'+boss+'.lua'&&control==='old-lock-limit'){assert.equal(lua.split('e3:SetCost(s.lockcost);').length,2);lua=lua.replace('e3:SetCost(s.lockcost);','');}if(name==='c'+boss+'.lua'&&control==='no-destroy'){assert.equal(lua.split('Duel.Destroy(tc,REASON_EFFECT)>0').length,2);lua=lua.replace('Duel.Destroy(tc,REASON_EFFECT)>0','true');}if(name==='c'+boss+'.lua'&&control==='old-field-condition'){const old='Duel.IsExistingMatchingCard(s.pyro,tp,LOCATION_MZONE,0,1,nil)';assert.equal(lua.split(old).length,2);lua=lua.replace(old,'Duel.IsExistingMatchingCard(Card.IsRace,tp,LOCATION_MZONE,0,1,nil,RACE_PYRO)');}if(name==='c'+boss+'.lua'&&control==='no-search'){const matches=lua.match(/(?:e1|e):SetOperation\(s\.(?:thop|activate)\)/g);assert.equal(matches?.length,1,'Search operation registration must be unique');lua=lua.replace(matches[0],matches[0].replace(/s\.(?:thop|activate)/,'function() end'));}if(name==='c'+boss+'.lua'&&control==='any-search-filter'){const fn='thf';assert(lua.includes('function s.'+fn+'('));lua+='\ns.'+fn+'=function(c) return c:IsAbleToHand() end\n';}if(name==='c'+boss+'.lua'&&control==='no-special-trigger'){const parent=lua.match(/(e[0-9]+):SetOperation\(s\.thop\)/)?.[1];assert(parent);const clone=lua.match(new RegExp('local (e[0-9]+)='+parent+':Clone\\(\\)\\s*\\1:SetCode\\(EVENT_SPSUMMON_SUCCESS\\)'));assert(clone,'Unique search clone required');lua=lua.replace(clone[0],clone[0].replace('EVENT_SPSUMMON_SUCCESS','EVENT_FLIP_SUMMON_SUCCESS'));}if(name==='c'+boss+'.lua'&&control==='no-discard'){const matches=lua.match(/Duel\.DiscardHand\([^\n]+\)/g);assert.equal(matches?.length,1);lua=lua.replace(matches[0],'do end');}if(name==='c'+boss+'.lua'&&process.argv.includes('--probe'))lua+=`
local old=s.lk s.lk=function(c,tp) Debug.Message(tostring(c:GetSequence()).." type="..c:GetType().." markers="..c:GetLinkMarker().." zone0="..c:GetLinkedZone(0).." zone1="..c:GetLinkedZone(1)) return old(c,tp) end
`;return lua;
 };
 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 add(boss,L.SZONE,0,P.FACEUP_ATTACK);add(helper2,L.MZONE,0,P.FACEUP_ATTACK,5);if(hasDiscard)add(filler,L.HAND);if(process.argv.includes('--special'))add(helper3,L.HAND);

 for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.ATTACK|Q.POSITION,controller,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 const index=p.activates.findIndex(c=>c.code===boss);
 if(!activated){assert(index>=0,'Initial Link zone-lock activation');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 if(turn<3){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP,index:0});continue;}
 assert.equal(index,-1,'Zone lock remains consumed next own turn while source stays face-up');assert(trace.some(m=>m.type===M.CHAINING&&m.code===boss),'Actual lock activation');done=true;
 }
 else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline&&!query(L.HAND).some(c=>c.code===helper)});
 else if(p.type===M.SELECT_CARD){let index=hasDiscard&&p.selects.every(c=>c.location===L.HAND)?p.selects.findIndex(c=>c.code===filler):p.selects.findIndex(c=>c.code===helper);if(index<0)index=0;core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
 else if(p.type===M.SELECT_UNSELECT_CARD){const index=p.select_cards.findIndex(c=>c.code===helper);assert(p.can_finish||index>=0,'Shared subgroup needs canonical target');core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index:p.can_finish?null:index});}
 else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.send?1:0});
 else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:!test.decline&&!query(L.HAND).some(c=>c.code===helper)});
 else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
 else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x7f)!==0x7f,shift=isMonster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/pyre-zone-lock-'+boss+'-'+helper+(process.argv.includes('--card-data-adapter')?'-card-data-adapter':'')+(targetLocationName!=='deck'?'-'+targetLocationName:'')+(process.argv.includes('--public-target-param')?'-public-target-param':'')+(process.argv.includes('--official')?'-official-'+helper2:'')+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Production Release zone-lock actual activation and count across next own turn, with neutral Pyre Link in EMZ. Test-only public card-data adapter restores Link arrows. Other lock behaviors, resets, leave-field effects and native Omega open',card_data_adapter:process.argv.includes('--card-data-adapter'),public_target_param_adapter:process.argv.includes('--public-target-param'),supporting_script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+helper+'.lua'))).digest('hex'),recipient:process.argv.includes('--official')?helper2:null,control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});


