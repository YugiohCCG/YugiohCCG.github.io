# The Yu-Gi-Oh Artwork Gospel

**Status:** Living evidence-based guide, version 0.1  
**Evidence base:** 500 square card artworks in the local `yugioh_ideogram4_500` dataset  
**Purpose:** Generate artwork that behaves like real Yu-Gi-Oh card art at card size, especially through Ideogram 4 with the `hclar52` LoRA  
**Rule of revision:** This document is not sacred because it is confidently written. It becomes reliable only through measured references and controlled generation trials.

---

## 1. What was actually studied

The reference set contains:

| Card group | Images |
|---|---:|
| Monsters | 300 |
| Spells | 120 |
| Traps | 80 |
| **Total** | **500** |

The Monster sample represents all 25 Monster Types present in the dataset. The Spell/Trap sample contains:

| Subtype | Images |
|---|---:|
| Normal Spell | 33 |
| Quick-Play Spell | 30 |
| Continuous Spell | 24 |
| Field Spell | 14 |
| Equip Spell | 11 |
| Ritual Spell | 8 |
| Normal Trap | 41 |
| Counter Trap | 20 |
| Continuous Trap | 19 |

The study combines:

1. A full contact-sheet review of all 500 images.
2. Larger stratified sheets for every Spell and Trap subtype.
3. Thirty compositionally diverse representatives from each major category.
4. Image measurements at a standardized size: edge density, center-to-outer detail ratio, bilateral symmetry, edge direction, luminance contrast, saturation, focal contrast and visual-attention location.
5. Comparison against the 248 recent generated images, especially the successful A.I.P transformation, Shrieker, stone cyclops and shadow-creature results.

The measurements are proxies. They cannot identify a face, sword, spell circle or narrative event. Every numerical claim was checked against the corresponding artwork sheets.

### Visual evidence sheets

- [All 300 Monsters](./art_gospel_analysis/overview_monsters.jpg)
- [All 120 Spells](./art_gospel_analysis/overview_spells.jpg)
- [All 80 Traps](./art_gospel_analysis/overview_traps.jpg)
- [Diverse Monster representatives](./art_gospel_analysis/representatives_monsters.jpg)
- [Diverse Spell representatives](./art_gospel_analysis/representatives_spells.jpg)
- [Diverse Trap representatives](./art_gospel_analysis/representatives_traps.jpg)
- [Field Spells](./art_gospel_analysis/spell_field.jpg)
- [Quick-Play Spells](./art_gospel_analysis/spell_quick_play.jpg)
- [Normal Traps](./art_gospel_analysis/trap_normal.jpg)
- [Counter Traps](./art_gospel_analysis/trap_counter.jpg)

The raw measurements are in [image_metrics.csv](./art_gospel_analysis/image_metrics.csv), and group distributions are in [group_summary.json](./art_gospel_analysis/group_summary.json).

---

## 2. The central truth: card art is designed for two viewing distances

Real artwork must succeed twice:

1. **Card-size read:** At approximately 100–150 pixels, the viewer should recognize the subject category, dominant gesture and focal effect.
2. **Inspection read:** At full size, the viewer discovers costume construction, anatomy, smaller actors, environmental clues and rendering texture.

Generated art often reverses this priority. It supplies hundreds of interesting details but no readable first impression. The correct hierarchy is:

> **Silhouette first → gesture second → focal accent third → supporting story fourth → surface detail last.**

If a picture only becomes understandable after zooming in, it is not yet successful card art.

---

## 3. The five-layer construction model

Think of every artwork as five functional layers. These are visual roles, not necessarily separate JSON objects.

### Layer 1: the silhouette

The main subject needs a recognizable outer contour. Wings, weapon, hair mass, shell, jaw, cloak, tail or pose should distinguish it before internal details are read.

Good silhouettes contain:

- One dominant mass.
- One or two characteristic extensions.
- Negative-space gaps between important limbs, weapons, wings or tendrils.
- A directional lean, curve or stance.

Bad silhouettes contain:

- Every limb overlapping the torso.
- Tendrils evenly distributed like a decorative sunburst.
- A character and background sharing the same edge density and value.
- A creature reduced to a round emblem, floating head or centered mouth.

### Layer 2: the gesture or event

A pose becomes card art when it has a verb. Useful verbs include:

`lunges`, `turns`, `descends`, `erupts`, `guards`, `conducts`, `summons`, `splits`, `intercepts`, `awakens`, `transforms`, `observes`, `opens`, `binds`, `deflects`.

Use one primary verb. A second verb may describe the response or consequence. More than two strong actions usually create a montage.

### Layer 3: the focal accent

Most references have one concentrated attention point:

- Face or eyes.
- Weapon contact.
- Open jaw or casting hand.
- Central object.
- Barrier collision.
- Portal center.
- Transformation boundary.

The focal accent is often brighter, warmer, sharper or more saturated than its surroundings. It does not have to sit at the geometric center. Across all 500 images, the median distance between the strongest local attention peak and the center was approximately **0.33 of the normalized canvas**, rising to **0.38 for Traps** and **0.42 for Quick-Play Spells**. Exact values are metric-dependent, but the visual conclusion is robust: strong accents frequently sit away from dead center.

### Layer 4: depth support

Depth usually comes from overlap and scale:

- A foreground body part, weapon, rock, energy arc or prop is cropped by an edge.
- The main subject occupies the middle ground.
- A smaller figure, building, horizon or repeated object supplies scale in the distance.

Foreground content should point inward or continue the action. It should not create a horizontal footer, circular border or evenly spaced frame.

### Layer 5: the background shell

The background establishes place, atmosphere and contrast. It should answer only the questions needed by the card:

- Where is this happening?
- What scale is the subject?
- What caused or resulted from the event?
- What color/value field best separates the subject?

It is not an inventory of everything that could exist in the location.

---

## 4. What the measurements say

Values below are medians. They should be treated as comparative evidence, not prompt targets.

| Group | Edge density | Outer ÷ central edges | Symmetry | Diagonal edge share | Luminance contrast | Saturation |
|---|---:|---:|---:|---:|---:|---:|
| All 500 | 0.239 | 0.886 | 0.779 | 0.463 | 0.229 | 0.394 |
| Monsters | 0.248 | 0.871 | 0.776 | 0.465 | 0.227 | 0.391 |
| Spells | 0.226 | 0.897 | 0.789 | 0.459 | 0.230 | 0.405 |
| Traps | 0.234 | 0.893 | 0.780 | 0.461 | 0.236 | 0.408 |
| Field Spells | 0.178 | 0.890 | 0.863 | 0.381 | 0.201 | 0.438 |
| Quick-Play Spells | 0.236 | 0.898 | 0.748 | 0.459 | 0.244 | 0.366 |
| Normal Traps | 0.237 | 0.887 | 0.795 | 0.474 | 0.236 | 0.404 |
| Counter Traps | 0.234 | 0.906 | 0.777 | 0.444 | 0.247 | 0.399 |

### Interpretation

1. **The outer frame is active, not empty.** The outer-to-central edge ratio is usually below 1.0, so the center tends to be denser, but the border still carries substantial visual information. In successful art this comes from cropped wings, weapons, bodies, terrain and effects—not uniformly detailed scenery.
2. **Perfect symmetry is exceptional.** General Monster, Spell and Trap art is only moderately symmetrical. Field Spells and Ritual imagery use symmetry more often because architecture, altars and magical systems benefit from it.
3. **Diagonal energy is normal.** Almost half of strong edge energy belongs to diagonal orientations. This is produced by poses, weapon arcs, wings, speed lines, beams and perspective—not by adding arbitrary diagonal streaks.
4. **Field Spells are quieter.** They have lower edge density, lower contrast and lower diagonal energy. Their interest comes from space, scale, atmosphere, architecture and a clear landmark.
5. **Reactive cards use stronger focal separation.** Traps, especially Counter Traps, separate their brightest event from the rest of the image more strongly than Monsters do.
6. **There is no mandatory saturation level.** The middle half of the entire dataset spans roughly 0.305–0.498 mean saturation. Both restrained silver/white art and extremely saturated fire or neon art are authentic.

### Common hue families

The most frequent dominant hue bins were azure/blue, red, orange and cyan. This does not mean every image should use them. It reflects recurring energy, sky, water, fire and magical-light motifs. The stronger transferable rule is **hue separation**, not a fixed palette.

---

## 5. Composition families found across the set

Official artwork repeatedly uses a small set of composition families, then varies character design and rendering inside them.

### A. Iconic introduction

One creature or character is presented clearly, often centered or slightly offset. The pose may be quiet, but one design idea dominates.

