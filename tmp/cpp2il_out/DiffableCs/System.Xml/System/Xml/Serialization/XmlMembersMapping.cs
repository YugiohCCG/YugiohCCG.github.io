namespace System.Xml.Serialization;

[DefaultMember("Item")]
public class XmlMembersMapping : XmlMapping
{
	private bool _hasWrapperElement; //Field offset: 0x48
	private XmlMemberMapping[] _mapping; //Field offset: 0x50

	public int Count
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 26
	}

	internal bool HasWrapperElement
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int get_Count() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_HasWrapperElement() { }

}

