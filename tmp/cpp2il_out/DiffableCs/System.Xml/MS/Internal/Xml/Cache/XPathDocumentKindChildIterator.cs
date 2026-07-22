namespace MS.Internal.Xml.Cache;

internal class XPathDocumentKindChildIterator : XPathDocumentBaseIterator
{
	private XPathNodeType _typ; //Field offset: 0x28

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathDocumentNavigator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]), typeof(int), typeof(XPathNode[]), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public XPathDocumentKindChildIterator(XPathDocumentNavigator parent, XPathNodeType typ) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathDocumentBaseIterator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathDocumentBaseIterator)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public XPathDocumentKindChildIterator(XPathDocumentKindChildIterator iter) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathDocumentBaseIterator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathDocumentBaseIterator)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual XPathNodeIterator Clone() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool MoveNext() { }

}