Use for:

- Low-level creatures.
- Mascots.
- Relics and machines.
- Normal Monsters.
- Characters whose identity matters more than an attack.

Required safeguard: the background must support the character's silhouette and personality. “Standing in a place” is insufficient.

### B. Diagonal attack

The torso, weapon, limb or energy path travels corner-to-corner. One object is often foreshortened and cropped.

Use for:

- Aggressive Effect Monsters.
- Quick-Play Spells.
- Normal Traps.
- Transformation and impact scenes.

Required safeguard: the diagonal must come from the action. A diagonal red stripe placed behind a static figure is graphic decoration, not motion.

### C. Arc, coil or flight path

Dragons, serpents, wings, ribbons and projectiles produce C-curves or S-curves. The curve guides the viewer from foreground to focal head or impact.

Required safeguard: preserve negative space within the curve. A closed loop becomes a logo or tunnel.

### D. Confrontation

Two subjects face, collide, bind or oppose each other. The space between them becomes the focal point.

Use for:

- Traps.
- Quick-Play Spells.
- Lore moments.
- Rival or fusion imagery.

Required safeguard: establish a dominant subject and a reacting subject. Equal-size mirrored figures often look like a versus poster.

### E. Transformation boundary

One subject changes material, form or allegiance. The boundary between states is the focus.

Required safeguard: preserve readable “before” and “after” regions. Covering the whole body with the new material only shows a finished creature.

### F. Object or emblem

A weapon, book, shield, machine, artifact or magical symbol dominates the frame.

Use for:

- Equip Spells.
- Ritual components.
- Some Continuous or Normal Spells.

Required safeguard: give the object scale, use or context. A perfectly centered object on radial rays easily becomes product art or a logo.

### G. Environmental landmark

Architecture, landscape or a fantastical location is the subject. Figures become scale markers.

Use for Field Spells and location-defining lore cards.

Required safeguard: choose one landmark and one spatial route into it. Do not render an entire world map of equal-detail attractions.

### H. Ritual or system

An altar, portal, circuit, orbit, diagram or repeated geometry depicts an organized magical process.

Use for Ritual and Continuous cards.

Required safeguard: symmetry is allowed, but the image still needs depth, hierarchy and a physical anchor.

### I. Narrative reaction

The card shows a discovery, interruption, surprise, mistake or consequence. Expressions, body direction and displaced props communicate the event.

Use for many Normal Traps and humorous cards.

Required safeguard: the event must read without the card name or effect text.

---

## 6. Monster artwork

Monster art has the widest range. “Every Monster must be attacking” is false. The consistent requirement is that the creature's **identity and characteristic behavior** are legible.

### Main-subject scale

Useful starting ranges, not laws:

- **Small/cute/weak Monster:** 40–65% of the canvas, with more environmental or graphic support.
- **Standard main-deck Monster:** 55–80%.
- **Boss or Extra Deck Monster:** 70–105%, allowing wings, weapon tips, energy or body segments to leave the frame.
- **Swarm or ensemble Monster:** distribute several readable masses; do not give every member equal size and detail.

### Pose rules

- Place the face, head, weapon contact or casting hand near a third intersection more often than dead center.
- Rotate shoulders and hips differently for humanoids; a straight front-facing torso is easily read as a character sheet.
- Give quadrupeds a weight-bearing paw, bent spine or clear gait.
- Give serpents one coherent curve and a head with surrounding negative space.
- Give winged creatures one dominant wing and one receding wing; two equally spread wings create an emblem unless symmetry is intentional.
- Show mechanical subjects through functional articulation, not a pile of plates.
- A giant needs a scale witness: small figures, architecture, terrain, smoke plume or a foreground object.

### Background rules

Monster backgrounds commonly fall into four modes:

1. **Abstract energy field:** supports highly graphic or supernatural designs.
2. **Environmental fragment:** one wall, forest opening, city mass, sky or floor plane.
3. **Narrative setting:** secondary characters or props explain the monster.
4. **Atmospheric void:** fog, darkness or light isolates a strong silhouette.

The background should share one visual relationship with the Monster: contrast, origin, habitat, victim, scale or motion. If it serves none of these, remove it.

### Boss-monster escalation

Boss art is not merely “more detail.” It increases:

- Apparent scale.
- Frame penetration.
- Contrast range.
- Layer count.
- Number of secondary effects.
- Environmental response.

Keep one dominant face or core. Detail may be high everywhere on the creature, but it should still flow toward that focal point.

---

## 7. Spell artwork by subtype

### Field Spell: show the world

Field Spells are the clearest exception to the character-first rule.

Observed tendencies:

- Highest symmetry of the measured groups: median 0.863.
- Lowest edge density: 0.178.
- Lowest diagonal share: 0.381.
- Lower luminance contrast: 0.201.
- Strong use of architecture, horizon, vanishing point, landmark or environmental transformation.

Construction:

1. Choose one landmark or governing environmental phenomenon.
2. Establish a foreground threshold, path, floor or terrain plane.
3. Place the landmark in the middle or far distance.
4. Add one scale figure or repeated architectural unit if needed.
5. Let atmosphere unify the frame.

Do not turn a Field Spell into a centered monster standing in a detailed room.

### Normal Spell: show a discrete idea

Normal Spells may show:

- A single object being used.
- A spell being cast.
- A character interaction.
- An attack or transformation.
- A symbolic visual joke.
- A result immediately after an action.

They are compositionally broad. The rule is **one complete visual sentence**: subject + verb + result.

### Quick-Play Spell: show acceleration

Quick-Play Spells are among the least symmetrical measured groups and have high contrast. Their visual grammar favors:

- A moment already in motion.
- Diagonal beams, thrusts, weapon arcs or evasive movement.
- Cropped foreground action.
- Strong source-to-target direction.
- A bright localized impact.

Do not show a character calmly posing while speed lines happen behind them.

### Continuous Spell: show an ongoing state

Continuous Spells often depict:

- A stable magical field.
- A repeated cycle.
- A persistent bond.
- An institution, contract or environmental condition.
- Several related actors under the same influence.

Circular and repeated geometry is appropriate when it describes the system. It should connect to physical subjects or a place rather than float as a decorative logo.

### Equip Spell: show object-to-user relationship

The object may dominate, but many references show it:

- Worn or held.
- Activating around a user.
- Striking a target.
- Manifesting the associated creature or power.

If the equipment is isolated, give it a strong material silhouette and a contextual effect. Avoid sterile product photography.

### Ritual Spell: stage a ceremony

Ritual artwork often accepts frontal symmetry, centered altars, portals, offerings and vertical light. The image should show an ordered process:

- Invoker or witness.
- Ritual focus.
- Energy destination or summoned presence.
- Architectural or symbolic alignment.

Symmetry here is semantic. It communicates ceremony and control.

---

## 8. Trap artwork by subtype

Trap art is usually event-first. Its strongest local attention point is more separated from the rest of the image than in Monster art.

### Normal Trap: show the reversal

Typical structure:

1. An initiating subject or force.
2. A target or reacting subject.
3. A visible reversal, capture, collision, reveal or consequence.

Normal Traps frequently use diagonal motion and strong bottom/outer-frame activity. The viewer should understand what went wrong.

### Counter Trap: show the interruption point

Counter Traps have the highest measured contrast and bright-pixel share among the main groups. Common motifs include:

- Barrier meeting attack.
- Beam or weapon collision.
- Authority figure stopping an action.
- Central cancellation symbol grounded in a physical event.
- Sudden white or gold interruption light.

The impact point may be central even when the participating subjects are off-center. The image should say “stopped now,” not merely “powerful energy.”

### Continuous Trap: show the persistent condition

Continuous Traps resemble systems, domains, bindings and repeating influence. They may use:

- Portals.
- Encirclement.
- Repeated figures.
- Environmental takeover.
- Surveillance or control.
- A stable threat looming over smaller actors.

Show why the condition persists. A single attack impact usually reads as a Normal Trap instead.

---

## 9. Foreground, middle ground and background

### Foreground

The foreground earns its place by doing at least one job:

- Establishing scale.
- Pointing toward the focal point.
- Continuing the action beyond the frame.
- Showing the viewer's physical position.
- Revealing a consequence.

Good foreground elements are few and large. One cropped paw, weapon, rock, cable or energy arc is often stronger than twenty particles.

### Middle ground

This is normally where the principal subject and action live. It carries:

- Highest semantic clarity.
- Most anatomical information.
- Strongest useful edge concentration.
- Focal contrast.

### Background

The background should usually be describable in one sentence containing:

