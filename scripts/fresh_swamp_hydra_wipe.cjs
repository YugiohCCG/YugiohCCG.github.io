'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=239935098,token=239935103,victim=900001161,spell=900001162,filler=900001163,heart=239935093,trap=900001164,refill=900001165,results=[];
 const control=process.argv.includes('--no-wipe')?'no-wipe':process.argv.includes('--four-monsters')?'four-monsters':process.argv.includes('--no-heart-gate')?'no-heart-gate':process.argv.includes('--monster-only')?'monster-only':process.argv.includes('--no-count')?'no-count':null;
 for(const test of [{},{four:true},{noHeart:true},{faceDownHeart:true},{wrongRace:true},{count:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:2,race:524288n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[token,candidateCard(token)],[victim,{...base,code:victim,race:test.wrongRace?1n:524288n}],[spell,{...base,code:spell,type:2}],[filler,{...base,code:filler}]]);
  cards.set(heart,{...candidateCard(heart),type:0x20002});cards.set(trap,{...base,code:trap,type:0x20004});cards.set(spell,{...cards.get(spell),type:0x20002});
  cards.set(refill,{...base,code:refill,type:2});
  const reader=name=>{
   if(name==='c'+refill+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local c=Duel.GetMatchingGroup(Card.IsCode,tp,0,LOCATION_GRAVE,nil,'+filler+'):GetFirst() Duel.SpecialSummon(c,0,tp,1-tp,false,false,POS_FACEUP) end) c:RegisterEffect(e) end';
   if([victim,filler,token,spell,heart,trap].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){if(control==='no-count')lua=lua.replace('wipe:SetCountLimit(1)','do end');if(control==='no-wipe')lua=lua.replace('Duel.Destroy(g,REASON_EFFECT)','do end');if(control==='four-monsters')lua=lua.replace('>=5','>=4');if(control==='no-heart-gate')lua=lua.replace('c:IsFaceup() and c:IsCode(HEART)','true');if(control==='monster-only')lua=lua.replaceAll('Duel.GetFieldGroup(tp,0,LOCATION_ONFIELD)','Duel.GetFieldGroup(tp,0,LOCATION_MZONE)');}return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false,refilled=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position:(code===heart&&test.faceDownHeart)||(code===trap)?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK});
   add(boss,L.MZONE);for(let i=1;i<(test.four?4:5);i++)add(victim,L.MZONE,0,i);if(!test.noHeart)add(heart,L.SZONE);add(filler,L.MZONE,1);add(spell,L.SZONE,1);add(trap,L.SZONE,1,1);if(test.count)add(refill,L.HAND);for(const p of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,p);core.startDuel(duel);
   const query=(controller=0,location=L.MZONE)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,controller,location}).filter(Boolean);
   for(let step=0;step<160&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END,'Unexpected duel end');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(refilled){assert.equal(query(1).length,1,'Actual restored opponent target');assert(!p.activates.some(c=>c.code===boss),'Once-per-turn wipe unavailable with legal target');done=true;continue;}const eligible=!test.four&&!test.noHeart&&!test.faceDownHeart&&!test.wrongRace;const index=p.activates.findIndex(c=>c.code===boss);if(!activated){assert.equal(index>=0,eligible,'Wipe eligibility');if(!eligible){done=true;continue;}activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}assert.equal(query(1).length,0,'Opponent Monster Zone cleared');assert.equal(query(1,L.SZONE).length,0,'Opponent Spell/Trap Zone cleared');const grave=query(1,L.GRAVE);assert.equal(grave.length,3,'Three opponent cards destroyed');for(const c of grave){assert(c.reason&1,'Destruction reason');assert(c.reason&0x40,'Effect reason');}assert.equal(query().length,5,'Own monsters retained');assert.equal(query(0,L.SZONE).length,1,'Own Heart retained');if(test.count){const index=p.activates.findIndex(c=>c.code===refill);assert(index>=0,'Neutral refill available');refilled=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}done=true;}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_CHAIN){core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});}
    else if(p.type===M.SELECT_PLACE){let place;for(const player of [0,1])for(const location of [L.MZONE,L.SZONE])for(let sequence=0;sequence<5;sequence++){const bit=(player===0?0:16)+(location===L.SZONE?8:0)+sequence;if(!place&&(p.field_mask&(1<<bit))===0)place={player,location,sequence};}assert(place,'Legal placement');core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[place]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/swamp-hydra-wipe'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public OCGCore, complete production Hydra/candidate metadata and Hydra Head token. Seeded field source, actual Quick wipe destroys opponent Monster/Continuous Spell/face-down Trap. Neutral Heart script isolates gate; actual Fusion/native Omega unverified.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(c=>c.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
