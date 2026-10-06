'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),crypto=require('node:crypto'),assert=require('node:assert/strict'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,SelectBattleCMDAction:B}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),colony=212684822,aqua=900000321,attacker=900000322,filler=900000323;
 const base={alias:0,setcodes:[],type:17,level:4,attribute:2,race:64n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const results=[];
 for(const test of [{},{ownAttack:true},{defense:true},{bystander:true},{win:true},{odd:true},{defense:true,pierce:true},{disabled:true}]){
  const trace=[],logs=[];let turn=0;
 const control=['no-half','no-reflect'].find(c=>process.argv.includes('--'+c));
 const cards=new Map([[colony,candidateCard(colony)],[aqua,{...base,code:aqua}],[attacker,{...base,code:attacker,attack:test.odd?1501:1500}],[filler,{...base,code:filler}]]);
  const reader=name=>{if(name==='c'+attacker+'.lua'&&test.pierce)return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_PIERCE) e:SetValue(1) c:RegisterEffect(e) end';if(name==='c'+aqua+'.lua'&&test.disabled)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_FIELD) e:SetCode(EFFECT_DISABLE) e:SetRange(LOCATION_MZONE) e:SetTargetRange(LOCATION_MZONE,0) e:SetTarget(function(e,c) return c:IsCode(${colony}) end) c:RegisterEffect(e) end`;if(name==='c'+aqua+'.lua'&&test.win)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_FIELD) e:SetCode(EFFECT_UPDATE_ATTACK) e:SetRange(LOCATION_MZONE) e:SetTargetRange(LOCATION_MZONE,0) e:SetTarget(function(e,c) return c:IsCode(${colony}) end) e:SetValue(2000) c:RegisterEffect(e) end`;if([`c${aqua}.lua`,`c${attacker}.lua`,`c${filler}.lua`].includes(name))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let lua=fs.readFileSync(file,'utf8');if(name==='constant.lua'&&!process.argv.includes('--raw-omega'))lua=lua.replace(/HALF_DAMAGE\s*=\s*-2147483647/,'HALF_DAMAGE=0x80000001').replace(/DOUBLE_DAMAGE\s*=\s*-2147483648/,'DOUBLE_DAMAGE=0x80000000');if(name==='c'+colony+'.lua'){if(control==='no-half')lua=lua.replace('math.floor(ev/2)','ev');if(control==='no-reflect')lua=lua.replace('Duel.ChangeBattleDamage(tp,0)','do end');}return lua};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{if(!cards.has(code))throw Error('Missing card '+code);return cards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,attacked=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
   const add=(code,location,player=0,seq=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:seq,position:code===colony&&test.defense?P.FACEUP_DEFENSE:P.FACEUP_ATTACK});
   add(colony,L.MZONE);if(test.defense)core.duelNewCard(duel,{team:0,duelist:0,code:aqua,controller:0,location:L.HAND,sequence:0,position:P.FACEDOWN_DEFENSE});if(test.bystander||test.win||test.disabled)add(aqua,L.MZONE,0,1);add(attacker,L.MZONE,1);
   for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<130&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
    if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));
    if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(p.type===M.SELECT_IDLECMD){if(p.player===(test.ownAttack?0:1)&&turn>1&&p.to_bp)core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_BP});else core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});}
    else if(p.type===M.SELECT_BATTLECMD){
     if(!attacked){const index=p.attacks.findIndex(c=>c.code===(test.ownAttack?colony:attacker));if(index<0)throw Error('Opponent attack unavailable');attacked=true;core.duelSetResponse(duel,{type:R.SELECT_BATTLECMD,action:B.SELECT_BATTLE,index});}
     else{const damage=trace.filter(m=>m.type===M.DAMAGE);const owner=damage.filter(m=>m.player===0).reduce((n,m)=>n+m.amount,0),opponent=damage.filter(m=>m.player===1).reduce((n,m)=>n+m.amount,0);assert.equal(owner,test.bystander?500:test.disabled?1500:0,'Owner battle damage');assert.equal(opponent,test.defense&&!test.pierce||test.bystander||test.disabled?0:test.win?500:750,'Opponent takes half reflected damage');done=true;break;}
    }else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===(test.ownAttack?attacker:test.bystander?aqua:colony));if(index<0)throw Error('Bubble Colony not a battle target');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:null});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:true});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  results.push({test,status:failure?'FAIL':'PASS',failure,attacked,trace,logs});console.log(`${failure?'FAIL':'PASS'} test=${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/ektelestis-battle'+(process.argv.includes('--raw-omega')?'-raw-omega':process.argv.includes('--no-half')?'-no-half':process.argv.includes('--no-reflect')?'-no-reflect':'')+'.json'),JSON.stringify({scope:'Full production Ektelestis seeded faceup with canonical stats; native attack/defense/bystander battle damage. Test-only signed Omega damage constants translated to public positive 0x80000000/1 unless raw-omega; production now uses continuous PRE_BATTLE_DAMAGE with forced new opponent damage; damage constant adapter is unused by this repair; native Omega/proper summon procedure unverified',script_sha256:crypto.createHash('sha256').update(fs.readFileSync(path.join(CUSTOM,'c'+colony+'.lua'))).digest('hex'),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
