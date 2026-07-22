namespace System.Xml;

internal sealed class XmlNameEx : XmlName
{
	private byte flags; //Field offset: 0x48
	private XmlSchemaSimpleType memberType; //Field offset: 0x50
	private XmlSchemaType schemaType; //Field offset: 0x58
	private object decl; //Field offset: 0x60

	public virtual bool IsDefault
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 8
	}

	public virtual bool IsNil
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 8
	}

	public virtual XmlSchemaSimpleType MemberType
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual XmlSchemaAttribute SchemaAttribute
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 114
	}

	public virtual XmlSchemaElement SchemaElement
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 114
	}

	public virtual XmlSchemaType SchemaType
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual XmlSchemaValidity Validity
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 43
	}

	[CalledBy(Type = typeof(XmlName), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(XmlDocument), typeof(XmlName), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(XmlDocument), typeof(XmlName)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	internal XmlNameEx(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(IXmlSchemaInfo schemaInfo) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public virtual bool get_IsDefault() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public virtual bool get_IsNil() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public virtual XmlSchemaSimpleType get_MemberType() { }

	[CallerCount(Count = 0)]
	public virtual XmlSchemaAttribute get_SchemaAttribute() { }

	[CallerCount(Count = 0)]
	public virtual XmlSchemaElement get_SchemaElement() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public virtual XmlSchemaType get_SchemaType() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual XmlSchemaValidity get_Validity() { }

	[CallerCount(Count = 0)]
	public void SetIsDefault(bool value) { }

	[CallerCount(Count = 0)]
	public void SetIsNil(bool value) { }

	[CallerCount(Count = 0)]
	public void SetValidity(XmlSchemaValidity value) { }

}

