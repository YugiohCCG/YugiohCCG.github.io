'use strict';
const fs=require('node:fs'),path=require('node:path'),Module=require('node:module'),assert=require('node:assert/strict');
const file=path.join(__dirname,'fresh_current_actual_ritual_targets.cjs');let outer=fs.readFileSync(file,'utf8');
const injection=`
assert([259156549,259247807,259494236].includes(target),'Remaining installed Cyberse Ritual target');
if(mode==='leotron')rep("['hand','extra','grave','fullField']","['hand','grave','fullField']");
if(mode==='witch')rep("['handEnough','fieldMaterial','extra','fullField']","['handEnough','fieldMaterial','fullField']");
`;
assert(outer.includes('const m=new Module(file,module);'));outer=outer.replace('const m=new Module(file,module);',injection+'\nconst m=new Module(file,module);');const m=new Module(file,module);m.filename=file;m.paths=module.paths;m._compile(outer,file);
