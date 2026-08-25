from __future__ import annotations

from pathlib import Path
from textwrap import dedent


ROOT = Path(__file__).resolve().parents[1]
OUT = ROOT / "public" / "CCG Downloads" / "CCG_Scripts"


SCRIPTS: dict[int, str] = {}


def add(card_id: int, source: str) -> None:
    SCRIPTS[card_id] = dedent(source).strip() + "\n"


add(259391738, r'''
--Aerocat Recon
--Omega references: Reinforcement of the Army (c32807846), Pot of Acquisitiveness (c64014615)
local s,id=GetID()
local MSG_ID=133391738
local SET_AEROCAT=0x3de1
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c)
 e1:SetDescription(aux.Stringid(MSG_ID,0))
 e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH)
 e1:SetType(EFFECT_TYPE_ACTIVATE); e1:SetCode(EVENT_FREE_CHAIN); e1:SetCountLimit(1,id)
 e1:SetTarget(s.thtg); e1:SetOperation(s.thop); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c)
 e2:SetDescription(aux.Stringid(MSG_ID,1))
 e2:SetCategory(CATEGORY_TODECK+CATEGORY_DRAW)
 e2:SetType(EFFECT_TYPE_IGNITION); e2:SetRange(LOCATION_GRAVE); e2:SetProperty(EFFECT_FLAG_CARD_TARGET)
 e2:SetCountLimit(1,id+100); e2:SetCost(aux.bfgcost); e2:SetTarget(s.tdtg); e2:SetOperation(s.tdop); c:RegisterEffect(e2)
end
function s.af(c) return c:IsSetCard(SET_AEROCAT) and c:IsType(TYPE_MONSTER) and c:IsAbleToHand() end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.af),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,nil) end Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK+LOCATION_GRAVE) end
function s.thop(e,tp) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND) local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.af),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,1,nil) if #g>0 then Duel.SendtoHand(g,nil,REASON_EFFECT); Duel.ConfirmCards(1-tp,g) end end
function s.rdf(c,e) return c~=e:GetHandler() and c:IsSetCard(SET_AEROCAT) and c:IsAbleToDeck() and (c:IsLocation(LOCATION_REMOVED) or aux.NecroValleyFilter(Card.IsAbleToDeck)(c,e)) end
function s.one(c) return c:IsFaceup() and c:IsType(TYPE_XYZ) and c:GetOverlayCount()==1 end
function s.tdtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc) if chkc then return s.rdf(chkc,e) end if chk==0 then return Duel.IsExistingTarget(s.rdf,tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,nil,e) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK) local g=Duel.SelectTarget(tp,s.rdf,tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,3,nil,e) Duel.SetOperationInfo(0,CATEGORY_TODECK,g,#g,0,0) end
function s.tdop(e,tp) local g=Duel.GetTargetCards(e):Filter(s.rdf,nil,e) if #g>0 and Duel.SendtoDeck(g,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)>0 and Duel.IsExistingMatchingCard(s.one,tp,LOCATION_MZONE,0,1,nil) and Duel.IsPlayerCanDraw(tp,1) and Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,2)) then Duel.BreakEffect(); Duel.Draw(tp,1,REASON_EFFECT) end end
''')

add(259296151, r'''
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
''')

add(259687425, r'''
--Retaliation Rebound
--Omega references: Solemn Judgment (c41420027), Infinite Impermanence (c10045474)
local s,id=GetID()
function s.initial_effect(c)
 local e=Effect.CreateEffect(c); e:SetCategory(CATEGORY_NEGATE); e:SetType(EFFECT_TYPE_ACTIVATE); e:SetCode(EVENT_CHAINING)
 e:SetCondition(s.con); e:SetTarget(s.tg); e:SetOperation(s.op); c:RegisterEffect(e)
 local e2=Effect.CreateEffect(c); e2:SetType(EFFECT_TYPE_SINGLE); e2:SetCode(EFFECT_TRAP_ACT_IN_HAND); e2:SetCondition(s.handcon); c:RegisterEffect(e2)
end
function s.handcon(e) return Duel.GetTurnPlayer()==e:GetHandlerPlayer() end
function s.con(e,tp,eg,ep,ev,re,r,rp)
 if rp~=1-tp or not Duel.IsChainNegatable(ev) or Duel.GetFieldGroupCount(tp,LOCATION_ONFIELD,0)>=Duel.GetFieldGroupCount(tp,0,LOCATION_ONFIELD) then return false end
 local code=re:GetCode()
 local negsummon=re:IsHasCategory(CATEGORY_DISABLE_SUMMON) and (code==EVENT_SUMMON or code==EVENT_FLIP_SUMMON or code==EVENT_SPSUMMON)
 if negsummon then return true end
 if ev<=1 or not (re:IsHasCategory(CATEGORY_NEGATE) or re:IsHasCategory(CATEGORY_DISABLE)) then return false end
 return Duel.GetChainInfo(ev-1,CHAININFO_TRIGGERING_PLAYER)==tp
end
function s.tg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end Duel.SetOperationInfo(0,CATEGORY_NEGATE,eg,1,0,0) end
function s.op(e,tp,eg,ep,ev) Duel.NegateActivation(ev) end
''')

add(259100752, r'''
--Pot of Rage
--Omega references: Supply Squad (c17626381), Morale Boost (c93671934)
local s,id=GetID()
function s.initial_effect(c)
 if not s.global_check then s.global_check=true
  local ge=Effect.CreateEffect(c); ge:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS); ge:SetCode(EVENT_DESTROYED); ge:SetOperation(s.count); Duel.RegisterEffect(ge,0)
  local ge2=ge:Clone(); ge2:SetCode(EVENT_REMOVE); Duel.RegisterEffect(ge2,0)
 end
 local e=Effect.CreateEffect(c); e:SetCategory(CATEGORY_DRAW); e:SetType(EFFECT_TYPE_ACTIVATE); e:SetCode(EVENT_FREE_CHAIN); e:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH); e:SetTarget(s.tg); e:SetOperation(s.op); c:RegisterEffect(e)
end
function s.count(e,tp,eg) for p=0,1 do local n=eg:FilterCount(function(c,p) return c:IsReason(REASON_EFFECT) and c:GetReasonPlayer()==1-p and (c:GetPreviousControler()==p or c:GetOwner()==p) end,nil,p) if n>0 then local old=Duel.GetFlagEffectLabel(p,id) or 0; Duel.ResetFlagEffect(p,id); Duel.RegisterFlagEffect(p,id,RESET_PHASE+PHASE_END,0,1,old+n) end end end
function s.tg(e,tp,eg,ep,ev,re,r,rp,chk) local n=math.floor((Duel.GetFlagEffectLabel(tp,id) or 0)/2) if chk==0 then return n>0 and Duel.IsPlayerCanDraw(tp,n) end Duel.SetTargetPlayer(tp); Duel.SetTargetParam(n); Duel.SetOperationInfo(0,CATEGORY_DRAW,nil,0,tp,n) end
function s.op(e,tp) local p,n=Duel.GetChainInfo(0,CHAININFO_TARGET_PLAYER,CHAININFO_TARGET_PARAM); Duel.Draw(p,n,REASON_EFFECT) end
''')

add(259928966, r'''
--Pot of Longevity
--Omega references: Number 60: Dugares the Timeless (c66011101), Time-Tearing Morganite (c19403423)
local s,id=GetID()
function s.initial_effect(c)
 local e=Effect.CreateEffect(c); e:SetType(EFFECT_TYPE_ACTIVATE); e:SetCode(EVENT_FREE_CHAIN); e:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH); e:SetOperation(s.op); c:RegisterEffect(e)
end
function s.op(e,tp)
 local c=e:GetHandler()
 local e1=Effect.CreateEffect(c); e1:SetType(EFFECT_TYPE_FIELD); e1:SetCode(EFFECT_DRAW_COUNT); e1:SetProperty(EFFECT_FLAG_PLAYER_TARGET); e1:SetTargetRange(1,0); e1:SetValue(3); e1:SetReset(RESET_PHASE+PHASE_DRAW+RESET_SELF_TURN,1); Duel.RegisterEffect(e1,tp)
 local e2=Effect.CreateEffect(c); e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS); e2:SetCode(EVENT_DRAW); e2:SetCondition(s.drawcon); e2:SetOperation(s.drawop); e2:SetReset(RESET_PHASE+PHASE_DRAW+RESET_SELF_TURN,1); Duel.RegisterEffect(e2,tp)
end
function s.drawcon(e,tp,eg) return Duel.GetTurnPlayer()==tp and Duel.GetCurrentPhase()==PHASE_DRAW and #eg==3 and eg:FilterCount(Card.IsReason,nil,REASON_RULE)==3 end
function s.drawop(e,tp)
 local c=e:GetHandler()
 local ex=Effect.CreateEffect(c); ex:SetType(EFFECT_TYPE_FIELD); ex:SetCode(EFFECT_SKIP_BP); ex:SetProperty(EFFECT_FLAG_PLAYER_TARGET); ex:SetTargetRange(1,0); ex:SetReset(RESET_PHASE+PHASE_BATTLE+RESET_SELF_TURN,1); Duel.RegisterEffect(ex,tp)
 if Duel.GetFieldGroupCount(tp,LOCATION_ONFIELD,0)>Duel.GetFieldGroupCount(tp,0,LOCATION_ONFIELD) and Duel.GetFieldGroupCount(tp,LOCATION_HAND,0)>0 then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK); local g=Duel.SelectMatchingCard(tp,Card.IsAbleToDeck,tp,LOCATION_HAND,0,1,1,nil); Duel.SendtoDeck(g,nil,SEQ_DECKBOTTOM,REASON_EFFECT) end
end
''')

add(259295979, r'''
--Land of the Pyre
--Omega references: Offerings to the Doomed (c19230407), Return of the Dragon Lords (c06853254)
local s,id=GetID()
function s.initial_effect(c)
 local e=Effect.CreateEffect(c); e:SetCategory(CATEGORY_DESTROY); e:SetType(EFFECT_TYPE_ACTIVATE); e:SetCode(EVENT_FREE_CHAIN); e:SetProperty(EFFECT_FLAG_CARD_TARGET); e:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH); e:SetTarget(s.tg); e:SetOperation(s.op); c:RegisterEffect(e)
 local e2=Effect.CreateEffect(c); e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS); e2:SetCode(EFFECT_DESTROY_REPLACE); e2:SetRange(LOCATION_GRAVE); e2:SetTarget(s.reptg); e2:SetValue(s.repval); e2:SetOperation(s.repop); c:RegisterEffect(e2)
end
function s.pyro(c) return c:IsFaceup() and c:IsRace(RACE_PYRO) end
function s.opp(c) return c:IsDestructable() end
function s.tg(e,tp,eg,ep,ev,re,r,rp,chk,chkc) if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and s.pyro(chkc) or chkc:IsControler(1-tp) and chkc:IsLocation(LOCATION_ONFIELD) and s.opp(chkc) end if chk==0 then return Duel.IsExistingTarget(s.pyro,tp,LOCATION_MZONE,0,1,nil) and Duel.IsExistingTarget(s.opp,tp,0,LOCATION_ONFIELD,1,nil) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY); local a=Duel.SelectTarget(tp,s.pyro,tp,LOCATION_MZONE,0,1,1,nil); Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY); local b=Duel.SelectTarget(tp,s.opp,tp,0,LOCATION_ONFIELD,1,1,nil); a:Merge(b); Duel.SetOperationInfo(0,CATEGORY_DESTROY,a,2,0,0) end
function s.op(e) local g=Duel.GetTargetCards(e):Filter(Card.IsRelateToEffect,nil,e); Duel.Destroy(g,REASON_EFFECT) end
function s.repfilter(c,tp) return c:IsFaceup() and c:IsControler(tp) and c:IsLocation(LOCATION_MZONE) and c:IsRace(RACE_PYRO) and c:IsReason(REASON_BATTLE+REASON_EFFECT) and not c:IsReason(REASON_REPLACE) end
function s.reptg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return eg:IsExists(s.repfilter,1,nil,tp) and e:GetHandler():IsAbleToRemove() end return Duel.SelectYesNo(tp,96) end
function s.repval(e,c) return s.repfilter(c,e:GetHandlerPlayer()) end
function s.repop(e) Duel.Remove(e:GetHandler(),POS_FACEUP,REASON_EFFECT+REASON_REPLACE) end
''')

add(259758294, r'''
--Ashened Face Off
--Omega references: Fire Formation - Tenki (c57103969), Salamangreat Balelynx (c14812471)
local s,id=GetID(); local SET_ASHENED=0x1ad
function s.initial_effect(c)
 Duel.AddCustomActivityCounter(id,ACTIVITY_SPSUMMON,s.spactivity)
 local e=Effect.CreateEffect(c); e:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH); e:SetType(EFFECT_TYPE_ACTIVATE); e:SetCode(EVENT_FREE_CHAIN); e:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH); e:SetTarget(s.thtg); e:SetOperation(s.thop); c:RegisterEffect(e)
 local e2=Effect.CreateEffect(c); e2:SetType(EFFECT_TYPE_FIELD); e2:SetCode(EFFECT_CHANGE_RACE); e2:SetRange(LOCATION_SZONE); e2:SetTargetRange(0,LOCATION_MZONE); e2:SetCondition(function() return Duel.GetTurnPlayer()==1-c:GetControler() end); e2:SetTarget(function(e,c) return c:IsFaceup() and c:IsSummonType(SUMMON_TYPE_SPECIAL) end); e2:SetValue(RACE_PYRO); c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c); e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS); e3:SetCode(EFFECT_DESTROY_REPLACE); e3:SetRange(LOCATION_SZONE); e3:SetCountLimit(1); e3:SetTarget(s.reptg); e3:SetValue(s.repval); e3:SetOperation(s.repop); c:RegisterEffect(e3)
end
function s.spactivity(c) return c:IsRace(RACE_PYRO) end
function s.splock(e,tp) local ex=Effect.CreateEffect(e:GetHandler()); ex:SetType(EFFECT_TYPE_FIELD); ex:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON); ex:SetProperty(EFFECT_FLAG_PLAYER_TARGET); ex:SetTargetRange(1,0); ex:SetTarget(function(e,c) return not c:IsRace(RACE_PYRO) end); ex:SetReset(RESET_PHASE+PHASE_END); Duel.RegisterEffect(ex,tp) end
function s.thf(c) return c:IsSetCard(SET_ASHENED) and c:IsAbleToHand() end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetCustomActivityCount(id,tp,ACTIVITY_SPSUMMON)==0 and Duel.IsExistingMatchingCard(s.thf,tp,LOCATION_DECK,0,1,nil) end s.splock(e,tp); Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK) end
function s.thop(e,tp) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND); local g=Duel.SelectMatchingCard(tp,s.thf,tp,LOCATION_DECK,0,1,1,nil); if #g>0 then Duel.SendtoHand(g,nil,REASON_EFFECT); Duel.ConfirmCards(1-tp,g) end end
function s.rf(c,tp) return c:IsFaceup() and c:IsControler(tp) and c:IsLocation(LOCATION_MZONE) and c:IsSetCard(SET_ASHENED) and c:IsReason(REASON_BATTLE+REASON_EFFECT) and not c:IsReason(REASON_REPLACE) end
function s.costf(c) return c:IsRace(RACE_PYRO) and c:IsAttribute(ATTRIBUTE_DARK) and c:IsAbleToRemove() end
function s.reptg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return eg:IsExists(s.rf,1,nil,tp) and Duel.IsExistingMatchingCard(s.costf,tp,LOCATION_GRAVE,0,1,nil) end if not Duel.SelectYesNo(tp,96) then return false end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE); local g=Duel.SelectMatchingCard(tp,s.costf,tp,LOCATION_GRAVE,0,1,1,nil); Duel.Remove(g,POS_FACEUP,REASON_EFFECT+REASON_REPLACE); return true end
function s.repval(e,c) return s.rf(c,e:GetHandlerPlayer()) end
function s.repop() end
''')

add(259253329, r'''
--Vaylantz Duality
--Omega references: Vaylantz Wars - The Place of Beginning (c13179234), Vaylantz Genesis Grand Duke (c76075139)
local s,id=GetID(); local SET_VAYLANTZ=0x17d
function s.initial_effect(c)
 local e0=Effect.CreateEffect(c); e0:SetType(EFFECT_TYPE_ACTIVATE); e0:SetCode(EVENT_FREE_CHAIN); c:RegisterEffect(e0)
 local e=Effect.CreateEffect(c); e:SetCategory(CATEGORY_DESTROY+CATEGORY_TOHAND+CATEGORY_SEARCH); e:SetType(EFFECT_TYPE_IGNITION); e:SetRange(LOCATION_SZONE); e:SetCountLimit(1,id); e:SetTarget(s.thtg); e:SetOperation(s.thop); c:RegisterEffect(e)
 local e2=Effect.CreateEffect(c); e2:SetCategory(CATEGORY_DESTROY); e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_F); e2:SetCode(EVENT_MOVE); e2:SetRange(LOCATION_SZONE); e2:SetCondition(s.mvcon); e2:SetOperation(s.mvop); c:RegisterEffect(e2)
end
function s.costf(c) return c:IsFaceup() and c:IsType(TYPE_PENDULUM) and c:IsDestructable() end
function s.thf(c) return c:IsSetCard(SET_VAYLANTZ) and c:IsAbleToHand() end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.costf,tp,LOCATION_ONFIELD,0,1,nil) and Duel.IsExistingMatchingCard(s.thf,tp,LOCATION_DECK,0,1,nil) end Duel.SetOperationInfo(0,CATEGORY_DESTROY,nil,1,tp,LOCATION_ONFIELD); Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK) end
function s.thop(e,tp) if not e:GetHandler():IsRelateToEffect(e) then return end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY); local tc=Duel.SelectMatchingCard(tp,s.costf,tp,LOCATION_ONFIELD,0,1,1,nil):GetFirst(); if tc and Duel.Destroy(tc,REASON_EFFECT)>0 then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND); local g=Duel.SelectMatchingCard(tp,s.thf,tp,LOCATION_DECK,0,1,1,nil); if #g>0 then Duel.SendtoHand(g,nil,REASON_EFFECT); Duel.ConfirmCards(1-tp,g) end end end
function s.mvcon(e,tp,eg) return not Duel.IsDamageStep() and eg:IsExists(function(c) return c:IsLocation(LOCATION_MZONE) and c:GetPreviousLocation()==LOCATION_MZONE and c:GetPreviousSequence()~=c:GetSequence() end,1,nil) end
function s.mvop(e,tp,eg) local seqs={} for tc in aux.Next(eg) do if tc:IsLocation(LOCATION_MZONE) and tc:GetPreviousLocation()==LOCATION_MZONE and tc:GetPreviousSequence()~=tc:GetSequence() then local seq=tc:GetSequence(); if tc:IsControler(tp) then seq=4-seq end; seqs[seq]=true end end local g=Duel.GetMatchingGroup(function(c,t) return t[c:GetSequence()] end,tp,0,LOCATION_ONFIELD,nil,seqs); if #g>0 then Duel.Destroy(g,REASON_EFFECT) end end
''')

add(259384841, r'''
--Divinity to Infinity
--Omega references: Transaction Rollback (c6351147)
local s,id=GetID(); local STRING_ID=133384841
function s.initial_effect(c)
 local e=Effect.CreateEffect(c); e:SetDescription(aux.Stringid(STRING_ID,0)); e:SetType(EFFECT_TYPE_ACTIVATE); e:SetCode(EVENT_FREE_CHAIN); e:SetProperty(EFFECT_FLAG_CARD_TARGET); e:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH); e:SetTarget(s.tg); e:SetOperation(s.op); c:RegisterEffect(e)
 local e2=Effect.CreateEffect(c); e2:SetType(EFFECT_TYPE_SINGLE); e2:SetCode(EFFECT_TRAP_ACT_IN_HAND); e2:SetCondition(function(e) return Duel.GetTurnPlayer()==e:GetHandlerPlayer() end); c:RegisterEffect(e2)
end
function s.filter(c) return c:IsSpellTrap() and c:GetTurnID()~=Duel.GetTurnCount() and c:IsAbleToRemove() and c:CheckActivateEffect(false,true,false)~=nil end
function s.tg(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
 if chkc then local te=e:GetLabelObject(); local tg=te and te:GetTarget(); return tg and tg(e,tp,eg,ep,ev,re,r,rp,0,chkc) end
 if chk==0 then return Duel.IsExistingTarget(s.filter,tp,0,LOCATION_GRAVE,1,nil) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE); local g=Duel.SelectTarget(tp,s.filter,tp,0,LOCATION_GRAVE,1,1,nil); local tc=g:GetFirst(); local te,ceg,cep,cev,cre,cr,crp=tc:CheckActivateEffect(false,true,true)
 Duel.ClearTargetCard(); tc:CreateEffectRelation(e); e:SetProperty(te:GetProperty()); local tg=te:GetTarget(); if tg then tg(e,tp,ceg,cep,cev,cre,cr,crp,1) end; te:SetLabelObject(e:GetLabelObject()); e:SetLabelObject(te); Duel.ClearOperationInfo(0); Duel.SetOperationInfo(0,CATEGORY_REMOVE,tc,1,0,0)
end
function s.op(e,tp,eg,ep,ev,re,r,rp) local te=e:GetLabelObject(); if not te then return end local tc=te:GetHandler(); if not tc:IsRelateToEffect(e) or Duel.Remove(tc,POS_FACEUP,REASON_EFFECT)==0 or not tc:IsLocation(LOCATION_REMOVED) then return end e:SetLabelObject(te:GetLabelObject()); local op=te:GetOperation(); if op then op(e,tp,eg,ep,ev,re,r,rp) end end
''')

