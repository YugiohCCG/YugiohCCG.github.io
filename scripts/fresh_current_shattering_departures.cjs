'use strict';
const fs=require('node:fs'),path=require('node:path'),Module=require('node:module'),assert=require('node:assert/strict');const file=path.join(__dirname,'fresh_current_silhouette_departures.cjs');let outer=fs.readFileSync(file,'utf8');const injection=String.raw`
rep('boss=256608976','boss=248453205');
rep('const reader=name=>{',"cards.set(900008101,{...base,code:900008101,type:17,level:4,setcodes:[0xbc5]});cards.set(900008102,{...base,code:900008102,type:17,level:4,setcodes:[0xbc5]});const reader=name=>{");
rep("if(name==='c0.lua')return '';", "if(name==='c0.lua')return '';if([900008101,900008102].some(c=>name==='c'+c+'.lua'))return 'local s,id=GetID() function s.initial_effect(c) end';");
rep('add(boss,L.HAND);', 'add(boss,L.HAND);add(900008102,L.HAND);core.duelNewCard(duel,{team:0,duelist:0,code:900008101,controller:0,location:L.DECK,sequence:0,position:P.FACEDOWN_DEFENSE});');
rep('const index=p.activates.findIndex(c=>c.code===spell);assert(index>=0);activated=true','const index=p.activates.findIndex(c=>c.code===boss);assert(index>=0);activated=true');
rep('LOCATION_MZONE,0,nil,256608976','LOCATION_MZONE,0,nil,900008101');
const shStart=s.indexOf("assert(trace.some(m=>m.type===M.MOVE&&m.card===monster"),shEnd=s.indexOf('eventDone=true;',shStart);assert(shStart>0&&shEnd>shStart);
s=s.slice(0,shStart)+"const gc=core.duelQueryLocation(duel,{flags:Q.CODE|Q.REASON,controller:0,location:L.GRAVE}).find(c=>c?.code===900008102);assert(gc&&(gc.reason&128),'Native actual Hand tribute cost');assert(core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.MZONE}).some(c=>c?.code===900008101),'Original actual recruit');assert(trace.some(m=>m.type===M.MOVE&&m.card===900008101&&m.from.location===L.DECK&&m.to.location===L.MZONE),'Native real Deck-to-field recruit');"+s.slice(shEnd);
rep('location:L.DECK}).find(c=>c?.code===boss)', 'location:L.DECK}).find(c=>c?.code===900008101)');
rep('let failure=null','let paid=false;let failure=null');
rep('const index=p.selects.findIndex(c=>c.code===revive);assert(index>=0);', 'const index=p.selects.findIndex(c=>c.code===(paid?900008101:900008102));assert(index>=0);paid=true;');
rep('yes:p.type===M.SELECT_EFFECTYN&&p.code===boss&&!eventDone','yes:false');
rep("'current-silhouette-departures'","'current-shattering-departures'");
s=s.replace(/scope:'[^']*'/,"scope:'Full original Shattering Sustained/installed metadata/corrected transport/no Lua API adapter. Actual neutral Stain Hand monster Tributed as cost, original level4 Stain Deck recruit/registerleave, then actual departure destinations and opposing Deck faceup outcome. Neutral materials/recipient/departure Spell; other effects/phase set/full-card/live Omega unverified.'");
`;const at=outer.lastIndexOf('const m=new Module(file,module);');assert(at>0);outer=outer.slice(0,at)+injection+outer.slice(at);const m=new Module(file,module);m.filename=file;m.paths=module.paths;m._compile(outer,file);