1. Location shell.
2. Two or three large value/color masses.
3. Atmosphere.
4. At most one story clue.

Example:

> A dark laboratory with broad green wall panels, one orange-lit doorway and pale vapor behind the creature.

That is normally better than listing monitors, shelves, warning signs, tubes, windows, desks, cables, tools, tanks, vents and debris.

### Detail allocation

A useful starting budget:

| Area | Visual-detail share |
|---|---:|
| Main subject and focal event | 60–75% |
| Foreground/action effects | 15–25% |
| Scenic background | 10–20% |

This is not pixel coverage. It describes where the viewer spends attention.

---

## 10. Color and lighting

### Build a value map before a palette

At thumbnail size, value separation matters before hue. Choose:

- Subject value family.
- Background value family.
- Focal highlight.

A dark subject needs a lighter opening, rim light or bright effect behind its silhouette. A pale subject needs a darker or more saturated support shape.

### Use a three-role palette

Most prompts need only:

1. **Dominant family:** fills most of the environment or subject.
2. **Counter-family:** separates subject from background.
3. **Accent:** marks eye, core, weapon or impact.

Do not describe every object with a separate color. Excess color specification produces equal emphasis.

### Common separation methods

- Cool background / warm focal point.
- Warm environment / pale or cyan subject.
- Dark body / white rim light.
- Desaturated scene / saturated energy accent.
- Light subject / dark framing masses.
- Complementary red-green, orange-blue or yellow-violet contrast.

### Effects are light sources

Energy should illuminate nearby anatomy and surfaces. A glowing orb that casts no colored light looks pasted onto the artwork.

### Black silhouettes

Pure silhouette can work, as image 0185 demonstrated, but a card subject normally needs two or three internal planes revealed by rim light. Otherwise the design disappears at print size.

---

## 11. Background restraint without emptiness

“Simple background” does not mean a blank gradient. It means **grouped information**.

Good simplified backgrounds:

- A wall plane, doorway and vapor mass.
- Sky, mountain silhouette and cloud bank.
- Forest canopy mass, clearing and one trunk.
- City silhouette, smoke plume and backlight.
- Floor perspective, rear wall and one machine.
- Magical void, halo and distant particles.

Bad backgrounds:

- Every laboratory shelf individually described.
- A city full of equally sharp windows.
- Repeating tentacles filling every gap.
- Random lightning applied across the whole frame.
- A blank studio gradient that removes the world.
- Heavy blur used to hide composition problems.

The background should lose **edge density and contrast**, not necessarily objects.

---

## 12. Prompting Ideogram 4 with the `hclar52` LoRA

### Style policy

Use `hclar52` as the only **named learned style** during current trials, but do not confuse this with removing the renderer controls that the successful prompts used.

Do not stack `hclar52` with unrelated named styles such as:

- “Yu-Gi-Oh style.”
- “Modern Japanese trading-card art.”
- “Cinematic digital painting.”
- “Anime concept art.”
- “Highly polished fantasy illustration.”
- Long lists of redundant quality adjectives.

Those phrases can compete with the learned distribution and make the result more generic. However, the best verified A.I.P outputs retained a compact `style_description` containing the medium, lighting, palette, mood and observable rendering priorities. Those fields are controls, not substitute style brands.

Place the information as follows:

- Begin `high_level_description` with the trained card class, such as `Beast-type MONSTER card illustration` or `Normal TRAP card illustration`.
- Put `hclar52 card illustration` in `style_description.art_style`, followed by physical priorities such as exaggerated perspective, readable anatomy or concentrated effects.
- Keep `medium` explicitly set to `illustration`.
- Use four or five palette anchors when palette consistency matters.
- Keep `aesthetics` short and card-specific rather than generic.

Do not rely on `hclar52` as a bare high-level prefix. Trial 02 produced weak flat cartoon renders with that approach.

### Proven native JSON structure

```json
{
  "high_level_description": "Beast-type MONSTER card illustration. A black-green artificial beast climbs from a ruptured laboratory chamber toward the viewer.",
  "style_description": {
    "aesthetics": "newly awakened, predatory, tense",
    "lighting": "cold green chamber light with a concentrated orange-red eye",
    "medium": "illustration",
    "art_style": "hclar52 card illustration with exaggerated perspective, readable monster anatomy and concentrated effects",
    "color_palette": ["#101816", "#29372B", "#D64725", "#E5C19A"]
  },
  "compositional_deconstruction": {
    "background": "A dark laboratory with broad pale-green wall panels, one orange-lit doorway and thin white vapor.",
    "elements": [
      {
        "type": "obj",
        "bbox": [120, 100, 930, 900],
        "desc": "A crouching artificial beast with layered black-green hide, one red-orange eye, four grasping limbs and thin red channels across its shoulders. One foreclaw crosses the lower foreground."
      }
    ]
  },
  "negative_prompt": "card frame, border, title, lettering, logo, watermark, evenly detailed laboratory, photographic blur, duplicate heads, extra limbs"
}
```

### Prompt order

1. Card class and Monster Type or Spell/Trap subtype.
2. Main subject identity.
3. One action.
4. Camera/viewpoint.
5. Main silhouette or distinguishing shape.
6. Compact `style_description` with `hclar52`, explicit illustration medium, lighting and palette.
7. One foreground depth device.
8. Simple background shell.
9. One focal light/color relationship.

### Element policy

- One coherent subject is one `obj` element.
- Keep its anatomy, clothing, weapon and attached appendages inside that description.
- Add separate elements only for genuinely separate subjects or important props.
- Begin with one to three elements. Add another only after a test proves it is necessary.
- Do not encode every spark, fragment, limb or tendril as its own object.

### Bounding-box policy

Ideogram bounding boxes use normalized coordinates from 0 to 1000 in this workflow, ordered:

```text
[top, left, bottom, right]
```

Use a box when placement matters. Omit it when natural placement is acceptable.

Starting boxes:

- Large central/offset Monster: `[100, 100, 930, 900]`
- Upper-body close-up: `[40, 120, 920, 950]`
- Smaller environmental figure: `[250, 200, 800, 750]`
- Foreground-to-background diagonal creature: use one generous box rather than separate body-part boxes.

Boxes should overlap only when the subjects physically overlap. Several huge overlapping boxes encourage duplicated anatomy, collage layouts and fused objects.

### Negative-prompt policy

Describe the desired construction directly in the positive fields. A compact negative prompt was present in every verified strong A.I.P reference and should currently be retained. Use it for output-format failures and common anatomical faults, not to design the scene by negation.

Do not rely only on:

> no symmetry, no logo, no detailed background, no extra limbs

Also use:

> asymmetrical three-quarter pose; one complete four-limbed creature; open negative space around the head; broad low-contrast wall shapes behind it

The effect of negative prompting has not yet been independently isolated. Do not remove it from the proven control until an A/B test changes only that field.

---

## 13. Failure modes found in the recent generations

### 1. Style-brand pileup

**Symptom:** Generic polished fantasy art that does not resemble the training distribution.  
**Cause:** `hclar52` competes with several unrelated style brands or genre clichés.  
**Fix:** Keep `hclar52` as the only named learned style, but retain concise physical controls for medium, light, palette, perspective and anatomy.

### 2. Mandala boss

**Symptom:** Centered eye or mouth with evenly distributed tendrils.  
**Cause:** Symmetrical language, full-frame appendages and circular energy.  
**Fix:** Three-quarter body; offset eye; unequal tendril directions; clear negative-space gaps.

### 3. Character sheet

**Symptom:** Front-facing figure standing against a decorative background.  
**Cause:** Detailed identity with no strong verb or camera direction.  
**Fix:** Add one physical action and rotate the body in depth.

### 4. Floating logo

**Symptom:** Brain, eye, mouth, shield or symbol isolated at the center.  
**Cause:** Object named without physical context; radial effects reinforce emblem reading.  
**Fix:** Add a user, target, surface, scale clue or environmental interaction.

### 5. Tentacle wallpaper

**Symptom:** Repeated appendages fill every background gap.  
**Cause:** Too many tendrils, each described as important.  
**Fix:** Specify an exact small count and distinct paths; keep appendages part of the creature element.

### 6. Graphic footer

**Symptom:** Red impact stripe or debris band across the bottom.  
**Cause:** “Red slash,” “impact line” or a shallow full-width foreground box.  
**Fix:** Use a localized contact point or diagonal fan and avoid full-width shallow boxes.

### 7. Busy laboratory

**Symptom:** Shelves and machinery compete with the creature.  
**Cause:** Background described as an inventory.  
**Fix:** Three broad room masses and one clue.

### 8. Flat black silhouette

