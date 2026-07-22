namespace UnityEngine.InputSystem;

[Extension]
public static class InputControlExtensions
{
	[CompilerGenerated]
	private sealed class <GetAllButtonPresses>d__43 : IEnumerable<InputControl>, IEnumerable, IEnumerator<InputControl>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private InputControl <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private InputEventPtr eventPtr; //Field offset: 0x28
		public InputEventPtr <>3__eventPtr; //Field offset: 0x30
		private float magnitude; //Field offset: 0x38
		public float <>3__magnitude; //Field offset: 0x3C
		private bool buttonControlsOnly; //Field offset: 0x40
		public bool <>3__buttonControlsOnly; //Field offset: 0x41
		private InputEventControlEnumerator <>7__wrap1; //Field offset: 0x48

		private override InputControl System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControl>.Current
		{
			[CallerCount(Count = 31)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 31)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 5
		}

		[CallerCount(Count = 18)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <GetAllButtonPresses>d__43(int <>1__state) { }

		[CallerCount(Count = 0)]
		private void <>m__Finally1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputEventPtr), Member = "get_type", ReturnType = typeof(FourCC))]
		[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
		[Calls(Type = typeof(InputControlExtensions), Member = "EnumerateControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(Enumerate), typeof(InputDevice), typeof(float)}, ReturnType = typeof(InputEventControlCollection))]
		[Calls(Type = typeof(InputEventControlEnumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice), typeof(Enumerate), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputEventControlEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 6)]
		private override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator<InputControl> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl>.GetEnumerator() { }

		[CallerCount(Count = 31)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override InputControl System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControl>.get_Current() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[CallerCount(Count = 31)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[CalledBy(Type = typeof(Vector3Composite), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal struct ControlBuilder
	{
		[CompilerGenerated]
		private InputControl <control>k__BackingField; //Field offset: 0x0

		public internal InputControl control
		{
			[CallerCount(Count = 138)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 4
			[CallerCount(Count = 5)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			internal set { } //Length: 8
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 7)]
		public ControlBuilder At(InputDevice device, int index) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public ControlBuilder DontReset(bool value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public void Finish() { }

		[CallerCount(Count = 138)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		public InputControl get_control() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public ControlBuilder IsButton(bool value) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputControl), Member = "set_noisy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public ControlBuilder IsNoisy(bool value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public ControlBuilder IsSynthetic(bool value) { }

		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal void set_control(InputControl value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public ControlBuilder WithAliases(int startIndex, int count) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public ControlBuilder WithChildren(int startIndex, int count) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public ControlBuilder WithDefaultState(PrimitiveValue value) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public ControlBuilder WithDisplayName(string displayName) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public ControlBuilder WithLayout(InternedString layout) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public ControlBuilder WithMinAndMax(PrimitiveValue min, PrimitiveValue max) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public ControlBuilder WithName(string name) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public ControlBuilder WithParent(InputControl parent) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public ControlBuilder WithProcessor(TProcessor processor) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public ControlBuilder WithShortDisplayName(string shortDisplayName) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public ControlBuilder WithStateBlock(InputStateBlock stateBlock) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public ControlBuilder WithUsages(int startIndex, int count) { }

	}

	internal struct DeviceBuilder
	{
		[CompilerGenerated]
		private InputDevice <device>k__BackingField; //Field offset: 0x0

		public internal InputDevice device
		{
			[CallerCount(Count = 138)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 4
			[CallerCount(Count = 5)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			internal set { } //Length: 8
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
		[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		public void Finish() { }

		[CallerCount(Count = 138)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		public InputDevice get_device() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputControl), Member = "set_noisy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public DeviceBuilder IsNoisy(bool value) { }

		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal void set_device(InputDevice value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public DeviceBuilder WithChildren(int startIndex, int count) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		public DeviceBuilder WithControlAlias(int controlIndex, InternedString alias) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		public DeviceBuilder WithControlTree(Byte[] controlTreeNodes, UInt16[] controlTreeIndicies) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 7)]
		public DeviceBuilder WithControlUsage(int controlIndex, InternedString usage, InputControl control) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public DeviceBuilder WithDisplayName(string displayName) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public DeviceBuilder WithLayout(InternedString layout) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public DeviceBuilder WithName(string name) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public DeviceBuilder WithShortDisplayName(string shortDisplayName) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public DeviceBuilder WithStateBlock(InputStateBlock stateBlock) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public DeviceBuilder WithStateOffsetToControlIndexMap(UInt32[] map) { }

	}

	[Flags]
	internal enum Enumerate
	{
		IgnoreControlsInDefaultState = 1,
		IgnoreControlsInCurrentState = 2,
		IncludeSyntheticControls = 4,
		IncludeNoisyControls = 8,
		IncludeNonLeafControls = 16,
	}

	internal struct InputEventControlCollection : IEnumerable<InputControl>, IEnumerable
	{
		internal InputDevice m_Device; //Field offset: 0x0
		internal InputEventPtr m_EventPtr; //Field offset: 0x8
		internal Enumerate m_Flags; //Field offset: 0x10
		internal float m_MagnitudeThreshold; //Field offset: 0x14

		public InputEventPtr eventPtr
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public InputEventPtr get_eventPtr() { }

		[CalledBy(Type = typeof(RebindingOperation), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputUser), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TouchSimulation), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(InputEventControlEnumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice), typeof(Enumerate), typeof(float)}, ReturnType = typeof(void))]
		public InputEventControlEnumerator GetEnumerator() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputEventControlEnumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice), typeof(Enumerate), typeof(float)}, ReturnType = typeof(void))]
		private override IEnumerator<InputControl> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl>.GetEnumerator() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputEventControlEnumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice), typeof(Enumerate), typeof(float)}, ReturnType = typeof(void))]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	internal struct InputEventControlEnumerator : IEnumerator<InputControl>, IEnumerator, IDisposable
	{
		private Enumerate m_Flags; //Field offset: 0x0
		private readonly InputDevice m_Device; //Field offset: 0x8
		private readonly UInt32[] m_StateOffsetToControlIndex; //Field offset: 0x10
		private readonly int m_StateOffsetToControlIndexLength; //Field offset: 0x18
		private readonly InputControl[] m_AllControls; //Field offset: 0x20
		private Byte* m_DefaultState; //Field offset: 0x28
		private Byte* m_CurrentState; //Field offset: 0x30
		private Byte* m_NoiseMask; //Field offset: 0x38
		private InputEventPtr m_EventPtr; //Field offset: 0x40
		private InputControl m_CurrentControl; //Field offset: 0x48
		private int m_CurrentIndexInStateOffsetToControlIndexMap; //Field offset: 0x50
		private uint m_CurrentControlStateBitOffset; //Field offset: 0x54
		private Byte* m_EventState; //Field offset: 0x58
		private uint m_CurrentBitOffset; //Field offset: 0x60
		private uint m_EndBitOffset; //Field offset: 0x64
		private float m_MagnitudeThreshold; //Field offset: 0x68

		public override InputControl Current
		{
			[CallerCount(Count = 10)]
			[DeduplicatedMethod]
			 get { } //Length: 254
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 10)]
			[DeduplicatedMethod]
			private get { } //Length: 254
		}

		[CalledBy(Type = typeof(InputEventControlCollection), Member = "GetEnumerator", ReturnType = typeof(InputEventControlEnumerator))]
		[CalledBy(Type = typeof(InputEventControlCollection), Member = "System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl>.GetEnumerator", ReturnType = typeof(System.Collections.Generic.IEnumerator`1<UnityEngine.InputSystem.InputControl>))]
		[CalledBy(Type = typeof(InputEventControlCollection), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[CalledBy(Type = "UnityEngine.InputSystem.InputControlExtensions+<GetAllButtonPresses>d__43", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputControlExtensions), Member = "GetFirstButtonPressOrNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(float), typeof(bool)}, ReturnType = typeof(InputControl))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InputControl), Member = "GetDeviceIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(InputStateBuffers), Member = "GetFrontBufferForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Void*))]
		[Calls(Type = typeof(InputEventControlEnumerator), Member = "Reset", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		internal InputEventControlEnumerator(InputEventPtr eventPtr, InputDevice device, Enumerate flags, float magnitudeThreshold = 0) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MemoryHelpers), Member = "MemCmpBitRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(uint), typeof(uint), typeof(Void*)}, ReturnType = typeof(bool))]
		private bool CheckCurrent(uint numBits) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MemoryHelpers), Member = "MemCmpBitRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(uint), typeof(uint), typeof(Void*)}, ReturnType = typeof(bool))]
		private bool CheckDefault(uint numBits) { }

		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		public override void Dispose() { }

		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		public override InputControl get_Current() { }

		[CalledBy(Type = typeof(RebindingOperation), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.InputControlExtensions+<GetAllButtonPresses>d__43", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputControlExtensions), Member = "GetFirstButtonPressOrNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(float), typeof(bool)}, ReturnType = typeof(InputControl))]
		[CalledBy(Type = typeof(InputUser), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TouchSimulation), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(MemoryHelpers), Member = "MemCmpBitRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(uint), typeof(uint), typeof(Void*)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 10)]
		[ContainsUnimplementedInstructions]
		public override bool MoveNext() { }

		[CalledBy(Type = typeof(InputEventControlEnumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice), typeof(Enumerate), typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InputEventPtr), Member = "get_type", ReturnType = typeof(FourCC))]
		[Calls(Type = typeof(DeltaStateEvent), Member = "get_deltaState", ReturnType = typeof(Void*))]
		[Calls(Type = typeof(DeltaStateEvent), Member = "get_deltaStateSizeInBytes", ReturnType = typeof(uint))]
		[Calls(Type = typeof(StateEvent), Member = "get_state", ReturnType = typeof(Void*))]
		[Calls(Type = typeof(StateEvent), Member = "get_stateSizeInBytes", ReturnType = typeof(uint))]
		[Calls(Type = typeof(InputEventPtr), Member = "IsA", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StateEvent)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TouchState), Member = "get_Format", ReturnType = typeof(FourCC))]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 22)]
		public override void Reset() { }

		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

	}


	[CalledBy(Type = typeof(Mouse), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Pointer), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Pointer), Member = "UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputControlExtensions), Member = "ReadUnprocessedValueFromEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.InputSystem.InputControl`1<UnityEngine.Vector2>), typeof(InputEventPtr), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlExtensions), Member = "WriteValueIntoEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.InputSystem.InputControl`1<UnityEngine.Vector2>), typeof(Vector2), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Extension]
	internal static void AccumulateValueInEvent(InputControl<Vector2> control, Void* currentStatePtr, InputEventPtr newState) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControlExtensions), Member = "ReadUnprocessedValueFromEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputControl`1<TValue>", typeof(InputEventPtr), "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlExtensions), Member = "WriteValueIntoEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputControl`1<TValue>", "TValue", typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Extension]
	public static void AccumulateValueInEvent(InputControl<Single> control, Void* currentStatePtr, InputEventPtr newState) { }

	[CalledBy(Type = typeof(RebindingOperation), Member = "GeneratePathForControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringHelpers), Member = "Escape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputControl), Member = "get_path", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	[Extension]
	internal static string BuildPath(InputControl control, string deviceLayout, StringBuilder builder = null) { }

	[CalledBy(Type = typeof(RebindingOperation), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AnyKeyControl), Member = "ReadUnprocessedValueFromState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputControlExtensions), Member = "CompareState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Void*), typeof(Void*), typeof(Void*)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[Extension]
	public static bool CheckStateIsAtDefault(InputControl control, Void* statePtr, Void* maskPtr = null) { }

	[CalledBy(Type = typeof(InputActionState), Member = "OnBeforeInitialUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "ProcessControlStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(double), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OnScreenControl), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputControl), Member = "GetDeviceIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputStateBuffers), Member = "GetFrontBufferForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(InputControlExtensions), Member = "CompareState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Void*), typeof(Void*), typeof(Void*)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[Extension]
	public static bool CheckStateIsAtDefault(InputControl control) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControlExtensions), Member = "CompareState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Void*), typeof(Void*), typeof(Void*)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[Extension]
	public static bool CheckStateIsAtDefaultIgnoringNoise(InputControl control, Void* statePtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControl), Member = "GetDeviceIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputStateBuffers), Member = "GetFrontBufferForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(InputControlExtensions), Member = "CompareState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Void*), typeof(Void*), typeof(Void*)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[Extension]
	public static bool CheckStateIsAtDefaultIgnoringNoise(InputControl control) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControl), Member = "GetDeviceIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputStateBuffers), Member = "GetFrontBufferForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(InputControlExtensions), Member = "CompareState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Void*), typeof(Void*), typeof(Void*)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[Extension]
	public static bool CompareState(InputControl control, Void* statePtr, Void* maskPtr = null) { }

	[CalledBy(Type = typeof(InputControlExtensions), Member = "IsPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(float)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "IsActuated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(float)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "CheckStateIsAtDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "CheckStateIsAtDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Void*), typeof(Void*)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "CheckStateIsAtDefaultIgnoringNoise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "CheckStateIsAtDefaultIgnoringNoise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Void*)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "CompareStateIgnoringNoise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Void*)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "CompareState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Void*), typeof(Void*)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputDevice), Member = "WriteChangedControlStatesInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Byte*), typeof(ControlBitRangeNode), typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(MemoryHelpers), Member = "MemCmpBitRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(uint), typeof(uint), typeof(Void*)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MemoryHelpers), Member = "ReadSingleBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(uint)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static bool CompareState(InputControl control, Void* firstStatePtr, Void* secondStatePtr, Void* maskPtr = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControl), Member = "GetDeviceIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputStateBuffers), Member = "GetFrontBufferForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(InputControlExtensions), Member = "CompareState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Void*), typeof(Void*), typeof(Void*)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[Extension]
	public static bool CompareStateIgnoringNoise(InputControl control, Void* statePtr) { }

	[CalledBy(Type = typeof(VirtualMouseInput), Member = "OnButtonActionTriggered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MouseState), Member = "get_format", ReturnType = typeof(FourCC))]
	[Calls(Type = typeof(InputControlExtensions), Member = "CopyState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 31)]
	[DeduplicatedMethod]
	[Extension]
	public static void CopyState(InputDevice device, out TState state) { }

	[CalledBy(Type = typeof(InputControlExtensions), Member = "CopyState", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TState"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), "TState&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputStateBlock), Member = "get_alignedSizeInBytes", ReturnType = typeof(uint))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(InputControl), Member = "GetDeviceIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputStateBuffers), Member = "GetFrontBufferForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[Extension]
	public static void CopyState(InputDevice device, Void* buffer, int bufferSizeInBytes) { }

	[CalledBy(Type = typeof(InputUser), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputControlExtensions), Member = "EnumerateControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(Enumerate), typeof(InputDevice), typeof(float)}, ReturnType = typeof(InputEventControlCollection))]
	[Extension]
	public static InputEventControlCollection EnumerateChangedControls(InputEventPtr eventPtr, InputDevice device = null, float magnitudeThreshold = 0) { }

	[CalledBy(Type = typeof(RebindingOperation), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<GetAllButtonPresses>d__43), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "EnumerateChangedControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice), typeof(float)}, ReturnType = typeof(InputEventControlCollection))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "GetFirstButtonPressOrNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(float), typeof(bool)}, ReturnType = typeof(InputControl))]
	[CalledBy(Type = typeof(TouchSimulation), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(InputEventPtr), Member = "get_type", ReturnType = typeof(FourCC))]
	[Calls(Type = typeof(InputEventPtr), Member = "get_deviceId", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputManager), Member = "TryGetDeviceById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(InputDevice))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	[Extension]
	public static InputEventControlCollection EnumerateControls(InputEventPtr eventPtr, Enumerate flags, InputDevice device = null, float magnitudeThreshold = 0) { }

	[CalledBy(Type = typeof(InputControlExtensions), Member = "FindControlsRecursive", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), "System.Collections.Generic.IList`1<TControl>", "System.Func`2<TControl, Boolean>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputControl), Member = "get_children", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControl>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputControlExtensions), Member = "FindControlsRecursive", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), "System.Collections.Generic.IList`1<TControl>", "System.Func`2<TControl, Boolean>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	[DeduplicatedMethod]
	[Extension]
	public static void FindControlsRecursive(InputControl parent, IList<TControl> controls, Func<TControl, Boolean> predicate) { }

	[CalledBy(Type = typeof(Touchscreen), Member = "UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	[Extension]
	public static TControl FindInParentChain(InputControl control) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Extension]
	[IteratorStateMachine(typeof(<GetAllButtonPresses>d__43))]
	public static IEnumerable<InputControl> GetAllButtonPresses(InputEventPtr eventPtr, float magnitude = -1, bool buttonControlsOnly = true) { }

	[CalledBy(Type = "UnityEngine.InputSystem.InputSystem+<>c", Member = "<get_onAnyButtonPress>b__80_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(InputControl))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "HasButtonPress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(float), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputEventPtr), Member = "get_type", ReturnType = typeof(FourCC))]
	[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
	[Calls(Type = typeof(InputControlExtensions), Member = "EnumerateControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(Enumerate), typeof(InputDevice), typeof(float)}, ReturnType = typeof(InputEventControlCollection))]
	[Calls(Type = typeof(InputEventControlEnumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice), typeof(Enumerate), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputEventControlEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlExtensions), Member = "GetStatePtrFromStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(InputControl), Member = "GetDeviceIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputStateBuffers), Member = "GetFrontBufferForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	[Extension]
	public static InputControl GetFirstButtonPressOrNull(InputEventPtr eventPtr, float magnitude = -1, bool buttonControlsOnly = true) { }

	[CalledBy(Type = typeof(InputControlExtensions), Member = "ReadValueFromEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputControl`1<TValue>", typeof(InputEventPtr), "TValue&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "ReadValueFromEventAsObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "ReadUnprocessedValueFromEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputControl`1<TValue>", typeof(InputEventPtr), "TValue&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "WriteValueFromObjectIntoEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "WriteValueIntoEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputControl`1<TValue>", "TValue", typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "HasValueChangeInEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "ResetToDefaultStateInEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "GetFirstButtonPressOrNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(float), typeof(bool)}, ReturnType = typeof(InputControl))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(InputEventPtr), Member = "get_type", ReturnType = typeof(FourCC))]
	[Calls(Type = typeof(InputControlExtensions), Member = "GetStatePtrFromStateEventUnchecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr), typeof(FourCC)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[Extension]
	public static Void* GetStatePtrFromStateEvent(InputControl control, InputEventPtr eventPtr) { }

	[CalledBy(Type = typeof(RebindingOperation), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "GetStatePtrFromStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(Void*))]
	[CalledBy(Type = typeof(TouchSimulation), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(DeltaStateEvent), Member = "get_deltaStateSizeInBytes", ReturnType = typeof(uint))]
	[Calls(Type = typeof(DeltaStateEvent), Member = "get_deltaState", ReturnType = typeof(Void*))]
	[Calls(Type = typeof(StateEvent), Member = "get_stateSizeInBytes", ReturnType = typeof(uint))]
	[Calls(Type = typeof(StateEvent), Member = "get_state", ReturnType = typeof(Void*))]
	[Calls(Type = typeof(InputStateBlock), Member = "get_effectiveByteOffset", ReturnType = typeof(uint))]
	[Calls(Type = typeof(InputStateBlock), Member = "get_alignedSizeInBytes", ReturnType = typeof(uint))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	[Extension]
	internal static Void* GetStatePtrFromStateEventUnchecked(InputControl control, InputEventPtr eventPtr, FourCC eventType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControlExtensions), Member = "GetFirstButtonPressOrNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(float), typeof(bool)}, ReturnType = typeof(InputControl))]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static bool HasButtonPress(InputEventPtr eventPtr, float magnitude = -1, bool buttonControlsOnly = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControlExtensions), Member = "GetStatePtrFromStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(InputControl), Member = "GetDeviceIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputStateBuffers), Member = "GetFrontBufferForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	[Extension]
	public static bool HasValueChangeInEvent(InputControl control, InputEventPtr eventPtr) { }

	[CalledBy(Type = typeof(RebindingOperation), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputControl), Member = "GetDeviceIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputStateBuffers), Member = "GetFrontBufferForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[Extension]
	public static bool HasValueChangeInState(InputControl control, Void* statePtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControl), Member = "GetDeviceIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputStateBuffers), Member = "GetFrontBufferForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(InputControlExtensions), Member = "CompareState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Void*), typeof(Void*), typeof(Void*)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static bool IsActuated(InputControl control, float threshold = 0) { }

	[CalledBy(Type = typeof(VirtualMouseInput), Member = "OnButtonActionTriggered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OnScreenStick), Member = "OnPointerChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ButtonControl), Member = "get_pressPointOrDefault", ReturnType = typeof(float))]
	[Calls(Type = typeof(InputControl), Member = "GetDeviceIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputStateBuffers), Member = "GetFrontBufferForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(InputControlExtensions), Member = "CompareState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Void*), typeof(Void*), typeof(Void*)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static bool IsPressed(InputControl control, float buttonPressPoint = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StateEvent), Member = "From", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputEventPtr&), typeof(Allocator)}, ReturnType = typeof(Unity.Collections.NativeArray`1<System.Byte>))]
	[Calls(Type = typeof(InputEventPtr), Member = "set_time", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	public static void QueueValueChange(InputControl<TValue> control, TValue value, double time = -1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Extension]
	public static object ReadDefaultValueAsObject(InputControl control) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	[Extension]
	public static TValue ReadUnprocessedValueFromEvent(InputControl<TValue> control, InputEventPtr eventPtr) { }

	[CalledBy(Type = typeof(InputControlExtensions), Member = "AccumulateValueInEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.InputSystem.InputControl`1<System.Single>), typeof(Void*), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputControlExtensions), Member = "GetStatePtrFromStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Single>), Member = "ReadDefaultValue", ReturnType = typeof(float))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[Extension]
	public static bool ReadUnprocessedValueFromEvent(InputControl<TValue> control, InputEventPtr inputEvent, out TValue value) { }

	[CalledBy(Type = typeof(InputActionState), Member = "ReadValueAsObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputControl), Member = "GetDeviceIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputStateBuffers), Member = "GetFrontBufferForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Extension]
	public static object ReadValueAsObject(InputControl control) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControlExtensions), Member = "GetStatePtrFromStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	[Extension]
	public static bool ReadValueFromEvent(InputControl<TValue> control, InputEventPtr inputEvent, out TValue value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	[DeduplicatedMethod]
	[Extension]
	public static TValue ReadValueFromEvent(InputControl<TValue> control, InputEventPtr inputEvent) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControlExtensions), Member = "GetStatePtrFromStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[Extension]
	public static object ReadValueFromEventAsObject(InputControl control, InputEventPtr inputEvent) { }

	[CalledBy(Type = typeof(InputActionState), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Void*), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputControl), Member = "GetDeviceIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputStateBuffers), Member = "GetFrontBufferForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[Extension]
	public static void ReadValueIntoBuffer(InputControl control, Void* buffer, int bufferSize) { }

	[CalledBy(Type = typeof(OnScreenControl), Member = "SentDefaultValueToControl", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputEventPtr), Member = "get_type", ReturnType = typeof(FourCC))]
	[Calls(Type = typeof(InputControlExtensions), Member = "GetStatePtrFromStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(MemoryHelpers), Member = "MemCpyBitRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	[Extension]
	public static bool ResetToDefaultStateInEvent(InputControl control, InputEventPtr eventPtr) { }

	[CalledBy(Type = typeof(FastKeyboard), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FastMouse), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FastTouchscreen), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 26)]
	[Extension]
	public static DeviceBuilder Setup(InputDevice device, int controlCount, int usageCount, int aliasCount) { }

	[CallerCount(Count = 463)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[Extension]
	public static ControlBuilder Setup(InputControl control) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControlExtensions), Member = "GetStatePtrFromStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Extension]
	public static void WriteValueFromObjectIntoEvent(InputControl control, InputEventPtr eventPtr, object value) { }

	[CalledBy(Type = typeof(InputControlExtensions), Member = "AccumulateValueInEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.InputSystem.InputControl`1<System.Single>), typeof(Void*), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OnScreenControl), Member = "SendValueToControl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputControlExtensions), Member = "GetStatePtrFromStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	[Extension]
	public static void WriteValueIntoEvent(InputControl<TValue> control, TValue value, InputEventPtr eventPtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 33)]
	[DeduplicatedMethod]
	[Extension]
	public static void WriteValueIntoEvent(InputControl control, TValue value, InputEventPtr eventPtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "Malloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(Allocator)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(InputControl), Member = "GetDeviceIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputStateBuffers), Member = "GetFrontBufferForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Allocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	[Extension]
	public static void WriteValueIntoState(InputControl control, Void* statePtr) { }

	[CalledBy(Type = typeof(PoseControl), Member = "WriteValueIntoState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PoseState), typeof(Void*)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 28)]
	[DeduplicatedMethod]
	[Extension]
	public static void WriteValueIntoState(InputControl control, TValue value, Void* statePtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	[Extension]
	public static void WriteValueIntoState(InputControl<TValue> control, TValue value, Void* statePtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[Extension]
	public static void WriteValueIntoState(InputControl<TValue> control, Void* statePtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControl), Member = "get_stateOffsetRelativeToDeviceRoot", ReturnType = typeof(uint))]
	[Calls(Type = typeof(InputStateBlock), Member = "get_alignedSizeInBytes", ReturnType = typeof(uint))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputControl), Member = "get_path", ReturnType = typeof(string))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 35)]
	[DeduplicatedMethod]
	[Extension]
	public static void WriteValueIntoState(InputControl<TValue> control, TValue value, ref TState state) { }

}

