import copy
import json
import re
import zipfile
from pathlib import Path

ROOT = Path(__file__).resolve().parent
OUT = ROOT / 'bellblast_experiments_v5'
OUT.mkdir(exist_ok=True)
(OUT / 'prompts').mkdir(exist_ok=True)
source = (ROOT / 'bellblast_v4_prompts.md').read_text(encoding='utf-8')
bases = [json.loads(s) for s in re.findall(r'```json\s*(.*?)\s*```', source, re.S)]
assert len(bases) == 4
names = ['Rika', 'Emi', 'Shiori', 'Reina']
records = []

def add(pid, char, title, group, change, prompt, baseline=None):
    records.append(dict(id=pid, character=char, title=title, group=group,
                        compare_to=baseline, change=change, prompt=prompt))

for i, (name, base) in enumerate(zip(names, bases), 1):
    add(f'C{i:02}', name, 'V4 control', 'control', 'Exact copy of the corresponding V4 prompt.', copy.deepcopy(base))

styles = [
    ('Hard cel planes', 'hclar52 card illustration, clean anime digital illustration with vibrant flat colors, two-tone cel shadows, fine defined line work and small sharp metal highlights'),
    ('Painted card finish', 'hclar52 card illustration, expressive anime drawing with tapered colored outlines, opaque painted shading, subtle brush texture and carefully defined material edges'),
    ('Graphic anime finish', 'hclar52 card illustration, modern anime digital art with clean vector-like line work, broad simplified color shapes, selective soft gradients and crisp graphic highlights'),
]
for variant, (title, style) in enumerate(styles, 1):
    for i, (name, base) in enumerate(zip(names, bases), 1):
        p = copy.deepcopy(base)
        p['style_description']['art_style'] = style
        add(f'R{variant}{i}', name, title, 'rendering', 'Only style_description.art_style changes.', p, f'C{i:02}')

weapons = [
    ('Heavy cylindrical construction', 'An absurdly enormous crimson bazooka has a straight torso-thick launch tube longer than its wielder is tall. A broad circular bore, thick ivory muzzle collar, navy shoulder cradle, gold star crest and exposed brass braces define its construction. Flat shadow bands and narrow edge highlights describe the heavy cylindrical metal.'),
    ('Sculpted fantasy construction', 'An absurdly enormous crimson bazooka has a torso-thick launch tube longer than its wielder is tall. Three swept ivory armor fins surround its broad circular muzzle; angular navy braces connect the heavy tube to its shoulder cradle. A gold star crest and brass fasteners repeat the academy uniform ornamentation.'),
]
for variant, (title, desc) in enumerate(weapons, 1):
    for i, (name, base) in enumerate(zip(names, bases), 1):
        p = copy.deepcopy(base)
        d = desc
        if name == 'Emi':
            d = d.replace('An absurdly enormous crimson bazooka has', 'An absurdly enormous crimson bazooka on a tiny book trolley has')
        if name == 'Reina':
            d = d.replace('a straight torso-thick launch tube', 'two straight torso-thick launch tubes').replace('a torso-thick launch tube', 'two torso-thick launch tubes')
        p['compositional_deconstruction']['elements'][1]['desc'] = d
        add(f'W{variant}{i}', name, title, 'weapon wording', 'Only the weapon element description changes; construction details are intentionally a bundle.', p, f'C{i:02}')

for i, (name, base) in enumerate(zip(names, bases), 1):
    p = copy.deepcopy(base)
    for el in p['compositional_deconstruction']['elements']:
        del el['bbox']
    add(f'B{i:02}', name, 'No bounding boxes', 'layout conditioning', 'Only the two optional bbox keys are removed. All prose is identical.', p, f'C{i:02}')

for i, (name, base) in enumerate(zip(names, bases), 1):
    p = copy.deepcopy(base)
    p['style_description']['lighting'] = 'even diffuse daylight, clear local colors, compact cool shadows under overlapping forms, restrained reflections and a single small highlight in each eye'
    add(f'L{i:02}', name, 'Diffuse daylight', 'lighting', 'Only style_description.lighting changes.', p, f'C{i:02}')

