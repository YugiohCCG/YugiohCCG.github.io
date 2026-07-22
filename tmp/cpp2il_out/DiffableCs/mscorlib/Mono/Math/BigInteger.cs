namespace Mono.Math;

internal class BigInteger
{
	private sealed class Kernel
	{

		[CallerCount(Count = 45)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public static Sign Compare(BigInteger bi1, BigInteger bi2) { }

		[CalledBy(Type = typeof(Kernel), Member = "multiByteDivide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger[]))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 11)]
		[ContainsUnimplementedInstructions]
		public static BigInteger[] DwordDivMod(BigInteger n, uint d) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public static uint DwordMod(BigInteger n, uint d) { }

		[CalledBy(Type = typeof(Kernel), Member = "multiByteDivide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger[]))]
		[CalledBy(Type = typeof(BigInteger), Member = "op_LeftShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(BigInteger))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		public static BigInteger LeftShift(BigInteger bi, int n) { }

		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public static void MinusEq(BigInteger big, BigInteger small) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		public static uint modInverse(BigInteger bi, uint modulus) { }

		[CalledBy(Type = typeof(RSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RSAManaged), Member = "ImportParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSAParameters)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DSAManaged), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(BigInteger), Member = "ModInverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ModulusRing), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BigInteger), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(ModulusRing), Member = "Difference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(Kernel), Member = "multiByteDivide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger[]))]
		[Calls(Type = typeof(ArithmeticException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 46)]
		[ContainsUnimplementedInstructions]
		public static BigInteger modInverse(BigInteger bi, BigInteger modulus) { }

		[CalledBy(Type = typeof(BigInteger), Member = "op_Modulus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
		[CalledBy(Type = typeof(PrimalityTests), Member = "SmallPrimeSppTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(ConfidenceFactor)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(BigInteger), Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
		[CalledBy(Type = typeof(ModulusRing), Member = "Difference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
		[CalledBy(Type = typeof(ModulusRing), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
		[CalledBy(Type = typeof(ModulusRing), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Kernel), Member = "modInverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
		[CalledBy(Type = typeof(DSAManaged), Member = "ImportParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DSAParameters)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DSAManaged), Member = "GenerateParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RSAManaged), Member = "ImportParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSAParameters)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DSAManaged), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(bool))]
		[CallerCount(Count = 21)]
		[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Kernel), Member = "LeftShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(Kernel), Member = "RightShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(Kernel), Member = "DwordDivMod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(uint)}, ReturnType = typeof(BigInteger[]))]
		[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 22)]
		[ContainsUnimplementedInstructions]
		public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2) { }

		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public static void Multiply(UInt32[] x, uint xOffset, uint xLen, UInt32[] y, uint yOffset, uint yLen, UInt32[] d, uint dOffset) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		public static BigInteger MultiplyByDword(BigInteger n, uint f) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public static void MultiplyMod2p32pmod(UInt32[] x, int xOffset, int xLen, UInt32[] y, int yOffest, int yLen, UInt32[] d, int dOffset, int mod) { }

		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public static void PlusEq(BigInteger bi1, BigInteger bi2) { }

		[CalledBy(Type = typeof(Kernel), Member = "multiByteDivide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger[]))]
		[CalledBy(Type = typeof(BigInteger), Member = "op_RightShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(BigInteger))]
		[CalledBy(Type = typeof(PrimalityTests), Member = "RabinMillerTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(ConfidenceFactor)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(PrimalityTests), Member = "SmallPrimeSppTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(ConfidenceFactor)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		public static BigInteger RightShift(BigInteger bi, int n) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public static uint SingleByteDivideInPlace(BigInteger n, uint d) { }

		[CalledBy(Type = typeof(BigInteger), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		public static BigInteger Subtract(BigInteger big, BigInteger small) { }

	}

	public sealed class ModulusRing
	{
		private BigInteger mod; //Field offset: 0x10
		private BigInteger constant; //Field offset: 0x18

		[CalledBy(Type = typeof(RSAManaged), Member = "EncryptValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
		[CalledBy(Type = typeof(DSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DSAManaged), Member = "GenerateParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mono.Math.BigInteger+Kernel", Member = "modInverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
		[CalledBy(Type = typeof(BigInteger), Member = "ModPow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
		[CalledBy(Type = typeof(PrimalityTests), Member = "RabinMillerTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(ConfidenceFactor)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(PrimalityTests), Member = "SmallPrimeSppTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(ConfidenceFactor)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 7)]
		[Calls(Type = "Mono.Math.BigInteger+Kernel", Member = "multiByteDivide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger[]))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		public ModulusRing(BigInteger modulus) { }

		[CalledBy(Type = typeof(ModulusRing), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
		[CalledBy(Type = typeof(ModulusRing), Member = "Difference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sign), typeof(uint)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 8)]
		public void BarrettReduction(BigInteger x) { }

		[CalledBy(Type = "Mono.Math.BigInteger+Kernel", Member = "modInverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BigInteger), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(ModulusRing), Member = "BarrettReduction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(void))]
		[Calls(Type = "Mono.Math.BigInteger+Kernel", Member = "multiByteDivide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger[]))]
		[Calls(Type = typeof(Exception), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		public BigInteger Difference(BigInteger a, BigInteger b) { }

		[CalledBy(Type = typeof(ModulusRing), Member = "Pow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
		[Calls(Type = "Mono.Math.BigInteger+Kernel", Member = "multiByteDivide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger[]))]
		[Calls(Type = typeof(BigInteger), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(ModulusRing), Member = "BarrettReduction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public BigInteger Multiply(BigInteger a, BigInteger b) { }

		[CalledBy(Type = typeof(RSAManaged), Member = "EncryptValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
		[CalledBy(Type = typeof(DSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DSAManaged), Member = "GenerateParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ModulusRing), Member = "Pow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
		[CalledBy(Type = typeof(BigInteger), Member = "ModPow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
		[CalledBy(Type = typeof(PrimalityTests), Member = "RabinMillerTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(ConfidenceFactor)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(PrimalityTests), Member = "SmallPrimeSppTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(ConfidenceFactor)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ModulusRing), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(BigInteger), Member = "TestBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public BigInteger Pow(BigInteger a, BigInteger k) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ModulusRing), Member = "Pow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
		public BigInteger Pow(uint b, BigInteger exp) { }

	}

	internal enum Sign
	{
		Negative = -1,
		Zero = 0,
		Positive = 1,
	}

	internal static readonly UInt32[] smallPrimes; //Field offset: 0x0
	private static RandomNumberGenerator rng; //Field offset: 0x8
	private uint length; //Field offset: 0x10
	private UInt32[] data; //Field offset: 0x18

	private static RandomNumberGenerator Rng
	{
		[CalledBy(Type = typeof(DSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DSAManaged), Member = "GenerateParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BigInteger), Member = "GenerateRandom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
		[CalledBy(Type = typeof(BigInteger), Member = "Randomize", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SequentialSearchPrimeGeneratorBase), Member = "GenerateSearchBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(BigInteger))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(RandomNumberGenerator), Member = "Create", ReturnType = typeof(RandomNumberGenerator))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 219
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static BigInteger() { }

	[CallerCount(Count = 38)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public BigInteger(uint ui) { }

	[CalledBy(Type = typeof(RSAManaged), Member = "EncryptValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(RSAManaged), Member = "ImportParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSAParameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DSAManaged), Member = "GenerateParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DSAManaged), Member = "ImportParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DSAParameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DSAManaged), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 22)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public BigInteger(Byte[] inData) { }

	[CalledBy(Type = typeof(ModulusRing), Member = "BarrettReduction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public BigInteger(Sign sign, uint len) { }

	[CalledBy(Type = typeof(Kernel), Member = "multiByteDivide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger[]))]
	[CalledBy(Type = typeof(Kernel), Member = "RightShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public BigInteger(BigInteger bi) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public BigInteger(BigInteger bi, uint len) { }

	[CallerCount(Count = 18)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public int BitCount() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void Clear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object o) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static BigInteger GeneratePseudoPrime(int bits) { }

	[CalledBy(Type = typeof(PrimalityTests), Member = "RabinMillerTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(ConfidenceFactor)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BigInteger), Member = "get_Rng", ReturnType = typeof(RandomNumberGenerator))]
	[ContainsInvalidInstructions]
	public static BigInteger GenerateRandom(int bits) { }

	[CalledBy(Type = typeof(DSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DSAManaged), Member = "GenerateParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SequentialSearchPrimeGeneratorBase), Member = "GenerateSearchBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	[CalledBy(Type = typeof(DSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DSAManaged), Member = "GenerateParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BigInteger), Member = "GenerateRandom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "Randomize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SequentialSearchPrimeGeneratorBase), Member = "GenerateSearchBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(RandomNumberGenerator), Member = "Create", ReturnType = typeof(RandomNumberGenerator))]
	[CallsUnknownMethods(Count = 1)]
	private static RandomNumberGenerator get_Rng() { }

	[CalledBy(Type = typeof(RSAManaged), Member = "ExportParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(RSAParameters))]
	[CalledBy(Type = typeof(RSAManaged), Member = "GetPaddedValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(DSAManaged), Member = "ExportParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DSAParameters))]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Byte[] GetBytes() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void Incr2() { }

	[CalledBy(Type = typeof(DSAManaged), Member = "GenerateParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PrimalityTests), Member = "RabinMillerTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(ConfidenceFactor)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PrimalityTests), Member = "SmallPrimeSppTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(ConfidenceFactor)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool IsProbablePrime() { }

	[CalledBy(Type = typeof(PrimalityTests), Member = "RabinMillerTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(ConfidenceFactor)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PrimalityTests), Member = "SmallPrimeSppTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(ConfidenceFactor)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BigInteger), Member = "TestBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public int LowestSetBit() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Kernel), Member = "modInverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	public BigInteger ModInverse(BigInteger modulus) { }

	[CalledBy(Type = typeof(DSAManaged), Member = "ImportParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DSAParameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DSAManaged), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ModulusRing), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ModulusRing), Member = "Pow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CallsUnknownMethods(Count = 1)]
	public BigInteger ModPow(BigInteger exp, BigInteger n) { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void Normalize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Kernel), Member = "multiByteDivide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger[]))]
	[CallsUnknownMethods(Count = 2)]
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	[CalledBy(Type = typeof(RSAManaged), Member = "get_PublicOnly", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RSAManaged), Member = "ExportParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(RSAParameters))]
	[CalledBy(Type = typeof(RSAManaged), Member = "ImportParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSAParameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DSAManaged), Member = "get_PublicOnly", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DSAManaged), Member = "ExportParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DSAParameters))]
	[CalledBy(Type = typeof(DSAManaged), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BigInteger), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PrimalityTests), Member = "RabinMillerTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(ConfidenceFactor)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PrimalityTests), Member = "SmallPrimeSppTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(ConfidenceFactor)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(BigInteger), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	public static BigInteger op_Implicit(uint value) { }

	[CalledBy(Type = typeof(PrimalityTests), Member = "RabinMillerTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(ConfidenceFactor)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static BigInteger op_Implicit(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	[CalledBy(Type = typeof(RSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RSAManaged), Member = "ExportParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(RSAParameters))]
	[CalledBy(Type = typeof(RSAManaged), Member = "ImportParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSAParameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RSAManaged), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DSAManaged), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PrimalityTests), Member = "RabinMillerTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(ConfidenceFactor)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(BigInteger), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Kernel), Member = "LeftShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(BigInteger))]
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Kernel), Member = "multiByteDivide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger[]))]
	[CallsUnknownMethods(Count = 2)]
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	[CalledBy(Type = typeof(DSAManaged), Member = "GenerateParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArithmeticException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static BigInteger op_Multiply(BigInteger bi, int i) { }

	[CalledBy(Type = typeof(RSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RSAManaged), Member = "ImportParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSAParameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DSAManaged), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ModulusRing), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(Kernel), Member = "modInverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(PrimalityTests), Member = "SmallPrimeSppTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(ConfidenceFactor)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sign), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Kernel), Member = "RightShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(BigInteger))]
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	[CalledBy(Type = typeof(RSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RSAManaged), Member = "ImportParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSAParameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DSAManaged), Member = "GenerateParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DSAManaged), Member = "ImportParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DSAParameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ModulusRing), Member = "Difference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(PrimalityTests), Member = "RabinMillerTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(ConfidenceFactor)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PrimalityTests), Member = "SmallPrimeSppTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(ConfidenceFactor)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Kernel), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArithmeticException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Exception), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	[CalledBy(Type = typeof(DSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BigInteger), Member = "Randomize", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void Randomize(RandomNumberGenerator rng) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = "get_Rng", ReturnType = typeof(RandomNumberGenerator))]
	[Calls(Type = typeof(BigInteger), Member = "Randomize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RandomNumberGenerator)}, ReturnType = typeof(void))]
	public void Randomize() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void SetBit(uint bitNum, bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void SetBit(uint bitNum) { }

	[CalledBy(Type = typeof(ModulusRing), Member = "Pow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "LowestSetBit", ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	public bool TestBit(int bitNum) { }

	[CalledBy(Type = typeof(DSAManaged), Member = "GenerateParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool TestBit(uint bitNum) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(string)}, ReturnType = typeof(string))]
	public string ToString(uint radix) { }

	[CalledBy(Type = typeof(BigInteger), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	public string ToString(uint radix, string characterSet) { }

}

