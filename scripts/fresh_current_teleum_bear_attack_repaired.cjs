'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=229875953,lab=900001210,filler=900001211,helper=900001212,helper2=process.argv.includes('--official')?Number(process.argv.find(a=>a.startsWith('--recipient='))?.split('=')[1]||15989522):900001213,helper3=900001214;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,SelectBattleCMDAction:B,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-track','no-bonus'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{persist:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[boss,candidateCard(boss)],[251699681,candidateCard(251699681)],[lab,{...base,code:lab,type:33,setcodes:test.wrongSet?[]:[0x39e2]}],[17601919,{...base,code:17601919,type:test.spellzone?0x20002:33}],[helper2,{...base,code:helper2,attack:2000,defense:1500}],[helper3,{...base,code:helper3,type:0x20002,attack:2000,defense:1500}],[filler,{...base,code:filler,type:2}]]);
 const eligible=!(test.opponent||test.facedown||test.wrongSet);
 const reader=name=>{if(name==='c0.lua')return '';if(name==='c'+helper3+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_SZONE) e:SetCondition(function(e,tp) local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_SZONE,0,nil,'+boss+') local mc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_MZONE,0,nil,'+lab+') return tc and mc and tc:GetEquipTarget()==mc end) c:RegisterEffect(e) end';if([lab,17601919,helper2,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){if(control==='no-bonus')lua=lua.replace('*500','*0');if(control==='no-equip')lua=lua.replace('Duel.Equip(tp,c,tc)','do end');if(control==='ignore-set')lua=lua.replace('c:IsSetCard(SET_VIR_PEDICAE_MORTIS)','true');if(control==='ignore-faceup')lua=lua.replace('c:IsFaceup() and','true and');}if(name==='c251699681.lua'&&control==='no-track')lua=lua.replace('Duel.RegisterFlagEffect(rp,id,0,0,1)','do end');return lua;};
 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0,attached=false;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 add(251699681,L.SZONE,0,P.FACEDOWN_DEFENSE,2);add(helper2,L.MZONE,1,P.FACEUP_ATTACK);add(boss,L.SZONE,0,P.FACEDOWN_DEFENSE);add(helper3,L.SZONE,0,P.FACEUP_ATTACK,1);add(lab,L.MZONE,test.opponent?1:0,test.facedown?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.LEVEL|Q.REASON|Q.ATTACK|Q.DEFENSE|Q.POSITION,controller,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 if(!activated){const index=p.activates.findIndex(c=>c.code===boss);assert.equal(index>=0,eligible,'Own faceup Vir Pedicae Mortis required');if(!eligible){done=true;continue;}if(eligible){activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}}
 if(turn===3){assert.equal(query(L.MZONE).find(c=>c.code===lab).attack,600,'Duel history survives turn change');assert(query(L.GRAVE).some(c=>c.code===251699681),'Trap GY does not erase history');done=true;continue;}if(turn===1){assert.equal(query(L.MZONE).find(c=>c.code===lab).attack,100);core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP,index:0});continue;}core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_BP,index:0});continue;

 }

 else if(p.type===M.SELECT_BATTLECMD){if(!second){const index=p.attacks.findIndex(c=>c.code===helper2);assert(index>=0);second=true;core.duelSetResponse(duel,{type:R.SELECT_BATTLECMD,action:B.SELECT_BATTLE,index});continue;}assert(attached,'Actual Bear Trap activated');assert(trace.some(m=>m.type===M.ATTACK),'Actual attack');assert.equal(trace.filter(m=>m.type===M.CHAINING&&m.code===251699681).length,1);assert(query(L.GRAVE,1).some(c=>c.code===helper2&&(c.reason&0x40)!==0),'Bear Trap destroys attacker');assert.equal(query(L.MZONE).find(c=>c.code===lab).attack,600,'Actual Bear Trap activation grants500');if(test.persist){core.duelSetResponse(duel,{type:R.SELECT_BATTLECMD,action:B.TO_EP,index:0});continue;}done=true;}
 else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});
 else if(p.type===M.SELECT_CARD){assert.equal(p.min,1);assert.equal(p.max,Math.min(2,test.pair||test.split||test.single?2:1));assert(p.selects.every(c=>c.code===lab),'Only intended effect choices');const indicies=test.single?[p.selects.findIndex(c=>c.code===lab)]:p.selects.map((c,i)=>i).slice(0,2);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies});}
 else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.lower?1:0});
 else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:!test.decline});
 else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:second&&!attached&&p.selects.some(c=>c.code===251699681)?(attached=true,p.selects.findIndex(c=>c.code===251699681)):p.forced?0:null});
 else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x7f)!==0x7f,shift=isMonster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-teleum-bear-attack-repaired'+(process.argv.includes('--official')?'-official-'+helper2:'')+(process.argv.includes('--spell-target-candidate')?'-spell-target-candidate':'')+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Teleum actual equip plus actual Bear Trap activation responding to opponent attack, native destruction and500 bonus. No adapters; further history/negation/native Omega OPEN',recipient:process.argv.includes('--official')?helper2:null,control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});


