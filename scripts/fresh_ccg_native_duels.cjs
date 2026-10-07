"use strict";
// Real engine cards, effects, legality, prompts and resolution. No Duel/Card mocks.
// The public core is NOT the native Omega executable; differences remain explicit.
const fs = require('node:fs');
const path = require('node:path');
const {pathToFileURL} = require('node:url');
const {DatabaseSync} = require('node:sqlite');
const crypto = require('node:crypto');
const {execFileSync} = require('node:child_process');
const ROOT = path.resolve(__dirname, '..');
const CUSTOM = path.join(ROOT, 'public/CCG Downloads/CCG_Scripts');
const OMEGA = path.join(ROOT, 'tmp/omega_scripts');
const OUT = path.join(ROOT, 'output/fresh-ccg-september');
const baseline = process.argv.includes('--baseline');
const hash = data => crypto.createHash('sha256').update(data).digest('hex');
const json = value => JSON.stringify(value, (_, v) => typeof v === 'bigint' ? v.toString() : v, 2);

async function main() {
  const mod = await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')), 'dist/index.js')).href);
  const {OcgMessageType:M, OcgResponseType:R, OcgLocation:L, OcgPosition:P, OcgProcessResult:S, SelectIdleCMDAction:A} = mod;
  const core = await mod.default({sync:true, print(){}, printErr(){}});
  const db = new DatabaseSync(path.join(ROOT,'public/CCG Downloads/CCG_Database/CCG_v1.db'), {readOnly:true});
  const query = db.prepare('select * from datas where id=?'); query.setReadBigInts(true);
  function customData(code) {
    const d = query.get(code); if (!d) throw Error(`Missing metadata ${code}`);
    const packed = d.setcode instanceof Uint8Array
      ? [...d.setcode].reduce((value,byte,i)=>value|(BigInt(byte)<<BigInt(i*8)),0n)
      : BigInt(d.setcode);
    const level = Number(d.level), type = Number(d.type);
    return {code,alias:Number(d.alias),setcodes:[0,1,2,3].map(i=>Number((packed>>BigInt(i*16))&65535n)).filter(Boolean),type,
      level:level&255,attribute:Number(d.attribute),race:BigInt(d.race),attack:Number(d.atk),defense:Number(d.def),
      lscale:(level>>>24)&255,rscale:(level>>>16)&255,link_marker:0};
  }
  const SURF=259944344, ORACLE=900000001, DUMMY=900000002, FILLER=900000003, SPINE=88316955;
  const base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:500,defense:500,lscale:0,rscale:0,link_marker:0};
  const metadata=new Map([[SURF,customData(SURF)],[ORACLE,{...base,code:ORACLE,type:2}],[DUMMY,{...base,code:DUMMY,type:33}],
    [FILLER,{...base,code:FILLER}],[SPINE,{...base,code:SPINE,setcodes:[0x104],type:0x200021,race:0x800n}]]);
  const results=[];
  const cases=[false,true].flatMap(protectedTarget=>['omega-reference','ccg'].map(variant=>({protectedTarget,variant})));
  for(const cardActivation of [false,true]) for(const worldLegacy of [false,true])
    cases.push({protectedTarget:false,variant:'ccg',prior:{cardActivation,worldLegacy}});
  for(const cardActivation of [false,true]) for(const worldLegacy of [false,true])
    cases.push({protectedTarget:false,variant:'ccg',future:{cardActivation,worldLegacy}});
  for (const {protectedTarget,variant,prior,future} of cases) {
    const logs=[],trace=[],loaded={}; const spell=variant==='ccg'?SURF:ORACLE;
    const injected={
      [`c${ORACLE}.lua`]:`local s,id=GetID()
function s.initial_effect(c)
 local e=Effect.CreateEffect(c)
 e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN)
 e:SetProperty(EFFECT_FLAG_CARD_TARGET)
 e:SetTarget(c88316955.target) e:SetOperation(c88316955.operation)
 c:RegisterEffect(e)
end`,
      [`c${DUMMY}.lua`]:`local s,id=GetID()
function s.initial_effect(c)
 ${protectedTarget ? 'local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_CANNOT_BE_EFFECT_TARGET) e:SetProperty(EFFECT_FLAG_SINGLE_RANGE) e:SetRange(LOCATION_MZONE) e:SetValue(1) c:RegisterEffect(e)' : ''}
 local watch=Effect.CreateEffect(c)
 watch:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS) watch:SetCode(EVENT_CHAINING)
 watch:SetOperation(function(e,tp,eg,ep,ev,re)
  if re:GetHandler():IsCode(${spell}) then
   assert(re:IsHasProperty(EFFECT_FLAG_CARD_TARGET),'Copied targeting effect must advertise CARD_TARGET')
  end
 end)
 Duel.RegisterEffect(watch,0)
end`,
    };
    const actor=prior||future;
    if(actor) {
      metadata.set(ORACLE,{...base,code:ORACLE,type:actor.cardActivation?(future?0x10002:2):0x20002,setcodes:actor.worldLegacy?[0xfe]:[]});
      injected[`c${ORACLE}.lua`]=`local s,id=GetID()
function s.initial_effect(c)
 local e=Effect.CreateEffect(c)
 e:SetType(${actor.cardActivation?'EFFECT_TYPE_ACTIVATE':future?'EFFECT_TYPE_QUICK_O':'EFFECT_TYPE_IGNITION'})
 ${actor.cardActivation?'e:SetCode(EVENT_FREE_CHAIN)':'e:SetRange(LOCATION_SZONE)'+(future?' e:SetCode(EVENT_FREE_CHAIN)':'')}
 e:SetCountLimit(1) e:SetOperation(function() end) c:RegisterEffect(e)
end`;
    }
    const readScript=name=>{
      if (name in injected) return injected[name];
      if(name===`c${FILLER}.lua` || name==='c0.lua') return '';
      const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(p=>fs.existsSync(p));
      if(!file) throw Error(`Missing script ${name}`);
      const source=baseline && name===`c${SURF}.lua`
        ? execFileSync('git',['show',`HEAD:public/CCG Downloads/CCG_Scripts/${name}`],{cwd:ROOT,encoding:'utf8'})
        : fs.readFileSync(file,'utf8');
      loaded[name]=hash(source); return source;
    };
    const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,
      seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},
      cardReader:code=>{if(!metadata.has(code)) throw Error(`Unexpected card ${code}`); return metadata.get(code);},
      scriptReader:readScript,errorHandler:(type,message)=>logs.push({type,message})});
    let failure=null, available=null, activated=false, completed=false, priorActivated=false;
    try {
      for(const name of ['constant.lua','utility.lua','procedure.lua'])
        if(!core.loadScript(duel,name,readScript(name))) throw Error(`Support load failed: ${name}`);
      const add=(code,player,location,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position:P.FACEUP_ATTACK});
      add(SPINE,0,L.HAND); add(spell,0,L.HAND); add(DUMMY,1,L.MZONE);
      if(actor) add(ORACLE,0,actor.cardActivation?L.HAND:L.SZONE);
      for(const player of [0,1]) for(let i=0;i<5;i++) add(FILLER,player,L.DECK);
      core.startDuel(duel);
      for(let step=0;step<100&&!completed;step++) {
        const status=core.duelProcess(duel); const messages=core.duelGetMessage(duel); trace.push(...messages);
        if(logs.some(l=>l.type===0)) throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));
        if(activated && messages.some(m=>m.type===M.CHAIN_END)) {
          if(future) throw Error('Restriction probe never reached a response window');
          if(core.duelQueryCount(duel,1,L.MZONE)!==0 || core.duelQueryCount(duel,1,L.GRAVE)!==1) throw Error('Selected monster was not destroyed');
          completed=true;
          break;
        }
        if(status===S.END) throw Error('Duel ended before assertion');
        if(status!==S.WAITING) continue;
        const prompt=messages.at(-1); if(!prompt) throw Error('Waiting with no prompt');
        if(prompt.type===M.SELECT_IDLECMD) {
          if(future&&!activated&&!prompt.activates.some(c=>c.code===ORACLE))
            throw Error('Future action unavailable before restriction: invalid fixture');
          if(prior&&!priorActivated) {
            const index=prompt.activates.findIndex(c=>c.code===ORACLE);
            if(index<0) throw Error('Prior action unavailable: invalid fixture');
            priorActivated=true;
            core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});
            continue;
          }
          if(activated) {
            if(core.duelQueryCount(duel,1,L.MZONE)!==0 || core.duelQueryCount(duel,1,L.GRAVE)!==1) throw Error('Selected monster was not destroyed');
            completed=true; break;
          }
          const index=prompt.activates.findIndex(c=>c.code===spell); available=index>=0;
          const expected=!protectedTarget && !(prior?.cardActivation && !prior?.worldLegacy);
          if(available!==expected) throw Error(`Expected activation ${expected}, got ${available}`);
          if(!available) {completed=true;break;}
          activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});
        } else if(prompt.type===M.SELECT_CHAIN) {
          if(future&&activated&&prompt.player===0) {
            const canRespond=prompt.selects.some(c=>c.code===ORACLE);
            const expected=!future.cardActivation||future.worldLegacy;
            if(canRespond!==expected) throw Error(`Expected response availability ${expected}, got ${canRespond}`);
            completed=true;break;
          }
          core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:null});
        }
        else if(prompt.type===M.SELECT_CARD) core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[0]});
        else if(prompt.type===M.SELECT_PLACE) {
          const sequence=[0,1,2,3,4].find(i=>(prompt.field_mask&(1<<(8+i)))===0);
          if(sequence===undefined) throw Error('No free spell zone in prompt');
          core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:L.SZONE,sequence}]});
        }
        else throw Error(`Unhandled prompt ${json(prompt)}`);
      }
      if(!completed) throw Error('Scenario step limit reached');
    } catch(error) {failure=error.message;} finally {core.destroyDuel(duel);}
    results.push({scenario:prior?'Surfacing prior Spell activation restriction':future?'Surfacing ongoing Spell activation restriction':'Surfacing copies Spine',prior,future,variant,protectedTarget,available,status:failure?'FAIL':'PASS',failure,loaded,logs,trace});
    console.log(`${failure?'FAIL':'PASS'} ${variant} protected=${protectedTarget}${prior?' prior='+JSON.stringify(prior):''}${future?' future='+JSON.stringify(future):''}${failure?' '+failure:''}`);
  }
  db.close();fs.mkdirSync(OUT,{recursive:true});
  fs.writeFileSync(path.join(OUT,baseline?'native-duels-baseline.json':'native-duels.json'),json({baseline,engine:'EDOPro public OCGCore WASM, Omega Lua support; not native Omega',version:core.getVersion(),results})+'\n');
  if(results.some(r=>r.status==='FAIL')) process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1;});
