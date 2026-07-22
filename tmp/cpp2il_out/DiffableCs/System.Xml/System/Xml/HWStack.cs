namespace System.Xml;

[DefaultMember("Item")]
internal class HWStack : ICloneable
{
	private Object[] stack; //Field offset: 0x10
	private int growthRate; //Field offset: 0x18
	private int used; //Field offset: 0x1C
	private int size; //Field offset: 0x20
	private int limit; //Field offset: 0x24

	internal object Item
	{
		[CalledBy(Type = typeof(XmlSchemaValidator), Member = "AddIdentityConstraints", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ElementIdentityConstraints", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaValidator), Member = "AttributeIdentityConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(string), typeof(XmlSchemaDatatype)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaValidator), Member = "EndElementIdentityConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(XmlSchemaDatatype)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdBuilder), Member = "get_ParentElement", ReturnType = typeof(Token))]
		[CalledBy(Type = typeof(XsdValidator), Member = "AddIdentityConstraints", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdValidator), Member = "ElementIdentityConstraints", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdValidator), Member = "AttributeIdentityConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(string), typeof(SchemaAttDef)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdValidator), Member = "EndElementIdentityConstraints", ReturnType = typeof(void))]
		[CallerCount(Count = 19)]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		internal get { } //Length: 117
		[CalledBy(Type = typeof(XdrBuilder), Member = "ProcessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XdrBuilder), Member = "Push", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XdrBuilder), Member = "PushGroupInfo", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_InitGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdBuilder), Member = "Push", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 9)]
		internal set { } //Length: 193
	}

	internal int Length
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	[CalledBy(Type = typeof(DtdValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlValidatingReaderImpl), typeof(IValidationEventHandling), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdValidator), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlNamespaceManager), typeof(SchemaInfo), typeof(string), typeof(XmlNameTable), typeof(SchemaNames), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlNamespaceManager), typeof(XmlSchema), typeof(XmlNameTable), typeof(SchemaNames), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "Init", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal HWStack(int GrowthRate) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal HWStack(int GrowthRate, int limit) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private HWStack(Object[] stack, int growthRate, int used, int size) { }

	[CalledBy(Type = typeof(DtdValidator), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	internal void AddToTop(object o) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public override object Clone() { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "AddIdentityConstraints", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ElementIdentityConstraints", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "AttributeIdentityConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(string), typeof(XmlSchemaDatatype)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "EndElementIdentityConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(XmlSchemaDatatype)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "get_ParentElement", ReturnType = typeof(Token))]
	[CalledBy(Type = typeof(XsdValidator), Member = "AddIdentityConstraints", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ElementIdentityConstraints", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "AttributeIdentityConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(string), typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "EndElementIdentityConstraints", ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal object get_Item(int index) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal int get_Length() { }

	[CalledBy(Type = typeof(DtdValidator), Member = "Pop", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ValidateEndElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "Pop", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "Pop", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateEndElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "Pop", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	internal object Peek() { }

	[CalledBy(Type = typeof(DtdValidator), Member = "Pop", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "EndChildren", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "Pop", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "PopGroupInfo", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_EndGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "ValidateEndElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "Pop", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "Pop", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "EndChildren", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "Pop", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ValidateEndElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "Pop", ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[CallsUnknownMethods(Count = 2)]
	internal object Pop() { }

	[CalledBy(Type = typeof(DtdValidator), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "ProcessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "Push", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "PushGroupInfo", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_InitGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "Push", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	internal object Push() { }

	[CalledBy(Type = typeof(XdrBuilder), Member = "ProcessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "Push", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "PushGroupInfo", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_InitGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "Push", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	internal void set_Item(int index, object value) { }

}

