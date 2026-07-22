namespace Unity.Burst;

internal static class BurstString
{
	internal enum CutoffMode
	{
		Unique = 0,
		TotalLength = 1,
		FractionLength = 2,
	}

	internal struct FormatOptions
	{
		public NumberFormatKind Kind; //Field offset: 0x0
		public sbyte AlignAndSize; //Field offset: 0x1
		public byte Specifier; //Field offset: 0x2
		public bool Lowercase; //Field offset: 0x3

		public bool Uppercase
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			 get { } //Length: 8
		}

		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		public FormatOptions(NumberFormatKind kind, sbyte alignAndSize, byte specifier, bool lowercase) { }

		[CallerCount(Count = 173)]
		[DeduplicatedMethod]
		public int EncodeToRaw() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public bool get_Uppercase() { }

		[CallerCount(Count = 0)]
		public int GetBase() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 34)]
		[ContainsUnimplementedInstructions]
		public virtual string ToString() { }

	}

	private struct NumberBuffer
	{
		private readonly Byte* _buffer; //Field offset: 0x0
		public NumberBufferKind Kind; //Field offset: 0x8
		public int DigitsCount; //Field offset: 0xC
		public int Scale; //Field offset: 0x10
		public readonly bool IsNegative; //Field offset: 0x14

		[CallerCount(Count = 0)]
		public NumberBuffer(NumberBufferKind kind, Byte* buffer, int digitsCount, int scale, bool isNegative) { }

		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		public Byte* GetDigitsPointer() { }

	}

	private enum NumberBufferKind
	{
		Integer = 0,
		Float = 1,
	}

	internal enum NumberFormatKind
	{
		General = 0,
		Decimal = 1,
		DecimalForceSigned = 2,
		Hexadecimal = 3,
	}

	public class PreserveAttribute : Attribute
	{

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public PreserveAttribute() { }

	}

	internal enum PrintFloatFormat
	{
		Positional = 0,
		Scientific = 1,
	}

	internal struct tBigInt
	{
		[CompilerGenerated]
		[UnsafeValueType]
		internal struct <m_blocks>e__FixedBuffer
		{
			public uint FixedElementField; //Field offset: 0x0

		}

		private const int c_BigInt_MaxBlocks = 35; //Field offset: 0x0
		public int m_length; //Field offset: 0x0
		[FixedBuffer(typeof(uint), 35)]
		public <m_blocks>e__FixedBuffer m_blocks; //Field offset: 0x4

		[CallerCount(Count = 0)]
		public uint GetBlock(int idx) { }

		[CallerCount(Count = 173)]
		[DeduplicatedMethod]
		public int GetLength() { }

		[CallerCount(Count = 0)]
		public uint GetU32() { }

		[CallerCount(Count = 16)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public bool IsZero() { }

		[CallerCount(Count = 0)]
		public void SetU32(uint val) { }

		[CallerCount(Count = 0)]
		public void SetU64(ulong val) { }

		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		public void SetZero() { }

	}

	internal struct tFloatUnion32
	{
		public float m_floatingPoint; //Field offset: 0x0
		public uint m_integer; //Field offset: 0x0

		[CallerCount(Count = 0)]
		public uint GetExponent() { }

		[CallerCount(Count = 0)]
		public uint GetMantissa() { }

		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		public bool IsNegative() { }

	}

	internal struct tFloatUnion64
	{
		public double m_floatingPoint; //Field offset: 0x0
		public ulong m_integer; //Field offset: 0x0

		[CallerCount(Count = 0)]
		public uint GetExponent() { }

		[CallerCount(Count = 0)]
		public ulong GetMantissa() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public bool IsNegative() { }

	}

	private static readonly Byte[] logTable; //Field offset: 0x0
	private const int SinglePrecision = 9; //Field offset: 0x0
	private const int DoublePrecision = 17; //Field offset: 0x0
	internal const int SingleNumberBufferLength = 10; //Field offset: 0x0
	internal const int DoubleNumberBufferLength = 18; //Field offset: 0x0
	private const int SinglePrecisionCustomFormat = 7; //Field offset: 0x0
	private const int DoublePrecisionCustomFormat = 15; //Field offset: 0x0
	private static readonly UInt32[] g_PowerOf10_U32; //Field offset: 0x8
	private static readonly Byte[] InfinityString; //Field offset: 0x10
	private static readonly Byte[] NanString; //Field offset: 0x18
	private static readonly Char[] SplitByColon; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	private static BurstString() { }

	[CallerCount(Count = 0)]
	private static bool AlignLeft(Byte* dest, ref int destIndex, int destLength, int align, int length) { }

	[CalledBy(Type = typeof(BurstString), Member = "FormatInfinityNaN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(ulong), typeof(bool), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(char), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "FormatNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(NumberBuffer&), typeof(int), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	private static bool AlignRight(Byte* dest, ref int destIndex, int destLength, int align, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BurstString), Member = "BigInt_Add_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(tBigInt&), typeof(tBigInt&), typeof(tBigInt&)}, ReturnType = typeof(void))]
	private static void BigInt_Add(out tBigInt pResult, in tBigInt lhs, in tBigInt rhs) { }

	[CalledBy(Type = typeof(BurstString), Member = "BigInt_Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(tBigInt&), typeof(tBigInt&), typeof(tBigInt&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "Dragon4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(int), typeof(uint), typeof(bool), typeof(CutoffMode), typeof(uint), typeof(Byte*), typeof(uint), typeof(Int32&)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 2)]
	private static void BigInt_Add_internal(out tBigInt pResult, in tBigInt pLarge, in tBigInt pSmall) { }

	[CallerCount(Count = 0)]
	private static int BigInt_Compare(in tBigInt lhs, in tBigInt rhs) { }

	[CalledBy(Type = typeof(BurstString), Member = "Dragon4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(int), typeof(uint), typeof(bool), typeof(CutoffMode), typeof(uint), typeof(Byte*), typeof(uint), typeof(Int32&)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static uint BigInt_DivideWithRemainder_MaxQuotient9(ref tBigInt pDividend, in tBigInt divisor) { }

	[CalledBy(Type = typeof(BurstString), Member = "BigInt_Pow10", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(tBigInt&), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "BigInt_MultiplyPow10", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(tBigInt&), typeof(tBigInt&), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "Dragon4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(int), typeof(uint), typeof(bool), typeof(CutoffMode), typeof(uint), typeof(Byte*), typeof(uint), typeof(Int32&)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BurstString), Member = "BigInt_Multiply_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(tBigInt&), typeof(tBigInt&), typeof(tBigInt&)}, ReturnType = typeof(void))]
	private static void BigInt_Multiply(out tBigInt pResult, in tBigInt lhs, in tBigInt rhs) { }

	[CallerCount(Count = 0)]
	private static void BigInt_Multiply(out tBigInt pResult, in tBigInt lhs, uint rhs) { }

	[CalledBy(Type = typeof(BurstString), Member = "BigInt_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(tBigInt&), typeof(tBigInt&), typeof(tBigInt&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "Dragon4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(int), typeof(uint), typeof(bool), typeof(CutoffMode), typeof(uint), typeof(Byte*), typeof(uint), typeof(Int32&)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private static void BigInt_Multiply_internal(out tBigInt pResult, in tBigInt pLarge, in tBigInt pSmall) { }

	[CallerCount(Count = 0)]
	private static void BigInt_Multiply10(ref tBigInt pResult) { }

	[CallerCount(Count = 0)]
	private static void BigInt_Multiply2(out tBigInt pResult, in tBigInt input) { }

	[CallerCount(Count = 0)]
	private static void BigInt_Multiply2(ref tBigInt pResult) { }

	[CalledBy(Type = typeof(BurstString), Member = "Dragon4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(int), typeof(uint), typeof(bool), typeof(CutoffMode), typeof(uint), typeof(Byte*), typeof(uint), typeof(Int32&)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BurstString), Member = "g_PowerOf10_Big", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(tBigInt))]
	[Calls(Type = typeof(BurstString), Member = "BigInt_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(tBigInt&), typeof(tBigInt&), typeof(tBigInt&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static void BigInt_MultiplyPow10(out tBigInt pResult, in tBigInt input, uint exponent) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BurstString), Member = "g_PowerOf10_Big", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(tBigInt))]
	[Calls(Type = typeof(BurstString), Member = "BigInt_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(tBigInt&), typeof(tBigInt&), typeof(tBigInt&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static void BigInt_Pow10(out tBigInt pResult, uint exponent) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static void BigInt_Pow2(out tBigInt pResult, uint exponent) { }

	[CalledBy(Type = typeof(BurstString), Member = "Dragon4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(int), typeof(uint), typeof(bool), typeof(CutoffMode), typeof(uint), typeof(Byte*), typeof(uint), typeof(Int32&)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 5)]
	private static void BigInt_ShiftLeft(ref tBigInt pResult, uint shift) { }

	[CalledBy(Type = typeof(BurstString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(double), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BurstString), Member = "LogBase2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BurstString), Member = "Dragon4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(int), typeof(uint), typeof(bool), typeof(CutoffMode), typeof(uint), typeof(Byte*), typeof(uint), typeof(Int32&)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(BurstString), Member = "FormatNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(NumberBuffer&), typeof(int), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BurstString), Member = "FormatInfinityNaN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(ulong), typeof(bool), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static void ConvertDoubleToString(Byte* dest, ref int destIndex, int destLength, double value, FormatOptions formatOptions) { }

	[CalledBy(Type = typeof(BurstString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(float), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BurstString), Member = "LogBase2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BurstString), Member = "Dragon4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(int), typeof(uint), typeof(bool), typeof(CutoffMode), typeof(uint), typeof(Byte*), typeof(uint), typeof(Int32&)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(BurstString), Member = "FormatNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(NumberBuffer&), typeof(int), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BurstString), Member = "FormatInfinityNaN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(ulong), typeof(bool), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static void ConvertFloatToString(Byte* dest, ref int destIndex, int destLength, float value, FormatOptions formatOptions) { }

	[CalledBy(Type = typeof(BurstString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(sbyte), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(short), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(long), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "FormatGeneral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(NumberBuffer&), typeof(int), typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BurstString), Member = "FormatNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(NumberBuffer&), typeof(int), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static void ConvertIntegerToString(Byte* dest, ref int destIndex, int destLength, long value, FormatOptions options) { }

	[CalledBy(Type = typeof(BurstString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(byte), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(ushort), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(uint), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(ulong), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(sbyte), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(short), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(long), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(BurstString), Member = "FormatNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(NumberBuffer&), typeof(int), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static void ConvertUnsignedIntegerToString(Byte* dest, ref int destIndex, int destLength, ulong value, FormatOptions options) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Preserve]
	public static void CopyFixedString(Byte* dest, int destLength, Byte* src, int srcLength) { }

	[CalledBy(Type = typeof(BurstString), Member = "FormatPositional", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(uint), typeof(ulong), typeof(int), typeof(uint), typeof(bool), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(BurstString), Member = "FormatScientific", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(uint), typeof(ulong), typeof(int), typeof(uint), typeof(bool), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(BurstString), Member = "ConvertFloatToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(float), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "ConvertDoubleToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(double), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BurstString), Member = "BigInt_ShiftLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(tBigInt&), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BurstString), Member = "g_PowerOf10_Big", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(tBigInt))]
	[Calls(Type = typeof(BurstString), Member = "BigInt_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(tBigInt&), typeof(tBigInt&), typeof(tBigInt&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BurstString), Member = "BigInt_Multiply_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(tBigInt&), typeof(tBigInt&), typeof(tBigInt&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BurstString), Member = "BigInt_MultiplyPow10", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(tBigInt&), typeof(tBigInt&), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BurstString), Member = "LogBase2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(BurstString), Member = "BigInt_DivideWithRemainder_MaxQuotient9", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(tBigInt&), typeof(tBigInt&)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(BurstString), Member = "BigInt_Add_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(tBigInt&), typeof(tBigInt&), typeof(tBigInt&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static uint Dragon4(ulong mantissa, int exponent, uint mantissaHighBitIdx, bool hasUnequalMargins, CutoffMode cutoffMode, uint cutoffNumber, Byte* pOutBuffer, uint bufferSize, out int pOutExponent) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BurstString), Member = "ConvertUnsignedIntegerToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(ulong), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[Preserve]
	public static void Format(Byte* dest, ref int destIndex, int destLength, ulong value, int formatOptionsRaw) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BurstString), Member = "ConvertIntegerToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(long), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BurstString), Member = "ConvertUnsignedIntegerToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(ulong), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[Preserve]
	public static void Format(Byte* dest, ref int destIndex, int destLength, long value, int formatOptionsRaw) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BurstString), Member = "ConvertIntegerToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(long), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BurstString), Member = "ConvertUnsignedIntegerToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(ulong), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[Preserve]
	public static void Format(Byte* dest, ref int destIndex, int destLength, int value, int formatOptionsRaw) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BurstString), Member = "ConvertIntegerToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(long), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BurstString), Member = "ConvertUnsignedIntegerToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(ulong), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[Preserve]
	public static void Format(Byte* dest, ref int destIndex, int destLength, short value, int formatOptionsRaw) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BurstString), Member = "ConvertIntegerToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(long), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BurstString), Member = "ConvertUnsignedIntegerToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(ulong), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[Preserve]
	public static void Format(Byte* dest, ref int destIndex, int destLength, sbyte value, int formatOptionsRaw) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BurstString), Member = "ConvertUnsignedIntegerToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(ulong), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[Preserve]
	public static void Format(Byte* dest, ref int destIndex, int destLength, uint value, int formatOptionsRaw) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BurstString), Member = "ConvertDoubleToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(double), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[Preserve]
	public static void Format(Byte* dest, ref int destIndex, int destLength, double value, int formatOptionsRaw) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BurstString), Member = "ConvertUnsignedIntegerToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(ulong), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[Preserve]
	public static void Format(Byte* dest, ref int destIndex, int destLength, byte value, int formatOptionsRaw) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BurstString), Member = "AlignRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Preserve]
	public static void Format(Byte* dest, ref int destIndex, int destLength, char value, int formatOptionsRaw) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BurstString), Member = "AlignRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Preserve]
	public static void Format(Byte* dest, ref int destIndex, int destLength, bool value, int formatOptionsRaw) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BurstString), Member = "ConvertUnsignedIntegerToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(ulong), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[Preserve]
	public static void Format(Byte* dest, ref int destIndex, int destLength, ushort value, int formatOptionsRaw) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BurstString), Member = "ConvertFloatToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(float), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[Preserve]
	public static void Format(Byte* dest, ref int destIndex, int destLength, float value, int formatOptionsRaw) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BurstString), Member = "AlignRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Preserve]
	public static void Format(Byte* dest, ref int destIndex, int destLength, Byte* src, int srcLength, int formatOptionsRaw) { }

	[CallerCount(Count = 0)]
	private static void FormatDecimalOrHexadecimal(Byte* dest, ref int destIndex, int destLength, ref NumberBuffer number, int zeroPadding, bool outputPositiveSign) { }

	[CalledBy(Type = typeof(BurstString), Member = "FormatNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(NumberBuffer&), typeof(int), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BurstString), Member = "ConvertIntegerToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(long), typeof(FormatOptions)}, ReturnType = typeof(void))]
	private static void FormatGeneral(Byte* dest, ref int destIndex, int destLength, ref NumberBuffer number, int nMaxDigits, byte expChar) { }

	[CalledBy(Type = typeof(BurstString), Member = "ConvertFloatToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(float), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "ConvertDoubleToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(double), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BurstString), Member = "AlignRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private static void FormatInfinityNaN(Byte* dest, ref int destIndex, int destLength, ulong mantissa, bool isNegative, FormatOptions formatOptions) { }

	[CalledBy(Type = typeof(BurstString), Member = "ConvertFloatToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(float), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "ConvertDoubleToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(double), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "ConvertUnsignedIntegerToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(ulong), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "ConvertIntegerToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(long), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BurstString), Member = "GetLengthForFormatGeneral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberBuffer&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BurstString), Member = "FormatGeneral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(NumberBuffer&), typeof(int), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BurstString), Member = "AlignRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	private static void FormatNumber(Byte* dest, ref int destIndex, int destLength, ref NumberBuffer number, int nMaxDigits, FormatOptions options) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BurstString), Member = "Dragon4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(int), typeof(uint), typeof(bool), typeof(CutoffMode), typeof(uint), typeof(Byte*), typeof(uint), typeof(Int32&)}, ReturnType = typeof(uint))]
	[CallsUnknownMethods(Count = 2)]
	private static int FormatPositional(Byte* pOutBuffer, uint bufferSize, ulong mantissa, int exponent, uint mantissaHighBitIdx, bool hasUnequalMargins, int precision) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BurstString), Member = "Dragon4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(int), typeof(uint), typeof(bool), typeof(CutoffMode), typeof(uint), typeof(Byte*), typeof(uint), typeof(Int32&)}, ReturnType = typeof(uint))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static int FormatScientific(Byte* pOutBuffer, uint bufferSize, ulong mantissa, int exponent, uint mantissaHighBitIdx, bool hasUnequalMargins, int precision) { }

	[CalledBy(Type = typeof(BurstString), Member = "BigInt_Pow10", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(tBigInt&), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "BigInt_MultiplyPow10", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(tBigInt&), typeof(tBigInt&), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "Dragon4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(int), typeof(uint), typeof(bool), typeof(CutoffMode), typeof(uint), typeof(Byte*), typeof(uint), typeof(Int32&)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 3)]
	private static tBigInt g_PowerOf10_Big(int i) { }

	[CalledBy(Type = typeof(BurstString), Member = "FormatNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(NumberBuffer&), typeof(int), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static int GetLengthForFormatGeneral(ref NumberBuffer number, int nMaxDigits) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static int GetLengthIntegerToString(long value, int basis, int zeroPadding) { }

	[CalledBy(Type = typeof(BurstString), Member = "Dragon4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(int), typeof(uint), typeof(bool), typeof(CutoffMode), typeof(uint), typeof(Byte*), typeof(uint), typeof(Int32&)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(BurstString), Member = "ConvertFloatToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(float), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BurstString), Member = "ConvertDoubleToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(double), typeof(FormatOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private static uint LogBase2(uint val) { }

	[CalledBy(Type = typeof(BurstString), Member = "ParseFormatToFormatOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(FormatOptions))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	private static void OptsSplit(string fullFormat, out string padding, out string format) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BurstString), Member = "OptsSplit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(uint), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 33)]
	public static FormatOptions ParseFormatToFormatOptions(string fullFormat) { }

	[CallerCount(Count = 0)]
	private static void RoundNumber(ref NumberBuffer number, int pos, bool isCorrectlyRounded) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool ShouldRoundUp(Byte* dig, int i, bool isCorrectlyRounded) { }

	[CallerCount(Count = 0)]
	private static byte ValueToIntegerChar(int value, bool uppercase) { }

}

