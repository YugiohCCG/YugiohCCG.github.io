namespace Enumerator;

[Flags]
public enum Reason
{
	Destroy = 1,
	Release = 2,
	Temporary = 4,
	Material = 8,
	Summon = 16,
	Battle = 32,
	Effect = 64,
	Cost = 128,
	Adjust = 256,
	LostTarget = 512,
	Rule = 1024,
	SPSummon = 2048,
	Dissumon = 4096,
	Flip = 8192,
	Discard = 16384,
	RDamage = 32768,
	RRecover = 65536,
	Return = 131072,
	Fusion = 262144,
	Synchro = 524288,
	Ritual = 1048576,
	XYZ = 2097152,
	Replace = 16777216,
	Draw = 33554432,
	Redirect = 67108864,
	Link = 268435456,
	LostOverlay = 536870912,
	Pendulum = 1073741824,
}