add(259446105, r'''
--Aerocat Lightning Shot
--Omega references: Solemn Strike (c40605147), Madolche Promenade (c68159562)
local s,id=GetID(); local SET_AEROCAT=0x3de1; local MSG_ID=133446105
function s.initial_effect(c) local e=Effect.CreateEffect(c); e:SetDescription(aux.Stringid(MSG_ID,0)); e:SetCategory(CATEGORY_NEGATE+CATEGORY_TODECK); e:SetType(EFFECT_TYPE_ACTIVATE); e:SetCode(EVENT_CHAINING); e:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH); e:SetCondition(s.con); e:SetTarget(s.tg); e:SetOperation(s.op); c:RegisterEffect(e) end
function s.one(c) return c:IsFaceup() and c:IsType(TYPE_XYZ) and c:IsRank(6) and c:IsAttribute(ATTRIBUTE_WIND) and c:GetOverlayCount()==1 end
function s.detach(c,tp) return c:IsFaceup() and c:IsType(TYPE_XYZ) and c:IsSetCard(SET_AEROCAT) and c:CheckRemoveOverlayCard(tp,1,REASON_EFFECT) end
function s.con(e,tp,eg,ep,ev,re,r,rp) return rp==1-tp and Duel.IsChainNegatable(ev) and Duel.IsExistingMatchingCard(s.one,tp,LOCATION_MZONE,0,1,nil) end
function s.tg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end Duel.SetOperationInfo(0,CATEGORY_NEGATE,eg,1,0,0) end
function s.op(e,tp,eg,ep,ev,re) if not Duel.NegateActivation(ev) then return end local g=Duel.GetMatchingGroup(s.detach,tp,LOCATION_MZONE,0,nil,tp); if #g>0 and Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,1)) then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVEXYZ); local tc=g:Select(tp,1,1,nil):GetFirst(); if tc:RemoveOverlayCard(tp,1,1,REASON_EFFECT)>0 then local rc=re:GetHandler(); if rc:IsRelateToEffect(re) then Duel.SendtoDeck(rc,nil,SEQ_DECKSHUFFLE,REASON_EFFECT) end end end end
''')

add(259187643, r'''
--World Legacy Calamities
--Omega references: World Legacy Succession (c99674361), World Legacy Pawns (c89320376)
local s,id=GetID(); local SET_WORLD_LEGACY=0xfe; local SET_KRAWLER=0x104; local MSG_ID=133187643
function s.initial_effect(c)
 Duel.AddCustomActivityCounter(id,ACTIVITY_CHAIN,s.chainfilter)
 local e=Effect.CreateEffect(c); e:SetDescription(aux.Stringid(MSG_ID,0)); e:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH+CATEGORY_TOGRAVE); e:SetType(EFFECT_TYPE_ACTIVATE); e:SetCode(EVENT_FREE_CHAIN); e:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH); e:SetTarget(s.acttg); e:SetOperation(s.actop); c:RegisterEffect(e)
 local e2=Effect.CreateEffect(c); e2:SetDescription(aux.Stringid(MSG_ID,1)); e2:SetCategory(CATEGORY_POSITION); e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O); e2:SetCode(EVENT_SPSUMMON_SUCCESS); e2:SetRange(LOCATION_SZONE); e2:SetProperty(EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY); e2:SetCountLimit(1,id+100); e2:SetTarget(s.postg); e2:SetOperation(s.posop); c:RegisterEffect(e2)
 local e3=e2:Clone(); e3:SetCode(EVENT_MSET); c:RegisterEffect(e3)
end
function s.chainfilter(re) return not re:IsActiveType(TYPE_SPELL+TYPE_TRAP) or re:GetHandler():IsSetCard(SET_WORLD_LEGACY) end
function s.wlf(c) return c:IsSetCard(SET_WORLD_LEGACY) and c:IsSpellTrap() and not c:IsCode(id) and (c:IsAbleToHand() or c:IsAbleToGrave()) end
function s.lock(e,tp) local ex=Effect.CreateEffect(e:GetHandler()); ex:SetType(EFFECT_TYPE_FIELD); ex:SetCode(EFFECT_CANNOT_ACTIVATE); ex:SetProperty(EFFECT_FLAG_PLAYER_TARGET); ex:SetTargetRange(1,0); ex:SetValue(function(e,re) return re:IsActiveType(TYPE_SPELL+TYPE_TRAP) and not re:GetHandler():IsSetCard(SET_WORLD_LEGACY) end); ex:SetReset(RESET_PHASE+PHASE_END); Duel.RegisterEffect(ex,tp) end
function s.acttg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetCustomActivityCount(id,tp,ACTIVITY_CHAIN)==0 and Duel.IsExistingMatchingCard(s.wlf,tp,LOCATION_DECK,0,1,nil) end s.lock(e,tp) end
function s.actop(e,tp) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SELECT); local g=Duel.SelectMatchingCard(tp,s.wlf,tp,LOCATION_DECK,0,1,1,nil); local tc=g:GetFirst(); if not tc then return end local op=0; if tc:IsAbleToHand() and tc:IsAbleToGrave() then op=Duel.SelectOption(tp,1190,1191) elseif tc:IsAbleToGrave() then op=1 end if op==0 then Duel.SendtoHand(tc,nil,REASON_EFFECT); Duel.ConfirmCards(1-tp,tc) else Duel.SendtoGrave(tc,REASON_EFFECT) end end
function s.pf(c) return c:IsFacedown() and c:IsCanChangePosition() end
function s.postg(e,tp,eg,ep,ev,re,r,rp,chk,chkc) if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and s.pf(chkc) end if chk==0 then return Duel.IsExistingTarget(s.pf,tp,LOCATION_MZONE,0,1,nil) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_POSCHANGE); local g=Duel.SelectTarget(tp,s.pf,tp,LOCATION_MZONE,0,1,1,nil); Duel.SetOperationInfo(0,CATEGORY_POSITION,g,1,0,0) end
function s.posop(e,tp) local tc=Duel.GetFirstTarget(); if tc:IsRelateToEffect(e) and Duel.ChangePosition(tc,POS_FACEUP_DEFENSE)>0 and not tc:IsSetCard(SET_KRAWLER) then local ex=Effect.CreateEffect(e:GetHandler()); ex:SetType(EFFECT_TYPE_SINGLE); ex:SetCode(EFFECT_CANNOT_TRIGGER); ex:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END); tc:RegisterEffect(ex) end end
''')

add(259181235, r'''
--World Legacy Crusadia Counter
--Omega references: Dogmatika Punishment (c82956214), Crusadia Krawler (c55838342)
local s,id=GetID(); local SET_WORLD_LEGACY=0xfe; local SET_CRUSADIA=0x116
function s.initial_effect(c)
 Duel.AddCustomActivityCounter(id,ACTIVITY_CHAIN,s.chainfilter)
 local e=Effect.CreateEffect(c); e:SetCategory(CATEGORY_NEGATE+CATEGORY_DESTROY); e:SetType(EFFECT_TYPE_ACTIVATE); e:SetCode(EVENT_CHAINING); e:SetCountLimit(1,id); e:SetCondition(s.con); e:SetTarget(s.tg); e:SetOperation(s.op); c:RegisterEffect(e)
 local e2=Effect.CreateEffect(c); e2:SetType(EFFECT_TYPE_SINGLE); e2:SetCode(EFFECT_TRAP_ACT_IN_HAND); e2:SetCondition(function(e) return not Duel.IsExistingMatchingCard(Card.IsFaceup,e:GetHandlerPlayer(),LOCATION_ONFIELD,0,1,nil) end); c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c); e3:SetCategory(CATEGORY_SPECIAL_SUMMON); e3:SetType(EFFECT_TYPE_IGNITION); e3:SetRange(LOCATION_GRAVE); e3:SetCountLimit(1,id); e3:SetCost(aux.bfgcost); e3:SetTarget(s.sptg); e3:SetOperation(s.spop); c:RegisterEffect(e3)
end
function s.chainfilter(re) return not re:IsActiveType(TYPE_SPELL+TYPE_TRAP) or re:GetHandler():IsSetCard(SET_WORLD_LEGACY) or re:GetHandler():IsSetCard(SET_CRUSADIA) end
function s.con(e,tp,eg,ep,ev,re,r,rp) local rc=re:GetHandler(); return rc:IsType(TYPE_LINK) and rc:IsLocation(LOCATION_MZONE) and rc:GetSequence()>4 and Duel.IsChainNegatable(ev) end
function s.exf(c,atk) return c:IsType(TYPE_LINK) and c:IsAttackAbove(atk+1) end
function s.tg(e,tp,eg,ep,ev,re,r,rp,chk) local rc=re:GetHandler(); if chk==0 then return Duel.IsExistingMatchingCard(s.exf,tp,LOCATION_EXTRA,0,1,nil,rc:GetAttack()) end e:SetLabel(rc:GetAttack(),rc:GetLink()); Duel.SetOperationInfo(0,CATEGORY_NEGATE,eg,1,0,0) end
function s.op(e,tp,eg,ep,ev,re) local atk,link=e:GetLabel(); local g=Duel.GetMatchingGroup(s.exf,tp,LOCATION_EXTRA,0,nil,atk); if #g==0 then return end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_CONFIRM); local tc=g:Select(tp,1,1,nil):GetFirst(); Duel.ConfirmCards(1-tp,tc); Duel.ShuffleExtra(tp); if Duel.NegateEffect(ev) and re:GetHandler():IsRelateToEffect(re) and tc:GetLink()<link then Duel.Destroy(re:GetHandler(),REASON_EFFECT) end end
function s.wlm(c,e,tp) return c:IsSetCard(SET_WORLD_LEGACY) and c:IsType(TYPE_MONSTER) and c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEUP_DEFENSE) end
function s.stlock(e,tp) local ex=Effect.CreateEffect(e:GetHandler()); ex:SetType(EFFECT_TYPE_FIELD); ex:SetCode(EFFECT_CANNOT_ACTIVATE); ex:SetProperty(EFFECT_FLAG_PLAYER_TARGET); ex:SetTargetRange(1,0); ex:SetValue(function(e,re) return re:IsActiveType(TYPE_SPELL+TYPE_TRAP) and not (re:GetHandler():IsSetCard(SET_WORLD_LEGACY) or re:GetHandler():IsSetCard(SET_CRUSADIA)) end); ex:SetReset(RESET_PHASE+PHASE_END); Duel.RegisterEffect(ex,tp) end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetCustomActivityCount(id,tp,ACTIVITY_CHAIN)==0 and Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and Duel.IsExistingMatchingCard(s.wlm,tp,LOCATION_DECK,0,1,nil,e,tp) end s.stlock(e,tp); Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_DECK) end
function s.spop(e,tp) if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON); local g=Duel.SelectMatchingCard(tp,s.wlm,tp,LOCATION_DECK,0,1,1,nil,e,tp); if #g>0 then Duel.SpecialSummon(g,0,tp,tp,false,false,POS_FACEUP_DEFENSE) end end
''')

add(259024242, r'''
--Devotee of the Pyre
--Omega references: Scapegoat (c73915051), Return of the Dragon Lords (c06853254)
local s,id=GetID(); local MSG_ID=133024242; local SET_PYRE=0x3135; local TOKEN_PYRE=239823001; local LORD=259542408
function s.initial_effect(c)
 aux.AddCodeList(c,259542408)
 local e=Effect.CreateEffect(c); e:SetCategory(CATEGORY_TOGRAVE+CATEGORY_TOKEN+CATEGORY_SPECIAL_SUMMON+CATEGORY_TOHAND+CATEGORY_SEARCH); e:SetType(EFFECT_TYPE_ACTIVATE); e:SetCode(EVENT_FREE_CHAIN); e:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH); e:SetCost(s.cost); e:SetTarget(s.tg); e:SetOperation(s.op); c:RegisterEffect(e)
 local e2=Effect.CreateEffect(c); e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS); e2:SetCode(EFFECT_DESTROY_REPLACE); e2:SetRange(LOCATION_GRAVE); e2:SetTarget(s.reptg); e2:SetValue(s.repval); e2:SetOperation(s.repop); c:RegisterEffect(e2)
end
s.listed_names={259542408}
function s.cf(c) return c:IsRace(RACE_PYRO) and c:IsAbleToGraveAsCost() end
function s.cost(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.cf,tp,LOCATION_HAND+LOCATION_MZONE,0,1,nil) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE); local g=Duel.SelectMatchingCard(tp,s.cf,tp,LOCATION_HAND+LOCATION_MZONE,0,1,1,nil); Duel.SendtoGrave(g,REASON_COST) end
function s.search(c) return c:IsSetCard(SET_PYRE) and c:IsSpell() and c:IsAbleToHand() end
function s.tg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>1 and Duel.IsPlayerCanSpecialSummonMonster(tp,239823001,SET_PYRE,TYPES_TOKEN,0,0,1,RACE_PYRO,ATTRIBUTE_FIRE) end Duel.SetOperationInfo(0,CATEGORY_TOKEN,nil,2,tp,0) end
function s.lord(c) return c:IsFaceup() and c:IsCode(LORD) end
function s.op(e,tp) if Duel.GetLocationCount(tp,LOCATION_MZONE)<2 or not Duel.IsPlayerCanSpecialSummonMonster(tp,TOKEN_PYRE,SET_PYRE,TYPES_TOKEN,0,0,1,RACE_PYRO,ATTRIBUTE_FIRE) then return end for i=1,2 do local tc=Duel.CreateToken(tp,TOKEN_PYRE); Duel.SpecialSummonStep(tc,0,tp,tp,false,false,POS_FACEUP); local ex=Effect.CreateEffect(e:GetHandler()); ex:SetType(EFFECT_TYPE_SINGLE); ex:SetCode(EFFECT_UNRELEASABLE_SUM); ex:SetValue(function(e,c) return not c:IsRace(RACE_PYRO) end); ex:SetReset(RESET_EVENT+RESETS_STANDARD); tc:RegisterEffect(ex); local exn=ex:Clone(); exn:SetCode(EFFECT_UNRELEASABLE_NONSUM); exn:SetValue(1); tc:RegisterEffect(exn); local ex2=Effect.CreateEffect(e:GetHandler()); ex2:SetType(EFFECT_TYPE_SINGLE); ex2:SetCode(EFFECT_CANNOT_BE_LINK_MATERIAL); ex2:SetValue(function(e,c) return not c:IsRace(RACE_PYRO) end); ex2:SetReset(RESET_EVENT+RESETS_STANDARD); tc:RegisterEffect(ex2) end Duel.SpecialSummonComplete(); if Duel.IsExistingMatchingCard(s.lord,tp,LOCATION_MZONE,0,1,nil) and Duel.IsExistingMatchingCard(s.search,tp,LOCATION_DECK,0,1,nil) and Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,0)) then Duel.BreakEffect(); Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND); local g=Duel.SelectMatchingCard(tp,s.search,tp,LOCATION_DECK,0,1,1,nil); Duel.SendtoHand(g,nil,REASON_EFFECT); Duel.ConfirmCards(1-tp,g) end end
function s.rf(c,tp) return c:IsFaceup() and c:IsControler(tp) and c:IsLocation(LOCATION_MZONE) and c:IsRace(RACE_PYRO) and c:IsReason(REASON_BATTLE+REASON_EFFECT) and not c:IsReason(REASON_REPLACE) end
function s.reptg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return eg:IsExists(s.rf,1,nil,tp) and e:GetHandler():IsAbleToRemove() end return Duel.SelectYesNo(tp,96) end
function s.repval(e,c) return s.rf(c,e:GetHandlerPlayer()) end
function s.repop(e) Duel.Remove(e:GetHandler(),POS_FACEUP,REASON_EFFECT+REASON_REPLACE) end
''')

add(259820516, r'''
--Expulsion of the Pyre
--Omega references: Foolish Burial Goods (c35726888), Pot of Acquisitiveness (c64014615)
local s,id=GetID(); local SET_PYRE=0x3135
function s.initial_effect(c)
 local e=Effect.CreateEffect(c); e:SetCategory(CATEGORY_TOGRAVE); e:SetType(EFFECT_TYPE_ACTIVATE); e:SetCode(EVENT_FREE_CHAIN); e:SetCountLimit(1,id); e:SetCost(s.cost); e:SetTarget(s.settg); e:SetOperation(s.setop); c:RegisterEffect(e)
 local e2=Effect.CreateEffect(c); e2:SetCategory(CATEGORY_TODECK+CATEGORY_DRAW); e2:SetType(EFFECT_TYPE_IGNITION); e2:SetRange(LOCATION_GRAVE); e2:SetProperty(EFFECT_FLAG_CARD_TARGET); e2:SetCountLimit(1,id+100); e2:SetCost(aux.bfgcost); e2:SetTarget(s.tdtg); e2:SetOperation(s.tdop); c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c); e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS); e3:SetCode(EFFECT_DESTROY_REPLACE); e3:SetRange(LOCATION_GRAVE); e3:SetTarget(s.reptg); e3:SetValue(s.repval); e3:SetOperation(s.repop); c:RegisterEffect(e3)
end
function s.cf(c) return c:IsRace(RACE_PYRO) and c:IsAbleToGraveAsCost() end
function s.cost(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.cf,tp,LOCATION_MZONE,0,1,nil) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE); local g=Duel.SelectMatchingCard(tp,s.cf,tp,LOCATION_MZONE,0,1,1,nil); Duel.SendtoGrave(g,REASON_COST) end
function s.sf(c) return c:IsSetCard(SET_PYRE) and c:IsSpell() and c:IsSSetable() end
function s.settg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.sf),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,nil) end end
function s.setop(e,tp) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SET); local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.sf),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,1,nil); if #g>0 then Duel.SSet(tp,g) end end
function s.rdf(c) return not c:IsCode(id) and (c:IsSetCard(SET_PYRE) and c:IsSpell() or c:IsRace(RACE_PYRO)) and c:IsAbleToDeck() end
function s.tdtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc) if chkc then return s.rdf(chkc) end if chk==0 then return Duel.IsExistingTarget(s.rdf,tp,LOCATION_REMOVED,0,3,nil) and Duel.IsPlayerCanDraw(tp,1) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK); local g=Duel.SelectTarget(tp,s.rdf,tp,LOCATION_REMOVED,0,3,3,nil); Duel.SetOperationInfo(0,CATEGORY_TODECK,g,3,0,0); Duel.SetOperationInfo(0,CATEGORY_DRAW,nil,0,tp,1) end
function s.tdop(e,tp) local g=Duel.GetTargetCards(e):Filter(Card.IsRelateToEffect,nil,e); if #g==3 and Duel.SendtoDeck(g,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)==3 then Duel.BreakEffect(); Duel.Draw(tp,1,REASON_EFFECT) end end
function s.rf(c,tp) return c:IsFaceup() and c:IsControler(tp) and c:IsLocation(LOCATION_MZONE) and c:IsRace(RACE_PYRO) and c:IsReason(REASON_BATTLE+REASON_EFFECT) and not c:IsReason(REASON_REPLACE) end
function s.reptg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return eg:IsExists(s.rf,1,nil,tp) and e:GetHandler():IsAbleToRemove() end return Duel.SelectYesNo(tp,96) end
function s.repval(e,c) return s.rf(c,e:GetHandlerPlayer()) end
function s.repop(e) Duel.Remove(e:GetHandler(),POS_FACEUP,REASON_EFFECT+REASON_REPLACE) end
''')

