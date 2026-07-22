namespace MS.Internal.Xml.XPath;

internal sealed class XPathEmptyIterator : ResetableIterator
{
	public static XPathEmptyIterator Instance; //Field offset: 0x0

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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static XPathEmptyIterator() { }

	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private XPathEmptyIterator() { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public virtual XPathNodeIterator Clone() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual int get_Count() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual XPathNavigator get_Current() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual int get_CurrentPosition() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool MoveNext() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void Reset() { }

}

