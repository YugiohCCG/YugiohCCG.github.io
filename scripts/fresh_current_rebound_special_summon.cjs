'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=259687425,lab=900001210,filler=900001211,helper=900001212,helper2=process.argv.includes('--official')?Number(process.argv.find(a=>a.startsWith('--recipient='))?.split('=')[1]||15989522):900001213,helper3=900001214;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-negate','no-summon-branch'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{equal:true},{fewer:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[boss,candidateCard(boss)],[helper,{...base,code:helper,type:33}],[filler,{...base,code:filler,type:2}],[lab,{...base,code:lab}],[900004603,{...base,code:900004603,type:0x100004}]]);
 const reader=name=>{if(name==='c0.lua')return '';if(name==='c900004603.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_SPSUMMON) e:SetCategory(CATEGORY_DISABLE_SUMMON) e:SetCondition(function(e,tp,eg) return eg:IsExists(Card.IsCode,1,nil,900001212) end) e:SetOperation(function(e,tp,eg) Duel.NegateSummon(eg) Duel.SendtoGrave(eg,REASON_EFFECT) end) c:RegisterEffect(e) end';if(name==='c'+helper+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_FIELD) e:SetCode(EFFECT_SPSUMMON_PROC) e:SetProperty(EFFECT_FLAG_UNCOPYABLE) e:SetRange(LOCATION_HAND) e:SetCondition(function(e,c) if c==nil then return true end return Duel.GetLocationCount(c:GetControler(),LOCATION_MZONE)>0 end) c:RegisterEffect(e) end';if([lab,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8');if(name==='constant.lua')lua+='\nCHAININFO_TRIGGERING_PLAYER=2\n';if(name==='c'+boss+'.lua'){if(control==='no-summon-branch'){assert(lua.includes('if negsummon then return true end'));lua=lua.replace('if negsummon then return true end','if negsummon then return false end');}if(control==='no-negate')lua=lua.replace('Duel.NegateActivation(ev)','do end');if(control==='ignore-count')lua=lua.replace('Duel.GetFieldGroupCount(tp,LOCATION_ONFIELD,0)>=Duel.GetFieldGroupCount(tp,0,LOCATION_ONFIELD)','false');}return lua;};

 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0,attached=false;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 add(boss,L.HAND);add(helper,L.HAND);add(900004603,L.SZONE,1,P.FACEDOWN_DEFENSE,0);if(!test.equal&&!test.fewer)add(lab,L.MZONE,1,P.FACEUP_ATTACK,0);if(test.equal||test.fewer)add(lab,L.MZONE,0,P.FACEUP_ATTACK,1);if(test.fewer)add(lab,L.MZONE,0,P.FACEUP_ATTACK,2);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.ATTACK|Q.POSITION,controller,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 if(!activated){const index=p.special_summons.findIndex(c=>c.code===helper);assert(index>=0);activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SPECIAL_SUMMON,index});continue;}
 const eligible=!(test.equal||test.fewer);assert(attached,'Actual opposing CL2 selected');assert.equal(third,eligible,'Rebound Hand activation with strictly more opponent cards');assert.equal(trace.some(m=>m.type===M.SPSUMMONED),eligible,'Actual Special Summon completion preserved only when countered');assert.equal(query(L.MZONE).some(c=>c.code===helper),eligible);assert.equal(query(L.GRAVE).some(c=>c.code===helper),!eligible,'Uncountered summon negation actually sends monster GY');assert.equal(query(L.GRAVE).some(c=>c.code===boss),eligible);done=true;

 }

 else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});
 else if(p.type===M.SELECT_CARD){assert.equal(p.min,1);assert.equal(p.max,Math.min(2,test.pair||test.split||test.single?2:1));assert(p.selects.every(c=>c.code===lab||c.code===helper2),'Only monsters selectable');const indicies=test.single?[p.selects.findIndex(c=>c.code===lab)]:p.selects.map((c,i)=>i).slice(0,2);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies});}
 else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.send?1:0});
 else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});
 else if(p.type===M.SELECT_CHAIN){const response=p.selects.findIndex(c=>c.code===900004603);if(response>=0&&!attached){attached=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:response});continue;}const index=p.selects.findIndex(c=>c.code===boss);const eligible=!(test.equal||test.fewer);if(index>=0)assert(eligible,'Counter wrongly offered');if(index>=0){third=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index});continue;}core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});}
 else if(p.type===M.SELECT_PLACE){const isMonster=(p.field_mask&0x7f)!==0x7f,shift=isMonster?0:8;const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:isMonster?L.MZONE:L.SZONE,sequence}]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-rebound-special-summon'+(process.argv.includes('--official')?'-official-'+helper2:'')+(process.argv.includes('--spell-target-candidate')?'-spell-target-candidate':'')+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Actual native Special Summon attempt; opposing CATEGORY_DISABLE_SUMMON Counter EVENT_SUMMON negates/sends monster GY unless own Hand Rebound countered. Strict field counts positive/equal/fewer. Explicit triggering-player adapter loaded but summon branch does not consult it. Native Omega/Special/Flip open',legacy_chaininfo_adapter:true,recipient:process.argv.includes('--official')?helper2:null,control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});


