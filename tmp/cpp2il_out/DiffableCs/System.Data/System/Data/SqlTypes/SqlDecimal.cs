namespace System.Data.SqlTypes;

[XmlSchemaProvider("GetXsdType")]
public struct SqlDecimal : INullable, IComparable, IXmlSerializable
{
	private static readonly byte s_NUMERIC_MAX_PRECISION; //Field offset: 0x0
	public static readonly byte MaxPrecision; //Field offset: 0x1
	public static readonly byte MaxScale; //Field offset: 0x2
	private static readonly byte s_bNullMask; //Field offset: 0x3
	private static readonly byte s_bIsNull; //Field offset: 0x4
	private static readonly byte s_bNotNull; //Field offset: 0x5
	private static readonly byte s_bReverseNullMask; //Field offset: 0x6
	private static readonly byte s_bSignMask; //Field offset: 0x7
	private static readonly byte s_bPositive; //Field offset: 0x8
	private static readonly byte s_bNegative; //Field offset: 0x9
	private static readonly byte s_bReverseSignMask; //Field offset: 0xA
	private static readonly uint s_uiZero; //Field offset: 0xC
	private static readonly int s_cNumeMax; //Field offset: 0x10
	private static readonly long s_lInt32Base; //Field offset: 0x18
	private static readonly ulong s_ulInt32Base; //Field offset: 0x20
	private static readonly ulong s_ulInt32BaseForMod; //Field offset: 0x28
	internal static readonly ulong s_llMax; //Field offset: 0x30
	private static readonly uint s_ulBase10; //Field offset: 0x38
	private static readonly double s_DUINT_BASE; //Field offset: 0x40
	private static readonly double s_DUINT_BASE2; //Field offset: 0x48
	private static readonly double s_DUINT_BASE3; //Field offset: 0x50
	private static readonly double s_DMAX_NUME; //Field offset: 0x58
	private static readonly uint s_DBL_DIG; //Field offset: 0x60
	private static readonly byte s_cNumeDivScaleMin; //Field offset: 0x64
	private static readonly UInt32[] s_rgulShiftBase; //Field offset: 0x68
	private static readonly UInt32[] s_decimalHelpersLo; //Field offset: 0x70
	private static readonly UInt32[] s_decimalHelpersMid; //Field offset: 0x78
	private static readonly UInt32[] s_decimalHelpersHi; //Field offset: 0x80
	private static readonly UInt32[] s_decimalHelpersHiHi; //Field offset: 0x88
	private static readonly Byte[] s_rgCLenFromPrec; //Field offset: 0x90
	private static readonly uint s_ulT1; //Field offset: 0x98
	private static readonly uint s_ulT2; //Field offset: 0x9C
	private static readonly uint s_ulT3; //Field offset: 0xA0
	private static readonly uint s_ulT4; //Field offset: 0xA4
	private static readonly uint s_ulT5; //Field offset: 0xA8
	private static readonly uint s_ulT6; //Field offset: 0xAC
	private static readonly uint s_ulT7; //Field offset: 0xB0
	private static readonly uint s_ulT8; //Field offset: 0xB4
	private static readonly uint s_ulT9; //Field offset: 0xB8
	private static readonly ulong s_dwlT10; //Field offset: 0xC0
	private static readonly ulong s_dwlT11; //Field offset: 0xC8
	private static readonly ulong s_dwlT12; //Field offset: 0xD0
	private static readonly ulong s_dwlT13; //Field offset: 0xD8
	private static readonly ulong s_dwlT14; //Field offset: 0xE0
	private static readonly ulong s_dwlT15; //Field offset: 0xE8
	private static readonly ulong s_dwlT16; //Field offset: 0xF0
	private static readonly ulong s_dwlT17; //Field offset: 0xF8
	private static readonly ulong s_dwlT18; //Field offset: 0x100
	private static readonly ulong s_dwlT19; //Field offset: 0x108
	public static readonly SqlDecimal Null; //Field offset: 0x110
	public static readonly SqlDecimal MinValue; //Field offset: 0x124
	public static readonly SqlDecimal MaxValue; //Field offset: 0x138
	internal byte _bStatus; //Field offset: 0x0
	internal byte _bLen; //Field offset: 0x1
	internal byte _bPrec; //Field offset: 0x2
	internal byte _bScale; //Field offset: 0x3
	internal uint _data1; //Field offset: 0x4
	internal uint _data2; //Field offset: 0x8
	internal uint _data3; //Field offset: 0xC
	internal uint _data4; //Field offset: 0x10

