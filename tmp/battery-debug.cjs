'use strict';
const fs=require('node:fs'),path=require('node:path'),assert=require('node:assert/strict'),crypto=require('node:crypto'),{pathToFileURL}=require('node:url'),{candidateCard}=require('./fresh_installed_card.cjs');
const ROOT=path.resolve(__dirname,'..'),boss=233759343,lab=900001210,filler=900001211,helper=900001212,helper2=process.argv.includes('--official')?Number(process.argv.find(a=>a.startsWith('--recipient='))?.split('=')[1]||15989522):900001213,helper3=900001214;
async function main(){
 const mod=await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport();
 const {OcgMessageType:M,OcgResponseType:R,OcgLocation:L,OcgPosition:P,OcgProcessResult:S,SelectIdleCMDAction:A,OcgQueryFlags:Q}=mod;
 const core=await mod.default({sync:true,print(){},printErr(){}}),results=[];
 const control=['no-zero','no-gain'].find(c=>process.argv.includes('--'+c));
 for(const test of [{},{decline:true},{noAlly:true},{wrongSet:true},{facedown:true},{zeroAtk:true}]){
 const logs=[],trace=[],base={alias:0,setcodes:[],type:17,level:2,attribute:1,race:1n,attack:100,defense:100,lscale:0,rscale:0,link_marker:0};
 const search2=900001215;
 const cards=new Map([[boss,candidateCard(boss)],[search2,{...base,code:search2,attack:test.zeroAtk?0:1800}],[lab,{...base,code:lab,type:test.wrongType?2:17,setcodes:test.wrongSet?[]:[0xc1c]}],[helper2,{...base,code:helper2}],[helper3,{...base,code:helper3,type:0x20004,setcodes:[0x6167]}],[filler,{...base,code:filler,type:2}]]);
 const reader=name=>{if(name==='c0.lua')return '';if(name==='c'+helper2+'.lua')return 'local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_IGNITION) e:SetRange(LOCATION_MZONE) e:SetCountLimit(1) e:SetOperation(function(e,tp) local tc=Duel.GetFirstMatchingCard(Card.IsCode,tp,LOCATION_HAND,0,nil,'+boss+') assert(Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP)>0) end) c:RegisterEffect(e) end';if([lab,search2,helper3,filler].some(code=>name==='c'+code+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';const file=[path.join(ROOT,'public/CCG Downloads/CCG_Scripts',name),path.join(ROOT,'tmp/omega_scripts',name)].find(f=>fs.existsSync(f));assert(file,name);let lua=fs.readFileSync(file,'utf8');if(name==='c'+boss+'.lua'){if(control==='no-zero')lua=lua.replace('e1:SetValue(0)','e1:SetValue(123)');if(control==='no-gain')lua=lua.replace('e2:SetValue(atk)','e2:SetValue(0)');}return lua;};

 const duel=core.createDuel({flags:mod.OcgDuelMode.MODE_MR5|mod.OcgDuelMode.PSEUDO_SHUFFLE,seed:[1n,2n,3n,4n],team1:{startingLP:test.lowLP?999:test.exactLP?1000:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:code=>cards.get(code),scriptReader:reader,errorHandler:(type,message)=>logs.push({type,message})});
 let failure=null,activated=false,done=false,second=false,third=false,turn=0,attached=false,offered=0;
 try{
 for(const name of ['constant.lua','utility.lua','procedure.lua'])core.loadScript(duel,name,reader(name));
 const add=(code,location,player=0,position=P.FACEDOWN_DEFENSE,sequence=0)=>core.duelNewCard(duel,{team:player,duelist:0,code,controller:player,location,sequence,position});
  add(boss,L.GRAVE);add(search2,L.MZONE,1,test.facedown?P.FACEDOWN_DEFENSE:P.FACEUP_ATTACK);if(!test.noAlly)add(lab,L.MZONE,0,P.FACEUP_ATTACK);for(const player of [0,1])for(let i=0;i<8;i++)add(filler,L.DECK,player);core.startDuel(duel);
 const query=(location,controller=0)=>core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON|Q.ATTACK|Q.POSITION,controller,location}).filter(Boolean);
 for(let step=0;step<260&&!done;step++){
 const state=core.duelProcess(duel),messages=core.duelGetMessage(duel);trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;if(logs.some(x=>x.type===0))throw Error(logs.map(x=>x.message).join('; '));assert(state!==S.END);if(state!==S.WAITING)continue;const p=messages.at(-1);
 if(p.type===M.SELECT_IDLECMD){
 const eligible=!test.facedown;if(!activated){const index=p.activates.findIndex(c=>c.code===boss);assert.equal(index>=0,eligible,'Faceup opposing target required');if(!eligible){done=true;continue;}activated=true;core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 assert.equal(query(L.MZONE,1).find(c=>c.code===search2).attack,0,'Opponent actual ATK becomes zero');const gain=!(test.decline||test.noAlly||test.wrongSet||test.zeroAtk);if(!test.noAlly)assert.equal(query(L.MZONE).find(c=>c.code===lab).attack,100+(gain?1800:0),'Actual optional lost ATK transfer');assert(query(L.REMOVED).some(c=>c.code===boss),'Actual source banished as cost');done=true;
assert(p.selects.every(c=>c.code===search2&&c.controller===1||c.code===lab&&c.controller===0),'Actual opposing target or own gain recipient');core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}
 assert.equal(query(L.MZONE,1).find(c=>c.code===search2).attack,0,'Opponent actual ATK becomes zero');const gain=!(test.decline||test.noAlly||test.wrongSet||test.zeroAtk);if(!test.noAlly)assert.equal(query(L.MZONE).find(c=>c.code===lab).attack,100+(gain?1800:0),'Actual optional lost ATK transfer');assert(query(L.REMOVED).some(c=>c.code===boss),'Actual source banished as cost');done=true;

