namespace UnityEngine.InputSystem.Utilities;

[DefaultMember("Item")]
internal struct InlinedArray : IEnumerable<TValue>, IEnumerable
{
	private struct Enumerator : IEnumerator<TValue>, IEnumerator, IDisposable
	{
		public InlinedArray<TValue> array; //Field offset: 0x0
		public int index; //Field offset: 0x0

		public override TValue Current
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 get { } //Length: 68
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
			[CallsUnknownMethods(Count = 3)]
			[DeduplicatedMethod]
			private get { } //Length: 161
		}

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public override void Dispose() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override TValue get_Current() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public override void Reset() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	public int length; //Field offset: 0x0
	public TValue firstValue; //Field offset: 0x0
	public TValue[] additionalValues; //Field offset: 0x0

	public int Capacity
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 21
	}

	public TValue Item
	{
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		 get { } //Length: 143
		[CalledBy(Type = typeof(InputActionState), Member = "AddToGlobalList", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionState), Member = "CompactGlobalList", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicBitfield), Member = "SetBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicBitfield), Member = "ClearBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ReplayController), Member = "WithDeviceMappedFromTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(ReplayController))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 143
	}

	[CalledBy(Type = typeof(InputManager), Member = "RegisterControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "RegisterControlLayoutBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.InputSystem.Layouts.InputControlLayout>), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Builder), Member = "Build", ReturnType = typeof(InputControlLayout))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public InlinedArray`1(TValue value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public InlinedArray`1(TValue firstValue, TValue[] additionalValues) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 19)]
	[DeduplicatedMethod]
	public InlinedArray`1(IEnumerable<TValue> values) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 22)]
	[DeduplicatedMethod]
	public void Append(IEnumerable<TValue> values) { }

	[CalledBy(Type = typeof(InputUser), Member = "InitiateUserAccountSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputDevice), typeof(InputUserPairingOptions)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputSystem.Layouts.InputControlLayout+LayoutJson", Member = "ToLayout", ReturnType = typeof(InputControlLayout))]
	[CalledBy(Type = typeof(Collection), Member = "TryLoadLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString, UnityEngine.InputSystem.Layouts.InputControlLayout>)}, ReturnType = typeof(InputControlLayout))]
	[CalledBy(Type = typeof(InputControlLayout), Member = "ParseHeaderFieldsFromJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InternedString&), typeof(InlinedArray`1<InternedString>&), typeof(InputDeviceMatcher&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public int Append(TValue value) { }

	[CalledBy(Type = "UnityEngine.InputSystem.InputControlPath+PathParser", Member = "MoveToNextComponent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReplayController), Member = "WithDeviceMappedFromTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(ReplayController))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayHelpers), Member = "AppendWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]&", typeof(Int32&), "TValue", typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public int AppendWithCapacity(TValue value, int capacityIncrement = 10) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public void AssignWithCapacity(InlinedArray<TValue> values) { }

	[CalledBy(Type = typeof(Collection), Member = "TryLoadLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString, UnityEngine.InputSystem.Layouts.InputControlLayout>)}, ReturnType = typeof(InputControlLayout))]
	[CalledBy(Type = typeof(InputActionTrace), Member = "DisposeInternal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CallbackArray`1), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CallbackArray`1), Member = "UnlockForChanges", ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void Clear() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void ClearWithCapacity() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayHelpers), Member = "Copy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = "TValue[]")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public InlinedArray<TValue> Clone() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public bool Contains(TValue value, IEqualityComparer<TValue> comparer) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_Capacity() { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public TValue get_Item(int index) { }

	[CalledBy(Type = typeof(InputControlPath), Member = "MatchControlComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsedPathComponent&), typeof(ControlItem&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override IEnumerator<TValue> GetEnumerator() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public int IndexOf(TValue value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	[DeduplicatedMethod]
	public void Merge(InlinedArray<TValue> other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlinedArray`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	public void Remove(TValue value) { }

	[CalledBy(Type = typeof(InlinedArray`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	public void RemoveAt(int index) { }

	[CalledBy(Type = typeof(InputActionState), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "RemoveMapFromGlobalList", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "RemoveUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "RemoveDeviceFromUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputDevice), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayHelpers), Member = "EraseAtByMovingTail", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]", typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public void RemoveAtByMovingTailWithCapacity(int index) { }

	[CalledBy(Type = typeof(InputActionState), Member = "ResetGlobals", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "DeferredResolutionOfBindings", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "DestroyAllActionMapStates", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReplayController), Member = "WithDeviceMappedFromTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(ReplayController))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayHelpers), Member = "EraseAtWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]", typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public void RemoveAtWithCapacity(int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public bool RemoveByMovingTailWithCapacity(TValue value) { }

	[CalledBy(Type = typeof(InputActionState), Member = "AddToGlobalList", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "CompactGlobalList", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicBitfield), Member = "SetBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicBitfield), Member = "ClearBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReplayController), Member = "WithDeviceMappedFromTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(ReplayController))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public void set_Item(int index, TValue value) { }

	[CalledBy(Type = typeof(StateChangeMonitorsForDevice), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(IInputStateChangeMonitor), typeof(long), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StateChangeMonitorsForDevice), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StateChangeMonitorsForDevice), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicBitfield), Member = "SetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public void SetLength(int size) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayHelpers), Member = "Join", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TValue[]"}, ReturnType = "TValue[]")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public TValue[] ToArray() { }

	[CalledBy(Type = typeof(InputControlPath), Member = "TryGetDeviceUsages", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = "UnityEngine.InputSystem.Layouts.InputControlLayout+LayoutJson", Member = "FromLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout)}, ReturnType = "UnityEngine.InputSystem.Layouts.InputControlLayout+LayoutJson")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public TOther[] ToArray(Func<TValue, TOther> mapFunction) { }

}

