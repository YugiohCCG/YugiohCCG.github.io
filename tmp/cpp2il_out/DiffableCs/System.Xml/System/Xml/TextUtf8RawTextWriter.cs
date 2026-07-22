namespace System.Xml;

internal class TextUtf8RawTextWriter : XmlUtf8RawTextWriter
{

	internal virtual bool SupportsNamespaceDeclarationInChunks
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	[CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(XmlWriter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	public TextUtf8RawTextWriter(Stream stream, XmlWriterSettings settings) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	internal virtual bool get_SupportsNamespaceDeclarationInChunks() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal virtual void StartElementContent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public virtual void WriteCData(string text) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void WriteCharEntity(char ch) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
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
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public virtual void WriteRaw(string data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public virtual void WriteString(string textBlock) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUtf8RawTextWriter), Member = "WriteRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public virtual void WriteWhitespace(string ws) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal virtual void WriteXmlDeclaration(string xmldecl) { }

}

