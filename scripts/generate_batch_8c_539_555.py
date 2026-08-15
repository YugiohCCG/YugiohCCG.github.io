#!/usr/bin/env python3
"""Generate the fresh semantic audit for CCG ordinals 539-555.

This source intentionally depends only on current cards.json/current CCG Lua and
the official Omega database/scripts.  Checklist Markdown and historical audit
verdicts are not inputs.
"""

from __future__ import annotations

import hashlib
import json
import sqlite3
from pathlib import Path


ROOT = Path(__file__).resolve().parents[1]
CARDS = json.loads((ROOT / "src/data/cards.json").read_text(encoding="utf-8"))
CCG = ROOT / "public/CCG Downloads/CCG_Scripts"
OMEGA = ROOT / "tmp/omega_scripts"
OMEGA_DB = Path(r"C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Bundles\db")
OUTPUT = ROOT / "scripts/output/effect_audit_agents/batch_8c_539_555.json"


def ref(card_id: int, matched_structure: str) -> dict:
    return {
        "script": f"tmp/omega_scripts/c{card_id}.lua",
        "card_id": card_id,
        "matched_structure": matched_structure,
    }


def effect(
    printed_clause: str,
    lua_implementation: str,
    references: list[dict],
    verdict: str = "PASS",
    issue: str | None = None,
) -> dict:
    return {
        "printed_clause": printed_clause,
        "lua_implementation": lua_implementation,
        "official_references": references,
        "verdict": verdict,
        "issue": issue,
    }


