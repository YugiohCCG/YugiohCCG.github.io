namespace Mono.Math.Prime;

internal sealed class PrimalityTests
{

	[CalledBy(Type = typeof(PrimalityTests), Member = "RabinMillerTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(ConfidenceFactor)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PrimalityTests), Member = "SmallPrimeSppTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(ConfidenceFactor)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private static int GetSPPRounds(BigInteger bi, ConfidenceFactor confidence) { }

	[CalledBy(Type = typeof(BigInteger), Member = "IsProbablePrime", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PrimalityTests), Member = "Test", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(ConfidenceFactor)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(PrimalityTests), Member = "GetSPPRounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(ConfidenceFactor)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigInteger), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "LowestSetBit", ReturnType = typeof(int))]
	[Calls(Type = "Mono.Math.BigInteger+Kernel", Member = "RightShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(ModulusRing), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ModulusRing), Member = "Pow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BigInteger), Member = "GenerateRandom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public static bool RabinMillerTest(BigInteger n, ConfidenceFactor confidence) { }

	[CalledBy(Type = typeof(BigInteger), Member = "IsProbablePrime", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PrimalityTests), Member = "Test", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(ConfidenceFactor)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PrimalityTests), Member = "GetSPPRounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(ConfidenceFactor)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigInteger), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "LowestSetBit", ReturnType = typeof(int))]
	[Calls(Type = "Mono.Math.BigInteger+Kernel", Member = "RightShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(ModulusRing), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ModulusRing), Member = "Pow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BigInteger), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = "Mono.Math.BigInteger+Kernel", Member = "multiByteDivide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger[]))]
	[CallsUnknownMethods(Count = 2)]
	public static bool SmallPrimeSppTest(BigInteger bi, ConfidenceFactor confidence) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PrimalityTests), Member = "RabinMillerTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(ConfidenceFactor)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PrimalityTests), Member = "SmallPrimeSppTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(ConfidenceFactor)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool Test(BigInteger n, ConfidenceFactor confidence) { }

}

