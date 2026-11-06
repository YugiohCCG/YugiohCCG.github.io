'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{candidateCard}=require('./fresh_installed_card.cjs');
const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september'),boss=218142234,left=238136421,right=215921734,probe=900004701,victim=900004702,response=900004703,filler=900004704;
const guard='\tif not (c:IsRelateToEffect(e) and c:IsFaceup()) then return end';
function corrected(s){const at=s.indexOf('function s.desop(e,tp,eg,ep,ev,re,r,rp)');assert(at>=0);const tail=s.slice(at);assert.equal(tail.split(guard).length,2);return s.slice(0,at)+tail.replace(guard+'\r\n','').replace(guard+'\n','');}
exports.corrected=corrected;
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport(),{OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod,core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['old-source','no-wipe','no-response'].find(x=>process.argv.includes('--'+x));
 for(const scenario of ['baseline','banishSource','faceDownSource','removeArms','negateActivation','negateEffect','noLeft','noRight','lowLP']){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:33,level:4,attribute:1,race:1n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[left,candidateCard(left)],[right,candidateCard(right)],[probe,{...base,code:probe}],[victim,{...base,code:victim}],[victim+10,{...base,code:victim+10,type:0x20002}],[victim+11,{...base,code:victim+11,type:4}],[response,{...base,code:response,type:0x100004}],[filler,{...base,code:filler}]]);
  const reader=name=>{
   if(name==='c0.lua')return '';
   if([left,right,victim,victim+10,victim+11,filler].some(x=>name==='c'+x+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';
   if(name==='c'+probe+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetOperation(function(e,tp) local fc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_MZONE,0,nil,${boss}) for _,code in ipairs({${scenario==='noLeft'?'':left},${scenario==='noRight'?'':right}}) do local ec=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_HAND,0,nil,code) assert(ec and Duel.Equip(tp,ec,fc)) local lim=Effect.CreateEffect(ec) lim:SetType(EFFECT_TYPE_SINGLE) lim:SetCode(EFFECT_EQUIP_LIMIT) lim:SetProperty(EFFECT_FLAG_CANNOT_DISABLE) lim:SetValue(function(e,c) return c==e:GetLabelObject() end) lim:SetLabelObject(fc) lim:SetReset(RESET_EVENT+RESETS_STANDARD) ec:RegisterEffect(lim) end end) c:RegisterEffect(e) end`.replace('ipairs({,','ipairs({');
   if(name==='c'+response+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_CHAINING) e:SetCondition(function(e,tp,eg,ep,ev,re) return re:GetHandler():IsCode(${boss}) end) e:SetOperation(function(e,tp,eg,ep,ev,re) ${control==='no-response'?'do end':scenario==='banishSource'?'Duel.Remove(re:GetHandler(),POS_FACEUP,REASON_EFFECT)':scenario==='faceDownSource'?'Duel.ChangePosition(re:GetHandler(),POS_FACEDOWN_DEFENSE)':scenario==='removeArms'?`Duel.Remove(Duel.GetMatchingGroup(Card.IsCode,1-tp,LOCATION_SZONE,0,nil,${left},${right}),POS_FACEUP,REASON_EFFECT)`:scenario==='negateActivation'?'Duel.NegateActivation(ev)':'Duel.NegateEffect(ev)'} end) c:RegisterEffect(e) end`;
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(fs.existsSync);assert(file,name);let lua=fs.readFileSync(file,'utf8');
   if(name==='c'+boss+'.lua'){
    if(control==='old-source')lua=fs.readFileSync(path.join(OUT,'seraphina-before-wipe-relation-repair',name),'utf8');
    if(process.argv.includes('--candidate'))lua=corrected(lua);
    if(control==='no-wipe'){const at=lua.indexOf('function s.desop(');lua=lua.slice(0,at)+lua.slice(at).replace('Duel.Destroy(g,REASON_EFFECT)','do end');}
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:scenario==='lowLP'?999:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{assert(cards.has(code),code);return cards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,prepared=false,activated=false,chained=false,done=false;
  try{
   for(const n of ['constant.lua','utility.lua','procedure.lua'])assert(core.loadScript(duel,n,reader(n)));
   const add=(code,location,player=0,sequence=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(boss,L.MZONE);add(probe,L.MZONE,0,4);add(left,L.HAND);add(right,L.HAND);add(victim,L.MZONE,1);add(victim+10,L.SZONE,1,2);add(victim+11,L.SZONE,1,3,P.FACEDOWN_DEFENSE);
   const responds=!['baseline','noLeft','noRight','lowLP'].includes(scenario);if(responds)add(response,L.SZONE,1,0,P.FACEDOWN_DEFENSE);
   for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   const query=(controller,location)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller,location}).filter(Boolean);
   for(let step=0;step<160&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!prepared){const index=p.activates.findIndex(c=>c.code===probe);assert(index>=0);prepared=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     const eligible=!['noLeft','noRight','lowLP'].includes(scenario),index=p.activates.findIndex(c=>c.code===boss&&Number(c.description)===132142234*16+3);
     if(!activated){assert.equal(index>=0,eligible,'Printed arms/LP activation requirements');if(!eligible){done=true;continue;}activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     assert.equal(chained,responds,'Native CL2 response');assert(trace.some(m=>m.type===M.PAY_LPCOST&&m.amount===1000),'Actual 1000 LP cost');
     const success=!['negateActivation','negateEffect'].includes(scenario);assert.equal(query(1,L.GRAVE).some(c=>c.code===victim),success,'Independent opponent-field destruction');
     for(const code of [victim,victim+10,victim+11])assert.equal(trace.filter(m=>m.type===M.MOVE&&m.card===code&&m.to.location===L.GRAVE).length,success?1:0,'All opposing monster/faceup Spell/facedown Trap destroyed');
     if(scenario==='banishSource')assert(query(0,L.REMOVED).some(c=>c.code===boss),'Source actually banished');
     if(scenario==='faceDownSource')assert(query(0,L.MZONE).some(c=>c.code===boss&&(c.position&P.FACEDOWN_DEFENSE)),'Source actually face down');
     if(scenario==='removeArms')assert.equal(query(0,L.REMOVED).filter(c=>[left,right].includes(c.code)).length,2);
     done=true;
    }else if(p.type===M.SELECT_CHAIN){const index=!chained?p.selects.findIndex(c=>c.code===response):-1;if(index>=0)chained=true;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:null});}
    else if(p.type===M.SELECT_EFFECTYN)core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:false});
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:false});
    else if(p.type===M.SELECT_PLACE){const shift=[0,8,16,24].find(v=>[0,1,2,3,4].some(i=>(p.field_mask&(1<<(v+i)))===0)),sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(shift+i)))===0);assert(shift!==undefined);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:shift>=16?1-p.player:p.player,location:shift%16===8?L.SZONE:L.MZONE,sequence}]});}
    else throw Error('Unhandled '+JSON.stringify(p));
   }assert(done,'Step limit');
  }catch(e){failure=e.message}finally{core.destroyDuel(duel)}
  results.push({scenario,failure,trace,logs});console.log((failure?'FAIL ':'PASS ')+scenario+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(OUT,'current-seraphina-wipe'+(process.argv.includes('--candidate')?'-candidate':'')+(control?'-'+control:'')+'.json'),JSON.stringify({scope:'Full Seraphina source/current installed metadata/corrected transport/native 1000 LP and CL2 response. Field-seeded source, neutral equip setup with production Arms identity/metadata; Arms own effects and original Fusion procedure excluded. No Lua API shim; no live Omega certification.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(v=>v.failure))process.exitCode=1;
}
if(require.main===module)main().catch(e=>{console.error(e);process.exitCode=1});
