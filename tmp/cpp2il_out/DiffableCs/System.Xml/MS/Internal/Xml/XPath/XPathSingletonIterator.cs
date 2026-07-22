namespace MS.Internal.Xml.XPath;

internal class XPathSingletonIterator : ResetableIterator
{
	private XPathNavigator _nav; //Field offset: 0x18
	private int _position; //Field offset: 0x20

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
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 19)]
	public XPathSingletonIterator(XPathNavigator nav) { }

	[CalledBy(Type = typeof(XPathNavigator), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathExpression), typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public XPathSingletonIterator(XPathNavigator nav, bool moved) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public XPathSingletonIterator(XPathSingletonIterator it) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public virtual XPathNodeIterator Clone() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public virtual int get_Count() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public virtual XPathNavigator get_Current() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public virtual int get_CurrentPosition() { }

	[CallerCount(Count = 0)]
	public virtual bool MoveNext() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public virtual void Reset() { }

}

