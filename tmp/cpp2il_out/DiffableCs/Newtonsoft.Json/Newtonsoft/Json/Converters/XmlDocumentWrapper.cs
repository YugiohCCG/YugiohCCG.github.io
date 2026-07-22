namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
internal class XmlDocumentWrapper : XmlNodeWrapper, IXmlDocument, IXmlNode
{
	private readonly XmlDocument _document; //Field offset: 0x28

	[Nullable(2)]
	public override IXmlElement DocumentElement
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlDocument), Member = "get_DocumentElement", ReturnType = typeof(XmlElement))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[NullableContext(2)]
		 get { } //Length: 164
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public XmlDocumentWrapper(XmlDocument document) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDocument), Member = "CreateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override IXmlNode CreateAttribute(string name, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDocument), Member = "CreateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override IXmlNode CreateCDataSection(string data) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override IXmlNode CreateComment(string data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDocument), Member = "CreateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlElement))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public override IXmlElement CreateElement(string elementName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDocument), Member = "CreateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlElement))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public override IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override IXmlNode CreateProcessingInstruction(string target, string data) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override IXmlNode CreateSignificantWhitespace(string text) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override IXmlNode CreateTextNode(string text) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override IXmlNode CreateWhitespace(string text) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public override IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[NullableContext(2)]
	public override IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDocument), Member = "get_DocumentElement", ReturnType = typeof(XmlElement))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[NullableContext(2)]
	public override IXmlElement get_DocumentElement() { }

}

