local script_path=assert(arg[1],"script path required")
local current_id=assert(tonumber(arg[2]),"numeric card id required")
local created,callbacks,registered=0,0,0

local function noop(...) return false end
local function lazy_table()
	return setmetatable({}, {__index=function(t,k) rawset(t,k,noop) return noop end})
end

function GetID()
	local script={}
	_G["c"..current_id]=script
	return script,current_id,0
end

local effect_mt={}
effect_mt.__index=function(t,k)
	if k=="Clone" then
		return function() return setmetatable({},effect_mt) end
	end
	if k=="SetCondition" or k=="SetCost" or k=="SetTarget" or k=="SetOperation" then
		return function(_,cb)
			assert(type(cb)=="function",k.." received "..type(cb))
			callbacks=callbacks+1
		end
	end
	return noop
end

Effect={
	CreateEffect=function()
		created=created+1
		return setmetatable({},effect_mt)
	end,
	GlobalEffect=function()
		created=created+1
		return setmetatable({},effect_mt)
	end,
}

Card=lazy_table()
Group=lazy_table()
Duel=lazy_table()
aux=setmetatable({}, {__index=function(t,k)
	local wrapper
	if k=="AddLinkProcedure" then
		wrapper=function() return setmetatable({},effect_mt) end
	else
		wrapper=function(...) return noop end
	end
	rawset(t,k,wrapper)
	return wrapper
end})
Fusion=lazy_table()
Synchro=lazy_table()
Xyz=lazy_table()
Link=lazy_table()
Pendulum=lazy_table()
Ritual=lazy_table()
Spirit=lazy_table()
bit=lazy_table()
CCG_GLOBAL_CHECKS={}

setmetatable(_G,{__index=function(t,k) rawset(t,k,0) return 0 end})
assert(loadfile(script_path))()
local script=assert(_G["c"..current_id],"GetID table was not created")
assert(type(script.initial_effect)=="function","initial_effect is missing")
local card=setmetatable({}, {__index=function(_,k)
	if k=="RegisterEffect" then
		return function(_,e)
			assert(type(e)=="table","RegisterEffect received "..type(e))
			registered=registered+1
		end
	end
	return noop
end})
script.initial_effect(card)
print(created,callbacks,registered)
