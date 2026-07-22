namespace MS.Internal.Xml.Cache;

internal class XPathDocumentElementDescendantIterator : XPathDocumentBaseIterator
{
	private XPathDocumentNavigator _end; //Field offset: 0x28
	private string _localName; //Field offset: 0x30
	private string _namespaceUri; //Field offset: 0x38
	private bool _matchSelf; //Field offset: 0x40

	[CalledBy(Type = typeof(XPathDocumentNavigator), Member = "SelectDescendants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(XPathNodeIterator))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XPathDocumentNavigator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]), typeof(int), typeof(XPathNode[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XPathNavigator), Member = "MoveToNonDescendant", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	public XPathDocumentElementDescendantIterator(XPathDocumentNavigator root, string name, string namespaceURI, bool matchSelf) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathDocumentBaseIterator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathDocumentBaseIterator)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public XPathDocumentElementDescendantIterator(XPathDocumentElementDescendantIterator iter) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathDocumentBaseIterator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathDocumentBaseIterator)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual XPathNodeIterator Clone() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public virtual bool MoveNext() { }

}

