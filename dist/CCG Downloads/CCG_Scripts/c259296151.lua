--Aerocat Blast Fist
--Omega references: Xyz Encore (c78610936), Pot of Acquisitiveness (c64014615)
local s,id=GetID()
local MSG_ID=133296151
function s.initial_effect(c)
 local e=Effect.CreateEffect(c); e:SetCategory(CATEGORY_DESTROY+CATEGORY_TODECK)
 e:SetDescription(aux.Stringid(MSG_ID,0))
 e:SetType(EFFECT_TYPE_ACTIVATE); e:SetCode(EVENT_FREE_CHAIN); e:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH)
 e:SetCost(s.cost); e:SetTarget(s.tg); e:SetOperation(s.op); c:RegisterEffect(e)
end
function s.xf(c) return c:IsFaceup() and c:IsType(TYPE_XYZ) and c:IsRank(6) and c:GetOverlayCount()>0 end
function s.df(c) return c:IsMonster() and c:IsDestructable() end
function s.cost(e,tp,eg,ep,ev,re,r,rp,chk)
 local g=Duel.GetMatchingGroup(s.xf,tp,LOCATION_MZONE,0,nil)
 local max=math.min(g:GetSum(Card.GetOverlayCount),Duel.GetMatchingGroupCount(s.df,tp,0,LOCATION_MZONE,nil))
 if chk==0 then return max>0 end
 local nums={} for i=1,max do nums[#nums+1]=i end
 local n=Duel.AnnounceNumber(tp,table.unpack(nums)); e:SetLabel(n)
 local left=n
 while left>0 do
  local xg=Duel.GetMatchingGroup(s.xf,tp,LOCATION_MZONE,0,nil)
  Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVEXYZ)
  local xc=xg:Select(tp,1,1,nil):GetFirst()
  local lim=math.min(left,xc:GetOverlayCount()); local take=lim
  if lim>1 then local opts={} for i=1,lim do opts[#opts+1]=i end take=Duel.AnnounceNumber(tp,table.unpack(opts)) end
  xc:RemoveOverlayCard(tp,take,take,REASON_COST); left=left-take
 end
end
function s.tg(e,tp,eg,ep,ev,re,r,rp,chk) local n=e:GetLabel() if chk==0 then return Duel.GetMatchingGroupCount(s.df,tp,0,LOCATION_MZONE,nil)>=n end Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,n,1-tp,LOCATION_MZONE) end
function s.one(c) return c:IsFaceup() and c:IsType(TYPE_XYZ) and c:GetOverlayCount()==1 end
function s.gyf(c) return c:IsAbleToDeck() end
function s.op(e,tp)
 local n=e:GetLabel(); local g=Duel.GetMatchingGroup(s.df,tp,0,LOCATION_MZONE,nil)
 if #g<n then return end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY); local dg=g:Select(tp,n,n,nil)
 if Duel.Destroy(dg,REASON_EFFECT)~=n then return end
 local ct=Duel.GetMatchingGroupCount(s.one,tp,LOCATION_MZONE,0,nil)
 if ct>0 and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.gyf),tp,0,LOCATION_GRAVE,1,nil) and Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,1)) then
  Duel.BreakEffect(); Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK)
  local rg=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.gyf),tp,0,LOCATION_GRAVE,1,ct,nil); Duel.SendtoDeck(rg,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)
 end
end
