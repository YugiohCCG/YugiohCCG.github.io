namespace System.Data.SqlTypes;

[XmlSchemaProvider("GetXsdType")]
public struct SqlMoney : INullable, IComparable, IXmlSerializable
{
	internal static readonly int s_iMoneyScale; //Field offset: 0x0
	private static readonly long s_lTickBase; //Field offset: 0x8
	private static readonly double s_dTickBase; //Field offset: 0x10
	private static readonly long s_minLong; //Field offset: 0x18
	private static readonly long s_maxLong; //Field offset: 0x20
	public static readonly SqlMoney Null; //Field offset: 0x28
	public static readonly SqlMoney Zero; //Field offset: 0x38
	public static readonly SqlMoney MinValue; //Field offset: 0x48
	public static readonly SqlMoney MaxValue; //Field offset: 0x58
	private bool _fNotNull; //Field offset: 0x0
	private long _value; //Field offset: 0x8

	public override bool IsNull
	{
		[CallerCount(Count = 18)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public decimal Value
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SqlMoney), Member = "ToDecimal", ReturnType = typeof(Decimal))]
		[Calls(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 162
	}

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static SqlMoney() { }

	[CalledBy(Type = typeof(SqlDecimal), Member = "ToSqlMoney", ReturnType = typeof(SqlMoney))]
	[CalledBy(Type = typeof(SqlMoney), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(SqlMoney))]
	[CalledBy(Type = typeof(SqlMoney), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(SqlMoney))]
	[CalledBy(Type = typeof(SqlMoney), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlMoney), typeof(SqlMoney)}, ReturnType = typeof(SqlMoney))]
	[CalledBy(Type = typeof(SqlMoney), Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlMoney), typeof(SqlMoney)}, ReturnType = typeof(SqlMoney))]
	[CalledBy(Type = typeof(SqlMoney), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlDecimal)}, ReturnType = typeof(SqlMoney))]
	[CalledBy(Type = typeof(SqlMoney), Member = "System.Xml.Serialization.IXmlSerializable.ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(SqlDecimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SqlDecimal), Member = "get_Scale", ReturnType = typeof(byte))]
	[Calls(Type = typeof(SqlDecimal), Member = "AdjustScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SqlDecimal), Member = "get_IsPositive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SQLResource), Member = "get_ArithOverflowMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public SqlMoney(decimal value) { }

	[CalledBy(Type = typeof(SqlMoney), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlInt64)}, ReturnType = typeof(SqlMoney))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SQLResource), Member = "get_ArithOverflowMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public SqlMoney(long value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private SqlMoney(bool fNull) { }

	[CallerCount(Count = 35)]
	[DeduplicatedMethod]
	internal SqlMoney(long value, int ignored) { }

	[CalledBy(Type = typeof(SqlMoney), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlByte)}, ReturnType = typeof(SqlMoney))]
	[CalledBy(Type = typeof(SqlMoney), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlInt16)}, ReturnType = typeof(SqlMoney))]
	[CalledBy(Type = typeof(SqlMoney), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlInt32)}, ReturnType = typeof(SqlMoney))]
	[CallerCount(Count = 3)]
	public SqlMoney(int value) { }

	[CalledBy(Type = typeof(SqlMoney), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlMoneyStorage), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlMoneyStorage), Member = "CompareValueTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SqlBoolean), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SqlBoolean), Member = "op_True", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlBoolean)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SqlMoney), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlMoney), typeof(SqlMoney)}, ReturnType = typeof(SqlBoolean))]
	[ContainsUnimplementedInstructions]
	public int CompareTo(SqlMoney value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlMoney), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlMoney)}, ReturnType = typeof(int))]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlMoney), Member = "ToDecimal", ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public decimal get_Value() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	[CalledBy(Type = typeof(SqlMoneyStorage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SqlBoolean), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public static SqlBoolean GreaterThan(SqlMoney x, SqlMoney y) { }

	[CalledBy(Type = typeof(SqlMoneyStorage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SqlBoolean), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public static SqlBoolean LessThan(SqlMoney x, SqlMoney y) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLResource), Member = "get_ArithOverflowMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public static SqlMoney op_Addition(SqlMoney x, SqlMoney y) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlMoney), Member = "ToDecimal", ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "Divide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(SqlMoney), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	public static SqlMoney op_Division(SqlMoney x, SqlMoney y) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlBoolean), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public static SqlBoolean op_Equality(SqlMoney x, SqlMoney y) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlDecimal), Member = "ToDecimal", ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(SqlMoney), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	public static SqlMoney op_Explicit(SqlDecimal x) { }

	[CalledBy(Type = typeof(SqlMoney), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlMoney)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SqlBoolean), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public static SqlBoolean op_GreaterThan(SqlMoney x, SqlMoney y) { }

	[CalledBy(Type = typeof(SqlConvert), Member = "ConvertToSqlMoney", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(SqlMoney))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SqlMoney), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static SqlMoney op_Implicit(SqlInt64 x) { }

	[CalledBy(Type = typeof(SqlConvert), Member = "ConvertToSqlMoney", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(SqlMoney))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SqlByte), Member = "get_Value", ReturnType = typeof(byte))]
	[Calls(Type = typeof(SqlMoney), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static SqlMoney op_Implicit(SqlByte x) { }

	[CalledBy(Type = typeof(SqlConvert), Member = "ConvertToSqlMoney", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(SqlMoney))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SqlMoney), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	public static SqlMoney op_Implicit(decimal x) { }

	[CalledBy(Type = typeof(SqlConvert), Member = "ConvertToSqlMoney", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(SqlMoney))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SqlMoney), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public static SqlMoney op_Implicit(SqlInt32 x) { }

	[CalledBy(Type = typeof(SqlConvert), Member = "ConvertToSqlMoney", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(SqlMoney))]
	[CalledBy(Type = typeof(SqlMoneyStorage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SqlMoney), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	public static SqlMoney op_Implicit(long x) { }

	[CalledBy(Type = typeof(SqlConvert), Member = "ConvertToSqlMoney", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(SqlMoney))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SqlMoney), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public static SqlMoney op_Implicit(SqlInt16 x) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlBoolean), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public static SqlBoolean op_LessThan(SqlMoney x, SqlMoney y) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlMoney), Member = "ToDecimal", ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(SqlMoney), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	public static SqlMoney op_Multiply(SqlMoney x, SqlMoney y) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLResource), Member = "get_ArithOverflowMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public static SqlMoney op_Subtraction(SqlMoney x, SqlMoney y) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SQLResource), Member = "get_ArithOverflowMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static SqlMoney op_UnaryNegation(SqlMoney x) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlConvert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(SqlMoney), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlMoney), Member = "ToDecimal", ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	[CalledBy(Type = typeof(SqlDecimal), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlMoney)}, ReturnType = typeof(SqlDecimal))]
	[CalledBy(Type = typeof(SqlMoney), Member = "get_Value", ReturnType = typeof(Decimal))]
	[CalledBy(Type = typeof(SqlMoney), Member = "ToDouble", ReturnType = typeof(double))]
	[CalledBy(Type = typeof(SqlMoney), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SqlMoney), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlMoney), typeof(SqlMoney)}, ReturnType = typeof(SqlMoney))]
	[CalledBy(Type = typeof(SqlMoney), Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlMoney), typeof(SqlMoney)}, ReturnType = typeof(SqlMoney))]
	[CalledBy(Type = typeof(SqlMoney), Member = "ToSqlDouble", ReturnType = typeof(SqlDouble))]
	[CalledBy(Type = typeof(SqlMoney), Member = "ToSqlDecimal", ReturnType = typeof(SqlDecimal))]
	[CalledBy(Type = typeof(SqlMoney), Member = "System.Xml.Serialization.IXmlSerializable.WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public decimal ToDecimal() { }

	[CalledBy(Type = typeof(SqlDouble), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlMoney)}, ReturnType = typeof(SqlDouble))]
	[CalledBy(Type = typeof(SqlSingle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlMoney)}, ReturnType = typeof(SqlSingle))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SqlMoney), Member = "ToDecimal", ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(double))]
	public double ToDouble() { }

	[CalledBy(Type = typeof(SqlMoneyStorage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SqlMoney), Member = "ToDecimal", ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(SqlDecimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	public SqlDecimal ToSqlDecimal() { }

	[CalledBy(Type = typeof(SqlMoneyStorage), Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SqlMoney), Member = "ToDecimal", ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(SQLResource), Member = "get_ArithOverflowMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public SqlDouble ToSqlDouble() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlMoney), Member = "ToDecimal", ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SQLResource), Member = "get_NullString", ReturnType = typeof(string))]
	public virtual string ToString() { }

}

