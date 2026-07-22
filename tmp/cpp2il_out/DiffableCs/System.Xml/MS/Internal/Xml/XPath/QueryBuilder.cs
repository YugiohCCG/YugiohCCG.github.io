namespace MS.Internal.Xml.XPath;

internal sealed class QueryBuilder
{
	private enum Flags
	{
		None = 0,
		SmartDesc = 1,
		PosFilter = 2,
		Filter = 4,
	}

	private enum Props
	{
		None = 0,
		PosFilter = 1,
		HasPosition = 2,
		HasLast = 4,
		NonFlat = 8,
	}

	private string _query; //Field offset: 0x10
	private bool _allowVar; //Field offset: 0x18
	private bool _allowKey; //Field offset: 0x19
	private bool _allowCurrent; //Field offset: 0x1A
	private bool _needContext; //Field offset: 0x1B
	private BaseAxisQuery _firstInput; //Field offset: 0x20
	private int _parseDepth; //Field offset: 0x28

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public QueryBuilder() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryBuilder), Member = "ProcessNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode), typeof(Flags), typeof(Props&)}, ReturnType = typeof(Query))]
	[CallsUnknownMethods(Count = 1)]
	private Query Build(AstNode root, string query) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathParser), Member = "ParseXPathExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(AstNode))]
	[Calls(Type = typeof(QueryBuilder), Member = "ProcessNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode), typeof(Flags), typeof(Props&)}, ReturnType = typeof(Query))]
	[CallsUnknownMethods(Count = 1)]
	internal Query Build(string query, bool allowVar, bool allowKey) { }

	[CalledBy(Type = typeof(XPathExpression), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XPathExpression))]
	[CalledBy(Type = typeof(XPathExpression), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(XPathExpression))]
	[CalledBy(Type = typeof(XPathNavigator), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XPathExpression))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XPathParser), Member = "ParseXPathExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(AstNode))]
	[Calls(Type = typeof(QueryBuilder), Member = "ProcessNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode), typeof(Flags), typeof(Props&)}, ReturnType = typeof(Query))]
	[CallsUnknownMethods(Count = 1)]
	internal Query Build(string query, out bool needContext) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool CanBeNumber(Query q) { }

	[CalledBy(Type = typeof(QueryBuilder), Member = "ProcessFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Function), typeof(Props&)}, ReturnType = typeof(Query))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(QueryBuilder), Member = "ProcessNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode), typeof(Flags), typeof(Props&)}, ReturnType = typeof(Query))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private List<Query> ProcessArguments(List<AstNode> args, out Props props) { }

	[CalledBy(Type = typeof(QueryBuilder), Member = "ProcessNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode), typeof(Flags), typeof(Props&)}, ReturnType = typeof(Query))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QueryBuilder), Member = "ProcessNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode), typeof(Flags), typeof(Props&)}, ReturnType = typeof(Query))]
	[Calls(Type = typeof(CacheAxisQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query), typeof(string), typeof(string), typeof(XPathNodeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ChildrenQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query), typeof(string), typeof(string), typeof(XPathNodeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CacheChildrenQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query), typeof(string), typeof(string), typeof(XPathNodeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DescendantOverDescendantQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query), typeof(bool), typeof(string), typeof(string), typeof(XPathNodeType), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FollSiblingQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query), typeof(string), typeof(string), typeof(XPathNodeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EmptyQuery), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PrecedingQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query), typeof(string), typeof(string), typeof(XPathNodeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XPathException))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 6)]
	private Query ProcessAxis(Axis root, Flags flags, out Props props) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryBuilder), Member = "ProcessNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode), typeof(Flags), typeof(Props&)}, ReturnType = typeof(Query))]
	[Calls(Type = typeof(NodeFunctions), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FunctionType), typeof(Query)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogicalExpr), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Op), typeof(Query), typeof(Query)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BooleanExpr), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Op), typeof(Query), typeof(Query)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FilterQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query), typeof(Query), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MergeFilterQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query), typeof(Query)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 7)]
	private Query ProcessFilter(Filter root, Flags flags, out Props props) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NodeFunctions), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FunctionType), typeof(Query)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(QueryBuilder), Member = "ProcessNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode), typeof(Flags), typeof(Props&)}, ReturnType = typeof(Query))]
	[Calls(Type = typeof(QueryBuilder), Member = "ProcessArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<MS.Internal.Xml.XPath.AstNode>), typeof(Props&)}, ReturnType = typeof(System.Collections.Generic.List`1<MS.Internal.Xml.XPath.Query>))]
	[Calls(Type = typeof(FunctionQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(System.Collections.Generic.List`1<MS.Internal.Xml.XPath.Query>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XPathException))]
	[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XPathException))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 12)]
	private Query ProcessFunction(Function root, out Props props) { }

	[CalledBy(Type = typeof(QueryBuilder), Member = "ProcessAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Axis), typeof(Flags), typeof(Props&)}, ReturnType = typeof(Query))]
	[CalledBy(Type = typeof(QueryBuilder), Member = "ProcessFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Filter), typeof(Flags), typeof(Props&)}, ReturnType = typeof(Query))]
	[CalledBy(Type = typeof(QueryBuilder), Member = "ProcessOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Operator), typeof(Props&)}, ReturnType = typeof(Query))]
	[CalledBy(Type = typeof(QueryBuilder), Member = "ProcessFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Function), typeof(Props&)}, ReturnType = typeof(Query))]
	[CalledBy(Type = typeof(QueryBuilder), Member = "ProcessArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<MS.Internal.Xml.XPath.AstNode>), typeof(Props&)}, ReturnType = typeof(System.Collections.Generic.List`1<MS.Internal.Xml.XPath.Query>))]
	[CalledBy(Type = typeof(QueryBuilder), Member = "ProcessNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode), typeof(Flags), typeof(Props&)}, ReturnType = typeof(Query))]
	[CalledBy(Type = typeof(QueryBuilder), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode), typeof(string)}, ReturnType = typeof(Query))]
	[CalledBy(Type = typeof(QueryBuilder), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(Query))]
	[CalledBy(Type = typeof(QueryBuilder), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Boolean&)}, ReturnType = typeof(Query))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(QueryBuilder), Member = "ProcessAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Axis), typeof(Flags), typeof(Props&)}, ReturnType = typeof(Query))]
	[Calls(Type = typeof(QueryBuilder), Member = "ProcessNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode), typeof(Flags), typeof(Props&)}, ReturnType = typeof(Query))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	private Query ProcessNode(AstNode root, Flags flags, out Props props) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryBuilder), Member = "ProcessNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode), typeof(Flags), typeof(Props&)}, ReturnType = typeof(Query))]
	[Calls(Type = typeof(BooleanExpr), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Op), typeof(Query), typeof(Query)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogicalExpr), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Op), typeof(Query), typeof(Query)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NumericExpr), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Op), typeof(Query), typeof(Query)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private Query ProcessOperator(Operator root, out Props props) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExtensionQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XPathException))]
	[CallsUnknownMethods(Count = 4)]
	private Query ProcessVariable(Variable root) { }

	[CallerCount(Count = 0)]
	private void Reset() { }

}

