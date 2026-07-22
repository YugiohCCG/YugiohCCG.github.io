namespace System.Xml;

internal class XmlNodeListEnumerator : IEnumerator
{
	private XPathNodeList list; //Field offset: 0x10
	private int index; //Field offset: 0x18
	private bool valid; //Field offset: 0x1C

	public override object Current
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 58
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public XmlNodeListEnumerator(XPathNodeList list) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override object get_Current() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathNodeList), Member = "ReadUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool MoveNext() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override void Reset() { }

}

