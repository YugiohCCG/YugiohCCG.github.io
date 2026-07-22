namespace System.Xml.Schema;

[DefaultMember("Item")]
internal class KeySequence
{
	private TypedObject[] ks; //Field offset: 0x10
	private int dim; //Field offset: 0x18
	private int hashcode; //Field offset: 0x1C
	private int posline; //Field offset: 0x20
	private int poscol; //Field offset: 0x24

	public object Item
	{
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 43
		[CalledBy(Type = typeof(XmlSchemaValidator), Member = "AttributeIdentityConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(string), typeof(XmlSchemaDatatype)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaValidator), Member = "EndElementIdentityConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(XmlSchemaDatatype)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdValidator), Member = "AttributeIdentityConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(string), typeof(SchemaAttDef)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdValidator), Member = "EndElementIdentityConstraints", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 8)]
		 set { } //Length: 270
	}

	public int PosCol
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int PosLine
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal KeySequence(int dim, int line, int col) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypedObject), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypedObject)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	public virtual bool Equals(object other) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public object get_Item(int index) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public int get_PosCol() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public int get_PosLine() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypedObject), Member = "SetDecimal", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Decimal), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "EndElementIdentityConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(XmlSchemaDatatype)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "EndElementIdentityConstraints", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	internal bool IsQualified() { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "AttributeIdentityConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(string), typeof(XmlSchemaDatatype)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "EndElementIdentityConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(XmlSchemaDatatype)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "AttributeIdentityConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(string), typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "EndElementIdentityConstraints", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	public void set_Item(int index, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public virtual string ToString() { }

}

