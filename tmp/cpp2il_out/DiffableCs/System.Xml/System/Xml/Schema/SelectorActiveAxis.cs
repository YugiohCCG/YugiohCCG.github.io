namespace System.Xml.Schema;

internal class SelectorActiveAxis : ActiveAxis
{
	private ConstraintStruct cs; //Field offset: 0x28
	private ArrayList KSs; //Field offset: 0x30
	private int KSpointer; //Field offset: 0x38

	public int lastDepth
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 159
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActiveAxis), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asttree)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public SelectorActiveAxis(Asttree axisTree, ConstraintStruct cs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AxisStack), Member = "MoveToParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public virtual bool EndElement(string localname, string URN) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public int get_lastDepth() { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "EndElementIdentityConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(XmlSchemaDatatype)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "EndElementIdentityConstraints", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public KeySequence PopKS() { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ElementIdentityConstraints", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ElementIdentityConstraints", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ActiveAxis), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asttree)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 13)]
	public int PushKS(int errline, int errcol) { }

}