add(259542408, r'''
--Lord of the Pyre
--Omega references: Link Disciple (c32995276), Decode Talker (c01861629)
local s,id=GetID(); local SET_PYRE=0x3135
function s.initial_effect(c)
 c:EnableReviveLimit(); aux.AddLinkProcedure(c,aux.FilterBoolFunction(Card.IsRace,RACE_PYRO),2,2)
 c:SetUniqueOnField(1,0,id)
 local e1=Effect.CreateEffect(c); e1:SetType(EFFECT_TYPE_FIELD); e1:SetCode(EFFECT_UNRELEASABLE_SUM); e1:SetRange(LOCATION_MZONE); e1:SetTargetRange(LOCATION_MZONE,0); e1:SetTarget(s.protected); e1:SetValue(s.limit); c:RegisterEffect(e1)
 local e2=e1:Clone(); e2:SetCode(EFFECT_UNRELEASABLE_NONSUM); e2:SetValue(1); c:RegisterEffect(e2)
 local e3=e1:Clone(); e3:SetCode(EFFECT_CANNOT_BE_LINK_MATERIAL); c:RegisterEffect(e3)
 local e3b=Effect.CreateEffect(c); e3b:SetType(EFFECT_TYPE_FIELD); e3b:SetCode(EFFECT_CANNOT_SELECT_BATTLE_TARGET); e3b:SetRange(LOCATION_MZONE); e3b:SetTargetRange(LOCATION_MZONE,0); e3b:SetTarget(s.linked); e3b:SetValue(s.atklimit); c:RegisterEffect(e3b)
 local e4=Effect.CreateEffect(c); e4:SetType(EFFECT_TYPE_SINGLE); e4:SetCode(EFFECT_UPDATE_ATTACK); e4:SetCondition(s.atkcon); e4:SetValue(s.atkval); c:RegisterEffect(e4)
 local e5=Effect.CreateEffect(c); e5:SetType(EFFECT_TYPE_SINGLE); e5:SetCode(EFFECT_INDESTRUCTABLE_BATTLE); e5:SetCondition(s.atkcon); e5:SetValue(1); c:RegisterEffect(e5)
 local e6=Effect.CreateEffect(c); e6:SetCategory(CATEGORY_DESTROY); e6:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O); e6:SetCode(EVENT_REMOVE); e6:SetRange(LOCATION_MZONE); e6:SetProperty(EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY); e6:SetCondition(s.descon); e6:SetTarget(s.destg); e6:SetOperation(s.desop); c:RegisterEffect(e6)
end
function s.linked(e,c) return e:GetHandler():GetLinkedGroup():IsContains(c) end
function s.protected(e,c) return c==e:GetHandler() or s.linked(e,c) end
function s.limit(e,c) return not c:IsRace(RACE_PYRO) end
function s.atklimit(e,c) return c:IsRace(RACE_PYRO) end
function s.atkcon(e) return e:GetHandler():GetLinkedGroup():IsExists(Card.IsRace,1,nil,RACE_PYRO) end
function s.atkval(e) return e:GetHandler():GetLinkedGroupCount()*1000 end
function s.descon(e,tp,eg) return eg:IsExists(function(c) return c:IsSetCard(SET_PYRE) and c:IsSpell() end,1,nil) end
function s.df(c) return c:IsDestructable() end
function s.destg(e,tp,eg,ep,ev,re,r,rp,chk,chkc) if chkc then return chkc:IsControler(1-tp) and chkc:IsLocation(LOCATION_ONFIELD) and s.df(chkc) end if chk==0 then return Duel.IsExistingTarget(s.df,tp,0,LOCATION_ONFIELD,1,nil) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY); local g=Duel.SelectTarget(tp,s.df,tp,0,LOCATION_ONFIELD,1,1,nil); Duel.SetOperationInfo(0,CATEGORY_DESTROY,g,1,0,0) end
function s.desop(e) local tc=Duel.GetFirstTarget(); if tc:IsRelateToEffect(e) then Duel.Destroy(tc,REASON_EFFECT) end end
''')

add(259464064, r'''
--Egg of the Ashened Demise
--Omega references: Priestess of the Ashened City (c67660909), Salamangreat Gazelle (c26889158)
local s,id=GetID(); local SET_ASHENED=0x1ad; local OBSIDIM=3055018
function s.initial_effect(c)
 aux.AddCodeList(c,3055018)
 local e0=Effect.CreateEffect(c); e0:SetType(EFFECT_TYPE_FIELD); e0:SetCode(EFFECT_SPSUMMON_PROC); e0:SetProperty(EFFECT_FLAG_UNCOPYABLE); e0:SetRange(LOCATION_HAND); e0:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH); e0:SetCondition(function(e,c) if c==nil then return true end return Duel.IsExistingMatchingCard(Card.IsCode,c:GetControler(),LOCATION_FZONE,LOCATION_FZONE,1,nil,OBSIDIM) end); c:RegisterEffect(e0)
 local e1=Effect.CreateEffect(c); e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH); e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O); e1:SetCode(EVENT_SUMMON_SUCCESS); e1:SetProperty(EFFECT_FLAG_DELAY); e1:SetCountLimit(1,id); e1:SetTarget(s.thtg); e1:SetOperation(s.thop); c:RegisterEffect(e1); local e2=e1:Clone(); e2:SetCode(EVENT_SPSUMMON_SUCCESS); c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c); e3:SetCategory(CATEGORY_SPECIAL_SUMMON); e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O); e3:SetCode(EVENT_DESTROYED); e3:SetRange(LOCATION_GRAVE); e3:SetProperty(EFFECT_FLAG_DELAY); e3:SetCountLimit(1,id+100); e3:SetCondition(s.spcon); e3:SetTarget(s.sptg); e3:SetOperation(s.spop); c:RegisterEffect(e3)
end
s.listed_names={3055018}
function s.thf(c) return aux.IsCodeListed(c,3055018) and c:IsAbleToHand() end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.thf,tp,LOCATION_DECK,0,1,nil) end Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK) end
function s.thop(e,tp) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND); local g=Duel.SelectMatchingCard(tp,s.thf,tp,LOCATION_DECK,0,1,1,nil); if #g>0 then Duel.SendtoHand(g,nil,REASON_EFFECT); Duel.ConfirmCards(1-tp,g) end end
function s.spcon(e,tp,eg) return eg:IsExists(function(c,tp) return c:IsPreviousControler(tp) and c:IsPreviousLocation(LOCATION_MZONE) and c:IsPreviousPosition(POS_FACEUP) and c:GetPreviousRaceOnField()&RACE_PYRO~=0 and (c:IsReason(REASON_BATTLE) or c:IsReason(REASON_EFFECT) and c:GetReasonPlayer()==1-tp) end,1,nil,tp) end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and e:GetHandler():IsCanBeSpecialSummoned(e,0,tp,false,false) end Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,e:GetHandler(),1,0,0) end
function s.spop(e,tp) local c=e:GetHandler(); if Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and c:IsRelateToEffect(e) and Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)>0 then local ex=Effect.CreateEffect(c); ex:SetType(EFFECT_TYPE_FIELD); ex:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON); ex:SetProperty(EFFECT_FLAG_PLAYER_TARGET); ex:SetTargetRange(1,0); ex:SetTarget(function(e,c) return c:IsLocation(LOCATION_EXTRA) and not c:IsRace(RACE_PYRO) end); ex:SetReset(RESET_PHASE+PHASE_END); Duel.RegisterEffect(ex,tp) end end
''')

add(259454809, r'''
--Raven the Lightning II Aerocat
--Omega references: Danger! Bigfoot! (c43316238), Overlay Regen (c27068117)
local s,id=GetID(); local STRING_ID=133454809; local SET_AEROCAT=0x3de1
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c); e1:SetDescription(aux.Stringid(STRING_ID,0)); e1:SetCategory(CATEGORY_SPECIAL_SUMMON); e1:SetType(EFFECT_TYPE_IGNITION); e1:SetRange(LOCATION_HAND); e1:SetCountLimit(1,id); e1:SetCost(s.hcost); e1:SetTarget(s.selftg); e1:SetOperation(s.selfop); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetDescription(aux.Stringid(STRING_ID,1)); e2:SetCategory(CATEGORY_SPECIAL_SUMMON); e2:SetType(EFFECT_TYPE_IGNITION); e2:SetRange(LOCATION_MZONE); e2:SetCountLimit(1,id+100); e2:SetTarget(s.sptg); e2:SetOperation(s.spop); c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c); e3:SetDescription(aux.Stringid(STRING_ID,2)); e3:SetType(EFFECT_TYPE_QUICK_O); e3:SetCode(EVENT_FREE_CHAIN); e3:SetRange(LOCATION_HAND+LOCATION_GRAVE); e3:SetProperty(EFFECT_FLAG_CARD_TARGET); e3:SetCountLimit(1,id+200); e3:SetTarget(s.ovtg); e3:SetOperation(s.ovop); c:RegisterEffect(e3)
end
function s.aero(c) return c:IsSetCard(SET_AEROCAT) end
function s.hcost(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.aero,tp,LOCATION_HAND,0,1,e:GetHandler()) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_CONFIRM); local g=Duel.SelectMatchingCard(tp,s.aero,tp,LOCATION_HAND,0,1,1,e:GetHandler()); Duel.ConfirmCards(1-tp,g) end
function s.selftg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and e:GetHandler():IsCanBeSpecialSummoned(e,0,tp,false,false) end Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,e:GetHandler(),1,0,0) end
function s.selfop(e,tp) local c=e:GetHandler(); if c:IsRelateToEffect(e) then Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP) end local ex=Effect.CreateEffect(c); ex:SetType(EFFECT_TYPE_FIELD); ex:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON); ex:SetProperty(EFFECT_FLAG_PLAYER_TARGET); ex:SetTargetRange(1,0); ex:SetTarget(function(e,c) return c:IsLocation(LOCATION_EXTRA) and not c:IsType(TYPE_XYZ) end); ex:SetReset(RESET_PHASE+PHASE_END); Duel.RegisterEffect(ex,tp) end
function s.spf(c,e,tp) return c:IsSetCard(SET_AEROCAT) and c:IsType(TYPE_MONSTER) and c:IsCanBeSpecialSummoned(e,0,tp,false,false) end
function s.spgroup(tp,e) return Duel.GetMatchingGroup(s.spf,tp,LOCATION_HAND+LOCATION_GRAVE+LOCATION_OVERLAY,0,nil,e,tp) end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and #s.spgroup(tp,e)>0 end Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_HAND+LOCATION_GRAVE+LOCATION_OVERLAY) end
function s.spop(e,tp) if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end local g=s.spgroup(tp,e); if #g==0 then return end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON); local tc=g:Select(tp,1,1,nil):GetFirst(); Duel.SpecialSummon(tc,0,tp,tp,false,false,POS_FACEUP) end
function s.xyz(c) return c:IsFaceup() and c:IsType(TYPE_XYZ) and c:IsRank(6) and c:IsAttribute(ATTRIBUTE_WIND) end
function s.ovtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc) if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and s.xyz(chkc) end if chk==0 then return Duel.IsExistingTarget(s.xyz,tp,LOCATION_MZONE,0,1,nil) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_XMATERIAL); Duel.SelectTarget(tp,s.xyz,tp,LOCATION_MZONE,0,1,1,nil) end
function s.ovop(e) local c=e:GetHandler(); local tc=Duel.GetFirstTarget(); if c:IsRelateToEffect(e) and tc:IsRelateToEffect(e) then Duel.Overlay(tc,Group.FromCards(c)) end end
''')

add(259767503, r'''
--Glint the Blackbird Aerocat
--Omega references: Thunder Dragon (c31786629), Overlay Regen (c27068117)
local s,id=GetID(); local STRING_ID=133767503; local SET_AEROCAT=0x3de1
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c); e1:SetDescription(aux.Stringid(STRING_ID,0)); e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH); e1:SetType(EFFECT_TYPE_IGNITION); e1:SetRange(LOCATION_HAND); e1:SetCountLimit(1,id); e1:SetCost(s.dcost); e1:SetTarget(s.thtg); e1:SetOperation(s.thop); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetDescription(aux.Stringid(STRING_ID,1)); e2:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_ATKCHANGE); e2:SetType(EFFECT_TYPE_IGNITION); e2:SetRange(LOCATION_GRAVE); e2:SetProperty(EFFECT_FLAG_CARD_TARGET); e2:SetCountLimit(1,id+100); e2:SetTarget(s.sptg); e2:SetOperation(s.spop); c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c); e3:SetDescription(aux.Stringid(STRING_ID,2)); e3:SetType(EFFECT_TYPE_QUICK_O); e3:SetCode(EVENT_FREE_CHAIN); e3:SetRange(LOCATION_HAND+LOCATION_GRAVE); e3:SetProperty(EFFECT_FLAG_CARD_TARGET); e3:SetCountLimit(1,id+200); e3:SetTarget(s.ovtg); e3:SetOperation(s.ovop); c:RegisterEffect(e3)
end
function s.dcost(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return e:GetHandler():IsDiscardable() end Duel.SendtoGrave(e:GetHandler(),REASON_COST+REASON_DISCARD) end
function s.thf(c) return c:IsSetCard(SET_AEROCAT) and c:IsSpellTrap() and c:IsAbleToHand() end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.thf,tp,LOCATION_DECK,0,1,nil) end Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK) end
function s.thop(e,tp) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND); local g=Duel.SelectMatchingCard(tp,s.thf,tp,LOCATION_DECK,0,1,1,nil); if #g>0 then Duel.SendtoHand(g,nil,REASON_EFFECT); Duel.ConfirmCards(1-tp,g) end end
function s.af(c) return c:IsFaceup() and c:IsSetCard(SET_AEROCAT) and c:IsType(TYPE_MONSTER) end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk,chkc) if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and s.af(chkc) end if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and e:GetHandler():IsCanBeSpecialSummoned(e,0,tp,false,false) and Duel.IsExistingTarget(s.af,tp,LOCATION_MZONE,0,1,nil) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_FACEUP); Duel.SelectTarget(tp,s.af,tp,LOCATION_MZONE,0,1,1,nil); Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,e:GetHandler(),1,0,0) end
function s.spop(e,tp) local c=e:GetHandler(); local tc=Duel.GetFirstTarget(); if c:IsRelateToEffect(e) and Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP)>0 then c:RegisterFlagEffect(id,RESET_EVENT+RESETS_REDIRECT,0,1); local ex=Effect.CreateEffect(c); ex:SetType(EFFECT_TYPE_SINGLE); ex:SetCode(EFFECT_LEAVE_FIELD_REDIRECT); ex:SetValue(LOCATION_REMOVED); ex:SetReset(RESET_EVENT+RESETS_REDIRECT); c:RegisterEffect(ex); if tc:IsRelateToEffect(e) and tc:IsFaceup() then local ea=Effect.CreateEffect(c); ea:SetType(EFFECT_TYPE_SINGLE); ea:SetCode(EFFECT_UPDATE_ATTACK); ea:SetValue(500); ea:SetReset(RESET_EVENT+RESETS_STANDARD); tc:RegisterEffect(ea) end end end
function s.xyz(c) return c:IsFaceup() and c:IsType(TYPE_XYZ) and c:IsRank(6) and c:IsAttribute(ATTRIBUTE_WIND) end
function s.ovtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc) if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and s.xyz(chkc) end if chk==0 then return Duel.IsExistingTarget(s.xyz,tp,LOCATION_MZONE,0,1,nil) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_XMATERIAL); Duel.SelectTarget(tp,s.xyz,tp,LOCATION_MZONE,0,1,1,nil) end
function s.ovop(e) local c=e:GetHandler(); local tc=Duel.GetFirstTarget(); if c:IsRelateToEffect(e) and tc:IsRelateToEffect(e) then Duel.Overlay(tc,Group.FromCards(c)) end end
''')

add(259113182, r'''
--Vik the Chinook Aerocat
--Omega references: K9-04 Noroi (c47960073), Overlay Regen (c27068117)
local s,id=GetID(); local STRING_ID=133113182; local SET_AEROCAT=0x3de1
function s.initial_effect(c)
 local e0=Effect.CreateEffect(c); e0:SetDescription(aux.Stringid(STRING_ID,0)); e0:SetType(EFFECT_TYPE_SINGLE); e0:SetCode(EFFECT_SUMMON_PROC); e0:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE); e0:SetCondition(s.ntcon); e0:SetOperation(s.ntop); e0:SetValue(SUMMON_TYPE_NORMAL+1); c:RegisterEffect(e0)
 local e1=Effect.CreateEffect(c); e1:SetDescription(aux.Stringid(STRING_ID,1)); e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH); e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O); e1:SetCode(EVENT_SUMMON_SUCCESS); e1:SetProperty(EFFECT_FLAG_DELAY); e1:SetCountLimit(1,id); e1:SetTarget(s.thtg); e1:SetOperation(s.thop); c:RegisterEffect(e1); local e2=e1:Clone(); e2:SetCode(EVENT_SPSUMMON_SUCCESS); c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c); e3:SetDescription(aux.Stringid(STRING_ID,2)); e3:SetType(EFFECT_TYPE_QUICK_O); e3:SetCode(EVENT_FREE_CHAIN); e3:SetRange(LOCATION_HAND+LOCATION_GRAVE); e3:SetProperty(EFFECT_FLAG_CARD_TARGET); e3:SetCountLimit(1,id+100); e3:SetTarget(s.ovtg); e3:SetOperation(s.ovop); c:RegisterEffect(e3)
end
function s.exf(c) return c:IsSetCard(SET_AEROCAT) and c:IsType(TYPE_XYZ) and not c:IsPublic() end
function s.ntcon(e,c,minc) if c==nil then return true end return minc==0 and Duel.GetLocationCount(c:GetControler(),LOCATION_MZONE)>0 and Duel.IsExistingMatchingCard(s.exf,c:GetControler(),LOCATION_EXTRA,0,1,nil) end
function s.ntop(e,tp) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_CONFIRM); local g=Duel.SelectMatchingCard(tp,s.exf,tp,LOCATION_EXTRA,0,1,1,nil); Duel.ConfirmCards(1-tp,g) end
function s.thf(c) return c:IsSetCard(SET_AEROCAT) and c:IsType(TYPE_MONSTER) and c:IsAbleToHand() end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.thf,tp,LOCATION_DECK,0,1,nil) end Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK) end
function s.thop(e,tp) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND); local g=Duel.SelectMatchingCard(tp,s.thf,tp,LOCATION_DECK,0,1,1,nil); if #g>0 then Duel.SendtoHand(g,nil,REASON_EFFECT); Duel.ConfirmCards(1-tp,g) end end
function s.xyz(c) return c:IsFaceup() and c:IsType(TYPE_XYZ) and c:IsRank(6) and c:IsAttribute(ATTRIBUTE_WIND) end
function s.ovtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc) if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and s.xyz(chkc) end if chk==0 then return Duel.IsExistingTarget(s.xyz,tp,LOCATION_MZONE,0,1,nil) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_XMATERIAL); Duel.SelectTarget(tp,s.xyz,tp,LOCATION_MZONE,0,1,1,nil) end
function s.ovop(e) local c=e:GetHandler(); local tc=Duel.GetFirstTarget(); if c:IsRelateToEffect(e) and tc:IsRelateToEffect(e) then Duel.Overlay(tc,Group.FromCards(c)) end end
''')

add(259548744, r'''
--Navi the NAV Hawk Aerocat
--Omega references: Daigusto Emeral (c581014), Cyber Dragon Infinity (c10443957)
local s,id=GetID(); local STRING_ID=133548744
function s.initial_effect(c)
 c:EnableReviveLimit(); aux.AddXyzProcedure(c,aux.FilterBoolFunction(Card.IsRace,RACE_BEAST),6,2,nil,nil,99)
 local e1=Effect.CreateEffect(c); e1:SetDescription(aux.Stringid(STRING_ID,0)); e1:SetCategory(CATEGORY_TODECK); e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O); e1:SetCode(EVENT_SPSUMMON_SUCCESS); e1:SetProperty(EFFECT_FLAG_DELAY); e1:SetCountLimit(1,id); e1:SetCondition(function(e) return e:GetHandler():IsSummonType(SUMMON_TYPE_XYZ) end); e1:SetOperation(s.xyzop); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetDescription(aux.Stringid(STRING_ID,1)); e2:SetCategory(CATEGORY_NEGATE+CATEGORY_DESTROY); e2:SetType(EFFECT_TYPE_QUICK_O); e2:SetCode(EVENT_CHAINING); e2:SetRange(LOCATION_MZONE); e2:SetProperty(EFFECT_FLAG_DAMAGE_STEP+EFFECT_FLAG_DAMAGE_CAL); e2:SetCountLimit(1,id+100); e2:SetCondition(s.negcon); e2:SetTarget(s.negtg); e2:SetOperation(s.negop); c:RegisterEffect(e2)
end
function s.tdf(c) return c:IsAbleToDeck() end
function s.ovf(c) return c:IsAbleToOverlay() end
function s.xyzop(e,tp) local c=e:GetHandler(); local max=math.min(c:GetOverlayCount(),Duel.GetMatchingGroupCount(s.tdf,tp,LOCATION_GRAVE,LOCATION_GRAVE,nil)); if max>0 and Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,2)) then local opts={}; for i=1,max do opts[#opts+1]=i end local n=Duel.AnnounceNumber(tp,table.unpack(opts)); if c:RemoveOverlayCard(tp,n,n,REASON_EFFECT)==n then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK); local g=Duel.SelectMatchingCard(tp,s.tdf,tp,LOCATION_GRAVE,LOCATION_GRAVE,n,n,nil); Duel.SendtoDeck(g,nil,SEQ_DECKSHUFFLE,REASON_EFFECT) end end if c:IsRelateToEffect(e) and Duel.IsExistingMatchingCard(s.ovf,tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,nil) and Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,3)) then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_XMATERIAL); local g=Duel.SelectMatchingCard(tp,s.ovf,tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,1,nil); Duel.Overlay(c,g) end end
function s.one(c) return c:IsFaceup() and c:IsType(TYPE_XYZ) and c:GetOverlayCount()==1 end
function s.negcon(e,tp,eg,ep,ev,re,r,rp) return rp==1-tp and re:IsActiveType(TYPE_MONSTER) and Duel.IsChainNegatable(ev) and Duel.IsExistingMatchingCard(s.one,tp,LOCATION_MZONE,0,1,nil) end
function s.negtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end Duel.SetOperationInfo(0,CATEGORY_NEGATE,eg,1,0,0) end
function s.negop(e,tp,eg,ep,ev,re) if Duel.NegateActivation(ev) and re:GetHandler():IsRelateToEffect(re) then Duel.Destroy(re:GetHandler(),REASON_EFFECT) end end
''')