**Symptom:** Strong outline but no printable internal design.  
**Cause:** “Black silhouette” without internal light planes.  
**Fix:** Reveal two or three internal forms with rim light or reflected light.

### 9. Lore collage

**Symptom:** Unrelated people, symbols, apparel, text or multiple scenes.  
**Cause:** Prompt explains history rather than a visible moment.  
**Fix:** Translate the lore into one event occurring now.

### 10. Safety-filter false positive

**Symptom:** Gray safety result despite benign intent.  
**Cause:** Terms describing birth, bodily disassembly, fear or prohibited material may trigger the filter even inside negative clauses.  
**Fix:** Use neutral visual language: `activated`, `converting into energy`, `alert`, `synthetic material`.

---

## 14. The trial-and-error protocol

Every new card should be treated as a controlled experiment.

### Stage 1: establish the minimal baseline

Generate four seeds using:

- `hclar52` only for style.
- One high-level sentence.
- One background sentence.
- One main subject element.
- No color palette array.
- No secondary objects unless essential.
- One loose bounding box or no box.

### Stage 2: diagnose one failure

Choose the single largest problem:

- Identity.
- Silhouette.
- Pose/action.
- Framing.
- Foreground depth.
- Background competition.
- Color/value separation.
- Style drift.

Do not fix all categories simultaneously.

### Stage 3: make one controlled change

Examples:

- Move the head from center to upper-left.
- Change front view to low three-quarter view.
- Add one cropped foreground paw.
- Replace a detailed city with broad smoke and building masses.
- Remove three secondary elements.
- Add a pale backlight behind a dark silhouette.

Generate the same seed first to expose the effect of the wording change. Then test three new seeds for robustness.

### Stage 4: score at thumbnail size

Score each item from 0 to 2:

| Criterion | 0 | 1 | 2 |
|---|---|---|---|
| Subject identity | unclear/wrong | partly recognizable | unmistakable |
| Silhouette | merged/noisy | readable with issues | immediate and distinctive |
| Pose/action | static/confused | action present | action instantly understood |
| Depth layering | flat | two layers | foreground, subject and background read clearly |
| Background | empty or competing | acceptable | supports story and silhouette |
| Focal hierarchy | no focus | weak focus | one clear primary and one optional secondary |
| Color/value | muddy | adequate | strong separation and focal accent |
| `hclar52` fidelity | generic/off-style | partial | convincing learned card-art language |

Maximum score: **16**.

- **14–16:** candidate final.
- **11–13:** retain and revise one issue.
- **8–10:** composition may be salvageable, but do not polish details yet.
- **0–7:** restart from a simpler scene sentence.

### Stage 5: record the evidence

```markdown
## Trial: [card name] — [date]

- Prompt version:
- Seed:
- Workflow/model/LoRA weight:
- Intended composition family:
- Score: /16
- What worked:
- Largest failure:
- Single change for next trial:
- Result after change:
- Candidate rule for the Gospel:
- Confidence: hypothesis / repeated / established
```

### Rule-promotion standard

- **Hypothesis:** observed in one generation batch.
- **Repeated:** observed across at least three useful outputs or reference examples.
- **Established:** holds across multiple card categories and survives a controlled A/B test.
- **Exception:** intentionally broken for a specific semantic reason, such as Ritual symmetry or a mascot portrait.

Never promote “the model did this once” into a universal rule.

---

## 15. Pre-generation card brief

Complete this before writing JSON:

```text
Card name:
Card category/subtype:
Narrative purpose:
Primary subject:
One defining shape:
One action verb:
Camera/viewpoint:
Primary focal point:
Foreground depth device:
Background shell:
Scale clue:
Dominant value family:
Counter-value or counter-hue:
Accent light/color:
Composition family:
What must remain readable at 128 px:
```

If the brief cannot name one action, one focal point and one dominant shape, the prompt is not ready.

---

## 16. The commandments

1. Thou shalt design for card size before full resolution.
2. Thou shalt use `hclar52` as the sole style trigger during current trials.
3. Thou shalt give each card one dominant visual sentence.
4. Thou shalt protect the main silhouette with negative space.
5. Thou shalt use one primary action verb.
6. Thou shalt place detail where the story happens.
7. Thou shalt let the foreground create depth, not a border.
8. Thou shalt group the background into broad masses.
9. Thou shalt use lighting to separate subject and environment.
10. Thou shalt treat energy as a light source.
11. Thou shalt not confuse more particles with more impact.
12. Thou shalt not split one creature into multiple JSON objects.
13. Thou shalt not describe every background prop.
14. Thou shalt not use symmetry by accident.
15. Thou may use symmetry when the card means ritual, system, monument or domain.
16. Thou shalt show the event on Spells and Traps, not merely the featured monster posing.
17. Thou shalt show the world on a Field Spell.
18. Thou shalt show acceleration on a Quick-Play Spell.
19. Thou shalt show interruption on a Counter Trap.
20. Thou shalt change one variable per trial and record what happened.

---

## 17. Sanity check against the recent generated highlights

The same measurements were run on selected recent outputs. This test confirms that no single metric predicts quality, but combinations help explain failure modes.

| Image | Visual reading | Edge density | Outer ÷ central edges | Symmetry | Diagonal share | Contrast |
|---|---|---:|---:|---:|---:|---:|
| 0036 | Strong A.I.P transformation | 0.177 | 0.654 | 0.820 | 0.465 | 0.239 |
| 0095 | Strong Shrieker concept | 0.191 | 0.568 | 0.839 | 0.423 | 0.169 |
| 0098 | Cleaner Shrieker variant | 0.200 | 0.693 | 0.832 | 0.435 | 0.206 |
| 0153 | Strong stone-cyclops scale | 0.194 | 0.635 | 0.862 | 0.391 | 0.171 |
| 0185 | Strong graphic silhouette | 0.094 | 1.553 | 0.952 | 0.559 | 0.191 |
| 0011 | Flat Caller poster | 0.160 | 0.809 | 0.916 | 0.446 | 0.136 |
| 0021 | Hive Mind emblem | 0.113 | 0.346 | 0.962 | 0.496 | 0.079 |
| 0052 | Symmetrical laboratory corridor | 0.263 | 0.961 | 0.927 | 0.318 | 0.116 |

For comparison, official Monster medians were edge density **0.248**, outer-to-central edge ratio **0.871**, symmetry **0.776**, diagonal share **0.465** and contrast **0.227**.

Interpretation:

- Image 0036 closely matches the official Monster medians for diagonal energy and contrast. Its center is more dominant than average, but the figure's pose and cable arcs keep the composition alive. It is the best overall A.I.P reference.
- The Shrieker images have lower total detail than the Monster median, yet remain readable because the mouth is an exceptional focal shape. Increasing detail everywhere would weaken them; future trials should add only selective anatomy and environmental response.
- Image 0153 succeeds through scale hierarchy and foreground witnesses even though it is more symmetrical and less diagonal than the typical Monster. Composition can earn an intentional exception.
- Image 0185 succeeds as a graphic image but is not a complete official-style target. Its extremely high symmetry and very low edge density make it closer to an emblem. Borrow its silhouette economy, limited red-eye accent and rim-light depth; add asymmetry and internal structure for final card art.
- The weak Caller, Hive Mind and laboratory examples combine high symmetry with low contrast or low directional energy. This explains why they read as posters, logos or static corridors.

The lesson is to borrow **specific successful properties**, not copy an entire image indiscriminately.

---

## 18. Immediate implications for A.I.P

The A.I.P identity should come from recurring physical traits, not repeated composition:

- Black-green synthetic hide or plates.
- Restrained red channels.
- Red-orange sensory organs.
- Artificial-organic construction.
- Laboratory origin or environmental consequence when relevant.

Each card needs a different visual verb:

| Card | Primary visual job |
|---|---|
| The Misstakes | origin/activation |
| Larva | emergence/mobility |
| Shrieker | sonic release |
| Claw | lateral pounce |
| Maw | rising coil and jaw turn |
| Predator | stalking arrival |
| Lab | environmental containment failure |
| Failures | material conversion |
| Assimilation | readable before/after transformation |
| Hive Mind | persistent synchronization |
| Caller | summoning signal |
| Zero Mother | colossal collection/control |

Do not give all twelve:

- A central red eye.
- A laboratory corridor.
- A circular energy ring.
- Front-facing symmetry.
- A full frame of red-black tendrils.

Consistency should come from anatomy and palette. Variety should come from composition, camera, action and card function.

---

## 19. Next research cycle

Version 0.1 establishes the reference-derived framework. The next cycle should:

