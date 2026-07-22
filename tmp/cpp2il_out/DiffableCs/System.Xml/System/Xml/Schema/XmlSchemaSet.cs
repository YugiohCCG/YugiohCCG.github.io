namespace System.Xml.Schema;

public class XmlSchemaSet
{
	private XmlNameTable nameTable; //Field offset: 0x10
	private SchemaNames schemaNames; //Field offset: 0x18
	private SortedList schemas; //Field offset: 0x20
	private ValidationEventHandler internalEventHandler; //Field offset: 0x28
	private ValidationEventHandler eventHandler; //Field offset: 0x30
	private bool isCompiled; //Field offset: 0x38
	private Hashtable schemaLocations; //Field offset: 0x40
	private Hashtable chameleonSchemas; //Field offset: 0x48
	private Hashtable targetNamespaces; //Field offset: 0x50
	private bool compileAll; //Field offset: 0x58
	private SchemaInfo cachedCompiledInfo; //Field offset: 0x60
	private XmlReaderSettings readerSettings; //Field offset: 0x68
	private XmlSchema schemaForSchema; //Field offset: 0x70
	private XmlSchemaCompilationSettings compilationSettings; //Field offset: 0x78
	internal XmlSchemaObjectTable elements; //Field offset: 0x80
	internal XmlSchemaObjectTable attributes; //Field offset: 0x88
	internal XmlSchemaObjectTable schemaTypes; //Field offset: 0x90
	internal XmlSchemaObjectTable substitutionGroups; //Field offset: 0x98
	private XmlSchemaObjectTable typeExtensions; //Field offset: 0xA0
	private object internalSyncObject; //Field offset: 0xA8

