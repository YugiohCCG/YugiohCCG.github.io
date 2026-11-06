'use strict';
const fs=require('node:fs'),path=require('node:path'),{pathToFileURL}=require('node:url'),{DatabaseSync}=require('node:sqlite');
const ROOT=path.resolve(__dirname,'..'),CUSTOM=path.join(ROOT,'public/CCG Downloads/CCG_Scripts'),OMEGA=path.join(ROOT,'tmp/omega_scripts');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport();
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),boss=238273769,target=900000811,filler=900000812,synchro=900000813,msg=132273769;
 const row=require('./fresh_installed_card.cjs').candidateCard(boss);
 const base={alias:0,setcodes:[],type:33,level:3,attribute:8,race:32n,attack:300,defense:200,lscale:0,rscale:0,link_marker:0},results=[];
 for(const test of [{member:true},{member:false},{member:true,full:true},{member:true,normal:true},{member:true,searchSelf:true},{member:true,noSearch:true},{member:true,synchro:true},{member:true,synchro:true,decline:true}].filter(t=>!!t.synchro===(process.argv.includes('--synchro-probe')||process.argv.includes('--native-synchro')))){
  const legal=test.normal||(test.member&&!test.full),logs=[],trace=[],cards=new Map([[boss,{...base,code:boss,setcodes:[0x1066],...row}],[target,{...base,code:target,setcodes:test.member?[0x1066]:[]}],[filler,{...base,code:filler}]]);
  cards.set(synchro,{...base,code:synchro,type:0x2001,level:7});
  const reader=name=>{if(name===`c${synchro}.lua`){if(process.argv.includes('--native-synchro'))return require('./fresh_native_two_material_synchro.cjs').recipe(boss,target);return 'local s,id=GetID() function s.initial_effect(c) aux.AddSynchroProcedure(c,nil,aux.NonTuner(nil),1,99) c:EnableReviveLimit() end';}if([target,filler].some(c=>name===`c${c}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';if(name==='c0.lua')return '';const file=[path.join(CUSTOM,name),path.join(OMEGA,name)].find(f=>fs.existsSync(f));if(!file)throw Error('Missing '+name);let lua=fs.readFileSync(file,'utf8');if(name===`c${boss}.lua`){if(process.argv.includes('--no-immediate'))lua=lua.replace('if sc then Duel.SynchroSummon(tp,sc,c,mg) end','do end');if(process.argv.includes('--no-search'))lua=lua.replace('Duel.SendtoHand(g,nil,REASON_EFFECT)','do end');if(process.argv.includes('--no-hand-summon'))lua=lua.replace('Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)==0','true');}return lua};
  const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
  let failure=null,activated=false,searched=false,done=false;
  try{
   for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
   const add=(code,location,player=0,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position:P.FACEUP_ATTACK});
   add(boss,L.HAND);add(boss,L.HAND);if(test.synchro)add(synchro,L.EXTRA);add(target,L.MZONE);if(test.full)for(let i=1;i<5;i++)add(filler,L.MZONE,0,i);if(!test.noSearch)add(test.searchSelf?boss:target,L.DECK);
   for(const player of [0,1])for(let i=0;i<5;i++)add(filler,L.DECK,player);
   core.startDuel(duel);
   for(let step=0;step<120&&!done;step++){
    const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));if(state===S.END)throw Error('Duel ended');if(state!==S.WAITING)continue;const p=messages.at(-1);
    if(p.type===M.SELECT_IDLECMD){
     const index=p.activates.findIndex(c=>c.code===boss&&String(c.description)===String(msg*16+3));
     if(legal&&!activated){activated=true;if(test.normal){const n=p.summons.findIndex(c=>c.code===boss);if(n<0)throw Error('Normal Summon unavailable');core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_SUMMON,index:n});}else{if(index<0)throw Error('Quick Summon unavailable');core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});}continue;}
     if(!test.normal&&index>=0)throw Error(legal?'Second copy bypasses shared Quick count':'Illegal hand activation offered');
     if(legal){const m=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.MZONE}),h=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.HAND});const used=test.synchro&&!test.decline;if(m.filter(c=>c?.code===boss).length!==(used?0:1)||m.some(c=>c?.code===synchro)!==!!used)throw Error('DDJ/Synchro Summon mismatch');if(used){const ex=core.duelQueryLocation(duel,{flags:Q.CODE|Q.POSITION,controller:0,location:L.EXTRA});if(!ex.some(c=>c?.code===boss&&c.position===P.FACEUP_DEFENSE))throw Error('DDJ material did not redirect face-up Extra');}const expectSearch=!test.noSearch&&!used;if(searched!==expectSearch)throw Error('Search availability mismatch');if(expectSearch&&!h.some(c=>c?.code===(test.searchSelf?boss:target)))throw Error('Search result missing');if(test.searchSelf&&h.filter(c=>c?.code===boss).length!==2)throw Error('Self-name search failed');}done=true;
    }
    else if(p.type===M.SELECT_CHAIN){const index=p.selects.findIndex(c=>c.code===boss&&String(c.description)===String(msg*16+4));if(index>=0){if(test.noSearch)throw Error('Search without candidate');searched=true;}core.duelSetResponse(duel,{type:R.SELECT_CHAIN,index:index<0?null:index});}
    else if(p.type===M.SELECT_UNSELECT_CARD){core.duelSetResponse(duel,{type:R.SELECT_UNSELECT_CARD,index:p.can_finish?null:0});}
    else if(p.type===M.SELECT_YESNO)core.duelSetResponse(duel,{type:R.SELECT_YESNO,yes:!test.decline});
    else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===(p.selects.some(c=>c.code===synchro)?synchro:test.searchSelf?boss:target));if(index<0)throw Error('Selection candidate missing');core.duelSetResponse(duel,{type:R.SELECT_CARD,indicies:[index]});}
    else if(p.type===M.SELECT_EFFECTYN){searched=true;core.duelSetResponse(duel,{type:R.SELECT_EFFECTYN,yes:true});}
    else if(p.type===M.SELECT_PLACE){const sequence=[0,1,2,3,4,5,6].find(i=>(p.field_mask&(1<<i))===0);core.duelSetResponse(duel,{type:R.SELECT_PLACE,places:[{player:0,location:L.MZONE,sequence}]});}
    else if(p.type===M.SELECT_POSITION)core.duelSetResponse(duel,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
    else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
   }
   if(!done)throw Error('Step limit');
  }catch(e){failure=e.message}finally{core.destroyDuel(duel)}
  results.push({...test,failure,activated,searched,trace,logs});console.log(`${failure?'FAIL':'PASS'} ${JSON.stringify(test)}${failure?': '+failure:''}`);
 }
 const suffix=process.argv.includes('--no-immediate')?'native-synchro-no-immediate':['native-synchro','synchro-probe','no-search','no-hand-summon'].find(f=>process.argv.includes('--'+f));
 fs.writeFileSync(path.join(ROOT,'output/fresh-ccg-september/current-symphonic-ddj-hand-monster'+(suffix?'-'+suffix:'')+'.json'),JSON.stringify({engine:'public OCGCore with Omega Lua; not native Omega',qualifiers:['Complete DDJ production script loaded; neutral companion monsters have no effects','Current installed metadata/corrected transport/no Lua API adapter. --native-synchro uses a neutral two-material native summon procedure with explicit Tuner/non-Tuner/level/mandatory-material checks; not the Omega helper or a general recipe certification. --synchro-probe retains missing public-engine Duel.CheckSynchroMaterial. Live Omega not verified'],results},(_,v)=>typeof v==='bigint'?String(v):v,2)+'\n');if(results.some(r=>r.failure))process.exitCode=1;
}
main().catch(e=>{console.error(e);process.exitCode=1});

