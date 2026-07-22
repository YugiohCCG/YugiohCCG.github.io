namespace System.Xml;

internal class XmlNodeReaderNavigator
{
	public struct VirtualAttribute
	{
		internal string name; //Field offset: 0x0
		internal string value; //Field offset: 0x8

		[CallerCount(Count = 68)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal VirtualAttribute(string name, string value) { }

	}

	private XmlNode curNode; //Field offset: 0x10
	private XmlNode elemNode; //Field offset: 0x18
	private XmlNode logNode; //Field offset: 0x20
	private int attrIndex; //Field offset: 0x28
	private int logAttrIndex; //Field offset: 0x2C
	private XmlNameTable nameTable; //Field offset: 0x30
	private XmlDocument doc; //Field offset: 0x38
	private int nAttrInd; //Field offset: 0x40
	private int nDeclarationAttrCount; //Field offset: 0x44
	private int nDocTypeAttrCount; //Field offset: 0x48
	private int nLogLevel; //Field offset: 0x4C
	private int nLogAttrInd; //Field offset: 0x50
	private bool bLogOnAttrVal; //Field offset: 0x54
	private bool bCreatedOnAttribute; //Field offset: 0x55
	internal VirtualAttribute[] decNodeAttributes; //Field offset: 0x58
	internal VirtualAttribute[] docTypeNodeAttributes; //Field offset: 0x60
	private bool bOnAttrVal; //Field offset: 0x68

	public int AttributeCount
	{
		[CalledBy(Type = typeof(XmlNodeReaderNavigator), Member = "CheckIndexCondition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlNodeReader), Member = "get_AttributeCount", ReturnType = typeof(int))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "InitDocTypeAttr", ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "InitDecAttr", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 316
	}

	public string BaseURI
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 39
	}

	internal bool CreatedOnAttribute
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	public XmlDocument Document
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool IsDefault
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 167
	}

	public bool IsEmptyElement
	{
		[CalledBy(Type = typeof(XmlNodeReader), Member = "get_IsEmptyElement", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlNodeReader), Member = "ReadNextNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlNodeReader), Member = "ReadAtZeroLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 154
	}

	private bool IsOnDeclOrDocType
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 57
	}

