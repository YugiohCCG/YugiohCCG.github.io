namespace MS.Internal.Xml.Cache;

internal struct XPathNode
{
	private XPathNodeInfoAtom _info; //Field offset: 0x0
	private ushort _idxSibling; //Field offset: 0x8
	private ushort _idxParent; //Field offset: 0xA
	private ushort _idxSimilar; //Field offset: 0xC
	private ushort _posOffset; //Field offset: 0xE
	private uint _props; //Field offset: 0x10
	private string _value; //Field offset: 0x18

	public string BaseUri
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 26
	}

	public int CollapsedLinePosition
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 37
	}

	public XPathDocument Document
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 26
	}

	public bool HasAttribute
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 8
	}

	public bool HasCollapsedText
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
	}

	public bool HasContentChild
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 8
	}

	public bool HasElementChild
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 8
	}

	public bool HasNamespaceDecls
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
	}

	public bool HasSibling
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 9
	}

	public bool IsAttrNmsp
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 21
	}

	public bool IsText
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XPathNavigator), Member = "IsText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType)}, ReturnType = typeof(bool))]
		 get { } //Length: 78
	}

	public bool IsXmlNamespaceNode
	{
		[CalledBy(Type = typeof(XPathDocumentNavigator), Member = "MoveToFirstNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNamespaceScope)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 103
	}

	public int LineNumber
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 36
	}

	public int LinePosition
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 29
	}

	public string LocalName
	{
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 26
	}

	public string Name
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 103
	}

	public string NamespaceUri
	{
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 26
	}

	public XPathNodeType NodeType
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
	}

	public XPathNodePageInfo PageInfo
	{
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 26
	}

	public string Prefix
	{
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 26
	}

	public string Value
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool ElementMatch(string localName, string namespaceName) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public string get_BaseUri() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int get_CollapsedLinePosition() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public XPathDocument get_Document() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_HasAttribute() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_HasCollapsedText() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_HasContentChild() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_HasElementChild() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_HasNamespaceDecls() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_HasSibling() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_IsAttrNmsp() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathNavigator), Member = "IsText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType)}, ReturnType = typeof(bool))]
	public bool get_IsText() { }

	[CalledBy(Type = typeof(XPathDocumentNavigator), Member = "MoveToFirstNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNamespaceScope)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool get_IsXmlNamespaceNode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int get_LineNumber() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int get_LinePosition() { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public string get_LocalName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public string get_Name() { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public string get_NamespaceUri() { }

	[CallerCount(Count = 0)]
	public XPathNodeType get_NodeType() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public XPathNodePageInfo get_PageInfo() { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public string get_Prefix() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public string get_Value() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public int GetParent(out XPathNode[] pageNode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathDocument), Member = "GetRootNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]&)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public int GetRoot(out XPathNode[] pageNode) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public int GetSibling(out XPathNode[] pageNode) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public int GetSimilarElement(out XPathNode[] pageNode) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool NameMatch(string localName, string namespaceName) { }

}

