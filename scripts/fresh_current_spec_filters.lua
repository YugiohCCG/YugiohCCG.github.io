-- Current printed eligibility deltas only; mock card boundaries, no native proof.
dofile('tmp/omega_scripts/constant.lua')
Card={};aux={};Duel={GetMZoneCount=function() return 1 end}
local passed=0
local function check(x,message) assert(x,message);passed=passed+1 end
local function load(code)
 local s={};GetID=function() return s,code end
 local file='public/CCG Downloads/CCG_Scripts/c'..code..'.lua'
 local body=assert(io.open(file)):read('*a')
 if arg[1]=='--old-insect-'..code then body=body:gsub('%(c:IsSetCard%(SET_WYVERNAL%) or c:IsRace%(RACE_INSECT%)%)','c:IsRace(RACE_INSECT)') end
 assert(_G.load(body,'@'..file))();return s
end
local function card(set,race,typ,loc,face,wind,level,legal)
 legal=legal~=false
 return {IsSetCard=function(_,v) return set and v==0x4714 end,
 IsRace=function(_,v) return (race & v)~=0 end,IsType=function(_,v) return (typ & v)~=0 end,
 IsLocation=function(_,v) return (loc & v)~=0 end,IsFaceup=function() return face end,
 IsAttribute=function(_,v) return wind and v==ATTRIBUTE_WIND end,
 IsLevelBelow=function(_,v) return level<=v end,
 IsAbleToDeck=function() return legal end,IsCanBeEffectTarget=function() return legal end,
 IsAbleToGraveAsCost=function() return legal end,IsCanBeFusionMaterial=function() return legal end,
 IsCanBeSpecialSummoned=function() return legal end,IsAbleToHand=function() return legal end,
 IsImmuneToEffect=function() return not legal end}
end
local gathering,sanctuary,sphinx,lymantria=load(259073666),load(259160760),load(259348317),load(259763531)
for _,set in ipairs{false,true} do for _,race in ipairs{RACE_INSECT,RACE_DRAGON} do
 local eligible=set or race==RACE_INSECT
 for _,typ in ipairs{TYPE_MONSTER,TYPE_SPELL,TYPE_MONSTER+TYPE_FUSION} do
  local monster=(typ & TYPE_MONSTER)~=0
  for _,legal in ipairs{false,true} do
   local c=card(set,race,typ,LOCATION_GRAVE,true,true,4,legal)
   check(gathering.tdfilter(c,{})==(eligible and monster and legal),'Gathering GY eligibility')
   check(sanctuary.costfilter(c,0)==(eligible and monster and legal),'Sanctuary face-up cost')
   check(sanctuary.summonedinsect(c)==(eligible and monster),'Sanctuary summon event')
   check(sanctuary.matfilter2(c,{})==(eligible and monster and legal),'Sanctuary material')
   check(sphinx.insectfusion(c)==(eligible and (typ & TYPE_FUSION)~=0),'Sphinx quick mode')
   check(lymantria.thfilter(c)==(eligible and monster and legal),'Lymantria WIND search')
   check(lymantria.spfilter(c,{},0)==(eligible and monster and legal),'Lymantria revival')
   check(not lymantria.exlimit({},c),'Non-Extra card exempt from lock')
   local extra=card(set,race,typ,LOCATION_EXTRA,true,true,4,legal)
   check(lymantria.exlimit({},extra)==not eligible,'Extra lock exceptions')
  end
 end
 local dark=card(set,race,TYPE_MONSTER,LOCATION_DECK,true,false,4,true)
 check(not lymantria.thfilter(dark),'Search requires WIND')
 local facedown=card(set,race,TYPE_MONSTER+TYPE_FUSION,LOCATION_MZONE,false,true,4,true)
 check(not sanctuary.costfilter(facedown,0),'Face-down cost excluded')
 check(not sphinx.insectfusion(facedown),'Face-down Fusion excludes quick mode')
 check(not sanctuary.matfilter(facedown),'Face-down field material excluded')
 local banished=card(set,race,TYPE_MONSTER,LOCATION_REMOVED,false,true,4,true)
 check(not sanctuary.matfilter(banished),'Face-down banished material excluded')
end end
local nature=load(259152704)
for _,race in ipairs{RACE_PLANT,RACE_INSECT,RACE_BEAST,RACE_DRAGON,RACE_WARRIOR} do
 local eligible=race==RACE_PLANT or race==RACE_INSECT or race==RACE_BEAST
 for _,tuner in ipairs{false,true} do for _,level in ipairs{4,5} do for _,legal in ipairs{false,true} do
  local c=card(false,race,TYPE_MONSTER+(tuner and TYPE_TUNER or 0),LOCATION_GRAVE,true,false,level,legal)
  check(nature.matfilter(c)==(eligible and tuner),'Nature Tuner race')
  check(nature.spfilter(c,{},0)==(eligible and level<=4 and legal),'Nature summon recipient')
  check(nature.tgtg({},c)==eligible,'Nature protection race')
 end end end
end
print('PASS '..passed..' current-spec filter assertions')