SPECS: dict[int, list[dict]] = {
    539: [
        effect(
            'When activated: optionally add 1 "Glitchling" card from the Deck and/or face-up Extra Deck, except this card; only 1 activation per turn.',
            "The activation effect has an oath count limit; at resolution it optionally selects one set card from Deck or face-up Extra Deck, excludes its own code, sends it to hand, and confirms it.",
            [ref(975299, "Optional search performed by a Spell activation with an activation count limit and hand confirmation.")],
        ),
        effect(
            "If you would Ritual Summon a Cyberse Ritual Monster using hand/field Tributes, Corruption Counters from the field can satisfy up to its Level.",
            "No field effect exposes Corruption Counters as material to other Ritual Summon effects. Counter substitution exists only inside this card's own triggered ritualsummon function.",
            [ref(20560620, "Official field effect exposes an additional Ritual-material source to Ritual procedures; its script is explicitly marked as a workaround/not fully implemented.")],
            "CUSTOM_GAP",
            "The printed replacement applies to arbitrary Cyberse Ritual Summons, but the Lua cannot inject counters into unrelated Ritual procedures; only this card's own Ritual option sees them.",
        ),
        effect(
            'Once per turn, if a Cyberse Ritual Monster is Tributed or used as Link Material: optionally Ritual Summon 1 "Glitchling" Ritual Monster from the GY/face-up Extra Deck using hand/field Tributes whose Levels meet or exceed its Level.',
            "Shared-count EVENT_RELEASE and REASON_LINK/EVENT_BE_MATERIAL triggers offer the ritual option; the operation selects the GY/face-up Extra Deck Ritual, selects legal hand/field ritual materials, removes any permitted counter deficit, releases materials, Ritual Summons, and completes the procedure.",
            [ref(15306543, "Field Spell ignition Ritual Summon using a greater-than-or-equal Level check and a nonstandard Ritual source."), ref(49721684, "Ritual Summon from hand or GY with greater-or-equal material handling and CompleteProcedure.")],
        ),
        effect(
            "Alternatively place Corruption Counters on this card up to the number of Cyberse monsters you control.",
            "The alternate operation counts Card.IsRace(RACE_CYBERSE) in the controller's Monster Zone and lets the player announce an addable amount from 1 through that count.",
            [ref(60258960, "Counts/places counters on a permitted card through EnableCounterPermit and AddCounter.")],
            "DEFECT",
            "The count filter lacks Card.IsFaceup, so face-down monsters can be counted as Cyberse even though face-down cards do not have a usable Race for this effect.",
        ),
    ],
    540: [
        effect(
            "Link Summoning procedure (no material line is present in the current printed text).",
            "AddLinkProcedure nevertheless requires 2 or 3 Cyberse monsters for this Link-3 monster, followed by EnableReviveLimit.",
            [ref(30741503, 'Official "Orcust" Link procedure requiring Effect Monsters and an archetype member.')],
            "CUSTOM_GAP",
            "The card is a Link Monster but its printed text has no Link-material line, so the Lua's 2-3 Cyberse-material procedure cannot be verified against a printed requirement.",
        ),
        effect(
            "If Link Summoned: add 1 Cyberse Ritual Monster from Deck/face-up Extra Deck and 1 Ritual Spell or Cyberse Normal Monster from GY/face-up banishment; HOPT.",
            "A delayed Link-Summon-success trigger with id count limit requires both pools, selects one from each, merges them, sends both to hand, and confirms them.",
            [ref(3629090, "Summon-success search from Deck/GY with hand confirmation."), ref(29596581, "Adds an eligible face-up banished or GY card to hand.")],
        ),
        effect(
            "Cannot be banished or destroyed by the opponent's cards or effects.",
            "A single-range EFFECT_INDESTRUCTABLE_EFFECT uses aux.indoval; a field EFFECT_CANNOT_REMOVE targets only this card when the reason is an opponent effect and not a redirect.",
            [ref(975299, "Opponent-effect destruction protection through aux.indoval."), ref(30459350, "Field-level EFFECT_CANNOT_REMOVE banishment prevention.")],
        ),
        effect(
            'Quick Effect: remove all Corruption Counters from an opponent monster as cost; destroy 1 controlled "Glitchling" Monster Card or Cyberse Normal Monster, then negate that opponent monster and gain 200 ATK per removed counter; uses per turn up to differently named Bitron/Protron/Digitron in your field or GY.',
            "The free-chain Quick Effect removes all counters from one face-up opponent monster as cost, tracks activations with a turn flag, destroys one eligible controlled on-field card at resolution, disables the counter-bearing monster through the End Phase, and gives this card a persistent 200-per-counter ATK update. The cap counts the three exact codes only in MZONE+GY without a face-up test.",
            [ref(11155484, "Destroy a controlled named card, then negate/destroy the related opposing activation."), ref(28903523, "A per-turn use cap derived from a live field count and temporary effect negation.")],
            "DEFECT",
            "The printed cap says the named cards in your field or GY, but tricount omits the Spell/Trap Zone and also counts face-down Monster Zone cards by code. Face-up named cards in the S/T Zone should count, while face-down cards should not.",
        ),
    ],
    541: [
        effect(
            "Activate by declaring a card name; during the opponent's next End Phase they choose that named card and another card from your Deck, then put both on top in random order; one activation per turn.",
            "The activation has an oath count limit, but Duel.AnnounceCard is called in the resolving operation. A two-End-Phase-reset continuous effect stores the code; on the opponent End Phase it lets the opponent select the two cards, random-selects which is top, calls Duel.ShuffleDeck, then moves both to the top.",
            [ref(28776350, "Duel.AnnounceCard is performed in the target/activation-declaration function and stored as chain target data."), ref(29107423, "Selects cards from the Deck and places selected cards on top without shuffling away the pre-existing Deck order as an unrelated action.")],
            "DEFECT",
            "The name is declared only when the Trap resolves instead of when it is activated, and Duel.ShuffleDeck randomly reorders every other card in the Deck even though the text randomizes only the order of the two chosen cards.",
        ),
    ],
    542: [
        effect(
            "1 DARK Tuner + 1 non-Tuner DARK monster.",
            "AddSynchroProcedure requires exactly one DARK Tuner and exactly one DARK non-Tuner, and EnableReviveLimit applies.",
            [ref(88643579, "DARK-restricted Synchro material filtering through AddSynchroProcedure and aux.NonTuner.")],
        ),
        effect(
            'If Synchro Summoned: target 1 of your banished "Orcust" monsters; Special Summon it; HOPT.',
            "A delayed summon-success trigger checks SUMMON_TYPE_SYNCHRO, targets one face-up banished Orcust monster that can be summoned, and Special Summons it if still related and a zone is available.",
            [ref(39778366, "Targets face-up banished Machine monsters and Special Summons them with zone checks.")],
        ),
        effect(
            "Banish this card from the GY; negate the effects of 1 face-up opponent card until the End Phase; HOPT separate from the first effect.",
            "A GY ignition effect banishes itself as cost, non-target-selects one negatable face-up opponent card at resolution, applies disable/disable-effect (and trap-monster disable) through the End Phase, and uses a distinct id+100 count code.",
            [ref(28903523, "Applies disable and disable-effect registrations to a face-up opposing card until the End Phase."), ref(98431356, "GY banish cost with a separate targeted follow-up effect and once-per-turn handling.")],
        ),
    ],
    543: [
        effect(
            '2+ Effect Monsters, including an "Orcust" monster.',
            "AddLinkProcedure accepts 2 or 3 Effect Monsters and lcheck requires at least one Link-material card in the Orcust set; EnableReviveLimit applies.",
            [ref(30741503, "Exact official Orcust Link-material group check requiring an Orcust member.")],
        ),
        effect(
            'While you control this linked card, "Orcustrated Babel" is unaffected by the opponent\'s activated effects.',
            "A field immunity effect is active while the handler IsLinkState; it targets face-up Orcustrated Babel and rejects activated effects owned by the opponent.",
            [ref(24151924, "Link-state-dependent immunity for linked/co-linked cards against opponent activated effects.")],
        ),
        effect(
            'Target 1 of your banished "Orcust" cards; return it to the GY; HOPT.',
            "An ignition effect targets one face-up banished Orcust card able to go to GY, then sends it with REASON_EFFECT+REASON_RETURN if it remains related.",
            [ref(1154611, "Targets a banished card and returns it to the GY with REASON_RETURN.")],
        ),
    ],
    544: [
        effect(
            'When Normal or Special Summoned: activate 1 "Charmelia" Continuous Spell/Trap from hand, Deck, or GY; HOPT.',
            "Cloned non-delay summon-success triggers find an activatable archetypal Continuous Spell/Trap, move it face-up to the S/T Zone, consume its activation count/cost, and raise the engine activation event.",
            [ref(22499034, "Official True Draco operation obtains GetActivateEffect, moves a Continuous Spell from Deck face-up, and executes its activation cost."), ref(79582540, "Cloned Normal/Special Summon success triggers with a shared hard once-per-turn code.")],
        ),
        effect(
            "If Tributed for a Ritual Summon: draw 1; HOPT.",
            "A delayed EVENT_RELEASE trigger requires REASON_RITUAL, checks draw legality, and draws one with a distinct id+100 count code.",
            [ref(23160024, "EVENT_RELEASE field trigger that draws one after qualifying Tributes."), ref(42600274, "EVENT_RELEASE trigger conditioned on REASON_RITUAL.")],
        ),
    ],
    545: [
        effect(
            'From hand, discard another "Charmelia" monster; Special Summon this card and a Deck/GY "Charmelia" monster whose name differs from the discarded card; HOPT.',
            "The ignition cost selects/discards another archetypal monster only if a differently named Deck/GY summon candidate exists, stores its code, requires two zones, then SpecialSummonSteps this card and one legal differently named candidate before SpecialSummonComplete.",
            [ref(29925614, "Discard another monster as cost to Special Summon the handler from hand."), ref(39778366, "Group/multiple Special Summon operation with zone-count validation.")],
        ),
        effect(
            'If Tributed for a Ritual Summon: activate 1 "Charmelia" Continuous Spell/Trap from Deck or GY; HOPT.',
            "A delayed EVENT_RELEASE trigger checks REASON_RITUAL, finds an activatable archetypal Continuous Spell/Trap through Necrovalley filtering, moves it face-up, consumes its activation count/cost, and raises the activation event.",
            [ref(42600274, "EVENT_RELEASE condition for being Tributed as part of a Ritual Summon."), ref(22499034, "Activates a Continuous Spell directly from Deck through GetActivateEffect and MoveToField.")],
        ),
    ],
    546: [
        effect(
            'During either Main Phase, discard this card; Ritual Summon a hand "Charmelia" Ritual using hand/Deck/field monsters (Levels meet or exceed) and/or controlled face-up "Charmelia" Continuous Spell/Traps worth 4 Levels each; HOPT.',
            "A Main-Phase Quick Effect discards itself as cost, builds legal monster materials from hand/MZONE/Deck plus face-up continuous archetypal S/T materials, values each S/T at 4, checks zones and a greater-or-equal subgroup, releases hand/field monsters, sends Deck monsters and S/T cards with Ritual material reasons, then Ritual Summons and completes procedure.",
            [ref(81560239, "Custom Ritual operation merges standard Ritual materials with Deck materials, selects a Level-valid subgroup, and completes the Ritual Summon."), ref(49721684, "Greater-or-equal Ritual procedure and CompleteProcedure handling.")],
        ),
        effect(
            'If Tributed for a Ritual Summon: place this card on the Deck bottom, then Special Summon 1 "Charmelia" monster from hand or GY; HOPT.',
            "A delayed REASON_RITUAL release trigger requires this card to be returnable through Necrovalley and a summon candidate; it sends itself to SEQ_DECKBOTTOM, then after a break selects and summons one archetypal hand/GY monster.",
            [ref(42600274, "REASON_RITUAL EVENT_RELEASE trigger with a GY follow-up."), ref(29596581, "Sequential zone movement followed by an archetypal Special Summon with Necrovalley handling.")],
        ),
    ],
    547: [
        effect(
            'When the opponent chains to your "Charmelia" card/effect: discard this card from hand or banish it from GY; Special Summon 1 "Charmelia" monster from hand/GY; HOPT.',
            "An EVENT_CHAINING Quick Effect verifies the opponent made the current chain link and the immediately preceding triggering effect was the controller's Charmelia effect; location-dependent cost discards or banishes this card, then the operation summons one archetypal hand/GY monster.",
            [ref(56322832, "Inspects the immediately preceding chain link and triggering player/handler to respond to an opponent chain made against an archetypal effect."), ref(98431356, "GY banish cost followed by a GY Special Summon effect.")],
        ),
        effect(
            'If Tributed for a Ritual Summon: add 1 "Charmelia" card from Deck or GY; HOPT.',
            "A delayed EVENT_RELEASE trigger requires REASON_RITUAL, searches one archetypal Deck/GY card through Necrovalley filtering, sends it to hand, and confirms it, using id+100.",
            [ref(42600274, "REASON_RITUAL EVENT_RELEASE trigger that recovers a Ritual-related card from GY."), ref(3629090, "Deck/GY add-to-hand operation with hand confirmation.")],
        ),
    ],
    548: [
        effect(
            'Ritual Summon a "Charmelia" Ritual from hand/GY using hand/Deck/field monsters whose Levels meet or exceed, and/or controlled face-up "Charmelia" Continuous Spell/Traps worth 4 Levels each; one activation per turn.',
            "The activation builds a custom greater-or-equal material group, but monmatfilter requires IsAbleToGrave for every monster in hand, Deck, or MZONE; after selection it releases hand/field monsters, sends Deck monsters/S/T cards, and Ritual Summons from hand/GY.",
            [ref(49721684, "Official greater-or-equal Ritual Summon from hand/GY uses ordinary Ritual Tributes."), ref(81560239, "Separates ordinary Ritual material from Deck material and only applies Deck-to-GY eligibility to the Deck-material pool.")],
            "DEFECT",
            "IsAbleToGrave is incorrectly required for hand/field monsters that are Tributed. Under a replacement such as Macro Cosmos, legal hand/field Tributes are rejected even though they can be released and banished instead; only Deck/S/T cards explicitly sent to the GY need that check.",
        ),
        effect(
            "For the rest of this turn after this card resolves, Extra Deck Special Summons are limited to Spellcaster or Fairy monsters.",
            "register_lock creates an End-Phase-reset EFFECT_CANNOT_SPECIAL_SUMMON for non-Spellcaster/non-Fairy Extra Deck monsters, but ritop calls it only when ritualsummon returns true after a successful Special Summon.",
            [ref(44362883, "Registers a turn-long Extra Deck Special Summon restriction as part of resolving/activating a summoning Spell.")],
            "DEFECT",
            "The printed restriction is tied to this card resolving, not to successfully Ritual Summoning. If the legal activation resolves without a summon because its materials/target disappear, the Lua applies no restriction.",
        ),
    ],
    549: [
        effect(
            'When activated: optionally add 1 "Charmelia" Ritual Monster and/or 1 "Charmelia" Ritual Spell from Deck; HOPT.',
            "The activation count uses id; resolution selects a subgroup of one or two where at most one is a Ritual Monster and at most one is an eligible Ritual Spell, then adds/confirms them.",
            [ref(975299, "Optional search performed when a persistent Spell is activated."), ref(3629090, "Ritual Spell search and Deck-to-hand confirmation.")],
        ),
        effect(
            'All "Charmelia" monsters you control gain 400 ATK/DEF.',
            "Paired field EFFECT_UPDATE_ATTACK/DEFENSE effects target face-up Charmelia monsters in the controller's Monster Zone and apply +400.",
            [ref(975299, "Paired archetype-wide field ATK/DEF updates on a persistent Spell.")],
        ),
        effect(
            'If sent to the GY by the effect of a "Charmelia" monster: place this card face-up in your S/T Zone; HOPT.',
            "A delayed EVENT_TO_GRAVE trigger requires REASON_EFFECT and checks the resolving effect handler is currently both Charmelia and TYPE_MONSTER, then moves this card face-up from GY if a zone remains.",
            [ref(59805313, "EVENT_TO_GRAVE trigger that later places a qualifying Continuous Spell/Trap face-up with MoveToField."), ref(79582540, "Uses re:IsActiveType/trigger semantics for identifying the type of the effect that caused a movement event.")],
            "DEFECT",
            "The condition tests re:GetHandler():IsType(TYPE_MONSTER) at trigger processing instead of re:IsActiveType(TYPE_MONSTER). If the Charmelia monster-effect handler changes type or becomes face-down before this trigger is checked, the printed cause is lost even though the causing effect was activated as a monster effect.",
        ),
    ],
    550: [
        effect(
            'While you control a "Charmelia" Ritual Monster, the opponent cannot target your "Charmelia" monsters with card effects.',
            "A field target-protection effect is conditional on a face-up Charmelia Ritual in the controller's MZONE, targets face-up Charmelia monsters, and uses opponent-only aux.tgoval.",
            [ref(975299, "Conditional/archetypal opponent-only effect-target protection through EFFECT_CANNOT_BE_EFFECT_TARGET and aux.tgoval.")],
        ),
        effect(
            'Once per turn, the first time a "Charmelia" monster you control would be destroyed by battle or card effect, it is not destroyed.',
            "A field EFFECT_INDESTRUCTABLE_COUNT targets face-up Charmelia monsters, has a shared count limit of one, and accepts REASON_BATTLE or REASON_EFFECT.",
            [ref(35815783, "Field EFFECT_INDESTRUCTABLE_COUNT for the first qualifying battle/effect destruction."), ref(15543940, "Counted battle-or-effect destruction prevention using the destruction reason mask.")],
        ),
        effect(
            'If sent to GY by a "Charmelia" card effect: add this card, then draw equal to your controlled "Charmelia" Ritual Monsters; HOPT.',
            "A delayed EVENT_TO_GRAVE trigger requires REASON_EFFECT and a Charmelia effect handler; it returns itself through Necrovalley, recomputes the face-up Ritual count after the successful add, breaks the effect, and draws that many.",
            [ref(79582540, "A movement trigger performs a first operation and conditionally draws after that operation succeeds."), ref(29596581, "Face-up/GY archetype filtering and Necrovalley-aware movement to hand.")],
        ),
    ],
    551: [
        effect(
            '(This card is always treated as a "Charmelia" card.)',
            "The current CCG database row stores both the card's own setcode and Charmelia setcode 0x12b1 (hex blob D2EBB112); listed_series also exposes Charmelia to script tooling.",
            [ref(28306253, "Official always-treated-as naming/archetype classification is database/list metadata rather than an activated Lua effect.")],
        ),
        effect(
            "If the opponent controls more cards, they cannot respond to this card's effect activations.",
            "Each activated effect calls protect_chain during target setup; if the opponent's on-field count exceeds the controller's, SetChainLimit permits only the controller to add the next chain link.",
            [ref(48130397, "Sets a chain limit during activation targeting so the opponent cannot respond.")],
        ),
        effect(
            'Once per turn during either Main Phase: Tribute a hand/face-up-field "Charmelia" monster; non-target-select an opponent monster, negate it, and if successful banish it face-down.',
            "A Main-Phase Quick Effect releases one eligible hand/MZONE monster as cost, non-target-selects a negatable opposing monster at resolution, registers disable effects, then removes it face-down without a sequential break; id count limit applies.",
            [ref(24224830, "Banishes a monster and applies effect negation to the selected card."), ref(11155484, "Cost followed by negation and a dependent removal/destruction operation.")],
        ),
        effect(
            'If the opponent controls an Extra-Deck-Summoned monster: Special Summon a "Charmelia" Ritual from hand/Deck/GY ignoring conditions, treated as a Ritual Summon; HOPT.',
            "The condition searches only face-up opponent monsters with Extra Deck summon location. The summon filter uses IsCanBeSpecialSummoned with nocheck=false,nolimit=true; the operation summons with SUMMON_TYPE_RITUAL and CompleteProcedure.",
            [ref(60303688, "Official Extra-Deck-summoned-monster condition checks IsSummonLocation without requiring face-up."), ref(14094090, "Ignoring Summoning conditions uses IsCanBeSpecialSummoned/Duel.SpecialSummon with nocheck=true."), ref(8454126, "Special Summon treated as a Ritual Summon through SUMMON_TYPE_RITUAL and CompleteProcedure.")],
            "DEFECT",
            "Two printed cases are excluded: extrafilter wrongly requires the opponent's Extra-Deck-Summoned monster to remain face-up, and the summon uses nocheck=false even though the text explicitly ignores Summoning Conditions.",
        ),
    ],
    552: [
        effect(
            'Can be Ritual Summoned with a "Charmelia" card.',
            "EnableReviveLimit plus an uncopyable aux.ritlimit Special Summon condition permits proper Ritual Summoning; Charmelia Ritual effects provide the matching archetypal summon routes.",
            [ref(3629090, "Official Ritual Monster revive-limit/proper Ritual Summon structure.")],
        ),
        effect(
            "Cannot be destroyed by battle.",
            "A single-range EFFECT_INDESTRUCTABLE_BATTLE on the Monster Zone has constant value 1.",
            [ref(15610297, "Unconditional battle indestructibility through EFFECT_INDESTRUCTABLE_BATTLE.")],
        ),
        effect(
            'Reveal from hand; shuffle this card into the Deck, then Special Summon 1 "Charmelia" monster from Deck; HOPT.',
            "The ignition cost confirms this non-public card; resolution sends it to SEQ_DECKSHUFFLE, requires it to reach Deck, then after a break selects and Special Summons one archetypal Deck monster.",
            [ref(95365081, "Exact reveal/shuffle-self-into-Deck then archetypal Deck Special Summon sequence.")],
        ),
        effect(
            "Once per turn (Quick Effect): target an opponent monster; place it face-up in your S/T Zone as a Continuous Spell.",
            "A free-chain target effect requires a face-up target and controller S/T capacity; resolution moves the still-related nonimmune target to the controller's S/T Zone and registers TYPE_SPELL+TYPE_CONTINUOUS.",
            [ref(24081957, "Targets a face-up monster, MoveToField places it in an S/T Zone, and EFFECT_CHANGE_TYPE makes it a Continuous Spell.")],
        ),
    ],
    553: [
        effect(
            'Can be Ritual Summoned with a "Charmelia" card.',
            "EnableReviveLimit and an uncopyable aux.ritlimit Special Summon condition enforce a proper Ritual Summon route.",
            [ref(3629090, "Official Ritual Monster proper-summon/revive-limit structure.")],
        ),
        effect(
            'You can only control 1 "Charmelia Fairy Morningstar".',
            "SetUniqueOnField(1,0,id) registers the one-per-controller uniqueness rule when the engine method is available.",
            [ref(93860227, "Official one-copy-on-field monster uniqueness procedure.")],
        ),
        effect(
            "Once per turn (Quick Effect): send a Continuous Spell/Trap from hand/face-up field to GY, target up to 2 opponent cards, negate then destroy them; a Monster Card paid cannot trigger in GY this turn.",
            "The Quick Effect sends an eligible card as cost; original/current Monster Cards receive EFFECT_CANNOT_TRIGGER through End Phase. It targets one or two negatable opponent cards, disables still-face-up valid targets, then after a break destroys the successfully disabled group; id count limit applies.",
            [ref(32422602, "Sends a face-up Continuous Spell/Trap as activation cost for a negation effect."), ref(11155484, "Negation followed by dependent destruction."), ref(10515412, "Applies EFFECT_CANNOT_TRIGGER to prevent a moved monster's effects.")],
        ),
        effect(
            'If sent to GY: target up to 2 "Charmelia" cards in GY/face-up banishment; add them to hand; HOPT.',
            "A delayed targeted EVENT_TO_GRAVE effect selects one or two archetypal GY/face-up-banished cards through Necrovalley filtering, rechecks relation/filter, sends them to hand, and confirms them; id+100 count applies.",
            [ref(29596581, "Recovers archetypal cards from GY or face-up banishment through a Necrovalley-aware filter."), ref(15306543, "GY/banishment retrieval into hand with face-up-banished filtering.")],
        ),
    ],
    554: [
        effect(
            "During your Main Phase: target 1 WIND Insect in your GY; add it to hand; HOPT.",
            "A Monster Zone ignition effect targets one WIND Insect monster in the controller's GY through Necrovalley, then returns it if still related and able.",
            [ref(42600274, "Targeted GY recovery to hand with relation checking."), ref(29596581, "Necrovalley-aware add-to-hand operation from GY.")],
        ),
        effect(
            'If sent to GY: Special Summon this card, then if sent from hand/field optionally send 1 "Wyvernal" monster from Deck to GY; HOPT.',
            "A delayed EVENT_TO_GRAVE trigger checks self-revival legality; operation snapshots the previous hand/on-field location, Special Summons itself through Necrovalley, and only after success optionally selects/sends one archetypal Deck monster.",
            [ref(73956664, "EVENT_TO_GRAVE self-revival followed by a dependent send-to-GY operation."), ref(60242223, "Delayed sent-to-GY trigger that sends an archetypal Deck card to GY.")],
        ),
    ],
    555: [
        effect(
            'Reveal this card in hand; Special Summon another "Wyvernal" from hand/Deck, then discard this card; HOPT.',
            "The hand ignition cost reveals/confirms this non-public card; resolution selects and Special Summons a non-self-code archetypal hand/Deck monster, then after a break discards the still-related handler with REASON_DISCARD; id count applies.",
            [ref(13332685, "Reveal-in-hand operation that Special Summons an archetypal monster from Deck before a mandatory follow-up action."), ref(95365081, "Reveal-hand cost and sequential Deck Special Summon structure.")],
        ),
        effect(
            'If Normal or Special Summoned: send exactly 2 same-name "Wyvernal" monsters from Deck to GY; HOPT.',
            "Cloned delayed Normal/Special Summon triggers share id+100; target legality requires two sendable same-code archetypal Deck monsters, and resolution selects one then a second with that code and sends the two-card group.",
            [ref(23812568, "Validates/selects exactly two same-code cards from the Deck and sends a two-card group to the GY."), ref(1050186, "Normal/Special Summon trigger that sends an archetypal monster from Deck to GY.")],
        ),
    ],
}