1. Generate the same A.I.P card with three prompt complexities: one element, two elements and four elements.
2. Compare no bounding box against one loose box and several precise boxes.
3. Compare a centered iconic pose against an offset action pose using the same seed.
4. Compare a blank background, a grouped background shell and a detailed environment.
5. Compare `hclar52` alone against `hclar52` plus one style phrase to quantify style interference.
6. Record all outputs and scores in a dedicated trial ledger.
7. Revise this Gospel only where repeated results support the change.

The goal is not to discover one perfect prompt. It is to discover which controls are reliable for this exact LoRA, model and workflow.

---

## 20. Trial ledger

### Trial 01 — Shrieker composition test — 2026-09-04

- **Intended test:** centered frontal composition against off-center diagonal composition.
- **Planned sample:** four matched seeds per variant.
- **Actual output:** four frontal images generated; all four diagonal images were replaced by safety-filter cards.
- **Result:** invalid experiment. No composition conclusion can be drawn.

#### Workflow evidence

Embedded ComfyUI metadata showed:

- `Generate JSON Prompt` was `true` for all eight images.
- Completed JSON was therefore passed through the workflow's text-generation model and rewritten before image conditioning.
- The four A images and four B images used eight different seeds rather than four matched seed pairs.
- The workflow used `Ideogram4_Yugioh_hclar52_r32_v1_000003500.safetensors` at model strength `1.0`.
- The Quality preset used Euler sampling with its 48-step schedule, CFG `7.0`, followed by a late CFG override of `3.5`.
- `ComfyUI_00344_.png` contains an ordinary RGB rendering of a checkerboard; it is not an image with transparency.

#### Visual evidence

The four generated A images consistently became frontal creature renders:

- strong bilateral symmetry;
- eye-level or slightly low product-shot staging;
- a flat laboratory wall and floor;
- radial glass or saliva-like marks used as decoration;
- little narrative depth;
- generic reptilian anatomy instead of a distinctive A.I.P silhouette.

This is consistent with the intermediate prompt generator's documented behavior: when the medium is ambiguous, it defaults to a photograph. `hclar52` alone did not reliably prevent that conversion.

#### Rules learned

1. Never paste completed JSON while `Generate JSON Prompt` is enabled.
2. If the switch is enabled, provide natural language rather than JSON and explicitly state the medium.
3. If the switch is disabled, provide renderer-ready JSON. In this workflow, use the Resolution Selector for aspect ratio rather than adding an untested `aspect_ratio` key to a proven direct prompt.
4. Begin Monster prompts with the card class, such as `Beast-type MONSTER card illustration`, and place `hclar52 card illustration` inside `style_description.art_style`.
5. Match the exact same seed between A and B.
6. A safety-filter card is a failed render, not a low-scoring artwork. Record the block rate separately.
7. Calibrate the prompt pipeline before testing composition.

**Confidence:** established for workflow routing; hypothesis for the medium-prefix improvement until Trial 02 is rendered.

### Trial 02 — Prompt-route calibration — 2026-09-04

- **Natural-language route:** two images generated with `Generate JSON Prompt = true`.
- **Direct-JSON route:** two images were safety-blocked with `Generate JSON Prompt = false`.
- **Seed control:** invalid; all four images used different seeds.
- **Checkpoint:** `Ideogram4_Yugioh_hclar52_r32_v1_000003500.safetensors`, strength `1.0`, in all four outputs.
- **Resolution:** the new outputs used the 1-megapixel selector and rendered at `1024 × 1024`; the verified strong Shriekers used the 2-megapixel selector and rendered at `1456 × 1456`.

#### Visual result

- Natural-language image 1 obeyed the diagonal scream but embedded a literal checkerboard border into the RGB artwork.
- Natural-language image 2 achieved an asymmetric three-quarter pose and directional fragments, but the rendering remained a flat mascot/cartoon treatment with weak depth and generic anatomy.
- Both direct minimal JSON attempts were blocked, so their visual quality cannot be compared.

#### Measured comparison

| Output | Edge density | Outer ÷ central edges | Symmetry | Diagonal share | Contrast | Saturation | Focal peak offset |
|---|---:|---:|---:|---:|---:|---:|---:|
| Trial 02 natural image 1 | 0.239 | 1.409 | 0.922 | 0.232 | 0.200 | 0.112 | 0.376 |
| Trial 02 natural image 2 | 0.114 | 0.395 | 0.891 | 0.373 | 0.159 | 0.205 | 0.099 |
| Verified Shrieker 0095 | 0.191 | 0.568 | 0.839 | 0.423 | 0.169 | 0.349 | 0.359 |
| Verified Shrieker 0098 | 0.200 | 0.693 | 0.832 | 0.435 | 0.206 | 0.263 | 0.259 |

The natural-language outputs are more bilaterally symmetric than both verified Shriekers. Image 1's checkerboard and rectangular artwork panel inflate outer-frame edge activity while reducing the total diagonal share. Image 2 moves in the right direction, but its focal peak sits almost centrally and its total saturation and edge activity are much lower than the strong references. The measurements support the visual diagnosis: the new images simplified structure and color instead of merely simplifying background clutter.

For Test 03, a healthy reproduction should approximately return to:

- symmetry below `0.86`;
- diagonal edge share above `0.40`;
- saturation above `0.25`;
- no artificial outer frame or checkerboard;
- a focal peak clearly displaced from the exact center.

#### Comparison with verified strong outputs

The earlier strong A.I.P images 0036, 0095 and 0098 used the same Ideogram model, LoRA checkpoint, LoRA strength and Quality preset. A complete node-by-node graph comparison found one additional generation-setting difference: verified Shrieker 0095 used 2 megapixels while the new calibration used 1 megapixel. Their prompt-construction differences were:

- `Generate JSON Prompt = false`;
- direct renderer-ready JSON;
- card class at the start of `high_level_description`;
- `hclar52 card illustration` inside `style_description.art_style` rather than as a bare high-level prefix;
- explicit `medium: illustration`;
- compact aesthetics, lighting and palette fields;
- loose bounding boxes;
- a separate `effect` element;
- a focused negative prompt.

Therefore Trial 02 does **not** show that direct JSON is intrinsically unsafe or ineffective. It shows that the new minimal JSON recipe failed while the older rich JSON recipe had already succeeded.

#### Revised rule

Restore the proven rich schema as the control. Remove or alter one field at a time only after deterministic reproduction succeeds.

Match the proven 2-megapixel setting during reproduction. Resolution is now a controlled variable and must not change silently between batches.

**Confidence:** established that minimal prompting performed worse in this batch; individual contributions of style fields, boxes, effect elements and the negative prompt remain unisolated.

### Trial 03 — Rich JSON routing test — 2026-09-04

- **Input:** the exact same 1,987-character rich Shrieker JSON in both runs.
- **Seed:** `573928216989127` in both runs.
- **Shared settings:** same models, LoRA checkpoint, LoRA strength `1.0`, Quality preset, Euler sampler, CFG schedule, square aspect ratio and 1-megapixel resolution.
- **Only changed variable:** `Generate JSON Prompt` OFF for `ComfyUI_00355_.png`; ON for `ComfyUI_00356_.png`.
- **Validity:** controlled A/B test.

#### Visual result

Both variants restored the illustrated card-art character that was absent from the minimal-prompt trials. Both have aggressive cropping, a readable black-green/red creature identity, environmental rupture and layered sound effects.

The direct route in image 355 is the stronger control:

- the coiled body remains more coherent;
- the orange eye and throat create clearer color hierarchy;
- the sound rings reinforce the body curve;
- the creature retains more separation from the chamber;
- the anatomy is strange but reads as one organism.

The regenerated route in image 356 is more immediately grotesque but less controlled:

- four enormous vertical fangs divide the mouth into bars;
- the circular effects become a cage-like overlay;
- ear-like head projections alter the creature identity;
- the focal region has little luminance separation from the surrounding body;
- the second prompt-generation pass introduces unobservable prompt drift.

#### Measured comparison

| Output | Edge density | Outer ÷ central edges | Symmetry | Diagonal share | Contrast | Saturation | Focal separation | Focal peak offset |
|---|---:|---:|---:|---:|---:|---:|---:|---:|
| 355 — direct JSON | 0.214 | 0.734 | 0.864 | 0.408 | 0.170 | 0.343 | 0.116 | 0.348 |
| 356 — JSON regenerated | 0.206 | 0.660 | 0.872 | 0.361 | 0.174 | 0.252 | 0.036 | 0.373 |
| Verified Shrieker 0095 | 0.191 | 0.568 | 0.839 | 0.423 | 0.169 | 0.349 | 0.150 | 0.359 |
| Verified Shrieker 0098 | 0.200 | 0.693 | 0.832 | 0.435 | 0.206 | 0.263 | 0.152 | 0.259 |