add(259615843, r'''
--Shade the Aigalon Aerocat
--Omega references: Crystal Wing Synchro Dragon (c50954680), Number 101: Silent Honor ARK (c48739166)
local s,id=GetID(); local SET_AEROCAT=0x3de1; local STRING_ID=133615843
function s.initial_effect(c)
 local e0=Effect.CreateEffect(c); e0:SetType(EFFECT_TYPE_FIELD); e0:SetCode(EFFECT_UPDATE_ATTACK); e0:SetRange(LOCATION_MZONE); e0:SetTargetRange(LOCATION_MZONE,0); e0:SetTarget(function(e,c) return c~=e:GetHandler() and c:IsSetCard(SET_AEROCAT) end); e0:SetValue(1000); c:RegisterEffect(e0)
 local e1=Effect.CreateEffect(c); e1:SetDescription(aux.Stringid(STRING_ID,0)); e1:SetCategory(CATEGORY_SPECIAL_SUMMON); e1:SetType(EFFECT_TYPE_QUICK_O); e1:SetCode(EVENT_FREE_CHAIN); e1:SetRange(LOCATION_HAND+LOCATION_GRAVE); e1:SetCountLimit(1,id); e1:SetCost(s.spcost); e1:SetTarget(s.sptg); e1:SetOperation(s.spop); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetDescription(aux.Stringid(STRING_ID,1)); e2:SetType(EFFECT_TYPE_QUICK_O); e2:SetCode(EVENT_FREE_CHAIN); e2:SetRange(LOCATION_MZONE); e2:SetProperty(EFFECT_FLAG_CARD_TARGET); e2:SetCountLimit(1,id+100); e2:SetCondition(function(e) return e:GetHandler():GetFlagEffect(id+500)==0 end); e2:SetTarget(s.ovtg); e2:SetOperation(s.ovop); c:RegisterEffect(e2)
end
function s.xf(c,tp) return c:IsFaceup() and c:IsType(TYPE_XYZ) and c:IsRank(6) and c:CheckRemoveOverlayCard(tp,1,REASON_COST) end
function s.spcost(e,tp,eg,ep,ev,re,r,rp,chk) local g=Duel.GetMatchingGroup(s.xf,tp,LOCATION_MZONE,LOCATION_MZONE,nil,tp); if chk==0 then return #g>0 end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVEXYZ); local tc=g:Select(tp,1,1,nil):GetFirst(); tc:RemoveOverlayCard(tp,1,1,REASON_COST) end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and e:GetHandler():IsCanBeSpecialSummoned(e,0,tp,false,false) end Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,e:GetHandler(),1,0,0) end
function s.spop(e,tp) local c=e:GetHandler(); if c:IsRelateToEffect(e) then Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP) end end
function s.aero(c) return c:IsFaceup() and c:IsSetCard(SET_AEROCAT) and c:IsType(TYPE_XYZ) end
function s.target(c,tp) return c:IsCanBeXyzMaterial() and (c:IsControler(tp) or c:IsAbleToChangeControler()) end
function s.ovtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc) if chkc then return chkc:IsLocation(LOCATION_ONFIELD) and s.target(chkc,tp) end if chk==0 then return Duel.IsExistingTarget(s.target,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,nil,tp) and Duel.IsExistingMatchingCard(s.aero,tp,LOCATION_MZONE,0,1,nil) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_XMATERIAL); Duel.SelectTarget(tp,s.target,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,1,nil,tp) end
function s.ovop(e,tp) local c=e:GetHandler(); local tc=Duel.GetFirstTarget(); if not tc or not tc:IsRelateToEffect(e) or (not tc:IsControler(tp) and not tc:IsAbleToChangeControler()) then return end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_XMATERIAL); local g=Duel.SelectMatchingCard(tp,s.aero,tp,LOCATION_MZONE,0,1,1,nil); local x=g:GetFirst(); if x then Duel.Overlay(x,Group.FromCards(tc)); if tc:GetOverlayTarget()==x and c:IsFaceup() and c:IsRelateToEffect(e) then c:RegisterFlagEffect(id+500,RESET_EVENT+RESETS_STANDARD,0,1) end end end
''')

add(259095349, r'''
--Goliath the Airship Aerocat
--Omega references: Number 38: Hope Harbinger Dragon Titanic Galaxy (c63767246), Firewall Dragon Darkfluid (c68934651)
local s,id=GetID(); local SET_AEROCAT=0x3de1; local STRING_ID=133095349
function s.initial_effect(c)
 c:EnableReviveLimit(); aux.AddXyzProcedure(c,nil,6,2)
 local e0=Effect.CreateEffect(c); e0:SetType(EFFECT_TYPE_FIELD); e0:SetCode(EFFECT_CANNOT_SELECT_BATTLE_TARGET); e0:SetRange(LOCATION_MZONE); e0:SetTargetRange(0,LOCATION_MZONE); e0:SetValue(function(e,c) return c~=e:GetHandler() end); c:RegisterEffect(e0)
 local e1=Effect.CreateEffect(c); e1:SetDescription(aux.Stringid(STRING_ID,0)); e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH); e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O); e1:SetCode(EVENT_SPSUMMON_SUCCESS); e1:SetProperty(EFFECT_FLAG_DELAY); e1:SetCountLimit(1,id); e1:SetCondition(function(e) return e:GetHandler():IsSummonType(SUMMON_TYPE_XYZ) end); e1:SetOperation(s.op); c:RegisterEffect(e1)
end
function s.af(c) return c:IsSetCard(SET_AEROCAT) and c:IsAbleToHand() end
function s.diff(g,c) return not g:IsExists(Card.IsType,1,nil,c:GetType()&(TYPE_MONSTER+TYPE_SPELL+TYPE_TRAP)) end
function s.xyz(c) return c:IsFaceup() and c:IsType(TYPE_XYZ) and c:IsRank(6) end
function s.ovf(c) return c:IsSetCard(SET_AEROCAT) and c:IsAbleToOverlay() end
function s.op(e,tp) local c=e:GetHandler(); local ct=c:GetOverlayCount(); if ct>0 and c:RemoveOverlayCard(tp,ct,ct,REASON_EFFECT)~=ct then return end if Duel.IsExistingMatchingCard(s.af,tp,LOCATION_DECK,0,1,nil) and Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,1)) then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND); local sg=Duel.SelectMatchingCard(tp,s.af,tp,LOCATION_DECK,0,1,1,nil); local tc=sg:GetFirst(); local kind=tc:GetType()&(TYPE_MONSTER+TYPE_SPELL+TYPE_TRAP); local df=function(c,k) return s.af(c) and c:GetType()&(TYPE_MONSTER+TYPE_SPELL+TYPE_TRAP)~=k end; if Duel.IsExistingMatchingCard(df,tp,LOCATION_DECK,0,1,nil,kind) and Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,3)) then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND); sg:Merge(Duel.SelectMatchingCard(tp,df,tp,LOCATION_DECK,0,1,1,nil,kind)) end Duel.SendtoHand(sg,nil,REASON_EFFECT); Duel.ConfirmCards(1-tp,sg) end if Duel.IsExistingMatchingCard(s.xyz,tp,LOCATION_MZONE,0,1,nil) and Duel.IsExistingMatchingCard(s.ovf,tp,LOCATION_GRAVE,0,1,nil) and Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,2)) then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_XMATERIAL); local x=Duel.SelectMatchingCard(tp,s.xyz,tp,LOCATION_MZONE,0,1,1,nil):GetFirst(); local g=Duel.SelectMatchingCard(tp,s.ovf,tp,LOCATION_GRAVE,0,1,1,nil); Duel.Overlay(x,g) end end
''')

add(259748623, r'''
--Argalia the Gripen Aerocat
--Omega references: Salamangreat Spinny (c52277807), Overlay Regen (c27068117)
local s,id=GetID(); local SET_AEROCAT=0x3de1; local STRING_ID=133748623
function s.initial_effect(c)
 local e0=Effect.CreateEffect(c); e0:SetDescription(aux.Stringid(STRING_ID,0)); e0:SetType(EFFECT_TYPE_FIELD); e0:SetCode(EFFECT_SPSUMMON_PROC); e0:SetProperty(EFFECT_FLAG_UNCOPYABLE); e0:SetRange(LOCATION_HAND); e0:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH); e0:SetCondition(s.spcon); c:RegisterEffect(e0)
 local e1=Effect.CreateEffect(c); e1:SetDescription(aux.Stringid(STRING_ID,1)); e1:SetCategory(CATEGORY_DESTROY); e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O); e1:SetCode(EVENT_SUMMON_SUCCESS); e1:SetProperty(EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY); e1:SetCountLimit(1,id); e1:SetTarget(s.destg); e1:SetOperation(s.desop); c:RegisterEffect(e1); local e2=e1:Clone(); e2:SetCode(EVENT_SPSUMMON_SUCCESS); c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c); e3:SetDescription(aux.Stringid(STRING_ID,2)); e3:SetType(EFFECT_TYPE_QUICK_O); e3:SetCode(EVENT_FREE_CHAIN); e3:SetRange(LOCATION_HAND+LOCATION_GRAVE); e3:SetProperty(EFFECT_FLAG_CARD_TARGET); e3:SetCountLimit(1,id+100); e3:SetTarget(s.ovtg); e3:SetOperation(s.ovop); c:RegisterEffect(e3)
end
function s.spcon(e,c) if c==nil then return true end return Duel.GetLocationCount(c:GetControler(),LOCATION_MZONE)>0 and Duel.IsExistingMatchingCard(function(x) return x:IsSetCard(SET_AEROCAT) and x:IsType(TYPE_MONSTER) end,c:GetControler(),LOCATION_MZONE+LOCATION_GRAVE,0,1,nil) end
function s.df(c) return c:IsMonster() and c:IsDestructable() end
function s.destg(e,tp,eg,ep,ev,re,r,rp,chk,chkc) if chkc then return chkc:IsControler(1-tp) and chkc:IsLocation(LOCATION_MZONE) and s.df(chkc) end if chk==0 then return Duel.IsExistingTarget(s.df,tp,0,LOCATION_MZONE,1,nil) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY); local g=Duel.SelectTarget(tp,s.df,tp,0,LOCATION_MZONE,1,1,nil); Duel.SetOperationInfo(0,CATEGORY_DESTROY,g,1,0,0) end
function s.xyz(c) return c:IsFaceup() and c:IsType(TYPE_XYZ) end
function s.oppgy(c) return c:IsCanBeXyzMaterial() end
function s.desop(e,tp) local tc=Duel.GetFirstTarget(); if tc and tc:IsRelateToEffect(e) and Duel.Destroy(tc,REASON_EFFECT)>0 and Duel.IsExistingMatchingCard(s.xyz,tp,LOCATION_MZONE,0,1,nil) and Duel.IsExistingMatchingCard(s.oppgy,tp,0,LOCATION_GRAVE,1,nil) and Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,3)) then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_XMATERIAL); local og=Duel.SelectMatchingCard(tp,s.oppgy,tp,0,LOCATION_GRAVE,1,1,nil); local x=Duel.SelectMatchingCard(tp,s.xyz,tp,LOCATION_MZONE,0,1,1,nil):GetFirst(); Duel.Overlay(x,og) end end
function s.r6(c) return c:IsFaceup() and c:IsType(TYPE_XYZ) and c:IsRank(6) and c:IsAttribute(ATTRIBUTE_WIND) end
function s.ovtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc) if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and s.r6(chkc) end if chk==0 then return Duel.IsExistingTarget(s.r6,tp,LOCATION_MZONE,0,1,nil) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_XMATERIAL); Duel.SelectTarget(tp,s.r6,tp,LOCATION_MZONE,0,1,1,nil) end
function s.ovop(e) local c=e:GetHandler(); local tc=Duel.GetFirstTarget(); if c:IsRelateToEffect(e) and tc:IsRelateToEffect(e) then Duel.Overlay(tc,Group.FromCards(c)) end end
''')

add(259754412, r'''
--Dinomorphia Ankylos
--Omega references: Dinomorphia Therizia (c92133240), Dinomorphia Diplos (c38628859)
local s,id=GetID(); local SET_DINOMORPHIA=0x173; local MSG_ID=133754412
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c); e1:SetDescription(aux.Stringid(MSG_ID,0)); e1:SetCategory(CATEGORY_SPECIAL_SUMMON); e1:SetType(EFFECT_TYPE_QUICK_O); e1:SetCode(EVENT_FREE_CHAIN); e1:SetRange(LOCATION_HAND+LOCATION_GRAVE); e1:SetCountLimit(1,id); e1:SetCost(s.lpcost); e1:SetTarget(s.selftg); e1:SetOperation(s.selfop); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetDescription(aux.Stringid(MSG_ID,1)); e2:SetCategory(CATEGORY_LEAVE_GRAVE); e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O); e2:SetCode(EVENT_SUMMON_SUCCESS); e2:SetProperty(EFFECT_FLAG_DELAY); e2:SetCountLimit(1,id+100); e2:SetTarget(s.settg); e2:SetOperation(s.setop); c:RegisterEffect(e2); local e3=e2:Clone(); e3:SetCode(EVENT_SPSUMMON_SUCCESS); c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c); e4:SetDescription(aux.Stringid(MSG_ID,2)); e4:SetCategory(CATEGORY_SPECIAL_SUMMON); e4:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O); e4:SetCode(EVENT_DESTROYED); e4:SetProperty(EFFECT_FLAG_DELAY); e4:SetCountLimit(1,id+200); e4:SetCost(s.spcost); e4:SetTarget(s.sptg); e4:SetOperation(s.spop); c:RegisterEffect(e4)
end
function s.lpcost(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end Duel.PayLPCost(tp,math.floor(Duel.GetLP(tp)/2)) end
function s.selftg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and e:GetHandler():IsCanBeSpecialSummoned(e,0,tp,false,false) end Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,e:GetHandler(),1,0,0) end
function s.selfop(e,tp) local c=e:GetHandler(); if c:IsRelateToEffect(e) then Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP) end end
function s.tf(c) return c:IsSetCard(SET_DINOMORPHIA) and c:IsTrap() and c:IsSSetable() end
function s.settg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.tf),tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,nil) end end
function s.setop(e,tp) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SET); local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.tf),tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,1,nil); local tc=g:GetFirst(); if tc and Duel.SSet(tp,tc)>0 and Duel.GetLP(tp)<=2000 then local ex=Effect.CreateEffect(e:GetHandler()); ex:SetType(EFFECT_TYPE_SINGLE); ex:SetCode(EFFECT_TRAP_ACT_IN_SET_TURN); ex:SetProperty(EFFECT_FLAG_SET_AVAILABLE); ex:SetReset(RESET_EVENT+RESETS_STANDARD); tc:RegisterEffect(ex) end end
function s.bf(c) return c:IsTrap() and c:IsAbleToRemoveAsCost() end
function s.spcost(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.bf,tp,LOCATION_GRAVE,0,1,nil) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE); local g=Duel.SelectMatchingCard(tp,s.bf,tp,LOCATION_GRAVE,0,1,1,nil); Duel.Remove(g,POS_FACEUP,REASON_COST) end
function s.spf(c,e,tp) return c:IsSetCard(SET_DINOMORPHIA) and c:IsLevel(4) and not c:IsCode(id) and c:IsCanBeSpecialSummoned(e,0,tp,false,false) end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.spf),tp,LOCATION_GRAVE,0,1,nil,e,tp) end Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_GRAVE) end
function s.spop(e,tp) if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON); local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.spf),tp,LOCATION_GRAVE,0,1,1,nil,e,tp); Duel.SpecialSummon(g,0,tp,tp,false,false,POS_FACEUP) end
''')

add(259640854, r'''
--Dinomorphia Triceron
--Omega references: Dinomorphia Rexterm (c92798873), Dinomorphia Kentregina (c48832775)
local s,id=GetID(); local SET_DINOMORPHIA=0x173; local MSG_ID=133640854
function s.initial_effect(c)
 c:EnableReviveLimit(); aux.AddFusionProcFun2(c,function(x) return x:IsSetCard(SET_DINOMORPHIA) and x:IsType(TYPE_FUSION) end,function(x) return x:IsSetCard(SET_DINOMORPHIA) end,true)
 local e0=Effect.CreateEffect(c); e0:SetType(EFFECT_TYPE_FIELD); e0:SetCode(EFFECT_TRAP_ACT_IN_SET_TURN); e0:SetRange(LOCATION_MZONE); e0:SetTargetRange(LOCATION_SZONE,0); e0:SetCondition(function(e) return Duel.GetLP(e:GetHandlerPlayer())<=2000 end); e0:SetTarget(function(e,c) return c:IsSetCard(SET_DINOMORPHIA) end); c:RegisterEffect(e0)
 local e1=Effect.CreateEffect(c); e1:SetDescription(aux.Stringid(MSG_ID,0)); e1:SetCategory(CATEGORY_DESTROY+CATEGORY_TODECK); e1:SetType(EFFECT_TYPE_QUICK_O); e1:SetCode(EVENT_FREE_CHAIN); e1:SetRange(LOCATION_MZONE); e1:SetProperty(EFFECT_FLAG_CARD_TARGET); e1:SetCountLimit(1,id); e1:SetCost(s.lpcost); e1:SetTarget(s.destg); e1:SetOperation(s.desop); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetDescription(aux.Stringid(MSG_ID,1)); e2:SetCategory(CATEGORY_SPECIAL_SUMMON); e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O); e2:SetCode(EVENT_DESTROYED); e2:SetProperty(EFFECT_FLAG_DELAY); e2:SetCountLimit(1,id+100); e2:SetTarget(s.sptg); e2:SetOperation(s.spop); c:RegisterEffect(e2)
end
function s.lpcost(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end Duel.PayLPCost(tp,math.floor(Duel.GetLP(tp)/2)) end
function s.own(c) return c:IsFaceup() and c:IsSetCard(SET_DINOMORPHIA) and c:IsType(TYPE_MONSTER) and c:IsDestructable() end
function s.opp(c) return c:IsDestructable() end
function s.destg(e,tp,eg,ep,ev,re,r,rp,chk,chkc) if chkc then return false end if chk==0 then return Duel.IsExistingTarget(s.own,tp,LOCATION_MZONE,0,1,e:GetHandler()) and Duel.IsExistingTarget(s.opp,tp,0,LOCATION_ONFIELD,1,nil) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY); local a=Duel.SelectTarget(tp,s.own,tp,LOCATION_MZONE,0,1,1,e:GetHandler()); Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY); local b=Duel.SelectTarget(tp,s.opp,tp,0,LOCATION_ONFIELD,1,1,nil); a:Merge(b); Duel.SetOperationInfo(0,CATEGORY_DESTROY,a,2,0,0) end
function s.rdf(c) return c:IsSetCard(SET_DINOMORPHIA) and c:IsTrap() and c:IsAbleToDeck() end
function s.desop(e,tp) local g=Duel.GetTargetCards(e):Filter(Card.IsRelateToEffect,nil,e); if Duel.Destroy(g,REASON_EFFECT)==2 and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.rdf),tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,nil) and Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,2)) then Duel.BreakEffect(); Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK); local rg=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.rdf),tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,3,nil); Duel.SendtoDeck(rg,nil,SEQ_DECKSHUFFLE,REASON_EFFECT) end end
function s.spf(c,e,tp) return c:IsSetCard(SET_DINOMORPHIA) and c:IsLevelBelow(6) and c:IsCanBeSpecialSummoned(e,0,tp,false,false) end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.spf),tp,LOCATION_GRAVE,0,1,nil,e,tp) end Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_GRAVE) end
function s.spop(e,tp) if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON); local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.spf),tp,LOCATION_GRAVE,0,1,1,nil,e,tp); Duel.SpecialSummon(g,0,tp,tp,false,false,POS_FACEUP) end
''')

add(259826112, r'''
--Dinomorphia Provocation
--Omega references: Dinomorphia Domain (c26631975), Dinomorphia Frenzy (c78420796)
local s,id=GetID(); local SET_DINOMORPHIA=0x173; local MSG_ID=133826112
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c); e1:SetDescription(aux.Stringid(MSG_ID,0)); e1:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_FUSION_SUMMON); e1:SetType(EFFECT_TYPE_ACTIVATE); e1:SetCode(EVENT_FREE_CHAIN); e1:SetCountLimit(1,id); e1:SetCost(s.lpcost); e1:SetTarget(s.tg); e1:SetOperation(s.op); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetDescription(aux.Stringid(MSG_ID,1)); e2:SetCategory(CATEGORY_TOGRAVE); e2:SetType(EFFECT_TYPE_IGNITION); e2:SetRange(LOCATION_GRAVE); e2:SetCountLimit(1,id+100); e2:SetCost(s.gycost); e2:SetTarget(s.gytg); e2:SetOperation(s.gyop); c:RegisterEffect(e2)
end
function s.lpcost(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end Duel.PayLPCost(tp,math.floor(Duel.GetLP(tp)/2)) end
function s.tf(c) return c:IsSetCard(SET_DINOMORPHIA) and c:IsTrap() and c:IsSSetable() end
function s.tg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.tf,tp,LOCATION_DECK,0,1,nil) end end
function s.op(e,tp) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SET); local g=Duel.SelectMatchingCard(tp,s.tf,tp,LOCATION_DECK,0,1,1,nil); if #g==0 or Duel.SSet(tp,g)==0 then return end local mg=Duel.GetFusionMaterial(tp); local fg=Duel.GetMatchingGroup(function(c,e,tp,mg) return c:IsSetCard(SET_DINOMORPHIA) and c:IsType(TYPE_FUSION) and c:IsCanBeSpecialSummoned(e,SUMMON_TYPE_FUSION,tp,false,false) and c:CheckFusionMaterial(mg) end,tp,LOCATION_EXTRA,0,nil,e,tp,mg); if #fg>0 and Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,2)) then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON); local fc=fg:Select(tp,1,1,nil):GetFirst(); local mat=Duel.SelectFusionMaterial(tp,fc,mg,nil,tp); fc:SetMaterial(mat); Duel.SendtoGrave(mat,REASON_EFFECT+REASON_MATERIAL+REASON_FUSION); Duel.BreakEffect(); Duel.SpecialSummon(fc,SUMMON_TYPE_FUSION,tp,tp,false,false,POS_FACEUP); fc:CompleteProcedure() end end
function s.gycost(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return e:GetHandler():IsAbleToRemoveAsCost() end Duel.Remove(e:GetHandler(),POS_FACEUP,REASON_COST); Duel.PayLPCost(tp,math.floor(Duel.GetLP(tp)/2)) end
function s.df(c) return c:IsSetCard(SET_DINOMORPHIA) and c:IsAbleToGrave() end
function s.gytg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.df,tp,LOCATION_DECK,0,1,nil) end Duel.SetOperationInfo(0,CATEGORY_TOGRAVE,nil,1,tp,LOCATION_DECK) end
function s.gyop(e,tp) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE); local g=Duel.SelectMatchingCard(tp,s.df,tp,LOCATION_DECK,0,1,1,nil); Duel.SendtoGrave(g,REASON_EFFECT) end
''')

