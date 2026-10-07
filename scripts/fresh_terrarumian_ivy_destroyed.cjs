'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),ivy=284639722,spell=900000521,own=900000522,opp=900000523,filler=900000524;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),r=db.prepare('select * from datas where id=?').get(ivy);db.close();
 const base={alias:0,setcodes:[],type:33,level:4,attribute:2,race:0x400n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const tests=[{own:true,opp:false,choice:'own'},{own:false,opp:true,choice:'opp'},{own:true,opp:true,choice:'own'},{own:true,opp:true,choice:'opp'},{own:false,opp:false,choice:null}],results=[];
 for(const test of tests){
  const trace=[],logs=[],cards=new Map([[ivy,{...base,code:ivy,setcodes:[0xA122],type:Number(r.type),level:Number(r.level)&255,lscale:(Number(r.level)>>>24)&255,rscale:(Number(r.level)>>>16)&255,attribute:Number(r.attribute),race:BigInt(r.race),attack:Number(r.atk),defense:Number(r.def)}],[spell,{...base,code:spell,type:2,level:0,attribute:0,race:0n,attack:0,defense:0}],[own,{...base,code:own,setcodes:[0xA122]}],[opp,{...base,code:opp}],[filler,{...base,code:filler}]]);
  const spellScript=`local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) if ${test.opp} then local g=Duel.GetMatchingGroup(Card.IsCode,tp,0,LOCATION_GRAVE,nil,${opp}) local tc=g:GetFirst() if tc then Duel.SpecialSummon(tc,0,tp,1-tp,false,false,POS_FACEUP) end end local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,${ivy}) Duel.Destroy(g,REASON_EFFECT) end) c:RegisterEffect(e) end`;
  const boosted='local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_SINGLE) e:SetCode(EFFECT_UPDATE_ATTACK) e:SetValue(500) c:RegisterEffect(e) end';
  const reader=name=>{if(name===`c${spell}.lua`)return spellScript;if([`c${own}.lua`,`c${opp}.lua`].includes(name))return boosted;if(name===`c${filler}.lua`)return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);return fs.readFileSync(file,'utf8')};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>{if(!cards.has(code))throw Error('Missing card '+code);return cards.get(code)},scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,triggered=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])if(!core.loadScript(duel,name,reader(name)))throw Error('Support '+name);
   const add=(code,location,player=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position:P.FACEUP_ATTACK});
   add(ivy,L.MZONE);add(spell,L.HAND);if(test.own)add(own,L.GRAVE);if(test.opp)add(opp,L.GRAVE,1);for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<120&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);
    if(logs.some(l=>l.type===0))throw Error(logs.filter(l=>l.type===0).map(l=>l.message).join('; '));
    if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;
    const p=messages.at(-1);if(!p)throw Error('Missing prompt');
    if(p.type===M.SELECT_IDLECMD){if(!activated){const index=p.activates.findIndex(c=>c.code===spell);if(index<0)throw Error('Destroy Spell unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}else{const ownM=core.duelQueryLocation(duel,{flags:Q.CODE|Q.ATTACK,controller:0,location:L.MZONE}).find(c=>c?.code===own),oppM=core.duelQueryLocation(duel,{flags:Q.CODE|Q.ATTACK,controller:1,location:L.MZONE}).find(c=>c?.code===opp);if(triggered!==Boolean(test.choice)||ownM?.attack!==(test.choice==='own'?1000:undefined)||oppM?.attack!==(test.opp?(test.choice==='opp'?1000:1500):undefined)||trace.some(m=>m.type===M.BECOME_TARGET)!==Boolean(test.choice))throw Error(`Negation outcome mismatch own=${ownM?.attack} opp=${oppM?.attack} triggered=${triggered}`);done=true;}}
    else if(p.type===M.SELECT_EFFECTYN){if(!test.choice)throw Error('Effect offered with no target');triggered=true;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});}
    else if(p.type===M.SELECT_OPTION)core.duelSetResponse(duel,{type:R.SELECT_OPTION,index:test.choice==='own'?0:1});
    else if(p.type===M.SELECT_CARD){const code=test.choice==='own'?own:opp,index=p.selects.findIndex(c=>c.code===code);if(index<0)throw Error('Chosen target unavailable');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_PLACE){let seq,location,player;for(const candidate of [0,1]){const shift=candidate*16;seq=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<(shift+i)))===0);location=L.MZONE;if(seq===undefined){location=L.SZONE;seq=[0,4,1,2,3,5].find(i=>(p.field_mask&(1<<(shift+8+i)))===0);}if(seq!==undefined){player=candidate;break;}}if(seq===undefined)throw Error('No open zone mask='+p.field_mask);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player,location,sequence:seq}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:null});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(error){failure=error.message}finally{core.destroyDuel(duel)}
  results.push({test,status:failure?'FAIL':'PASS',failure,triggered,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/terrarumian-ivy-destroyed.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');
 if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(error=>{console.error(error);process.exitCode=1});
