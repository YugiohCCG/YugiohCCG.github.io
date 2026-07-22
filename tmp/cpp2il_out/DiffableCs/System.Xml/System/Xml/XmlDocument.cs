namespace System.Xml;

public class XmlDocument : XmlNode
{
	internal static EmptyEnumerator EmptyEnumerator; //Field offset: 0x0
	internal static IXmlSchemaInfo NotKnownSchemaInfo; //Field offset: 0x8
	internal static IXmlSchemaInfo ValidSchemaInfo; //Field offset: 0x10
	internal static IXmlSchemaInfo InvalidSchemaInfo; //Field offset: 0x18
	private XmlImplementation implementation; //Field offset: 0x18
	private DomNameTable domNameTable; //Field offset: 0x20
	private XmlLinkedNode lastChild; //Field offset: 0x28
	private XmlNamedNodeMap entities; //Field offset: 0x30
	private Hashtable htElementIdMap; //Field offset: 0x38
	private Hashtable htElementIDAttrDecl; //Field offset: 0x40
	private SchemaInfo schemaInfo; //Field offset: 0x48
	private XmlSchemaSet schemas; //Field offset: 0x50
	private bool reportValidity; //Field offset: 0x58
	private bool actualLoadingStatus; //Field offset: 0x59
	private XmlNodeChangedEventHandler onNodeInsertingDelegate; //Field offset: 0x60
	private XmlNodeChangedEventHandler onNodeInsertedDelegate; //Field offset: 0x68
	private XmlNodeChangedEventHandler onNodeRemovingDelegate; //Field offset: 0x70
	private XmlNodeChangedEventHandler onNodeRemovedDelegate; //Field offset: 0x78
	private XmlNodeChangedEventHandler onNodeChangingDelegate; //Field offset: 0x80
	private XmlNodeChangedEventHandler onNodeChangedDelegate; //Field offset: 0x88
	internal bool fEntRefNodesPresent; //Field offset: 0x90
	internal bool fCDataNodesPresent; //Field offset: 0x91
	private bool preserveWhitespace; //Field offset: 0x92
	private bool isLoading; //Field offset: 0x93
	internal string strDocumentName; //Field offset: 0x98
	internal string strDocumentFragmentName; //Field offset: 0xA0
	internal string strCommentName; //Field offset: 0xA8
	internal string strTextName; //Field offset: 0xB0
	internal string strCDataSectionName; //Field offset: 0xB8
	internal string strEntityName; //Field offset: 0xC0
	internal string strID; //Field offset: 0xC8
	internal string strXmlns; //Field offset: 0xD0
	internal string strXml; //Field offset: 0xD8
	internal string strSpace; //Field offset: 0xE0
	internal string strLang; //Field offset: 0xE8
	internal string strEmpty; //Field offset: 0xF0
	internal string strNonSignificantWhitespaceName; //Field offset: 0xF8
	internal string strSignificantWhitespaceName; //Field offset: 0x100
	internal string strReservedXmlns; //Field offset: 0x108
	internal string strReservedXml; //Field offset: 0x110
	internal string baseURI; //Field offset: 0x118
	private XmlResolver resolver; //Field offset: 0x120
	internal bool bSetResolver; //Field offset: 0x128
	internal object objLock; //Field offset: 0x130
	private XmlAttribute namespaceXml; //Field offset: 0x138

