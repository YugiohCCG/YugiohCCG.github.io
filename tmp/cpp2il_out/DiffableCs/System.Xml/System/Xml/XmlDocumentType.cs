namespace System.Xml;

public class XmlDocumentType : XmlLinkedNode
{
	private string name; //Field offset: 0x20
	private string publicId; //Field offset: 0x28
	private string systemId; //Field offset: 0x30
	private string internalSubset; //Field offset: 0x38
	private bool namespaces; //Field offset: 0x40
	private XmlNamedNodeMap entities; //Field offset: 0x48
	private XmlNamedNodeMap notations; //Field offset: 0x50
	private SchemaInfo schemaInfo; //Field offset: 0x58

	internal SchemaInfo DtdSchemaInfo
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	public XmlNamedNodeMap Entities
	{
		[CalledBy(Type = typeof(XmlDocument), Member = "GetEntityNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlEntity))]
		[CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo), typeof(XmlDocumentType)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 121
	}

	public string InternalSubset
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual bool IsReadOnly
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual string LocalName
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual string Name
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual XmlNodeType NodeType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public XmlNamedNodeMap Notations
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 121
	}

	internal bool ParseWithNamespaces
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	public string PublicId
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string SystemId
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(XmlDocument), Member = "CreateDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(XmlDocumentType))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlLoader), Member = "ParseDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocumentType), typeof(bool), typeof(XmlResolver)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	protected private XmlDocumentType(string name, string publicId, string systemId, string internalSubset, XmlDocument doc) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual XmlNode CloneNode(bool deep) { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	internal SchemaInfo get_DtdSchemaInfo() { }

	[CalledBy(Type = typeof(XmlDocument), Member = "GetEntityNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlEntity))]
	[CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo), typeof(XmlDocumentType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public XmlNamedNodeMap get_Entities() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public string get_InternalSubset() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public virtual bool get_IsReadOnly() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public virtual string get_LocalName() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public virtual string get_Name() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual XmlNodeType get_NodeType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public XmlNamedNodeMap get_Notations() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	internal bool get_ParseWithNamespaces() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public string get_PublicId() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public string get_SystemId() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_DtdSchemaInfo(SchemaInfo value) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void WriteContentTo(XmlWriter w) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteTo(XmlWriter w) { }

}

