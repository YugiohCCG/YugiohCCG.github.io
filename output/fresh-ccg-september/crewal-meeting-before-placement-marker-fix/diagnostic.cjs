'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=222676270,lab=900001210,filler=900001211,helper=900001212,helper2=Number(process.argv.find(a=>a.startsWith('--recipient='))?.split('=')[1]||210366076),helper3=900001214,costCard=900001215;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['placement-marker-probe'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{decline:true},{unrelated:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:33,level:5,attribute:32,race:16n,setcodes:[]}],[helper2,candidateCard(helper2)],[helper3,{...base,code:helper3,type:2}],[costCard,{...base,code:costCard,type:0x20004}],[filler,{...base,code:filler,type:2}]]);
 const reader=name=>{if(name==='c0.lua')return '';if(name==='c'+helper3+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) Duel.Damage(1-tp,100,REASON_EFFECT) end) c:RegisterEffect(e) ${control==='broad-marker'?'aux.CCGFaceupPlacementEffects=aux.CCGFaceupPlacementEffects or {} aux.CCGFaceupPlacementEffects[e]=true':''} end`;if([lab,costCard,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+helper2+'.lua'&&control==='placement-marker-probe'){const effect=helper2===210366076?'e1':'e2';lua=lua.replace(effect+':SetTarget(s.target)','aux.CCGFaceupPlacementEffects=aux.CCGFaceupPlacementEffects or {} aux.CCGFaceupPlacementEffects['+effect+']=true '+effect+':SetTarget(s.target)');}if(name==='c'+boss+'.lua'&&control==='no-negation')lua=lua.replace('Duel.NegateEffect(ev)','do end');if(name==='c'+boss+'.lua'&&control==='no-discard')lua=lua.replace('Duel.SendtoGrave(c,REASON_COST+REASON_DISCARD)','do end');return lua;};

 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0,attached=false;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 add(boss,L.HAND);add(lab,L.GRAVE,0,P.FACEUP_ATTACK);add(costCard,L.SZONE,0,P.FACEUP_ATTACK,1);add(test.unrelated?helper3:helper2,L.SZONE,0,!test.unrelated&&helper2===222654570?P.FACEUP_ATTACK:P.FACEDOWN_DEFENSE);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.ATTACK|Q.POSITION,controller,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 if(!activated){const index=p.activates.findIndex(c=>c.code===(test.unrelated?helper3:helper2));assert(index>=0);activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 const moves=trace.filter(m=>m.type===M.MOVE&&m.card===lab);assert.equal(moves.length,test.unrelated?0:test.decline?1:0,'Actual Swamp placement resolves only when response declined');const responds=!test.decline&&!test.unrelated;assert.equal(trace.some(m=>m.type===M.MOVE&&m.card===boss&&m.to.location===L.GRAVE),responds,'FrozenGirl discard matches response');if(responds)assert(query(L.GRAVE).some(c=>c.code===boss&&(c.reason&128)&&(c.reason&0x4000)),'Cost and discard reasons');if(!test.unrelated)assert(query(L.GRAVE).some(c=>c.code===costCard&&(c.reason&128)),'Actual ContinuousTrap cost remains paid');if(test.unrelated)assert(trace.some(m=>m.type===M.DAMAGE&&m.amount===100),'Unrelated damage resolves');done=true;

 }

 else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});
 else if(p.type===M.SELECT_CARD){assert.equal(p.min,1);assert.equal(p.max,1);assert(p.selects.every(c=>c.code===lab||c.code===helper2||c.code===costCard));core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[0]});}
 else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.send?1:0});
 else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});
 else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===boss);if(activated&&!second&&p.player===0){assert.equal(index>=0,!test.unrelated,'Printed placement response eligibility');if(index>=0)second=true;}core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0&&!test.decline?index:p.forced?0:null});}
 else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x7f)!==0x7f,shift=isMonster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-frozen-girl-crewal-'+helper2+(process.argv.includes('--official')?'-official-'+helper2:'')+(process.argv.includes('--spell-target-candidate')?'-spell-target-candidate':'')+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Diagnostic FrozenGirl versus two actual Crewal GY Zombie faceup SZONE placements with actual ContinuousTrap cost. Marker probe only; decline and unrelated damage reference; production unchanged/nativeOmega OPEN',legacy_chaininfo_adapter:false,secondary_script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+helper2+'.lua'))).digest('hex'),recipient:process.argv.includes('--official')?helper2:null,control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});


