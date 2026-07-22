namespace System.Xml;

public abstract class XmlCharacterData : XmlLinkedNode
{
	private string data; //Field offset: 0x20

	public override string Data
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 30
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 190
	}

	public virtual string InnerText
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 17
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 17
	}

	public virtual string Value
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 17
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 17
	}

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XmlLinkedNode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected private XmlCharacterData(string data, XmlDocument doc) { }

	[CalledBy(Type = typeof(XmlSignificantWhitespace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlDocument)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSignificantWhitespace), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlWhitespace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlDocument)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlWhitespace), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
	[Calls(Type = typeof(XmlCharType), Member = "IsOnlyWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	internal bool CheckOnData(string data) { }

	[CalledBy(Type = typeof(XmlCharacterData), Member = "DecideXPNodeTypeForTextNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XPathNodeType&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSignificantWhitespace), Member = "get_XPNodeType", ReturnType = typeof(XPathNodeType))]
	[CalledBy(Type = typeof(XmlWhitespace), Member = "get_XPNodeType", ReturnType = typeof(XPathNodeType))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlCharacterData), Member = "DecideXPNodeTypeForTextNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XPathNodeType&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	internal bool DecideXPNodeTypeForTextNodes(XmlNode node, ref XPathNodeType xnt) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override string get_Data() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string get_InnerText() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string get_Value() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public override void set_Data(string value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void set_InnerText(string value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void set_Value(string value) { }

}

