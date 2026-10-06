'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=210175845,lab=900001191,filler=900001192,spellCost=900001193,recipient=900001194,results=[];
 const control=process.argv.includes('--no-count')?'no-count':process.argv.includes('--early')?'early':process.argv.includes('--late')?'late':process.argv.includes('--no-summon')?'no-summon':null;
 for(const test of [{chain:1},{chain:2},{chain:3},{chain:4},{chain:3,full:true},{chain:3,count:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:33,setcodes:test.wrongPartner?[]:[0x52f8]}],[filler,{...base,code:filler}],[spellCost,{...base,code:spellCost,type:33}],[recipient,{...base,code:recipient,type:2}]]);
  const reader=name=>{
   if(test.chain&&name==='c'+recipient+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function() end) c:RegisterEffect(e) end';
   if(name==='c'+lab+'.lua'||name==='c'+spellCost+'.lua'||name==='c'+filler+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_QUICK_O) e:SetRange(LOCATION_MZONE) e:SetCode(EVENT_FREE_CHAIN) e:SetCountLimit(1) e:SetOperation(function() end) c:RegisterEffect(e) end';
   if([lab,filler,spellCost,recipient].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){
    if(control==='no-count')lua=lua.replace('e2:SetCountLimit(1,id+100)','do end');if(control==='early')lua=lua.replace('ev>=3','ev>=2');if(control==='late')lua=lua.replace('ev>=3','ev>=4');if(control==='no-summon')lua=lua.replace('Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)','do end');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false,turn=0,secondary=false,chainStarted=false,countChecked=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(recipient,L.HAND);add(boss,L.GRAVE,0,P.FACEUP_ATTACK);if(test.count)add(boss,L.GRAVE,0,P.FACEUP_ATTACK);add(lab,L.MZONE,0,P.FACEUP_ATTACK,0);add(spellCost,L.MZONE,0,P.FACEUP_ATTACK,1);add(filler,L.MZONE,0,P.FACEUP_ATTACK,2);if(test.full){add(filler,L.MZONE,0,P.FACEUP_ATTACK,3);add(filler,L.MZONE,0,P.FACEUP_ATTACK,4);}for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,controller,location}).filter(Boolean);
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(!chainStarted){const index=p.activates.findIndex(c=>c.code===recipient);assert(index>=0,'Neutral chain starter available');chainStarted=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}assert.equal(activated,test.chain>=3&&!test.full,'Revival activation availability');assert.equal(query(L.MZONE).some(c=>c.code===boss),test.chain>=3&&!test.full,'Actual revival arrival');if(activated){assert(trace.some(m=>m.type===M.CHAINING&&m.code===boss&&m.chain_size===test.chain+1),'Native revival chain position');if(test.count){assert(countChecked,'Second-copy chain window checked');assert.equal(query(L.GRAVE).filter(c=>c.code===boss).length,1,'Second source retained GY');assert.equal(query(L.MZONE).filter(c=>c.code===boss).length,1,'Only first source revived');}else assert(!query(L.GRAVE).some(c=>c.code===boss),'Source left GY');}else assert(query(L.GRAVE).some(c=>c.code===boss),'Ineligible source remains GY');done=true;}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const location=activated?L.MZONE:L.SZONE;const offset=activated?0:8;const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(offset+i)))===0);assert(sequence!==undefined,'Legal placement slot');core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else if(p.type===M.SELECT_CHAIN){let index=-1;if(test.count&&activated&&p.player===0&&!countChecked){assert.equal(query(L.MZONE).length,3,'Two free MZONE slots before resolution');assert.equal(query(L.GRAVE).filter(c=>c.code===boss).length,2,'Both sources still GY during chain building');assert(!p.selects.some(c=>c.code===boss&&c.location===L.GRAVE),'Shared revival limit blocks second copy');countChecked=true;}if(chainStarted&&!activated&&p.player===0){const current=trace.filter(m=>m.type===M.CHAINING).length;const revival=p.selects.findIndex(c=>c.code===boss&&c.location===L.GRAVE);assert.equal(revival>=0,current>=3&&!test.full,'Native GY response threshold');if(current<test.chain){const wanted=[recipient,lab,spellCost,filler][current];index=p.selects.findIndex(c=>c.code===wanted);assert(index>=0,'Next neutral chain response available');}else if(revival>=0){index=revival;activated=true;}}core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/scarstech-principality-revival'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public OCGCore; full production Principality/candidate metadata, neutral partner/opponent cards. Actual native GY response threshold and revival; no native Omega certification.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(c=>c.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
