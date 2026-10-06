import copy
import json
import uuid
from pathlib import Path

ROOT = Path(__file__).resolve().parent
OUT = ROOT / 'bellblast_v6_trio'
OUT.mkdir(exist_ok=True)
(OUT / 'workflows').mkdir(exist_ok=True)
base_path = ROOT / 'bellblast_experiments_v5/queued_workflows/S08_Reina_seed751299600367585.json'
base_workflow = json.loads(base_path.read_text(encoding='utf-8'))
style = {
    'aesthetics': 'playful fantasy academy artillery, one expressive young adult heroine, impossibly oversized equipment, a strong readable silhouette within a full-bleed illustrated scene',
    'lighting': 'even diffuse daylight, clear local colors, compact cool shadows under overlapping forms, restrained reflections and a single small highlight in each eye',
    'medium': 'illustration',
    'art_style': 'hclar52 card illustration, expressive hand-drawn anime anatomy, fine tapered linework, angular cel shading, selective painted transitions and richly painted backgrounds',
    'color_palette': ['#202C48', '#B92C3E', '#F3E8CE', '#D9AE50', '#65BCD0', '#444A61']
}
uniform = 'She wears a navy sailor jacket, oversized ivory collar, crimson ribbon, gold star clasp, pleated skirt, opaque tights and reinforced boots.'
specs = [
    ('N01_Nao', 'Nao — Signal Officer',
     'a blue-haired academy signal officer braces an enormous shoulder bazooka upward from a clock-tower balcony, launching a brilliant star-shaped signal flare.',
     'A single continuous painted clock-tower balcony fills the image, with ivory parapets, turquoise sky and distant academy rooftops extending to all four edges. A small golden star flare rises above the barrel. The tower steps frame the heroine at lower right; her face stays clear beneath the diagonal launcher.',
     [270, 360, 990, 960],
     'A young adult academy woman with a long slate-blue braid, amber eyes and a compact gold headset braces one boot on a low step. Both gloved hands support the enormous launcher above her shoulder.',
     [20, 0, 650, 870],
     'A comically colossal crimson bazooka, longer than its wielder is tall and thicker than her torso, angles toward the upper left. A deep circular bore sits inside a heavy ivory collar. Stepped navy armor, brass braces, a gold star crest and a compact folding signal sight give the thick launch tube a distinctive silhouette.'),
    ('N02_Momo', 'Momo — Chemistry Quartermaster',
     'a pink-haired academy chemistry specialist struggles to steer an absurdly enormous alchemical bazooka on a tiny laboratory trolley around a corner.',
     'A single continuous painted academy laboratory fills the image edge to edge: tall cyan windows, ivory workbenches, green glass vessels and a tiled floor. The trolley turns sharply around a bench, its outer wheel lifting. A small curl of pale mint vapor escapes the barrel; the woman and machine remain fully within the room.',
     [110, 460, 990, 980],
     'A young adult academy woman with dusty-pink hair in a messy bun, green eyes and brass goggles on her forehead leans backward, gripping a laboratory trolley handle with both gloved hands.',
     [150, 0, 950, 720],
     'A comically colossal crimson bazooka rests on a tiny navy laboratory trolley, its torso-thick tube dwarfing the wheels. A deep circular bore, heavy ivory muzzle collar, stepped armor and gold star crest establish solid machinery. One small emerald glass cartridge is enclosed within the armored rear chamber, beside brass cooling fins.'),
    ('N03_Aya', 'Aya — Hurdle Gunner',
     'a violet-haired academy athletics ace clears a low training hurdle while swinging a comically enormous bazooka across her shoulder.',
     'A single continuous painted academy athletics courtyard fills the image edge to edge, with a red running track, low ivory training hurdles and navy railings against turquoise sky. A tipped hurdle and short angular dust marks follow the jump. The weapon crosses the track lines diagonally, while the face and bent legs remain clearly separated.',
     [100, 310, 980, 970],
     'A young adult academy woman with a long violet ponytail, warm brown skin and a confident grin clears a low hurdle, one knee bent forward. Both gloved hands grip her enormous shoulder bazooka.',
     [200, 0, 680, 1000],
     'A comically colossal crimson bazooka stretches across the foreground, longer than the athlete is tall and as thick as her torso. Its broad circular bore has a heavy ivory collar. Stepped navy armor, brass braces, a gold star crest and two short backward-swept stabilizer fins make the massive cylindrical weapon readable in motion.')
]
records = []
seeds = [751299600367585, 751299600367586]
for pid, title, scene, background, cb, character, wb, weapon in specs:
    prompt = {
        'high_level_description': 'A Warrior-type MONSTER card artwork showing the following scene: ' + scene,
        'style_description': copy.deepcopy(style),
        'compositional_deconstruction': {
            'background': background,
            'elements': [
                {'type': 'obj', 'bbox': cb, 'desc': character + ' ' + uniform},
                {'type': 'obj', 'bbox': wb, 'desc': weapon}
            ]
        }
    }
    assert len(prompt['high_level_description'].split()) <= 50
    assert json.dumps(prompt).count('hclar52') == 1
    for e in prompt['compositional_deconstruction']['elements']:
        assert 30 <= len(e['desc'].split()) <= 60, (pid, len(e['desc'].split()))
    text = json.dumps(prompt, ensure_ascii=False, indent=2)
    (OUT / (pid + '.json')).write_text(text + '\n', encoding='utf-8')
    record = {'id': pid, 'title': title, 'prompt': prompt, 'jobs': []}
    for seed in seeds:
        w = copy.deepcopy(base_workflow)
        w['id'] = str(uuid.uuid4())
        prefix = f'BellblastV6/{pid}_seed{seed}'
        for node in w['nodes']:
            if node['id'] == 192:
                node['widgets_values'][0] = text
                node['widgets_values_named']['value'] = text
            elif node['id'] == 160:
                node['widgets_values'][0] = seed
                node['widgets_values_named']['seed'] = seed
            elif node['id'] == 159:
                node['widgets_values'][0] = prefix
                if 'widgets_values_named' in node:
                    node['widgets_values_named']['filename_prefix'] = prefix
        name = f'{pid}_seed{seed}.json'
        (OUT / 'workflows' / name).write_text(json.dumps(w, ensure_ascii=False), encoding='utf-8')
        record['jobs'].append({'seed': seed, 'workflow': name, 'filename_prefix': prefix, 'status': 'prepared'})
    records.append(record)
(OUT / 'manifest.json').write_text(json.dumps(records, ensure_ascii=False, indent=2), encoding='utf-8')
md = '# Bellblast V6 — three new characters\n\nDerived from the 72-entry review. Keep diffuse L-series lighting, retain explicit boxes, use S08-inspired heavy shoulder staging and S04-inspired clear equipment interaction. Explicit continuous full-frame scenery addresses recurring cutout backgrounds. These combined refinements are hypotheses, not a proven rendering winner.\n\n'
md += '\n\n'.join('## ' + r['title'] + '\n\n```json\n' + json.dumps(r['prompt'], ensure_ascii=False, indent=2) + '\n```' for r in records)
(OUT / 'ALL_PROMPTS.md').write_text(md + '\n', encoding='utf-8')
print(json.dumps({'characters': len(records), 'jobs': sum(len(r['jobs']) for r in records), 'output': str(OUT)}, indent=2))
