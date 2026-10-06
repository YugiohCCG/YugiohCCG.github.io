'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_candidate_card.cjs');
const ROOT=path.resolve(__dirname,'..');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=210506870,lab=900001191,filler=900001192,spellCost=900001193,recipient=900001194,results=[];
 const control=process.argv.includes('--no-equip-gate')?'no-equip-gate':process.argv.includes('--wrong-value')?'wrong-value':null;
 for(const test of [{count:0},{count:1},{count:2},{count:1,wrongSet:true},{count:0,unequipped:true},{count:1,opponent:true}]){
  const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
  const cards=new Map([[boss,candidateCard(boss)],[lab,{...base,code:lab,type:0x40002,setcodes:test.wrongSet?[]:[0xb47]}],[filler,{...base,code:filler}],[recipient,{...base,code:recipient,type:2}]]);
  const reader=name=>{
   if(name==='c'+recipient+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local tc=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_MZONE,0,nil,'+boss+'):GetFirst() local g=Duel.GetMatchingGroup(Card.IsCode,tp,LOCATION_HAND,0,nil,'+lab+') for c in aux.Next(g) do local lim=Effect.CreateEffect(c) lim:SetType(EFFECT_TYPE_SINGLE) lim:SetCode(EFFECT_EQUIP_LIMIT) lim:SetValue(1) c:RegisterEffect(lim) Duel.Equip('+(test.opponent?1:0)+',c,tc) end end) c:RegisterEffect(e) end';
   if([lab,filler,spellCost,recipient].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';
   const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){
    if(control==='no-equip-gate')lua=lua.replace('c:GetEquipTarget()~=nil','true');if(control==='wrong-value')lua=lua.replace('LOCATION_SZONE,0,nil)*200','LOCATION_SZONE,0,nil)*100');
   }return lua;
  };
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false,turn=0,secondary=false,placementStarted=false,placementFinished=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
   add(boss,L.MZONE,0,P.FACEUP_ATTACK);add(recipient,L.HAND);for(let i=0;i<test.count;i++)add(lab,L.HAND);if(test.unequipped)add(lab,L.SZONE,0,P.FACEUP_ATTACK,2);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
   const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.ATTACK|Q.EQUIP_CARD,controller:0,location}).filter(Boolean);
   for(let step=0;step<260&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){if(!activated){assert.equal(query(L.MZONE).find(c=>c.code===boss).attack,1400,'Initial printed ATK');const index=p.activates.findIndex(c=>c.code===recipient);assert(index>=0,'Actual equip helper activation');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}const equips=core.duelQueryLocation(duel,{flags:Q.CODE|Q.EQUIP_CARD,controller:test.opponent?1:0,location:L.SZONE}).filter(Boolean).filter(c=>c.code===lab);assert.equal(equips.length,test.count+(test.unequipped?1:0),'Actual Equip card placement');assert.equal(equips.filter(c=>c.equipCard&&c.equipCard.location===L.MZONE&&c.equipCard.controller===0).length,test.count,'Native Equip relations to own Monster');if(test.count)assert.equal(query(L.HAND).filter(c=>c.code===lab).length,0,'Equip cards actually left Hand');const expected=1400+(!test.wrongSet&&!test.opponent?test.count*200:0);assert.equal(query(L.MZONE).find(c=>c.code===boss).attack,expected,'Printed 200 per own qualifying equipped Spell');done=true;}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else if(p.type===M.SELECT_PLACE){const ownSide=(p.field_mask&0x1f00)!==0x1f00;const player=ownSide?p.player:1-p.player;const shift=ownSide?8:24;const sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(shift+i)))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player,location:L.SZONE,sequence}]});}
    else if(p.type===M.SELECT_CHAIN){const index=-1;core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index>=0?index:p.forced?0:null});}
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }assert(done,'Step limit');
  }catch(e){failure=e.message;}finally{core.destroyDuel(duel);}results.push({test,failure,trace,logs});console.log((failure?'FAIL':'PASS')+' '+JSON.stringify(test)+(failure?': '+failure:''));
 }
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/talismandrake-heat-attack'+(control?'-'+control:'')+'.json'),JSON.stringify({adapter:null,engine:'Public OCGCore, full production Talismandrake Heat/candidate metadata; neutral supporting cards. Field ATK with native Duel.Equip and neutral equip Spells; source seeded MZONE, no procedure certificate; native Omega unverified; no native Omega certification.',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(c=>c.failure))process.exitCode=1;
}main().catch(e=>{console.error(e);process.exitCode=1;});
