namespace MS.Internal.Xml.Cache;

internal struct XPathNodeRef
{
	private XPathNode[] _page; //Field offset: 0x0
	private int _idx; //Field offset: 0x8

	public int Index
	{
		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public XPathNode[] Page
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 19)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public XPathNodeRef(XPathNode[] page, int idx) { }

	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	public int get_Index() { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public XPathNode[] get_Page() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual int GetHashCode() { }

}

