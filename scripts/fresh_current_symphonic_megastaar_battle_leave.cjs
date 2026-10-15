'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport();
 const {candidateCard}=require('./fresh_current_card.cjs');
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,SelectBattleCMDAction:B,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=238273772,target=900000831,filler=900000832,setup=900000833,tuner=900000834,nonTuner=900000835,enemy=900000859,blocker=900000860;

 const base={alias:0,setcodes:[],type:33,level:3,attribute:8,race:32n,attack:300,defense:200,lscale:0,rscale:0,link_marker:0},results=[];
 for(const test of [{},{decline:true},{full:true},{weak:true}]){
  const legal=!test.noCost&&!test.nonWind&&!test.nonMachine&&!test.nonSynchro,logs=[],trace=[],cards=new Map([[boss,candidateCard(boss)],[target,{...base,code:target,setcodes:[],type:test.nonSynchro?33:0x2021,attribute:test.nonWind?32:8,race:test.nonMachine?1n:32n}],[filler,{...base,code:filler}],[enemy,{...base,code:enemy,attack:test.weak?1000:6000,defense:0}],[blocker,{...base,code:blocker,type:0x20002,level:0}],[setup,{...base,code:setup,type:2,level:0}],[tuner,{...base,code:tuner,type:0x1011,level:2}],[nonTuner,{...base,code:nonTuner,type:0x1002011,level:process.argv.includes('--wrong-total')?7:8}]]);
  const reader=name=>{if(name===`c${setup}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local b=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,${boss}):GetFirst() assert(b and b:IsSummonType(SUMMON_TYPE_SYNCHRO) and b:IsStatus(STATUS_PROC_COMPLETE)) Duel.Hint(HINT_NUMBER,tp,701) end) c:RegisterEffect(e) end`;if([target,filler,tuner,nonTuner,enemy,blocker].some(c=>name===`c${c}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');if(name===`c${boss}.lua`){if(process.argv.includes('--no-placement'))source=source.replace('Duel.MoveToField(c,tp,tp,LOCATION_PZONE,POS_FACEUP,true)','(function() return false end)()');if(process.argv.includes('--no-battle-trigger'))source=source.replace('c:IsReason(REASON_BATTLE) or ','');if(process.argv.includes('--no-summon'))source=source.replace('Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)','(function() return 0 end)()');if(process.argv.includes('--no-cost'))source=source.replace('Duel.Release(g,REASON_COST)','do end');}return source};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,summoned=false,placed=false,activated=false,done=false,attacked=false,turn=0,choices=0;
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
   const add=(code,location,player=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position});add(boss,L.EXTRA,0,P.FACEDOWN_DEFENSE);add(setup,L.HAND);add(enemy,L.MZONE,1);if(test.full){core.duelNewCard(duel,{team:0,duelist:0,code:blocker,controller:0,location:L.SZONE,sequence:0,position:P.FACEUP_ATTACK});core.duelNewCard(duel,{team:0,duelist:0,code:blocker,controller:0,location:L.SZONE,sequence:4,position:P.FACEUP_ATTACK});}if(!test.noCost)add(target,L.MZONE);core.duelNewCard(duel,{team:0,duelist:0,code:tuner,controller:0,location:L.MZONE,sequence:2,position:P.FACEUP_ATTACK});core.duelNewCard(duel,{team:0,duelist:0,code:nonTuner,controller:0,location:L.MZONE,sequence:3,position:P.FACEUP_ATTACK});for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<300&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(!summoned){const index=p.special_summons.findIndex(c=>c.code===boss);if(index<0)throw Error('Actual native Synchro procedure missing');summoned=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SPECIAL_SUMMON,index});continue;}if(!placed){const index=p.activates.findIndex(c=>c.code===setup&&c.location===L.HAND);if(index<0)throw Error('Pendulum activation missing');placed=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}if(turn!==3){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP,index:0});continue;}core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_BP,index:0});}
    else if(p.type===M.SELECT_BATTLECMD){if(!attacked){const index=p.attacks.findIndex(c=>c.code===boss);if(index<0)throw Error('Actual source attack missing');attacked=true;core.duelSetResponse(duel,{type:R.SELECT_BATTLECMD,action:B.SELECT_BATTLE,index});continue;}
     if(!trace.some(t=>t.type===M.ATTACK)||!trace.some(t=>t.type===M.HINT&&t.hint_type===9&&Number(t.hint)===701))throw Error('Actual battle/proper history missing');
     const zones=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.SZONE}),field=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.MZONE}),extra=core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:0,location:L.EXTRA});
     if(choices!==(!test.full&&!test.weak?1:0))throw Error('Actual optional battle leave choice mismatch');if(JSON.stringify(trace.filter(t=>t.type===M.NEW_TURN).map(t=>t.player))!=='[0,1,0]')throw Error('Actual natural own battle turn missing');const place=!test.weak&&!test.decline&&!test.full;if(zones.some(c=>c?.code===boss)!==place||field.some(c=>c?.code===boss)!==!!test.weak)throw Error('Battle leave/PZone outcome mismatch');if(!place&&!test.weak&&!extra.some(c=>c?.code===boss&&(c.position&P.FACEUP_DEFENSE)))throw Error('Battle faceupExtra destination missing');
     const expected=Math.abs(cards.get(boss).attack-cards.get(enemy).attack),damagedPlayer=test.weak?1:0;if(trace.filter(t=>t.type===M.DAMAGE&&t.player===damagedPlayer).reduce((n,t)=>n+Number(t.amount),0)!==expected)throw Error('Native battle damage mismatch');done=true;}

    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===enemy);if(index<0)throw Error('Actual battle target missing');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_EFFECTYN){choices++;if(test.full||test.weak)throw Error('Ineligible battle leave offered');core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:!test.decline});}
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:null});
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,4,1,2,3].find(i=>(p.field_mask&(1<<(8+i)))===0);}core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(e){failure=e.message}finally{core.destroyDuel(duel)}
  results.push({...test,failure,summoned,attacked,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 const control=['no-placement','no-battle-trigger'].find(c=>process.argv.includes('--'+c));
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-symphonic-megastaar-battle-leave'+(control?'-'+control:'')+'.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; Mega Staar production effects; actual native two-material Synchro procedure via explicit bounded legacy-API adapter, actual ownturn3 attack into stronger/weaker opponent and optional battle leave PZone placement; no CompleteProcedure; not native Omega or production recipe certification',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
