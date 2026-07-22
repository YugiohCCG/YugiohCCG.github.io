namespace MS.Internal.Xml.Cache;

internal sealed class XPathNodeInfoAtom
{
	private string _localName; //Field offset: 0x10
	private string _namespaceUri; //Field offset: 0x18
	private string _prefix; //Field offset: 0x20
	private string _baseUri; //Field offset: 0x28
	private XPathNode[] _pageParent; //Field offset: 0x30
	private XPathNode[] _pageSibling; //Field offset: 0x38
	private XPathNode[] _pageSimilar; //Field offset: 0x40
	private XPathDocument _doc; //Field offset: 0x48
	private int _lineNumBase; //Field offset: 0x50
	private int _linePosBase; //Field offset: 0x54
	private XPathNodePageInfo _pageInfo; //Field offset: 0x58

	public string BaseUri
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public XPathDocument Document
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 254
	}

	public int LineNumberBase
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int LinePositionBase
	{
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public string LocalName
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string NamespaceUri
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public XPathNodePageInfo PageInfo
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public XPathNode[] ParentPage
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string Prefix
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public XPathNode[] SiblingPage
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public XPathNode[] SimilarElementPage
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public string get_BaseUri() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public XPathDocument get_Document() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public int get_LineNumberBase() { }

	[CallerCount(Count = 14)]
	[DeduplicatedMethod]
	public int get_LinePositionBase() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public string get_LocalName() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public string get_NamespaceUri() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public XPathNodePageInfo get_PageInfo() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public XPathNode[] get_ParentPage() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public string get_Prefix() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public XPathNode[] get_SiblingPage() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public XPathNode[] get_SimilarElementPage() { }

}

