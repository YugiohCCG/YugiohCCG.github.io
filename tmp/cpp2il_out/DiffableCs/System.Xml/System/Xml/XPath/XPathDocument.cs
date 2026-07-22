namespace System.Xml.XPath;

public class XPathDocument
{
	private XPathNode[] pageText; //Field offset: 0x10
	private XPathNode[] pageRoot; //Field offset: 0x18
	private XPathNode[] pageXmlNmsp; //Field offset: 0x20
	private int idxText; //Field offset: 0x28
	private int idxRoot; //Field offset: 0x2C
	private int idxXmlNmsp; //Field offset: 0x30
	private XmlNameTable nameTable; //Field offset: 0x38
	private bool hasLineInfo; //Field offset: 0x40
	private Dictionary<XPathNodeRef, XPathNodeRef> mapNmsp; //Field offset: 0x48
	private Dictionary<String, XPathNodeRef> idValueMap; //Field offset: 0x50

	internal bool HasLineInfo
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal XmlNameTable NameTable
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	internal bool get_HasLineInfo() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	internal XmlNameTable get_NameTable() { }

	[CalledBy(Type = typeof(XPathDocumentNavigator), Member = "MoveToFirstChild", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XPathDocumentNavigator), Member = "MoveToChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XPathDocumentNavigator), Member = "MoveToFollowing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType), typeof(XPathNavigator)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	internal int GetCollapsedTextNode(out XPathNode[] pageText) { }

	[CalledBy(Type = typeof(XPathDocumentNavigator), Member = "MoveToRoot", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XPathNode), Member = "GetRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal int GetRootNode(out XPathNode[] pageRoot) { }

	[CalledBy(Type = typeof(XPathDocumentNavigator), Member = "MoveToFirstNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNamespaceScope)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XPathNodeHelper), Member = "GetInScopeNamespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]), typeof(int), typeof(XPathNode[]&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal int GetXmlNamespaceNode(out XPathNode[] pageXmlNmsp) { }

	[CalledBy(Type = typeof(XPathDocumentNavigator), Member = "MoveToId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[CallsUnknownMethods(Count = 3)]
	internal int LookupIdElement(string id, out XPathNode[] pageElem) { }

	[CalledBy(Type = typeof(XPathDocumentNavigator), Member = "MoveToFirstNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNamespaceScope)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XPathNodeHelper), Member = "GetLocalNamespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]), typeof(int), typeof(XPathNode[]&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XPathNodeHelper), Member = "GetInScopeNamespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]), typeof(int), typeof(XPathNode[]&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<MS.Internal.Xml.Cache.XPathNodeRef, MS.Internal.Xml.Cache.XPathNodeRef>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeRef)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<MS.Internal.Xml.Cache.XPathNodeRef, MS.Internal.Xml.Cache.XPathNodeRef>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeRef)}, ReturnType = typeof(XPathNodeRef))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal int LookupNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

}