def sha256(data: bytes) -> str:
    return hashlib.sha256(data).hexdigest()


def main() -> int:
    with sqlite3.connect(OMEGA_DB) as db:
        official = {int(cid): str(name) for cid, name in db.execute("SELECT id,name FROM texts")}

    records = []
    for ordinal in range(539, 556):
        card = CARDS[ordinal - 1]
        script_path = CCG / f"c{card['passcode']}.lua"
        effects = SPECS[ordinal]
        for index, item in enumerate(effects, 1):
            item["effect_index"] = index
            for reference in item["official_references"]:
                card_id = int(reference["card_id"])
                official_path = OMEGA / f"c{card_id}.lua"
                if not official_path.is_file():
                    raise FileNotFoundError(official_path)
                if card_id not in official:
                    raise ValueError(f"Official reference {card_id} has no Omega DB row")
                reference["card_name"] = official[card_id]

        verdicts = {item["verdict"] for item in effects}
        overall = "DEFECT" if "DEFECT" in verdicts else "CUSTOM_GAP" if "CUSTOM_GAP" in verdicts else "PASS"
        records.append(
            {
                "ordinal": ordinal,
                "passcode": int(card["passcode"]),
                "name": card["name"],
                "text_sha256": sha256(str(card.get("text") or "").encode("utf-8")),
                "script_sha256": sha256(script_path.read_bytes()),
                "overall_verdict": overall,
                "coverage_override": {
                    "expected_individual_effects": len(effects),
                    "reason": (
                        f"Fresh semantic segmentation found {len(effects)} individual printed procedure/effect records. "
                        "Conjunctions, choices, dependent 'then/and if you do' steps, and their HOPT/use-cap text are kept "
                        "with the single Lua effect that resolves them; separately functioning procedures, continuous rules, "
                        "and activated/triggered effects are separate records."
                    ),
                },
                "effects": effects,
            }
        )

    payload = {
        "schema_version": 1,
        "batch": "8c",
        "ordinal_start": 539,
        "ordinal_end": 555,
        "method": "Fresh card-by-card semantic comparison; checklist Markdown and historical verdicts were not consulted.",
        "cards": records,
    }
    OUTPUT.parent.mkdir(parents=True, exist_ok=True)
    OUTPUT.write_text(json.dumps(payload, ensure_ascii=False, indent=2) + "\n", encoding="utf-8")
    print(f"wrote {OUTPUT}")
    print(f"cards={len(records)} effects={sum(len(record['effects']) for record in records)}")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
