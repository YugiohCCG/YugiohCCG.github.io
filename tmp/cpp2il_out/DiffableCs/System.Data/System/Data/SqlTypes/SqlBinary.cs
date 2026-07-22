namespace System.Data.SqlTypes;

[DefaultMember("Item")]
[XmlSchemaProvider("GetXsdType")]
public struct SqlBinary : INullable, IComparable, IXmlSerializable
{
	public static readonly SqlBinary Null; //Field offset: 0x0
	private Byte[] _value; //Field offset: 0x0

	public override bool IsNull
	{
		[CallerCount(Count = 13)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public Byte[] Value
	{
		[CalledBy(Type = "Newtonsoft.Json.Converters.BinaryConverter", Member = "GetByteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "System.Byte[]")]
		[CalledBy(Type = typeof(SqlBinary), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlBinary), typeof(SqlBinary)}, ReturnType = typeof(SqlBoolean))]
		[CalledBy(Type = typeof(SqlBinary), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlBinary), typeof(SqlBinary)}, ReturnType = typeof(SqlBoolean))]
		[CalledBy(Type = typeof(SqlBinary), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlBinary), typeof(SqlBinary)}, ReturnType = typeof(SqlBoolean))]
		[CalledBy(Type = typeof(SqlBinary), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlBinary)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(SqlBinary), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SqlBytes), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlBinary)}, ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 200
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static SqlBinary() { }

	[CallerCount(Count = 66)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private SqlBinary(bool fNull) { }

	[CalledBy(Type = "Newtonsoft.Json.Converters.BinaryConverter", Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", typeof(Type), typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public SqlBinary(Byte[] value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlBinary), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlBinary)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ADP), Member = "WrongType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 8)]
	public override int CompareTo(object value) { }

	[CalledBy(Type = typeof(SqlBinary), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlBinaryStorage), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlBinaryStorage), Member = "CompareValueTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SqlBinary), Member = "get_Value", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(SqlBinary), Member = "PerformCompareByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(EComparison))]
	[ContainsUnimplementedInstructions]
	public int CompareTo(SqlBinary value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlBinary), Member = "get_Value", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(SqlBinary), Member = "PerformCompareByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(EComparison))]
	[Calls(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object value) { }

	[CallerCount(Count = 13)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool get_IsNull() { }

	[CalledBy(Type = "Newtonsoft.Json.Converters.BinaryConverter", Member = "GetByteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = typeof(SqlBinary), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlBinary), typeof(SqlBinary)}, ReturnType = typeof(SqlBoolean))]
	[CalledBy(Type = typeof(SqlBinary), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlBinary), typeof(SqlBinary)}, ReturnType = typeof(SqlBoolean))]
	[CalledBy(Type = typeof(SqlBinary), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlBinary), typeof(SqlBinary)}, ReturnType = typeof(SqlBoolean))]
	[CalledBy(Type = typeof(SqlBinary), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlBinary)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlBinary), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SqlBytes), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlBinary)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public Byte[] get_Value() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	[CalledBy(Type = typeof(SqlString), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static int HashByteArray(Byte[] rgbValue, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlBinary), Member = "get_Value", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(SqlBinary), Member = "PerformCompareByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(EComparison))]
	[ContainsUnimplementedInstructions]
	public static SqlBoolean op_Equality(SqlBinary x, SqlBinary y) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlBinary), Member = "get_Value", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(SqlBinary), Member = "PerformCompareByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(EComparison))]
	[ContainsUnimplementedInstructions]
	public static SqlBoolean op_GreaterThan(SqlBinary x, SqlBinary y) { }

	[CalledBy(Type = typeof(SqlConvert), Member = "ConvertToSqlBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(SqlBinary))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static SqlBinary op_Implicit(Byte[] x) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlBinary), Member = "get_Value", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(SqlBinary), Member = "PerformCompareByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(EComparison))]
	[ContainsUnimplementedInstructions]
	public static SqlBoolean op_LessThan(SqlBinary x, SqlBinary y) { }

	[CalledBy(Type = typeof(SqlBinary), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlBinary), typeof(SqlBinary)}, ReturnType = typeof(SqlBoolean))]
	[CalledBy(Type = typeof(SqlBinary), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlBinary), typeof(SqlBinary)}, ReturnType = typeof(SqlBoolean))]
	[CalledBy(Type = typeof(SqlBinary), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlBinary), typeof(SqlBinary)}, ReturnType = typeof(SqlBoolean))]
	[CalledBy(Type = typeof(SqlBinary), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlBinary)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlBinary), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	private static EComparison PerformCompareByte(Byte[] x, Byte[] y) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(Convert), Member = "FromBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

}

