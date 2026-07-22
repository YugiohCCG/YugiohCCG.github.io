namespace System.Data.SqlTypes;

[XmlSchemaProvider("GetXsdType")]
public struct SqlByte : INullable, IComparable, IXmlSerializable
{
	private static readonly int s_iBitNotByteMax; //Field offset: 0x0
	public static readonly SqlByte Null; //Field offset: 0x4
	public static readonly SqlByte Zero; //Field offset: 0x6
	public static readonly SqlByte MinValue; //Field offset: 0x8
	public static readonly SqlByte MaxValue; //Field offset: 0xA
	private bool m_fNotNull; //Field offset: 0x0
	private byte m_value; //Field offset: 0x1

	public override bool IsNull
	{
		[CallerCount(Count = 18)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public byte Value
	{
		[CalledBy(Type = typeof(SqlDecimal), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlByte)}, ReturnType = typeof(SqlDecimal))]
		[CalledBy(Type = typeof(SqlDouble), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlByte)}, ReturnType = typeof(SqlDouble))]
		[CalledBy(Type = typeof(SqlInt16), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlByte)}, ReturnType = typeof(SqlInt16))]
		[CalledBy(Type = typeof(SqlInt32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlByte)}, ReturnType = typeof(SqlInt32))]
		[CalledBy(Type = typeof(SqlInt64), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlByte)}, ReturnType = typeof(SqlInt64))]
		[CalledBy(Type = typeof(SqlMoney), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlByte)}, ReturnType = typeof(SqlMoney))]
		[CalledBy(Type = typeof(SqlSingle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlByte)}, ReturnType = typeof(SqlSingle))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 84
	}

	[CallerCount(Count = 0)]
	private static SqlByte() { }

	[CallerCount(Count = 0)]
	private SqlByte(bool fNull) { }

	[CallerCount(Count = 67)]
	[DeduplicatedMethod]
	public SqlByte(byte value) { }

	[CalledBy(Type = typeof(SqlByte), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlByteStorage), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlByteStorage), Member = "CompareValueTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SqlByte), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlByte), typeof(SqlByte)}, ReturnType = typeof(SqlBoolean))]
	[Calls(Type = typeof(SqlByte), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlByte), typeof(SqlByte)}, ReturnType = typeof(SqlBoolean))]
	[ContainsUnimplementedInstructions]
	public int CompareTo(SqlByte value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlByte), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlByte)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ADP), Member = "WrongType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 8)]
	public override int CompareTo(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object value) { }

	[CallerCount(Count = 18)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool get_IsNull() { }

	[CalledBy(Type = typeof(SqlDecimal), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlByte)}, ReturnType = typeof(SqlDecimal))]
	[CalledBy(Type = typeof(SqlDouble), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlByte)}, ReturnType = typeof(SqlDouble))]
	[CalledBy(Type = typeof(SqlInt16), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlByte)}, ReturnType = typeof(SqlInt16))]
	[CalledBy(Type = typeof(SqlInt32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlByte)}, ReturnType = typeof(SqlInt32))]
	[CalledBy(Type = typeof(SqlInt64), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlByte)}, ReturnType = typeof(SqlInt64))]
	[CalledBy(Type = typeof(SqlMoney), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlByte)}, ReturnType = typeof(SqlMoney))]
	[CalledBy(Type = typeof(SqlSingle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlByte)}, ReturnType = typeof(SqlSingle))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public byte get_Value() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	[CalledBy(Type = typeof(SqlByteStorage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SqlByte), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlByte), typeof(SqlByte)}, ReturnType = typeof(SqlBoolean))]
	public static SqlBoolean GreaterThan(SqlByte x, SqlByte y) { }

	[CalledBy(Type = typeof(SqlByteStorage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SqlByte), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlByte), typeof(SqlByte)}, ReturnType = typeof(SqlBoolean))]
	public static SqlBoolean LessThan(SqlByte x, SqlByte y) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLResource), Member = "get_ArithOverflowMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static SqlByte op_Addition(SqlByte x, SqlByte y) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLResource), Member = "get_DivideByZeroMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(DivideByZeroException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public static SqlByte op_Division(SqlByte x, SqlByte y) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static SqlBoolean op_Equality(SqlByte x, SqlByte y) { }

	[CalledBy(Type = typeof(SqlInt64), Member = "ToSqlByte", ReturnType = typeof(SqlByte))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SqlInt64), Member = "get_Value", ReturnType = typeof(long))]
	[Calls(Type = typeof(SQLResource), Member = "get_ArithOverflowMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static SqlByte op_Explicit(SqlInt64 x) { }

	[CalledBy(Type = typeof(SqlByte), Member = "GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlByte), typeof(SqlByte)}, ReturnType = typeof(SqlBoolean))]
	[CalledBy(Type = typeof(SqlByte), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlByte)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static SqlBoolean op_GreaterThan(SqlByte x, SqlByte y) { }

	[CalledBy(Type = typeof(SqlConvert), Member = "ConvertToSqlByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(SqlByte))]
	[CalledBy(Type = typeof(SqlByteStorage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	public static SqlByte op_Implicit(byte x) { }

	[CalledBy(Type = typeof(SqlByte), Member = "LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlByte), typeof(SqlByte)}, ReturnType = typeof(SqlBoolean))]
	[CalledBy(Type = typeof(SqlByte), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlByte)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static SqlBoolean op_LessThan(SqlByte x, SqlByte y) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLResource), Member = "get_ArithOverflowMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static SqlByte op_Multiply(SqlByte x, SqlByte y) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLResource), Member = "get_ArithOverflowMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static SqlByte op_Subtraction(SqlByte x, SqlByte y) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlConvert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(byte))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	[CalledBy(Type = typeof(SqlByteStorage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SqlDouble), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlByte)}, ReturnType = typeof(SqlDouble))]
	public SqlDouble ToSqlDouble() { }

	[CalledBy(Type = typeof(SqlByteStorage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SqlInt64), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlByte)}, ReturnType = typeof(SqlInt64))]
	public SqlInt64 ToSqlInt64() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

