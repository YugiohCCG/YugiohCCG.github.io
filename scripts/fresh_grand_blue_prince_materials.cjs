'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=259937946,lab=900001210,filler=900001211,helper=900001212,helper2=process.argv.includes('--official')?Number(process.argv.find(a=>a.startsWith('--recipient='))?.split('=')[1]||15989522):900001213,helper3=900001214;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['any-controller','any-set','any-princess','owner-instead'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{field:true},{opponentPrincess:true},{opponentGrandBlue:true},{wrongSet:true},{missingPrincess:true},{wrongPrincess:true},{borrowedPrincess:true},{borrowedGrandBlue:true},{lentPrincess:true},{lentGrandBlue:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:test.monster?33:test.trap?4:2,setcodes:test.wrongSet?[]:[0x27e9]}],[filler,{...base,code:filler,type:2}],[helper,{...base,code:helper,type:2}],[helper2,{...base,code:helper2,type:65,attack:1000,setcodes:[]}],[helper3,{...base,code:helper3,type:2}]]);
 cards.set(259177849,{...candidateCard(259177849)});cards.set(lab,{...base,code:lab,setcodes:test.wrongSet?[]:[0x67ee]});
 const reader=name=>{
 if(name==='c259177849.lua')return 'local s,id=GetID() function s.initial_effect(c) end';
 if(name==='c'+helper+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_EXTRA,0,nil,${boss}) ${test.borrowedPrincess||test.lentPrincess?`local pc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_MZONE,LOCATION_MZONE,nil,259177849) assert(Duel.GetControl(pc,${test.borrowedPrincess?0:1})==1,'Native Princess control transfer') assert(pc:GetOwner()==${test.borrowedPrincess?1:0} and pc:GetControler()==${test.borrowedPrincess?0:1},'Princess owner/controller seeded distinctly')`:''} ${test.borrowedGrandBlue||test.lentGrandBlue?`local pc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_MZONE,LOCATION_MZONE,nil,${lab}) assert(Duel.GetControl(pc,${test.borrowedGrandBlue?0:1})==1,'Native GrandBlue control transfer') assert(pc:GetOwner()==${test.borrowedGrandBlue?1:0} and pc:GetControler()==${test.borrowedGrandBlue?0:1},'GrandBlue owner/controller seeded distinctly')`:''} local g=Duel.GetMatchingGroup(Card.IsType,tp,LOCATION_HAND+LOCATION_MZONE,LOCATION_HAND+LOCATION_MZONE,nil,TYPE_MONSTER) assert(tc:CheckFusionMaterial(g,nil,tp)==${test.opponentPrincess||test.opponentGrandBlue||test.lentPrincess||test.lentGrandBlue||test.wrongSet||test.missingPrincess||test.wrongPrincess?'false':'true'},'Native Fusion material possession and identity') end) c:RegisterEffect(e) end`;
 if(name==='c'+helper2+'.lua'&&!process.argv.includes('--official'))return `local s,id=GetID() s.material_setcode=${test.wrongMaterial?'0x8d':'0xbd'} function s.initial_effect(c) end`;
 if([lab,filler].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
 const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,'Missing '+name);let lua=fs.readFileSync(file,'utf8');
 if(name==='c'+boss+'.lua'){if(control==='owner-instead')lua=lua.replace('c:IsControler(fc:GetControler())','c:GetOwner()==fc:GetControler()');if(control==='any-controller')lua=lua.replace('return c:IsControler(fc:GetControler())','return true');if(control==='any-set')lua=lua.replace('c:IsFusionSetCard(SET_GRAND_BLUE)','true');if(control==='any-princess')lua=lua.replace('c:IsFusionCode(CARD_GRAND_BLUE_PRINCESS)','true');
 }if(name==='procedure.lua')lua+='\n-- TEST ONLY: neutral fixture has no mandatory materials; modern engine lacks Omega mandatory-material APIs.\naux.MustMaterialCheck=function() return true end\n';if(name==='utility.lua')lua+='\n-- TEST ONLY: modern public engine lacks Omega Fusion identity methods. Neutral unchanged-code fixtures only.\nCard.IsFusionCode=Card.IsFusionCode or Card.IsCode\nCard.IsFusionSetCard=Card.IsFusionSetCard or Card.IsSetCard\n';return lua;
 };
 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
 if(!test.missingPrincess)add(test.wrongPrincess?helper2:259177849,L.MZONE,test.opponentPrincess||test.borrowedPrincess?1:0,P.FACEUP_ATTACK);add(lab,test.field||test.opponentGrandBlue||test.borrowedGrandBlue||test.lentGrandBlue?L.MZONE:L.HAND,test.opponentGrandBlue||test.borrowedGrandBlue?1:0,P.FACEUP_ATTACK,test.field||test.lentGrandBlue?1:0);add(boss,L.EXTRA);add(helper,L.HAND);
 for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.ATTACK,controller,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 if(!activated){const index=p.activates.findIndex(c=>c.code===helper);assert(index>=0,'Actual flip fixture');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 assert(query(L.EXTRA).some(c=>c.code===boss),'Material check alone does not summon source');done=true;
 }

 else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:false});
 else if(p.type===M.SELECT_CARD){let index=p.selects.findIndex(c=>c.code===lab);if(index<0)index=p.selects.findIndex(c=>c.code===helper2);if(index<0)index=0;core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
 else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.send?1:0});
 else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});
 else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===boss);core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});}
 else if(p.type===M.SELECT_PLACE){let place;for(const side of [0,1])for(const zone of [L.MZONE,L.SZONE]){const shift=side*16+(zone===L.MZONE?0:8);const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(shift+i)))===0);if(!place&&sequence!==undefined)place={player:p.player^side,location:zone,sequence};}assert(place,'Available placement');core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[place]});}
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/grand-blue-prince-materials'+(process.argv.includes('--official')?'-official-'+helper2:'')+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Native CheckFusionMaterial only: own Princess field plus own GrandBlue hand/field, opposing controller and missing/wrong identity negatives. Test-only unchanged Fusion identity aliases/no mandatory material fixture; Native control transfers validate borrowed/lent ownership distinctions. Substitute/identity-changing/native Omega open',recipient:process.argv.includes('--official')?helper2:null,control,script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+boss+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});


