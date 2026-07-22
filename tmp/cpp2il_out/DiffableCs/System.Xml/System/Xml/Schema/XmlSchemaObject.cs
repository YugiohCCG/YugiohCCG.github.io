namespace System.Xml.Schema;

public abstract class XmlSchemaObject
{
	private int lineNum; //Field offset: 0x10
	private int linePos; //Field offset: 0x14
	private string sourceUri; //Field offset: 0x18
	private XmlSerializerNamespaces namespaces; //Field offset: 0x20
	private XmlSchemaObject parent; //Field offset: 0x28
	private bool isProcessing; //Field offset: 0x30

	[XmlIgnore]
	internal override string IdAttribute
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		internal set { } //Length: 3
	}

	[XmlIgnore]
	internal bool IsProcessing
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	[XmlIgnore]
	public int LineNumber
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[XmlIgnore]
	public int LinePosition
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[XmlIgnore]
	internal override string NameAttribute
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		internal set { } //Length: 3
	}

	[XmlNamespaceDeclarations]
	public XmlSerializerNamespaces Namespaces
	{
		[CalledBy(Type = typeof(XmlSchemaInference), Member = "InferSchema1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlSchemaSet)}, ReturnType = typeof(XmlSchemaSet))]
		[CalledBy(Type = typeof(XmlSchemaInference), Member = "CreateNewElementforChoice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(XmlSchemaElement))]
		[CalledBy(Type = typeof(Preprocessor), Member = "GetBuildInSchema", ReturnType = typeof(XmlSchema))]
		[CalledBy(Type = typeof(SchemaNamespaceManager), Member = "LookupNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(SchemaNamespaceManager), Member = "LookupPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(XsdBuilder), Member = "StartChildren", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Data.XSDSchema", Member = "GetPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CalledBy(Type = "System.Data.XSDSchema", Member = "GetNamespaceFromPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CallerCount(Count = 8)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 105
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[XmlIgnore]
	public XmlSchemaObject Parent
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[XmlIgnore]
	public string SourceUri
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected XmlSchemaObject() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal override XmlSchemaObject Clone() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal override string get_IdAttribute() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal bool get_IsProcessing() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public int get_LineNumber() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public int get_LinePosition() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal override string get_NameAttribute() { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "InferSchema1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlSchemaSet)}, ReturnType = typeof(XmlSchemaSet))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "CreateNewElementforChoice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(XmlSchemaElement))]
	[CalledBy(Type = typeof(Preprocessor), Member = "GetBuildInSchema", ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = typeof(SchemaNamespaceManager), Member = "LookupNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SchemaNamespaceManager), Member = "LookupPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "StartChildren", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "GetPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "GetNamespaceFromPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public XmlSerializerNamespaces get_Namespaces() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public XmlSchemaObject get_Parent() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public string get_SourceUri() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal override void OnAdd(XmlSchemaObjectCollection container, object item) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal override void OnClear(XmlSchemaObjectCollection container) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal override void OnRemove(XmlSchemaObjectCollection container, object item) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal override void set_IdAttribute(string value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_IsProcessing(bool value) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public void set_LineNumber(int value) { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public void set_LinePosition(int value) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal override void set_NameAttribute(string value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Namespaces(XmlSerializerNamespaces value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Parent(XmlSchemaObject value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_SourceUri(string value) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

}

