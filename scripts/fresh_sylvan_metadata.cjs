'use strict';
const path=require('node:path'),assert=require('node:assert/strict'),{DatabaseSync}=require('node:sqlite');
const db=new DatabaseSync(path.resolve(__dirname,'../output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true});
const query=db.prepare('select * from datas where id=?');query.setReadBigInts(true);
const cards=new Map();
for(const code of [238276572,238276573,238276574,238276575,238276576,238276577,238276578,238276579]){
 const row=query.get(code);assert(row,'Missing staged Sylvan row '+code);
 const setcodes=[];
 if(row.setcode instanceof Uint8Array){for(let i=0;i+1<row.setcode.length;i+=2)setcodes.push(row.setcode[i]|(row.setcode[i+1]<<8));}
 else{for(let packed=BigInt.asUintN(64,BigInt(row.setcode||0));packed>0n;packed>>=16n)setcodes.push(Number(packed&0xffffn));}
 assert(setcodes.includes(0x90),'Candidate Sylvan setcode does not match canonical 0x90: '+code);
 const isLink=(row.type&0x4000000n)!==0n;
 cards.set(code,{code,alias:Number(row.alias),setcodes,type:Number(row.type),level:Number(row.level&255n),attribute:Number(row.attribute),race:row.race,attack:Number(row.atk),defense:isLink?0:Number(row.def),lscale:Number((row.level>>24n)&255n),rscale:Number((row.level>>16n)&255n),link_marker:isLink?Number(row.def):0});
}
db.close();
exports.sylvanCard=code=>{assert(cards.has(code),'Unloaded Sylvan card '+code);return cards.get(code);};