uniform = 'She wears a navy sailor jacket, oversized ivory collar, crimson ribbon, gold star clasp, pleated skirt, opaque tights and reinforced boots.'
scenes = [
    (0, 'Desk sled',
     'a copper-haired academy girl rides a school desk across the courtyard while firing a bazooka larger than herself.',
     'A school desk skids diagonally over courtyard paving, throwing up short angular chips. Its legs bend backward under the load. A compact golden blast exits the left edge; the academy entrance and a crimson pennant remain clearly painted behind the action.',
     'A young adult academy girl with pointed copper twin tails and a mischievous grin kneels securely on a sliding school desk, bracing both hands on her shoulder bazooka.',
     [120,350,850,970], [220,0,650,1000]),
    (0, 'Overloaded backpack',
     'a copper-haired academy girl charges up school steps with an enormous bazooka sticking out of her reinforced school backpack.',
     'Broad academy steps climb diagonally past a navy railing toward open doors. Two fallen exercise books tumble behind the runner. Clear turquoise sky separates her copper hair from the massive launcher rising over her shoulder.',
     'A young adult academy girl with pointed copper twin tails and a determined grin leans sharply forward, running uphill with both hands gripping the straps of her overloaded backpack.',
     [150,320,990,950], [0,100,750,800]),
    (1, 'Manual versus machinery',
     'a green-haired academy quartermaster calmly reads an instruction booklet while sitting on an absurdly enormous bazooka.',
     'An academy supply room contains neatly stacked books and ivory storage cases. The enormous bazooka rests securely across two low ammunition crates. A tiny open toolbox on the floor emphasizes its scale; clear window light separates each object.',
     'A young adult academy girl with a neat green bob, round spectacles and a thoughtful expression sits upright on her grounded bazooka, holding an open instruction booklet in both hands.',
     [50,400,850,900], [470,0,940,1000]),
    (1, 'Trolley runaway',
     'a green-haired academy quartermaster hangs onto a tiny trolley as its enormous bazooka rolls down a sloping school corridor.',
     'A sloping academy passage recedes toward open courtyard doors. A tiny trolley tilts on its two wheels beneath the enormous launcher. Loose exercise books slide along the floor, following the same diagonal as the rolling equipment.',
     'A young adult academy girl with a neat green bob, round spectacles and an indignant expression leans backward, gripping the runaway trolley handle while both boots skid along the floor.',
     [120,450,970,1000], [220,0,850,730]),
    (2, 'Silent checkpoint',
     'a stern black-haired academy prefect stands beside a gigantic upright bazooka at the school gates.',
     'Tall ivory academy gateposts frame a turquoise sky and a crimson pennant. The gigantic bazooka stands vertically beside the prefect with its rear planted on the paving. A tiny confiscated paper airplane rests on the massive muzzle collar.',
     'A young adult academy girl with straight black hair and narrow focused eyes stands calmly beside her upright bazooka, one gloved hand resting on its grip and the other raised for silence.',
     [100,480,990,950], [0,30,1000,540]),
    (2, 'Landing interception',
     'a black-haired academy prefect pivots on a stair landing and aims an enormous bazooka across the descending staircase.',
     'An academy stairwell is viewed from above, with strong zigzag railings and ivory steps. The huge launcher crosses the stair geometry on a contrasting diagonal. The prefect\'s trailing black hair and crimson ribbon describe her sharp turn.',
     'A young adult academy girl with straight black hair and a severe focused expression pivots on one planted boot, gripping her immense shoulder bazooka with both hands as her jacket swings outward.',
     [130,350,970,960], [200,0,720,1000]),
    (3, 'Captain at assembly',
     'a silver-haired academy captain commands the morning assembly beside a double-barreled bazooka larger than the ceremonial podium.',
     'An outdoor academy assembly platform carries a tiny wooden podium and an enormous grounded launcher. A crimson school pennant rises behind the captain. Ivory architecture and turquoise sky form broad clear shapes around the commanding silhouette.',
     'A young adult academy captain with swept silver hair and a composed smile stands beside her immense grounded bazooka, resting one gloved hand on its carry handle and raising the other decisively.',
     [40,450,980,980], [300,0,970,800]),
    (3, 'Storm-facing salute',
     'a silver-haired academy captain raises a colossal double-barreled bazooka toward the sky from a windswept clock-tower balcony.',
     'A clock-tower balcony overlooks distant academy roofs. Broad painted turquoise clouds sweep behind the enormous twin launcher. A crimson pennant and the captain\'s short cape stream sideways; small golden charging lights illuminate the two deep barrel interiors.',
     'A young adult academy captain with swept silver hair and a confident smile braces one boot on a low stone step, raising her immense shoulder bazooka diagonally with both gloved hands.',
     [180,370,990,970], [0,0,740,850]),
]
for n, (idx, title, scene, bg, char, cb, wb) in enumerate(scenes, 1):
    p = copy.deepcopy(bases[idx])
    p['high_level_description'] = 'A Warrior-type MONSTER card artwork showing the following scene: ' + scene
    p['compositional_deconstruction'] = dict(background=bg, elements=[
        dict(type='obj', bbox=cb, desc=char + ' ' + uniform),
        dict(type='obj', bbox=wb, desc=('An absurdly enormous crimson double-barreled bazooka has two thick parallel launch tubes in one housing, each with a deep circular bore.' if idx == 3 else 'An absurdly enormous crimson bazooka has a straight cylindrical launch tube longer than its wielder is tall and as thick as her torso.') + ' Broad ivory muzzle collars, stepped armor plates, a navy shoulder cradle, brass fasteners and a gold star crest define its heavy construction.')])
    add(f'S{n:02}', names[idx], title, 'scene exploration', 'Pose, action, background and object placement change together. Exploratory scene, not an isolated technique test.', p, f'C{idx+1:02}')

