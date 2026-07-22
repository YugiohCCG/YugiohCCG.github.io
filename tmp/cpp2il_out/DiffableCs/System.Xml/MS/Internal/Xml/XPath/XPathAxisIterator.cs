namespace MS.Internal.Xml.XPath;

internal abstract class XPathAxisIterator : XPathNodeIterator
{
	internal XPathNavigator nav; //Field offset: 0x18
	internal XPathNodeType type; //Field offset: 0x20
	internal string name; //Field offset: 0x28
	internal string uri; //Field offset: 0x30
	internal int position; //Field offset: 0x38
	internal bool matchSelf; //Field offset: 0x3C
	internal bool first; //Field offset: 0x3D

	public virtual XPathNavigator Current
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual int CurrentPosition
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	protected override bool Matches
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 316
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public XPathAxisIterator(XPathNavigator nav, bool matchSelf) { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public XPathAxisIterator(XPathNavigator nav, XPathNodeType type, bool matchSelf) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	public XPathAxisIterator(XPathNavigator nav, string name, string namespaceURI, bool matchSelf) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public XPathAxisIterator(XPathAxisIterator it) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public virtual XPathNavigator get_Current() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public virtual int get_CurrentPosition() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected override bool get_Matches() { }

}

