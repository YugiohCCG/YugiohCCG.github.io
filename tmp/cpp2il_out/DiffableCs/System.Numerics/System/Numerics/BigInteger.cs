namespace System.Numerics;

[IsReadOnly]
public struct BigInteger : IFormattable, IComparable, IComparable<BigInteger>, IEquatable<BigInteger>
{
	private enum GetBytesMode
	{
		AllocateArray = 0,
		Count = 1,
		Span = 2,
	}

	private static readonly BigInteger s_bnMinInt; //Field offset: 0x0
	private static readonly BigInteger s_bnOneInt; //Field offset: 0x10
	private static readonly BigInteger s_bnZeroInt; //Field offset: 0x20
	private static readonly BigInteger s_bnMinusOneInt; //Field offset: 0x30
	private static readonly Byte[] s_success; //Field offset: 0x40
	internal readonly int _sign; //Field offset: 0x0
	internal readonly UInt32[] _bits; //Field offset: 0x8

	public bool IsZero
	{
		[CallerCount(Count = 16)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public static BigInteger MinusOne
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 91
	}

	public static BigInteger Zero
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 91
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 14)]
	private static BigInteger() { }

	[CalledBy(Type = typeof(BigInteger), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_LeftShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_RightShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Modulus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	internal BigInteger(UInt32[] value, bool negative) { }

	[CallerCount(Count = 12)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal BigInteger(int n, UInt32[] rgu) { }

	[CalledBy(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BigNumber), Member = "HexNumberToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigNumberBuffer&), typeof(BigInteger&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public BigInteger(ReadOnlySpan<Byte> value, bool isUnsigned = false, bool isBigEndian = false) { }

	[CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadInteger", ReturnType = typeof(int))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "ToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[CLSCompliant(False)]
	public BigInteger(Byte[] value) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "ToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Decimal), Member = "Truncate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "GetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(Int32[]))]
	[CallsUnknownMethods(Count = 4)]
	public BigInteger(decimal value) { }

	[CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadOidAsString", ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "ToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigNumber), Member = "NumberToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigNumberBuffer&), typeof(BigInteger&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	public BigInteger(int value) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "ToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public BigInteger(float value) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "ToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[CLSCompliant(False)]
	public BigInteger(ulong value) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "ToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Modulus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 6)]
	public BigInteger(long value) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "ToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[CLSCompliant(False)]
	public BigInteger(uint value) { }

	[CalledBy(Type = "Newtonsoft.Json.JsonValidatingReader", Member = "ValidateInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Schema.JsonSchemaModel"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "ToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	public BigInteger(double value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigIntegerCalculator), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigIntegerCalculator), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(uint)}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	private static BigInteger Add(UInt32[] leftBits, int leftSign, UInt32[] rightBits, int rightSign) { }

	[CalledBy(Type = typeof(BigInteger), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(long)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(long)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(BigInteger)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(BigInteger)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ulong), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(long), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public int CompareTo(long other) { }

	[CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "CompareBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Data.Common.BigIntegerStorage", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Data.Common.BigIntegerStorage", Member = "CompareValueTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(BigInteger), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public override int CompareTo(BigInteger other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public override int CompareTo(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CalledBy(Type = typeof(BigInteger), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(long)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(long)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool Equals(long other) { }

	[CalledBy(Type = typeof(BigInteger), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(BigInteger other) { }

	[CallerCount(Count = 16)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_IsZero() { }

	[CallerCount(Count = 0)]
	public static BigInteger get_MinusOne() { }

	[CallerCount(Count = 0)]
	public static BigInteger get_Zero() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal static int GetDiffLength(UInt32[] rgu1, UInt32[] rgu2, int cu) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private static bool GetPartsForBitManipulation(ref BigInteger x, out UInt32[] xd, out int xl) { }

	[CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadOidAsString", ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "Operation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.ExpressionType", typeof(object), typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Data.AutoIncrementBigInteger", Member = "set_Step", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.AutoIncrementBigInteger", Member = "MoveAfter", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.AutoIncrementBigInteger", Member = "SetCurrentAndIncrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BigNumber), Member = "NumberToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigNumberBuffer&), typeof(BigInteger&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(BigIntegerCalculator), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(BigIntegerCalculator), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(uint)}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(BigIntegerCalculator), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(BigIntegerCalculator), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(uint)}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static BigInteger op_Addition(BigInteger left, BigInteger right) { }

	[CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "Operation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.ExpressionType", typeof(object), typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigIntegerCalculator), Member = "Divide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public static BigInteger op_Division(BigInteger dividend, BigInteger divisor) { }

	[CalledBy(Type = "System.Data.AutoIncrementBigInteger", Member = "set_Seed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BigInteger), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(bool))]
	public static bool op_Equality(BigInteger left, long right) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "FromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Nullable`1<Single>")]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(float))]
	[CalledBy(Type = "System.Data.Common.BigIntegerStorage", Member = "ConvertFromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NumericsHelpers), Member = "GetDoubleFromParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(ulong)}, ReturnType = typeof(double))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float op_Explicit(BigInteger value) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "FromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Nullable`1<UInt64>")]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(ulong))]
	[CalledBy(Type = "System.Data.Common.BigIntegerStorage", Member = "ConvertFromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[CLSCompliant(False)]
	public static ulong op_Explicit(BigInteger value) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "FromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(long))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Nullable`1<Int64>")]
	[CalledBy(Type = "System.Data.DataColumn", Member = "set_DataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.AutoIncrementBigInteger", Member = "get_Step", ReturnType = typeof(long))]
	[CalledBy(Type = "System.Data.Common.BigIntegerStorage", Member = "ConvertFromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public static long op_Explicit(BigInteger value) { }

	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Nullable`1<UInt32>")]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(uint))]
	[CalledBy(Type = "System.Data.Common.BigIntegerStorage", Member = "ConvertFromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[CLSCompliant(False)]
	public static uint op_Explicit(BigInteger value) { }

	[CalledBy(Type = "Newtonsoft.Json.JsonReader", Member = "ReadAsDecimal", ReturnType = "System.Nullable`1<Decimal>")]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "FromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Nullable`1<Decimal>")]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "System.Data.Common.BigIntegerStorage", Member = "ConvertFromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decimal), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public static decimal op_Explicit(BigInteger value) { }

	[CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadInteger", ReturnType = typeof(int))]
	[CalledBy(Type = "Newtonsoft.Json.JsonReader", Member = "ReadAsInt32", ReturnType = "System.Nullable`1<Int32>")]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Nullable`1<Boolean>")]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(int))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Nullable`1<Int32>")]
	[CalledBy(Type = "System.Data.Common.BigIntegerStorage", Member = "ConvertFromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(sbyte))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(short))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	public static int op_Explicit(BigInteger value) { }

	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Nullable`1<Char>")]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(ushort))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(char))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Nullable`1<UInt16>")]
	[CalledBy(Type = "System.Data.Common.BigIntegerStorage", Member = "ConvertFromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BigInteger), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[CLSCompliant(False)]
	public static ushort op_Explicit(BigInteger value) { }

	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(short))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Nullable`1<Int16>")]
	[CalledBy(Type = "System.Data.Common.BigIntegerStorage", Member = "ConvertFromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BigInteger), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public static short op_Explicit(BigInteger value) { }

	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(sbyte))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Nullable`1<SByte>")]
	[CalledBy(Type = "System.Data.Common.BigIntegerStorage", Member = "ConvertFromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BigInteger), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[CLSCompliant(False)]
	public static sbyte op_Explicit(BigInteger value) { }

	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(byte))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Nullable`1<Byte>")]
	[CalledBy(Type = "System.Data.Common.BigIntegerStorage", Member = "ConvertFromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BigInteger), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public static byte op_Explicit(BigInteger value) { }

	[CalledBy(Type = "Newtonsoft.Json.JsonReader", Member = "ReadAsDouble", ReturnType = "System.Nullable`1<Double>")]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "FromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Nullable`1<Double>")]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(double))]
	[CalledBy(Type = "System.Data.Common.BigIntegerStorage", Member = "ConvertFromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(NumericsHelpers), Member = "GetDoubleFromParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(ulong)}, ReturnType = typeof(double))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static double op_Explicit(BigInteger value) { }

	[CalledBy(Type = "System.Data.Common.BigIntegerStorage", Member = "ConvertToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(void))]
	[CLSCompliant(False)]
	public static BigInteger op_Implicit(ulong value) { }

	[CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadOidAsString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.AutoIncrementBigInteger", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.Common.BigIntegerStorage", Member = "ConvertToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public static BigInteger op_Implicit(int value) { }

	[CalledBy(Type = "System.Data.Common.BigIntegerStorage", Member = "ConvertToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CLSCompliant(False)]
	public static BigInteger op_Implicit(uint value) { }

	[CalledBy(Type = "System.Data.DataColumn", Member = "set_AutoIncrementCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataColumn", Member = "set_DataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.AutoIncrementInt64", Member = "set_Seed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.AutoIncrementInt64", Member = "SetCurrentAndIncrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.AutoIncrementBigInteger", Member = "set_Seed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.AutoIncrementBigInteger", Member = "set_Step", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.Common.BigIntegerStorage", Member = "ConvertToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	public static BigInteger op_Implicit(long value) { }

	[CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadOidAsString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.Common.BigIntegerStorage", Member = "ConvertToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public static BigInteger op_Implicit(byte value) { }

	[CalledBy(Type = "System.Data.Common.BigIntegerStorage", Member = "ConvertToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CLSCompliant(False)]
	public static BigInteger op_Implicit(sbyte value) { }

	[CalledBy(Type = "System.Data.Common.BigIntegerStorage", Member = "ConvertToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CLSCompliant(False)]
	public static BigInteger op_Implicit(ushort value) { }

	[CalledBy(Type = "System.Data.Common.BigIntegerStorage", Member = "ConvertToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public static BigInteger op_Implicit(short value) { }

	[CalledBy(Type = "Newtonsoft.Json.JsonReader", Member = "ReadAsBoolean", ReturnType = "System.Nullable`1<Boolean>")]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextReader", Member = "ReadAsBoolean", ReturnType = "System.Nullable`1<Boolean>")]
	[CalledBy(Type = "Newtonsoft.Json.JsonValidatingReader", Member = "ValidateInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Schema.JsonSchemaModel"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "FromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.AutoIncrementBigInteger", Member = "set_Step", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(BigInteger), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(bool))]
	public static bool op_Inequality(BigInteger left, long right) { }

	[CalledBy(Type = "System.Data.DataColumn", Member = "set_AutoIncrementCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BigInteger), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
	public static bool op_Inequality(BigInteger left, BigInteger right) { }

	[CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadOidAsString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BigInteger), Member = "op_RightShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigInteger), Member = "op_RightShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(BigInteger))]
	[CallsUnknownMethods(Count = 3)]
	public static BigInteger op_LeftShift(BigInteger value, int shift) { }

	[CalledBy(Type = "System.Data.AutoIncrementBigInteger", Member = "BoundaryCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BigInteger), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public static bool op_LessThan(long left, BigInteger right) { }

	[CalledBy(Type = "System.Data.AutoIncrementBigInteger", Member = "BoundaryCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BigInteger), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(int))]
	public static bool op_LessThan(BigInteger left, long right) { }

	[CalledBy(Type = "System.Data.AutoIncrementInt64", Member = "BoundaryCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BigInteger), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(int))]
	public static bool op_LessThanOrEqual(long left, BigInteger right) { }

	[CalledBy(Type = "System.Data.AutoIncrementInt64", Member = "BoundaryCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BigInteger), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public static bool op_LessThanOrEqual(BigInteger left, long right) { }

	[CalledBy(Type = "System.Data.AutoIncrementBigInteger", Member = "BoundaryCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BigInteger), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public static bool op_LessThanOrEqual(BigInteger left, BigInteger right) { }

	[CalledBy(Type = "Newtonsoft.Json.JsonValidatingReader", Member = "ValidateInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Schema.JsonSchemaModel"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigIntegerCalculator), Member = "Divide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public static BigInteger op_Modulus(BigInteger dividend, BigInteger divisor) { }

	[CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "Operation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.ExpressionType", typeof(object), typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BigNumber), Member = "NumberToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigNumberBuffer&), typeof(BigInteger&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BigIntegerCalculator), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigIntegerCalculator), Member = "Square", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(int), typeof(UInt32*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigIntegerCalculator), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(uint)}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static BigInteger op_Multiply(BigInteger left, BigInteger right) { }

	[CalledBy(Type = typeof(BigInteger), Member = "op_LeftShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NumericsHelpers), Member = "DangerousMakeTwosComplement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigInteger), Member = "op_LeftShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(BigInteger))]
	[CallsUnknownMethods(Count = 3)]
	public static BigInteger op_RightShift(BigInteger value, int shift) { }

	[CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "Operation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.ExpressionType", typeof(object), typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Data.AutoIncrementBigInteger", Member = "set_Step", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BigIntegerCalculator), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(BigIntegerCalculator), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(uint)}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(BigIntegerCalculator), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(BigIntegerCalculator), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(uint)}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static BigInteger op_Subtraction(BigInteger left, BigInteger right) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static BigInteger op_UnaryNegation(BigInteger value) { }

	[CalledBy(Type = typeof(BigInteger), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(BigNumber), Member = "TryValidateParseStyleInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberStyles), typeof(ArgumentException&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BigNumber), Member = "TryParseBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(BigInteger&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public static BigInteger Parse(string value, NumberStyles style, IFormatProvider provider) { }

	[CalledBy(Type = "Newtonsoft.Json.JsonTextReader", Member = "BigIntegerParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CultureInfo)}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "ToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = "System.Data.Common.BigIntegerStorage", Member = "ConvertToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(BigInteger))]
	[CalledBy(Type = "System.Data.Common.BigIntegerStorage", Member = "ConvertXmlToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(BigInteger), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(BigInteger))]
	public static BigInteger Parse(string value, IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigIntegerCalculator), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[])}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigIntegerCalculator), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(uint)}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static BigInteger Subtract(UInt32[] leftBits, int leftSign, UInt32[] rightBits, int rightSign) { }

	[CalledBy(Type = typeof(BigInteger), Member = "ToByteArray", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BigInteger), Member = "TryGetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GetBytesMode), typeof(System.Span`1<System.Byte>), typeof(bool), typeof(bool), typeof(Int32&)}, ReturnType = typeof(Byte[]))]
	public Byte[] ToByteArray(bool isUnsigned = false, bool isBigEndian = false) { }

	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonWriter", Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BigInteger), Member = "ToByteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(Byte[]))]
	public Byte[] ToByteArray() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(BigNumber), Member = "FormatBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BigInteger), typeof(string), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

	[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter", Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter", Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter", Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.XmlNodeConverter", Member = "ConvertTokenToXmlValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader"}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(BigNumber), Member = "FormatBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BigInteger), typeof(string), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(string))]
	public string ToString(IFormatProvider provider) { }

	[CalledBy(Type = "Newtonsoft.Json.JsonConvert", Member = "ToStringInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.JsonConvert", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.Common.BigIntegerStorage", Member = "ConvertFromBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.Common.BigIntegerStorage", Member = "ConvertObjectToXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(BigNumber), Member = "FormatBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BigInteger), typeof(string), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(string))]
	public override string ToString(string format, IFormatProvider provider) { }

	[CalledBy(Type = typeof(BigInteger), Member = "ToByteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(BigInteger), Member = "TryWriteBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>), typeof(Int32&), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BigInteger), Member = "TryWriteOrCountBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>), typeof(Int32&), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BigNumber), Member = "FormatBigIntegerToHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BigInteger), typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private Byte[] TryGetBytes(GetBytesMode mode, Span<Byte> destination, bool isUnsigned, bool isBigEndian, ref int bytesWritten) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = "TryGetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GetBytesMode), typeof(System.Span`1<System.Byte>), typeof(bool), typeof(bool), typeof(Int32&)}, ReturnType = typeof(Byte[]))]
	public bool TryWriteBytes(Span<Byte> destination, out int bytesWritten, bool isUnsigned = false, bool isBigEndian = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = "TryGetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GetBytesMode), typeof(System.Span`1<System.Byte>), typeof(bool), typeof(bool), typeof(Int32&)}, ReturnType = typeof(Byte[]))]
	[ContainsUnimplementedInstructions]
	internal bool TryWriteOrCountBytes(Span<Byte> destination, out int bytesWritten, bool isUnsigned = false, bool isBigEndian = false) { }

}

