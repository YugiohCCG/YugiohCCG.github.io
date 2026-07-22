namespace System.Xml;

public class XmlException : SystemException
{
	private string res; //Field offset: 0x90
	private String[] args; //Field offset: 0x98
	private int lineNumber; //Field offset: 0xA0
	private int linePosition; //Field offset: 0xA4
	[OptionalField]
	private string sourceUri; //Field offset: 0xA8
	private string message; //Field offset: 0xB0

	public int LineNumber
	{
		[CallerCount(Count = 3)]
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

	internal string ResString
	{
		[CallerCount(Count = 57)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetEnumerator", ReturnType = typeof(SerializationInfoEnumerator))]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "get_Current", ReturnType = typeof(SerializationEntry))]
	[Calls(Type = typeof(XmlException), Member = "CreateMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 18)]
	protected XmlException(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(IXmlLineInfo), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IXmlLineInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(IXmlLineInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlConvert), Member = "CreateException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(ExceptionType), typeof(int), typeof(int)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XmlConvert), Member = "TryVerifyNMTOKEN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XmlConvert), Member = "TryVerifyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(ValidateNames), Member = "GetInvalidNameException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = "CreateMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	internal XmlException(string res, String[] args, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntityOrSubset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Uri), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	internal XmlException(string res, String[] args, Exception innerException, int lineNumber, int linePosition) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	internal XmlException(string res, String[] args, int lineNumber, int linePosition, string sourceUri) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	internal XmlException(string res, String[] args, int lineNumber, int linePosition) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal XmlException(string res, string arg, int lineNumber, int linePosition, string sourceUri) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal XmlException(string res, String[] args, IXmlLineInfo lineInfo, string sourceUri) { }

	[CalledBy(Type = typeof(XmlReader), Member = "ReadElementString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal XmlException(string res, String[] args, IXmlLineInfo lineInfo) { }

	[CalledBy(Type = typeof(ReadContentAsBinaryHelper), Member = "Finish", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReader), Member = "ReadStartElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReader), Member = "ReadElementString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlReader), Member = "ReadEndElement", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal XmlException(string res, string arg, IXmlLineInfo lineInfo) { }

	[CalledBy(Type = typeof(XmlConvert), Member = "CreateException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ExceptionType), typeof(int), typeof(int)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XmlConvert), Member = "CreateException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(ExceptionType), typeof(int), typeof(int)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XmlConvert), Member = "CreateInvalidHighSurrogateCharException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(ExceptionType)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XmlConvert), Member = "CreateInvalidHighSurrogateCharException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(ExceptionType), typeof(int), typeof(int)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XdrValidator), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal XmlException(string res, string arg, int lineNumber, int linePosition) { }

	[CallerCount(Count = 56)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal XmlException(string res, string arg) { }

	[CalledBy(Type = typeof(BinXmlSqlDecimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(QName), Member = "CheckPrefixNS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "AddQName", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ReadInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ReadDoc", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ThrowXmlException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ThrowXmlException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "PushNamespaceImplicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "PushNamespaceExplicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlDocument), Member = "CheckName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValidateNames), Member = "ThrowInvalidName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	internal XmlException(string res, String[] args) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlException), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlException), Member = "CreateMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	internal XmlException(string message, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	public XmlException(string message, Exception innerException, int lineNumber, int linePosition) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "Read", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	public XmlException(string message, Exception innerException) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "FinishCDATA", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ReadDoc", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SetupFromParserContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlParserContext), typeof(XmlReaderSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	public XmlException(string message) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	public XmlException() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal XmlException(string res, string arg, string sourceUri) { }

	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "ValidateContentChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "ValidateContentChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteDocType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "InvalidCharsException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XmlDocument), Member = "CheckName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseExternalId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.DtdParser+Token", "System.Xml.DtdParser+Token", typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ThrowInvalidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValidateNames), Member = "ThrowInvalidName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlConvert), Member = "VerifyQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ExceptionType)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Preprocessor), Member = "ValidateNameAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "ValidateNameAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	internal static String[] BuildCharExceptionArgs(string data, int invCharIndex) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowInvalidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Xml.DtdParser+Token")]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.DtdParser+LiteralType"}, ReturnType = "System.Xml.DtdParser+Token")]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanCondSection3", ReturnType = "System.Xml.DtdParser+Token")]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanNmtoken", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ThrowInvalidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(String[]))]
	[CallsUnknownMethods(Count = 2)]
	internal static String[] BuildCharExceptionArgs(Char[] data, int length, int invCharIndex) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(XmlConvert), Member = "CreateInvalidNameCharException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(ExceptionType)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XmlConvert), Member = "CreateInvalidCharException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(ExceptionType)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XmlConvert), Member = "CreateInvalidCharException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XmlConvert), Member = "CreateInvalidCharException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(ExceptionType)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XmlConvert), Member = "TryVerifyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(ValidateNames), Member = "SplitQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlConvert), Member = "TryVerifyNMTOKEN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.DtdParser+LiteralType"}, ReturnType = "System.Xml.DtdParser+Token")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRefInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(StringBuilder), typeof(Int32&), typeof(EntityType&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), "System.Xml.XmlTextReaderImpl+NodeData"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValidateNames), Member = "GetInvalidNameException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	internal static String[] BuildCharExceptionArgs(char invChar, char nextChar) { }

	[CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlException), Member = "FormatUserMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SR), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 9)]
	private static string CreateMessage(string res, String[] args, int lineNumber, int linePosition) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlException), Member = "CreateMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	private static string FormatUserMessage(string message, int lineNumber, int linePosition) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public int get_LineNumber() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public int get_LinePosition() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Exception), Member = "get_Message", ReturnType = typeof(string))]
	public virtual string get_Message() { }

	[CallerCount(Count = 57)]
	[DeduplicatedMethod]
	internal string get_ResString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Exception), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

