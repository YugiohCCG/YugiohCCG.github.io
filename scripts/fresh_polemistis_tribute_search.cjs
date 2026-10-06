'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=254065048,lab=900001210,filler=900001211,helper=900001212,helper2=process.argv.includes('--official')?Number(process.argv.find(a=>a.startsWith('--recipient='))?.split('=')[1]||15989522):900001213,helper3=900001214;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-search'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{trap:true},{send:true},{send:true,trap:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:test.trap?4:2,setcodes:[0x7398]}],[filler,{...base,code:filler,type:2}],[helper,{...base,code:helper,type:2}],[helper2,{...base,code:helper2,type:65,attack:1000,setcodes:[]}],[helper3,{...base,code:helper3,type:2}]]);
 cards.set(240299293,{...candidateCard(240299293),level:test.zeroLevel?0:1});cards.set(224225695,candidateCard(224225695));
 const reader=name=>{
 if(((process.argv.includes('--actual-support')||process.argv.includes('--proper-support'))?[240299293]:[240299293,224225695]).some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';
 if(name==='c'+helper+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) Duel.SpecialSummon(Duel.GetFirstMatchingCard(Card.IsCode,tp,${test.sourceGrave?'LOCATION_GRAVE':'LOCATION_EXTRA'},0,nil,${boss}),0,tp,tp,true,true,POS_FACEUP) end) c:RegisterEffect(e) end`;
 if(name==='c'+helper2+'.lua'&&!process.argv.includes('--official'))return `local s,id=GetID() s.material_setcode=${test.wrongMaterial?'0x8d':'0xbd'} function s.initial_effect(c) end`;
 if([lab,filler].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
 const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,'Missing '+name);let lua=fs.readFileSync(file,'utf8');
 if(name==='c'+boss+'.lua'){if(control==='no-search')lua=lua.replace('Duel.SendtoHand(tc,nil,REASON_EFFECT)>0','false').replace('Duel.SendtoGrave(tc,REASON_EFFECT)','do end');
 }return lua;
 };
 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 add(lab,L.DECK);add(boss,L.EXTRA);if(process.argv.includes('--proper-support')){add(224225695,L.HAND);add(240299293,L.MZONE,0,P.FACEUP_ATTACK,0);}else if(!test.noProto)add(224225695,L.MZONE,0,test.protoFacedown?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK,0);
 add(240299293,L.MZONE,0,P.FACEUP_ATTACK,1);if(!test.oneToken)add(test.wrongToken?lab:240299293,L.MZONE,test.opponentToken?1:0,P.FACEUP_ATTACK,2);
 if(test.full){add(lab,L.MZONE,0,P.FACEUP_ATTACK,3);add(lab,L.MZONE,0,P.FACEUP_ATTACK,4);}
 for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.ATTACK|Q.LEVEL,controller,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 const eligible=!test.noProto&&!test.protoFacedown&&!test.oneToken&&!test.wrongToken&&!test.opponentToken;
 if(!activated){if(process.argv.includes('--proper-support')&&!second){const index=p.special_summons.findIndex(c=>c.code===224225695);assert(index>=0,'Actual To Proto own procedure legal');second=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SPECIAL_SUMMON,index});continue;}if(test.zeroLevel)assert(query(L.MZONE).filter(c=>c.code===240299293).every(c=>c.level===1),'Native Level0 seed is clamped to1, not actual Level0');const index=p.special_summons.findIndex(c=>c.code===boss);assert.equal(index>=0,eligible,'Required controlled Token pair and face-up To Proto Ataxia');if(!eligible){done=true;continue;}activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SPECIAL_SUMMON,index});continue;}
 assert(query(L.MZONE).some(c=>c.code===boss),'Actual inherent ExtraDeck SpecialSummon resolves');assert.equal(query(L.MZONE).filter(c=>c.code===240299293).length,0,'Both Tokens tributed');assert(query(L.MZONE).some(c=>c.code===224225695),'To Proto Ataxia is not tributed');assert.equal(query(L.MZONE).length,2);assert.equal(trace.filter(m=>m.type===M.CHAINING&&m.code===boss).length,1,'Real tribute summon triggers search');const target=query(test.send?L.GRAVE:L.HAND).find(c=>c.code===lab);assert(target,'Native tribute search reaches selected destination');assert(target.reason&64,'Effect movement');if(!test.send)assert(trace.some(m=>m.type===M.CONFIRM_CARDS),'Search revealed');done=true;
 }

 else if(p.type===M.SELECT_UNSELECT_CARD){const index=p.select_cards.findIndex(c=>c.code===240299293);core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index:index>=0?index:null});}
 else if(p.type===M.SELECT_CARD){let index=p.selects.findIndex(c=>c.code===(process.argv.includes('--proper-support')&&!activated?240299293:lab));if(index<0)index=p.selects.findIndex(c=>c.code===helper2);if(index<0)index=0;core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
 else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.send?1:0});
 else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});
 else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===boss);core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
 else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x7f)!==0x7f,shift=isMonster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/polemistis-tribute-search'+(process.argv.includes('--proper-support')?'-proper-support':process.argv.includes('--actual-support')?'-actual-support':'')+(process.argv.includes('--official')?'-official-'+helper2:'')+(control?'-'+control:'')+'.json'),JSON.stringify({supporting_script_sha256:(process.argv.includes('--actual-support')||process.argv.includes('--proper-support'))?crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c224225695.lua'))).digest('hex'):null,scope:'Full source native tribute then search. Default supporting metadata neutral effects; actual-support enables full ToProto source seededfield; proper-support uses full ToProto own native hand procedure banishing third Token before Polemistis tributes remaining pair. Normal Token metadata/no separate effect script. No summon bypass/API adapter. Native Omega open',recipient:process.argv.includes('--official')?helper2:null,control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});


