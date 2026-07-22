namespace Enumerator;

[Flags]
public enum Category
{
	SkillCard = 1,
	SpeedSpellCard = 2,
	BossCard = 4,
	BetaCard = 8,
	ActionCard = 16,
	CommandCard = 32,
	DoubleScript = 64,
	RushLegendary = 128,
	PreErrata = 256,
	DarkCard = 512,
	DuelLinks = 1024,
	RushCard = 2048,
	StartCard = 4096,
	OneCard = 8192,
	TwoCard = 16384,
	ThreeCard = 32768,
	LevelZero = 65536,
	TreatedAs = 131072,
	BlueGod = 262144,
	YellowGod = 524288,
	RedGod = 1048576,
	HasMaxAtk = 2097152,
	RulingErrata = 4194304,
	PendulumEffect = 8388608,
	Anime = 16777216,
}

