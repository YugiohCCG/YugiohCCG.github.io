'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport();
 const {candidateCard}=require('./fresh_current_card.cjs');
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=238273772,amp=75304793,holder=900000851,target=900000852,grave=900000853,setup=900000854,filler=900000855,tuner=900000856,nonTuner=900000857;

 const base={alias:0,setcodes:[],type:33,level:3,attribute:8,race:32n,attack:5000,defense:4000,lscale:0,rscale:0,link_marker:0},results=[];
 for(const test of [{move:'grave'},{move:'banish'},{move:'hand'},{move:'grave',own:true},{move:'grave',decline:true},{move:'grave',full:true},{move:'destroy'},{move:'destroy',own:true}]){
  const legal=!test.own&&!test.decline&&!test.full&&test.move!=='destroy'&&test.move!=='hand',logs=[],trace=[],cards=new Map([[boss,candidateCard(boss)],[amp,{...base,code:amp,type:0x80002,level:0}],[holder,{...base,code:holder,type:0x20002,level:0}],[target,{...base,code:target}],[grave,{...base,code:grave,type:0x10002,level:0}],[setup,{...base,code:setup,type:2,level:0}],[filler,{...base,code:filler}],[tuner,{...base,code:tuner,type:0x1011,level:2}],[nonTuner,{...base,code:nonTuner,type:0x1002011,level:8}]]);
  const action=test.move==='banish'?'Duel.Remove(b,POS_FACEUP,REASON_EFFECT)':test.move==='hand'?'Duel.SendtoHand(b,nil,REASON_EFFECT)':test.move==='destroy'?'Duel.Destroy(b,REASON_EFFECT)':'Duel.SendtoGrave(b,REASON_EFFECT)';
  const reader=name=>{
   if(name===`c${setup}.lua`||name===`c${grave}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp)
    ${test.own?'':"if tp==0 then return end"}
    local b=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,LOCATION_MZONE,nil,${boss}):GetFirst()
    assert(b:IsSummonType(SUMMON_TYPE_SYNCHRO) and b:IsStatus(STATUS_PROC_COMPLETE),'Actual proper Synchro history missing') Duel.Hint(HINT_NUMBER,tp,701) Duel.Hint(HINT_NUMBER,tp,b:IsCanBeEffectTarget(e)==(tp==0) and 988 or 989)
    ${action}
   end) c:RegisterEffect(e) end`;
   if([holder,target,filler,tuner,nonTuner].some(c=>name===`c${c}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');if(name===`c${boss}.lua`){if(process.argv.includes('--no-placement'))source=source.replace('Duel.MoveToField(c,tp,tp,LOCATION_PZONE,POS_FACEUP,true)','(function() return false end)()');if(process.argv.includes('--no-destruction-protection'))source=source.replace('c:RegisterEffect(e5)','');if(process.argv.includes('--no-target-protection'))source=source.replace('c:RegisterEffect(e4)','');}return source;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,summoned=false,prepared=false,activated=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   core.loadScript(duel,'bounded_synchro_compat.lua',`assert(Duel.CheckSynchroMaterial==nil)
local modernNotTuner=Card.IsNotTuner Card.IsNotTuner=function(c,sc) return modernNotTuner(c,sc,sc:GetControler()) end
local function materials(c,f1,f2,minc,maxc)
 local tp=c:GetControler()
 local t=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,${tuner}):GetFirst()
 local n=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,${nonTuner}):GetFirst()
 if not t or not n or minc>1 or maxc<1 or not t:IsFaceup() or not n:IsFaceup() or not t:IsType(TYPE_TUNER) or not f1(t,c) or not f2(n,c) or t:GetLevel()+n:GetLevel()~=c:GetLevel() or not t:IsCanBeSynchroMaterial(c) or not n:IsCanBeSynchroMaterial(c) then return nil end
 local g=Group.FromCards(t,n) return g
end
Duel.CheckSynchroMaterial=function(c,f1,f2,minc,maxc) return materials(c,f1,f2,minc,maxc)~=nil end
Duel.SelectSynchroMaterial=function(tp,c,f1,f2,minc,maxc) return materials(c,f1,f2,minc,maxc) end`);
   const add=(code,location,player=0,sequence=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});add(boss,L.EXTRA,0,0,P.FACEDOWN_DEFENSE);add(tuner,L.MZONE,0,2);add(nonTuner,L.MZONE,0,3);add(setup,L.HAND);if(!test.own)add(grave,L.SZONE,1,2,P.FACEDOWN_DEFENSE);if(test.full){add(holder,L.SZONE,0,0);add(holder,L.SZONE,0,4);}for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<120&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!summoned){const index=p.special_summons.findIndex(c=>c.code===boss);if(index<0)throw Error('Actual native Synchro procedure missing');summoned=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SPECIAL_SUMMON,index});continue;}
     if(!prepared){const index=p.activates.findIndex(c=>c.code===setup);if(index<0)throw Error('Setup missing');prepared=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     const zone=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.SZONE}),field=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.MZONE});
     if(!trace.some(t=>t.type===M.HINT&&t.hint_type===9&&Number(t.hint)===701))throw Error('Actual proper history witness missing');if(!trace.some(t=>t.type===M.HINT&&t.hint_type===9&&Number(t.hint)===988)||trace.some(t=>t.type===M.HINT&&t.hint_type===9&&Number(t.hint)===989))throw Error('Native target eligibility mismatch');
     if(zone.some(c=>c?.code===boss)!==legal)throw Error('Pendulum placement mismatch');
     if(!legal&&test.move!=='hand'&&(test.move!=='destroy'||test.own)&&!core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:0,location:L.EXTRA}).some(c=>c?.code===boss&&(c.position&P.FACEUP_DEFENSE)))throw Error('Actual faceup Extra destination missing');
     if(test.move==='hand'&&!core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:0,location:L.EXTRA}).some(c=>c?.code===boss&&c.position===P.FACEDOWN_DEFENSE))throw Error('Native hidden Extra return missing');if(test.move==='destroy'&&field.some(c=>c?.code===boss)!==!test.own)throw Error('Effect destruction immunity mismatch');
     if(!test.own&&!activated)throw Error('Opponent fixture did not activate');done=true;
    }
    else if(p.type===M.SELECT_CHAIN){let index=p.selects.findIndex(c=>c.code===grave);if(index>=0){if(activated||!prepared)index=-1;else activated=true;}else{index=p.selects.findIndex(c=>c.code===boss&&String(c.description)===String(132273772*16+2));if(index>=0&&(test.own||test.full||test.move==='destroy'))throw Error('Ineligible placement trigger offered');if(test.decline)index=-1;}core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index<0?null:index});}
    else if(p.type===M.SELECT_EFFECTYN){if(test.own||test.full||test.move==='destroy')throw Error('Ineligible placement trigger offered');core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:!test.decline});}
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,4,1,2,3].find(i=>(p.field_mask&(1<<(8+i)))===0);}core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(e){failure=e.message}finally{core.destroyDuel(duel)}
  results.push({...test,failure,summoned,activated,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 const control=['no-placement','no-destruction-protection','no-target-protection'].find(c=>process.argv.includes('--'+c));
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-symphonic-megastaar-leave-proper-history'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'public OCGCore with full Mega Staar and official Amplifire; not native Omega',qualifiers:['Actual proper native Synchro via bounded test-only legacy API/IsNotTuner adapters; own Spell and opponent chained Quick-Play perform actual moves/destruction','IsCanBeEffectTarget probes targeting protection; no actual targeted effect is activated','General production Synchro recipe, battle destruction, and native Omega remain unverified'],results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
