#!/usr/bin/env python3
"""Build three training-shaped Ideogram 4 artwork prompts for every A.I.P card."""

from __future__ import annotations

import json
from pathlib import Path


ROOT = Path(__file__).resolve().parents[1]
OUT_JSON = ROOT / "output" / "aip_yugioh_ah_3x_prompts.json"
OUT_MD = ROOT / "output" / "AIP_YUGIOH_AH_3X_PROMPTS.md"

STYLE = "hclar52 card illustration"
BBOX = [0, 0, 996, 996]


def visual_text(text: str) -> str:
    """Remove lore names that carry no learned visual meaning inside prompts."""
    replacements = (
        ("A.I.P Xyz organism", "black-green Xyz organism"),
        ("A.I.P Xyz creature", "black-green Xyz creature"),
        ("A.I.P Xyz beast", "black-green Xyz beast"),
        ("A.I.P laboratory", "underground laboratory"),
        ("A.I.P prototype", "artificial prototype"),
        ("A.I.P predators", "black-green predators"),
        ("A.I.P creatures", "black-green creatures"),
        ("A.I.P creature", "black-green creature"),
        ("A.I.P beast", "black-green beast"),
        ("A.I.P specimen", "artificial specimen"),
        ("A.I.P network", "living neural network"),
        ("A.I.P armor", "black-green biological armor"),
        ("A.I.P beasts", "artificial beasts"),
        ("A.I.P predator", "artificial predator"),
        ("A.I.P Caller", "towering hooded caller"),
        ("A.I.P mother", "colossal one-eyed mother organism"),
        ("The small Shrieker", "The small long-jawed beast"),
        ("The Claw", "The six-limbed hunter"),
        ("The Maw", "The jawed beast"),
        ("The Predator", "The apex predator"),
        ("The Caller", "The hooded caller"),
        ("Zero Mother", "The mother organism"),
    )
    for source, target in replacements:
        text = text.replace(source, target)
    return text


def v(label, high, aesthetics, lighting, palette, background, desc):
    return {
        "version": label,
        "prompt": {
            "high_level_description": visual_text(high),
            "style_description": {
                "aesthetics": visual_text(aesthetics),
                "lighting": visual_text(lighting),
                "medium": "illustration",
                "art_style": STYLE,
                "color_palette": palette,
            },
            "compositional_deconstruction": {
                "background": visual_text(background),
                "elements": [{"type": "obj", "bbox": BBOX, "desc": visual_text(desc)}],
            },
        },
    }


