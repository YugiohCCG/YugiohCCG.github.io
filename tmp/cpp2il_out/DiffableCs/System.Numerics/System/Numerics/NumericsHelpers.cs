namespace System.Numerics;

internal static class NumericsHelpers
{

	[CallerCount(Count = 0)]
	public static uint Abs(int a) { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public static int CbitHighZero(uint u) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static int CbitHighZero(ulong uu) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint CombineHash(uint u1, uint u2) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static int CombineHash(int n1, int n2) { }

	[CalledBy(Type = typeof(BigInteger), Member = "op_RightShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void DangerousMakeTwosComplement(UInt32[] d) { }

	[CalledBy(Type = typeof(BigInteger), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(double))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static double GetDoubleFromParts(int sign, int exp, ulong man) { }

	[CallerCount(Count = 0)]
	public static void GetDoubleParts(double dbl, out int sign, out int exp, out ulong man, out bool fFinite) { }

	[CallerCount(Count = 0)]
	public static ulong MakeUlong(uint uHi, uint uLo) { }

}

