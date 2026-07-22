namespace MS.Internal.Xml.Cache;

internal abstract class XPathDocumentBaseIterator : XPathNodeIterator
{
	protected XPathDocumentNavigator ctxt; //Field offset: 0x18
	protected int pos; //Field offset: 0x20

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
	[Calls(Type = typeof(XPathDocumentNavigator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]), typeof(int), typeof(XPathNode[]), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected XPathDocumentBaseIterator(XPathDocumentNavigator ctxt) { }

	[CalledBy(Type = typeof(XPathDocumentElementChildIterator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathDocumentElementChildIterator)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XPathDocumentElementChildIterator), Member = "Clone", ReturnType = typeof(XPathNodeIterator))]
	[CalledBy(Type = typeof(XPathDocumentKindChildIterator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathDocumentKindChildIterator)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XPathDocumentKindChildIterator), Member = "Clone", ReturnType = typeof(XPathNodeIterator))]
	[CalledBy(Type = typeof(XPathDocumentElementDescendantIterator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathDocumentElementDescendantIterator)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XPathDocumentElementDescendantIterator), Member = "Clone", ReturnType = typeof(XPathNodeIterator))]
	[CalledBy(Type = typeof(XPathDocumentKindDescendantIterator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathDocumentKindDescendantIterator)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XPathDocumentKindDescendantIterator), Member = "Clone", ReturnType = typeof(XPathNodeIterator))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(XPathDocumentNavigator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]), typeof(int), typeof(XPathNode[]), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected XPathDocumentBaseIterator(XPathDocumentBaseIterator iter) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public virtual XPathNavigator get_Current() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public virtual int get_CurrentPosition() { }

}

