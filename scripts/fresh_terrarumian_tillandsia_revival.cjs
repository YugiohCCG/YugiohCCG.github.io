'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{sylvanCard}=require('./fresh_sylvan_metadata.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=284639725,mat=900001031,topBase=900001032,setup=900001033,spell=900001034,filler=900001035,results=[];
 for(const test of [{proper:true},{proper:false},{proper:true,send:true}]){
  const top=topBase;
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:2,attribute:4,race:1024n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([mat,top,setup,spell,filler].map(code=>[code,{...base,code}]));
  cards.set(top,{...cards.get(top),race:test.nonplant?1n:1024n});for(const code of [setup,spell])cards.set(code,{...cards.get(code),type:2,level:0});if(test.trap)cards.set(spell,{...cards.get(spell),type:4});if(test.monster)cards.set(spell,{...base,code:spell,type:33});const {DatabaseSync}=require('node:sqlite');const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true});const q=db.prepare('select * from datas where id=?');q.setReadBigInts(true);const row=q.get(boss);assert(row);const setcodes=[];for(let i=0;i+1<row.setcode.length;i+=2)setcodes.push(row.setcode[i]|row.setcode[i+1]<<8);assert(setcodes.includes(0xa122));cards.set(boss,{...base,code:boss,setcodes,type:Number(row.type),level:Number(row.level&255n),attribute:Number(row.attribute),race:row.race,attack:Number(row.atk),defense:0,link_marker:Number(row.def)});db.close();cards.set(mat,{...cards.get(mat),setcodes:[0x90]});if(top===238276575)cards.set(top,sylvanCard(top));
  if(test.continuous)cards.set(spell,{...cards.get(spell),type:0x20002});
  const reader=name=>{
   if(name==='c'+setup+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) '+(test.proper?'local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,'+boss+'):GetFirst() tc:CompleteProcedure()':'local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_GRAVE,0,nil,'+boss+'):GetFirst() Duel.SpecialSummon(tc,0,tp,tp,true,true,POS_FACEUP)')+' end) c:RegisterEffect(e) end';
   if(name==='c'+spell+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,LOCATION_MZONE,nil,'+boss+'):GetFirst() '+(test.send?'Duel.SendtoGrave':'Duel.Destroy')+'(tc,REASON_EFFECT) end) c:RegisterEffect(e) end';
   if([mat,filler,topBase].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'&&process.argv.includes('--any-send'))source=source.replace('c:IsReason(REASON_DESTROY) and c:IsReason(REASON_EFFECT)','c:IsReason(REASON_EFFECT)');return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,prepared=false,activated=false,done=false,turn=0;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   add(boss,test.proper?L.MZONE:L.GRAVE);add(mat,L.HAND);add(setup,L.HAND);if(test.trap)core.duelNewCard(duel,{team:1,duelist:0,code:spell,controller:1,location:L.SZONE,sequence:0,position:P.FACEDOWN_DEFENSE});else add(spell,test.monster?L.MZONE:test.continuous?L.SZONE:L.HAND,test.own?0:1);add(top,L.DECK);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.OVERLAY_CARD,controller,location}).filter(Boolean);
   for(let step=0;step<160&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!prepared){const index=p.activates.findIndex(x=>x.code===setup);assert(index>=0);prepared=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(!test.own&&turn<2){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
     if(!activated){const index=p.activates.findIndex(x=>x.code===spell);assert(index>=0,'Fixture Spell unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     const revives=test.proper&&!test.send;
     assert.equal(query(L.MZONE).some(x=>x.code===boss),revives,'Revival outcome mismatch');
     assert.equal(query(L.GRAVE).some(x=>x.code===boss),!revives,'GY outcome mismatch');
     assert(trace.some(x=>x.type===M.MOVE&&x.card===boss&&x.to.location===L.GRAVE),'No actual GY send');if(revives)assert(trace.some(x=>x.type===M.SPSUMMONED),'No actual revival');done=true;

    }else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(x=>x.code===boss);core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_CARD)core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[0]});
    else if(p.type===M.SELECT_PLACE){const player=p.player;let location=L.MZONE,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(16*player+i)))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(16*player+8+i)))===0);}core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player,location,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const control=process.argv.includes('--any-send')?'any-send':null;
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/terrarumian-tillandsia-revival'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'Public OCGCore, full production Tillandsia and actual candidate metadata; seeded field Link, proper case fixture calls CompleteProcedure explicitly, actual opponent destruction; no Link Summon certification, native Omega untested',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});





