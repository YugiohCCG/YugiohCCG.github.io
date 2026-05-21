# Omega Scripting Reference

For the full custom-card production workflow, see `docs/omega-custom-card-workflow.md`.

Use the Duelists Unite Omega script database as the primary reference when writing or debugging custom YGO Omega card scripts:

https://gitlab.com/duelists-unite/omega_scripts/-/blob/master/

Before scripting unfamiliar effects, check this source for existing working patterns, especially for:

- Xyz, Fusion, Link, and Pendulum summon procedures
- effects that activate cards the turn they are Set
- card ownership, control, and material handling
- chain rewriting, replacement effects, and target clearing
- Omega-compatible helper functions and constants

Avoid assuming EDOPro helper APIs exist in Omega. Prefer patterns directly observed in this repository when there is any compatibility doubt.
