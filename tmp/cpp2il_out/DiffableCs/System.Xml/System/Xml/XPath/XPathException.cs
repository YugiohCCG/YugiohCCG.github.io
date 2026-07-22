namespace System.Xml.XPath;

public class XPathException : SystemException
{
	private string res; //Field offset: 0x90
	private String[] args; //Field offset: 0x98
	private string message; //Field offset: 0xA0

	public virtual string Message
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Exception), Member = "get_Message", ReturnType = typeof(string))]
		 get { } //Length: 25
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetEnumerator", ReturnType = typeof(SerializationInfoEnumerator))]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "get_Current", ReturnType = typeof(SerializationEntry))]
	[Calls(Type = typeof(XPathException), Member = "CreateMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	protected XPathException(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathException), Member = "CreateMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public XPathException() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathException), Member = "CreateMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public XPathException(string message, Exception innerException) { }

	[CalledBy(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XPathException))]
	[CalledBy(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(XPathException))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XPathException), Member = "CreateMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private XPathException(string res, String[] args) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathException), Member = "CreateMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private XPathException(string res, String[] args, Exception inner) { }

	[CalledBy(Type = typeof(XPathNavigator), Member = "Select", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathExpression)}, ReturnType = typeof(XPathNodeIterator))]
	[CalledBy(Type = typeof(XPathScanner), Member = "ScanString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XPathScanner), Member = "NextLex", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XPathParser), Member = "ParseExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CalledBy(Type = typeof(VariableQuery), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(VariableQuery), Member = "SetXsltContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsltContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueQuery), Member = "Advance", ReturnType = typeof(XPathNavigator))]
	[CalledBy(Type = typeof(ValueQuery), Member = "get_Count", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueQuery), Member = "get_Current", ReturnType = typeof(XPathNavigator))]
	[CalledBy(Type = typeof(ValueQuery), Member = "get_CurrentPosition", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FunctionQuery), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(FunctionQuery), Member = "SetXsltContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsltContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExtensionQuery), Member = "Advance", ReturnType = typeof(XPathNavigator))]
	[CalledBy(Type = typeof(ExtensionQuery), Member = "get_Current", ReturnType = typeof(XPathNavigator))]
	[CalledBy(Type = typeof(CompiledXpathExpr), Member = "get_QueryTree", ReturnType = typeof(Query))]
	[CalledBy(Type = "MS.Internal.Xml.XPath.CompiledXpathExpr+UndefinedXsltContext", Member = "ResolveFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XPathResultType[])}, ReturnType = typeof(IXsltContextFunction))]
	[CalledBy(Type = "MS.Internal.Xml.XPath.CompiledXpathExpr+UndefinedXsltContext", Member = "ResolveVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(IXsltContextVariable))]
	[CalledBy(Type = typeof(XPathNavigator), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathExpression), typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(QueryBuilder), Member = "ProcessFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Function), typeof(Props&)}, ReturnType = typeof(Query))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XPathException), Member = "CreateMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	internal static XPathException Create(string res) { }

	[CalledBy(Type = "MS.Internal.Xml.XPath.CompiledXpathExpr+UndefinedXsltContext", Member = "LookupNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XPathScanner), Member = "NextLex", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XPathScanner), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XPathParser), Member = "GetAxis", ReturnType = typeof(AxisType))]
	[CalledBy(Type = typeof(XPathParser), Member = "CheckNodeSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathResultType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XPathParser), Member = "CheckToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LexKind)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XPathParser), Member = "ParseMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CalledBy(Type = typeof(XPathParser), Member = "ParsePrimaryExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CalledBy(Type = typeof(XPathParser), Member = "ParseStep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CalledBy(Type = typeof(XPathParser), Member = "ParseNodeTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode), typeof(AxisType), typeof(XPathNodeType)}, ReturnType = typeof(AstNode))]
	[CalledBy(Type = typeof(XPathParser), Member = "ParseUnionExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CalledBy(Type = typeof(XPathParser), Member = "ParseXPathExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(AstNode))]
	[CalledBy(Type = typeof(VariableQuery), Member = "SetXsltContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsltContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(QueryBuilder), Member = "ProcessFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Function), typeof(Props&)}, ReturnType = typeof(Query))]
	[CalledBy(Type = typeof(QueryBuilder), Member = "ProcessVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Variable)}, ReturnType = typeof(Query))]
	[CalledBy(Type = typeof(QueryBuilder), Member = "ProcessAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Axis), "MS.Internal.Xml.XPath.QueryBuilder+Flags", typeof(Props&)}, ReturnType = typeof(Query))]
	[CalledBy(Type = typeof(FunctionQuery), Member = "SetXsltContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsltContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XPathParser), Member = "ParsePredicate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CallerCount(Count = 30)]
	[Calls(Type = typeof(XPathException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal static XPathException Create(string res, string arg) { }

	[CalledBy(Type = typeof(XPathParser), Member = "ParseMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AstNode)}, ReturnType = typeof(AstNode))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XPathException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal static XPathException Create(string res, string arg, string arg2) { }

	[CalledBy(Type = typeof(FunctionQuery), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XPathException), Member = "CreateMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal static XPathException Create(string res, string arg, Exception innerException) { }

	[CalledBy(Type = typeof(XPathException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XPathException), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XPathException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XPathException))]
	[CalledBy(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Exception)}, ReturnType = typeof(XPathException))]
	[CalledBy(Type = typeof(XPathException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XPathException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(SR), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	private static string CreateMessage(string res, String[] args) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Exception), Member = "get_Message", ReturnType = typeof(string))]
	public virtual string get_Message() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Exception), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

