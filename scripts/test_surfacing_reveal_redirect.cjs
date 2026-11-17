'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=259944344,ally=900001021,top=900001022,filler=900001023,refill=900001024,greetings=238276575,results=[];
 for(const test of [{},{redirect:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[greetings,{...base,code:greetings}],[ally,{...base,code:ally,setcodes:[0x104]}],[top,{...base,code:top,type:2,setcodes:[0xfe]}],[filler,{...base,code:filler}]]);
  cards.set(refill,{...base,code:refill,type:2,level:0});if(test.wide)cards.set(filler,{...cards.get(filler),race:1n});
  const reader=name=>{
   if(name==='c'+refill+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,'+ally+'):GetFirst() Duel.SendtoDeck(tc,nil,SEQ_DECKSHUFFLE,REASON_EFFECT) end) c:RegisterEffect(e) end';
   if(test.redirect&&name==='c'+top+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_TO_HAND_REDIRECT) e:SetValue(LOCATION_REMOVED) c:RegisterEffect(e) end'; if([ally,top,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[process.env.CCG_REPAIR_SOURCE&&path.join(process.env.CCG_REPAIR_SOURCE,name),path.join(CUSTOM,name),path.join(OMEGA,name)].filter(Boolean).find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-excavate'))source=source.replace('CCGSylvan.Excavate(e,tp,1)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-search-count'))source=source.replace('e1:SetCountLimit(1,id)','do end');
   // Public core's modern third-argument DUEL flag; this control is not Omega Lua.
   if(name==='c'+boss+'.lua'&&process.argv.includes('--duel-search-count'))source=source.replace('e1:SetCountLimit(1,id)','e1:SetCountLimit(1,id,2)');
   if(name==='ccg_sylvan.lua'&&process.argv.includes('--no-bottom'))source=source.replace('Duel.MoveSequence(Duel.GetDecktopGroup(tp,1):GetFirst(),SEQ_DECKBOTTOM)','do end');
   return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,refilled=false,repeated=false,turn=0,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   add(boss,L.GRAVE);add(ally,L.GRAVE);core.duelNewCard(duel,{team:0,duelist:0,code:top,controller:0,location:L.GRAVE,sequence:1,position:P.FACEUP_ATTACK});add(filler,L.DECK);if(test.wide){add(refill,L.HAND);for(let i=0;i<3;i++)add(filler,L.DECK);core.duelNewCard(duel,{team:0,duelist:0,code:boss,controller:0,location:L.MZONE,sequence:1,position:P.FACEUP_ATTACK});}for(let i=0;i<8;i++)add(filler,L.DECK,1);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,controller:0,location}).filter(Boolean);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     const index=p.activates.findIndex(x=>x.code===boss&&String(x.description)===String(133944344*16+1));
     if(test.short||test.noally){assert.equal(index,-1,'Illegal search activation offered');done=true;continue;}
     if(!activated){assert(index>=0,'Search unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     const h=query(L.HAND),b=query(L.REMOVED);assert(h.some(x=>x.code===ally),'Krawler not added');if(test.redirect)assert(b.some(x=>x.code===top),'Redirect absent');else assert(h.some(x=>x.code===top),'World Legacy not added');const revealed=trace.filter(x=>x.type===M.CONFIRM_CARDS&&x.player===1).flatMap(x=>x.cards.map(c=>c.code));assert(revealed.includes(ally),'Received card not revealed');assert.equal(revealed.includes(top),!test.redirect,'Redirected card reveal mismatch');done=true;
    }else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:true}); else if(p.type===M.SELECT_CARD){let index=p.selects.findIndex(x=>x.code===ally);if(index<0)index=p.selects.findIndex(x=>x.code===top);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});
    else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:L.SZONE,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const control=['--no-excavate','--no-search-count','--no-bottom','--duel-search-count'].find(x=>process.argv.includes(x))?.slice(2)||null;
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/surfacing-reveal-probe'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public OCGCore, full production Gink/Greetings and actual candidate metadata; seeded field Xyz, neutral search/top cards; actual search HOPT/reset tested, no Xyz procedure certification; native Omega untested',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});

