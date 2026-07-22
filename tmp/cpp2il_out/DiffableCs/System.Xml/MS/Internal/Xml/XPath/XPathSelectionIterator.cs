namespace MS.Internal.Xml.XPath;

internal class XPathSelectionIterator : ResetableIterator
{
	private XPathNavigator _nav; //Field offset: 0x18
	private Query _query; //Field offset: 0x20
	private int _position; //Field offset: 0x28

	public virtual int Count
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public virtual XPathNavigator Current
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual int CurrentPosition
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = typeof(XPathNavigator), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathExpression), typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(FunctionQuery), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal XPathSelectionIterator(XPathNavigator nav, Query query) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	protected XPathSelectionIterator(XPathSelectionIterator it) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public virtual XPathNodeIterator Clone() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int get_Count() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public virtual XPathNavigator get_Current() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public virtual int get_CurrentPosition() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public virtual bool MoveNext() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void Reset() { }

}

