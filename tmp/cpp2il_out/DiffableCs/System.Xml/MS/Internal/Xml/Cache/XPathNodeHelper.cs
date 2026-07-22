namespace MS.Internal.Xml.Cache;

internal abstract class XPathNodeHelper
{

	[CalledBy(Type = typeof(XPathDocumentNavigator), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static bool GetAttribute(ref XPathNode[] pageNode, ref int idxNode, string localName, string namespaceName) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private static void GetChild(ref XPathNode[] pageNode, ref int idxNode) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	public static bool GetContentChild(ref XPathNode[] pageNode, ref int idxNode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathNavigator), Member = "GetContentKindMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public static bool GetContentChild(ref XPathNode[] pageNode, ref int idxNode, XPathNodeType typ) { }

	[CalledBy(Type = typeof(XPathDocumentNavigator), Member = "MoveToFollowing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType), typeof(XPathNavigator)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XPathNavigator), Member = "GetContentKindMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public static bool GetContentFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd, XPathNodeType typ) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathNavigator), Member = "GetContentKindMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public static bool GetContentSibling(ref XPathNode[] pageNode, ref int idxNode, XPathNodeType typ) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public static bool GetContentSibling(ref XPathNode[] pageNode, ref int idxNode) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static bool GetElementChild(ref XPathNode[] pageNode, ref int idxNode, string localName, string namespaceName) { }

	[CalledBy(Type = typeof(XPathDocumentNavigator), Member = "MoveToFollowing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XPathNavigator)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public static bool GetElementFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd, string localName, string namespaceName) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static bool GetElementSibling(ref XPathNode[] pageNode, ref int idxNode, string localName, string namespaceName) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public static bool GetFirstAttribute(ref XPathNode[] pageNode, ref int idxNode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathDocument), Member = "GetXmlNamespaceNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XPathDocument), Member = "LookupNamespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]), typeof(int), typeof(XPathNode[]&)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 4)]
	public static int GetInScopeNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathDocument), Member = "LookupNamespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]), typeof(int), typeof(XPathNode[]&)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	public static int GetLocalNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static int GetLocation(XPathNode[] pageNode, int idxNode) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public static bool GetNextAttribute(ref XPathNode[] pageNode, ref int idxNode) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	public static bool GetNonDescendant(ref XPathNode[] pageNode, ref int idxNode) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public static bool GetParent(ref XPathNode[] pageNode, ref int idxNode) { }

	[CalledBy(Type = typeof(XPathDocumentNavigator), Member = "get_Value", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XPathDocumentNavigator), Member = "MoveToFollowing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType), typeof(XPathNavigator)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XPathNavigator), Member = "IsText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	public static bool GetTextFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd) { }

}

