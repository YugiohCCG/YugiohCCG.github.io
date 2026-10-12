'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=210716547,lab=900001210,filler=900001211,helper=900001212,helper2=process.argv.includes('--official')?Number(process.argv.find(a=>a.startsWith('--recipient='))?.split('=')[1]||15989522):900001213,helper3=900001214;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-send','allow-any','no-lock'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{normal:true},{spell:true},{wrongSet:true},{opponent:true},{absent:true},{lock:true},{decline:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:4,attribute:32,race:128n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:test.spell?2:17,setcodes:test.wrongSet?[]:[0xc1c]}],[helper,{...base,code:helper}],[helper2,{...base,code:helper2}],[filler,{...base,code:filler,type:2}]]);
 const reader=name=>{if(name==='c0.lua')return '';if(name==='c'+helper+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_HAND,0,nil,210716547) Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP) end) c:RegisterEffect(e) ${test.lock&&control!=='no-lock'?'local l=Effect.CreateEffect(c) l:SetType(EFFECT_TYPE_FIELD) l:SetCode(EFFECT_CANNOT_TO_GRAVE) l:SetRange(LOCATION_MZONE) l:SetTargetRange(LOCATION_DECK,0) c:RegisterEffect(l)':''} end`;if(name==='c'+helper2+'.lua')return `local s,id=GetID() function s.initial_effect(c) ${(test.indestructible||test.blockedPlayer!==undefined)?'local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_INDESTRUCTABLE_EFFECT) e:SetCondition(function(e) return '+(test.indestructible?'true':'e:GetHandler():GetControler()=='+test.blockedPlayer)+' end) e:SetValue(1) c:RegisterEffect(e)':''} end`;if([lab,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){if(control==='no-send')lua=lua.replace('Duel.SendtoGrave(g,REASON_EFFECT)','do end');if(control==='allow-any')lua=lua.replace('c:IsSetCard(SET_ALDREZ) and c:IsAbleToGrave()','c:IsAbleToGrave()');}return lua;};
 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0,attached=false,offered=0;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0,owner=player)=>core.duelNewCard(duel,{team:owner,duelist:0,code,controller:player,location,sequence,position});
 add(boss,L.HAND);add(helper,L.MZONE,0,P.FACEUP_ATTACK,0);if(!test.absent)add(lab,L.DECK,test.opponent?1:0);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 if(!activated){const index=test.normal?p.summons.findIndex(c=>c.code===boss):p.activates.findIndex(c=>c.code===helper);assert(index>=0);activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:test.normal?A.SELECT_SUMMON:A.SELECT_ACTIVATE,index});continue;}
 if(test.normal)assert(query(L.GRAVE).some(c=>c.code===helper),'Actual Normal Summon tribute');const excluded=test.wrongSet||test.opponent||test.absent||test.lock;assert(query(L.MZONE).some(c=>c.code===boss),'Actual full summon');assert.equal(offered,excluded?0:1,'Printed optional trigger eligibility');assert.equal(query(L.GRAVE).some(c=>c.code===lab),!excluded&&!test.decline,'Actual own DeckGY send');if(!test.absent&&(excluded||test.decline))assert(query(L.DECK,test.opponent?1:0).some(c=>c.code===lab),'Excluded or declined actual resource retained');done=true;



 }

 else if(p.type===M.SELECT_YESNO){offered++;core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});}
 else if(p.type===M.SELECT_UNSELECT_CARD){const index=p.can_finish?null:p.select_cards.findIndex(c=>[lab,helper2,...(test.heatMaterial?[boss]:[])].includes(c.code));assert(index===null||index>=0,'Real neutral material');core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index});}
 else if(p.type===M.SELECT_TRIBUTE){assert.equal(p.selects[0].code,helper);core.duelSetResponse(duel,{type:R.SELECT_TRIBUTE,indicies:[0]});}
 else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===lab);assert(index>=0||control==='allow-any');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index>=0?index:0]});}
 else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.both&&test.send?1:0});
 else if(p.type===M.SELECT_EFFECTYN){if(p.code===boss)offered++;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:p.code===boss&&!test.decline});}
 else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:second&&offered&&!attached&&p.selects.some(c=>c.code===helper3)?(attached=true,p.selects.findIndex(c=>c.code===helper3)):p.forced?0:null});
 else if(p.type===M.SELECT_PLACE){let place;for(const [player,location,shift] of [[0,L.MZONE,0],[0,L.SZONE,8],[1,L.MZONE,16],[1,L.SZONE,24]]){const order=location===L.MZONE?[2,0,1,2,3,4,5,6]:[2,0,1,2,3,4];const sequence=order.find(i=>(p.field_mask&(1<<(shift+i)))===0);if(sequence!==undefined){place={player:player===0?p.player:1-p.player,location,sequence};break;}}assert(place);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[place]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-clock-of-aldrez-deck-send'+(process.argv.includes('--occupied-guard-comparison')?'-occupied-guard-comparison':'')+(control?'-'+control:'')+'.json'),JSON.stringify({in_memory_occupied_guard:process.argv.includes('--occupied-guard-comparison'),scope:'Full production Morbydrip actual Special Summon/target/column placement; occupied destination probe. No adapters.',control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});

