-- Execute card initialization and pure callback families against Omega-shaped values.
local script_path=assert(arg[1],"script path required")
local current_id=assert(tonumber(arg[2]),"numeric card id required")

local card_mt,group_mt,effect_mt={},{},{}
local card,group,effect

local numeric_card_methods={
	GetAttack=true,GetBaseAttack=true,GetDefense=true,GetBaseDefense=true,
	GetLevel=true,GetRank=true,GetLink=true,GetScale=true,GetLeftScale=true,GetRightScale=true,
	GetCode=true,GetOriginalCode=true,GetOriginalCodeRule=true,GetType=true,GetOriginalType=true,
	GetRace=true,GetOriginalRace=true,GetAttribute=true,GetOriginalAttribute=true,
	GetLocation=true,GetPreviousLocation=true,GetSequence=true,GetPreviousSequence=true,
	GetControler=true,GetPreviousControler=true,GetOwner=true,GetOwnerPlayer=true,
	GetSummonPlayer=true,GetSummonType=true,GetReason=true,GetReasonPlayer=true,
	GetStatus=true,GetCounter=true,GetFlagEffect=true,GetFlagEffectLabel=true,
	GetColumnZone=true,GetLinkedZone=true,GetMutualLinkedZone=true,GetFieldID=true,
	GetTurnID=true,GetBattlePosition=true,GetOriginalLevel=true,GetOriginalRank=true,
	GetOriginalAttack=true,GetOriginalDefense=true,
}
local group_card_methods={
	GetOverlayGroup=true,GetLinkedGroup=true,GetMutualLinkedGroup=true,GetEquipGroup=true,
	GetMaterial=true,GetColumnGroup=true,
}
local single_card_methods={
	GetBattleTarget=true,GetReasonCard=true,GetEquipTarget=true,GetUnionTarget=true,
	GetOwnerTarget=true,GetPreviousEquipTarget=true,
}
local effect_card_methods={
	GetActivateEffect=true,
}

card_mt.__len=function() return 1 end
card_mt.__index=function(_,key)
	if numeric_card_methods[key] then return function() return 1 end end
	if group_card_methods[key] then return function() return group end end
	if single_card_methods[key] then return function() return card end end
	if effect_card_methods[key] then return function() return effect end end
	if key=="GetHandler" or key=="GetFirst" then return function() return card end end
	if key=="Filter" or key=="Select" or key=="RandomSelect" or key=="Clone" then return function() return group end end
	if key=="DeleteGroup" or key=="KeepAlive" then return function() end end
	if key=="CheckActivateEffect" then return function() return effect,group,0,0,effect,0,0 end end
	if key=="GetTarget" then return function() return function() return group end end end
	if key=="GetOperation" or key=="GetCost" then return function() return function() return 1 end end end
	if key:match("^Is") or key:match("^Can") or key:match("^Check") then
		return function() return true end
	end
	return function() return 1 end
end

group_mt.__len=function() return 1 end
group_mt.__sub=function() return group end
group_mt.__index=function(_,key)
	if key=="GetFirst" or key=="SelectUnselect" then return function() return card end end
	if key=="GetNext" then return function() return nil end end
	if key=="GetCount" or key=="FilterCount" or key=="GetClassCount" or key=="GetSum" then return function() return 1 end end
	if key=="IsContains" or key=="IsExists" or key=="CheckWithSumEqual"
		or key=="CheckWithSumGreater" or key=="CheckSubGroup" then return function() return true end end
	if key=="SelectSubGroup" then return function() return group end end
	if key=="FilterSelect" or key=="Filter" or key=="Select" or key=="Clone"
		or key=="Match" or key=="GetMaxGroup" or key=="GetMinGroup" then return function() return group end end
	return function() return group end
end

effect_mt.__index=function(_,key)
	if key=="GetHandler" or key=="GetOwner" or key=="GetHandlerPlayer" then
		return key=="GetHandlerPlayer" and function() return 0 end or function() return card end
	end
	if key=="GetLabel" then return function() return 1,1,1,1,1,1 end end
	if key=="GetDescription" or key=="GetCode" or key=="GetType"
		or key=="GetCategory" or key=="GetProperty" or key=="GetReset" then return function() return 1 end end
	if key=="GetLabelObject" then return function() return card end end
	if key=="GetTarget" then return function() return function() return group end end end
	if key=="GetOperation" or key=="GetCost" then return function() return function() return 1 end end end
	if key=="Clone" then return function() return setmetatable({},effect_mt) end end
	if key:match("^Is") then return function() return true end end
	return function() return 1 end
end

card=setmetatable({},card_mt)
group=setmetatable({card},group_mt)
effect=setmetatable({},effect_mt)

function GetID()
	local script={}
	_G["c"..current_id]=script
	return script,current_id,0
end

local function lazy_namespace(default)
	return setmetatable({},{
		__index=function(t,key)
			local value=default(key)
			rawset(t,key,value)
			return value
		end
	})
end

Effect={
	CreateEffect=function() return setmetatable({},effect_mt) end,
	GlobalEffect=function() return setmetatable({},effect_mt) end,
}
Card=lazy_namespace(function(key)
	if key:match("^Is") or key:match("^Can") or key:match("^Check") then return function() return true end end
	if key:match("^Get") then return function() return 1 end end
	return function() return true end
end)
Group=lazy_namespace(function()
	return function() return group end
end)
Group.CreateGroup=function() return group end
Group.FromCards=function() return group end

