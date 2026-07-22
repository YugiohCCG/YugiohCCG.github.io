namespace System.Xml;

internal sealed class XmlEventCache : XmlRawWriter
{
	private struct XmlEvent
	{
		private XmlEventType eventType; //Field offset: 0x0
		private string s1; //Field offset: 0x8
		private string s2; //Field offset: 0x10
		private string s3; //Field offset: 0x18
		private object o; //Field offset: 0x20

		public XmlEventType EventType
		{
			[CallerCount(Count = 173)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public object Object
		{
			[CallerCount(Count = 12)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public string String1
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public string String2
		{
			[CallerCount(Count = 106)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public string String3
		{
			[CallerCount(Count = 31)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		[CallerCount(Count = 173)]
		[DeduplicatedMethod]
		public XmlEventType get_EventType() { }

		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		public object get_Object() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public string get_String1() { }

		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		public string get_String2() { }

		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		public string get_String3() { }

		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		public void InitEvent(XmlEventType eventType) { }

		[CallerCount(Count = 12)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public void InitEvent(XmlEventType eventType, string s1) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public void InitEvent(XmlEventType eventType, string s1, string s2) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		public void InitEvent(XmlEventType eventType, string s1, string s2, string s3) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		public void InitEvent(XmlEventType eventType, string s1, string s2, string s3, object o) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public void InitEvent(XmlEventType eventType, object o) { }

	}

	private enum XmlEventType
	{
		Unknown = 0,
		DocType = 1,
		StartElem = 2,
		StartAttr = 3,
		EndAttr = 4,
		CData = 5,
		Comment = 6,
		PI = 7,
		Whitespace = 8,
		String = 9,
		Raw = 10,
		EntRef = 11,
		CharEnt = 12,
		SurrCharEnt = 13,
		Base64 = 14,
		BinHex = 15,
		XmlDecl1 = 16,
		XmlDecl2 = 17,
		StartContent = 18,
		EndElem = 19,
		FullEndElem = 20,
		Nmsp = 21,
		EndBase64 = 22,
		Close = 23,
		Flush = 24,
		Dispose = 25,
	}

	private List<XmlEvent[]> pages; //Field offset: 0x28
	private XmlEvent[] pageCurr; //Field offset: 0x30
	private int pageSize; //Field offset: 0x38
	private bool hasRootNode; //Field offset: 0x3C
	private StringConcat singleText; //Field offset: 0x40
	private string baseUri; //Field offset: 0x78

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public XmlEventCache(string baseUri, bool hasRootNode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	private void AddEvent(XmlEventType eventType, object o) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 6)]
	private void AddEvent(XmlEventType eventType, string s1, string s2, string s3, object o) { }

	[CalledBy(Type = typeof(XmlEventCache), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEventCache), Member = "WriteStartAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEventCache), Member = "WriteEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEventCache), Member = "WriteFullEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 5)]
	private void AddEvent(XmlEventType eventType, string s1, string s2, string s3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 4)]
	private void AddEvent(XmlEventType eventType, string s1, string s2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	private void AddEvent(XmlEventType eventType, string s1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	private void AddEvent(XmlEventType eventType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public virtual void Close() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlWriter), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	protected virtual void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public void EndEvents() { }

	[CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlOutputMethod)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	public void EventsToWriter(XmlWriter writer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public virtual void Flush() { }

	[CallerCount(Count = 29)]
	[Calls(Type = typeof(StringConcat), Member = "GetResult", ReturnType = typeof(string))]
	[Calls(Type = typeof(StringConcat), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private int NewEvent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	internal virtual void StartElementContent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static Byte[] ToBytes(Byte[] buffer, int index, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void WriteBase64(Byte[] buffer, int index, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void WriteBinHex(Byte[] buffer, int index, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void WriteCData(string text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void WriteCharEntity(char ch) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void WriteComment(string text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 6)]
	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public virtual void WriteEndAttribute() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	internal virtual void WriteEndBase64() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "AddEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlEventType), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void WriteEntityRef(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "AddEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlEventType), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 4)]
	internal virtual void WriteNamespaceDeclaration(string prefix, string ns) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 4)]
	public virtual void WriteProcessingInstruction(string name, string text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void WriteRaw(string data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "AddEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlEventType), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "AddEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlEventType), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[Calls(Type = typeof(StringConcat), Member = "ConcatNoDelimiter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void WriteString(string text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void WriteValue(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void WriteWhitespace(string ws) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	internal virtual void WriteXmlDeclaration(string xmldecl) { }

}

