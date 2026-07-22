namespace Enumerator;

[Flags]
public enum CardLocation
{
	None = 0,
	Deck = 1,
	Hand = 2,
	MonsterZone = 4,
	SpellZone = 8,
	Grave = 16,
	Removed = 32,
	Extra = 64,
	Overlay = 128,
	Onfield = 12,
	FieldZone = 256,
	PendulumZone = 512,
}

