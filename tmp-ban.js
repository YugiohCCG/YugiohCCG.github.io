const https=require('https');
https.get('https://www.duelingbook.com/banlist?id=3880',res=>{
  let d='';res.on('data',c=>d+=c);
  res.on('end',()=>{
    const arr=[...d.matchAll(/src="([^"]+)"/g)].map(m=>m[1]);
    console.log(arr.filter(s=>s.toLowerCase().includes('ban')).slice(0,20));
  });
});
