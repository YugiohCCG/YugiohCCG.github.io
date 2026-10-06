'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const officialTrap=process.argv.includes('--official-trap');
 const core=await mod.default({sync:true,print(){},printErr(){}}),blossom=238272438,root1=900000721,root2=900000722,search=officialTrap?11110218:900000723,filler=900000724,clear=900000725,revival=900000726;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),r=db.prepare('select * from datas where id=?').get(blossom);db.close();
 const base={alias:0,setcodes:[],type:33,level:3,attribute:1,race:1n,attack:300,defense:200,lscale:0,rscale:0,link_marker:0},results=[];
 for(const test of [{enough:true,repeat:false},{enough:false,repeat:false},{enough:true,repeat:true}]){
  const {enough,repeat}=test;
  const trace=[],logs=[],cards=new Map([[blossom,{...base,code:blossom,setcodes:[0xA110,0xA111],type:Number(r.type),level:Number(r.level)&255,attribute:Number(r.attribute),race:BigInt(r.race),attack:Number(r.atk),defense:Number(r.def)}],[root1,{...base,code:root1,setcodes:[0xA110]}],[root2,{...base,code:root2,setcodes:[0xA110]}],[search,{...base,code:search,setcodes:[0xA110,0xA111]}],[filler,{...base,code:filler}]]);
  if(officialTrap)cards.set(search,{...base,code:search,setcodes:[],type:4,level:0,attribute:0,race:0n,attack:0,defense:0});
  cards.set(clear,{...base,code:clear,type:2,level:0,attribute:0,race:0n,attack:0,defense:0});
  cards.set(revival,{...base,code:revival,type:2,level:0,attribute:0,race:0n,attack:0,defense:0});
  const revivalScript=`local s,id=GetID() function s.filter(c,e,tp) return c:IsCode(${blossom}) and c:IsCanBeSpecialSummoned(e,0,tp,false,false) end function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetTarget(function(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and Duel.IsExistingMatchingCard(s.filter,tp,LOCATION_GRAVE,0,1,nil,e,tp) end end) c:RegisterEffect(e) end`;
  const reader=name=>{if(name===`c${revival}.lua`)return revivalScript;if(name===`c${clear}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) Duel.SendtoGrave(Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,${blossom}),REASON_EFFECT) end) c:RegisterEffect(e) end`;if([`c${root1}.lua`,`c${root2}.lua`,`c${search}.lua`,`c${filler}.lua`].includes(name))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8')};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{if(!cards.has(code))throw Error('Missing card '+code);return cards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,started=false,triggered=false,cleared=false,checkedLimit=false,secondStarted=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
   if(!core.loadScript(duel,'public-core-compat.lua','if not Duel.GetMustMaterial then Duel.GetMustMaterial=function() return Group.CreateGroup() end end if not Duel.CheckMustMaterial then Duel.CheckMustMaterial=function() return true end end'))throw Error('Compatibility binding');
   const add=(code,location)=>core.duelNewCard(duel,{team:0,duelist:0,code,controller:0,location,sequence:0,position:P.FACEUP_ATTACK});add(blossom,L.EXTRA);add(root1,L.GRAVE);if(enough)add(root2,L.GRAVE);if(repeat){add(blossom,L.EXTRA);add(root1,L.GRAVE);add(root2,L.GRAVE);}add(search,L.DECK);for(const player of [0,1])for(let i=0;i<5;i++)core.duelNewCard(duel,{team:player,duelist:0,code:filler,controller:player,location:L.DECK,sequence:0,position:P.FACEUP_ATTACK});
   if(repeat){add(clear,L.HAND);core.duelNewCard(duel,{team:0,duelist:0,code:revival,controller:0,location:L.HAND,sequence:0,position:P.FACEUP_ATTACK});}
   core.startDuel(duel);
   for(let step=0;step<200&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(p.type===M.SELECT_IDLECMD){
     if(repeat&&cleared&&p.player===0&&p.activates.some(c=>c.code===revival))throw Error('Ordinary revival offered despite mandatory summon restriction');
     if(repeat&&checkedLimit){
      if(p.player===1){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
      if(!secondStarted){const index=p.special_summons.findIndex(c=>c.code===blossom);if(index<0)throw Error('Alternate Summon did not reset next turn');secondStarted=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SPECIAL_SUMMON,index});}
      else{const m=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.MZONE}),x=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.REMOVED});if(m.filter(c=>c?.code===blossom).length!==1||x.filter(c=>c?.code===root1||c?.code===root2).length!==4)throw Error('Second-turn alternate Summon mismatch');done=true;}
     }else if(!started&&enough){const index=p.special_summons.findIndex(c=>c.code===blossom);if(index<0)throw Error('Alternate Summon unavailable');started=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SPECIAL_SUMMON,index});}
     else{if(!enough&&p.special_summons.some(c=>c.code===blossom))throw Error('Alternate Summon offered with one material');const m=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.MZONE}),x=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.REMOVED}),h=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.HAND});if(enough&&(!triggered||!cleared&&!m.some(c=>c?.code===blossom)||!x.some(c=>c?.code===root1)||!x.some(c=>c?.code===root2)||!h.some(c=>c?.code===search)))throw Error('Alternate Summon/search mismatch');
      if(repeat&&!cleared){const index=p.activates.findIndex(c=>c.code===clear);if(index<0)throw Error('Zone-clear Spell unavailable');cleared=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}
      else if(repeat){const g=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.GRAVE}),ex=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.EXTRA});if(m.some(c=>c?.code===blossom)||!g.some(c=>c?.code===blossom)||g.filter(c=>c?.code===root1||c?.code===root2).length!==2||!ex.some(c=>c?.code===blossom)||p.special_summons.some(c=>c.code===blossom))throw Error('Second copy bypassed shared alternate Summon limit');checkedLimit=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});}else done=true;
     }
    }
    else if(p.type===M.SELECT_EFFECTYN){const yes=p.code===blossom;if(yes)triggered=true;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes});}
    else if(p.type===M.SELECT_CHAIN){const index=p.player===0?p.selects.findIndex(c=>c.code===blossom):-1;if(index>=0)triggered=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:null});}
    else if(p.type===M.SELECT_CARD){if(p.max>=2&&p.selects.some(c=>c.code===root1)&&p.selects.some(c=>c.code===root2))core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[p.selects.findIndex(c=>c.code===root1),p.selects.findIndex(c=>c.code===root2)]});else{const index=p.selects.findIndex(c=>c.code===search);if(index<0)throw Error('Search unavailable');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}}
    else if(p.type===M.SELECT_PLACE){let seq=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<i))===0),location=L.MZONE;if(seq===undefined){location=L.SZONE;seq=[0,4,1,2,3,5].find(i=>(p.field_mask&(1<<(8+i)))===0);}if(seq===undefined)throw Error('No zone');core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence:seq}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_UNSELECT_CARD)core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index:p.can_finish?null:0});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  results.push({test,status:failure?'FAIL':'PASS',failure,checkedLimit,secondStarted,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,`output/fresh-ccg-september/underroot-terror-blossom-alt${officialTrap?'-official-trap':''}.json`),JSON.stringify({engine:'public OCGCore with Omega Lua; no native Omega; neutral material bindings',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
