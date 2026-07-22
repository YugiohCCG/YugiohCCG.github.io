namespace System.Xml;

public class XmlProcessingInstruction : XmlLinkedNode
{
	private string target; //Field offset: 0x20
	private string data; //Field offset: 0x28

	public string Data
	{
		[CalledBy(Type = typeof(XmlProcessingInstruction), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlProcessingInstruction), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 190
	}

	public virtual string InnerText
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlProcessingInstruction), Member = "set_Data", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	public virtual string LocalName
	{
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 17
	}

	public virtual string Name
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 30
	}

	public virtual XmlNodeType NodeType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public virtual string Value
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlProcessingInstruction), Member = "set_Data", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	internal virtual string XPLocalName
	{
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 17
	}

	internal virtual XPathNodeType XPNodeType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 6
	}

	[CalledBy(Type = typeof(XmlDocument), Member = "CreateProcessingInstruction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlProcessingInstruction))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	protected private XmlProcessingInstruction(string target, string data, XmlDocument doc) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual XmlNode CloneNode(bool deep) { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public virtual string get_InnerText() { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string get_LocalName() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual string get_Name() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual XmlNodeType get_NodeType() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public virtual string get_Value() { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual string get_XPLocalName() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal virtual XPathNodeType get_XPNodeType() { }

	[CalledBy(Type = typeof(XmlProcessingInstruction), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlProcessingInstruction), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public void set_Data(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlProcessingInstruction), Member = "set_Data", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public virtual void set_InnerText(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlProcessingInstruction), Member = "set_Data", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public virtual void set_Value(string value) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void WriteContentTo(XmlWriter w) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteTo(XmlWriter w) { }

}

