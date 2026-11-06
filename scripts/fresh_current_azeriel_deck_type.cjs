'use strict';
const fs=require('node:fs'),path=require('node:path'),Module=require('node:module'),assert=require('node:assert/strict');const file=path.join(__dirname,'fresh_current_azeriel_deck_send.cjs');let outer=fs.readFileSync(file,'utf8');const injection=String.raw`
rep("['accept','decline','missing','negated']","['monster','spell','mixedTypes']");
rep('const reader=name=>{',"cards.set(258590942,candidateCard(258590942));const reader=name=>{");
rep("if(scenario!=='missing')add(900006600,L.DECK);","if(scenario!=='spell')add(900006600,L.DECK);if(scenario!=='monster')add(258590942,L.DECK);");
rep('const index=p.selects.findIndex(c=>c.code===900006600);assert(index>=0);',"const wrong=p.selects.findIndex(c=>c.code===258590942),index=wrong>=0?wrong:p.selects.findIndex(c=>c.code===900006600);assert(index>=0);");
rep("assert.equal(offered,scenario!=='missing','Native Xyz trigger offer');", "assert(!core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.GRAVE}).some(c=>c?.code===258590942),'Actual Arckcestial Spell must not be sent');assert.equal(offered,scenario!=='spell','Native monster-only trigger availability');");
rep("scenario==='accept','Actual Deck send'", "scenario!=='spell','Actual Deck send'");
rep("['decline','negated'].includes(scenario),'Resource stays Deck'", "false,'Monster resource spent'");
rep("if(scenario==='accept')assert(trace.some", "if(scenario!=='spell')assert(trace.some");
rep('azeriel-before-visibility-repair','deck-monster-type-before-repair');
rep('return lua;};',"if(name==='c'+boss+'.lua'&&process.argv.includes('--typed-candidate'))lua=require('./fresh_azeriel_monster_filter_repair.cjs').corrected(lua);return lua;};");
rep("const suffix=process.argv.includes('--no-send')?", "const suffix=process.argv.includes('--typed-candidate')?'-typed-candidate':process.argv.includes('--no-send')?");
rep("'current-azeriel-deck-send'","'current-azeriel-deck-type'");
s=s.replace(/scope:'[^']*'/,"scope:'Full Azeriel/actual Meadow Spell script/installed metadata/corrected transport/no Lua API adapter. Reused actual paid source Xyz preparation; monster-only Deck send versus actual Arckcestial Meadow Spell-only and mixed pool. Native offered trigger/selection/Deck-to-GY outcomes. Neutral monster/material/paid recipe setup, no original general recipe/full-card/live Omega.'");
`;const slot=outer.lastIndexOf('\n`;');assert(slot>0);outer=outer.slice(0,slot)+'\n'+injection+outer.slice(slot);const m=new Module(file,module);m.filename=file;m.paths=module.paths;m._compile(outer,file);
