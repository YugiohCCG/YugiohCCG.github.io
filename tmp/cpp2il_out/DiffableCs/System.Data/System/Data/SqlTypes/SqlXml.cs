namespace System.Data.SqlTypes;

[XmlSchemaProvider("GetXsdType")]
public sealed class SqlXml : INullable, IXmlSerializable
{
	private static readonly Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> s_sqlReaderDelegate; //Field offset: 0x0
	private static readonly XmlReaderSettings s_defaultXmlReaderSettings; //Field offset: 0x8
	private static readonly XmlReaderSettings s_defaultXmlReaderSettingsCloseInput; //Field offset: 0x10
	private static MethodInfo s_createSqlReaderMethodInfo; //Field offset: 0x18
	private MethodInfo _createSqlReaderMethodInfo; //Field offset: 0x10
	private bool _fNotNull; //Field offset: 0x18
	private Stream _stream; //Field offset: 0x20
	private bool _firstCreateReader; //Field offset: 0x28

	private static MethodInfo CreateSqlReaderMethodInfo
	{
		[CalledBy(Type = typeof(SqlXml), Member = "CreateReader", ReturnType = typeof(XmlReader))]
		[CalledBy(Type = typeof(SqlXml), Member = "CreateSqlReaderDelegate", ReturnType = typeof(System.Func`4<System.IO.Stream, System.Xml.XmlReaderSettings, System.Xml.XmlParserContext, System.Xml.XmlReader>))]
		[CalledBy(Type = typeof(SqlXml), Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
		[Calls(Type = typeof(Decimal), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(Decimal&))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 463
	}

	public override bool IsNull
	{
		[CallerCount(Count = 7)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlXml), Member = "get_CreateSqlReaderMethodInfo", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlReaderSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_ConformanceLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConformanceLevel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_CloseInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private static SqlXml() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public SqlXml() { }

	[CalledBy(Type = typeof(SqlXml), Member = "System.Xml.Serialization.IXmlSerializable.WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SqlXml), Member = "get_CreateSqlReaderMethodInfo", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(SqlXml), Member = "CreateSqlXmlReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(bool)}, ReturnType = typeof(XmlReader))]
	[Calls(Type = typeof(SqlNullValueException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public XmlReader CreateReader() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlXml), Member = "get_CreateSqlReaderMethodInfo", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> CreateSqlReaderDelegate() { }

	[CalledBy(Type = typeof(SqlXml), Member = "CreateReader", ReturnType = typeof(XmlReader))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ADP), Member = "IsCatchableExceptionType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TargetInvocationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	internal static XmlReader CreateSqlXmlReader(Stream stream, bool closeInput = false, bool throwTargetInvocationExceptions = false) { }

	[CalledBy(Type = typeof(SqlXml), Member = "CreateReader", ReturnType = typeof(XmlReader))]
	[CalledBy(Type = typeof(SqlXml), Member = "CreateSqlReaderDelegate", ReturnType = typeof(System.Func`4<System.IO.Stream, System.Xml.XmlReaderSettings, System.Xml.XmlParserContext, System.Xml.XmlReader>))]
	[CalledBy(Type = typeof(SqlXml), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Decimal), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(Decimal&))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static MethodInfo get_CreateSqlReaderMethodInfo() { }

	[CallerCount(Count = 7)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool get_IsNull() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void SetNull() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 3)]
	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SqlXml), Member = "CreateReader", ReturnType = typeof(XmlReader))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

}

