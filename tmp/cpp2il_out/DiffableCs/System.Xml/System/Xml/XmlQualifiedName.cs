namespace System.Xml;

public class XmlQualifiedName
{
	private sealed class HashCodeOfStringDelegate : MulticastDelegate
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public HashCodeOfStringDelegate(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override int Invoke(string s, int sLen, long additionalEntropy) { }

	}

	private static HashCodeOfStringDelegate hashCodeDelegate; //Field offset: 0x0
	public static readonly XmlQualifiedName Empty; //Field offset: 0x8
	private string name; //Field offset: 0x10
	private string ns; //Field offset: 0x18
	private int hash; //Field offset: 0x20

	public bool IsEmpty
	{
		[CallerCount(Count = 105)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 52
	}

	public string Name
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string Namespace
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private static XmlQualifiedName() { }

	[CallerCount(Count = 179)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public XmlQualifiedName(string name, string ns) { }

	[CalledBy(Type = typeof(QueryOutputWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlRawWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlValidatingReaderImpl), typeof(XmlSchemaCollection), typeof(IValidationEventHandling)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "Init", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public XmlQualifiedName() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(int)}, ReturnType = "System.Xml.XmlTextReaderImpl+EntityType")]
	[CalledBy(Type = typeof(DtdParser), Member = "InitializeFreeFloatingDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(IDtdParserAdapter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "GetNameQualified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlQualifiedName))]
	[CalledBy(Type = typeof(BaseValidator), Member = "ProcessEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaInfo), typeof(string), typeof(object), typeof(ValidationEventHandler), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseValidator), Member = "ProcessEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaInfo), typeof(string), typeof(IValidationEventHandling), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaInfo), Member = "System.Xml.IDtdInfo.LookupEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IDtdEntityInfo))]
	[CalledBy(Type = typeof(SchemaNames), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "ProcessAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataTable", Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 69)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public XmlQualifiedName(string name) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "ValidateQNameAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject), typeof(string), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "ValidateQNameAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject), typeof(string), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "ProcessAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal void Atomize(XmlNameTable nameTable) { }

	[CalledBy(Type = typeof(XmlSchemaAttribute), Member = "Clone", ReturnType = typeof(XmlSchemaObject))]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchemaObject))]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CloneAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection)}, ReturnType = typeof(XmlSchemaObjectCollection))]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CloneParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), typeof(XmlSchema)}, ReturnType = typeof(XmlSchemaParticle))]
	[CalledBy(Type = typeof(XmlSchemaElement), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchemaObject))]
	[CalledBy(Type = typeof(XmlSchemaSimpleTypeList), Member = "Clone", ReturnType = typeof(XmlSchemaObject))]
	[CalledBy(Type = typeof(XmlSchemaSimpleTypeRestriction), Member = "Clone", ReturnType = typeof(XmlSchemaObject))]
	[CalledBy(Type = typeof(XmlSchemaSimpleTypeUnion), Member = "Clone", ReturnType = typeof(XmlSchemaObject))]
	[CallerCount(Count = 16)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal XmlQualifiedName Clone() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public virtual bool Equals(object other) { }

	[CallerCount(Count = 105)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_IsEmpty() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public string get_Name() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public string get_Namespace() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "GetHashCodeDelegate", ReturnType = typeof(HashCodeOfStringDelegate))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(XmlQualifiedName), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Delegate), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(Delegate))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private static HashCodeOfStringDelegate GetHashCodeDelegate() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private static int GetHashCodeOfString(string s, int length, long additionalEntropy) { }

	[CalledBy(Type = typeof(QueryOutputWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdValidator), Member = "ValidateElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ValidateElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaInfo), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "Validate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateElement", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	internal void Init(string name, string ns) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private static bool IsRandomizedHashingDisabled() { }

	[CallerCount(Count = 86)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static bool op_Equality(XmlQualifiedName a, XmlQualifiedName b) { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadClassInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "HandleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = "System.Data.DataTable")]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "HandleElementColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), "System.Data.DataTable", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.SimpleType", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "FindElementRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection), typeof(string), typeof(string)}, ReturnType = typeof(XmlSchemaElement))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "FindElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection), typeof(string)}, ReturnType = typeof(XmlSchemaElement))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "FindMatchingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(XmlReader), typeof(XmlSchemaComplexType), typeof(Int32&), typeof(Boolean&), typeof(XmlSchema), typeof(bool)}, ReturnType = typeof(XmlSchemaElement))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "GetEffectiveSchemaType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool)}, ReturnType = typeof(XmlSchemaType))]
	[CalledBy(Type = typeof(SymbolsDictionary), Member = "GetNamespaceListSymbols", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamespaceList)}, ReturnType = typeof(ICollection))]
	[CalledBy(Type = typeof(ClassMap), Member = "get_HasSimpleContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSerializableMapping), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlRootAttribute), typeof(string), typeof(string), typeof(TypeData), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTypeMapping), Member = "UpdateRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteNullableQualifiedNameLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteNullableQualifiedNameEncoded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteElementString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteElementQualifiedName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "InferElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static bool op_Inequality(XmlQualifiedName a, XmlQualifiedName b) { }

	[CalledBy(Type = typeof(Datatype_QName), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(Datatype_NOTATION), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(Datatype_QNameXdr), Member = "ParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "ProcessAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlQualifiedName))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ValidateNames), Member = "ParseQNameThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	internal static XmlQualifiedName Parse(string s, IXmlNamespaceResolver nsmgr, out string prefix) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void SetNamespace(string ns) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

	[CalledBy(Type = typeof(XdrBuilder), Member = "ProcessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "ProcessAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_EndRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_BuildElementType_Name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_BuildAttributeType_Name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_BuildAttributeType_DtType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_BeginAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "CheckDatatype", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlSchemaDatatype))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	public static string ToString(string name, string ns) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "ValidateQNameAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject), typeof(string), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "ValidateQNameAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject), typeof(string), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlConvert), Member = "VerifyNCName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "ToUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Uri))]
	[CallsUnknownMethods(Count = 1)]
	internal void Verify() { }

}

