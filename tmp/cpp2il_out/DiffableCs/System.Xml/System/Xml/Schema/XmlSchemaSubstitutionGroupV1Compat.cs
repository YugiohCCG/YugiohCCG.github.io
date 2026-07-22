namespace System.Xml.Schema;

internal class XmlSchemaSubstitutionGroupV1Compat : XmlSchemaSubstitutionGroup
{
	private XmlSchemaChoice choice; //Field offset: 0x48

	[XmlIgnore]
	internal XmlSchemaChoice Choice
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		internal get { } //Length: 254
	}

	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Prepare", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaChoice), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public XmlSchemaSubstitutionGroupV1Compat() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	internal XmlSchemaChoice get_Choice() { }

}

