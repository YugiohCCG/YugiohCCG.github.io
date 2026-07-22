namespace System.Xml.Serialization;

public class XmlSerializerNamespaces
{
	private Hashtable namespaces; //Field offset: 0x10

	public int Count
	{
		[CalledBy(Type = typeof(XmlSerializer), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(object), typeof(XmlSerializerNamespaces)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 138
	}

	internal ArrayList NamespaceList
	{
		[CalledBy(Type = typeof(XmlSerializerNamespaces), Member = "ToArray", ReturnType = typeof(XmlQualifiedName[]))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlSerializerNamespaces), Member = "get_Namespaces", ReturnType = typeof(Hashtable))]
		[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 18)]
		internal get { } //Length: 979
	}

	internal Hashtable Namespaces
	{
		[CalledBy(Type = typeof(XmlSerializerNamespaces), Member = "get_NamespaceList", ReturnType = typeof(ArrayList))]
		[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteNamespaceDeclarations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSerializerNamespaces)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaNamespaceManager), Member = "LookupNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(SchemaNamespaceManager), Member = "LookupPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 105
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public XmlSerializerNamespaces() { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadAttributeMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializer), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(object), typeof(XmlSerializerNamespaces)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "InferSchema1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlSchemaSet)}, ReturnType = typeof(XmlSchemaSet))]
	[CalledBy(Type = typeof(Preprocessor), Member = "GetBuildInSchema", ReturnType = typeof(XmlSchema))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XmlConvert), Member = "VerifyNCName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "ToUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Uri))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Add(string prefix, string ns) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void AddInternal(string prefix, string ns) { }

	[CalledBy(Type = typeof(XmlSerializer), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(object), typeof(XmlSerializerNamespaces)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public int get_Count() { }

	[CalledBy(Type = typeof(XmlSerializerNamespaces), Member = "ToArray", ReturnType = typeof(XmlQualifiedName[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializerNamespaces), Member = "get_Namespaces", ReturnType = typeof(Hashtable))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 18)]
	internal ArrayList get_NamespaceList() { }

	[CalledBy(Type = typeof(XmlSerializerNamespaces), Member = "get_NamespaceList", ReturnType = typeof(ArrayList))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteNamespaceDeclarations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSerializerNamespaces)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaNamespaceManager), Member = "LookupNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SchemaNamespaceManager), Member = "LookupPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal Hashtable get_Namespaces() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_Namespaces(Hashtable value) { }

	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(XmlSerializerNamespaces)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "GetPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "GetNamespaceFromPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlSerializerNamespaces), Member = "get_NamespaceList", ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public XmlQualifiedName[] ToArray() { }

}

