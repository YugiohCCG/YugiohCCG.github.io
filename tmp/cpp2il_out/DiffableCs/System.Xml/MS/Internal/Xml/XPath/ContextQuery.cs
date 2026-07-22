namespace MS.Internal.Xml.XPath;

internal class ContextQuery : Query
{
	protected XPathNavigator contextNode; //Field offset: 0x18

	public virtual int Count
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public virtual XPathNavigator Current
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
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

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ContextQuery() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	protected ContextQuery(ContextQuery other) { }

	[CallerCount(Count = 0)]
	public virtual XPathNavigator Advance() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual XPathNodeIterator Clone() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual object Evaluate(XPathNodeIterator context) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public virtual int get_Count() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
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

}

