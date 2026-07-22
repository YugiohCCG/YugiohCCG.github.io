namespace UnityEngine.InputSystem;

[DebuggerDisplay("{DebuggerDisplay(),nq}")]
[DefaultMember("Item")]
public abstract class InputControl
{
	[Flags]
	public enum ControlFlags
	{
		ConfigUpToDate = 1,
		IsNoisy = 2,
		IsSynthetic = 4,
		IsButton = 8,
		DontReset = 16,
		SetupFinished = 32,
		UsesStateFromOtherControl = 64,
	}

	protected private InputStateBlock m_StateBlock; //Field offset: 0x10
	internal InternedString m_Name; //Field offset: 0x20
	internal string m_Path; //Field offset: 0x30
	internal string m_DisplayName; //Field offset: 0x38
	internal string m_DisplayNameFromLayout; //Field offset: 0x40
	internal string m_ShortDisplayName; //Field offset: 0x48
	internal string m_ShortDisplayNameFromLayout; //Field offset: 0x50
	internal InternedString m_Layout; //Field offset: 0x58
	internal InternedString m_Variants; //Field offset: 0x68
	internal InputDevice m_Device; //Field offset: 0x78
	internal InputControl m_Parent; //Field offset: 0x80
	internal int m_UsageCount; //Field offset: 0x88
	internal int m_UsageStartIndex; //Field offset: 0x8C
	internal int m_AliasCount; //Field offset: 0x90
	internal int m_AliasStartIndex; //Field offset: 0x94
	internal int m_ChildCount; //Field offset: 0x98
	internal int m_ChildStartIndex; //Field offset: 0x9C
	internal ControlFlags m_ControlFlags; //Field offset: 0xA0
	internal bool m_CachedValueIsStale; //Field offset: 0xA4
	internal bool m_UnprocessedCachedValueIsStale; //Field offset: 0xA5
	internal PrimitiveValue m_DefaultState; //Field offset: 0xA8
	internal PrimitiveValue m_MinValue; //Field offset: 0xB8
	internal PrimitiveValue m_MaxValue; //Field offset: 0xC8
	internal FourCC m_OptimizedControlDataType; //Field offset: 0xD8

