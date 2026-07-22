namespace System.Xml.Schema;

internal class XmlSchemaSubstitutionGroup : XmlSchemaObject
{
	private ArrayList membersList; //Field offset: 0x38
	private XmlQualifiedName examplar; //Field offset: 0x40

	[XmlIgnore]
	internal XmlQualifiedName Examplar
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	[XmlIgnore]
	internal ArrayList Members
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CalledBy(Type = typeof(Compiler), Member = "ProcessSubstitutionGroups", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public XmlSchemaSubstitutionGroup() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal XmlQualifiedName get_Examplar() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	internal ArrayList get_Members() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_Examplar(XmlQualifiedName value) { }

}

