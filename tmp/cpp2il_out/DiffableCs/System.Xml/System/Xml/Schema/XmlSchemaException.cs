namespace System.Xml.Schema;

public class XmlSchemaException : SystemException
{
	private string res; //Field offset: 0x90
	private String[] args; //Field offset: 0x98
	private string sourceUri; //Field offset: 0xA0
	private int lineNumber; //Field offset: 0xA8
	private int linePosition; //Field offset: 0xAC
	private XmlSchemaObject sourceSchemaObject; //Field offset: 0xB0
	private string message; //Field offset: 0xB8

	internal String[] Args
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	internal string GetRes
	{
		[CallerCount(Count = 57)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	public int LineNumber
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public int LinePosition
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public virtual string Message
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Exception), Member = "get_Message", ReturnType = typeof(string))]
		 get { } //Length: 25
	}

	public XmlSchemaObject SourceSchemaObject
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public string SourceUri
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[CalledBy(Type = typeof(XmlSchemaInferenceException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetEnumerator", ReturnType = typeof(SerializationInfoEnumerator))]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "get_Current", ReturnType = typeof(SerializationEntry))]
	[Calls(Type = typeof(XmlSchemaException), Member = "CreateMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	protected XmlSchemaException(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 37)]
	[Calls(Type = typeof(XmlSchemaException), Member = "CreateMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal XmlSchemaException(string res, String[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition, XmlSchemaObject source) { }

	[CalledBy(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal XmlSchemaException(string res, String[] args, XmlSchemaObject source) { }

	[CalledBy(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FacetsChecker), Member = "ConstructRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatatypeImplementation), typeof(XmlSchemaObjectCollection), typeof(XmlNameTable)}, ReturnType = typeof(RestrictionFacets))]
	[CalledBy(Type = "System.Xml.Schema.FacetsChecker+FacetsCompiler", Member = "CheckDupFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet), typeof(RestrictionFlags), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.FacetsChecker+FacetsCompiler", Member = "CompileFractionDigitsFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.FacetsChecker+FacetsCompiler", Member = "CompileTotalDigitsFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.FacetsChecker+FacetsCompiler", Member = "CompileMinExclusiveFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.FacetsChecker+FacetsCompiler", Member = "CompileMaxExclusiveFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.FacetsChecker+FacetsCompiler", Member = "CompileMaxInclusiveFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.FacetsChecker+FacetsCompiler", Member = "CompileWhitespaceFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.FacetsChecker+FacetsCompiler", Member = "CompileMaxLengthFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.FacetsChecker+FacetsCompiler", Member = "CompileMinLengthFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.FacetsChecker+FacetsCompiler", Member = "CompileLengthFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_NOTATION), Member = "VerifySchemaValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectTable), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.FacetsChecker+FacetsCompiler", Member = "CompileMinInclusiveFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
	[CallerCount(Count = 39)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal XmlSchemaException(string res, XmlSchemaObject source) { }

	[CallerCount(Count = 9)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal XmlSchemaException(string res, String[] args, string sourceUri, int lineNumber, int linePosition) { }

	[CalledBy(Type = typeof(Parser), Member = "StartParsing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	internal XmlSchemaException(string res, string sourceUri, int lineNumber, int linePosition) { }

	[CallerCount(Count = 22)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal XmlSchemaException(string res, string arg, string sourceUri, int lineNumber, int linePosition) { }

	[CalledBy(Type = typeof(BaseProcessor), Member = "AddToTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectTable), typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileIdentityConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaIdentityConstraint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileBaseMemberTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType)}, ReturnType = typeof(XmlSchemaSimpleType[]))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileIdentityConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaIdentityConstraint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.FacetsChecker+FacetsCompiler", Member = "CheckProhibitedFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet), typeof(RestrictionFlags), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.FacetsChecker+FacetsCompiler", Member = "CompileFractionDigitsFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.FacetsChecker+FacetsCompiler", Member = "CompileWhitespaceFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaObject), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileBaseMemberTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType)}, ReturnType = typeof(XmlSchemaSimpleType[]))]
	[CallerCount(Count = 40)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal XmlSchemaException(string res, string arg, XmlSchemaObject source) { }

	[CalledBy(Type = typeof(XmlSchemaSet), Member = "IsSchemaLoaded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(XmlSchema&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaException), Member = "CreateMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal XmlSchemaException(string res, String[] args) { }

	[CalledBy(Type = typeof(XmlSchemaException), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public XmlSchemaException(string message, Exception innerException, int lineNumber, int linePosition) { }

	[CalledBy(Type = typeof(Datatype_doubleXdr), Member = "ParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Datatype_floatXdr), Member = "ParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Datatype_QNameXdr), Member = "ParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Datatype_char), Member = "ParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Datatype_fixed), Member = "ParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Datatype_uuid), Member = "ParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	public XmlSchemaException(string message, Exception innerException) { }

	[CalledBy(Type = typeof(XmlSchemaInferenceException), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidationException), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	public XmlSchemaException(string message) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	public XmlSchemaException() { }

	[CallerCount(Count = 79)]
	[Calls(Type = typeof(XmlSchemaException), Member = "CreateMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	internal XmlSchemaException(string res, string arg) { }

	[CalledBy(Type = typeof(XdrValidator), Member = "CompleteValidation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	internal static string CreateMessage(string res, String[] args) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal String[] get_Args() { }

	[CallerCount(Count = 57)]
	[DeduplicatedMethod]
	internal string get_GetRes() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_LineNumber() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public int get_LinePosition() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Exception), Member = "get_Message", ReturnType = typeof(string))]
	public virtual string get_Message() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public XmlSchemaObject get_SourceSchemaObject() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public string get_SourceUri() { }

	[CalledBy(Type = typeof(XmlSchemaInferenceException), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidationException), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Exception), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void SetSchemaObject(XmlSchemaObject source) { }

	[CalledBy(Type = typeof(CompiledIdentityConstraint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaIdentityConstraint), typeof(XmlNamespaceManager)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileSimpleContentRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaSimpleContentRestriction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileIdentityConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaIdentityConstraint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileSimpleContentRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaSimpleContentRestriction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileIdentityConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaIdentityConstraint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[CallsUnknownMethods(Count = 3)]
	internal void SetSource(XmlSchemaObject source) { }

	[CalledBy(Type = typeof(DtdValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdValidator), Member = "ValidateEndStartElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ValidateEndStartElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "ProcessAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildSimpleTypeUnion_MemberTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildDocumentation_XmlLang", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateStartElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateEndStartElement", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	internal void SetSource(string sourceUri, int lineNumber, int linePosition) { }

}

