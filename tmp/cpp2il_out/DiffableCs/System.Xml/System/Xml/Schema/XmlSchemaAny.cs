namespace System.Xml.Schema;

public class XmlSchemaAny : XmlSchemaParticle
{
	private string ns; //Field offset: 0x78
	private XmlSchemaContentProcessing processContents; //Field offset: 0x80
	private NamespaceList namespaceList; //Field offset: 0x88

	[XmlAttribute("namespace")]
	public string Namespace
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[XmlIgnore]
	internal NamespaceList NamespaceList
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	internal virtual string NameString
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(NamespaceList), Member = "get_Enumerate", ReturnType = typeof(ICollection))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 15)]
		internal get { } //Length: 990
	}

	[DefaultValue(XmlSchemaContentProcessing::None (0))]
	[XmlAttribute("processContents")]
	public XmlSchemaContentProcessing ProcessContents
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	[XmlIgnore]
	internal XmlSchemaContentProcessing ProcessContentsCorrect
	{
		[CalledBy(Type = typeof(Compiler), Member = "IsValidRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), typeof(XmlSchemaParticle)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Compiler), Member = "IsAnyFromAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAny), typeof(XmlSchemaAny)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlSchemaValidator), Member = "FastGetElementDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(object)}, ReturnType = typeof(SchemaElementDecl))]
		[CalledBy(Type = typeof(XsdValidator), Member = "ProcessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdValidator), Member = "FastGetElementDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(SchemaElementDecl))]
		[CallerCount(Count = 7)]
		internal get { } //Length: 21
	}

	[XmlIgnore]
	internal string ResolvedNamespace
	{
		[CalledBy(Type = typeof(Compiler), Member = "CompileComplexContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(ContentValidator))]
		[CallerCount(Count = 4)]
		internal get { } //Length: 67
	}

	[CalledBy(Type = typeof(XsdBuilder), Member = "InitAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataSet", Member = "GetDataSetSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(XmlSchemaComplexType))]
	[CalledBy(Type = "System.Data.DataTable", Member = "GetDataTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(XmlSchemaComplexType))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlSchemaParticle), Member = ".ctor", ReturnType = typeof(void))]
	public XmlSchemaAny() { }

	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "IsValidRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), typeof(XmlSchemaParticle)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "IsElementFromAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaAny)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Compiler), Member = "IsElementFromAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaAny)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal bool Allows(XmlQualifiedName qname) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NamespaceList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void BuildNamespaceList(string targetNamespace) { }

	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "PreprocessParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NamespaceListV1Compat), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void BuildNamespaceListV1Compat(string targetNamespace) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public string get_Namespace() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal NamespaceList get_NamespaceList() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(NamespaceList), Member = "get_Enumerate", ReturnType = typeof(ICollection))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 15)]
	internal virtual string get_NameString() { }

	[CalledBy(Type = typeof(Compiler), Member = "IsValidRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), typeof(XmlSchemaParticle)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Compiler), Member = "IsAnyFromAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAny), typeof(XmlSchemaAny)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "FastGetElementDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(object)}, ReturnType = typeof(SchemaElementDecl))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ProcessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "FastGetElementDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(SchemaElementDecl))]
	[CallerCount(Count = 7)]
	internal XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

	[CalledBy(Type = typeof(Compiler), Member = "CompileComplexContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(ContentValidator))]
	[CallerCount(Count = 4)]
	internal string get_ResolvedNamespace() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Namespace(string value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_ProcessContents(XmlSchemaContentProcessing value) { }

}

