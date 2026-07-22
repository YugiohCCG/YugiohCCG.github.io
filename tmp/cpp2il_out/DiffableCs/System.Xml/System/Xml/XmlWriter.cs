namespace System.Xml;

public abstract class XmlWriter : IDisposable
{
	private Char[] writeNodeBuffer; //Field offset: 0x10

	public abstract WriteState WriteState
	{
		 get { } //Length: 0
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected XmlWriter() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void Close() { }

	[CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlOutputMethod)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Linq.XAttribute", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.Linq.XNode", Member = "GetXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Linq.SaveOptions"}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlWriterSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(XmlWriter))]
	[CallsUnknownMethods(Count = 1)]
	public static XmlWriter Create(TextWriter output, XmlWriterSettings settings) { }

	[CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlOutputMethod)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlWriterSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(XmlWriter))]
	[CallsUnknownMethods(Count = 1)]
	public static XmlWriter Create(Stream output, XmlWriterSettings settings) { }

	[CalledBy(Type = "Mono.Nat.Upnp.RequestMessage", Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]&"}, ReturnType = typeof(HttpWebRequest))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlWriterSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(IFormatProvider)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(XmlWriter))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static XmlWriter Create(StringBuilder output, XmlWriterSettings settings) { }

	[CalledBy(Type = typeof(XmlEventCache), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override void Dispose(bool disposing) { }

	[CalledBy(Type = typeof(XmlAsyncCheckWriter), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Dispose() { }

	public abstract void Flush() { }

	public abstract WriteState get_WriteState() { }

	public abstract string LookupPrefix(string ns) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlReader), Member = "get_IsDefaultInternal", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 8)]
	public override void WriteAttributes(XmlReader reader, bool defattr) { }

	[CallerCount(Count = 56)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void WriteAttributeString(string prefix, string localName, string ns, string value) { }

	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteNullTagEncoded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteNullTagLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(TypeData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void WriteAttributeString(string localName, string ns, string value) { }

	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WritePotentiallyReferencingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(Type), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteReferencedElements", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(TypeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteReferencingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.NewDiffgramGen", Member = "GenerateColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataRow", "System.Data.DataColumn", "System.Data.DataRowVersion"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XmlDataTreeWriter", Member = "XmlDataRowWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataRow", typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void WriteAttributeString(string localName, string value) { }

	public abstract void WriteBase64(Byte[] buffer, int index, int count) { }

	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteBinHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BinHexEncoder), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(XmlWriter)}, ReturnType = typeof(void))]
	public override void WriteBinHex(Byte[] buffer, int index, int count) { }

	public abstract void WriteCData(string text) { }

	public abstract void WriteCharEntity(char ch) { }

	public abstract void WriteChars(Char[] buffer, int index, int count) { }

	public abstract void WriteComment(string text) { }

	public abstract void WriteDocType(string name, string pubid, string sysid, string subset) { }

	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteElementString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void WriteElementString(string localName, string ns, string value) { }

	public abstract void WriteEndAttribute() { }

	public abstract void WriteEndDocument() { }

	public abstract void WriteEndElement() { }

	public abstract void WriteEntityRef(string name) { }

	public abstract void WriteFullEndElement() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsInvalidInstructions]
	public override void WriteNode(XmlReader reader, bool defattr) { }

	public abstract void WriteProcessingInstruction(string name, string text) { }

	public abstract void WriteRaw(Char[] buffer, int index, int count) { }

	public abstract void WriteRaw(string data) { }

	public abstract void WriteStartAttribute(string prefix, string localName, string ns) { }

	public abstract void WriteStartDocument() { }

	public abstract void WriteStartDocument(bool standalone) { }

	[CalledBy(Type = "Mono.Nat.Upnp.CreatePortMappingMessage", Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Nat.Upnp.DeletePortMappingMessage", Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Nat.Upnp.GetGenericPortMappingEntry", Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Nat.Upnp.GetSpecificPortMappingEntryMessage", Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Nat.Upnp.RequestMessage", Member = "WriteFullElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(string), typeof(IPAddress)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Nat.Upnp.RequestMessage", Member = "WriteFullElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(string), "Mono.Nat.Protocol"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Nat.Upnp.RequestMessage", Member = "WriteFullElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Nat.Upnp.RequestMessage", Member = "WriteFullElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void WriteStartElement(string localName) { }

	public abstract void WriteStartElement(string prefix, string localName, string ns) { }

	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteElementEncoded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(string), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteElementLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(string), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteNullTagEncoded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteReferencingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteSerializable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IXmlSerializable), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteSerializable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IXmlSerializable), typeof(string), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(bool), typeof(ICollection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteTypedPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(object), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void WriteStartElement(string localName, string ns) { }

	public abstract void WriteString(string text) { }

	public abstract void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void WriteValue(string value) { }

	public abstract void WriteWhitespace(string ws) { }

}

