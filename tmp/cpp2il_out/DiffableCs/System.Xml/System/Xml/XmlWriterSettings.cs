namespace System.Xml;

public sealed class XmlWriterSettings
{
	private bool useAsync; //Field offset: 0x10
	private Encoding encoding; //Field offset: 0x18
	private bool omitXmlDecl; //Field offset: 0x20
	private NewLineHandling newLineHandling; //Field offset: 0x24
	private string newLineChars; //Field offset: 0x28
	private TriState indent; //Field offset: 0x30
	private string indentChars; //Field offset: 0x38
	private bool newLineOnAttributes; //Field offset: 0x40
	private bool closeOutput; //Field offset: 0x41
	private NamespaceHandling namespaceHandling; //Field offset: 0x44
	private ConformanceLevel conformanceLevel; //Field offset: 0x48
	private bool checkCharacters; //Field offset: 0x4C
	private bool writeEndDocumentOnClose; //Field offset: 0x4D
	private XmlOutputMethod outputMethod; //Field offset: 0x50
	private List<XmlQualifiedName> cdataSections; //Field offset: 0x58
	private bool doNotEscapeUriAttributes; //Field offset: 0x60
	private bool mergeCDataSections; //Field offset: 0x61
	private string mediaType; //Field offset: 0x68
	private string docTypeSystem; //Field offset: 0x70
	private string docTypePublic; //Field offset: 0x78
	private XmlStandalone standalone; //Field offset: 0x80
	private bool autoXmlDecl; //Field offset: 0x84
	private bool isReadOnly; //Field offset: 0x85

	public bool Async
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	internal bool AutoXmlDeclaration
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	internal List<XmlQualifiedName> CDataSectionElements
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	public bool CheckCharacters
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool CloseOutput
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public ConformanceLevel ConformanceLevel
	{
		[CallerCount(Count = 26)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CalledBy(Type = "Mono.Nat.Upnp.RequestMessage", Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]&"}, ReturnType = typeof(HttpWebRequest))]
		[CalledBy(Type = "System.Xml.Linq.XAttribute", Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = "System.Xml.Linq.XNode", Member = "GetXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Linq.SaveOptions"}, ReturnType = typeof(string))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(XmlWriterSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 152
	}

	internal string DocTypePublic
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal string DocTypeSystem
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	public bool DoNotEscapeUriAttributes
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public Encoding Encoding
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool Indent
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 8
		[CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlOutputMethod)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Xml.Linq.XNode", Member = "GetXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Linq.SaveOptions"}, ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(XmlWriterSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 86
	}

	public string IndentChars
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	internal TriState IndentInternal
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	internal bool IsQuerySpecific
	{
		[CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(XmlWriter))]
		[CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(XmlWriter))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 95
	}

	internal string MediaType
	{
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal bool MergeCDataSections
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	public NamespaceHandling NamespaceHandling
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CalledBy(Type = "System.Xml.Linq.XNode", Member = "GetXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Linq.SaveOptions"}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(XmlWriterSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 152
	}

	public string NewLineChars
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public NewLineHandling NewLineHandling
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public bool NewLineOnAttributes
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool OmitXmlDeclaration
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = "System.Xml.Linq.XNode", Member = "GetXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Linq.SaveOptions"}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(XmlWriterSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		 set { } //Length: 77
	}

