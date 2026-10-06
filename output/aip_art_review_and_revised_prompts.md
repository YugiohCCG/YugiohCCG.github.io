# A.I.P artwork deep dive and revised Ideogram prompts

## Bottom line

The LoRA is capable of convincing trading-card art. The problem is mostly prompt composition, not insufficient style learning. Image 0036, the Shrieker results around 0095–0100, the stone cyclops around 0153, and the shadow creature at 0185 work because each has one dominant silhouette, an immediate visual event, and a clear depth path. Most weaker outputs describe a subject and a setting but not a moment, so Ideogram defaults to a centered character sheet, logo, specimen display, or symmetrical poster.

The new rule is: **one card = one readable event**. Character detail belongs on the subject; environmental detail should be evidence of the event, not scenery competing for attention.

## What the 500-card reference set shows

- Monster art usually reads at thumbnail size from one main silhouette occupying roughly two-thirds of the square.
- Detail is not uniformly distributed. Faces, weapons, claws, armor breaks, spell sigils, and the impact area are sharp; distant architecture is compressed into broad value and color masses.
- Foreground elements create depth by being cropped by the artwork edge: a claw, rock, energy arc, cable, weapon, or victim. They are not a decorative border.
- Backgrounds can contain many objects, but they are grouped into two or three large shapes. Small detail is concentrated around the story clue.
- Separation is usually made with value contrast, rim light, opposing color temperature, and overlap—not photographic depth-of-field blur.
- Normal Monster art is an iconic introduction to the creature. Effect Monsters show characteristic behavior. Spells show a process or place. Traps show the instant something goes wrong.
- The local 500-image analysis found a median outer-to-central detail ratio of 0.778 overall. That does **not** mean the background should be nearly as elaborate as the subject: outer detail often comes from cropped effects, debris, secondary figures, and motion marks.

## Audit of the supplied generations

