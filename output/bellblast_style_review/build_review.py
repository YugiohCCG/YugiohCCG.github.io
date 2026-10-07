"""Read-only audit of source images; produce revised prompt and review artifacts."""
import collections
import hashlib
import html
import json
from pathlib import Path

from PIL import Image, ImageDraw, ImageFont

HERE = Path(__file__).resolve().parent
DATA = HERE.parent / 'yugioh_ideogram4_500'
rows = json.loads((DATA / 'selection/image-manifest.json').read_text(encoding='utf-8'))
hashes = collections.defaultdict(list)
modes = collections.Counter()
sizes = collections.Counter()
for row in rows:
    path = DATA / row['image_file']
    with Image.open(path) as im:
        im.load()
        modes[im.mode] += 1
        sizes[str(im.size)] += 1
        key = hashlib.sha256(im.convert('RGB').tobytes()).hexdigest()
    hashes[key].append(row['dataset_id'])
stats = {
    'scope': 'Local images only; not verified against the unavailable release archive or training run.',
    'images_decoded': len(rows),
    'manifest_category_counts': dict(collections.Counter(r['card_category'] for r in rows)),
    'image_modes': dict(modes),
    'image_sizes': dict(sizes),
    'caption_files_present': len(list((DATA / 'captions').glob('*.json'))),
    'unique_decoded_rgb_images': len(hashes),
    'exact_duplicate_groups': [v for v in hashes.values() if len(v) > 1],
    'visual_review': {'contact_sheets': 20, 'images_per_sheet': 25, 'coverage': '0001-0500', 'individual_enlargements': [21, 25, 112, 128, 231, 268, 283, 470]},
}
(HERE / 'dataset_audit.json').write_text(json.dumps(stats, indent=2) + '\n', encoding='utf-8')

def prompt(summary, aesthetics, lighting, palette, background, elements):
    return {
        'high_level_description': 'A Warrior-type MONSTER card artwork showing the following scene: ' + summary,
        'style_description': {
            'aesthetics': aesthetics,
            'lighting': lighting,
            'medium': 'illustration',
            'art_style': 'hclar52 card illustration',
            'color_palette': palette,
        },
        'compositional_deconstruction': {'background': background, 'elements': elements},
    }

