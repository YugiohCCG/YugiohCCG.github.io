namespace System.Xml.Linq;

public class XDocumentType : XNode
{
	private string _name; //Field offset: 0x28
	private string _publicId; //Field offset: 0x30
	private string _systemId; //Field offset: 0x38
	private string _internalSubset; //Field offset: 0x40

	public string InternalSubset
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string Name
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual XmlNodeType NodeType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public string PublicId
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string SystemId
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = "Newtonsoft.Json.Converters.XDocumentWrapper", Member = "CreateXmlDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = "Newtonsoft.Json.Converters.IXmlNode")]
	[CalledBy(Type = "System.Xml.Linq.XContainer+ContentReader", Member = "ReadContentFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XContainer), typeof(XmlReader)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlConvert), Member = "VerifyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public XDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public XDocumentType(XDocumentType other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	internal virtual XNode CloneNode() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public string get_InternalSubset() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public string get_Name() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual XmlNodeType get_NodeType() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public string get_PublicId() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public string get_SystemId() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public virtual void WriteTo(XmlWriter writer) { }

}

