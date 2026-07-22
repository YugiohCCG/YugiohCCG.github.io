namespace System.Xml.Serialization;

public class XmlTypeMapping : XmlMapping
{
	private string xmlType; //Field offset: 0x48
	private string xmlTypeNamespace; //Field offset: 0x50
	private TypeData type; //Field offset: 0x58
	private XmlTypeMapping baseMap; //Field offset: 0x60
	private bool multiReferenceType; //Field offset: 0x68
	private bool includeInSchema; //Field offset: 0x69
	private bool isNullable; //Field offset: 0x6A
	private bool isAny; //Field offset: 0x6B
	private ArrayList _derivedTypes; //Field offset: 0x70

	internal XmlTypeMapping BaseMap
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal ArrayList DerivedTypes
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal bool HasXmlTypeNamespace
	{
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal get { } //Length: 9
	}

	internal bool IncludeInSchema
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	internal bool IsAny
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		internal set { } //Length: 4
	}

	internal bool IsNullable
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	internal bool MultiReferenceType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal TypeData TypeData
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	public string TypeFullName
	{
		[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadListElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(bool), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "GetEnumValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(string)}, ReturnType = typeof(object))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 27
	}

	internal string XmlType
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		internal get { } //Length: 254
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal string XmlTypeNamespace
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		internal get { } //Length: 30
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "CreateTypeMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string), typeof(string)}, ReturnType = typeof(XmlTypeMapping))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlMapping), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal XmlTypeMapping(string elementName, string ns, TypeData typeData, string xmlType, string xmlTypeNamespace) { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	internal XmlTypeMapping get_BaseMap() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	internal ArrayList get_DerivedTypes() { }

	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal bool get_HasXmlTypeNamespace() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal bool get_IsAny() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal bool get_IsNullable() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_MultiReferenceType() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	internal TypeData get_TypeData() { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadListElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(bool), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "GetEnumValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public string get_TypeFullName() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	internal string get_XmlType() { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	internal string get_XmlTypeNamespace() { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadClassInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 12)]
	internal XmlTypeMapping GetRealElementMap(string name, string ens) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	internal XmlTypeMapping GetRealTypeMap(Type objectType) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_BaseMap(XmlTypeMapping value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_IncludeInSchema(bool value) { }

	[CallerCount(Count = 0)]
	internal void set_IsAny(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_IsNullable(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_XmlType(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_XmlTypeNamespace(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	internal void UpdateRoot(XmlQualifiedName qname) { }

}

