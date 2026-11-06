'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport();
 const {candidateCard}=require('./fresh_installed_card.cjs');
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(x){if(process.argv.includes('--probe-material'))console.log(x)},printErr(){}}),boss=238273769,target=900001301,filler=900001302,partner=900001303,mat1=900001304,mat2=900001305,adjust=900001307;
 const base={alias:0,setcodes:[],type:33,level:3,attribute:8,race:32n,attack:300,defense:200,lscale:0,rscale:0,link_marker:0},results=[];
 for(const scenario of ['lifecycle']){
 const logs=[],trace=[],cards=new Map([[boss,candidateCard(boss)],[filler,{...base,code:filler}],[partner,{...base,code:partner,type:17,setcodes:[0x1066]}],[adjust,{...base,code:adjust,type:2}],[target,{...base,code:target,type:0x2041,attribute:32}],[mat2,{...base,code:mat2,type:2}],[mat1,{...base,code:mat1,type:0x41,attribute:8}]]);
  const reader=name=>{
   if(name===`c${adjust}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local dark=Duel.GetMatchingGroup(Card.IsCode,0,LOCATION_EXTRA,0,nil,${target}):GetFirst() assert(not dark:IsCanBeSpecialSummoned(e,0,0,true,true),'WIND lock missing') Duel.ChangePosition(Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,${boss}),POS_FACEDOWN_DEFENSE) end) c:RegisterEffect(e) end`;
   if(name===`c${mat2}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local dark=Duel.GetMatchingGroup(Card.IsCode,0,LOCATION_EXTRA,0,nil,${target}):GetFirst() assert(dark:IsCanBeSpecialSummoned(e,0,0,true,true),'WIND lock failed to expire') assert(Duel.SpecialSummon(dark,0,0,0,true,true,POS_FACEUP)>0,'Next-turn DARK summon failed') end) c:RegisterEffect(e) end`;
   if([target,mat1,partner].some(c=>name===`c${c}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c0.lua')return '';if(name===`c${filler}.lua`)return 'local s,id=GetID() function s.initial_effect(c) end';
   const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');if(name===`c${boss}.lua`){if(process.argv.includes('--per-copy'))source=source.replace('e3:SetCountLimit(1,id+100)','e3:SetCountLimit(1)');if(process.argv.includes('--no-reset'))source=source.replace('e3:SetCountLimit(1,id+100)','e3:SetCountLimit(1,id+100,2)');if(process.argv.includes('--no-expiry'))source=source.replace('lock:SetReset(RESET_PHASE+PHASE_END)','do end');} return source;
  };

  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,flips=0,turn=0,expiry=false,reset=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,position=P.FACEUP_ATTACK,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});add(boss,L.MZONE,0,P.FACEDOWN_DEFENSE,0);add(boss,L.MZONE,0,P.FACEDOWN_DEFENSE,1);add(adjust,L.HAND);add(mat2,L.HAND,1);add(target,L.EXTRA,0,P.FACEDOWN_DEFENSE);add(partner,L.DECK);add(partner,L.DECK);for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<300&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     const chains=trace.filter(t=>t.type===M.CHAINING&&t.code===boss&&String(t.description)===String(132273769*16+2));
     if(turn===2){if(!expiry){const index=p.activates.findIndex(c=>c.code===mat2);if(index<0)throw Error('Expiry probe missing');expiry=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}if(chains.length!==1)throw Error('Shared Flip use not respected');core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP,index:0});continue;}
     if(turn===1&&flips<2||turn===3&&flips<3){const index=p.pos_changes.findIndex(c=>c.code===boss);if(index<0)throw Error('Native Flip unavailable');flips++;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_POS_CHANGE,index});continue;}
     if(turn===1&&!reset){const index=p.activates.findIndex(c=>c.code===adjust);if(index<0)throw Error('Reset Spell missing');reset=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(turn===1){if(chains.length!==1)throw Error('Shared Flip use not respected');core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP,index:0});continue;}
     if(turn!==3||chains.length!==2)throw Error('Next-turn Flip reset missing');
     const field=core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:0,location:L.MZONE});if(field.filter(c=>c?.code===partner&&c.position===P.FACEDOWN_DEFENSE).length!==2)throw Error('Actual Flip recruits missing');done=true;
    }
    else if(p.type===M.SELECT_UNSELECT_CARD){const index=p.can_finish?null:p.select_cards.findIndex(c=>[boss,mat1,mat2].includes(c.code));if(index!==null&&index<0)throw Error('Actual recipe material selection missing');core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index});}
    else if(p.type===M.SELECT_CARD){const indices=p.selects.map((c,i)=>[partner,boss].includes(c.code)?i:-1).filter(i=>i>=0).slice(0,p.max);if(indices.length<p.min)throw Error('Actual Fusion selection missing');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:indices});}
    else if(p.type===M.SELECT_EFFECTYN){if(p.code!==boss)throw Error('Wrong material trigger source');core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});}
    else if(p.type===M.SELECT_YESNO)throw Error('Unexpected yes/no');
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else if(p.type===M.SELECT_PLACE){const shift=[0,8,16,24].find(v=>[0,1,2,3,4,5,6].some(i=>(p.field_mask&(1<<(v+i)))===0));const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:shift>=16?1-p.player:p.player,location:shift%16===8?L.SZONE:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(e){failure=e.message}finally{core.destroyDuel(duel)}
  results.push({scenario,failure,flips,turn,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify({scenario})}${failure?': '+failure:''}`);
 }
 const control=['per-copy','no-reset','no-expiry'].find(c=>process.argv.includes('--'+c));
 fs.writeFileSync(path.join(ROOT,`output/fresh-ccg-september/current-symphonic-ddj-flip-lifecycle${process.argv.includes('--chaininfo-compat')?'-chaininfo-compat':''}${control?'-'+control:''}.json`),JSON.stringify({material_api_compat:process.argv.includes('--material-api-compat'),scope:'Current installed metadata/corrected transport/no Lua API adapter. Two native Flip Summons share named use; actual next own turn restores use; neutral Spell sets DDJs face-down. Real Deck recruitment checked. Native WIND lock initially blocks DARK Extra eligibility; next opponent turn permits actual DARK Extra summon. Live Omega not verified',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
