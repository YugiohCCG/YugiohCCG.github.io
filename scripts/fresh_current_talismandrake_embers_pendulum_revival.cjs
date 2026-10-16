'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport();
 const {candidateCard}=require('./fresh_current_card.cjs');
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=256928871,target=900001301,filler=900001302,partner=900001303,mat1=900001304,mat2=900001305,adjust=900001307;
 const base={alias:0,setcodes:[],type:33,level:3,attribute:8,race:32n,attack:300,defense:200,lscale:0,rscale:0,link_marker:0},results=[];
 for(const test of [{move:'grave'},{move:'banish'},{move:'hand'},{move:'deck'},{wrongSet:true},{nonFusion:true},{improper:true},{full:true}]){
  const legal=!test.wrongSet&&!test.nonFusion&&!test.improper&&!test.full,logs=[],trace=[],cards=new Map([[boss,candidateCard(boss)],[target,{...base,code:target,type:2}],[adjust,{...base,code:adjust,type:2}],[filler,{...base,code:filler}],[partner,{...base,code:partner,type:test.nonFusion?17:0x41,setcodes:test.wrongSet?[]:[0xb47],race:128n,level:8}],[mat1,{...base,code:mat1,type:17}],[mat2,{...base,code:mat2,type:17}]]);
  const reader=name=>{if(name===`c${adjust}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local fc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,${partner}):GetFirst() assert(fc) ${test.move==='banish'?'Duel.Remove(fc,POS_FACEUP,REASON_EFFECT)':test.move==='hand'?'Duel.SendtoHand(fc,nil,REASON_EFFECT)':test.move==='deck'?'Duel.SendtoDeck(fc,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)':'Duel.SendtoGrave(fc,REASON_EFFECT)'} end) c:RegisterEffect(e) end`;
   if(name===`c${target}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local fc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND+LOCATION_EXTRA,0,nil,${partner}):GetFirst() local g=Duel.GetMatchingGroup(function(c) return c:IsCode(${mat1},${mat2}) end,tp,LOCATION_HAND,0,nil) assert(#g==2) fc:SetMaterial(g) assert(Duel.SendtoGrave(g,REASON_EFFECT+REASON_MATERIAL+REASON_FUSION)==2) assert(Duel.SpecialSummon(fc,${test.nonFusion?'0':'SUMMON_TYPE_FUSION'},tp,tp,false,false,POS_FACEUP)==1) ${test.improper?'':'fc:CompleteProcedure()'} assert(Duel.SendtoGrave(fc,REASON_EFFECT)>0 and fc:IsLocation(LOCATION_GRAVE)) ${test.full?`Duel.SpecialSummon(Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_DECK,0,nil,${filler}),0,tp,tp,false,false,POS_FACEUP)`:''} Duel.Hint(HINT_NUMBER,tp,701) end) c:RegisterEffect(e) end`;
   if(name===`c${partner}.lua`)return 'local s,id=GetID() function s.initial_effect(c) '+(test.nonFusion?'':'c:EnableReviveLimit()')+' end';
   if([filler,mat1,mat2].some(c=>name===`c${c}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(name===`c${boss}.lua`&&process.argv.includes('--old-source')?path.join(ROOT,'output/fresh-ccg-september/embers-before-extra-redirect-repair/c256928871.lua'):file,'utf8');if(name===`c${boss}.lua`&&process.argv.includes('--candidate'))source=source.replace('SetValue(LOCATION_EXTRA)','SetValue(LOCATION_DECK)');if(name===`c${boss}.lua`){if(process.argv.includes('--no-revive'))source=source.replace('Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)','(function() return 0 end)()');if(process.argv.includes('--no-redirect'))source=source.replace('tc:RegisterEffect(e1,true)','');if(process.argv.includes('--allow-wrong-set'))source=source.replace('return c:IsSetCard(SET_TALISMANDRAKE) and c:IsType(TYPE_FUSION)','return c:IsType(TYPE_FUSION)');if(process.argv.includes('--allow-non-fusion'))source=source.replace(' and c:IsType(TYPE_FUSION)','');}return source;};

  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,placed=false,prepared=false,activated=false,redirected=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position});add(boss,L.HAND);add(target,L.HAND);add(adjust,L.HAND);add(mat1,L.HAND);add(mat2,L.HAND);add(partner,test.nonFusion?L.HAND:L.EXTRA,test.opponent?1:0,P.FACEDOWN_DEFENSE);for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<90&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!placed){const index=p.activates.findIndex(c=>c.code===boss&&c.location===L.HAND);if(index<0)throw Error('Native Pendulum activation missing');placed=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(!prepared){const index=p.activates.findIndex(c=>c.code===target);if(index<0)throw Error('Actual Fusion/setup fixture missing');prepared=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     const index=p.activates.findIndex(c=>c.code===boss&&String(c.description)===String(132928871*16));
     if(!legal){if(index>=0)throw Error('Illegal revival available');if(!core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.GRAVE}).some(c=>c?.code===partner))throw Error('Actual GY candidate missing');if(test.full&&core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.MZONE}).filter(c=>c?.code===filler).length!==5)throw Error('Actual full field missing');done=true;continue;}
     if(!activated){if(index<0)throw Error('Native Pendulum revival unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(index>=0)throw Error('Named use limit missing');
     if(!redirected){if(!core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.MZONE}).some(c=>c?.code===partner)||!trace.some(t=>t.type===M.BECOME_TARGET))throw Error('Actual targeted revival missing');const index=p.activates.findIndex(c=>c.code===adjust);if(index<0)throw Error('Actual leave operation missing');redirected=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(!core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.EXTRA}).some(c=>c?.code===partner)||core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.MZONE}).some(c=>c?.code===partner))throw Error('Actual leave-to-Extra redirect missing');done=true;
    }
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===partner);if(index<0)throw Error('Actual revival target missing');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else if(p.type===M.SELECT_PLACE){const shift=[0,8,16,24].find(v=>[0,1,2,3,4].some(i=>(p.field_mask&(1<<(v+i)))===0));const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:shift>=16?1-p.player:p.player,location:shift%16===8?L.SZONE:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(e){failure=e.message}finally{core.destroyDuel(duel)}
  results.push({...test,failure,activated,redirected,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 const control=['old-source','candidate','no-revive','no-redirect','allow-wrong-set','allow-non-fusion'].find(c=>process.argv.includes('--'+c));
 fs.writeFileSync(path.join(ROOT,`output/fresh-ccg-september/current-talismandrake-embers-pendulum-revival${control?'-'+control:''}.json`),JSON.stringify({scope:'Full Embers/current metadata; real neutral Fusion material/procedure/GY history then native targeted revival and leave redirect; no LuaAPI adapter; not native Omega/fullcard certification',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
