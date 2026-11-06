const fs=require('fs'),path=require('path'),assert=require('assert/strict');
const root=path.resolve(__dirname,'..');
process.chdir(root);
async function main(){
 const mod=await require(path.join(root,'scripts/fresh_corrected_card_data_transport.cjs')).loadCorrectedTransport();
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,SelectBattleCMDAction:B,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const mode=process.argv[2]||'candidate';
 for(const kind of ['stable','leave-return','grave-return','facedown','facedown-up']){
 const actor=900011001,recipient=900011002,filler=900011003,boss=259307285,logs=[];
 const base={alias:0,setcodes:[],type:33,level:4,attribute:1,race:1n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[actor,{...base,code:actor}],[recipient,{...base,code:recipient}],[filler,{...base,code:filler,type:2}],[boss,require(path.join(root,'scripts/fresh_installed_card.cjs')).candidateCard(boss)]]);
 const reader=n=>{
 if(n==='c0.lua')return '';
 if(n===`c${recipient}.lua`||n===`c${filler}.lua`)return 'local s,id=GetID() function s.initial_effect(c) end';
 if(n===`c${actor}.lua`)return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetOperation(function(e,tp) local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_MZONE,0,nil,${recipient}) c${boss}.retreg(e,tp,tc) ${(kind==='leave-return'||kind==='grave-return')?`assert(${kind==='grave-return'?'Duel.SendtoGrave(tc,REASON_EFFECT)':'Duel.SendtoHand(tc,nil,REASON_EFFECT)'}>0) Duel.BreakEffect() assert(Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP_ATTACK)>0)`:(kind==='facedown'||kind==='facedown-up')?`Duel.ChangePosition(tc,POS_FACEDOWN_DEFENSE) ${kind==='facedown-up'?'Duel.ChangePosition(tc,POS_FACEUP_ATTACK)':''}`:''} end) c:RegisterEffect(e) end`;
 const p=[path.join(root,'public/CCG Downloads/CCG_Scripts',n),path.join(root,'tmp/omega_scripts',n)].find(fs.existsSync);assert(p,n);let src=fs.readFileSync(p,'utf8');if(n===`c${boss}.lua`){const backup=path.join(root,'output/fresh-ccg-september/gravity-delayed-return-before-repair',n);if(fs.existsSync(backup))src=fs.readFileSync(backup,'utf8');if(mode==='once-only')src=src.replace('te:SetLabelObject(tc)','te:SetCountLimit(1) te:SetLabelObject(tc)');else if(mode!=='old'){src=require(path.join(root,'scripts/fresh_gravity_delayed_return_repair.cjs')).corrected(src);if(mode==='no-once')src=src.replace('te:SetCountLimit(1)','');if(mode==='no-tracking')src=src.replace(' and rc:GetFieldID()==te:GetLabel()\n\t\t\tand rc:GetFlagEffect(id)>0','');if(mode==='no-return')src=src.replace('Duel.SendtoHand(rc,nil,REASON_EFFECT)','do end');}}return src;};
 const d=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,turn=0,phase=0,activated=false,done=false;
 try{
 for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(d,n,reader(n));
 const add=(code,loc,p=0,seq=0)=>core.duelNewCard(d,{team:p,duelist:0,code,controller:p,location:loc,sequence:seq,position:P.FACEUP_ATTACK});
 add(boss,L.GRAVE);add(actor,L.MZONE);add(recipient,L.MZONE,0,1);for(const p of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,p);core.startDuel(d);
 const query=loc=>core.duelQueryLocation(d,{flags:Q.CODE|Q.POSITION,controller:0,location:loc}).filter(Boolean);
 for(let step=0;step<200&&!done;step++){
 const state=core.duelProcess(d),messages=core.duelGetMessage(d);for(const m of messages){if(m.type===M.NEW_TURN)turn++;if(m.type===M.NEW_PHASE)phase=m.phase;}
 assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){ 
 if(turn<3){core.duelSetResponse(d,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
 if(!activated){const index=p.activates.findIndex(x=>x.code===actor);assert(index>=0);activated=true;core.duelSetResponse(d,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 if(phase===256){const returned=query(L.HAND).some(x=>x.code===recipient);assert.equal(returned,kind==='stable','Only the still-tracked monster should return');done=true;continue;}
 core.duelSetResponse(d,{type:R.SELECT_IDLECMD,action:A.TO_BP});
 }else if(p.type===M.SELECT_BATTLECMD)core.duelSetResponse(d,{type:R.SELECT_BATTLECMD,action:B.TO_M2});
 else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(d,{type:R.SELECT_CHAIN,index:p.forced?0:null});
 else if(p.type===M.SELECT_PLACE)core.duelSetResponse(d,{type:R.SELECT_PLACE,places:[{player:0,location:L.MZONE,sequence:1}]});
 else if(p.type===M.SELECT_POSITION)core.duelSetResponse(d,{type:R.SELECT_POSITION,position:P.FACEUP_ATTACK});
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(d);}
 results.push({kind,failure,logs});
 }
 console.log(mode,results.map(x=>x.kind+': '+(x.failure||'PASS')).join(' | '));
 fs.writeFileSync(path.join(root,`output/fresh-ccg-september/current-gravity-delayed-return-${mode}.json`),JSON.stringify({mode,scope:'Original Attack on Gravity retreg helper invoked by neutral ignition actor; actual native phase progression, bounce/GY revival and position changes. Source negate/summon branches not tested. No Lua API mappings; not live Omega or full-card proof.',results},null,2));
}
main().catch(e=>{console.error(e);process.exitCode=1});
