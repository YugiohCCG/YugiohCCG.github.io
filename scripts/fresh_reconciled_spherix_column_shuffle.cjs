'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_installed_card.cjs');
const ROOT=path.resolve(__dirname,'..'),source=231088629,setup=900004101,own=900004102,enemy=900004103;
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),control=['old-faceup','no-shuffle','no-column','no-cost'].find(c=>process.argv.includes('--'+c))||null,results=[];
 for(const test of [{},{facedown:true},{trapPartner:true},{fusionPartner:true},{wrongSet:true},{wrongColumn:true},{spellPartner:true},{oneCounter:true},{targetImmune:true}]){
  const trace=[],logs=[],neutral={alias:0,setcodes:[],type:17,level:1,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[source,candidateCard(source)],[setup,{...neutral,code:setup,type:2}],[own,{...neutral,code:own,type:test.spellPartner?2:test.fusionPartner?0x61:17,setcodes:test.wrongSet?[]:[0x760]}],[enemy,{...neutral,code:enemy}]]);
  const expected=!test.wrongSet&&!test.wrongColumn&&!test.spellPartner&&!test.oneCounter;
  const reader=name=>{
   if(name==='c0.lua')return '';
   if(name==='c'+setup+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) s.n=(s.n or 0)+1 local sc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_MZONE,0,nil,${source}) if s.n==2 then assert(sc:GetCounter(0x1290)==0,"Exact two-counter cost consumed") return end assert(sc:AddCounter(0x1290,${test.oneCounter?1:2}),"Fixture counters placed") end) c:RegisterEffect(e) end`;
   if(name==='c'+own+'.lua')return `local s,id=GetID() function s.initial_effect(c) ${test.trapPartner?'local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_CHANGE_TYPE) e:SetValue(TYPE_TRAP+TYPE_CONTINUOUS) c:RegisterEffect(e)':''} end`;
   if(name==='c'+enemy+'.lua')return `local s,id=GetID() function s.initial_effect(c) ${test.targetImmune?'local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_CANNOT_BE_EFFECT_TARGET) e:SetValue(1) c:RegisterEffect(e)':''} end`;
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(p=>fs.existsSync(p));assert(file,'Missing '+name);let lua=fs.readFileSync(file,'utf8');
   if(name==='c'+source+'.lua'){
    if(control==='no-cost')lua=lua.replace('e:GetHandler():RemoveCounter(tp,COUNTER_GRAVITY,2,REASON_COST)','do end');
    if(control==='old-faceup')lua=lua.replace('return c:IsType(TYPE_MONSTER) and c:IsAbleToDeck()','return c:IsFaceup() and c:IsType(TYPE_MONSTER) and c:IsAbleToDeck()');
    if(control==='no-shuffle')lua=lua.replace('Duel.SendtoDeck(Group.FromCards(oc,gc),nil,SEQ_DECKSHUFFLE,REASON_EFFECT)','do end');
    if(control==='no-column')lua=lua.replace('and oc:GetColumnGroup():IsContains(c)','');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,done=false,placed=false,used=false,probed=false;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,n,reader(n));
   const add=(code,location,player=0,sequence=0,position=P.FACEDOWN_DEFENSE)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(source,L.MZONE,0,0,P.FACEUP_ATTACK);add(own,test.trapPartner||test.spellPartner?L.SZONE:L.MZONE,0,test.wrongColumn?1:2,P.FACEUP_ATTACK);add(enemy,L.MZONE,1,2,test.facedown?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK);add(setup,L.HAND);add(setup,L.HAND);
   for(const player of [0,1])for(let i=0;i<5;i++)add(setup,L.DECK,player);core.startDuel(duel);
   const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller,location}).filter(Boolean);
   for(let step=0;step<150&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);assert(!logs.some(l=>l.type===0),JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!placed){const index=p.activates.findIndex(c=>c.code===setup);assert(index>=0);placed=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(!used){const index=p.activates.findIndex(c=>c.code===source);assert.equal(index>=0,expected,'Printed column-shuffle activation availability');if(index<0){done=true;continue;}used=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(!probed){const index=p.activates.findIndex(c=>c.code===setup);assert(index>=0);probed=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert(!query(L.MZONE,1).some(c=>c.code===enemy),'Opponent recipient left field');assert(query(L.DECK,1).some(c=>c.code===enemy),'Opponent recipient in owner Deck');assert(query(test.fusionPartner?L.EXTRA:L.DECK).some(c=>c.code===own),'Own recipient in owner Deck/Extra');assert(!p.activates.some(c=>c.code===source),'Counter cost consumed');assert.equal(trace.filter(m=>m.type===M.CHAINING&&m.code===source).length,1,'Actual Spherix chain');assert(!trace.some(m=>m.type===M.BECOME_TARGET),'Shuffle is non-targeting');done=true;
    }else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===enemy||c.code===own);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);assert(sequence!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:p.player,location:L.SZONE,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}
  results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 const sha=p=>crypto.createHash('sha256').update(fs.readFileSync(p)).digest('hex');
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-reconciled-spherix-column-shuffle'+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Canonical Spherix initially fielded, two counters supplied by actual neutral Spell. Actual non-targeting column shuffle, face-down/Continuous-Trap/Fusion partner and rejection boundaries. Synthetic recipients; proper Synchro, chain interruption and native Omega remain open.',control,script_sha256:sha(path.join(ROOT,'public/CCG Downloads/CCG_Scripts/c'+source+'.lua')),harness_sha256:sha(__filename),results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 if(results.some(r=>r.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
