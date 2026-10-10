'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=259668626,lab=900001210,filler=900001211,helper=900001212,helper2=process.argv.includes('--official')?Number(process.argv.find(a=>a.startsWith('--recipient='))?.split('=')[1]||15989522):900001213,helper3=900001214;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-set','ignore-origin','no-protection'].find(c=>process.argv.includes('--'+c));
 for(const test of [{hand:true},{hand:true,rule:true},{hand:false},{hand:true,decline:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:161,setcodes:[0x12b1]}],[helper2,{...base,code:helper2,type:33,setcodes:test.wrongSet?[]:[0x12b1]}],[helper3,{...base,code:helper3,type:4}],[filler,{...base,code:filler,type:2}]]);
 const reader=name=>{if(name==='c'+lab+'.lua'&&test.blocked)return 'local s,id=GetID() function s.initial_effect(c) local z=Effect.CreateEffect(c) z:SetType(EFFECT_TYPE_SINGLE) z:SetCode(EFFECT_CANNOT_TO_HAND) c:RegisterEffect(z) end';if(name==='c'+helper2+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local z=Effect.CreateEffect(c) z:SetType(EFFECT_TYPE_IGNITION) z:SetRange(LOCATION_MZONE) z:SetCountLimit(1) z:SetOperation(function(e,tp) local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND+LOCATION_SZONE,0,nil,'+boss+') '+'Duel.SendtoGrave(g,'+(test.rule?'REASON_RULE':'REASON_EFFECT')+')'+' end) c:RegisterEffect(z) end';if(name==='c'+helper3+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local z=Effect.CreateEffect(c) z:SetType(EFFECT_TYPE_IGNITION) z:SetRange(LOCATION_MZONE) z:SetCountLimit(1) z:SetOperation(function(e,tp) Duel.Destroy(Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_SZONE,0,nil,'+boss+'),REASON_EFFECT) end) c:RegisterEffect(z) end';if(name==='c0.lua')return '';if([lab,helper2,helper3,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){if(control==='no-set')lua=lua.replace('Duel.SSet(tp,c)','0');if(control==='ignore-origin')lua=lua.replace('c:IsPreviousLocation(LOCATION_HAND)','true');if(control==='no-protection')lua=lua.replace('\t\tc:RegisterEffect(e1)','\t\tdo end');}return lua;};

 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:test.lowLP?999:test.exactLP?1000:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0,attached=false;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 add(boss,test.hand?L.HAND:L.SZONE,0,P.FACEUP_ATTACK);add(helper2,L.MZONE,0,P.FACEUP_ATTACK);add(helper3,L.MZONE,0,P.FACEUP_ATTACK,1);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.ATTACK|Q.POSITION,controller,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 if(!activated){const index=p.activates.findIndex(c=>c.code===helper2);assert(index>=0);activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 const eligible=test.hand&&!test.decline;assert.equal(query(L.SZONE).some(c=>c.code===boss&&(c.position&P.FACEDOWN_DEFENSE)),eligible,'Only accepted prior-Hand send sets actual facedown source');if(eligible&&!second){second=true;const index=p.activates.findIndex(c=>c.code===helper3);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}if(eligible){assert(!query(L.GRAVE).some(c=>c.code===boss),'Native destruction cannot destroy protected Set card');}done=true;

 }

 else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});
 else if(p.type===M.SELECT_CARD){assert.equal(p.min,2);assert.equal(p.max,2);assert(p.selects.every(c=>c.code===helper2));core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[0,1]});}
 else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.send?1:0});
 else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:!test.decline});
 else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:p.selects?.findIndex(c=>c.code===boss)>=0?p.selects.findIndex(c=>c.code===boss):null});
 else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x7f)!==0x7f,shift=isMonster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-domestica-self-set'+(process.argv.includes('--official')?'-official-'+helper2:'')+(process.argv.includes('--spell-target-candidate')?'-spell-target-candidate':'')+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Actual Domestica sent HandGY by effect/rule optionally Sets facedown; native effectDestroy then preserves protected Set source. FieldGY and decline do not Set. No adapters. HandTribute/recycletrigger/limits/nativeOmegaOPEN',recipient:process.argv.includes('--official')?helper2:null,control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});


