namespace MS.Internal.Xml.XPath;

internal abstract class ExtensionQuery : Query
{
	protected string prefix; //Field offset: 0x18
	protected string name; //Field offset: 0x20
	protected XsltContext xsltContext; //Field offset: 0x28
	private ResetableIterator _queryIterator; //Field offset: 0x30

	public virtual int Count
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 34
	}

	public virtual XPathNavigator Current
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XPathException))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 144
	}

	public virtual int CurrentPosition
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 31
	}

	protected string QName
	{
		[CalledBy(Type = typeof(FunctionQuery), Member = "SetXsltContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsltContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FunctionQuery), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(VariableQuery), Member = "SetXsltContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsltContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 94
	}

	public virtual XPathResultType StaticType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CalledBy(Type = typeof(QueryBuilder), Member = "ProcessVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Variable)}, ReturnType = typeof(Query))]
	[CalledBy(Type = typeof(VariableQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public ExtensionQuery(string prefix, string name) { }

	[CalledBy(Type = typeof(VariableQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VariableQuery)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VariableQuery), Member = "Clone", ReturnType = typeof(XPathNodeIterator))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Query), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(XPathNodeIterator))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	protected ExtensionQuery(ExtensionQuery other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XPathException))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public virtual XPathNavigator Advance() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual int get_Count() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XPathException))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public virtual XPathNavigator get_Current() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual int get_CurrentPosition() { }

	[CalledBy(Type = typeof(FunctionQuery), Member = "SetXsltContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsltContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FunctionQuery), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(VariableQuery), Member = "SetXsltContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsltContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	protected string get_QName() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual XPathResultType get_StaticType() { }

	[CalledBy(Type = typeof(FunctionQuery), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(VariableQuery), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XPathArrayIterator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(double))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	[ContainsUnimplementedInstructions]
	protected object ProcessResult(object value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void Reset() { }

}

