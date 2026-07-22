namespace System.Xml;

public class XmlConvert
{
	private static XmlCharType xmlCharType; //Field offset: 0x0
	internal static Char[] crt; //Field offset: 0x8
	private static readonly int c_EncodedCharLength; //Field offset: 0x10
	private static Regex c_EncodeCharPattern; //Field offset: 0x18
	private static Regex c_DecodeCharPattern; //Field offset: 0x20
	private static String[] s_allDateTimeFormats; //Field offset: 0x28
	internal static readonly Char[] WhitespaceChars; //Field offset: 0x30

	private static String[] AllDateTimeFormats
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlConvert), Member = "CreateAllDateTimeFormats", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 169
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private static XmlConvert() { }

	[CalledBy(Type = typeof(XmlConvert), Member = "get_AllDateTimeFormats", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(XmlConvert), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 29)]
	private static void CreateAllDateTimeFormats() { }

	[CalledBy(Type = typeof(XmlConvert), Member = "VerifyCharData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ExceptionType), typeof(ExceptionType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	internal static Exception CreateException(string res, ExceptionType exceptionType, int lineNo, int linePos) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	internal static Exception CreateException(string res, string arg, ExceptionType exceptionType, int lineNo, int linePos) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "CreateException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(ExceptionType), typeof(int), typeof(int)}, ReturnType = typeof(Exception))]
	internal static Exception CreateException(string res, String[] args, ExceptionType exceptionType) { }

	[CalledBy(Type = typeof(XmlConvert), Member = "VerifyQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ExceptionType)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlConvert), Member = "CreateException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(ExceptionType)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XmlConvert), Member = "CreateInvalidSurrogatePairException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(ExceptionType), typeof(int), typeof(int)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XmlConvert), Member = "CreateInvalidCharException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(ExceptionType)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XmlConvert), Member = "CreateInvalidCharException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(ExceptionType)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XmlConvert), Member = "CreateInvalidNameCharException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(ExceptionType)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(SR), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception CreateException(string res, String[] args, ExceptionType exceptionType, int lineNo, int linePos) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "CheckText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlNodeType))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(XmlConvert), Member = "CreateException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(ExceptionType), typeof(int), typeof(int)}, ReturnType = typeof(Exception))]
	internal static Exception CreateInvalidCharException(char invChar, char nextChar, ExceptionType exceptionType) { }

	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "InvalidXmlChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte*), typeof(bool)}, ReturnType = typeof(Byte*))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteCDataSection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteCommentOrPi", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteRawWithCharChecking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "InvalidXmlChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Char*), typeof(bool)}, ReturnType = typeof(Char*))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteCDataSection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteCommentOrPi", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteRawWithCharChecking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "RawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "EncodeChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*&), typeof(Char*), typeof(Char*&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(SR), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception CreateInvalidCharException(char invChar, char nextChar) { }

	[CalledBy(Type = typeof(XmlConvert), Member = "VerifyCharData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ExceptionType), typeof(ExceptionType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(XmlConvert), Member = "CreateException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(ExceptionType), typeof(int), typeof(int)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 1)]
	internal static Exception CreateInvalidCharException(string data, int invCharPos, ExceptionType exceptionType) { }

	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "EncodeSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*), typeof(Char*)}, ReturnType = typeof(Char*))]
	[CalledBy(Type = typeof(XmlTextEncoder), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextEncoder), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextEncoder), Member = "WriteRawWithSurrogateChecking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "EncodeSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*), typeof(Byte*)}, ReturnType = typeof(Byte*))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlConvert), Member = "CreateInvalidHighSurrogateCharException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(ExceptionType)}, ReturnType = typeof(Exception))]
	internal static Exception CreateInvalidHighSurrogateCharException(char hi) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(uint), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SR), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	internal static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType, int lineNo, int linePos) { }

	[CalledBy(Type = typeof(XmlConvert), Member = "CreateInvalidHighSurrogateCharException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(uint), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SR), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	internal static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType) { }

	[CalledBy(Type = typeof(DtdParser), Member = "InitializeFreeFloatingDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(IDtdParserAdapter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static ArgumentException CreateInvalidNameArgumentException(string name, string argumentName) { }

	[CalledBy(Type = typeof(XmlConvert), Member = "VerifyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlConvert), Member = "VerifyNCName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlConvert), Member = "VerifyNCName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ExceptionType)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(XmlConvert), Member = "CreateException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(ExceptionType), typeof(int), typeof(int)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 1)]
	internal static Exception CreateInvalidNameCharException(string name, int index, ExceptionType exceptionType) { }

	[CalledBy(Type = typeof(XmlConvert), Member = "VerifyCharData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ExceptionType), typeof(ExceptionType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlConvert), Member = "CreateInvalidSurrogatePairException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XmlConvert), Member = "CreateInvalidSurrogatePairException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(ExceptionType)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(uint), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "CreateException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(ExceptionType), typeof(int), typeof(int)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 4)]
	internal static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType, int lineNo, int linePos) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "CreateInvalidSurrogatePairException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(ExceptionType), typeof(int), typeof(int)}, ReturnType = typeof(Exception))]
	internal static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "CheckText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlNodeType))]
	[CalledBy(Type = typeof(CharEntityEncoderFallbackBuffer), Member = "Fallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "EncodeSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*), typeof(Char*)}, ReturnType = typeof(Char*))]
	[CalledBy(Type = typeof(XmlTextEncoder), Member = "WriteSurrogateChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextEncoder), Member = "WriteSurrogateCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextEncoder), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextEncoder), Member = "WriteRawWithSurrogateChecking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "EncodeSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*), typeof(Byte*)}, ReturnType = typeof(Byte*))]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteSurrogateCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(XmlConvert), Member = "CreateInvalidSurrogatePairException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(ExceptionType), typeof(int), typeof(int)}, ReturnType = typeof(Exception))]
	internal static Exception CreateInvalidSurrogatePairException(char low, char hi) { }

	[CallerCount(Count = 46)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Regex), Member = "Matches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(MatchCollection))]
	[Calls(Type = typeof(MatchCollection), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public static string DecodeName(string name) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static long DoubleToInt64Bits(double value) { }

	[CallerCount(Count = 34)]
	[Calls(Type = typeof(XmlConvert), Member = "EncodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(string))]
	public static string EncodeLocalName(string name) { }

	[CalledBy(Type = typeof(XmlCustomFormatter), Member = "FromXmlName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "CreateMapMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(XmlReflectionMember), typeof(string)}, ReturnType = typeof(XmlTypeMapMember))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(bool), typeof(ICollection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteTypedPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.XmlNodeConverter", Member = "CreateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", "Newtonsoft.Json.Converters.IXmlDocument", "Newtonsoft.Json.Converters.IXmlNode", typeof(string), typeof(XmlNamespaceManager), typeof(string), "System.Collections.Generic.Dictionary`2<String, String>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.XmlNodeConverter", Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", "Newtonsoft.Json.Converters.IXmlDocument", "Newtonsoft.Json.Converters.IXmlNode", typeof(string), typeof(string), typeof(XmlNamespaceManager), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.XmlNodeConverter", Member = "CreateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Newtonsoft.Json.Converters.IXmlDocument", typeof(string), typeof(XmlNamespaceManager)}, ReturnType = "Newtonsoft.Json.Converters.IXmlElement")]
	[CalledBy(Type = "System.Data.DataColumn", Member = "set_Prefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataSet", Member = "set_Prefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataSet", Member = "Clone", ReturnType = "System.Data.DataSet")]
	[CalledBy(Type = "System.Data.DataTable", Member = "set_Prefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[ContainsInvalidInstructions]
	public static string EncodeName(string name) { }

	[CalledBy(Type = typeof(XmlConvert), Member = "EncodeLocalName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Regex), Member = "Matches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(MatchCollection))]
	[Calls(Type = typeof(MatchCollection), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlCharType), Member = "IsNameCharXml4e", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	private static string EncodeName(string name, bool first, bool local) { }

	[CalledBy(Type = typeof(XmlCustomFormatter), Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(BinHexDecoder), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(bool)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal static Byte[] FromBinHexString(string s) { }

	[CalledBy(Type = typeof(Datatype_hexBinary), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToHexBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(BinHexDecoder), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(bool)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal static Byte[] FromBinHexString(string s, bool allowOddCount) { }

	[CallerCount(Count = 0)]
	private static int FromHex(char digit) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "CreateAllDateTimeFormats", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static String[] get_AllDateTimeFormats() { }

	[CalledBy(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static bool IsNegativeZero(double value) { }

	[CalledBy(Type = typeof(Datatype_List), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(NamespaceList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "EnumerateAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlListConverter), Member = "ChangeListType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlListConverter), Member = "StringAsList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Collections.Generic.List`1<System.String>))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "ParseBlockFinalEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(IDQuery), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(IDQuery), Member = "ProcessIds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNavigator), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[CallsUnknownMethods(Count = 1)]
	internal static String[] SplitString(string value) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseEndElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDoctypeDecl", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipDtd", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "System.Xml.XmlTextReaderImpl+NodeData")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "IncrementalRead", ReturnType = typeof(int))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static bool StrEqual(Char[] chars, int strPos1, int strLen1, string str2) { }

	[CalledBy(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(XmlDateTimeSerializationMode)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlConvert), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlDateTimeSerializationMode)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
	[Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	private static DateTime SwitchToLocalTime(DateTime value) { }

	[CalledBy(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(XmlDateTimeSerializationMode)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlConvert), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlDateTimeSerializationMode)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
	[Calls(Type = typeof(DateTime), Member = "ToUniversalTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	private static DateTime SwitchToUtcTime(DateTime value) { }

	[CalledBy(Type = typeof(XmlCustomFormatter), Member = "ToXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BinHexEncoder), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal static string ToBinHexString(Byte[] inArray) { }

	[CallerCount(Count = 34)]
	[Calls(Type = typeof(string), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 14)]
	public static bool ToBoolean(string s) { }

	[CalledBy(Type = typeof(XmlCustomFormatter), Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "RefineSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(XmlQualifiedName))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlByte", Member = "System.Xml.Serialization.IXmlSerializable.ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.Common.ByteStorage", Member = "ConvertXmlToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(byte), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(byte))]
	public static byte ToByte(string s) { }

	[CalledBy(Type = typeof(Datatype_char), Member = "ParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.Common.CharStorage", Member = "ConvertXmlToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static char ToChar(string s) { }

	[CalledBy(Type = typeof(XmlCustomFormatter), Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlConvert), Member = "CreateAllDateTimeFormats", ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(DateTime), Member = "ParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(IFormatProvider), typeof(DateTimeStyles)}, ReturnType = typeof(DateTime))]
	[CallsUnknownMethods(Count = 2)]
	[Obsolete("Use XmlConvert.ToDateTime() that takes in XmlDateTimeSerializationMode")]
	public static DateTime ToDateTime(string s) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(DateTime), Member = "ParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(IFormatProvider), typeof(DateTimeStyles)}, ReturnType = typeof(DateTime))]
	public static DateTime ToDateTime(string s, String[] formats) { }

	[CalledBy(Type = typeof(XmlCustomFormatter), Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "RefineSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(XmlQualifiedName))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "DateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlDateTime", Member = "System.Xml.Serialization.IXmlSerializable.ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.Common.DateTimeStorage", Member = "ConvertXmlToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlConvert), Member = "SwitchToUtcTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(XmlConvert), Member = "SwitchToLocalTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	public static DateTime ToDateTime(string s, XmlDateTimeSerializationMode dateTimeOption) { }

	[CalledBy(Type = "System.Data.Common.DateTimeOffsetStorage", Member = "ConvertXmlToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTimeOffset))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static DateTimeOffset ToDateTimeOffset(string s) { }

	[CalledBy(Type = typeof(XmlCustomFormatter), Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Datatype_fixed), Member = "ParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlMoney", Member = "System.Xml.Serialization.IXmlSerializable.ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.Common.DecimalStorage", Member = "ConvertXmlToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Decimal), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	public static decimal ToDecimal(string s) { }

	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.Common.DoubleStorage", Member = "ConvertXmlToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlDouble", Member = "System.Xml.Serialization.IXmlSerializable.ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(double))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(double))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlNumeric2Converter), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(double))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "RefineSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(XmlQualifiedName))]
	[CalledBy(Type = typeof(Datatype_doubleXdr), Member = "ParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlCustomFormatter), Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlNumeric2Converter), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(double), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(string), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static double ToDouble(string s) { }

	[CalledBy(Type = typeof(XmlCustomFormatter), Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Datatype_uuid), Member = "ParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public static Guid ToGuid(string s) { }

	[CalledBy(Type = typeof(XmlCustomFormatter), Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "RefineSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(XmlQualifiedName))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlInt16", Member = "System.Xml.Serialization.IXmlSerializable.ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.Common.Int16Storage", Member = "ConvertXmlToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(short), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(short))]
	public static short ToInt16(string s) { }

	[CalledBy(Type = typeof(XmlCustomFormatter), Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "RefineSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(XmlQualifiedName))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlInt32", Member = "System.Xml.Serialization.IXmlSerializable.ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.Common.Int32Storage", Member = "ConvertXmlToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(int))]
	public static int ToInt32(string s) { }

	[CalledBy(Type = typeof(XmlCustomFormatter), Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "RefineSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(XmlQualifiedName))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlInt64", Member = "System.Xml.Serialization.IXmlSerializable.ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.Common.Int64Storage", Member = "ConvertXmlToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(long), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(long))]
	public static long ToInt64(string s) { }

	[CalledBy(Type = typeof(XmlSchemaParticle), Member = "set_MinOccursString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaParticle), Member = "set_MaxOccursString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Decimal))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Decimal), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	internal static decimal ToInteger(string s) { }

	[CalledBy(Type = typeof(XmlCustomFormatter), Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "RefineSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(XmlQualifiedName))]
	[CalledBy(Type = "System.Data.Common.SByteStorage", Member = "ConvertXmlToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(sbyte), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(sbyte))]
	[CLSCompliant(False)]
	public static sbyte ToSByte(string s) { }

	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.Common.SingleStorage", Member = "ConvertXmlToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlSingle", Member = "System.Xml.Serialization.IXmlSerializable.ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlNumeric2Converter), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(double))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "RefineSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(XmlQualifiedName))]
	[CalledBy(Type = typeof(Datatype_floatXdr), Member = "ParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlCustomFormatter), Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlNumeric2Converter), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(float), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(string), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float ToSingle(string s) { }

	[CalledBy(Type = "System.Data.Common.CharStorage", Member = "ConvertObjectToXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string ToString(char value) { }

	[CalledBy(Type = typeof(XmlCustomFormatter), Member = "ToXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.Linq.XContainer", Member = "GetStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.Common.DecimalStorage", Member = "ConvertObjectToXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlMoney", Member = "System.Xml.Serialization.IXmlSerializable.WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.XmlNodeConverter", Member = "ConvertTokenToXmlValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader"}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "DecimalToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "DecimalToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "DecimalToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlSchemaParticle), Member = "get_MaxOccursString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlSchemaParticle), Member = "get_MinOccursString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(string))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Decimal), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	public static string ToString(decimal value) { }

	[CalledBy(Type = typeof(XmlCustomFormatter), Member = "ToXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBooleanConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBooleanConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBooleanConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.XmlNodeConverter", Member = "ConvertTokenToXmlValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader"}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.Common.BooleanStorage", Member = "ConvertObjectToXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.Linq.XContainer", Member = "GetStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 10)]
	public static string ToString(bool value) { }

	[CalledBy(Type = typeof(XmlCustomFormatter), Member = "ToXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.Common.SByteStorage", Member = "ConvertObjectToXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(sbyte), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CLSCompliant(False)]
	public static string ToString(sbyte value) { }

	[CalledBy(Type = typeof(XmlCustomFormatter), Member = "ToXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "RefineSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(XmlQualifiedName))]
	[CalledBy(Type = typeof(XmlNumeric2Converter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlNumeric2Converter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.XmlNodeConverter", Member = "ConvertTokenToXmlValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader"}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlDouble", Member = "System.Xml.Serialization.IXmlSerializable.WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.Common.DoubleStorage", Member = "ConvertObjectToXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.Linq.XContainer", Member = "GetStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(XmlConvert), Member = "IsNegativeZero", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(double), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[ContainsUnimplementedInstructions]
	public static string ToString(double value) { }

	[CalledBy(Type = "System.Data.Common.TimeSpanStorage", Member = "ConvertObjectToXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.Linq.XContainer", Member = "GetStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XsdDuration), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDuration), Member = "ToString", ReturnType = typeof(string))]
	public static string ToString(TimeSpan value) { }

	[CalledBy(Type = "System.Data.SqlTypes.SqlDateTime", Member = "System.Xml.Serialization.IXmlSerializable.WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	public static string ToString(DateTime value, string format) { }

	[CalledBy(Type = typeof(XmlCustomFormatter), Member = "ToXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.XmlNodeConverter", Member = "ConvertTokenToXmlValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader"}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.Common.DateTimeStorage", Member = "ConvertObjectToXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.Linq.XContainer", Member = "GetStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlConvert), Member = "SwitchToUtcTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(XmlConvert), Member = "SwitchToLocalTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	public static string ToString(DateTime value, XmlDateTimeSerializationMode dateTimeOption) { }

	[CalledBy(Type = "Newtonsoft.Json.Converters.XmlNodeConverter", Member = "ConvertTokenToXmlValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader"}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.Common.DateTimeOffsetStorage", Member = "ConvertObjectToXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.Linq.XContainer", Member = "GetStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	public static string ToString(DateTimeOffset value) { }

	[CalledBy(Type = typeof(XmlCustomFormatter), Member = "ToXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlGuid", Member = "System.Xml.Serialization.IXmlSerializable.WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
	public static string ToString(Guid value) { }

	[CalledBy(Type = typeof(XmlCustomFormatter), Member = "ToXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.Common.UInt64Storage", Member = "ConvertObjectToXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(ulong), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CLSCompliant(False)]
	public static string ToString(ulong value) { }

	[CalledBy(Type = typeof(XmlCustomFormatter), Member = "ToXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.Common.UInt32Storage", Member = "ConvertObjectToXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(uint), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CLSCompliant(False)]
	public static string ToString(uint value) { }

	[CalledBy(Type = typeof(XmlCustomFormatter), Member = "ToXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.Common.UInt16Storage", Member = "ConvertObjectToXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(ushort), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CLSCompliant(False)]
	public static string ToString(ushort value) { }

	[CalledBy(Type = typeof(XmlCustomFormatter), Member = "ToXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "RefineSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(XmlQualifiedName))]
	[CalledBy(Type = typeof(XmlNumeric2Converter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlNumeric2Converter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.XmlNodeConverter", Member = "ConvertTokenToXmlValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader"}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlSingle", Member = "System.Xml.Serialization.IXmlSerializable.WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.Common.SingleStorage", Member = "ConvertObjectToXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.Linq.XContainer", Member = "GetStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(XmlConvert), Member = "IsNegativeZero", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[ContainsUnimplementedInstructions]
	public static string ToString(float value) { }

	[CalledBy(Type = typeof(XmlCustomFormatter), Member = "ToXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "Int64ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "Int64ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.XmlNodeConverter", Member = "ConvertTokenToXmlValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader"}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlInt64", Member = "System.Xml.Serialization.IXmlSerializable.WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.Common.Int64Storage", Member = "ConvertObjectToXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(long), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	public static string ToString(long value) { }

	[CalledBy(Type = typeof(XmlCustomFormatter), Member = "ToXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlInt16", Member = "System.Xml.Serialization.IXmlSerializable.WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.Common.Int16Storage", Member = "ConvertObjectToXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(short), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	public static string ToString(short value) { }

	[CalledBy(Type = typeof(XmlCustomFormatter), Member = "ToXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlByte", Member = "System.Xml.Serialization.IXmlSerializable.WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.Common.ByteStorage", Member = "ConvertObjectToXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	public static string ToString(byte value) { }

	[CalledBy(Type = typeof(XmlCustomFormatter), Member = "ToXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.Common.Int32Storage", Member = "ConvertObjectToXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlInt32", Member = "System.Xml.Serialization.IXmlSerializable.WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdDuration), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DurationType)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "Int32ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "Int32ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(sbyte))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "Int32ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(short))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "Int32ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	public static string ToString(int value) { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "RefineSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(XmlQualifiedName))]
	[CalledBy(Type = "System.Data.Common.TimeSpanStorage", Member = "ConvertXmlToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XsdDuration), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDuration), Member = "ToTimeSpan", ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	public static TimeSpan ToTimeSpan(string s) { }

	[CalledBy(Type = typeof(XmlCustomFormatter), Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "RefineSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(XmlQualifiedName))]
	[CalledBy(Type = "System.Data.Common.UInt16Storage", Member = "ConvertXmlToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(ushort), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(ushort))]
	[CLSCompliant(False)]
	public static ushort ToUInt16(string s) { }

	[CalledBy(Type = typeof(XmlCustomFormatter), Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "RefineSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(XmlQualifiedName))]
	[CalledBy(Type = "System.Data.Common.UInt32Storage", Member = "ConvertXmlToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(uint), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(uint))]
	[CLSCompliant(False)]
	public static uint ToUInt32(string s) { }

	[CalledBy(Type = typeof(XmlCustomFormatter), Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "RefineSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(XmlQualifiedName))]
	[CalledBy(Type = "System.Data.Common.UInt64Storage", Member = "ConvertXmlToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(ulong), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(ulong))]
	[CLSCompliant(False)]
	public static ulong ToUInt64(string s) { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "SetupValidator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReaderSettings), typeof(XmlReader), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "PreprocessNotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaNotation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Preprocessor), Member = "ParseUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NamespaceList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializerNamespaces), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlQualifiedName), Member = "Verify", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), "System.Xml.Schema.SchemaCollectionPreprocessor+Compositor"}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UriKind), typeof(Uri&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 27)]
	internal static Uri ToUri(string s) { }

	[CallerCount(Count = 30)]
	[Calls(Type = typeof(string), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(double), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Double&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[CallsUnknownMethods(Count = 3)]
	internal static double ToXPathDouble(object o) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnXmlReservedAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.XmlTextReaderImpl+NodeData"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "HandleSpecialAttribute", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.XmlWellFormedWriter+AttributeValueCache", Member = "Trim", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNode), Member = "get_XmlSpace", ReturnType = typeof(XmlSpace))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToBase64Binary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToHexBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(string), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	internal static string TrimString(string value) { }

	[CalledBy(Type = "System.Xml.XmlWellFormedWriter+AttributeValueCache", Member = "Trim", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "TrimEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	internal static string TrimStringEnd(string value) { }

	[CalledBy(Type = "System.Xml.XmlWellFormedWriter+AttributeValueCache", Member = "Trim", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "TrimStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	internal static string TrimStringStart(string value) { }

	[CalledBy(Type = typeof(Datatype_boolean), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SR), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	internal static Exception TryToBoolean(string s, out bool result) { }

	[CalledBy(Type = typeof(Datatype_unsignedByte), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(byte), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Byte&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SR), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	internal static Exception TryToByte(string s, out byte result) { }

	[CalledBy(Type = typeof(Datatype_char), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(char), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Char&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SR), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	internal static Exception TryToChar(string s, out char result) { }

	[CalledBy(Type = typeof(Datatype_decimal), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(Datatype_fixed), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Decimal), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Decimal&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SR), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	internal static Exception TryToDecimal(string s, out decimal result) { }

	[CalledBy(Type = typeof(Datatype_double), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(double), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Double&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(SR), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	internal static Exception TryToDouble(string s, out double result) { }

	[CalledBy(Type = typeof(Datatype_uuid), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SR), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 24)]
	internal static Exception TryToGuid(string s, out Guid result) { }

	[CalledBy(Type = typeof(Datatype_short), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(short), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Int16&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SR), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	internal static Exception TryToInt16(string s, out short result) { }

	[CalledBy(Type = typeof(Datatype_int), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SR), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	internal static Exception TryToInt32(string s, out int result) { }

	[CalledBy(Type = typeof(Datatype_long), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(long), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Int64&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SR), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	internal static Exception TryToInt64(string s, out long result) { }

	[CalledBy(Type = typeof(Datatype_integer), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Decimal), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Decimal&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SR), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	internal static Exception TryToInteger(string s, out decimal result) { }

	[CalledBy(Type = typeof(Datatype_byte), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(sbyte), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(SByte&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SR), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	internal static Exception TryToSByte(string s, out sbyte result) { }

	[CalledBy(Type = typeof(Datatype_float), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(float), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(SR), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	internal static Exception TryToSingle(string s, out float result) { }

	[CalledBy(Type = typeof(Datatype_duration), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XsdDuration), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDuration&)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(XsdDuration), Member = "TryToTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan&)}, ReturnType = typeof(Exception))]
	internal static Exception TryToTimeSpan(string s, out TimeSpan result) { }

	[CalledBy(Type = typeof(Datatype_unsignedShort), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(ushort), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(UInt16&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SR), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	internal static Exception TryToUInt16(string s, out ushort result) { }

	[CalledBy(Type = typeof(Datatype_unsignedInt), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(uint), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SR), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	internal static Exception TryToUInt32(string s, out uint result) { }

	[CalledBy(Type = typeof(Datatype_unsignedLong), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(ulong), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(UInt64&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SR), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	internal static Exception TryToUInt64(string s, out ulong result) { }

	[CalledBy(Type = typeof(Datatype_anyURI), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(StringFacetsChecker), Member = "CheckBuiltInFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlTypeCode), typeof(bool)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SR), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UriKind), typeof(Uri&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 18)]
	internal static Exception TryToUri(string s, out Uri result) { }

	[CalledBy(Type = typeof(StringFacetsChecker), Member = "CheckBuiltInFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlTypeCode), typeof(bool)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ValidateNames), Member = "ParseNameNoNamespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception TryVerifyName(string name) { }

	[CalledBy(Type = typeof(StringFacetsChecker), Member = "CheckBuiltInFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlTypeCode), typeof(bool)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ValidateNames), Member = "ParseNCName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ValidateNames), Member = "GetInvalidNameException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 1)]
	internal static Exception TryVerifyNCName(string name) { }

	[CalledBy(Type = typeof(StringFacetsChecker), Member = "CheckBuiltInFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlTypeCode), typeof(bool)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal static Exception TryVerifyNMTOKEN(string name) { }

	[CalledBy(Type = typeof(StringFacetsChecker), Member = "CheckBuiltInFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlTypeCode), typeof(bool)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal static Exception TryVerifyNormalizedString(string str) { }

	[CalledBy(Type = typeof(StringFacetsChecker), Member = "CheckBuiltInFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlTypeCode), typeof(bool)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception TryVerifyTOKEN(string token) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ScanOverAnyValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinXmlToken), typeof(bool), typeof(bool)}, ReturnType = typeof(XmlNodeType))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(XmlConvert), Member = "CreateInvalidSurrogatePairException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(ExceptionType), typeof(int), typeof(int)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(XmlConvert), Member = "CreateException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ExceptionType), typeof(int), typeof(int)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(XmlConvert), Member = "CreateInvalidCharException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(ExceptionType)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 20)]
	internal static void VerifyCharData(string data, ExceptionType invCharExceptionType, ExceptionType invSurrogateExceptionType) { }

	[CalledBy(Type = typeof(DtdParser), Member = "InitializeFreeFloatingDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(IDtdParserAdapter)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Linq.XDocumentType", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ValidateNames), Member = "ParseNameNoNamespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlConvert), Member = "CreateInvalidNameCharException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(ExceptionType)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	public static string VerifyName(string name) { }

	[CalledBy(Type = typeof(XmlQualifiedName), Member = "Verify", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializerNamespaces), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "ValidateIdAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "ValidateIdAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Linq.XName", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Linq.XNamespace", typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Linq.XNamespace", Member = "GetName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = "System.Xml.Linq.XName")]
	[CalledBy(Type = "System.Xml.Linq.XProcessingInstruction", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Linq.XProcessingInstruction", Member = "ValidateName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ValidateNames), Member = "ParseNCName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlConvert), Member = "CreateInvalidNameCharException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(ExceptionType)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	public static string VerifyNCName(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValidateNames), Member = "ParseNCName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlConvert), Member = "CreateInvalidNameCharException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(ExceptionType)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	internal static string VerifyNCName(string name, ExceptionType exceptionType) { }

	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteDocType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ValidateNames), Member = "ParseNCName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(XmlConvert), Member = "CreateException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(ExceptionType), typeof(int), typeof(int)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 10)]
	internal static string VerifyQName(string name, ExceptionType exceptionType) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessNotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaNotation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), "System.Xml.Schema.SchemaCollectionPreprocessor+Compositor"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static string VerifyTOKEN(string token) { }

	[CalledBy(Type = typeof(NumberFunctions), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(NumberFunctions), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(double))]
	[CalledBy(Type = typeof(StringFunctions), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	internal static double XPathRound(double value) { }

}

