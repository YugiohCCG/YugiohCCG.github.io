'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=243420199,lab=900001210,filler=900001211,helper=900001212,helper2=process.argv.includes('--official')?Number(process.argv.find(a=>a.startsWith('--recipient='))?.split('=')[1]||15989522):900001213,helper3=900001214;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-limit','no-overlay'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{reset:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:test.spell?2:33,setcodes:test.wrongSet?[]:[0x7a34]}],[helper2,{...base,code:helper2,type:test.notXyz?33:0x800021,level:4,setcodes:test.wrongRecipient?[]:[0x7a34]}],[helper3,{...base,code:helper3,type:2}],[filler,{...base,code:filler,type:2}]]);
 const reader=name=>{if(name==='c'+lab+'.lua'&&test.blocked)return 'local s,id=GetID() function s.initial_effect(c) local z=Effect.CreateEffect(c) z:SetType(EFFECT_TYPE_SINGLE) z:SetCode(EFFECT_CANNOT_TO_HAND) c:RegisterEffect(z) end';if(name==='c0.lua')return '';if([lab,helper2,helper3,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){if(control==='no-limit')lua=lua.replace('e2:SetCountLimit(1,{id,1})','do end');if(control==='no-overlay')lua=lua.replace('Duel.Overlay(tc,mc)','do end');if(control==='no-cost')lua=lua.replace('e2:SetCost(aux.bfgcost)','do end');if(control==='ignore-xyz')lua=lua.replace('c:IsType(TYPE_XYZ)','true');}return lua;};

 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0,attached=false;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 add(boss,L.GRAVE);add(boss,L.GRAVE);add(lab,L.DECK);if(!test.sourceOnly)add(lab,test.grave?L.GRAVE:L.DECK);add(helper2,L.MZONE,0,P.FACEUP_ATTACK);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.ATTACK|Q.POSITION,controller,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 if(!activated){const indices=p.activates.map((c,i)=>c.code===boss?i:-1).filter(i=>i>=0);assert.equal(indices.length,2,'Both Graveyard copies initially eligible');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index:indices[0]});continue;}
 const materials=trace.filter(m=>m.type===M.MOVE&&m.card===lab&&m.to.location===L.MZONE&&m.to.sequence===0&&m.to.overlay_sequence!==undefined);assert.equal(materials.length,second?2:1,'Actual attachments before and after limit reset');if(second){assert.equal(trace.filter(m=>m.type===M.MOVE&&m.card===boss&&m.to.location===L.REMOVED).length,2,'Both copies actually banish for cost');done=true;continue;}
 const index=p.activates.findIndex(c=>c.code===boss);if(turn<3){assert(index<0,'Shared once-per-turn Graveyard use across copies');if(!test.reset){done=true;continue;}core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP,index:0});continue;}assert(index>=0,'Second Graveyard copy eligible next ownturn');second=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});

 }

 else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});
 else if(p.type===M.SELECT_CARD){assert.equal(p.min,1);assert.equal(p.max,1);assert(p.selects.every(c=>c.code===lab||c.code===helper2||c.code===boss));core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[p.selects.some(c=>c.code===lab)?p.selects.findIndex(c=>c.code===lab):p.selects.findIndex(c=>c.code===helper2)]});}
 else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.send?1:0});
 else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});
 else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
 else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x7f)!==0x7f,shift=isMonster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-melody-division-attach-limit'+(process.argv.includes('--official')?'-official-'+helper2:'')+(process.argv.includes('--spell-target-candidate')?'-spell-target-candidate':'')+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Melody two Graveyard copies native shared once-per-turn banish/overlay effect; second copy excluded same turn then actual banishcost/second Deckoverlay after next ownturn reset. No adapters. Interruption/Necrovalley/nativeOmega OPEN',legacy_chaininfo_adapter:false,recipient:process.argv.includes('--official')?helper2:null,control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});


