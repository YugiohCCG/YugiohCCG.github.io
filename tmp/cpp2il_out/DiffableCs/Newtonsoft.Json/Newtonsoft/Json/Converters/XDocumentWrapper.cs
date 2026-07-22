namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
internal class XDocumentWrapper : XContainerWrapper, IXmlDocument, IXmlNode
{

	public virtual List<IXmlNode> ChildNodes
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XContainerWrapper), Member = "get_ChildNodes", ReturnType = typeof(System.Collections.Generic.List`1<Newtonsoft.Json.Converters.IXmlNode>))]
		[Calls(Type = typeof(XDocumentWrapper), Member = "get_Document", ReturnType = typeof(XDocument))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		 get { } //Length: 405
	}

	private XDocument Document
	{
		[CalledBy(Type = typeof(XDocumentWrapper), Member = "get_ChildNodes", ReturnType = typeof(System.Collections.Generic.List`1<Newtonsoft.Json.Converters.IXmlNode>))]
		[CalledBy(Type = typeof(XDocumentWrapper), Member = "get_HasChildNodes", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XDocumentWrapper), Member = "get_DocumentElement", ReturnType = typeof(IXmlElement))]
		[CalledBy(Type = typeof(XDocumentWrapper), Member = "AppendChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IXmlNode)}, ReturnType = typeof(IXmlNode))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 107
	}

	[Nullable(2)]
	public override IXmlElement DocumentElement
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XDocument), Member = "get_Root", ReturnType = typeof(XElement))]
		[Calls(Type = typeof(XDocumentWrapper), Member = "get_Document", ReturnType = typeof(XDocument))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[NullableContext(2)]
		 get { } //Length: 246
	}

	protected virtual bool HasChildNodes
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XContainer), Member = "get_LastNode", ReturnType = typeof(XNode))]
		[Calls(Type = typeof(XDocumentWrapper), Member = "get_Document", ReturnType = typeof(XDocument))]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 153
	}

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public XDocumentWrapper(XDocument document) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XDocumentWrapper), Member = "get_Document", ReturnType = typeof(XDocument))]
	[Calls(Type = typeof(XContainerWrapper), Member = "AppendChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IXmlNode)}, ReturnType = typeof(IXmlNode))]
	[CallsUnknownMethods(Count = 2)]
	public virtual IXmlNode AppendChild(IXmlNode newChild) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MiscellaneousUtils), Member = "GetLocalName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XName), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XName))]
	[Calls(Type = typeof(XAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XName), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XName), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XName))]
	[Calls(Type = typeof(XAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XName), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override IXmlNode CreateAttribute(string name, string value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override IXmlNode CreateCDataSection(string data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XComment), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override IXmlNode CreateComment(string text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MiscellaneousUtils), Member = "GetLocalName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XName), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XName))]
	[Calls(Type = typeof(XElement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XName)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XName), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XName))]
	[Calls(Type = typeof(XElement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XName)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override IXmlElement CreateElement(string elementName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XProcessingInstruction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override IXmlNode CreateProcessingInstruction(string target, string data) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override IXmlNode CreateSignificantWhitespace(string text) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override IXmlNode CreateTextNode(string text) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override IXmlNode CreateWhitespace(string text) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XDocumentType), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[NullableContext(2)]
	public override IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XContainerWrapper), Member = "get_ChildNodes", ReturnType = typeof(System.Collections.Generic.List`1<Newtonsoft.Json.Converters.IXmlNode>))]
	[Calls(Type = typeof(XDocumentWrapper), Member = "get_Document", ReturnType = typeof(XDocument))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public virtual List<IXmlNode> get_ChildNodes() { }

	[CalledBy(Type = typeof(XDocumentWrapper), Member = "get_ChildNodes", ReturnType = typeof(System.Collections.Generic.List`1<Newtonsoft.Json.Converters.IXmlNode>))]
	[CalledBy(Type = typeof(XDocumentWrapper), Member = "get_HasChildNodes", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XDocumentWrapper), Member = "get_DocumentElement", ReturnType = typeof(IXmlElement))]
	[CalledBy(Type = typeof(XDocumentWrapper), Member = "AppendChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IXmlNode)}, ReturnType = typeof(IXmlNode))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private XDocument get_Document() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XDocument), Member = "get_Root", ReturnType = typeof(XElement))]
	[Calls(Type = typeof(XDocumentWrapper), Member = "get_Document", ReturnType = typeof(XDocument))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[NullableContext(2)]
	public override IXmlElement get_DocumentElement() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XContainer), Member = "get_LastNode", ReturnType = typeof(XNode))]
	[Calls(Type = typeof(XDocumentWrapper), Member = "get_Document", ReturnType = typeof(XDocument))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	protected virtual bool get_HasChildNodes() { }

}

