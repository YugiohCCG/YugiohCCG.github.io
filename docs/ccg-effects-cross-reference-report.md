# CCG Lua Effects Cross-Reference Report
**Date**: 2026-08-06

This report cross-references every single effect in CCG Lua scripts against official Yugioh Omega scripts. Effects are matched by their (Type, Code, Property, Range) signature.

## Summary
- **Total Cards Analyzed**: 578
- **Total Effects Cross-Referenced**: 1719
- **Effects Passed**: 1601
- **Effects Failed (Anomalous/Custom)**: 118
---

## c210175845.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100261051.lua, c1154611.lua, c15155568.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_GRAVE`

## c210366076.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211052.lua, c100211099.lua, c100213004.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_GRAVE`

## c210506870.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c13073850.lua, c24573625.lua, c42880485.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_SPECIAL_SUMMON|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_PLAYER_TARGET|Range:LOCATION_PZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10024317.lua, c101302204.lua, c15146890.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_PZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10000010.lua, c10000020.lua, c100213002.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_UPDATE_ATTACK|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 5**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`

## c210628767.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1006081.lua, c101203023.lua, c10158145.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211004.lua, c101203057.lua, c101204051.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_SZONE`
* **Effect 3**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_F|Code:EVENT_PHASE+PHASE_END|Prop:NONE|Range:NONE`

## c210678856.lua
* No effects found using standard `Effect.CreateEffect` pattern.

## c210696007.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c61470213.lua, c91781484.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_ADD_SETCODE|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214006.lua, c100214014.lua, c100214015.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100213002.lua, c100214018.lua, c100240205.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_GRAVE`

## c210716547.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c38339996.lua, c65734501.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_HAND+LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100212003.lua, c100241003.lua, c100256008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_DISABLE|Prop:NONE|Range:NONE`

