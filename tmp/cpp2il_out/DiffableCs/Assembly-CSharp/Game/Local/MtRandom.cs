namespace Game.Local;

internal class MtRandom
{
	private const int N = 624; //Field offset: 0x0
	private const int M = 397; //Field offset: 0x0
	private uint _current; //Field offset: 0x10
	private uint _left; //Field offset: 0x14
	private readonly UInt32[] _state; //Field offset: 0x18

	[CalledBy(Type = typeof(LocalDuel), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(LocalGame)}, ReturnType = typeof(LocalDuel))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MtRandom), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal MtRandom() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MtRandom), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal MtRandom(uint seed) { }

	[CalledBy(Type = typeof(MtRandom), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MtRandom), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MtRandom), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	internal void Init(uint seed = 19650218) { }

	[CallerCount(Count = 0)]
	private static uint MixBits(uint u, uint v) { }

	[CalledBy(Type = typeof(MtRandom), Member = "Rand", ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(MtRandom), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void NextState() { }

	[CalledBy(Type = typeof(LocalDuel), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(LocalGame)}, ReturnType = typeof(LocalDuel))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MtRandom), Member = "NextState", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal uint Rand() { }

	[CalledBy(Type = typeof(LocalDuel), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(LocalGame)}, ReturnType = typeof(LocalDuel))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MtRandom), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MtRandom), Member = "NextState", ReturnType = typeof(void))]
	internal void Reset(uint rs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static uint Twist(uint u, uint v) { }

}