CHAININFO_TRIGGERING_EFFECT=101
CHAININFO_TARGET_CARDS=102
CHAININFO_TRIGGERING_LOCATION=103
CHAININFO_TRIGGERING_PLAYER=104
CHAININFO_TRIGGERING_CONTROLER=105
Duel=lazy_namespace(function(key)
	if key=="GetChainInfo" then
		return function(_, ...)
			local out={}
			for _,info in ipairs({...}) do
				if info==CHAININFO_TRIGGERING_EFFECT then out[#out+1]=effect
				elseif info==CHAININFO_TARGET_CARDS then out[#out+1]=group
				else out[#out+1]=1 end
			end
			return table.unpack(out)
		end
	end
	if key=="GetActivityCount" then return function() return 1,1,1 end end
	if key:find("Count") or key=="GetLocationCount" or key=="GetLocationCountFromEx"
		or key=="GetUsableMZoneCount" or key=="GetCounter" then return function() return 1 end end
	if key:find("MatchingGroup") or key:find("MatchingCard") or key:find("FieldGroup") or key:find("OperatedGroup")
		or key=="GetDecktopGroup" or key=="GetTargetCards" or key=="GetReleaseGroup"
		or key=="GetRitualMaterial" or key=="GetFusionMaterial" or key=="SelectFusionMaterial"
		or key=="GetTargetsRelateToChain" then
		return function() return group end
	end
	if key=="GetChainMaterial" then return function() return effect end end
	if key=="GetFirstTarget" or key=="GetFieldCard" or key=="CreateToken"
		or key=="GetAttacker" or key=="GetAttackTarget" then return function() return card end end
	if key:match("^Is") or key:match("^Check") then return function() return true end end
	if key:match("^Get") or key:match("^Select") or key:match("^Send") or key:match("^Special")
		or key:match("^Draw") or key:match("^Destroy") or key:match("^Remove") then return function() return 1 end end
	return function() return 1 end
end)

aux=lazy_namespace(function()
	return function() return true end
end)
Auxiliary=aux
aux.TRUE=function() return true end
aux.Stringid=function() return 1 end
aux.NecroValleyFilter=function(f) return f or function() return true end end
aux.AddEquipProcedure=function() return effect end
aux.AddLinkProcedure=function() return effect end
aux.FilterBoolFunction=function(f,...)
	local args={...}
	return function(c) return f(c,table.unpack(args)) end
end
aux.AND=function(...)
	local fs={...}
	return function(...)
		for _,f in ipairs(fs) do if not f(...) then return false end end
		return true
	end
end
aux.OR=function(...)
	local fs={...}
	return function(...)
		for _,f in ipairs(fs) do if f(...) then return true end end
		return false
	end
end
aux.Next=function()
	local done=false
	return function()
		if done then return nil end
		done=true
		return card
	end
end

Fusion=lazy_namespace(function() return function() return true end end)
Synchro=lazy_namespace(function() return function() return true end end)
Xyz=lazy_namespace(function() return function() return true end end)
Link=lazy_namespace(function() return function() return true end end)
Pendulum=lazy_namespace(function() return function() return true end end)
Ritual=lazy_namespace(function() return function() return true end end)
Spirit=lazy_namespace(function() return function() return true end end)
bit=lazy_namespace(function() return function() return 1 end end)
CCG_GLOBAL_CHECKS={}
c29724053={[0]=1,[1]=1}

setmetatable(_G,{__index=function(t,key)
	rawset(t,key,1)
	return 1
end})

assert(loadfile(script_path))()
local script=assert(_G["c"..current_id],"GetID table was not created")
if type(script)~="table" then
	print("SKIP compatibility loader")
	os.exit(0)
end
local init_ok,init_err=pcall(script.initial_effect,card)
if not init_ok then
	print("calls=0 failures=1")
	print("initial_effect: "..tostring(init_err))
	os.exit(1)
end

local interesting={"filter","con","val","limit","check","count","zone","match","cost","target","tg"}
local failures={}
local calls=0
local function argument_for(name)
	if not name then return 1 end
	if name=="e" or name=="se" or name=="re" or name=="te" or name=="pe" then return effect end
	if name=="g" or name:match("g$") or name:match("^g%d+$") or name=="selected" or name=="mat" then return group end
	if name=="f" or name=="filter" then return function() return true end end
	if name=="chk" then return 0 end
	if name=="chkc" then return nil end
	if name=="c" or name=="tc" or name=="mc" or name=="rc" or name=="sc" or name=="ec" or name=="syncard"
		or name=="xc" or name=="pc" or name=="lc" or name=="ac" or name=="bc" or name=="dc"
		or name=="fc" or name=="cc" or name=="oc" or name=="ic" or name=="xyzc" then return card end
	return 1
end

for name,fn in pairs(script) do
	local should_call=false
	if type(name)=="string" then
		for _,fragment in ipairs(interesting) do
			if name:match(fragment) then should_call=true break end
		end
		if name:match("op$") then should_call=true end
	end
	if type(fn)=="function" and name~="initial_effect" and should_call then
		local info=debug.getinfo(fn,"u")
		local args={}
		for i=1,info.nparams do
			local pname=debug.getlocal(fn,i)
			args[i]=argument_for(pname)
		end
		calls=calls+1
		local ok,err=pcall(fn,table.unpack(args,1,info.nparams))
		if not ok then failures[#failures+1]=name..": "..tostring(err) end
	end
end

print("calls="..calls.." failures="..#failures)
for _,failure in ipairs(failures) do print(failure) end
if #failures>0 then os.exit(1) end
