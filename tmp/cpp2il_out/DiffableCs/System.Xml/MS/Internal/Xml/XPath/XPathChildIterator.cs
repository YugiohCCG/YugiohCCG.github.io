namespace MS.Internal.Xml.XPath;

internal class XPathChildIterator : XPathAxisIterator
{

	[CalledBy(Type = typeof(XPathNavigator), Member = "SelectChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType)}, ReturnType = typeof(XPathNodeIterator))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public XPathChildIterator(XPathNavigator nav, XPathNodeType type) { }

	[CalledBy(Type = typeof(XPathNavigator), Member = "SelectChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XPathNodeIterator))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public XPathChildIterator(XPathNavigator nav, string name, string namespaceURI) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public XPathChildIterator(XPathChildIterator it) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public virtual XPathNodeIterator Clone() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool MoveNext() { }

}