add(259935441, r'''
--Dinomorphia Hideout
--Omega references: Temple of the Kings (c29762407), Transaction Rollback (c6351147)
local s,id=GetID(); local SET_DINOMORPHIA=0x173; local MSG_ID=133935441
function s.initial_effect(c)
 Duel.AddCustomActivityCounter(id,ACTIVITY_SPSUMMON,function(c) return c:IsSetCard(SET_DINOMORPHIA) end)
 local ea=Effect.CreateEffect(c); ea:SetType(EFFECT_TYPE_ACTIVATE); ea:SetCode(EVENT_FREE_CHAIN); c:RegisterEffect(ea)
 local e0=Effect.CreateEffect(c); e0:SetType(EFFECT_TYPE_SINGLE); e0:SetCode(EFFECT_TRAP_ACT_IN_SET_TURN); e0:SetCondition(function(e) return Duel.GetFieldGroupCount(e:GetHandlerPlayer(),0,LOCATION_ONFIELD)>0 end); c:RegisterEffect(e0)
 local e1=Effect.CreateEffect(c); e1:SetDescription(aux.Stringid(MSG_ID,0)); e1:SetType(EFFECT_TYPE_IGNITION); e1:SetRange(LOCATION_SZONE); e1:SetCountLimit(1,id); e1:SetCost(s.cpcost); e1:SetTarget(s.cptg); e1:SetOperation(s.cpop); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetType(EFFECT_TYPE_FIELD); e2:SetCode(EFFECT_TRAP_ACT_IN_HAND); e2:SetRange(LOCATION_SZONE); e2:SetTargetRange(LOCATION_HAND,0); e2:SetCondition(function(e) local tp=e:GetHandlerPlayer(); return Duel.GetTurnPlayer()==tp and Duel.GetFlagEffect(tp,id+300)==0 end); e2:SetTarget(function(e,c) return c:IsSetCard(SET_DINOMORPHIA) end); c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c); e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS); e3:SetCode(EVENT_CHAINING); e3:SetRange(LOCATION_SZONE); e3:SetCondition(s.handcon); e3:SetOperation(s.handop); c:RegisterEffect(e3)
end
function s.cpf(c) return c:IsSetCard(SET_DINOMORPHIA) and c:IsNormalTrap() and c:IsAbleToGrave() and c:CheckActivateEffect(false,true,false)~=nil end
function s.lock(e,tp) local ex=Effect.CreateEffect(e:GetHandler()); ex:SetType(EFFECT_TYPE_FIELD); ex:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON); ex:SetProperty(EFFECT_FLAG_PLAYER_TARGET); ex:SetTargetRange(1,0); ex:SetTarget(function(e,c) return not c:IsSetCard(SET_DINOMORPHIA) end); ex:SetReset(RESET_PHASE+PHASE_END); Duel.RegisterEffect(ex,tp) end
function s.cpcost(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetCustomActivityCount(id,tp,ACTIVITY_SPSUMMON)==0 and Duel.IsExistingMatchingCard(s.cpf,tp,LOCATION_DECK,0,1,nil) end Duel.PayLPCost(tp,math.floor(Duel.GetLP(tp)/2)); Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE); local tc=Duel.SelectMatchingCard(tp,s.cpf,tp,LOCATION_DECK,0,1,1,nil):GetFirst(); local te=tc:CheckActivateEffect(false,true,true); Duel.SendtoGrave(tc,REASON_COST); e:SetLabelObject(te); s.lock(e,tp) end
function s.cptg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end local te=e:GetLabelObject(); if not te then return end e:SetProperty(te:GetProperty()); local tg=te:GetTarget(); if tg then tg(e,tp,eg,ep,ev,re,r,rp,1) end; te:SetLabelObject(e:GetLabelObject()); e:SetLabelObject(te); Duel.ClearOperationInfo(0) end
function s.cpop(e,tp,eg,ep,ev,re,r,rp) local te=e:GetLabelObject(); if te then e:SetLabelObject(te:GetLabelObject()); local op=te:GetOperation(); if op then op(e,tp,eg,ep,ev,re,r,rp) end end end
function s.handcon(e,tp,eg,ep,ev,re,r,rp) local rc=re:GetHandler(); return rp==tp and re:IsActiveType(TYPE_TRAP) and re:IsHasType(EFFECT_TYPE_ACTIVATE) and re:GetActivateLocation()==LOCATION_HAND and rc:IsSetCard(SET_DINOMORPHIA) end
function s.handop(e,tp) Duel.RegisterFlagEffect(tp,id+300,RESET_PHASE+PHASE_END,0,1) end
''')

add(259481543, r'''
--Krawler Astrocyte
--Omega references: Krawler Glial (c51205763), World Legacy Pawns (c89320376)
local s,id=GetID(); local SET_KRAWLER=0x104; local SET_WORLD_LEGACY=0xfe; local MSG_ID=133481543
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c); e1:SetDescription(aux.Stringid(MSG_ID,0)); e1:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_POSITION); e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_FLIP+EFFECT_TYPE_TRIGGER_O); e1:SetCode(EVENT_FLIP); e1:SetCountLimit(1,id); e1:SetTarget(s.fliptg); e1:SetOperation(s.flipop); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetDescription(aux.Stringid(MSG_ID,1)); e2:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_POSITION); e2:SetType(EFFECT_TYPE_IGNITION); e2:SetRange(LOCATION_HAND); e2:SetCountLimit(1,id+100); e2:SetCost(s.dcost); e2:SetTarget(s.selftg); e2:SetOperation(s.selfop); c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c); e3:SetDescription(aux.Stringid(MSG_ID,2)); e3:SetCategory(CATEGORY_SPECIAL_SUMMON); e3:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O); e3:SetCode(EVENT_LEAVE_FIELD); e3:SetProperty(EFFECT_FLAG_DELAY); e3:SetCountLimit(1,id+200); e3:SetCondition(s.lvcon); e3:SetTarget(s.lvtg); e3:SetOperation(s.lvop); c:RegisterEffect(e3)
end
function s.deckf(c,e,tp) return c:IsSetCard(SET_KRAWLER) and c:IsLevel(2) and c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEDOWN_DEFENSE) end
function s.fliptg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and Duel.IsExistingMatchingCard(s.deckf,tp,LOCATION_DECK,0,1,nil,e,tp) end Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_DECK) end
function s.flipop(e,tp) if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON); local g=Duel.SelectMatchingCard(tp,s.deckf,tp,LOCATION_DECK,0,1,1,nil,e,tp); if Duel.SpecialSummon(g,0,tp,tp,false,false,POS_FACEDOWN_DEFENSE)>0 and Duel.IsExistingMatchingCard(Card.IsFacedown,tp,LOCATION_MZONE,0,1,nil) and Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,3)) then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_POSCHANGE); local tc=Duel.SelectMatchingCard(tp,Card.IsFacedown,tp,LOCATION_MZONE,0,1,1,nil):GetFirst(); if Duel.ChangePosition(tc,POS_FACEUP_DEFENSE)>0 and e:GetHandler():IsFaceup() and e:GetHandler():IsCanTurnSet() then Duel.ChangePosition(e:GetHandler(),POS_FACEDOWN_DEFENSE) end end end
function s.disf(c) return (c:IsSetCard(SET_KRAWLER) or c:IsSetCard(SET_WORLD_LEGACY)) and c:IsDiscardable() end
function s.dcost(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.disf,tp,LOCATION_HAND,0,1,e:GetHandler()) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DISCARD); local g=Duel.SelectMatchingCard(tp,s.disf,tp,LOCATION_HAND,0,1,1,e:GetHandler()); Duel.SendtoGrave(g,REASON_COST+REASON_DISCARD) end
function s.selftg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and e:GetHandler():IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEDOWN_DEFENSE) end Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,e:GetHandler(),1,0,0) end
function s.selfop(e,tp) local c=e:GetHandler(); if c:IsRelateToEffect(e) and Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEDOWN_DEFENSE)>0 and Duel.IsExistingMatchingCard(Card.IsFacedown,tp,LOCATION_MZONE,0,1,nil) and Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,3)) then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_POSCHANGE); local tc=Duel.SelectMatchingCard(tp,Card.IsFacedown,tp,LOCATION_MZONE,0,1,1,nil):GetFirst(); Duel.ChangePosition(tc,POS_FACEUP_DEFENSE) end end
function s.lvcon(e,tp,eg,ep,ev,re,r,rp) local c=e:GetHandler(); return c:IsPreviousPosition(POS_FACEUP) and c:IsPreviousControler(tp) and rp==1-tp and c:IsReason(REASON_EFFECT) end
function s.lvf(c,e,tp) return c:IsSetCard(SET_KRAWLER) and not c:IsCode(id) and c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEDOWN_DEFENSE) end
function s.lvtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>1 and Duel.GetMatchingGroup(s.lvf,tp,LOCATION_DECK,0,nil,e,tp):GetClassCount(Card.GetCode)>=2 end Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,2,tp,LOCATION_DECK) end
function s.lvop(e,tp) if Duel.GetLocationCount(tp,LOCATION_MZONE)<2 then return end local g=Duel.GetMatchingGroup(s.lvf,tp,LOCATION_DECK,0,nil,e,tp); local sg=aux.SelectUnselectGroup(g,e,tp,2,2,aux.dncheck,1,tp,HINTMSG_SPSUMMON); if #sg==2 then Duel.SpecialSummon(sg,0,tp,tp,false,false,POS_FACEDOWN_DEFENSE); Duel.ConfirmCards(1-tp,sg) end end
''')

add(259774818, r'''
--Krawler Lamina
--Omega references: Krawler Ranvier (c10698416), World Legacy Pawns (c89320376)
local s,id=GetID(); local SET_KRAWLER=0x104; local SET_WORLD_LEGACY=0xfe; local MSG_ID=133774818
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c); e1:SetDescription(aux.Stringid(MSG_ID,0)); e1:SetCategory(CATEGORY_TOHAND); e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_FLIP+EFFECT_TYPE_TRIGGER_O); e1:SetCode(EVENT_FLIP); e1:SetProperty(EFFECT_FLAG_CARD_TARGET); e1:SetCountLimit(1,id); e1:SetTarget(s.rtg); e1:SetOperation(s.rop); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetDescription(aux.Stringid(MSG_ID,1)); e2:SetCategory(CATEGORY_SPECIAL_SUMMON); e2:SetType(EFFECT_TYPE_QUICK_O); e2:SetCode(EVENT_FREE_CHAIN); e2:SetRange(LOCATION_HAND); e2:SetCountLimit(1,id+100); e2:SetCost(s.dcost); e2:SetTarget(s.sptg); e2:SetOperation(s.spop); c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c); e3:SetDescription(aux.Stringid(MSG_ID,2)); e3:SetCategory(CATEGORY_REMOVE); e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O); e3:SetCode(EVENT_SPSUMMON_SUCCESS); e3:SetRange(LOCATION_GRAVE); e3:SetProperty(EFFECT_FLAG_DELAY); e3:SetCountLimit(1,id+200); e3:SetCondition(s.lkcon); e3:SetCost(aux.bfgcost); e3:SetTarget(s.pltg); e3:SetOperation(s.plop); c:RegisterEffect(e3)
end
function s.own(c) return c:IsAbleToHand() end
function s.opp(c) return c:IsAbleToHand() end
function s.rtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc) if chkc then return false end if chk==0 then return Duel.IsExistingTarget(s.own,tp,LOCATION_ONFIELD,0,1,nil) and Duel.IsExistingTarget(s.opp,tp,0,LOCATION_ONFIELD,1,nil) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RTOHAND); local a=Duel.SelectTarget(tp,s.own,tp,LOCATION_ONFIELD,0,1,1,nil); Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RTOHAND); local b=Duel.SelectTarget(tp,s.opp,tp,0,LOCATION_ONFIELD,1,1,nil); a:Merge(b); Duel.SetOperationInfo(0,CATEGORY_TOHAND,a,2,0,0) end
function s.rop(e) local g=Duel.GetTargetCards(e):Filter(Card.IsRelateToEffect,nil,e); Duel.SendtoHand(g,nil,REASON_EFFECT) end
function s.dcost(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return e:GetHandler():IsDiscardable() end Duel.SendtoGrave(e:GetHandler(),REASON_COST+REASON_DISCARD) end
function s.spf(c,e,tp) return c:IsSetCard(SET_KRAWLER) and not c:IsCode(id) and c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEUP_DEFENSE+POS_FACEDOWN_DEFENSE) end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.spf),tp,LOCATION_HAND+LOCATION_GRAVE+LOCATION_REMOVED,0,1,nil,e,tp) end Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_HAND+LOCATION_GRAVE+LOCATION_REMOVED) end
function s.spop(e,tp) if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON); local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.spf),tp,LOCATION_HAND+LOCATION_GRAVE+LOCATION_REMOVED,0,1,1,nil,e,tp); local tc=g:GetFirst(); if tc then local pos=Duel.SelectPosition(tp,tc,POS_FACEUP_DEFENSE+POS_FACEDOWN_DEFENSE); Duel.SpecialSummon(tc,0,tp,tp,false,false,pos); if pos==POS_FACEDOWN_DEFENSE then Duel.ConfirmCards(1-tp,tc) end end end
function s.lkcon(e,tp,eg) return eg:IsExists(Card.IsType,1,nil,TYPE_LINK) end
function s.face(c,tp) return not c:IsForbidden() and c:CheckUniqueOnField(tp) end
function s.wlf(c,tp) return c:IsSetCard(SET_WORLD_LEGACY) and c:IsType(TYPE_CONTINUOUS) and c:IsSpellTrap() and (c:IsSSetable() or s.face(c,tp)) end
function s.pltg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetLocationCount(tp,LOCATION_SZONE)>0 and Duel.IsExistingMatchingCard(s.wlf,tp,LOCATION_HAND+LOCATION_DECK,0,1,nil,tp) end end
function s.plop(e,tp) if Duel.GetLocationCount(tp,LOCATION_SZONE)<=0 then return end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOFIELD); local tc=Duel.SelectMatchingCard(tp,s.wlf,tp,LOCATION_HAND+LOCATION_DECK,0,1,1,nil,tp):GetFirst(); if not tc then return end local face=s.face(tc,tp); local set=tc:IsSSetable(); if face and set then if Duel.SelectOption(tp,aux.Stringid(MSG_ID,3),aux.Stringid(MSG_ID,4))==0 then Duel.MoveToField(tc,tp,tp,LOCATION_SZONE,POS_FACEUP,true) else Duel.SSet(tp,tc) end elseif face then Duel.MoveToField(tc,tp,tp,LOCATION_SZONE,POS_FACEUP,true) else Duel.SSet(tp,tc) end end
''')

add(259322868, r'''
--Krawler of the World Legacy
--Omega references: Subterror Behemoth Fiendess (c74937659), Krawler Glial (c51205763)
local s,id=GetID(); local SET_KRAWLER=0x104; local MSG_ID=133322868
function s.initial_effect(c)
 local e0=Effect.CreateEffect(c); e0:SetDescription(aux.Stringid(MSG_ID,0)); e0:SetType(EFFECT_TYPE_FIELD); e0:SetCode(EFFECT_SPSUMMON_PROC); e0:SetProperty(EFFECT_FLAG_UNCOPYABLE); e0:SetRange(LOCATION_HAND); e0:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH); e0:SetCondition(s.spcon); e0:SetTarget(s.sptg0); e0:SetOperation(s.spop0); c:RegisterEffect(e0)
 local e1=Effect.CreateEffect(c); e1:SetDescription(aux.Stringid(MSG_ID,1)); e1:SetCategory(CATEGORY_SPECIAL_SUMMON); e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O); e1:SetCode(EVENT_SPSUMMON_SUCCESS); e1:SetProperty(EFFECT_FLAG_DELAY); e1:SetCountLimit(1,id); e1:SetTarget(s.sptg); e1:SetOperation(s.spop); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetDescription(aux.Stringid(MSG_ID,2)); e2:SetCategory(CATEGORY_POSITION); e2:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O); e2:SetCode(EVENT_TO_GRAVE); e2:SetProperty(EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY); e2:SetCountLimit(1,id+100); e2:SetCondition(s.poscon); e2:SetTarget(s.postg); e2:SetOperation(s.posop); c:RegisterEffect(e2)
end
function s.rel(c,tp) return c:IsFacedown() and c:IsReleasable() and Duel.GetMZoneCount(tp,c)>0 end
function s.spcon(e,c) if c==nil then return true end local tp=c:GetControler(); return Duel.IsExistingMatchingCard(s.rel,tp,LOCATION_MZONE,LOCATION_MZONE,1,nil,tp) end
function s.sptg0(e,tp,eg,ep,ev,re,r,rp,c) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RELEASE); local g=Duel.SelectMatchingCard(tp,s.rel,tp,LOCATION_MZONE,LOCATION_MZONE,1,1,nil,tp); if #g==0 then return false end e:SetLabelObject(g:GetFirst()); return true end
function s.spop0(e,tp) Duel.Release(e:GetLabelObject(),REASON_COST) end
function s.kf(c,e,tp) return c:IsSetCard(SET_KRAWLER) and c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEDOWN_DEFENSE) end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.kf),tp,LOCATION_HAND+LOCATION_GRAVE,0,1,nil,e,tp) end Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_HAND+LOCATION_GRAVE) end
function s.spop(e,tp) if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON); local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.kf),tp,LOCATION_HAND+LOCATION_GRAVE,0,1,1,nil,e,tp); if Duel.SpecialSummon(g,0,tp,tp,false,false,POS_FACEDOWN_DEFENSE)>0 then Duel.ConfirmCards(1-tp,g) end end
function s.poscon(e,tp,eg,ep,ev,re,r,rp) local c=e:GetHandler(); local rc=c:GetReasonCard(); return c:IsReason(REASON_LINK) or c:IsReason(REASON_EFFECT) and rc and rc:IsSetCard(SET_KRAWLER) end
function s.pf(c) return c:IsCanChangePosition() end
function s.postg(e,tp,eg,ep,ev,re,r,rp,chk,chkc) if chkc then return chkc:IsLocation(LOCATION_MZONE) and s.pf(chkc) end if chk==0 then return Duel.IsExistingTarget(s.pf,tp,LOCATION_MZONE,LOCATION_MZONE,1,nil) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_POSCHANGE); Duel.SelectTarget(tp,s.pf,tp,LOCATION_MZONE,LOCATION_MZONE,1,1,nil) end
function s.posop(e,tp) local tc=Duel.GetFirstTarget(); if not tc:IsRelateToEffect(e) then return end if tc:IsFacedown() then Duel.ChangePosition(tc,POS_FACEUP_DEFENSE) elseif tc:IsCanTurnSet() then Duel.ChangePosition(tc,POS_FACEDOWN_DEFENSE) end end
''')

