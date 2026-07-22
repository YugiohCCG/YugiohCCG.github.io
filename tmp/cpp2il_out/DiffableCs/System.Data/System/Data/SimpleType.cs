namespace System.Data;

internal sealed class SimpleType : ISerializable
{
	private string _baseType; //Field offset: 0x10
	private SimpleType _baseSimpleType; //Field offset: 0x18
	private XmlQualifiedName _xmlBaseType; //Field offset: 0x20
	private string _name; //Field offset: 0x28
	private int _length; //Field offset: 0x30
	private int _minLength; //Field offset: 0x34
	private int _maxLength; //Field offset: 0x38
	private string _pattern; //Field offset: 0x40
	private string _ns; //Field offset: 0x48
	private string _maxExclusive; //Field offset: 0x50
	private string _maxInclusive; //Field offset: 0x58
	private string _minExclusive; //Field offset: 0x60
	private string _minInclusive; //Field offset: 0x68
	internal string _enumeration; //Field offset: 0x70

	internal SimpleType BaseSimpleType
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal string BaseType
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal int Length
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	internal int MaxLength
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	internal string Name
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal string Namespace
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		internal get { } //Length: 254
	}

	public string SimpleTypeQualifiedName
	{
		[CalledBy(Type = typeof(XSDSchema), Member = "CollectElementsAnnotations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(ArrayList)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet), typeof(DataSet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleSimpleTypeSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(string), typeof(DataTable), typeof(bool), typeof(XmlAttribute[]), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleAttributeColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XSDSchema), Member = "HandleElementColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 94
	}

	internal XmlQualifiedName XmlBaseType
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CalledBy(Type = typeof(SimpleType), Member = "CreateEnumeratedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SimpleType))]
	[CalledBy(Type = typeof(SimpleType), Member = "CreateByteArrayType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SimpleType))]
	[CalledBy(Type = typeof(SimpleType), Member = "CreateLimitedStringType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(SimpleType))]
	[CalledBy(Type = typeof(SimpleType), Member = "CreateSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StorageType), typeof(Type)}, ReturnType = typeof(SimpleType))]
	[CalledBy(Type = typeof(XDRSchema), Member = "HandleColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	internal SimpleType(string baseType) { }

	[CalledBy(Type = typeof(SimpleType), Member = "LoadTypeValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "CollectElementsAnnotations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "ParseDataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleSimpleTypeSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(string), typeof(DataTable), typeof(bool), typeof(XmlAttribute[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleAttributeColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleElementColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_QualifiedName", ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SimpleType), Member = "LoadTypeValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	internal SimpleType(XmlSchemaSimpleType node) { }

	[CalledBy(Type = typeof(DataColumn), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(string), typeof(MappingType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "set_DataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "SetMaxLengthSimpleType", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "set_MaxLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "set_SimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SimpleType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "Clone", ReturnType = typeof(DataColumn))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal bool CanHaveMaxLength() { }

	[CalledBy(Type = typeof(DataColumn), Member = "SetMaxLengthSimpleType", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "set_MaxLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	internal void ConvertToAnnonymousSimpleType() { }

	[CalledBy(Type = typeof(XDRSchema), Member = "HandleColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SimpleType), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static SimpleType CreateByteArrayType(string encoding) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleType), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal static SimpleType CreateEnumeratedType(string values) { }

	[CalledBy(Type = typeof(DataColumn), Member = "SetMaxLengthSimpleType", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "set_MaxLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SimpleType), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal static SimpleType CreateLimitedStringType(int length) { }

	[CalledBy(Type = typeof(DataColumn), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(string), typeof(MappingType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "set_DataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SimpleType), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static SimpleType CreateSimpleType(StorageType typeCode, Type type) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	internal SimpleType get_BaseSimpleType() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal string get_BaseType() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	internal int get_Length() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	internal int get_MaxLength() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	internal string get_Name() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	internal string get_Namespace() { }

	[CalledBy(Type = typeof(XSDSchema), Member = "CollectElementsAnnotations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet), typeof(DataSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleSimpleTypeSimpleContentColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(string), typeof(DataTable), typeof(bool), typeof(XmlAttribute[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleAttributeColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleElementColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public string get_SimpleTypeQualifiedName() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal XmlQualifiedName get_XmlBaseType() { }

	[CalledBy(Type = typeof(SimpleType), Member = "HasConflictingDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SimpleType)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XSDSchema), Member = "CollectElementsAnnotations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SimpleType), Member = "HasConflictingDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SimpleType)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	internal string HasConflictingDefinition(SimpleType otherSimpleType) { }

	[CalledBy(Type = typeof(DataColumn), Member = "SetMaxLengthSimpleType", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "set_MaxLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XSDSchema), Member = "QualifiedName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal bool IsPlainString() { }

	[CalledBy(Type = typeof(SimpleType), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleElementColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_QualifiedName", ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SimpleType), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaObjectCollection), Member = "GetEnumerator", ReturnType = typeof(XmlSchemaObjectEnumerator))]
	[Calls(Type = typeof(XmlSchemaObjectEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaObjectEnumerator), Member = "get_Current", ReturnType = typeof(XmlSchemaObject))]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XSDSchema), Member = "GetMsdataAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAnnotated), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "SimpleTypeNotSupported", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 25)]
	internal void LoadTypeValues(XmlSchemaSimpleType node) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	internal string QualifiedName(string name) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_MaxLength(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleColumnType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(XmlDocument), typeof(XmlElement), typeof(XmlElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 2)]
	internal XmlNode ToNode(XmlDocument dc, Hashtable prefixes, bool inRemoting) { }

}

