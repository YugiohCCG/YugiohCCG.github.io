namespace Enumerator;

[Flags]
public enum DuelPhase
{
	Draw = 1,
	Standby = 2,
	Main1 = 4,
	BattleStart = 8,
	BattleStep = 16,
	Damage = 32,
	DamageCal = 64,
	Battle = 128,
	Main2 = 256,
	End = 512,
}