add(259669838, r'''
--Krawler Plexus
--Omega references: Ghostrick Festival (c35871958), Krawler Glial (c51205763)
local s,id=GetID(); local SET_KRAWLER=0x104; local MSG_ID=133669838
function s.initial_effect(c)
 local e0=aux.AddLinkProcedure(c,function(x) return x:IsLinkSetCard(SET_KRAWLER) end,1,1); e0:SetProperty(e0:GetProperty()|EFFECT_FLAG_SET_AVAILABLE); c:EnableReviveLimit(); c:SetSPSummonOnce(id)
 local e1=Effect.CreateEffect(c); e1:SetDescription(aux.Stringid(MSG_ID,0)); e1:SetCategory(CATEGORY_SPECIAL_SUMMON+CATEGORY_POSITION); e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O); e1:SetCode(EVENT_SPSUMMON_SUCCESS); e1:SetProperty(EFFECT_FLAG_DELAY); e1:SetCountLimit(1,id); e1:SetCost(s.dcost); e1:SetTarget(s.sptg); e1:SetOperation(s.spop); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetDescription(aux.Stringid(MSG_ID,1)); e2:SetCategory(CATEGORY_TODECK+CATEGORY_ATKCHANGE); e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O); e2:SetCode(EVENT_LEAVE_FIELD); e2:SetRange(LOCATION_GRAVE); e2:SetProperty(EFFECT_FLAG_DELAY); e2:SetCondition(s.lvcon); e2:SetTarget(s.tdtg); e2:SetOperation(s.tdop); c:RegisterEffect(e2)
end
function s.dcost(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end local yes=Duel.IsExistingMatchingCard(Card.IsDiscardable,tp,LOCATION_HAND,0,1,nil) and Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,2)); e:SetLabel(yes and 1 or 0); if yes then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DISCARD); local g=Duel.SelectMatchingCard(tp,Card.IsDiscardable,tp,LOCATION_HAND,0,1,1,nil); Duel.SendtoGrave(g,REASON_COST+REASON_DISCARD) end end
function s.spf(c,e,tp) return c:IsSetCard(SET_KRAWLER) and c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEDOWN_DEFENSE) end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.spf),tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,nil,e,tp) end Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,1,tp,LOCATION_GRAVE+LOCATION_REMOVED) end
function s.spop(e,tp) if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON); local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.spf),tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,1,nil,e,tp); if Duel.SpecialSummon(g,0,tp,tp,false,false,POS_FACEDOWN_DEFENSE)>0 then Duel.ConfirmCards(1-tp,g); if e:GetLabel()==1 and Duel.IsExistingMatchingCard(Card.IsFacedown,tp,LOCATION_MZONE,0,1,nil) and Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,3)) then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_POSCHANGE); local tc=Duel.SelectMatchingCard(tp,Card.IsFacedown,tp,LOCATION_MZONE,0,1,1,nil):GetFirst(); Duel.ChangePosition(tc,POS_FACEUP_DEFENSE) end end end
function s.lvcon(e,tp,eg,ep,ev,re,r,rp) return eg:IsExists(function(c,tp) return c:IsPreviousControler(tp) and c:IsPreviousLocation(LOCATION_MZONE) and c:IsSetCard(SET_KRAWLER) and c:IsReason(REASON_EFFECT) and c:GetReasonPlayer()==1-tp end,1,nil,tp) end
function s.tdf(c) return c:IsSetCard(SET_KRAWLER) and c:IsType(TYPE_MONSTER) and c:IsAbleToDeck() end
function s.tdtg(e,tp,eg,ep,ev,re,r,rp,chk) local c=e:GetHandler(); if chk==0 then return c:IsAbleToDeck() and Duel.IsExistingMatchingCard(s.tdf,tp,LOCATION_GRAVE,0,2,c) end Duel.SetOperationInfo(0,CATEGORY_TODECK,nil,3,tp,LOCATION_GRAVE) end
function s.tdop(e,tp) local c=e:GetHandler(); if not c:IsRelateToEffect(e) or not c:IsAbleToDeck() then return end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK); local g=Duel.SelectMatchingCard(tp,s.tdf,tp,LOCATION_GRAVE,0,2,2,c); g:AddCard(c); if Duel.SendtoDeck(g,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)==3 then local ex=Effect.CreateEffect(c); ex:SetType(EFFECT_TYPE_FIELD); ex:SetCode(EFFECT_UPDATE_ATTACK); ex:SetTargetRange(LOCATION_MZONE,0); ex:SetTarget(function(e,c) return c:IsSetCard(SET_KRAWLER) end); ex:SetValue(300); ex:SetReset(RESET_PHASE+PHASE_END); Duel.RegisterEffect(ex,tp); local ex2=ex:Clone(); ex2:SetCode(EFFECT_UPDATE_DEFENSE); Duel.RegisterEffect(ex2,tp) end end
''')

add(259944344, r'''
--World Legacy Surfacing
--Omega references: Transaction Rollback (c6351147), Krawler Spine (c88316955), Krawler Axon (c15710054), Krawler Glial (c51205763), Krawler Receptor (c83293307), Krawler Dendrite (c46083111), Krawler Ranvier (c10698416)
local s,id=GetID(); local SET_KRAWLER=0x104; local SET_WORLD_LEGACY=0xfe; local MSG_ID=133944344
function s.initial_effect(c)
 Duel.AddCustomActivityCounter(id,ACTIVITY_CHAIN,s.chainfilter)
 local e1=Effect.CreateEffect(c); e1:SetDescription(aux.Stringid(MSG_ID,0)); e1:SetType(EFFECT_TYPE_ACTIVATE); e1:SetCode(EVENT_FREE_CHAIN); e1:SetCountLimit(1,id); e1:SetTarget(s.cptg); e1:SetOperation(s.cpop); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetDescription(aux.Stringid(MSG_ID,1)); e2:SetCategory(CATEGORY_TOHAND); e2:SetType(EFFECT_TYPE_IGNITION); e2:SetRange(LOCATION_GRAVE); e2:SetCountLimit(1,id+100); e2:SetCost(aux.bfgcost); e2:SetTarget(s.thtg); e2:SetOperation(s.thop); c:RegisterEffect(e2)
end
function s.chainfilter(re) return not re:IsActiveType(TYPE_SPELL+TYPE_TRAP) or re:GetHandler():IsSetCard(SET_WORLD_LEGACY) end
function s.glial(c,e,tp) return c:IsSetCard(SET_KRAWLER) and not c:IsCode(51205763) and c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEUP_ATTACK+POS_FACEDOWN_DEFENSE) end
function s.receptor(c) return c:IsSetCard(SET_KRAWLER) and c:IsType(TYPE_MONSTER) and c:IsAbleToHand() end
function s.dendrite(c) return c:IsType(TYPE_MONSTER) and c:IsAbleToGrave() end
function s.ranvier(c) return c:IsSetCard(SET_KRAWLER) and c:IsType(TYPE_MONSTER) and c:IsAbleToHand() end
function s.flipok(c,e,tp)
 local code=c:GetCode()
 if code==88316955 then return Duel.IsExistingMatchingCard(aux.TRUE,tp,LOCATION_MZONE,LOCATION_MZONE,1,nil) end
 if code==15710054 then return Duel.IsExistingMatchingCard(Card.IsSpellTrap,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,nil) end
 if code==51205763 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.glial),tp,LOCATION_HAND+LOCATION_GRAVE,0,1,nil,e,tp) end
 if code==83293307 then return Duel.IsExistingMatchingCard(s.receptor,tp,LOCATION_DECK,0,1,nil) end
 if code==46083111 then return Duel.IsExistingMatchingCard(s.dendrite,tp,LOCATION_DECK,0,1,nil) end
 if code==10698416 then return Duel.IsExistingTarget(aux.NecroValleyFilter(s.ranvier),tp,LOCATION_GRAVE,0,1,nil) end
 return false
end
function s.rf(c,e,tp) return c:IsSetCard(SET_KRAWLER) and c:IsLevelBelow(2) and c:IsType(TYPE_FLIP) and s.flipok(c,e,tp) end
function s.lock(e,tp) local ex=Effect.CreateEffect(e:GetHandler()); ex:SetType(EFFECT_TYPE_FIELD); ex:SetCode(EFFECT_CANNOT_ACTIVATE); ex:SetProperty(EFFECT_FLAG_PLAYER_TARGET); ex:SetTargetRange(1,0); ex:SetValue(function(e,re) return re:IsActiveType(TYPE_SPELL+TYPE_TRAP) and not re:GetHandler():IsSetCard(SET_WORLD_LEGACY) end); ex:SetReset(RESET_PHASE+PHASE_END); Duel.RegisterEffect(ex,tp) end
function s.cptg(e,tp,eg,ep,ev,re,r,rp,chk)
 local loc=LOCATION_HAND+LOCATION_GRAVE; if Duel.GetFieldGroupCount(tp,0,LOCATION_ONFIELD)>0 then loc=loc+LOCATION_DECK end
 if chk==0 then return Duel.GetCustomActivityCount(id,tp,ACTIVITY_CHAIN)==0 and Duel.IsExistingMatchingCard(s.rf,tp,loc,0,1,nil,e,tp) end
 Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_CONFIRM); local g=Duel.SelectMatchingCard(tp,s.rf,tp,loc,0,1,1,nil,e,tp); Duel.ConfirmCards(1-tp,g)
 local code=g:GetFirst():GetCode(); e:SetLabel(code); s.lock(e,tp)
 if code==88316955 then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY); local tg=Duel.SelectTarget(tp,aux.TRUE,tp,LOCATION_MZONE,LOCATION_MZONE,1,1,nil); Duel.SetOperationInfo(0,CATEGORY_DESTROY,tg,1,0,0)
 elseif code==15710054 then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_DESTROY); local tg=Duel.SelectTarget(tp,Card.IsSpellTrap,tp,LOCATION_ONFIELD,LOCATION_ONFIELD,1,1,nil); Duel.SetOperationInfo(0,CATEGORY_DESTROY,tg,1,0,0)
 elseif code==10698416 then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND); local tg=Duel.SelectTarget(tp,aux.NecroValleyFilter(s.ranvier),tp,LOCATION_GRAVE,0,1,2,nil); Duel.SetOperationInfo(0,CATEGORY_TOHAND,tg,#tg,0,0) end
end
function s.cpop(e,tp)
 local code=e:GetLabel()
 if code==88316955 or code==15710054 then local tc=Duel.GetFirstTarget(); if tc and tc:IsRelateToEffect(e) then Duel.Destroy(tc,REASON_EFFECT) end
 elseif code==51205763 then if Duel.GetLocationCount(tp,LOCATION_MZONE)<=0 then return end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON); local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.glial),tp,LOCATION_HAND+LOCATION_GRAVE,0,1,1,nil,e,tp); local tc=g:GetFirst(); if tc then local pos=Duel.SelectPosition(tp,tc,POS_FACEUP_ATTACK+POS_FACEDOWN_DEFENSE); if Duel.SpecialSummon(tc,0,tp,tp,false,false,pos)>0 and tc:IsFacedown() then Duel.ConfirmCards(1-tp,tc) end end
 elseif code==83293307 then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND); local g=Duel.SelectMatchingCard(tp,s.receptor,tp,LOCATION_DECK,0,1,1,nil); if #g>0 then Duel.SendtoHand(g,nil,REASON_EFFECT); Duel.ConfirmCards(1-tp,g) end
 elseif code==46083111 then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE); local g=Duel.SelectMatchingCard(tp,s.dendrite,tp,LOCATION_DECK,0,1,1,nil); Duel.SendtoGrave(g,REASON_EFFECT)
 elseif code==10698416 then local g=Duel.GetTargetCards(e):Filter(aux.NecroValleyFilter(s.ranvier),nil); if #g>0 then Duel.SendtoHand(g,nil,REASON_EFFECT) end end
end
function s.thf(c) return (c:IsSetCard(SET_KRAWLER) and c:IsType(TYPE_MONSTER) or c:IsSetCard(SET_WORLD_LEGACY) and c:IsSpellTrap()) and not c:IsCode(id) and c:IsAbleToHand() end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.thf),tp,LOCATION_GRAVE+LOCATION_REMOVED,0,1,nil) end Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_GRAVE+LOCATION_REMOVED) end
function s.thop(e,tp) local g=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.thf),tp,LOCATION_GRAVE+LOCATION_REMOVED,0,nil); if #g==0 then return end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND); local sg=g:Select(tp,1,1,nil); local first=sg:GetFirst(); local other=g:Filter(function(c,krawler) return krawler and c:IsSetCard(SET_WORLD_LEGACY) and c:IsSpellTrap() or not krawler and c:IsSetCard(SET_KRAWLER) and c:IsType(TYPE_MONSTER) end,nil,first:IsSetCard(SET_KRAWLER) and first:IsType(TYPE_MONSTER)); if #other>0 and Duel.SelectYesNo(tp,aux.Stringid(MSG_ID,2)) then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND); sg:Merge(other:Select(tp,1,1,nil)) end Duel.SendtoHand(sg,nil,REASON_EFFECT) end
''')

add(259247853, r'''
--Machina X-Krawler
--Omega references: Ghostrick Festival (c35871958), Grapha, Dragon Overlord of Dark World (c39552584)
local s,id=GetID(); local SET_KRAWLER=0x104; local MSG_ID=133247853
function s.initial_effect(c)
 local e0=aux.AddLinkProcedure(c,function(x) return x:IsLinkSetCard(SET_KRAWLER) end,2,4); e0:SetProperty(e0:GetProperty()|EFFECT_FLAG_SET_AVAILABLE); c:EnableReviveLimit()
 local e1=Effect.CreateEffect(c); e1:SetType(EFFECT_TYPE_FIELD); e1:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON); e1:SetRange(LOCATION_MZONE); e1:SetProperty(EFFECT_FLAG_PLAYER_TARGET); e1:SetTargetRange(1,0); e1:SetTarget(function(e,c) return not c:IsSetCard(SET_KRAWLER) end); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetType(EFFECT_TYPE_SINGLE); e2:SetCode(EFFECT_CANNOT_BE_EFFECT_TARGET); e2:SetProperty(EFFECT_FLAG_SINGLE_RANGE); e2:SetRange(LOCATION_MZONE); e2:SetValue(aux.tgoval); c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c); e3:SetDescription(aux.Stringid(MSG_ID,0)); e3:SetCategory(CATEGORY_TOGRAVE); e3:SetType(EFFECT_TYPE_QUICK_O); e3:SetCode(EVENT_CHAINING); e3:SetRange(LOCATION_MZONE); e3:SetCountLimit(1,id); e3:SetCondition(s.chcon); e3:SetCost(s.chcost); e3:SetTarget(s.chtg); e3:SetOperation(s.chop); c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c); e4:SetDescription(aux.Stringid(MSG_ID,1)); e4:SetCategory(CATEGORY_SPECIAL_SUMMON); e4:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O); e4:SetCode(EVENT_LEAVE_FIELD); e4:SetProperty(EFFECT_FLAG_DELAY); e4:SetCountLimit(1,id+100); e4:SetCondition(s.lvcon); e4:SetTarget(s.sptg); e4:SetOperation(s.spop); c:RegisterEffect(e4)
 c:SetUniqueOnField(1,0,id)
end
function s.chcon(e,tp,eg,ep,ev,re,r,rp) return rp==1-tp and re:IsActiveType(TYPE_SPELL+TYPE_TRAP) end
function s.cf(c) return c:IsSetCard(SET_KRAWLER) and c:IsType(TYPE_MONSTER) and c:IsAbleToRemoveAsCost() end
function s.chcost(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.cf,tp,LOCATION_GRAVE,0,2,nil) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_REMOVE); local g=Duel.SelectMatchingCard(tp,s.cf,tp,LOCATION_GRAVE,0,2,2,nil); Duel.Remove(g,POS_FACEUP,REASON_COST) end
function s.chtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(Card.IsAbleToGrave,tp,LOCATION_MZONE,0,1,nil) end end
function s.chop(e,tp,eg,ep,ev) Duel.ChangeTargetCard(ev,Group.CreateGroup()); Duel.ChangeChainOperation(ev,function(e,tp) local g=Duel.GetMatchingGroup(Card.IsAbleToGrave,tp,0,LOCATION_MZONE,nil); if #g>0 then Duel.Hint(HINT_SELECTMSG,1-tp,HINTMSG_TOGRAVE); local sg=g:Select(1-tp,1,1,nil); Duel.SendtoGrave(sg,REASON_EFFECT) end end) end
function s.lvcon(e,tp,eg,ep,ev,re,r,rp) local c=e:GetHandler(); return c:IsPreviousControler(tp) and c:IsPreviousLocation(LOCATION_MZONE) and c:IsPreviousPosition(POS_FACEUP) and (c:IsReason(REASON_BATTLE) or c:IsReason(REASON_EFFECT) and rp==1-tp) end
function s.spf(c,e,tp) return c:IsSetCard(SET_KRAWLER) and c:IsType(TYPE_LINK) and not c:IsCode(id) and c:IsCanBeSpecialSummoned(e,SUMMON_TYPE_LINK,tp,false,false) end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetLocationCountFromEx(tp)>1 and Duel.GetMatchingGroup(s.spf,tp,LOCATION_EXTRA,0,nil,e,tp):GetClassCount(Card.GetCode)>=2 end Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,nil,2,tp,LOCATION_EXTRA) end
function s.spop(e,tp) if Duel.GetLocationCountFromEx(tp)<2 then return end local g=Duel.GetMatchingGroup(s.spf,tp,LOCATION_EXTRA,0,nil,e,tp); local sg=aux.SelectUnselectGroup(g,e,tp,2,2,aux.dncheck,1,tp,HINTMSG_SPSUMMON); if #sg==2 then for tc in aux.Next(sg) do Duel.SpecialSummonStep(tc,SUMMON_TYPE_LINK,tp,tp,false,false,POS_FACEUP); tc:CompleteProcedure() end Duel.SpecialSummonComplete() end end
''')

add(259792415, r'''
--The Intergalataxian
--Omega references: Predaplant Verte Anaconda (c70369116), Battle Fader (c19665973), Yamato-no-Kami (c82841979)
local s,id=GetID(); local STRING_ID=133792415; local SET_GALACTICA=0x9c9
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c); e1:SetDescription(aux.Stringid(STRING_ID,0)); e1:SetCategory(CATEGORY_TOGRAVE+CATEGORY_SPECIAL_SUMMON); e1:SetType(EFFECT_TYPE_QUICK_O); e1:SetCode(EVENT_FREE_CHAIN); e1:SetRange(LOCATION_HAND); e1:SetHintTiming(0,TIMING_BATTLE_PHASE); e1:SetCountLimit(1,id); e1:SetCondition(function() return Duel.IsBattlePhase() end); e1:SetCost(s.cpcost); e1:SetTarget(s.cptg); e1:SetOperation(s.cpop); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetDescription(aux.Stringid(STRING_ID,1)); e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O); e2:SetCode(EVENT_BATTLE_DESTROYING); e2:SetRange(LOCATION_MZONE); e2:SetCountLimit(1,id+100); e2:SetCondition(s.bpcon); e2:SetOperation(s.endbp); c:RegisterEffect(e2)
 local e3=e2:Clone(); e3:SetCode(EVENT_BATTLE_DAMAGE); e3:SetCondition(s.bdcon); c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c); e4:SetDescription(aux.Stringid(STRING_ID,2)); e4:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_F); e4:SetCode(EVENT_PHASE+PHASE_END); e4:SetRange(LOCATION_MZONE); e4:SetCountLimit(1); e4:SetCondition(function(e,tp) return Duel.GetTurnPlayer()==1-tp end); e4:SetTarget(s.rtg); e4:SetOperation(s.rop); c:RegisterEffect(e4)
end
s.listed_series={SET_GALACTICA}
function s.cpf(c) return c:IsSetCard(SET_GALACTICA) and c:IsSpell() and c:IsAbleToGraveAsCost() and c:CheckActivateEffect(true,true,false)~=nil end
function s.cpcost(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.cpf,tp,LOCATION_DECK,0,1,nil) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOGRAVE); local tc=Duel.SelectMatchingCard(tp,s.cpf,tp,LOCATION_DECK,0,1,1,nil):GetFirst(); local te=tc:CheckActivateEffect(true,true,true); Duel.SendtoGrave(tc,REASON_COST); e:SetLabelObject(te) end
function s.cptg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end local te=e:GetLabelObject(); if not te then return end e:SetProperty(te:GetProperty()); local tg=te:GetTarget(); if tg then tg(e,tp,eg,ep,ev,re,r,rp,1) end; te:SetLabelObject(e:GetLabelObject()); e:SetLabelObject(te); Duel.ClearOperationInfo(0) end
function s.cpop(e,tp,eg,ep,ev,re,r,rp) local te=e:GetLabelObject(); if te then e:SetLabelObject(te:GetLabelObject()); local op=te:GetOperation(); if op then op(e,tp,eg,ep,ev,re,r,rp) end end local c=e:GetHandler(); if Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and c:IsRelateToEffect(e) then Duel.BreakEffect(); Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP) end end
function s.bpcon(e,tp,eg,ep,ev,re,r,rp) local bc=e:GetHandler():GetBattleTarget(); return Duel.GetTurnPlayer()==1-tp and bc~=nil and eg:IsContains(bc) end
function s.bdcon(e,tp,eg,ep) return Duel.GetTurnPlayer()==1-tp and ep==1-tp and eg:IsExists(function(c) return c:IsControler(tp) end,1,nil) end
function s.endbp(e,tp) Duel.SkipPhase(1-tp,PHASE_BATTLE,RESET_PHASE+PHASE_BATTLE,1) end
function s.rtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return e:GetHandler():IsAbleToHand() end Duel.SetOperationInfo(0,CATEGORY_TOHAND,e:GetHandler(),1,0,0) end
function s.rop(e) local c=e:GetHandler(); if c:IsRelateToEffect(e) then Duel.SendtoHand(c,nil,REASON_EFFECT) end end
''')

