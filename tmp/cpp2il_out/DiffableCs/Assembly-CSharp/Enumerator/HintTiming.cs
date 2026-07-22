namespace Enumerator;

[Flags]
public enum HintTiming
{
	None = 0,
	DrawPhase = 1,
	StandbyPhase = 2,
	MainEnd = 4,
	BattleStart = 8,
	BattleEnd = 16,
	EndPhase = 32,
	Summon = 64,
	SpSummon = 128,
	FlipSummon = 256,
	MSet = 512,
	SSet = 1024,
	PosChange = 2048,
	Attack = 4096,
	DamageStep = 8192,
	DamageCal = 16384,
	ChainEnd = 32768,
	Draw = 65536,
	Damage = 131072,
	Recover = 262144,
	Destroy = 524288,
	Remove = 1048576,
	ToHand = 2097152,
	ToDeck = 4194304,
	ToGrave = 8388608,
	BattlePhase = 16777216,
	Equip = 33554432,
	BattleStepEnd = 67108864,
}

