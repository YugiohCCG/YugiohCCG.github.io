'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=211699737,lab=900001210,filler=900001211,helper=900001212,helper2=900001213,helper3=900001214;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-copy','no-cost','no-negate','no-remove'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{trap:true},{monster:true},{own:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const wanted=34695290,other=wanted===34695290?61089209:34695290;
 const revealed=test.selfReveal?wanted:lab;
 const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:33,setcodes:test.wrongSet?[]:[0x157]}],[filler,{...base,code:filler,type:2}],[helper,{...base,code:helper,type:test.trap?4:test.monster?33:2}],[helper2,{...base,code:helper2,type:2}],[helper3,{...base,code:helper3,type:2}]]);
 for(const code of [34695290,61089209,7574904])cards.set(code,{...base,code,type:33,setcodes:[0x157]});
 if(test.selfReveal)cards.set(wanted,{...base,code:wanted,type:33,setcodes:[0x157]});
 const reader=name=>{
 if(name==='c'+helper+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) ${test.monster?'e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE)':'e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN)'} e:SetOperation(function(e,tp) Duel.Damage(1-tp,777,REASON_EFFECT) end) c:RegisterEffect(e) end`;
 if([lab,filler,helper2].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
 const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,'Missing '+name);let lua=fs.readFileSync(file,'utf8');
 if(name==='c'+boss+'.lua'){
 if(control==='no-copy')lua=lua.replace('e:GetHandler():CopyEffect(code,RESET_EVENT+(RESETS_STANDARD&~(RESET_LEAVE+RESET_TOGRAVE)),1)','do end');
 }
 if(name==='c34695290.lua'){
 if(control==='no-cost')lua=lua.replace('Duel.Remove(g,POS_FACEUP,REASON_COST)','do end');
 if(control==='no-negate')lua=lua.replace('Duel.NegateActivation(ev)','false');
 if(control==='no-remove')lua=lua.replace('Duel.Remove(eg,POS_FACEUP,REASON_EFFECT)','do end');
 }return lua;
 };
 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 add(boss,L.MZONE,0,P.FACEUP_ATTACK);add(lab,L.DECK);add(wanted,L.DECK);add(helper2,L.HAND);
 add(helper,test.trap?L.SZONE:test.monster?L.MZONE:L.HAND,test.own?0:1,test.trap?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK,test.monster&&test.own?1:0);
 for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,controller,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 if(!activated){const index=p.activates.findIndex(c=>c.code===boss&&String(c.description)===String(133699737*16+1));assert(index>=0,'Actual copy ignition');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 if(!second){assert(query(L.GRAVE).some(c=>c.code===lab),'Reveal actually sent');assert(query(L.REMOVED).some(c=>c.code===wanted),'Actual Beast banished before copying');if(turn<(test.own?1:2)){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}const index=p.activates.findIndex(c=>c.code===helper);assert(index>=0,'Actual incoming Spell/Trap/Monster effect');second=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 const eligible=!test.trap&&!test.monster&&!test.own;assert.equal(trace.some(m=>m.type===M.CHAINING&&m.code===boss&&m.chain_size===2),eligible,'Copied official Beast response eligibility');
 if(eligible){const paid=query(L.REMOVED).find(c=>c.code===helper2);assert(paid&&(paid.reason&0x80),'Copied Beast actual banish COST');assert(!trace.some(m=>m.type===M.DAMAGE),'Actual Spell activation negated');assert(query(L.REMOVED,1).some(c=>c.code===helper),'Negated opposing Spell actually banished');}
 else{assert(trace.some(m=>m.type===M.DAMAGE&&m.amount===777),'Ineligible original effect resolves');assert(query(L.HAND).some(c=>c.code===helper2),'No banishment cost for excluded response');}done=true;
 }

 else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===revealed||c.code===wanted||c.code===helper2);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
 else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});
 else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===boss);core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
 else if(p.type===M.SELECT_PLACE){const monster=(p.field_mask&0x7f)!==0x7f;const shift=monster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:monster?L.MZONE:L.SZONE,sequence}]});}

 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/myutant-amalgamate-beast'+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Production Amalgamate ignition then actual designated Omega Beast copied script/Quick response. Actual cost, opponent Spell activation negation and banishment. Neutral recipient stats and incoming/cost cards; no native Omega, other copied effects or printed CopyEffect interpretation certification',control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
