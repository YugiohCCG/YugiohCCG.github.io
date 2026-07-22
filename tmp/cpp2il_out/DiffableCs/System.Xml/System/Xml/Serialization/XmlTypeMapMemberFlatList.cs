namespace System.Xml.Serialization;

internal class XmlTypeMapMemberFlatList : XmlTypeMapMemberExpandable
{
	private ListMap _listMap; //Field offset: 0x80

	public ListMap ListMap
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 16
	}

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XmlTypeMapMember), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public XmlTypeMapMemberFlatList() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ListMap get_ListMap() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_ListMap(ListMap value) { }

}

