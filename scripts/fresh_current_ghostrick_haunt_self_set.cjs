'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=241540236,lab=900001210,filler=900001211,helper=900001212,helper2=process.argv.includes('--official')?Number(process.argv.find(a=>a.startsWith('--recipient='))?.split('=')[1]||15989522):900001213,helper3=900001214;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-set','no-redirect','no-delay','ignore-level'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{decline:true},{wrongSet:true},{wrongLevel:true},{field:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,level:test.wrongLevel?2:1,setcodes:test.wrongSet?[]:[0x8d]}],[helper2,{...base,code:helper2}],[helper3,{...base,code:helper3,type:2,setcodes:[0x8d]}],[filler,{...base,code:filler,type:2}]]);
 const reader=name=>{if(name==='c0.lua')return '';if(name==='c'+lab+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_HAND+LOCATION_MZONE) e:SetCountLimit(1) e:SetOperation(function(e,tp) Duel.Recover(tp,100,REASON_EFFECT) end) c:RegisterEffect(e) end';if(name==='c'+helper2+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetOperation(function(e,tp) Duel.Destroy(Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_SZONE,0,nil,'+boss+'),REASON_EFFECT) end) c:RegisterEffect(e) end';if([helper3,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){if(control==='no-delay')lua=lua.replace('e2:SetProperty(EFFECT_FLAG_DELAY)','do end');if(control==='no-set')lua=lua.replace('Duel.SSet(tp,c)','0');if(control==='no-redirect')lua=lua.replace('e1:SetValue(LOCATION_REMOVED)','e1:SetValue(LOCATION_GRAVE)');if(control==='ignore-level')lua=lua.replace('rc:IsLevel(1)','true');}return lua;};

 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0,attached=false;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 add(boss,L.GRAVE);add(lab,test.field?L.MZONE:L.HAND,0,P.FACEUP_ATTACK);add(helper2,L.MZONE,0,P.FACEUP_ATTACK,1);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.ATTACK|Q.POSITION,controller,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 const eligible=!(test.decline||test.wrongSet||test.wrongLevel||test.field);if(!activated){const index=p.activates.findIndex(c=>c.code===lab);assert(index>=0);activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 if(!second){assert.equal(query(L.SZONE).some(c=>c.code===boss&&(c.position&P.FACEDOWN_DEFENSE)),eligible,'Actual optional native Graveyard selfSet');assert.equal(query(L.GRAVE).some(c=>c.code===boss),!eligible);if(!eligible){done=true;continue;}const index=p.activates.findIndex(c=>c.code===helper2);assert(index>=0);second=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 assert(query(L.REMOVED).some(c=>c.code===boss),'Recovered Haunt actually banished when destroyed');assert(!query(L.GRAVE).some(c=>c.code===boss));done=true;

 }

 else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});
 else if(p.type===M.SELECT_CARD){assert.equal(p.min,1);assert.equal(p.max,1);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[p.selects.some(c=>c.code===helper2)?p.selects.findIndex(c=>c.code===helper2):p.selects.findIndex(c=>c.code===lab)]});}
 else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.send?1:0});
 else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:!test.decline});
 else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.selects?.some(c=>c.code===boss)&&!test.decline?p.selects.findIndex(c=>c.code===boss):p.forced?0:null});
 else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x7f)!==0x7f,shift=isMonster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-ghostrick-haunt-self-set'+(process.argv.includes('--official')?'-official-'+helper2:'')+(process.argv.includes('--spell-target-candidate')?'-spell-target-candidate':'')+(process.argv.includes('--delay-probe')?'-delay-probe':'')+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Ghostrick Haunt native Level1Ghostrick Hand effect chain => optional GYselfSet then actual destruction banishredirect. Decline/wrongset/wronglevel/fieldorigin excludes. Neutral ignition isolates native EVENT_CHAINING. No adapters. Interruption/other leavefieldroutes/nativeOmega OPEN',legacy_chaininfo_adapter:false,recipient:process.argv.includes('--official')?helper2:null,control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});


