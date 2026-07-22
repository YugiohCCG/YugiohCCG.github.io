namespace System.Data.SqlTypes;

[XmlSchemaProvider("GetXsdType")]
public struct SqlInt64 : INullable, IComparable, IXmlSerializable
{
	private static readonly long s_lLowIntMask; //Field offset: 0x0
	private static readonly long s_lHighIntMask; //Field offset: 0x8
	public static readonly SqlInt64 Null; //Field offset: 0x10
	public static readonly SqlInt64 Zero; //Field offset: 0x20
	public static readonly SqlInt64 MinValue; //Field offset: 0x30
	public static readonly SqlInt64 MaxValue; //Field offset: 0x40
	private bool m_fNotNull; //Field offset: 0x0
	private long m_value; //Field offset: 0x8

	public override bool IsNull
	{
		[CallerCount(Count = 18)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public long Value
	{
		[CalledBy(Type = typeof(SqlByte), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlInt64)}, ReturnType = typeof(SqlByte))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 84
	}

	[CallerCount(Count = 0)]
	private static SqlInt64() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private SqlInt64(bool fNull) { }

	[CallerCount(Count = 35)]
	[DeduplicatedMethod]
	public SqlInt64(long value) { }

	[CalledBy(Type = typeof(SqlInt64), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlInt64Storage), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlInt64Storage), Member = "CompareValueTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SqlBoolean), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SqlBoolean), Member = "op_True", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlBoolean)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SqlInt64), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlInt64), typeof(SqlInt64)}, ReturnType = typeof(SqlBoolean))]
	[ContainsUnimplementedInstructions]
	public int CompareTo(SqlInt64 value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlInt64), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlInt64)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ADP), Member = "WrongType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 8)]
	public override int CompareTo(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlBoolean), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SqlBoolean), Member = "get_Value", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object value) { }

	[CallerCount(Count = 18)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool get_IsNull() { }

	[CalledBy(Type = typeof(SqlByte), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlInt64)}, ReturnType = typeof(SqlByte))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public long get_Value() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	[CalledBy(Type = typeof(SqlInt64Storage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SqlBoolean), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public static SqlBoolean GreaterThan(SqlInt64 x, SqlInt64 y) { }

	[CalledBy(Type = typeof(SqlInt64Storage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SqlBoolean), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public static SqlBoolean LessThan(SqlInt64 x, SqlInt64 y) { }

	[CalledBy(Type = typeof(SqlByteStorage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(SqlInt16Storage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(SqlInt32Storage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(SqlInt64Storage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(SQLResource), Member = "get_ArithOverflowMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static SqlInt64 op_Addition(SqlInt64 x, SqlInt64 y) { }

	[CalledBy(Type = typeof(SqlByteStorage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(SqlInt16Storage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(SqlInt32Storage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SQLResource), Member = "get_DivideByZeroMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(DivideByZeroException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLResource), Member = "get_ArithOverflowMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	public static SqlInt64 op_Division(SqlInt64 x, SqlInt64 y) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlBoolean), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public static SqlBoolean op_Equality(SqlInt64 x, SqlInt64 y) { }

	[CalledBy(Type = typeof(SqlDecimal), Member = "ToSqlInt64", ReturnType = typeof(SqlInt64))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SqlDecimal), Member = "AdjustScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SqlDecimal), Member = "get_IsPositive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SQLResource), Member = "get_ConversionOverflowMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public static SqlInt64 op_Explicit(SqlDecimal x) { }

	[CalledBy(Type = typeof(SqlInt64), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlInt64)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SqlBoolean), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public static SqlBoolean op_GreaterThan(SqlInt64 x, SqlInt64 y) { }

	[CalledBy(Type = typeof(SqlConvert), Member = "ConvertToSqlInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(SqlInt64))]
	[CalledBy(Type = typeof(SqlByteStorage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(SqlInt16Storage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(SqlInt32Storage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(SqlInt64Storage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 12)]
	public static SqlInt64 op_Implicit(long x) { }

	[CalledBy(Type = typeof(SqlConvert), Member = "ConvertToSqlInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(SqlInt64))]
	[CalledBy(Type = typeof(SqlInt16Storage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	public static SqlInt64 op_Implicit(SqlInt16 x) { }

	[CalledBy(Type = typeof(SqlByte), Member = "ToSqlInt64", ReturnType = typeof(SqlInt64))]
	[CalledBy(Type = typeof(SqlConvert), Member = "ConvertToSqlInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(SqlInt64))]
	[CalledBy(Type = typeof(SqlByteStorage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SqlByte), Member = "get_Value", ReturnType = typeof(byte))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static SqlInt64 op_Implicit(SqlByte x) { }

	[CalledBy(Type = typeof(SqlConvert), Member = "ConvertToSqlInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(SqlInt64))]
	[CalledBy(Type = typeof(SqlInt32Storage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	public static SqlInt64 op_Implicit(SqlInt32 x) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlBoolean), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public static SqlBoolean op_LessThan(SqlInt64 x, SqlInt64 y) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLResource), Member = "get_DivideByZeroMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(DivideByZeroException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SQLResource), Member = "get_ArithOverflowMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	public static SqlInt64 op_Modulus(SqlInt64 x, SqlInt64 y) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLResource), Member = "get_ArithOverflowMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 15)]
	public static SqlInt64 op_Multiply(SqlInt64 x, SqlInt64 y) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLResource), Member = "get_ArithOverflowMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static SqlInt64 op_Subtraction(SqlInt64 x, SqlInt64 y) { }

	[CallerCount(Count = 0)]
	public static SqlInt64 op_UnaryNegation(SqlInt64 x) { }

	[CallerCount(Count = 0)]
	private static bool SameSignLong(long x, long y) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlConvert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	[CalledBy(Type = typeof(SqlByteStorage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SqlByte), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlInt64)}, ReturnType = typeof(SqlByte))]
	public SqlByte ToSqlByte() { }

	[CalledBy(Type = typeof(SqlInt64Storage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SqlDecimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	public SqlDecimal ToSqlDecimal() { }

	[CalledBy(Type = typeof(SqlInt64Storage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SQLResource), Member = "get_ArithOverflowMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public SqlDouble ToSqlDouble() { }

	[CalledBy(Type = typeof(SqlInt16Storage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SQLResource), Member = "get_ArithOverflowMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public SqlInt16 ToSqlInt16() { }

	[CalledBy(Type = typeof(SqlInt32Storage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SQLResource), Member = "get_ArithOverflowMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public SqlInt32 ToSqlInt32() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLResource), Member = "get_NullString", ReturnType = typeof(string))]
	[Calls(Type = typeof(long), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

