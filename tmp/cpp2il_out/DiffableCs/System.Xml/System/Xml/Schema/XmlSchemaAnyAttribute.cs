namespace System.Xml.Schema;

public class XmlSchemaAnyAttribute : XmlSchemaAnnotated
{
	private string ns; //Field offset: 0x50
	private XmlSchemaContentProcessing processContents; //Field offset: 0x58
	private NamespaceList namespaceList; //Field offset: 0x60

	[XmlAttribute("namespace")]
	public string Namespace
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[XmlIgnore]
	internal NamespaceList NamespaceList
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[DefaultValue(XmlSchemaContentProcessing::None (0))]
	[XmlAttribute("processContents")]
	public XmlSchemaContentProcessing ProcessContents
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[XmlIgnore]
	internal XmlSchemaContentProcessing ProcessContentsCorrect
	{
		[CalledBy(Type = typeof(SchemaInfo), Member = "GetAttributeXsd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl), typeof(XmlQualifiedName), typeof(XmlSchemaObject), typeof(AttributeMatchState&)}, ReturnType = typeof(SchemaAttDef))]
		[CalledBy(Type = typeof(Compiler), Member = "IsProcessContentsRestricted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaAnyAttribute)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		internal get { } //Length: 15
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public XmlSchemaAnyAttribute() { }

	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileLocalAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaComplexType), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaDerivationMethod)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileLocalAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaComplexType), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaDerivationMethod)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CheckAtrributeGroupRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttributeGroup), typeof(XmlSchemaAttributeGroup)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal bool Allows(XmlQualifiedName qname) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection), typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NamespaceList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void BuildNamespaceList(string targetNamespace) { }

	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "PreprocessAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection), typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NamespaceListV1Compat), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void BuildNamespaceListV1Compat(string targetNamespace) { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	internal NamespaceList get_NamespaceList() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public XmlSchemaContentProcessing get_ProcessContents() { }

	[CalledBy(Type = typeof(SchemaInfo), Member = "GetAttributeXsd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl), typeof(XmlQualifiedName), typeof(XmlSchemaObject), typeof(AttributeMatchState&)}, ReturnType = typeof(SchemaAttDef))]
	[CalledBy(Type = typeof(Compiler), Member = "IsProcessContentsRestricted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaAnyAttribute)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	internal XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileAttributeGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttributeGroup)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileLocalAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaComplexType), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaDerivationMethod)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileAnyAttributeIntersection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaAnyAttribute)}, ReturnType = typeof(XmlSchemaAnyAttribute))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileAttributeGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttributeGroup)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileLocalAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaComplexType), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaDerivationMethod)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileAnyAttributeIntersection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaAnyAttribute)}, ReturnType = typeof(XmlSchemaAnyAttribute))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(NamespaceList), Member = "Intersection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamespaceList), typeof(NamespaceList), typeof(bool)}, ReturnType = typeof(NamespaceList))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal static XmlSchemaAnyAttribute Intersection(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileLocalAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaComplexType), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaDerivationMethod)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileLocalAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaComplexType), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaDerivationMethod)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CheckAtrributeGroupRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttributeGroup), typeof(XmlSchemaAttributeGroup)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NamespaceList), Member = "IsSubset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamespaceList), typeof(NamespaceList)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal static bool IsSubset(XmlSchemaAnyAttribute sub, XmlSchemaAnyAttribute super) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Namespace(string value) { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public void set_ProcessContents(XmlSchemaContentProcessing value) { }

	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileLocalAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaComplexType), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaDerivationMethod)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileAnyAttributeUnion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaAnyAttribute)}, ReturnType = typeof(XmlSchemaAnyAttribute))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileLocalAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaComplexType), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaDerivationMethod)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileAnyAttributeUnion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaAnyAttribute)}, ReturnType = typeof(XmlSchemaAnyAttribute))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NamespaceList), Member = "Union", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamespaceList), typeof(NamespaceList), typeof(bool)}, ReturnType = typeof(NamespaceList))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal static XmlSchemaAnyAttribute Union(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

}