	public internal XmlOutputMethod OutputMethod
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	internal bool ReadOnly
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	internal XmlStandalone Standalone
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 7
	}

	public bool WriteEndDocumentOnClose
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 5
	}

	[CalledBy(Type = "Mono.Nat.Upnp.RequestMessage", Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]&"}, ReturnType = typeof(HttpWebRequest))]
	[CalledBy(Type = typeof(XmlWriter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(XmlWriter))]
	[CalledBy(Type = typeof(XmlWriter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(XmlWriter))]
	[CalledBy(Type = typeof(XmlWriter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(XmlWriterSettings)}, ReturnType = typeof(XmlWriter))]
	[CalledBy(Type = "System.Xml.Linq.XAttribute", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.Linq.XNode", Member = "GetXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Linq.SaveOptions"}, ReturnType = typeof(string))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public XmlWriterSettings() { }

	[CalledBy(Type = typeof(XmlWriterSettings), Member = "set_OmitXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlWriterSettings), Member = "set_Indent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlWriterSettings), Member = "set_ConformanceLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConformanceLevel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlWriterSettings), Member = "set_NamespaceHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamespaceHandling)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	private void CheckReadOnly(string propertyName) { }

	[CalledBy(Type = typeof(XmlAutoDetectWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public XmlWriterSettings Clone() { }

	[CalledBy(Type = typeof(XmlWriter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(XmlWriter))]
	[CalledBy(Type = typeof(XmlWriter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(XmlWriterSettings)}, ReturnType = typeof(XmlWriter))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlAutoDetectWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEncodedRawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HtmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HtmlEncodedRawTextWriterIndent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlEncodedRawTextWriterIndent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriterSettings), Member = "get_IsQuerySpecific", ReturnType = typeof(bool))]
	[Calls(Type = typeof(QueryOutputWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlRawWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlAsyncCheckWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal XmlWriter CreateWriter(TextWriter output) { }

	[CalledBy(Type = typeof(XmlWriter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(XmlWriter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlAsyncCheckWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(QueryOutputWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlRawWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriterSettings), Member = "get_IsQuerySpecific", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlUtf8RawTextWriterIndent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HtmlUtf8RawTextWriterIndent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HtmlUtf8RawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextUtf8RawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlEncodedRawTextWriterIndent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HtmlEncodedRawTextWriterIndent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HtmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEncodedRawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlAutoDetectWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	internal XmlWriter CreateWriter(Stream output) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_Async() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_AutoXmlDeclaration() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	internal List<XmlQualifiedName> get_CDataSectionElements() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_CheckCharacters() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_CloseOutput() { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	public ConformanceLevel get_ConformanceLevel() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	internal string get_DocTypePublic() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	internal string get_DocTypeSystem() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_DoNotEscapeUriAttributes() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public Encoding get_Encoding() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_Indent() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public string get_IndentChars() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	internal TriState get_IndentInternal() { }

	[CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(XmlWriter))]
	[CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(XmlWriter))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool get_IsQuerySpecific() { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	internal string get_MediaType() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_MergeCDataSections() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public NamespaceHandling get_NamespaceHandling() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public string get_NewLineChars() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public NewLineHandling get_NewLineHandling() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public bool get_NewLineOnAttributes() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_OmitXmlDeclaration() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public XmlOutputMethod get_OutputMethod() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal XmlStandalone get_Standalone() { }

	[CallerCount(Count = 0)]
	public bool get_WriteEndDocumentOnClose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	private void Initialize() { }

	[CalledBy(Type = "Mono.Nat.Upnp.RequestMessage", Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]&"}, ReturnType = typeof(HttpWebRequest))]
	[CalledBy(Type = "System.Xml.Linq.XAttribute", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.Linq.XNode", Member = "GetXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Linq.SaveOptions"}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlWriterSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_ConformanceLevel(ConformanceLevel value) { }

	[CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlOutputMethod)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Linq.XNode", Member = "GetXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Linq.SaveOptions"}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlWriterSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_Indent(bool value) { }

	[CalledBy(Type = "System.Xml.Linq.XNode", Member = "GetXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Linq.SaveOptions"}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlWriterSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_NamespaceHandling(NamespaceHandling value) { }

	[CalledBy(Type = "System.Xml.Linq.XNode", Member = "GetXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Linq.SaveOptions"}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlWriterSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public void set_OmitXmlDeclaration(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_OutputMethod(XmlOutputMethod value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_ReadOnly(bool value) { }

}

