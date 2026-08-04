# Comprehensive Research Report: 100 YGO Omega Specific Lua Scripting Bugs & Technical Deep Dive

This document compiles **100 specific Lua scripting bugs, API incompatibilities, engine quirks, and runtime edge cases** unique to **YGO Omega** (and its derivative ocgcore engine implementation). Each entry provides an in-line deep dive including the problem description, root cause, broken Lua pattern, the exact Omega-compliant solution, and relevant script file references in the codebase (`public/CCG Downloads/CCG_Scripts/` and `tmp/omega_scripts/`).

---

## Section 1: Engine Initialization & Script Loading Bugs (Bugs 1–10)

### 1. Duplicate `s.initial_effect` Definitions
* **Problem**: Defining `function s.initial_effect(c)` twice or embedding a nested `function s.initial_effect(c)` inside a script file.
* **Root Cause**: Omega’s script loader executes the file sequentially. A duplicate top-level definition overwrites the first table entry; a nested definition returns early from the outer function, skipping all registrations defined after it.
* **Broken Code**:
  ```lua
  function s.initial_effect(c)
      local e1=Effect.CreateEffect(c)
      -- ... e1 setup ...
      c:RegisterEffect(e1)
      function s.initial_effect(c) -- BUG: Nested duplicate
          local e2=Effect.CreateEffect(c)
          c:RegisterEffect(e2)
      end
  end
  ```
* **Omega Fix**: Ensure exactly **one** top-level `s.initial_effect(c)` function exists per script file.
  ```lua
  function s.initial_effect(c)
      local e1=Effect.CreateEffect(c)
      c:RegisterEffect(e1)
      local e2=Effect.CreateEffect(c)
      c:RegisterEffect(e2)
  end
  ```
* **File References**:
  * Local Audit Reference: [`c245265629.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c245265629.lua)
  * Official Reference: [`tmp/omega_scripts/c10000040.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/c10000040.lua)

### 2. Missing or Incorrect `GetID()` Scope Initialization
* **Problem**: Using legacy YGOPro hardcoded script tables (`c12345678 = {}`) instead of Omega's dynamic `GetID()` helper.
* **Root Cause**: Omega dynamically assigns script scope via `local s, id = GetID()`. Hardcoding script IDs breaks when passcodes are remapped or installed under CCG set aliases.
* **Broken Code**:
  ```lua
  c241056746 = {}
  local s = c241056746
  ```
* **Omega Fix**:
  ```lua
  local s, id = GetID()
  function s.initial_effect(c) ... end
  ```
* **File References**:
  * Local Fix: [`c241056746.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c241056746.lua)
  * Official Reference: [`tmp/omega_scripts/c10755153.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/c10755153.lua)

### 3. Usage of Native Lua File Loaders (`dofile` / `require`)
* **Problem**: Invoking `dofile("script.lua")` or `require("module")` inside custom card scripts.
* **Root Cause**: Omega runs Lua in a restricted sandbox environment without standard filesystem I/O bindings. Native I/O calls throw fatal Lua execution errors during card loading.
* **Broken Code**:
  ```lua
  dofile("c250556612.lua")
  ```
* **Omega Fix**: Use Omega’s engine-provided script loader:
  ```lua
  Duel.LoadScript("c250556612.lua")
  ```
