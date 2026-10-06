'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=213530841,lab=900001210,filler=900001211,helper=900001212,helper2=process.argv.includes('--official')?Number(process.argv.find(a=>a.startsWith('--recipient='))?.split('=')[1]||15989522):900001213,helper3=900001214;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-count','no-renewal'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{renewal:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:test.spell?2:33,attribute:test.wrongAttribute?1:2,setcodes:[]}],[filler,{...base,code:filler,type:2}],[helper,{...base,code:helper,type:2}],[helper2,{...base,code:helper2,type:65,attack:1000,setcodes:[]}],[helper3,{...base,code:helper3,type:2}]]);
 cards.set(lab,{...base,code:lab,type:33,setcodes:test.wrongSet?[]:[0xdae7]});cards.set(helper3,{...base,code:helper3,type:test.spellEffect?2:33});
 cards.set(helper2,{...base,code:helper2,type:33});
 const reader=name=>{
 if([helper3,helper2].some(c=>name==='c'+c+'.lua'))return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(${test.spellEffect?'EFFECT_TYPE_ACTIVATE':'EFFECT_TYPE_IGNITION'}) e:SetCode(EVENT_FREE_CHAIN) ${test.spellEffect?'':'e:SetRange(LOCATION_MZONE)'} e:SetCountLimit(1) e:SetOperation(function(e,tp) Duel.Damage(1-tp,1000,REASON_EFFECT) end) c:RegisterEffect(e) end`;
 if(name==='c'+helper+'.lua')return 'local s,id=GetID() function s.initial_effect(c) end';
 if(name==='c'+helper2+'.lua'&&!process.argv.includes('--official'))return `local s,id=GetID() s.material_setcode=${test.wrongMaterial?'0x8d':'0xbd'} function s.initial_effect(c) end`;
 if(name==='c'+lab+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_UPDATE_ATTACK) e:SetProperty(EFFECT_FLAG_SINGLE_RANGE) e:SetRange(LOCATION_MZONE) e:SetValue(500) c:RegisterEffect(e) end';
 if([filler].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
 const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,'Missing '+name);let lua=fs.readFileSync(file,'utf8');
 if(name==='c'+boss+'.lua'){if(control==='no-count')lua=lua.replace('e1:SetCountLimit(1,id)','do end');if(control==='no-renewal')lua=lua.replace('e1:SetCountLimit(1,id)','e1:SetCountLimit(1,id,2)');
 }return lua;
 };
 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 add(helper3,test.spellEffect?L.HAND:L.MZONE,1,P.FACEUP_ATTACK);add(boss,L.SZONE);add(boss,L.SZONE,0,P.FACEDOWN_DEFENSE,1);add(helper2,L.MZONE,1,P.FACEUP_ATTACK,1);if(!test.noSupport)add(lab,L.MZONE,0,test.facedownSupport?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK);
 for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.ATTACK|Q.POSITION,controller,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 if(!activated){if(turn===1){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP,index:0});continue;}assert.equal(turn,2);const index=p.activates.findIndex(c=>c.code===helper3);assert(index>=0,'Opponent Spell activation');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}if(!second){assert.equal(trace.filter(m=>m.type===M.CHAINING&&m.code===boss).length,1,'First negate used');assert.equal(query(L.SZONE).filter(c=>c.code===boss).length,1,'Unused Counter remains set');if(test.renewal&&turn<4){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP,index:0});continue;}assert.equal(turn,test.renewal?4:2);const index=p.activates.findIndex(c=>c.code===helper2);assert(index>=0,'Second actual opponent monster effect legal');second=true;third=false;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}assert.equal(trace.filter(m=>m.type===M.CHAINING&&m.code===boss).length,test.renewal?2:1,'Shared negate limit and later turn renewal');assert.equal(trace.filter(m=>m.type===M.DAMAGE).length,test.renewal?0:1,'Second opponent effect resolves only when shared limit exhausted');assert.equal(query(L.GRAVE).filter(c=>c.code===boss).length,test.renewal?2:1,'Actual used trap count');done=true;
 }

 else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:false});
 else if(p.type===M.SELECT_CARD){let index=p.selects.findIndex(c=>c.code===helper3);if(index<0)index=0;core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
 else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.send?1:0});
 else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});
 else if(p.type===M.SELECT_CHAIN){let index=-1;if(activated&&!third&&p.player===0&&trace.findLastIndex(m=>m.type===M.CHAINING)>trace.findLastIndex(m=>m.type===M.CHAIN_END)){index=p.selects.findIndex(c=>c.code===boss);assert.equal(index>=0,!second||!!test.renewal,'Shared negate chain availability');if(index>=0)third=true;}core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
 else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x7f)!==0x7f,shift=isMonster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/chrono-saur-counter-negate-count'+(process.argv.includes('--official')?'-official-'+helper2:'')+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Two full Counter setcopies, two separately native opponent monster effects, shared negation HOPT same turn2 versus refreshed opponentturn4; native damage/used trap counts. No API adapter; no-renewal public countflag2 mutation only. Interruptions/native Omega open',recipient:process.argv.includes('--official')?helper2:null,control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});


