import copy, json
from pathlib import Path
HERE=Path(__file__).resolve().parent
DATA=Path(r'C:\Manual Files\New Documents\Yugioh\Models\yugioh_ideogram4_500_release\training')
control=json.loads((DATA/'ygo4_0231.json').read_text(encoding='utf-8'))
(HERE/'reference_control_0231.json').write_text(json.dumps(control,indent=2,ensure_ascii=False)+'\n',encoding='utf-8')
adapted=copy.deepcopy(control)
adapted['high_level_description']='A Warrior-type MONSTER card artwork showing the following scene: a copper-haired schoolgirl turns sideways in a running leap while firing a heavy shoulder bazooka across a sunlit academy courtyard.'
adapted['style_description']['aesthetics']='playful anime fantasy character artwork with dynamic airborne action and explosive courtyard details'
adapted['style_description']['lighting']='warm daytime sunlight with bright yellow discharge light striking the face, sleeves and metal launcher'
adapted['style_description']['color_palette']=['#F5E2B3','#2C3446','#D84A46','#E59344','#65768D','#913337']
adapted['compositional_deconstruction']['background']='A sunlit academy courtyard with pale stone staircases, fluttering red pennants and blue window shadows. A thick curling discharge cloud passes behind the girl and across the lower foreground, carrying golden sparks and airborne fragments of paving through the warm daylight.'
adapted['compositional_deconstruction']['elements']=[{
    'type':'obj','bbox':[12,45,981,936],
    'desc':'A determined schoolgirl with copper twin tails and wide expressive eyes twists sideways in midair. She wears a navy sailor uniform with an ivory collar, red neck ribbon, pleated skirt, opaque tights and buckled boots. Both hands grip a heavy black-and-red bazooka braced against her shoulder, its flared steel muzzle discharging a jagged golden blast.'
}]
for name,p in [('reference',control),('adaptation',adapted)]:
    assert len(p['high_level_description'].split())<=50
    assert json.dumps(p).count('hclar52')==1
    for e in p['compositional_deconstruction']['elements']:
        assert 30<=len(e['desc'].split())<=60
(HERE/'rookie_reference_adaptation_v3.json').write_text(json.dumps(adapted,indent=2,ensure_ascii=False)+'\n',encoding='utf-8')
packpath=HERE/'bellblast_ideogram4_prompts_v2.json'
pack=json.loads(packpath.read_text(encoding='utf-8'))
pack['version']='2.0-user-tested-style-target-not-achieved'
pack['render_status']='User supplied 36 v2 results (ComfyUI_00450_ through ComfyUI_00485_) in Untitled Folder.zip. Reviewed all at contact-sheet size and four individually. Composition follows portions of the prompts, but the desired style is not achieved. See shared_results_review.md.'
packpath.write_text(json.dumps(pack,indent=2,ensure_ascii=False)+'\n',encoding='utf-8')
print('Saved exact training-caption control and one untested schoolgirl adaptation; marked v2 pack as user-tested and unsuccessful.')
