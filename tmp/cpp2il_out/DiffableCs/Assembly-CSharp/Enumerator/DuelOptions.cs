namespace Enumerator;

[Flags]
public enum DuelOptions
{
	SplitPendulumZones = 1,
	AttackFirstTurn = 2,
	OldReplay = 4,
	ObsoleteRuling = 8,
	NoShuffleDeck = 16,
	IsTag = 32,
	SimpleAI = 64,
	SecondPlayerFirst = 128,
	IsRelay = 256,
	IsTCG = 512,
	EnableEMZ = 1024,
	InvertQuickPriority = 2048,
	LastPlayerAttacksFirst = 4096,
}

