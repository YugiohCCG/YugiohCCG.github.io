namespace System.Numerics;

internal static class BigIntegerCalculator
{
	private static int ReducerThreshold; //Field offset: 0x0
	private static int SquareThreshold; //Field offset: 0x4
	private static int AllocationThreshold; //Field offset: 0x8
	private static int MultiplyThreshold; //Field offset: 0xC

	[CallerCount(Count = 0)]
	private static BigIntegerCalculator() { }

	[CalledBy(Type = typeof(BigIntegerCalculator), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BigIntegerCalculator), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	private static void Add(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	[CalledBy(Type = typeof(BigInteger), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public static UInt32[] Add(UInt32[] left, uint right) { }

	[CalledBy(Type = typeof(BigInteger), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public static UInt32[] Add(UInt32[] left, UInt32[] right) { }

	[CallerCount(Count = 0)]
	private static uint AddDivisor(UInt32* left, int leftLength, UInt32* right, int rightLength) { }

	[CalledBy(Type = typeof(BigIntegerCalculator), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BigIntegerCalculator), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	private static void AddSelf(UInt32* left, int leftLength, UInt32* right, int rightLength) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static int Compare(UInt32[] left, UInt32[] right) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static UInt32[] CreateCopy(UInt32[] value) { }

	[CalledBy(Type = typeof(BigInteger), Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Modulus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigIntegerCalculator), Member = "Divide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(UInt32[]))]
	[CalledBy(Type = typeof(BigIntegerCalculator), Member = "Remainder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(UInt32[]))]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	private static void Divide(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static UInt32[] Divide(UInt32[] left, uint right) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigIntegerCalculator), Member = "Divide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static UInt32[] Divide(UInt32[] left, UInt32[] right) { }

	[CallerCount(Count = 0)]
	private static bool DivideGuessTooBig(ulong q, ulong valHi, uint valLo, uint divHi, uint divLo) { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	private static int LeadingZeros(uint value) { }

	[CalledBy(Type = typeof(BigInteger), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static UInt32[] Multiply(UInt32[] left, uint right) { }

	[CalledBy(Type = typeof(BigInteger), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BigIntegerCalculator), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static UInt32[] Multiply(UInt32[] left, UInt32[] right) { }

	[CalledBy(Type = typeof(BigIntegerCalculator), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(UInt32[]))]
	[CalledBy(Type = typeof(BigIntegerCalculator), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BigIntegerCalculator), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigIntegerCalculator), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigIntegerCalculator), Member = "SubtractCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigIntegerCalculator), Member = "AddSelf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	private static void Multiply(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static uint Remainder(UInt32[] left, uint right) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigIntegerCalculator), Member = "Divide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static UInt32[] Remainder(UInt32[] left, UInt32[] right) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigIntegerCalculator), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static UInt32[] Square(UInt32[] value) { }

	[CalledBy(Type = typeof(BigInteger), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigIntegerCalculator), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(UInt32[]))]
	[CalledBy(Type = typeof(BigIntegerCalculator), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(BigIntegerCalculator), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigIntegerCalculator), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigIntegerCalculator), Member = "SubtractCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigIntegerCalculator), Member = "AddSelf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private static void Square(UInt32* value, int valueLength, UInt32* bits, int bitsLength) { }

	[CalledBy(Type = typeof(BigInteger), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public static UInt32[] Subtract(UInt32[] left, uint right) { }

	[CalledBy(Type = typeof(BigInteger), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public static UInt32[] Subtract(UInt32[] left, UInt32[] right) { }

	[CallerCount(Count = 0)]
	private static void Subtract(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	[CalledBy(Type = typeof(BigIntegerCalculator), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BigIntegerCalculator), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	private static void SubtractCore(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* core, int coreLength) { }

	[CallerCount(Count = 0)]
	private static uint SubtractDivisor(UInt32* left, int leftLength, UInt32* right, int rightLength, ulong q) { }

}

