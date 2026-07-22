namespace System.Xml;

internal class XPathNodeList : XmlNodeList
{
	private static readonly Object[] nullparams; //Field offset: 0x0
	private List<XmlNode> list; //Field offset: 0x10
	private XPathNodeIterator nodeIterator; //Field offset: 0x18
	private bool done; //Field offset: 0x20

	public virtual int Count
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XPathNodeList), Member = "ReadUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 82
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static XPathNodeList() { }

	[CalledBy(Type = typeof(XmlNode), Member = "SelectSingleNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNamespaceManager)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlNode), Member = "SelectNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNamespaceManager)}, ReturnType = typeof(XmlNodeList))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public XPathNodeList(XPathNodeIterator nodeIterator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathNodeList), Member = "ReadUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public virtual int get_Count() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual IEnumerator GetEnumerator() { }

	[CalledBy(Type = typeof(XPathNodeList), Member = "ReadUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private XmlNode GetNode(XPathNavigator n) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathNodeList), Member = "ReadUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual XmlNode Item(int index) { }

	[CalledBy(Type = typeof(XPathNodeList), Member = "get_Count", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XPathNodeList), Member = "Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlNodeListEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XPathNodeList), Member = "GetNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNavigator)}, ReturnType = typeof(XmlNode))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal int ReadUntil(int index) { }

}

