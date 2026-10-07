   -- Line 6:
   local e2=Effect.CreateEffect(c); ... e2:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O); e2:SetCode(EVENT_BATTLE_DESTROYING);
   -- Line 7:
   local e3=e2:Clone(); e3:SetCode(EVENT_BATTLE_DAMAGE);
