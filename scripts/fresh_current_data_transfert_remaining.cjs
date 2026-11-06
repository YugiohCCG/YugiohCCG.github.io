'use strict';
const fs=require('node:fs'),path=require('node:path'),Module=require('node:module'),assert=require('node:assert/strict');
const file=path.join(__dirname,'fresh_current_data_transfert_targets.cjs');let outer=fs.readFileSync(file,'utf8');const injection=`
assert([259156549,259247807,259494236].includes(target));
rep("['hand','field','extra','grave','extraNoGate','graveNoGate','fullHand','fullField','fullExtra','extraBlocked','protected','insufficient']","['hand','field','grave','graveNoGate','fullHand','fullField','protected','insufficient']");
s=s.replace(/scope:'[^']*'/,"scope:'Full original Data-Transfert and actual non-Pendulum Protron/Bitron/Digitron target sources, installed metadata/corrected transport/no Lua API adapter. Native Ritual materials/group/reasons/type/completion; Hand/field/full-field, actual paid prior GY history, named-normal gate and negative boundaries. Neutral fixed paid prior history and code-only normal gate; target optional followups declined. No independent target procedures/followups/full-card/live Omega certification.'");
`;assert(outer.includes('const m=new Module(file,module);'));outer=outer.replace('const m=new Module(file,module);',injection+'\nconst m=new Module(file,module);');const m=new Module(file,module);m.filename=file;m.paths=module.paths;m._compile(outer,file);
