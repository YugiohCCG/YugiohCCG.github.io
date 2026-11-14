'use strict';
const fs=require('node:fs');
const path=require('node:path');
const assert=require('node:assert/strict');
const root=path.resolve(__dirname,'..');
process.env.CCG_INSTALLED_CARD_DB ||= require('node:path').resolve(__dirname,'../public/CCG Downloads/CCG_Database/CCG_v1.db');
const {candidateCard}=require('./fresh_installed_card.cjs');
const library=process.env.CCG_OMEGA_SCRIPTS||path.resolve(__dirname,'../public/CCG Downloads/CCG_Scripts');
const omega=path.join(root,'tmp/omega_scripts');
const neutral='local s,id=GetID() function s.initial_effect(c) end';

async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport();
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}});
 const scenarios=[
  {code:239932270,type:0x10002,resource:900008001,resourceType:0x20002,set:0x16d,expected:L.SZONE},
  {code:239932271,type:0x20002,expected:L.SZONE},
  {code:239932272,type:2,resource:18940725,resourceType:33,set:0x16d,expected:L.GRAVE},
  {code:239934743,type:33,resource:900008003,resourceType:0x61,set:0x1b0,expected:L.GRAVE},
  {code:239934744,type:2,resource:60764609,resourceType:33,set:0x1b0,expected:L.MZONE}
 ];
 for(const test of scenarios){
  const logs=[],filler=900008005,search=900008006;
  const base={alias:0,setcodes:[],type:17,level:2,attribute:16,race:8n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[filler,{...base,code:filler}],[search,{...base,code:search,race:512n}]]);
  cards.set(test.code,candidateCard(test.code));
  const sky=test.code===239932271, boss=900008010, deckMaterial=900008011;
  if(sky){
   cards.set(boss,{...base,code:boss,level:7,race:512n,setcodes:[0x16d]});
   cards.set(deckMaterial,{...base,code:deckMaterial,setcodes:[0x16d]});
  }
  if(test.resource)cards.set(test.resource,{...base,code:test.resource,type:test.resourceType,setcodes:[test.set],race:test.set===0x16d?512n:8n});
  const reader=name=>{
   if(name==='c0.lua')return '';
   if(name==='c'+boss+'.lua'||name==='c'+deckMaterial+'.lua'||name==='c'+filler+'.lua'||name==='c'+search+'.lua'||name==='c'+test.resource+'.lua'&&test.code!==239932272)return neutral;
   const file=[path.join(library,name),path.resolve(__dirname,'../tmp/ohmen-reference',name),path.join(omega,name)].find(fs.existsSync);
   assert(file,name);
   return fs.readFileSync(file,'utf8');
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])assert(core.loadScript(duel,name,reader(name)));
   const add=(code,location,player=0,position)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:position??(location===L.EXTRA?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK)});
   add(test.code,L.HAND);
   if(sky){add(boss,L.HAND);add(filler,L.HAND);add(deckMaterial,L.DECK);add(filler,L.MZONE,1,P.FACEUP_DEFENSE);}
   if(test.resource)add(test.resource,test.code===239934743?L.EXTRA:test.code===239932272?L.HAND:L.DECK);
   if(test.code===239932272)add(search,L.DECK);
   for(const p of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,p);
   core.startDuel(duel);
   let started=false,done=false,tributeAttempted=false;
   const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller,location}).filter(Boolean);
   for(let i=0;i<100&&!done;i++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);
    if(messages.some(m=>m.type===M.CHAINING&&m.code===test.code))started=true;assert(!logs.some(x=>x.type===0),logs.map(x=>x.message).join('\n'));
    assert(state!==S.END);
    if(state!==S.WAITING)continue;
    const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!started){
      const summon=test.code===239934743;
      const index=(summon?p.summons:p.activates).findIndex(x=>x.code===test.code);
      assert(index>=0,test.code+' activation or summon available '+JSON.stringify(logs));
      core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:summon?A.SELECT_SUMMON:A.SELECT_ACTIVATE,index});
      started=true;
     }else if(sky&&!tributeAttempted){
      const index=p.summons.findIndex(x=>x.code===boss);
      assert(index>=0,"Sky offers the alternate Tribute Summon");
      core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SUMMON,index});
      tributeAttempted=true;
     }else{
      if(sky){
       assert(query(L.MZONE).some(x=>x.code===boss),"Sky Tribute Summon resolved");
       assert.equal(query(L.REMOVED).length,2,"Sky banished both materials");
       assert.equal(query(L.MZONE,1)[0].position,P.FACEUP_ATTACK,"Sky changed the opponent monster to Attack Position");
      }
      const expected=test.code===239932270?test.resource:test.code===239934743||test.code===239934744?test.resource:test.code;
      assert(query(test.expected).some(x=>x.code===expected),'Expected card reached destination');
      if(test.code===239932272)assert(query(L.HAND).some(x=>x.code===search),'Copied Robina search resolved');
      done=true;
     }
    }else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.selects.findIndex(x=>x.code===test.code)>=0?p.selects.findIndex(x=>x.code===test.code):p.forced?0:null});
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:p.code===test.code});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:false});
    else if(p.type===M.SELECT_CARD)core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:p.selects.map((_,j)=>j).slice(0,p.min)});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){
     const shift=[0,8,16,24].find(v=>[0,1,2,3,4,5,6,7].some(j=>(p.field_mask&(1<<(v+j)))===0));
     const sequence=[0,1,2,3,4,5,6,7].find(j=>(p.field_mask&(1<<(shift+j)))===0);
     core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:shift>=16?1-p.player:p.player,location:shift%16===8?L.SZONE:L.MZONE,sequence}]});
    }else throw Error('Unhandled '+p.type);
   }
   assert(done,'Duel fixture reached outcome');
   console.log(test.code,'PASS');
  }finally{core.destroyDuel(duel);}
 }
}
main().catch(e=>{console.error(e);process.exitCode=1});
