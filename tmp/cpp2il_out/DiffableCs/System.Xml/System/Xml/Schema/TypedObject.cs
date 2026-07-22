namespace System.Xml.Schema;

internal class TypedObject
{
	private class DecimalStruct
	{
		private bool isDecimal; //Field offset: 0x10
		private Decimal[] dvalue; //Field offset: 0x18

		public Decimal[] Dvalue
		{
			[CallerCount(Count = 31)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public bool IsDecimal
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

		[CalledBy(Type = typeof(TypedObject), Member = "SetDecimal", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public DecimalStruct() { }

		[CalledBy(Type = typeof(TypedObject), Member = "SetDecimal", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public DecimalStruct(int dim) { }

		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		public Decimal[] get_Dvalue() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public bool get_IsDecimal() { }

		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public void set_IsDecimal(bool value) { }

	}

	private DecimalStruct dstruct; //Field offset: 0x10
	private object ovalue; //Field offset: 0x18
	private string svalue; //Field offset: 0x20
	private XmlSchemaDatatype xsdtype; //Field offset: 0x28
	private int dim; //Field offset: 0x30
	private bool isList; //Field offset: 0x34

	public int Dim
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public Decimal[] Dvalue
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 27
	}

	public bool IsDecimal
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 27
	}

	public bool IsList
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public XmlSchemaDatatype Type
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public object Value
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "AttributeIdentityConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(string), typeof(XmlSchemaDatatype)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "EndElementIdentityConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(XmlSchemaDatatype)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "AttributeIdentityConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(string), typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "EndElementIdentityConstraints", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public TypedObject(object obj, string svalue, XmlSchemaDatatype xsdtype) { }

	[CalledBy(Type = typeof(KeySequence), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TypedObject), Member = "SetDecimal", ReturnType = typeof(void))]
	[Calls(Type = typeof(Decimal), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public bool Equals(TypedObject other) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public int get_Dim() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public Decimal[] get_Dvalue() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public bool get_IsDecimal() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_IsList() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public XmlSchemaDatatype get_Type() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public object get_Value() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Decimal), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private bool ListDValueEquals(TypedObject other) { }

	[CalledBy(Type = typeof(TypedObject), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypedObject)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(KeySequence), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DecimalStruct), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DecimalStruct), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Array), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void SetDecimal() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}

