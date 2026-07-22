namespace MS.Internal.Xml.XPath;

internal class CompiledXpathExpr : XPathExpression
{
	private class UndefinedXsltContext : XsltContext
	{
		private IXmlNamespaceResolver _nsResolver; //Field offset: 0x50

		public virtual string DefaultNamespace
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 18
		}

		public virtual bool Whitespace
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public UndefinedXsltContext(IXmlNamespaceResolver nsResolver) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public virtual string get_DefaultNamespace() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_Whitespace() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XPathException))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		public virtual string LookupNamespace(string prefix) { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool PreserveWhitespace(XPathNavigator node) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XPathException))]
		[CallsUnknownMethods(Count = 3)]
		public virtual IXsltContextFunction ResolveFunction(string prefix, string name, XPathResultType[] ArgTypes) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XPathException))]
		[CallsUnknownMethods(Count = 3)]
		public virtual IXsltContextVariable ResolveVariable(string prefix, string name) { }

	}

	private Query _query; //Field offset: 0x10
	private string _expr; //Field offset: 0x18
	private bool _needContext; //Field offset: 0x20

	internal Query QueryTree
	{
		[CalledBy(Type = typeof(XPathNavigator), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathExpression), typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XPathException))]
		[CallsUnknownMethods(Count = 3)]
		internal get { } //Length: 77
	}

	[CalledBy(Type = typeof(XPathExpression), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XPathExpression))]
	[CalledBy(Type = typeof(XPathExpression), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(XPathExpression))]
	[CalledBy(Type = typeof(XPathNavigator), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XPathExpression))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal CompiledXpathExpr(Query query, string expression, bool needContext) { }

	[CalledBy(Type = typeof(XPathNavigator), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathExpression), typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XPathException))]
	[CallsUnknownMethods(Count = 3)]
	internal Query get_QueryTree() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void SetContext(XmlNamespaceManager nsManager) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NameTable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void SetContext(IXmlNamespaceResolver nsResolver) { }

}

