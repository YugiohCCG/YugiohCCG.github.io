namespace System.Xml.Schema;

public sealed class XmlSchemaInference
{
	internal enum InferenceOption
	{
		Restricted = 0,
		Relaxed = 1,
	}

	internal static XmlQualifiedName ST_boolean; //Field offset: 0x0
	internal static XmlQualifiedName ST_byte; //Field offset: 0x8
	internal static XmlQualifiedName ST_unsignedByte; //Field offset: 0x10
	internal static XmlQualifiedName ST_short; //Field offset: 0x18
	internal static XmlQualifiedName ST_unsignedShort; //Field offset: 0x20
	internal static XmlQualifiedName ST_int; //Field offset: 0x28
	internal static XmlQualifiedName ST_unsignedInt; //Field offset: 0x30
	internal static XmlQualifiedName ST_long; //Field offset: 0x38
	internal static XmlQualifiedName ST_unsignedLong; //Field offset: 0x40
	internal static XmlQualifiedName ST_integer; //Field offset: 0x48
	internal static XmlQualifiedName ST_decimal; //Field offset: 0x50
	internal static XmlQualifiedName ST_float; //Field offset: 0x58
	internal static XmlQualifiedName ST_double; //Field offset: 0x60
	internal static XmlQualifiedName ST_duration; //Field offset: 0x68
	internal static XmlQualifiedName ST_dateTime; //Field offset: 0x70
	internal static XmlQualifiedName ST_time; //Field offset: 0x78
	internal static XmlQualifiedName ST_date; //Field offset: 0x80
	internal static XmlQualifiedName ST_gYearMonth; //Field offset: 0x88
	internal static XmlQualifiedName ST_string; //Field offset: 0x90
	internal static XmlQualifiedName ST_anySimpleType; //Field offset: 0x98
	internal static XmlQualifiedName[] SimpleTypes; //Field offset: 0xA0
	private XmlSchema rootSchema; //Field offset: 0x10
	private XmlSchemaSet schemaSet; //Field offset: 0x18
	private XmlReader xtr; //Field offset: 0x20
	private NameTable nametable; //Field offset: 0x28
	private string TargetNamespace; //Field offset: 0x30
	private XmlNamespaceManager NamespaceManager; //Field offset: 0x38
	private ArrayList schemaList; //Field offset: 0x40
	private InferenceOption occurrence; //Field offset: 0x48
	private InferenceOption typeInference; //Field offset: 0x4C

	public InferenceOption Occurrence
	{
		[CallerCount(Count = 26)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public InferenceOption TypeInference
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 99)]
	private static XmlSchemaInference() { }

