namespace System.Xml.Schema;

internal sealed class ConstraintStruct
{
	internal CompiledIdentityConstraint constraint; //Field offset: 0x10
	internal SelectorActiveAxis axisSelector; //Field offset: 0x18
	internal ArrayList axisFields; //Field offset: 0x20
	internal Hashtable qualifiedTable; //Field offset: 0x28
	internal Hashtable keyrefTable; //Field offset: 0x30
	private int tableDim; //Field offset: 0x38

	internal int TableDim
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "AddIdentityConstraints", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "AddIdentityConstraints", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ActiveAxis), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asttree)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	internal ConstraintStruct(CompiledIdentityConstraint constraint) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	internal int get_TableDim() { }

}

