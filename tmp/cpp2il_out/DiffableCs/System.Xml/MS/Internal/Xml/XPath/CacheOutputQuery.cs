namespace MS.Internal.Xml.XPath;

internal abstract class CacheOutputQuery : Query
{
	internal Query input; //Field offset: 0x18
	protected List<XPathNavigator> outputBuffer; //Field offset: 0x20

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

	public virtual XPathResultType StaticType
	{
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CalledBy(Type = typeof(DocumentOrderQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForwardPositionQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IDQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MergeFilterQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query), typeof(Query)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public CacheOutputQuery(Query input) { }

	[CalledBy(Type = typeof(DocumentOrderQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DocumentOrderQuery)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DocumentOrderQuery), Member = "Clone", ReturnType = typeof(XPathNodeIterator))]
	[CalledBy(Type = typeof(ForwardPositionQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ForwardPositionQuery)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForwardPositionQuery), Member = "Clone", ReturnType = typeof(XPathNodeIterator))]
	[CalledBy(Type = typeof(IDQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDQuery)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IDQuery), Member = "Clone", ReturnType = typeof(XPathNodeIterator))]
	[CalledBy(Type = typeof(MergeFilterQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MergeFilterQuery)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MergeFilterQuery), Member = "Clone", ReturnType = typeof(XPathNodeIterator))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Query), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query)}, ReturnType = typeof(Query))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected CacheOutputQuery(CacheOutputQuery other) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual XPathNavigator Advance() { }

	[CalledBy(Type = typeof(DocumentOrderQuery), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ForwardPositionQuery), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(IDQuery), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(MergeFilterQuery), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public virtual XPathResultType get_StaticType() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual void Reset() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void SetXsltContext(XsltContext context) { }

}