| Images | Intended card/concept | What worked | What failed | Direction |
|---|---|---|---|---|
| 0001–0010 | Zero Mother | Boss scale, red eye, recognizable black/green/red biology | Near-perfect symmetry; tentacles wallpaper the entire frame; reads as a mandala rather than a creature in a world | Three-quarter body, off-center eye, six purposeful tendrils, small environmental scale clue |
| 0011–0020 | Caller | Readable red eyes and summoning motif | Generic humanoid demon; flat poster silhouette; repetitive city bars and triangular rays | Non-human sensory beast, low-angle arrival, summoned creatures at different depths |
| 0021–0030 | Hive Mind | Clean eye focal point; controlled palette; 0021/0023/0026 are readable | Floating logo/brain emblem; static and centered; no evidence of a continuing network | Three linked beasts plus a smaller off-center neural organ; triangular action composition |
| 0031–0040 | Assimilation | 0036 has the strongest A.I.P action, anatomy, depth, and impact sparks | 0031–0032 are hard failures; several valid images use too many equal-width cables and lose the before/after transformation | Keep the 0036 energy, but show a visibly original half and assimilated half; limit foreground tendrils |
| 0041–0050 | Failures | Containment narrative, green laboratory identity, strong observer silhouettes in 0044 | Bright diagonal red bar is interpreted literally; specimen often looks merely displayed, not trapped by an effect | Show a capture/attachment event with separate victim and absorber; no warning stripe or glass-circle framing |
| 0051–0060 | A.I.P Lab | Plausible space, strong central depth, coherent industrial palette | Ten versions of the same symmetrical corridor and central tube; too much shelving; no memorable incident | Asymmetrical breached research floor with multiple depth zones and one active containment failure |
| 0061–0070 | Predator | Powerful mass and readable claws | Generic hunched videogame beast; same front-facing pose; red impact stripe becomes a repeated graphic footer | Stalking three-quarter quadruped, one paw crossing foreground, backlit breach behind it |
| 0071–0080 | Maw | Strong simple mouth motif and serpentine movement | Becomes an abstract hose/tunnel; nearly every image is a centered circular opening | Give it a head, eye, shoulders, and a readable S-curved body; jaw is the focal feature, not the whole composition |
| 0081–0090 | Claw | Oversized claw reads immediately; 0086 has useful motion | Generic muscular humanoid; repeated frontal leap; multiple claws merge; identical red ground burst | Lateral pounce with one dominant crescent foreclaw and a clean negative-space gap around it |
| 0091–0100 | Shrieker | 0095 is the best dramatic close-up; broken glass and the open throat create a real event | Four hard failures; the white circular ring resembles a bubble/logo; some variants become cute mascot creatures | Keep the mouth and shockwave, remove the complete circle, show an asymmetric cone of distortion |
| 0101–0110 | Larva | 0104–0110 preserve the pillbug identity and lab palette | Hard failures and unrelated portraits; surviving results are static product shots with little personality | Small creature actively escaping a tray, with one close foreground tool and a restrained lab backdrop |
| 0111–0120 | Misstakes | 0117–0120 finally establish a creature and an accident | Six hard semantic failures: portraits, apparel, safety blocks; lore-heavy wording likely scattered attention | Describe one precise origin incident, not the archetype history; no humans as the central subject |
| 0121–0128 / 0241–0248 | Storm woman | Palette and lightning are coherent | Centered fashion pose, ribbon border, lightning wallpaper | Make the lightning perform one action and use the landscape as consequence |
| 0129–0136 / 0235–0240 | Storm serpent | Excellent long silhouette and elemental identity | Same flat coil over the same volcano; weak foreground and scale | Let one body segment cross the foreground while the head strikes into depth |
| 0137–0144 / 0227–0234 | Hairy shepherd | Readable design and comic character | Model-sheet stance, pasted sheep silhouettes, little narrative | Show a funny task or mishap with one sheep in foreground and the giant reacting |
| 0145–0152 / 0218–0226 | Tree mother | Attractive palette and ornamental identity; 0152 is clean | Symmetrical icon, cutout/transparent-looking backgrounds, ceremonial portrait rather than card event | Use her spiral as an active magical process within a real grove |
| 0153–0160 / 0209–0217 | Stone cyclops | One of the strongest sets: low-angle scale, warm/cool separation, foreground figures, forward motion | Repetitive anatomy and camera; some versions too clean and toy-like | Preserve this compositional grammar; vary gesture and asymmetry, add stone chips and cast shadows |
| 0161–0168 / 0201–0208 | River comb maiden | Hair provides a distinctive graphic shape | Pin-up crop, empty waterline, little depth, inconsistent mythic identity | Put the combing action into a dangerous river event and add a foreground reflection/current |
| 0169–0176 / 0195–0200 | Stone bearer | Strong mythic task and scale | Nearly symmetrical doorway; pale empty sky; repetitive frontal approach | Oblique camera, one collapsing upright, foreground rubble, landscape visible through one side |
| 0177–0194 | Shadow beast | 0185 has superb silhouette economy, red-eye focal point, and portal-to-creature depth | Internal anatomy disappears into solid black; many versions read as logos; strong symmetry | Retain the silhouette but reveal two or three internal planes with rim light and make the arrival asymmetric |

## Generation grammar to use from now on

Write prompts in this order:

1. **Style trigger and deliverable:** `hclar52 card illustration, artwork only`.
2. **Subject identity:** species, anatomy, material, and the two or three recurring A.I.P identifiers.
3. **One present-tense event:** lunges, ruptures, converts, calls, captures, or awakens.
4. **Camera and crop:** low three-quarter, high oblique, profile, close-up; state what crosses the edge.
5. **Foreground:** at most two or three large cropped elements.
6. **Midground:** the subject and impact point, highest contrast and sharpest detail.
7. **Background:** two or three broad masses plus one story clue, lower contrast and fewer edges.
8. **Lighting and palette:** identify the key light, rim light, and accent color.
9. **Exclusions:** no card frame, title, writing, logos, diagram, centered emblem, decorative border, split panel, or photorealism.

Recommended visual budget: subject 65–75%, active effects/foreground 15–25%, scenic background 10–15%. Do not ask for “an extremely detailed background.” Ask for a specific but simplified environment.

## Full revised copy-paste prompts

### 1. The Misstakes of the A.I.P Experience

```text
hclar52 card illustration, artwork only. A single newly activated artificial creature escapes during the first failed Anti-Invasion Protocol experiment: a small crouching beast with glossy black-green synthetic hide, uneven armor-like folds, one large luminous red-orange eye, thin red energy channels beneath the surface, four grasping limbs and an unfinished trailing tail. It climbs out of a ruptured specimen basin toward the viewer, alert and unpredictable rather than cute. Low three-quarter camera near floor level; one wet foreclaw and a broken restraint cable cross the lower edge as foreground depth. The creature occupies about two-thirds of the image and has the sharpest detail. Behind it, a broad pale-green laboratory wall, one shattered observation window and two tiny alarm-lit technician silhouettes are simplified into low-contrast shapes. Sickly green overhead light, hot red-orange glow from the basin, small glass fragments and liquid droplets concentrated around the escape point. Polished dramatic fantasy trading-card rendering, crisp anatomy, controlled detail and a clear silhouette. Artwork without a card frame, title, letters, readable signs, logo, collage, split screen, apparel mockup, portrait photography or decorative border.
```