P = [
    {
        "card": "The Misstakes of the A.I.P Experience",
        "card_kind": "Level 3 DARK Beast Normal Monster",
        "versions": [
            v("A — First Awakening", "A Beast-type Normal MONSTER card artwork showing the following scene: an unfinished artificial beast climbs from a ruptured specimen basin during the first failed laboratory activation.", "uncanny experimental creature art with fragile newborn energy", "sickly green overhead light with a warm orange glow beneath the specimen fluid", ["#D8D6B2", "#26382F", "#7D9A66", "#D95B32", "#98D4C7", "#171D1A"], "A damaged pale-green laboratory surrounds a cracked steel basin, one broken observation window, hanging cables, and low vapor.", "A small asymmetrical quadrupedal creature pulls itself from green nutrient fluid. Its pale unfinished hide is interrupted by black-green armor patches, one oversized orange eye, thin red vessels, mismatched forelimbs, and a trailing restraint cable; its wet claws scrape the basin as glass falls behind it."),
            v("B — Observation Breach", "A Beast-type Normal MONSTER card artwork showing the following scene: a malformed artificial animal crashes through an observation window as its frightened makers abandon the laboratory.", "tense creature-feature fantasy with sudden broken-glass motion", "cold cyan window light crossed by red emergency reflections and a dim orange eye", ["#18241F", "#547263", "#9AC8C0", "#C53E2E", "#E5D7B6", "#0D1210"], "A wide laboratory observation room contains one shattered window, a dark control desk, and two distant fleeing silhouettes.", "An unfinished black-green beast bursts shoulder-first through the broken window. One foreleg is armored and powerful while the other remains pale and narrow; a single orange eye watches the fleeing figures, red channels glow beneath translucent skin, and a snapped collar trails sparks through the glass."),
            v("C — Abandoned Prototype", "A Beast-type Normal MONSTER card artwork showing the following scene: the first abandoned A.I.P prototype prowls alone through a powerless research wing after its restraints have failed.", "lonely ominous laboratory fantasy with a discoverable origin story", "a narrow amber maintenance lamp reveals the creature against deep teal-black corridors", ["#101816", "#2D4438", "#778B67", "#DB7B36", "#C7C5A7", "#07100D"], "A powerless research corridor recedes through broad shadowed doorways, scattered restraint hoops, and a thin layer of green mist.", "A lean imperfect beast steps over its discarded harness and follows a blinking amber lamp. Its uneven black-green plates expose pale synthetic tissue, one orange eye is fully developed while the opposite socket remains sealed, and its long tail drags a bundle of severed sensor wires."),
        ],
    },
    {
        "card": "A.I.P Ex Larva",
        "card_kind": "Level 3 DARK Beast Effect Monster",
        "versions": [
            v("A — Specimen-Tray Escape", "A Beast-type MONSTER card artwork showing the following scene: a small pillbug-like artificial larva scuttles out of a cracked specimen tray across a laboratory workbench.", "quick clever creature art with tactile miniature detail", "cool green bench light with a warm red rim along the shell seams", ["#14231D", "#355642", "#7EA06B", "#D94B2B", "#E2D4B7", "#8FC9C0"], "A laboratory bench holds one cracked steel tray, a blurred cabinet bank, a forceps, and a broken vial.", "A low larval beast bends into a shallow curve as its front feet grip the bench and its rear plates emerge from the tray. Seven overlapping black-green shell plates carry narrow red seams, one recessed orange eye peers forward, and translucent nutrient gel stretches between its hooked feet."),
            v("B — Revealed Packmate", "A Beast-type MONSTER card artwork showing the following scene: an artificial larva cracks open a glowing data capsule and awakens another dormant beast hidden inside it.", "playful technological summoning with a sharp moment of discovery", "white capsule light illuminates green shell plates while orange-red signals pulse outward", ["#10201A", "#3F6950", "#D8E8D7", "#E25B2B", "#F4D48C", "#2D8D83"], "A dark specimen archive is reduced to broad drawer shapes, one open capsule cradle, and drifting green vapor.", "The pillbug larva hooks its forefeet around a translucent capsule as the casing splits. A second tiny beast-shaped shadow rises from orange light within, while the larva's single eye and seven red-seamed plates reflect the same pulse; broken shell halves spin away from the awakening."),
            v("C — Trap Conductor", "A Beast-type MONSTER card artwork showing the following scene: a tiny artificial larva sacrifices its body to activate a dormant containment protocol during a larger beast's attack.", "urgent sacrificial fantasy action with compact electrical energy", "cyan laboratory darkness cut by one red pulse and a white impact flash", ["#0B1512", "#274438", "#69A092", "#C92E28", "#F0E4C8", "#314D47"], "A shadowed laboratory floor contains one inactive restraint seal, a broken cable loop, and the legs of a larger beast passing behind.", "The larva leaps onto the restraint seal as its shell breaks into seven glowing segments. Red current races from those plates through the floor cables, igniting a wide mechanical trap beneath the larger beast while the larva's orange eye remains visible inside the dissolving pulse."),
        ],
    },
    {
        "card": "A.I.P Ex Shrieker",
        "card_kind": "Level 3 DARK Beast Effect Monster",
        "versions": [
            v("A — Containment Scream", "A Beast-type MONSTER card artwork showing the following scene: a squat black-green artificial beast bursts through a containment wall and unleashes a sonic scream across the laboratory.", "violent bio-mechanical monster action with a single directional impact", "cold cyan backlight contrasts with orange throat light and thin red armor seams", ["#101816", "#29372B", "#D64725", "#F0C88F", "#65C5C2", "#77815B"], "A dark green laboratory chamber has one shattered containment wall, broad cracked panels, drifting vapor, and sparse red alarms.", "A low four-legged predator lunges through the breach with heavy black-green shoulder plates, one orange eye, short hooked claws, and a tall fang-lined mouth. A narrow cone of compressed air tears toward the upper left, carrying several broad glass pieces and bending the vapor along one path."),
            v("B — Division Cry", "A Beast-type MONSTER card artwork showing the following scene: a screaming artificial beast breaks apart into two different A.I.P predators that spring from the same violent sound wave.", "explosive metamorphosis with clearly separated emerging creatures", "orange throat light divides into two red-cyan trails against a dark green chamber", ["#0D1714", "#244238", "#C63A2A", "#E7B66D", "#67BFB5", "#D7D2B8"], "A damaged summoning chamber curves around a central floor rupture, with simple wall ribs and low smoke.", "The small Shrieker arches backward as its black-green body dissolves into a compressed sonic flare. Two distinct beasts emerge from opposite sides of the flare: a lean taloned hunter races left and a heavy jawed predator drives right, each connected to the vanishing Shrieker by one red energy stream."),
            v("C — Last Echo", "A Beast-type MONSTER card artwork showing the following scene: the fading echo of a fallen artificial beast shields its pack from a collapsing laboratory ceiling.", "protective supernatural aftermath with restrained spectral motion", "dim teal ruin light with a translucent orange-red echo surrounding the surviving beasts", ["#0B1412", "#304A40", "#5F8C80", "#D84B2C", "#F0C88F", "#777963"], "A collapsed laboratory passage contains two broad falling slabs, thick dust, and the shadowed shapes of surviving artificial beasts.", "A translucent afterimage of the Shrieker rises from a small broken shell on the floor. Its open jaw releases one curved orange-red vibration that catches the falling slabs above two crouching packmates; the spectral eye remains bright while the rest of its body disperses into the dust."),
        ],
    },
    {
        "card": "A.I.P Ex Claw",
        "card_kind": "Level 6 DARK Beast Effect Monster",
        "versions": [
            v("A — Corridor Ripper", "A Beast-type MONSTER card artwork showing the following scene: a lean six-limbed artificial hunter tears sideways through a reinforced laboratory corridor with one immense crescent foreclaw.", "fast predatory action with aggressive foreshortening", "hard white light flashes along pale talons above deep green armor and red seams", ["#0E1714", "#284137", "#BFC7BB", "#E5D7B2", "#C83D2A", "#4F8F87"], "A reinforced corridor collapses into two broad wall planes and one receding doorway beneath green emergency haze.", "A narrow black-green hunter twists through the corridor on six limbs. Four long ivory-metal talons on its leading forearm carve a single crescent through the wall, while the smaller rear claw anchors behind its plated torso; one orange eye and swept-back armor fins follow the direction of the strike."),
            v("B — Grave Excavator", "A Beast-type MONSTER card artwork showing the following scene: an artificial clawed hunter rips open a sealed specimen vault and exposes the dormant beast preserved beneath it.", "dark archaeological laboratory fantasy with forceful excavation", "a red-orange glow rises from the opened vault beneath cold overhead cyan light", ["#101714", "#34463B", "#958A70", "#D74729", "#E5D0A8", "#4AA79A"], "A ruined specimen archive contains a cracked floor vault, broad stone-metal drawers, and low dust clouds.", "The six-limbed hunter drives its enormous crescent talons through the vault lid and pulls the metal apart. Beneath the claw, the fossil-like outline of another black-green beast rests in orange fluid; red signal threads travel from the exposed specimen into the hunter's plated arm."),
            v("C — Returning Material", "A Beast-type MONSTER card artwork showing the following scene: a wounded artificial hunter dissolves into orbiting material and restores a colossal A.I.P creature from a ruined chamber.", "dramatic resurrection with controlled circular energy", "pale green grave light contrasts with a dense orange-red material core", ["#0A1310", "#263E34", "#688F7C", "#D5402C", "#F0C990", "#B9B9A6"], "A broken underground chamber opens around one dark crater, fractured machinery, and a distant cyan shaft of light.", "The Claw kneels beside the crater as its body separates into six red-edged armor fragments. Those fragments spiral into the chest of a larger rising A.I.P beast, and the immense crescent talons become two solid orbiting plates locked against the revived creature's dark body."),
        ],
    },
    {
        "card": "A.I.P Ex Maw",
        "card_kind": "Level 6 DARK Beast Effect Monster",
        "versions": [
            v("A — Floorbreaker", "A Beast-type MONSTER card artwork showing the following scene: a massive jawed artificial beast erupts through a laboratory floor and bites across the chamber.", "heavy destructive monster art with a powerful rising curve", "dull orange light burns inside the mouth beneath cold green industrial illumination", ["#0B1512", "#263B32", "#C9432B", "#E2C69B", "#6F8470", "#55AEA2"], "A pale concrete laboratory is split by one broad floor rupture, a shadowed wall opening, and green vapor.", "A thick black-green beast rises from the rupture on a muscular curved body with small gripping forelimbs, one recessed orange eye, and a broad side-opening jaw. Uneven ivory teeth close around a torn floor beam as red channels flare between its layered armor plates."),
            v("B — Protocol Seeder", "A Beast-type MONSTER card artwork showing the following scene: a jawed artificial beast plants a living containment trap into the laboratory floor as it emerges.", "ominous biological engineering with a clear cause-and-effect event", "orange mouth light illuminates a crimson seed against muted green shadows", ["#0D1814", "#30483B", "#9B8465", "#D73C2A", "#F0D2A1", "#4D9B8E"], "A circular test chamber contains one cracked floor channel, dark observation glass, and a restrained bank of pipes.", "The Maw crouches over the floor and lowers a red-black organic capsule from between its fangs. Root-like signal lines spread from the capsule into a concealed mechanical seal, while the creature's small foreclaws brace against the concrete and its single orange eye watches the device awaken."),
            v("C — Selective Ruin", "A Beast-type MONSTER card artwork showing the following scene: a black-green artificial beast roars as a destructive pulse tears through ordinary animals but passes harmlessly around its own pack.", "apocalyptic monster effect art with a readable protected group", "a white-orange shock front divides dark green allies from gray collapsing enemies", ["#0A1210", "#253B32", "#667069", "#D7422C", "#F4D49D", "#6AB4A7"], "A ruined research arena is divided by one diagonal shock front, broken floor plates, and a smoky green wall.", "The Maw opens its broad side jaw and releases a dense orange pulse. Gray altered beasts on one side fragment into ash and armor shards, while three black-green A.I.P creatures on the other side remain solid inside thin red outlines; the Maw's eye and teeth anchor the source of the destruction."),
        ],
    },
    {
        "card": "A.I.P Ex Predator",
        "card_kind": "Level 9 DARK Beast Effect Monster",
        "versions": [
            v("A — Apex Breach", "A Beast-type MONSTER card artwork showing the following scene: an enormous armored artificial predator stalks from a burning laboratory breach into cold night rain.", "monumental predatory fantasy with controlled weight and menace", "hot orange laboratory light rims a black-green body against blue-gray rain", ["#0A1110", "#203B32", "#C6452C", "#E08948", "#496A78", "#B8C4BD"], "A torn laboratory doorway separates a hot smoky interior from a rain-filled exterior of broad blue-gray structures.", "A low quadrupedal apex beast steps through the breach with a wedge-shaped skull, two narrow orange eyes, layered dorsal plates, long forearms, and heavy hooked claws. One paw crushes a fallen containment cart while its arched back and trailing tail emerge from the firelit doorway."),
            v("B — Sacrificial Emergence", "A Beast-type MONSTER card artwork showing the following scene: a colossal artificial predator materializes from the collapsing body of a smaller Beast inside a ritual laboratory.", "dark predatory summoning with solemn biological transformation", "deep cyan chamber light surrounds a concentrated red-orange emergence flare", ["#08120F", "#244238", "#5A7465", "#C83328", "#E6A25F", "#72B9AE"], "A circular underground laboratory contains one broken summoning cradle, broad wall ribs, and descending smoke.", "A smaller pale Beast dissolves into red-black particles beneath the descending paws of the Predator. The enormous black-green creature forms from those particles head-first, its orange eyes opening above the vanishing donor while dense armor plates lock across its shoulders and spine."),
            v("C — Protocol Hunter", "A Beast-type MONSTER card artwork showing the following scene: the apex A.I.P predator activates a hidden laboratory protocol while hunting through an abandoned city research district.", "urban monster pursuit with covert technological menace", "cold moonlight and cyan windows reveal restrained red signals along the creature", ["#091210", "#20352E", "#3E5960", "#C43A2A", "#D4B47C", "#72AFA7"], "An abandoned research district consists of a few dark tower shapes, one illuminated service tunnel, rain, and ground fog.", "The Predator prowls between ruined buildings as a thin tendril from its foreclaw touches a concealed red seal in the street. The seal unfolds into a black-green trap behind an unaware distant figure, while the beast's low head, two orange eyes, and heavy shoulders remain half hidden by rain."),
        ],
    },
    {
        "card": "A.I.P Lab",
        "card_kind": "Field Spell",
        "versions": [
            v("A — Containment Failure", "A Field SPELL card artwork showing the following scene: an asymmetrical underground research laboratory suffers simultaneous containment failures as artificial beasts escape into its central work floor.", "environmental science-fantasy with layered spatial storytelling", "sickly green overhead light mixes with red alarms and white containment vapor", ["#111A17", "#344C40", "#7C9276", "#B93629", "#D9D3B6", "#5AA69C"], "A deep research floor contains a ruptured central chamber, an observation window, broad machinery banks, and receding service walkways.", "Green fluid pours from the broken chamber while three differently sized black-green beasts escape along separate paths. A small larva crosses the wet foreground, a clawed hunter climbs a side gantry, and a massive shadow presses through the rear wall as red signal lines awaken beneath the floor."),
            v("B — Level Calibration", "A Field SPELL card artwork showing the following scene: one artificial Beast passes through three linked laboratory rings and rapidly changes from a larva into a towering predator.", "transformative laboratory fantasy with three readable stages of growth", "cyan-white calibration light intensifies into orange-red energy across the chamber", ["#0D1815", "#2D4D42", "#69B5AA", "#D7462C", "#F0D6A5", "#29352F"], "A long calibration hall is formed by three large mechanical arches, a dark rear wall, and low green mist.", "A single black-green creature crosses the arches from left to right in three continuous growth phases: plated larva, lean clawed hunter, and massive quadrupedal predator. The same orange eye and red armor seams identify every stage while energy steps upward between the rings."),
            v("C — Pack Overclock", "A Field SPELL card artwork showing the following scene: the A.I.P laboratory channels a shared power surge through an entire pack of artificial beasts during an emergency.", "energetic field-wide enhancement with a coherent network pattern", "a cyan reactor column sends restrained red-orange pulses through dark green creatures", ["#081310", "#1F4035", "#49A89A", "#D53628", "#F0B969", "#8B9A82"], "A circular power chamber surrounds one cyan reactor column, broad floor conduits, and shadowed observation decks.", "Five different A.I.P beasts circle the reactor at varied depths as one red pulse travels through the floor and illuminates their armor seams at the same instant. The nearest clawed forelimb digs into the floor while the largest predator raises its head behind the reactor glow."),
        ],
    },
    {
        "card": "Failures of the A.I.P",
        "card_kind": "Normal Trap",
        "versions": [
            v("A — Captured as Material", "A Normal TRAP card artwork showing the following scene: a hostile monster is compressed into a dark material orb and pulled beneath a waiting A.I.P Xyz beast.", "sudden supernatural capture with a sharp reversal of power", "violet-black compression light contrasts with orange eyes and cold laboratory green", ["#0A1210", "#263D35", "#5D3C74", "#C53B2B", "#E4C58F", "#62A89D"], "A ruined laboratory arena contains one cracked platform, scattered restraints, and a shadowed green wall.", "A pale armored enemy twists inside a collapsing violet sphere as two black-green tendrils pull it downward. Above the sphere, the underside and claws of a massive A.I.P Xyz creature descend, surrounded by several dense red-black material orbs that share the captive's reflected outline."),
            v("B — Gallery of Failures", "A Normal TRAP card artwork showing the following scene: rejected artificial prototypes awaken together inside a forgotten laboratory disposal vault.", "tragic biological horror with varied malformed creatures", "weak amber disposal lamps reveal pale bodies beneath intermittent red alarms", ["#101512", "#4A5143", "#9B9274", "#C13A2E", "#D8C9A7", "#456F67"], "A deep disposal vault contains broken specimen tanks, a flooded trench, and broad shelves fading into green darkness.", "Several failed prototypes crawl from shattered tanks: a beast with sealed eyes, a larva with mismatched plates, a jaw without a body, and a pale quadruped dragging cables. One completed black-green organism watches from the upper shadows as red veins begin connecting the discarded creatures."),
            v("C — Recycled Error", "A Normal TRAP card artwork showing the following scene: a discarded A.I.P specimen is dissolved, returned through the laboratory system, and replaced by a newly awakened subject.", "eerie industrial recycling with a circular narrative flow", "muted green machinery surrounds one bright orange-red transfer pulse", ["#0B1512", "#2F493D", "#6F806A", "#D3412C", "#E8C589", "#64A69A"], "A compact processing chamber contains a dark reclamation tank, one transparent return pipe, and a sealed specimen drawer.", "A malformed shell dissolves inside the reclamation tank and travels as red-black particles through the return pipe. At the opposite end, the specimen drawer opens around one bright orange eye and a small black-green claw, linking disposal and renewed creation in a single machine."),
        ],
    },
    {
        "card": "A.I.P Ex Assimilation",
        "card_kind": "Normal Trap",
        "versions": [
            v("A — Split Transformation", "A Normal TRAP card artwork showing the following scene: an armored automaton is transformed into an A.I.P creature along a violent diagonal boundary.", "dramatic biomechanical conversion with two clearly connected material states", "cold white light remains on the machine while orange-red energy burns through the altered half", ["#121819", "#B8C2C2", "#243C33", "#C83A2B", "#E89B55", "#647B74"], "A ruined laboratory loading bay appears as broad gray wall shapes, one broken gantry, and low green smoke.", "One continuous crouching figure is divided by a jagged red conversion front. Its left side retains pale angular armor and a mechanical hand; its right side has become black-green muscle plates, a predatory jaw, one orange eye, and a hooked claw as two thick tendrils tighten around its torso."),
            v("B — Stolen Knight", "A Normal TRAP card artwork showing the following scene: a luminous enemy knight is seized by a black-green neural organism and forced to turn against its former allies.", "ominous mind-control fantasy with a readable change of allegiance", "white-gold knight light is swallowed by dark green shadows and one red-orange eye", ["#0C1412", "#2B4137", "#D8D8C8", "#C63C2D", "#E3A35D", "#5C7B72"], "A shattered city courtyard contains two distant pale warriors, broad fallen columns, and green smoke from a laboratory breach.", "A compact one-eyed organism grips the knight's upper back with four short tendrils. Black-green armor spreads across the knight's silver body as the sword turns toward the distant allies; the helmet visor goes dark except for a new orange eye and thin red seams along the transformed arm."),
            v("C — Neural Override", "A Normal TRAP card artwork showing the following scene: an artificial parasite enters the exposed core of a giant enemy Beast and rewrites its body into A.I.P armor.", "large-scale biological takeover with concentrated invasive detail", "a red core flare illuminates black-green growth against blue-gray storm light", ["#091210", "#223B32", "#556A72", "#D63D2A", "#F0B66B", "#A4AAA0"], "A storm-damaged containment yard contains one fallen tower, wet concrete, and a distant laboratory doorway.", "A giant pale Beast rears as a small black-green parasite enters a cracked chest core. Red channels branch from the wound and lock dark armor plates across one shoulder, jaw, and foreleg; the original blue eye fades while a new orange sensory node opens above it."),
        ],
    },
    {
        "card": "A.I.P Ex Hive Mind",
        "card_kind": "Continuous Trap",
        "versions": [
            v("A — Synchronized Pack", "A Continuous TRAP card artwork showing the following scene: three different artificial beasts synchronize with a suspended neural organism inside a dark laboratory chamber.", "eerie coordinated intelligence with sparse precise connections", "soft green chamber light is punctuated by four simultaneous orange-red eye flares", ["#08120F", "#243C33", "#567869", "#C6382A", "#EDA65D", "#66AAA0"], "A curved chamber wall contains two broad green light panels, a shadowed floor, and faint vapor.", "A folded black-green neural organism floats above three beasts at different depths: a plated larva, a long-jawed hunter, and a heavy predator. Four thin red filaments connect their foreheads, and every orange eye ignites together as the creatures turn toward the same unseen threat."),
            v("B — Memory Reclamation", "A Continuous TRAP card artwork showing the following scene: the A.I.P network extracts a dead monster's memory and returns its empty body to a vast biological archive.", "surreal technological necromancy with ordered flowing information", "violet grave light transitions into red signals and a cool cyan archive glow", ["#091310", "#253C34", "#59446A", "#C83A2C", "#E4A660", "#5AA79D"], "A subterranean archive contains one circular reclamation pool, broad vertical memory stacks, and green mist.", "A translucent monster rises from the pool as its memories separate into red luminous symbols and travel into a black-green neural mass. The emptied body sinks through a ring of dark fluid while an orange eye opens inside a distant archive cell, showing the network has stored and reused the pattern."),
            v("C — Forced Evolution", "A Continuous TRAP card artwork showing the following scene: a hive intelligence reorganizes several artificial beasts into the materials for a towering A.I.P Xyz organism.", "ritualized collective evolution with layered creature scale", "red neural pulses converge beneath a cold cyan column of transformation light", ["#07110E", "#203B31", "#4F897D", "#D43829", "#E8B66F", "#9D9C84"], "A wide laboratory pit is surrounded by simple observation tiers, broken rails, and descending green vapor.", "Three beasts leap into a cyan transformation column as their black-green bodies become dense orbiting material spheres. Above them, the shadow of a crowned many-limbed organism takes shape around one orange eye while the hive node directs every red filament into the forming body."),
        ],
    },
    {
        "card": "Caller of the A.I.P Ex",
        "card_kind": "Rank 6 DARK Beast Xyz Monster",
        "versions": [
            v("A — Ruined-City Broadcast", "A Beast-type Xyz MONSTER card artwork showing the following scene: a towering artificial caller broadcasts from a collapsed transmitter and summons lesser A.I.P beasts through a ruined city.", "commanding science-fantasy monster art with layered scale", "cold blue-gray backlight reveals black-green armor while one red pulse crosses the ruins", ["#080F0E", "#1D352E", "#465E69", "#C5362B", "#E6A25F", "#6FAAA0"], "A foggy ruined skyline surrounds a collapsed transmitter dish, a broken platform, and several distant red-black apertures.", "A tall hunched quadrupedal caller grips the transmitter with elongated forelimbs. A broad manta-like sensory hood shelters two narrow orange eyes, layered black-green plates and restrained red channels; three smaller beasts emerge through separate apertures below as one signal travels from the hood into the dish."),
            v("B — Tenfold Foresight", "A Beast-type Xyz MONSTER card artwork showing the following scene: a many-eyed artificial caller examines ten possible futures suspended above two opposing memory wells.", "occult information-control fantasy with ordered but unsettling imagery", "cyan and violet future-images orbit a dark figure lit by orange sensory nodes", ["#080F12", "#203A36", "#3E6680", "#6B4B87", "#D13B2E", "#E5A95E"], "A dark prediction chamber contains two circular memory wells, five reflections above each well, and a floor veiled in mist.", "The Caller crouches between the wells and spreads its sensory hood. Ten translucent scene fragments arc overhead in two groups of five while small orange eyes open across the hood; one long claw rearranges the nearest fragment and dense red-black material spheres orbit its chest."),
            v("C — Stolen Summoning", "A Beast-type Xyz MONSTER card artwork showing the following scene: an enemy-owned monster is reshaped into compatible material as the A.I.P Caller descends into battle.", "predatory summoning ritual with a clear theft and transformation", "a white enemy aura fractures into orange-red material beneath cold green descent light", ["#09120F", "#213B32", "#CBD0C3", "#C43B2C", "#E9A65E", "#5A9D93"], "A broken arena lies beneath a dark laboratory aperture, broad floor cracks, and low green smoke.", "A pale enemy monster is compressed into a red-black sphere as six glowing bands lock around it. The Caller descends above on elongated forelimbs, its manta hood open and orange eyes fixed on the stolen material, while a newly summoned packmate climbs from the enemy's fading shadow."),
        ],
    },
    {
        "card": "Zero Mother of the A.I.P Ex",
        "card_kind": "Rank 9 DARK Beast Xyz Monster",
        "versions": [
            v("A — Mother Emergent", "A Beast-type Xyz MONSTER card artwork showing the following scene: the colossal mother organism rises from the destroyed central laboratory with her offspring orbiting around her.", "monumental maternal bio-horror with immense controlled scale", "cold cyan light behind the ruin outlines a black-green carapace and one vast orange eye", ["#050C0A", "#172F28", "#3D6D62", "#C93229", "#E89A50", "#9D9A7E"], "A vast central laboratory opens into smoke and darkness above a tiny broken gantry and scattered containment towers.", "An immense asymmetrical cephalopod-beast lifts a heavy black-green hood over one off-center orange eye and a toothed lower maw. Six long tendrils emerge from separate sockets, each guiding a small creature-shaped red-black material orb, while two powerful front limbs crush the ruined facility below."),
            v("B — Maternal Collection", "A Beast-type Xyz MONSTER card artwork showing the following scene: the A.I.P mother seizes two enemy monsters and seals them into living material around her body.", "overwhelming capture scene with readable tendril paths and colossal weight", "two bright captive auras collapse into red-black spheres beneath a cyan storm sky", ["#050D0B", "#18342B", "#56777A", "#CF3B2B", "#ECA55D", "#C3C3AD"], "A shattered research city forms broad dark blocks below storm clouds, green vapor, and a distant laboratory crater.", "Zero Mother towers above two struggling enemy monsters. One thick tendril wraps a silver warrior and another coils around a blue dragon; both captives compress into separate spheres beside her carapace as four remaining tendrils brace against the city and her orange eye observes the collection."),
            v("C — Beast Dominion", "A Beast-type Xyz MONSTER card artwork showing the following scene: the mother organism rewrites every creature across a battlefield into members of one artificial Beast ecology.", "world-altering biological fantasy with a vast spreading transformation", "an orange-red wave radiates beneath green storm light and black celestial clouds", ["#050C09", "#18332A", "#456B5F", "#C93629", "#E9A45B", "#7F8977"], "A wide battlefield of ruins, flooded trenches, and distant towers stretches beneath the hovering mother organism.", "Zero Mother spreads six tendrils as one red biological wave crosses the land. A dragon, warrior, machine, and aquatic creature each acquire black-green armor plates, orange eyes, and Beast-like claws while retaining their original outlines; dense material spheres circle the mother's hood above them."),
        ],
    },
]