Image 355 is closer to the verified Shriekers in diagonal energy, saturation and focal separation. Image 356 does not gain measurable compositional strength from the second prompt-generation pass.

#### Rule established

When a completed rich JSON prompt already exists, disable `Generate JSON Prompt`. Passing JSON through the generator again changes content unpredictably and weakens experimental reproducibility.

**Confidence:** established by a matched-seed A/B test and consistent with embedded workflow routing.

### Trial 04 — Resolution test — 2026-09-04

- **A:** `ComfyUI_00355_.png`, 1 megapixel, `1024 × 1024`.
- **B:** `ComfyUI_00357_.png`, 2 megapixels, `1456 × 1456`.
- **Locked:** exact 1,987-character prompt, seed `573928216989127`, direct JSON route, model, LoRA, strength and complete sampler graph.
- **Graph verification:** the Resolution Selector was the only changed prompt-graph node.
- **Validity:** controlled A/B test.

#### Visual result

The 2-megapixel result has cleaner individual teeth, stronger local contrast and more resolved material surfaces. It does not behave like an upscale of the 1-megapixel result. The creature becomes a much tighter mouth portrait, most of the body leaves the frame and the sound rings form a larger enclosing circle.

The 1-megapixel result is compositionally preferable for this seed because it retains more of the coiled torso, connects the forelimbs to the action and gives the orange eye greater importance relative to the mouth.

#### Measured comparison

| Output | Edge density | Outer ÷ central edges | Symmetry | Diagonal share | Contrast | Saturation | Focal separation | Peak component area |
|---|---:|---:|---:|---:|---:|---:|---:|---:|
| 355 — 1 MP | 0.214 | 0.734 | 0.864 | 0.408 | 0.170 | 0.343 | 0.116 | 0.026 |
| 357 — 2 MP | 0.209 | 0.726 | 0.867 | 0.437 | 0.213 | 0.239 | 0.033 | 0.154 |

The 2-megapixel image gains diagonal energy and contrast but loses color concentration and focal separation. Its largest salient component occupies roughly six times the image fraction measured in the 1-megapixel version, consistent with the mouth taking over the composition.

#### Rule learned

Changing latent resolution changes composition even when the seed and prompt are identical. A numerical seed does not identify the same noise layout across different latent dimensions. Therefore:

1. Do not treat 2 megapixels as a detail-only upgrade.
2. Choose generation resolution before seed hunting.
3. If a 1-megapixel composition wins, upscale that image separately instead of expecting a 2-megapixel rerun to preserve it.
4. One seed is insufficient to establish that 1 megapixel is universally superior; this result establishes only that higher latent resolution can alter and worsen framing.

**Winner for this seed:** 355 at 1 megapixel.

**Confidence:** established behavior for composition drift; resolution preference remains card- and seed-dependent.

### Trial 05 — Subject-scale bounding box — 2026-09-04

- **A:** `ComfyUI_00355_.png`, creature box `[40, 120, 980, 900]`.
- **B:** `ComfyUI_00358_.png`, creature box `[120, 170, 920, 830]`.
- **Locked:** every other prompt character, effect box, seed `573928216989127`, direct JSON route, 1-megapixel resolution and full generation graph.
- **Graph verification:** node 192 was the only changed graph node, and the two box coordinates were the only changed prompt values.
- **Validity:** controlled A/B test.

#### Visual result

The inset B reveals more of the coiled torso and gives the laboratory walls a stronger framing role. It therefore succeeds at literal subject scaling. However, it does not improve the whole composition:

- the creature becomes more upright and centered;
- the full-frame effect box expands into the freed space;
- the sound rings become a near-complete circular enclosure;
- dozens of small fragments distribute detail behind the entire head;
- the forelimbs remain indistinct despite more body being visible;
- the orange eye loses dominance relative to the large pale effect field.

#### Measured comparison

| Output | Edge density | Outer ÷ central edges | Symmetry | Diagonal share | Contrast | Saturation | Focal separation | Peak component area |
|---|---:|---:|---:|---:|---:|---:|---:|---:|
| 355 — wide creature box | 0.214 | 0.734 | 0.864 | 0.408 | 0.170 | 0.343 | 0.116 | 0.026 |
| 358 — inset creature box | 0.192 | 0.733 | 0.900 | 0.427 | 0.167 | 0.328 | 0.047 | 0.136 |

The inset box raises diagonal edge share slightly, but symmetry increases and focal separation falls sharply. The largest salient component grows more than fivefold, consistent with the sound-ring field overtaking the hierarchy.

#### Rule learned

A smaller subject box does not merely zoom out. Other full-frame elements can occupy the released space and reorganize the image. Evaluate all overlapping boxes as a system.

**Winner:** 355. Image 358 provides useful evidence but does not improve the overall card composition.

**Confidence:** established for this prompt and seed; further creatures are needed before generalizing exact box sizes.

### Trial 06 — Negative-prompt leakage — 2026-09-04

- **A:** `ComfyUI_00358_.png`, with the top-level `negative_prompt` field.
- **B:** `ComfyUI_00359_.png`, without that field.
- **Locked:** every positive prompt character, boxes, seed `573928216989127`, direct JSON route, 1-megapixel resolution and full generation graph.
- **Graph verification:** node 192 was the only changed graph node; B exactly equals A with the negative field removed.
- **Validity:** controlled A/B test.

#### Visual result

Removing the negative field did not remove or visibly reduce the dense shard cloud, circular sound enclosure, seal-like head or extreme mouth emphasis. Image 359 is somewhat less bilaterally balanced and has stronger global contrast, but its focal hierarchy remains weak.

#### Measured comparison

| Output | Edge density | Outer ÷ central edges | Symmetry | Diagonal share | Contrast | Saturation | Focal separation | Peak component area |
|---|---:|---:|---:|---:|---:|---:|---:|---:|
| 358 — with negative field | 0.192 | 0.733 | 0.900 | 0.427 | 0.167 | 0.328 | 0.047 | 0.136 |
| 359 — without negative field | 0.190 | 0.673 | 0.875 | 0.405 | 0.195 | 0.296 | 0.025 | 0.139 |

#### Rule learned

The dense fragments arise primarily from the positive effect instruction—`sound rings`, `glass fragments`, `dust and fluid droplets`—combined with a nearly full-frame effect box. The negative field did not successfully suppress its listed unwanted concepts in this test.

Omit the top-level `negative_prompt` from current direct JSON experiments so that unwanted nouns are not added to the positively encoded string. This is a workflow-specific practical rule, not proof that the model interprets every negative term positively.

**Winner:** weak preference for 359 because it removes an ineffective and confounding field; neither image solves the effect-composition problem.

**Confidence:** established that this negative field did not suppress the observed failures for this prompt and seed.

### Trial 07 — Directional effect language — provisional visual result

Use image 359 as A. Change only the effect description from two broad sound rings with diffuse fragments and droplets to one pressure crescent travelling toward the upper left with six separated fragments. Keep the full-frame effect box unchanged so the experiment isolates semantic effect construction before testing effect placement.

The supplied inline result shows a clear qualitative improvement:

- the complete circular sound enclosure disappears;
- the sonic event travels from the mouth toward the upper left;
- the creature separates more clearly from the quiet green wall;
- the orange mouth light becomes a stronger focal accent;
- the action reads without a uniform debris cloud across the entire image.

The new fragment instruction introduces a different failure: the requested six large fragments become four oversized shield-like glass panels on the left. Two dark circular containment fixtures also compete with the creature's orange eye.

The original PNG and embedded metadata were not available locally at review time, so seed and graph equality remain unverified. Do not promote this from a visual result to an established A/B rule until the source PNG is audited.

#### Provisional lesson

Directional effect language is more promising than complete sound rings. Explicitly requesting a count of large fragments gives those fragments too much visual importance.

### Trial 08 — Remove fragment sentence — provisional visual result

Keep the Trial 07 pressure-crescent sentence and remove only `Six large glass fragments follow the same diagonal with clear empty gaps between them.` This tests whether the oversized glass panels disappear without losing the successful directional wave.

`ComfyUI_00361_.png` verifies the B configuration: seed `573928216989127`, direct JSON, generator OFF, 1 megapixel. Its graph differs from image 359 only in node 192, where the earlier two-ring effect description is replaced by the single no-fragment crescent. The intermediate Trial 07 PNG was not locally available for a strict graph diff, so the specific Trial 07-to-08 attribution remains provisional.