### 2. A.I.P Ex Larva

```text
hclar52 card illustration, artwork only. A small A.I.P larva scuttles out of a cracked steel specimen tray: a low pillbug-like artificial beast with seven overlapping black-green shell plates, narrow glowing red seams, one recessed red-orange eye, many short hooked feet and a little smear of translucent green nutrient gel beneath it. Show it in active motion, body bent into a shallow curve as the front legs grip the table edge and the rear plates are still emerging from the tray. High oblique close camera; a cropped forceps and one broken glass vial sit large in the lower foreground, leading toward the larva. The larva is the only main subject and occupies roughly sixty percent of the composition. Background is a restrained laboratory bench with two broad shadowed cabinets and one soft monitor glow, without tiny labels or shelves full of objects. Cool green ambient light, warm red rim light along the shell seams, crisp focus on eye and front legs, fewer edges in the background. Polished fantasy TCG creature art, slightly uncanny and clever rather than adorable. Artwork without a card frame, title, writing, logo, human portrait, product-shot white background, perfect symmetry or decorative circle.
```

### 3. A.I.P Ex Shrieker

```text
hclar52 card illustration, artwork only. A squat reptilian A.I.P beast releases a powerful sonic cry inside a damaged laboratory: segmented black-green hide, glowing red channels, one bulging orange eye, powerful forelimbs and an impossibly deep vertical mouth lined with irregular ivory fangs. Extreme low three-quarter close-up as the head twists toward the upper left and the open throat becomes the focal point. The creature fills about seventy percent of the image, but one shoulder and one claw remain visible so it reads as a beast rather than a floating mouth. An asymmetric cone of compressed air erupts from the jaws, bending dust and sending several large glass fragments past the camera without forming a complete circular bubble. Foreground fragments are cropped at the left and lower edges. Background is only a cracked green wall, one dark pipe bank and a soft cyan emergency light, all lower contrast. Orange throat light, cyan rim light, sharp face and teeth, motion streaks only along the sound direction. Dramatic polished trading-card illustration, energetic and imposing. Artwork without a card frame, words, logo, full circle, centered emblem, cute mascot proportions or photographic blur.
```

### 4. A.I.P Ex Claw

```text
hclar52 card illustration, artwork only. A lean six-limbed A.I.P hunting beast pounces sideways through a breached research corridor. Its body has overlapping black-green muscle plates, thin glowing red channels, a narrow predatory skull, one red-orange eye and a swept-back armored mane. Its defining feature is one enormous crescent foreclaw made of four long pale metallic talons. Dynamic low three-quarter camera: the beast travels from upper right toward lower left while the dominant claw sweeps across the near foreground and is partly cropped by the left edge; the second claw stays behind the torso and does not overlap the first. Keep a clean pocket of negative space around the main talons so their silhouette reads instantly. Small floor fragments and one red spark fan mark the contact point without creating a graphic stripe across the bottom. Background consists of two broad corridor wall planes and one receding doorway in muted gray-green, with sparse cables and simple shelving. Hard white rim light on the talons, deep green body shadows, controlled red accents. Polished fantasy TCG action art, crisp anatomy and strong foreshortening. Artwork without a card frame, title, writing, logo, frontal bodybuilder pose, extra claws, decorative border or flat beige backdrop.
```

### 5. A.I.P Ex Maw

```text
hclar52 card illustration, artwork only. A massive serpentine A.I.P beast rises through a fractured laboratory floor: a readable head and upper torso with black-green segmented armor, glowing red channels, one recessed orange eye, small gripping forelimbs and a huge side-opening jaw filled with uneven ivory teeth. The thick body forms one clear S-curve from the lower foreground to the head in the upper-right third; it must look like a living creature rather than a detached hose or circular tunnel. Three-quarter side view with the jaw turning toward a small distant silhouette at the left edge. One body coil and two pieces of broken flooring are cropped in the foreground to establish depth. The mouth is the highest-contrast focal area, lit from within by dull orange biological light. Background is a simple pale concrete chamber with one cracked wall opening and distant green vapor, grouped into broad low-detail masses. Dust and debris follow the creature’s upward motion, leaving clear negative space around the head. Polished dramatic fantasy trading-card art, precise silhouette and muscular motion. Artwork without a card frame, writing, logo, centered circular mouth, repeated pipe pattern, decorative ring, flat profile diagram or photorealism.
```