## c210923192.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10012614.lua, c100211100.lua, c100211125.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_UPDATE_ATTACK|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c12021072.lua, c13235258.lua, c27970830.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_SUMMON_SUCCESS|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c18973184.lua, c57775709.lua, c57775790.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_CHAIN_END|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c100214010.lua, c100256020.lua, c101203057.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_SZONE`
* **Effect 6**: `PASS` (Matches official pattern found in: c101304095.lua, c20822520.lua, c27993919.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_CHAINING|Prop:NONE|Range:NONE`

## c211086520.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`

## c211682274.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1003028.lua, c101202083.lua, c101203021.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c11852093.lua, c20938824.lua, c33334269.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_REMOVE|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`

## c211699737.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`

## c211873618.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100245001.lua, c100245002.lua, c100259002.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`

## c211964444.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`

## c212052682.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c131182.lua, c15495787.lua, c16279989.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_SUMMON|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c14761450.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_MSET|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_HAND`
* **Effect 4**: `PASS` (Matches official pattern found in: c22134079.lua, c26016357.lua, c36239585.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_FLIP|Prop:EFFECT_FLAG_CARD_TARGET|Range:NONE`
* **Effect 5**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_QUICK_O+EFFECT_TYPE_XMATERIAL|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:NONE`

## c212055290.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`

## c212184534.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000010.lua, c10000030.lua, c100211050.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`

## c212345347.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100256022.lua, c100261007.lua, c101203073.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 3**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_EXTRA_SYNCHRO_MATERIAL|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_SZONE`
* **Effect 4**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CHANGE_TYPE|Prop:NONE|Range:NONE`

## c212377618.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c61470213.lua, c91781484.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_ADD_SETCODE|Prop:NONE|Range:NONE`

## c212413422.lua
* **Effect 1**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_ADD_SETCODE|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c1003028.lua, c101202083.lua, c101203021.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 3**: `PASS` (Matches official pattern found in: c100214019.lua, c100228002.lua, c100259003.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c27024795.lua, c56499179.lua, c56499179.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_REMOVE|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_REMOVED`
* **Effect 5**: `PASS` (Matches official pattern found in: c10000020.lua, c100240201.lua, c100254201.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_UPDATE_ATTACK|Prop:NONE|Range:NONE`

## c212429024.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000040.lua, c17469113.lua, c24643913.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_DISABLE_SPSUMMON|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c12421694.lua, c16008155.lua, c17749468.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_CHAIN_SOLVED|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 4**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CHANGE_TYPE|Prop:NONE|Range:NONE`

## c212684822.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100245006.lua, c101204038.lua, c101306036.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_EXTRA`
* **Effect 3**: `PASS` (Matches official pattern found in: c34031284.lua, c35494087.lua, c3918345.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_REFLECT_BATTLE_DAMAGE|Prop:NONE|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c60953118.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CHANGE_BATTLE_DAMAGE|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:LOCATION_MZONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c212737555.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100213002.lua, c100214018.lua, c100240205.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_GRAVE`
* **Effect 2**: `PASS` (Matches official pattern found in: c11852093.lua, c20938824.lua, c33334269.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_REMOVE|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`

## c212822164.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100245001.lua, c100245002.lua, c100245003.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_INDESTRUCTABLE_BATTLE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211003.lua, c100211051.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_SPECIAL_SUMMON|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:NONE`

## c212837324.lua
* **Effect 1**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_AVOID_BATTLE_DAMAGE|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100212004.lua, c100256010.lua, c10032958.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_BATTLE_DESTROYING|Prop:NONE|Range:NONE`

## c213266433.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c120287032.lua, c120301038.lua, c36326160.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_ATTACK_ANNOUNCE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245038.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 4**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_IMMUNE_EFFECT|Prop:EFFECT_FLAG_SET_AVAILABLE|Range:NONE`

## c213530841.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100245010.lua, c100245011.lua, c100259009.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_CHAINING|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100256009.lua, c100256023.lua, c10045474.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_TRAP_ACT_IN_HAND|Prop:NONE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211098.lua, c100212005.lua, c10024317.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_DESTROYED|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c213611313.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c12421694.lua, c16008155.lua, c17749468.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_CHAIN_SOLVED|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100261051.lua, c1154611.lua, c15155568.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_GRAVE`

## c213615627.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100256024.lua, c11125718.lua, c11954712.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_PIERCE|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c10000020.lua, c100240201.lua, c100254201.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_UPDATE_ATTACK|Prop:NONE|Range:NONE`

## c213849997.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100256009.lua, c100256023.lua, c10045474.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_TRAP_ACT_IN_HAND|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214006.lua, c100214014.lua, c100214015.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211052.lua, c100211099.lua, c100213004.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_GRAVE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100245037.lua, c101203030.lua, c101204077.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_DISABLE|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c100245037.lua, c101203030.lua, c101204077.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_DISABLE_EFFECT|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`

## c213990492.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214008.lua, c100245032.lua, c100256006.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_ATTACK_ANNOUNCE|Prop:NONE|Range:LOCATION_GRAVE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211098.lua, c100212005.lua, c10024317.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_DESTROYED|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c214226989.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000010.lua, c10000030.lua, c100211050.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245038.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10000010.lua, c10000030.lua, c100211050.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`

## c214349717.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c101304086.lua, c10755153.lua, c15397015.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_SUMMON|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214004.lua, c13647631.lua, c29092121.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_HAND`

## c214371067.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c15327215.lua, c15475415.lua, c19301729.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:NONE|Range:LOCATION_HAND`
* **Effect 3**: `PASS` (Matches official pattern found in: c34072799.lua, c42600274.lua, c52738610.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_RELEASE|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`

## c214511076.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1003028.lua, c101202083.lua, c101203021.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100245031.lua, c100245033.lua, c101303204.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_BE_MATERIAL|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`

## c214552846.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c34487429.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_FZONE`
* **Effect 3**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_F|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`

## c215006791.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100213002.lua, c100256010.lua, c101203038.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_INDESTRUCTABLE_BATTLE|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100261050.lua, c10755984.lua, c12800777.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_PHASE+PHASE_END|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c10140443.lua, c11954712.lua, c15635751.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_PHASE+PHASE_STANDBY|Prop:NONE|Range:NONE`

## c215034223.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c101203002.lua, c101203029.lua, c101203052.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:LOCATION_GRAVE`

## c215068354.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c37192109.lua, c39643167.lua, c51053997.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_PHASE+PHASE_STANDBY|Prop:EFFECT_FLAG_IGNORE_IMMUNE|Range:NONE`

## c215105971.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245038.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10002346.lua, c100250208.lua, c100261050.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_SINGLE|Code:EFFECT_DESTROY_REPLACE|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211001.lua, c100212001.lua, c101204036.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_LEAVE_FIELD|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c215142357.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c15005145.lua, c23526128.lua, c32086564.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_INDESTRUCTABLE_EFFECT|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c30459350.lua, c53829527.lua, c58809685.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_REMOVE|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:LOCATION_SZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100211100.lua, c100211100.lua, c100211125.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c37552929.lua, c38669664.lua, c55870497.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_CHAINING|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_SZONE`

## c215445495.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000010.lua, c10000030.lua, c100211050.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`

## c215621622.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`

## c215629896.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c38339996.lua, c65734501.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_HAND+LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c101203015.lua, c3773196.lua, c42216237.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_SINGLE|Code:EVENT_REMOVE|Prop:NONE|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c101203015.lua, c12196873.lua, c18743376.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_PHASE+PHASE_STANDBY|Prop:NONE|Range:LOCATION_REMOVED`

## c215730767.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211100.lua, c100211100.lua, c100211125.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_SZONE`

## c215768254.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214008.lua, c100245032.lua, c100256006.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100256022.lua, c100261007.lua, c101203073.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100256022.lua, c100261007.lua, c101203073.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 4**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_EXTRA_SYNCHRO_MATERIAL|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_SZONE`
* **Effect 5**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CHANGE_TYPE|Prop:NONE|Range:NONE`

## c215853847.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100240204.lua, c101202085.lua, c101203001.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_INDESTRUCTABLE_BATTLE|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c17086528.lua, c19028307.lua, c19712214.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_NO_BATTLE_DAMAGE|Prop:NONE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211002.lua, c10509340.lua, c10805153.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_ACTIVATE|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c10000020.lua, c100240201.lua, c100254201.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_UPDATE_ATTACK|Prop:NONE|Range:NONE`
* **Effect 6**: `PASS` (Matches official pattern found in: c100256024.lua, c101302204.lua, c10526791.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_ATTACK_ALL|Prop:NONE|Range:NONE`
* **Effect 7**: `PASS` (Matches official pattern found in: c10282757.lua, c42717221.lua, c49121795.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_ATTACK|Prop:NONE|Range:NONE`

## c215885404.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214006.lua, c100214014.lua, c100214015.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:NONE`

## c215921734.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214006.lua, c100214014.lua, c100214015.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211052.lua, c100211099.lua, c100213004.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_GRAVE`
* **Effect 3**: `PASS` (Matches official pattern found in: c1164211.lua, c15610297.lua, c17601919.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CHANGE_TYPE|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c10004783.lua, c100228002.lua, c100256022.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_EQUIP_LIMIT|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c10004783.lua, c100228002.lua, c100246001.lua)
  * Signature: `Type:EFFECT_TYPE_EQUIP|Code:EFFECT_UPDATE_ATTACK|Prop:NONE|Range:NONE`
* **Effect 6**: `PASS` (Matches official pattern found in: c14235211.lua, c32991300.lua, c46354113.lua)
  * Signature: `Type:EFFECT_TYPE_EQUIP|Code:EFFECT_PIERCE|Prop:NONE|Range:NONE`

## c215984744.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100245038.lua, c101203039.lua, c120231052.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_INDESTRUCTABLE_EFFECT|Prop:NONE|Range:LOCATION_MZONE`

## c216140411.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CHANGE_CODE|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_SZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c25415161.lua, c51053997.lua, c53742162.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_LEAVE_FIELD|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_SZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100213002.lua, c100214018.lua, c100240205.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_GRAVE`

## c216258796.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c11335209.lua, c34230233.lua, c41406613.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_GRAVE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245038.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_MZONE`

## c216294702.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214006.lua, c100214014.lua, c100214015.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10560119.lua, c11074235.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_LEAVE_FIELD_REDIRECT|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_CLIENT_HINT|Range:NONE`

## c216505735.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`

## c216532402.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100261047.lua, c101203025.lua, c20665527.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_DESTROYED|Prop:EFFECT_FLAG_DAMAGE_STEP+EFFECT_FLAG_DELAY|Range:LOCATION_GRAVE`

## c216620496.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214006.lua, c100214014.lua, c100214015.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c86319972.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_REMOVE|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:LOCATION_GRAVE`

## c216958556.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1006081.lua, c101203023.lua, c10158145.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100213002.lua, c100214018.lua, c100240205.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_GRAVE`

## c217029078.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245038.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10140443.lua, c11954712.lua, c15635751.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_PHASE+PHASE_STANDBY|Prop:NONE|Range:NONE`

## c217118040.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100214016.lua, c100256024.lua, c101203006.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_ADD_TYPE|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`

## c217174535.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211098.lua, c10300821.lua, c1340142.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_SPSUMMON|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245038.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211001.lua, c11674673.lua, c11688916.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_MZONE`

## c217332244.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c131182.lua, c15495787.lua, c16279989.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_SUMMON|Prop:NONE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c1003028.lua, c101202083.lua, c101203021.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 4**: `PASS` (Matches official pattern found in: c100250209.lua, c10113611.lua, c16261341.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_BATTLE_DAMAGE|Prop:NONE|Range:NONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 6**: `PASS` (Matches official pattern found in: c11852093.lua, c20938824.lua, c33334269.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_REMOVE|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 7**: `PASS` (Matches official pattern found in: c10000020.lua, c100240201.lua, c100254201.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_UPDATE_ATTACK|Prop:NONE|Range:NONE`

## c217632789.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100245010.lua, c100245011.lua, c100259009.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_CHAINING|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100256009.lua, c100256023.lua, c10045474.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_TRAP_ACT_IN_HAND|Prop:NONE|Range:NONE`

## c217645912.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c16269385.lua, c16269385.lua, c26534688.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_FZONE`

## c217700538.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214006.lua, c100214014.lua, c100214015.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100263008.lua, c101203019.lua, c10732060.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_GRAVE`

## c217713649.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c34267821.lua, c37629703.lua, c42352091.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_HAND+LOCATION_MZONE`

## c218142234.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100212005.lua, c100245016.lua, c100245017.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_PZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214019.lua, c100228002.lua, c100259003.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211001.lua, c100212001.lua, c101204036.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_LEAVE_FIELD|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`

## c218261525.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214008.lua, c100245032.lua, c100245034.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_BE_MATERIAL|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100213002.lua, c100214018.lua, c100240205.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_GRAVE`

## c218600459.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c38339996.lua, c65734501.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_HAND+LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c101203015.lua, c3773196.lua, c42216237.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_SINGLE|Code:EVENT_REMOVE|Prop:NONE|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c101203015.lua, c12196873.lua, c18743376.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_PHASE+PHASE_STANDBY|Prop:NONE|Range:LOCATION_REMOVED`

## c218685316.lua
* **Effect 1**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_MOVE|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_HAND+LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100213002.lua, c100214018.lua, c100240205.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_GRAVE`

## c218837030.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214008.lua, c100245032.lua, c100256006.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214019.lua, c100228002.lua, c100259003.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100211003.lua, c100211051.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_SPECIAL_SUMMON|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:NONE`

## c218905439.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214006.lua, c100214014.lua, c100214015.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c101203002.lua, c101203029.lua, c101203052.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:LOCATION_GRAVE`

## c219002796.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214019.lua, c100245006.lua, c11443677.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_SINGLE_RANGE+EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_EXTRA`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000090.lua, c100213003.lua, c100250203.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_IMMUNE_EFFECT|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c1710476.lua, c23950192.lua, c2980764.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_ATTACK_ANNOUNCE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c11039171.lua, c1516510.lua, c15939229.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_SINGLE|Code:EVENT_SPSUMMON_SUCCESS|Prop:NONE|Range:NONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c100212004.lua, c100256010.lua, c10032958.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_BATTLE_DESTROYING|Prop:NONE|Range:NONE`

## c219047593.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10004783.lua, c100228002.lua, c100256022.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_EQUIP_LIMIT|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214006.lua, c100214014.lua, c100214015.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c19089195.lua, c59385322.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_F|Code:EVENT_BATTLE_START|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c11881272.lua, c20007374.lua, c2896663.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_BATTLE_DESTROYING|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c10474647.lua, c10474647.lua, c10474647.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SET_ATTACK_FINAL|Prop:NONE|Range:NONE`
* **Effect 6**: `PASS` (Matches official pattern found in: c100212003.lua, c100241003.lua, c100256008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_DISABLE|Prop:NONE|Range:NONE`
* **Effect 7**: `PASS` (Matches official pattern found in: c100212003.lua, c100241003.lua, c100256008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_DISABLE_EFFECT|Prop:NONE|Range:NONE`
* **Effect 8**: `PASS` (Matches official pattern found in: c17573739.lua, c29095457.lua, c38511382.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_DISABLE_TRAPMONSTER|Prop:NONE|Range:NONE`

## c219150610.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c1122030.lua, c18458255.lua, c24839398.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EFFECT_DESTROY_REPLACE|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c25415161.lua, c51053997.lua, c53742162.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_LEAVE_FIELD|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_SZONE`

## c219419648.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100240204.lua, c101202085.lua, c101203001.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_INDESTRUCTABLE_BATTLE|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c34031284.lua, c35494087.lua, c3918345.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_REFLECT_BATTLE_DAMAGE|Prop:NONE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c10019086.lua, c100212002.lua, c100256005.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_ATTACK_ANNOUNCE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c10474647.lua, c10474647.lua, c10474647.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SET_ATTACK_FINAL|Prop:NONE|Range:NONE`

## c219543855.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100256024.lua, c101203013.lua, c101302204.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_SINGLE|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214019.lua, c100228002.lua, c100259003.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`

## c219714894.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_PAY_LPCOST|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_GRAVE`
* **Effect 3**: `PASS` (Matches official pattern found in: c14318794.lua, c59957503.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_PAY_LPCOST|Prop:NONE|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c14318794.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_TURN_END|Prop:NONE|Range:NONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c100245003.lua, c100256019.lua, c100256019.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_LEAVE_FIELD_REDIRECT|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`

## c219783132.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100256022.lua, c100261007.lua, c101203073.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211125.lua, c14154221.lua, c14220547.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:LOCATION_SZONE`

## c219826457.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c120300000.lua, c13073850.lua, c13073850.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SET_BASE_ATTACK|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 2**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_REMOVED`
* **Effect 3**: `PASS` (Matches official pattern found in: c36319131.lua, c63542003.lua, c66192538.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE+LOCATION_GRAVE`
* **Effect 4**: `PASS` (Matches official pattern found in: c10004783.lua, c100228002.lua, c100256022.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_EQUIP_LIMIT|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c10004783.lua, c100228002.lua, c100246001.lua)
  * Signature: `Type:EFFECT_TYPE_EQUIP|Code:EFFECT_UPDATE_ATTACK|Prop:NONE|Range:NONE`
* **Effect 6**: `PASS` (Matches official pattern found in: c11881272.lua, c20007374.lua, c2896663.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_BATTLE_DESTROYING|Prop:NONE|Range:LOCATION_SZONE`

## c219905997.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000010.lua, c10000030.lua, c100211050.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`

## c219995840.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c220124524.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c12678601.lua, c50304345.lua, c50793215.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_SINGLE|Code:EVENT_BE_MATERIAL|Prop:NONE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10182251.lua, c11845050.lua, c12948099.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_ADD_TYPE|Prop:NONE|Range:NONE`

## c220148485.lua
* No effects found using standard `Effect.CreateEffect` pattern.

## c220150285.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100213002.lua, c100214018.lua, c100240205.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_GRAVE`

## c220305422.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211050.lua, c100212001.lua, c100213001.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:EFFECT_FLAG_DAMAGE_CAL+EFFECT_FLAG_DAMAGE_STEP|Range:LOCATION_MZONE`

## c220538776.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10194329.lua, c15771991.lua, c70939418.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_DAMAGE|Prop:EFFECT_FLAG_DAMAGE_CAL+EFFECT_FLAG_DAMAGE_STEP+EFFECT_FLAG_DELAY|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211052.lua, c100211099.lua, c100213004.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_GRAVE`
* **Effect 3**: `PASS` (Matches official pattern found in: c92536468.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_REVERSE_DAMAGE|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:NONE`

## c220749574.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c101304086.lua, c10755153.lua, c15397015.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_SUMMON|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000.lua, c10000040.lua, c100240201.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 3**: `PASS` (Matches official pattern found in: c24610207.lua, c55697723.lua, c61496006.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_XYZ_LEVEL|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 5**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c220856437.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c14391625.lua, c16246535.lua, c27182739.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_NONTUNER|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 2**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_REMOVED`
* **Effect 3**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`

## c220916791.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c34072799.lua, c42600274.lua, c52738610.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_RELEASE|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`

## c221047295.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211053.lua, c100212003.lua, c14457896.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100213002.lua, c100214018.lua, c100240205.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_GRAVE`

## c221321849.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211053.lua, c100212003.lua, c14457896.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100213002.lua, c100214018.lua, c100240205.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_GRAVE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100245003.lua, c100256019.lua, c100256019.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_LEAVE_FIELD_REDIRECT|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`

## c221509060.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`

## c221511784.lua
* **Effect 1**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND+LOCATION_REMOVED`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245038.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100261025.lua, c100261027.lua, c101203003.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_PHASE+PHASE_END|Prop:NONE|Range:LOCATION_GRAVE`

## c221672256.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245038.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c221759221.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c14391625.lua, c16246535.lua, c27182739.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_NONTUNER|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c4632019.lua, c92676637.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SYNCHRO_LEVEL|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 4**: `PASS` (Matches official pattern found in: c100214008.lua, c100245032.lua, c100245034.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_BE_MATERIAL|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c37192109.lua, c39643167.lua, c51053997.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_PHASE+PHASE_STANDBY|Prop:EFFECT_FLAG_IGNORE_IMMUNE|Range:NONE`

## c221822671.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211123.lua, c100211124.lua, c100245003.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`
* **Effect 3**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_GRAVE`

## c221827483.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c61470213.lua, c91781484.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_ADD_SETCODE|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214019.lua, c100245006.lua, c11443677.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_SINGLE_RANGE+EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_EXTRA`
* **Effect 3**: `PASS` (Matches official pattern found in: c1710476.lua, c23950192.lua, c2980764.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_ATTACK_ANNOUNCE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100212004.lua, c100256010.lua, c10032958.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_BATTLE_DESTROYING|Prop:NONE|Range:NONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c100211122.lua, c101203016.lua, c12888461.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_REMOVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 6**: `PASS` (Matches official pattern found in: c1516510.lua, c16240772.lua, c28643791.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_IMMUNE_EFFECT|Prop:NONE|Range:NONE`
* **Effect 7**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_PHASE+PHASE_STANDBY|Prop:NONE|Range:NONE`

## c221855414.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211123.lua, c100250204.lua, c100259005.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_BE_EFFECT_TARGET|Prop:EFFECT_FLAG_IGNORE_IMMUNE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c101204044.lua, c16006416.lua, c34755994.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c10000000.lua, c10000020.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_F|Code:EVENT_PHASE+PHASE_END|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c60018643.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_TO_HAND|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:NONE`

## c221924008.lua
* **Effect 1**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_EXTRA`
* **Effect 2**: `PASS` (Matches official pattern found in: c14799437.lua, c15941690.lua, c16313112.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:NONE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100211003.lua, c100211051.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_SPECIAL_SUMMON|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:NONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c100245003.lua, c100256019.lua, c100256019.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_LEAVE_FIELD_REDIRECT|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`
* **Effect 6**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_NONTUNER|Prop:NONE|Range:NONE`

## c222257685.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211052.lua, c100211099.lua, c100213004.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_GRAVE`
* **Effect 3**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_ADD_CODE|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`

## c222476063.lua
* **Effect 1**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_ADD_SETCODE|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c1003028.lua, c101202083.lua, c101203021.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c222654570.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211100.lua, c100211100.lua, c100211125.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_SZONE`

## c222676270.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100256002.lua, c100263002.lua, c101306004.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_HAND`

## c222782750.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100256002.lua, c100263002.lua, c101306004.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_HAND`

## c222875833.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100256009.lua, c100256023.lua, c10045474.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_TRAP_ACT_IN_HAND|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214006.lua, c100214014.lua, c100214015.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211052.lua, c100211099.lua, c100213004.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_GRAVE`

## c223158720.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214006.lua, c100214014.lua, c100214015.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100213002.lua, c100214018.lua, c100240205.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_GRAVE`

## c223366685.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c15005145.lua, c23526128.lua, c32086564.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_INDESTRUCTABLE_EFFECT|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211100.lua, c100211100.lua, c100211125.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100211122.lua, c101203016.lua, c12888461.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_REMOVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c223505382.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`

## c223512283.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100240204.lua, c101202085.lua, c101203001.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_INDESTRUCTABLE_BATTLE|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000010.lua, c10000020.lua, c100213002.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_UPDATE_ATTACK|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100261026.lua, c101203047.lua, c10804018.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_PHASE+PHASE_END|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c100256005.lua, c100263006.lua, c101306036.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_DESTROYED|Prop:NONE|Range:NONE`
* **Effect 6**: `PASS` (Matches official pattern found in: c5914858.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_BE_LINK_MATERIAL|Prop:EFFECT_FLAG_SET_AVAILABLE|Range:LOCATION_MZONE`

## c223558392.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100256008.lua, c100261023.lua, c101202087.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_HAND`

## c223592011.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100256008.lua, c100261023.lua, c101202087.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_HAND`

## c223750159.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c55990317.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_F|Code:EVENT_DESTROYED|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c223770816.lua
* **Effect 1**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CHANGE_CODE|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214019.lua, c100228002.lua, c100259003.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211001.lua, c11674673.lua, c11688916.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100211123.lua, c100211124.lua, c100245003.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`

## c224049334.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_SZONE+LOCATION_GRAVE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100256005.lua, c100263006.lua, c101306036.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_DESTROYED|Prop:NONE|Range:NONE`

## c224225695.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c131182.lua, c15495787.lua, c16279989.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_SUMMON|Prop:NONE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c1003028.lua, c101202083.lua, c101203021.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 4**: `PASS` (Matches official pattern found in: c120155000.lua, c122520.lua, c17313545.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_DISABLE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c100211123.lua, c100211124.lua, c100245003.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`
* **Effect 6**: `PASS` (Matches official pattern found in: c11852093.lua, c20938824.lua, c33334269.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_REMOVE|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 7**: `PASS` (Matches official pattern found in: c10000020.lua, c100240201.lua, c100254201.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_UPDATE_ATTACK|Prop:NONE|Range:NONE`
* **Effect 8**: `PASS` (Matches official pattern found in: c10000020.lua, c100240201.lua, c100254201.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_UPDATE_ATTACK|Prop:NONE|Range:NONE`
* **Effect 9**: `PASS` (Matches official pattern found in: c12275533.lua, c15771991.lua, c16480084.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_UPDATE_DEFENSE|Prop:NONE|Range:NONE`
* **Effect 10**: `PASS` (Matches official pattern found in: c12275533.lua, c15771991.lua, c16480084.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_UPDATE_DEFENSE|Prop:NONE|Range:NONE`

## c224235021.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c101304095.lua, c20822520.lua, c27993919.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_CHAINING|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100256009.lua, c100256023.lua, c10045474.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_TRAP_ACT_IN_HAND|Prop:NONE|Range:NONE`

## c224274662.lua
* **Effect 1**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_EXTRA`
* **Effect 2**: `PASS` (Matches official pattern found in: c100256024.lua, c101203013.lua, c101302204.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_SINGLE|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211050.lua, c100212001.lua, c100213001.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:EFFECT_FLAG_DAMAGE_CAL+EFFECT_FLAG_DAMAGE_STEP|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100261026.lua, c101203047.lua, c10804018.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_PHASE+PHASE_END|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c100212003.lua, c100241003.lua, c100256008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_DISABLE|Prop:NONE|Range:NONE`

## c224467692.lua
* No effects found using standard `Effect.CreateEffect` pattern.

## c224751741.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100261024.lua, c101203066.lua, c24461358.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_LEAVE_FIELD|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_GRAVE`
* **Effect 3**: `PASS` (Matches official pattern found in: c5914858.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_BE_LINK_MATERIAL|Prop:EFFECT_FLAG_SET_AVAILABLE|Range:LOCATION_MZONE`

## c224774049.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`

## c224800873.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211052.lua, c100211099.lua, c100213004.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_GRAVE`

## c224811863.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1003028.lua, c101202083.lua, c101203021.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211003.lua, c100211051.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_SPECIAL_SUMMON|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:NONE`

## c224822244.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1006081.lua, c101203023.lua, c10158145.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10019086.lua, c100212002.lua, c100256005.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_ATTACK_ANNOUNCE|Prop:NONE|Range:LOCATION_MZONE`

## c224943273.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c225091736.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c1006081.lua, c101203023.lua, c10158145.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`

## c225106953.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1003028.lua, c101202083.lua, c101203021.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100245001.lua, c100245002.lua, c100259002.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211003.lua, c100211051.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_SPECIAL_SUMMON|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:NONE`

## c225109525.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000010.lua, c10000020.lua, c100213002.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_UPDATE_ATTACK|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211123.lua, c100211124.lua, c100245003.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`

## c225161820.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211123.lua, c100211124.lua, c100245003.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10474647.lua, c10474647.lua, c10474647.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SET_ATTACK_FINAL|Prop:NONE|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c10000020.lua, c100240201.lua, c100254201.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_UPDATE_ATTACK|Prop:NONE|Range:NONE`

## c225260657.lua
* No effects found using standard `Effect.CreateEffect` pattern.

## c225358630.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100245010.lua, c100245011.lua, c100259009.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_CHAINING|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211122.lua, c101203016.lua, c12888461.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_REMOVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c12541409.lua, c22377092.lua, c2547033.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_TRAP_ACT_IN_SET_TURN|Prop:EFFECT_FLAG_SET_AVAILABLE|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100245003.lua, c100256019.lua, c100256019.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_LEAVE_FIELD_REDIRECT|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`

## c226063408.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c101203010.lua, c101208203.lua, c26866984.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_HAND+LOCATION_GRAVE`
* **Effect 2**: `PASS` (Matches official pattern found in: c1006081.lua, c101203023.lua, c10158145.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`

## c226645052.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c101304086.lua, c10755153.lua, c15397015.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_SUMMON|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214004.lua, c13647631.lua, c29092121.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_HAND`
* **Effect 3**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_TRIGGER|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_CLIENT_HINT|Range:NONE`

## c226827770.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_INACTIVATE|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100254202.lua, c101304208.lua, c10529441.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_SPSUMMON_SUCCESS|Prop:NONE|Range:NONE`

## c226902471.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c61470213.lua, c91781484.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_ADD_SETCODE|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211122.lua, c101203016.lua, c12888461.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_REMOVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c226903348.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1003028.lua, c101202083.lua, c101203021.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100245001.lua, c100245002.lua, c100259002.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211003.lua, c100211051.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_SPECIAL_SUMMON|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:NONE`

## c226950506.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100245040.lua, c10080320.lua, c11102908.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_UPDATE_ATTACK|Prop:NONE|Range:LOCATION_FZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100261006.lua, c100261028.lua, c1003840.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_FZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100211003.lua, c100211051.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_SPECIAL_SUMMON|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:NONE`

## c227035644.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100213002.lua, c100214018.lua, c100240205.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_GRAVE`

## c227043533.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c38339996.lua, c65734501.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_HAND+LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c101203015.lua, c3773196.lua, c42216237.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_SINGLE|Code:EVENT_REMOVE|Prop:NONE|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c101203015.lua, c12196873.lua, c18743376.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_PHASE+PHASE_STANDBY|Prop:NONE|Range:LOCATION_REMOVED`

## c227335484.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c101204079.lua, c13023431.lua, c15613529.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_MUST_ATTACK|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 2**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_PHASE+PHASE_BATTLE_START|Prop:NONE|Range:LOCATION_HAND`
* **Effect 3**: `PASS` (Matches official pattern found in: c100212004.lua, c100256010.lua, c10032958.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_BATTLE_DESTROYING|Prop:NONE|Range:NONE`

## c227362839.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211123.lua, c100211124.lua, c100245003.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`

## c227531376.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c131182.lua, c15495787.lua, c16279989.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_SUMMON|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c101203052.lua, c10158145.lua, c10963799.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_SPECIAL_SUMMON|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c15627227.lua, c21903613.lua, c36429703.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_BE_LINK_MATERIAL|Prop:NONE|Range:NONE`
* **Effect 5**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_HAND`

## c227610954.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10000020.lua, c100240201.lua, c100254201.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_UPDATE_ATTACK|Prop:NONE|Range:NONE`

## c227745087.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100259002.lua, c11366199.lua, c15033525.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND+LOCATION_GRAVE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100260001.lua, c101301084.lua, c101304085.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_RELEASE|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100245003.lua, c100256019.lua, c100256019.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_LEAVE_FIELD_REDIRECT|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`

## c228033609.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000010.lua, c10163855.lua, c10209545.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:NONE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c34072799.lua, c42600274.lua, c52738610.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_RELEASE|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`

## c228040066.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c101304086.lua, c10755153.lua, c15397015.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_SUMMON|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214004.lua, c13647631.lua, c29092121.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_HAND`

## c228169392.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000000.lua, c100256016.lua, c101203023.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_BE_EFFECT_TARGET|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100212004.lua, c12527118.lua, c1269512.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_PHASE+PHASE_BATTLE_START|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211001.lua, c100212001.lua, c101204036.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_LEAVE_FIELD|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c10474647.lua, c10474647.lua, c10474647.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SET_ATTACK_FINAL|Prop:NONE|Range:NONE`

## c228386117.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000010.lua, c10000030.lua, c100211050.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`
* **Effect 3**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_F|Code:EVENT_MOVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100214012.lua, c100214013.lua, c100215001.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CHANGE_LEVEL|Prop:NONE|Range:NONE`

## c228464260.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c11270236.lua, c11366199.lua, c13203964.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_ADD_ATTRIBUTE|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10000090.lua, c100213003.lua, c100250203.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_IMMUNE_EFFECT|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`

## c228472690.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000010.lua, c10000030.lua, c100211050.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000010.lua, c10000030.lua, c100211050.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`

## c228635967.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214006.lua, c100214014.lua, c100214015.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100263008.lua, c101203019.lua, c10732060.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_GRAVE`

## c228686743.lua
* No effects found using standard `Effect.CreateEffect` pattern.

## c228860650.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214008.lua, c100245032.lua, c100256006.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100240203.lua, c100259010.lua, c101202092.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_GRAVE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211003.lua, c100211051.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_SPECIAL_SUMMON|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:NONE`

## c228926678.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100245001.lua, c100245002.lua, c100245003.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_INDESTRUCTABLE_BATTLE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100263008.lua, c101203019.lua, c10732060.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_GRAVE`

## c229021849.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100212004.lua, c100256010.lua, c10032958.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_BATTLE_DESTROYING|Prop:NONE|Range:NONE`

## c229327103.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100256008.lua, c100261023.lua, c101202087.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_HAND`

## c229399508.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214008.lua, c100245032.lua, c100256006.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_HAND`
* **Effect 3**: `PASS` (Matches official pattern found in: c34072799.lua, c42600274.lua, c52738610.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_RELEASE|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`

## c229499914.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211122.lua, c101203016.lua, c12888461.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_REMOVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c229786055.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214006.lua, c100214014.lua, c100214015.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:NONE`

## c229875953.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10004783.lua, c10352095.lua, c1118137.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_CONTINUOUS_TARGET|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10004783.lua, c100228002.lua, c100246001.lua)
  * Signature: `Type:EFFECT_TYPE_EQUIP|Code:EFFECT_UPDATE_ATTACK|Prop:NONE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c11678191.lua, c1200843.lua, c12324546.lua)
  * Signature: `Type:EFFECT_TYPE_EQUIP|Code:EFFECT_DESTROY_SUBSTITUTE|Prop:EFFECT_FLAG_IGNORE_IMMUNE|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c10004783.lua, c100228002.lua, c100256022.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_EQUIP_LIMIT|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`

## c229996802.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211052.lua, c100211099.lua, c100213004.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_GRAVE`

## c230132786.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1003028.lua, c101202083.lua, c101203021.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211003.lua, c100211051.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_SPECIAL_SUMMON|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:NONE`

## c230303021.lua
* **Effect 1**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CHANGE_CODE|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE+LOCATION_GRAVE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c14318794.lua, c59957503.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_PAY_LPCOST|Prop:NONE|Range:NONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c14318794.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_TURN_END|Prop:NONE|Range:NONE`

## c230749983.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c230812008.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c19748583.lua, c20056760.lua, c23431858.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_HAND+LOCATION_GRAVE`
* **Effect 2**: `PASS` (Matches official pattern found in: c78872731.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION+EFFECT_TYPE_XMATERIAL|Code:NONE|Prop:NONE|Range:NONE`

## c230947464.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c13073850.lua, c24573625.lua, c42880485.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_SPECIAL_SUMMON|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_PLAYER_TARGET|Range:LOCATION_PZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c101304083.lua, c10266279.lua, c29251488.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_PZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c64881644.lua, c90276649.lua, c90276649.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_EXTRA`

## c230998543.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1003028.lua, c101202083.lua, c101203021.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211003.lua, c100211051.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_SPECIAL_SUMMON|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:NONE`

## c231088629.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000040.lua, c17469113.lua, c24643913.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_DISABLE_SPSUMMON|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c26722601.lua, c51011872.lua, c56638325.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_SUMMON_SUCCESS|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10019086.lua, c12755462.lua, c13478040.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_SPSUMMON_SUCCESS|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 5**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CHANGE_TYPE|Prop:NONE|Range:NONE`
* **Effect 6**: `PASS` (Matches official pattern found in: c100211100.lua, c100211100.lua, c100211125.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_SZONE`

## c231089172.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`

## c231129918.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c24610207.lua, c55697723.lua, c61496006.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_XYZ_LEVEL|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c101304088.lua, c15079028.lua, c18321034.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_GRAVE`

## c231273040.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214006.lua, c100214014.lua, c100214015.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c1372887.lua, c164710.lua, c23265313.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_TO_HAND|Prop:NONE|Range:NONE`

## c231331942.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c47077318.lua, c53085623.lua, c53085623.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_F|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c231400558.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`

## c231523659.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214008.lua, c100245032.lua, c100256006.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c20003027.lua, c27483935.lua, c29942771.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_MZONE`

## c231825514.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c33776734.lua, c33776734.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_TO_GRAVE_REDIRECT|Prop:EFFECT_FLAG_IGNORE_IMMUNE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000000.lua, c100256016.lua, c101203023.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_BE_EFFECT_TARGET|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211123.lua, c100211124.lua, c100245003.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`

## c231872299.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100245040.lua, c10080320.lua, c11102908.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_UPDATE_ATTACK|Prop:NONE|Range:LOCATION_FZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100261006.lua, c100261028.lua, c1003840.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_FZONE`

## c231892575.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000080.lua, c10375182.lua, c10875327.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_BE_BATTLE_TARGET|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c14512825.lua, c20938824.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_BE_EFFECT_TARGET|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 4**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`

## c232038002.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD+EFFECT_TYPE_XMATERIAL|Code:EVENT_CHAIN_SOLVING|Prop:NONE|Range:NONE`

## c232100722.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1003028.lua, c101202083.lua, c101203021.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c78872731.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION+EFFECT_TYPE_XMATERIAL|Code:NONE|Prop:NONE|Range:NONE`

## c232104829.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214008.lua, c100245032.lua, c100256006.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10071151.lua, c19025379.lua, c21501505.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c102380.lua, c37613663.lua, c4081665.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_SUMMON|Prop:EFFECT_FLAG_OATH+EFFECT_FLAG_PLAYER_TARGET|Range:NONE`

## c232232676.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c38339996.lua, c65734501.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_HAND+LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c101203015.lua, c3773196.lua, c42216237.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_SINGLE|Code:EVENT_REMOVE|Prop:NONE|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c101203015.lua, c12196873.lua, c18743376.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_PHASE+PHASE_STANDBY|Prop:NONE|Range:LOCATION_REMOVED`

## c232449539.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c11155484.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_MOVE|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`

## c232706629.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_MUST_USE_MZONE|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:LOCATION_SZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211100.lua, c100211100.lua, c100211125.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c101304096.lua, c1490690.lua, c23526128.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_SZONE`

## c232824319.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000000.lua, c100256016.lua, c101203023.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_BE_EFFECT_TARGET|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c13857930.lua, c17732278.lua, c45710945.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_F|Code:EVENT_ATTACK_ANNOUNCE|Prop:NONE|Range:LOCATION_MZONE`

## c233103500.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214019.lua, c100228002.lua, c100259003.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211123.lua, c100211124.lua, c100245003.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100245006.lua, c101204038.lua, c101306036.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_EXTRA`

## c233212369.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214006.lua, c100214014.lua, c100214015.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c1372887.lua, c164710.lua, c23265313.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_TO_HAND|Prop:NONE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10140443.lua, c11954712.lua, c15635751.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_PHASE+PHASE_STANDBY|Prop:NONE|Range:NONE`

## c233436485.lua
* No effects found using standard `Effect.CreateEffect` pattern.

## c233499093.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211050.lua, c100212001.lua, c100213001.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:EFFECT_FLAG_DAMAGE_CAL+EFFECT_FLAG_DAMAGE_STEP|Range:LOCATION_MZONE`

## c233502817.lua
* **Effect 1**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_HAND+LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c71459017.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_F|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c233659599.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c101203010.lua, c101208203.lua, c26866984.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_HAND+LOCATION_GRAVE`
* **Effect 2**: `PASS` (Matches official pattern found in: c34072799.lua, c42600274.lua, c52738610.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_RELEASE|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`

## c233759343.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211052.lua, c100211099.lua, c100213004.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_GRAVE`

## c233957828.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214008.lua, c100245032.lua, c100245034.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_BE_MATERIAL|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c234178973.lua
* **Effect 1**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_ADD_CODE|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100261024.lua, c101203066.lua, c24461358.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_LEAVE_FIELD|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_GRAVE`

## c234179728.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c101204079.lua, c13023431.lua, c15613529.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_MUST_ATTACK|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 2**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_PHASE+PHASE_BATTLE_START|Prop:NONE|Range:LOCATION_HAND`
* **Effect 3**: `PASS` (Matches official pattern found in: c100212004.lua, c100256010.lua, c10032958.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_BATTLE_DESTROYING|Prop:NONE|Range:NONE`

## c234296128.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211050.lua, c100212001.lua, c100213001.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:EFFECT_FLAG_DAMAGE_CAL+EFFECT_FLAG_DAMAGE_STEP|Range:LOCATION_MZONE`

## c234455260.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1003028.lua, c101202083.lua, c101203021.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211003.lua, c100211051.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_SPECIAL_SUMMON|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:NONE`

## c234507067.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1003028.lua, c101202083.lua, c101203021.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211098.lua, c100212005.lua, c10024317.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_DESTROYED|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c234592047.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`

## c234599395.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214019.lua, c100228002.lua, c100259003.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c1164211.lua, c15610297.lua, c17601919.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CHANGE_TYPE|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c17315396.lua, c27107590.lua, c28927782.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_SPECIAL_SUMMON|Prop:EFFECT_FLAG_OATH+EFFECT_FLAG_PLAYER_TARGET|Range:NONE`

## c234729347.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_BE_BATTLE_TARGET|Prop:NONE|Range:LOCATION_FZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100261006.lua, c100261028.lua, c1003840.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_FZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c19814508.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_F|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_FZONE`

## c234818744.lua
* No effects found using standard `Effect.CreateEffect` pattern.

## c234984156.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214006.lua, c100214014.lua, c100214015.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:NONE`

## c235051048.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100245006.lua, c101204038.lua, c101306036.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_EXTRA`
* **Effect 3**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c101202086.lua, c12469386.lua, c18616294.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_DESTROYED|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_GRAVE`

## c235051716.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214010.lua, c100256020.lua, c101203057.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_SZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211122.lua, c101203016.lua, c12888461.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_REMOVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c235352857.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c101203015.lua, c3773196.lua, c42216237.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_SINGLE|Code:EVENT_REMOVE|Prop:NONE|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c101203015.lua, c12196873.lua, c18743376.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_PHASE+PHASE_STANDBY|Prop:NONE|Range:LOCATION_REMOVED`

## c235448944.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1003028.lua, c101202083.lua, c101203021.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100214008.lua, c100245032.lua, c100245034.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_BE_MATERIAL|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100245003.lua, c100256019.lua, c100256019.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_LEAVE_FIELD_REDIRECT|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`

## c235538173.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214008.lua, c100245032.lua, c100256006.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100256022.lua, c100261007.lua, c101203073.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100256022.lua, c100261007.lua, c101203073.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 4**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_EXTRA_SYNCHRO_MATERIAL|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_SZONE`
* **Effect 5**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CHANGE_TYPE|Prop:NONE|Range:NONE`

## c235607781.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100261024.lua, c101202086.lua, c101204025.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND+LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100260001.lua, c101301084.lua, c101304085.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_RELEASE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c235612490.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c235637994.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214008.lua, c100245032.lua, c100256006.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214019.lua, c100228002.lua, c100259003.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211098.lua, c100212005.lua, c10024317.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_DESTROYED|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100256005.lua, c100263006.lua, c101306036.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_DESTROYED|Prop:NONE|Range:NONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c100212003.lua, c100241003.lua, c100256008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_DISABLE|Prop:NONE|Range:NONE`
* **Effect 6**: `PASS` (Matches official pattern found in: c100212003.lua, c100241003.lua, c100256008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_DISABLE_EFFECT|Prop:NONE|Range:NONE`

## c235687149.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100245001.lua, c100245002.lua, c100259002.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`

## c235789995.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c38339996.lua, c65734501.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_HAND+LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c101203015.lua, c3773196.lua, c42216237.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_SINGLE|Code:EVENT_REMOVE|Prop:NONE|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c101203015.lua, c12196873.lua, c18743376.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_PHASE+PHASE_STANDBY|Prop:NONE|Range:LOCATION_REMOVED`

## c236017388.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214008.lua, c100245032.lua, c100245034.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_BE_MATERIAL|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100245003.lua, c100256019.lua, c100256019.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_LEAVE_FIELD_REDIRECT|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`

## c236158052.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c34072799.lua, c42600274.lua, c52738610.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_RELEASE|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10474647.lua, c10474647.lua, c10474647.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SET_ATTACK_FINAL|Prop:NONE|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100245003.lua, c100256019.lua, c100256019.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_LEAVE_FIELD_REDIRECT|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`

## c236179696.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211123.lua, c100211124.lua, c100245003.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`

## c236239443.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214016.lua, c101203042.lua, c101203075.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_SZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100256005.lua, c100263006.lua, c101306036.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_DESTROYED|Prop:NONE|Range:NONE`

## c236473882.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100212004.lua, c100256010.lua, c10032958.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_BATTLE_DESTROYING|Prop:NONE|Range:NONE`

## c236542835.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_F|Code:EVENT_REMOVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c236551669.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`

## c236616849.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100261024.lua, c101203066.lua, c24461358.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_LEAVE_FIELD|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_GRAVE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100213003.lua, c102380.lua, c12600382.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_F|Code:EVENT_PHASE+PHASE_STANDBY|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`

## c236721134.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c11335209.lua, c34230233.lua, c41406613.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_GRAVE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245038.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_MZONE`

## c236744343.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100245024.lua, c10424147.lua, c10424147.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_FZONE`
* **Effect 3**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_BATTLE_DESTROYED|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:LOCATION_FZONE`

## c236815197.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211052.lua, c100211099.lua, c100213004.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_GRAVE`

## c236818346.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000000.lua, c100256016.lua, c101203023.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_BE_EFFECT_TARGET|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211123.lua, c100211124.lua, c100245003.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`

## c236898203.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214008.lua, c100245032.lua, c100256006.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c15447747.lua, c2830693.lua, c29111045.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_ATTACK_ANNOUNCE|Prop:NONE|Range:LOCATION_GRAVE`
* **Effect 3**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_PHASE+end_phase|Prop:NONE|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c12800564.lua, c61405855.lua, c77967790.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_PHASE+PHASE_BATTLE|Prop:NONE|Range:NONE`

## c237089049.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100263008.lua, c101203019.lua, c10732060.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_GRAVE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100256012.lua, c35886170.lua, c48393693.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_MOVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c237269434.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c19748583.lua, c20056760.lua, c23431858.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_HAND+LOCATION_GRAVE`
* **Effect 3**: `PASS` (Matches official pattern found in: c1164211.lua, c15610297.lua, c17601919.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CHANGE_TYPE|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`

## c237444604.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245038.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_MZONE`

## c237684285.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000000.lua, c100256016.lua, c101203023.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_BE_EFFECT_TARGET|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214019.lua, c100228002.lua, c100259003.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100261050.lua, c10755984.lua, c12800777.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_PHASE+PHASE_END|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c10140443.lua, c11954712.lua, c15635751.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_PHASE+PHASE_STANDBY|Prop:NONE|Range:NONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c10140443.lua, c11954712.lua, c15635751.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_PHASE+PHASE_STANDBY|Prop:NONE|Range:NONE`

## c237692523.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100254202.lua, c101304208.lua, c10529441.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_SPSUMMON_SUCCESS|Prop:NONE|Range:NONE`

## c237917359.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211052.lua, c100211099.lua, c100213004.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_GRAVE`

## c238035167.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1003028.lua, c101202083.lua, c101203021.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211122.lua, c101203016.lua, c12888461.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_REMOVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c238064522.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c1372887.lua, c164710.lua, c23265313.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_TO_HAND|Prop:NONE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c101304095.lua, c20822520.lua, c27993919.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_CHAINING|Prop:NONE|Range:NONE`

## c238136421.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214006.lua, c100214014.lua, c100214015.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211052.lua, c100211099.lua, c100213004.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_GRAVE`
* **Effect 3**: `PASS` (Matches official pattern found in: c1164211.lua, c15610297.lua, c17601919.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CHANGE_TYPE|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c10004783.lua, c100228002.lua, c100256022.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_EQUIP_LIMIT|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c10004783.lua, c100228002.lua, c100246001.lua)
  * Signature: `Type:EFFECT_TYPE_EQUIP|Code:EFFECT_UPDATE_ATTACK|Prop:NONE|Range:NONE`
* **Effect 6**: `PASS` (Matches official pattern found in: c11881272.lua, c49867899.lua, c58346901.lua)
  * Signature: `Type:EFFECT_TYPE_EQUIP|Code:EFFECT_CANNOT_BE_EFFECT_TARGET|Prop:NONE|Range:NONE`

## c238184015.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100245010.lua, c100245011.lua, c100259009.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_CHAINING|Prop:NONE|Range:NONE`
* **Effect 2**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_GRAVE`
* **Effect 3**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CHANGE_TYPE|Prop:NONE|Range:NONE`

## c238241974.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c101203010.lua, c101208203.lua, c26866984.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_HAND+LOCATION_GRAVE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`

## c238256111.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1003028.lua, c101202083.lua, c101203021.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c238282350.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c24610207.lua, c55697723.lua, c61496006.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_XYZ_LEVEL|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c101304088.lua, c15079028.lua, c18321034.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_GRAVE`

## c238711686.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100213002.lua, c100256010.lua, c101203038.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_INDESTRUCTABLE_BATTLE|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`

## c238841732.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100213002.lua, c100214018.lua, c100240205.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_GRAVE`

## c238976759.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100261006.lua, c100261028.lua, c1003840.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_FZONE`

## c239028111.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100213003.lua, c102380.lua, c12600382.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_F|Code:EVENT_PHASE+PHASE_STANDBY|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10002346.lua, c100212004.lua, c10375182.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_UPDATE_ATTACK|Prop:NONE|Range:LOCATION_MZONE`

## c239127930.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c61470213.lua, c91781484.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_ADD_SETCODE|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100245026.lua, c22748199.lua, c31596518.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_GRAVE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100213002.lua, c100214018.lua, c100240205.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_GRAVE`

## c239179363.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100263004.lua, c32731036.lua, c40732515.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND+LOCATION_GRAVE`
* **Effect 3**: `PASS` (Matches official pattern found in: c2116237.lua, c2347656.lua, c27134209.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c100211123.lua, c100211124.lua, c100245003.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`
* **Effect 6**: `PASS` (Matches official pattern found in: c1516510.lua, c16240772.lua, c28643791.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_IMMUNE_EFFECT|Prop:NONE|Range:NONE`

## c239235967.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214006.lua, c100214014.lua, c100214015.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c239245471.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100261024.lua, c101203066.lua, c24461358.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_LEAVE_FIELD|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_GRAVE`
* **Effect 3**: `PASS` (Matches official pattern found in: c5914858.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_BE_LINK_MATERIAL|Prop:EFFECT_FLAG_SET_AVAILABLE|Range:LOCATION_MZONE`

## c239335848.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c120231023.lua, c20630765.lua, c21785144.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_UPDATE_DEFENSE|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100245001.lua, c100245002.lua, c100259002.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`

## c239725695.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214019.lua, c100228002.lua, c100259003.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c13241004.lua, c20001443.lua, c3560069.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_BE_MATERIAL|Prop:EFFECT_FLAG_DELAY+EFFECT_FLAG_PLAYER_TARGET|Range:NONE`

## c240104048.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c11335209.lua, c34230233.lua, c41406613.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_GRAVE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 3**: `PASS` (Matches official pattern found in: c100245001.lua, c100245002.lua, c100245003.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_INDESTRUCTABLE_BATTLE|Prop:NONE|Range:LOCATION_MZONE`

## c240299292.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214008.lua, c100245032.lua, c100245034.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_BE_MATERIAL|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c240511702.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000010.lua, c10000020.lua, c100213002.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_UPDATE_ATTACK|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c240575550.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c120300000.lua, c13073850.lua, c13073850.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SET_BASE_ATTACK|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`

## c240768497.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100256002.lua, c100263002.lua, c101306004.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245038.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_MZONE`

## c240976976.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214008.lua, c100245032.lua, c100245034.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_BE_MATERIAL|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c241056746.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100245010.lua, c100245011.lua, c100259009.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_CHAINING|Prop:NONE|Range:NONE`

## c241440521.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100245031.lua, c100245033.lua, c101303204.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_BE_MATERIAL|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`

## c241447408.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`

## c241504188.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100245001.lua, c100245002.lua, c100245003.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_INDESTRUCTABLE_BATTLE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211050.lua, c100212001.lua, c100213001.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:EFFECT_FLAG_DAMAGE_CAL+EFFECT_FLAG_DAMAGE_STEP|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c101301087.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_PHASE+PHASE_END|Prop:NONE|Range:NONE`

## c241540236.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100256022.lua, c100261007.lua, c101203073.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 3**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_GRAVE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100245003.lua, c100256019.lua, c100256019.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_LEAVE_FIELD_REDIRECT|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`

## c241543138.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211122.lua, c101203016.lua, c12888461.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_REMOVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_REMOVED`

## c241706191.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245038.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_MZONE`

## c241868535.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c19369609.lua, c3743515.lua, c40221691.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_BATTLE_START|Prop:NONE|Range:LOCATION_MZONE`

## c241880822.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1003028.lua, c101202083.lua, c101203021.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211098.lua, c100212005.lua, c10024317.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_DESTROYED|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c241957394.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100245010.lua, c100245011.lua, c100259009.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_CHAINING|Prop:NONE|Range:NONE`

## c241976572.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211123.lua, c100211124.lua, c100245003.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100213002.lua, c100214018.lua, c100240205.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_GRAVE`

## c242009896.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100256022.lua, c100261007.lua, c101203073.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_SZONE`

## c242094473.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000090.lua, c100213003.lua, c100250203.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_IMMUNE_EFFECT|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c120278001.lua, c120283032.lua, c26096328.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_EXTRA_ATTACK_MONSTER|Prop:NONE|Range:NONE`
* **Effect 3**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_PAY_LPCOST|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c10002346.lua, c100212004.lua, c10375182.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_UPDATE_ATTACK|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c242838495.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c76589815.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_BE_BATTLE_TARGET|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100261005.lua, c101204044.lua, c11825276.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_DIRECT_ATTACK|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c12421694.lua, c16008155.lua, c17749468.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_CHAIN_SOLVED|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c10000020.lua, c100240201.lua, c100254201.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_UPDATE_ATTACK|Prop:NONE|Range:NONE`

## c243144691.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214008.lua, c100245032.lua, c100245034.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_BE_MATERIAL|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c243194249.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100263004.lua, c32731036.lua, c40732515.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND+LOCATION_GRAVE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`

## c243306841.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100213002.lua, c100214018.lua, c100240205.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_GRAVE`

## c243420199.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100213002.lua, c100214018.lua, c100240205.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_GRAVE`

## c243488958.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c101304095.lua, c20822520.lua, c27993919.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_CHAINING|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214006.lua, c100214014.lua, c100214015.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100256009.lua, c100256023.lua, c10045474.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_TRAP_ACT_IN_HAND|Prop:NONE|Range:NONE`

## c243920845.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100256008.lua, c100261023.lua, c101202087.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_HAND`

## c244009988.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c101304095.lua, c20822520.lua, c27993919.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_CHAINING|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100256022.lua, c100261007.lua, c101203073.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100256009.lua, c100256023.lua, c10045474.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_TRAP_ACT_IN_HAND|Prop:NONE|Range:NONE`
* **Effect 5**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_TRAP_ACT_IN_SET_TURN|Prop:NONE|Range:NONE`

## c244013196.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c131182.lua, c15495787.lua, c16279989.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_SUMMON|Prop:NONE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c1003028.lua, c101202083.lua, c101203021.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`

## c244408495.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214008.lua, c100245032.lua, c100256006.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c244778917.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1006081.lua, c101203023.lua, c10158145.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c6205579.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:id|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`

## c244790302.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c101203048.lua, c12081875.lua, c176392.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EFFECT_DESTROY_REPLACE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211123.lua, c100211124.lua, c100245003.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`

## c244816828.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c11852093.lua, c20938824.lua, c33334269.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_REMOVE|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`

## c244920555.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100256008.lua, c100261023.lua, c101202087.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_HAND`

## c244921711.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100245006.lua, c101204038.lua, c101306036.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_EXTRA`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100213002.lua, c100214018.lua, c100240205.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_GRAVE`

## c244959812.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211053.lua, c100212003.lua, c14457896.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c101202084.lua, c25919316.lua, c39823987.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_SINGLE|Code:EVENT_DESTROYED|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c23015896.lua, c35984222.lua, c38107923.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_F|Code:EVENT_PHASE+PHASE_STANDBY|Prop:NONE|Range:LOCATION_GRAVE`

## c244972185.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_ADD_CODE|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_ONFIELD+LOCATION_GRAVE`
* **Effect 3**: `PASS` (Matches official pattern found in: c1122030.lua, c18458255.lua, c24839398.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EFFECT_DESTROY_REPLACE|Prop:NONE|Range:LOCATION_SZONE`

## c244986323.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c87475570.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_BE_EFFECT_TARGET|Prop:EFFECT_FLAG_IGNORE_IMMUNE|Range:LOCATION_PZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c13014905.lua, c20343502.lua, c34172284.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c100211098.lua, c100212005.lua, c10024317.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_DESTROYED|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c245099829.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c18861006.lua, c23299957.lua, c71209500.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_INDESTRUCTABLE_EFFECT|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000010.lua, c10000020.lua, c100213002.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_UPDATE_ATTACK|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100261026.lua, c101203047.lua, c10804018.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_PHASE+PHASE_END|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c100256007.lua, c101306001.lua, c26285788.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_RELEASE|Prop:NONE|Range:NONE`
* **Effect 6**: `PASS` (Matches official pattern found in: c5914858.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_BE_LINK_MATERIAL|Prop:EFFECT_FLAG_SET_AVAILABLE|Range:LOCATION_MZONE`

## c245265629.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100245006.lua, c101204038.lua, c101306036.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_EXTRA`
* **Effect 2**: `PASS` (Matches official pattern found in: c1003028.lua, c13289758.lua, c14212201.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_BE_XYZ_MATERIAL|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c101204005.lua, c10979723.lua, c120229002.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_SELECT_BATTLE_TARGET|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c10248389.lua, c47737087.lua, c54289683.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SET_ATTACK_FINAL|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`

## c245354354.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c47077318.lua, c53085623.lua, c53085623.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_F|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100214008.lua, c100245032.lua, c100245034.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_BE_MATERIAL|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c245378354.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214008.lua, c100245032.lua, c100256006.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100211003.lua, c100211051.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_SPECIAL_SUMMON|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:NONE`

## c245395343.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_REMOVED`

## c245400676.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100256024.lua, c101203013.lua, c101302204.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_SINGLE|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c36319131.lua, c63542003.lua, c66192538.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE+LOCATION_GRAVE`

## c245452058.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c19316241.lua, c43534808.lua, c58288218.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_HAND+LOCATION_GRAVE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100245003.lua, c100256019.lua, c100256019.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_LEAVE_FIELD_REDIRECT|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`

## c245837578.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c132308.lua, c42006475.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_HAND+LOCATION_GRAVE`
* **Effect 2**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_MZONE`

## c245935439.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100212005.lua, c100245016.lua, c100245017.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_PZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214008.lua, c100245032.lua, c100245034.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_BE_MATERIAL|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c245970073.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100213002.lua, c100214018.lua, c100240205.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_GRAVE`

## c246216813.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100260001.lua, c101301084.lua, c101304085.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_RELEASE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c246380598.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c131182.lua, c15495787.lua, c16279989.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_SUMMON|Prop:NONE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c1003028.lua, c101202083.lua, c101203021.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 4**: `PASS` (Matches official pattern found in: c120155000.lua, c122520.lua, c17313545.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_DISABLE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c34031284.lua, c35494087.lua, c3918345.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_REFLECT_BATTLE_DAMAGE|Prop:NONE|Range:NONE`
* **Effect 6**: `PASS` (Matches official pattern found in: c60953118.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CHANGE_BATTLE_DAMAGE|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:LOCATION_MZONE`
* **Effect 7**: `PASS` (Matches official pattern found in: c100211123.lua, c100211124.lua, c100245003.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`
* **Effect 8**: `PASS` (Matches official pattern found in: c11852093.lua, c20938824.lua, c33334269.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_REMOVE|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`

## c246393365.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214010.lua, c100256020.lua, c101203057.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_SZONE`
* **Effect 3**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_EXTRA_ATTACK|Prop:NONE|Range:LOCATION_SZONE`

## c246421842.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_F|Code:EVENT_REMOVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c246496923.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_ACTIVATE|Prop:NONE|Range:LOCATION_FZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100245024.lua, c10424147.lua, c10424147.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_FZONE`

## c246524183.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`

## c246830897.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c120253055.lua, c269510.lua, c29400787.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_SELECT_BATTLE_TARGET|Prop:NONE|Range:LOCATION_FZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c1061200.lua, c13301895.lua, c20212491.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_BE_EFFECT_TARGET|Prop:EFFECT_FLAG_IGNORE_IMMUNE|Range:LOCATION_FZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100261006.lua, c100261028.lua, c1003840.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_FZONE`
* **Effect 5**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_RELEASE|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:LOCATION_FZONE`

## c246900181.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214006.lua, c100214014.lua, c100214015.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:NONE`

## c247298564.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100212006.lua, c100256007.lua, c100256009.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_GRAVE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100245003.lua, c100256019.lua, c100256019.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_LEAVE_FIELD_REDIRECT|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`

## c247378501.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c101202088.lua, c50281477.lua, c77832858.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SUMMON_PROC|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c10004783.lua, c100228002.lua, c100256022.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_EQUIP_LIMIT|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`

## c247458749.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211052.lua, c100211099.lua, c100213004.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_GRAVE`

## c247499445.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1003028.lua, c101202083.lua, c101203021.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c1006081.lua, c101203023.lua, c10158145.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100245037.lua, c101203030.lua, c101204077.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_DISABLE|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`

## c247580036.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c101203015.lua, c101301085.lua, c13735899.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:LOCATION_MZONE`

## c247779405.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245038.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10140443.lua, c11954712.lua, c15635751.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_PHASE+PHASE_STANDBY|Prop:NONE|Range:NONE`

## c247789143.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10002346.lua, c100212004.lua, c10375182.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_UPDATE_ATTACK|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245038.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c10000020.lua, c100240201.lua, c100254201.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_UPDATE_ATTACK|Prop:NONE|Range:NONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c10000020.lua, c100240201.lua, c100254201.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_UPDATE_ATTACK|Prop:NONE|Range:NONE`

## c247831166.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211100.lua, c100211100.lua, c100211125.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 3**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:id|Prop:NONE|Range:LOCATION_SZONE`

## c247919552.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CHANGE_TYPE|Prop:NONE|Range:NONE`

## c248290754.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100245038.lua, c101203039.lua, c120231052.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_INDESTRUCTABLE_EFFECT|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211123.lua, c100211124.lua, c100245003.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`

## c248453205.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100261025.lua, c100261027.lua, c101203003.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_PHASE+PHASE_END|Prop:NONE|Range:LOCATION_GRAVE`
* **Effect 3**: `PASS` (Matches official pattern found in: c31076103.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_SINGLE|Code:EVENT_LEAVE_FIELD|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`

## c248638801.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c11270236.lua, c11366199.lua, c13203964.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_ADD_ATTRIBUTE|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c11039171.lua, c1516510.lua, c15939229.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_SINGLE|Code:EVENT_SPSUMMON_SUCCESS|Prop:NONE|Range:NONE`
* **Effect 3**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_PRE_DAMAGE_CALCULATE|Prop:EFFECT_FLAG_DAMAGE_CAL+EFFECT_FLAG_DAMAGE_STEP|Range:LOCATION_MZONE`

## c248760718.lua
* **Effect 1**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CHANGE_ATTRIBUTE|Prop:NONE|Range:LOCATION_PZONE`
* **Effect 2**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_PZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100214008.lua, c100245032.lua, c100256006.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_HAND`
* **Effect 4**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 5**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_TRAP_ACT_IN_SET_TURN|Prop:EFFECT_FLAG_SET_AVAILABLE|Range:NONE`

## c248788543.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214006.lua, c100214014.lua, c100214015.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211052.lua, c100211099.lua, c100213004.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_GRAVE`
* **Effect 3**: `PASS` (Matches official pattern found in: c1164211.lua, c15610297.lua, c17601919.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CHANGE_TYPE|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c10004783.lua, c100228002.lua, c100256022.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_EQUIP_LIMIT|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c10004783.lua, c100228002.lua, c100246001.lua)
  * Signature: `Type:EFFECT_TYPE_EQUIP|Code:EFFECT_UPDATE_ATTACK|Prop:NONE|Range:NONE`
* **Effect 6**: `PASS` (Matches official pattern found in: c1122030.lua, c18458255.lua, c24839398.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EFFECT_DESTROY_REPLACE|Prop:NONE|Range:LOCATION_SZONE`

## c248801935.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10004783.lua, c10352095.lua, c1118137.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_CONTINUOUS_TARGET|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10004783.lua, c100228002.lua, c100256022.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_EQUIP_LIMIT|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c11161666.lua, c18377261.lua, c36099130.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_EQUIP|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c10960419.lua, c16528181.lua, c19748583.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_BATTLE_START|Prop:NONE|Range:LOCATION_SZONE`

## c248884592.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c101203010.lua, c101208203.lua, c26866984.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_HAND+LOCATION_GRAVE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c17315396.lua, c27107590.lua, c28927782.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_SPECIAL_SUMMON|Prop:EFFECT_FLAG_OATH+EFFECT_FLAG_PLAYER_TARGET|Range:NONE`

## c248891593.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c58775978.lua, c84808313.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_REMAIN_FIELD|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 3**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100256009.lua, c100256023.lua, c10045474.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_TRAP_ACT_IN_HAND|Prop:NONE|Range:NONE`
* **Effect 5**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_CHAINING|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_SZONE`

## c248940511.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214019.lua, c100228002.lua, c100259003.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245038.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SYNCHRO_MATERIAL_CUSTOM|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`

## c248946297.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`

## c249018041.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`

## c249093610.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100245006.lua, c101204038.lua, c101306036.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_EXTRA`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c10666000.lua, c12817939.lua, c1995985.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_PHASE+PHASE_STANDBY|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c100211050.lua, c100212001.lua, c100213001.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:EFFECT_FLAG_DAMAGE_CAL+EFFECT_FLAG_DAMAGE_STEP|Range:LOCATION_MZONE`

## c249454272.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100256022.lua, c100261007.lua, c101203073.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 3**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_EXTRA_SYNCHRO_MATERIAL|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_SZONE`

## c249629457.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c101304096.lua, c1490690.lua, c23526128.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c24010609.lua, c2759860.lua, c32247099.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_PHASE+PHASE_END|Prop:NONE|Range:LOCATION_SZONE`

## c249680945.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214008.lua, c100245032.lua, c100256006.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100256022.lua, c100261007.lua, c101203073.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100256022.lua, c100261007.lua, c101203073.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 4**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_EXTRA_SYNCHRO_MATERIAL|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_SZONE`
* **Effect 5**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CHANGE_TYPE|Prop:NONE|Range:NONE`

## c249746105.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`

## c249805098.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100256002.lua, c100263002.lua, c101306004.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c66570171.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE+LOCATION_GRAVE`

## c250047045.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_REMOVED`

## c250262550.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c250339529.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214019.lua, c100228002.lua, c100259003.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`

## c250508903.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1005587.lua, c11925569.lua, c12247206.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_SPSUMMON_SUCCESS|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211052.lua, c100211099.lua, c100213004.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_GRAVE`

## c250556612.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c33776734.lua, c33776734.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_TO_GRAVE_REDIRECT|Prop:EFFECT_FLAG_IGNORE_IMMUNE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100256025.lua, c101301089.lua, c10497636.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_INDESTRUCTABLE_EFFECT|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`

## c250792632.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c1006081.lua, c101203023.lua, c10158145.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c1164211.lua, c15610297.lua, c17601919.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CHANGE_TYPE|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100211003.lua, c100211051.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_SPECIAL_SUMMON|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:NONE`

## c250829750.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c120293075.lua, c20644748.lua, c2602411.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_ACTIVATE|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:LOCATION_SZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c1122030.lua, c18458255.lua, c24839398.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EFFECT_DESTROY_REPLACE|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c63053267.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_PRE_BATTLE_DAMAGE|Prop:NONE|Range:LOCATION_SZONE`

## c250902476.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100245010.lua, c100245011.lua, c100259009.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_CHAINING|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100246002.lua, c10759529.lua, c120105013.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_ATTACK_ANNOUNCE|Prop:NONE|Range:NONE`

## c250917339.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100256005.lua, c100263006.lua, c101306036.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_DESTROYED|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c1003028.lua, c101202083.lua, c101203021.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 3**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`

## c251058567.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100256008.lua, c100261023.lua, c101202087.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_HAND`

## c251191343.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c11335209.lua, c34230233.lua, c41406613.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_GRAVE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 3**: `PASS` (Matches official pattern found in: c11852093.lua, c20938824.lua, c33334269.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_REMOVE|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`

## c251236672.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c26162470.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_DESTROYED|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_FZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c65589010.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_BATTLED|Prop:NONE|Range:LOCATION_FZONE`

## c251331463.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100256009.lua, c100256023.lua, c10045474.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_TRAP_ACT_IN_HAND|Prop:NONE|Range:NONE`

## c251571153.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c101204051.lua, c120247052.lua, c37684215.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_INDESTRUCTABLE_EFFECT|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_SZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c9553721.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_HAND|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_SZONE`

## c251699681.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c11593137.lua, c27556460.lua, c30888983.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_SUMMON|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100246002.lua, c10759529.lua, c120105013.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_ATTACK_ANNOUNCE|Prop:NONE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100213002.lua, c100214018.lua, c100240205.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_GRAVE`
* **Effect 4**: `PASS` (Matches official pattern found in: c101304095.lua, c20822520.lua, c27993919.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_CHAINING|Prop:NONE|Range:NONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c100245003.lua, c100256019.lua, c100256019.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_LEAVE_FIELD_REDIRECT|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`

## c251710981.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100261051.lua, c1154611.lua, c15155568.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_GRAVE`
* **Effect 3**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_MOVE|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`

## c252210718.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100213002.lua, c100214018.lua, c100240205.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_GRAVE`

## c252249599.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214019.lua, c100228002.lua, c100259003.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000010.lua, c10000020.lua, c100213002.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_UPDATE_ATTACK|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c76589815.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_BE_BATTLE_TARGET|Prop:NONE|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c16308000.lua, c60168186.lua, c71209500.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_BE_EFFECT_TARGET|Prop:NONE|Range:NONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`

## c252496004.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1003028.lua, c101202083.lua, c101203021.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c71459017.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_F|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c252513554.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100259002.lua, c11366199.lua, c15033525.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND+LOCATION_GRAVE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100250202.lua, c100250202.lua, c1006081.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_UPDATE_LEVEL|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`

## c252552954.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214019.lua, c100228002.lua, c100259003.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245038.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_MZONE`

## c253128790.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c23979249.lua, c3137279.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_REMOVE|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211001.lua, c11674673.lua, c11688916.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_MZONE`
* **Effect 3**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_NONTUNER|Prop:NONE|Range:NONE`

## c253152295.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10642488.lua, c97036149.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_ATTACK_ANNOUNCE|Prop:NONE|Range:LOCATION_HAND+LOCATION_GRAVE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100245001.lua, c100245002.lua, c100245003.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_INDESTRUCTABLE_BATTLE|Prop:NONE|Range:LOCATION_MZONE`

## c253472430.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100212006.lua, c100256007.lua, c100256009.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_GRAVE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100212003.lua, c100241003.lua, c100256008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_DISABLE|Prop:NONE|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100212003.lua, c100241003.lua, c100256008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_DISABLE_EFFECT|Prop:NONE|Range:NONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c10474647.lua, c10474647.lua, c10474647.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SET_ATTACK_FINAL|Prop:NONE|Range:NONE`

## c253520299.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100212004.lua, c100256010.lua, c10032958.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_BATTLE_DESTROYING|Prop:NONE|Range:NONE`

## c253552927.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`

## c253928485.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`

## c253934904.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100256002.lua, c100263002.lua, c101306004.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100212006.lua, c100256007.lua, c100256009.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_GRAVE`

## c254065048.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100245006.lua, c101204038.lua, c101306036.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_EXTRA`
* **Effect 3**: `PASS` (Matches official pattern found in: c10000010.lua, c10000020.lua, c100213002.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_UPDATE_ATTACK|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100256024.lua, c101302204.lua, c10526791.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_ATTACK_ALL|Prop:NONE|Range:NONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c254215159.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211122.lua, c101203016.lua, c12888461.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_REMOVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100245003.lua, c100256019.lua, c100256019.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_LEAVE_FIELD_REDIRECT|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`

## c254375894.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100259002.lua, c11366199.lua, c15033525.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND+LOCATION_GRAVE`

## c254894701.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c76589815.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_BE_BATTLE_TARGET|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100261005.lua, c101204044.lua, c11825276.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_DIRECT_ATTACK|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c12421694.lua, c16008155.lua, c17749468.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_CHAIN_SOLVED|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c10000020.lua, c100240201.lua, c100254201.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_UPDATE_ATTACK|Prop:NONE|Range:NONE`
* **Effect 6**: `PASS` (Matches official pattern found in: c10000020.lua, c100240201.lua, c100254201.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_UPDATE_ATTACK|Prop:NONE|Range:NONE`

## c255048812.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211098.lua, c100212005.lua, c10024317.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_DESTROYED|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c255082735.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214016.lua, c101203042.lua, c101203075.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_SZONE`

## c255277197.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100261027.lua, c101303207.lua, c38129297.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_FUSION_SUMMON|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211052.lua, c100211099.lua, c100213004.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_GRAVE`

## c255283389.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`

## c255668557.lua
* **Effect 1**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:NONE|Range:LOCATION_GRAVE+LOCATION_REMOVED`
* **Effect 2**: `PASS` (Matches official pattern found in: c12678601.lua, c50304345.lua, c50793215.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_SINGLE|Code:EVENT_BE_MATERIAL|Prop:NONE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10182251.lua, c11845050.lua, c12948099.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_ADD_TYPE|Prop:NONE|Range:NONE`

## c255686110.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c11270236.lua, c11366199.lua, c13203964.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_ADD_ATTRIBUTE|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100240204.lua, c101203001.lua, c120253030.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_AVOID_BATTLE_DAMAGE|Prop:NONE|Range:NONE`
* **Effect 3**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_F|Code:EVENT_TO_HAND|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c10000020.lua, c100240201.lua, c100254201.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_UPDATE_ATTACK|Prop:NONE|Range:NONE`
* **Effect 6**: `PASS` (Matches official pattern found in: c100211003.lua, c101204001.lua, c101204002.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_UPDATE_LEVEL|Prop:NONE|Range:NONE`
* **Effect 7**: `PASS` (Matches official pattern found in: c100245003.lua, c100256019.lua, c100256019.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_LEAVE_FIELD_REDIRECT|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`

## c255832330.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100240203.lua, c100259010.lua, c101202092.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_GRAVE`
* **Effect 3**: `PASS` (Matches official pattern found in: c1164211.lua, c15610297.lua, c17601919.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CHANGE_TYPE|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c10004783.lua, c100228002.lua, c100256022.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_EQUIP_LIMIT|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c120228053.lua, c12324546.lua, c1435851.lua)
  * Signature: `Type:EFFECT_TYPE_EQUIP|Code:EFFECT_UPDATE_DEFENSE|Prop:NONE|Range:NONE`
* **Effect 6**: `PASS` (Matches official pattern found in: c1122030.lua, c18458255.lua, c24839398.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EFFECT_DESTROY_REPLACE|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 7**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EFFECT_SEND_REPLACE|Prop:NONE|Range:LOCATION_SZONE`

## c255953418.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c13482262.lua, c30761649.lua, c56725612.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:LOCATION_FZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10560119.lua, c11074235.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_LEAVE_FIELD_REDIRECT|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_CLIENT_HINT|Range:NONE`

## c255977900.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c101203055.lua, c11163040.lua, c18973184.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_SPSUMMON_SUCCESS|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211100.lua, c100211100.lua, c100211125.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_SZONE`

## c256005703.lua
* **Effect 1**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_AVOID_BATTLE_DAMAGE|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100212004.lua, c100256010.lua, c10032958.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_BATTLE_DESTROYING|Prop:NONE|Range:NONE`

## c256110263.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214006.lua, c100214014.lua, c100214015.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c1372887.lua, c164710.lua, c23265313.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_TO_HAND|Prop:NONE|Range:NONE`

## c256172827.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214008.lua, c100245032.lua, c100256006.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100256022.lua, c100261007.lua, c101203073.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100256022.lua, c100261007.lua, c101203073.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 4**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_EXTRA_SYNCHRO_MATERIAL|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_SZONE`
* **Effect 5**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CHANGE_TYPE|Prop:NONE|Range:NONE`

## c256207361.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100245006.lua, c101204038.lua, c101306036.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_EXTRA`
* **Effect 2**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c11221418.lua, c23587624.lua, c2368215.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_SUMMON|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c1516510.lua, c16240772.lua, c28643791.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_IMMUNE_EFFECT|Prop:NONE|Range:NONE`

## c256287781.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100256022.lua, c100261007.lua, c101203073.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c101304096.lua, c1490690.lua, c23526128.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_SZONE`

## c256462992.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c14512825.lua, c20938824.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_BE_EFFECT_TARGET|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_GRAVE+LOCATION_REMOVED`

## c256469525.lua
* **Effect 1**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_ADD_SETCODE|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c1003028.lua, c101202083.lua, c101203021.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100263004.lua, c100263006.lua, c11738489.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SET_BASE_ATTACK|Prop:NONE|Range:NONE`

## c256608976.lua
* **Effect 1**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_MOVE|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c31076103.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_SINGLE|Code:EVENT_LEAVE_FIELD|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c101304081.lua, c11522979.lua, c14017402.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CHANGE_CODE|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`

## c256831125.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_BE_EFFECT_TARGET|Prop:NONE|Range:LOCATION_FZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c1061200.lua, c2144946.lua, c295517.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_UPDATE_LEVEL|Prop:NONE|Range:LOCATION_FZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c33981008.lua, c34822850.lua, c43236494.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_PHASE+PHASE_STANDBY|Prop:NONE|Range:LOCATION_FZONE`
* **Effect 5**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_CHAIN_SOLVED|Prop:NONE|Range:LOCATION_FZONE`
* **Effect 6**: `PASS` (Matches official pattern found in: c101304095.lua, c45383307.lua, c53819808.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_SUMMON_SUCCESS|Prop:NONE|Range:LOCATION_FZONE`
* **Effect 7**: `PASS` (Matches official pattern found in: c24793135.lua, c36742774.lua, c47679935.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_SPSUMMON_SUCCESS|Prop:NONE|Range:LOCATION_FZONE`
* **Effect 8**: `PASS` (Matches official pattern found in: c1127737.lua, c33900648.lua, c33900648.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_PHASE+PHASE_END|Prop:NONE|Range:LOCATION_FZONE`
* **Effect 9**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CHANGE_TYPE|Prop:NONE|Range:NONE`

## c256928871.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c13073850.lua, c24573625.lua, c42880485.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_SPECIAL_SUMMON|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_PLAYER_TARGET|Range:LOCATION_PZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10024317.lua, c101302204.lua, c15146890.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_PZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c64881644.lua, c90276649.lua, c90276649.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_EXTRA`

## c256930605.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214006.lua, c100214014.lua, c100214015.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100213002.lua, c100214018.lua, c100240205.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_GRAVE`

## c257081514.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1003028.lua, c101202083.lua, c101203021.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211098.lua, c100212005.lua, c10024317.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_DESTROYED|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c257176166.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c14512825.lua, c20938824.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_BE_EFFECT_TARGET|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_MOVE|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100214012.lua, c100214013.lua, c100215001.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CHANGE_LEVEL|Prop:NONE|Range:NONE`

## c257239133.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100213002.lua, c100214018.lua, c100240205.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_GRAVE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100245003.lua, c100256019.lua, c100256019.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_LEAVE_FIELD_REDIRECT|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`

## c257464336.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100213002.lua, c100214018.lua, c100240205.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_GRAVE`

## c257549955.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214006.lua, c100214014.lua, c100214015.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c101301096.lua, c14088859.lua, c14812471.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EFFECT_DESTROY_REPLACE|Prop:NONE|Range:LOCATION_GRAVE`

## c257677549.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c131182.lua, c15495787.lua, c16279989.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_SUMMON|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c15627227.lua, c21903613.lua, c36429703.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_BE_LINK_MATERIAL|Prop:NONE|Range:NONE`
* **Effect 4**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_HAND`
* **Effect 5**: `PASS` (Matches official pattern found in: c17315396.lua, c27107590.lua, c28927782.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_SPECIAL_SUMMON|Prop:EFFECT_FLAG_OATH+EFFECT_FLAG_PLAYER_TARGET|Range:NONE`

## c257794541.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c37192109.lua, c39643167.lua, c51053997.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_PHASE+PHASE_STANDBY|Prop:EFFECT_FLAG_IGNORE_IMMUNE|Range:NONE`

## c258241424.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100213002.lua, c100214018.lua, c100240205.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_GRAVE`

## c258260221.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100256002.lua, c100263002.lua, c101306004.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c101204043.lua, c18843291.lua, c41085464.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_REMOVE|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:LOCATION_MZONE`

## c258328859.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100213002.lua, c100214018.lua, c100240205.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_GRAVE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c258576611.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c71459017.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_F|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c3355732.lua, c49195710.lua, c65479980.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_TRIGGER|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`

## c258590942.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_F|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:LOCATION_FZONE`

## c258934904.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c58775978.lua, c84808313.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_REMAIN_FIELD|Prop:NONE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c68337209.lua, c68337209.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_DIRECT_ATTACK|Prop:NONE|Range:LOCATION_FZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c29400787.lua, c56725612.lua, c7617062.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_DIRECT_ATTACK|Prop:NONE|Range:LOCATION_FZONE`
* **Effect 5**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_CHAIN_SOLVED|Prop:NONE|Range:LOCATION_FZONE`

## c259017109.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000010.lua, c10000020.lua, c100213002.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_UPDATE_ATTACK|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`

## c259023461.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_PAY_LPCOST|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_GRAVE`
* **Effect 3**: `PASS` (Matches official pattern found in: c14318794.lua, c59957503.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_PAY_LPCOST|Prop:NONE|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c14318794.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_TURN_END|Prop:NONE|Range:NONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c100245003.lua, c100256019.lua, c100256019.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_LEAVE_FIELD_REDIRECT|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`

## c259028576.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1003028.lua, c101202083.lua, c101203021.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100245001.lua, c100245002.lua, c100259002.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211003.lua, c100211051.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_SPECIAL_SUMMON|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:NONE`

## c259033429.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10248389.lua, c47737087.lua, c54289683.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SET_ATTACK_FINAL|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c19406822.lua, c93130021.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_ADJUST|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245038.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_MZONE`

## c259057226.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1003028.lua, c101202083.lua, c101203021.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211003.lua, c100211051.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_SPECIAL_SUMMON|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:NONE`

## c259058125.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000010.lua, c10000020.lua, c100213002.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_UPDATE_ATTACK|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214008.lua, c100245032.lua, c100256006.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_HAND`
* **Effect 3**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_DRAW|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_GRAVE`

## c259069729.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_DRAW|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_MZONE`

## c259072169.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c21949879.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_EXTRA`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c101203015.lua, c101301085.lua, c13735899.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100211003.lua, c100211051.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_SPECIAL_SUMMON|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:NONE`

## c259072745.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245038.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10004783.lua, c100228002.lua, c100256022.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_EQUIP_LIMIT|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c1516510.lua, c16240772.lua, c28643791.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_IMMUNE_EFFECT|Prop:NONE|Range:NONE`

## c259072906.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100212005.lua, c100245016.lua, c100245017.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_PZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 4**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c259073666.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211052.lua, c100211099.lua, c100213004.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_GRAVE`

## c259086544.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000080.lua, c10375182.lua, c10875327.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_BE_BATTLE_TARGET|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c12421694.lua, c16008155.lua, c17749468.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_CHAIN_SOLVED|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211050.lua, c100212001.lua, c100213001.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:EFFECT_FLAG_DAMAGE_CAL+EFFECT_FLAG_DAMAGE_STEP|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c10000020.lua, c100240201.lua, c100254201.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_UPDATE_ATTACK|Prop:NONE|Range:NONE`

## c259090287.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100261006.lua, c100261028.lua, c1003840.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_FZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100261006.lua, c100261028.lua, c1003840.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_FZONE`
* **Effect 4**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_DISABLE|Prop:NONE|Range:LOCATION_FZONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c58793369.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_DISEFFECT|Prop:NONE|Range:LOCATION_FZONE`
* **Effect 6**: `PASS` (Matches official pattern found in: c13076804.lua, c49565413.lua, c57232301.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_REMOVE|Prop:NONE|Range:NONE`

## c259093260.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c31603289.lua, c67098897.lua, c93192592.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SYNCHRO_LEVEL_EX|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_IGNORE_IMMUNE|Range:LOCATION_EXTRA`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211050.lua, c100212001.lua, c100213001.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:EFFECT_FLAG_DAMAGE_CAL+EFFECT_FLAG_DAMAGE_STEP|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10406322.lua, c11024707.lua, c28806532.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:LOCATION_MZONE`

## c259097228.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1516510.lua, c16240772.lua, c28643791.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_IMMUNE_EFFECT|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c11790356.lua, c120277015.lua, c27911549.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CHANGE_RACE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`

## c259107906.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c11426487.lua, c19636995.lua, c25920413.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_SPSUM_PARAM+EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c101202081.lua, c101202082.lua, c10474647.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_F|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c259114562.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c101304086.lua, c10755153.lua, c15397015.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_SUMMON|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214004.lua, c13647631.lua, c29092121.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_HAND`

## c259114673.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211123.lua, c100211124.lua, c100245003.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`

## c259121126.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c101203010.lua, c101208203.lua, c26866984.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_HAND+LOCATION_GRAVE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c259126370.lua
* **Effect 1**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_DRAW|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000010.lua, c10000030.lua, c100211050.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c259135917.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c101304086.lua, c10755153.lua, c15397015.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_SUMMON|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100212006.lua, c100256007.lua, c100256009.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_GRAVE`
* **Effect 5**: `PASS` (Matches official pattern found in: c100256013.lua, c101203078.lua, c12181376.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_ACTIVATE|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:NONE`

## c259137697.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1003028.lua, c101202083.lua, c101203021.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245038.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_MZONE`

## c259138193.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100256008.lua, c100261023.lua, c101202087.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c33171768.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_UPDATE_ATTACK|Prop:EFFECT_FLAG_CLIENT_HINT|Range:NONE`

## c259144144.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214019.lua, c100228002.lua, c100259003.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`

## c259152704.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c14512825.lua, c20938824.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_BE_EFFECT_TARGET|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_MUST_ATTACK_MONSTER|Prop:NONE|Range:LOCATION_MZONE`

## c259156549.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c14512825.lua, c20938824.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_BE_EFFECT_TARGET|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`

## c259160760.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100261006.lua, c100261028.lua, c1003840.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_FZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c16269385.lua, c16269385.lua, c26534688.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_FZONE`

## c259174227.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c11426487.lua, c19636995.lua, c25920413.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_SPSUM_PARAM+EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c101202081.lua, c101202082.lua, c10474647.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_F|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c259177849.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000010.lua, c10000030.lua, c100211050.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100245001.lua, c100245002.lua, c100259002.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`

## c259179054.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c18861006.lua, c23299957.lua, c71209500.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_INDESTRUCTABLE_EFFECT|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`

## c259184310.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100245001.lua, c100245002.lua, c100259002.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`

## c259193076.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c22850702.lua, c24151924.lua, c27632520.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_IMMUNE_EFFECT|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100256025.lua, c101301089.lua, c10497636.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_INDESTRUCTABLE_EFFECT|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c71015787.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_HAND_LIMIT|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`

## c259201342.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c14088859.lua, c14088859.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EFFECT_SEND_REPLACE|Prop:NONE|Range:LOCATION_GRAVE`

## c259203522.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10012614.lua, c100211100.lua, c100211125.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_UPDATE_ATTACK|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100214010.lua, c100256020.lua, c101203057.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_SZONE`

## c259214334.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100245010.lua, c100245011.lua, c100259009.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_CHAINING|Prop:NONE|Range:NONE`

## c259219942.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1003028.lua, c101202083.lua, c101203021.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100245001.lua, c100245002.lua, c100259002.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211003.lua, c100211051.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_SPECIAL_SUMMON|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c33776734.lua, c33776734.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_TO_GRAVE_REDIRECT|Prop:EFFECT_FLAG_IGNORE_IMMUNE|Range:LOCATION_MZONE`

## c259223502.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214019.lua, c100228002.lua, c100259003.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245038.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_MZONE`

## c259225324.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c101302207.lua, c29432356.lua, c30998403.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_EXTRA_PENDULUM_SUMMON|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c101302207.lua, c29432356.lua, c30998403.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_EXTRA_PENDULUM_SUMMON|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:NONE`

## c259226793.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100245010.lua, c100245011.lua, c100259009.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_CHAINING|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100256009.lua, c100256023.lua, c10045474.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_TRAP_ACT_IN_HAND|Prop:NONE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211098.lua, c100212005.lua, c10024317.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_DESTROYED|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c259226799.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c11167052.lua, c47873397.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_BE_EFFECT_TARGET|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c31552317.lua, c39568067.lua, c61159609.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_INDESTRUCTABLE_COUNT|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c259229055.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100245006.lua, c101204038.lua, c101306036.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_EXTRA`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245038.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_MZONE`

## c259230000.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c61470213.lua, c91781484.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_ADD_SETCODE|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214006.lua, c100214014.lua, c100214015.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c82044279.lua, c82044280.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_DESTROYED|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c18861006.lua, c23299957.lua, c71209500.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_INDESTRUCTABLE_EFFECT|Prop:NONE|Range:NONE`

## c259235389.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c17775525.lua, c34496660.lua, c36953371.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_DEFENSE_ATTACK|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100259002.lua, c11366199.lua, c15033525.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND+LOCATION_GRAVE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245038.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c18847598.lua, c32787239.lua, c42256406.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_BE_BATTLE_TARGET|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c100254202.lua, c101304208.lua, c10529441.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_SPSUMMON_SUCCESS|Prop:NONE|Range:NONE`

## c259241946.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`

## c259245149.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c101304086.lua, c10755153.lua, c15397015.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_SUMMON|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 4**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_EXTRA_SUMMON_COUNT|Prop:NONE|Range:LOCATION_HAND+LOCATION_MZONE`

## c259245496.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100296003.lua, c146746.lua, c17217034.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_BE_LINK_MATERIAL|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245038.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_MZONE`

## c259247807.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10002346.lua, c100212004.lua, c10375182.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_UPDATE_ATTACK|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c34267821.lua, c37629703.lua, c42352091.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_HAND+LOCATION_MZONE`

## c259253032.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100256025.lua, c101301089.lua, c10497636.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_INDESTRUCTABLE_EFFECT|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c101204043.lua, c18843291.lua, c41085464.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_REMOVE|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`

## c259264449.lua
* **Effect 1**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_IGNORE_IMMUNE|Range:NONE`

## c259264881.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c101304086.lua, c10755153.lua, c15397015.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_SUMMON|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 4**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_EXTRA_SUMMON_COUNT|Prop:NONE|Range:LOCATION_HAND+LOCATION_MZONE`

## c259265448.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c66328392.lua, c96203584.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_SZONE`
* **Effect 3**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_F|Code:EVENT_PHASE+PHASE_BATTLE_START|Prop:NONE|Range:LOCATION_SZONE`

## c259269688.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214006.lua, c100214014.lua, c100214015.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211052.lua, c100211099.lua, c100213004.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_GRAVE`

## c259269774.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214019.lua, c100228002.lua, c100259003.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211123.lua, c100211124.lua, c100245003.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`

## c259273394.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100213002.lua, c100214018.lua, c100240205.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_GRAVE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100245037.lua, c101203030.lua, c101204077.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_DISABLE|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100245037.lua, c101203030.lua, c101204077.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_DISABLE_EFFECT|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c100245037.lua, c101203074.lua, c101204077.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_DISABLE_TRAPMONSTER|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`
* **Effect 6**: `PASS` (Matches official pattern found in: c100214004.lua, c101202089.lua, c101306003.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_UPDATE_ATTACK|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`

## c259273851.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214006.lua, c100214014.lua, c100214015.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:NONE`

## c259275822.lua
* No effects found using standard `Effect.CreateEffect` pattern.

## c259288669.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214008.lua, c100245032.lua, c100256006.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100260001.lua, c101301084.lua, c101304085.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_RELEASE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c259290896.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100245010.lua, c100245011.lua, c100259009.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_CHAINING|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100256009.lua, c100256023.lua, c10045474.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_TRAP_ACT_IN_HAND|Prop:NONE|Range:NONE`

## c259303191.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`

## c259304399.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100256002.lua, c100263002.lua, c101306004.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c1006081.lua, c101203023.lua, c10158145.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`

## c259307285.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100246002.lua, c10759529.lua, c120105013.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_ATTACK_ANNOUNCE|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100256009.lua, c100256023.lua, c10045474.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_TRAP_ACT_IN_HAND|Prop:NONE|Range:NONE`

## c259308265.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c39064822.lua, c42472002.lua, c94076521.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_EXTRA_SUMMON_COUNT|Prop:NONE|Range:NONE`

## c259315827.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10002346.lua, c100250208.lua, c100261050.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_SINGLE|Code:EFFECT_DESTROY_REPLACE|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c15935204.lua, c49514333.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EFFECT_SEND_REPLACE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c101303204.lua, c11327848.lua, c1157683.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_EQUIP_LIMIT|Prop:NONE|Range:NONE`

## c259337739.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c101304086.lua, c10755153.lua, c15397015.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_SUMMON|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 4**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_EXTRA_SUMMON_COUNT|Prop:NONE|Range:LOCATION_HAND+LOCATION_MZONE`

## c259341133.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1003028.lua, c13289758.lua, c14212201.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_BE_XYZ_MATERIAL|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214008.lua, c100245032.lua, c100256006.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_HAND`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100263008.lua, c101203019.lua, c10732060.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_GRAVE`

## c259348317.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c259350270.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1434352.lua, c17286057.lua, c18590133.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SET_ATTACK|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000010.lua, c10000030.lua, c100211050.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10000010.lua, c10000030.lua, c100211050.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`

## c259352030.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100245006.lua, c101204038.lua, c101306036.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_EXTRA`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c10002346.lua, c100250208.lua, c100261050.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_SINGLE|Code:EFFECT_DESTROY_REPLACE|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`

## c259360287.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100259002.lua, c11366199.lua, c15033525.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND+LOCATION_GRAVE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214008.lua, c100245032.lua, c100256006.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_HAND`

## c259363148.lua
* **Effect 1**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_EXTRA`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c10002346.lua, c100212004.lua, c10375182.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_UPDATE_ATTACK|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c101203030.lua, c12163590.lua, c15848542.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_PHASE+PHASE_BATTLE|Prop:NONE|Range:LOCATION_MZONE`

## c259365935.lua
* **Effect 1**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_EXTRA`
* **Effect 2**: `PASS` (Matches official pattern found in: c11039171.lua, c1516510.lua, c15939229.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_SINGLE|Code:EVENT_SPSUMMON_SUCCESS|Prop:NONE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10000000.lua, c100256016.lua, c101203023.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_BE_EFFECT_TARGET|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c10071151.lua, c19025379.lua, c21501505.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c100261050.lua, c10755984.lua, c12800777.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_PHASE+PHASE_END|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`

## c259366281.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100200290.lua, c20726052.lua, c57111661.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_TRAP_ACT_IN_SET_TURN|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_SET_AVAILABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100245010.lua, c100245011.lua, c100259009.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_CHAINING|Prop:NONE|Range:NONE`
* **Effect 3**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_PAY_LPCOST|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_GRAVE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100245003.lua, c100256019.lua, c100256019.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_LEAVE_FIELD_REDIRECT|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`

## c259366507.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1003028.lua, c101202083.lua, c101203021.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211098.lua, c100212005.lua, c10024317.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_DESTROYED|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c259366591.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100245031.lua, c100245033.lua, c101303204.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_BE_MATERIAL|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`

## c259369909.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`

## c259373017.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c57458399.lua, c70333910.lua, c71278040.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c46647144.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_F|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_MZONE`

## c259377794.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c101304086.lua, c10755153.lua, c15397015.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_SUMMON|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100212006.lua, c100256007.lua, c100256009.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_GRAVE`
* **Effect 5**: `PASS` (Matches official pattern found in: c10000020.lua, c100240201.lua, c100254201.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_UPDATE_ATTACK|Prop:NONE|Range:NONE`

## c259392825.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214008.lua, c100245032.lua, c100256006.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211123.lua, c100211124.lua, c100245003.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`

## c259394179.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c47077318.lua, c53085623.lua, c53085623.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_F|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c259395418.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214019.lua, c100228002.lua, c100259003.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c101203030.lua, c12163590.lua, c15848542.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_PHASE+PHASE_BATTLE|Prop:NONE|Range:LOCATION_MZONE`

## c259402105.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100256022.lua, c100261007.lua, c101203073.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100256022.lua, c100261007.lua, c101203073.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_SZONE`

## c259405917.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1434352.lua, c17286057.lua, c18590133.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SET_ATTACK|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211123.lua, c100211124.lua, c100245003.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100211123.lua, c100211124.lua, c100245003.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`

## c259410628.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_EXTRA_RELEASE_SUM|Prop:NONE|Range:LOCATION_HAND`
* **Effect 3**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100256022.lua, c100261007.lua, c101203073.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c12541409.lua, c22377092.lua, c2547033.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_TRAP_ACT_IN_SET_TURN|Prop:EFFECT_FLAG_SET_AVAILABLE|Range:NONE`

## c259417461.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c16227633.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_LEAVE_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_GRAVE`

## c259429721.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100256008.lua, c100261023.lua, c101202087.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100240203.lua, c100259010.lua, c101202092.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_GRAVE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100214019.lua, c10604644.lua, c11743119.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_EQUIP_LIMIT|Prop:EFFECT_FLAG_OWNER_RELATE|Range:NONE`

## c259431066.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100240203.lua, c100259010.lua, c101202092.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_GRAVE`

## c259434499.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214006.lua, c100214014.lua, c100214015.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:NONE`

## c259459462.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000080.lua, c10375182.lua, c10875327.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_BE_BATTLE_TARGET|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c12421694.lua, c16008155.lua, c17749468.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_CHAIN_SOLVED|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c120244029.lua, c120298020.lua, c17016362.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CHANGE_DAMAGE|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c10000020.lua, c100240201.lua, c100254201.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_UPDATE_ATTACK|Prop:NONE|Range:NONE`

## c259464700.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c38339996.lua, c65734501.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_HAND+LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100261051.lua, c1154611.lua, c15155568.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_GRAVE`

## c259465391.lua
* **Effect 1**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_XYZ_LEVEL|Prop:EFFECT_FLAG_SET_AVAILABLE|Range:LOCATION_EXTRA`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`

## c259466138.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_ATTACK_ALL|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c101303202.lua, c1315120.lua, c14509651.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_SINGLE|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100211052.lua, c100211099.lua, c100213004.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_GRAVE`

## c259471193.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c47077318.lua, c53085623.lua, c53085623.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_F|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c259472680.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100259002.lua, c11366199.lua, c15033525.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND+LOCATION_GRAVE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10002346.lua, c100212004.lua, c10375182.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_UPDATE_ATTACK|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c17315396.lua, c27107590.lua, c28927782.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_SPECIAL_SUMMON|Prop:EFFECT_FLAG_OATH+EFFECT_FLAG_PLAYER_TARGET|Range:NONE`

## c259475154.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`

## c259479044.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1434352.lua, c17286057.lua, c18590133.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SET_ATTACK|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100245001.lua, c100245002.lua, c100245003.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_INDESTRUCTABLE_BATTLE|Prop:NONE|Range:LOCATION_MZONE`

## c259479818.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c259482393.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100256005.lua, c100263006.lua, c101306036.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_DESTROYED|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c1003028.lua, c101202083.lua, c101203021.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 3**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`

## c259485374.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`

## c259487387.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c101203010.lua, c101208203.lua, c26866984.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_HAND+LOCATION_GRAVE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_DRAW|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_MZONE`

## c259489283.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100213002.lua, c100256010.lua, c101203038.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_INDESTRUCTABLE_BATTLE|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 4**: `PASS` (Matches official pattern found in: c100211123.lua, c100211124.lua, c100245003.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`

## c259494236.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10002346.lua, c100212004.lua, c10375182.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_UPDATE_ATTACK|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245038.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_MZONE`

## c259499577.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214010.lua, c100256020.lua, c101203057.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_SZONE`

## c259500899.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100245001.lua, c100245002.lua, c100259002.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100245003.lua, c100256019.lua, c100256019.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_LEAVE_FIELD_REDIRECT|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`

## c259519336.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1434352.lua, c17286057.lua, c18590133.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SET_ATTACK|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10002346.lua, c100212004.lua, c10375182.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_UPDATE_ATTACK|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`

## c259522807.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1003028.lua, c101202083.lua, c101203021.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245038.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_MZONE`

## c259524916.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100233201.lua, c101203012.lua, c10178757.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_HAND|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c259527622.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c101203010.lua, c101208203.lua, c26866984.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_HAND+LOCATION_GRAVE`
* **Effect 2**: `PASS` (Matches official pattern found in: c71459017.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_F|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c19333131.lua, c2204038.lua, c26434972.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_INDESTRUCTABLE_BATTLE|Prop:NONE|Range:NONE`

## c259531370.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100256002.lua, c100263002.lua, c101306004.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211050.lua, c100212001.lua, c100213001.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:EFFECT_FLAG_DAMAGE_CAL+EFFECT_FLAG_DAMAGE_STEP|Range:LOCATION_MZONE`

## c259533644.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1003028.lua, c101202083.lua, c101203021.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c259546637.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c72302403.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_REMAIN_FIELD|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c96162588.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_RELEASE|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_SZONE`

## c259552732.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211053.lua, c100212003.lua, c14457896.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214012.lua, c100214013.lua, c100215001.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CHANGE_LEVEL|Prop:NONE|Range:NONE`

## c259562343.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214006.lua, c100214014.lua, c100214015.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100213002.lua, c100214018.lua, c100240205.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_GRAVE`

## c259568843.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c132308.lua, c42006475.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_HAND+LOCATION_GRAVE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100260001.lua, c101301084.lua, c101304085.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_RELEASE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c259576196.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214019.lua, c100228002.lua, c100259003.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100213002.lua, c100214018.lua, c100240205.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_GRAVE`

## c259578863.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214019.lua, c100228002.lua, c100259003.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100260001.lua, c25795273.lua, c3381441.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_UPDATE_DEFENSE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100213002.lua, c100214018.lua, c100240205.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_GRAVE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100245037.lua, c101203030.lua, c101204077.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_DISABLE|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`

## c259581666.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211123.lua, c100211124.lua, c100245003.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`

## c259586445.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211123.lua, c100211124.lua, c100245003.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214019.lua, c100228002.lua, c100259003.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`

## c259599798.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000010.lua, c10000030.lua, c100211050.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c259605536.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c20065549.lua, c29047353.lua, c31476755.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_IMMUNE_EFFECT|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211100.lua, c100211100.lua, c100211125.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c72710085.lua, c91407982.lua, c95471006.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_REMOVE|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_SZONE`

## c259607933.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c101203030.lua, c12163590.lua, c15848542.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_PHASE+PHASE_BATTLE|Prop:NONE|Range:LOCATION_MZONE`

## c259609997.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1003028.lua, c101202083.lua, c101203021.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c71459017.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_F|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245038.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_MZONE`

## c259612312.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245038.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c259614449.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000010.lua, c10163855.lua, c10209545.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100260001.lua, c101301084.lua, c101304085.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_RELEASE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c259614765.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100245037.lua, c101203030.lua, c101204077.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_DISABLE|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`

## c259624110.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100296003.lua, c146746.lua, c17217034.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_BE_LINK_MATERIAL|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10002346.lua, c100212004.lua, c10375182.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_UPDATE_ATTACK|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245038.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_MZONE`

## c259626409.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100296003.lua, c146746.lua, c17217034.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_BE_LINK_MATERIAL|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10071151.lua, c19025379.lua, c21501505.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100261050.lua, c10755984.lua, c12800777.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_PHASE+PHASE_END|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`

## c259628203.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211123.lua, c100211124.lua, c100245003.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`

## c259630851.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214006.lua, c100214014.lua, c100214015.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100213002.lua, c100214018.lua, c100240205.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_GRAVE`

## c259632020.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100296003.lua, c146746.lua, c17217034.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_BE_LINK_MATERIAL|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c22850702.lua, c24151924.lua, c27632520.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_IMMUNE_EFFECT|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`

## c259646610.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c22850702.lua, c24151924.lua, c27632520.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_IMMUNE_EFFECT|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000010.lua, c10000030.lua, c100211050.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`

## c259650132.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c11426487.lua, c19636995.lua, c25920413.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_SPSUM_PARAM+EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c101202081.lua, c101202082.lua, c10474647.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_F|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`

## c259650969.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c11167052.lua, c47873397.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_BE_EFFECT_TARGET|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211100.lua, c100211100.lua, c100211125.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_SZONE`

## c259652372.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214008.lua, c100245032.lua, c100256006.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_DRAW|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:LOCATION_MZONE`

## c259655976.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`

## c259664027.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c101301096.lua, c14088859.lua, c14812471.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EFFECT_DESTROY_REPLACE|Prop:NONE|Range:LOCATION_GRAVE`

## c259668626.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_EXTRA_RELEASE_SUM|Prop:NONE|Range:LOCATION_HAND`
* **Effect 3**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c89058026.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_DECK|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_SZONE`
* **Effect 5**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_INDESTRUCTABLE_EFFECT|Prop:EFFECT_FLAG_SET_AVAILABLE|Range:NONE`

## c259670933.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100245006.lua, c101204038.lua, c101306036.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_EXTRA`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 4**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_SINGLE|Code:EVENT_RELEASE|Prop:NONE|Range:NONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c100212006.lua, c100256007.lua, c100256009.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_GRAVE`

## c259678739.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_UNRELEASABLE_SUM|Prop:NONE|Range:LOCATION_PZONE`
* **Effect 3**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_BE_FUSION_MATERIAL|Prop:NONE|Range:LOCATION_PZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 5**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c259679619.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c11082056.lua, c13857930.lua, c1784686.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_ADD_CODE|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c12644061.lua, c59160188.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CHANGE_ATTRIBUTE|Prop:NONE|Range:LOCATION_FZONE`

## c259680842.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`

## c259686203.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c101304086.lua, c10755153.lua, c15397015.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_SUMMON|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100212006.lua, c100256007.lua, c100256009.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_GRAVE`
* **Effect 5**: `PASS` (Matches official pattern found in: c54408264.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_IMMUNE_EFFECT|Prop:NONE|Range:NONE`

## c259688514.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1003028.lua, c13289758.lua, c14212201.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_BE_XYZ_MATERIAL|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214008.lua, c100245032.lua, c100256006.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_HAND`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100245026.lua, c22748199.lua, c31596518.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_GRAVE`

## c259688676.lua
* **Effect 1**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_RITUAL_LEVEL|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c14146794.lua, c27978707.lua, c3064425.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:EFFECT_FLAG_DAMAGE_CAL+EFFECT_FLAG_DAMAGE_STEP|Range:LOCATION_GRAVE`

## c259718504.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c47077318.lua, c53085623.lua, c53085623.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_F|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c259721372.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c13482262.lua, c30761649.lua, c56725612.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:LOCATION_FZONE`

## c259722826.lua
* No effects found using standard `Effect.CreateEffect` pattern.

## c259724129.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1003028.lua, c13289758.lua, c14212201.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_BE_XYZ_MATERIAL|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214008.lua, c100245032.lua, c100256006.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_HAND`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100245026.lua, c22748199.lua, c31596518.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_GRAVE`

## c259726853.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c11426487.lua, c19636995.lua, c25920413.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_SPSUM_PARAM+EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c101202081.lua, c101202082.lua, c10474647.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_F|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c259737127.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c101304086.lua, c10755153.lua, c15397015.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_SUMMON|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100212006.lua, c100256007.lua, c100256009.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_GRAVE`

## c259753109.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211123.lua, c100211124.lua, c100245003.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100245001.lua, c100245002.lua, c100259002.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100212003.lua, c100241003.lua, c100256008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_DISABLE|Prop:NONE|Range:NONE`

## c259755133.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214006.lua, c100214014.lua, c100214015.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100256009.lua, c100256023.lua, c10045474.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_TRAP_ACT_IN_HAND|Prop:NONE|Range:NONE`

## c259758604.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10012614.lua, c100211100.lua, c100211125.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_UPDATE_ATTACK|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c259763531.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211123.lua, c100211124.lua, c100245003.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`

## c259766646.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`

## c259780273.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100245031.lua, c100245033.lua, c101303204.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_BE_MATERIAL|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_SPECIAL_SUMMON|Prop:EFFECT_FLAG_CLIENT_HINT+EFFECT_FLAG_OATH+EFFECT_FLAG_PLAYER_TARGET|Range:NONE`

## c259783008.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c259790247.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100260001.lua, c101301084.lua, c101304085.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_RELEASE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c259794136.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100212002.lua, c101203013.lua, c101203024.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND+LOCATION_GRAVE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c259796760.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c47077318.lua, c53085623.lua, c53085623.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_F|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c259815138.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100214001.lua, c100214012.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100213002.lua, c100214018.lua, c100240205.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_GRAVE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100245003.lua, c100256019.lua, c100256019.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_LEAVE_FIELD_REDIRECT|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`

## c259825991.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000010.lua, c10000030.lua, c100211050.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`

## c259841490.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1434352.lua, c17286057.lua, c18590133.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SET_ATTACK|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`

## c259851064.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211123.lua, c100211124.lua, c100245003.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100245001.lua, c100245002.lua, c100259002.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`

## c259869259.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100261007.lua, c89086647.lua)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:EVENT_ADJUST|Prop:NONE|Range:LOCATION_SZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c101202091.lua, c10131855.lua, c50056656.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_SZONE`

## c259873115.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100212005.lua, c100245016.lua, c100245017.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_PZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245038.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_MZONE`

## c259881255.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1003028.lua, c101202083.lua, c101203021.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_SPSUMMON_PROC|Prop:EFFECT_FLAG_UNCOPYABLE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c101202081.lua, c101202082.lua, c10474647.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_F|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`

## c259883029.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214006.lua, c100214014.lua, c100214015.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100213002.lua, c100214018.lua, c100240205.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_GRAVE`

## c259883971.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100212006.lua, c100256007.lua, c100256009.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_GRAVE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100245037.lua, c101203030.lua, c101204077.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_DISABLE|Prop:EFFECT_FLAG_CANNOT_DISABLE|Range:NONE`

## c259889864.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211050.lua, c100212001.lua, c100213001.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_CHAINING|Prop:EFFECT_FLAG_DAMAGE_CAL+EFFECT_FLAG_DAMAGE_STEP|Range:LOCATION_MZONE`

## c259898110.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100214008.lua, c100245032.lua, c100256006.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c17315396.lua, c27107590.lua, c28927782.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_SPECIAL_SUMMON|Prop:EFFECT_FLAG_OATH+EFFECT_FLAG_PLAYER_TARGET|Range:NONE`

## c259911246.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c47077318.lua, c53085623.lua, c53085623.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_F|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c259920959.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000090.lua, c100213003.lua, c100250203.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_IMMUNE_EFFECT|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100201001.lua, c100239201.lua, c100245007.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_MZONE`

## c259923860.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100213002.lua, c100214018.lua, c100240205.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_GRAVE`

## c259924331.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`

## c259926839.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 2**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_DRAW|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:LOCATION_MZONE`

## c259927462.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100212006.lua, c100256007.lua, c100256009.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_GRAVE`

## c259934043.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1003028.lua, c13289758.lua, c14212201.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_BE_XYZ_MATERIAL|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10019086.lua, c100211003.lua, c100211097.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_DELAY|Range:NONE`

## c259934756.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211002.lua, c100211122.lua, c100212006.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_HAND`
* **Effect 3**: `PASS` (Matches official pattern found in: c100245001.lua, c100245002.lua, c100259002.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_TO_GRAVE|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`

## c259937399.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c1003028.lua, c13289758.lua, c14212201.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_BE_XYZ_MATERIAL|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214008.lua, c100245032.lua, c100256006.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:LOCATION_HAND`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211051.lua, c100211097.lua, c100214008.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100263008.lua, c101203019.lua, c10732060.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_GRAVE`
* **Effect 5**: `PASS` (Matches official pattern found in: c16684346.lua, c77189532.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_EXTRA_LINK_MATERIAL|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 6**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_CONTINUOUS+EFFECT_TYPE_FIELD|Code:ev|Prop:NONE|Range:NONE`

## c259937946.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100214019.lua, c100228002.lua, c100259003.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c100211123.lua, c100211124.lua, c100245003.lua)
  * Signature: `Type:EFFECT_TYPE_QUICK_O|Code:EVENT_FREE_CHAIN|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_MZONE`

## c259940722.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c100241001.lua, c100245036.lua, c100245037.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_MATERIAL_CHECK|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100240204.lua, c101202085.lua, c101203001.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_INDESTRUCTABLE_BATTLE|Prop:NONE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c10000000.lua, c100256016.lua, c101203023.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_CANNOT_BE_EFFECT_TARGET|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c10000090.lua, c100213003.lua, c100250203.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_IMMUNE_EFFECT|Prop:EFFECT_FLAG_SINGLE_RANGE|Range:LOCATION_MZONE`
* **Effect 5**: `PASS` (Matches official pattern found in: c101203052.lua, c10158145.lua, c10963799.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_CANNOT_SPECIAL_SUMMON|Prop:EFFECT_FLAG_PLAYER_TARGET|Range:LOCATION_MZONE`
* **Effect 6**: `PASS` (Matches official pattern found in: c10000000.lua, c10000080.lua, c10000090.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_MZONE`

## c259943152.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `FAIL` (No official script matches this effect signature)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_CHAINING|Prop:NONE|Range:LOCATION_FZONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c13482262.lua, c30761649.lua, c56725612.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_CARD_TARGET+EFFECT_FLAG_DELAY|Range:LOCATION_FZONE`

## c259944943.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10000.lua, c10000010.lua, c10000040.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_SPSUMMON_CONDITION|Prop:EFFECT_FLAG_CANNOT_DISABLE+EFFECT_FLAG_UNCOPYABLE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100256024.lua, c101302204.lua, c10526791.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_ATTACK_ALL|Prop:NONE|Range:NONE`
* **Effect 3**: `PASS` (Matches official pattern found in: c3117804.lua, c43321985.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD|Code:EFFECT_DEFENSE_ATTACK|Prop:NONE|Range:LOCATION_MZONE`
* **Effect 4**: `PASS` (Matches official pattern found in: c100256024.lua, c11125718.lua, c11954712.lua)
  * Signature: `Type:EFFECT_TYPE_SINGLE|Code:EFFECT_PIERCE|Prop:NONE|Range:NONE`

## c259961648.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100263008.lua, c101203019.lua, c10732060.lua)
  * Signature: `Type:EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O|Code:EVENT_SPSUMMON_SUCCESS|Prop:EFFECT_FLAG_DELAY|Range:LOCATION_GRAVE`

## c259992800.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c19748583.lua, c20056760.lua, c23431858.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:EFFECT_FLAG_CARD_TARGET|Range:LOCATION_HAND+LOCATION_GRAVE`
* **Effect 2**: `PASS` (Matches official pattern found in: c100211100.lua, c100211100.lua, c100211125.lua)
  * Signature: `Type:EFFECT_TYPE_IGNITION|Code:NONE|Prop:NONE|Range:LOCATION_SZONE`

## c259998396.lua
* **Effect 1**: `PASS` (Matches official pattern found in: c10012614.lua, c100200290.lua, c100211004.lua)
  * Signature: `Type:EFFECT_TYPE_ACTIVATE|Code:EVENT_FREE_CHAIN|Prop:NONE|Range:NONE`
