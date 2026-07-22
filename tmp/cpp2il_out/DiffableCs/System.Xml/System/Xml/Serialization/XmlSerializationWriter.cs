namespace System.Xml.Serialization;

public abstract class XmlSerializationWriter : XmlSerializationGeneratedCode
{
	private class WriteCallbackInfo
	{
		public Type Type; //Field offset: 0x10
		public string TypeName; //Field offset: 0x18
		public string TypeNs; //Field offset: 0x20
		public XmlSerializationWriteCallback Callback; //Field offset: 0x28

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public WriteCallbackInfo() { }

	}

	private ObjectIDGenerator idGenerator; //Field offset: 0x10
	private int qnameCount; //Field offset: 0x18
	private bool topLevelElement; //Field offset: 0x1C
	private ArrayList namespaces; //Field offset: 0x20
	private XmlWriter writer; //Field offset: 0x28
	private Queue referencedElements; //Field offset: 0x30
	private Hashtable callbacks; //Field offset: 0x38
	private Hashtable serializedObjects; //Field offset: 0x40

	protected XmlWriter Writer
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlMapping)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializer), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlMapping)}, ReturnType = typeof(XmlSerializationWriter))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected XmlSerializationWriter() { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "InitCallbacks", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	protected void AddWriteCallback(Type type, string typeName, string typeNs, XmlSerializationWriteCallback callback) { }

	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WritePotentiallyReferencingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(Type), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool AlreadyQueued(object ob) { }

	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WritePotentiallyReferencingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(Type), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteReferencingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Queue), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void CheckReferenceQueue() { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteAnyElementContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapMemberAnyElement), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	protected Exception CreateUnknownAnyElementException(string name, string ns) { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteListContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(TypeData), typeof(ListMap), typeof(object), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected Exception CreateUnknownTypeException(object o) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	protected Exception CreateUnknownTypeException(Type type) { }

	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteTypedPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteListElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(object), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "GetStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(TypeData), typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "GetQualifiedName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	protected string FromXmlQualifiedName(XmlQualifiedName xmlQualifiedName) { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	protected XmlWriter get_Writer() { }

	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WritePotentiallyReferencingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(Type), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteReferencedElements", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(TypeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteReferencingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ObjectIDGenerator), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private string GetId(object o, bool addToReferencesList) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private string GetNamespacePrefix(string ns) { }

	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "FromXmlQualifiedName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteElementQualifiedName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(TypeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteXmlAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteXsiType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private string GetQualifiedName(string name, string ns) { }

	protected abstract void InitCallbacks() { }

	[CalledBy(Type = typeof(XmlSerializer), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(object), typeof(XmlSerializerNamespaces)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializerNamespaces), Member = "ToArray", ReturnType = typeof(XmlQualifiedName[]))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal void Initialize(XmlWriter writer, XmlSerializerNamespaces nss) { }

	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WritePotentiallyReferencingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(Type), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteReferencedElements", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TypeData), Member = "get_ListItemTypeData", ReturnType = typeof(TypeData))]
	[Calls(Type = typeof(TypeData), Member = "get_ListItemType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool IsPrimitiveArray(TypeData td) { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlMembersMapping), typeof(Object[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	protected void TopLevelElement() { }

	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteReferencedElements", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TypeData), Member = "get_ListItemTypeData", ReturnType = typeof(TypeData))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(bool), typeof(ICollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "GetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "GetQualifiedName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(TypeData), Member = "get_ListItemType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WritePotentiallyReferencingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(Type), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void WriteArray(object o, TypeData td) { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteAttributeMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteListElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(object), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected void WriteAttribute(string localName, string ns, string value) { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlMembersMapping), typeof(Object[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected void WriteAttribute(string prefix, string localName, string ns, string value) { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(object), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteAnyElementContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapMemberAnyElement), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteXmlNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteNullTagEncoded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected void WriteElementEncoded(XmlNode node, string name, string ns, bool isNullable, bool any) { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(object), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteAnyElementContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapMemberAnyElement), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteXmlNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteNullTagLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected void WriteElementLiteral(XmlNode node, string name, string ns, bool isNullable, bool any) { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WritePrimitiveValueLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(string), typeof(XmlTypeMapping), typeof(TypeData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteElementQualifiedName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value) { }

	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteElementQualifiedName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteNullableQualifiedNameEncoded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteNullableQualifiedNameLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WritePrimitiveValueEncoded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(string), typeof(XmlQualifiedName), typeof(XmlTypeMapping), typeof(TypeData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlConvert), Member = "EncodeLocalName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(bool), typeof(ICollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteXsiType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "GetQualifiedName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value, XmlQualifiedName xsiType) { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WritePrimitiveValueLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(string), typeof(XmlTypeMapping), typeof(TypeData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteElementString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	protected void WriteElementString(string localName, string ns, string value) { }

	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteElementString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteNullableStringEncoded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteNullableStringLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WritePrimitiveValueEncoded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(string), typeof(XmlQualifiedName), typeof(XmlTypeMapping), typeof(TypeData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteElementString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlConvert), Member = "EncodeLocalName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(bool), typeof(ICollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteXsiType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected void WriteElementString(string localName, string ns, string value, XmlQualifiedName xsiType) { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(object), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected void WriteEndElement(object o) { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected void WriteEndElement() { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteObjectElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(object), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSerializerNamespaces), Member = "get_Namespaces", ReturnType = typeof(Hashtable))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 18)]
	protected void WriteNamespaceDeclarations(XmlSerializerNamespaces xmlns) { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WritePrimitiveValueEncoded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(string), typeof(XmlQualifiedName), typeof(XmlTypeMapping), typeof(TypeData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteNullTagEncoded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteElementQualifiedName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	protected void WriteNullableQualifiedNameEncoded(string name, string ns, XmlQualifiedName value, XmlQualifiedName xsiType) { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WritePrimitiveValueLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(string), typeof(XmlTypeMapping), typeof(TypeData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteNullTagLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteElementQualifiedName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	protected void WriteNullableQualifiedNameLiteral(string name, string ns, XmlQualifiedName value) { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WritePrimitiveValueEncoded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(string), typeof(XmlQualifiedName), typeof(XmlTypeMapping), typeof(TypeData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteElementString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[ContainsInvalidInstructions]
	protected void WriteNullableStringEncoded(string name, string ns, string value, XmlQualifiedName xsiType) { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WritePrimitiveValueLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(string), typeof(XmlTypeMapping), typeof(TypeData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteNullTagLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteElementString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	protected void WriteNullableStringLiteral(string name, string ns, string value) { }

	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteElementEncoded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(string), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteNullableQualifiedNameEncoded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WritePotentiallyReferencingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(Type), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteReferencingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(object), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected void WriteNullTagEncoded(string name, string ns) { }

	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteElementLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(string), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteNullableQualifiedNameLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteNullableStringLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteSerializable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IXmlSerializable), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteSerializable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IXmlSerializable), typeof(string), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(object), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(bool), typeof(ICollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected void WriteNullTagLiteral(string name, string ns) { }

	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(TypeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteNullTagEncoded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlCustomFormatter), Member = "ToXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "IsPrimitiveArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeTranslator), Member = "GetTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool)}, ReturnType = typeof(TypeData))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteXsiType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "GetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "AlreadyQueued", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "CheckReferenceQueue", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(bool), typeof(ICollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 8)]
	protected void WritePotentiallyReferencingElement(string n, string ns, object o, Type ambientType, bool suppressReference, bool isNullable) { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeTranslator), Member = "GetTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeData))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "IsPrimitiveArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(TypeData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(bool), typeof(ICollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "GetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteXsiType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	protected void WriteReferencedElements() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "CheckReferenceQueue", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "GetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteNullTagEncoded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	protected void WriteReferencingElement(string n, string ns, object o, bool isNullable) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteNullTagLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable) { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(object), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteNullTagLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable, bool wrapped) { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected void WriteStartDocument() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(bool), typeof(ICollection)}, ReturnType = typeof(void))]
	protected void WriteStartElement(string name, string ns) { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlMembersMapping), typeof(Object[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(bool), typeof(ICollection)}, ReturnType = typeof(void))]
	protected void WriteStartElement(string name, string ns, bool writePrefixed) { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(object), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(bool), typeof(ICollection)}, ReturnType = typeof(void))]
	protected void WriteStartElement(string name, string ns, object o) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(bool), typeof(ICollection)}, ReturnType = typeof(void))]
	protected void WriteStartElement(string name, string ns, object o, bool writePrefixed) { }

	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteElementQualifiedName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteElementString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteNullTagLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WritePotentiallyReferencingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(Type), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteReferencedElements", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(TypeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlConvert), Member = "EncodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 33)]
	private void WriteStartElement(string name, string ns, object o, bool writePrefixed, ICollection namespaces) { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(object), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeTranslator), Member = "GetTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool)}, ReturnType = typeof(TypeData))]
	[Calls(Type = typeof(XmlConvert), Member = "EncodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TypeData), Member = "get_IsXsdType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "FromXmlQualifiedName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlCustomFormatter), Member = "ToXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteXsiType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	protected void WriteTypedPrimitive(string name, string ns, object o, bool xsiType) { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WritePrimitiveValueLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(string), typeof(XmlTypeMapping), typeof(TypeData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WritePrimitiveValueEncoded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(string), typeof(XmlQualifiedName), typeof(XmlTypeMapping), typeof(TypeData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected void WriteValue(string value) { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteAttributeMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TypeTranslator), Member = "ParseArrayType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "GetQualifiedName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 5)]
	protected void WriteXmlAttribute(XmlNode node, object container) { }

	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteElementEncoded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(string), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteElementLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(string), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlDocument), Member = "get_DocumentElement", ReturnType = typeof(XmlElement))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void WriteXmlNode(XmlNode node) { }

	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteElementQualifiedName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteElementString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WritePotentiallyReferencingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(Type), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteReferencedElements", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteTypedPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(object), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "GetQualifiedName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected void WriteXsiType(string name, string ns) { }

}