	public string LocalName
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsInvalidInstructions]
		 get { } //Length: 148
	}

	public string Name
	{
		[CalledBy(Type = typeof(XmlNodeReader), Member = "get_Name", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 244
	}

	public string NamespaceURI
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public XmlNameTable NameTable
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public XmlNodeType NodeType
	{
		[CalledBy(Type = typeof(XmlNodeReader), Member = "ReadNextNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlNodeReader), Member = "ReadForward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 62
	}

	public string Prefix
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public IXmlSchemaInfo SchemaInfo
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 39
	}

	public string Value
	{
		[CalledBy(Type = typeof(XmlNodeReader), Member = "get_Value", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "InitDecAttr", ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 639
	}

	public string XmlLang
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 39
	}

	public XmlSpace XmlSpace
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 39
	}

	[CalledBy(Type = typeof(XmlNodeReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 28)]
	public XmlNodeReaderNavigator(XmlNode node) { }

	[CalledBy(Type = typeof(XmlNodeReaderNavigator), Member = "GetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlNodeReaderNavigator), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "get_AttributeCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private void CheckIndexCondition(int attributeIndex) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	internal string DefaultLookupNamespace(string prefix) { }

	[CalledBy(Type = typeof(XmlNodeReaderNavigator), Member = "CheckIndexCondition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNodeReader), Member = "get_AttributeCount", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "InitDocTypeAttr", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "InitDecAttr", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public int get_AttributeCount() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string get_BaseURI() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_CreatedOnAttribute() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public XmlDocument get_Document() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool get_IsDefault() { }

	[CalledBy(Type = typeof(XmlNodeReader), Member = "get_IsEmptyElement", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlNodeReader), Member = "ReadNextNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlNodeReader), Member = "ReadAtZeroLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool get_IsEmptyElement() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool get_IsOnDeclOrDocType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsInvalidInstructions]
	public string get_LocalName() { }

	[CalledBy(Type = typeof(XmlNodeReader), Member = "get_Name", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public string get_Name() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public string get_NamespaceURI() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public XmlNameTable get_NameTable() { }

	[CalledBy(Type = typeof(XmlNodeReader), Member = "ReadNextNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlNodeReader), Member = "ReadForward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public XmlNodeType get_NodeType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public string get_Prefix() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public IXmlSchemaInfo get_SchemaInfo() { }

	[CalledBy(Type = typeof(XmlNodeReader), Member = "get_Value", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "InitDecAttr", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public string get_Value() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string get_XmlLang() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public XmlSpace get_XmlSpace() { }

	[CalledBy(Type = typeof(XmlNodeReader), Member = "GetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "CheckIndexCondition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "InitDocTypeAttr", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "InitDecAttr", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public string GetAttribute(int attributeIndex) { }

	[CalledBy(Type = typeof(XmlNodeReader), Member = "GetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "GetDeclarationAttr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDeclaration), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	public string GetAttribute(string name) { }

	[CalledBy(Type = typeof(XmlNodeReader), Member = "GetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "GetDeclarationAttr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDeclaration), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	public string GetAttribute(string name, string ns) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private string GetAttributeFromElement(XmlElement elem, string name) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private string GetAttributeFromElement(XmlElement elem, string name, string ns) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "InitDecAttr", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public int GetDecAttrInd(string name) { }

	[CalledBy(Type = typeof(XmlNodeReaderNavigator), Member = "GetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlNodeReaderNavigator), Member = "GetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public string GetDeclarationAttr(XmlDeclaration decl, string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "InitDecAttr", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public string GetDeclarationAttr(int i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "InitDocTypeAttr", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public int GetDocTypeAttrInd(string name) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public string GetDocumentTypeAttr(XmlDocumentType docType, string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "InitDocTypeAttr", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public string GetDocumentTypeAttr(int i) { }

	[CalledBy(Type = typeof(XmlNodeReader), Member = "System.Xml.IXmlNamespaceResolver.GetNamespacesInScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNamespaceScope)}, ReturnType = typeof(System.Collections.Generic.IDictionary`2<System.String, System.String>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallsUnknownMethods(Count = 3)]
	internal IDictionary<String, String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	[CalledBy(Type = typeof(XmlNodeReaderNavigator), Member = "get_Value", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlNodeReaderNavigator), Member = "get_AttributeCount", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlNodeReaderNavigator), Member = "GetDeclarationAttr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlNodeReaderNavigator), Member = "GetDecAttrInd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlNodeReaderNavigator), Member = "GetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlNodeReaderNavigator), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlNodeReaderNavigator), Member = "MoveToNextAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(XmlDocument), Member = "get_Version", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlDocument), Member = "get_Encoding", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlDocument), Member = "get_Standalone", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 8)]
	private void InitDecAttr() { }

	[CalledBy(Type = typeof(XmlNodeReaderNavigator), Member = "get_AttributeCount", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlNodeReaderNavigator), Member = "GetDocumentTypeAttr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlNodeReaderNavigator), Member = "GetDocTypeAttrInd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlNodeReaderNavigator), Member = "GetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlNodeReaderNavigator), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlNodeReaderNavigator), Member = "MoveToNextAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void InitDocTypeAttr() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool IsLocalNameEmpty(XmlNodeType nt) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void LogMove(int level) { }

	[CalledBy(Type = typeof(XmlNodeReaderNavigator), Member = "LookupPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlNodeReader), Member = "LookupNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlNodeReader), Member = "System.Xml.IXmlNamespaceResolver.LookupNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 3)]
	public string LookupNamespace(string prefix) { }

	[CalledBy(Type = typeof(XmlNodeReader), Member = "System.Xml.IXmlNamespaceResolver.LookupPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "LookupNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallsUnknownMethods(Count = 3)]
	internal string LookupPrefix(string namespaceName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	public bool MoveToAttribute(string name) { }

	[CalledBy(Type = typeof(XmlNodeReaderNavigator), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlNodeReader), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "InitDecAttr", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "InitDocTypeAttr", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "MoveToAttributeFromElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public bool MoveToAttribute(string name, string namespaceURI) { }

	[CalledBy(Type = typeof(XmlNodeReader), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNodeReader), Member = "MoveToFirstAttribute", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "CheckIndexCondition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlAttribute))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public void MoveToAttribute(int attributeIndex) { }

	[CalledBy(Type = typeof(XmlNodeReaderNavigator), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "FindNodeOffsetNS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private bool MoveToAttributeFromElement(XmlElement elem, string name, string ns) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool MoveToElement() { }

	[CalledBy(Type = typeof(XmlNodeReader), Member = "ReadNextNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool MoveToFirstChild() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public bool MoveToNext() { }

	[CalledBy(Type = typeof(XmlNodeReader), Member = "MoveToNextAttribute", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "InitDocTypeAttr", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNodeReaderNavigator), Member = "InitDecAttr", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlAttribute))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 4)]
	public bool MoveToNextAttribute(ref int level) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool MoveToNextSibling(XmlNode node) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool MoveToParent() { }

	[CalledBy(Type = typeof(XmlNodeReader), Member = "ReadAttributeValue", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public bool ReadAttributeValue(ref int level, ref bool bResolveEntity, ref XmlNodeType nt) { }

	[CalledBy(Type = typeof(XmlNodeReader), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlNodeReader), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNodeReader), Member = "MoveToFirstAttribute", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlNodeReader), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlNodeReader), Member = "ReSetReadingMarks", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 6)]
	public void ResetMove(ref int level, ref XmlNodeType nt) { }

	[CalledBy(Type = typeof(XmlNodeReader), Member = "MoveToNextAttribute", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlNodeReader), Member = "MoveToElement", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void ResetToAttribute(ref int level) { }

	[CalledBy(Type = typeof(XmlNodeReader), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void RollBackMove(ref int level) { }

}

