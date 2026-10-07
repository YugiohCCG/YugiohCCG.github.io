   -- Line 36:
   return c:IsFaceup() and c:IsCanBeEffectTarget(e) and (c:GetLevel()>0 or c:GetRank()>0)
   -- Line 66:
   return c:IsFaceup() and ((c:GetLevel()>0 and c:GetLevel()<c:GetOriginalLevel()) or (c:GetRank()>0 and c:GetRank()<c:GetOriginalRank()))
