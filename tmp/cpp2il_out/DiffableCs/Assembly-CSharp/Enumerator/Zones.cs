namespace Enumerator;

public static class Zones
{
	public static readonly Int32[] ZCODES; //Field offset: 0x0
	public const int PendulumZones = 3; //Field offset: 0x0
	public const int RightPendulumZone = 2; //Field offset: 0x0
	public const int LeftPendulumZone = 1; //Field offset: 0x0
	public const int SpellZones = 31; //Field offset: 0x0
	public const int ExtraMonsterZones = 96; //Field offset: 0x0
	public const int MainMonsterZones = 31; //Field offset: 0x0
	public const int LinkedZones = 65536; //Field offset: 0x0
	public const int MonsterZones = 127; //Field offset: 0x0
	public const int z5 = 32; //Field offset: 0x0
	public const int z4 = 16; //Field offset: 0x0
	public const int z3 = 8; //Field offset: 0x0
	public const int z2 = 4; //Field offset: 0x0
	public const int z1 = 2; //Field offset: 0x0
	public const int z0 = 1; //Field offset: 0x0
	public const int z6 = 64; //Field offset: 0x0
	public const int NotLinkedZones = 131072; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static Zones() { }

	[CalledBy(Type = typeof(CardOptionList), Member = "OnBlockZone", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSide), Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Duel), Member = "GetFieldSlots", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation), typeof(byte), typeof(int)}, ReturnType = typeof(System.Collections.Generic.List`1<Scenes.Battle.FieldSlot>))]
	[CallerCount(Count = 10)]
	[ContainsUnimplementedInstructions]
	public static bool IsAvailable(int zone, int filter) { }

}