assert len(records) == 40
for r in records:
    p = r['prompt']
    assert list(p) == ['high_level_description','style_description','compositional_deconstruction']
    assert len(p['high_level_description'].split()) <= 50, r['id']
    assert json.dumps(p).count('hclar52') == 1
    for el in p['compositional_deconstruction']['elements']:
        assert 30 <= len(el['desc'].split()) <= 60, (r['id'],len(el['desc'].split()))
        if 'bbox' in el:
            y0,x0,y1,x1 = el['bbox']
            assert 0 <= y0 < y1 <= 1000 and 0 <= x0 < x1 <= 1000
    if r['group'] in ['rendering','lighting']:
        baseline = copy.deepcopy(bases[names.index(r['character'])])
        field = 'art_style' if r['group']=='rendering' else 'lighting'
        baseline['style_description'][field] = p['style_description'][field]
        assert baseline == p
    if r['group'] == 'layout conditioning':
        baseline = copy.deepcopy(bases[names.index(r['character'])])
        for el in baseline['compositional_deconstruction']['elements']:
            del el['bbox']
        assert baseline == p
    (OUT/'prompts'/f"{r['id']}_{r['character']}.json").write_text(json.dumps(p,ensure_ascii=False,indent=2)+'\n',encoding='utf-8')

guide = '''# Bellblast V5: 40 prompt experiments

These are untested prompt experiments for the existing Ideogram 4 workflow. They preserve the academy uniforms, crimson/ivory/navy weapons, gold star emblem and comically huge bazookas. Warrior is a provisional archetype card type.

## How to run and return results

1. Paste only the JSON object into the structured prompt input. IDs and titles are administrative labels, not prompt text.
2. Use the same two seeds for every prompt in the first pass. Keep the checkpoint, both LoRA strengths, sampler, scheduler, steps, guidance, resolution and any upscaling unchanged. This gives 80 images and two comparable examples per prompt, not a statistical ranking.
3. A practical starting set of 16 prompts is C01-C04, R11-R14, R21-R24 and B01-B04. Then run R31-R34, W11-W14, W21-W24, L01-L04 and S01-S08.
4. Save results with their prompt ID and seed, for example R11_Rika_seed12345.png. Preserve the embedded ComfyUI workflow/prompt if possible. Do not place the ID inside the generated artwork prompt.
5. Zip the results and share them back. Include workflow/settings if your export strips metadata. The review_template.json is optional; filenames plus embedded settings are enough to begin review.
6. After review, combine the strongest rendering, lighting and weapon treatments into new prompts and check them on fresh seeds. Do not assume individually successful changes will combine successfully.

The previous rookie workflow used the 3500 LoRA checkpoint, strength 1.0 on both model branches and Euler. Those are continuity references, not claimed optimal settings. Use the rest of your existing workflow unchanged for this prompt comparison.

## What each group tests

| Group | Count | Change |
|---|---:|---|
| C01-C04 | 4 | Exact V4 controls, one per character |
| R11-R14 | 4 | art_style only: harder cel-shadow rendering |
| R21-R24 | 4 | art_style only: painted finish and colored outlines |
| R31-R34 | 4 | art_style only: graphic shapes and selective gradients |
| W11-W14 | 4 | Weapon description only: heavy straight cylindrical construction |
| W21-W24 | 4 | Weapon description only: sculpted fantasy fins and braces |
| B01-B04 | 4 | Remove bbox keys only; keep identical prose |
| L01-L04 | 4 | Lighting description only: diffuse daylight |
| S01-S08 | 8 | New scenes; several composition variables change together |

Every four-prompt technique group uses character order Rika, Emi, Shiori, Reina. Compare each experiment against its listed control at the same seed. The bounding-box experiment tests presence versus absence; it does not test resolution. The weapon groups test bundles of construction wording, not individual adjectives. Scene experiments test ideas and readability, not isolated rendering techniques.

## Review criteria

Rate each result from 1 (poor) to 5 (strong): similarity to the selected official humanoid-combat references; archetype consistency; comically huge but recognizable bazooka; clear face and silhouette at card size; readable pose/action; clean anatomy and object connections. Also record a short note on the most obvious failure. Compare all attempted outputs, including failures, rather than selecting only the prettiest seed.

The comparison should use the actual training folder, particularly ygo4_0021, ygo4_0231, ygo4_0268 and ygo4_0283, rather than treating all official Yu-Gi-Oh artwork as one uniform rendering style. A prompt win is provisional until it holds across characters and fresh seeds.

## Prompt index

'''
guide += '\n'.join(f"- **{r['id']} — {r['character']}: {r['title']}**. Compare with {r['compare_to'] or 'itself as control'}." for r in records)
(OUT/'README.md').write_text(guide+'\n',encoding='utf-8')
pack = '# Bellblast V5 — all 40 copy/paste prompts\n\nPaste only one JSON object at a time. See README.md for test order and review instructions. All prompts are untested.\n\n'
for r in records:
    pack += f"## {r['id']} — {r['character']}: {r['title']}\n\n{r['change']} Compare with: {r['compare_to'] or 'control'}.\n\n```json\n{json.dumps(r['prompt'],ensure_ascii=False,indent=2)}\n```\n\n"
(OUT/'ALL_PROMPTS.md').write_text(pack,encoding='utf-8')
(OUT/'manifest.json').write_text(json.dumps([{k:v for k,v in r.items() if k!='prompt'} for r in records],indent=2)+'\n',encoding='utf-8')
template = dict(settings=dict(checkpoint=None,lora_strengths=None,sampler=None,scheduler=None,steps=None,guidance=None,width=None,height=None,other=None),results=[dict(prompt_id=r['id'],seed=None,filename=None,scores=dict(reference_similarity=None,archetype_consistency=None,bazooka_scale_and_identity=None,card_size_readability=None,action_clarity=None,anatomy_and_connections=None),notes='') for r in records])
(OUT/'review_template.json').write_text(json.dumps(template,indent=2)+'\n',encoding='utf-8')
archive = ROOT / 'bellblast_experiments_v5.zip'
with zipfile.ZipFile(archive,'w',zipfile.ZIP_DEFLATED) as z:
    for path in sorted(OUT.rglob('*')):
        if path.is_file():
            z.write(path,Path(OUT.name)/path.relative_to(OUT))
print(json.dumps(dict(prompts=len(records),validated=True,folder=str(OUT),archive=str(archive)),indent=2))
