namespace MS.Internal.Xml.Cache;

internal sealed class XPathNodePageInfo
{
	private int _pageNum; //Field offset: 0x10
	private int _nodeCount; //Field offset: 0x14
	private XPathNode[] _pageNext; //Field offset: 0x18

	public XPathNode[] NextPage
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public int NodeCount
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int PageNumber
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public XPathNode[] get_NextPage() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public int get_NodeCount() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public int get_PageNumber() { }

}

