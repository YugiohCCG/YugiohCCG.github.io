namespace MS.Internal.Xml.Cache;

internal class XPathDocumentKindDescendantIterator : XPathDocumentBaseIterator
{
	private XPathDocumentNavigator _end; //Field offset: 0x28
	private XPathNodeType _typ; //Field offset: 0x30
	private bool _matchSelf; //Field offset: 0x34

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathDocumentNavigator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]), typeof(int), typeof(XPathNode[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XPathNavigator), Member = "MoveToNonDescendant", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public XPathDocumentKindDescendantIterator(XPathDocumentNavigator root, XPathNodeType typ, bool matchSelf) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathDocumentBaseIterator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathDocumentBaseIterator)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public XPathDocumentKindDescendantIterator(XPathDocumentKindDescendantIterator iter) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathDocumentBaseIterator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathDocumentBaseIterator)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public virtual XPathNodeIterator Clone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathNavigator), Member = "GetKindMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual bool MoveNext() { }

}

