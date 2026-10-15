-- Focused regressions for the requested Ohmen revision, independent of the duel UI.
local root=arg[1] or '.'
local suite={}
local current
function GetID() current={} return current,259405917 end
local function loadcard(code)
 dofile(root..'/public/CCG Downloads/CCG_Scripts/c'..code..'.lua')
 return current
end
bit={band=function(a,b) return a&b end,bor=function(a,b) return a|b end,
 bnot=function(a) return ~a end,lshift=function(a,b) return a<<b end,rshift=function(a,b) return a>>b end,
 bxor=function(a,b) return a~b end}
LOCATION_MZONE=4
aux={Next=function(g) local i=0 return function() i=i+1 return g[i] end end}
local linked={{IsFaceup=function() return true end,GetMutualLinkedGroupCount=function() return 1 end,
 GetLinkedZone=function(self,p) return p==0 and 2 or 8 end}}
Duel={GetMatchingGroup=function() return linked end,CheckLocation=function(p,loc,i) return true end}
local siemens=loadcard(259405917)
assert(siemens.movezones(0,0)==2,'Own destination must follow a co-linked monster arrow')
assert(siemens.movezones(1,0)==8,'Opponent destination must use its own field orientation')
assert(siemens.movefilter({GetControler=function() return 1 end},0),'Opponent monsters may move')
Duel.CheckLocation=function(p,loc,i) return i~=3 end
assert(not siemens.movefilter({GetControler=function() return 1 end},0),'Occupied pointed zone cannot be used')
Duel.CheckLocation=function() return true end
local moved,selector
local victim={GetControler=function() return 1 end}
Duel.Hint=function() end
Duel.SelectMatchingCard=function() return {GetFirst=function() return victim end} end
Duel.SelectDisableField=function(tp,n,own,opponent,mask)
 assert(own==0 and opponent==LOCATION_MZONE,'Opponent movement selects an opponent zone')
 assert((~mask)&(8<<16)~=0,'Only the pointed free destination should be selectable')
 return 8<<16
end
Duel.MoveSequence=function(c,seq) assert(c==victim) moved=seq end
siemens.effop2({},0)
assert(moved==3,'Opponent destination bit must map back to its sequence')
local captured
victim.IsRelateToEffect=function() return true end
victim.IsControlerCanBeChanged=function() return true end
Duel.GetFirstTarget=function() return victim end
Duel.SelectDisableField=function() return 2 end
Duel.GetControl=function(...) captured={...} end
siemens.effop3({},0)
assert(captured[5]==1 and captured[6]==2,'Control transfer must receive player count and explicit destination mask')
print('PASS: Siemens own/opponent movement, occupied destinations, selection orientation and control zone arguments')
-- Test every copy of the shared spread implementation.
local function group(items)
 local g=items or {}
 function g:IsContains(c) for _,v in ipairs(self) do if c==v then return true end end return false end
 function g:AddCard(c) if not self:IsContains(c) then table.insert(self,c) end end
 return g
end
Group={CreateGroup=function() return group() end}
TYPE_LINK=0x4000000
for _,code in ipairs({259174227,259726853,259650132,259107906,259881255}) do
 local card=loadcard(code)
 local function node(counter,blocked)
  local n={counter=counter or 0,attempts=0,links=group(),mutual=group()}
  function n:IsType(t) return true end
  function n:GetLinkedGroup() return self.links end
  function n:GetMutualLinkedGroup() return self.mutual end
  function n:GetCounter(t) return self.counter end
  function n:AddCounter(t,n) self.attempts=self.attempts+1 if not blocked then self.counter=self.counter+n end end
  return n
 end
 local function connect(a,b) a.mutual:AddCard(b) b.mutual:AddCard(a) end
 local source={};local a,b,c,d=node(3),node(),node(),node()
 a.links:AddCard(source);connect(a,b);connect(b,c);connect(c,a);connect(b,d)
 Duel.GetMatchingGroup=function() return group({a}) end
 local placed,n=card.spreadcurrent(source,0)
 assert(n==4 and #placed==4,'Cycle and branch must both be traversed: '..code)
 for _,v in ipairs({a,b,c,d}) do assert(v.attempts==1,'Each recipient receives only one counter') end
 assert(a.counter==4,'Existing counters do not count as already visited this resolution')
 local blocked=node(0,true);local nextnode=node();connect(blocked,nextnode)
 Duel.GetMatchingGroup=function() return group({blocked}) end
 local p,count=card.spreadcurrent(source,0)
 assert(count==0 and nextnode.attempts==0,'A failed counter placement must not propagate or loop')
end
print('PASS: all five spread scripts handle a cycle, a branch, existing counters and blocked placement')
local carcel=loadcard(259033429)
RESET_EVENT=1;RESETS_STANDARD=2;RESET_PHASE=4;PHASE_END=8
local received={}
local opponent={GetLink=function() return 2 end,AddCounter=function(self,t,n) received.opponent=n end,IsControler=function() return false end}
local boss={GetMutualLinkedGroupCount=function() return 1 end,GetMutualLinkedGroup=function() return {opponent} end,
 GetFlagEffect=function() return 0 end,RegisterFlagEffect=function() end,
 AddCounter=function(self,t,n) received.boss=n end}
Duel.GetFlagEffect=function() return 0 end;Duel.RegisterFlagEffect=function() end
carcel.adjustop({GetHandler=function() return boss end},0)
assert(received.boss==2 and received.opponent==2,'Carcel must place counters on both itself and an opponent co-linked monster')
print('PASS: Carcel includes an opponent co-linked monster in both rating total and counter recipients')
