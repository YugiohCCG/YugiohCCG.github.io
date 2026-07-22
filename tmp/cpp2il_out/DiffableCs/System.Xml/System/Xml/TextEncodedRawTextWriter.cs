namespace System.Xml;

internal class TextEncodedRawTextWriter : XmlEncodedRawTextWriter
{

	internal virtual bool SupportsNamespaceDeclarationInChunks
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	[CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(XmlWriter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	public TextEncodedRawTextWriter(TextWriter writer, XmlWriterSettings settings) { }

	[CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(XmlWriter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	public TextEncodedRawTextWriter(Stream stream, XmlWriterSettings settings) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	internal virtual bool get_SupportsNamespaceDeclarationInChunks() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal virtual void StartElementContent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteRawWithCharChecking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void WriteCData(string text) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void WriteCharEntity(char ch) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteRawWithCharChecking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void WriteComment(string text) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual void WriteEndAttribute() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void WriteEntityRef(string name) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal virtual void WriteNamespaceDeclaration(string prefix, string ns) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void WriteProcessingInstruction(string name, string text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteRawWithCharChecking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteRawWithCharChecking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void WriteRaw(string data) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteRawWithCharChecking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void WriteString(string textBlock) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "ChangeTextContentMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlEncodedRawTextWriter), Member = "WriteRawWithCharChecking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void WriteWhitespace(string ws) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal virtual void WriteXmlDeclaration(string xmldecl) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

}

