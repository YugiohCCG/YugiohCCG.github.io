'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport();
 const {candidateCard}=require('./fresh_current_card.cjs');
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=230947464,target=900001301,filler=900001302,partner=900001303,mat1=900001304,mat2=900001305;
 const base={alias:0,setcodes:[],type:33,level:3,attribute:8,race:32n,attack:300,defense:200,lscale:0,rscale:0,link_marker:0},results=[];
 for(const test of [{},{decline:true},{nonPyro:true},{ordinary:true},{nonFusion:true},{opponent:true}]){
  const legal=!test.nonPyro&&!test.ordinary&&!test.nonFusion&&!test.opponent,logs=[],trace=[],cards=new Map([[boss,candidateCard(boss)],[target,{...base,code:target,type:2}],[filler,{...base,code:filler}],[partner,{...base,code:partner,type:test.nonFusion?17:0x41,race:test.nonPyro?1n:128n,level:8}],[mat1,{...base,code:mat1,type:17}],[mat2,{...base,code:mat2,type:17}]]);
  const reader=name=>{if(name===`c${target}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local p=${test.opponent?1:0} local fc=Duel.GetMatchingGroup(Card.IsCode,p,LOCATION_HAND+LOCATION_EXTRA,0,nil,${partner}):GetFirst() local g=Duel.GetMatchingGroup(function(c) return c:IsCode(${mat1},${mat2}) end,tp,LOCATION_HAND,0,nil) assert(#g==2) fc:SetMaterial(g) assert(Duel.SendtoGrave(g,REASON_EFFECT+REASON_MATERIAL+REASON_FUSION)==2) assert(Duel.SpecialSummon(fc,${test.ordinary||test.nonFusion?'0':'SUMMON_TYPE_FUSION'},tp,p,false,false,POS_FACEUP)==1) ${test.ordinary||test.nonFusion?'':'fc:CompleteProcedure()'} Duel.Hint(HINT_NUMBER,tp,701) end) c:RegisterEffect(e) end`;
   if([filler,partner,mat1,mat2].some(c=>name===`c${c}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');if(name===`c${boss}.lua`){if(process.argv.includes('--allow-ordinary'))source=source.replace('and c:IsSummonType(SUMMON_TYPE_FUSION)','and true');if(process.argv.includes('--allow-opponent'))source=source.replace('c:IsControler(tp) and c:IsSummonType','c:IsSummonType');if(process.argv.includes('--no-damage'))source=source.replace('Duel.Damage(p,d,REASON_EFFECT)','do end');if(process.argv.includes('--no-race-filter'))source=source.replace(' and c:IsRace(RACE_PYRO) and c:IsType(TYPE_FUSION)',' and c:IsType(TYPE_FUSION)');}return source;};

  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,placed=false,activated=false,offers=0,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   if(process.argv.includes('--chaininfo-compat'))core.loadScript(duel,'spark_chaininfo_compat.lua','CHAININFO_TARGET_PLAYER=9 CHAININFO_TARGET_PARAM=10');
   const add=(code,location,player=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position});add(boss,L.HAND);add(target,L.HAND);add(mat1,L.HAND);add(mat2,L.HAND);add(partner,test.nonFusion?L.HAND:L.EXTRA,test.opponent?1:0,P.FACEDOWN_DEFENSE);for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<90&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!placed){const index=p.activates.findIndex(c=>c.code===boss&&c.location===L.HAND);if(index<0)throw Error('Native Pendulum activation missing');placed=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(!activated){const index=p.activates.findIndex(c=>c.code===target);if(index<0)throw Error('Actual Fusion fixture missing');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(offers!==(legal?1:0))throw Error('Printed damage trigger eligibility mismatch');const damage=trace.filter(t=>t.type===M.DAMAGE&&t.player===1).reduce((n,t)=>n+Number(t.amount),0);if(damage!==(legal&&!test.decline?500:0))throw Error('Actual native500 damage mismatch');if(!trace.some(t=>t.type===M.HINT&&t.hint_type===9&&Number(t.hint)===701))throw Error('Actual summon/material history missing');if(!core.duelQueryLocation(duel,{flags:Q.CODE,controller:test.opponent?1:0,location:L.MZONE}).some(c=>c?.code===partner))throw Error('Actual summoned monster missing');done=true;
    }
    else if(p.type===M.SELECT_EFFECTYN){if(p.code!==boss||!legal)throw Error('Wrong optional trigger');offers++;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:!test.decline});}
    else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===boss);if(index>=0){if(!legal)throw Error('Illegal damage trigger');offers++;}core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:test.decline||index<0?null:index});}
    else if(p.type===M.SELECT_PLACE){const shift=[0,8,16,24].find(v=>[0,1,2,3,4].some(i=>(p.field_mask&(1<<(v+i)))===0));const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:shift>=16?1-p.player:p.player,location:shift%16===8?L.SZONE:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(e){failure=e.message}finally{core.destroyDuel(duel)}
  results.push({...test,failure,activated,offers,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 const control=['no-damage','no-race-filter','allow-ordinary','allow-opponent'].find(c=>process.argv.includes('--'+c));
 fs.writeFileSync(path.join(ROOT,`output/fresh-ccg-september/current-talismandrake-spark-pendulum-damage${process.argv.includes('--chaininfo-compat')?'-chaininfo-compat':''}${control?'-'+control:''}.json`),JSON.stringify({chaininfo_compatibility:process.argv.includes('--chaininfo-compat')?{CHAININFO_TARGET_PLAYER:9,CHAININFO_TARGET_PARAM:10,source:'https://raw.githubusercontent.com/ProjectIgnis/CardScripts/master/constant.lua',qualification:'Test-only modern engine constants; not native Omega'}:null,scope:'Full Spark actual Hand PZone and neutral two-material native Fusion event; no native Omega/fullcard certification',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
