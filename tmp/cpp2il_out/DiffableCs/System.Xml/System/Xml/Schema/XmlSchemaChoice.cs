namespace System.Xml.Schema;

public class XmlSchemaChoice : XmlSchemaGroupBase
{
	private XmlSchemaObjectCollection items; //Field offset: 0x78

	internal virtual bool IsEmpty
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlSchemaParticle), Member = "get_IsEmpty", ReturnType = typeof(bool))]
		internal get { } //Length: 7
	}

	[XmlElement("any", typeof(XmlSchemaAny))]
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	[XmlElement("element", typeof(XmlSchemaElement))]
	public virtual XmlSchemaObjectCollection Items
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "FindMatchingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(XmlReader), typeof(XmlSchemaComplexType), typeof(Int32&), typeof(Boolean&), typeof(XmlSchema), typeof(bool)}, ReturnType = typeof(XmlSchemaElement))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CannonicalizeGroupRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaGroupRef), typeof(bool), typeof(bool)}, ReturnType = typeof(XmlSchemaParticle))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CannonicalizeChoice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaChoice), typeof(bool), typeof(bool)}, ReturnType = typeof(XmlSchemaParticle))]
	[CalledBy(Type = typeof(Compiler), Member = "CannonicalizeElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(XmlSchemaParticle))]
	[CalledBy(Type = typeof(Compiler), Member = "CannonicalizeGroupRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaGroupRef), typeof(bool)}, ReturnType = typeof(XmlSchemaParticle))]
	[CalledBy(Type = typeof(Compiler), Member = "CannonicalizeChoice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaChoice), typeof(bool)}, ReturnType = typeof(XmlSchemaParticle))]
	[CalledBy(Type = typeof(Compiler), Member = "IsElementFromGroupBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaGroupBase)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSchemaSubstitutionGroupV1Compat), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "InitChoice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaParticle), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public XmlSchemaChoice() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaParticle), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	internal virtual bool get_IsEmpty() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public virtual XmlSchemaObjectCollection get_Items() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual void SetItems(XmlSchemaObjectCollection newItems) { }

}

