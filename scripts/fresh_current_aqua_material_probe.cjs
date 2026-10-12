const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_current_card.cjs');
const ROOT=path.resolve(__dirname,'..'),source=227035644,material=900004301,filler=900004302;
(async()=>{
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href),{OcgLocation:L,OcgPosition:P}=mod;
 const adapter=process.argv.includes('--legacy-faceup-adapter');const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 for(const [location,position] of [[L.MZONE,P.FACEUP_ATTACK],[L.MZONE,P.FACEDOWN_DEFENSE],[L.GRAVE,P.FACEUP_ATTACK],[L.REMOVED,P.FACEUP_ATTACK],[L.REMOVED,P.FACEDOWN_DEFENSE]]){
  const logs=[],neutral={alias:0,setcodes:[],type:17,level:1,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0},cards=new Map([[source,candidateCard(source)],[material,{...neutral,code:material}],[filler,{...neutral,code:filler}]]);
  const reader=name=>{if(name==='c0.lua')return '';if(name==='c'+material+'.lua'||name==='c'+filler+'.lua')return 'local s,id=GetID() function s.initial_effect(c) end';const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(p=>fs.existsSync(p));assert(file,name);return fs.readFileSync(file,'utf8');};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   if(adapter)core.loadScript(duel,'legacy_faceup_adapter.lua','Card.IsFaceupEx=function(c) return c:IsFaceup() or c:IsLocation(LOCATION_HAND+LOCATION_GRAVE+LOCATION_DECK) end');
   for(const [code,loc,pos] of [[source,L.GRAVE,P.FACEUP_ATTACK],[material,location,position]])core.duelNewCard(duel,{team:0,duelist:0,code,controller:0,location:loc,sequence:0,position:pos});
   for(const player of [0,1])for(let i=0;i<5;i++)core.duelNewCard(duel,{team:player,duelist:0,code:filler,controller:player,location:L.DECK,sequence:0,position:P.FACEDOWN_DEFENSE});
   core.loadScript(duel,'aqua_probe.lua',`local e=Effect.GlobalEffect() e:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS) e:SetCode(EVENT_ADJUST) e:SetOperation(function(e) e:Reset() local c=Duel.GetMatchingGroup(Card.IsCode,0,LOCATION_MZONE+LOCATION_GRAVE+LOCATION_REMOVED,0,nil,${material}):GetFirst() Debug.Message('AQUA_MATERIAL:'..tostring(c227035644.cffilter1(c))) end) Duel.RegisterEffect(e,0)`);
   core.startDuel(duel);for(let step=0;step<10&&!logs.some(l=>l.message.includes('AQUA_MATERIAL:'));step++){core.duelProcess(duel);core.duelGetMessage(duel);}
   assert(!logs.some(l=>l.type===0),JSON.stringify(logs));const record=logs.find(l=>l.message.includes('AQUA_MATERIAL:'));assert(record,JSON.stringify(logs));results.push({location,position,eligible:record.message.includes('AQUA_MATERIAL:true'),logs});
  }catch(e){results.push({location,position,failure:e.message,logs});}finally{core.destroyDuel(duel);}
 }
 const sha=p=>crypto.createHash('sha256').update(fs.readFileSync(p)).digest('hex');
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-aqua-material-probe'+(adapter?'-legacy-faceup-adapter':'')+'.json'),JSON.stringify({adapter,scope:'Actual public-core Card filter evaluation on five placements. Diagnostic only: no Fusion Summon and no full/native Omega certificate.',script_sha256:sha(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c227035644.lua')),harness_sha256:sha(__filename),results},null,2));if(adapter)assert.deepEqual(results.map(r=>r.eligible),[true,false,true,true,false]);else assert(results.every(r=>r.failure&&r.logs.some(l=>l.message.includes('IsFaceupEx'))));console.log(JSON.stringify(results.map(({logs,...r})=>r)));
})().catch(e=>{console.error(e);process.exitCode=1});
