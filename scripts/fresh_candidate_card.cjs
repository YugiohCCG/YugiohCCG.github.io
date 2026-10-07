'use strict';
const path=require('node:path'),assert=require('node:assert/strict'),{DatabaseSync}=require('node:sqlite');
exports.candidateCard=code=>{
 const db=new DatabaseSync(path.resolve(__dirname,'../output/fresh-ccg-september/candidate-CCG_v1.db'),{readOnly:true});
 const q=db.prepare('select * from datas where id=?');q.setReadBigInts(true);
 const row=q.get(code);db.close();assert(row,'Missing candidate card '+code);
 const setcodes=[];
 if(row.setcode instanceof Uint8Array){for(let i=0;i+1<row.setcode.length;i+=2)setcodes.push(row.setcode[i]|row.setcode[i+1]<<8);}
 else{for(let packed=BigInt.asUintN(64,BigInt(row.setcode||0));packed>0n;packed>>=16n)setcodes.push(Number(packed&65535n));}
 const isLink=(row.type&0x4000000n)!==0n;
 return {code,alias:Number(row.alias),setcodes,type:Number(row.type),level:Number(row.level&255n),attribute:Number(row.attribute),race:row.race,attack:Number(row.atk),defense:isLink?0:Number(row.def),link_marker:isLink?Number(row.def):0,lscale:Number(row.level>>24n&255n),rscale:Number(row.level>>16n&255n)};
};
