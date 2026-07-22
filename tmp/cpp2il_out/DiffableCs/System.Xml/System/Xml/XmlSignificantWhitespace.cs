namespace System.Xml;

public class XmlSignificantWhitespace : XmlCharacterData
{

	internal virtual bool IsText
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	public virtual string LocalName
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 42
	}

	public virtual string Name
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 42
	}

	public virtual XmlNodeType NodeType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public virtual XmlNode ParentNode
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlNode), Member = "get_ParentNode", ReturnType = typeof(XmlNode))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 146
	}

	public virtual XmlNode PreviousText
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 61
	}

	public virtual string Value
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 17
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlCharacterData), Member = "CheckOnData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 146
	}

	internal virtual XPathNodeType XPNodeType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlCharacterData), Member = "DecideXPNodeTypeForTextNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XPathNodeType&)}, ReturnType = typeof(bool))]
		internal get { } //Length: 37
	}

	[CalledBy(Type = typeof(XmlDocument), Member = "CreateSignificantWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlSignificantWhitespace))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlCharacterData), Member = "CheckOnData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	protected private XmlSignificantWhitespace(string strData, XmlDocument doc) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual XmlNode CloneNode(bool deep) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	internal virtual bool get_IsText() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string get_LocalName() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string get_Name() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual XmlNodeType get_NodeType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNode), Member = "get_ParentNode", ReturnType = typeof(XmlNode))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual XmlNode get_ParentNode() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual XmlNode get_PreviousText() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string get_Value() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlCharacterData), Member = "DecideXPNodeTypeForTextNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XPathNodeType&)}, ReturnType = typeof(bool))]
	internal virtual XPathNodeType get_XPNodeType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlCharacterData), Member = "CheckOnData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public virtual void set_Value(string value) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void WriteContentTo(XmlWriter w) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void WriteTo(XmlWriter w) { }

}

