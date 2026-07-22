namespace UnityEngine.InputSystem;

[DebuggerDisplay("Count = {Count}")]
[DefaultMember("Item")]
public struct InputControlList : IList<TControl>, ICollection<TControl>, IEnumerable<TControl>, IEnumerable, IReadOnlyList<TControl>, IReadOnlyCollection<TControl>, IDisposable
{
	private struct Enumerator : IEnumerator<TControl>, IEnumerator, IDisposable
	{
		private readonly UInt64* m_Indices; //Field offset: 0x0
		private readonly int m_Count; //Field offset: 0x0
		private int m_Current; //Field offset: 0x0

		public override TControl Current
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(InputControlList`1), Member = "FromIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = "TControl")]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			 get { } //Length: 140
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			private get { } //Length: 54
		}

		[CalledBy(Type = typeof(InputControlList`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<TControl>")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public Enumerator(InputControlList<TControl> list) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public override void Dispose() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputControlList`1), Member = "FromIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = "TControl")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public override TControl get_Current() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public override bool MoveNext() { }

		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		public override void Reset() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	private const ulong kInvalidIndex = 18446744073709551615; //Field offset: 0x0
	private int m_Count; //Field offset: 0x0
	private NativeArray<UInt64> m_Indices; //Field offset: 0x0
	private readonly Allocator m_Allocator; //Field offset: 0x0