### 6. A.I.P Ex Predator

```text
hclar52 card illustration, artwork only. The apex A.I.P predator stalks out of a torn laboratory breach into cold rain: an enormous low quadrupedal beast with a black-green armored hide, red biological channels, a wedge-shaped skull, two small orange eyes, layered dorsal spines, long forearms and heavy hooked claws. It is powerful but unmistakably animal rather than a muscular humanoid. Low ground-level three-quarter camera; one planted forepaw dominates the lower-right foreground and is partly cropped, while the head sits off-center in the upper-left third and watches the viewer. The arched back and trailing tail create a diagonal depth line into the breached doorway. Behind it are only two broad masses: a hot orange laboratory interior and a cool blue-gray rain-filled exterior, with one tiny overturned containment cart for scale. Rain catches the rim light; red channels glow subtly rather than outlining every muscle. Keep face, paw and shoulder sharp, with reduced edge density in the background. Premium fantasy TCG boss-monster illustration, imposing and controlled. Artwork without a card frame, title, letters, logo, frontal crouching bodybuilder, red graphic footer, extra limbs, dense rubble wallpaper or photographic blur.
```

### 7. A.I.P Lab

```text
hclar52 card illustration, artwork only. An oblique cutaway view of the abandoned Anti-Invasion Protocol laboratory at the exact moment containment begins to fail. The composition is environmental rather than a monster portrait. A ruptured cylindrical chamber sits off-center in the middle distance, spilling green nutrient fluid across a grated floor; thick black-green organic growth with faint red veins has spread across one wall and bends a bank of pipes toward the chamber. In the lower foreground, a cropped overturned instrument cart and two wet cable loops lead the eye inward. On the far side, one tiny technician silhouette stands behind a wide observation window, providing scale. Build the room from three large value masses: dark foreground machinery, a pale green central work floor and a deep shadowed rear wall. Only the ruptured chamber and spreading organism receive fine detail; distant shelves are suggested as broad rectangles. Sickly overhead green light, red emergency reflections and white vapor around the breach. Cinematic fantasy TCG Field Spell artwork with strong spatial depth and a discoverable story. Artwork without a centered hallway, perfect bilateral symmetry, building facade, readable sign, card frame, title, writing, logo, endless shelves or monster posing at the camera.
```

### 8. Failures of the A.I.P

```text
hclar52 card illustration, artwork only. An unstable artificial beast is converted into glowing material inside the A.I.P laboratory. The pale quadrupedal subject stands on the left, clearly separate from the conversion organism, with one foreleg braced against the floor and one brightly illuminated eye. From the right, a compact black-green A.I.P organism with a red central eye surrounds the subject with several broad ribbon-like streams of dark energy and glowing red nodes, drawing the streams toward a dense floating material orb. Use a strong diagonal action from the lower-left subject toward the upper-right orb without placing a solid stripe across the picture. One open restraint ring and several floor fragments are cropped along the lower foreground. Background is a subdued laboratory wall with one observation window and a soft green alarm glow, kept simple and low contrast. The energy boundary and the two eyes are the sharpest areas; the rest falls into grouped shapes. Dramatic Trap Card snapshot with polished fantasy trading-card rendering. Artwork without a specimen calmly floating in a tube, full glass circle, card frame, title, words, logo, warning bar, split panel or decorative border.
```

### 9. A.I.P Ex Assimilation

```text
hclar52 card illustration, artwork only. An armored automaton is being assimilated into an A.I.P Ex creature during a dramatic transformation. Show one continuous figure with a readable before-and-after boundary: the left half still has pale angular mechanical armor and an articulated mechanical hand, while the right half has become glossy black-green artificial muscle, a predatory jaw, one glowing orange eye and thin red energy channels. The altered arm reaches forward as two thick segmented tendrils wrap the torso; use only two major tendrils, each following a different curve. Dynamic three-quarter crouch inspired by image 0036, body turned across the frame from upper left to lower right. One cable and the transformed hand cross the lower foreground; orange sparks appear only at the shoulder and waist where conversion is occurring. Background is a broad gray ruined-city silhouette with one pale smoke mass, quiet enough to preserve the figure. Strong cool rim light on original armor, hot red-orange light at the assimilation boundary, crisp anatomy and visual impact. Premium fantasy TCG Trap artwork without a card frame, title, writing, logo, tentacle wallpaper, complete circles, duplicated body, symmetrical pose or overly detailed skyline.
```