	public Int32[] Data
	{
		[CalledBy(Type = typeof(SqlDecimal), Member = "GetHashCode", ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		 get { } //Length: 320
	}

	public override bool IsNull
	{
		[CalledBy(Type = typeof(SqlDecimal), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SqlDecimalStorage), Member = "IsNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 96
	}

	public bool IsPositive
	{
		[CalledBy(Type = typeof(SqlDecimal), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(SqlDecimal), Member = "ToDouble", ReturnType = typeof(double))]
		[CalledBy(Type = typeof(SqlDecimal), Member = "ToDecimal", ReturnType = typeof(Decimal))]
		[CalledBy(Type = typeof(SqlDecimal), Member = "op_UnaryNegation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal)}, ReturnType = typeof(SqlDecimal))]
		[CalledBy(Type = typeof(SqlDecimal), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal), typeof(SqlDecimal)}, ReturnType = typeof(SqlDecimal))]
		[CalledBy(Type = typeof(SqlDecimal), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal), typeof(SqlDecimal)}, ReturnType = typeof(SqlDecimal))]
		[CalledBy(Type = typeof(SqlDecimal), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal), typeof(SqlDecimal)}, ReturnType = typeof(SqlDecimal))]
		[CalledBy(Type = typeof(SqlDecimal), Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal), typeof(SqlDecimal)}, ReturnType = typeof(SqlDecimal))]
		[CalledBy(Type = typeof(SqlDecimal), Member = "CompareNm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal)}, ReturnType = typeof(EComparison))]
		[CalledBy(Type = typeof(SqlInt64), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal)}, ReturnType = typeof(SqlInt64))]
		[CalledBy(Type = typeof(SqlMoney), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 269
	}

	public byte Scale
	{
		[CalledBy(Type = typeof(SqlMoney), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 224
	}

	public decimal Value
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SqlDecimal), Member = "ToDecimal", ReturnType = typeof(Decimal))]
		 get { } //Length: 101
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SqlDecimal), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SqlDecimal))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private static SqlDecimal() { }

	[CallerCount(Count = 0)]
	private SqlDecimal(bool fNull) { }

	[CalledBy(Type = typeof(SqlDecimal), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(SqlDecimal))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(SqlDecimal))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlMoney)}, ReturnType = typeof(SqlDecimal))]
	[CalledBy(Type = typeof(SqlMoney), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlMoney), Member = "ToSqlDecimal", ReturnType = typeof(SqlDecimal))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Decimal), Member = "GetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(SqlDecimal), Member = "CalculatePrecision", ReturnType = typeof(byte))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public SqlDecimal(decimal value) { }

	[CalledBy(Type = typeof(SqlDecimal), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlByte)}, ReturnType = typeof(SqlDecimal))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlInt16)}, ReturnType = typeof(SqlDecimal))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlInt32)}, ReturnType = typeof(SqlDecimal))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	public SqlDecimal(int value) { }

	[CalledBy(Type = typeof(SqlDecimal), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlInt64)}, ReturnType = typeof(SqlDecimal))]
	[CalledBy(Type = typeof(SqlInt64), Member = "ToSqlDecimal", ReturnType = typeof(SqlDecimal))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SqlDecimal), Member = "BGetPrecUI8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(byte))]
	[ContainsUnimplementedInstructions]
	public SqlDecimal(long value) { }

	[CalledBy(Type = typeof(SqlDecimal), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal), typeof(SqlDecimal)}, ReturnType = typeof(SqlDecimal))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal), typeof(SqlDecimal)}, ReturnType = typeof(SqlDecimal))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal), typeof(SqlDecimal)}, ReturnType = typeof(SqlDecimal))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(SQLResource), Member = "get_InvalidPrecScaleMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(SqlTypeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private SqlDecimal(UInt32[] rglData, byte bLen, byte bPrec, byte bScale, bool fPositive) { }

	[CalledBy(Type = typeof(SqlDecimal), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SqlDecimal))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal), typeof(SqlDecimal)}, ReturnType = typeof(SqlDecimal))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "AdjustScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SQLResource), Member = "get_ArithOverflowMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	private void AddULong(uint ulAdd) { }

	[CalledBy(Type = typeof(SqlDecimal), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal), typeof(SqlDecimal)}, ReturnType = typeof(SqlDecimal))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal), typeof(SqlDecimal)}, ReturnType = typeof(SqlDecimal))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal), typeof(SqlDecimal)}, ReturnType = typeof(SqlDecimal))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "CompareNm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal)}, ReturnType = typeof(EComparison))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlInt64), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal)}, ReturnType = typeof(SqlInt64))]
	[CalledBy(Type = typeof(SqlMoney), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SqlDecimal), Member = "DivByULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(SqlDecimal), Member = "MultByULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SqlDecimal), Member = "AddULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SqlTruncateException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLResource), Member = "get_ArithOverflowMessage", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	internal void AdjustScale(int digits, bool fRound) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static byte BGetPrecUI4(uint value) { }

	[CalledBy(Type = typeof(SqlDecimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static byte BGetPrecUI8(ulong dwlVal) { }

	[CalledBy(Type = typeof(SqlDecimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal), typeof(SqlDecimal)}, ReturnType = typeof(SqlDecimal))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SqlDecimal), Member = "VerifyPrecision", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte)}, ReturnType = typeof(byte))]
	[CallsUnknownMethods(Count = 2)]
	private byte CalculatePrecision() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLResource), Member = "get_InvalidPrecScaleMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(SqlTypeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private static void CheckValidPrecScale(byte bPrec, byte bScale) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static char ChFromDigit(uint uiDigit) { }

	[CalledBy(Type = typeof(SqlDecimal), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal), typeof(SqlDecimal)}, ReturnType = typeof(SqlBoolean))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal), typeof(SqlDecimal)}, ReturnType = typeof(SqlBoolean))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal), typeof(SqlDecimal)}, ReturnType = typeof(SqlBoolean))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SqlDecimal), Member = "get_IsPositive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SqlDecimal), Member = "AdjustScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SqlDecimal), Member = "LAbsCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal)}, ReturnType = typeof(int))]
	private EComparison CompareNm(SqlDecimal snumOp) { }

	[CalledBy(Type = typeof(SqlDecimal), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlDecimalStorage), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlDecimalStorage), Member = "CompareValueTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SqlDecimal), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal), typeof(SqlDecimal)}, ReturnType = typeof(SqlBoolean))]
	[Calls(Type = typeof(SqlBoolean), Member = "op_True", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlBoolean)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SqlDecimal), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal), typeof(SqlDecimal)}, ReturnType = typeof(SqlBoolean))]
	[ContainsUnimplementedInstructions]
	public int CompareTo(SqlDecimal value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlDecimal), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ADP), Member = "WrongType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 8)]
	public override int CompareTo(object value) { }

	[CalledBy(Type = typeof(SqlDecimal), Member = "AdjustScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SQLResource), Member = "get_DivideByZeroMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(DivideByZeroException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private uint DivByULong(uint iDivisor) { }

	[CallerCount(Count = 0)]
	internal static ulong DWL(uint lo, uint hi) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlDecimal), Member = "get_IsNull", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SqlDecimal), Member = "CompareNm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal)}, ReturnType = typeof(EComparison))]
	[Calls(Type = typeof(SqlBoolean), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SqlBoolean), Member = "get_Value", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool FGt10_38() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private bool FGt10_38(UInt32[] rglData) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool FZero() { }

	[CalledBy(Type = typeof(SqlDecimal), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public Int32[] get_Data() { }

	[CalledBy(Type = typeof(SqlDecimal), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SqlDecimalStorage), Member = "IsNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	public override bool get_IsNull() { }

	[CalledBy(Type = typeof(SqlDecimal), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "ToDouble", ReturnType = typeof(double))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "ToDecimal", ReturnType = typeof(Decimal))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "op_UnaryNegation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal)}, ReturnType = typeof(SqlDecimal))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal), typeof(SqlDecimal)}, ReturnType = typeof(SqlDecimal))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal), typeof(SqlDecimal)}, ReturnType = typeof(SqlDecimal))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal), typeof(SqlDecimal)}, ReturnType = typeof(SqlDecimal))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal), typeof(SqlDecimal)}, ReturnType = typeof(SqlDecimal))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "CompareNm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal)}, ReturnType = typeof(EComparison))]
	[CalledBy(Type = typeof(SqlInt64), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal)}, ReturnType = typeof(SqlInt64))]
	[CalledBy(Type = typeof(SqlMoney), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public bool get_IsPositive() { }

	[CalledBy(Type = typeof(SqlMoney), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public byte get_Scale() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlDecimal), Member = "ToDecimal", ReturnType = typeof(Decimal))]
	public decimal get_Value() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlDecimal), Member = "CalculatePrecision", ReturnType = typeof(byte))]
	[Calls(Type = typeof(SqlDecimal), Member = "AdjustScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SqlDecimal), Member = "get_Data", ReturnType = typeof(Int32[]))]
	[CallsUnknownMethods(Count = 2)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	[CalledBy(Type = typeof(SqlDecimalStorage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SqlDecimal), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal), typeof(SqlDecimal)}, ReturnType = typeof(SqlBoolean))]
	public static SqlBoolean GreaterThan(SqlDecimal x, SqlDecimal y) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static uint HI(ulong x) { }

	[CalledBy(Type = typeof(SqlDecimal), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal), typeof(SqlDecimal)}, ReturnType = typeof(SqlDecimal))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "CompareNm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal)}, ReturnType = typeof(EComparison))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private int LAbsCmp(SqlDecimal snumOp) { }

	[CalledBy(Type = typeof(SqlDecimalStorage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SqlDecimal), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal), typeof(SqlDecimal)}, ReturnType = typeof(SqlBoolean))]
	public static SqlBoolean LessThan(SqlDecimal x, SqlDecimal y) { }

	[CallerCount(Count = 19)]
	[DeduplicatedMethod]
	private static uint LO(ulong x) { }

	[CalledBy(Type = typeof(SqlDecimal), Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal), typeof(SqlDecimal)}, ReturnType = typeof(SqlDecimal))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SqlDecimal), Member = "MpMul1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(Int32&), typeof(uint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static void MpDiv(UInt32[] rgulU, int ciulU, UInt32[] rgulD, int ciulD, UInt32[] rgulQ, out int ciulQ, UInt32[] rgulR, out int ciulR) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static void MpDiv1(UInt32[] rgulU, ref int ciulU, uint iulD, out uint iulR) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void MpMove(UInt32[] rgulS, int ciulS, UInt32[] rgulD, out int ciulD) { }

	[CalledBy(Type = typeof(SqlDecimal), Member = "MpDiv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(Int32&), typeof(UInt32[]), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static void MpMul1(UInt32[] piulD, ref int ciulD, uint iulX) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private static void MpNormalize(UInt32[] rgulU, ref int ciulU) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void MpSet(UInt32[] rgulD, out int ciulD, uint iulN) { }

	[CalledBy(Type = typeof(SqlDecimal), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SqlDecimal))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "AdjustScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SQLResource), Member = "get_ArithOverflowMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	private void MultByULong(uint uiMultiplier) { }

	[CalledBy(Type = typeof(SqlDecimal), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal), typeof(SqlDecimal)}, ReturnType = typeof(SqlDecimal))]
	[CalledBy(Type = typeof(SqlDecimalStorage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(SqlInt64Storage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(SqlMoneyStorage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(SqlDecimal), Member = "get_IsPositive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SqlDecimal), Member = "AdjustScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SqlDecimal), Member = "LAbsCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SqlDecimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(byte), typeof(byte), typeof(byte), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SqlDecimal), Member = "CalculatePrecision", ReturnType = typeof(byte))]
	[Calls(Type = typeof(SQLResource), Member = "get_ArithOverflowMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public static SqlDecimal op_Addition(SqlDecimal x, SqlDecimal y) { }

	[CalledBy(Type = typeof(SqlDecimalStorage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(SqlInt64Storage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(SqlMoneyStorage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SqlDecimal), Member = "get_IsPositive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SqlDecimal), Member = "AdjustScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SqlDecimal), Member = "MpDiv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(int), typeof(UInt32[]), typeof(Int32&), typeof(UInt32[]), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SqlDecimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(byte), typeof(byte), typeof(byte), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLResource), Member = "get_DivideByZeroMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(DivideByZeroException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static SqlDecimal op_Division(SqlDecimal x, SqlDecimal y) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlDecimal), Member = "CompareNm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal)}, ReturnType = typeof(EComparison))]
	[Calls(Type = typeof(SqlBoolean), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public static SqlBoolean op_Equality(SqlDecimal x, SqlDecimal y) { }

	[CalledBy(Type = typeof(SqlDecimal), Member = "GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal), typeof(SqlDecimal)}, ReturnType = typeof(SqlBoolean))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SqlDecimal), Member = "CompareNm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal)}, ReturnType = typeof(EComparison))]
	[Calls(Type = typeof(SqlBoolean), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public static SqlBoolean op_GreaterThan(SqlDecimal x, SqlDecimal y) { }

	[CalledBy(Type = typeof(SqlMoneyStorage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SqlMoney), Member = "ToDecimal", ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(SqlDecimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	public static SqlDecimal op_Implicit(SqlMoney x) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlDecimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	public static SqlDecimal op_Implicit(decimal x) { }

	[CalledBy(Type = typeof(SqlDecimalStorage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(SqlInt64Storage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(SqlMoneyStorage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SqlDecimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	public static SqlDecimal op_Implicit(long x) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlByte), Member = "get_Value", ReturnType = typeof(byte))]
	[Calls(Type = typeof(SqlDecimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static SqlDecimal op_Implicit(SqlByte x) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlDecimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public static SqlDecimal op_Implicit(SqlInt16 x) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlDecimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public static SqlDecimal op_Implicit(SqlInt32 x) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlDecimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static SqlDecimal op_Implicit(SqlInt64 x) { }

	[CalledBy(Type = typeof(SqlDecimal), Member = "LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal), typeof(SqlDecimal)}, ReturnType = typeof(SqlBoolean))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SqlDecimal), Member = "CompareNm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal)}, ReturnType = typeof(EComparison))]
	[Calls(Type = typeof(SqlBoolean), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public static SqlBoolean op_LessThan(SqlDecimal x, SqlDecimal y) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SqlDecimal), Member = "get_IsPositive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SqlDecimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(byte), typeof(byte), typeof(byte), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SqlDecimal), Member = "AdjustScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SqlDecimal), Member = "AddULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLResource), Member = "get_ArithOverflowMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 17)]
	[ContainsUnimplementedInstructions]
	public static SqlDecimal op_Multiply(SqlDecimal x, SqlDecimal y) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlDecimal), Member = "get_IsPositive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SqlDecimal), Member = "SetSignBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SqlDecimal), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal), typeof(SqlDecimal)}, ReturnType = typeof(SqlDecimal))]
	public static SqlDecimal op_Subtraction(SqlDecimal x, SqlDecimal y) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlDecimal), Member = "get_IsPositive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SqlDecimal), Member = "SetSignBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public static SqlDecimal op_UnaryNegation(SqlDecimal x) { }

	[CalledBy(Type = typeof(SqlDecimal), Member = "System.Xml.Serialization.IXmlSerializable.ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SqlDecimal), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SQLResource), Member = "get_NullString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(SqlDecimal), Member = "MultByULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SqlDecimal), Member = "AddULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLResource), Member = "get_FormatMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 21)]
	public static SqlDecimal Parse(string s) { }

	[CallerCount(Count = 0)]
	private void SetPositive() { }

	[CalledBy(Type = typeof(SqlDecimal), Member = "op_UnaryNegation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal)}, ReturnType = typeof(SqlDecimal))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal), typeof(SqlDecimal)}, ReturnType = typeof(SqlDecimal))]
	[CallerCount(Count = 2)]
	private void SetSignBit(bool fPositive) { }

	[CallerCount(Count = 0)]
	private void SetToZero() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void StoreFromWorkingArray(UInt32[] rguiData) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SqlDecimal), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SqlDecimal))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlDecimal), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	[CalledBy(Type = typeof(SqlDecimal), Member = "get_Value", ReturnType = typeof(Decimal))]
	[CalledBy(Type = typeof(SqlDecimal), Member = "ToSqlMoney", ReturnType = typeof(SqlMoney))]
	[CalledBy(Type = typeof(SqlMoney), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal)}, ReturnType = typeof(SqlMoney))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SqlDecimal), Member = "get_IsPositive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLResource), Member = "get_ConversionOverflowMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private decimal ToDecimal() { }

	[CalledBy(Type = typeof(SqlDecimal), Member = "ToSqlDouble", ReturnType = typeof(SqlDouble))]
	[CalledBy(Type = typeof(SqlDouble), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal)}, ReturnType = typeof(SqlDouble))]
	[CalledBy(Type = typeof(SqlSingle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal)}, ReturnType = typeof(SqlSingle))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Math), Member = "Pow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(SqlDecimal), Member = "get_IsPositive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public double ToDouble() { }

	[CalledBy(Type = typeof(SqlDecimalStorage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SqlDecimal), Member = "ToDouble", ReturnType = typeof(double))]
	[Calls(Type = typeof(SQLResource), Member = "get_ArithOverflowMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public SqlDouble ToSqlDouble() { }

	[CalledBy(Type = typeof(SqlInt64Storage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SqlInt64), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal)}, ReturnType = typeof(SqlInt64))]
	public SqlInt64 ToSqlInt64() { }

	[CalledBy(Type = typeof(SqlMoneyStorage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SqlDecimal), Member = "ToDecimal", ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(SqlMoney), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	public SqlMoney ToSqlMoney() { }

	[CalledBy(Type = typeof(SqlDecimal), Member = "System.Xml.Serialization.IXmlSerializable.WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SqlDecimal), Member = "get_IsPositive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SQLResource), Member = "get_NullString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual string ToString() { }

	[CalledBy(Type = typeof(SqlDecimal), Member = "CalculatePrecision", ReturnType = typeof(byte))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool VerifyPrecision(byte precision) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ZeroToMaxLen(UInt32[] rgulData, int cUI4sCur) { }

}