	public event ValidationEventHandler ValidationEventHandler
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 7)]
		 add { } //Length: 306
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 4)]
		 remove { } //Length: 184
	}

	public XmlSchemaCompilationSettings CompilationSettings
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	internal SchemaInfo CompiledInfo
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	public int Count
	{
		[CalledBy(Type = typeof(XmlSerializableMapping), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlRootAttribute), typeof(string), typeof(string), typeof(TypeData), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 39
	}

	public XmlSchemaObjectTable GlobalAttributes
	{
		[CalledBy(Type = typeof(XmlSchemaSet), Member = "Compile", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = "ClearTables", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = "CopyFromCompiledSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(XmlSchemaObjectTable), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 117
	}

	public XmlSchemaObjectTable GlobalElements
	{
		[CalledBy(Type = typeof(XmlSchemaInference), Member = "InferSchema1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlSchemaSet)}, ReturnType = typeof(XmlSchemaSet))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = "Compile", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = "ClearTables", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = "CopyFromCompiledSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(XmlSchemaObjectTable), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 117
	}

	public XmlSchemaObjectTable GlobalTypes
	{
		[CalledBy(Type = typeof(XmlSchemaInference), Member = "InferElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaInference), Member = "GetEffectiveSchemaType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool)}, ReturnType = typeof(XmlSchemaType))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = "Compile", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = "ClearTables", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = "CopyFromCompiledSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(XmlSchemaObjectTable), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 117
	}

	internal object InternalSyncObject
	{
		[CalledBy(Type = typeof(XmlSchema), Member = "set_IsRedefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchema))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = "RemoveRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = "Compile", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = "Reprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchema))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(bool)}, ReturnType = typeof(XmlSchema))]
		[CallerCount(Count = 8)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 113
	}

	public bool IsCompiled
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	internal XmlReaderSettings ReaderSettings
	{
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal Hashtable SchemaLocations
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal SortedList SortedSchemas
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal XmlSchemaObjectTable SubstitutionGroups
	{
		[CalledBy(Type = typeof(ContentValidator), Member = "AddParticleToExpected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), typeof(XmlSchemaSet), typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = "Compile", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = "ClearTables", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = "CopyFromCompiledSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(XmlSchemaObjectTable), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 117
	}

	internal XmlSchemaObjectTable TypeExtensions
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlSchemaObjectTable), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 117
	}

	public XmlResolver XmlResolver
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_XmlResolver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 30
	}

	[CalledBy(Type = typeof(XmlReaderSettings), Member = "get_Schemas", ReturnType = typeof(XmlSchemaSet))]
	[CalledBy(Type = typeof(XmlSerializableMapping), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlRootAttribute), typeof(string), typeof(string), typeof(TypeData), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataSet", Member = "ReadXSDSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataTable", Member = "ReadXSDSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NameTable), Member = ".ctor", ReturnType = typeof(void))]
	[ContainsInvalidInstructions]
	public XmlSchemaSet() { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "InferSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(XmlSchemaSet))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(XmlSchemaSet), typeof(IXmlNamespaceResolver), typeof(XmlSchemaValidationFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "CheckIsXmlAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(SchemaAttDef))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "AddXmlNamespaceSchema", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SortedList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_XmlResolver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_NameTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_DtdProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DtdProcessing)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaInfo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	public XmlSchemaSet(XmlNameTable nameTable) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaSet), Member = "PreprocessSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema&), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "AddSchemaToSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	private XmlSchema Add(string targetNamespace, XmlSchema schema) { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(XmlSchema), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaObjectTable)}, ReturnType = typeof(XmlSchemaAttribute))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "CreateXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "AddElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlSchema), typeof(XmlSchemaObjectCollection), typeof(int)}, ReturnType = typeof(XmlSchemaElement))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "AddSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "CheckIsXmlAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(SchemaAttDef))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "AddXmlNamespaceSchema", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataSet", Member = "ReadXSDSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataTable", Member = "ReadXSDSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(XmlSchemaSet), Member = "get_InternalSyncObject", ReturnType = typeof(object))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchema), Member = "get_SchemaId", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "PreprocessSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema&), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "AddSchemaToSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public XmlSchema Add(XmlSchema schema) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(XmlSchemaSet), typeof(IXmlNamespaceResolver), typeof(XmlSchemaValidationFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "CheckIsXmlAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(SchemaAttDef))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "AddXmlNamespaceSchema", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Monitor), Member = "TryEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchema), Member = "get_SchemaId", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "FindSchemaByNSAndUrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(DictionaryEntry[])}, ReturnType = typeof(XmlSchema))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "PreprocessSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema&), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "AddSchemaToSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "CopyFromCompiledSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "get_InternalSyncObject", ReturnType = typeof(object))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 45)]
	public void Add(XmlSchemaSet schemas) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UriKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "IsSchemaLoaded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(XmlSchema&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "ParseSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlReader)}, ReturnType = typeof(XmlSchema))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "PreprocessSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema&), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "AddSchemaToSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchema), Member = "get_ImportedSchemas", ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "FindSchemaByNSAndUrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(DictionaryEntry[])}, ReturnType = typeof(XmlSchema))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "RemoveRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 16)]
	internal void Add(string targetNamespace, XmlReader reader, Hashtable validatedNamespaces) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 7)]
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchema)}, ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlReader), typeof(Hashtable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlSchema), Member = "get_SchemaId", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSchema), Member = "get_SchemaTypes", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaObject))]
	[Calls(Type = typeof(XmlSchema), Member = "get_ImportedSchemas", ReturnType = typeof(ArrayList))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 7)]
	private void AddSchemaToSet(XmlSchema schema) { }

	[CalledBy(Type = typeof(XmlSchemaSet), Member = "ProcessNewSubstitutionGroups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectTable), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "CopyFromCompiledSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaObject))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "GetBuildInSchema", ReturnType = typeof(XmlSchema))]
	[Calls(Type = typeof(XmlSchema), Member = "get_Attributes", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "FindIndexByValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private bool AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaSet), Member = "get_GlobalElements", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "get_GlobalAttributes", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "get_GlobalTypes", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "get_SubstitutionGroups", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void ClearTables() { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "InferSchema1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlSchemaSet)}, ReturnType = typeof(XmlSchemaSet))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "CheckIsXmlAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(SchemaAttDef))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "AddXmlNamespaceSchema", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "RecompileSchemaSet", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataSet", Member = "ReadXSDSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataSet", Member = "InferSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), "System.String[]", "System.Data.XmlReadMode"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataTable", Member = "ReadXSDSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(SchemaInfo), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaInfo), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "get_GlobalElements", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "get_GlobalTypes", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "get_SubstitutionGroups", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(Compiler), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet), typeof(SchemaInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "get_GlobalAttributes", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Compiler), Member = "Prepare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Preprocessor), Member = "GetBuildInSchema", ReturnType = typeof(XmlSchema))]
	[Calls(Type = typeof(Compiler), Member = "ImportAllCompiledSchemas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaInfo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Compiler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(ValidationEventHandler), typeof(XmlSchema), typeof(XmlSchemaCompilationSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "get_InternalSyncObject", ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 18)]
	public void Compile() { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(XmlSchema), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaObjectTable)}, ReturnType = typeof(XmlSchemaAttribute))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "AddElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlSchema), typeof(XmlSchemaObjectCollection), typeof(int)}, ReturnType = typeof(XmlSchemaElement))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool Contains(string targetNamespace) { }

	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SchemaInfo), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaInfo), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "ProcessNewSubstitutionGroups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectTable), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "get_SubstitutionGroups", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "get_GlobalTypes", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "get_GlobalAttributes", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "get_GlobalElements", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(bool)}, ReturnType = typeof(XmlSchema))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "AddToTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectTable), typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "get_Values", ReturnType = typeof(ICollection))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "VerifyTables", ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchema), Member = "get_SchemaId", ReturnType = typeof(int))]
	[Calls(Type = typeof(SchemaInfo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallsUnknownMethods(Count = 95)]
	internal void CopyFromCompiledSet(XmlSchemaSet otherSet) { }

	[CalledBy(Type = typeof(XmlSerializableMapping), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlRootAttribute), typeof(string), typeof(string), typeof(TypeData), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public void CopyTo(XmlSchema[] schemas, int index) { }

	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlReader), typeof(Hashtable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "IsSchemaLoaded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(XmlSchema&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "AddSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[Calls(Type = typeof(ChameleonKey), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	internal XmlSchema FindSchemaByNSAndUrl(Uri schemaUri, string ns, DictionaryEntry[] locationsTable) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public XmlSchemaCompilationSettings get_CompilationSettings() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	internal SchemaInfo get_CompiledInfo() { }

	[CalledBy(Type = typeof(XmlSerializableMapping), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlRootAttribute), typeof(string), typeof(string), typeof(TypeData), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int get_Count() { }

	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Compile", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "ClearTables", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "CopyFromCompiledSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public XmlSchemaObjectTable get_GlobalAttributes() { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "InferSchema1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlSchemaSet)}, ReturnType = typeof(XmlSchemaSet))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Compile", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "ClearTables", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "CopyFromCompiledSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public XmlSchemaObjectTable get_GlobalElements() { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "InferElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "GetEffectiveSchemaType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool)}, ReturnType = typeof(XmlSchemaType))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Compile", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "ClearTables", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "CopyFromCompiledSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public XmlSchemaObjectTable get_GlobalTypes() { }

	[CalledBy(Type = typeof(XmlSchema), Member = "set_IsRedefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "RemoveRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Compile", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Reprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(bool)}, ReturnType = typeof(XmlSchema))]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal object get_InternalSyncObject() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_IsCompiled() { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	internal XmlReaderSettings get_ReaderSettings() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal Hashtable get_SchemaLocations() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal SortedList get_SortedSchemas() { }

	[CalledBy(Type = typeof(ContentValidator), Member = "AddParticleToExpected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), typeof(XmlSchemaSet), typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Compile", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "ClearTables", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "CopyFromCompiledSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal XmlSchemaObjectTable get_SubstitutionGroups() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal XmlSchemaObjectTable get_TypeExtensions() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	internal ValidationEventHandler GetEventHandler() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlReaderSettings), Member = "GetXmlResolver_CheckConfig", ReturnType = typeof(XmlResolver))]
	[CallsUnknownMethods(Count = 1)]
	internal XmlResolver GetResolver() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	internal bool GetSchemaByUri(Uri schemaUri, out XmlSchema schema) { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "ProcessElementEvent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "PreprocessSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema&), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "ParseSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlReader)}, ReturnType = typeof(XmlSchema))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SchemaNames), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal SchemaNames GetSchemaNames(XmlNameTable nt) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal string GetTargetNamespace(XmlSchema schema) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void InternalValidationCallback(object sender, ValidationEventArgs e) { }

	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlReader), typeof(Hashtable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchema), Member = "get_SchemaId", ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchema), Member = "get_SchemaTypes", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaObject))]
	[Calls(Type = typeof(XmlSchema), Member = "get_ImportedSchemas", ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "FindSchemaByNSAndUrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(DictionaryEntry[])}, ReturnType = typeof(XmlSchema))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "PreprocessSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema&), typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 26)]
	[CallsUnknownMethods(Count = 28)]
	internal bool IsSchemaLoaded(Uri schemaUri, string targetNamespace, out XmlSchema schema) { }

	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlReader), typeof(Hashtable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaSet), Member = "GetSchemaNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(SchemaNames))]
	[Calls(Type = typeof(Parser), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaType), typeof(XmlNameTable), typeof(SchemaNames), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "GetXmlResolver_CheckConfig", ReturnType = typeof(XmlResolver))]
	[Calls(Type = typeof(Parser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(string)}, ReturnType = typeof(SchemaType))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal XmlSchema ParseSchema(string targetNamespace, XmlReader reader) { }

	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Reprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchema)}, ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlReader), typeof(Hashtable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "IsSchemaLoaded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(XmlSchema&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XmlSchemaSet), Member = "GetSchemaNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(SchemaNames))]
	[Calls(Type = typeof(Preprocessor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(SchemaNames), typeof(ValidationEventHandler), typeof(XmlSchemaCompilationSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "GetXmlResolver_CheckConfig", ReturnType = typeof(XmlResolver))]
	[Calls(Type = typeof(Preprocessor), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 6)]
	internal bool PreprocessSchema(ref XmlSchema schema, string targetNamespace) { }

	[CalledBy(Type = typeof(XmlSchemaSet), Member = "CopyFromCompiledSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "get_Values", ReturnType = typeof(ICollection))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "ResolveSubstitutionGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSubstitutionGroup), typeof(XmlSchemaObjectTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaObject))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "AddToTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectTable), typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 19)]
	private void ProcessNewSubstitutionGroups(XmlSchemaObjectTable substitutionGroupsTable, bool resolve) { }

	[CalledBy(Type = typeof(XmlSchemaSet), Member = "RemoveRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "CopyFromCompiledSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlSchemaSet), Member = "get_InternalSyncObject", ReturnType = typeof(object))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchema), Member = "get_SchemaId", ReturnType = typeof(int))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "RemoveSchemaFromGlobalTables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "RemoveSchemaFromCaches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "Schemas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ICollection))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	internal XmlSchema Remove(XmlSchema schema, bool forceCompile) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 4)]
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlReader), typeof(Hashtable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "AddSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(bool)}, ReturnType = typeof(XmlSchema))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchema), Member = "get_ImportedSchemas", ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchema), Member = "get_ImportedNamespaces", ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "get_InternalSyncObject", ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlSchema), Member = "get_SchemaId", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 35)]
	public bool RemoveRecursive(XmlSchema schemaToRemove) { }

	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Reprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(bool)}, ReturnType = typeof(XmlSchema))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlSchema), Member = "GetExternalSchemasList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 14)]
	private void RemoveSchemaFromCaches(XmlSchema schema) { }

	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Reprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(bool)}, ReturnType = typeof(XmlSchema))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlSchemaSet), Member = "VerifyTables", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchema), Member = "get_Elements", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "get_Values", ReturnType = typeof(ICollection))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchema), Member = "get_Attributes", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(XmlSchema), Member = "get_SchemaTypes", ReturnType = typeof(XmlSchemaObjectTable))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 48)]
	private void RemoveSchemaFromGlobalTables(XmlSchema schema) { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "InferSchema1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlSchemaSet)}, ReturnType = typeof(XmlSchemaSet))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchema), Member = "get_ImportedSchemas", ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaObject))]
	[Calls(Type = typeof(XmlSchema), Member = "get_SchemaTypes", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "PreprocessSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema&), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "Schemas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ICollection))]
	[Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "RemoveSchemaFromCaches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "RemoveSchemaFromGlobalTables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "get_InternalSyncObject", ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlSchema), Member = "get_SchemaId", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 37)]
	public XmlSchema Reprocess(XmlSchema schema) { }

	[CalledBy(Type = typeof(XmlSchemaSet), Member = "ProcessNewSubstitutionGroups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectTable), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "ResolveSubstitutionGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSubstitutionGroup), typeof(XmlSchemaObjectTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaObject))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "ResolveSubstitutionGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSubstitutionGroup), typeof(XmlSchemaObjectTable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 6)]
	private void ResolveSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup, XmlSchemaObjectTable substTable) { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(XmlSchema), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaObjectTable)}, ReturnType = typeof(XmlSchemaAttribute))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "AddElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlSchema), typeof(XmlSchemaObjectCollection), typeof(int)}, ReturnType = typeof(XmlSchemaElement))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "FindGlobalElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchema&)}, ReturnType = typeof(XmlSchemaElement))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Reprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(bool)}, ReturnType = typeof(XmlSchema))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public ICollection Schemas(string targetNamespace) { }

	[CalledBy(Type = "System.Data.XSDSchema", Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet), "System.Data.DataSet"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "GetPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "GetNamespaceFromPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ICollection Schemas() { }

	[CalledBy(Type = typeof(XmlSchemaSet), Member = "RemoveRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Compile", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "ParseSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlReader)}, ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "IsSchemaLoaded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(XmlSchema&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "AddToTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectTable), typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ValidationEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_CompilationSettings(XmlSchemaCompilationSettings value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_XmlResolver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_XmlResolver(XmlResolver value) { }

	[CalledBy(Type = typeof(XmlSchemaSet), Member = "CopyFromCompiledSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "RemoveSchemaFromGlobalTables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private void VerifyTables() { }

}

