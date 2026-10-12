'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=210506870,lab=900001210,filler=900001211,helper=900001212,helper2=process.argv.includes('--official')?Number(process.argv.find(a=>a.startsWith('--recipient='))?.split('=')[1]||15989522):900001213,helper3=900001214;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-fusion','no-material','no-procedure'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{field:true},{heatMaterial:true},{wrongRace:true},{absent:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:4,attribute:32,race:128n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const fusion=227362839;
 const cards=new Map([[boss,candidateCard(boss)],[fusion,candidateCard(fusion)],[lab,{...base,code:lab,race:test.wrongRace?1n:128n}],[helper2,{...base,code:helper2}],[filler,{...base,code:filler,type:2}]]);
 const reader=name=>{if(name==='c0.lua')return '';if([lab,helper2,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){if(control==='no-fusion')lua=lua.replace('Duel.SpecialSummon(fc,SUMMON_TYPE_FUSION,tp,tp,false,false,POS_FACEUP)>0','false');if(control==='no-material')lua=lua.replace('Duel.SendtoGrave(mat,REASON_EFFECT+REASON_MATERIAL+REASON_FUSION)','do end');if(control==='no-procedure')lua=lua.replace('fc:CompleteProcedure()','do end');}if(name==='c'+fusion+'.lua'&&process.argv.includes('--attribute-diagnostic'))lua=lua.replace('c:IsFusionAttribute(ATTRIBUTE_DARK)','c:IsAttribute(ATTRIBUTE_DARK)');return lua;};
 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0,attached=false,offered=0;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 add(boss,L.MZONE,0,P.FACEUP_ATTACK);add(fusion,L.EXTRA);if(!test.absent)add(lab,test.field?L.MZONE:L.HAND,0,P.FACEUP_ATTACK,1);if(!test.heatMaterial&&!test.absent&&!test.wrongRace)add(helper2,L.HAND);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.ATTACK|Q.POSITION,controller,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 if(!activated){const index=p.activates.findIndex(c=>c.code===boss&&c.location===L.MZONE&&BigInt(c.description)===BigInt(132506870)*16n+2n);const excluded=!!(test.absent||test.wrongRace); if(excluded){assert.equal(index,-1,'Insufficient actual materials');done=true;continue;}assert(index>=0,'Fusion ignition offered');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 assert(query(L.MZONE).some(c=>c.code===fusion),'Actual full Pyre Fusion summon');assert(query(L.GRAVE).some(c=>c.code===lab),'Actual neutral material sent to GY');if(test.heatMaterial)assert(query(L.EXTRA).some(c=>c.code===boss),'Pendulum material goes faceup Extra');else assert(query(L.GRAVE).some(c=>c.code===helper2),'Second actual material sent to GY');assert(trace.some(m=>m.type===M.SPSUMMONING&&m.cards?.some(c=>c.code===fusion))||query(L.MZONE).some(c=>c.code===fusion),'Native Fusion arrival');done=true;

 }

 else if(p.type===M.SELECT_YESNO){offered++;core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});}
 else if(p.type===M.SELECT_UNSELECT_CARD){const index=p.can_finish?null:p.select_cards.findIndex(c=>[lab,helper2,...(test.heatMaterial?[boss]:[])].includes(c.code));assert(index===null||index>=0,'Real neutral material');core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index});}
 else if(p.type===M.SELECT_CARD){const wanted=p.selects.some(c=>c.code===fusion)?[fusion]:[lab,...(test.heatMaterial?[boss]:[helper2])];const indicies=p.selects.map((c,i)=>wanted.includes(c.code)?i:-1).filter(i=>i>=0).slice(0,p.max);assert(indicies.length>=p.min);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies});}
 else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.both&&test.send?1:0});
 else if(p.type===M.SELECT_EFFECTYN){if(p.code===boss)offered++;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});}
 else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:second&&offered&&!attached&&p.selects.some(c=>c.code===helper3)?(attached=true,p.selects.findIndex(c=>c.code===helper3)):p.forced?0:null});
 else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x7f)!==0x7f,shift=isMonster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-talismandrake-heat-fusion-material'+(process.argv.includes('--attribute-diagnostic')?'-attribute-diagnostic':'')+(control?'-'+control:'')+'.json'),JSON.stringify({legacy_attribute_diagnostic:process.argv.includes('--attribute-diagnostic'),scope:'Full Heat native Fusion using full Pyre and actual Hand/field/Pendulum materials. No adapters; complete procedure, interruptions, Chain Material remain OPEN',control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
