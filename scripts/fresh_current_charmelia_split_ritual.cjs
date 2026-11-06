'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href);
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=Number(process.argv[2]||259241946),ritual=900000901,material=900000902,filler=900000903,macro=30241314;
 const db=new DatabaseSync(path.join(ROOT,'output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true}),row=db.prepare('select * from datas where id=?').get(boss);db.close();
 const extra=900000904, spellRoute=process.argv.includes('--spell');
 const base={alias:0,setcodes:[],type:33,level:2,attribute:8,race:0x1000000n,attack:300,defense:200,lscale:0,rscale:0,link_marker:0},results=[];
 for(const test of [{two:true},{two:true,replacement:true}]){
  const legal=!test.unrelated&&!test.wrongSum&&!test.occupied,logs=[],trace=[],cards=new Map([[boss,{...base,code:boss,setcodes:[0x12b1],type:Number(row.type),level:0}],[ritual,{...base,code:ritual,setcodes:[0x12b1],type:0xa1,level:spellRoute?6:4}],[material,{...base,code:material,setcodes:test.unrelated?[]:[0x12b1],level:test.wrongSum?1:2}],[filler,{...base,code:filler,level:0}],[extra,{...base,code:extra,setcodes:[0x12b1],type:spellRoute?0x20002:33}],[macro,{...base,code:macro,type:0x20004,level:0}]]);
  const reader=name=>{if(name===`c${ritual}.lua`)return 'local s,id=GetID() function s.initial_effect(c) c:EnableReviveLimit() end';if([material,extra].some(c=>name===`c${c}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';if(name===`c${filler}.lua`&&test.replacement)return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS) e:SetCode(EFFECT_SEND_REPLACE) e:SetRange(LOCATION_MZONE) e:SetTarget(function(e,tp,eg) return eg:IsExists(Card.IsCode,1,nil,900000904) end) e:SetValue(function(e,tc) return tc:IsCode(900000904) end) c:RegisterEffect(e) end';if([filler].some(c=>name===`c${c}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let source=fs.readFileSync(file,'utf8');if(name===`c${boss}.lua`&&process.argv.includes('--old-relation'))source=source.replace('rc:IsLocation(LOCATION_HAND) and Duel.SpecialSummon','rc:IsRelateToEffect(e) and Duel.SpecialSummon');if(name===`c${boss}.lua`&&process.argv.includes('--deck-api'))source=source.replace('if Duel.SendtoGrave(mat,REASON_EFFECT+REASON_RELEASE+REASON_MATERIAL+REASON_RITUAL)==0 then return end','Duel.ReleaseRitualMaterial(mat,true)');if(name===`c${boss}.lua`&&process.argv.includes('--old-deck-release'))source=source.replace('Duel.SendtoGrave(mat,REASON_EFFECT+REASON_RELEASE+REASON_MATERIAL+REASON_RITUAL)','Duel.Release(mat,REASON_EFFECT+REASON_MATERIAL+REASON_RITUAL)');if(name===`c${boss}.lua`&&process.argv.includes('--ordinary-send'))source=source.replace('REASON_EFFECT+REASON_RELEASE+REASON_MATERIAL+REASON_RITUAL','REASON_EFFECT+REASON_MATERIAL+REASON_RITUAL');if(name==='c'+boss+'.lua'&&!process.argv.includes('--fixed'))source=fs.readFileSync(path.join(ROOT,'output/fresh-ccg-september/charmelia-split-ritual-before-repair',name),'utf8');return source};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position:P.FACEUP_ATTACK});add(boss,L.HAND);add(ritual,L.HAND);add(material,test.deck?L.DECK:L.MZONE);add(extra,spellRoute?L.SZONE:L.DECK,0,1);if(test.replacement)add(filler,L.MZONE,1,4);if(test.occupied)add(filler,L.MZONE);if(test.macro)add(macro,L.SZONE,1,2);for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<120&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){const index=p.activates.findIndex(c=>c.code===boss&&c.location===L.HAND);if(legal&&!activated){if(index<0)throw Error('Ritual activation unavailable');activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}if(!legal&&index>=0)throw Error('Illegal Ritual activation offered');if(legal){
     const query=location=>core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location}).filter(Boolean);
     const summoned=query(L.MZONE).some(c=>c.code===ritual);
     if(summoned!==(!test.replacement||!process.argv.includes('--fixed')))throw Error('Ritual outcome mismatch');
     if(!query(L.GRAVE).some(c=>c.code===material))throw Error('Field material did not move');
     if(query(L.GRAVE).some(c=>c.code===extra)===Boolean(test.replacement))throw Error('Extra material movement mismatch');
    }done=true;}
    else if(p.type===M.SELECT_CARD){const wanted=p.selects.some(c=>c.code===ritual)?ritual:material,index=p.selects.findIndex(c=>c.code===wanted);if(index<0)throw Error('Candidate missing');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_UNSELECT_CARD){if(p.can_finish){core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index:null});}else{const index=p.select_cards.findIndex(c=>c.code===material||c.code===extra);if(index<0)throw Error('Material selection missing');core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index});}}
    else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:p.forced?0:null});
    else if(p.type===M.SELECT_PLACE){let location=L.MZONE,sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<i))===0);if(sequence===undefined){location=L.SZONE;sequence=[0,1,2,3,4].find(i=>(p.field_mask&(1<<(8+i)))===0);}core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location,sequence}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(e){failure=e.message}finally{core.destroyDuel(duel)}
  results.push({...test,failure,activated,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 fs.writeFileSync(path.join(ROOT,`output/fresh-ccg-september/current-charmelia-split-ritual-${spellRoute?'spell':'deck'}-${process.argv.includes('--fixed')?'fixed':'prior'}-${boss}${!process.argv.includes('--fixed')?'-before':''}${process.argv.includes('--old-relation')?'-old-relation':process.argv.includes('--deck-api')?'-deck-api':process.argv.includes('--old-deck-release')?'-old-deck-release':process.argv.includes('--ordinary-send')?'-ordinary-send':''}.json`),JSON.stringify({engine:'public OCGCore with existing Sacred Feather; neutral Ritual plus actual EVENT_RELEASE fixture on materials; not native Omega',adapter:process.argv.includes('--deck-api')?'In-memory Deck branch uses ReleaseRitualMaterial(mat,true) instead of Release; not production or native Omega proof':null,results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});
