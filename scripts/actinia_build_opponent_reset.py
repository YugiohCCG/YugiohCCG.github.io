from pathlib import Path
S=Path.cwd()/'scripts';t=(S/'fresh_current_actinia_use_reset.cjs').read_text()
t=t.replace('add(original,L.MZONE,0,P.FACEUP_ATTACK,2);','add(original,L.MZONE,0,P.FACEUP_ATTACK,2);add(original,L.MZONE,1,P.FACEUP_ATTACK,0);')
t=t.replace('assert.equal(turn,3)','assert.equal(turn,2)').replace('turn<3','turn<2')
t=t.replace('current-actinia-use-reset','current-actinia-opponent-reset').replace('next ownturn3','earliest opponentturn2').replace('Revival/opponent reset/nativeOmega','Revival/nativeOmega')
t=t.replace("assert(query(L.MZONE).some(c=>c.code===original),'Native indestructible original retained');","assert(query(L.MZONE).some(c=>c.code===original),'Native own indestructible original retained');if(attempts===3){const opposing=core.duelQueryLocation(duel,{flags:Q.CODE,controller:1,location:L.MZONE}).filter(Boolean);assert(opposing.some(c=>c.code===original),'Native opponent original retained');assert(trace.some(m=>m.type===M.CHAINING&&m.code===original&&m.triggering_controller===1),'Actual opposing original activation');}")
(S/'fresh_current_actinia_opponent_reset.cjs').write_text(t,encoding='utf-8')
t=(S/'fresh_current_actinia_use_reset_batch.py').read_text().replace('actinia_use_reset','actinia_opponent_reset').replace('actinia-use-reset','actinia-opponent-reset')
(S/'fresh_current_actinia_opponent_reset_batch.py').write_text(t,encoding='utf-8')
