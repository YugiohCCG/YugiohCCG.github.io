namespace System.Xml.Schema;

public class XmlSchemaInfo : IXmlSchemaInfo
{
	private bool isDefault; //Field offset: 0x10
	private bool isNil; //Field offset: 0x11
	private XmlSchemaElement schemaElement; //Field offset: 0x18
	private XmlSchemaAttribute schemaAttribute; //Field offset: 0x20
	private XmlSchemaType schemaType; //Field offset: 0x28
	private XmlSchemaSimpleType memberType; //Field offset: 0x30
	private XmlSchemaValidity validity; //Field offset: 0x38
	private XmlSchemaContentType contentType; //Field offset: 0x3C

	public XmlSchemaContentType ContentType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	internal bool HasDefaultValue
	{
		[CalledBy(Type = typeof(XsdValidatingReader), Member = "GetIsDefault", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 52
	}

	public override bool IsDefault
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 370
	}

	public override bool IsNil
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	internal bool IsUnionType
	{
		[CalledBy(Type = typeof(XsdValidatingReader), Member = "Skip", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdValidatingReader), Member = "System.Xml.Schema.IXmlSchemaInfo.get_MemberType", ReturnType = typeof(XmlSchemaSimpleType))]
		[CalledBy(Type = typeof(XsdValidatingReader), Member = "GetIsDefault", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdValidatingReader), Member = "GetMemberType", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 60
	}

	public override XmlSchemaSimpleType MemberType
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public override XmlSchemaAttribute SchemaAttribute
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlValueGetter), typeof(string), typeof(XmlSchemaInfo)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(XmlSchemaValidator), Member = "GetUnspecifiedDefaultAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 64
	}

	public override XmlSchemaElement SchemaElement
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaInfo), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaValidator), Member = "SkipToEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaValidator), Member = "InternalValidateEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaInfo), typeof(object)}, ReturnType = typeof(object))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 64
	}

	public override XmlSchemaType SchemaType
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaInfo), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlValueGetter), typeof(string), typeof(XmlSchemaInfo)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(XmlSchemaValidator), Member = "SkipToEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaValidator), Member = "GetUnspecifiedDefaultAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaValidator), Member = "InternalValidateEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaInfo), typeof(object)}, ReturnType = typeof(object))]
		[CallerCount(Count = 6)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 71
	}

	public override XmlSchemaValidity Validity
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	internal XmlSchemaType XmlType
	{
		[CalledBy(Type = typeof(XsdValidatingReader), Member = "ProcessEndElementEvent", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdValidatingReader), Member = "ReadAheadForMemberType", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdValidatingReader), Member = "GetIsDefault", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaValidator), Member = "GetUnspecifiedDefaultAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		internal get { } //Length: 17
	}

	[CalledBy(Type = typeof(AttributePSVIInfo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "AddAttributePSVI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(AttributePSVIInfo))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public XmlSchemaInfo() { }

	[CalledBy(Type = typeof(XmlDocument), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal XmlSchemaInfo(XmlSchemaValidity validity) { }

	[CalledBy(Type = typeof(AttributePSVIInfo), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "ProcessElementEvent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "AddAttributePSVI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(AttributePSVIInfo))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlValueGetter), typeof(string), typeof(XmlSchemaInfo)}, ReturnType = typeof(object))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	internal void Clear() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public XmlSchemaContentType get_ContentType() { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "GetIsDefault", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool get_HasDefaultValue() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override bool get_IsDefault() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override bool get_IsNil() { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "Skip", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "System.Xml.Schema.IXmlSchemaInfo.get_MemberType", ReturnType = typeof(XmlSchemaSimpleType))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "GetIsDefault", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "GetMemberType", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool get_IsUnionType() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public override XmlSchemaSimpleType get_MemberType() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public override XmlSchemaAttribute get_SchemaAttribute() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public override XmlSchemaElement get_SchemaElement() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public override XmlSchemaType get_SchemaType() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public override XmlSchemaValidity get_Validity() { }

	[CalledBy(Type = typeof(XsdValidatingReader), Member = "ProcessEndElementEvent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "ReadAheadForMemberType", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "GetIsDefault", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "GetUnspecifiedDefaultAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	internal XmlSchemaType get_XmlType() { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void set_IsDefault(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_IsNil(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_MemberType(XmlSchemaSimpleType value) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlValueGetter), typeof(string), typeof(XmlSchemaInfo)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "GetUnspecifiedDefaultAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void set_SchemaAttribute(XmlSchemaAttribute value) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaInfo), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "SkipToEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "InternalValidateEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaInfo), typeof(object)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void set_SchemaElement(XmlSchemaElement value) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaInfo), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ValidateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlValueGetter), typeof(string), typeof(XmlSchemaInfo)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "SkipToEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "GetUnspecifiedDefaultAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "InternalValidateEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaInfo), typeof(object)}, ReturnType = typeof(object))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public void set_SchemaType(XmlSchemaType value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Validity(XmlSchemaValidity value) { }

}

