namespace UnityEngine.InputSystem.Layouts;

internal struct InputDeviceBuilder : IDisposable
{
	public struct RefInstance : IDisposable
	{

		[CalledBy(Type = typeof(InputDevice), Member = "Build", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(InputDeviceDescription), typeof(bool)}, ReturnType = "TDevice")]
		[CalledBy(Type = typeof(InputManager), Member = "RecreateDevicesUsingLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "RecreateDevicesUsingLayoutWithInferiorMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceMatcher)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(InputDeviceBuilder), Member = "Reset", ReturnType = typeof(void))]
		[Calls(Type = typeof(CacheRefInstance), Member = "Dispose", ReturnType = typeof(void))]
		public override void Dispose() { }

	}

	private const uint kSizeForControlUsingStateFromOtherControl = 4294967295; //Field offset: 0x0
	private static InputDeviceBuilder s_Instance; //Field offset: 0x0
	private static int s_InstanceRef; //Field offset: 0x28
	private InputDevice m_Device; //Field offset: 0x0
	private CacheRefInstance m_LayoutCacheRef; //Field offset: 0x8
	private Dictionary<String, ControlItem> m_ChildControlOverrides; //Field offset: 0x10
	private List<UInt32> m_StateOffsetToControlMap; //Field offset: 0x18
	private StringBuilder m_StringBuilder; //Field offset: 0x20

	internal static InputDeviceBuilder instance
	{
		[CalledBy(Type = typeof(InputDevice), Member = "Build", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(InputDeviceDescription), typeof(bool)}, ReturnType = "TDevice")]
		[CallerCount(Count = 2)]
		internal get { } //Length: 51
	}

	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "InsertChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&), typeof(ControlItem&)}, ReturnType = typeof(InputControl))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputControl), Member = "get_noisy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControl), Member = "set_dontReset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputControl), Member = "set_isButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputControl), Member = "get_dontReset", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputDevice), Member = "set_hasDontResetControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "set_hasControlsWithDefaultState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputStateBlock), Member = "GetSizeOfPrimitiveFormatInBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FourCC)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArrayHelpers), Member = "GrowBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]&", typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputControl), Member = "get_usesStateFromOtherControl", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NamedValue), Member = "ApplyAllToObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TParameterList"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "TParameterList"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDeviceBuilder), Member = "AddProcessors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(ControlItem&), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayHelpers), Member = "AppendToImmutable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]&", "TValue[]"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ControlItem), Member = "get_dontReset", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControl), Member = "set_usesStateFromOtherControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputControl), Member = "set_synthetic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ControlItem), Member = "get_isSynthetic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControl), Member = "set_noisy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ControlItem), Member = "get_isNoisy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputDeviceBuilder), Member = "InstantiateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(InputDeviceBuilder), Member = "FindOrLoadLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputControlLayout))]
	[Calls(Type = typeof(ControlItem), Member = "Merge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ControlItem)}, ReturnType = typeof(ControlItem))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ControlItem&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Intern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 32)]
	[ContainsUnimplementedInstructions]
	private InputControl AddChildControl(InputControlLayout layout, InternedString variants, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, ControlItem controlItem, int childIndex, string nameOverride = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControlPath), Member = "TryFindChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int)}, ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(InputDeviceBuilder), Member = "InsertChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&), typeof(ControlItem&)}, ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(InputDeviceBuilder), Member = "ComputeStateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void AddChildControlIfMissing(InputControlLayout layout, InternedString variants, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, ref ControlItem controlItem) { }

	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "InstantiateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(InputControl))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputDeviceBuilder), Member = "ComputeStateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDeviceBuilder), Member = "InsertChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&), typeof(ControlItem&)}, ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(InputControlPath), Member = "TryFindChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int)}, ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(InputStateBlock), Member = "get_alignedSizeInBytes", ReturnType = typeof(uint))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputDeviceBuilder), Member = "AddChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&), typeof(ControlItem), typeof(int), typeof(string)}, ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(ArrayHelpers), Member = "GrowBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]&", typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputDeviceBuilder), Member = "InsertChildControlOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(ControlItem&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ControlItem), Member = "get_isArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ControlItem), Member = "get_isModifyingExistingControl", ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringHelpers), Member = "CharacterSeparatedListsHaveAtLeastOneCommonElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	private void AddChildControls(InputControlLayout layout, InternedString variants, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls) { }

	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "InsertControlBitRangeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ControlBitRangeNode&), typeof(InputControl), typeof(Int32&), typeof(ushort)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void AddChildren(ref ControlBitRangeNode parent, ControlBitRangeNode left, ControlBitRangeNode right) { }

	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "InsertControlBitRangeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ControlBitRangeNode&), typeof(InputControl), typeof(Int32&), typeof(ushort)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputDeviceBuilder), Member = "GetControlIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(ArrayHelpers), Member = "InsertAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16[]&), typeof(int), typeof(ushort)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void AddControlToNode(InputControl control, ref int controlIndiciesNextFreeIndex, int nodeIndex) { }

	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "SetDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddParentDisplayNameRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(StringBuilder), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "FinalizeControlHierarchyRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(int), typeof(InputControl[]), typeof(bool), typeof(bool), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputDeviceBuilder), Member = "AddParentDisplayNameRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(StringBuilder), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputControl), Member = "get_shortDisplayName", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControl), Member = "get_displayName", ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 1)]
	private static void AddParentDisplayNameRecursive(InputControl control, StringBuilder stringBuilder, bool shortName) { }

	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&), typeof(ControlItem), typeof(int), typeof(string)}, ReturnType = typeof(InputControl))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(TypeTable), Member = "LookupTypeRegistration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(NamedValue), Member = "ApplyAllToObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TParameterList"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "TParameterList"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private static void AddProcessors(InputControl control, ref ControlItem controlItem, string layoutName) { }

	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "InstantiateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(InputControl))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputControlPath), Member = "TryFindChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int)}, ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(InputControl), Member = "set_usesStateFromOtherControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputControl), Member = "get_dontReset", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControl), Member = "set_dontReset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	private static void ApplyUseStateFrom(InputControl parent, ref ControlItem controlItem, InputControlLayout layout) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private string ChildControlOverridePath(InputControl parent, InternedString controlName) { }

	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "InstantiateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(InputControl))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControlIfMissing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&), typeof(ControlItem&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputControl), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputControl), Member = "get_layout", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputControl), Member = "get_path", ReturnType = typeof(string))]
	[Calls(Type = typeof(MemoryHelpers), Member = "AlignNatural", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(MemoryHelpers), Member = "ComputeFollowingByteOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(InputStateBlock), Member = "GetSizeOfPrimitiveFormatInBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FourCC)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputControl), Member = "get_children", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControl>))]
	[Calls(Type = typeof(InputStateBlock), Member = "get_alignedSizeInBytes", ReturnType = typeof(uint))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 43)]
	private static void ComputeStateLayout(InputControl control) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CacheRefInstance), Member = "Dispose", ReturnType = typeof(void))]
	public override void Dispose() { }

	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InternedString), typeof(InputDeviceDescription)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputDevice), Member = "get_allControls", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControl>))]
	[Calls(Type = typeof(ControlBitRangeNode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDeviceBuilder), Member = "FinalizeControlHierarchyRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(int), typeof(InputControl[]), typeof(bool), typeof(bool), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private void FinalizeControlHierarchy() { }

	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "FinalizeControlHierarchy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "FinalizeControlHierarchyRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(int), typeof(InputControl[]), typeof(bool), typeof(bool), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputControl), Member = "set_isSetupFinished", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDeviceBuilder), Member = "FinalizeControlHierarchyRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(int), typeof(InputControl[]), typeof(bool), typeof(bool), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputControl), Member = "set_dontReset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputControl), Member = "get_dontReset", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControl), Member = "set_noisy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputControl), Member = "get_noisy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputDeviceBuilder), Member = "SetDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(InputControl), Member = "get_displayName", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputDeviceBuilder), Member = "AddParentDisplayNameRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(StringBuilder), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputControl), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "EncodeStateOffsetToControlMapEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(InputDeviceBuilder), Member = "InsertControlBitRangeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ControlBitRangeNode&), typeof(InputControl), typeof(Int32&), typeof(ushort)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputStateBlock), Member = "get_effectiveBitOffset", ReturnType = typeof(uint))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 18)]
	private void FinalizeControlHierarchyRecursive(InputControl control, int controlIndex, InputControl[] allControls, bool noisy, bool dontReset, ref int controlIndiciesNextFreeIndex) { }

	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&), typeof(ControlItem), typeof(int), typeof(string)}, ReturnType = typeof(InputControl))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputControlLayout), Member = "get_cache", ReturnType = typeof(Cache&))]
	[Calls(Type = typeof(Cache), Member = "FindOrLoadLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputControlLayout))]
	private static InputControlLayout FindOrLoadLayout(string name) { }

	[CalledBy(Type = typeof(InputDevice), Member = "Build", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(InputDeviceDescription), typeof(bool)}, ReturnType = "TDevice")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputDevice), Member = "get_allControls", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControl>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[Calls(Type = typeof(InputControl), Member = "get_isButton", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public InputDevice Finish() { }

	[CalledBy(Type = typeof(InputDevice), Member = "Build", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(InputDeviceDescription), typeof(bool)}, ReturnType = "TDevice")]
	[CallerCount(Count = 2)]
	internal static InputDeviceBuilder get_instance() { }

	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "InsertControlBitRangeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ControlBitRangeNode&), typeof(InputControl), typeof(Int32&), typeof(ushort)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputStateBlock), Member = "get_effectiveBitOffset", ReturnType = typeof(uint))]
	[CallsUnknownMethods(Count = 2)]
	private ushort GetBestMidPoint(ControlBitRangeNode parent, ushort startOffset) { }

	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddControlToNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private ushort GetControlIndex(InputControl control) { }

	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControlIfMissing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&), typeof(ControlItem&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputControlPath), Member = "TryFindChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int)}, ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArrayHelpers), Member = "InsertAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDeviceBuilder), Member = "AddChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&), typeof(ControlItem), typeof(int), typeof(string)}, ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 21)]
	private InputControl InsertChildControl(InputControlLayout layout, InternedString variant, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, ref ControlItem controlItem) { }

	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ControlItem&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ControlItem), Member = "Merge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ControlItem)}, ReturnType = typeof(ControlItem))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ControlItem)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void InsertChildControlOverride(InputControl parent, ref ControlItem controlItem) { }

	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "FinalizeControlHierarchyRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(int), typeof(InputControl[]), typeof(bool), typeof(bool), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "InsertControlBitRangeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ControlBitRangeNode&), typeof(InputControl), typeof(Int32&), typeof(ushort)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputDeviceBuilder), Member = "GetBestMidPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ControlBitRangeNode), typeof(ushort)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(ControlBitRangeNode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDeviceBuilder), Member = "AddChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ControlBitRangeNode&), typeof(ControlBitRangeNode), typeof(ControlBitRangeNode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputStateBlock), Member = "get_effectiveBitOffset", ReturnType = typeof(uint))]
	[Calls(Type = typeof(InputDeviceBuilder), Member = "AddControlToNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDeviceBuilder), Member = "InsertControlBitRangeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ControlBitRangeNode&), typeof(InputControl), typeof(Int32&), typeof(ushort)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void InsertControlBitRangeNode(ref ControlBitRangeNode parent, InputControl control, ref int controlIndiciesNextFreeIndex, ushort startOffset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControlLayout), Member = "get_cache", ReturnType = typeof(Cache&))]
	[Calls(Type = typeof(Cache), Member = "FindOrLoadLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputControlLayout))]
	[Calls(Type = typeof(InputDeviceBuilder), Member = "InstantiateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(InputControl))]
	private InputControl InstantiateLayout(InternedString layout, InternedString variants, InternedString name, InputControl parent) { }

	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InternedString), typeof(InputDeviceDescription)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "InstantiateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InternedString), typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(InputControl))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&), typeof(ControlItem), typeof(int), typeof(string)}, ReturnType = typeof(InputControl))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputControlPath), Member = "CleanSlashes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputControl), Member = "get_path", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputDeviceBuilder), Member = "ApplyUseStateFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(ControlItem&), typeof(InputControlLayout)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputDeviceBuilder), Member = "ComputeStateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDeviceBuilder), Member = "AddChildControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputControl), Member = "set_noisy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputControlLayout), Member = "get_canRunInBackground", ReturnType = typeof(System.Nullable`1<System.Boolean>))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(InputControlLayout), Member = "get_isNoisy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 38)]
	[ContainsUnimplementedInstructions]
	private InputControl InstantiateLayout(InputControlLayout layout, InternedString variants, InternedString name, InputControl parent) { }

	[CalledBy(Type = typeof(InputDevice), Member = "Build", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(InputDeviceDescription), typeof(bool)}, ReturnType = "TDevice")]
	[CalledBy(Type = typeof(InputManager), Member = "RecreateDevicesUsingLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "RecreateDevicesUsingLayoutWithInferiorMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceMatcher)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	internal static RefInstance Ref() { }

	[CalledBy(Type = typeof(RefInstance), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void Reset() { }

	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "FinalizeControlHierarchyRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(int), typeof(InputControl[]), typeof(bool), typeof(bool), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControl), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDeviceBuilder), Member = "AddParentDisplayNameRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(StringBuilder), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputControl), Member = "get_shortDisplayName", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputControl), Member = "get_displayName", ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void SetDisplayName(InputControl control, string longDisplayNameFromLayout, string shortDisplayNameFromLayout, bool shortName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputStateBlock), Member = "GetSizeOfPrimitiveFormatInBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FourCC)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private static void SetFormat(InputControl control, ControlItem controlItem) { }

	[CalledBy(Type = typeof(InputDevice), Member = "Build", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(InputDeviceDescription), typeof(bool)}, ReturnType = "TDevice")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputControlLayout), Member = "CacheRef", ReturnType = typeof(CacheRefInstance))]
	[Calls(Type = typeof(InputControlLayout), Member = "get_cache", ReturnType = typeof(Cache&))]
	[Calls(Type = typeof(Cache), Member = "FindOrLoadLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputControlLayout))]
	[Calls(Type = typeof(InputDeviceBuilder), Member = "InstantiateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(InputDeviceBuilder), Member = "FinalizeControlHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32>), Member = "Sort", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(InputControl), Member = "CallFinishSetupRecursive", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void Setup(InternedString layout, InternedString variants, InputDeviceDescription deviceDescription = null) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ShiftChildIndicesInHierarchyOneUp(InputDevice device, int startIndex, InputControl exceptControl) { }

}

