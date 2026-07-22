namespace UnityEngine.InputSystem.Utilities;

[Extension]
internal static class ArrayHelpers
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public TValue secondValue; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass33_0`1() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		internal bool <Merge>b__0(TValue x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public IEqualityComparer<TValue> comparer; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass34_0`1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_1
	{
		public TValue secondValue; //Field offset: 0x0
		public <>c__DisplayClass34_0<TValue> CS$<>8__locals1; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass34_1`1() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		internal bool <Merge>b__0(TValue x) { }

	}


	[CalledBy(Type = typeof(ControlSchemeSyntax), Member = "AddDeviceEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Flags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "AddControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(InputControlScheme)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+NewLayoutMsg", Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(Message)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputRemoting), Member = "System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Message)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "RegisterControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MatcherJson), Member = "FromMatcher", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceMatcher)}, ReturnType = typeof(MatcherJson))]
	[CalledBy(Type = typeof(InputDeviceMatcher), Member = "WithManufacturerContains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputDeviceMatcher))]
	[CalledBy(Type = typeof(InputDeviceMatcher), Member = "With", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(object), typeof(bool)}, ReturnType = typeof(InputDeviceMatcher))]
	[CalledBy(Type = typeof(InputDeviceMatcher), Member = "FromDeviceDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription)}, ReturnType = typeof(InputDeviceMatcher))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public static int Append(ref TValue[] array, TValue value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 25)]
	[DeduplicatedMethod]
	public static int Append(ref TValue[] array, IEnumerable<TValue> values) { }

	[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputControlList`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TControl")]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public static int AppendListWithCapacity(ref TValue[] array, ref int length, TValues values, int capacityIncrement = 10) { }

	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&), typeof(ControlItem), typeof(int), typeof(string)}, ReturnType = typeof(InputControl))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static int AppendToImmutable(ref TValue[] array, TValue[] values) { }

	[CalledBy(Type = typeof(InputDevice), Member = "AddDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StateChangeMonitorsForDevice), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(IInputStateChangeMonitor), typeof(long), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlinedArray`1), Member = "AppendWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public static int AppendWithCapacity(ref TValue[] array, ref int count, TValue value, int capacityIncrement = 10) { }

	[CalledBy(Type = typeof(InputControlList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TControl>", typeof(Allocator)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputControlList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TControl[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputControlList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static int AppendWithCapacity(ref NativeArray<TValue>& array, ref int count, TValue value, int capacityIncrement = 10, Allocator allocator = 4) { }

	[CalledBy(Type = typeof(DeviceArray), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Extension]
	public static void Clear(TValue[] array, ref int count) { }

	[CalledBy(Type = typeof(FingerAndTouchState), Member = "UpdateActiveTouches", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchSimulation), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Extension]
	public static void Clear(TValue[] array) { }

	[CalledBy(Type = typeof(StateChangeMonitorsForDevice), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "FlushDisconnectedDevices", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchSimulation), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Extension]
	public static void Clear(TValue[] array, int count) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 14)]
	[DeduplicatedMethod]
	public static TValue[] Clone(TValue[] array) { }

	[CalledBy(Type = typeof(RemoteInputPlayerConnection), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEditorPlayerConnection), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RemoteInputPlayerConnection), Member = "OnConnected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RemoteInputPlayerConnection), Member = "OnDisconnected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static bool Contains(TValue[] array, TValue value) { }

	[CalledBy(Type = typeof(InputActionMap), Member = "SetUpPerActionControlAndBindingArrays", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	public static bool ContainsReference(TFirst[] array, int startIndex, int count, TSecond value) { }

	[CalledBy(Type = typeof(InputUser), Member = "GetUnpairedInputDevices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlList`1<InputDevice>&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputUser), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchSimulation), Member = "AddPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Pointer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchSimulation), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	public static bool ContainsReference(TFirst[] array, int count, TSecond value) { }

	[CalledBy(Type = typeof(InputActionMap), Member = "SetUpPerActionControlAndBindingArrays", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "SwitchControlSchemeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme&), typeof(InputDevice[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	public static bool ContainsReference(TValue[] array, TValue value) { }

	[CalledBy(Type = typeof(InputActionState), Member = "Clone", ReturnType = typeof(InputActionState))]
	[CalledBy(Type = typeof(InputActionState), Member = "System.ICloneable.Clone", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(InlinedArray`1), Member = "Clone", ReturnType = "UnityEngine.InputSystem.Utilities.InlinedArray`1<TValue>")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static TValue[] Copy(TValue[] array) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static void DuplicateWithCapacity(ref TValue[] array, int count, int capacity, int capacityIncrement = 10) { }

	[CalledBy(Type = typeof(FingerAndTouchState), Member = "AddFingers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touchscreen)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArrayHelpers), Member = "InsertAtWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]&", typeof(Int32&), typeof(int), "TValue", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public static void EnsureCapacity(ref TValue[] array, int count, int capacity, int capacityIncrement = 10) { }

	[CalledBy(Type = typeof(RemoteInputPlayerConnection), Member = "OnDisconnected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public static bool Erase(ref TValue[] array, TValue value) { }

	[CalledBy(Type = typeof(BindingSyntax), Member = "Erase", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "RemoveAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "RemoveControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+DisconnectMsg", Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(Message)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputRemoting), Member = "RemoveRemoteDevices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchSimulation), Member = "RemovePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Pointer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public static void EraseAt(ref TValue[] array, int index) { }

	[CalledBy(Type = typeof(InlinedArray`1), Member = "RemoveAtByMovingTailWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static void EraseAtByMovingTail(TValue[] array, ref int count, int index) { }

	[CalledBy(Type = typeof(InputControlList`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlList`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static void EraseAtWithCapacity(NativeArray<TValue> array, ref int count, int index) { }

	[CalledBy(Type = typeof(RebindingOperation), Member = "RemoveCandidate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDevice), Member = "RemoveDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StateChangeMonitorsForDevice), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessStateChangeMonitors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Void*), typeof(Void*), typeof(uint), typeof(uint)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputUser), Member = "RemoveUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlinedArray`1), Member = "RemoveAtWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	public static void EraseAtWithCapacity(TValue[] array, ref int count, int index) { }

	[CalledBy(Type = typeof(InputUser), Member = "RemoveLostDevicesForUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FingerAndTouchState), Member = "RemoveFingers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touchscreen)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public static void EraseSliceWithCapacity(ref TValue[] array, ref int length, int index, int count) { }

	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&), typeof(ControlItem), typeof(int), typeof(string)}, ReturnType = typeof(InputControl))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public static int GrowBy(ref TValue[] array, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static int GrowBy(ref NativeArray<TValue>& array, int count, Allocator allocator = 4) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static int GrowWithCapacity(ref TValue[] array, ref int count, int growBy, int capacityIncrement = 10) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static int GrowWithCapacity(ref NativeArray<TValue>& array, ref int count, int growBy, int capacityIncrement = 10, Allocator allocator = 4) { }

	[CalledBy(Type = typeof(InputActionMap), Member = "SetUpPerActionControlAndBindingArrays", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	public static bool HaveDuplicateReferences(TFirst[] first, int index, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool HaveEqualElements(TValue[] first, TValue[] second, int count = 2147483647) { }

	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "RemoveAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Extension]
	public static int IndexOf(TValue[] array, Predicate<TValue> predicate) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static int IndexOf(TValue[] array, TValue value, int startIndex = 0, int count = -1) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[Extension]
	public static int IndexOf(TValue[] array, Predicate<TValue> predicate, int startIndex = 0, int count = -1) { }

	[CalledBy(Type = typeof(Joystick), Member = "OnRemoved", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "RemoveDeviceFromUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputDevice), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "TryFindUserIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputUser), Member = "FindUserPairedToDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.Users.InputUser>))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "OnFocusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Gamepad), Member = "OnRemoved", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchSimulation), Member = "RemovePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Pointer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputControlList`1), Member = "ToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(InputControlList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputControlList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TControl[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputControlList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TControl>", typeof(Allocator)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "RemoveAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeviceArray), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DeviceArray), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputStateHistory), Member = "RecordStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Void*), typeof(double)}, ReturnType = typeof(Record))]
	[CalledBy(Type = typeof(InputControlList`1), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TControl>", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchSimulation), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 23)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	public static int IndexOfReference(TFirst[] array, TSecond value, int count = -1) { }

	[CalledBy(Type = typeof(InputUser), Member = "RemoveDeviceFromUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputDevice), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static int IndexOfReference(TFirst[] array, TSecond value, int startIndex, int count) { }

	[CalledBy(Type = typeof(InputDevice), Member = "RemoveDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	public static int IndexOfValue(TValue[] array, TValue value, int startIndex = 0, int count = -1) { }

	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "AddBindingInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(InputBinding), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	public static void InsertAt(ref TValue[] array, int index, TValue value) { }

	[CalledBy(Type = typeof(FingerAndTouchState), Member = "UpdateActiveTouches", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayHelpers), Member = "EnsureCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]&", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static void InsertAtWithCapacity(ref TValue[] array, ref int count, int index, TValue value, int capacityIncrement = 10) { }

	[CalledBy(Type = typeof(InlinedArray`1), Member = "ToArray", ReturnType = "TValue[]")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static TValue[] Join(TValue value, TValue[] values) { }

	[CallerCount(Count = 47)]
	[DeduplicatedMethod]
	[Extension]
	public static int LengthSafe(TValue[] array) { }

	[CalledBy(Type = typeof(InputControlLayout), Member = "MergeLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.Utilities.InternedString>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.Utilities.InternedString>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	public static TValue[] Merge(TValue[] first, TValue[] second) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 15)]
	[DeduplicatedMethod]
	public static TValue[] Merge(TValue[] first, TValue[] second, IEqualityComparer<TValue> comparer) { }

	[CalledBy(Type = typeof(InputUser), Member = "AddDeviceToUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputDevice), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public static void MoveSlice(TValue[] array, int sourceIndex, int destinationIndex, int count) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 13)]
	[DeduplicatedMethod]
	public static void PutAtIfNotSet(ref TValue[] array, int index, Func<TValue> valueFn) { }

	[CalledBy(Type = typeof(InputControlList`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static void Resize(ref NativeArray<TValue>& array, int newSize, Allocator allocator) { }

	[CalledBy(Type = "UnityEngine.InputSystem.Layouts.InputControlLayout+LayoutJson", Member = "FromLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout)}, ReturnType = "UnityEngine.InputSystem.Layouts.InputControlLayout+LayoutJson")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public static TNew[] Select(TOld[] array, Func<TOld, TNew> converter) { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private static void Swap(ref TValue first, ref TValue second) { }

	[CalledBy(Type = typeof(PlayerInput), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Extension]
	public static void SwapElements(TValue[] array, int index1, int index2) { }

	[CalledBy(Type = typeof(InputControlList`1), Member = "SwapElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static void SwapElements(NativeArray<TValue> array, int index1, int index2) { }

}