	[CalledBy(Type = "System.Data.DataSet", Member = "InferSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), "System.String[]", "System.Data.XmlReadMode"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NameTable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaElementDecl), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaType), Member = "set_ElementDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaElementDecl)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public XmlSchemaInference() { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "ProcessAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement&), typeof(XmlSchemaType), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaAttribute), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaAttribute), Member = "set_RefName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaInference), Member = "FindAttributeRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICollection), typeof(string), typeof(string)}, ReturnType = typeof(XmlSchemaAttribute))]
	[Calls(Type = typeof(XmlSchemaInference), Member = "GetSchemaType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSchemaObjectCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSchemaAttribute), Member = "set_SchemaTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaInference), Member = "RefineSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlSchemaInference), Member = "FindAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICollection), typeof(string)}, ReturnType = typeof(XmlSchemaAttribute))]
	[Calls(Type = typeof(XmlSchemaImport), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchema))]
	[Calls(Type = typeof(XmlSchema), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "Schemas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ICollection))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "get_Values", ReturnType = typeof(ICollection))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSchemaInferenceException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	private XmlSchemaAttribute AddAttribute(string localName, string prefix, string childURI, string attrValue, bool bCreatingNewType, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, XmlSchemaObjectTable compiledAttributes) { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "InferSchema1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlSchemaSet)}, ReturnType = typeof(XmlSchemaSet))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "InferElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "FindMatchingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(XmlReader), typeof(XmlSchemaComplexType), typeof(Int32&), typeof(Boolean&), typeof(XmlSchema), typeof(bool)}, ReturnType = typeof(XmlSchemaElement))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XmlSchemaInferenceException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaInference), Member = "InferElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaObjectCollection), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaParticle), Member = "set_MinOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaElement), Member = "set_RefName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaImport), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaObjectCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "Schemas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ICollection))]
	[Calls(Type = typeof(XmlSchemaInference), Member = "FindGlobalElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchema&)}, ReturnType = typeof(XmlSchemaElement))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchema))]
	[Calls(Type = typeof(XmlSchema), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 11)]
	private XmlSchemaElement AddElement(string localName, string prefix, string childURI, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, int positionWithinCollection) { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "InferElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "ProcessAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement&), typeof(XmlSchemaType), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "MakeExistingAttributesOptional", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaObjectCollection)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(XmlSchemaInferenceException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private XmlSchemaSimpleContentExtension CheckSimpleContentExtension(XmlSchemaComplexType ct) { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "FindMatchingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(XmlReader), typeof(XmlSchemaComplexType), typeof(Int32&), typeof(Boolean&), typeof(XmlSchema), typeof(bool)}, ReturnType = typeof(XmlSchemaElement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaElement), Member = "set_IsNillable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaObject), Member = "get_Namespaces", ReturnType = typeof(XmlSerializerNamespaces))]
	[Calls(Type = typeof(XmlSchemaElement), Member = "set_RefName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaElement), Member = "set_SchemaTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaElement), Member = "set_SubstitutionGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decimal), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaParticle), Member = "set_MinOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaParticle), Member = "set_MaxOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	private XmlSchemaElement CreateNewElementforChoice(XmlSchemaElement copyElement) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchema), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchema))]
	[CallsUnknownMethods(Count = 2)]
	private XmlSchema CreateXmlSchema(string targetNS) { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "InferSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Boolean&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlConvert), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlDateTimeSerializationMode)}, ReturnType = typeof(DateTime))]
	internal static int DateTime(string s, bool bDate, bool bTime) { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(XmlSchema), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaObjectTable)}, ReturnType = typeof(XmlSchemaAttribute))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "SwitchUseToOptional", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection), typeof(XmlSchemaObjectCollection)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	internal XmlSchemaAttribute FindAttribute(ICollection attributes, string attrName) { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(XmlSchema), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaObjectTable)}, ReturnType = typeof(XmlSchemaAttribute))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "SwitchUseToOptional", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection), typeof(XmlSchemaObjectCollection)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	internal XmlSchemaAttribute FindAttributeRef(ICollection attributes, string attributeName, string nsURI) { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "FindMatchingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(XmlReader), typeof(XmlSchemaComplexType), typeof(Int32&), typeof(Boolean&), typeof(XmlSchema), typeof(bool)}, ReturnType = typeof(XmlSchemaElement))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "FindGlobalElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchema&)}, ReturnType = typeof(XmlSchemaElement))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal XmlSchemaElement FindElement(XmlSchemaObjectCollection elements, string elementName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	internal XmlSchemaElement FindElementRef(XmlSchemaObjectCollection elements, string elementName, string nsURI) { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "AddElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlSchema), typeof(XmlSchemaObjectCollection), typeof(int)}, ReturnType = typeof(XmlSchemaElement))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "FindMatchingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(XmlReader), typeof(XmlSchemaComplexType), typeof(Int32&), typeof(Boolean&), typeof(XmlSchema), typeof(bool)}, ReturnType = typeof(XmlSchemaElement))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlSchemaSet), Member = "Schemas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ICollection))]
	[Calls(Type = typeof(XmlSchemaInference), Member = "FindElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection), typeof(string)}, ReturnType = typeof(XmlSchemaElement))]
	[CallsUnknownMethods(Count = 15)]
	internal XmlSchemaElement FindGlobalElement(string namespaceURI, string localName, out XmlSchema parentSchema) { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "InferElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaInferenceException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionBase), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaInference), Member = "CreateNewElementforChoice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(XmlSchemaElement))]
	[Calls(Type = typeof(XmlSchemaChoice), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaInference), Member = "FindElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection), typeof(string)}, ReturnType = typeof(XmlSchemaElement))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaObjectCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Decimal), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaInference), Member = "FindGlobalElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchema&)}, ReturnType = typeof(XmlSchemaElement))]
	[Calls(Type = typeof(XmlSchemaInference), Member = "SetMinMaxOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaInference), Member = "InferElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaParticle), Member = "set_MaxOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaParticle), Member = "set_MinOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaInference), Member = "AddElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlSchema), typeof(XmlSchemaObjectCollection), typeof(int)}, ReturnType = typeof(XmlSchemaElement))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 78)]
	[CallsUnknownMethods(Count = 31)]
	internal XmlSchemaElement FindMatchingElement(bool bCreatingNewType, XmlReader xtr, XmlSchemaComplexType ct, ref int lastUsedSeqItem, ref bool bParticleChanged, XmlSchema parentSchema, bool setMaxoccurs) { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	public InferenceOption get_Occurrence() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "get_GlobalTypes", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaObject))]
	[Calls(Type = typeof(XmlSchemaType), Member = "GetBuiltInSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaSimpleType))]
	[Calls(Type = typeof(XmlSchemaType), Member = "GetBuiltInComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaComplexType))]
	[CallsUnknownMethods(Count = 1)]
	private XmlSchemaType GetEffectiveSchemaType(XmlSchemaElement elem, bool bCreatingNewType) { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(XmlSchema), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaObjectTable)}, ReturnType = typeof(XmlSchemaAttribute))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "InferElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaInferenceException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static int GetSchemaType(XmlQualifiedName qname) { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "InferSchema1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlSchemaSet)}, ReturnType = typeof(XmlSchemaSet))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "AddElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlSchema), typeof(XmlSchemaObjectCollection), typeof(int)}, ReturnType = typeof(XmlSchemaElement))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "FindMatchingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(XmlReader), typeof(XmlSchemaComplexType), typeof(Int32&), typeof(Boolean&), typeof(XmlSchema), typeof(bool)}, ReturnType = typeof(XmlSchemaElement))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaSequence), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaInference), Member = "AddElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlSchema), typeof(XmlSchemaObjectCollection), typeof(int)}, ReturnType = typeof(XmlSchemaElement))]
	[Calls(Type = typeof(XmlSchemaParticle), Member = "set_MinOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaObjectCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSchemaInference), Member = "GetSchemaType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSchemaSimpleContentExtension), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaInference), Member = "FindMatchingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(XmlReader), typeof(XmlSchemaComplexType), typeof(Int32&), typeof(Boolean&), typeof(XmlSchema), typeof(bool)}, ReturnType = typeof(XmlSchemaElement))]
	[Calls(Type = typeof(XmlSchemaInference), Member = "MoveAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaSimpleContentExtension), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSimpleContentExtension), Member = "set_BaseTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlSchemaInference), Member = "RefineSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlSchemaElement), Member = "set_SchemaTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaInference), Member = "ProcessAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement&), typeof(XmlSchemaType), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaInference), Member = "CheckSimpleContentExtension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(XmlSchemaSimpleContentExtension))]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = "get_Attributes", ReturnType = typeof(XmlSchemaObjectCollection))]
	[Calls(Type = typeof(XmlSchemaType), Member = "GetBuiltInComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaComplexType))]
	[Calls(Type = typeof(XmlSchemaType), Member = "GetBuiltInSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaSimpleType))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(XmlSchemaObject))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "get_GlobalTypes", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaInferenceException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 73)]
	[CallsUnknownMethods(Count = 41)]
	[ContainsUnimplementedInstructions]
	internal void InferElement(XmlSchemaElement xse, bool bCreatingNewType, XmlSchema parentSchema) { }

	[CalledBy(Type = "System.Data.DataSet", Member = "InferSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), "System.String[]", "System.Data.XmlReadMode"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaInference), Member = "InferSchema1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlSchemaSet)}, ReturnType = typeof(XmlSchemaSet))]
	public XmlSchemaSet InferSchema(XmlReader instanceDocument) { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "InferSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(XmlSchemaSet))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaSet), Member = "Compile", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "get_GlobalElements", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "get_Values", ReturnType = typeof(ICollection))]
	[Calls(Type = typeof(XmlSchemaInference), Member = "InferElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaInference), Member = "AddElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlSchema), typeof(XmlSchemaObjectCollection), typeof(int)}, ReturnType = typeof(XmlSchemaElement))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaObject), Member = "get_Namespaces", ReturnType = typeof(XmlSerializerNamespaces))]
	[Calls(Type = typeof(XmlSerializerNamespaces), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "Reprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchema))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaInferenceException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 48)]
	internal XmlSchemaSet InferSchema1(XmlReader instanceDocument, XmlSchemaSet schemas) { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "RefineSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(XmlQualifiedName))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(XmlSchemaInference), Member = "DateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static int InferSimpleType(string s, ref bool bNeedsRangeCheck) { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "ProcessAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement&), typeof(XmlSchemaType), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = "get_Attributes", ReturnType = typeof(XmlSchemaObjectCollection))]
	[Calls(Type = typeof(XmlSchemaInference), Member = "SwitchUseToOptional", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection), typeof(XmlSchemaObjectCollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaInference), Member = "CheckSimpleContentExtension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(XmlSchemaSimpleContentExtension))]
	[Calls(Type = typeof(XmlSchemaInferenceException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal void MakeExistingAttributesOptional(XmlSchemaComplexType ct, XmlSchemaObjectCollection attributesInInstance) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = "get_Attributes", ReturnType = typeof(XmlSchemaObjectCollection))]
	[Calls(Type = typeof(XmlSchemaObjectCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void MoveAttributes(XmlSchemaSimpleContentExtension scExtension, XmlSchemaComplexType ct) { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "InferElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = "get_AttributeUses", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "get_Values", ReturnType = typeof(ICollection))]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = "get_Attributes", ReturnType = typeof(XmlSchemaObjectCollection))]
	[Calls(Type = typeof(XmlSchemaObjectCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CollectionBase), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	private void MoveAttributes(XmlSchemaComplexType ct, XmlSchemaSimpleContentExtension simpleContentExtension, bool bCreatingNewType) { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "InferElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaInferenceException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaInferenceException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaInference), Member = "MakeExistingAttributesOptional", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaObjectCollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaElement), Member = "set_IsNillable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaObjectCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSchemaInference), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(XmlSchema), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaObjectTable)}, ReturnType = typeof(XmlSchemaAttribute))]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = "get_AttributeUses", ReturnType = typeof(XmlSchemaObjectTable))]
	[Calls(Type = typeof(XmlSchemaInference), Member = "CheckSimpleContentExtension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(XmlSchemaSimpleContentExtension))]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = "get_Attributes", ReturnType = typeof(XmlSchemaObjectCollection))]
	[Calls(Type = typeof(XmlSchemaElement), Member = "set_SchemaTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSimpleContentExtension), Member = "set_BaseTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSimpleContentExtension), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 25)]
	[CallsUnknownMethods(Count = 11)]
	internal void ProcessAttributes(ref XmlSchemaElement xse, XmlSchemaType effectiveSchemaType, bool bCreatingNewType, XmlSchema parentSchema) { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(XmlSchema), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaObjectTable)}, ReturnType = typeof(XmlSchemaAttribute))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "InferElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(XmlConvert), Member = "ToTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(XmlConvert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(XmlConvert), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(XmlConvert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(XmlConvert), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(XmlConvert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlConvert), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(XmlConvert), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(XmlConvert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(XmlConvert), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(sbyte))]
	[Calls(Type = typeof(XmlSchemaInference), Member = "InferSimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Boolean&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlDateTimeSerializationMode)}, ReturnType = typeof(DateTime))]
	[CallsUnknownMethods(Count = 1)]
	internal XmlQualifiedName RefineSimpleType(string s, ref int iTypeFlags) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Occurrence(InferenceOption value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_TypeInference(InferenceOption value) { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "FindMatchingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(XmlReader), typeof(XmlSchemaComplexType), typeof(Int32&), typeof(Boolean&), typeof(XmlSchema), typeof(bool)}, ReturnType = typeof(XmlSchemaElement))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Decimal), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaParticle), Member = "set_MinOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaParticle), Member = "set_MaxOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void SetMinMaxOccurs(XmlSchemaElement el, bool setMaxOccurs) { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "MakeExistingAttributesOptional", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaObjectCollection)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlSchemaInference), Member = "FindAttributeRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICollection), typeof(string), typeof(string)}, ReturnType = typeof(XmlSchemaAttribute))]
	[Calls(Type = typeof(XmlSchemaInference), Member = "FindAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICollection), typeof(string)}, ReturnType = typeof(XmlSchemaAttribute))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void SwitchUseToOptional(XmlSchemaObjectCollection attributes, XmlSchemaObjectCollection attributesInInstance) { }

}

