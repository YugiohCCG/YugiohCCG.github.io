namespace System.Xml;

public class XmlNodeChangedEventArgs : EventArgs
{
	private XmlNodeChangedAction action; //Field offset: 0x10
	private XmlNode node; //Field offset: 0x18
	private XmlNode oldParent; //Field offset: 0x20
	private XmlNode newParent; //Field offset: 0x28
	private string oldValue; //Field offset: 0x30
	private string newValue; //Field offset: 0x38

	public XmlNodeChangedAction Action
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = typeof(XmlDocument), Member = "GetEventArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode), typeof(XmlNode), typeof(string), typeof(string), typeof(XmlNodeChangedAction)}, ReturnType = typeof(XmlNodeChangedEventArgs))]
	[CalledBy(Type = typeof(XmlDocument), Member = "GetInsertEventArgsForLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNodeChangedEventArgs))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public XmlNodeChangedEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public XmlNodeChangedAction get_Action() { }

}