cards = [
    {
        'card_name': 'Bellblast Rookie - Rika',
        'reference_ids': ['ygo4_0021', 'ygo4_0231', 'ygo4_0283'],
        'design_intent': 'Replace the frontal toy-cannon cutout with a readable lateral recoil pose. Repeat a split-star motif through uniform and launcher.',
        'prompt': prompt(
            'a copper-haired schoolgirl swings a red shoulder bazooka toward the upper left while bracing one boot against a rooftop parapet.',
            'spirited academy artillery, angular star motifs, a bold diagonal gesture with the face and sailor collar clearly visible',
            'clear cool daylight, hard warm reflections on red metal, a small white discharge flash and deep blue shadows beneath the jacket',
            ['#234F83', '#D63B43', '#F1EBDA', '#263047', '#EFBE48'],
            'A pale turquoise sky fills the square to every edge behind slanting white clouds and fine golden discharge rays. A blue-gray school parapet crosses the lower right, with chalky dust lifting from the planted boot. Three loose sheets trail sideways through the recoil wake at different depths.',
            [
                {'type': 'obj', 'bbox': [80, 250, 980, 970], 'desc': 'A copper-haired schoolgirl with swept pointed twin-tails and a determined sideways smile twists her torso left. Her navy sailor jacket has an ivory angular collar, red split-star neck ribbon and flared cuffs. A pleated skirt, opaque tights, red-trimmed boots and square schoolbag complete the uniform. Both hands brace the shoulder launcher; her forward boot presses against the parapet.'},
                {'type': 'obj', 'bbox': [180, 30, 550, 780], 'desc': 'A long red shoulder bazooka angles upward to the left, showing its broad side panel and a narrow oval muzzle. Stepped ivory plates, dark rectangular vents and a gold split-star sight echo the uniform. A schoolbag-style strap loops underneath. The rear rests against her right shoulder while the grips remain below her unobscured face.'},
            ],
        ),
    },
    {
        'card_name': 'Bellblast Quartermaster - Emi',
        'reference_ids': ['ygo4_0128', 'ygo4_0268'],
        'design_intent': 'A composed reload identity with a full graphic background, not a detailed music-room diorama or a display of a separate weapon.',
        'prompt': prompt(
            'a bespectacled schoolgirl slides a luminous shell into the open breech of an upright shoulder bazooka beside her unfolded schoolbag.',
            'precise, self-assured academy artillery, elegant vertical silhouette, repeated split-star and cartridge shapes',
            'cool mint ambient light with narrow gold metal highlights and localized amber shell light across the gloves',
            ['#23483F', '#DBEAD9', '#273047', '#D4AB55', '#BA4149'],
            'An opaque mint and deep-green magical backdrop fills the square. Broad diagonal bands resembling folded notebook corners alternate with thin gold trajectories and tiny diamond sparks. The pale central region separates the dark uniform, while darker green planes continue beyond all four edges.',
            [
                {'type': 'obj', 'bbox': [60, 280, 980, 830], 'desc': 'A green-haired schoolgirl with a blunt bob and narrow round spectacles stands with one knee slightly bent. Her navy sailor jacket has an ivory angular collar, red split-star ribbon and white gloves. A pleated skirt, opaque tights and brass-buckled boots complete her uniform. One hand steadies the upright launcher while the other slides a shell into its breech.'},
                {'type': 'obj', 'bbox': [90, 80, 940, 480], 'desc': 'A tall forest-green bazooka stands beside the girl with its muzzle pointing upward and the rear braced near her boot. Stepped ivory plating surrounds an open rectangular breech. A gold split-star sight and dark cooling slots repeat the academy equipment motif. One amber-tipped cartridge is halfway inside the side opening.'},
                {'type': 'obj', 'bbox': [670, 640, 970, 980], 'desc': 'An unfolded navy schoolbag rests beside the girl, its rigid interior holding three large ivory cartridges in dark fitted sleeves. The flap bears a small gold split-star clasp. One empty sleeve and a loose red carrying strap make the bag read as equipment currently being used.'},
            ],
        ),
    },
    {
        'card_name': 'Bellblast Hall Monitor - Shiori',
        'reference_ids': ['ygo4_0268', 'ygo4_0283', 'ygo4_0470'],
        'design_intent': 'Make discipline legible through posture, directional blast and matching equipment rather than a huge blank shield hiding the character.',
        'prompt': prompt(
            'a dark-haired schoolgirl slides into a defensive stance and fires a shield-braced bazooka sideways across a school corridor.',
            'stern, forceful academy artillery, angular defensive silhouette and a sharply directed burst',
            'cold window light with a concentrated yellow-white muzzle flash, blue garment shadows and crimson equipment reflections',
            ['#263C68', '#DDEBF0', '#B73249', '#E3B74C', '#708AA6'],
            'A tilted blue school corridor continues to the edges, its broad windows and floor seams converging toward the upper right. White pressure streaks cut horizontally across the space from the weapon. A fan of floor dust follows the sliding boot; distant door shapes remain simple and clearly drawn.',
            [
                {'type': 'obj', 'bbox': [70, 320, 980, 960], 'desc': 'A long dark-haired schoolgirl with narrow focused eyes braces in a wide sideways stance. Her navy sailor jacket has an ivory angular collar, red split-star ribbon and crimson armband. A pleated skirt, opaque tights and squared boots complete the uniform. Her torso and stern face remain visible above the launcher, with both hands locked around its grips.'},
                {'type': 'obj', 'bbox': [310, 10, 720, 780], 'desc': 'An ivory shoulder bazooka points toward the left edge, its narrow barrel supported by a navy folding shield plate beneath the foregrip. Two angular shield wings resemble a split school ribbon. Red reinforcement bars and a gold star-shaped sight link it to the uniform. A short jagged white flash exits the muzzle.'},
            ],
        ),
    },
    {
        'card_name': 'Bellblast Captain - Reina, Final Bell',
        'reference_ids': ['ygo4_0112', 'ygo4_0231', 'ygo4_0283'],
        'design_intent': 'Escalate the same uniform-and-launcher design into a boss image. One captain and an asymmetrical pair of long weapons, rather than six repeated tubes around a small central figure.',
        'prompt': prompt(
            'a silver-haired schoolgirl captain turns above a school bell tower with two linked bazookas unfolding around her as golden discharge paths sweep across the sky.',
            'commanding academy artillery, sweeping asymmetry, a prominent face framed by long angular weapon silhouettes',
            'brilliant gold discharge light against saturated blue sky, crisp ivory armor highlights and deep violet cloth shadows',
            ['#243D88', '#E8ECF2', '#CC354D', '#F0C353', '#563C76'],
            'A deep cobalt sky fills the image, crossed by long white cloud streaks and two curved gold discharge paths. A school bell tower rises from the lower left, its bronze bell catching the same gold light as the equipment. Rays and clouds continue beyond the square, with a pale opening behind the captain\u2019s face.',
            [
                {'type': 'obj', 'bbox': [80, 280, 970, 910], 'desc': 'A silver-haired schoolgirl captain turns left with an assured expression and one knee raised. Her navy sailor jacket carries an oversized ivory collar, crimson split-star ribbon and narrow gold shoulder trim. A pleated skirt, opaque tights and ivory-cuffed boots preserve the academy uniform. Long ribbon tails stream behind her as both hands control separate launcher grips.'},
                {'type': 'obj', 'bbox': [180, 0, 690, 850], 'desc': 'A long ivory and crimson bazooka crosses below the captain\u2019s face toward the left edge, presenting stepped side armor rather than an enlarged circular opening. A split-star gold sight rises above dark cooling slots. Its rear joins a compact navy schoolbag harness through one articulated brass support.'},
                {'type': 'obj', 'bbox': [30, 560, 800, 990], 'desc': 'A second matching bazooka unfolds behind the captain\u2019s opposite shoulder, angled upward toward the right. Its smaller visible muzzle and receding ivory panels establish depth. Crimson stabilizer fins open like pointed ribbon ends, while one curved brass arm links the rear chamber to the same compact backpack harness.'},
            ],
        ),
    },
]

