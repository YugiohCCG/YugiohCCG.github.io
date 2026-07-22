namespace System.Xml.Schema;

[XmlRoot("schema", Namespace = "http://www.w3.org/2001/XMLSchema")]
public class XmlSchema : XmlSchemaObject
{
	private static int globalIdCounter; //Field offset: 0x0
	private XmlSchemaForm attributeFormDefault; //Field offset: 0x38
	private XmlSchemaForm elementFormDefault; //Field offset: 0x3C
	private XmlSchemaDerivationMethod blockDefault; //Field offset: 0x40
	private XmlSchemaDerivationMethod finalDefault; //Field offset: 0x44
	private string targetNs; //Field offset: 0x48
	private string version; //Field offset: 0x50
	private XmlSchemaObjectCollection includes; //Field offset: 0x58
	private XmlSchemaObjectCollection items; //Field offset: 0x60
	private string id; //Field offset: 0x68
	private XmlAttribute[] moreAttributes; //Field offset: 0x70
	private bool isCompiled; //Field offset: 0x78
	private bool isCompiledBySet; //Field offset: 0x79
	private bool isPreprocessed; //Field offset: 0x7A
	private bool isRedefined; //Field offset: 0x7B
	private int errorCount; //Field offset: 0x7C
	private XmlSchemaObjectTable attributes; //Field offset: 0x80
	private XmlSchemaObjectTable attributeGroups; //Field offset: 0x88
	private XmlSchemaObjectTable elements; //Field offset: 0x90
	private XmlSchemaObjectTable types; //Field offset: 0x98
	private XmlSchemaObjectTable groups; //Field offset: 0xA0
	private XmlSchemaObjectTable notations; //Field offset: 0xA8
	private XmlSchemaObjectTable identityConstraints; //Field offset: 0xB0
	private ArrayList importedSchemas; //Field offset: 0xB8
	private ArrayList importedNamespaces; //Field offset: 0xC0
	private int schemaId; //Field offset: 0xC8
	private Uri baseUri; //Field offset: 0xD0
	private bool isChameleon; //Field offset: 0xD8
	private Hashtable ids; //Field offset: 0xE0
	private XmlDocument document; //Field offset: 0xE8

