'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=900004701,ally=259072745,top=900004402,filler=900004403,results=[];
 for(const test of [{},{spirit:true},{wrongattribute:true},{wrongrace:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:test.wrongattribute?16:32,race:test.wrongrace?1n:8n,attack:100,defense:200,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,{...base,code:boss,type:2}],[ally,candidateCard(ally)],[top,{...base,code:top,setcodes:[]}],[filler,{...base,code:filler}]]);
  cards.set(59822133,{...base,code:59822133,type:0x2021,level:9,attribute:16,race:8192n,attack:2500,defense:3000});const reader=name=>{if(name==='c'+boss+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetTarget(function(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then local fc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_EXTRA,0,nil,259072745):GetFirst() return fc and fc:CheckFusionMaterial(Duel.GetFusionMaterial(tp),nil,tp) and Duel.GetLocationCountFromEx(tp)>0 end end) e:SetOperation(function(e,tp) local fc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_EXTRA,0,nil,259072745):GetFirst() local mg=Duel.GetFusionMaterial(tp) if not fc or not fc:CheckFusionMaterial(mg,nil,tp) then return end local mat=Duel.SelectFusionMaterial(tp,fc,mg,nil,tp) assert(#mat==2) fc:SetMaterial(mat) Duel.SendtoGrave(mat,REASON_EFFECT+REASON_MATERIAL+REASON_FUSION) Duel.BreakEffect() if Duel.SpecialSummon(fc,SUMMON_TYPE_FUSION,tp,tp,false,false,POS_FACEUP)>0 then fc:CompleteProcedure() end end) c:RegisterEffect(e) end`;
   if([top,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+ally+'.lua'&&process.argv.includes('--old-spirit-cap'))lua=lua.replaceAll('Duel.IsPlayerAffectedByEffect(tp,59822133) and 1 or 2','2');return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,refilled=false,repeated=false,turn=0,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   core.loadScript(duel,'legacy_faceup_adapter.lua','Card.IsFaceupEx=function(c) return c:IsFaceup() or c:IsLocation(LOCATION_HAND+LOCATION_GRAVE+LOCATION_DECK) end');
   if(process.argv.includes('--neutral-mandatory-adapter'))core.loadScript(duel,'neutral_mandatory_adapter.lua','Duel.GetMustMaterial=function() return Group.CreateGroup() end Duel.CheckMustMaterial=function() return true end');
   add(boss,L.HAND);add(ally,L.EXTRA);add(top,L.HAND);add(filler,L.HAND);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);if(test.spirit)core.duelNewCard(duel,{team:1,duelist:0,code:59822133,controller:1,location:L.MZONE,sequence:0,position:P.FACEUP_ATTACK});core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.POSITION,controller:0,location}).filter(Boolean);
   for(let step=0;step<100&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
          if(!activated){const index=p.activates.findIndex(x=>x.code===boss);if(test.wrongattribute||test.wrongrace){assert.equal(index,-1,'Canonical Bhodi DARK Fiend recipe excludes invalid materials');done=true;continue;}assert(index>=0,'Neutral Fusion activation available');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert(query(L.MZONE).some(x=>x.code===ally),'Actual material Fusion Summon');assert.equal(query(L.MZONE).filter(x=>x.code===top||x.code===filler).length,test.spirit?1:2,'Actual material revivals');assert(trace.some(x=>x.type===M.SPSUMMONED),'Native completion');done=true;
    }else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===ally);core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
    else if(p.type===M.SELECT_CARD){const revival=p.selects.every(c=>c.location===L.GRAVE);if(revival)assert.equal(p.max,test.spirit?1:2,'Spirit revival maximum');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:p.selects.map((_,i)=>i).slice(0,revival?p.max:p.min)});}
    else if(p.type===M.SELECT_UNSELECT_CARD)core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index:p.can_finish?null:Math.max(0,p.select_cards.findIndex(c=>c.code===top))});
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}assert(sequence!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const crypto=require('node:crypto'),sha=p=>crypto.createHash('sha256').update(fs.readFileSync(p)).digest('hex');
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-bhodi-material-fusion'+(process.argv.includes('--neutral-mandatory-adapter')?'-neutral-mandatory-adapter':'')+(process.argv.includes('--old-spirit-cap')?'-old-spirit-cap':'')+'.json'),JSON.stringify({scope:'Full canonical Bhodi recipe and actual material Fusion Summon via neutral Fusion spell using CheckFusionMaterial/SelectFusionMaterial, reason flags and CompleteProcedure; actual GY material revivals two/one with pinned Spirit fixture. DARK Fiend negative material pairs. Explicit legacy FaceupEx and sterile mandatory-material adapters; native Omega/general mandatory effects/equip/banished recipients open.',control:process.argv.includes('--old-spirit-cap')?'old-spirit-cap':null,script_sha256:sha(path.join(CUSTOM,'c'+ally+'.lua')),harness_sha256:sha(__filename),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(x=>x.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
