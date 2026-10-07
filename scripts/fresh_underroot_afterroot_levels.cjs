'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=238272440,syn=900000771,xyz=900000772,rit=900000773,spell=900000774,filler=900000775;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),r=db.prepare('select * from datas where id=?').get(boss);db.close();
 const base={alias:0,setcodes:[],type:33,level:3,attribute:1,race:1n,attack:300,defense:200,lscale:0,rscale:0,link_marker:0},results=[];
 for(const root of [true,false]){
  const logs=[],trace=[],cards=new Map([[boss,{...base,code:boss,setcodes:[0xA110,0xA113],type:Number(r.type),level:Number(r.level)&255,attribute:Number(r.attribute),race:BigInt(r.race),attack:Number(r.atk),defense:Number(r.def)}],[spell,{...base,code:spell,type:2,level:0}],[filler,{...base,code:filler}]]);
  for(const [code,type] of [[syn,0x2000],[xyz,0x800000],[rit,0x80]])cards.set(code,{...base,code,type:33|type,setcodes:root?[0xA110]:[]});
  const reader=name=>{
   if(name===`c${spell}.lua`)return `local s,id=GetID()
function s.initial_effect(c)
 local e=Effect.CreateEffect(c)
 e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN)
 e:SetOperation(function(e,tp)
  local c=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,${boss}):GetFirst()
  local function card(code) return Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_EXTRA+LOCATION_HAND,0,nil,code):GetFirst() end
  assert(c:GetLevel()==4,'Printed Level was altered')
  assert(c:GetSynchroLevel(card(${syn}))==${root?65540:4},'Synchro material Level mismatch')
  assert(c:GetRitualLevel(card(${rit}))==${root?65540:4},'Ritual material Level mismatch')
  assert(c:IsXyzLevel(card(${xyz}),4),'Original Xyz Level unavailable')
  assert(c:IsXyzLevel(card(${xyz}),1)==${root?'true':'false'},'Alternate Xyz Level mismatch')
  Duel.Damage(tp,777,REASON_EFFECT)
 end)
 c:RegisterEffect(e)
end`;
   if([syn,xyz,rit,filler].some(code=>name===`c${code}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8');
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});add(boss,L.MZONE);add(syn,L.EXTRA);add(xyz,L.EXTRA);add(rit,L.HAND);add(spell,L.HAND);for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<75&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(!activated){const index=p.activates.findIndex(c=>c.code===spell);if(index<0)throw Error('Probe Spell unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}else{if(!trace.some(t=>t.type===M.DAMAGE))throw Error('No successful Level probe');done=true;}}
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:null});
    else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:L.SZONE,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(e){failure=e.message}finally{core.destroyDuel(duel)}
  results.push({root,failure,trace,logs});console.log(`${failure?'FAIL':'PASS'} root=${root}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/underroot-afterroot-levels.json'),JSON.stringify({engine:'public OCGCore material-Level API probe, not actual Summon selection',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
