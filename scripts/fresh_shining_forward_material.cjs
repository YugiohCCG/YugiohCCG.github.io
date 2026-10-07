'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=232038002,lab=900001210,filler=900001211,helper=900001212,helper2=900001213,helper3=900001214;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-grant'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{wrongSet:true},{noMaterial:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const wanted=test.spell?61089209:test.trap?7574904:34695290,other=wanted===34695290?61089209:34695290;
 const revealed=test.selfReveal?wanted:lab;
 const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:2,level:test.xyz?4:test.link?1:2,link_marker:test.link?2:0,setcodes:test.wrongSet?[]:[0x8d]}],[filler,{...base,code:filler,type:2}],[helper,{...base,code:helper,type:2}],[helper2,{...base,code:helper2,type:0x800021,level:4,setcodes:test.wrongSet?[]:[0x7a34]}],[helper3,{...base,code:helper3,type:2}]]);
 const reader=name=>{
 if(name==='c'+helper+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local host=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_MZONE,0,nil,${helper2}) local g=Duel.GetMatchingGroup(function(c) return c:IsCode(${boss}) or c:IsCode(${helper3}) end,tp,LOCATION_MZONE,0,nil) Duel.Overlay(host,g) end) c:RegisterEffect(e) end`;
 if(name==='c'+lab+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) Duel.Damage(1-tp,500,REASON_EFFECT) end) c:RegisterEffect(e) end';
 if([filler,helper2,helper3].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
 const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,'Missing '+name);let lua=fs.readFileSync(file,'utf8');
 if(name==='c'+boss+'.lua'){
 if(control==='no-grant')lua=lua.replace('e3:SetType(EFFECT_TYPE_XMATERIAL+EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)','e3:SetType(EFFECT_TYPE_SINGLE)');
 if(control==='no-cost')lua=lua.replace('e:GetHandler():RemoveOverlayCard(tp,1,1,REASON_COST)','do end');
 if(control==='no-position')lua=lua.replace('Duel.ChangePosition(tc,POS_FACEDOWN_DEFENSE)','do end');
 if(control==='no-count')lua=lua.replace('e6:SetCountLimit(1)','do end');
 }return lua;
 };
 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 add(helper2,L.MZONE,0,P.FACEUP_ATTACK);
 if(!test.noMaterial)add(boss,L.MZONE,0,P.FACEUP_ATTACK,1);
 if(test.count)add(helper3,L.MZONE,0,P.FACEUP_ATTACK,2);
 add(helper,L.HAND);add(lab,L.HAND,1);
 for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION|Q.REASON|Q.OVERLAY_CARD,controller,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 if(!activated){const index=p.activates.findIndex(c=>c.code===helper);assert(index>=0);activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 if(turn===1){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
 if(!second){const index=p.activates.findIndex(c=>c.code===lab);assert(index>=0,'Opponent Spell activation');second=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 assert.equal(trace.filter(m=>m.type===M.DAMAGE&&m.player===0&&m.amount===500).length,test.wrongSet||test.noMaterial?1:0,'Material Spell negation result');done=true;
 }

 else if(p.type===M.SELECT_CARD){const preferred=test.count&&p.selects.some(c=>c.code===helper3)?helper3:lab;let index=p.selects.findIndex(c=>c.code===preferred);if(index<0)index=p.selects.findIndex(c=>c.code===boss);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
 else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});
 else if(p.type===M.SELECT_CHAIN){const index=-1;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
 else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x7f)!==0x7f,shift=isMonster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/shining-forward-material'+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Forward Division full source, seeded neutral Xyz host, actual Overlay and opponent Spell damage; matching host and missing-material negatives. Proper Xyz Summon and native Omega remain open',control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});