	public int Capacity
	{
		[CalledBy(Type = typeof(InputControlList`1), Member = "AddSlice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TList"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TList", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 61
		[CalledBy(Type = typeof(RebindingOperation), Member = "ResetAfterMatchCompleted", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MatchResult), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputDevice>))]
		[CalledBy(Type = typeof(InputControlList`1), Member = "AddSlice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TList"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TList", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ArrayHelpers), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<TValue>&", typeof(int), typeof(Allocator)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		 set { } //Length: 241
	}

	public override int Count
	{
		[CallerCount(Count = 173)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override bool IsReadOnly
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override TControl Item
	{
		[CalledBy(Type = typeof(RebindingOperation), Member = "get_selectedControl", ReturnType = typeof(InputControl))]
		[CalledBy(Type = typeof(RebindingOperation), Member = "OnComplete", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionState), Member = "RestoreActionStatesAfterReResolvingBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnmanagedMemory), typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputControl>), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Match), Member = "get_control", ReturnType = typeof(InputControl))]
		[CalledBy(Type = typeof(Match), Member = "get_device", ReturnType = typeof(InputDevice))]
		[CalledBy(Type = typeof(MatchResult), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputDevice>))]
		[CalledBy(Type = typeof(InputControlList`1), Member = "Sort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TCompare"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "TCompare"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerInput), Member = "AssignUserAndDevices", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerInput), Member = "OnUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ArrayHelpers), Member = "AppendListWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TValues"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]&", typeof(Int32&), "TValues", typeof(int)}, ReturnType = typeof(int))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(InputControlList`1), Member = "FromIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = "TControl")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		 get { } //Length: 240
		[CalledBy(Type = typeof(InputActionState), Member = "PrepareForBindingReResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(InputControlList`1<InputControl>&), typeof(Boolean&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		 set { } //Length: 231
	}

	[CalledBy(Type = typeof(InputActionState), Member = "PrepareForBindingReResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(InputControlList`1<InputControl>&), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputControlScheme), Member = "PickDevicesFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices", typeof(InputDevice)}, ReturnType = typeof(MatchResult))]
	[CalledBy(Type = typeof(InputControlPath), Member = "TryFindControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int)}, ReturnType = typeof(InputControl[]))]
	[CalledBy(Type = typeof(PlayerInput), Member = "AssignUserAndDevices", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "GetUnpairedInputDevices", ReturnType = typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputDevice>))]
	[CalledBy(Type = typeof(InputUser), Member = "UpdateControlSchemeMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public InputControlList`1(Allocator allocator, int initialCapacity = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayHelpers), Member = "IndexOfReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst", "TSecond"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst[]", "TSecond", typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArrayHelpers), Member = "AppendWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<TValue>&", typeof(Int32&), "TValue", typeof(int), typeof(Allocator)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 19)]
	[DeduplicatedMethod]
	public InputControlList`1(IEnumerable<TControl> values, Allocator allocator = 4) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayHelpers), Member = "IndexOfReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst", "TSecond"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst[]", "TSecond", typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArrayHelpers), Member = "AppendWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<TValue>&", typeof(Int32&), "TValue", typeof(int), typeof(Allocator)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	public InputControlList`1(TControl[] values) { }

	[CalledBy(Type = typeof(RebindingOperation), Member = "AddCandidate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RebindingOperation), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MatchResult), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputDevice>))]
	[CalledBy(Type = typeof(InputControlScheme), Member = "PickDevicesFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices", typeof(InputDevice)}, ReturnType = typeof(MatchResult))]
	[CalledBy(Type = typeof(InputControlPath), Member = "MatchControlsRecursive", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int), "UnityEngine.InputSystem.InputControlList`1<TControl>&", typeof(bool)}, ReturnType = "TControl")]
	[CalledBy(Type = typeof(InputControlPath), Member = "MatchByUsageAtDeviceRootRecursive", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(string), typeof(int), "UnityEngine.InputSystem.InputControlList`1<TControl>&", typeof(bool)}, ReturnType = "TControl")]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "GetUnpairedInputDevices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlList`1<InputDevice>&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(ArrayHelpers), Member = "IndexOfReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst", "TSecond"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst[]", "TSecond", typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArrayHelpers), Member = "AppendWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<TValue>&", typeof(Int32&), "TValue", typeof(int), typeof(Allocator)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override void Add(TControl item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NativeArray`1), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), "Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayHelpers), Member = "IndexOfReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst", "TSecond"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst[]", "TSecond", typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 25)]
	[DeduplicatedMethod]
	public void AddRange(IEnumerable<TControl> list, int count = -1, int destinationIndex = -1) { }

	[CalledBy(Type = typeof(InputUser), Member = "UpdateControlSchemeMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputControlList`1), Member = "get_Capacity", ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputControlList`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), "Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputControlList`1), Member = "ToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	[DeduplicatedMethod]
	public void AddSlice(TList list, int count = -1, int destinationIndex = -1, int sourceIndex = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControlList`1), Member = "FromIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = "TControl")]
	[Calls(Type = typeof(ArrayHelpers), Member = "AppendWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(Int32&), typeof(object), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	internal void AppendTo(ref TControl[] array, ref int count) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public override void Clear() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool Contains(TControl item, int startIndex, int count = -1) { }

	[CalledBy(Type = typeof(MatchResult), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputDevice>))]
	[CalledBy(Type = typeof(InputControlScheme), Member = "FindControlSchemeForDevices", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices", "TSchemes"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices", "TSchemes", typeof(InputControlScheme&), typeof(MatchResult&), typeof(InputDevice), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlScheme), Member = "PickDevicesFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices", typeof(InputDevice)}, ReturnType = typeof(MatchResult))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Contains(TControl item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override void CopyTo(TControl[] array, int arrayIndex) { }

	[CalledBy(Type = typeof(RebindingOperation), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RebindingOperation), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MatchResult), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputControlPath), Member = "TryFindControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int)}, ReturnType = typeof(InputControl[]))]
	[CalledBy(Type = typeof(PlayerInput), Member = "AssignUserAndDevices", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInputManager), Member = "IsDeviceUsableWithPlayerActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputUser), Member = "UpdateControlSchemeMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputStateHistory), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public override void Dispose() { }

	[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TControl")]
	[CalledBy(Type = typeof(InputControlList`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TControl")]
	[CalledBy(Type = typeof(InputControlList`1), Member = "ToArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "TControl[]")]
	[CalledBy(Type = typeof(InputControlList`1), Member = "AppendTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TControl[]&", typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputSystem), Member = "GetDeviceById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(InputDevice))]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	private static TControl FromIndex(ulong index) { }

	[CalledBy(Type = typeof(InputControlList`1), Member = "AddSlice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TList"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TList", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_Capacity() { }

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	public override int get_Count() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool get_IsReadOnly() { }

	[CalledBy(Type = typeof(RebindingOperation), Member = "get_selectedControl", ReturnType = typeof(InputControl))]
	[CalledBy(Type = typeof(RebindingOperation), Member = "OnComplete", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "RestoreActionStatesAfterReResolvingBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnmanagedMemory), typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputControl>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Match), Member = "get_control", ReturnType = typeof(InputControl))]
	[CalledBy(Type = typeof(Match), Member = "get_device", ReturnType = typeof(InputDevice))]
	[CalledBy(Type = typeof(MatchResult), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputDevice>))]
	[CalledBy(Type = typeof(InputControlList`1), Member = "Sort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TCompare"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "TCompare"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "AssignUserAndDevices", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArrayHelpers), Member = "AppendListWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TValues"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]&", typeof(Int32&), "TValues", typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(InputControlList`1), Member = "FromIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = "TControl")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public override TControl get_Item(int index) { }

	[CalledBy(Type = typeof(InputUser), Member = "UpdateControlSchemeMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputControlList`1<TControl>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override IEnumerator<TControl> GetEnumerator() { }

	[CalledBy(Type = typeof(RebindingOperation), Member = "AddCandidate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RebindingOperation), Member = "RemoveCandidate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RebindingOperation), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override int IndexOf(TControl item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	public int IndexOf(TControl item, int startIndex, int count = -1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override void Insert(int index, TControl item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayHelpers), Member = "EraseAtWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<TValue>", typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override bool Remove(TControl item) { }

	[CalledBy(Type = typeof(RebindingOperation), Member = "RemoveCandidate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayHelpers), Member = "EraseAtWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<TValue>", typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public override void RemoveAt(int index) { }

	[CalledBy(Type = typeof(InputActionState), Member = "PrepareForBindingReResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(InputControlList`1<InputControl>&), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(byte), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	public void Resize(int size) { }

	[CalledBy(Type = typeof(RebindingOperation), Member = "ResetAfterMatchCompleted", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MatchResult), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputDevice>))]
	[CalledBy(Type = typeof(InputControlList`1), Member = "AddSlice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TList"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TList", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArrayHelpers), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<TValue>&", typeof(int), typeof(Allocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public void set_Capacity(int value) { }

	[CalledBy(Type = typeof(InputActionState), Member = "PrepareForBindingReResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(InputControlList`1<InputControl>&), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public override void set_Item(int index, TControl value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControlList`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TControl")]
	[Calls(Type = typeof(InputControlList`1), Member = "SwapElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 16)]
	[DeduplicatedMethod]
	public void Sort(int startIndex, int count, TCompare comparer) { }

	[CalledBy(Type = typeof(RebindingOperation), Member = "SortCandidatesByScore", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputControlList`1), Member = "Sort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TCompare"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "TCompare"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "OnUnpairedDeviceUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArrayHelpers), Member = "SwapElements", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<TValue>", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public void SwapElements(int index1, int index2) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[CalledBy(Type = typeof(InputControlPath), Member = "TryFindControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int)}, ReturnType = typeof(InputControl[]))]
	[CalledBy(Type = typeof(InputStateHistory), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputControlList`1), Member = "FromIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = "TControl")]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	public TControl[] ToArray(bool dispose = false) { }

	[CalledBy(Type = typeof(InputControlList`1), Member = "AddSlice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TList"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TList", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayHelpers), Member = "IndexOfReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst", "TSecond"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst[]", "TSecond", typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private static ulong ToIndex(TControl control) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}

