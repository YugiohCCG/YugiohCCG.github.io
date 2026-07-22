namespace System.Xml;

internal class XmlLoader
{
	private XmlDocument doc; //Field offset: 0x10
	private XmlReader reader; //Field offset: 0x18
	private bool preserveWhitespace; //Field offset: 0x20

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public XmlLoader() { }

	[CalledBy(Type = typeof(XmlLoader), Member = "ParsePartialContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(string), typeof(XmlNodeType)}, ReturnType = typeof(XmlNamespaceManager))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNodeType), typeof(XmlParserContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "set_XmlValidatingReaderCompatibilityMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "set_XmlResolver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "set_Namespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "Create", ReturnType = typeof(IDtdParser))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SetDtdInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private XmlReader CreateInnerXmlReader(string xmlFragment, XmlNodeType nt, XmlParserContext context, XmlDocument doc) { }

	[CalledBy(Type = typeof(XmlLoader), Member = "ExpandEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlEntityReference)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	private string EntitizeName(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlLoader), Member = "ParsePartialContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(string), typeof(XmlNodeType)}, ReturnType = typeof(XmlNamespaceManager))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void ExpandEntity(XmlEntity ent) { }

	[CalledBy(Type = typeof(XmlEntityReference), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlDocument), Member = "get_Entities", ReturnType = typeof(XmlNamedNodeMap))]
	[Calls(Type = typeof(XmlLoader), Member = "EntitizeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlLoader), Member = "ParsePartialContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(string), typeof(XmlNodeType)}, ReturnType = typeof(XmlNamespaceManager))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 20)]
	internal void ExpandEntityReference(XmlEntityReference eref) { }

	[CalledBy(Type = typeof(XmlLoader), Member = "ParsePartialContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(string), typeof(XmlNodeType)}, ReturnType = typeof(XmlNamespaceManager))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlParserContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(XmlNamespaceManager), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(XmlSpace)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 37)]
	[CallsUnknownMethods(Count = 20)]
	private XmlParserContext GetContext(XmlNode node) { }

	[CalledBy(Type = typeof(XmlDocument), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "get_Schemas", ReturnType = typeof(XmlSchemaSet))]
	[Calls(Type = typeof(XmlLoader), Member = "LoadNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 10)]
	internal void Load(XmlDocument doc, XmlReader reader, bool preserveWhitespace) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDocument), Member = "AddAttrXmlName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[Calls(Type = typeof(XmlLoader), Member = "LoadAttributeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlLoader), Member = "UnexpectedNodeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 29)]
	[CallsUnknownMethods(Count = 7)]
	private XmlAttribute LoadAttributeNode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlDocument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlLoader), Member = "LoadAttributeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	private XmlAttribute LoadAttributeNodeDirect() { }

	[CalledBy(Type = typeof(XmlLoader), Member = "LoadAttributeNode", ReturnType = typeof(XmlAttribute))]
	[CalledBy(Type = typeof(XmlLoader), Member = "LoadDefaultAttribute", ReturnType = typeof(XmlAttribute))]
	[CalledBy(Type = typeof(XmlLoader), Member = "LoadAttributeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlLoader), Member = "LoadAttributeNodeDirect", ReturnType = typeof(XmlAttribute))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(XmlEntityReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlDocument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlLoader), Member = "LoadAttributeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlLoader), Member = "UnexpectedNodeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 5)]
	private void LoadAttributeValue(XmlNode parent, bool direct) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlLoader), Member = "ParseXmlDeclarationValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	private XmlDeclaration LoadDeclarationNode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDocument), Member = "AddAttrXmlName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[Calls(Type = typeof(XmlLoader), Member = "LoadAttributeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	private XmlAttribute LoadDefaultAttribute() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlLoader), Member = "LoadNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlNode))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void LoadDocSequence(XmlDocument parentDoc) { }

	[CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentTypeNode", ReturnType = typeof(XmlDocumentType))]
	[CalledBy(Type = typeof(XmlLoader), Member = "ParseDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocumentType), typeof(bool), typeof(XmlResolver)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDocument), Member = "AddIdInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlName), typeof(XmlName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlDocument), Member = "AddAttrXmlName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[Calls(Type = typeof(XmlDocument), Member = "AddXmlName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[Calls(Type = typeof(SchemaDeclBase), Member = "get_Prefix", ReturnType = typeof(string))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(SchemaInfo), Member = "get_ParameterEntities", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaEntity>))]
	[Calls(Type = typeof(XmlDocumentType), Member = "get_Entities", ReturnType = typeof(XmlNamedNodeMap))]
	[Calls(Type = typeof(XmlEntity), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(XmlDocument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SchemaInfo), Member = "get_GeneralEntities", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaEntity>))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SchemaInfo), Member = "get_Notations", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.String, System.Xml.Schema.SchemaNotation>))]
	[CallsDeduplicatedMethods(Count = 26)]
	[CallsUnknownMethods(Count = 50)]
	private void LoadDocumentType(IDtdInfo dtdInfo, XmlDocumentType dtNode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlLoader), Member = "ParseDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocumentType), typeof(bool), typeof(XmlResolver)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo), typeof(XmlDocumentType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private XmlDocumentType LoadDocumentTypeNode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEntityReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlDocument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlLoader), Member = "LoadNodeDirect", ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(XmlLoader), Member = "LoadNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlNode))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 1)]
	private XmlEntityReference LoadEntityReferenceNode(bool direct) { }

	[CalledBy(Type = typeof(XmlAttribute), Member = "set_InnerXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlLoader), Member = "ParsePartialContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(string), typeof(XmlNodeType)}, ReturnType = typeof(XmlNamespaceManager))]
	internal void LoadInnerXmlAttribute(XmlAttribute node, string innerxmltext) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlLoader), Member = "ParsePartialContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(string), typeof(XmlNodeType)}, ReturnType = typeof(XmlNamespaceManager))]
	[Calls(Type = typeof(XmlLoader), Member = "RemoveDuplicateNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(XmlNamespaceManager), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	internal void LoadInnerXmlElement(XmlElement node, string innerxmltext) { }

	[CalledBy(Type = typeof(XmlLoader), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlLoader), Member = "LoadDocSequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlLoader), Member = "ReadCurrentNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlReader)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlLoader), Member = "LoadEntityReferenceNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlEntityReference))]
	[CalledBy(Type = typeof(XmlLoader), Member = "ParsePartialContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(string), typeof(XmlNodeType)}, ReturnType = typeof(XmlNamespaceManager))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	private XmlNode LoadNode(bool skipOverWhitespace) { }

	[CalledBy(Type = typeof(XmlLoader), Member = "LoadEntityReferenceNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlEntityReference))]
	[CalledBy(Type = typeof(XmlLoader), Member = "ParsePartialContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(string), typeof(XmlNodeType)}, ReturnType = typeof(XmlNamespaceManager))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	private XmlNode LoadNodeDirect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlLoader), Member = "ParseDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocumentType), typeof(bool), typeof(XmlResolver)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void ParseDocumentType(XmlDocumentType dtNode) { }

	[CalledBy(Type = typeof(XmlDocumentType), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(XmlDocument)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentTypeNode", ReturnType = typeof(XmlDocumentType))]
	[CalledBy(Type = typeof(XmlLoader), Member = "ParseDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocumentType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlParserContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable), typeof(XmlNamespaceManager), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(XmlSpace)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNodeType), typeof(XmlParserContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "set_Namespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "set_XmlResolver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DtdParser), Member = "Create", ReturnType = typeof(IDtdParser))]
	[Calls(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo), typeof(XmlDocumentType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	private void ParseDocumentType(XmlDocumentType dtNode, bool bUseResolver, XmlResolver resolver) { }

	[CalledBy(Type = typeof(XmlDocumentFragment), Member = "set_InnerXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlElement), Member = "set_InnerXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEntity), Member = "get_LastNode", ReturnType = typeof(XmlLinkedNode))]
	[CalledBy(Type = typeof(XmlLoader), Member = "LoadInnerXmlElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlLoader), Member = "LoadInnerXmlAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlLoader), Member = "ExpandEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlEntity)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlLoader), Member = "ExpandEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlEntityReference)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(XmlLoader), Member = "GetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlParserContext))]
	[Calls(Type = typeof(XmlLoader), Member = "CreateInnerXmlReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNodeType), typeof(XmlParserContext), typeof(XmlDocument)}, ReturnType = typeof(XmlReader))]
	[Calls(Type = typeof(XmlLoader), Member = "LoadNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(XmlLoader), Member = "LoadNodeDirect", ReturnType = typeof(XmlNode))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	internal XmlNamespaceManager ParsePartialContent(XmlNode parentNode, string innerxmltext, XmlNodeType nt) { }

	[CalledBy(Type = typeof(XmlDeclaration), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlLoader), Member = "LoadDeclarationNode", ReturnType = typeof(XmlDeclaration))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlParserContext)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 16)]
	internal static void ParseXmlDeclarationValue(string strValue, out string version, out string encoding, out string standalone) { }

	[CalledBy(Type = typeof(XmlDocument), Member = "ReadNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(XmlNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlLoader), Member = "LoadNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 11)]
	internal XmlNode ReadCurrentNode(XmlDocument doc, XmlReader reader) { }

	[CalledBy(Type = typeof(XmlElement), Member = "set_InnerXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlLoader), Member = "LoadInnerXmlElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlLoader), Member = "RemoveDuplicateNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(XmlNamespaceManager), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(XmlLoader), Member = "RemoveDuplicateNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(XmlNamespaceManager), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallsUnknownMethods(Count = 1)]
	private void RemoveDuplicateNamespace(XmlElement elem, XmlNamespaceManager mgr, bool fCheckElemAttrs) { }

	[CalledBy(Type = typeof(XmlLoader), Member = "LoadAttributeNode", ReturnType = typeof(XmlAttribute))]
	[CalledBy(Type = typeof(XmlLoader), Member = "LoadAttributeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Parser), Member = "LoadElementNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlElement))]
	[CalledBy(Type = typeof(Parser), Member = "LoadAttributeNode", ReturnType = typeof(XmlAttribute))]
	[CalledBy(Type = typeof(Parser), Member = "LoadEntityReferenceInAttribute", ReturnType = typeof(XmlEntityReference))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static Exception UnexpectedNodeType(XmlNodeType nodetype) { }

}

