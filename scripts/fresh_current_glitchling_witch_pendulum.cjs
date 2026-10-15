'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href),{OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A}=mod,core=await mod.default({sync:true,print(){},printErr(){}});
 const boss=259678739,probe=900002201,target=900002202,filler=900002203,extras=[900002204,900002205,900002206,900002207];
 const control=['no-protection','protect-own','no-counter','no-probe'].find(c=>process.argv.includes('--'+c)),results=[];
 for(const scenario of ['none','opponent','own','both','disabled','removed','counterRemoved']){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:4,attribute:1,race:1n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[probe,{...base,code:probe,type:33}],[target,{...base,code:target,type:33}],[filler,{...base,code:filler}],...extras.map((code,i)=>[code,{...base,code,type:[0x61,0x2021,0x800021,0x4000021][i],level:[8,8,4,2][i],link_marker:i===3?1:0}])]);
  const blocked=scenario==='opponent'||scenario==='both';
  const reader=name=>{
   if(name==='c0.lua')return '';
   if(name==='c'+target+'.lua')return 'local s,id=GetID() function s.initial_effect(c) c:EnableCounterPermit(0x1994,LOCATION_MZONE) end';
   if(name==='c'+probe+'.lua')return `local s,id=GetID() function s.initial_effect(c)
    local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetDescription(901)
    e:SetOperation(function(e,tp) local own=Duel.GetFieldCard(tp,LOCATION_MZONE,0) local opp=Duel.GetFieldCard(1-tp,LOCATION_MZONE,0) local pc=Duel.GetFieldCard(tp,LOCATION_PZONE,0)
    ${control==='no-counter'?'':scenario!=='none'?`assert(opp:AddCounter(0x1994,1))`:''}
    ${control==='no-counter'?'':scenario==='own'||scenario==='both'?`assert(own:AddCounter(0x1994,1))`:''}
    ${scenario==='own'?'if opp:GetCounter(0x1994)>0 then assert(opp:RemoveCounter(tp,0x1994,1,REASON_EFFECT)) end':''}
    ${scenario==='counterRemoved'?'if opp:GetCounter(0x1994)>0 then assert(opp:RemoveCounter(tp,0x1994,1,REASON_EFFECT)) end':''}
    ${scenario==='removed'?'assert(Duel.Remove(pc,POS_FACEUP,REASON_EFFECT)>0)':''}
    ${scenario==='disabled'?'local d=Effect.CreateEffect(e:GetHandler()) d:SetType(EFFECT_TYPE_SINGLE) d:SetCode(EFFECT_DISABLE) d:SetReset(RESET_EVENT+RESETS_STANDARD) pc:RegisterEffect(d) local dd=d:Clone() dd:SetCode(EFFECT_DISABLE_EFFECT) pc:RegisterEffect(dd)':''}
    Duel.Hint(HINT_NUMBER,tp,701) end) c:RegisterEffect(e)
    local check=e:Clone() check:SetDescription(902)
    check:SetOperation(function(e,tp) ${control==='no-probe'?'do return end':''}
      local success,err=pcall(function()
       for player=0,1 do local tc=Duel.GetFieldCard(player,LOCATION_MZONE,0) local allowed=player==tp or ${blocked?'false':'true'}
        assert(tc:IsReleasable()==allowed,'Tribute Summon release')
        assert(tc:IsReleasableByEffect(e,tp)==allowed,'Effect release')
        assert(tc:IsCanBeFusionMaterial(Duel.GetFirstMatchingCard(Card.IsCode,player,LOCATION_EXTRA,0,nil,${extras[0]}),SUMMON_TYPE_FUSION)==allowed,'Fusion material')
        assert(tc:IsCanBeSynchroMaterial(Duel.GetFirstMatchingCard(Card.IsCode,player,LOCATION_EXTRA,0,nil,${extras[1]}))==allowed,'Synchro material player'..player)
        assert(tc:IsCanBeXyzMaterial(Duel.GetFirstMatchingCard(Card.IsCode,player,LOCATION_EXTRA,0,nil,${extras[2]}))==allowed,'Xyz material')
        assert(tc:IsCanBeLinkMaterial(Duel.GetFirstMatchingCard(Card.IsCode,player,LOCATION_EXTRA,0,nil,${extras[3]}))==allowed,'Link material')
       end
      end) Duel.Hint(HINT_NUMBER,tp,success and 988 or 989)
    end) c:RegisterEffect(check) end`;
   if([filler,...extras].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(fs.existsSync);assert(file,name);let lua=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'){if(control==='no-protection')lua=lua.replaceAll('e1:SetRange(LOCATION_PZONE)','e1:SetRange(LOCATION_GRAVE)').replaceAll('e3:SetRange(LOCATION_PZONE)','e3:SetRange(LOCATION_GRAVE)');if(control==='protect-own')lua=lua.replaceAll('SetTargetRange(0,LOCATION_MZONE)','SetTargetRange(LOCATION_MZONE,LOCATION_MZONE)');}return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{assert(cards.has(code),String(code));return cards.get(code);},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,placed=false,prepared=false,checked=false,done=false;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   const add=(code,location,player=0,position=P.FACEUP_ATTACK,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(boss,L.HAND);add(probe,L.MZONE,0,P.FACEUP_ATTACK,4);for(const player of [0,1])add(target,L.MZONE,player);for(const player of [0,1])for(const code of extras)add(code,L.EXTRA,player,P.FACEDOWN_DEFENSE);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<160&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!placed){const index=p.activates.findIndex(c=>c.code===boss&&c.location===L.HAND);assert(index>=0);placed=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(!prepared||!checked){const index=p.activates.findIndex(c=>c.code===probe&&Number(c.description)===(!prepared?901:902));assert(index>=0,'Native setup/observer effect');if(!prepared)prepared=true;else checked=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert(trace.some(m=>m.type===M.HINT&&Number(m.hint)===701),'Native counter/lifecycle setup executed');assert(trace.some(m=>m.type===M.HINT&&Number(m.hint)===988),'All12 native eligibility observations pass');assert(!trace.some(m=>m.type===M.HINT&&Number(m.hint)===989),'Native observation failed');done=true;
    }else if(p.type===M.SELECT_PLACE){core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:L.SZONE,sequence:0}]});}
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:false});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({scenario,failure,trace,logs});if(failure)console.log('FAIL '+scenario+': '+failure);
 }
 fs.writeFileSync(path.join(OUT,'current-glitchling-witch-pendulum'+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Full Witch production source, actual native hand-to-PZone activation/counter addition/removal/source banishment/disable. Native eligibility observations for six release/material methods for both players. No actual Fusion/Synchro/Xyz/Link/Tribute summon certification, no API shim/live Omega/fullcard. Other Witch effects open.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');console.log(JSON.stringify({cases:results.length,passed:results.filter(r=>!r.failure).length}));if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