add(259844716, r'''
--Yurei
--Omega references: Effect Veiler (c97268402), Nikitama (c24701235), Yaksha (c94215860)
local s,id=GetID(); local STRING_ID=133844716
function s.initial_effect(c)
 local e0=Effect.CreateEffect(c); e0:SetType(EFFECT_TYPE_SINGLE); e0:SetCode(EFFECT_SPSUMMON_CONDITION); e0:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE); e0:SetValue(aux.FALSE); c:RegisterEffect(e0)
 local e1=Effect.CreateEffect(c); e1:SetDescription(aux.Stringid(STRING_ID,0)); e1:SetCategory(CATEGORY_NEGATE); e1:SetType(EFFECT_TYPE_QUICK_O); e1:SetCode(EVENT_CHAINING); e1:SetRange(LOCATION_HAND); e1:SetCountLimit(1,id); e1:SetCondition(s.negcon); e1:SetCost(s.negcost); e1:SetTarget(s.negtg); e1:SetOperation(s.negop); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetDescription(aux.Stringid(STRING_ID,1)); e2:SetCategory(CATEGORY_SUMMON+CATEGORY_ATKCHANGE); e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O); e2:SetCode(EVENT_ATTACK_ANNOUNCE); e2:SetRange(LOCATION_HAND); e2:SetCountLimit(1,id); e2:SetCondition(s.atkcon); e2:SetTarget(s.sumtg); e2:SetOperation(s.sumop); c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c); e3:SetDescription(aux.Stringid(STRING_ID,2)); e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_F); e3:SetCode(EVENT_PHASE+PHASE_END); e3:SetRange(LOCATION_MZONE+LOCATION_GRAVE+LOCATION_REMOVED); e3:SetCountLimit(1); e3:SetCondition(s.retcon); e3:SetTarget(s.rtg); e3:SetOperation(s.rop); c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c); e4:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_CONTINUOUS); e4:SetCode(EVENT_SUMMON_SUCCESS); e4:SetOperation(s.mark); c:RegisterEffect(e4); local e5=e4:Clone(); e5:SetCode(EVENT_FLIP); c:RegisterEffect(e5); local e6=e4:Clone(); e6:SetCode(EVENT_RELEASE); c:RegisterEffect(e6)
end
function s.negcon(e,tp,eg,ep,ev,re,r,rp) local ex,g,_,_,loc=Duel.GetOperationInfo(ev,CATEGORY_DESTROY); return rp==1-tp and re:IsHasCategory(CATEGORY_DESTROY) and ex and (g and g:IsExists(Card.IsOnField,1,nil) or loc and loc&LOCATION_ONFIELD~=0) and Duel.IsChainDisablable(ev) end
function s.spirit(c) return c:IsType(TYPE_SPIRIT) and c:IsReleasable() end
function s.negcost(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.spirit,tp,LOCATION_HAND+LOCATION_MZONE,0,1,e:GetHandler()) end Duel.ConfirmCards(1-tp,e:GetHandler()); Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RELEASE); local g=Duel.SelectMatchingCard(tp,s.spirit,tp,LOCATION_HAND+LOCATION_MZONE,0,1,1,e:GetHandler()); Duel.Release(g,REASON_COST) end
function s.negtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end Duel.SetOperationInfo(0,CATEGORY_NEGATE,eg,1,0,0) end
function s.negop(e,tp,eg,ep,ev) Duel.NegateEffect(ev) end
function s.atkcon(e,tp) local a=Duel.GetAttacker(); local d=Duel.GetAttackTarget(); return (a and a:IsControler(tp) and a:IsType(TYPE_SPIRIT)) or (d and d:IsControler(tp) and d:IsType(TYPE_SPIRIT)) end
function s.sumtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return e:GetHandler():IsSummonable(true,nil) end Duel.SetOperationInfo(0,CATEGORY_SUMMON,e:GetHandler(),1,0,0) end
function s.sumop(e,tp) local c=e:GetHandler(); local tc=Duel.GetAttacker(); if not (tc:IsControler(tp) and tc:IsType(TYPE_SPIRIT)) then tc=Duel.GetAttackTarget() end if c:IsRelateToEffect(e) and Duel.Summon(tp,c,true,nil)>0 and tc and tc:IsFaceup() then local ex=Effect.CreateEffect(c); ex:SetType(EFFECT_TYPE_SINGLE); ex:SetCode(EFFECT_SET_ATTACK_FINAL); ex:SetValue(tc:GetAttack()*2); ex:SetReset(RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END); tc:RegisterEffect(ex) end end
function s.mark(e) e:GetHandler():RegisterFlagEffect(id,RESET_EVENT+RESETS_STANDARD+RESET_PHASE+PHASE_END,0,1) end
function s.retcon(e) return e:GetHandler():GetFlagEffect(id)>0 end
function s.rtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return e:GetHandler():IsAbleToHand() end Duel.SetOperationInfo(0,CATEGORY_TOHAND,e:GetHandler(),1,0,0) end
function s.rop(e) local c=e:GetHandler(); if c:IsRelateToEffect(e) then Duel.SendtoHand(c,nil,REASON_EFFECT) end end
''')

add(259560506, r'''
--Hannya
--Omega references: Nikitama (c24701235), Shinobaroness Shade Peacock (c33325951)
local s,id=GetID(); local STRING_ID=133560506
function s.initial_effect(c)
 if not s.global_check then s.global_check=true; local ge=Effect.CreateEffect(c); ge:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS); ge:SetCode(EVENT_SUMMON_SUCCESS); ge:SetOperation(s.count); Duel.RegisterEffect(ge,0) end
 local e0=Effect.CreateEffect(c); e0:SetType(EFFECT_TYPE_SINGLE); e0:SetCode(EFFECT_SPSUMMON_CONDITION); e0:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE); e0:SetValue(aux.FALSE); c:RegisterEffect(e0)
 local e1=Effect.CreateEffect(c); e1:SetDescription(aux.Stringid(STRING_ID,0)); e1:SetCategory(CATEGORY_SUMMON); e1:SetType(EFFECT_TYPE_QUICK_O); e1:SetCode(EVENT_FREE_CHAIN); e1:SetRange(LOCATION_HAND); e1:SetCountLimit(1,id); e1:SetCondition(s.nscon); e1:SetCost(s.relcost); e1:SetTarget(s.nstg); e1:SetOperation(s.nsop); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetDescription(aux.Stringid(STRING_ID,1)); e2:SetCategory(CATEGORY_TOHAND); e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O); e2:SetCode(EVENT_RELEASE); e2:SetRange(LOCATION_GRAVE); e2:SetCountLimit(1,id+100); e2:SetCondition(s.thcon); e2:SetCost(aux.bfgcost); e2:SetTarget(s.thtg); e2:SetOperation(s.thop); c:RegisterEffect(e2)
 aux.EnableSpiritReturn(c,EVENT_SUMMON_SUCCESS,EVENT_FLIP)
end
function s.count(e,tp,eg) local p=Duel.GetTurnPlayer(); local old=Duel.GetFlagEffectLabel(p,id+500) or 0; Duel.ResetFlagEffect(p,id+500); Duel.RegisterFlagEffect(p,id+500,RESET_PHASE+PHASE_END,0,1,old+#eg) end
function s.nscon(e,tp) return (Duel.GetFlagEffectLabel(tp,id+500) or 0)>=2 end
function s.relcost(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return e:GetHandler():IsReleasable() end Duel.Release(e:GetHandler(),REASON_COST) end
function s.nsf(c) return c:IsType(TYPE_SPIRIT) and c:IsSummonable(true,nil) end
function s.nstg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.nsf,tp,LOCATION_HAND,0,1,nil) end end
function s.nsop(e,tp) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SUMMON); local g=Duel.SelectMatchingCard(tp,s.nsf,tp,LOCATION_HAND,0,1,1,nil); local tc=g:GetFirst(); if tc then Duel.Summon(tp,tc,true,nil) end end
function s.thcon(e,tp,eg) return eg:IsExists(Card.IsType,1,nil,TYPE_SPIRIT) end
function s.thf(c) return c:IsType(TYPE_SPIRIT) and c:IsAbleToHand() end
function s.compatible(c,g) return g:IsExists(function(x,c) return x~=c and x:GetLevel()~=c:GetLevel() and x:GetAttribute()~=c:GetAttribute() end,1,nil,c) end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk) local g=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.thf),tp,LOCATION_GRAVE,0,nil); if chk==0 then return g:IsExists(s.compatible,1,nil,g) end Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,2,tp,LOCATION_GRAVE) end
function s.thop(e,tp) local g=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.thf),tp,LOCATION_GRAVE,0,nil); local first=g:Filter(s.compatible,nil,g); if #first==0 then return end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND); local a=first:Select(tp,1,1,nil):GetFirst(); local rest=g:Filter(function(c,a) return c~=a and c:GetLevel()~=a:GetLevel() and c:GetAttribute()~=a:GetAttribute() end,nil,a); if #rest==0 then return end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND); local b=rest:Select(tp,1,1,nil):GetFirst(); Duel.SendtoHand(Group.FromCards(a,b),nil,REASON_EFFECT) end
''')

add(259635008, r'''
--Abe no Seimei
--Omega references: Infinite Cards (c94163677), Izanagi (c06544078), Shinobaron Peacock (c52900000)
local s,id=GetID(); local STRING_ID=133635008
function s.initial_effect(c)
 c:EnableReviveLimit(); aux.AddSynchroProcedure(c,function(x) return x:IsType(TYPE_TUNER) and x:IsType(TYPE_SPIRIT) end,aux.NonTuner(nil),1)
 local e1=Effect.CreateEffect(c); e1:SetDescription(aux.Stringid(STRING_ID,0)); e1:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_F); e1:SetCode(EVENT_SPSUMMON_SUCCESS); e1:SetProperty(EFFECT_FLAG_DELAY); e1:SetOperation(s.handop); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetDescription(aux.Stringid(STRING_ID,1)); e2:SetCategory(CATEGORY_ATKCHANGE); e2:SetType(EFFECT_TYPE_IGNITION); e2:SetRange(LOCATION_MZONE); e2:SetProperty(EFFECT_FLAG_CARD_TARGET); e2:SetCountLimit(1); e2:SetTarget(s.lvtg); e2:SetOperation(s.lvop); c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c); e3:SetDescription(aux.Stringid(STRING_ID,2)); e3:SetCategory(CATEGORY_TOEXTRA+CATEGORY_SPECIAL_SUMMON); e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_F); e3:SetCode(EVENT_PHASE+PHASE_END); e3:SetRange(LOCATION_MZONE); e3:SetCountLimit(1); e3:SetCondition(s.retcon); e3:SetTarget(s.rettg); e3:SetOperation(s.retop); c:RegisterEffect(e3)
end
function s.handop(e,tp) local ex=Effect.CreateEffect(e:GetHandler()); ex:SetType(EFFECT_TYPE_FIELD); ex:SetCode(EFFECT_HAND_LIMIT); ex:SetProperty(EFFECT_FLAG_PLAYER_TARGET); ex:SetTargetRange(1,0); ex:SetValue(7); ex:SetReset(RESET_PHASE+PHASE_END,Duel.GetTurnPlayer()==tp and 2 or 3); Duel.RegisterEffect(ex,tp) end
function s.lvf(c) return c:IsFaceup() and c:IsType(TYPE_SPIRIT) and c:HasLevel() end
function s.lvtg(e,tp,eg,ep,ev,re,r,rp,chk,chkc) if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and s.lvf(chkc) and chkc~=e:GetHandler() end if chk==0 then return Duel.IsExistingTarget(s.lvf,tp,LOCATION_MZONE,0,1,e:GetHandler()) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_FACEUP); Duel.SelectTarget(tp,s.lvf,tp,LOCATION_MZONE,0,1,1,e:GetHandler()) end
function s.lvop(e,tp) local c=e:GetHandler(); local tc=Duel.GetFirstTarget(); if not tc:IsRelateToEffect(e) or not tc:IsFaceup() then return end local up=tc:GetLevel()<12; local down=tc:GetLevel()>1; if not (up or down) then return end local op=up and down and Duel.SelectOption(tp,60,61) or (up and 0 or 1); local ex=Effect.CreateEffect(c); ex:SetType(EFFECT_TYPE_SINGLE); ex:SetCode(EFFECT_UPDATE_LEVEL); ex:SetValue(op==0 and 1 or -1); ex:SetReset(RESET_EVENT+RESETS_STANDARD); tc:RegisterEffect(ex); local ea=Effect.CreateEffect(c); ea:SetType(EFFECT_TYPE_SINGLE); ea:SetCode(EFFECT_UPDATE_ATTACK); ea:SetValue(tc:GetBaseAttack()); ea:SetReset(RESET_EVENT+RESETS_STANDARD); c:RegisterEffect(ea) end
function s.retcon(e) return e:GetHandler():IsSummonType(SUMMON_TYPE_SPECIAL) and e:GetHandler():GetTurnID()==Duel.GetTurnCount() end
function s.rettg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return e:GetHandler():IsAbleToExtra() end Duel.SetOperationInfo(0,CATEGORY_TOEXTRA,e:GetHandler(),1,0,0) end
function s.sf(c,e,tp,tuner) return c:IsType(TYPE_SPIRIT) and c:IsType(tuner and TYPE_TUNER or TYPE_MONSTER) and (not tuner and not c:IsType(TYPE_TUNER) or tuner) and c:IsCanBeSpecialSummoned(e,0,tp,true,true) end
function s.retop(e,tp) local c=e:GetHandler(); if Duel.SendtoDeck(c,nil,SEQ_DECKSHUFFLE,REASON_EFFECT)==0 then return end local tun=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.sf),tp,LOCATION_GRAVE,0,nil,e,tp,true); local non=Duel.GetMatchingGroup(aux.NecroValleyFilter(s.sf),tp,LOCATION_GRAVE,0,nil,e,tp,false); local pairs=Group.CreateGroup(); local a=tun:GetFirst(); while a do local b=non:GetFirst(); while b do if a:GetLevel()+b:GetLevel()==6 then pairs:AddCard(a); pairs:AddCard(b) end b=non:GetNext() end a=tun:GetNext() end if #pairs<2 or Duel.GetLocationCount(tp,LOCATION_MZONE)<2 then return end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SPSUMMON); local t=tun:Filter(function(x,n) return n:IsExists(function(y,x) return x:GetLevel()+y:GetLevel()==6 end,1,nil,x) end,nil,non):Select(tp,1,1,nil):GetFirst(); local n=non:Filter(function(x,t) return x:GetLevel()+t:GetLevel()==6 end,nil,t):Select(tp,1,1,nil):GetFirst(); Duel.SpecialSummon(Group.FromCards(t,n),0,tp,tp,true,true,POS_FACEUP) end
''')

add(259221974, r'''
--Melantha, Keeper of Lamentations
--Omega references: Battlewasp - Dart the Hunter (c91283212), Artifact Scythe (c20292186)
local s,id=GetID(); local STRING_ID=133221974
function s.initial_effect(c)
 if not s.global_check then s.global_check=true; local ge=Effect.CreateEffect(c); ge:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS); ge:SetCode(EVENT_SPSUMMON_SUCCESS); ge:SetOperation(s.exmark); Duel.RegisterEffect(ge,0) end
 c:EnableReviveLimit(); local e0=Effect.CreateEffect(c); e0:SetType(EFFECT_TYPE_SINGLE); e0:SetCode(EFFECT_SPSUMMON_CONDITION); e0:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE); e0:SetValue(function(e,se) return se and se:GetHandler()==e:GetHandler() end); c:RegisterEffect(e0)
 local e1=Effect.CreateEffect(c); e1:SetType(EFFECT_TYPE_SINGLE); e1:SetCode(EFFECT_INDESTRUCTABLE_BATTLE); e1:SetValue(1); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetType(EFFECT_TYPE_FIELD); e2:SetCode(EFFECT_INDESTRUCTABLE_BATTLE); e2:SetRange(LOCATION_MZONE); e2:SetTargetRange(0,LOCATION_MZONE); e2:SetTarget(function(e,c) return c==e:GetHandler():GetBattleTarget() end); e2:SetValue(1); c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c); e3:SetDescription(aux.Stringid(STRING_ID,0)); e3:SetCategory(CATEGORY_SPECIAL_SUMMON); e3:SetType(EFFECT_TYPE_QUICK_O); e3:SetCode(EVENT_FREE_CHAIN); e3:SetRange(LOCATION_HAND); e3:SetCountLimit(1,id); e3:SetCondition(s.spcon); e3:SetTarget(s.sptg); e3:SetOperation(s.spop); c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c); e4:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS); e4:SetCode(EVENT_SPSUMMON_SUCCESS); e4:SetRange(LOCATION_MZONE); e4:SetCondition(s.taxcon); e4:SetOperation(s.taxop); c:RegisterEffect(e4)
end
function s.exmark(e,tp,eg) for p=0,1 do if eg:IsExists(function(c,p) return c:IsControler(p) and c:IsPreviousLocation(LOCATION_EXTRA) end,1,nil,p) then Duel.RegisterFlagEffect(p,id,RESET_PHASE+PHASE_END,0,1) end end end
function s.spcon(e,tp) return Duel.GetFieldGroupCount(tp,LOCATION_ONFIELD,0)==0 and Duel.GetFlagEffect(1-tp,id)>0 end
function s.sptg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetLocationCount(tp,LOCATION_MZONE)>0 and e:GetHandler():IsCanBeSpecialSummoned(e,0,tp,false,false) end Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,e:GetHandler(),1,0,0) end
function s.spop(e,tp) local c=e:GetHandler(); if c:IsRelateToEffect(e) then Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP) end end
function s.taxcon(e,tp,eg) return eg:IsExists(function(c,p) return c:IsControler(p) and c:IsPreviousLocation(LOCATION_EXTRA) end,1,nil,1-tp) end
function s.taxop(e,tp,eg) local p=1-tp; local sg=eg:Filter(function(c,p) return c:IsControler(p) and c:IsPreviousLocation(LOCATION_EXTRA) end,nil,p); local can_shuffle=Duel.IsExistingMatchingCard(Card.IsAbleToDeck,p,LOCATION_HAND,0,1,nil); local op=can_shuffle and Duel.SelectOption(p,aux.Stringid(STRING_ID,1),aux.Stringid(STRING_ID,2)) or 1; if op==0 then Duel.Hint(HINT_SELECTMSG,p,HINTMSG_TODECK); local g=Duel.SelectMatchingCard(p,Card.IsAbleToDeck,p,LOCATION_HAND,0,1,1,nil); Duel.SendtoDeck(g,nil,SEQ_DECKSHUFFLE,REASON_EFFECT) else Duel.SendtoGrave(sg,REASON_RULE) end end
''')

add(259797813, r'''
--Nautica Musicale
--Omega references: Fire Formation - Tenki (c57103969), Shared Ride (c01372887)
local s,id=GetID(); local STRING_ID=133797813; local SET_NAUTICA=0x8f0
function s.initial_effect(c)
 local e1=Effect.CreateEffect(c); e1:SetDescription(aux.Stringid(STRING_ID,0)); e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH); e1:SetType(EFFECT_TYPE_ACTIVATE); e1:SetCode(EVENT_FREE_CHAIN); e1:SetTarget(s.thtg); e1:SetOperation(s.thop); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetDescription(aux.Stringid(STRING_ID,1)); e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O); e2:SetCode(EVENT_CHAIN_SOLVED); e2:SetRange(LOCATION_SZONE); e2:SetCondition(s.chcon); e2:SetTarget(s.chtg); e2:SetOperation(s.chop); c:RegisterEffect(e2)
 c:SetUniqueOnField(1,0,id)
end
function s.nf(c) return c:IsSetCard(SET_NAUTICA) and c:IsType(TYPE_MONSTER) and c:IsAbleToHand() end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return true end if Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.nf),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,nil) then Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK+LOCATION_GRAVE) end end
function s.thop(e,tp) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND); local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.nf),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,1,nil); if #g>0 then Duel.SendtoHand(g,nil,REASON_EFFECT); Duel.ConfirmCards(1-tp,g) end end
function s.chcon(e,tp,eg,ep,ev,re,r,rp) local rc=re:GetHandler(); local ex,g,p,_,loc=Duel.GetOperationInfo(ev,CATEGORY_SPECIAL_SUMMON); return rp==tp and ex and g and p==tp and loc&LOCATION_HAND~=0 and rc:IsSetCard(SET_NAUTICA) and g:IsExists(function(c) return c:IsSetCard(SET_NAUTICA) and c:IsType(TYPE_MONSTER) end,1,nil) end
function s.oppmf(c) return c:IsType(TYPE_MONSTER) and c:IsAbleToHand() end
function s.chtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsPlayerCanDraw(tp,1) and Duel.IsExistingMatchingCard(s.oppmf,tp,0,LOCATION_DECK,1,nil) end Duel.SetOperationInfo(0,CATEGORY_DRAW,nil,0,tp,1); Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,1-tp,LOCATION_DECK) end
function s.chop(e,tp) if Duel.Draw(tp,1,REASON_EFFECT)==0 then return end local p=1-tp; Duel.Hint(HINT_SELECTMSG,p,HINTMSG_ATOHAND); local g=Duel.SelectMatchingCard(p,function(c) return c:IsType(TYPE_MONSTER) and c:IsAbleToHand() end,p,LOCATION_DECK,0,1,1,nil); local tc=g:GetFirst(); if not tc then return end Duel.SendtoHand(tc,nil,REASON_EFFECT); Duel.ConfirmCards(tp,tc); if Duel.GetFieldGroupCount(tp,LOCATION_HAND,0)>0 then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK); local bg=Duel.SelectMatchingCard(tp,Card.IsAbleToDeck,tp,LOCATION_HAND,0,1,1,nil); Duel.SendtoDeck(bg,nil,SEQ_DECKBOTTOM,REASON_EFFECT) end Duel.Recover(tp,200,REASON_EFFECT); local code=tc:GetCode(); local ex=Effect.CreateEffect(e:GetHandler()); ex:SetType(EFFECT_TYPE_FIELD); ex:SetCode(EFFECT_CANNOT_ACTIVATE); ex:SetProperty(EFFECT_FLAG_PLAYER_TARGET); ex:SetTargetRange(0,1); ex:SetValue(function(e,re) return re:GetHandler():IsCode(code) end); ex:SetReset(RESET_PHASE+PHASE_END,2); Duel.RegisterEffect(ex,tp) end
''')

