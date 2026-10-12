'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=216140411,lab=900001210,filler=900001211,helper=900001212,helper2=process.argv.includes('--official')?Number(process.argv.find(a=>a.startsWith('--recipient='))?.split('=')[1]||15989522):900001213,helper3=900001214;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-search','deck-only','allow-any'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{banished:true},{spell:true},{spell:true,banished:true},{down:true,banished:true},{wrongSet:true},{wrongType:true},{opponent:true},{noResource:true},{decline:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const search2=test.spell?256930605:213266433;
 const cards=new Map([[256930605,candidateCard(256930605)],[boss,candidateCard(boss)],[213266433,candidateCard(213266433)],[lab,{...base,code:lab,type:test.wrongType?2:17,setcodes:test.wrongType?[0x813]:[]}],[helper2,{...base,code:helper2}],[helper3,{...base,code:helper3,type:0x20004,setcodes:[0x6167]}],[filler,{...base,code:filler,type:2}]]);
 const reader=name=>{if(name==='c0.lua')return '';if(name==='c'+helper2+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetOperation(function(e,tp) local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_HAND,0,nil,'+boss+') assert(Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)>0) end) c:RegisterEffect(e) end';if([lab,helper3,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){if(control==='no-search')lua=lua.replace('Duel.SendtoHand(tc,nil,REASON_EFFECT)','do end');if(control==='deck-only')lua=lua.replaceAll('LOCATION_DECK+LOCATION_REMOVED','LOCATION_DECK');if(control==='allow-any')lua=lua.replace('(c:IsCode(CARD_FRUTEIFICATION) or (c:IsSetCard(SET_FRUTE) and c:IsType(TYPE_MONSTER)))','true').replace('(not c:IsLocation(LOCATION_REMOVED) or c:IsFaceup())','true');}return lua;};

 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0,attached=false,offered=0;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 add(boss,L.HAND);if(!(test.noResource||test.wrongSet||test.wrongType))add(search2,test.banished?L.REMOVED:L.DECK,test.opponent?1:0,test.down?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK);if(test.both)add(256930605,L.GRAVE);add(lab,test.grave?L.GRAVE:L.DECK);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.ATTACK|Q.POSITION,controller,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 const eligible=!(test.noResource||test.wrongSet||test.wrongType||test.down||test.opponent);if(!activated){const index=p.activates.findIndex(c=>c.code===boss);assert(index>=0,'Optional search permits activation without resource');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}assert(trace.some(m=>m.type===M.CHAINING&&m.code===boss),'Actual Fruteopia activation');assert.equal(offered,eligible?1:0,'Optional offer eligibility');const resolved=eligible&&!test.decline;assert.equal(query(L.HAND).some(c=>c.code===search2),resolved,'Actual optional search');assert.equal(query(L.HAND).length,resolved?1:0);if(resolved)assert(trace.some(m=>m.type===M.MOVE&&m.card===search2&&m.from.location===(test.banished?L.REMOVED:L.DECK)&&m.to.location===L.HAND));assert(query(L.SZONE).some(c=>c.code===boss),'Fruteopia remains onfield');done=true;

 }

 else if(p.type===M.SELECT_YESNO){offered++;core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});}
 else if(p.type===M.SELECT_CARD){assert(p.selects.every(c=>[search2,256930605].includes(c.code)&&c.controller===0),'Only eligible own archetype monsters');const index=p.selects.findIndex(c=>c.code===(test.chooseGrave?256930605:search2));assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
 else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.both&&test.send?1:0});
 else if(p.type===M.SELECT_EFFECTYN){offered++;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:!test.decline});}
 else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
 else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x7f)!==0x7f,shift=isMonster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-fruteopia-search'+(process.argv.includes('--official')?'-official-'+helper2:'')+(process.argv.includes('--spell-target-candidate')?'-spell-target-candidate':'')+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Full Fruteopia actual optional activation search full HangingFrute/Fruteification Deck/faceupbanished; exclusions/decline; source retained onfield; native name-change probe pending. Neutral ineligible card. No adapters; interruption/locks/activationlimit/nativeOmega/fullcard OPEN',legacy_chaininfo_adapter:false,recipient:process.argv.includes('--official')?helper2:null,control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});