validation = []
for index, card in enumerate(cards, 1):
    p = card['prompt']
    assert list(p) == ['high_level_description', 'style_description', 'compositional_deconstruction']
    assert list(p['style_description']) == ['aesthetics', 'lighting', 'medium', 'art_style', 'color_palette']
    assert len(p['high_level_description'].split()) <= 50
    assert json.dumps(p).count('hclar52') == 1
    assert p['style_description']['medium'] == 'illustration'
    palette = p['style_description']['color_palette']
    assert 1 <= len(palette) <= 16 and len(set(palette)) == len(palette)
    for c in palette:
        assert len(c) == 7 and c[0] == '#' and all(x in '0123456789ABCDEF' for x in c[1:])
    counts = []
    for el in p['compositional_deconstruction']['elements']:
        n = len(el['desc'].split())
        assert 30 <= n <= 60, (index, n, el['desc'])
        counts.append(n)
        y1, x1, y2, x2 = el['bbox']
        assert 0 <= y1 < y2 <= 1000 and 0 <= x1 < x2 <= 1000
    assert 'Bellblast' not in json.dumps(p)
    (HERE / f'0{index}_prompt.json').write_text(json.dumps(p, ensure_ascii=False, indent=2) + '\n', encoding='utf-8')
    validation.append({'card_name': card['card_name'], 'summary_words': len(p['high_level_description'].split()), 'element_words': counts, 'schema_checks': 'passed'})

pack = {
    'version': '2.0-reference-reviewed-unrendered',
    'canvas': {'width': 2048, 'height': 2048},
    'prompt_policy': 'Names and reference IDs are administrative metadata. Paste only the prompt object into the existing structured encoder. Bboxes use [y_min,x_min,y_max,x_max]. Canvas is a retained pack default, not a tested resolution recommendation. No workflow or negative-conditioning changes are implied.',
    'render_status': 'Not generated or visually validated. Prompt and design hypotheses based on review of 500 local reference images and three user-supplied results.',
    'cards': cards,
}
(HERE / 'bellblast_ideogram4_prompts_v2.json').write_text(json.dumps(pack, ensure_ascii=False, indent=2) + '\n', encoding='utf-8')
(HERE / 'prompt_validation.json').write_text(json.dumps(validation, indent=2) + '\n', encoding='utf-8')
md = ['# Bellblast revised structured prompts', '', 'Reference-reviewed proposals; generation results have not been tested.', '', 'Paste one JSON object into the existing structured prompt input. Keep your model, seed, sampler, guidance, resolution, LoRA setup and negative conditioning unchanged for the first comparison. The supplied objects already are structured prompts.', '']
for i, card in enumerate(cards, 1):
    md += [f"## {i}. {card['card_name']}", '', card['design_intent'], '', 'Reference image IDs: ' + ', '.join(card['reference_ids']) + '.', '', '```json', json.dumps(card['prompt'], ensure_ascii=False, indent=2), '```', '']
(HERE / 'revised_prompts.md').write_text('\n'.join(md), encoding='utf-8')

references = [
    (21, 'Costume, equipment and ribbons share a motif.'),
    (25, 'Large prop; face and gesture still remain readable.'),
    (112, 'Weapon side profile; effects cross multiple depths.'),
    (128, 'Iconic pose works with a designed abstract backdrop.'),
    (231, 'Hair, sleeves and weapon follow one strong gesture.'),
    (268, 'Static stance works; motif repeats across the uniform.'),
    (283, 'Angular costume shapes; selective face and hand detail.'),
    (470, 'Sideways attack; environment supports the direction.'),
]
font = ImageFont.truetype('C:/Windows/Fonts/arial.ttf', 20)
small = ImageFont.truetype('C:/Windows/Fonts/arial.ttf', 17)
sheet = Image.new('RGB', (1600, 920), '#F4F2ED')
draw = ImageDraw.Draw(sheet)
for i, (number, note) in enumerate(references):
    x, y = (i % 4) * 400, (i // 4) * 460
    with Image.open(DATA / 'images' / f'ygo4_{number:04d}.png') as im:
        thumb = im.convert('RGB').resize((392, 392), Image.Resampling.LANCZOS)
    sheet.paste(thumb, (x + 4, y + 4))
    draw.text((x + 8, y + 398), f'ygo4_{number:04d}', font=font, fill='#171D27')
    import textwrap
    draw.multiline_text((x + 8, y + 424), '\n'.join(textwrap.wrap(note, 48)), font=small, fill='#273047', spacing=1)
sheet.save(HERE / 'relevant_reference_board.jpg', quality=94)
print(json.dumps({'audit': stats, 'prompt_validation': validation}, indent=2))