	internal bool ActualLoadingStatus
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	public virtual string BaseURI
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	internal bool CanReportValidity
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal override XmlDeclaration Declaration
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		internal get { } //Length: 163
	}

	public XmlElement DocumentElement
	{
		[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "get_Value", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "get_ValueDocument", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(XmlDocument), Member = "IsValidChildType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlDocument), Member = "get_SchemaInfo", ReturnType = typeof(IXmlSchemaInfo))]
		[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteXmlNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Newtonsoft.Json.Converters.XmlDocumentWrapper", Member = "get_DocumentElement", ReturnType = "Newtonsoft.Json.Converters.IXmlElement")]
		[CalledBy(Type = "System.Data.DataSet", Member = "ReadXDRSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Data.DataSet", Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = "System.Data.XmlReadMode")]
		[CalledBy(Type = "System.Data.DataSet", Member = "InferSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), "System.String[]", "System.Data.XmlReadMode"}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Data.DataSet", Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), "System.Data.XmlReadMode", typeof(bool)}, ReturnType = "System.Data.XmlReadMode")]
		[CalledBy(Type = "System.Data.DataTable", Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), "System.Data.XmlReadMode", typeof(bool)}, ReturnType = "System.Data.XmlReadMode")]
		[CalledBy(Type = "System.Data.XmlDataLoader", Member = "LoadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument)}, ReturnType = typeof(void))]
		[CallerCount(Count = 16)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 127
	}

	public override XmlDocumentType DocumentType
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 127
	}

	internal SchemaInfo DtdSchemaInfo
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		internal get { } //Length: 254
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal string Encoding
	{
		[CalledBy(Type = typeof(XmlNodeReaderNavigator), Member = "InitDecAttr", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal get { } //Length: 39
	}

	internal XmlNamedNodeMap Entities
	{
		[CalledBy(Type = typeof(XmlLoader), Member = "ExpandEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlEntityReference)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 109
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal bool HasEntityReferences
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	internal bool HasSetResolver
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 8
	}

	public XmlImplementation Implementation
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual string InnerText
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 95
	}

	public virtual string InnerXml
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 17
	}

	internal virtual bool IsContainer
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	internal bool IsLoading
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	public virtual bool IsReadOnly
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	internal virtual XmlLinkedNode LastNode
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	public virtual string LocalName
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public virtual string Name
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	internal XmlAttribute NamespaceXml
	{
		[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "MoveToNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "MoveToFirstNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNamespaceScope)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "MoveToNextNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNamespaceScope)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(XmlDocument), Member = "AddAttrXmlName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
		[Calls(Type = typeof(XmlAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlName), typeof(XmlDocument)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 222
	}

	public XmlNameTable NameTable
	{
		[CallerCount(Count = 21)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 27
	}

	public virtual XmlNodeType NodeType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public virtual XmlDocument OwnerDocument
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual XmlNode ParentNode
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual IXmlSchemaInfo SchemaInfo
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlDocument), Member = "get_DocumentElement", ReturnType = typeof(XmlElement))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 283
	}

	public XmlSchemaSet Schemas
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	internal string Standalone
	{
		[CalledBy(Type = typeof(XmlNodeReaderNavigator), Member = "InitDecAttr", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal get { } //Length: 39
	}

	internal string Version
	{
		[CalledBy(Type = typeof(XmlNodeReaderNavigator), Member = "InitDecAttr", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal get { } //Length: 39
	}

	public override XmlResolver XmlResolver
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NamedPermissionSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(PermissionSet), Member = "Demand", ReturnType = typeof(void))]
		[Calls(Type = typeof(SecurityException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 8)]
		 set { } //Length: 327
	}

	internal virtual XPathNodeType XPNodeType
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaValidity)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static XmlDocument() { }

	[CalledBy(Type = typeof(XmlDocument), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlImplementation), Member = "CreateDocument", ReturnType = typeof(XmlDocument))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallsUnknownMethods(Count = 24)]
	protected private XmlDocument(XmlImplementation imp) { }

	[CalledBy(Type = "Mono.Nat.Upnp.ResponseMessage", Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Nat.Upnp.UpnpNatDevice", typeof(string)}, ReturnType = "Mono.Nat.Upnp.ResponseMessage")]
	[CalledBy(Type = "System.Data.NewDiffgramGen", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataTable", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.NewDiffgramGen", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataSet"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XmlTreeGen", Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataSet", "System.Data.DataTable", typeof(XmlWriter), typeof(bool), "System.Converter`2<Type, String>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XmlTreeGen", Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataSet", "System.Data.DataTable", typeof(XmlWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XmlTreeGen", Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataTable", typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataTable", Member = "ReadXmlDiffgram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataTable", Member = "ReadXDRSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataSet", Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), "System.Data.XmlReadMode", typeof(bool)}, ReturnType = "System.Data.XmlReadMode")]
	[CalledBy(Type = "System.Data.DataTable", Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), "System.Data.XmlReadMode", typeof(bool)}, ReturnType = "System.Data.XmlReadMode")]
	[CalledBy(Type = "System.Data.DataSet", Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = "System.Data.XmlReadMode")]
	[CalledBy(Type = "System.Data.DataSet", Member = "ReadXDRSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataSet", Member = "ReadXmlSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.XmlNodeConverter", Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", typeof(Type), typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSchema), Member = "get_Document", ReturnType = typeof(XmlDocument))]
	[CalledBy(Type = typeof(Parser), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaType), typeof(XmlNameTable), typeof(SchemaNames), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Nat.Upnp.UpnpSearcher+<ServicesReceived>d__17", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataSet", Member = "ReadXmlDiffgram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(XmlImplementation), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDocument), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlImplementation)}, ReturnType = typeof(void))]
	public XmlDocument() { }

	[CalledBy(Type = typeof(XmlSerializationReader), Member = "get_Document", ReturnType = typeof(XmlDocument))]
	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadXmlDocument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlDocument))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadXmlNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	public XmlDocument(XmlNameTable nt) { }

	[CalledBy(Type = typeof(XmlAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlDocument)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAttribute), Member = "set_Prefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDocument), Member = "CreateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[CalledBy(Type = typeof(XmlDocument), Member = "get_NamespaceXml", ReturnType = typeof(XmlAttribute))]
	[CalledBy(Type = typeof(XmlLoader), Member = "LoadAttributeNode", ReturnType = typeof(XmlAttribute))]
	[CalledBy(Type = typeof(XmlLoader), Member = "LoadDefaultAttribute", ReturnType = typeof(XmlAttribute))]
	[CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo), typeof(XmlDocumentType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(DomNameTable), Member = "AddName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	internal XmlName AddAttrXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	[CalledBy(Type = typeof(XmlDocument), Member = "CreateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(XmlElement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlDocument), Member = "GetSchemaElementDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement)}, ReturnType = typeof(SchemaElementDecl))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(SchemaDeclBase), Member = "get_Prefix", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlDocument), Member = "PrepareDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	internal void AddDefaultAttributes(XmlElement elem) { }

	[CalledBy(Type = typeof(XmlAttribute), Member = "ResetOwnerElementInElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "InsertParentIntoElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "ResetParentInElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlDocument), Member = "GetElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(XmlElement)}, ReturnType = typeof(WeakReference))]
	[Calls(Type = typeof(WeakReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	internal void AddElementWithId(string id, XmlElement elem) { }

	[CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo), typeof(XmlDocumentType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal bool AddIdInfo(XmlName eleName, XmlName attrName) { }

	[CalledBy(Type = typeof(XmlElement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlDocument)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlElement), Member = "set_Prefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo), typeof(XmlDocumentType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DomNameTable), Member = "AddName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[CallsUnknownMethods(Count = 1)]
	internal XmlName AddXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal virtual void AfterEvent(XmlNodeChangedEventArgs args) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDocument), Member = "GetInsertEventArgsForLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNodeChangedEventArgs))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 13)]
	internal virtual XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal virtual void BeforeEvent(XmlNodeChangedEventArgs args) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDocument), Member = "HasNodeTypeInPrevSiblings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(XmlNode)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	internal virtual bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDocument), Member = "HasNodeTypeInPrevSiblings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(XmlNode)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal virtual bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	[CalledBy(Type = typeof(XmlAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlName), typeof(XmlDocument)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlElement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlName), typeof(bool), typeof(XmlDocument)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ValidateNames), Member = "ParseNmtoken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal static void CheckName(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDocument), Member = "ImportNodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(bool)}, ReturnType = typeof(XmlNode))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public virtual XmlNode CloneNode(bool deep) { }

	[CalledBy(Type = typeof(XmlElement), Member = "SetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.XmlDocumentWrapper", Member = "CreateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = "Newtonsoft.Json.Converters.IXmlNode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlNode), Member = "SplitName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public XmlAttribute CreateAttribute(string name) { }

	[CalledBy(Type = "Newtonsoft.Json.Converters.XmlDocumentWrapper", Member = "CreateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = "Newtonsoft.Json.Converters.IXmlNode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlNode), Member = "SplitName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDocument), Member = "AddAttrXmlName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[Calls(Type = typeof(XmlAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlName), typeof(XmlDocument)}, ReturnType = typeof(void))]
	public override XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlLinkedNode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override XmlCDataSection CreateCDataSection(string data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlLinkedNode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override XmlComment CreateComment(string data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUnspecifiedAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlDocument)}, ReturnType = typeof(void))]
	protected private override XmlAttribute CreateDefaultAttribute(string prefix, string localName, string namespaceURI) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDocumentFragment), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument)}, ReturnType = typeof(void))]
	public override XmlDocumentFragment CreateDocumentFragment() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDocumentType), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(XmlDocument)}, ReturnType = typeof(void))]
	public override XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	[CalledBy(Type = "Newtonsoft.Json.Converters.XmlDocumentWrapper", Member = "CreateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "Newtonsoft.Json.Converters.IXmlElement")]
	[CalledBy(Type = "System.Data.DataSet", Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), "System.Data.XmlReadMode", typeof(bool)}, ReturnType = "System.Data.XmlReadMode")]
	[CalledBy(Type = "System.Data.DataTable", Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), "System.Data.XmlReadMode", typeof(bool)}, ReturnType = "System.Data.XmlReadMode")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlNode), Member = "SplitName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public XmlElement CreateElement(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DomNameTable), Member = "AddName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[Calls(Type = typeof(XmlElement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlName), typeof(bool), typeof(XmlDocument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDocument), Member = "AddDefaultAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override XmlElement CreateElement(string prefix, string localName, string namespaceURI) { }

	[CalledBy(Type = "Newtonsoft.Json.Converters.XmlDocumentWrapper", Member = "CreateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = "Newtonsoft.Json.Converters.IXmlElement")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlNode), Member = "SplitName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public XmlElement CreateElement(string qualifiedName, string namespaceURI) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEntityReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlDocument)}, ReturnType = typeof(void))]
	public override XmlEntityReference CreateEntityReference(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDocument), Member = "NormalizeText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(DocumentXPathNavigator), Member = "ResetPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 3)]
	protected private override XPathNavigator CreateNavigator(XmlNode node) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual XPathNavigator CreateNavigator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlProcessingInstruction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlDocument)}, ReturnType = typeof(void))]
	public override XmlProcessingInstruction CreateProcessingInstruction(string target, string data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSignificantWhitespace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlDocument)}, ReturnType = typeof(void))]
	public override XmlSignificantWhitespace CreateSignificantWhitespace(string text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlDocument)}, ReturnType = typeof(void))]
	public override XmlText CreateTextNode(string text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlWhitespace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlDocument)}, ReturnType = typeof(void))]
	public override XmlWhitespace CreateWhitespace(string text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDeclaration), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlDocument)}, ReturnType = typeof(void))]
	public override XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_ActualLoadingStatus() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public virtual string get_BaseURI() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_CanReportValidity() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal override XmlDeclaration get_Declaration() { }

	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "get_Value", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "get_ValueDocument", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlDocument), Member = "IsValidChildType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlDocument), Member = "get_SchemaInfo", ReturnType = typeof(IXmlSchemaInfo))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteXmlNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.XmlDocumentWrapper", Member = "get_DocumentElement", ReturnType = "Newtonsoft.Json.Converters.IXmlElement")]
	[CalledBy(Type = "System.Data.DataSet", Member = "ReadXDRSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataSet", Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(bool)}, ReturnType = "System.Data.XmlReadMode")]
	[CalledBy(Type = "System.Data.DataSet", Member = "InferSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), "System.String[]", "System.Data.XmlReadMode"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataSet", Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), "System.Data.XmlReadMode", typeof(bool)}, ReturnType = "System.Data.XmlReadMode")]
	[CalledBy(Type = "System.Data.DataTable", Member = "ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), "System.Data.XmlReadMode", typeof(bool)}, ReturnType = "System.Data.XmlReadMode")]
	[CalledBy(Type = "System.Data.XmlDataLoader", Member = "LoadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument)}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public XmlElement get_DocumentElement() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override XmlDocumentType get_DocumentType() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	internal SchemaInfo get_DtdSchemaInfo() { }

	[CalledBy(Type = typeof(XmlNodeReaderNavigator), Member = "InitDecAttr", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal string get_Encoding() { }

	[CalledBy(Type = typeof(XmlLoader), Member = "ExpandEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlEntityReference)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal XmlNamedNodeMap get_Entities() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_HasEntityReferences() { }

	[CallerCount(Count = 0)]
	internal bool get_HasSetResolver() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public XmlImplementation get_Implementation() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	internal virtual bool get_IsContainer() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_IsLoading() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool get_IsReadOnly() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	internal virtual XmlLinkedNode get_LastNode() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual string get_LocalName() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual string get_Name() { }

	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "MoveToNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "MoveToFirstNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNamespaceScope)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "MoveToNextNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNamespaceScope)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlDocument), Member = "AddAttrXmlName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[Calls(Type = typeof(XmlAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlName), typeof(XmlDocument)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal XmlAttribute get_NamespaceXml() { }

	[CallerCount(Count = 21)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public XmlNameTable get_NameTable() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual XmlNodeType get_NodeType() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual XmlDocument get_OwnerDocument() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual XmlNode get_ParentNode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDocument), Member = "get_DocumentElement", ReturnType = typeof(XmlElement))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	[CalledBy(Type = typeof(XmlNodeReaderNavigator), Member = "InitDecAttr", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal string get_Standalone() { }

	[CalledBy(Type = typeof(XmlNodeReaderNavigator), Member = "InitDecAttr", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal string get_Version() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal virtual XPathNodeType get_XPNodeType() { }

	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "RemoveNodeAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlDocument), Member = "GetSchemaElementDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement)}, ReturnType = typeof(SchemaElementDecl))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(XmlDocument), Member = "PrepareDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	internal XmlAttribute GetDefaultAttribute(XmlElement elem, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	[CalledBy(Type = typeof(XmlDocument), Member = "AddElementWithId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDocument), Member = "RemoveElementWithId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 23)]
	private WeakReference GetElement(ArrayList elementList, XmlElement elem) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNode), Member = "IsConnected", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	public override XmlElement GetElementById(string elementId) { }

	[CalledBy(Type = typeof(XmlEntityReference), Member = "get_ChildBaseURI", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlDocumentType), Member = "get_Entities", ReturnType = typeof(XmlNamedNodeMap))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	internal XmlEntity GetEntityNode(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNodeChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode), typeof(XmlNode), typeof(string), typeof(string), typeof(XmlNodeChangedAction)}, ReturnType = typeof(void))]
	internal virtual XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDocument), Member = "GetIDInfoByElement_", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlName)}, ReturnType = typeof(XmlName))]
	internal XmlName GetIDInfoByElement(XmlName eleName) { }

	[CalledBy(Type = typeof(XmlAttribute), Member = "PrepareOwnerElementInElementIdAttrMap", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "InsertParentIntoElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "RemoveParentFromElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "PrepareParentInElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlDocument), Member = "GetIDInfoByElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlName)}, ReturnType = typeof(XmlName))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlName), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private XmlName GetIDInfoByElement_(XmlName eleName) { }

	[CalledBy(Type = typeof(XmlAttribute), Member = "AppendChildForLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlDocument)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlDocument), Member = "AppendChildForLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlDocument)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlElement), Member = "AppendChildForLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlDocument)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlNamedNodeMap), Member = "AddNodeForLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlDocument)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlNode), Member = "AppendChildForLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlDocument)}, ReturnType = typeof(XmlNode))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlNodeChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode), typeof(XmlNode), typeof(string), typeof(string), typeof(XmlNodeChangedAction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal XmlNodeChangedEventArgs GetInsertEventArgsForLoad(XmlNode node, XmlNode newParent) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal XmlResolver GetResolver() { }

	[CalledBy(Type = typeof(XmlDocument), Member = "AddDefaultAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDocument), Member = "GetDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private SchemaElementDecl GetSchemaElementDecl(XmlElement elem) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlName), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal XmlName GetXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private bool HasNodeTypeInNextSiblings(XmlNodeType nt, XmlNode refNode) { }

	[CalledBy(Type = typeof(XmlDocument), Member = "CanInsertBefore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlDocument), Member = "CanInsertAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	private bool HasNodeTypeInPrevSiblings(XmlNodeType nt, XmlNode refNode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(XmlDocument), Member = "ImportNodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(bool)}, ReturnType = typeof(XmlNode))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	private void ImportAttributes(XmlNode fromElem, XmlNode toElem) { }

	[CalledBy(Type = typeof(XmlDocument), Member = "ImportNodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(bool)}, ReturnType = typeof(XmlNode))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlDocument), Member = "ImportNodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(bool)}, ReturnType = typeof(XmlNode))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void ImportChildren(XmlNode fromNode, XmlNode toNode, bool deep) { }

	[CalledBy(Type = typeof(XmlDocument), Member = "CloneNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlDocument), Member = "ImportNodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(bool)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlDocument), Member = "ImportAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDocument), Member = "ImportChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(XmlDocument), Member = "ImportNodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(bool)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(XmlDocument), Member = "ImportChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 36)]
	[CallsUnknownMethods(Count = 19)]
	private XmlNode ImportNodeInternal(XmlNode node, bool deep) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal static bool IsTextNode(XmlNodeType nt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDocument), Member = "get_DocumentElement", ReturnType = typeof(XmlElement))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	internal virtual bool IsValidChildType(XmlNodeType type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlLoader), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override void Load(XmlReader reader) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReader), Member = "set_XmlValidatingReaderCompatibilityMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReader), Member = "set_EntityHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EntityHandling)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReader), Member = "set_XmlResolver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public override void LoadXml(string xml) { }

	[CalledBy(Type = typeof(XmlDocument), Member = "CreateNavigator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XPathNavigator))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 1)]
	private XmlNode NormalizeText(XmlNode n) { }

	[CalledBy(Type = typeof(XmlDocument), Member = "AddDefaultAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDocument), Member = "GetDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SchemaDeclBase), Member = "get_DefaultValueRaw", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	private XmlAttribute PrepareDefaultAttribute(SchemaAttDef attdef, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlLoader), Member = "ReadCurrentNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlReader)}, ReturnType = typeof(XmlNode))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override XmlNode ReadNode(XmlReader reader) { }

	[CalledBy(Type = typeof(XmlAttribute), Member = "ResetOwnerElementInElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "RemoveParentFromElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "ResetParentInElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlDocument), Member = "GetElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(XmlElement)}, ReturnType = typeof(WeakReference))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	internal void RemoveElementWithId(string id, XmlElement elem) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 1)]
	public override void Save(XmlWriter w) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_DtdSchemaInfo(SchemaInfo value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_Entities(XmlNamedNodeMap value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public virtual void set_InnerText(string value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void set_InnerXml(string value) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal void set_IsLoading(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual void set_LastNode(XmlLinkedNode value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Schemas(XmlSchemaSet value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NamedPermissionSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PermissionSet), Member = "Demand", ReturnType = typeof(void))]
	[Calls(Type = typeof(SecurityException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public override void set_XmlResolver(XmlResolver value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void SetBaseURI(string inBaseURI) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	internal void SetDefaultNamespace(string prefix, string localName, ref string namespaceURI) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReader), Member = "set_XmlValidatingReaderCompatibilityMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReader), Member = "set_EntityHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EntityHandling)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReader), Member = "set_XmlResolver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private XmlTextReader SetupReader(XmlTextReader tr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNode), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public virtual void WriteContentTo(XmlWriter xw) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void WriteTo(XmlWriter w) { }

}

