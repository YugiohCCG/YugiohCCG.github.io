namespace System;

internal static class Marvin
{
	[CompilerGenerated]
	private static readonly ulong <DefaultSeed>k__BackingField; //Field offset: 0x0

	public static ulong DefaultSeed
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 78
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static uint _rotl(uint value, int shift) { }

	[CallerCount(Count = 0)]
	private static Marvin() { }

	[CallerCount(Count = 0)]
	private static void Block(ref uint rp0, ref uint rp1) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	public static int ComputeHash32(ReadOnlySpan<Byte> data, ulong seed) { }

	[CalledBy(Type = typeof(CompareInfo), Member = "GetIgnoreCaseHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.IPAddress", Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[ContainsInvalidInstructions]
	public static int ComputeHash32(ref byte data, int count, ulong seed) { }

	[CallerCount(Count = 0)]
	private static ulong GenerateSeed() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static ulong get_DefaultSeed() { }

}

