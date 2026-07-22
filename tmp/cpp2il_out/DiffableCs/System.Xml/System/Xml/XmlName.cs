namespace System.Xml;

internal class XmlName : IXmlSchemaInfo
{
	private string prefix; //Field offset: 0x10
	private string localName; //Field offset: 0x18
	private string ns; //Field offset: 0x20
	private string name; //Field offset: 0x28
	private int hashCode; //Field offset: 0x30
	internal XmlDocument ownerDoc; //Field offset: 0x38
	internal XmlName next; //Field offset: 0x40

	public int HashCode
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public override bool IsDefault
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override bool IsNil
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public string LocalName
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override XmlSchemaSimpleType MemberType
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public string Name
	{
		[CalledBy(Type = typeof(XmlAttribute), Member = "get_Name", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(XmlElement), Member = "get_Name", ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 6)]
		 get { } //Length: 407
	}

	public string NamespaceURI
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public XmlDocument OwnerDocument
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string Prefix
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override XmlSchemaAttribute SchemaAttribute
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override XmlSchemaElement SchemaElement
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override XmlSchemaType SchemaType
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override XmlSchemaValidity Validity
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CalledBy(Type = typeof(XmlName), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(XmlDocument), typeof(XmlName), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[CalledBy(Type = typeof(XmlNameEx), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(XmlDocument), typeof(XmlName), typeof(IXmlSchemaInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal XmlName(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next) { }

	[CalledBy(Type = typeof(DomNameTable), Member = "AddName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlNameEx), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(XmlDocument), typeof(XmlName), typeof(IXmlSchemaInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(XmlDocument), typeof(XmlName)}, ReturnType = typeof(void))]
	public static XmlName Create(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(IXmlSchemaInfo schemaInfo) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public int get_HashCode() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool get_IsDefault() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool get_IsNil() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public string get_LocalName() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override XmlSchemaSimpleType get_MemberType() { }

	[CalledBy(Type = typeof(XmlAttribute), Member = "get_Name", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlElement), Member = "get_Name", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public string get_Name() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public string get_NamespaceURI() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public XmlDocument get_OwnerDocument() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public string get_Prefix() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override XmlSchemaAttribute get_SchemaAttribute() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override XmlSchemaElement get_SchemaElement() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override XmlSchemaType get_SchemaType() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override XmlSchemaValidity get_Validity() { }

	[CalledBy(Type = typeof(DomNameTable), Member = "GetName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[CalledBy(Type = typeof(DomNameTable), Member = "AddName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[CalledBy(Type = typeof(XmlDocument), Member = "GetXmlName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[CalledBy(Type = typeof(XmlDocument), Member = "GetIDInfoByElement_", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlName)}, ReturnType = typeof(XmlName))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	public static int GetHashCode(string name) { }

}

