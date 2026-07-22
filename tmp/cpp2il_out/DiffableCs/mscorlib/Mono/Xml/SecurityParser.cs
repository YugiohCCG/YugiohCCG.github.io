namespace Mono.Xml;

internal class SecurityParser : SmallXmlParser, IContentHandler
{
	private SecurityElement root; //Field offset: 0x68
	private SecurityElement current; //Field offset: 0x70
	private Stack stack; //Field offset: 0x78

	[CalledBy(Type = typeof(KeyPairPersistence), Member = "Load", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(KeyPairPersistence), Member = "FromXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Stack), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	public SecurityParser() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SmallXmlParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(IContentHandler)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void LoadXml(string xml) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SecurityElement), Member = "Escape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SecurityElement), Member = "set_Text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void OnChars(string ch) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public override void OnEndElement(string name) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnEndParsing(SmallXmlParser parser) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnIgnorableWhitespace(string s) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnProcessingInstruction(string name, string text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SecurityElement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecurityElement), Member = "AddChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecurityElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecurityElement), Member = "Escape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SecurityElement), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	public override void OnStartElement(string name, IAttrList attrs) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnStartParsing(SmallXmlParser parser) { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	public SecurityElement ToXml() { }

}

