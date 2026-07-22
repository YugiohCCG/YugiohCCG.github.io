namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
internal class XmlElementWrapper : XmlNodeWrapper, IXmlElement, IXmlNode
{
	private readonly XmlElement _element; //Field offset: 0x28

	public override bool IsEmpty
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlElement), Member = "get_IsEmpty", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 29
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public XmlElementWrapper(XmlElement element) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlElement), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public override bool get_IsEmpty() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override string GetPrefixOfNamespace(string namespaceUri) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public override void SetAttributeNode(IXmlNode attribute) { }

}

