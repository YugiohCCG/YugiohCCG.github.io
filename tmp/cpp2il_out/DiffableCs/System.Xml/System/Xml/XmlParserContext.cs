namespace System.Xml;

public class XmlParserContext
{
	private XmlNameTable _nt; //Field offset: 0x10
	private XmlNamespaceManager _nsMgr; //Field offset: 0x18
	private string _docTypeName; //Field offset: 0x20
	private string _pubId; //Field offset: 0x28
	private string _sysId; //Field offset: 0x30
	private string _internalSubset; //Field offset: 0x38
	private string _xmlLang; //Field offset: 0x40
	private XmlSpace _xmlSpace; //Field offset: 0x48
	private string _baseURI; //Field offset: 0x50
	private Encoding _encoding; //Field offset: 0x58

	public string BaseURI
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string DocTypeName
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public Encoding Encoding
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	internal bool HasDtdInfo
	{
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInitUriString", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInitStream", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInitTextReader", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(int)}, ReturnType = "System.Xml.XmlTextReaderImpl+EntityType")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		internal get { } //Length: 117
	}

	public string InternalSubset
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public XmlNamespaceManager NamespaceManager
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public XmlNameTable NameTable
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string PublicId
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string SystemId
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string XmlLang
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public XmlSpace XmlSpace
	{
		[CallerCount(Count = 26)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ImplReadXmlText", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlParserContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(XmlNamespaceManager), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(XmlSpace), typeof(Encoding)}, ReturnType = typeof(void))]
	public XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string xmlLang, XmlSpace xmlSpace) { }

	[CalledBy(Type = typeof(XmlLoader), Member = "ParseDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocumentType), typeof(bool), typeof(XmlResolver)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlLoader), Member = "GetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlParserContext))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlParserContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(XmlNamespaceManager), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(XmlSpace), typeof(Encoding)}, ReturnType = typeof(void))]
	public XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace) { }

	[CalledBy(Type = typeof(XmlParserContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(XmlNamespaceManager), typeof(string), typeof(XmlSpace)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlParserContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(XmlNamespaceManager), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(XmlSpace)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	public XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace, Encoding enc) { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public string get_BaseURI() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public string get_DocTypeName() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public Encoding get_Encoding() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInitUriString", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInitStream", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInitTextReader", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(int)}, ReturnType = "System.Xml.XmlTextReaderImpl+EntityType")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	internal bool get_HasDtdInfo() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public string get_InternalSubset() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public XmlNamespaceManager get_NamespaceManager() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public XmlNameTable get_NameTable() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public string get_PublicId() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public string get_SystemId() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public string get_XmlLang() { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	public XmlSpace get_XmlSpace() { }

}

