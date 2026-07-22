namespace UnityEngine.UIElements;

[DefaultMember("Item")]
public struct ToggleButtonGroupState : IEquatable<ToggleButtonGroupState>, IComparable<ToggleButtonGroupState>
{
	[SerializeField]
	private ulong m_Data; //Field offset: 0x0
	[SerializeField]
	private int m_Length; //Field offset: 0x8

	internal ulong data
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	public bool Item
	{
		[CalledBy(Type = typeof(ToggleButtonGroup), Member = "OnOptionChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ToggleButtonGroupState), Member = "GetActiveOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Int32>)}, ReturnType = typeof(System.Span`1<System.Int32>))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 229
		[CalledBy(Type = typeof(ToggleButtonGroup), Member = "set_isMultipleSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ToggleButtonGroup), Member = "OnButtonGroupContainerElementRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ToggleButtonGroup), Member = "OnOptionChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		 set { } //Length: 247
	}

	public internal int length
	{
		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal set { } //Length: 4
	}

	[CalledBy(Type = typeof(ToggleButtonGroup), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ToggleButtonGroupState)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public ToggleButtonGroupState(ulong optionsBitMask, int length) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override int CompareTo(ToggleButtonGroupState other) { }

	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(ToggleButtonGroupState other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	internal ulong get_data() { }

	[CalledBy(Type = typeof(ToggleButtonGroup), Member = "OnOptionChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ToggleButtonGroupState), Member = "GetActiveOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Int32>)}, ReturnType = typeof(System.Span`1<System.Int32>))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	public bool get_Item(int index) { }

	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	public int get_length() { }

	[CalledBy(Type = typeof(ToggleButtonGroup), Member = "set_isMultipleSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ToggleButtonGroup), Member = "set_allowEmptySelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ToggleButtonGroup), Member = "OnButtonGroupContainerElementRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ToggleButtonGroup), Member = "UpdateButtonStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ToggleButtonGroupState)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ToggleButtonGroup), Member = "OnOptionChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ToggleButtonGroupState), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public Span<Int32> GetActiveOptions(Span<Int32> activeOptionsIndices) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashCode), Member = "Combine", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(int)}, ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(ToggleButtonGroupState lhs, ToggleButtonGroupState rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(ToggleButtonGroupState lhs, ToggleButtonGroupState rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void ResetAllOptions() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private void ResetOptions(int startingIndex) { }

	[CalledBy(Type = typeof(ToggleButtonGroup), Member = "set_isMultipleSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ToggleButtonGroup), Member = "OnButtonGroupContainerElementRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ToggleButtonGroup), Member = "OnOptionChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public void set_Item(int index, bool value) { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void set_length(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "PadLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

}