### 10. A.I.P Ex Hive Mind

```text
hclar52 card illustration, artwork only. Three different A.I.P beasts are synchronized by a living neural organism in a dark laboratory chamber. Place the small floating organism off-center in the upper-right third: a folded black-green organic mass with one red-orange eye and only four short tendrils. Below it, arrange three clearly separated beast heads at different depths in a loose triangle—a larval pillbug near the lower edge, a long-jawed shrieker at left and a larger armored predator receding at right. Thin red pulses travel along sparse translucent filaments from each forehead to the organism, and all four eyes illuminate at the same instant. One nearby filament and part of the larva shell are cropped by the foreground edge to create depth. Background is a single curved chamber wall with two broad green light panels and faint vapor, without rows of equipment. Concentrate sharp detail on the eyes and pulse junctions; keep ample dark negative space between silhouettes. Continuous Trap Card artwork, eerie coordinated intelligence and polished fantasy TCG rendering. Artwork without a centered emblem, floating logo, isolated organ on an empty background, perfect symmetry, decorative circle, card frame, title or writing.
```

### 11. Caller of the A.I.P Ex

```text
hclar52 card illustration, artwork only. A non-human A.I.P caller emerges above a collapsed broadcast platform and calls lesser beasts from the ruined city below. The caller is a tall hunched quadrupedal creature with elongated forelimbs, a broad manta-like sensory hood, layered black-green synthetic hide, two narrow red eyes and several restrained red channels visible inside the shadows. Low-angle three-quarter camera looking upward; the caller steps from the upper-left darkness toward a circular transmitter dish in the lower foreground, with one long hand gripping its rim. A pale blue-gray backlight reveals two or three internal body planes and keeps the silhouette readable, echoing the atmosphere of image 0185 without turning the creature into solid black. On the right and far lower background, three small A.I.P beasts appear through uneven red-black apertures at different distances. The skyline is only a few broad vertical shapes behind fog. Strong rim light, one red pulse traveling from caller to dish, sharp hands and eyes, controlled negative space. Premium Xyz boss-monster TCG art without a humanoid demon, cloak, triangular laser poster, perfect symmetry, full black silhouette, card frame, title, writing or logo.
```

### 12. Zero, Mother of the A.I.P Ex

```text
hclar52 card illustration, artwork only. Zero, the colossal mother organism of the A.I.P Ex, rises from the ruined central laboratory. She is an immense asymmetrical cephalopod-beast with a heavy black-green maternal carapace, one large red-orange eye set off-center beneath a layered hood, a toothed lower maw, powerful front limbs and six long tendrils emerging from distinct sockets. Show her in three-quarter profile rather than facing straight forward. Two tendrils arc into the near foreground and are cropped by opposite edges; the other four reach toward separate floating creature-shaped energy fragments, gathering them into small red-black material orbs around her body. Keep each tendril readable and leave negative space between them. A tiny broken laboratory gantry and several pin-sized distant figures at the lower-left establish enormous scale. Background is a simple smoke-filled chamber opening with one cold cyan backlight and broad ruined wall shapes; it must not compete with the mother. Highest detail and contrast on the eye, hood, maw and nearest grasping limb, with restrained red channels elsewhere. Monumental premium fantasy Xyz card illustration without perfect radial symmetry, mandala composition, tentacle wallpaper, centered floating eye, decorative ring, card frame, title, writing, logo or dense city detail.
```

## Selection workflow

Generate six seeds per card, then reject any result that fails one of these thumbnail tests:

1. At 128 px, can the subject and its action be named in two seconds?
2. Is there exactly one primary focal point and at most one secondary focal point?
3. Can the main silhouette be traced without merging into the background or another limb?
4. Does the foreground create depth rather than form a decorative border?
5. Does the background contain one useful story clue while remaining grouped into broad shapes?
6. For Spells and Traps, does the image show an event or location instead of another posed monster portrait?
7. Is all accidental text, circular logo framing, transparent-looking background, and literal prompt graphic absent?

For revision passes, change only one category at a time: camera, gesture, foreground prop, or lighting. Do not rewrite the creature identity on every seed, or the archetype will drift.
