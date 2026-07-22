namespace MS.Internal.Xml.XPath;

internal sealed class EmptyQuery : Query
{

	public virtual int Count
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual XPathNavigator Current
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual int CurrentPosition
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
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

	[CalledBy(Type = typeof(QueryBuilder), Member = "ProcessAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Axis), "MS.Internal.Xml.XPath.QueryBuilder+Flags", typeof(Props&)}, ReturnType = typeof(Query))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public EmptyQuery() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual XPathNavigator Advance() { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public virtual XPathNodeIterator Clone() { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public virtual object Evaluate(XPathNodeIterator context) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual int get_Count() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual XPathNavigator get_Current() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual int get_CurrentPosition() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public virtual QueryProps get_Properties() { }

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public virtual XPathResultType get_StaticType() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void Reset() { }

}

