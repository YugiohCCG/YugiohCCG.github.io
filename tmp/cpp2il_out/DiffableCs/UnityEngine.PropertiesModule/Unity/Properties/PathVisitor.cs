namespace Unity.Properties;

public abstract class PathVisitor : IPropertyBagVisitor, IPropertyVisitor
{
	[IsReadOnly]
	private struct PropertyScope : IDisposable
	{
		private readonly PathVisitor m_Visitor; //Field offset: 0x0
		private readonly IProperty m_Property; //Field offset: 0x8

		[CalledBy(Type = typeof(PathVisitor), Member = "Unity.Properties.IPropertyVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>", "TContainer&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		public PropertyScope(PathVisitor visitor, IProperty property) { }

		[CalledBy(Type = typeof(PathVisitor), Member = "Unity.Properties.IPropertyVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>", "TContainer&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public override void Dispose() { }

	}

	private int m_PathIndex; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private PropertyPath <Path>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private IProperty <Property>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <ReadonlyVisit>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private VisitReturnCode <ReturnCode>k__BackingField; //Field offset: 0xB4

	public PropertyPath Path
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 84
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		 set { } //Length: 91
	}

	private IProperty Property
	{
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 19
	}

	public bool ReadonlyVisit
	{
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	public VisitReturnCode ReturnCode
	{
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected PathVisitor() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public PropertyPath get_Path() { }

	[CallerCount(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private IProperty get_Property() { }

	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_ReadonlyVisit() { }

	[CallerCount(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public VisitReturnCode get_ReturnCode() { }

	[CalledBy(Type = "UnityEngine.UIElements.BindingUpdater+UIPathVisitor", Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.SetValueVisitor`1", Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.PropertyContainer+GetValueVisitor`1", Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public override void Reset() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	public void set_Path(PropertyPath value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Property(IProperty value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_ReadonlyVisit(bool value) { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_ReturnCode(VisitReturnCode value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyPath), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(PropertyPathPart))]
	[Calls(Type = typeof(PropertyPathPart), Member = "get_Key", ReturnType = typeof(object))]
	[Calls(Type = typeof(AttributesScope), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyPathPart), Member = "get_Index", ReturnType = typeof(int))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyPathPart), Member = "get_Name", ReturnType = typeof(string))]
	[Calls(Type = "System.Threading.Tasks.DebuggerSupport", Member = "AddToActiveTasksNonInlined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[Calls(Type = "System.Threading.Tasks.DebuggerSupport", Member = "RemoveFromActiveTasksNonInlined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 50)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private override void Unity.Properties.IPropertyBagVisitor.Visit(IPropertyBag<TContainer> properties, ref TContainer container) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyBag), Member = "TryGetPropertyBagForValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), typeof(IPropertyBag&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PropertyScope), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathVisitor), typeof(IProperty)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyContainer), Member = "Accept", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPropertyBagVisitor), typeof(Int32Enum&), typeof(VisitParameters)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyScope), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	private override void Unity.Properties.IPropertyVisitor.Visit(Property<TContainer, TValue> property, ref TContainer container) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void VisitPath(Property<TContainer, TValue> property, ref TContainer container, ref TValue value) { }

}

