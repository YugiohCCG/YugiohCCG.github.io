'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=241868535,lab=215984744,filler=900001211,helper=900001212,helper2=process.argv.includes('--official')?Number(process.argv.find(a=>a.startsWith('--recipient='))?.split('=')[1]||15989522):900001213,helper3=900001214;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,SelectBattleCMDAction:B,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-cost','no-boost','no-response'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{sourceGY:true},{sourceDown:true},{battlerHand:true},{activation:true},{effect:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const rec=test.iron?234984156:test.mine?231872299:test.kaboom?241447408:211086520;
 const cards=new Map([[helper3,{...base,code:helper3,type:0x100004}],[boss,candidateCard(boss)],[lab,candidateCard(lab)],[rec,candidateCard(rec)],[helper2,{...base,code:helper2,attack:100}],[filler,{...base,code:filler,type:2}]]);
 const reader=name=>{if(name==='c'+helper3+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_CHAINING) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode('+boss+') end) e:SetOperation(function(e,tp,eg,ep,ev) '+(control==='no-response'?'do end':test.activation?'assert(Duel.NegateActivation(ev))':test.effect?'assert(Duel.NegateEffect(ev))':test.sourceGY?'Duel.SendtoGrave(Duel.GetMatchingGroup(Card.IsCode,tp,0,LOCATION_MZONE,nil,'+boss+'),REASON_EFFECT)':test.sourceDown?'Duel.ChangePosition(Duel.GetMatchingGroup(Card.IsCode,tp,0,LOCATION_MZONE,nil,'+boss+'),POS_FACEDOWN_DEFENSE)':'Duel.SendtoHand(Duel.GetMatchingGroup(Card.IsCode,tp,0,LOCATION_MZONE,nil,'+lab+'),nil,REASON_EFFECT)')+' end) c:RegisterEffect(e) end';if(name==='c0.lua')return '';if([helper2,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){if(control==='no-cost')lua=lua.replace('Duel.SendtoGrave(g,REASON_COST)','do end');if(control==='no-boost')lua=lua.replace('e1:SetValue(500)','e1:SetValue(0)');if(control==='allow-cost')lua=lua.replace('return c:IsSetCard(SET_RECOLLECTION)','return true');}return lua;};

 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0,attached=false,offered=0;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 if(Object.keys(test).length)add(helper3,L.SZONE,1,P.FACEDOWN_DEFENSE,0);add(boss,L.MZONE,0,P.FACEUP_ATTACK,1);add(lab,L.MZONE,0,P.FACEUP_ATTACK,0);add(helper2,L.MZONE,1,P.FACEUP_ATTACK,0);if(!test.noResource)add(rec,L.DECK);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.ATTACK|Q.POSITION,controller,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 if(!test.defender&&turn<3||test.defender&&turn<2){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP,index:0});continue;}core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_BP,index:0});continue;

 }

 else if(p.type===M.SELECT_BATTLECMD){if(!third){third=true;const index=p.attacks.findIndex(c=>c.code===(test.defender?helper2:lab));assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_BATTLECMD,action:B.SELECT_BATTLE,index});continue;}assert.equal(offered,1);assert(query(L.GRAVE).some(c=>c.code===rec),'Cost retained after interruption');assert((query(L.GRAVE).find(c=>c.code===rec).reason&0x80)!==0);if(test.battlerHand){assert(query(L.HAND).some(c=>c.code===lab),'Actual battling monster returned to hand');assert(!query(L.MZONE).some(c=>c.code===lab));}else assert.equal(query(L.MZONE).find(c=>c.code===lab).attack,test.activation||test.effect?1800:2300,'Boost resolves unless negated/battler absent');if(test.sourceGY)assert(query(L.GRAVE).some(c=>c.code===boss));if(test.sourceDown)assert((query(L.MZONE).find(c=>c.code===boss).position&P.FACEDOWN_DEFENSE)!==0);if(test.activation||test.effect)assert(trace.some(m=>m.type===(test.activation?M.CHAIN_NEGATED:M.CHAIN_DISABLED)),'Native negation');done=true;}
 else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});
 else if(p.type===M.SELECT_CARD){const code=p.selects.some(c=>c.code===rec)?rec:p.selects.some(c=>c.code===filler)?filler:test.defender?lab:helper2;const index=p.selects.findIndex(c=>c.code===code);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
 else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.both&&test.send?1:0});
 else if(p.type===M.SELECT_EFFECTYN){offered++;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:!test.decline});}
 else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:offered>0&&!attached&&p.selects.some(c=>c.code===helper3)?(attached=true,p.selects.findIndex(c=>c.code===helper3)):p.forced?0:null});
 else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x7f)!==0x7f,shift=isMonster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-papa-battle-interruption'+(process.argv.includes('--official')?'-official-'+helper2:'')+(process.argv.includes('--spell-target-candidate')?'-spell-target-candidate':'')+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Papa actual full HappyServant battle and Static Deckcost, native CL2 source GY/facedown, battler Hand and activation/effect negation; paid cost retained. No adapters. No adapters; limit/reset/interruption/nativeOmega OPEN',legacy_chaininfo_adapter:false,recipient:process.argv.includes('--official')?helper2:null,control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});


