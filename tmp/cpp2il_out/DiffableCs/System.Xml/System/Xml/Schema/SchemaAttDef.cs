namespace System.Xml.Schema;

internal sealed class SchemaAttDef : SchemaDeclBase, IDtdDefaultAttributeInfo, IDtdAttributeInfo
{
	public enum Reserve
	{
		None = 0,
		XmlSpace = 1,
		XmlLang = 2,
	}

	public static readonly SchemaAttDef Empty; //Field offset: 0x0
	private string defExpanded; //Field offset: 0x60
	private int lineNum; //Field offset: 0x68
	private int linePos; //Field offset: 0x6C
	private int valueLineNum; //Field offset: 0x70
	private int valueLinePos; //Field offset: 0x74
	private Reserve reserved; //Field offset: 0x78
	private bool defaultValueChecked; //Field offset: 0x7C
	private XmlSchemaAttribute schemaAttribute; //Field offset: 0x80

	internal bool DefaultValueChecked
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal string DefaultValueExpanded
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		internal get { } //Length: 30
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal int LineNumber
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	internal int LinePosition
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	internal Reserve Reserved
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	internal XmlSchemaAttribute SchemaAttribute
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 16
	}

	private override bool System.Xml.IDtdAttributeInfo.IsDeclaredInExternal
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	private override bool System.Xml.IDtdAttributeInfo.IsNonCDataType
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 44
	}

	private override bool System.Xml.IDtdAttributeInfo.IsXmlAttribute
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		private get { } //Length: 8
	}

	private override int System.Xml.IDtdAttributeInfo.LineNumber
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private get { } //Length: 4
	}

	private override int System.Xml.IDtdAttributeInfo.LinePosition
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private get { } //Length: 4
	}

	private override string System.Xml.IDtdAttributeInfo.LocalName
	{
		[CallerCount(Count = 6)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 27
	}

	private override string System.Xml.IDtdAttributeInfo.Prefix
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SchemaDeclBase), Member = "get_Prefix", ReturnType = typeof(string))]
		private get { } //Length: 7
	}

	private override string System.Xml.IDtdDefaultAttributeInfo.DefaultValueExpanded
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		private get { } //Length: 30
	}

	private override object System.Xml.IDtdDefaultAttributeInfo.DefaultValueTyped
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	private override int System.Xml.IDtdDefaultAttributeInfo.ValueLineNumber
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		private get { } //Length: 4
	}

	private override int System.Xml.IDtdDefaultAttributeInfo.ValueLinePosition
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		private get { } //Length: 4
	}

	internal XmlTokenizedType TokenizedType
	{
		[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 39
		[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(SchemaElementDecl), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(XmlSchemaDatatype), Member = "FromXmlTokenizedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType)}, ReturnType = typeof(XmlSchemaDatatype))]
		[CallsUnknownMethods(Count = 1)]
		internal set { } //Length: 41
	}

	internal int ValueLineNumber
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	internal int ValueLinePosition
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SchemaDeclBase), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static SchemaAttDef() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SchemaDeclBase), Member = ".ctor", ReturnType = typeof(void))]
	private SchemaAttDef() { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_InitAttributeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_BeginAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SchemaDeclBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(string)}, ReturnType = typeof(void))]
	public SchemaAttDef(XmlQualifiedName name, string prefix) { }

	[CalledBy(Type = typeof(Compiler), Member = "CompileAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SchemaDeclBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(string)}, ReturnType = typeof(void))]
	public SchemaAttDef(XmlQualifiedName name) { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 2)]
	internal void CheckXmlSpace(IValidationEventHandling validationEventHandling) { }

	[CalledBy(Type = typeof(Compiler), Member = "CompileAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_EndRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_EndElementType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = "XDR_BeginAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XdrBuilder)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal SchemaAttDef Clone() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_DefaultValueChecked() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	internal string get_DefaultValueExpanded() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal int get_LineNumber() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal int get_LinePosition() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal Reserve get_Reserved() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal XmlSchemaAttribute get_SchemaAttribute() { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal XmlTokenizedType get_TokenizedType() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	internal int get_ValueLineNumber() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	internal int get_ValueLinePosition() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_DefaultValueExpanded(string value) { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	internal void set_LineNumber(int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_LinePosition(int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_Reserved(Reserve value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_SchemaAttribute(XmlSchemaAttribute value) { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(SchemaElementDecl), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlSchemaDatatype), Member = "FromXmlTokenizedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType)}, ReturnType = typeof(XmlSchemaDatatype))]
	[CallsUnknownMethods(Count = 1)]
	internal void set_TokenizedType(XmlTokenizedType value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_ValueLineNumber(int value) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal void set_ValueLinePosition(int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private override bool System.Xml.IDtdAttributeInfo.get_IsDeclaredInExternal() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private override bool System.Xml.IDtdAttributeInfo.get_IsNonCDataType() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private override bool System.Xml.IDtdAttributeInfo.get_IsXmlAttribute() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private override int System.Xml.IDtdAttributeInfo.get_LineNumber() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private override int System.Xml.IDtdAttributeInfo.get_LinePosition() { }

	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override string System.Xml.IDtdAttributeInfo.get_LocalName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SchemaDeclBase), Member = "get_Prefix", ReturnType = typeof(string))]
	private override string System.Xml.IDtdAttributeInfo.get_Prefix() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	private override string System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueExpanded() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	private override object System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueTyped() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	private override int System.Xml.IDtdDefaultAttributeInfo.get_ValueLineNumber() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	private override int System.Xml.IDtdDefaultAttributeInfo.get_ValueLinePosition() { }

}

