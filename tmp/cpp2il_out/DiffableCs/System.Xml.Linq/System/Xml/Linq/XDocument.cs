namespace System.Xml.Linq;

public class XDocument : XContainer
{
	private XDeclaration _declaration; //Field offset: 0x30

	public XDeclaration Declaration
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public virtual XmlNodeType NodeType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public XElement Root
	{
		[CalledBy(Type = "Newtonsoft.Json.Converters.XDocumentWrapper", Member = "get_DocumentElement", ReturnType = "Newtonsoft.Json.Converters.IXmlElement")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(XDocument), Member = "GetFirstNode", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		 get { } //Length: 57
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public XDocument() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XContainer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XContainer)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public XDocument(XDocument other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal virtual void AddAttribute(XAttribute a) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal virtual void AddAttributeSkipNotify(XAttribute a) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XContainer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XContainer)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal virtual XNode CloneNode() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public XDeclaration get_Declaration() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual XmlNodeType get_NodeType() { }

	[CalledBy(Type = "Newtonsoft.Json.Converters.XDocumentWrapper", Member = "get_DocumentElement", ReturnType = "Newtonsoft.Json.Converters.IXmlElement")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XDocument), Member = "GetFirstNode", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	public XElement get_Root() { }

	[CalledBy(Type = typeof(XDocument), Member = "get_Root", ReturnType = typeof(XElement))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	private T GetFirstNode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool IsWhitespace(string s) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Declaration(XDeclaration value) { }

	[CalledBy(Type = typeof(XDocument), Member = "ValidateNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNode), typeof(XNode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void ValidateDocument(XNode previous, XmlNodeType allowBefore, XmlNodeType allowAfter) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XDocument), Member = "ValidateDocument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNode), typeof(XmlNodeType), typeof(XmlNodeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	internal virtual void ValidateNode(XNode node, XNode previous) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	internal virtual void ValidateString(string s) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XContainer), Member = "WriteContentTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	public virtual void WriteTo(XmlWriter writer) { }

}

