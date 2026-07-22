namespace Unity.Collections;

[DebuggerTypeProxy(typeof(BitField32DebugView))]
[GenerateTestsForBurstCompatibility]
public struct BitField32
{
	public uint Value; //Field offset: 0x0

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public BitField32(uint initialValue = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void CheckArgs(int pos, int numBits) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public void Clear() { }

	[CallerCount(Count = 0)]
	public int CountBits() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public int CountLeadingZeros() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public int CountTrailingZeros() { }

	[CallerCount(Count = 0)]
	public uint GetBits(int pos, int numBits = 1) { }

	[CallerCount(Count = 0)]
	public bool IsSet(int pos) { }

	[CallerCount(Count = 0)]
	public void SetBits(int pos, bool value) { }

	[CallerCount(Count = 0)]
	public void SetBits(int pos, bool value, int numBits) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool TestAll(int pos, int numBits = 1) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool TestAny(int pos, int numBits = 1) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool TestNone(int pos, int numBits = 1) { }

}

