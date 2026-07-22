namespace System.Data.SqlTypes;

[XmlSchemaProvider("GetXsdType")]
public struct SqlGuid : INullable, IComparable, IXmlSerializable
{
	private static readonly int s_sizeOfGuid; //Field offset: 0x0
	private static readonly Int32[] s_rgiGuidOrder; //Field offset: 0x8
	public static readonly SqlGuid Null; //Field offset: 0x10
	private Byte[] m_value; //Field offset: 0x0

	public override bool IsNull
	{
		[CallerCount(Count = 13)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public Guid Value
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 161
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private static SqlGuid() { }

	[CallerCount(Count = 66)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private SqlGuid(bool fNull) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Guid), Member = "ToByteArray", ReturnType = typeof(Byte[]))]
	[CallsUnknownMethods(Count = 1)]
	public SqlGuid(Guid g) { }

	[CalledBy(Type = typeof(SqlGuid), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlGuid), typeof(SqlGuid)}, ReturnType = typeof(SqlBoolean))]
	[CalledBy(Type = typeof(SqlGuid), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlGuid), typeof(SqlGuid)}, ReturnType = typeof(SqlBoolean))]
	[CalledBy(Type = typeof(SqlGuid), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlGuid), typeof(SqlGuid)}, ReturnType = typeof(SqlBoolean))]
	[CalledBy(Type = typeof(SqlGuid), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlGuid)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlGuid), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	private static EComparison Compare(SqlGuid x, SqlGuid y) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ADP), Member = "WrongType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 8)]
	[ContainsInvalidInstructions]
	public override int CompareTo(object value) { }

	[CalledBy(Type = typeof(SqlGuidStorage), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SqlGuidStorage), Member = "CompareValueTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SqlGuid), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlGuid), typeof(SqlGuid)}, ReturnType = typeof(EComparison))]
	[Calls(Type = typeof(SqlBoolean), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SqlBoolean), Member = "op_True", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlBoolean)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	public int CompareTo(SqlGuid value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlGuid), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlGuid), typeof(SqlGuid)}, ReturnType = typeof(EComparison))]
	[Calls(Type = typeof(SqlBoolean), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SqlBoolean), Member = "get_Value", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object value) { }

	[CallerCount(Count = 13)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool get_IsNull() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Guid get_Value() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Guid), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlGuid), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlGuid), typeof(SqlGuid)}, ReturnType = typeof(EComparison))]
	[Calls(Type = typeof(SqlBoolean), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public static SqlBoolean op_Equality(SqlGuid x, SqlGuid y) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlGuid), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlGuid), typeof(SqlGuid)}, ReturnType = typeof(EComparison))]
	[Calls(Type = typeof(SqlBoolean), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public static SqlBoolean op_GreaterThan(SqlGuid x, SqlGuid y) { }

	[CalledBy(Type = typeof(SqlConvert), Member = "ConvertToSqlGuid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(SqlGuid))]
	[CalledBy(Type = typeof(SqlConvert), Member = "ChangeType2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(StorageType), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Guid), Member = "ToByteArray", ReturnType = typeof(Byte[]))]
	[CallsUnknownMethods(Count = 1)]
	public static SqlGuid op_Implicit(Guid x) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlGuid), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SqlGuid), typeof(SqlGuid)}, ReturnType = typeof(EComparison))]
	[Calls(Type = typeof(SqlBoolean), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public static SqlBoolean op_LessThan(SqlGuid x, SqlGuid y) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Guid), Member = "ToByteArray", ReturnType = typeof(Byte[]))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(SQLResource), Member = "get_NullString", ReturnType = typeof(string))]
	public virtual string ToString() { }

}

