namespace MS.Internal.Xml.XPath;

internal abstract class CacheAxisQuery : BaseAxisQuery
{
	protected List<XPathNavigator> outputBuffer; //Field offset: 0x58

	public virtual int Count
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 60
	}

	public virtual XPathNavigator Current
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 87
	}

	public virtual int CurrentPosition
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public virtual QueryProps Properties
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CalledBy(Type = typeof(ParentQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query), typeof(string), typeof(string), typeof(XPathNodeType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PreSiblingQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query), typeof(string), typeof(string), typeof(XPathNodeType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(QueryBuilder), Member = "ProcessAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Axis), "MS.Internal.Xml.XPath.QueryBuilder+Flags", typeof(Props&)}, ReturnType = typeof(Query))]
	[CalledBy(Type = typeof(XPathAncestorQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query), typeof(string), typeof(string), typeof(XPathNodeType), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	public CacheAxisQuery(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	[CalledBy(Type = typeof(ParentQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParentQuery)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParentQuery), Member = "Clone", ReturnType = typeof(XPathNodeIterator))]
	[CalledBy(Type = typeof(PreSiblingQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PreSiblingQuery)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PreSiblingQuery), Member = "Clone", ReturnType = typeof(XPathNodeIterator))]
	[CalledBy(Type = typeof(XPathAncestorQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathAncestorQuery)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XPathAncestorQuery), Member = "Clone", ReturnType = typeof(XPathNodeIterator))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Query), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query)}, ReturnType = typeof(Query))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	protected CacheAxisQuery(CacheAxisQuery other) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual XPathNavigator Advance() { }

	[CalledBy(Type = typeof(ParentQuery), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(PreSiblingQuery), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XPathAncestorQuery), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual object Evaluate(XPathNodeIterator context) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int get_Count() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual XPathNavigator get_Current() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public virtual int get_CurrentPosition() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public virtual QueryProps get_Properties() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual void Reset() { }

}

