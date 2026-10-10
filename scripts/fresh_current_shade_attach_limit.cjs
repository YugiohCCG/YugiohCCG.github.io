'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=259615843,lab=900001210,filler=900001211,helper=900001212,helper2=process.argv.includes('--official')?Number(process.argv.find(a=>a.startsWith('--recipient='))?.split('=')[1]||15989522):900001213,helper3=900001214;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['include-target','no-faceup-limit'].find(c=>process.argv.includes('--'+c));
 for(const test of [{xyzTarget:true},{nextTurn:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:test.spell?2:33,attribute:test.wrongAttribute?1:2,setcodes:[]}],[filler,{...base,code:filler,type:2}],[helper,{...base,code:helper,type:2}],[helper2,{...base,code:helper2,type:65,attack:1000,setcodes:[]}],[helper3,{...base,code:helper3,type:2}]]);
 cards.set(helper2,{...base,code:helper2,type:0x800021,level:6,setcodes:[0x3de1]});cards.set(lab,{...base,code:lab,type:0x800021,level:test.wrongRank?5:6,attribute:test.wrongAttribute?1:8,setcodes:test.wrongSet?[]:[0x3de1]});cards.set(helper3,{...base,code:helper3,type:test.spellTarget?0x20002:17});
 const reader=name=>{
 if(name==='c'+helper3+'.lua')return 'local s,id=GetID() function s.initial_effect(c) end';if(false)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(${test.spellEffect?'EFFECT_TYPE_ACTIVATE':'EFFECT_TYPE_IGNITION'}) e:SetCode(EVENT_FREE_CHAIN) ${test.spellEffect?'':'e:SetRange(LOCATION_MZONE)'} e:SetCountLimit(1) e:SetOperation(function(e,tp) Duel.Damage(1-tp,1000,REASON_EFFECT) end) c:RegisterEffect(e) end`;
 if(name==='c'+helper+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,LOCATION_MZONE,nil,900001210):GetFirst() local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_GRAVE,0,nil,900001211) Duel.Overlay(tc,g) ${test.facedownSupport?'Duel.ChangePosition(tc,POS_FACEDOWN_DEFENSE)':''} end) c:RegisterEffect(e) end`;
 if(name==='c'+helper2+'.lua'&&!process.argv.includes('--official'))return `local s,id=GetID() s.material_setcode=${test.wrongMaterial?'0x8d':'0xbd'} function s.initial_effect(c) end`;
 if(name==='c'+lab+'.lua')return 'local s,id=GetID() function s.initial_effect(c) end';if([filler].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
 const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,'Missing '+name);let lua=fs.readFileSync(file,'utf8');
 if(name==='c'+boss+'.lua'){if(process.argv.includes('--spell-target-candidate'))lua=lua.replace('c:IsCanBeXyzMaterial() and ','');if(control==='include-target')lua=lua.replace('0,1,1,tc)','0,1,1,nil)');if(control==='no-faceup-limit')lua=lua.replace('e:GetHandler():GetFlagEffect(id+500)==0','true');if(control==='old-target-filter')lua=lua.replace('c:IsCanOverlay()','c:IsCanBeXyzMaterial()');if(control==='no-overlay')lua=lua.replace('Duel.Overlay(x,Group.FromCards(tc))','do end');if(control==='any-recipient')lua=lua.replace('c:IsSetCard(SET_AEROCAT) and c:IsType(TYPE_XYZ)','c:IsType(TYPE_XYZ)');if(control==='no-shuffle')lua=lua.replace('Duel.SendtoDeck(rc,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)','do end');
 }return lua;
 };
 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0,attached=false;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));core.loadScript(duel,'shade_neutral_overlay_adapter.lua',`assert(Card.IsCanOverlay==nil) Card.IsCanOverlay=function(c) assert(c:IsCode(900001210,259615843,900001214,900001213,900001212),'Adapter only neutral field fixtures and Shade') return true end`);
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 add(boss,L.MZONE,0,P.FACEUP_ATTACK,1);add(lab,L.MZONE,0,P.FACEUP_ATTACK);add(helper3,test.spellTarget?L.SZONE:L.MZONE,1,P.FACEUP_ATTACK);
 if(test.xyzTarget)add(helper2,L.MZONE,0,P.FACEUP_ATTACK,2);add(helper,test.nextTurn?L.SZONE:L.HAND,0,P.FACEUP_ATTACK);if(!test.empty)add(filler,L.GRAVE);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.ATTACK|Q.POSITION,controller,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 if(test.nextTurn&&activated){if(turn===1){const host=core.duelQueryLocation(duel,{flags:Q.CODE|Q.OVERLAY_CARD,controller:0,location:L.MZONE}).filter(Boolean).find(c=>c.code===lab);assert(host.overlayCards?.includes(helper),'First attachment actually succeeded');}if(turn<3){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}assert.equal(p.activates.findIndex(c=>c.code===boss),-1,'Once while faceup persists next turn');assert(query(L.MZONE,1).some(c=>c.code===helper3),'Another legal target remains');done=true;continue;}
 if(!activated){const index=p.activates.findIndex(c=>c.code===boss);assert(index>=0);activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 const x=core.duelQueryLocation(duel,{flags:Q.CODE|Q.OVERLAY_CARD,controller:0,location:L.MZONE}).filter(Boolean).find(c=>c.code===(test.xyzTarget?helper2:lab));assert(x.overlayCards?.includes(test.xyzTarget?lab:helper),'Actual chosen distinct Xyz receiver contains target');done=true;
 }

 else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});
 else if(p.type===M.SELECT_CARD){const targeting=p.selects.some(c=>c.code===boss);if(!targeting&&test.xyzTarget)assert(!p.selects.some(c=>c.code===lab),'Target excluded from receiver menu');const desired=targeting?(test.xyzTarget?lab:helper):(test.xyzTarget?helper2:lab);const index=p.selects.findIndex(c=>c.code===desired);assert(index>=0,'Intended target/receiver available');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
 else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.send?1:0});
 else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});
 else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
 else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x7f)!==0x7f,shift=isMonster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-shade-attach-limit'+(process.argv.includes('--official')?'-official-'+helper2:'')+(process.argv.includes('--spell-target-candidate')?'-spell-target-candidate':'')+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Canonical Shade targets own Aerocat Xyz and attaches it to distinct second Xyz; receiver menu excludes target. Actual first attachment followed by next own turn with another legal target checks once-faceup flag persists. Bounded neutral IsCanOverlay adapter; leave/reset/count copies/native Omega open.',recipient:process.argv.includes('--official')?helper2:null,control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});