def validate() -> None:
    assert len(P) == 12
    assert sum(len(card["versions"]) for card in P) == 36
    banned = ("negative_prompt", "breathing room", "middle distance", "fully visible", "contained in frame")
    for card in P:
        assert len(card["versions"]) == 3
        for item in card["versions"]:
            prompt = item["prompt"]
            assert prompt["style_description"]["art_style"] == STYLE
            elements = prompt["compositional_deconstruction"]["elements"]
            assert len(elements) == 1 and elements[0]["bbox"] == BBOX
            serialized = json.dumps(prompt).lower()
            assert not any(term in serialized for term in banned)
            assert "a.i.p" not in serialized


def main() -> None:
    validate()
    OUT_JSON.write_text(json.dumps(P, ensure_ascii=False, indent=2) + "\n", encoding="utf-8")
    lines = [
        "# A.I.P — Three Yu-Gi-Oh-shaped artwork prompts per card",
        "",
        "All prompts use the released Ideogram 4 caption schema. Recommended baseline: main CFG `4.0`, late CFG `3.5`, LoRA `1.0`, prompt generator OFF, square 1 MP. Each version is a separate complete prompt.",
        "",
    ]
    for index, card in enumerate(P, 1):
        lines += [f"## {index}. {card['card']}", "", f"*{card['card_kind']}*", ""]
        for item in card["versions"]:
            lines += [f"### {item['version']}", "", "```json", json.dumps(item["prompt"], ensure_ascii=False, indent=2), "```", ""]
    OUT_MD.write_text("\n".join(lines), encoding="utf-8")
    print(f"Wrote {OUT_JSON}")
    print(f"Wrote {OUT_MD}")
    print("12 cards, 36 validated prompts")


if __name__ == "__main__":
    main()
