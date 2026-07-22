namespace MS.Internal.Xml.Cache;

internal sealed class XPathDocumentNavigator : XPathNavigator, IXmlLineInfo
{
	private XPathNode[] _pageCurrent; //Field offset: 0x10
	private XPathNode[] _pageParent; //Field offset: 0x18
	private int _idxCurrent; //Field offset: 0x20
	private int _idxParent; //Field offset: 0x24
	private string _atomizedLocalName; //Field offset: 0x28

	public virtual string BaseURI
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 237
	}

	public override int LineNumber
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 115
	}

	public override int LinePosition
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 152
	}

	public virtual string LocalName
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 56
	}

	public virtual string Name
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 147
	}

	public virtual string NamespaceURI
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 56
	}

	public virtual XmlNameTable NameTable
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 65
	}

	public virtual XPathNodeType NodeType
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 49
	}

	public virtual string Prefix
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 56
	}

	public virtual object UnderlyingObject
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 17
	}

	public virtual string Value
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XPathNodeHelper), Member = "GetTextFollowing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]&), typeof(Int32&), typeof(XPathNode[]), typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		 get { } //Length: 677
	}

	[CalledBy(Type = typeof(XPathDocumentBaseIterator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathDocumentNavigator)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XPathDocumentBaseIterator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathDocumentBaseIterator)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XPathDocumentElementChildIterator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathDocumentNavigator), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XPathDocumentKindChildIterator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathDocumentNavigator), typeof(XPathNodeType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XPathDocumentElementDescendantIterator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathDocumentNavigator), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XPathDocumentKindDescendantIterator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathDocumentNavigator), typeof(XPathNodeType), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XPathDocumentNavigator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathDocumentNavigator)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XPathDocumentNavigator), Member = "Clone", ReturnType = typeof(XPathNavigator))]
	[CalledBy(Type = typeof(XPathDocumentNavigator), Member = "SelectChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType)}, ReturnType = typeof(XPathNodeIterator))]
	[CalledBy(Type = typeof(XPathDocumentNavigator), Member = "SelectChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XPathNodeIterator))]
	[CalledBy(Type = typeof(XPathDocumentNavigator), Member = "SelectDescendants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType), typeof(bool)}, ReturnType = typeof(XPathNodeIterator))]
	[CallerCount(Count = 14)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public XPathDocumentNavigator(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageParent, int idxParent) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathDocumentNavigator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]), typeof(int), typeof(XPathNode[]), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public XPathDocumentNavigator(XPathDocumentNavigator nav) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathDocumentNavigator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]), typeof(int), typeof(XPathNode[]), typeof(int)}, ReturnType = typeof(void))]
	public virtual XPathNavigator Clone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathDocumentNavigator), Member = "GetPrimaryLocation", ReturnType = typeof(int))]
	[Calls(Type = typeof(XPathDocumentNavigator), Member = "GetSecondaryLocation", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual XmlNodeOrder ComparePosition(XPathNavigator other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public virtual string get_BaseURI() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override int get_LineNumber() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override int get_LinePosition() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual string get_LocalName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	public virtual string get_Name() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual string get_NamespaceURI() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual XmlNameTable get_NameTable() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual XPathNodeType get_NodeType() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual string get_Prefix() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual object get_UnderlyingObject() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathNodeHelper), Member = "GetTextFollowing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]&), typeof(Int32&), typeof(XPathNode[]), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public virtual string get_Value() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private int GetFollowingEnd(XPathDocumentNavigator end, bool useParentOfVirtual, out XPathNode[] pageEnd) { }

	[CalledBy(Type = typeof(XPathNavigatorKeyComparer), Member = "System.Collections.IEqualityComparer.GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	public int GetPositionHashCode() { }

	[CalledBy(Type = typeof(XPathDocumentNavigator), Member = "ComparePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNavigator)}, ReturnType = typeof(XmlNodeOrder))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private int GetPrimaryLocation() { }

	[CalledBy(Type = typeof(XPathDocumentNavigator), Member = "ComparePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNavigator)}, ReturnType = typeof(XmlNodeOrder))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private int GetSecondaryLocation() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override bool HasLineInfo() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public virtual bool IsDescendant(XPathNavigator other) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsElementMatch(string localName, string namespaceURI) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathNavigator), Member = "GetKindMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool IsKindMatch(XPathNodeType typ) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public virtual bool IsSamePosition(XPathNavigator other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual bool MoveTo(XPathNavigator other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathNodeHelper), Member = "GetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]&), typeof(Int32&), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public virtual bool MoveToAttribute(string localName, string namespaceURI) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public virtual bool MoveToChild(string localName, string namespaceURI) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathNavigator), Member = "GetContentKindMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XPathDocument), Member = "GetCollapsedTextNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]&)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	public virtual bool MoveToChild(XPathNodeType type) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public virtual bool MoveToFirstAttribute() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathDocument), Member = "GetCollapsedTextNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]&)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 8)]
	public virtual bool MoveToFirstChild() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathDocument), Member = "GetXmlNamespaceNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XPathDocument), Member = "LookupNamespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]), typeof(int), typeof(XPathNode[]&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XPathNode), Member = "get_IsXmlNamespaceNode", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 10)]
	public virtual bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathNodeHelper), Member = "GetContentFollowing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]&), typeof(Int32&), typeof(XPathNode[]), typeof(int), typeof(XPathNodeType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XPathNodeHelper), Member = "GetTextFollowing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]&), typeof(Int32&), typeof(XPathNode[]), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XPathDocument), Member = "GetCollapsedTextNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]&)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 13)]
	public virtual bool MoveToFollowing(XPathNodeType type, XPathNavigator end) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathNodeHelper), Member = "GetElementFollowing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]&), typeof(Int32&), typeof(XPathNode[]), typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public virtual bool MoveToFollowing(string localName, string namespaceURI, XPathNavigator end) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathDocument), Member = "LookupIdElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XPathNode[]&)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 4)]
	public virtual bool MoveToId(string id) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public virtual bool MoveToNext() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathNavigator), Member = "GetContentKindMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public virtual bool MoveToNext(XPathNodeType type) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public virtual bool MoveToNext(string localName, string namespaceURI) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public virtual bool MoveToNextAttribute() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public virtual bool MoveToNextNamespace(XPathNamespaceScope scope) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public virtual bool MoveToParent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathDocument), Member = "GetRootNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]&)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void MoveToRoot() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathDocumentNavigator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]), typeof(int), typeof(XPathNode[]), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public virtual XPathNodeIterator SelectChildren(XPathNodeType type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathDocumentNavigator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]), typeof(int), typeof(XPathNode[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XPathNavigator), Member = "SelectChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XPathNodeIterator))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public virtual XPathNodeIterator SelectChildren(string name, string namespaceURI) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathDocumentNavigator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]), typeof(int), typeof(XPathNode[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XPathNavigator), Member = "MoveToNonDescendant", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public virtual XPathNodeIterator SelectDescendants(XPathNodeType type, bool matchSelf) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathDocumentElementDescendantIterator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathDocumentNavigator), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XPathNavigator), Member = "SelectDescendants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(XPathNodeIterator))]
	public virtual XPathNodeIterator SelectDescendants(string name, string namespaceURI, bool matchSelf) { }

}

