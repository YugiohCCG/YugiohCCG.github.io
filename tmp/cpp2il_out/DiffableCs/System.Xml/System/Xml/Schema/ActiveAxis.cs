namespace System.Xml.Schema;

internal class ActiveAxis
{
	private int _currentDepth; //Field offset: 0x10
	private bool _isActive; //Field offset: 0x14
	private Asttree _axisTree; //Field offset: 0x18
	private ArrayList _axisStack; //Field offset: 0x20

	public int CurrentDepth
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = typeof(ConstraintStruct), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledIdentityConstraint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocatedActiveAxis), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asttree), typeof(KeySequence), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SelectorActiveAxis), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asttree), typeof(ConstraintStruct)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SelectorActiveAxis), Member = "PushKS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(AxisStack), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	internal ActiveAxis(Asttree axisTree) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AxisStack), Member = "MoveToParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override bool EndElement(string localname, string URN) { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public int get_CurrentDepth() { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "AttributeIdentityConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(string), typeof(XmlSchemaDatatype)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "AttributeIdentityConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(string), typeof(SchemaAttDef)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AxisStack), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public bool MoveToAttribute(string localname, string URN) { }

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ElementIdentityConstraints", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidator), Member = "ElementIdentityConstraints", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AxisStack), Member = "MoveToChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public bool MoveToStartElement(string localname, string URN) { }

	[CallerCount(Count = 0)]
	internal void Reactivate() { }

}