Visually, removing the fragment sentence eliminates the oversized glass panels while retaining a clear leftward sonic event. Compared with the older two-ring image 359, image 361 also:

- reduces edge density from `0.190` to `0.138`;
- reduces symmetry from `0.875` to `0.860`;
- raises diagonal edge share from `0.405` to `0.427`;
- raises saturation from `0.296` to `0.330`;
- removes the uniform debris field.

The remaining crescent is too large and loops around the left half of the composition. This is now a placement problem rather than a content-density problem.

#### Provisional lesson

Do not enumerate decorative fragments unless each one is narratively necessary. A single directional effect shape produces a cleaner card image than rings plus debris.

### Trial 09 — Effect bounding box — 2026-09-04

- **A:** `ComfyUI_00361_.png`, effect box `[0, 20, 1000, 980]`.
- **B:** `ComfyUI_00362_.png`, effect box `[20, 0, 700, 700]`.
- **Locked:** every other prompt character, seed `573928216989127`, direct JSON route, 1-megapixel resolution and full generation graph.
- **Graph verification:** node 192 was the only changed node; the effect-box coordinates were the only changed prompt values.
- **Validity:** controlled A/B test.

#### Result

The inset box removes the looping oval but produces a worse layout:

- broad white letterbox bands occupy the top and bottom;
- the illustration is treated like a rectangular panel inside the square canvas;
- the pressure wave remains oversized;
- diagonal edge share falls from `0.427` to `0.376`;
- bright-pixel fraction jumps from `0.001` to `0.198` because of the white bands;
- the two dark wall fixtures remain competing focal shapes.

The white areas are ordinary RGB pixels, not transparency.

#### Rule learned

Do not give an abstract, deformable effect a tight rectangular box unless the effect itself is meant to occupy a rectangular region. A box can change the renderer's interpretation of the entire artwork boundary, not merely the effect's position.

**Winner:** image 361 with the full effect box.

**Confidence:** established for this prompt and seed.

### Trial 10 — Unboxed effect — provisional visual result

Use image 361 as A. Remove only the effect element's `bbox` while retaining its type and description. The creature remains boxed. This tests whether natural language can anchor the crescent to the mouth without turning the effect into either a full-frame loop or a rectangular artwork panel.

The supplied inline result fails visibly:

- a portrait-oriented illustration panel appears inside the square canvas;
- a checkerboard surround occupies the unused canvas;
- the orange eye is duplicated;
- an unrelated pipe-like appendage appears behind the creature;
- the crescent becomes a broad fan rather than a controlled arc;
- the image reads as a placed asset or layout mockup rather than full-bleed card artwork.

The original PNG was not locally available for metadata verification, so this result remains provisional. Nevertheless, removing the box did not produce the intended natural anchoring.

#### Provisional lesson

The separate `type: "effect"` element is now the common factor across the ring, panel and unboxed-layout failures. The next test should preserve the effect wording while removing the separate effect element.

### Trial 11 — Single object element — 2026-09-04

- **A:** `ComfyUI_00361_.png`, separate boxed creature and effect elements.
- **B:** `ComfyUI_00364_.png`, one object element containing the same pressure-crescent sentence.
- **Locked:** creature box `[120, 170, 920, 830]`, background, style fields, seed `573928216989127`, direct JSON route, generator OFF, 1-megapixel resolution and generation settings.
- **Metadata verification:** B contains the expected seed, direct JSON input, generator OFF, Ideogram 4 model, `hclar52` LoRA at strength `1.0`, Quality preset, Euler sampler and CFG `7` / late CFG `3.5`.

#### Result

Removing the separate effect element does not fix the panel failure. Image 364 still produces:

- a portrait-oriented artwork panel inside the square output;
- literal checkerboard outside the panel;
- a duplicated orange eye;
- a triangular, pane-like pressure wave;
- an overly tight mouth-dominant crop.

Most importantly, the visible panel boundaries closely match the remaining creature box `[120, 170, 920, 830]`. The checkerboard occupies the canvas that the box does not cover. This makes the remaining object box the strongest causal candidate for the panel/compositing interpretation.

#### Rule learned

Combining an attached action with its subject is not sufficient when the subject still has an inset bounding box. In this workflow, a box can behave as an explicit artwork or compositing region rather than a soft placement hint.

**Winner:** image 361. Image 364 is a useful diagnostic failure.

**Confidence:** strong visual and metadata evidence; the final causal test is removal of the last box.

### Trial 12 — No bounding boxes — 2026-09-04

- **A:** `ComfyUI_00364_.png`, one object element with box `[120, 170, 920, 830]`.
- **B:** `ComfyUI_00365_.png`, the identical prompt with that final box removed.
- **Locked:** every descriptive word, element structure, seed `573928216989127`, direct JSON route, generator OFF, 1-megapixel resolution and generation settings.
- **Metadata verification:** B contains the expected seed, direct JSON input, generator OFF, Ideogram 4 model, `hclar52` LoRA at strength `1.0`, Quality preset, Euler sampler and CFG `7` / late CFG `3.5`.
- **Validity:** controlled A/B test.

#### Result

Removing the final box produces a decisive improvement:

- the image becomes full bleed;
- the checkerboard surround and inset portrait panel disappear;
- the duplicated orange eye disappears;
- the unrelated rear appendage disappears;
- the creature and laboratory now occupy one coherent scene;
- the pressure effect clearly originates at the mouth and travels toward the upper left.

The remaining flaws are different in kind. The monster is still cropped too tightly, the mouth occupies most of the image and the translucent crescent remains broader than desired. These are now attributable to explicit framing and emphasis language rather than a compositing failure: the prompt says `head crops near the top`, `enormous vertical mouth` and `dominant open-mouth focal point`.

#### Rule learned

For a single full-bleed card illustration in this Ideogram 4 workflow, omit bounding boxes unless a genuine layout or isolated compositing region is intended. Use natural-language spatial relationships for subject placement and attached effects. An inset object box can create literal uncovered canvas rather than merely guiding position.

**Winner:** image 365.

**Confidence:** established by a controlled same-seed test.

### Trial 13 — Natural-language wider framing — 2026-09-04

- **A:** `ComfyUI_00365_.png`, action with the head cropped near the top.
- **B:** `ComfyUI_00366_.png`, the identical unboxed prompt with explicit complete-subject, middle-distance and breathing-room language.
- **Locked:** every other prompt character, element structure, absence of boxes, seed `573928216989127`, direct JSON route, generator OFF, 1-megapixel resolution and generation settings.
- **Metadata verification:** B contains the expected seed, direct JSON input, generator OFF, Ideogram 4 model, `hclar52` LoRA at strength `1.0`, Quality preset, Euler sampler and CFG `7` / late CFG `3.5`.
- **Image verification:** B is a 24-bit RGB PNG. Its checkerboard is baked imagery, not alpha transparency.
- **Validity:** controlled A/B test.

#### Result

The wider-framing sentence successfully reveals the entire coiled body and all four limbs, but catastrophically changes the output format:

- the artwork becomes a small portrait panel centered on a square checkerboard;
- the panel occupies only part of the available canvas;
- the monster reads like an isolated character asset rather than an event filling a card illustration;
- the pressure crescent remains oversized and crosses the panel edge;
- the anatomy is clearer, but the card-level composition is unusable.

Because no `bbox` exists in either prompt, bounding boxes are not the only trigger for placed-asset layouts. The changed sentence contains several layout-oriented phrases: `complete creature`, `compact ... silhouette`, `middle distance`, `remain visible` and `clear breathing room`. Their combination describes presentation requirements more strongly than an event occurring inside a world.

#### Rule learned

Avoid production/layout vocabulary in the generation prompt. Do not request a `complete subject`, `silhouette`, `middle distance`, `breathing room`, `fully visible`, `contained in frame` or similar framing checklist. Such language can produce a poster, character sheet, sticker or artwork panel—even with no boxes and no transparency request.

Request the desired scale indirectly through physical action and environmental contact: describe the torso coiling through the room, claws striking a surface, wings crossing the sky or a tail passing behind scenery.

**Winner:** image 365. Image 366 proves that wider anatomy was attainable but used an unacceptable layout grammar.

**Confidence:** established for the combined sentence at this seed; individual phrases remain to be isolated if necessary.

### Trial 14 — Action-based framing — 2026-09-04

Use image 365 as the stable A reference. Replace only its crop sentence with `Its long segmented torso coils diagonally through the chamber while both foreclaws tear into the laboratory floor.` Keep the prompt unboxed and all other words and settings unchanged.

#### Result

