#!/usr/bin/env python3
"""Write the manually reviewed captions for duplicate-artwork replacements."""

from __future__ import annotations

import json
from pathlib import Path


ROOT = Path(__file__).resolve().parents[1]
CAPTIONS = ROOT / "output" / "yugioh_ideogram4_500" / "captions"


def caption(prefix, scene, aesthetics, lighting, art_style, palette, background, elements):
    return {
        "high_level_description": f"{prefix} card artwork showing the following scene: {scene}",
        "style_description": {
            "aesthetics": aesthetics,
            "lighting": lighting,
            "medium": "illustration",
            "art_style": f"hclar52 card illustration, {art_style}",
            "color_palette": palette,
        },
        "compositional_deconstruction": {
            "background": background,
            "elements": [
                {"type": "obj", "bbox": bbox, "desc": desc}
                for bbox, desc in elements
            ],
        },
    }


DATA = {
    "ygo4_0195": caption(
        "A Pyro-type MONSTER",
        "a colossal salamander-like volcanic beast rears from molten rock, its craggy armor split by brilliant yellow magma and tipped with glowing crystal spikes.",
        "colossal elemental creature design, molten geology, and dramatic subterranean fantasy action",
        "intense yellow-orange magma shines through the beast and reflects across dark stone while cool turquoise cavern haze rims its silhouette",
        "bold digital fantasy painting with faceted rock textures, high-contrast lava glow, and exaggerated monster anatomy",
        ["#2A2421", "#FFB000", "#FFF02A", "#E34B12", "#176E70", "#74B7AA", "#6E655F"],
        "A vast teal-green cavern surrounds an erupting volcanic cone, with suspended embers, smoky mineral haze, jagged walls, and a bright river of lava crossing the foreground.",
        [([70, 0, 1000, 1000], "A gigantic four-legged rock salamander dominates the frame with a long arched neck, blunt armored head, broad clawed feet, and a heavy segmented tail. Charcoal stone plates encase a brilliant molten-yellow body, while triangular crystal spikes and glowing fissures repeat along its limbs, shoulders, jaw, and back.")],
    ),
    "ygo4_0197": caption(
        "A Pyro-type MONSTER",
        "a gloomy anthropomorphic candle stands inside a ritual chamber while a huge two-toned fire spirit rises from its wick with a menacing grin.",
        "whimsical occult character art balancing cute proportions with theatrical supernatural menace",
        "hot yellow and orange fire illuminates the upper chamber while violet-blue flame colors the lower spirit and pale candle body",
        "polished anime fantasy illustration with soft gradients, crisp outlines, symmetrical staging, and luminous flame effects",
        ["#FFF0A4", "#FF9A16", "#E74525", "#4A20D8", "#7A3CC8", "#E7E3DF", "#24142E"],
        "A symmetrical ceremonial hall has purple curtains, carved dark panels, paired flaming braziers, and a circular floor sigil drawn in fine cream-colored geometric lines.",
        [
            ([40, 120, 620, 890], "A large hovering flame spirit has a blazing yellow-orange head, heavy black eyes, a hooked nose, a wide shadowed mouth with jagged teeth, and raised flame-shaped arms. Its muscular lower half transitions into saturated violet and cobalt fire before narrowing into a short twisted wick."),
            ([570, 270, 1000, 750], "A squat white candle creature stands below the spirit with wax dripping over its rounded body, tired red eyes, a downturned mouth, tiny arms, and flattened feet. Its central wick emerges from a shallow opening at the top and aligns directly beneath the hovering apparition."),
        ],
    ),
    "ygo4_0200": caption(
        "A Pyro-type MONSTER",
        "three sticker-like cartoon firefighters with flaming hair strike different angry, confident, and shouting poses against a playful pink patterned field.",
        "energetic chibi character sheet, comedic expressions, pop-art patterning, and playful fire motifs",
        "flat bright illumination with warm orange flame highlights and thin white sticker borders separating every figure from the background",
        "clean cel-shaded cartoon art with thick outlines, halftone textures, graphic flames, and decorative pastel shapes",
        ["#F48AA4", "#FF6538", "#FFB53C", "#6B2F3D", "#F4E8E7", "#79D7D3", "#B34161"],
        "A layered rose-pink collage combines swirling lines, halftone patches, loose flame doodles, and scattered pastel stars in blue, green, yellow, and pink.",
        [([100, 20, 980, 980], "Three small pink-skinned firefighter mascots wear dark maroon suits, silver belts, white padded gloves, and orange forehead bands while tall orange flames replace their hair. The upper figure raises both fists confidently, the lower-left figure folds its arms and bares clenched teeth, and the lower-right figure shouts with fists lifted.")],
    ),
    "ygo4_0203": caption(
        "A Pyro-type MONSTER",
        "a luminous woman formed from living flame twists through a graceful airborne dance as sweeping ribbons of orange fire spiral around her body.",
        "elegant elemental figure study, fluid dance motion, and intensely saturated abstract fire",
        "the figure glows nearly white from within, edged by yellow and orange flames against deep crimson and violet shadows",
        "stylized digital painting with flowing calligraphic fire shapes, simplified anatomy, and sparkling particle accents",
        ["#FFF6A0", "#FFB10A", "#F05512", "#B40D25", "#511044", "#1F0B2D", "#FFD23A"],
        "A nonliteral vortex of crimson, orange, and deep violet brushlike currents fills the square field, scattered with tiny golden sparks and molten droplets.",
        [([30, 20, 1000, 940], "A slender feminine fire elemental arches diagonally in midair with one knee raised, one leg extended, and delicate hands held in a dancer's pose. Her glowing face, torso, and limbs are pale yellow-white, while long streaming hair and a short swirling skirt dissolve into layered orange and red flames.")],
    ),
    "ygo4_0205": caption(
        "A Pyro-type MONSTER",
        "a massive armored magma dragon roars with both clawed fists raised while rings of fire and exploding lava surround its airborne body.",
        "aggressive kaiju-scale battle art, heavy lava-forged armor, explosive motion, and overwhelming heat",
        "incandescent yellow fire backlights dark blue, olive, and rust-red armor while sharp red energy rays radiate from the center",
        "detailed anime monster illustration with layered mechanical-organic plates, hard inked edges, molten cracks, and explosive effects",
        ["#263048", "#6F744A", "#7B2927", "#FFB313", "#F14A12", "#C7CED3", "#2B0C12"],
        "A chaotic red-orange eruption fills the background with radiating energy lines, floating black debris, lava-veined rocks, and multiple circular firebursts.",
        [([30, 30, 1000, 980], "A towering bipedal dragon has a long blade-shaped snout, open fanged jaws, angular navy armor, olive chest plates, rust-red forearm guards, silver claws, and broad pointed wings. It lunges forward with both fists raised as fiery orbs orbit its shoulders, waist, and segmented tail above fractured lava rock.")],
    ),
    "ygo4_0208": caption(
        "A Pyro-type MONSTER",
        "a hulking rose-gold armored giant strides through spectral flames while enormous translucent skeletal hands reach inward around his horned crown.",
        "ominous imperial giant, supernatural armor, crushing forward motion, and infernal ghost imagery",
        "orange fire glows from below and through armor seams while cold violet-white spectral light outlines the surrounding skulls and hands",
        "high-detail anime fantasy painting with monumental foreshortening, polished metal plates, sparks, and translucent spirit effects",
        ["#B97672", "#E9A8A0", "#17131B", "#D0A65A", "#FF5A22", "#B9A5F2", "#59D8D2"],
        "A turbulent violet-black void burns with red-orange sparks and flames as ghostly skulls, clawed hands, and a huge curved metallic structure encircle the central giant.",
        [([20, 10, 1000, 990], "A broad muscular humanoid advances toward the viewer in massive rose-gold plate armor with spiked forearms, dark engraved joints, a black waistcloth, clawed gold fingertips, and a tall horned helmet. Green gemstones glow at his abdomen and overhead while translucent skeletal hands hover beside his shoulders and spectral skulls curl through the flames below.")],
    ),
    "ygo4_0271": caption(
        "A Warrior-type MONSTER",
        "a silent blue-and-silver swordsman stands poised with an enormous riveted blade as looping bands of icy light and starbursts sweep around him.",
        "heroic armored duelist portrait, restrained confidence, crisp metallic design, and magical winter atmosphere",
        "bright cyan-white backlight and lavender star flares gleam across silver armor, deep blue cloth, and the polished oversized sword",
        "clean anime card illustration with precise armor linework, smooth cel shading, luminous ribbons, and sparkling highlights",
        ["#182151", "#49558B", "#C9CED6", "#F2F5F8", "#7BCEE2", "#AF81DB", "#D1A03A"],
        "An abstract midnight forest and icy blue magical haze are crossed by wide white-violet energy ribbons, frostlike particles, and sharp four-pointed stars.",
        [([20, 20, 1000, 980], "A lean blond warrior wears a closed silver helmet with a long blade-like crest, layered navy armor edged in riveted steel, pointed gauntlets, fitted greaves, and a flowing split coat with white and gold panels. He extends one open hand while holding a massive broad silver sword diagonally through the foreground.")],
    ),
    "ygo4_0342": caption(
        "A Field SPELL",
        "a crowded prehistoric valley teems with many colorful dinosaurs running, fighting, hatching, grazing, and tumbling beneath jungle trees and pale mountains.",
        "busy storybook panorama, humorous dinosaur behavior, layered ecosystem detail, and adventurous prehistoric spectacle",
        "clear daylight from a blue sky evenly illuminates the animals and foliage, with pale atmospheric light streaking over distant mountains",
        "detailed cartoon fantasy landscape with expressive creatures, crisp outlines, varied scales, and densely staged visual vignettes",
        ["#6E9C4C", "#314F2E", "#88BFD5", "#D5D2B5", "#A45850", "#4E83A6", "#B69A5F"],
        "A lush primeval basin contains giant trees, cycads, palms, onion-shaped plants, a winding river, misty limestone peaks, a blue sky, and distant flying reptiles.",
        [
            ([450, 0, 1000, 1000], "The crowded foreground contains a long-snouted predator, a small green hatchling, a horned dinosaur beside a cracked egg, two arguing theropods, and a large armored quadruped charging out of frame. Their varied olive, tan, blue, pink, and grey bodies overlap across grass, mud, stones, and shallow water."),
            ([100, 30, 520, 1000], "Smaller prehistoric animals animate the middle and upper scene: a blue creature peers through leaves, a brown long-tailed animal tumbles through the air, and a red horned beast crashes headfirst into a pale cliff, leaving a burst of dust and broken rock around the impact."),
        ],
    ),
    "ygo4_0358": caption(
        "A Normal SPELL",
        "a blond female magician thrusts a circular golden focus forward, blasting radial beams through a cracked magenta energy sphere.",
        "iconic magical attack pose, explosive graphic impact, saturated arcade-like energy, and dynamic foreshortening",
        "a brilliant yellow-white blast shines from the foreground disc while neon pink and purple energy illuminates the figure from behind",
        "bold cel-shaded anime illustration with thick outlines, radial speed lines, jagged lightning cracks, and flat saturated color",
        ["#F3C02D", "#F6D86A", "#E73788", "#8A176F", "#2A0D50", "#E8A0B8", "#2C6C94"],
        "A dark violet and magenta radial burst converges behind a large translucent rose-colored sphere fractured by jagged electric cracks and pierced by wide yellow rays.",
        [([80, 0, 1000, 660], "A young blond spellcaster lunges diagonally in a pink sleeveless tunic, blue conical hat and boots, gold-trimmed wrist guards, and a flowing rose sash. She braces one arm behind her while aiming an oversized circular golden magical focus directly toward the viewer, creating strong foreground foreshortening and a white-hot central flare.")],
    ),
    "ygo4_0387": caption(
        "A Quick-Play SPELL",
        "two female magicians cast together as a dark violet energy mass tears open amid branching lightning, radiant beams, and a glowing floor sigil.",
        "cooperative spellcasting action, layered character silhouettes, violent magical discharge, and high-speed impact",
        "white-gold rays and blue-violet lightning burst from the right, casting strong highlights across purple, blue, and pink costumes",
        "dynamic cel-shaded anime art with sharp motion streaks, overlapping figures, electrical arcs, and luminous magic-circle geometry",
        ["#251448", "#51307B", "#37608A", "#E5A4C4", "#F0C563", "#8A56F0", "#E9F6FF"],
        "A dark abstract battle space is filled with teal and gold speed streaks, branching lavender lightning, flying sparks, black-violet energy clouds, and a bright geometric circle across the lower right.",
        [
            ([220, 0, 1000, 700], "A blond female spellcaster in a blue pointed hat, short blue-and-pink dress, high boots, gold ornaments, and a flowing dark cape leaps forward. She grips a curved staff with both hands and directs its golden spiral tip into a crackling violet-black mass at the right side of the scene."),
            ([60, 40, 690, 630], "A second spellcaster in dark purple segmented armor and a tall pointed helmet appears immediately behind the blond caster. Her pale open hand reaches toward the left edge while her other arm extends into the shared attack, creating a synchronized two-person casting pose amid crossing light streaks."),
        ],
    ),
    "ygo4_0392": caption(
        "A Quick-Play SPELL",
        "a sleek white biomechanical dragon opens its jaws and releases a concentrated torrent of blue-white light across the frame.",
        "close-up mechanical dragon attack, polished futuristic anatomy, and overwhelming directed energy",
        "the breath beam burns white at its core with cyan edges, reflecting across silver armor and contrasting with a blurred red-green backdrop",
        "clean cel-shaded anime illustration with chrome highlights, smooth armor contours, tight cropping, and layered luminous beam streaks",
        ["#E9F5F5", "#A9CED1", "#40BFE3", "#2A5364", "#40366E", "#8F343A", "#17443E"],
        "A heavily blurred field of dark green, maroon, black, and violet motion bands isolates the dragon and emphasizes the horizontal force of its attack.",
        [([0, 0, 1000, 1000], "A large serpentine mechanical dragon fills the composition with white-silver armor, teal ribbed insets, dark blue neck segments, purple oval shoulder nodes, swept horns, and narrow golden eyes. Its head turns right with jaws open as multiple parallel blue-white energy streams and curved white shock lines erupt outward beyond the image edge.")],
    ),
    "ygo4_0425": caption(
        "A Continuous TRAP",
        "a monumental stone tablet bearing a cyan line drawing of a staff-wielding armored magician rises inside a dark temple corridor.",
        "solemn ancient relic, mystical archaeological atmosphere, monumental symmetry, and restrained supernatural tension",
        "a cold turquoise aura burns around the slab while low pale mist rises from below and faint golden motes punctuate the darkness",
        "atmospheric fantasy illustration with weathered stone textures, minimal composition, glowing engraved lines, and cinematic haze",
        ["#151510", "#4A4638", "#7E745E", "#36C6C5", "#83E5DC", "#D7D5B7", "#756A2B"],
        "A tall shadowed temple passage recedes behind the relic, bordered by massive green-grey masonry walls, deep black ceiling space, drifting ground fog, and sparse floating gold sparks.",
        [([120, 240, 960, 770], "A huge upright rectangular sandstone slab stands centered on a thick base, its chipped edges, hairline cracks, stains, and recessed border showing great age. Fine cyan-blue grooves depict a frontal robed figure wearing a tall pointed helmet and shoulder armor, holding a long staff, with a short row of small hieroglyph-like symbols near its feet.")],
    ),
    "ygo4_0428": caption(
        "A Continuous TRAP",
        "a horned dark-haired man and a grey-haired elf girl examine a glowing circular talisman while bizarre stitched familiars crowd around them.",
        "gothic supernatural character ensemble, uneasy intimacy, dense monster details, and playful macabre charm",
        "soft lavender ambient light fills the chamber while green and cyan glows emanate from the talisman, eyes, gems, and mechanical familiar parts",
        "polished anime fantasy illustration with crisp character rendering, layered creature silhouettes, luminous accents, and ornate occult motifs",
        ["#211A38", "#3A315A", "#74679B", "#D3C5DE", "#8BCB55", "#2CD1D3", "#B53170"],
        "A translucent violet chamber contains curtains, circular occult diagrams, suspended chains, smoky bat-shaped marks, curling black tendrils, and the looming toothed silhouette of a many-horned beast.",
        [
            ([120, 140, 1000, 900], "Two pointed-eared humanoids occupy the center. A tall pale man with tousled black hair, curved horns, one spiral red eye, and a dark feathered coat leans toward a shorter grey-haired girl wearing green hornlike ornaments and a magenta hood. She presents a round brown talisman whose intricate pink-and-green center emits a smoky glow."),
            ([210, 0, 1000, 1000], "Strange familiars surround the pair: purple stitched beasts with single red eyes, metallic spikes, cyan drill-like snouts, wires, and glowing markings press in from the left and lower edge, while a small angular brown cat with a bell sits at the lower right beneath the shadow of a huge fanged creature."),
        ],
    ),
}


def main() -> int:
    for dataset_id, value in DATA.items():
        path = CAPTIONS / f"{dataset_id}.json"
        path.write_text(json.dumps(value, ensure_ascii=False, indent=2) + "\n", encoding="utf-8")
        print(path.name)
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
