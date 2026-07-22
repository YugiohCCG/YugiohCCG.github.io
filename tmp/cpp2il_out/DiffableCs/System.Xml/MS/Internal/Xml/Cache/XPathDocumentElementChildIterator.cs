namespace MS.Internal.Xml.Cache;

internal class XPathDocumentElementChildIterator : XPathDocumentBaseIterator
{
	private string _localName; //Field offset: 0x28
	private string _namespaceUri; //Field offset: 0x30

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathDocumentNavigator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]), typeof(int), typeof(XPathNode[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public XPathDocumentElementChildIterator(XPathDocumentNavigator parent, string name, string namespaceURI) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathDocumentBaseIterator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathDocumentBaseIterator)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public XPathDocumentElementChildIterator(XPathDocumentElementChildIterator iter) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathDocumentBaseIterator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathDocumentBaseIterator)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual XPathNodeIterator Clone() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool MoveNext() { }

}

