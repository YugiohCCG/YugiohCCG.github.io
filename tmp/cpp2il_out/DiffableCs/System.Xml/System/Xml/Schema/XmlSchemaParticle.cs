namespace System.Xml.Schema;

public abstract class XmlSchemaParticle : XmlSchemaAnnotated
{
	private class EmptyParticle : XmlSchemaParticle
	{

		internal virtual bool IsEmpty
		{
			[CallerCount(Count = 23)]
			[DeduplicatedMethod]
			internal get { } //Length: 3
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public EmptyParticle() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		internal virtual bool get_IsEmpty() { }

	}

	[Flags]
	private enum Occurs
	{
		None = 0,
		Min = 1,
		Max = 2,
	}

	internal static readonly XmlSchemaParticle Empty; //Field offset: 0x0
	private decimal minOccurs; //Field offset: 0x50
	private decimal maxOccurs; //Field offset: 0x60
	private Occurs flags; //Field offset: 0x70

	internal override bool IsEmpty
	{
		[CalledBy(Type = typeof(XmlSchemaAll), Member = "get_IsEmpty", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlSchemaChoice), Member = "get_IsEmpty", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Decimal), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
		internal get { } //Length: 127
	}

	[XmlIgnore]
	public decimal MaxOccurs
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 31)]
		[Calls(Type = typeof(Decimal), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Decimal), Member = "Truncate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(Decimal))]
		[Calls(Type = typeof(Decimal), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Decimal), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 410
	}

	[XmlAttribute("maxOccurs")]
	public string MaxOccursString
	{
		[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaGroup)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "IsElementFromGroupBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaGroupBase), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "PreprocessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "PreprocessGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaGroup)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Decimal), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(string))]
		 get { } //Length: 276
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "IsElementFromGroupBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaGroupBase), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XsdBuilder), Member = "SetMaxOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(XmlConvert), Member = "ToInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Decimal))]
		[Calls(Type = typeof(Decimal), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Decimal), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 557
	}

	[XmlIgnore]
	public decimal MinOccurs
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 42)]
		[Calls(Type = typeof(Decimal), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Decimal), Member = "Truncate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(Decimal))]
		[Calls(Type = typeof(Decimal), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 317
	}

	[XmlAttribute("minOccurs")]
	public string MinOccursString
	{
		[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaGroup)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "IsGroupBaseFromAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaGroupBase), typeof(XmlSchemaAny)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "IsElementFromGroupBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaGroupBase), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "PreprocessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "PreprocessGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaGroup)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Compiler), Member = "IsGroupBaseFromAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaGroupBase), typeof(XmlSchemaAny)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(string))]
		 get { } //Length: 110
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "IsGroupBaseFromAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaGroupBase), typeof(XmlSchemaAny)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "IsElementFromGroupBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaGroupBase), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Compiler), Member = "IsGroupBaseFromAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaGroupBase), typeof(XmlSchemaAny)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XsdBuilder), Member = "SetMinOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(XmlConvert), Member = "ToInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Decimal))]
		[Calls(Type = typeof(Decimal), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 359
	}

	internal override string NameString
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 18
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static XmlSchemaParticle() { }

	[CalledBy(Type = typeof(XmlSchemaAll), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaAny), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaChoice), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaContentProcessing)}, ReturnType = typeof(XmlSchemaComplexType))]
	[CalledBy(Type = typeof(XmlSchemaElement), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaGroupBase), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaGroupRef), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected XmlSchemaParticle() { }

	[CalledBy(Type = typeof(XmlSchemaAll), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSchemaChoice), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Decimal), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	internal override bool get_IsEmpty() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public decimal get_MaxOccurs() { }

	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaGroup)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "IsElementFromGroupBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaGroupBase), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "PreprocessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "PreprocessGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaGroup)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decimal), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(string))]
	public string get_MaxOccursString() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public decimal get_MinOccurs() { }

	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaGroup)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "IsGroupBaseFromAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaGroupBase), typeof(XmlSchemaAny)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "IsElementFromGroupBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaGroupBase), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "PreprocessElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "PreprocessGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaGroup)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "IsGroupBaseFromAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaGroupBase), typeof(XmlSchemaAny)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(string))]
	public string get_MinOccursString() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal override string get_NameString() { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "PrintExpectedElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal XmlQualifiedName GetQualifiedName() { }

	[CallerCount(Count = 31)]
	[Calls(Type = typeof(Decimal), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Decimal), Member = "Truncate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Decimal), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_MaxOccurs(decimal value) { }

	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "IsElementFromGroupBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaGroupBase), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "SetMaxOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlConvert), Member = "ToInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Decimal), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void set_MaxOccursString(string value) { }

	[CallerCount(Count = 42)]
	[Calls(Type = typeof(Decimal), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Decimal), Member = "Truncate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_MinOccurs(decimal value) { }

	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "IsGroupBaseFromAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaGroupBase), typeof(XmlSchemaAny)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "IsElementFromGroupBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaGroupBase), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Compiler), Member = "IsGroupBaseFromAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaGroupBase), typeof(XmlSchemaAny)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "SetMinOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XmlConvert), Member = "ToInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_MinOccursString(string value) { }

}

