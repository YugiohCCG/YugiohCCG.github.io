namespace System.Xml.Schema;

public class XmlSchemaAttributeGroup : XmlSchemaAnnotated
{
	private string name; //Field offset: 0x50
	private XmlSchemaObjectCollection attributes; //Field offset: 0x58
	private XmlSchemaAnyAttribute anyAttribute; //Field offset: 0x60
	private XmlQualifiedName qname; //Field offset: 0x68
	private XmlSchemaAttributeGroup redefined; //Field offset: 0x70
	private XmlSchemaObjectTable attributeUses; //Field offset: 0x78
	private XmlSchemaAnyAttribute attributeWildcard; //Field offset: 0x80
	private int selfReferenceCount; //Field offset: 0x88

	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	public XmlSchemaObjectCollection Attributes
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[XmlIgnore]
	internal XmlSchemaObjectTable AttributeUses
	{
		[CalledBy(Type = typeof(BaseProcessor), Member = "AddToTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectTable), typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseProcessor), Member = "IsValidAttributeGroupRedefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject), typeof(XmlSchemaObject), typeof(XmlSchemaObjectTable)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Cleanup", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Cleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CleanupAttributeGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttributeGroup)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileAttributeGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttributeGroup)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileLocalAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaComplexType), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaDerivationMethod)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Compiler), Member = "CleanupAttributeGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttributeGroup)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Compiler), Member = "CompileAttributeGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttributeGroup)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Compiler), Member = "CompileLocalAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaComplexType), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaDerivationMethod)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Compiler), Member = "CheckAtrributeGroupRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttributeGroup), typeof(XmlSchemaAttributeGroup)}, ReturnType = typeof(void))]
		[CallerCount(Count = 25)]
		[Calls(Type = typeof(XmlSchemaObjectTable), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 105
	}

	[XmlIgnore]
	internal XmlSchemaAnyAttribute AttributeWildcard
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 16
	}

	[XmlAttribute("name")]
	public string Name
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[XmlIgnore]
	internal virtual string NameAttribute
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	[XmlIgnore]
	public XmlQualifiedName QualifiedName
	{
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[XmlIgnore]
	internal XmlSchemaAttributeGroup Redefined
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	[XmlIgnore]
	public XmlSchemaAttributeGroup RedefinedAttributeGroup
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[XmlIgnore]
	internal int SelfReferenceCount
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 7
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	[CalledBy(Type = typeof(Preprocessor), Member = "GetBuildInSchema", ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "InitAttributeGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public XmlSchemaAttributeGroup() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = "HasAttributeQNameRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = "CloneAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection)}, ReturnType = typeof(XmlSchemaObjectCollection))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal virtual XmlSchemaObject Clone() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public XmlSchemaObjectCollection get_Attributes() { }

	[CalledBy(Type = typeof(BaseProcessor), Member = "AddToTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectTable), typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseProcessor), Member = "IsValidAttributeGroupRedefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject), typeof(XmlSchemaObject), typeof(XmlSchemaObjectTable)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Cleanup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Cleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CleanupAttributeGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttributeGroup)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileAttributeGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttributeGroup)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileLocalAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaComplexType), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaDerivationMethod)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CleanupAttributeGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttributeGroup)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileAttributeGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttributeGroup)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileLocalAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaComplexType), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaDerivationMethod)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CheckAtrributeGroupRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttributeGroup), typeof(XmlSchemaAttributeGroup)}, ReturnType = typeof(void))]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal XmlSchemaObjectTable get_AttributeUses() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal XmlSchemaAnyAttribute get_AttributeWildcard() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public string get_Name() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	internal virtual string get_NameAttribute() { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	public XmlQualifiedName get_QualifiedName() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	internal XmlSchemaAttributeGroup get_Redefined() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public XmlSchemaAttributeGroup get_RedefinedAttributeGroup() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal int get_SelfReferenceCount() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_AttributeWildcard(XmlSchemaAnyAttribute value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Name(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual void set_NameAttribute(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_Redefined(XmlSchemaAttributeGroup value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_SelfReferenceCount(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void SetQualifiedName(XmlQualifiedName value) { }

}

