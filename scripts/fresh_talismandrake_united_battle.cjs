'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=215034223,lab=900001210,filler=900001211,helper=900001212,helper2=process.argv.includes('--official')?Number(process.argv.find(a=>a.startsWith('--recipient='))?.split('=')[1]||15989522):900001213;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,SelectBattleCMDAction:B,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-pierce','no-replacement'].find(c=>process.argv.includes('--'+c));
 for(const test of [{arm:215921734},{arm:248788543},{arm:248788543,decline:true}]){
 const helper3=test.arm;
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:test.spell?2:33,attribute:test.wrongAttribute?1:2,setcodes:[]}],[filler,{...base,code:filler,type:2}],[helper,{...base,code:helper,type:2}],[helper2,{...base,code:helper2,type:65,attack:1000,setcodes:[]}],[helper3,{...base,code:helper3,type:2}]]);
 cards.set(900001214,{...base,code:900001214,attack:2000,defense:100});cards.set(lab,{...base,code:lab,type:65538});
 cards.set(helper2,{...base,code:helper2,type:test.notFusion?17:65,level:6,attribute:test.wrongAttribute?16:32,race:test.wrongRace?1n:128n});cards.set(helper3,candidateCard(helper3));
 const reader=name=>{
 if(name==='c'+helper3+'.lua'&&!process.argv.includes('--canonical-arms'))return 'local s,id=GetID() function s.initial_effect(c) end';


 if(name==='c'+helper+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,${test.notFusion?'LOCATION_HAND':'LOCATION_EXTRA'},0,nil,${helper2}) Duel.SpecialSummon(tc,0,tp,${test.opponent?1:0},false,false,POS_FACEUP) local ec=Duel.GetFirstMatchingCard(Card.IsCode,tp,${test.opponentEquip?'0,LOCATION_HAND':'LOCATION_HAND,0'},nil,${lab}) assert(Duel.Equip(${test.opponentEquip?1:0},ec,tc),"Native additional equip") end) c:RegisterEffect(e) end`;
 if(name==='c'+helper2+'.lua'&&!process.argv.includes('--official'))return `local s,id=GetID() s.material_setcode=${test.wrongMaterial?'0x8d':'0xbd'} function s.initial_effect(c) end`;
 if(name==='c'+lab+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_EQUIP_LIMIT) e:SetValue(function(e,c) return c:IsCode(${helper2}) end) c:RegisterEffect(e) end`;
 if(name==='c900001214.lua')return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c'+filler+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) ${control==='no-removal'?'do end':`Duel.Destroy(Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_SZONE,0,nil,${lab}),REASON_EFFECT)`} end) c:RegisterEffect(e) end`;if(name==='c0.lua')return '';
 const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,'Missing '+name);let lua=fs.readFileSync(file,'utf8');
 if(name==='c'+boss+'.lua'){if(control==='no-pierce')lua=lua.replace('e1:SetCode(EFFECT_PIERCE)','e1:SetCode(EFFECT_UPDATE_DEFENSE)');if(control==='no-replacement')lua=lua.replace('\t\ts.battle_replace(ec)','\t\tdo end');
 }return lua;
 };
 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0,attacked=false;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 add(900001214,L.MZONE,1,test.arm===215921734?P.FACEUP_DEFENSE:P.FACEUP_ATTACK);add(boss,L.GRAVE);add(filler,L.HAND);add(helper,L.HAND);add(helper2,test.notFusion?L.HAND:L.EXTRA);add(helper3,L.DECK);add(lab,L.HAND,test.opponentEquip?1:0);

 for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.ATTACK|Q.DEFENSE|Q.POSITION,controller,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 if(!activated){if(false){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP,index:0});continue;}const index=p.activates.findIndex(c=>c.code===helper);assert(index>=0,'Actual Spell Special Summon');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 const battleTurn=test.arm===215921734?3:2;if(turn<battleTurn){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP,index:0});continue;}assert.equal(turn,battleTurn);core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_BP,index:0});

 }

 else if(p.type===M.SELECT_BATTLECMD){if(!attacked){const index=p.attacks.findIndex(c=>c.code===(test.arm===215921734?helper2:900001214));assert(index>=0,'Native attacker available');attacked=true;core.duelSetResponse(duel,{type:R.SELECT_BATTLECMD,action:B.SELECT_BATTLE,index});continue;}if(test.arm===215921734){assert(trace.some(m=>m.type===M.DAMAGE&&m.player===1&&m.amount===500),'Actual piercing damage500');assert(query(L.MZONE).some(c=>c.code===helper2),'Halberd recipient remains');}else{assert.equal(query(L.MZONE).some(c=>c.code===helper2),!test.decline,'Sabre accepted survival/declined destruction');assert(query(L.GRAVE).some(c=>c.code===helper3),'Sabre leaves field');assert(trace.some(m=>m.type===M.DAMAGE&&m.player===0&&m.amount===900),'Actual battle damage900');}done=true;}
 else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});
 else if(p.type===M.SELECT_CARD){let index=p.selects.findIndex(c=>c.code===(test.arm===215921734?900001214:helper2));if(index<0)index=p.selects.findIndex(c=>c.code===helper3);if(index<0)index=0;core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
 else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.send?1:0});
 else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:p.code===boss||!test.decline});
 else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===boss);core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
 else if(p.type===M.SELECT_PLACE){const oppositeMonster=(p.field_mask&0x7f)===0x7f&&((p.field_mask>>>16)&0x7f)!==0x7f;const isMonster=oppositeMonster||(p.field_mask&0x7f)!==0x7f,shift=oppositeMonster?16:isMonster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:oppositeMonster?1-p.player:p.player,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/talismandrake-united-battle'+(process.argv.includes('--canonical-arms')?'-canonical':'')+(process.argv.includes('--official')?'-official-'+helper2:'')+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'United fullsource actual GY equip trigger; native Halberd piercing and Sabre battle replacement accepted/declined. Extra neutral Equip affects Sabre ATK; Arms fullLua when canonical_arms=true; otherwise neutralLua. Arms fullLua when canonical_arms=true; otherwise neutralLua/no adapters/bypass; remainingeffects/native Omega open',canonical_arms:process.argv.includes('--canonical-arms'),supporting_scripts_sha256:process.argv.includes('--canonical-arms')?Object.fromEntries([...new Set(results.map(r=>r.test.arm))].map(code=>[code,crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+code+'.lua'))).digest('hex')])):null,recipient:process.argv.includes('--official')?helper2:null,control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});


