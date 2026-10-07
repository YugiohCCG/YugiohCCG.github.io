'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=211699737,lab=900001210,filler=900001211,helper=900001212,helper2=900001213,helper3=900001214;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['wrong-branch','no-send','no-banish','no-copy','no-count','allow-missing'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{spell:true},{trap:true},{missingBoss:true},{wrongSet:true},{absent:true},{count:true},{missingBoss:true,spell:true},{missingBoss:true,trap:true},{selfReveal:true},{selfReveal:true,pair:true},{targetLost:true},{revealLost:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const wanted=test.spell?61089209:test.trap?7574904:34695290,other=wanted===34695290?61089209:34695290;
 const revealed=test.selfReveal?wanted:lab;
 const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:test.spell?2:test.trap?4:17,setcodes:test.wrongSet?[]:[0x157]}],[filler,{...base,code:filler,type:2}],[helper,{...base,code:helper,type:2}],[helper2,{...base,code:helper2,type:2}],[helper3,{...base,code:helper3,type:2}]]);
 for(const code of [34695290,61089209,7574904])cards.set(code,{...base,code,type:33,setcodes:[]});
 if(test.selfReveal)cards.set(wanted,{...base,code:wanted,type:33,setcodes:[0x157]});
 const reader=name=>{
 if(name==='c'+helper+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_QUICK_O) e:SetCode(EVENT_CHAINING) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${boss}) end) e:SetOperation(function(e,tp) local g=Duel.GetMatchingGroup(Card.IsCode,1-tp,LOCATION_DECK,0,nil,${test.revealLost?revealed:wanted}) Duel.Remove(g,POS_FACEUP,REASON_EFFECT) end) c:RegisterEffect(e) end`;
 if([34695290,61089209,7574904].some(c=>name==='c'+c+'.lua')){const code=Number(name.slice(1,-4));return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetDescription(aux.Stringid(id,0)) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) Duel.Hint(HINT_NUMBER,tp,${code}) end) c:RegisterEffect(e) end`;}
 if([lab,filler].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
 const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,'Missing '+name);let lua=fs.readFileSync(file,'utf8');
 if(name==='c'+boss+'.lua'){
 if(control==='wrong-branch')lua=lua.replace('and BEAST or ((typ&TYPE_SPELL)~=0 and MIST or ARSENAL)','and MIST or ((typ&TYPE_SPELL)~=0 and ARSENAL or BEAST)');
 if(control==='no-send')lua=lua.replace('Duel.SendtoGrave(rc,REASON_EFFECT)==0 or not rc:IsLocation(LOCATION_GRAVE)','false');
 if(control==='no-banish')lua=lua.replace('Duel.Remove(tc,POS_FACEUP,REASON_EFFECT)>0 and tc:IsLocation(LOCATION_REMOVED)','true');
 if(control==='no-copy')lua=lua.replace('e:GetHandler():CopyEffect(code,RESET_EVENT+(RESETS_STANDARD&~(RESET_LEAVE+RESET_TOGRAVE)),1)','do end');
 if(control==='no-count')lua=lua.replace('e2:SetCountLimit(1,id+100)','do end');
 if(control==='allow-missing')lua=lua.replace(/ and Duel.IsExistingMatchingCard\(s.rmfilter,tp,LOCATION_DECK,0,1,c,code\)/,'');
 }return lua;
 };
 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 add(boss,L.MZONE,0,P.FACEUP_ATTACK);if(!test.absent)add(revealed,L.DECK);
 if(!test.selfReveal||!!test.pair)add(test.missingBoss?other:wanted,L.DECK);if(test.targetLost||test.revealLost)add(helper,L.MZONE,1,P.FACEUP_ATTACK);
 if(test.count){add(boss,L.MZONE,0,P.FACEUP_ATTACK,1);add(lab,L.DECK);add(wanted,L.DECK);}
 for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,controller:0,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 const index=p.activates.findIndex(c=>c.code===boss&&String(c.description)===String(133699737*16+1));
 if(!activated){const eligible=!test.missingBoss&&!test.wrongSet&&!test.absent&&(!test.selfReveal||!!test.pair);assert.equal(index>=0,eligible,'Reveal branch activation availability');if(index<0){done=true;continue;}activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 if(test.revealLost){assert(trace.some(m=>m.type===M.CHAINING&&m.code===helper),'Actual reveal-loss chain');assert(!query(L.GRAVE).some(c=>c.code===revealed),'Moved reveal is not sent again');assert(query(L.DECK).some(c=>c.code===wanted),'Recipient untouched when reveal lost');assert(!p.activates.some(c=>c.code===boss&&String(c.description)!==String(133699737*16+1)),'No copy when reveal lost');done=true;continue;}
 const sent=query(L.GRAVE).find(c=>c.code===revealed);assert(sent&&(sent.reason&0x40)&&!(sent.reason&0x80),'Revealed card sent as EFFECT, not COST');
 if(test.targetLost){assert(trace.filter(m=>m.type===M.CHAINING&&m.code===helper).length===1,'Actual recipient-loss chain');assert(!p.activates.some(c=>c.code===boss&&String(c.description)!==String(133699737*16+1)),'No copy when recipient unavailable at resolution');done=true;continue;}
 const removed=query(L.REMOVED).find(c=>c.code===wanted);assert(removed&&(removed.reason&0x40)&&!(removed.reason&0x80),'Correct branch monster banished as effect');assert(!query(L.REMOVED).some(c=>c.code===other),'Wrong branch not banished');
 assert(trace.some(m=>m.type===M.CONFIRM_CARDS),'Actual reveal confirmation');
 const copy=p.activates.findIndex(c=>c.code===boss&&String(c.description)!==String(133699737*16+1));assert(copy>=0,'Copied neutral original effect actually registered');
 if(!second){second=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index:copy});continue;}
 assert(trace.some(m=>m.type===M.HINT&&Number(m.hint)===wanted),'Copied neutral effect actually resolves branch marker');
 if(test.count){assert(index<0,'Shared copy HOPT blocks second source');assert(query(L.DECK).some(c=>c.code===lab)&&query(L.DECK).some(c=>c.code===wanted),'Second legal branch pair retained');}done=true;
 }

 else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===revealed||c.code===wanted||c.code===other);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
 else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});
 else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===helper);core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
 else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x7f)!==0x7f,shift=isMonster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/myutant-amalgamate-copy'+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Production reveal/send/banish and native CopyEffect tested in public core with seeded field source and neutral recipient scripts/metadata. Copied neutral ignition marker is not official Beast/Mist/Arsenal behavior or printed-effect interpretation certification. No native Omega verification',control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