	public ReadOnlyArray<InternedString> aliases
	{
		[CalledBy(Type = typeof(InputControlPath), Member = "MatchControlsRecursive", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int), "UnityEngine.InputSystem.InputControlList`1<TControl>&", typeof(bool)}, ReturnType = "TControl")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 119
	}

	public ReadOnlyArray<InputControl> children
	{
		[CalledBy(Type = typeof(InputControlExtensions), Member = "FindControlsRecursive", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), "System.Collections.Generic.IList`1<TControl>", "System.Func`2<TControl, Boolean>"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputControlPath), Member = "TryFindChild", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int)}, ReturnType = "TControl")]
		[CalledBy(Type = typeof(InputControlPath), Member = "MatchChildrenRecursive", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int), "UnityEngine.InputSystem.InputControlList`1<TControl>&", typeof(bool)}, ReturnType = "TControl")]
		[CalledBy(Type = typeof(Touchscreen), Member = "FinishSetup", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "IsControlOrChildUsingLayoutRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InternedString)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputManager), Member = "RemoveControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "ResetControlPathsRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "ComputeStateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 119
	}

	protected private Void* currentStatePtr
	{
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(InputControl), Member = "GetDeviceIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(InputStateBuffers), Member = "GetFrontBufferForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Void*))]
		private get { } //Length: 24
	}

	protected private Void* defaultStatePtr
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 54
	}

	public InputDevice device
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string displayName
	{
		[CalledBy(Type = "Extensions.HotkeyInput", Member = "UpdateData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Enumerator.Hotkeys", typeof(int), "Enumerator.HotkeyType"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputControlPath), Member = "ToHumanReadableString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(String&), typeof(HumanReadableStringOptions), typeof(InputControl)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(InputControlPath), Member = "MatchControlsRecursive", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int), "UnityEngine.InputSystem.InputControlList`1<TControl>&", typeof(bool)}, ReturnType = "TControl")]
		[CalledBy(Type = typeof(Keyboard), Member = "FindKeyOnCurrentKeyboardLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(KeyControl))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "SetDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddParentDisplayNameRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(StringBuilder), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "FinalizeControlHierarchyRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(int), typeof(InputControl[]), typeof(bool), typeof(bool), typeof(Int32&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[CallsDeduplicatedMethods(Count = 2)]
		 get { } //Length: 102
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	internal bool dontReset
	{
		[CalledBy(Type = typeof(InputManager), Member = "InitializeDeviceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&), typeof(ControlItem), typeof(int), typeof(string)}, ReturnType = typeof(InputControl))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "ApplyUseStateFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(ControlItem&), typeof(InputControlLayout)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "FinalizeControlHierarchyRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(int), typeof(InputControl[]), typeof(bool), typeof(bool), typeof(Int32&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		internal get { } //Length: 12
		[CallerCount(Count = 53)]
		internal set { } //Length: 31
	}

	internal bool hasDefaultState
	{
		[CalledBy(Type = typeof(InputManager), Member = "InitializeDefaultState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "InitializeDeviceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AxisControl), Member = "FinishSetup", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal get { } //Length: 25
	}

	internal bool isButton
	{
		[CalledBy(Type = typeof(InputActionState), Member = "ProcessButtonState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TriggerState&), typeof(int), typeof(BindingState*)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TouchSimulation), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "Finish", ReturnType = typeof(InputDevice))]
		[CalledBy(Type = typeof(OneModifierComposite), Member = "DetermineValueTypeAndSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&), typeof(int), typeof(Type&), typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		internal get { } //Length: 12
		[CallerCount(Count = 172)]
		internal set { } //Length: 31
	}

	internal bool isConfigUpToDate
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 10
		[CallerCount(Count = 0)]
		internal set { } //Length: 31
	}

	internal bool isSetupFinished
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 12
		[CallerCount(Count = 464)]
		internal set { } //Length: 31
	}

	public InputControl Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputControlPath), Member = "TryFindChild", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int)}, ReturnType = "TControl")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 173
	}

	public string layout
	{
		[CalledBy(Type = typeof(InputControlPath), Member = "MatchControlsRecursive", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int), "UnityEngine.InputSystem.InputControlList`1<TControl>&", typeof(bool)}, ReturnType = "TControl")]
		[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+NewDeviceMsg", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(Message))]
		[CalledBy(Type = typeof(InputManager), Member = "IsControlUsingLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InternedString)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HIDSupport), Member = "set_supportedHIDUsages", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.HID.HIDSupport+HIDPageUsage>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputEventTrace), Member = "OnInputEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "ComputeStateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 30
	}

	public float magnitude
	{
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(InputControl), Member = "GetDeviceIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(InputStateBuffers), Member = "GetFrontBufferForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Void*))]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 53
	}

	public string name
	{
		[CalledBy(Type = typeof(InputControl), Member = "GetDeviceIndex", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(InputControlPath), Member = "MatchControlsRecursive", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int), "UnityEngine.InputSystem.InputControlList`1<TControl>&", typeof(bool)}, ReturnType = "TControl")]
		[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+NewDeviceMsg", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(Message))]
		[CalledBy(Type = "UnityEngine.InputSystem.InputManager+<>c", Member = "<MakeDeviceNameUnique>b__192_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "MakeDeviceNameUnique", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "AssignUniqueDeviceId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "SetDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "ComputeStateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "FinalizeControlHierarchyRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(int), typeof(InputControl[]), typeof(bool), typeof(bool), typeof(Int32&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DpadAxisControl), Member = "FinishSetup", ReturnType = typeof(void))]
		[CallerCount(Count = 16)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 30
	}

	protected private Void* noiseMaskPtr
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 55
	}

	public internal bool noisy
	{
		[CalledBy(Type = typeof(InputManager), Member = "InitializeDeviceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "UpdateState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputUpdateType), typeof(Void*), typeof(uint), typeof(uint), typeof(double), typeof(InputEventPtr)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&), typeof(ControlItem), typeof(int), typeof(string)}, ReturnType = typeof(InputControl))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "FinalizeControlHierarchyRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(int), typeof(InputControl[]), typeof(bool), typeof(bool), typeof(Int32&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
		[CalledBy(Type = typeof(InputControl), Member = "set_noisy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ControlBuilder), Member = "IsNoisy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ControlBuilder))]
		[CalledBy(Type = typeof(DeviceBuilder), Member = "IsNoisy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DeviceBuilder))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "InstantiateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(InputControl))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&), typeof(ControlItem), typeof(int), typeof(string)}, ReturnType = typeof(InputControl))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "FinalizeControlHierarchyRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(int), typeof(InputControl[]), typeof(bool), typeof(bool), typeof(Int32&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
		[Calls(Type = typeof(InputControl), Member = "set_noisy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		internal set { } //Length: 331
	}

	public FourCC optimizedControlDataType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public InputControl parent
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public string path
	{
		[CallerCount(Count = 24)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputControl), Member = "get_path", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 262
	}

	protected private Void* previousFrameStatePtr
	{
		[CalledBy(Type = typeof(InputControl`1), Member = "ReadValueFromPreviousFrame", ReturnType = "TValue")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InputControl), Member = "GetDeviceIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(InputStateBuffers), Member = "GetBackBufferForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Void*))]
		private get { } //Length: 24
	}

	public string shortDisplayName
	{
		[CalledBy(Type = "Extensions.HotkeyInput", Member = "UpdateData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Enumerator.Hotkeys", typeof(int), "Enumerator.HotkeyType"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputControlPath), Member = "ToHumanReadableString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(String&), typeof(HumanReadableStringOptions), typeof(InputControl)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "SetDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddParentDisplayNameRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(StringBuilder), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 83
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public InputStateBlock stateBlock
	{
		[CallerCount(Count = 17)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	protected private uint stateOffsetRelativeToDeviceRoot
	{
		[CalledBy(Type = typeof(InputControlExtensions), Member = "WriteValueIntoState", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TState"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputControl`1<TValue>", "TValue", "TState&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 93
	}

	public internal bool synthetic
	{
		[CalledBy(Type = typeof(RebindingOperation), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
		[CallerCount(Count = 122)]
		internal set { } //Length: 31
	}

	public ReadOnlyArray<InternedString> usages
	{
		[CalledBy(Type = typeof(InputSystem), Member = "GetDevice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = "TDevice")]
		[CalledBy(Type = typeof(ParsedPathComponent), Member = "Matches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputControlPath), Member = "MatchControlsRecursive", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int), "UnityEngine.InputSystem.InputControlList`1<TControl>&", typeof(bool)}, ReturnType = "TControl")]
		[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+NewDeviceMsg", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(Message))]
		[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+ChangeUsageMsg", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(Message))]
		[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+ChangeUsageMsg", Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(Message)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "SetDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "AddDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "RemoveDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
		[CallerCount(Count = 13)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 119
	}

	internal bool usesStateFromOtherControl
	{
		[CalledBy(Type = typeof(InputManager), Member = "InitializeDeviceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&), typeof(ControlItem), typeof(int), typeof(string)}, ReturnType = typeof(InputControl))]
		[CallerCount(Count = 3)]
		internal get { } //Length: 12
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&), typeof(ControlItem), typeof(int), typeof(string)}, ReturnType = typeof(InputControl))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "ApplyUseStateFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(ControlItem&), typeof(InputControlLayout)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		internal set { } //Length: 31
	}

	public abstract int valueSizeInBytes
	{
		 get { } //Length: 0
	}

	public abstract Type valueType
	{
		 get { } //Length: 0
	}

	public string variants
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 30
	}

	[CalledBy(Type = typeof(InputControl`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected InputControl() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal override void AddProcessor(object first) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControl), Member = "MarkAsStaleRecursively", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void ApplyParameterChanges() { }

	[CalledBy(Type = typeof(InputControl), Member = "BakeOffsetIntoStateBlockRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "RemoveDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputStateBuffers), Member = "MigrateAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice[]), typeof(int), typeof(InputStateBuffers)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputControl), Member = "BakeOffsetIntoStateBlockRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal void BakeOffsetIntoStateBlockRecursive(uint offset) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	protected override FourCC CalculateOptimizedControlDataType() { }

	[CalledBy(Type = typeof(InputControl), Member = "CallFinishSetupRecursive", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InternedString), typeof(InputDeviceDescription)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputControl), Member = "CallFinishSetupRecursive", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	internal void CallFinishSetupRecursive() { }

	public abstract bool CompareValue(Void* firstStatePtr, Void* secondStatePtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControl), Member = "get_path", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputControl), Member = "GetDeviceIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputStateBuffers), Member = "GetFrontBufferForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private string DebuggerDisplay() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControl), Member = "get_path", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 12)]
	[Conditional("UNITY_EDITOR")]
	internal void EnsureOptimizationTypeHasNotChanged() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override float EvaluateMagnitude(Void* statePtr) { }

	[CallerCount(Count = 9)]
	[Calls(Type = typeof(InputControl), Member = "GetDeviceIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputStateBuffers), Member = "GetFrontBufferForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Void*))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public float EvaluateMagnitude() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void FinishSetup() { }

	[CalledBy(Type = typeof(InputControlPath), Member = "MatchControlsRecursive", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int), "UnityEngine.InputSystem.InputControlList`1<TControl>&", typeof(bool)}, ReturnType = "TControl")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ReadOnlyArray<InternedString> get_aliases() { }

	[CalledBy(Type = typeof(InputControlExtensions), Member = "FindControlsRecursive", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), "System.Collections.Generic.IList`1<TControl>", "System.Func`2<TControl, Boolean>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputControlPath), Member = "TryFindChild", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int)}, ReturnType = "TControl")]
	[CalledBy(Type = typeof(InputControlPath), Member = "MatchChildrenRecursive", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int), "UnityEngine.InputSystem.InputControlList`1<TControl>&", typeof(bool)}, ReturnType = "TControl")]
	[CalledBy(Type = typeof(Touchscreen), Member = "FinishSetup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "IsControlOrChildUsingLayoutRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InternedString)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputManager), Member = "RemoveControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "ResetControlPathsRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "ComputeStateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ReadOnlyArray<InputControl> get_children() { }

	[CallerCount(Count = 23)]
	[Calls(Type = typeof(InputControl), Member = "GetDeviceIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputStateBuffers), Member = "GetFrontBufferForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Void*))]
	protected private Void* get_currentStatePtr() { }

	[CallerCount(Count = 0)]
	protected private Void* get_defaultStatePtr() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public InputDevice get_device() { }

	[CalledBy(Type = "Extensions.HotkeyInput", Member = "UpdateData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Enumerator.Hotkeys", typeof(int), "Enumerator.HotkeyType"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputControlPath), Member = "ToHumanReadableString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(String&), typeof(HumanReadableStringOptions), typeof(InputControl)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputControlPath), Member = "MatchControlsRecursive", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int), "UnityEngine.InputSystem.InputControlList`1<TControl>&", typeof(bool)}, ReturnType = "TControl")]
	[CalledBy(Type = typeof(Keyboard), Member = "FindKeyOnCurrentKeyboardLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(KeyControl))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "SetDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddParentDisplayNameRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(StringBuilder), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "FinalizeControlHierarchyRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(int), typeof(InputControl[]), typeof(bool), typeof(bool), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 2)]
	public string get_displayName() { }

	[CalledBy(Type = typeof(InputManager), Member = "InitializeDeviceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&), typeof(ControlItem), typeof(int), typeof(string)}, ReturnType = typeof(InputControl))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "ApplyUseStateFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(ControlItem&), typeof(InputControlLayout)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "FinalizeControlHierarchyRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(int), typeof(InputControl[]), typeof(bool), typeof(bool), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	internal bool get_dontReset() { }

	[CalledBy(Type = typeof(InputManager), Member = "InitializeDefaultState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "InitializeDeviceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AxisControl), Member = "FinishSetup", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal bool get_hasDefaultState() { }

	[CalledBy(Type = typeof(InputActionState), Member = "ProcessButtonState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TriggerState&), typeof(int), typeof(BindingState*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchSimulation), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "Finish", ReturnType = typeof(InputDevice))]
	[CalledBy(Type = typeof(OneModifierComposite), Member = "DetermineValueTypeAndSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&), typeof(int), typeof(Type&), typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	internal bool get_isButton() { }

	[CallerCount(Count = 0)]
	internal bool get_isConfigUpToDate() { }

	[CallerCount(Count = 0)]
	internal bool get_isSetupFinished() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControlPath), Member = "TryFindChild", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int)}, ReturnType = "TControl")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public InputControl get_Item(string path) { }

	[CalledBy(Type = typeof(InputControlPath), Member = "MatchControlsRecursive", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int), "UnityEngine.InputSystem.InputControlList`1<TControl>&", typeof(bool)}, ReturnType = "TControl")]
	[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+NewDeviceMsg", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(Message))]
	[CalledBy(Type = typeof(InputManager), Member = "IsControlUsingLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InternedString)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HIDSupport), Member = "set_supportedHIDUsages", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.HID.HIDSupport+HIDPageUsage>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputEventTrace), Member = "OnInputEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "ComputeStateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string get_layout() { }

	[CallerCount(Count = 9)]
	[Calls(Type = typeof(InputControl), Member = "GetDeviceIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputStateBuffers), Member = "GetFrontBufferForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Void*))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public float get_magnitude() { }

	[CalledBy(Type = typeof(InputControl), Member = "GetDeviceIndex", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputControlPath), Member = "MatchControlsRecursive", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int), "UnityEngine.InputSystem.InputControlList`1<TControl>&", typeof(bool)}, ReturnType = "TControl")]
	[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+NewDeviceMsg", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(Message))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputManager+<>c", Member = "<MakeDeviceNameUnique>b__192_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "MakeDeviceNameUnique", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "AssignUniqueDeviceId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "SetDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "ComputeStateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "FinalizeControlHierarchyRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(int), typeof(InputControl[]), typeof(bool), typeof(bool), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DpadAxisControl), Member = "FinishSetup", ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string get_name() { }

	[CallerCount(Count = 0)]
	protected private Void* get_noiseMaskPtr() { }

	[CalledBy(Type = typeof(InputManager), Member = "InitializeDeviceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "UpdateState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputUpdateType), typeof(Void*), typeof(uint), typeof(uint), typeof(double), typeof(InputEventPtr)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&), typeof(ControlItem), typeof(int), typeof(string)}, ReturnType = typeof(InputControl))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "FinalizeControlHierarchyRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(int), typeof(InputControl[]), typeof(bool), typeof(bool), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	public bool get_noisy() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public FourCC get_optimizedControlDataType() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public InputControl get_parent() { }

	[CallerCount(Count = 24)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControl), Member = "get_path", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public string get_path() { }

	[CalledBy(Type = typeof(InputControl`1), Member = "ReadValueFromPreviousFrame", ReturnType = "TValue")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputControl), Member = "GetDeviceIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputStateBuffers), Member = "GetBackBufferForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Void*))]
	protected private Void* get_previousFrameStatePtr() { }

	[CalledBy(Type = "Extensions.HotkeyInput", Member = "UpdateData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Enumerator.Hotkeys", typeof(int), "Enumerator.HotkeyType"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputControlPath), Member = "ToHumanReadableString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(String&), typeof(HumanReadableStringOptions), typeof(InputControl)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "SetDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddParentDisplayNameRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(StringBuilder), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string get_shortDisplayName() { }

	[CallerCount(Count = 17)]
	[DeduplicatedMethod]
	public InputStateBlock get_stateBlock() { }

	[CalledBy(Type = typeof(InputControlExtensions), Member = "WriteValueIntoState", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TState"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputControl`1<TValue>", "TValue", "TState&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected private uint get_stateOffsetRelativeToDeviceRoot() { }

	[CalledBy(Type = typeof(RebindingOperation), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_synthetic() { }

	[CalledBy(Type = typeof(InputSystem), Member = "GetDevice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = "TDevice")]
	[CalledBy(Type = typeof(ParsedPathComponent), Member = "Matches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlPath), Member = "MatchControlsRecursive", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int), "UnityEngine.InputSystem.InputControlList`1<TControl>&", typeof(bool)}, ReturnType = "TControl")]
	[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+NewDeviceMsg", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(Message))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+ChangeUsageMsg", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(Message))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+ChangeUsageMsg", Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(Message)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "SetDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "AddDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "RemoveDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ReadOnlyArray<InternedString> get_usages() { }

	[CalledBy(Type = typeof(InputManager), Member = "InitializeDeviceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&), typeof(ControlItem), typeof(int), typeof(string)}, ReturnType = typeof(InputControl))]
	[CallerCount(Count = 3)]
	internal bool get_usesStateFromOtherControl() { }

	public abstract int get_valueSizeInBytes() { }

	public abstract Type get_valueType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string get_variants() { }

	[CalledBy(Type = typeof(InputControl), Member = "GetChildControl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "TControl")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlPath), Member = "TryFindChild", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int)}, ReturnType = "TControl")]
	[Calls(Type = typeof(InputControl), Member = "MakeChildPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	public InputControl GetChildControl(string path) { }

	[CallerCount(Count = 261)]
	[Calls(Type = typeof(InputControl), Member = "GetChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 32)]
	[DeduplicatedMethod]
	public TControl GetChildControl(string path) { }

	[CalledBy(Type = typeof(InputControl), Member = "get_magnitude", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "GetFirstButtonPressOrNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(float), typeof(bool)}, ReturnType = typeof(InputControl))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "HasValueChangeInEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "HasValueChangeInState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Void*)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "CompareState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Void*), typeof(Void*)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "CompareStateIgnoringNoise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Void*)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "CheckStateIsAtDefaultIgnoringNoise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "CopyState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "WriteValueIntoState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Void*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "CheckStateIsAtDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "ReadValueAsObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "IsActuated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(float)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "IsPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(float)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputEventControlEnumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice), typeof(Enumerate), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputControl), Member = "get_previousFrameStatePtr", ReturnType = typeof(Void*))]
	[CalledBy(Type = typeof(InputControl), Member = "get_currentStatePtr", ReturnType = typeof(Void*))]
	[CalledBy(Type = typeof(InputControl), Member = "EvaluateMagnitude", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(InputControl), Member = "DebuggerDisplay", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "ReadValueIntoBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(InputControl), Member = "get_path", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputControl), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 19)]
	internal int GetDeviceIndex() { }

	[CalledBy(Type = typeof(InputActionState), Member = "OnBeforeInitialUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "ProcessControlStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(double), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ButtonControl), Member = "get_pressPointOrDefault", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool IsValueConsideredPressed(float value) { }

	[CalledBy(Type = typeof(InputControl), Member = "GetChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputControl))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputControl), Member = "get_path", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	internal string MakeChildPath(string path) { }

	[CallerCount(Count = 0)]
	internal void MarkAsStale() { }

	[CalledBy(Type = typeof(InputControl), Member = "ApplyParameterChanges", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "ApplySettings", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[Calls(Type = typeof(ButtonControl), Member = "UpdateWasPressed", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	internal void MarkAsStaleRecursively() { }

	public abstract object ReadValueFromBufferAsObject(Void* buffer, int bufferSize) { }

	public abstract object ReadValueFromStateAsObject(Void* statePtr) { }

	public abstract void ReadValueFromStateIntoBuffer(Void* statePtr, Void* bufferPtr, int bufferSize) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void RefreshConfiguration() { }

	[CalledBy(Type = typeof(Keyboard), Member = "get_keyboardLayout", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(KeyControl), Member = "get_scanCode", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void RefreshConfigurationIfNeeded() { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected void set_displayName(string value) { }

	[CallerCount(Count = 53)]
	internal void set_dontReset(bool value) { }

	[CallerCount(Count = 172)]
	internal void set_isButton(bool value) { }

	[CallerCount(Count = 0)]
	internal void set_isConfigUpToDate(bool value) { }

	[CallerCount(Count = 464)]
	internal void set_isSetupFinished(bool value) { }

	[CalledBy(Type = typeof(InputControl), Member = "set_noisy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ControlBuilder), Member = "IsNoisy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ControlBuilder))]
	[CalledBy(Type = typeof(DeviceBuilder), Member = "IsNoisy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DeviceBuilder))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "InstantiateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(InputControl))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&), typeof(ControlItem), typeof(int), typeof(string)}, ReturnType = typeof(InputControl))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "FinalizeControlHierarchyRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(int), typeof(InputControl[]), typeof(bool), typeof(bool), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputControl), Member = "set_noisy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal void set_noisy(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected void set_shortDisplayName(string value) { }

	[CallerCount(Count = 122)]
	internal void set_synthetic(bool value) { }

	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&), typeof(ControlItem), typeof(int), typeof(string)}, ReturnType = typeof(InputControl))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "ApplyUseStateFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(ControlItem&), typeof(InputControlLayout)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	internal void set_usesStateFromOtherControl(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SetOptimizedControlDataType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	internal void SetOptimizedControlDataTypeRecursively() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControl), Member = "get_path", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual string ToString() { }

	[CalledBy(Type = typeof(InputControl), Member = "TryGetChildControl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "TControl")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlPath), Member = "TryFindChild", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int)}, ReturnType = "TControl")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public InputControl TryGetChildControl(string path) { }

	[CalledBy(Type = typeof(Joystick), Member = "FinishSetup", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControl), Member = "TryGetChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = "System.Linq.Expressions.Interpreter.InterpretedFrame", Member = "Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Interpreter.InterpretedFrame"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 46)]
	[DeduplicatedMethod]
	public TControl TryGetChildControl(string path) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override void WriteValueFromBufferIntoState(Void* bufferPtr, int bufferSize, Void* statePtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override void WriteValueFromObjectIntoState(object value, Void* statePtr) { }

}

