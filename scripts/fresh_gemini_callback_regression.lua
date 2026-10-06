--Focused production callback tests. These mock Duel boundaries; they do not certify native Omega.
dofile('tmp/omega_scripts/constant.lua')
Card={}; Duel={}; aux={Stringid=function() return 0 end,FilterBoolFunction=function() return function() end end,
 AddXyzProcedure=function() end,AddFusionProcFun2=function() end,AddCodeList=function() end,
 AddFusionProcMix=function() end,NOT=function(f) return function(c,...) return not f(c,...) end end,NecroValleyFilter=function(f)
 return function(c,...) return (not f or f(c,...)) and not c:IsHasEffect(EFFECT_NECRO_VALLEY) end end}
local passed=0
local function check(value,message) assert(value,message); passed=passed+1 end
local function card(values)
 values=values or {}
 return setmetatable({},{__index=function(t,key)
  return function() local v=values[key:sub(1,3)=='Get' and key:sub(4) or key]; if v~=nil then return v end; return false end
 end})
end
local function load(code)
 local s={}; GetID=function() return s,code end
 assert(loadfile('public/CCG Downloads/CCG_Scripts/c'..code..'.lua'))()
 return s
end
for _,code in ipairs{212184534,215445495,216505735,231400558,259655976} do
 local s=load(code)
 check(not s.xyzctrl(card{IsFaceup=false,IsType=true}),'Face-down Xyz does not block '..code)
 check(s.xyzctrl(card{IsFaceup=true,IsType=true}),'Face-up Xyz blocks '..code)
 for _,destroy in ipairs{0,1} do
  local trace={}; Duel.Destroy=function() trace[#trace+1]='destroy';return destroy end
  Duel.BreakEffect=function() trace[#trace+1]='break' end
  Duel.Draw=function() trace[#trace+1]='draw' end
  s.drop({GetHandler=function() return card{IsRelateToEffect=true,OverlayCount=0,IsDestructable=true} end},0)
  check(table.concat(trace,',')==(destroy==1 and 'destroy,break,draw' or 'destroy'),'Then draw depends on destruction '..code)
 end
end
do
 local s=load(210628767)
 for _,controller in ipairs{0,1} do for _,owner in ipairs{0,1} do for _,seq in ipairs{0,4,5,6} do
  local expected=seq>=5 and (seq==5 and 1 or 3) or seq
  if controller~=owner then expected=4-expected end
  local moved
  Duel.GetFieldCard=function(p,loc,sq) check(p==owner and sq==expected,'Owner column mapping');return nil end
  Duel.GetLocationCount=function() return 1 end;Duel.MoveToField=function() return true end
  Duel.MoveSequence=function(c,sq) moved=sq end
  local c=card{Owner=owner,Controler=controller,IsLocation=true}
  check(s.moveincolumn(c,0,seq) and moved==expected,'Valid owner S/T zone')
 end end end
end
do
 local s=load(215105971)
 for _,owner in ipairs{0,1} do for _,reason in ipairs{0,1} do
  local c=card{IsPreviousPosition=true,IsPreviousLocation=true,IsSummonType=true,PreviousControler=0,Owner=owner,ReasonPlayer=reason}
  check(s.spcon({GetHandler=function() return c end},0,nil,nil,nil,nil,nil,reason)==(owner==0 and reason==1),'Owner and opponent reason checks')
 end end
end
do
 local s=load(215142357)
 for _,location in ipairs{LOCATION_MZONE,LOCATION_HAND,LOCATION_GRAVE} do
  local rc=card{IsSetCard=true,IsControler=false,IsLocation=false}
  local re={GetHandler=function() return rc end,IsActiveType=function() return true end,GetActivateLocation=function() return location end}
  check(s.drcon({},0,nil,nil,nil,re,nil,0)==(location==LOCATION_MZONE),'Activation location remains valid after self-cost')
  check(not s.drcon({},0,nil,nil,nil,re,nil,1),'Opponent activation excluded')
 end
end
do
 local s=load(259792415); Duel.GetTurnPlayer=function() return 1 end
 local destroyed=card{IsStatus=true}
 local attacker=card{IsControler=true,BattleTarget=destroyed}
 local eg={IsExists=function(_,fn) return fn(attacker) end}
 check(s.bpcon({},0,eg),'Any controlled attacker, not handler')
 Duel.GetTurnPlayer=function() return 0 end
 check(not s.bpcon({},0,eg),'Opponent turn only')
end
for _,code in ipairs{259391738,259944344} do
 local s=load(code)
 for _,face in ipairs{false,true} do
  local c=card{IsSetCard=true,IsType=true,IsAbleToDeck=true,IsAbleToHand=true,IsFaceup=face,IsCode=false}
  c.IsLocation=function(_,loc) return loc==LOCATION_REMOVED end
  local ok=code==259391738 and s.rdf(c,{GetHandler=function() return {} end}) or code==259944344 and s.thf(c)
  check(not not ok==face,'Banished archetype recognition requires face-up '..code)
 end
end
local function registrations(code)
 local effects={}
 Effect={CreateEffect=function()
  return setmetatable({data={}},{__index=function(t,k)
   if k=='Clone' then return function() local out={data={}};for a,b in pairs(t.data) do out.data[a]=b end;return setmetatable(out,getmetatable(t)) end end
   return function(_,...) t.data[k]={...} end
  end})
 end}
 local c={RegisterEffect=function(_,e) effects[#effects+1]=e end,EnableReviveLimit=function() end}
 load(code).initial_effect(c);return effects
end
do
 local es=registrations(216258796)
 local e=es[2]
 check(e.data.SetProperty[1]==EFFECT_FLAG_DAMAGE_STEP+EFFECT_FLAG_DAMAGE_CAL,'Activation negate Damage Step flags')
end
do
 local es=registrations(219002796)
 check(es[3].data.SetProperty[1]==EFFECT_FLAG_PLAYER_TARGET,'Attack prohibition player flag')
 check(es[3].data.SetTargetRange[1]==0 and es[3].data.SetTargetRange[2]==1,'Attack prohibition opponent only')
end
do
 local es=registrations(259655976)
 check(es[1].data.SetType[1]==EFFECT_TYPE_IGNITION,'Lighting main-phase branch spell speed one')
 check(es[2].data.SetType[1]==EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O,'Lighting retains summon trigger')
end
do
 local s=load(220150285)
 check(not s.ffilter1(card{IsImmuneToEffect=true},{}),'Immune Fusion material excluded')
 check(s.ffilter1(card{IsImmuneToEffect=false},{}),'Nonimmune Fusion material admitted')
end
do
 local s=load(236473882); local handler={}; local e={GetHandler=function() return handler end}
 for _,zones in ipairs{0,1} do
  Duel.GetLocationCountFromEx=function(tp,p,excluded) check(excluded==handler,'Leaving Link handler excluded from zones');return zones end
  check(s.spfilter(card{IsSetCard=true,IsType=true,IsLink=true,IsCanBeSpecialSummoned=true},e,0)==(zones>0),'Link summon requires a legal zone')
 end
end
do
 local s=load(232449539)
 check(s.checkfilter(card{IsSetCard=true,IsType=true,IsLocation=true,IsPreviousLocation=false,IsReason=false}),'Deck return by cost qualifies')
 check(not s.checkfilter(card{IsSetCard=true,IsType=true,IsLocation=true,IsPreviousLocation=true}),'Already in Deck does not qualify')
end
for _,code in ipairs{215006791,237684285} do
 local s=load(code)
 for _,count in ipairs{0,1} do
  local g={};for i=1,count do g[i]={} end;g.FilterCount=function() return 0 end
  local c=card{IsSummonType=true,Material=g};local e={GetHandler=function() return c end}
  check((code==215006791 and s.rmcon(e,0) or code==237684285 and s.rtcon(e,0))==(count>0),'Archetype-only summon needs actual materials')
 end
end
do
 local s=load(237684285)
 for _,returned in ipairs{1,2} do for _,available in ipairs{1,3} do
  local tg={{}};tg.Filter=function() return tg end
  local og={FilterCount=function() return returned end};local selected,split
  Duel.GetChainInfo=function() return tg end;Duel.SendtoHand=function() return returned end
  Duel.GetOperatedGroup=function() return og end;Duel.GetMatchingGroupCount=function() return available end
  Duel.Hint=function() end;Duel.BreakEffect=function() split=true end
  Duel.SelectMatchingCard=function(tp,f,p,loc,opp,min,max) selected={min,max};return {{}} end
  Duel.SendtoDeck=function() return 0 end
  s.rtop({},0)
  check(selected[1]==math.min(returned,available) and selected[2]==selected[1] and split,'Clement Winds shuffle count and then timing')
 end end
end
do
 local captured
 aux.AddFusionProcMix=function(c,sub,insf,first,second) captured={sub,insf,first,second} end
 local s=load(259363148)
 check(s.contactfilter(card{IsType=true,IsSetCard=true,IsAbleToDeckAsCost=false,IsAbleToDeckOrExtraAsCost=true}),'Extra Deck contact material can return as cost')
 local c={RegisterEffect=function() end,EnableReviveLimit=function() end}
 s.initial_effect(c)
 check(captured and captured[1]==false and captured[3]==s.matfilter and captured[4]==s.matfilter,'Satyrius registers its two generic Fusion materials')
end
print('PASS '..passed..' production callback assertions (mock boundaries; native Omega unverified)')
