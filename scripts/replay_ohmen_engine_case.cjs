'use strict';
const fs=require('node:fs'),path=require('node:path'),Module=require('node:module');
const file=path.join(__dirname,process.argv[2]);if(!/^fresh_[a-z_]+\.cjs$/.test(process.argv[2]))throw Error('Invalid fixture name');
let code=fs.readFileSync(file,'utf8').replaceAll("require('./fresh_candidate_card.cjs')","require('./ohmen_test_metadata.cjs')").replaceAll("require('./fresh_current_card.cjs')","require('./ohmen_test_metadata.cjs')");
// Explicit fixture updates for the final printed rules; original fixtures stay immutable.
if(process.argv[2]==='fresh_conductor_movement.cjs')code=code.replace('link_marker:test.nonCoLinked?4:5','link_marker:test.nonCoLinked?4:7');
if(process.argv[2]==='fresh_beacon_movement_counters.cjs')code=code.replaceAll('!test.fullField&&!test.allFacedown','!test.fullField').replaceAll('test.fullField||test.allFacedown','test.fullField').replaceAll('test.noCoLink?0:1','test.noCoLink||test.allFacedown?0:1');
if(process.argv[2]==='fresh_carcel_dual_summon.cjs')code=code.replace('!test.wrongSet&&!test.oneSpace&&!test.sameName','!test.wrongSet&&!test.oneSpace').replace('test.wrongSet||test.oneSpace||test.sameName','test.wrongSet||test.oneSpace');
// Native counter selection is emitted when counters are split across cards/players.
code=code.replace("else if(p.type===M.SELECT_POSITION)","else if(p.type===M.SELECT_COUNTER){let remaining=p.count;const counters=p.cards.map(c=>{const n=Math.min(remaining,c.count);remaining-=n;return n;});assert.equal(remaining,0);core.duelSetResponse(duel,{type:R.SELECT_COUNTER,counters});}\n else if(p.type===M.SELECT_POSITION)");
code=code.replaceAll("path.join(ROOT,'tmp/omega_scripts',name)","path.join(process.env.OHMEN_REFERENCE_DIR||path.join(ROOT,'tmp/ohmen-reference'),name)");
const replay=new Module(file,module);replay.filename=file;replay.paths=Module._nodeModulePaths(__dirname);replay._compile(code,file);
