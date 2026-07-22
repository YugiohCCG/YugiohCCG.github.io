namespace System.Xml.Schema;

public class XmlSchemaSequence : XmlSchemaGroupBase
{
	private XmlSchemaObjectCollection items; //Field offset: 0x78

	internal virtual bool IsEmpty
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Decimal), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 170
	}

	[XmlElement("element", typeof(XmlSchemaElement))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	[XmlElement("any", typeof(XmlSchemaAny))]
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	public virtual XmlSchemaObjectCollection Items
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "InferElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataTable", Member = "GetDataTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(XmlSchemaComplexType))]
	[CalledBy(Type = "System.Data.DataSet", Member = "GetDataSetSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(XmlSchemaComplexType))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "InitSequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaContentProcessing)}, ReturnType = typeof(XmlSchemaComplexType))]
	[CalledBy(Type = typeof(Compiler), Member = "CannonicalizeSequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSequence), typeof(bool)}, ReturnType = typeof(XmlSchemaParticle))]
	[CalledBy(Type = typeof(Compiler), Member = "IsElementFromGroupBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaGroupBase)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileComplexContentExtension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaComplexContent), typeof(XmlSchemaComplexContentExtension)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CannonicalizeSequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSequence), typeof(bool), typeof(bool)}, ReturnType = typeof(XmlSchemaParticle))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CannonicalizeAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAll), typeof(bool), typeof(bool)}, ReturnType = typeof(XmlSchemaParticle))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CannonicalizeGroupRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaGroupRef), typeof(bool), typeof(bool)}, ReturnType = typeof(XmlSchemaParticle))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileComplexContentExtension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaComplexContent), typeof(XmlSchemaComplexContentExtension)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CannonicalizeGroupRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaGroupRef), typeof(bool)}, ReturnType = typeof(XmlSchemaParticle))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(XmlSchemaGroupBase), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public XmlSchemaSequence() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Decimal), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal virtual bool get_IsEmpty() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public virtual XmlSchemaObjectCollection get_Items() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual void SetItems(XmlSchemaObjectCollection newItems) { }

}