Image 367 disproves the hypothesis. It preserves more body than image 365 but again generates a bordered portrait panel over a baked checkerboard. It also worsens the creature design:

- the squat artificial beast becomes a generic serpentine worm-dragon;
- the mouth and sonic cone remain disproportionately large;
- the long repeated body segments create a monotonous hose-like silhouette;
- the claws are small and disconnected from the advertised floor impact;
- the environment becomes a thin decorative frame instead of a spatial scene;
- the clean outlined rendering lacks the material variety and layered depth visible across the official reference set.

Metadata verifies the same seed `573928216989127`, direct JSON route, generator OFF, 1-megapixel resolution, Ideogram 4 base and current LoRA at strength `1.0`.

#### Rule learned

Action language alone does not reliably control framing, and prompt micro-tuning is no longer a useful diagnostic. The repeated panel behavior and weak style transfer must be separated into model, checkpoint and prompt contributions with a LoRA-off/LoRA-on reproduction control.

**Winner:** image 365. Stop iterating on this Shrieker prompt until the model control is complete.

### Control 15 — Exact training-caption reproduction — 2026-09-04

Render the untouched `ygo4_0035` caption for `Salamandra, the Flying Flame Dragon` with the same seed and graph in two conditions:

- **A:** current LoRA strength `0.0`;
- **B:** current LoRA strength `1.0`.

Compare both outputs with the corresponding official training artwork. Because the caption is copied byte-for-byte from the released dataset, this removes new-prompt design as a confound.

#### Verified mapping

- **Official:** released `training/ygo4_0035.png`.
- **A:** `ComfyUI_00368_.png`, LoRA strength `0.0`.
- **B:** `ComfyUI_00369_.png`, current step-3500 LoRA strength `1.0`.
- **Locked:** exact released caption, seed `573928216989127`, direct JSON route, generator OFF, Quality preset, Euler sampler, CFG `7`, late CFG `3.5`, square 1-megapixel output and Ideogram 4 base.
- **Validity:** controlled LoRA-off/LoRA-on test.

#### Result

Both outputs are coherent full-bleed illustrations. Therefore JSON, a full-frame box and this workflow do not inherently cause the checkerboard/panel failure. The current LoRA is loading and has a strong visible effect:

- B shifts toward bright yellow-white flame and stronger red/yellow separation;
- B gains crisp graphic contours and luminous edge treatment;
- B's contrast and edge density move closer to the official reference;
- B looks more like polished card artwork than A's dark painterly fantasy image.

The LoRA does not reproduce the official composition or its abstract flame anatomy. At strength `1.0`, B also introduces very smooth outlines and conspicuous repeated tube segments. It is closer to the learned distribution, but may be over-constrained by the current inference guidance or checkpoint strength.

| Image | LoRA | Contrast | Edge density | Mean saturation |
|---|---:|---:|---:|---:|
| Official | — | 0.262 | 0.097 | 0.757 |
| 00368 | 0.0 | 0.168 | 0.105 | 0.974 |
| 00369 | 1.0 | 0.231 | 0.092 | 0.886 |

#### Rule learned

The LoRA is operational. The failed A.I.P series cannot be blamed on a dead loader or JSON alone. Diagnose inference guidance and LoRA strength before redesigning the A.I.P prompt.

### Control 16 — Training caption at CFG 4 — 2026-09-04

Use image 369 as A. Keep the exact training caption, seed, LoRA strength `1.0` and all other settings unchanged; reduce only main CFG from `7` to `4`, matching the guidance used by the release training validation recipe. Keep late CFG at `3.5`.

#### Result

`ComfyUI_00370_.png` verifies LoRA strength `1.0`, main CFG `4.0`, late CFG `3.5`, the locked seed and exact released caption. Relative to image 369 at CFG 7:

- rigid tube-like body segments largely become continuous flame ribbons;
- the anatomy is more thoroughly constructed from the prompted element;
- the image gains brightness and better internal flow;
- edge density moves from `0.092` to `0.097`, exactly matching the official reference's measured value;
- the composition remains more circular and conventionally dragon-like than the official artwork;
- mean saturation rises from `0.886` to `0.928`, so lower CFG does not universally reduce saturation.

#### Rule learned

Use main CFG `4` as the current Ideogram 4 + `hclar52` baseline. It better matches the training validation recipe and materially improves structural fluidity. Keep late CFG at `3.5` until separately tested. Do not claim that lower CFG always reduces saturation.

**Winner:** image 370 at CFG 4.

### Trial 17 — Training-matched A.I.P reset — 2026-09-04

Abandon the accumulated Shrieker prompt. Use a new caption patterned directly on the released Monster captions:

- exact `A Beast-type MONSTER card artwork showing the following scene:` opening;
- one full-frame object box `[0, 0, 996, 996]`;
- one object containing creature and attached action;
- a concise environmental background;
- no negative prompt;
- `hclar52 card illustration` as the entire `art_style` value;
- CFG `4`, late CFG `3.5`, LoRA strength `1.0`.

This tests the complete inference recipe rather than another isolated wording change.

#### Result

`ComfyUI_00371_.png` is the first successful A.I.P composition in the series:

- full-bleed scene with no panel or checkerboard;
- one coherent creature interacting with one environment;
- strong upper-left to lower-right attack diagonal;
- large foreshortened claws create foreground depth;
- broken wall masses frame the subject without becoming a detailed background;
- cyan backlight, orange eye and mouth establish readable focal accents;
- the silhouette remains legible at card-thumbnail scale.

The result still falls short of the official Monster distribution in finish. It is unusually smooth, low-contrast and bilaterally balanced, with a very large unified salient mass.

| Metric | Image 371 | Official Monster percentile |
|---|---:|---:|
| Edge density | 0.129 | 2nd |
| Outer-to-center edge ratio | 0.531 | 2nd |
| Symmetry | 0.875 | 97th |
| Diagonal edge share | 0.503 | 87th |
| Luminance contrast | 0.133 | below sampled range |
| Mean saturation | 0.523 | 84th |
| Focal-luma separation | 0.147 | 56th |
| Peak component area | 0.175 | 98th |

#### Rule learned

Match the released caption grammar before adding compositional inventions. CFG 4 plus a concise training-shaped prompt produces a substantially more authentic card structure. However, LoRA strength `1.0` may be flattening texture and contrast.

### Trial 18 — LoRA strength 0.7 — provisional user verdict

Use image 371 as A. Keep the complete prompt, full-frame box, seed, CFG `4`, late CFG `3.5` and every other setting unchanged. Reduce both model LoRA strengths from `1.0` to `0.7`.

#### Hypothesis

Lower LoRA strength may retain the learned Yu-Gi-Oh composition while allowing more base-model material variation, localized contrast and edge detail. Reject the change if it loses the coherent card-art structure or returns to generic painterly fantasy rendering.

The user reports that the 0.7 result looks worse. No source PNG was supplied for metadata or metric verification, so this remains a provisional visual verdict. Retain LoRA strength `1.0` as the production baseline unless the lower-strength image is later audited and establishes a narrower benefit.

## A.I.P full-set redesign rules — 2026-09-04

The 36-prompt, three-variant A.I.P redesign uses the following production rules:

1. Match the released caption schema and vocabulary distribution rather than writing an art-director checklist.
2. Begin with the correct card class: Monster, Xyz Monster, Field Spell, Normal Trap or Continuous Trap.
3. Give each image one dominant visual event. Spell and Trap art depicts a cause-and-effect incident rather than posing a mascot.
4. Use one coherent object element. Creature, motion and attached effects belong in the same description.
5. Use a full-canvas `[0, 0, 996, 996]` box for this batch. Do not use inset boxes until panel behavior is solved reliably.
6. Keep object descriptions within the dataset's 30–60-word range and high-level descriptions below 50 words.
7. Use `hclar52 card illustration` as the entire `art_style` value. Put subject-specific appearance into aesthetics, lighting and concrete object description.
8. Do not mention the A.I.P archetype name inside model-facing prompt text. Replace lore labels with visible anatomy, material, color and action.
9. Do not use negative prompts or production phrases such as `breathing room`, `fully visible`, `contained in frame`, `silhouette` or `middle distance`.
10. Maintain a shared visual language without cloning one creature: black-green artificial biology, sparse red channels, orange sensory organs, pale claws, cyan laboratory light and red-black material orbs.
11. Provide three meaningfully different concepts per card: identity-forward, effect-forward and lore/environment-forward.
12. Use main CFG `4.0`, late CFG `3.5`, LoRA strength `1.0`, generator OFF and square 1-megapixel generation as the current baseline. The 0.7-strength experiment received a worse provisional visual verdict.
