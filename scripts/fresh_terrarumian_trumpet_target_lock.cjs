'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),trumpet=284639724,target=900000581,spell=900000582,filler=900000583;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),r=db.prepare('select * from datas where id=?').get(trumpet);db.close();
 const base={alias:0,setcodes:[],type:33,level:4,attribute:2,race:0x400n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const results=[];
 for(const test of [{terrarumian:true,actor:1,allowed:false},{terrarumian:false,actor:1,allowed:true},{terrarumian:true,actor:0,allowed:true}]){
  const trace=[],logs=[],cards=new Map([[trumpet,{...base,code:trumpet,setcodes:[0xA122],type:Number(r.type),level:Number(r.level)&255,lscale:(Number(r.level)>>>24)&255,rscale:(Number(r.level)>>>16)&255,attribute:Number(r.attribute),race:BigInt(r.race),attack:Number(r.atk),defense:Number(r.def)}],[target,{...base,code:target,setcodes:test.terrarumian?[0xA122]:[]}],[spell,{...base,code:spell,type:2,level:0,attribute:0,race:0n,attack:0,defense:0}],[filler,{...base,code:filler}]]);
  const own=test.actor===0,source=`local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetProperty(EFFECT_FLAG_CARD_TARGET) e:SetTarget(function(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingTarget(Card.IsFaceup,tp,${own?'LOCATION_MZONE,0':'0,LOCATION_MZONE'},1,nil) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY) Duel.SelectTarget(tp,Card.IsFaceup,tp,${own?'LOCATION_MZONE,0':'0,LOCATION_MZONE'},1,1,nil) end) e:SetOperation(function(e,tp) local tc=Duel.GetFirstTarget() if tc and tc:IsRelateToEffect(e) then Duel.Destroy(tc,REASON_EFFECT) end end) c:RegisterEffect(e) end`;
  const reader=name=>{if(name===`c${spell}.lua`)return source;if([`c${target}.lua`,`c${filler}.lua`].includes(name))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8')};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{if(!cards.has(code))throw Error('Missing card '+code);return cards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,placed=false,activated=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   add(trumpet,L.HAND);add(target,L.MZONE);add(spell,L.HAND,test.actor);for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<105&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);
    if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));
    if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(p.type===M.SELECT_IDLECMD){if(!placed){const index=p.activates.findIndex(c=>c.code===trumpet&&c.location===L.HAND);if(index<0)throw Error('Cannot place Trumpet');placed=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}else if(p.player!==test.actor)core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});else if(!activated){const index=p.activates.findIndex(c=>c.code===spell);if(!test.allowed){if(index>=0)throw Error('Opponent could target protected Terrarumian');done=true;}else{if(index<0)throw Error('Legal targeting action blocked');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}}else{const m=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.MZONE});if(m.some(c=>c?.code===target))throw Error('Legal target not destroyed');done=true;}}
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===target);if(index<0)throw Error('Target selection unavailable');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_PLACE){const seq=[0,4,1,2,3,5].find(i=>(p.field_mask&(1<<(8+i)))===0);if(seq===undefined)throw Error('No Spell zone');core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:L.SZONE,sequence:seq}]});}
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:null});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  results.push({test,status:failure?'FAIL':'PASS',failure,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/terrarumian-trumpet-target-lock.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