	[DefaultValue(XmlSchemaForm::None (0))]
	[XmlAttribute("attributeFormDefault")]
	public XmlSchemaForm AttributeFormDefault
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[XmlIgnore]
	public XmlSchemaObjectTable AttributeGroups
	{
		[CalledBy(Type = typeof(BaseProcessor), Member = "AddToTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectTable), typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Compiler), Member = "Prepare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "PreprocessRedefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaRedefine)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), "System.Xml.Schema.SchemaCollectionPreprocessor+Compositor"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "Cleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileLocalAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaComplexType), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaDerivationMethod)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Compile", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileAttributeGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttributeGroup)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Cleanup", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessRedefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RedefineEntry)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Preprocessor), Member = "CopyIncludedComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(XmlSchema)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Preprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(ArrayList)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Preprocessor), Member = "Cleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Cleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
		[CallerCount(Count = 22)]
		[Calls(Type = typeof(XmlSchemaObjectTable), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 117
	}

	[XmlIgnore]
	public XmlSchemaObjectTable Attributes
	{
		[CalledBy(Type = typeof(BaseProcessor), Member = "AddToTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectTable), typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = "AddToTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectTable), typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = "RemoveSchemaFromGlobalTables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Compiler), Member = "Prepare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), "System.Xml.Schema.SchemaCollectionPreprocessor+Compositor"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "Cleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Output", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Cleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Cleanup", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Preprocessor), Member = "CopyIncludedComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(XmlSchema)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Preprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(ArrayList)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Preprocessor), Member = "Cleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Compile", ReturnType = typeof(void))]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(XmlSchemaObjectTable), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 117
	}

	[XmlIgnore]
	internal Uri BaseUri
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	[DefaultValue(XmlSchemaDerivationMethod::None (256))]
	[XmlAttribute("blockDefault")]
	public XmlSchemaDerivationMethod BlockDefault
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[XmlIgnore]
	internal XmlDocument Document
	{
		[CalledBy(Type = typeof(XsdBuilder), Member = "ProcessAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(XmlDocument), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 117
	}

	[DefaultValue(XmlSchemaForm::None (0))]
	[XmlAttribute("elementFormDefault")]
	public XmlSchemaForm ElementFormDefault
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[XmlIgnore]
	public XmlSchemaObjectTable Elements
	{
		[CalledBy(Type = typeof(Preprocessor), Member = "Cleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = "RemoveSchemaFromGlobalTables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Compiler), Member = "Prepare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), "System.Xml.Schema.SchemaCollectionPreprocessor+Compositor"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "Cleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CheckSubstitutionGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSubstitutionGroup)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileSubstitutionGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSubstitutionGroupV1Compat)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Compile", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Cleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Cleanup", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Prepare", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Preprocessor), Member = "CopyIncludedComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(XmlSchema)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Preprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(ArrayList)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Output", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaInfo)}, ReturnType = typeof(void))]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(XmlSchemaObjectTable), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 117
	}

	[XmlIgnore]
	internal int ErrorCount
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	[DefaultValue(XmlSchemaDerivationMethod::None (256))]
	[XmlAttribute("finalDefault")]
	public XmlSchemaDerivationMethod FinalDefault
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[XmlIgnore]
	public XmlSchemaObjectTable Groups
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[XmlAttribute("id", DataType = "ID")]
	public string Id
	{
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[XmlIgnore]
	internal virtual string IdAttribute
	{
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	[XmlIgnore]
	internal XmlSchemaObjectTable IdentityConstraints
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	[XmlIgnore]
	internal Hashtable Ids
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	internal ArrayList ImportedNamespaces
	{
		[CalledBy(Type = typeof(Preprocessor), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Preprocessor), Member = "LoadExternals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Preprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(ArrayList)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = "RemoveRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 117
	}

	internal ArrayList ImportedSchemas
	{
		[CalledBy(Type = typeof(Preprocessor), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = "RemoveRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = "Reprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchema))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlReader), typeof(Hashtable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = "AddSchemaToSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = "IsSchemaLoaded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(XmlSchema&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlSchemaValidator), Member = "AddSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 117
	}

	[XmlElement("import", typeof(XmlSchemaImport))]
	[XmlElement("include", typeof(XmlSchemaInclude))]
	[XmlElement("redefine", typeof(XmlSchemaRedefine))]
	public XmlSchemaObjectCollection Includes
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[XmlIgnore]
	internal bool IsChameleon
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	[XmlIgnore]
	internal bool IsCompiledBySet
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	[XmlIgnore]
	internal bool IsPreprocessed
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	[XmlIgnore]
	internal bool IsRedefined
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Preprocessor), Member = "GetBuildInSchema", ReturnType = typeof(XmlSchema))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlSchemaSet), Member = "get_InternalSyncObject", ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		internal set { } //Length: 495
	}

	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroup))]
	[XmlElement("annotation", typeof(XmlSchemaAnnotation))]
	[XmlElement("notation", typeof(XmlSchemaNotation))]
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	[XmlElement("group", typeof(XmlSchemaGroup))]
	[XmlElement("element", typeof(XmlSchemaElement))]
	[XmlElement("complexType", typeof(XmlSchemaComplexType))]
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaObjectCollection Items
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[XmlIgnore]
	public XmlSchemaObjectTable Notations
	{
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[XmlIgnore]
	internal int SchemaId
	{
		[CalledBy(Type = typeof(Preprocessor), Member = "BuildSchemaList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchema))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = "RemoveRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = "Reprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchema))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = "AddSchemaToSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(bool)}, ReturnType = typeof(XmlSchema))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = "CopyFromCompiledSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = "IsSchemaLoaded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(XmlSchema&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 25)]
		[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
		internal get { } //Length: 106
	}

	[XmlIgnore]
	public XmlSchemaObjectTable SchemaTypes
	{
		[CallerCount(Count = 43)]
		[Calls(Type = typeof(XmlSchemaObjectTable), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 117
	}

	[XmlAttribute("targetNamespace", DataType = "anyURI")]
	public string TargetNamespace
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 254
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[XmlAttribute("version", DataType = "token")]
	public string Version
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CallerCount(Count = 0)]
	private static XmlSchema() { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(XmlSchema), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaObjectTable)}, ReturnType = typeof(XmlSchemaAttribute))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "CreateXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "AddElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlSchema), typeof(XmlSchemaObjectCollection), typeof(int)}, ReturnType = typeof(XmlSchemaElement))]
	[CalledBy(Type = typeof(Parser), Member = "StartParsing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "GetBuildInSchema", ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = typeof(XmlSchema), Member = "Clone", ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = typeof(XmlSchema), Member = "DeepClone", ReturnType = typeof(XmlSchema))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public XmlSchema() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal virtual void AddAnnotation(XmlSchemaAnnotation annotation) { }

	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "LoadExternals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(XmlSchemaCollection)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchema), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaCollectionCompiler), Member = "Cleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	internal XmlSchema Clone() { }

	[CalledBy(Type = typeof(XmlSchemaCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SchemaInfo), typeof(XmlSchema), typeof(bool)}, ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = typeof(XmlSchemaCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SchemaInfo), typeof(XmlSchema), typeof(bool), typeof(XmlResolver)}, ReturnType = typeof(XmlSchema))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaCollectionPreprocessor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(SchemaNames), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaCollectionPreprocessor), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(bool), typeof(XmlSchemaCollection)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SchemaCollectionCompiler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaCollectionCompiler), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(SchemaInfo), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal bool CompileSchema(XmlSchemaCollection xsc, XmlResolver resolver, SchemaInfo schemaInfo, string ns, ValidationEventHandler validationEventHandler, XmlNameTable nameTable, bool CompileContentModel) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "GetBuildInSchema", ReturnType = typeof(XmlSchema))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Compiler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(ValidationEventHandler), typeof(XmlSchema), typeof(XmlSchemaCompilationSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Compiler), Member = "Prepare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Compiler), Member = "Compile", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal void CompileSchemaInSet(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "GetChameleonSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchema)}, ReturnType = typeof(XmlSchema))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchema), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchemaObject))]
	[Calls(Type = typeof(XmlSchemaElement), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchemaObject))]
	[Calls(Type = typeof(XmlSchemaGroup), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchemaObject))]
	[Calls(Type = typeof(XmlSchemaObjectCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 8)]
	internal XmlSchema DeepClone() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public XmlSchemaForm get_AttributeFormDefault() { }

	[CalledBy(Type = typeof(BaseProcessor), Member = "AddToTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectTable), typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Cleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "Cleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "CopyIncludedComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessRedefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RedefineEntry)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileAttributeGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttributeGroup)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Cleanup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileLocalAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaComplexType), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaDerivationMethod)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "Cleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), "System.Xml.Schema.SchemaCollectionPreprocessor+Compositor"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "PreprocessRedefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaRedefine)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "Prepare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Compile", ReturnType = typeof(void))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public XmlSchemaObjectTable get_AttributeGroups() { }

	[CalledBy(Type = typeof(BaseProcessor), Member = "AddToTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectTable), typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Compile", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "Cleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "CopyIncludedComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Cleanup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Cleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "Cleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), "System.Xml.Schema.SchemaCollectionPreprocessor+Compositor"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "Prepare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "RemoveSchemaFromGlobalTables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "AddToTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectTable), typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Output", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public XmlSchemaObjectTable get_Attributes() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal Uri get_BaseUri() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public XmlSchemaDerivationMethod get_BlockDefault() { }

	[CalledBy(Type = typeof(XsdBuilder), Member = "ProcessAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlDocument), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal XmlDocument get_Document() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public XmlSchemaForm get_ElementFormDefault() { }

	[CalledBy(Type = typeof(Preprocessor), Member = "Cleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Output", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "CopyIncludedComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Prepare", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Cleanup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Cleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Compile", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CheckSubstitutionGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSubstitutionGroup)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "Cleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), "System.Xml.Schema.SchemaCollectionPreprocessor+Compositor"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "Prepare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "RemoveSchemaFromGlobalTables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileSubstitutionGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSubstitutionGroupV1Compat)}, ReturnType = typeof(void))]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public XmlSchemaObjectTable get_Elements() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal int get_ErrorCount() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public XmlSchemaDerivationMethod get_FinalDefault() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public XmlSchemaObjectTable get_Groups() { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	public string get_Id() { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	internal virtual string get_IdAttribute() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	internal XmlSchemaObjectTable get_IdentityConstraints() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal Hashtable get_Ids() { }

	[CalledBy(Type = typeof(Preprocessor), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Preprocessor), Member = "LoadExternals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "RemoveRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal ArrayList get_ImportedNamespaces() { }

	[CalledBy(Type = typeof(Preprocessor), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "RemoveRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Reprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlReader), typeof(Hashtable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "AddSchemaToSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "IsSchemaLoaded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(XmlSchema&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "AddSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal ArrayList get_ImportedSchemas() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public XmlSchemaObjectCollection get_Includes() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_IsChameleon() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_IsCompiledBySet() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_IsPreprocessed() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_IsRedefined() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	public XmlSchemaObjectCollection get_Items() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public XmlSchemaObjectTable get_Notations() { }

	[CalledBy(Type = typeof(Preprocessor), Member = "BuildSchemaList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "RemoveRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Reprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "AddSchemaToSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(bool)}, ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "CopyFromCompiledSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "IsSchemaLoaded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(XmlSchema&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	internal int get_SchemaId() { }

	[CallerCount(Count = 43)]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public XmlSchemaObjectTable get_SchemaTypes() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public string get_TargetNamespace() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public string get_Version() { }

	[CalledBy(Type = typeof(XmlSchema), Member = "GetExternalSchemasList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "RemoveSchemaFromCaches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlSchema), Member = "GetExternalSchemasList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	internal void GetExternalSchemasList(IList extList, XmlSchema schema) { }

	[CalledBy(Type = "System.Data.DataSet", Member = "ReadXSDSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataSet", Member = "System.Xml.Serialization.IXmlSerializable.GetSchema", ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = "System.Data.DataTable", Member = "ReadXSDSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataTable", Member = "GetSchema", ReturnType = typeof(XmlSchema))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SchemaNames), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Parser), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaType), typeof(XmlNameTable), typeof(SchemaNames), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Parser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(string)}, ReturnType = typeof(SchemaType))]
	[Calls(Type = typeof(ValidationEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public static XmlSchema Read(XmlReader reader, ValidationEventHandler validationEventHandler) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_AttributeFormDefault(XmlSchemaForm value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_BaseUri(Uri value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_BlockDefault(XmlSchemaDerivationMethod value) { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public void set_ElementFormDefault(XmlSchemaForm value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_ErrorCount(int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_FinalDefault(XmlSchemaDerivationMethod value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Id(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual void set_IdAttribute(string value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_IsChameleon(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_IsCompiledBySet(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_IsPreprocessed(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Preprocessor), Member = "GetBuildInSchema", ReturnType = typeof(XmlSchema))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "get_InternalSyncObject", ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal void set_IsRedefined(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_TargetNamespace(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Version(string value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void SetIsCompiled(bool isCompiled) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

}