* **File References**:
  * Audit Document: [`docs/session-handoff-card-scripting.md`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/docs/session-handoff-card-scripting.md#L138)

### 4. Out-of-Bounds `aux.Stringid` Indexing
* **Problem**: Referencing `aux.Stringid(id, index)` where `index >= 16` or where the string index is not defined in `CCG_v1.db`.
* **Root Cause**: Omega encodes string references into bitfields combined with card passcodes. String indices above 15 overflow into the card ID bitmask, resulting in corrupted UI prompts or client crashes.
* **Broken Code**:
  ```lua
  e1:SetDescription(aux.Stringid(id, 18)) -- BUG: Overflow (> 15)
  ```
* **Omega Fix**: Keep `index` between `0` and `15`, and verify matching entry in `datas` / `texts` table in `CCG_v1.db`.
  ```lua
  e1:SetDescription(aux.Stringid(id, 0))
  ```
* **File References**:
  * Local Audit Reference: [`c223158720.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c223158720.lua)

### 5. Script Passcode File Base Mismatch vs SQLite Database ID
* **Problem**: File named `c245265629.lua` with internal ID `245265630` or SQLite `datas.id` = `245265630`.
* **Root Cause**: Omega resolves script paths directly from `datas.id` in `CCG_v1.db` formatted as `c<id>.lua`. Any mismatch prevents Omega from loading the script entirely.
* **Omega Fix**: Strictly synchronize `c<id>.lua` filename, SQLite `id`, card JSON `passcode`, and `local s, id = GetID()`.
* **File References**:
  * Audit Report: [`docs/lua-audit-2026-07-20-ultimate-fourth-pass.md`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/docs/lua-audit-2026-07-20-ultimate-fourth-pass.md)

### 6. Top-Level State Code Execution Outside `s.initial_effect`
* **Problem**: Executing state-modifying logic (e.g. creating effects or group objects) at the root level of the Lua script file.
* **Root Cause**: Top-level code executes once when the Lua chunk is parsed. State variables created here persist across multiple duels in the same client process, causing cross-duel state pollution.
* **Broken Code**:
  ```lua
  local global_group = Group.CreateGroup() -- BUG: Persists across duels
  function s.initial_effect(c) ... end
  ```
* **Omega Fix**: Initialize all dynamic state within `s.initial_effect(c)` or inside effect callbacks.
* **File References**:
  * Local Reference: [`c245935439.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c245935439.lua)

### 7. Missing Archetype Setcode Bitmask Override in Database Sync
* **Problem**: `c:IsSetCard(0x08F0)` returns `false` despite correct script logic.
* **Root Cause**: Omega derives setcode filtering from SQLite `datas.setcode`. If `setcode` in `CCG_v1.db` is 0, the engine skips setcode checks regardless of Lua definitions.
* **Omega Fix**: Ensure `sync_omega_ccg_db.py` sets explicit setcode values in `CCG_v1.db` during build.
* **File References**:
  * Sync Script: [`scripts/sync_omega_ccg_db.py`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/scripts/sync_omega_ccg_db.py)

### 8. Referencing Non-Existent `CARD_*` Constants
* **Problem**: Using `CARD_BLUE_EYES` or custom `CARD_MY_ARCHETYPE` without prior definition.
* **Root Cause**: YGO Omega does not define card-code constants globally unless explicitly declared in `constant.lua`. Unbound `CARD_*` references evaluate to `nil`, breaking equality checks.
* **Broken Code**:
  ```lua
  if c:IsCode(CARD_DARK_MAGICIAN) then ... end -- CARD_DARK_MAGICIAN is nil
  ```
* **Omega Fix**: Define explicit local constants at the top of the file or use literal numeric passcodes:
  ```lua
  local CARD_DARK_MAGICIAN = 46986414
  if c:IsCode(CARD_DARK_MAGICIAN) then ... end
  ```
* **File References**:
  * Local Reference: [`c250556612.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c250556612.lua)

### 9. Omitting Control Scope in `aux.AddUniqueCardTable`
* **Problem**: Registering a unique card constraint that locks both players from controlling the card simultaneously.
* **Root Cause**: Calling unique card helpers without specifying player scope defaults to field-wide uniqueness.
* **Broken Code**:
  ```lua
  aux.AddUniqueCardTable(c, s.filter) -- Locks both players
  ```
* **Omega Fix**: Pass explicit player control scope:
  ```lua
  aux.AddUniqueCardTable(c, s.filter, LOCATION_MZONE, 0, 1) -- Per-player limit
  ```
* **File References**:
  * Local Reference: [`c215034223.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c215034223.lua)

### 10. Direct Invocation of `Effect.GlobalEffect` at Script Parse Time
* **Problem**: Registering global duel rules at root Lua execution time.
* **Root Cause**: Global effects registered outside card initialization lose owner context and fail when re-initializing duel state in rematch sessions.
* **Omega Fix**: Register global effects inside `s.initial_effect(c)` attached to card instance `c`:
  ```lua
  function s.initial_effect(c)
      local e1=Effect.GlobalEffect(c)
      -- ...
      Duel.RegisterEffect(e1, 0)
  end
  ```
* **File References**:
  * Local Reference: [`c259264449.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c259264449.lua)

---

## Section 2: Copied Activation & Effect Delegation Bugs (Bugs 11–20)

### 11. Invoking `op(e,tp,eg,ev,re,r,rp)` Directly Without `CheckActivateEffect` Validation
* **Problem**: Executing a targeted card's operation directly: `local op=te:GetOperation(); op(e,tp,eg,ev,re,r,rp)`.
* **Root Cause**: Calling `op` directly bypasses legality checks, target selection UI, and event parameter forwarding. In Omega, this causes desynchronization between client UI and host engine.
* **Broken Code**:
  ```lua
  local op=tc:GetActivateEffect():GetOperation()
  if op then op(e,tp,eg,ev,re,r,rp) end
  ```
* **Omega Fix**: Use Omega's official `CheckActivateEffect` idiom:
  ```lua
  local te,ceg,cep,ev,re,r,rp=tc:CheckActivateEffect(true,true,true)
  if te then
      e:SetProperty(te:GetProperty())
      local op=te:GetOperation()
      if op then op(e,tp,ceg,cep,ev,re,r,rp) end
  end
  ```
* **File References**:
  * Local Fix: [`c244790302.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c244790302.lua)

### 12. Bypassing Event Forwarding (`ceg, cep, ev, re, r, rp`) in Copied Activations
* **Problem**: Passing original triggering event `eg, ev` to a copied effect instead of the event returned by `CheckActivateEffect`.
* **Root Cause**: The copied card may require a different event context (e.g. `EVENT_SPSUMMON_SUCCESS` vs `EVENT_CHAINING`). Passing mismatched event parameters causes `re:GetHandler()` calls within the copied script to return `nil`.
* **Omega Fix**: Forward `ceg, cep, ev, re, r, rp` strictly as returned by `tc:CheckActivateEffect(...)`.
* **File References**:
  * Local Fix: [`c244790302.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c244790302.lua)

### 13. Copied Spell/Trap Activation Location Spoofing
* **Problem**: Copying a Normal Spell activation from GY while the engine still evaluates `LOCATION_GRAVE`.
* **Root Cause**: Certain cards check `e:IsHasType(EFFECT_TYPE_ACTIVATE)` and `c:IsLocation(LOCATION_SZONE)`. Executing activation from GY without setting card context causes location checks to fail.
* **Omega Fix**: Clear location requirement or move card temporarily using `Duel.MoveToField` if text specifies "activate that Spell/Trap".
* **File References**:
  * Local Fix: [`c250556612.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c250556612.lua)

### 14. Ephemeral Label Object Memory Leak in Copied Chains
* **Problem**: Passing dynamic `Card` or `Group` objects via `e:SetLabelObject()` during copied activations across chains.
* **Root Cause**: `SetLabelObject` holds strong references. If the chain is negated, the object reference is retained, causing memory retention or invalid dereferencing on deleted objects.
* **Omega Fix**: Use card field IDs (`c:GetFieldID()`) or local label flags instead of direct object pointers.
* **File References**:
  * Local Reference: [`c259219942.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c259219942.lua)

### 15. Omitting `Duel.ClearTargetCard()` Before Executing Copied Activation
* **Problem**: Target card from initial copying effect bleeds into the target list of the copied effect.
* **Root Cause**: Target arrays in `Duel.GetChainInfo(0, CHAININFO_TARGET_CARDS)` persist across sub-operations unless explicitly cleared.
* **Omega Fix**: Clear targets before invoking copied target selection:
  ```lua
  Duel.ClearTargetCard()
  ```
* **File References**:
  * Local Fix: [`c244790302.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c244790302.lua)

### 16. Enforcing Cost Payment on Copied "Apply the Effect" Cards
* **Problem**: Forcing cost payment when copying a card effect whose text states "apply the activation effect of that card".
* **Root Cause**: "Apply the effect" skips costs (`e:GetCost()`). Calling `te:GetCost()` in copied operations causes illegal cost deductions (e.g. paying LP twice).
* **Omega Fix**: Invoke only `te:GetTarget()` (for verification) and `te:GetOperation()`, skipping `te:GetCost()`.
* **File References**:
  * Local Fix: [`c244790302.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c244790302.lua)
  * Local Fix: [`c250556612.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c250556612.lua)

### 17. UI Lock on Copied Continuous Spell/Trap Activation
* **Problem**: Copying the activation of a Continuous Spell/Trap in GY without placing it in S/T zone.
* **Root Cause**: Omega's UI expects Continuous Spells/Traps to remain on field during resolution. Executing operational logic in GY causes client rendering state lock.
* **Omega Fix**: If copying activation of Continuous Spell/Trap, place card on field via `Duel.MoveToField(tc,tp,tp,LOCATION_SZONE,POS_FACEUP,true)`.
* **File References**:
  * Official Reference: [`tmp/omega_scripts/fixed-scripts/c26700718.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/fixed-scripts/c26700718.lua)

### 18. Unchecked `te:IsHasProperty(EFFECT_FLAG_CARD_TARGET)` in Copied Operations
* **Problem**: Calling `te:GetTarget()` on non-targeting effects, causing unexpected UI target prompts.
* **Root Cause**: Executing target function unconditionally forces prompt execution even when property flags lack `EFFECT_FLAG_CARD_TARGET`.
* **Omega Fix**:
  ```lua
  if te:IsHasProperty(EFFECT_FLAG_CARD_TARGET) then
      local tg=te:GetTarget()
      if tg then tg(e,tp,ceg,cep,ev,re,r,rp,1) end
  end
  ```
* **File References**:
  * Local Fix: [`c244790302.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c244790302.lua)

### 19. Using Wrong String ID in Copied Activation Choice Prompt
* **Problem**: `Duel.SelectYesNo(tp, aux.Stringid(id, 0))` displaying unrelated text when prompting to copy an effect.
* **Root Cause**: Hardcoding local string ID instead of fetching target card's description via `te:GetDescription()`.
* **Omega Fix**:
  ```lua
  local doc = te:GetDescription()
  if Duel.SelectYesNo(tp, doc) then ... end
  ```
* **File References**:
  * Local Fix: [`c250556612.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c250556612.lua)

### 20. Double Once-Per-Turn Restriction Triggers on Copied Activations
* **Problem**: Executing a copied effect increments the count limit of both the copying card and the copied card.
* **Root Cause**: Calling `te:UseCountLimit(tp)` manually during copied execution.
* **Omega Fix**: Do not invoke `UseCountLimit` on target effect `te` when executing copied operations.
* **File References**:
  * Local Fix: [`c244790302.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c244790302.lua)

---

## Section 3: Special Summon & Extra Deck Procedure Bugs (Bugs 21–32)

### 21. Passing 5 Parameters to Legacy `aux.AddLinkProcedure`
* **Problem**: Calling `aux.AddLinkProcedure(c, f, min, max, gf)` in Omega scripts.
* **Root Cause**: Omega’s legacy `aux.AddLinkProcedure` takes 4 arguments. Passing 5 arguments shifts `gf` into an invalid parameter position, resulting in broken Link Summon filters.
* **Broken Code**:
  ```lua
  aux.AddLinkProcedure(c, s.mfilter, 2, 2, s.gfilter) -- BUG: 5 parameters
  ```
* **Omega Fix**: Use modern `Link.AddProcedure`:
  ```lua
  Link.AddProcedure(c, s.mfilter, 2, 2, s.gfilter)
  ```
* **File References**:
  * Official Reference: [`tmp/omega_scripts/c100211098.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/c100211098.lua)

### 22. Calling Non-Existent `aux.AddFusionProcMixN` Helper
* **Problem**: Using `aux.AddFusionProcMixN(c, sub, ins, ...)` in script initializers.
* **Root Cause**: `aux.AddFusionProcMixN` does not exist in YGO Omega’s helper library. Script fails at parse time.
* **Omega Fix**: Use `aux.AddFusionProcMixRep` or modern procedure namespace `Fusion.AddProcMixRep`:
  ```lua
  Fusion.AddProcMixRep(c, true, true, s.ffilter, 2, 2)
  ```
* **File References**:
  * Official Reference: [`tmp/omega_scripts/fixed-scripts/fusion/c48130397.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/fixed-scripts/fusion/c48130397.lua)

### 23. Checking `Duel.GetLocationCount` for Extra Deck Special Summons
* **Problem**: Using `Duel.GetLocationCount(tp, LOCATION_MZONE) > 0` to check legality of Extra Deck Special Summon.
* **Root Cause**: Extra Deck monsters must be summoned to Main Monster Zones pointed to by Link Markers or the Extra Monster Zone. `GetLocationCount` checks total open zones regardless of Link topology.
* **Broken Code**:
  ```lua
  if Duel.GetLocationCount(tp, LOCATION_MZONE) <= 0 then return false end
  ```
* **Omega Fix**: Use `Duel.GetLocationCountFromEx`:
  ```lua
  if Duel.GetLocationCountFromEx(tp, tp, nil, c) <= 0 then return false end
  ```
* **File References**:
  * Local Fix: [`c225109525.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c225109525.lua)

### 24. Bypassing `Duel.IsPlayerCanSpecialSummonCount` under Simultaneous Summons
* **Problem**: Special Summoning 2 monsters at once without checking multi-summon limits.
* **Root Cause**: Cards like "Blue-Eyes Spirit Dragon" restrict Special Summons to 1 monster at a time. Omitting count checks allows illegal double-summons or crashes zone assignment.
* **Omega Fix**:
  ```lua
  if not Duel.IsPlayerCanSpecialSummonCount(tp, 2) then return false end
  ```
* **File References**:
  * Local Fix: [`c248946297.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c248946297.lua)

### 25. Invalid Hand-Based Extra Link Material Setup (`EFFECT_EXTRA_LINK_MATERIAL`)
* **Problem**: Registering custom flag `EFFECT_EXTRA_LINK_MATERIAL` directly on monster.
* **Root Cause**: Omega requires hand link material permissions to be registered via official hand material registration patterns rather than generic property flags.
* **Omega Fix**: Register hand material evaluation callback via `Link.AddProcedure` parameter or `EFFECT_EXTRA_MATERIAL`.
* **File References**:
  * Official Reference: [`tmp/omega_scripts/c101203051.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/c101203051.lua)

### 26. Incorrect Return Tuple in Custom `EFFECT_XYZ_LEVEL`
* **Problem**: `SetValue` callback returning single Level integer: `return 4`.
* **Root Cause**: Omega’s `EFFECT_XYZ_LEVEL` expects `function(e,c,rc)` returning `level | (rank << 16)` or tuple `(lv, rank)`. Returning a single value causes invalid Xyz rank calculation.
* **Omega Fix**:
  ```lua
  e1:SetValue(function(e,c,rc)
      return 4 | (4 << 16)
  end)
  ```
* **File References**:
  * Local Fix: [`c220749574.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c220749574.lua)
  * Official Reference: [`tmp/omega_scripts/c61496006.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/c61496006.lua)

### 27. Unbounded Non-Tuner Selection in Custom Synchro Procedures
* **Problem**: Custom Synchro filter failing to bound non-Tuner count limits.
* **Root Cause**: `Synchro.AddProcedure` requires explicit min/max parameters for non-Tuners. Missing bounds allow selecting 0 non-Tuners.
* **Omega Fix**:
  ```lua
  Synchro.AddProcedure(c, nil, 1, 1, Synchro.NonTuner(nil), 1, 99)
  ```
* **File References**:
  * Official Reference: [`tmp/omega_scripts/c1174075.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/c1174075.lua)

### 28. Setting Oath Restrictions After Special Summon Operation
* **Problem**: Registering `EFFECT_CANNOT_SPECIAL_SUMMON` restriction *after* `Duel.SpecialSummon(...)`.
* **Root Cause**: If Special Summon fails or is negated, the oath restriction is incorrectly skipped or applied out of order.
* **Omega Fix**: Register oath restrictions at cost evaluation or before operation execution.
* **File References**:
  * Local Fix: [`c248946297.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c248946297.lua)

### 29. Direct Pendulum Scale Mutation Overflow
* **Problem**: Setting scale variables directly on card data table instead of registering scale effects.
* **Root Cause**: Omega's engine reads scales dynamically from active scale effects (`EFFECT_CHANGE_LSCALE` / `EFFECT_CHANGE_RSCALE`).
* **Omega Fix**: Register scale modification effects attached to Pendulum zone location.
* **File References**:
  * Local Reference: [`c210506870.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c210506870.lua)

### 30. Omitting `c:EnableReviveLimit()` on Special Summon Monsters
* **Problem**: Nomi / Special Summon-only monsters revivable from GY without proper initial summon.
* **Root Cause**: Missing `c:EnableReviveLimit()` omits `REGFL_REVIVE_LIMIT` flag in engine core.
* **Omega Fix**: Call `c:EnableReviveLimit()` in `s.initial_effect(c)` before defining summon procedures.
* **File References**:
  * Local Fix: [`c236818346.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c236818346.lua)

### 31. Manual Ritual Monster Release Validation Failure
* **Problem**: Writing custom loop to sum Levels for Ritual Summon without `Ritual.CreateProc`.
* **Root Cause**: Hand-written Ritual math fails to account for monsters that can be treated as multiple Levels or whole tributes.
* **Omega Fix**: Use Omega's `Ritual.AddProc` / `Ritual.CreateProc` standard helpers.
* **File References**:
  * Local Reference: [`c257464336.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c257464336.lua)
  * Official Reference: [`tmp/omega_scripts/c101303207.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/c101303207.lua)

### 32. Missing `IsAbleToGraveAsCost` / `IsAbleToDeckAsCost` in Contact Fusion
* **Problem**: Contact Fusion procedure allowing send-to-GY of cards under "Macro Cosmos".
* **Root Cause**: Banishment redirection prevents cards from being sent to GY as cost.
* **Omega Fix**: Include `c:IsAbleToGraveAsCost()` in material selection filter.
* **File References**:
  * Local Reference: [`c259363148.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c259363148.lua)

---

## Section 4: Card Location & Material Redirection Bugs (Bugs 33–42)

### 33. Registering Detachment Triggers with `EVENT_TO_GRAVEYARD`
* **Problem**: Detached Xyz material trigger failing to fire when detached for cost.
* **Root Cause**: Xyz materials detached for cost do not trigger standard `EVENT_TO_GRAVEYARD` unless reason contains `REASON_COST` and previous location `LOCATION_OVERLAY` is verified.
* **Omega Fix**: Use `EVENT_MOVE` or check overlay origin:
  ```lua
  function s.regcon(e,tp,eg,ev,re,r,rp)
      local c=e:GetHandler()
      return c:IsReason(REASON_COST) and c:IsPreviousLocation(LOCATION_OVERLAY)
  end
  ```
* **File References**:
  * Local Reference: [`c240299292.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c240299292.lua)

### 34. Using `EFFECT_LEAVE_FIELD_REDIRECT` for Xyz Overlay Material Banishment
* **Problem**: Card attached as Xyz material failing to banish when detached/sent to GY.
* **Root Cause**: Xyz materials are **not** considered on the field. `EFFECT_LEAVE_FIELD_REDIRECT` does not apply to overlay materials.
* **Broken Code**:
  ```lua
  e1:SetCode(EFFECT_LEAVE_FIELD_REDIRECT)
  e1:SetValue(LOCATION_REMOVED)
  ```
* **Omega Fix**: Use overlay-specific redirect helper or `EFFECT_TO_GRAVEYARD_REDIRECT` with overlay check:
  ```lua
  e1:SetCode(EFFECT_TO_GRAVEYARD_REDIRECT)
  e1:SetTarget(function(e,c) return c:IsLocation(LOCATION_OVERLAY) end)
  e1:SetValue(LOCATION_REMOVED)
  ```
* **File References**:
  * Local Fix: [`c218905439.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c218905439.lua)
  * Official Reference: [`tmp/omega_scripts/c57448410.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/c57448410.lua)

### 35. Bypassing `aux.NecrovalleyFilter` in GY Selection Operations
* **Problem**: Card effect successfully moving card out of GY while "Necrovalley" is active.
* **Root Cause**: Selecting target directly without wrapping filter in `aux.NecrovalleyFilter`.
* **Broken Code**:
  ```lua
  local g=Duel.GetMatchingGroup(s.filter,tp,LOCATION_GRAVE,0,nil)
  ```
* **Omega Fix**:
  ```lua
  local g=Duel.GetMatchingGroup(aux.NecrovalleyFilter(s.filter),tp,LOCATION_GRAVE,0,nil)
  ```
* **File References**:
  * Local Fix: [`c259377794.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c259377794.lua)

### 36. Face-Down Banished Card Selection Leak
* **Problem**: Selecting face-down banished card for operation expecting face-up card.
* **Root Cause**: Cards in `LOCATION_REMOVED` can be face-down. Face-down banished cards have no public properties (Attribute, Type, ATK).
* **Omega Fix**: Include `c:IsFaceup()` in target filter for banished cards:
  ```lua
  function s.filter(c)
      return c:IsFaceup() and c:IsSetCard(0x08F0)
  end
  ```
* **File References**:
  * Official Reference: [`tmp/omega_scripts/c71197066.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/c71197066.lua)

### 37. Omitting `Duel.ShuffleDeck` After Deck Search
* **Problem**: Searching Deck for card and adding to hand without shuffling Deck.
* **Root Cause**: Deck ordering remains deterministic in engine unless `Duel.ShuffleDeck` is invoked explicitly.
* **Omega Fix**: Always call `Duel.ShuffleDeck(tp)` after `Duel.SelectMatchingCard` or `Duel.SendtoHand` from Deck.
* **File References**:
  * Official Reference: [`tmp/omega_scripts/c100227043.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/c100227043.lua)

### 38. Missing Deck Bottom Ordering Prompt (`SortDeckbottom`)
* **Problem**: Returning 2+ cards to bottom of Deck in arbitrary engine order.
* **Root Cause**: Card text specifying "in any order" requires prompting player to order returned cards.
* **Omega Fix**: Use `Duel.SortDeckbottom(tp, tp, count)` or prompt player for sequence.
* **File References**:
  * Local Fix: [`c220749574.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c220749574.lua)

### 39. Control Change Execution Without Open Zone Verification
* **Problem**: `Duel.GetControl(tc, tp)` executing when target player has 5 monsters.
* **Root Cause**: If no zones are available, `Duel.GetControl` sends target to GY or destroys it depending on rule parameters.
* **Omega Fix**: Verify `Duel.GetLocationCount(tp, LOCATION_MZONE) > 0` before target selection.
* **File References**:
  * Local Reference: [`c233659599.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c233659599.lua)

### 40. Unchecked `c:IsRelateToEffect(e)` on Equip Spell Resolution
* **Problem**: Equip Spell equipping to target that left field before resolution.
* **Root Cause**: Missing relationship check causes Equip Spell to remain on field unattached, immediately destroying itself by game rule.
* **Omega Fix**: Verify target relationship on resolution:
  ```lua
  if tc and tc:IsRelateToEffect(e) and tc:IsFaceup() then
      Duel.Equip(tp, c, tc)
  end
  ```
* **File References**:
  * Official Reference: [`tmp/omega_scripts/c10960419.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/c10960419.lua)

### 41. Temporary Banishment Token Memory Leak / Engine Fault
* **Problem**: Banishing a Token "until the End Phase".
* **Root Cause**: Tokens cease to exist when leaving the field. Attempting to return a banished Token at End Phase throws null reference exception.
* **Omega Fix**: Exclude tokens from temporary banishment target filters:
  ```lua
  function s.filter(c)
      return c:IsAbleToRemove() and not c:IsType(TYPE_TOKEN)
  end
  ```
* **File References**:
  * Local Fix: [`c259269688.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c259269688.lua)

### 42. Using `LOCATION_REMOVED` Destination in `Duel.SendtoGrave`
* **Problem**: Calling `Duel.SendtoGrave(g, REASON_EFFECT + LOCATION_REMOVED)`.
* **Root Cause**: `SendtoGrave` sends cards to GY regardless of location flags in reason. To banish cards, `Duel.Remove` must be used.
* **Omega Fix**:
  ```lua
  Duel.Remove(g, POS_FACEUP, REASON_EFFECT)
  ```
* **File References**:
  * Official Reference: [`tmp/omega_scripts/c60516416.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/c60516416.lua)

---

## Section 5: Chain, Negation & Replacement Effect Bugs (Bugs 43–54)

### 43. Calling `Duel.NegateActivation` for Effect Negation
* **Problem**: Executing `Duel.NegateActivation(ev)` when card text reads "negate that effect".
* **Root Cause**: Negating activation (`NegateActivation`) rewrites chain trigger status and un-sets activation history. Negating effect (`NegateEffect`) disables resolving operation while preserving chain structure.
* **Omega Fix**: Use `Duel.NegateEffect(ev)` for effect negation:
  ```lua
  if Duel.NegateEffect(ev) then
      -- additional destruction or resolution
  end
  ```
* **File References**:
  * Official Reference: [`tmp/omega_scripts/c41420027.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/c41420027.lua)

### 44. Omitting `Duel.IsChainDisablable(ev)` Verification
* **Problem**: Counter Trap attempting to negate non-disablable chain link.
* **Root Cause**: Certain cards cannot have activations/effects negated. Bypassing check causes engine assertion failure.
* **Omega Fix**:
  ```lua
  if not Duel.IsChainDisablable(ev) then return false end
  ```
* **File References**:
  * Official Reference: [`tmp/omega_scripts/c98069388.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/c98069388.lua)

### 45. Negating and Destroying Without Relationship Check
* **Problem**: Destroying negated card via `Duel.Destroy(re:GetHandler(), REASON_EFFECT)` when card left target location.
* **Root Cause**: If triggering card moved location before negation resolves, `re:GetHandler()` refers to card in original zone. If relationship is broken, destroy operation must handle current location.
* **Omega Fix**: Check `re:GetHandler():IsRelateToEffect(re)` before destruction.
* **File References**:
  * Official Reference: [`tmp/omega_scripts/fixed-scripts/c16625614.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/fixed-scripts/c16625614.lua)

### 46. Destruction Replacement Infinite Loops (`EFFECT_DESTROY_REPLACE`)
* **Problem**: Replacement effect triggering on its own destruction, freezing duel.
* **Root Cause**: Target filter in replacement effect missing self-exemption.
* **Omega Fix**: Include `c ~= e:GetHandler()` or origin check in replacement target filter.
* **File References**:
  * Local Fix: [`c244790302.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c244790302.lua)
  * Official Reference: [`tmp/omega_scripts/c1580833.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/c1580833.lua)

### 47. Type Misconception on `CHAININFO_TRIGGERING_EFFECT`
* **Problem**: Expecting integer ID from `local te = Duel.GetChainInfo(ev, CHAININFO_TRIGGERING_EFFECT)`.
* **Root Cause**: `CHAININFO_TRIGGERING_EFFECT` returns the actual `Effect` object instance, not a numeric passcode.
* **Omega Fix**:
  ```lua
  local te = Duel.GetChainInfo(ev, CHAININFO_TRIGGERING_EFFECT)
  local tc = te:GetHandler() -- Extract card handler from effect
  ```
* **File References**:
  * Local Reference: [`c259229055.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c259229055.lua)

### 48. Manual Chain Index Calculation (`GetCurrentChain() + 1`)
* **Problem**: Calculating next chain link index via `Duel.GetCurrentChain() + 1`.
* **Root Cause**: Concurrent triggers resolve chain stacking dynamically. Hardcoding indexes creates race conditions in simultaneous chain building.
* **Omega Fix**: Pass `0` or current chain index parameter `ev` provided by callback signature.
* **File References**:
  * Script Verification: [`scripts/verify_omega_message_routes.py`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/scripts/verify_omega_message_routes.py)

### 49. Operation Replacement Without `Duel.ChangeChainOperation`
* **Problem**: Replacing resolving chain effect by modifying `te:SetOperation(...)` directly.
* **Root Cause**: Modifying effect operation object permanently mutates card behavior for subsequent turns.
* **Omega Fix**: Use Omega's chain replacement API:
  ```lua
  Duel.ChangeChainOperation(ev, s.replaced_op)
  ```
* **File References**:
  * Local Fix: [`c256287781.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c256287781.lua)
  * Official Reference: [`tmp/omega_scripts/fixed-scripts/Genesys/c80453041.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/fixed-scripts/Genesys/c80453041.lua)

### 50. Omitting Phase Guard on Quick Effects (`EFFECT_TYPE_QUICK_O`)
* **Problem**: Main Phase Quick Effect activating during Battle Phase.
* **Root Cause**: Setting `EFFECT_TYPE_QUICK_O` without phase condition permits activation in any phase.
* **Omega Fix**: Add condition check:
  ```lua
  function s.quickcon(e,tp,eg,ev,re,r,rp)
      return Duel.IsMainPhase()
  end
  ```
* **File References**:
  * Local Reference: [`c250556612.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c250556612.lua)

### 51. Omitting `EFFECT_FLAG_DAMAGE_STEP` on Damage Step Negators
* **Problem**: Card that negates activations failing to prompt during Damage Step.
* **Root Cause**: Omega suppresses effect activations during Damage Step unless property flags explicitly include `EFFECT_FLAG_DAMAGE_STEP` or `EFFECT_FLAG_DAMAGE_CAL`.
* **Omega Fix**:
  ```lua
  e1:SetProperty(EFFECT_FLAG_DAMAGE_STEP + EFFECT_FLAG_DAMAGE_CAL)
  ```
* **File References**:
  * Official Reference: [`tmp/omega_scripts/c100259003.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/c100259003.lua)

### 52. Missing `EFFECT_FLAG_DELAY` on Optional "If" Triggers
* **Problem**: Optional "If... you can" trigger missing activation window on Chain Link 2+.
* **Root Cause**: Without `EFFECT_FLAG_DELAY`, trigger condition must be exact last event. If event occurs at CL2, trigger misses timing.
* **Omega Fix**: Always add `EFFECT_FLAG_DELAY` to optional "If" triggers:
  ```lua
  e1:SetProperty(EFFECT_FLAG_DELAY)
  ```
* **File References**:
  * Local Reference: [`c226063408.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c226063408.lua)

### 53. Unbounded Continuous Stat Buff Range (`EFFECT_UPDATE_ATTACK`)
* **Problem**: Continuous ATK aura updating monsters face-down or in GY.
* **Root Cause**: Omitting target filter or location mask applies stat changes to all cards owned by player.
* **Omega Fix**: Restrict continuous effect scope:
  ```lua
  e1:SetTargetRange(LOCATION_MZONE, 0)
  e1:SetTarget(aux.TargetBoolFunction(Card.IsFaceup))
  ```
* **File References**:
  * Official Reference: [`tmp/omega_scripts/c11390349.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/c11390349.lua)

### 54. Incomplete Trap Monster Disable Handling
* **Problem**: Trap Monster negated by card effect remaining as monster on field with ATK intact.
* **Root Cause**: When Trap Monster is negated, it must lose monster status and revert to S/T zone properties if specified by engine rule.
* **Omega Fix**: Use Omega's official Trap Monster disable helper patterns during negation setup.
* **File References**:
  * Local Fix: [`c259114562.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c259114562.lua)

---

## Section 6: UI, Selection Prompts & Client Sync Bugs (Bugs 55–66)

### 55. Forced Remote Opponent Choice with 0 Legal Candidates
* **Problem**: Client UI freezes on opponent's screen when prompt forces choice with zero legal options.
* **Root Cause**: Sending choice request to client without pre-validating candidate group count (`#g > 0`) locks client UI waiting for input.
* **Omega Fix**: Pre-validate count before calling `Duel.SelectMatchingCard` or `Duel.SelectOption`:
  ```lua
  if #g > 0 and Duel.SelectYesNo(1-tp, aux.Stringid(id, 0)) then
      -- prompt selection
  end
  ```
* **File References**:
  * Local Fix: [`c226645052.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c226645052.lua)

### 56. Passing Misspelled Selection Hint Constants
* **Problem**: Calling `Duel.Hint(HINT_SELECTMSG, tp, HINTMSG_DISCARD)` where constant is misspelled.
* **Root Cause**: Invalid hint constants evaluate to `nil` or `0`, showing generic or blank prompt headers in UI.
* **Omega Fix**: Verify exact constant names in `constant.lua` (e.g. `HINTMSG_TOGRAVE`, `HINTMSG_DISCARD`).
* **File References**:
  * Local Reference: [`c220749574.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c220749574.lua)

### 57. Unrestricted `Duel.SelectYesNo` Default Confirmation
* **Problem**: Prompting player "Do you want to activate effect?" when target operation has no legal resolution.
* **Root Cause**: Failing to check operation legality inside target/condition function before rendering UI prompt.
* **Omega Fix**: Ensure condition function `s.condition` and target function `s.target` return `false` when resolution is impossible.
* **File References**:
  * Local Fix: [`c248946297.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c248946297.lua)

### 58. Passing Function Instead of Code Array to `Duel.AnnounceCard`
* **Problem**: `Duel.AnnounceCard(tp, s.announce_filter)` throwing type error in Omega.
* **Root Cause**: Omega's `AnnounceCard` expects player ID followed by card type masks or integer array, not a Lua filter function.
* **Omega Fix**: Use proper argument parameters for card declaration:
  ```lua
  local ac=Duel.AnnounceCard(tp, TYPE_MONSTER)
  ```
* **File References**:
  * Local Reference: [`c229327103.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c229327103.lua)

### 59. Unpacking Multi-Card Announcement Indexes Incorrectly
* **Problem**: Reading card announcement return value as single integer when declaring multiple cards.
* **Root Cause**: Announcing multiple choices returns multiple values or a table depending on API overload.
* **Omega Fix**: Assign return values matching exact overload declaration.
* **File References**:
  * Script Verification: [`scripts/verify_omega_callbacks.py`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/scripts/verify_omega_callbacks.py)

### 60. Unregistered String ID in `Duel.SelectOption`
* **Problem**: `Duel.SelectOption(tp, aux.Stringid(id, 2), aux.Stringid(id, 3))` displaying blank buttons in UI.
* **Root Cause**: String IDs 2 and 3 missing from SQLite `CCG_v1.db` `texts` table for that passcode.
* **Omega Fix**: Add corresponding entries in database string overrides before release.
* **File References**:
  * Script Reference: [`scripts/remap_omega_string_ids.py`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/scripts/remap_omega_string_ids.py)

### 61. Omitting `c:IsCanBeEffectTarget(e)` in Target Filters
* **Problem**: Effect targeting card that has target-immunity ("cannot be targeted by card effects").
* **Root Cause**: Checking only card properties (e.g. Level/Attribute) without checking targeting immunity.
* **Omega Fix**: Include targeting check in filter:
  ```lua
  function s.tgfilter(c,e)
      return c:IsCanBeEffectTarget(e) and c:IsFaceup()
  end
  ```
* **File References**:
  * Local Fix: [`c248788543.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c248788543.lua)

### 62. Min/Max Count Inversion in `Duel.SelectTarget`
* **Problem**: Calling `Duel.SelectTarget(tp, s.filter, tp, LOCATION_MZONE, 0, 2, 1, nil)`.
* **Root Cause**: Passing `min > max` (e.g. min 2, max 1) causes target selection dialog to fail immediately or crash engine.
* **Omega Fix**: Ensure `min <= max`:
  ```lua
  Duel.SelectTarget(tp, s.filter, tp, LOCATION_MZONE, 0, 1, 2, nil)
  ```
* **File References**:
  * Local Reference: [`c218905439.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c218905439.lua)

### 63. Omitting `e:SetTargetCard(g)` in Target Phase
* **Problem**: Selected target card not highlighted on UI field during chain build.
* **Root Cause**: Omega highlights targeted cards based on target card list set via `e:SetTargetCard(g)` or `Duel.SelectTarget`.
* **Omega Fix**: Always use `Duel.SelectTarget` or manually invoke `e:SetTargetCard(g)`.
* **File References**:
  * Official Reference: [`tmp/omega_scripts/fixed-scripts/Targeting/c43355214.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/fixed-scripts/Targeting/c43355214.lua)

### 64. Raw Integer Zone Mask Overflow in `Duel.SelectDisableField`
* **Problem**: Passing unmasked integer to `Duel.SelectDisableField`.
* **Root Cause**: Zone masks are bitfields. Passing invalid integers enables non-existent field zones, corrupting zone display.
* **Omega Fix**: Shift bits correctly (`1 << zone_index`) or use engine constants.
* **File References**:
  * Local Reference: [`c250556612.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c250556612.lua)

### 65. Out-of-Bounds Indexing in `Duel.SelectOption`
* **Problem**: Passing 4 option strings to `Duel.SelectOption` but handling only 2 return indexes.
* **Root Cause**: `SelectOption` returns 0-indexed integer corresponding to chosen button.
* **Omega Fix**: Handle all possible return values (`0, 1, 2, 3`) in conditional logic.
* **File References**:
  * Local Reference: [`c250556612.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c250556612.lua)

### 66. Reading `Duel.TossCoin` Single Return on Multiple Flips
* **Problem**: `local res = Duel.TossCoin(tp, 2)` evaluating `res` as total heads.
* **Root Cause**: `Duel.TossCoin(tp, 2)` returns multiple boolean parameters (`res1, res2`), not an array or sum.
* **Omega Fix**:
  ```lua
  local c1, c2 = Duel.TossCoin(tp, 2)
  ```
* **File References**:
  * Local Reference: [`c259475154.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c259475154.lua)

---

## Section 7: Stat Modification, Reset & Timing Bugs (Bugs 67–78)

### 67. Usage of Non-Existent `RESETS_STANDARD_DISABLE` Constant
* **Problem**: `e1:SetReset(RESET_EVENT + RESETS_STANDARD_DISABLE)` failing to parse or evaluate to `nil`.
* **Root Cause**: `RESETS_STANDARD_DISABLE` is not a standard Omega engine constant.
* **Broken Code**:
  ```lua
  e1:SetReset(RESET_EVENT + RESETS_STANDARD_DISABLE)
  ```
* **Omega Fix**: Use standard composite reset constants:
  ```lua
  e1:SetReset(RESET_EVENT + RESETS_STANDARD + RESET_DISABLE)
  ```
* **File References**:
  * Official Reference: [`tmp/omega_scripts/c61434639.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/c61434639.lua)

### 68. Omitting `RESET_EVENT + RESETS_STANDARD` on Temporary ATK Buffs
* **Problem**: Monster gaining ATK until End Phase retaining ATK boost after going to GY and being revived.
* **Root Cause**: Stat modification effect lacking location event reset flags persists across zone changes.
* **Omega Fix**:
  ```lua
  e1:SetReset(RESET_EVENT + RESETS_STANDARD + RESET_PHASE + PHASE_END)
  ```
* **File References**:
  * Official Reference: [`tmp/omega_scripts/c11443677.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/c11443677.lua)

### 69. Swapping ATK/DEF Calculated from Current Instead of Original Baseline
* **Problem**: ATK/DEF swap effect calculating inverted stats iteratively on every frame.
* **Root Cause**: Swap value function reading `c:GetAttack()` dynamically instead of capturing baseline original stat.
* **Omega Fix**: Use `c:GetBaseAttack()` / `c:GetBaseDefense()` or `EFFECT_SWAP_AD`.
* **File References**:
  * Local Reference: [`c217174535.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c217174535.lua)

### 70. Level Modification Missing Phase Reset
* **Problem**: Monster Level change persisting permanently across turns.
* **Root Cause**: Omitting `RESET_PHASE + PHASE_END` when text specifies "until the end of this turn".
* **Omega Fix**: Set explicit phase reset:
  ```lua
  e1:SetReset(RESET_EVENT + RESETS_STANDARD + RESET_PHASE + PHASE_END)
  ```
* **File References**:
  * Official Reference: [`tmp/omega_scripts/c55697723.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/c55697723.lua)

### 71. Unrestricted `EFFECT_CANNOT_BE_BATTLE_TARGET` Protection Scope
* **Problem**: Monster with battle protection unable to be targeted by owner's own card tests.
* **Root Cause**: Failing to check attacker controller in `SetValue`.
* **Omega Fix**:
  ```lua
  e1:SetValue(function(e,c)
      return c:IsControler(1-e:GetHandlerPlayer())
  end)
  ```
* **File References**:
  * Official Reference: [`tmp/omega_scripts/c98069388.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/c98069388.lua)

### 72. Omitting Turn Reset on Set-Turn Trap Permissions
* **Problem**: Trap card granted permission to activate turn it was set retaining permission on subsequent turns.
* **Root Cause**: Missing `RESET_PHASE + PHASE_END` on `EFFECT_TRAP_ACT_IN_SET_TURN`.
* **Omega Fix**: Apply strict single-turn reset:
  ```lua
  e1:SetReset(RESET_EVENT + RESETS_STANDARD + RESET_PHASE + PHASE_END)
  ```
* **File References**:
  * Local Reference: [`c223158720.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c223158720.lua)

### 73. Unbounded Flag Effect Count Accumulation
* **Problem**: Duel performance degrading over long games when card tracks actions via `c:RegisterFlagEffect`.
* **Root Cause**: Registering flag effects without reset flags leaks flag records in memory.
* **Omega Fix**: Include phase or turn reset on flag effects:
  ```lua
  c:RegisterFlagEffect(id, RESET_EVENT + RESETS_STANDARD + RESET_PHASE + PHASE_END, 0, 1)
  ```
* **File References**:
  * Local Fix: [`c259264449.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c259264449.lua)

### 74. Unchecked Flag Effect Label Extraction (`c:GetFlagEffectLabel`)
* **Problem**: Calling `c:GetFlagEffectLabel(id)` when card has 0 flags registered.
* **Root Cause**: `GetFlagEffectLabel` returns `nil` if flag does not exist, causing arithmetic crash.
* **Omega Fix**:
  ```lua
  if c:GetFlagEffect(id) > 0 then
      local label = c:GetFlagEffectLabel(id)
      -- use label safely
  end
  ```
* **File References**:
  * Local Fix: [`c259934043.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c259934043.lua)

### 75. Missing Player Turn ID Verification in Delayed End Phase Triggers
* **Problem**: "During the next Standby Phase" trigger firing during opponent's Standby Phase instead of owner's.
* **Root Cause**: Registering `EVENT_PHASE + PHASE_STANDBY` without recording current `Duel.GetTurnCount()`.
* **Omega Fix**: Store target turn count in label:
  ```lua
  e1:SetLabel(Duel.GetTurnCount())
  e1:SetCondition(function(e,tp)
      return Duel.GetTurnCount() > e:GetLabel() and Duel.GetTurnPlayer() == tp
  end)
  ```
* **File References**:
  * Official Reference: [`tmp/omega_scripts/c61441708.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/c61441708.lua)

### 76. Reducing ATK/DEF of Immune Monsters
* **Problem**: Operation applying ATK reduction to monster with `EFFECT_IMMUNE_EFFECT`.
* **Root Cause**: Modifying stats in operation without checking `c:IsImmuneToEffect(e)`.
* **Omega Fix**: Verify immunity before stat reduction:
  ```lua
  if tc:IsRelateToEffect(e) and tc:IsFaceup() and not tc:IsImmuneToEffect(e) then
      -- apply ATK change
  end
  ```
* **File References**:
  * Official Reference: [`tmp/omega_scripts/c11012887.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/c11012887.lua)

### 77. `SetTargetPlayer` Misconfiguration on Continuous Aura Effects
* **Problem**: Field ATK boost applying only to Player 0.
* **Root Cause**: Continuous stat aura calling `e:SetTargetPlayer(tp)` inappropriately.
* **Omega Fix**: Continuous stat auras do not use `SetTargetPlayer`; use `SetTargetRange(LOCATION_MZONE, LOCATION_MZONE)`.
* **File References**:
  * Official Reference: [`tmp/omega_scripts/c33438666.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/c33438666.lua)

### 78. ATK Scaling by Material Count Without 0-Material Guard
* **Problem**: ATK calculation throwing divide-by-zero or evaluation error when materials detached.
* **Root Cause**: `c:GetOverlayCount()` returning 0 when calculating multiplier.
* **Omega Fix**: Guard material count calculation:
  ```lua
  local count = c:GetOverlayCount()
  local atk = count * 500
  ```
* **File References**:
  * Local Reference: [`c250556612.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c250556612.lua)

---

## Section 8: Custom Archetype, Race/Attribute & Constant Bugs (Bugs 79–88)

### 79. Usage of Unbound `RACE_GALAXY` Constant
* **Problem**: Custom card script using `RACE_GALAXY` failing at compile time.
* **Root Cause**: `RACE_GALAXY` is a custom race bitmask not defined in stock YGOPro core constants.
* **Omega Fix**: Declare local bitmask explicitly at top of file:
  ```lua
  local RACE_GALAXY = 0x80000000
  ```
* **File References**:
  * Audit Reference: [`docs/lua-audit-2026-07-20-ultimate-fourth-pass.md`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/docs/lua-audit-2026-07-20-ultimate-fourth-pass.md)

### 80. Set Code Hexadecimal Collision
* **Problem**: Custom archetype set code `0x01` matching official Konami set code for "Hero".
* **Root Cause**: Arbitrary set code values overlap existing official archetype masks.
* **Omega Fix**: Allocate set codes in custom high-range space (e.g. `0x08F0`, `0x92B1`).
* **File References**:
  * Local Reference: [`c259475154.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c259475154.lua)

### 81. Unregistered Custom Token Creation Passcodes
* **Problem**: `Duel.CreateToken(tp, 259999999)` loading invisible card frame or crashing client.
* **Root Cause**: Token passcode missing matching row in SQLite `CCG_v1.db` `datas` table.
* **Omega Fix**: Register all Token passcodes in database and `sync_omega_ccg_db.py`.
* **File References**:
  * Script Sync: [`scripts/sync_omega_ccg_db.py`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/scripts/sync_omega_ccg_db.py)

### 82. Hardcoded Text Search for Archetype Inclusion
* **Problem**: Checking card text via string matching instead of setcode logic.
* **Root Cause**: String matching fails when card names vary or setcode is altered by card effects.
* **Omega Fix**: Use `c:IsSetCard(...)` or official listed text helpers `c:IsListsCode(...)`.
* **File References**:
  * Local Fix: [`c229327103.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c229327103.lua)

### 83. Setting Attribute Modifications Without `EFFECT_CHANGE_ATTRIBUTE`
* **Problem**: Attempting `c:SetAttribute(ATTRIBUTE_FIRE)` directly in operation.
* **Root Cause**: Card attributes are read dynamically from registered effects in engine core.
* **Omega Fix**: Register continuous attribute change effect:
  ```lua
  local e1=Effect.CreateEffect(c)
  e1:SetType(EFFECT_TYPE_SINGLE)
  e1:SetCode(EFFECT_CHANGE_ATTRIBUTE)
  e1:SetValue(ATTRIBUTE_FIRE)
  c:RegisterEffect(e1)
  ```
* **File References**:
  * Official Reference: [`tmp/omega_scripts/c100245016.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/c100245016.lua)

### 84. Unregistered Custom Counter Constants
* **Problem**: `c:AddCounter(0x15, 1)` failing to display counter visual on card image in UI.
* **Root Cause**: Counter type `0x15` not registered in Omega counter texture database.
* **Omega Fix**: Use registered counter constants defined in `constant.lua` (e.g. `COUNTER_SPELL` = `0x1`).
* **File References**:
  * Local Reference: [`c244790302.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c244790302.lua)

### 85. Missing Bitwise AND in Multi-Setcode Mask Evaluation
* **Problem**: `c:IsSetCard(0x108F)` failing on card carrying setcodes `0x08F` and `0x1000`.
* **Root Cause**: Setcodes in engine are packed bitfields. Comparing equality directly instead of using engine `IsSetCard` breaks multi-archetype support.
* **Omega Fix**: Always use `c:IsSetCard(setcode)`.
* **File References**:
  * Audit Document: [`docs/session-handoff-card-scripting.md`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/docs/session-handoff-card-scripting.md)

### 86. Evaluating Combined Attributes with Addition (`+`)
* **Problem**: `c:GetAttribute() == ATTRIBUTE_FIRE + ATTRIBUTE_WATER`.
* **Root Cause**: Dual-attribute monsters represent attributes via bitwise OR (`|`), not addition (`+`).
* **Omega Fix**: Use bitwise operations:
  ```lua
  if (c:GetAttribute() & (ATTRIBUTE_FIRE | ATTRIBUTE_WATER)) ~= 0 then ... end
  ```
* **File References**:
  * Local Fix: [`c244790302.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c244790302.lua)

### 87. Trap Monster Initialization Missing `c:SetCardTarget`
* **Problem**: Continuous Trap Monster Special Summoned to zone without establishing S/T target link.
* **Root Cause**: Trap Monsters must retain connection to their S/T zone card instance.
* **Omega Fix**: Include target link logic during Trap Monster Special Summon operation.
* **File References**:
  * Local Fix: [`c259114562.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c259114562.lua)

### 88. Token Initialization Omitting `TYPE_TOKEN` in Database
* **Problem**: Token created in-game treated as Effect Monster or Card carrying incorrect card frame.
* **Root Cause**: `datas.type` column in SQLite database missing `TYPE_TOKEN` (`0x4140`).
* **Omega Fix**: Ensure database row specifies `type` containing `TYPE_MONSTER + TYPE_TOKEN`.
* **File References**:
  * Script Sync: [`scripts/sync_omega_ccg_db.py`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/scripts/sync_omega_ccg_db.py)

---

## Section 9: Opponent Interactions & Ownership Bugs (Bugs 89–95)

### 89. Deducting Opponent Resources as Activation Cost
* **Problem**: Discarding card from opponent's hand as cost (`e:SetCost`).
* **Root Cause**: YGO rules prohibit paying activation costs using opponent's resources unless text explicitly overrides standard game rules.
* **Omega Fix**: Move opponent resource movement into effect operation (`e:SetOperation`), not cost.
* **File References**:
  * Local Fix: [`c226645052.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c226645052.lua)

### 90. Banishing Opponent's Hand Cards Face-Up Unconditionally
* **Problem**: Effect banishing card from opponent's hand placing card face-up when text specifies hidden card.
* **Root Cause**: `Duel.Remove` defaults to `POS_FACEUP` unless `POS_FACEDOWN` is specified.
* **Omega Fix**:
  ```lua
  Duel.Remove(g, POS_FACEDOWN, REASON_EFFECT)
  ```
* **File References**:
  * Official Reference: [`tmp/omega_scripts/c71197066.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/c71197066.lua)

### 91. Returning Opponent's Cards to "Your" Hand / Deck
* **Problem**: `Duel.SendtoHand(tc, tp, REASON_EFFECT)` sending opponent's card to player's hand.
* **Root Cause**: Cards can **never** enter opponent's hand or Main Deck. Engine automatically redirects card to owner's hand, but script logic expecting card count in player's hand fails.
* **Omega Fix**: Always check owner:
  ```lua
  local owner = tc:GetOwner()
  Duel.SendtoHand(tc, owner, REASON_EFFECT)
  ```
* **File References**:
  * Local Reference: [`c218905439.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/public/CCG%20Downloads/CCG_Scripts/c218905439.lua)

### 92. Public UI Leak During Opponent Deck Search
* **Problem**: Allowing player to view opponent's entire Deck when card text specifies random selection.
* **Root Cause**: `Duel.SelectMatchingCard(tp, ... LOCATION_DECK)` shows full Deck UI to `tp`.
* **Omega Fix**: If selection is random or done by opponent, pass `1-tp` as selecting player.
* **File References**:
  * Official Reference: [`tmp/omega_scripts/c100256003.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/c100256003.lua)

### 93. Forcing Opponent Attack Without Attack Position Verification
* **Problem**: Forcing target opponent monster to attack when monster is in Defense Position.
* **Root Cause**: Monsters in Defense Position cannot declare attacks.
* **Omega Fix**: Include `c:IsAttackPos()` and `c:CanAttack()` in target filter.
* **File References**:
  * Official Reference: [`tmp/omega_scripts/c51345461.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/c51345461.lua)

### 94. Attaching Opponent Card as Xyz Material Without Owner GY Handling
* **Problem**: Opponent's card attached as Xyz material going to player's GY when detached.
* **Root Cause**: Omitting owner verification on material detachment.
* **Omega Fix**: Engine routes detached materials to owner's GY automatically; script must not manually send detached material to `tp`'s GY.
* **File References**:
  * Official Reference: [`tmp/omega_scripts/c100240202.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/c100240202.lua)

### 95. Incorrect Link Marker Co-Link Arrow Calculation Across Fields
* **Problem**: Co-link calculation between Link monsters on opposite sides of field returning `false`.
* **Root Cause**: Link arrows across fields require inverted directional checks (e.g. Top arrow points to opponent's Bottom arrow).
* **Omega Fix**: Use engine standard `c:IsDirectlyToAnotherCard(tc)` or `aux.GetColumnGroup`.
* **File References**:
  * Local Audit Reference: [`docs/lua-manual-review-guide-2026-07-20.md`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/docs/lua-manual-review-guide-2026-07-20.md#L19)

---

## Section 10: Advanced Engine State & Memory Safety Bugs (Bugs 96–100)

### 96. Accessing Properties of Reset Effect Objects
* **Problem**: Calling `e:GetHandler()` after calling `e:Reset()`.
* **Root Cause**: Calling `Reset()` invalidates the internal C++ pointer of the effect object. Subsequent method calls return `nil` or throw invalid pointer exception.
* **Omega Fix**: Cache needed properties **before** invoking `e:Reset()`.
* **File References**:
  * Official Reference: [`tmp/omega_scripts/c61434639.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/c61434639.lua)

### 97. Accumulating Un-Deleted `Group` Objects in Loops
* **Problem**: `Group.CreateGroup()` inside `while` loop causing memory growth over long duels.
* **Root Cause**: Lua group wrappers persist in engine memory until garbage collected or manually deleted via `g:DeleteGroup()`.
* **Omega Fix**: Call `g:DeleteGroup()` when temporary group is no longer needed:
  ```lua
  local g = Group.CreateGroup()
  -- operations on g
  g:DeleteGroup()
  ```
* **File References**:
  * Local Audit Reference: [`docs/session-handoff-card-scripting.md`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/docs/session-handoff-card-scripting.md)

### 98. Modifying Group Contents During Active `g:ForEach` / `g:GetNext` Iteration
* **Problem**: Removing card from group (`g:RemoveCard(tc)`) inside `for tc in aux.Next(g)` loop.
* **Root Cause**: Mutating group structure during iteration invalidates internal group iterator index, skipping remaining elements.
* **Omega Fix**: Clone group before mutating, or collect cards to remove into a separate group:
  ```lua
  local g2 = g:Clone()
  for tc in aux.Next(g2) do
      if condition then g:RemoveCard(tc) end
  end
  ```
* **File References**:
  * Official Reference: [`tmp/omega_scripts/c101203018.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/c101203018.lua)

### 99. Calling Single-Card Methods on `Group` Objects
* **Problem**: `local atk = g:GetAttack()` where `g` is a `Group`.
* **Root Cause**: `Group` objects do not possess card methods like `GetAttack` or `GetCode`. Attempting to dereference throws Lua execution error.
* **Omega Fix**: Extract first card or iterate over group:
  ```lua
  local tc = g:GetFirst()
  if tc then local atk = tc:GetAttack() end
  ```
* **File References**:
  * Local Audit Reference: [`docs/session-handoff-card-scripting.md`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/docs/session-handoff-card-scripting.md)

### 100. Unchecked `Duel.GetChainMaterial` Null Dereference in Fusion Procedures
* **Problem**: Fusion procedure calling `local chmf = Duel.GetChainMaterial(tp)` and immediately invoking `chmf:GetOperation()`.
* **Root Cause**: `GetChainMaterial` returns `nil` if "Chain Material" is not active. Dereferencing `nil` causes immediate script execution crash during Fusion Summon evaluation.
* **Omega Fix**: Always check for `nil` before using Chain Material reference:
  ```lua
  local chmf = Duel.GetChainMaterial(tp)
  if chmf then
      -- apply Chain Material substitution
  end
  ```
* **File References**:
  * Official Reference: [`tmp/omega_scripts/fixed-scripts/fusion/c87669904.lua`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts/fixed-scripts/fusion/c87669904.lua)

---

## Conclusion & Verification Guidelines

When writing or auditing YGO Omega Lua scripts:
1. **Always verify against [`tmp/omega_scripts`](file:///c:/Manual%20Files/Applications/YugiohCCG.github.io/tmp/omega_scripts)** (the official Omega corpus) for current function signatures and procedure helpers.
2. **Run `luac -p` and strict callback registration smoke tests** before deploying scripts.
3. **Verify SQLite Database SHA-256 and `aux.Stringid` alignment** in `CCG_v1.db` to prevent client UI prompt locks.