add(259941091, r'''
--Nautica Oceanica
--Omega references: Amano-Iwato (c32181268), Summon Over (c48032131)
local s,id=GetID(); local STRING_ID=133941091; local SET_NAUTICA=0x8f0
function s.initial_effect(c)
 local e0=Effect.CreateEffect(c); e0:SetType(EFFECT_TYPE_ACTIVATE); e0:SetCode(EVENT_FREE_CHAIN); c:RegisterEffect(e0)
 local e1=Effect.CreateEffect(c); e1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS); e1:SetCode(EVENT_SUMMON_SUCCESS); e1:SetRange(LOCATION_FZONE); e1:SetOperation(s.lockop); c:RegisterEffect(e1); local e2=e1:Clone(); e2:SetCode(EVENT_SPSUMMON_SUCCESS); c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c); e3:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS); e3:SetCode(EVENT_CHAIN_SOLVED); e3:SetRange(LOCATION_FZONE); e3:SetCondition(s.chcon); e3:SetOperation(s.chop); c:RegisterEffect(e3)
end
function s.source_active(e) local fc=e:GetOwner(); return fc:IsFaceup() and fc:IsLocation(LOCATION_FZONE) and fc:GetFieldID()==e:GetLabel() end
function s.lockop(e,tp,eg) local fc=e:GetHandler(); for tc in aux.Next(eg) do if tc:IsAttackPos() and tc:IsPreviousLocation(LOCATION_HAND) then local ex=Effect.CreateEffect(fc); ex:SetType(EFFECT_TYPE_SINGLE); ex:SetCode(EFFECT_CANNOT_TRIGGER); ex:SetCondition(s.source_active); ex:SetLabel(fc:GetFieldID()); ex:SetReset(RESET_EVENT+RESETS_STANDARD); tc:RegisterEffect(ex) end end end
function s.chcon(e,tp,eg,ep,ev,re,r,rp) if rp~=tp or not re:GetHandler():IsSetCard(SET_NAUTICA) then return false end local ex,_,_,p,loc=Duel.GetOperationInfo(ev,CATEGORY_SPECIAL_SUMMON); if not ex then ex,_,_,p,loc=Duel.GetOperationInfo(ev,CATEGORY_SUMMON) end if ex and loc and loc&LOCATION_HAND~=0 then e:SetLabel(p); return true end return false end
function s.nf(c) return c:IsSetCard(SET_NAUTICA) and c:IsType(TYPE_MONSTER) and c:IsAbleToHand() end
function s.chop(e,tp)
 if not Duel.SelectYesNo(tp,aux.Stringid(STRING_ID,0)) then return end
 if e:GetLabel()==tp then
  local p=1-tp; if Duel.GetLocationCount(p,LOCATION_MZONE)<=0 then return end
  local normal=function(c) return c:IsSummonable(true,nil) end
  local special=function(c,e,p) return c:IsCanBeSpecialSummoned(e,0,p,false,false,POS_FACEUP_ATTACK) end
  local b1=Duel.IsExistingMatchingCard(normal,p,LOCATION_HAND,0,1,nil); local b2=Duel.IsExistingMatchingCard(special,p,LOCATION_HAND,0,1,nil,e,p)
  if not (b1 or b2) then return end
  local choice=b1 and b2 and Duel.SelectOption(p,1151,1152) or (b1 and 0 or 1)
  Duel.Hint(HINT_SELECTMSG,p,choice==0 and HINTMSG_SUMMON or HINTMSG_SPSUMMON)
  local g=Duel.SelectMatchingCard(p,choice==0 and normal or special,p,LOCATION_HAND,0,1,1,nil,e,p); local tc=g:GetFirst(); local done=0
  if tc then if choice==0 then done=Duel.Summon(p,tc,true,nil) else done=Duel.SpecialSummon(tc,0,p,p,false,false,POS_FACEUP_ATTACK) end end
  if done>0 then local ea=Effect.CreateEffect(e:GetHandler()); ea:SetType(EFFECT_TYPE_SINGLE); ea:SetCode(EFFECT_SET_ATTACK_FINAL); ea:SetValue(0); ea:SetReset(RESET_EVENT+RESETS_STANDARD); tc:RegisterEffect(ea); local ei=Effect.CreateEffect(e:GetHandler()); ei:SetType(EFFECT_TYPE_SINGLE); ei:SetCode(EFFECT_IMMUNE_EFFECT); ei:SetValue(function(e,re) return re:GetOwner()==e:GetOwner() end); ei:SetReset(RESET_EVENT+RESETS_STANDARD); tc:RegisterEffect(ei) end
 elseif Duel.IsExistingMatchingCard(aux.NecroValleyFilter(s.nf),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,nil) then
  Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND); local g=Duel.SelectMatchingCard(tp,aux.NecroValleyFilter(s.nf),tp,LOCATION_DECK+LOCATION_GRAVE,0,1,1,nil)
  if Duel.SendtoHand(g,nil,REASON_EFFECT)>0 then Duel.ConfirmCards(1-tp,g); if Duel.GetFieldGroupCount(tp,LOCATION_HAND,0)>0 then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TODECK); local bg=Duel.SelectMatchingCard(tp,Card.IsAbleToDeck,tp,LOCATION_HAND,0,1,1,nil); Duel.SendtoDeck(bg,nil,SEQ_DECKBOTTOM,REASON_EFFECT) end end
 end
end
''')

add(259883230, r'''
--Release of the Pyre
--Omega references: Fire Formation - Tenki (c57103969), Ground Collapse (c90502999)
local s,id=GetID(); local SET_PYRE=0x3135
function s.initial_effect(c)
 local e0=Effect.CreateEffect(c); e0:SetType(EFFECT_TYPE_ACTIVATE); e0:SetCode(EVENT_FREE_CHAIN); c:RegisterEffect(e0)
 local e1=Effect.CreateEffect(c); e1:SetCategory(CATEGORY_TOHAND+CATEGORY_SEARCH); e1:SetType(EFFECT_TYPE_IGNITION); e1:SetRange(LOCATION_SZONE); e1:SetCountLimit(1,id); e1:SetCondition(function(e,tp) return Duel.IsExistingMatchingCard(Card.IsRace,tp,LOCATION_MZONE,0,1,nil,RACE_PYRO) end); e1:SetTarget(s.thtg); e1:SetOperation(s.thop); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetType(EFFECT_TYPE_FIELD); e2:SetCode(EFFECT_CANNOT_SPECIAL_SUMMON); e2:SetRange(LOCATION_SZONE); e2:SetProperty(EFFECT_FLAG_PLAYER_TARGET); e2:SetTargetRange(1,0); e2:SetTarget(function(e,c) return not c:IsRace(RACE_PYRO) end); c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c); e3:SetType(EFFECT_TYPE_IGNITION); e3:SetRange(LOCATION_SZONE); e3:SetProperty(EFFECT_FLAG_CARD_TARGET); e3:SetCountLimit(1,id+100); e3:SetTarget(s.locktg); e3:SetOperation(s.lockop); c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c); e4:SetCategory(CATEGORY_DRAW+CATEGORY_TOGRAVE); e4:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O); e4:SetCode(EVENT_LEAVE_FIELD); e4:SetRange(LOCATION_SZONE); e4:SetProperty(EFFECT_FLAG_DELAY); e4:SetCountLimit(1,id+200); e4:SetCondition(s.drcon); e4:SetTarget(s.drtg); e4:SetOperation(s.drop); c:RegisterEffect(e4)
end
function s.thf(c) return c:IsSetCard(SET_PYRE) and c:IsSpell() and c:IsAbleToHand() end
function s.thtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.thf,tp,LOCATION_DECK,0,1,nil) end Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_DECK) end
function s.thop(e,tp) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND); local g=Duel.SelectMatchingCard(tp,s.thf,tp,LOCATION_DECK,0,1,1,nil); if #g>0 then Duel.SendtoHand(g,nil,REASON_EFFECT); Duel.ConfirmCards(1-tp,g) end end
function s.pointsempty(c,tp) local zone=c:GetLinkedZone(1-tp)&0x1f; for seq=0,4 do if zone&(1<<seq)~=0 and Duel.CheckLocation(1-tp,LOCATION_MZONE,seq) then return true end end return false end
function s.lk(c,tp) return c:IsFaceup() and c:IsSetCard(SET_PYRE) and c:IsType(TYPE_LINK) and c:GetSequence()>4 and s.pointsempty(c,tp) end
function s.locktg(e,tp,eg,ep,ev,re,r,rp,chk,chkc) if chkc then return chkc:IsControler(tp) and chkc:IsLocation(LOCATION_MZONE) and s.lk(chkc,tp) end if chk==0 then return Duel.IsExistingTarget(s.lk,tp,LOCATION_MZONE,0,1,nil,tp) end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_FACEUP); Duel.SelectTarget(tp,s.lk,tp,LOCATION_MZONE,0,1,1,nil,tp) end
function s.lockcon(e) local tc=e:GetLabelObject(); return tc and tc:IsFaceup() and tc:IsLocation(LOCATION_MZONE) and tc:GetSequence()>4 and s.pointsempty(tc,e:GetLabel()) end
function s.lockop(e,tp) local tc=Duel.GetFirstTarget(); if not tc or not tc:IsRelateToEffect(e) then return end local ex=Effect.CreateEffect(e:GetHandler()); ex:SetType(EFFECT_TYPE_FIELD); ex:SetCode(EFFECT_DISABLE_FIELD); ex:SetCondition(s.lockcon); ex:SetLabel(tp); ex:SetLabelObject(tc); ex:SetValue(0x60<<16); Duel.RegisterEffect(ex,tp) end
function s.drcon(e,tp,eg,ep,ev,re,r,rp) return eg:IsExists(function(c,tp) return c:IsPreviousControler(tp) and c:IsPreviousLocation(LOCATION_MZONE) and c:IsSetCard(SET_PYRE) and c:IsType(TYPE_MONSTER) and c:IsReason(REASON_EFFECT) and c:GetReasonPlayer()==1-tp end,1,nil,tp) end
function s.drtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsPlayerCanDraw(tp,1) end Duel.SetOperationInfo(0,CATEGORY_DRAW,nil,0,tp,1) end
function s.drop(e,tp) if Duel.Draw(tp,1,REASON_EFFECT)>0 and e:GetHandler():IsRelateToEffect(e) then Duel.BreakEffect(); Duel.SendtoGrave(e:GetHandler(),REASON_EFFECT) end end
''')

add(259882493, r'''
--Vaylantz Destroyer Patrician
--Omega references: Vaylantz Genesis Grand Duke (c76075139), Vaylantz Dominator Duke (c13291886)
local s,id=GetID(); local MSG_ID=133882493; local SET_VAYLANTZ=0x17d
function s.initial_effect(c)
 c:EnableReviveLimit(); aux.AddFusionProcFunRep(c,function(x) return x:IsFusionSetCard(SET_VAYLANTZ) end,2,true); aux.EnablePendulumAttribute(c,false)
 local e0=Effect.CreateEffect(c); e0:SetType(EFFECT_TYPE_SINGLE); e0:SetCode(EFFECT_SPSUMMON_CONDITION); e0:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE); e0:SetValue(s.splimit); c:RegisterEffect(e0)
 local e1=Effect.CreateEffect(c); e1:SetType(EFFECT_TYPE_FIELD); e1:SetCode(EFFECT_SPSUMMON_PROC); e1:SetProperty(EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE); e1:SetRange(LOCATION_EXTRA); e1:SetCountLimit(1,id+EFFECT_COUNT_CODE_OATH); e1:SetCondition(s.excon); e1:SetTarget(s.extg); e1:SetOperation(s.exop); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetType(EFFECT_TYPE_IGNITION); e2:SetRange(LOCATION_PZONE); e2:SetCountLimit(1,id); e2:SetTarget(s.ptg); e2:SetOperation(s.pop); c:RegisterEffect(e2)
 local e3=Effect.CreateEffect(c); e3:SetCategory(CATEGORY_COIN); e3:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O); e3:SetCode(EVENT_SPSUMMON_SUCCESS); e3:SetProperty(EFFECT_FLAG_DELAY); e3:SetCountLimit(1,id+100); e3:SetOperation(s.coinop); c:RegisterEffect(e3); local e4=e3:Clone(); e4:SetCode(EVENT_MOVE); e4:SetCondition(function(e) local c=e:GetHandler(); return c:IsLocation(LOCATION_MZONE) and c:GetPreviousLocation()==LOCATION_MZONE and c:GetPreviousSequence()~=c:GetSequence() end); c:RegisterEffect(e4)
 local e5=Effect.CreateEffect(c); e5:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O); e5:SetCode(EVENT_DESTROYED); e5:SetProperty(EFFECT_FLAG_DELAY); e5:SetCondition(function(e,tp) local c=e:GetHandler(); return c:IsPreviousControler(tp) and c:IsPreviousLocation(LOCATION_MZONE) and c:IsPreviousPosition(POS_FACEUP) and c:IsPreviousSummonType(SUMMON_TYPE_SPECIAL) end); e5:SetTarget(s.pztg); e5:SetOperation(s.pzop); c:RegisterEffect(e5)
end
function s.splimit(e,se,sp,st) local c=e:GetHandler(); return not (c:IsLocation(LOCATION_EXTRA) and c:IsFacedown()) or st&SUMMON_TYPE_FUSION==SUMMON_TYPE_FUSION or se==e end
function s.rel(c,tp,sc) local seq=c:GetSequence(); return c:IsFaceup() and c:IsSetCard(SET_VAYLANTZ) and c:IsReleasable() and Duel.IsExistingMatchingCard(function(x,s) return x~=c and x:IsFaceup() and x:IsSetCard(SET_VAYLANTZ) and x:GetSequence()==s end,tp,LOCATION_ONFIELD,0,1,nil,seq) end
function s.excon(e,c) if c==nil then return true end local tp=c:GetControler(); return c:IsFacedown() and Duel.IsExistingMatchingCard(s.rel,tp,LOCATION_MZONE,0,1,nil,tp,c) and Duel.GetLocationCountFromEx(tp,tp,nil,c)>0 end
function s.extg(e,tp,eg,ep,ev,re,r,rp,chk,c) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_RELEASE); local g=Duel.SelectMatchingCard(tp,s.rel,tp,LOCATION_MZONE,0,1,1,nil,tp,c); if #g==0 then return false end e:SetLabelObject(g:GetFirst()); return true end
function s.exop(e,tp) Duel.Release(e:GetLabelObject(),REASON_SPSUMMON) end
function s.movef(c) local seq=c:GetSequence(); return c:IsLocation(LOCATION_MZONE) and seq<5 and (seq>0 and Duel.CheckLocation(c:GetControler(),LOCATION_MZONE,seq-1) or seq<4 and Duel.CheckLocation(c:GetControler(),LOCATION_MZONE,seq+1)) end
function s.ptg(e,tp,eg,ep,ev,re,r,rp,chk) local c=e:GetHandler(); local b1=c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEUP,tp,1<<c:GetSequence()); local b2=Duel.IsExistingMatchingCard(s.movef,tp,LOCATION_MZONE,0,1,nil); if chk==0 then return b1 or b2 end local op=b1 and b2 and Duel.SelectOption(tp,aux.Stringid(MSG_ID,0),aux.Stringid(MSG_ID,1)) or (b1 and 0 or 1); e:SetLabel(op); if op==0 then Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,0,0) end end
function s.pop(e,tp) local c=e:GetHandler(); if not c:IsRelateToEffect(e) then return end if e:GetLabel()==0 then Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP,1<<c:GetSequence()); return end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_FACEUP); local tc=Duel.SelectMatchingCard(tp,s.movef,tp,LOCATION_MZONE,0,1,1,nil):GetFirst(); if tc then local seq=tc:GetSequence(); local flag=0; if seq>0 and Duel.CheckLocation(tp,LOCATION_MZONE,seq-1) then flag=flag|(1<<(seq-1)) end; if seq<4 and Duel.CheckLocation(tp,LOCATION_MZONE,seq+1) then flag=flag|(1<<(seq+1)) end; Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOZONE); local z=Duel.SelectDisableField(tp,1,LOCATION_MZONE,0,~flag); Duel.MoveSequence(tc,math.log(z,2)) end end
function s.vmon(c) return c:IsSetCard(SET_VAYLANTZ) and c:IsType(TYPE_MONSTER) and (not c:IsLocation(LOCATION_EXTRA) or c:IsFaceup()) end
function s.vst(c) return c:IsSetCard(SET_VAYLANTZ) and c:IsSpellTrap() and c:IsSSetable() end
function s.coinop(e,tp) local res=Duel.TossCoin(tp,1); if res==COIN_HEADS and Duel.GetLocationCount(tp,LOCATION_PZONE)>0 then local g=Duel.GetMatchingGroup(s.vmon,tp,LOCATION_DECK+LOCATION_EXTRA,0,nil); if #g>0 then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOFIELD); local tc=g:Select(tp,1,1,nil):GetFirst(); Duel.MoveToField(tc,tp,tp,LOCATION_PZONE,POS_FACEUP,true) end elseif res==COIN_TAILS then Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_SET); local g=Duel.SelectMatchingCard(tp,s.vst,tp,LOCATION_DECK,0,1,1,nil); if #g>0 then Duel.SSet(tp,g) end end end
function s.pztg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.GetLocationCount(tp,LOCATION_PZONE)>0 and e:GetHandler():IsAbleToExtra() end end
function s.pzop(e,tp) local c=e:GetHandler(); if c:IsRelateToEffect(e) then Duel.MoveToField(c,tp,tp,LOCATION_PZONE,POS_FACEUP,true) end end
''')

add(259537607, r'''
--Arktos X - Vaylantz Game Master
--Omega references: Vaylantz Genesis Grand Duke (c76075139), Vaylantz Voltage Viscount (c41802073)
local s,id=GetID(); local MSG_ID=133537607; local SET_VAYLANTZ=0x17d
function s.initial_effect(c)
 aux.EnablePendulumAttribute(c)
 local e1=Effect.CreateEffect(c); e1:SetDescription(aux.Stringid(MSG_ID,0)); e1:SetCategory(CATEGORY_SPECIAL_SUMMON); e1:SetType(EFFECT_TYPE_IGNITION); e1:SetRange(LOCATION_PZONE); e1:SetCountLimit(1,id); e1:SetCondition(s.pcon); e1:SetTarget(s.ptg); e1:SetOperation(s.pop); c:RegisterEffect(e1)
 local e2=Effect.CreateEffect(c); e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_F); e2:SetCode(EVENT_SUMMON_SUCCESS); e2:SetRange(LOCATION_MZONE); e2:SetCondition(s.mvcon); e2:SetOperation(s.mvop); c:RegisterEffect(e2); local e3=e2:Clone(); e3:SetCode(EVENT_SPSUMMON_SUCCESS); c:RegisterEffect(e3)
 local e4=Effect.CreateEffect(c); e4:SetDescription(aux.Stringid(MSG_ID,1)); e4:SetType(EFFECT_TYPE_QUICK_O); e4:SetCode(EVENT_FREE_CHAIN); e4:SetRange(LOCATION_MZONE); e4:SetCountLimit(1,id+100); e4:SetTarget(s.qtg); e4:SetOperation(s.qop); c:RegisterEffect(e4)
end
function s.pcon(e,tp) return Duel.IsExistingMatchingCard(function(c) return c:IsFaceup() and c:IsSetCard(SET_VAYLANTZ) and c:IsType(TYPE_FUSION) end,tp,LOCATION_MZONE,0,1,nil) end
function s.ptg(e,tp,eg,ep,ev,re,r,rp,chk) local c=e:GetHandler(); if chk==0 then return c:IsCanBeSpecialSummoned(e,0,tp,false,false,POS_FACEUP,tp,1<<c:GetSequence()) end Duel.SetOperationInfo(0,CATEGORY_SPECIAL_SUMMON,c,1,0,0) end
function s.pop(e,tp) local c=e:GetHandler(); if c:IsRelateToEffect(e) then Duel.SpecialSummon(c,0,tp,tp,false,false,POS_FACEUP,tp,1<<c:GetSequence()) end end
function s.mvcon(e,tp,eg) return #eg==1 and eg:GetFirst():IsControler(1-tp) and eg:GetFirst():IsLocation(LOCATION_MZONE) and e:GetHandler():GetSequence()<5 end
function s.mvop(e,tp,eg) local c=e:GetHandler(); local oc=eg:GetFirst(); if not c:IsFaceup() or not oc:IsFaceup() then return end local cs=c:GetSequence(); local os=4-oc:GetSequence(); local ns=cs; if os<cs and cs>0 then ns=cs-1 elseif os>cs and cs<4 then ns=cs+1 end if ns~=cs and Duel.CheckLocation(tp,LOCATION_MZONE,ns) then Duel.MoveSequence(c,ns) end end
function s.mf(c) local tp=c:GetControler(); for i=0,4 do if i~=c:GetSequence() and Duel.CheckLocation(tp,LOCATION_MZONE,i) then return true end end return false end
function s.qtg(e,tp,eg,ep,ev,re,r,rp,chk) if chk==0 then return Duel.IsExistingMatchingCard(s.mf,tp,LOCATION_MZONE,0,1,nil) end end
function s.qop(e,tp) Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_FACEUP); local tc=Duel.SelectMatchingCard(tp,s.mf,tp,LOCATION_MZONE,0,1,1,nil):GetFirst(); if not tc then return end local flag=0; for i=0,4 do if i~=tc:GetSequence() and Duel.CheckLocation(tp,LOCATION_MZONE,i) then flag=flag|(1<<i) end end Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_TOZONE); local z=Duel.SelectDisableField(tp,1,LOCATION_MZONE,0,~flag); Duel.MoveSequence(tc,math.log(z,2)) end
''')


def main() -> None:
    OUT.mkdir(parents=True, exist_ok=True)
    for card_id, source in sorted(SCRIPTS.items()):
        (OUT / f"c{card_id}.lua").write_text(source, encoding="utf-8", newline="\n")
    print(f"Wrote {len(SCRIPTS)} Lua scripts")


if __name__ == "__main__":
    main()
