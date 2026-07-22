namespace System.Xml.Serialization;

internal class XmlTypeMapMemberExpandable : XmlTypeMapMemberElement
{
	private int _flatArrayIndex; //Field offset: 0x78

	public int FlatArrayIndex
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XmlTypeMapMember), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public XmlTypeMapMemberExpandable() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_FlatArrayIndex() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_FlatArrayIndex(int value) { }

}

