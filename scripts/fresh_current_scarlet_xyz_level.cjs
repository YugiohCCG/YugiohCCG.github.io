'use strict';
const fs=require('node:fs'),path=require('node:path'),Module=require('node:module');const file=path.join(__dirname,'fresh_current_aldrez_knight_xyz_level.cjs');let script=fs.readFileSync(file,'utf8').replaceAll('238282350','220749574').replaceAll('current-aldrez-knight-xyz-level','current-scarlet-xyz-level').replaceAll('Full Knight','Full Scarlet');
const at=script.indexOf('const m=new Module');if(at<0)throw Error('Parent changed');script=script.slice(0,at)+`
rep('[{},{rank3:true},{disabled:true}]','[{},{wrongRace:true},{disabled:true},{rank7:true},{rank7:true,wrongRace:true},{rank7:true,disabled:true}]');
rep('test.rank3?3:4','test.rank7?7:1');rep('test.rank3?3:4','test.rank7?7:1');
rep('level:test.rank7?7:1,setcodes:','level:test.rank7?7:1,race:test.wrongRace?1n:64n,setcodes:');
rep('!(test.rank3||test.disabled)','test.rank7||!(test.wrongRace||test.disabled)');
rep("lua.replace('e0:SetValue(s.xyzlv)','e0:SetValue(0)')","lua.replace('e4:SetValue(s.xyzlv)','e4:SetValue(function(e,c,rc) return c:GetLevel() end)')");
rep("lua.replace('if rc and rc:IsRank(4) then return 4 end','if rc then return rc:GetRank() end')","lua.replace('if rc:IsRace(RACE_AQUA) then','if true then')");
s=s.replace(/scope:'Full Scarlet[^']*'/,"scope:'Full Scarlet/current installed metadata/corrected transport/no Lua API adapter. Initially field source; paid neutral fixed Xyz procedure invokes native IsCanBeXyzMaterial/IsXyzLevel. Aqua Rank1 treatment, non-Aqua/disabled negatives; natural Level7 preserved for Aqua/non-Aqua/disabled. Actual native two-card Overlay. Original Hand history and named/general recipient recipes/full-card/live Omega separate.'");
`+script.slice(at);const m=new Module(file,module);m.filename=file;m.paths=module.paths;m._compile(script,file);
