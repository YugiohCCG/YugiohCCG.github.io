'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=212052682,lab=900001210,filler=900001211,helper=900001212,helper2=900001213,helper3=900001214;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-summon','any-player','any-set'].find(c=>process.argv.includes('--'+c));
 for(const test of [{set:true},{special:true},{special:true,facedown:true},{special:true,wrongSet:true},{set:true,wrongSet:true},{set:true,opponent:true},{special:true,opponent:true},{set:true,full:true},{special:true,full:true},{set:true,multiple:true},{special:true,multiple:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const wanted=test.spell?61089209:test.trap?7574904:34695290,other=wanted===34695290?61089209:34695290;
 const revealed=test.selfReveal?wanted:lab;
 const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:33,setcodes:test.wrongSet?[]:[0x8d]}],[filler,{...base,code:filler,type:2}],[helper,{...base,code:helper,type:2}],[helper2,{...base,code:helper2,type:33}],[helper3,{...base,code:helper3,type:2}]]);
 const reader=name=>{
 if(name==='c'+helper+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_GRAVE) e:SetOperation(function(e,tp) local c=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,${lab}):GetFirst() Duel.SpecialSummon(c,0,tp,tp,false,false,${test.facedown?'POS_FACEDOWN_DEFENSE':'POS_FACEUP'}) end) c:RegisterEffect(e) end`;
 if([lab,filler,helper2].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
 const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,'Missing '+name);let lua=fs.readFileSync(file,'utf8');
 if(name==='c'+boss+'.lua'){
 if(control==='no-summon')lua=lua.replace('Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEDOWN_DEFENSE)','do end');
 if(control==='any-player')lua=lua.replace('eg:IsExists(Card.IsSummonPlayer,1,nil,tp)','true').replace('c:IsSummonPlayer(p) and c:IsSetCard(SET_GHOSTRICK)','c:IsSetCard(SET_GHOSTRICK)');
 if(control==='any-set')lua=lua.replace('c:IsSummonPlayer(p) and c:IsSetCard(SET_GHOSTRICK)','c:IsSummonPlayer(p)');
 }return lua;
 };
 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 add(boss,L.HAND);if(test.multiple)add(boss,L.HAND);add(lab,L.HAND,test.opponent?1:0);if(test.special)add(helper,L.GRAVE,test.opponent?1:0);if(test.full)for(let i=0;i<4;i++)add(helper2,L.MZONE,0,P.FACEUP_ATTACK,i);
 for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:0,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 if(!activated){if(turn<(test.opponent?2:1)){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}const index=(test.set?p.monster_sets:p.activates).findIndex(c=>c.code===(test.set?lab:helper));assert(index>=0,'Actual triggering Set/Special Summon action');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:test.set?A.SELECT_MONSTER_SET:A.SELECT_ACTIVATE,index});continue;}
 const eligible=!test.opponent&&!test.full&&(test.set||!test.wrongSet);
 assert.equal(trace.some(m=>m.type===M.CHAINING&&m.code===boss),eligible,'Own Set/Ghostrick Special Summon trigger');const summons=query(L.MZONE).filter(c=>c.code===boss);assert.equal(summons.length,eligible?(test.multiple?2:1):0,'Actual hand summon count');const summoned=summons[0];if(eligible){const move=trace.find(m=>m.type===M.MOVE&&m.card===boss&&m.to.location===L.MZONE);assert.equal(move.from.location,L.HAND,'Actual hand origin');assert(move.to.position&P.FACEDOWN,'Printed face-down Defense summon');}else assert(query(L.HAND).some(c=>c.code===boss),'Source stays in hand');done=true;
 }

 else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===lab);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
 else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});
 else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===boss);core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
 else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x7f)!==0x7f,shift=isMonster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/ghostrick-djinn-hand'+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Actual full production Djinn hand trigger after actual Normal Set or neutral effect Special Summon. Candidate source metadata, neutral Ghostrick supporting card, native hand movement/face-down position and player/field capacity checks. No adapters; native Omega and other effects unverified',control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});


