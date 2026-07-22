namespace MS.Internal.Xml.XPath;

[DebuggerDisplay("{ToString()}")]
internal abstract class Query : ResetableIterator
{

	public virtual int Count
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 200
	}

	public override QueryProps Properties
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public abstract XPathResultType StaticType
	{
		 get { } //Length: 0
	}

	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Query() { }

	[CallerCount(Count = 35)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected Query(Query other) { }

	public abstract XPathNavigator Advance() { }

	[CallerCount(Count = 42)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Query Clone(Query input) { }

	[CalledBy(Type = typeof(ChildrenQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChildrenQuery)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DescendantQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DescendantQuery)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DescendantQuery), Member = "Clone", ReturnType = typeof(XPathNodeIterator))]
	[CalledBy(Type = typeof(ExtensionQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExtensionQuery)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FollowingQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FollowingQuery)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FollowingQuery), Member = "Clone", ReturnType = typeof(XPathNodeIterator))]
	[CalledBy(Type = typeof(FunctionQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FunctionQuery)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PrecedingQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrecedingQuery)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PrecedingQuery), Member = "Clone", ReturnType = typeof(XPathNodeIterator))]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected static XPathNodeIterator Clone(XPathNodeIterator input) { }

	[CalledBy(Type = typeof(CacheChildrenQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CacheChildrenQuery)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CacheChildrenQuery), Member = "Clone", ReturnType = typeof(XPathNodeIterator))]
	[CalledBy(Type = typeof(FollSiblingQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FollSiblingQuery)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FollSiblingQuery), Member = "Clone", ReturnType = typeof(XPathNodeIterator))]
	[CalledBy(Type = typeof(FollowingQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FollowingQuery)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FollowingQuery), Member = "Clone", ReturnType = typeof(XPathNodeIterator))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected static XPathNavigator Clone(XPathNavigator input) { }

	[CalledBy(Type = typeof(CacheChildrenQuery), Member = "Advance", ReturnType = typeof(XPathNavigator))]
	[CalledBy(Type = typeof(CacheChildrenQuery), Member = "DecideNextNode", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Query), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Xml.XPath.XPathNavigator>), typeof(XPathNavigator)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UnionExpr), Member = "Advance", ReturnType = typeof(XPathNavigator))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	public static XmlNodeOrder CompareNodes(XPathNavigator l, XPathNavigator r) { }

	public abstract object Evaluate(XPathNodeIterator nodeIterator) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public virtual int get_Count() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public override QueryProps get_Properties() { }

	public abstract XPathResultType get_StaticType() { }

	[CallerCount(Count = 0)]
	private static int GetMedian(int l, int r) { }

	[CalledBy(Type = typeof(IDQuery), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(LogicalExpr), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(NumberFunctions), Member = "Number", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(double))]
	[CalledBy(Type = typeof(OperandQuery), Member = "get_StaticType", ReturnType = typeof(XPathResultType))]
	[CalledBy(Type = typeof(StringFunctions), Member = "toString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(VariableQuery), Member = "get_StaticType", ReturnType = typeof(XPathResultType))]
	[CallerCount(Count = 7)]
	protected XPathResultType GetXPathType(object value) { }

	[CalledBy(Type = typeof(DocumentOrderQuery), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(IDQuery), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(IDQuery), Member = "ProcessIds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNavigator), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MergeFilterQuery), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ParentQuery), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(PreSiblingQuery), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XPathAncestorQuery), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Query), Member = "CompareNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNavigator), typeof(XPathNavigator)}, ReturnType = typeof(XmlNodeOrder))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public static bool Insert(List<XPathNavigator> buffer, XPathNavigator nav) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool MoveNext() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void SetXsltContext(XsltContext context) { }

}

