namespace System.Xml;

public class XmlEntity : XmlNode
{
	private string publicId; //Field offset: 0x18
	private string systemId; //Field offset: 0x20
	private string notationName; //Field offset: 0x28
	private string name; //Field offset: 0x30
	private string unparsedReplacementStr; //Field offset: 0x38
	private string baseURI; //Field offset: 0x40
	private XmlLinkedNode lastChild; //Field offset: 0x48
	private bool childrenFoliating; //Field offset: 0x50

	public virtual string BaseURI
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual string InnerText
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlNode), Member = "get_InnerText", ReturnType = typeof(string))]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 95
	}

	public virtual string InnerXml
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 95
	}

	internal virtual bool IsContainer
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	public virtual bool IsReadOnly
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	internal virtual XmlLinkedNode LastNode
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(XmlLoader), Member = "ParsePartialContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(string), typeof(XmlNodeType)}, ReturnType = typeof(XmlNamespaceManager))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 248
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	public virtual string LocalName
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual string Name
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual XmlNodeType NodeType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public string SystemId
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo), typeof(XmlDocumentType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	internal XmlEntity(string name, string strdata, string publicId, string systemId, string notationName, XmlDocument doc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public virtual XmlNode CloneNode(bool deep) { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public virtual string get_BaseURI() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNode), Member = "get_InnerText", ReturnType = typeof(string))]
	[DeduplicatedMethod]
	public virtual string get_InnerText() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	internal virtual bool get_IsContainer() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public virtual bool get_IsReadOnly() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlLoader), Member = "ParsePartialContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(string), typeof(XmlNodeType)}, ReturnType = typeof(XmlNamespaceManager))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual XmlLinkedNode get_LastNode() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public virtual string get_LocalName() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public virtual string get_Name() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual XmlNodeType get_NodeType() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public string get_SystemId() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal virtual bool IsValidChildType(XmlNodeType type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public virtual void set_InnerText(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public virtual void set_InnerXml(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual void set_LastNode(XmlLinkedNode value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void SetBaseURI(string inBaseURI) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void WriteContentTo(XmlWriter w) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void WriteTo(XmlWriter w) { }

}

