namespace MS.Internal.Xml.XPath;

internal class IteratorFilter : XPathNodeIterator
{
	private XPathNodeIterator _innerIterator; //Field offset: 0x18
	private string _name; //Field offset: 0x20
	private int _position; //Field offset: 0x28

	public virtual XPathNavigator Current
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public virtual int CurrentPosition
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = typeof(ChildrenQuery), Member = "Advance", ReturnType = typeof(XPathNavigator))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal IteratorFilter(XPathNodeIterator innerIterator, string name) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private IteratorFilter(IteratorFilter it) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public virtual XPathNodeIterator Clone() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual XPathNavigator get_Current() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public virtual int get_CurrentPosition() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool MoveNext() { }

}

