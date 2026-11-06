'use strict';
const fs=require('node:fs'),path=require('node:path'),Module=require('node:module'),assert=require('node:assert/strict');
const boss=process.argv.includes('--shield')?255832330:248788543,file=path.join(__dirname,'fresh_current_meadow_events.cjs');let s=fs.readFileSync(file,'utf8');
function rep(a,b){assert(s.includes(a),a);s=s.replace(a,b);}
rep('boss=258590942','boss='+boss);
rep("['normal','special','facedown','light','own','mixed']","['effectAccept','effectDecline','battleAccept','battleDecline']");
rep("own=scenario==='own',ep=own?0:1,eligible=['normal','special','mixed'].includes(scenario)","own=false,ep=1,eligible=scenario===(boss===255832330?'effectAccept':'battleAccept')");
rep('const reader=name=>{',"cards.set(revive,candidateCard(218142234));cards.set(monster,{...cards.get(monster),attack:10000});const reader=name=>{");
const start=s.indexOf("if(name===`c${spell}.lua`)"),end=s.indexOf('if([monster,revive,filler,mixed]',start);assert(start>0&&end>start);
s=s.slice(0,start)+"if(name==='c'+spell+'.lua')return `local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) local g=Duel.GetMatchingGroup(function(tc) return tc:IsCode(900006103,900006105) end,tp,0,LOCATION_MZONE,nil) assert(#g==2) if ${scenario.startsWith('effect')?'true':'false'} then Duel.Destroy(g,REASON_EFFECT) end end) c:RegisterEffect(e) end`;"+s.slice(end);
// Use the actual installed Fusion Pendulum recipient identity and complete script.
rep("if([monster,revive,filler,mixed].some", "if([monster,filler,mixed].some");
rep('add(boss,L.HAND);add(revive,L.GRAVE);', 'add(boss,L.GRAVE);add(revive,L.MZONE);core.duelNewCard(duel,{team:0,duelist:0,code:mixed,controller:0,location:L.MZONE,sequence:1,position:P.FACEUP_ATTACK});');
rep('add(monster,L.HAND,ep);','add(monster,L.MZONE,ep);');
rep('let failure=null,activated=false','let turn=0,attacked=false,offered=false;let failure=null,activated=false');
rep('trace.push(...ms);','trace.push(...ms);turn+=ms.filter(m=>m.type===M.NEW_TURN).length;');
rep("if(!eventDone){eventDone=true;const index=scenario==='normal'?p.summons.findIndex(c=>c.code===monster):p.activates.findIndex(c=>c.code===spell);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:scenario==='normal'?A.SELECT_SUMMON:A.SELECT_ACTIVATE,index});continue;}","if(!eventDone){eventDone=true;assert(core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.SZONE}).some(c=>c?.code===boss),'Actual original GY equip');const index=p.activates.findIndex(c=>c.code===spell);assert(index>=0);core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});continue;}");
const a=s.indexOf('const field=core.duelQueryLocation'),b=s.indexOf('done=true;',a);assert(a>0&&b>a);
const checks="const field=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.MZONE}).filter(Boolean),gy=core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,controller:0,location:L.GRAVE}).filter(Boolean);assert.equal(field.some(c=>c.code===revive),eligible,'Equipped recipient protection');assert.equal(field.some(c=>c.code===mixed),scenario.startsWith('battle'),'Unrelated own card destruction unchanged');assert.equal(offered,scenario.startsWith(boss===255832330?'effect':'battle'),'Correct replacement reason');if(eligible)assert(gy.some(c=>c.code===boss),'Replacement equip actually destroyed');if(scenario.startsWith('battle'))assert(trace.some(m=>m.type===M.ATTACK),'Actual native battle');";
s=s.slice(0,a)+"if(scenario.startsWith('battle')){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_BP,index:0});continue;}"+checks+s.slice(b);
rep('SelectIdleCMDAction:A,OcgQueryFlags:Q','SelectIdleCMDAction:A,SelectBattleCMDAction:B,OcgQueryFlags:Q');
rep('else if(p.type===M.SELECT_CARD){',"else if(p.type===M.SELECT_BATTLECMD){if(!attacked){const index=p.attacks.findIndex(c=>c.code===monster);assert(index>=0);attacked=true;core.duelSetResponse(duel,{type:R.SELECT_BATTLECMD,action:B.SELECT_BATTLE,index});continue;}"+checks+"done=true;}else if(p.type===M.SELECT_CARD){");
rep('yes:false',"yes:(p.type===M.SELECT_EFFECTYN&&p.code===boss?(offered=true,scenario.endsWith('Accept')):false)");
rep("'summon-visibility-before-repair'","'destroy-replacement-before-repair'");
rep('return lua;};',"if(name==='c'+boss+'.lua'&&process.argv.includes('--replacement-candidate')){const a='e4:SetTarget(s.reptg)';assert.equal(lua.split(a).length,2);lua=lua.replace(a,a+'\\n\\te4:SetValue(function(e,c) return c==e:GetHandler():GetEquipTarget() end)');}return lua;};");
rep("const suffix=process.argv.includes('--old-source')?","const suffix=process.argv.includes('--replacement-candidate')?'-replacement-candidate':process.argv.includes('--old-source')?");
rep("'current-meadow-events'","'current-blaze-'+boss+'-replacement'");
s=s.replace(/scope:'[^']*'/,"scope:'Full Blaze source/original GY equip/current installed metadata/corrected transport/no Lua API adapter. Initially field Seraphina recipient and neutral other monster; native opponent effect destruction or battle, accept/decline and reason boundaries. No original Fusion history/full-card/live Omega certification.'");
s=s.replaceAll('900006103','218142234');
if(process.argv.includes('--no-replacement')){s=s.replace("process.argv.includes('--old-source')","(process.argv.includes('--old-source')||process.argv.includes('--no-replacement'))");s=s.replace("const suffix=","const suffix=process.argv.includes('--no-replacement')?'-no-replacement':");}
const m=new Module(file,module);m.filename=file;m.paths=module.paths;m._compile(s,file);
