namespace System.Xml.XPath;

[DebuggerDisplay("{debuggerDisplayProxy}")]
public abstract class XPathNavigator : XPathItem, ICloneable, IXPathNavigable, IXmlNamespaceResolver
{
	internal static readonly XPathNavigatorKeyComparer comparer; //Field offset: 0x0
	internal static readonly Char[] NodeTypeLetter; //Field offset: 0x8
	internal static readonly Char[] UniqueIdTbl; //Field offset: 0x10
	internal static readonly Int32[] ContentKindMasks; //Field offset: 0x18

	public abstract string BaseURI
	{
		 get { } //Length: 0
	}

	public abstract string LocalName
	{
		 get { } //Length: 0
	}

	public abstract string Name
	{
		 get { } //Length: 0
	}

	public abstract string NamespaceURI
	{
		 get { } //Length: 0
	}

	public abstract XmlNameTable NameTable
	{
		 get { } //Length: 0
	}

	public abstract XPathNodeType NodeType
	{
		 get { } //Length: 0
	}

	public abstract string Prefix
	{
		 get { } //Length: 0
	}

	public override IXmlSchemaInfo SchemaInfo
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 57
	}

	public virtual object TypedValue
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 8)]
		 get { } //Length: 472
	}

	public override object UnderlyingObject
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual bool ValueAsBoolean
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 6)]
		 get { } //Length: 465
	}

	public virtual DateTime ValueAsDateTime
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 6)]
		 get { } //Length: 465
	}

	public virtual double ValueAsDouble
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 6)]
		 get { } //Length: 465
	}

	public virtual int ValueAsInt
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 6)]
		 get { } //Length: 465
	}

	public virtual long ValueAsLong
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 6)]
		 get { } //Length: 465
	}

	public virtual Type ValueType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 213
	}

	public override string XmlLang
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 188
	}

	public virtual XmlSchemaType XmlType
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 144
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static XPathNavigator() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected XPathNavigator() { }

	public abstract XPathNavigator Clone() { }

	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "ComparePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNavigator)}, ReturnType = typeof(XmlNodeOrder))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 27)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override XmlNodeOrder ComparePosition(XPathNavigator nav) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private XmlNodeOrder CompareSiblings(XPathNavigator n1, XPathNavigator n2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryBuilder), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Boolean&)}, ReturnType = typeof(Query))]
	[Calls(Type = typeof(CompiledXpathExpr), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override XPathExpression Compile(string xpath) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override XPathNavigator CreateNavigator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CompiledXpathExpr), Member = "get_QueryTree", ReturnType = typeof(Query))]
	[Calls(Type = typeof(Query), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query)}, ReturnType = typeof(Query))]
	[Calls(Type = typeof(XPathSingletonIterator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNavigator), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XPathSelectionIterator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNavigator), typeof(Query)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XPathException))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public override object Evaluate(XPathExpression expr, XPathNodeIterator context) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override object Evaluate(XPathExpression expr) { }

	public abstract string get_BaseURI() { }

	public abstract string get_LocalName() { }

	public abstract string get_Name() { }

	public abstract string get_NamespaceURI() { }

	public abstract XmlNameTable get_NameTable() { }

	public abstract XPathNodeType get_NodeType() { }

	public abstract string get_Prefix() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override IXmlSchemaInfo get_SchemaInfo() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	public virtual object get_TypedValue() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override object get_UnderlyingObject() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 6)]
	public virtual bool get_ValueAsBoolean() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 6)]
	public virtual DateTime get_ValueAsDateTime() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 6)]
	public virtual double get_ValueAsDouble() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 6)]
	public virtual int get_ValueAsInt() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 6)]
	public virtual long get_ValueAsLong() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public virtual Type get_ValueType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public override string get_XmlLang() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public virtual XmlSchemaType get_XmlType() { }

	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "MoveToChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "MoveToFollowing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType), typeof(XPathNavigator)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "MoveToNext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XPathNavigator), Member = "MoveToChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XPathDocumentNavigator), Member = "MoveToChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XPathDocumentNavigator), Member = "MoveToNext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XPathNodeHelper), Member = "GetContentChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]&), typeof(Int32&), typeof(XPathNodeType)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XPathNodeHelper), Member = "GetContentSibling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]&), typeof(Int32&), typeof(XPathNodeType)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XPathNodeHelper), Member = "GetContentFollowing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]&), typeof(Int32&), typeof(XPathNode[]), typeof(int), typeof(XPathNodeType)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 2)]
	internal static int GetContentKindMask(XPathNodeType type) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static int GetDepth(XPathNavigator nav) { }

	[CalledBy(Type = typeof(XPathDocumentKindDescendantIterator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XPathDocumentNavigator), Member = "IsKindMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	internal static int GetKindMask(XPathNodeType type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	public override IDictionary<String, String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public override bool IsDescendant(XPathNavigator nav) { }

	public abstract bool IsSamePosition(XPathNavigator other) { }

	[CalledBy(Type = typeof(XPathNode), Member = "get_IsText", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XPathNodeHelper), Member = "GetTextFollowing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]&), typeof(Int32&), typeof(XPathNode[]), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	internal static bool IsText(XPathNodeType type) { }

	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "LookupNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	public override string LookupNamespace(string prefix) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 1)]
	public override string LookupPrefix(string namespaceURI) { }

	public abstract bool MoveTo(XPathNavigator other) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	public override bool MoveToAttribute(string localName, string namespaceURI) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	public override bool MoveToChild(string localName, string namespaceURI) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathNavigator), Member = "GetContentKindMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public override bool MoveToChild(XPathNodeType type) { }

	public abstract bool MoveToFirstAttribute() { }

	public abstract bool MoveToFirstChild() { }

	public abstract bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope) { }

	[CalledBy(Type = typeof(NamespaceQuery), Member = "Advance", ReturnType = typeof(XPathNavigator))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool MoveToFirstNamespace() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathNavigator), Member = "MoveToNonDescendant", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 1)]
	public override bool MoveToFollowing(string localName, string namespaceURI, XPathNavigator end) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathNavigator), Member = "MoveToNonDescendant", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public override bool MoveToFollowing(XPathNodeType type, XPathNavigator end) { }

	public abstract bool MoveToId(string id) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public override bool MoveToNamespace(string name) { }

	public abstract bool MoveToNext() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	public override bool MoveToNext(string localName, string namespaceURI) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public override bool MoveToNext(XPathNodeType type) { }

	public abstract bool MoveToNextAttribute() { }

	[CalledBy(Type = typeof(NamespaceQuery), Member = "Advance", ReturnType = typeof(XPathNavigator))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool MoveToNextNamespace() { }

	public abstract bool MoveToNextNamespace(XPathNamespaceScope namespaceScope) { }

	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "MoveToFollowing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XPathNavigator)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "MoveToFollowing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType), typeof(XPathNavigator)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XPathNavigator), Member = "MoveToFollowing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XPathNavigator)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XPathNavigator), Member = "MoveToFollowing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType), typeof(XPathNavigator)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XPathDocumentElementDescendantIterator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathDocumentNavigator), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XPathDocumentKindDescendantIterator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathDocumentNavigator), typeof(XPathNodeType), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XPathDocumentNavigator), Member = "SelectDescendants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType), typeof(bool)}, ReturnType = typeof(XPathNodeIterator))]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	internal bool MoveToNonDescendant() { }

	public abstract bool MoveToParent() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void MoveToRoot() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XPathException))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public override XPathNodeIterator Select(XPathExpression expr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathChildIterator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNavigator), typeof(XPathNodeType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override XPathNodeIterator SelectChildren(XPathNodeType type) { }

	[CalledBy(Type = typeof(XPathDocumentNavigator), Member = "SelectChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XPathNodeIterator))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XPathChildIterator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNavigator), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override XPathNodeIterator SelectChildren(string name, string namespaceURI) { }

	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "SelectDescendants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType), typeof(bool)}, ReturnType = typeof(XPathNodeIterator))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override XPathNodeIterator SelectDescendants(XPathNodeType type, bool matchSelf) { }

	[CalledBy(Type = typeof(XPathDocumentNavigator), Member = "SelectDescendants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(XPathNodeIterator))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override XPathNodeIterator SelectDescendants(string name, string namespaceURI, bool matchSelf) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private override object System.ICloneable.Clone() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	public virtual object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver) { }

}

