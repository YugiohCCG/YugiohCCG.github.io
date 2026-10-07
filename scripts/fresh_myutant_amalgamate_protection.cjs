'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=211699737,lab=900001210,filler=900001211,helper=900001212,helper2=900001213,helper3=900001214;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-copy','no-protection','any-type','any-player','no-reset'].find(c=>process.argv.includes('--'+c));
 for(const branch of ['beast','mist','arsenal'])for(const test of [{incoming:'spell'},{incoming:'trap'},{incoming:'monster'},{incoming:branch==='beast'?'monster':branch==='mist'?'spell':'trap',own:true},{incoming:branch==='beast'?'monster':branch==='mist'?'spell':'trap',reset:'grave'},{incoming:branch==='beast'?'monster':branch==='mist'?'spell':'trap',reset:'banish'}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const wanted=branch==='beast'?34695290:branch==='mist'?61089209:7574904,other=wanted===34695290?61089209:34695290;
 const revealed=test.selfReveal?wanted:lab;
 const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:branch==='beast'?33:branch==='mist'?2:4,setcodes:[0x157]}],[filler,{...base,code:filler,type:2}],[helper,{...base,code:helper,type:test.incoming==='trap'?4:test.incoming==='monster'?33:2}],[helper2,{...base,code:helper2,type:2}],[helper3,{...base,code:helper3,type:2}]]);
 for(const code of [34695290,61089209,7574904])cards.set(code,{...base,code,type:33,setcodes:[0x157]});
 if(test.selfReveal)cards.set(wanted,{...base,code:wanted,type:33,setcodes:[0x157]});
 const reader=name=>{
 if(name==='c'+helper2+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local c=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,${boss}):GetFirst() ${test.reset==='grave'?'Duel.SendtoGrave(c,REASON_EFFECT)':'Duel.Remove(c,POS_FACEUP,REASON_EFFECT)'} Duel.SpecialSummon(c,0,tp,tp,true,true,POS_FACEUP) end) c:RegisterEffect(e) end`;
 if(name==='c'+helper+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) ${test.incoming==='monster'?'e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE)':'e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN)'} e:SetProperty(EFFECT_FLAG_CARD_TARGET) e:SetTarget(function(e,tp,eg,ep,ev,re,r,rp,chk,chkc) local f=function(c,e) return c:IsCode(${boss}) and c:IsCanBeEffectTarget(e) end if chk==0 then return Duel.IsExistingTarget(f,tp,${test.own?'LOCATION_MZONE,0':'0,LOCATION_MZONE'},1,nil,e) end Duel.SelectTarget(tp,f,tp,${test.own?'LOCATION_MZONE,0':'0,LOCATION_MZONE'},1,1,nil,e) end) e:SetOperation(function(e,tp) local tc=Duel.GetFirstTarget() if tc and tc:IsRelateToEffect(e) then Duel.Hint(HINT_NUMBER,tp,6232) end end) c:RegisterEffect(e) end`;
 if([lab,filler,helper2].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
 const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,'Missing '+name);let lua=fs.readFileSync(file,'utf8');
 if(name==='c'+boss+'.lua'){
 if(control==='no-reset')lua=lua.replace('RESET_EVENT+(RESETS_STANDARD&~(RESET_LEAVE+RESET_TOGRAVE)),1','0,1');
 if(control==='no-copy')lua=lua.replace('e:GetHandler():CopyEffect(code,RESET_EVENT+(RESETS_STANDARD&~(RESET_LEAVE+RESET_TOGRAVE)),1)','do end');
 }
 if(['c34695290.lua','c61089209.lua','c7574904.lua'].includes(name)){
 if(control==='no-protection')lua=lua.replace(/e2:SetValue\(c[0-9]+.ctval\)/,'e2:SetValue(aux.FALSE)');
 if(control==='any-type')lua=lua.replace(/ and re:IsActiveType\(TYPE_[A-Z]+\)/,'');
 if(control==='any-player')lua=lua.replace('aux.tgoval(e,re,rp) and ','');
 }return lua;
 };
 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0,resetDone=false;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 add(boss,L.MZONE,0,P.FACEUP_ATTACK);add(lab,L.DECK);add(wanted,L.DECK);add(helper2,L.HAND);
 add(helper,test.incoming==='trap'?L.SZONE:test.incoming==='monster'?L.MZONE:L.HAND,test.own?0:1,test.incoming==='trap'?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK,test.incoming==='monster'&&test.own?1:0);
 for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,controller,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 if(!activated){const index=p.activates.findIndex(c=>c.code===boss&&String(c.description)===String(133699737*16+1));assert(index>=0,'Actual copy ignition');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 if(!second){assert(query(L.GRAVE).some(c=>c.code===lab),'Reveal actually sent');if(test.reset&&!resetDone){const index=p.activates.findIndex(c=>c.code===helper2);assert(index>=0,'Actual reset helper');resetDone=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}if(test.reset){assert(trace.some(m=>m.type===M.MOVE&&m.card===boss&&m.to.location===(test.reset==='grave'?L.GRAVE:L.REMOVED)),'Source actually leaves to reset location');assert(trace.some(m=>m.type===M.SPSUMMONED),'Source actually returns to field');}assert(query(L.REMOVED).some(c=>c.code===wanted),'Actual Beast banished before copying');if(turn<(test.own?(test.incoming==='trap'?3:1):2)){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}const index=p.activates.findIndex(c=>c.code===helper);const blocked=!test.own&&!test.reset&&test.incoming===(branch==='beast'?'monster':branch==='mist'?'spell':'trap');assert.equal(index>=0,!blocked,'Copied target protection type/player boundary');if(blocked){assert(query(L.MZONE).some(c=>c.code===boss),'Protected source retained');done=true;continue;}second=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 assert(trace.some(m=>m.type===M.HINT&&String(m.hint)==='6232'),'Allowed actual targeting effect resolves on source');assert(query(L.MZONE).some(c=>c.code===boss),'Target remains on field');done=true;
 }

 else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===revealed||c.code===wanted||c.code===boss);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
 else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});
 else if(p.type===M.SELECT_CHAIN){core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});}
 else if(p.type===M.SELECT_PLACE){const monster=(p.field_mask&0x7f)!==0x7f;const shift=monster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:monster?L.MZONE:L.SZONE,sequence}]});}

 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({branch,test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+branch+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/myutant-amalgamate-protection'+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Actual Amalgamate copying designated Omega Beast/Mist/Arsenal scripts, native targeting protection checked with real Card.IsCanBeEffectTarget and actual allowed targeting selections/resolution. Neutral official stats/supporting cards and seeded source. No public adapters. Native Omega, copied destruction/reset effects unverified; user confirms grant-all CopyEffect interpretation',control,official_sources:[34695290,61089209,7574904].map(code=>({code,sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'tmp/omega_scripts/c'+code+'.lua'))).digest('hex')})),script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
