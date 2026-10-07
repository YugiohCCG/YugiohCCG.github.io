'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),inc=238276250,ritual=900000911,mat=900000912,trigger=900000913,victim=900000914,filler=900000915,results=[];
 for(const test of [{},{spellHand:true},{two:true},{release:true},{selfOnly:true},{deckMat:true},{rebirth:true},{rebirth:true,two:true}]){
  const spell=test.rebirth?23459650:216532402;
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:8,race:2n,attack:300,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[inc,{...base,code:inc,setcodes:[0x11f],level:8}],[spell,{...base,code:spell,setcodes:[0x11f],type:0x82,level:0}],[ritual,{...base,code:ritual,setcodes:[0x11f],type:0xa1,level:test.two?4:2}],[mat,{...base,code:mat,setcodes:[0x11f]}],[trigger,{...base,code:trigger,type:2,level:0}],[victim,{...base,code:victim}],[filler,{...base,code:filler}]]);
  const reader=name=>{
   if(name===`c${trigger}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,${victim}) Duel.${test.release?'Release':'Destroy'}(g,REASON_EFFECT) end) c:RegisterEffect(e) end`;
   if(name===`c${ritual}.lua`)return 'local s,id=GetID() function s.initial_effect(c) c:EnableReviveLimit() end';
   if([mat,victim,filler].some(id=>name===`c${id}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');if(name===`c${inc}.lua`&&process.argv.includes('--no-material-block'))source=source.replace('e:GetHandler():RegisterEffect(block)','--negative control: do not register the material block');return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,copied=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position:P.FACEUP_ATTACK});
   add(inc,L.HAND);add(ritual,L.HAND);add(spell,test.spellHand?L.HAND:L.DECK);add(trigger,L.HAND);add(victim,L.MZONE);if(!test.selfOnly)add(mat,test.deckMat?L.DECK:L.MZONE,0,1);if(test.two)add(mat,L.MZONE,0,2);add(filler,L.MZONE,1);if(test.two)add(filler,L.MZONE,1,1);for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<150&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!activated){const index=p.activates.findIndex(c=>c.code===trigger);if(index<0)throw Error('Trigger Spell unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     const query=(player,location)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.STATUS|Q.REASON,controller:player,location});
     if(test.selfOnly){if(copied)throw Error('Self-only illegal copy offered');if(!query(0,L.HAND).some(c=>c?.code===inc))throw Error('Incarnation left hand');}
     else{const rc=query(0,L.MZONE).find(c=>c?.code===ritual);if(!rc||(rc.status&8)===0)throw Error('Proper copied Ritual Summon failed');if(!query(0,L.GRAVE).some(c=>c?.code===spell&&(c.reason&0x80)))throw Error('Ritual Spell not sent as cost');if(!query(0,L.REMOVED).some(c=>c?.code===inc))throw Error('GY trigger did not banish Incarnation');if(query(1,L.MZONE).filter(Boolean).length)throw Error('Tribute-count destruction failed');const materials=query(0,L.GRAVE).filter(c=>c?.code===mat);if(materials.length!==(test.two?2:1)||materials.some(c=>(c.reason&2)===0))throw Error('Actual Tributes mismatch');}done=true;
    }else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===inc);if(index>=0&&p.selects[index].location===L.HAND)copied=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
    else if(p.type===M.SELECT_CARD){const priority=[ritual,spell,mat,filler];const code=priority.find(code=>p.selects.some(c=>c.code===code));const indices=p.selects.map((c,i)=>c.code===code?i:-1).filter(i=>i>=0).slice(0,code===filler?(test.two?2:1):1);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:indices});}
    else if(p.type===M.SELECT_UNSELECT_CARD)core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index:p.can_finish?null:p.select_cards.findIndex(c=>c.code===mat)});
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_EFFECTYN){copied=true;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }if(!done)throw Error('Step limit');
  }catch(e){failure=e.message}finally{core.destroyDuel(duel)}
  results.push({...test,failure,copied,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,`output/fresh-ccg-september/nephthys-incarnation-copy${process.argv.includes('--no-material-block')?'-no-material-block':''}.json`),JSON.stringify({engine:'Public OCGCore with full production Incarnation/Sacred Feather or official Rebirth and neutral Ritual/material/trigger fixtures; not native Omega',adapter:process.argv.includes('--no-material-block')?'In-memory negative control disables prospective material block':null,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1});
