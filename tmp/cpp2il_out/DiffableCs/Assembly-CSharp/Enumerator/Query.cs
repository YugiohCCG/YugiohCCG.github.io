namespace Enumerator;

[Flags]
public enum Query
{
	Code = 1,
	Position = 2,
	Alias = 4,
	Type = 8,
	Level = 16,
	Rank = 32,
	Attribute = 64,
	Race = 128,
	Attack = 256,
	Defence = 512,
	BaseAttack = 1024,
	BaseDefence = 2048,
	Reason = 4096,
	ReasonCard = 8192,
	EquipCard = 16384,
	TargetCard = 32768,
	OverlayCard = 65536,
	Counters = 131072,
	Owner = 262144,
	Status = 524288,
	LScale = 2097152,
	RScale = 4194304,
	Link = 8388608,
	SleeveRarity = 536870912,
	Cover = 1073741824,
	Rarity = 2147483648,
	DEFAULT = 4294959103,
}

