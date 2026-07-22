namespace UnityEngine.InputSystem.LowLevel;

internal class NativeInputRuntime : IInputRuntime
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public Action<InputUpdateType> value; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass10_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal void <set_onBeforeUpdate>b__0(NativeInputUpdateType updateType) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public Func<InputUpdateType, Boolean> value; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass13_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal bool <set_onShouldRunUpdate>b__0(NativeInputUpdateType updateType) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public InputUpdateDelegate value; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass7_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputEventBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEvent*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputEventBuffer), Member = "Reset", ReturnType = typeof(void))]
		[Calls(Type = typeof(InputEventBuffer), Member = "get_capacityInBytes", ReturnType = typeof(long))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 6)]
		internal void <set_onUpdate>b__0(NativeInputUpdateType updateType, NativeInputEventBuffer* eventBufferPtr) { }

	}

	public static readonly NativeInputRuntime instance; //Field offset: 0x0
	private bool m_RunInBackground; //Field offset: 0x10
	private Action m_ShutdownMethod; //Field offset: 0x18
	private InputUpdateDelegate m_OnUpdate; //Field offset: 0x20
	private Action<InputUpdateType> m_OnBeforeUpdate; //Field offset: 0x28
	private Func<InputUpdateType, Boolean> m_OnShouldRunUpdate; //Field offset: 0x30
	private float m_PollingFrequency; //Field offset: 0x38
	private bool m_DidCallOnShutdown; //Field offset: 0x3C
	private Action<Boolean> m_FocusChangedMethod; //Field offset: 0x40

	public override double currentTime
	{
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngineInternal.Input.NativeInputSystem", Member = "get_currentTime", ReturnType = typeof(double))]
		 get { } //Length: 64
	}

	public override double currentTimeForFixedUpdate
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Time), Member = "get_fixedUnscaledTime", ReturnType = typeof(float))]
		[Calls(Type = "UnityEngineInternal.Input.NativeInputSystem", Member = "get_currentTimeOffsetToRealtimeSinceStartup", ReturnType = typeof(double))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 96
	}

	public override double currentTimeOffsetToRealtimeSinceStartup
	{
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngineInternal.Input.NativeInputSystem", Member = "get_currentTimeOffsetToRealtimeSinceStartup", ReturnType = typeof(double))]
		 get { } //Length: 64
	}

	public override bool isPlayerFocused
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Application), Member = "get_isFocused", ReturnType = typeof(bool))]
		 get { } //Length: 64
	}

	public override bool normalizeScrollWheelDelta
	{
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngineInternal.Input.NativeInputSystem", Member = "get_normalizeScrollWheelDelta", ReturnType = typeof(bool))]
		 get { } //Length: 64
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngineInternal.Input.NativeInputSystem", Member = "set_normalizeScrollWheelDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		 set { } //Length: 73
	}

	public override Action<InputUpdateType> onBeforeUpdate
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 333
	}

	public override Action<Int32, String> onDeviceDiscovered
	{
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngineInternal.Input.NativeInputSystem", Member = "get_onDeviceDiscovered", ReturnType = typeof(System.Action`2<System.Int32, System.String>))]
		 get { } //Length: 64
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngineInternal.Input.NativeInputSystem", Member = "set_onDeviceDiscovered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.Int32, System.String>)}, ReturnType = typeof(void))]
		 set { } //Length: 73
	}

	public override Action<Boolean> onPlayerFocusChanged
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Application), Member = "add_focusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Application), Member = "remove_focusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 256
	}

	public override Func<InputUpdateType, Boolean> onShouldRunUpdate
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 333
	}

	public override Action onShutdown
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Application), Member = "add_quitting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Application), Member = "remove_quitting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 256
	}

	public override InputUpdateDelegate onUpdate
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 327
	}

	public override float pollingFrequency
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngineInternal.Input.NativeInputSystem", Member = "SetPollingFrequency", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		 set { } //Length: 91
	}

	public override bool runInBackground
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Application), Member = "get_runInBackground", ReturnType = typeof(bool))]
		 get { } //Length: 81
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 370
	}

	public override ScreenOrientation screenOrientation
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 7
	}

	public override Vector2 screenSize
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
		[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
		 get { } //Length: 55
	}

	public override float scrollWheelDeltaPerTick
	{
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngineInternal.Input.NativeInputSystem", Member = "GetScrollWheelDeltaPerTick", ReturnType = typeof(float))]
		 get { } //Length: 64
	}

	public override float unscaledGameTime
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static NativeInputRuntime() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public NativeInputRuntime() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngineInternal.Input.NativeInputSystem", Member = "AllocateDeviceId", ReturnType = typeof(int))]
	public override int AllocateDeviceId() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputDeviceCommand), Member = "get_payloadPtr", ReturnType = typeof(Void*))]
	[Calls(Type = typeof(InputDeviceCommand), Member = "get_payloadSizeInBytes", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngineInternal.Input.NativeInputSystem", Member = "IOCTL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(IntPtr), typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override long DeviceCommand(int deviceId, InputDeviceCommand* commandPtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngineInternal.Input.NativeInputSystem", Member = "get_currentTime", ReturnType = typeof(double))]
	public override double get_currentTime() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_fixedUnscaledTime", ReturnType = typeof(float))]
	[Calls(Type = "UnityEngineInternal.Input.NativeInputSystem", Member = "get_currentTimeOffsetToRealtimeSinceStartup", ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	public override double get_currentTimeForFixedUpdate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngineInternal.Input.NativeInputSystem", Member = "get_currentTimeOffsetToRealtimeSinceStartup", ReturnType = typeof(double))]
	public override double get_currentTimeOffsetToRealtimeSinceStartup() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Application), Member = "get_isFocused", ReturnType = typeof(bool))]
	public override bool get_isPlayerFocused() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngineInternal.Input.NativeInputSystem", Member = "get_normalizeScrollWheelDelta", ReturnType = typeof(bool))]
	public override bool get_normalizeScrollWheelDelta() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public override Action<InputUpdateType> get_onBeforeUpdate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngineInternal.Input.NativeInputSystem", Member = "get_onDeviceDiscovered", ReturnType = typeof(System.Action`2<System.Int32, System.String>))]
	public override Action<Int32, String> get_onDeviceDiscovered() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public override Action<Boolean> get_onPlayerFocusChanged() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public override Func<InputUpdateType, Boolean> get_onShouldRunUpdate() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public override Action get_onShutdown() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public override InputUpdateDelegate get_onUpdate() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override float get_pollingFrequency() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Application), Member = "get_runInBackground", ReturnType = typeof(bool))]
	public override bool get_runInBackground() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override ScreenOrientation get_screenOrientation() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	public override Vector2 get_screenSize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngineInternal.Input.NativeInputSystem", Member = "GetScrollWheelDeltaPerTick", ReturnType = typeof(float))]
	public override float get_scrollWheelDeltaPerTick() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
	[DeduplicatedMethod]
	public override float get_unscaledGameTime() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnFocusChanged(bool focus) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void OnShutdown() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool OnWantsToShutdown() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngineInternal.Input.NativeInputSystem", Member = "QueueInputEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void QueueEvent(InputEvent* ptr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngineInternal.Input.NativeInputSystem", Member = "set_normalizeScrollWheelDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	public override void set_normalizeScrollWheelDelta(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public override void set_onBeforeUpdate(Action<InputUpdateType> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngineInternal.Input.NativeInputSystem", Member = "set_onDeviceDiscovered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.Int32, System.String>)}, ReturnType = typeof(void))]
	public override void set_onDeviceDiscovered(Action<Int32, String> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Application), Member = "add_focusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Application), Member = "remove_focusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override void set_onPlayerFocusChanged(Action<Boolean> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public override void set_onShouldRunUpdate(Func<InputUpdateType, Boolean> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Application), Member = "add_quitting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Application), Member = "remove_quitting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override void set_onShutdown(Action value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public override void set_onUpdate(InputUpdateDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngineInternal.Input.NativeInputSystem", Member = "SetPollingFrequency", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	public override void set_pollingFrequency(float value) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override void set_runInBackground(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngineInternal.Input.NativeInputSystem", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngineInternal.Input.NativeInputUpdateType"}, ReturnType = typeof(void))]
	public override void Update(InputUpdateType updateType) { }

}

