'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=244163199,ally=900001051,top=900001022,filler=900001023,refill=900001024,greetings=238276575,results=[];
 for(const test of [{},{repeatGrant:true},{decline:true},{wrongRank:true},{sameAttribute:true},{wrongset:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[greetings,candidateCard(greetings)],[ally,{...base,code:ally,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2}],[top,{...base,code:top,race:test.nonplant?1n:1024n}],[filler,{...base,code:filler}]]);
  cards.set(top,{...base,code:top,type:0x20002,level:0});cards.set(17228909,{...base,code:17228909,type:0x4011,race:65536n,attribute:1,level:1,attack:0,defense:0});cards.set(ally,{...base,code:ally,type:33,race:test.wrongrace?1024n:524288n,attribute:test.wrongattribute?4:2});cards.set(refill,{...base,code:refill});cards.set(900001030,{...base,code:900001030});
  cards.set(filler,{...base,code:filler,type:2});
  cards.set(ally,{...base,code:ally,type:0x800021,level:test.wrongRank?11:12});cards.set(top,{...base,code:top,attribute:test.sameAttribute?16:4,setcodes:test.wrongset?[]:[0xa120]});
  cards.set(900001092,{...base,code:900001092,attribute:2});
  const reader=name=>{
   if(name==='c'+top+'.lua'&&test.repeatGrant)return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,'+ally+'):GetFirst() Duel.Overlay(tc,Group.FromCards(Duel.CreateToken(tp,900001092))) end) c:RegisterEffect(e) end';
   if([ally,top,filler,900001092].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--grant-count'))source=source.replace('grant:SetRange(LOCATION_MZONE)','grant:SetRange(LOCATION_MZONE) grant:SetCountLimit(1)');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--no-grant'))source=source.replace('tc:RegisterEffect(grant,true)','do end');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--any-attribute'))source=source.replace('and c:GetAttribute()~=attribute','');
   if(name==='c'+boss+'.lua'&&process.argv.includes('--any-set'))source=source.replace('and c:IsSetCard(SET_KILLAMITY)','');
   return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:test.lowLP?1000:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,prepared=false,refilled=false,repeated=false,turn=0,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   add(boss,L.GRAVE);add(ally,L.MZONE);add(top,L.DECK);if(test.repeatGrant)add(top,L.DECK);
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.OVERLAY_CARD|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!activated){const index=p.activates.findIndex(x=>x.code===boss&&String(x.description)===String(132163199*16+2));if(test.wrongRank){assert.equal(index,-1,'Wrong Rank attachment offered');done=true;continue;}assert(index>=0);activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     const index=p.activates.findIndex(x=>x.code===ally&&String(x.description)===String(132163199*16+4));
     if(test.decline||test.sameAttribute||test.wrongset){assert.equal(index,-1,'Invalid grant activation offered');assert.equal(query(L.MZONE).find(x=>x.code===ally).overlayCards.length,1,'Source not attached');done=true;continue;}
     if(!repeated){assert.equal(query(L.MZONE).find(x=>x.code===ally).overlayCards.length,1,'Source not actual material');assert(index>=0,'Granted ignition missing');repeated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(test.repeatGrant&&!refilled){assert(query(L.GRAVE).some(x=>x.code===boss),'Goldenrod did not leave material');const pi=p.activates.findIndex(x=>x.code===top);assert(pi>=0);refilled=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index:pi});continue;}if(test.repeatGrant&&!prepared){assert(index>=0,'Grant lost or turn-limited after Goldenrod detachment');prepared=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}if(test.repeatGrant){assert.equal(query(L.MZONE).filter(x=>x.code===top).length,2,'Granted effect failed second same-turn Summon');assert(query(L.GRAVE).some(x=>x.code===900001092&&(x.reason&0x80)),'Second material not detached as cost');}
     assert(query(L.GRAVE).some(x=>x.code===boss&&(x.reason&0x80)),'Source not detached as cost');assert(query(L.MZONE).some(x=>x.code===top),'Deck target not actually Summoned');assert.equal(query(L.MZONE).find(x=>x.code===ally).overlayCards.length,0);done=true;
    }else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(x=>x.code===(repeated?(p.selects.some(x=>x.code===boss)?boss:p.selects.some(x=>x.code===900001092)?900001092:top):ally));assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.place?1:0});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}assert(sequence!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const control=process.argv.includes('--grant-count')?'grant-count':process.argv.includes('--no-grant')?'no-grant':process.argv.includes('--any-attribute')?'any-attribute':process.argv.includes('--any-set')?'any-set':null;
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/killamity-goldenrod-grant'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public core full Goldenrod/candidate metadata; neutral seeded Rank12 and Deck recipient, actual attachment/detach/granted Summon; no Xyz procedure certification',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});



