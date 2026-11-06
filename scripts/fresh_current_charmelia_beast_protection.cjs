'use strict';
const fs=require('fs'),path=require('path'),assert=require('assert/strict');
const ROOT=path.resolve(__dirname,'..'),OUT=path.join(ROOT,'output/fresh-ccg-september');
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport(),{OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),mode=process.argv[2]||'current',boss=259226799,actor=900011051,victim=900011052,ritual=900011053,filler=900011054,other=900011055,results=[];
 for(const kind of ['no-ritual','friendly-target','protected-target','wrong-ritual','facedown-ritual','source-departure','reset']){
 const friendly=kind==='friendly-target',ritualPresent=!['no-ritual','reset'].includes(kind),protectedTarget=kind==='protected-target',player=friendly?0:1,logs=[],trace=[];
 const base={alias:0,setcodes:[],type:33,level:4,attribute:1,race:1n,attack:1000,defense:1000,lscale:0,rscale:0,link_marker:0};
 const cards=new Map([[boss,require('./fresh_installed_card.cjs').candidateCard(boss)],[actor,{...base,code:actor}],[victim,{...base,code:victim,setcodes:[0x12b1]}],[other,{...base,code:other,setcodes:[0x12b1]}],[ritual,{...base,code:ritual,type:161,setcodes:kind==='wrong-ritual'?[]:[0x12b1]}],[filler,{...base,code:filler}]]);
 const reader=n=>{
 if(n==='c0.lua')return '';
 if([victim,other,ritual,filler].some(c=>n===`c${c}.lua`))return 'local s,id=GetID() function s.initial_effect(c) end';
 if(n===`c${actor}.lua`)return `local s,id=GetID() function s.initial_effect(c) ${kind==='source-departure'?`local z=Effect.CreateEffect(c) z:SetDescription(100) z:SetType(EFFECT_TYPE_IGNITION) z:SetRange(LOCATION_MZONE) z:SetCountLimit(1) z:SetOperation(function(e,tp) local tc=Duel.GetFirstMatchingCard(Card.IsCode,0,LOCATION_SZONE,0,nil,${boss}) assert(Duel.SendtoGrave(tc,REASON_EFFECT)>0) end) c:RegisterEffect(z)`:''} local e=Effect.CreateEffect(c) e:SetDescription(101) e:SetLabel(0) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetProperty(EFFECT_FLAG_CARD_TARGET) e:SetCategory(CATEGORY_DESTROY) e:SetTarget(function(e,tp,eg,ep,ev,re,r,rp,chk,chkc) local code=e:GetLabel()==0 and ${victim} or ${other} if chkc then return chkc:IsCode(code) and chkc:IsLocation(LOCATION_MZONE) end if chk==0 then return Duel.IsExistingTarget(Card.IsCode,tp,LOCATION_MZONE,LOCATION_MZONE,1,nil,code) end Duel.SelectTarget(tp,Card.IsCode,tp,LOCATION_MZONE,LOCATION_MZONE,1,1,nil,code) end) e:SetOperation(function(e) local tc=Duel.GetFirstTarget() if tc and tc:IsRelateToEffect(e) then Duel.Destroy(tc,REASON_EFFECT) end e:SetLabel(e:GetLabel()+1) end) c:RegisterEffect(e) end`;
 const p=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',n),path.join(ROOT,'tmp/omega_scripts',n)].find(fs.existsSync);assert(p,n);let s=fs.readFileSync(p,'utf8');if(n===`c${boss}.lua`){if(mode==='no-target')s=s.replace('c:RegisterEffect(e2)','do end');if(mode==='no-destruction')s=s.replace('c:RegisterEffect(e3)','do end');if(mode==='unlimited')s=s.replace('e3:SetCountLimit(1)','do end');}return s;};
 const d=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:c=>cards.get(c),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});let failure=null,turn=0,uses=0,sourceLeft=false,done=false;
 try{
 for(const n of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(d,n,reader(n));
 const add=(code,location,p=0,seq=0,position=P.FACEUP_ATTACK)=>core.duelNewCard(d,{team:p,duelist:0,code,controller:p,location,sequence:seq,position});
 add(boss,L.SZONE);add(victim,L.MZONE);add(other,L.MZONE,0,3);add(actor,L.MZONE,player,friendly?2:0);if(kind==='reset')add(actor,L.MZONE,0,2);if(ritualPresent)add(ritual,L.MZONE,0,1,kind==='facedown-ritual'?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK);for(const p of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,p);core.startDuel(d);
 const query=loc=>core.duelQueryLocation(d,{flags:Q.CODE|Q.REASON,controller:0,location:loc}).filter(Boolean);
 for(let step=0;step<180&&!done;step++){
 const state=core.duelProcess(d),messages=core.duelGetMessage(d);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;
 assert(!logs.length,JSON.stringify(logs));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){if(p.player!==(kind==='reset'&&uses>=2?0:player)){core.duelSetResponse(d,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
 if(kind==='source-departure'&&!sourceLeft){const index=p.activates.findIndex(c=>c.code===actor&&String(c.description)==='100');assert(index>=0);sourceLeft=true;core.duelSetResponse(d,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 const index=p.activates.findIndex(c=>c.code===actor&&String(c.description)==='101');
 if(!uses){assert.equal(index>=0,!protectedTarget,'Only opponent targeting under a faceup matching Ritual is blocked');if(protectedTarget){done=true;continue;}}
 if(uses===1){assert.equal(query(L.MZONE).some(c=>c.code===victim),kind!=='source-departure','First destruction prevented only while source applies');if(kind==='source-departure'){assert(query(L.GRAVE).some(c=>c.code===boss));done=true;continue;}}
 if(uses===2){assert(query(L.GRAVE).some(c=>c.code===other),'Second distinct recipient in same turn is destroyed');if(kind!=='reset'){done=true;continue;}assert.equal(turn,3,'Natural next player turn');}if(uses===3){assert.equal(turn,3);assert(query(L.MZONE).some(c=>c.code===victim),'First destruction protection resets on next player turn');done=true;continue;}
 assert(index>=0);uses++;core.duelSetResponse(d,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});
 }else if(p.type===M.SELECT_CHAIN)core.duelSetResponse(d,{type:R.SELECT_CHAIN,index:p.forced?0:null});
 else if(p.type===M.SELECT_CARD){const index=p.selects.findIndex(c=>c.code===(uses===2?other:victim));assert(index>=0);core.duelSetResponse(d,{type:R.SELECT_CARD,indicies:[index]});}
 else throw Error('Unhandled '+JSON.stringify(p,(_,v)=>typeof v==='bigint'?String(v):v));
 }assert(done,'Step limit');
 }catch(e){failure=e.message;}finally{core.destroyDuel(d);}results.push({kind,failure,uses,logs,trace});console.log(kind,failure||'PASS');
 }
 fs.writeFileSync(path.join(OUT,`current-charmelia-beast-protection-${mode}.json`),JSON.stringify({mode,scope:'Original continuous Beast protections with seeded faceup source, neutral Charmelia recipients and typed Rituals (original recipient summon histories not certified). Native targeted destruction of distinct recipients sharing one source limit, opponent/friendly targeting, wrong-set/facedown Ritual and actual source departure. No Lua API mapping. Battle/simultaneous destruction and cross-copy limits and full-card/live open.',results},(_,v)=>typeof v==='bigint'?String(v):v,2));
}
main().catch(e=>{console.error(e);process.exitCode=1});
