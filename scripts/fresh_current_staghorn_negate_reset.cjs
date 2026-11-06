'use strict';
const fs=require('node:fs'),path=require('node:path'),Module=require('node:module'),assert=require('node:assert/strict');
const file=path.join(__dirname,'fresh_terrarumian_staghorn_chain.cjs'),control=['per-copy','no-reset','no-negate','unadapted'].find(x=>process.argv.includes('--'+x));let s=fs.readFileSync(file,'utf8');
function replace(a,b){assert(s.includes(a),a);s=s.replace(a,b);}
replace("await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href)","await require('./fresh_corrected_card_data_transport.cjs').loadCorrectedTransport()");
replace('return cards.get(code)',"return code<900000000?require('./fresh_installed_card.cjs').candidateCard(code):cards.get(code)");
replace('[{terrarumian:true,accept:true},{terrarumian:true,accept:false},{terrarumian:false,accept:true}]','[{terrarumian:true,accept:true},{terrarumian:true,accept:false}]');
replace('[trap,{...base,code:trap,type:4,','[trap,{...base,code:trap,type:0x20004,');
const trapLua='local s,id=GetID() function s.initial_effect(c) local e=Effect.CreateEffect(c) e:SetType(EFFECT_TYPE_ACTIVATE) e:SetCode(EVENT_FREE_CHAIN) e:SetOperation(function(e,tp) Duel.Damage(1-tp,1000,REASON_EFFECT) end) c:RegisterEffect(e) local q=e:Clone() q:SetType(EFFECT_TYPE_QUICK_O) q:SetCode(EVENT_CHAINING) q:SetRange(LOCATION_SZONE) c:RegisterEffect(q) end';
const oldTrap=s.match(/if\(name===`c\$\{trap\}\.lua`\)return '[^']*';/);assert(oldTrap);s=s.replace(oldTrap[0],'if(name===`c${trap}.lua`)return '+JSON.stringify(trapLua)+';');
const mapping="source=source.replace('CHAININFO_TRIGGERING_EFFECT','1').replace('CHAININFO_TRIGGERING_PLAYER','2');";
if(control==='unadapted')replace(mapping,'doNothing:;');
replace('}return source};',`if(${JSON.stringify(control)}==='per-copy')source=source.replace('Duel.GetFlagEffect(tp,id)','e:GetHandler():GetFlagEffect(id)').replace('Duel.RegisterFlagEffect(tp,id','c:RegisterFlagEffect(id');if(${JSON.stringify(control)}==='no-reset')source=source.replace('id,RESET_PHASE+PHASE_END,0,1','id,RESET_PHASE+PHASE_END,0,3');if(${JSON.stringify(control)}==='no-negate')source=source.replace('Duel.NegateEffect(ev)','false');}return source};`);
replace('let failure=null,placed=false','let stage=0,turn=0,placements=0,pending=false;const offers=[0,0,0];let failure=null,placed=false');
replace('add(fern,L.HAND);add(spell,L.HAND);','add(fern,L.HAND);add(fern,L.HAND);add(spell,L.HAND);add(spell,L.HAND);add(spell,L.HAND);');
replace('step<140','step<500');
replace('trace.push(...messages);','trace.push(...messages);for(const m of messages)if(m.type===M.NEW_TURN)turn++;');
const a=s.indexOf('    if(p.type===M.SELECT_IDLECMD){'),b=s.indexOf('    else if(p.type===M.SELECT_CHAIN)',a);assert(a>=0&&b>a);
s=s.slice(0,a)+`    if(p.type===M.SELECT_IDLECMD){
     const select=index=>{assert(index>=0,'Native source/Spell activation');core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.SELECT_ACTIVATE,index});};
     if(placements<2){placements++;select(p.activates.findIndex(c=>c.code===fern&&c.location===L.HAND));continue;}
     const zone=core.duelQueryLocation(duel,{flags:Q.CODE,controller:0,location:L.SZONE}).filter(c=>c?.code===fern).length,damage=trace.filter(m=>m.type===M.DAMAGE&&m.player===0).reduce((n,m)=>n+m.amount,0);
     if(pending){assert(chained,'Actual opponent response');pending=false;if(stage===1){assert.equal(turn,1);assert.equal(damage,test.accept?0:1000,'First accepted/declined resolving negate');assert.equal(zone,test.accept?1:2,'First source destruction');}if(stage===2){assert.equal(turn,1);assert.equal(damage,1000,'Same-turn shared negate or unconsumed decline');assert.equal(zone,1,'One actual source remains');assert(test.accept?offers[1]===0:offers[1]>0,'Second-copy named exclusion versus declined first use');}if(stage===3){assert.equal(turn,3);assert.equal(damage,1000,'Native negate resets next own turn');assert.equal(zone,0,'Second actual source destruction');assert(offers[2]>0);assert.equal(trace.filter(m=>m.type===M.CHAINING&&m.code===spell).length,3);done=true;continue;}}
     if(stage===2&&turn<3||p.player!==0){core.duelSetResponse(duel,{type:R.SELECT_IDLECMD,action:A.TO_EP});continue;}
     stage++;ready=true;chained=false;pending=true;select(p.activates.findIndex(c=>c.code===spell));
    }
`+s.slice(b);
replace("offered=true;if(!test.terrarumian)throw Error('Negation offered against non-Terrarumian');core.duelSetResponse(duel,{type:p.type===M.SELECT_EFFECTYN?R.SELECT_EFFECTYN:R.SELECT_YESNO,yes:test.accept});", "offered=true;offers[stage-1]++;core.duelSetResponse(duel,{type:p.type===M.SELECT_EFFECTYN?R.SELECT_EFFECTYN:R.SELECT_YESNO,yes:stage===1?test.accept:true});");
replace('failure,offered,chained,trace,logs','failure,offers,offered,chained,trace,logs');
replace("'output/fresh-ccg-september/terrarumian-staghorn-chain.json'","'output/fresh-ccg-september/current-staghorn-negate-reset'+"+JSON.stringify(control?'-'+control:'')+"+'.json'");
replace("engine:'public OCGCore with Omega Lua; not native Omega'","engine:'Public OCGCore/current installed metadata/corrected transport; explicit chain-info index mapping 1/2 unless unadapted. Not live Omega',scope:'Full Staghorn sources actually placed from Hand; three native opposing responses across own turns1/3. Accepted first use shares player flag; declined first use permits later same-turn use. Both actual source destructions and native damage prove outcomes. No general Omega chain-info compatibility conclusion.'");
s="const assert=require('node:assert/strict');\n"+s;const m=new Module(file,module);m.filename=file;m.paths=module.paths;m._compile(s,file);
