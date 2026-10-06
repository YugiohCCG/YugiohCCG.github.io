'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=238273769,target=900000841,filler=900000842,partner=900000843;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),row=db.prepare('select * from datas where id=?').get(boss);db.close();
 const base={alias:0,setcodes:[],type:33,level:3,attribute:8,race:32n,attack:300,defense:200,lscale:0,rscale:0,link_marker:0},results=[];
 for(const test of [{member:true},{member:false},{member:true,noPartner:true},{member:true,badPartner:true},{member:true,full:true}]){
  const legal=test.member&&!test.noPartner&&!test.badPartner&&!test.full,logs=[],trace=[],cards=new Map([[boss,{...base,code:boss,setcodes:[0x1066],type:Number(row.type),level:Number(row.level)&255,attribute:Number(row.attribute),race:BigInt(row.race),attack:Number(row.atk),defense:Number(row.def)}],[target,{...base,code:target,setcodes:test.member?[0x1066]:[]}],[filler,{...base,code:filler}],[partner,{...base,code:partner,type:0x1000021,setcodes:test.badPartner?[]:[0x1066]}]]);
  const reader=name=>{if(name===`c${target}.lua`)return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetOperation(function(e,tp) Duel.Damage(tp,100,REASON_EFFECT) end) c:RegisterEffect(e) end';if(name===`c${partner}.lua`)return 'local s,id=GetID() function s.initial_effect(c) aux.EnablePendulumAttribute(c) end';if([filler].some(c=>name===`c${c}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');if(name===`c${boss}.lua`){if(process.argv.includes('--old-type'))source=source.replace('e2:SetType(EFFECT_TYPE_QUICK_O)','e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)');if(process.argv.includes('--old-filter'))source=source.replace('return c:IsSetCard(SET_SYMPHONIC)\n  and c:IsCanBeSpecialSummoned','return c:IsSetCard(SET_SYMPHONIC) and c:IsType(TYPE_MONSTER)\n  and c:IsCanBeSpecialSummoned');}return source};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,placed=false,partnerPlaced=false,activated=false,responded=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence:0,position});add(boss,L.HAND);add(target,L.MZONE);if(!test.noPartner)add(partner,L.HAND);if(test.full)for(let i=1;i<5;i++)core.duelNewCard(duel,{team:0,duelist:0,code:filler,controller:0,location:L.MZONE,sequence:i,position:P.FACEUP_ATTACK});for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<90&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     if(!placed||(!test.noPartner&&!partnerPlaced)){const code=!placed?boss:partner,index=p.activates.findIndex(c=>c.code===code&&c.location===L.HAND);if(index<0)throw Error('Pendulum activation missing');if(!placed)placed=true;else partnerPlaced=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(!activated){const index=p.activates.findIndex(c=>c.code===target);if(index<0)throw Error('Monster fixture ignition missing');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
     if(responded!==legal)throw Error('Response eligibility mismatch');
     const h=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.HAND}),m=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.MZONE}),z=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.SZONE});
     if(legal){if(!h.some(c=>c?.code===boss)||!m.some(c=>c?.code===partner)||z.some(c=>c?.code===boss||c?.code===partner))throw Error('Return/Summon result mismatch');}
     else if(!z.some(c=>c?.code===boss))throw Error('Ineligible response moved DDJ');done=true;
    }
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===partner);if(index<0)throw Error('Flip candidate missing');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===boss&&String(c.description)===String(132273769*16+1));if(index>=0){if(!legal||!activated)throw Error('Illegal Pendulum response offered');responded=true;}core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index<0?null:index});}
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(e){failure=e.message}finally{core.destroyDuel(duel)}
  results.push({...test,failure,activated,responded,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 const control=process.argv.includes('--old-type')?'old-type':process.argv.includes('--old-filter')?'old-filter':null;
 fs.writeFileSync(path.join(ROOT,`output/fresh-ccg-september/symphonic-ddj-response${control?'-'+control:''}.json`),JSON.stringify({engine:'public OCGCore with Omega Lua; neutral companion effect and Pendulum; not native Omega',control,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
