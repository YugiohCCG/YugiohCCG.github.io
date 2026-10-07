const fs=require('node:fs'),path=require('node:path'),crypto=require('node:crypto'),assert=require('node:assert/strict'),{pathToFileURL}=require('node:url');
const root=path.resolve(__dirname,'..'),out=path.join(root,'output/fresh-ccg-september');
const cases=[
 [238274862,'destroyed',[[{previous:2},true],[{previous:4},true],[{previous:1},false],[{previous:1,current:2},false]]],
 [239935100,'destroyfilter',[[{original:1,current:2},true],[{original:2,current:1},false]]],
 [239935102,'watercard',[[{original:1,current:2},true],[{original:2,current:1},false]]],
 [259024242,'search',[[{current:2},true],[{current:0x10002},true],[{current:4},false],[{current:1},false]]],
 [259095349,'ovf',[[{overlay:true},true],[{overlay:false},false]]],
 [259548744,'ovf',[[{overlay:true},true],[{overlay:false},false]]],
 [259635008,'lvf',[[{haslevel:true},true],[{haslevel:false},false]]],
 [259935441,'cpf',[[{current:4},true],[{current:0x100004},false],[{current:0x20004},false],[{current:2},false]]],
 [259882493,'vst',[[{current:2},true],[{current:4},true],[{current:1},false]]]
];
async function main(){
 const mod=await import(pathToFileURL(path.join(path.dirname(require.resolve('@n1xx1/ocgcore-wasm')),'dist/index.js')).href),core=await mod.default({sync:true,print(){},printErr(){}}),logs=[];
 const duel=core.createDuel({flags:0n,seed:[1n,2n,3n,4n],team1:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},team2:{startingLP:8000,startingDrawCount:0,drawCountPerTurn:0},cardReader:()=>null,scriptReader:()=>'',errorHandler:(type,message)=>logs.push({type,message})});
 let lua=`TYPE_MONSTER=1 TYPE_SPELL=2 TYPE_TRAP=4 TYPE_SPIRIT=512\nlocal function fixture(t)\n return {IsType=function(self,k) return ((t.current or 513)&k)~=0 end,GetType=function()return t.current or 513 end,GetOriginalType=function()return t.original or 1 end,GetPreviousTypeOnField=function()return t.previous or 1 end,IsCanOverlay=function()return t.overlay end,IsHasLevel=function()return t.haslevel end,IsFaceup=function()return true end,IsSetCard=function()return true end,IsAbleToHand=function()return true end,IsSSetable=function()return true end,IsAbleToGrave=function()return true end,CheckActivateEffect=function()return {} end,IsPreviousLocation=function()return true end,IsPreviousPosition=function()return true end,IsAttribute=function()return true end,IsRace=function()return true end,IsDestructable=function()return true end}\nend\n`;
 const results=[];
 for(const [code,fn,tests] of cases){
 const source=fs.readFileSync(path.join(root,'public/CCG Downloads/CCG_Scripts/c'+code+'.lua'),'utf8');
 lua+='do\nlocal captured={} local function GetID()return captured,'+code+' end\n'+source+'\n';
 tests.forEach(([fields,expected],i)=>{const table='{'+Object.entries(fields).map(([k,v])=>k+'='+String(v)).join(',')+'}';lua+=`assert(captured.${fn}(fixture(${table}))==${expected},"${code}:${fn}:${i}")\n`;results.push({passcode:code,filter:fn,fields,expected,script_sha256:crypto.createHash('sha256').update(source).digest('hex')});});lua+='end\n';
 }
 try{assert(core.loadScript(duel,'omega_predicate_probe.lua',lua));assert(!logs.some(x=>x.type===0),JSON.stringify(logs));}finally{core.destroyDuel(duel);}
 fs.writeFileSync(path.join(out,'omega-predicate-filter-tests.json'),JSON.stringify({scope:'Actual production Lua filter calls with explicit table fixtures, executed in public Lua runtime. IsCanOverlay/IsHasLevel return values are fixtures; no native method or full effect certification.',results,logs},null,2)+'\n');console.log(JSON.stringify({filter_cases:results.length,status:'PASS'}));
}main().catch(e=>{console.error(e);process.exitCode=1;});
