namespace UnityEngine.InputSystem;

[InputControlLayout(stateType = typeof(TouchscreenState), isGenericTypeOfDevice = True)]
public class Touchscreen : Pointer, IInputStateCallbackReceiver, IEventMerger, ICustomDeviceReset
{
	private static readonly ProfilerMarker k_TouchscreenUpdateMarker; //Field offset: 0x0
	private static readonly ProfilerMarker k_TouchAllocateMarker; //Field offset: 0x8
	[CompilerGenerated]
	private static Touchscreen <current>k__BackingField; //Field offset: 0x10
	internal static float s_TapTime; //Field offset: 0x18
	internal static float s_TapDelayTime; //Field offset: 0x1C
	internal static float s_TapRadiusSquared; //Field offset: 0x20
	[CompilerGenerated]
	private TouchControl <primaryTouch>k__BackingField; //Field offset: 0x1C0
	[CompilerGenerated]
	private ReadOnlyArray<TouchControl> <touches>k__BackingField; //Field offset: 0x1C8

	public internal static Touchscreen current
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 79
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		internal set { } //Length: 110
	}

	public TouchControl primaryTouch
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	protected TouchControl[] touchControlArray
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CalledBy(Type = typeof(FastTouchscreen), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 109
	}

	public ReadOnlyArray<TouchControl> touches
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		 set { } //Length: 24
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	private static Touchscreen() { }

	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Touchscreen() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Pointer), Member = "FinishSetup", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputControl), Member = "GetChildControl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "TControl")]
	[Calls(Type = typeof(InputControl), Member = "get_children", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControl>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	protected virtual void FinishSetup() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static Touchscreen get_current() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public TouchControl get_primaryTouch() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	protected TouchControl[] get_touchControlArray() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ReadOnlyArray<TouchControl> get_touches() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void MakeCurrent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputEventPtr), Member = "get_type", ReturnType = typeof(FourCC))]
	[Calls(Type = typeof(TouchState), Member = "get_Format", ReturnType = typeof(FourCC))]
	[Calls(Type = typeof(StateEvent), Member = "get_state", ReturnType = typeof(Void*))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

	[CalledBy(Type = typeof(Touchscreen), Member = "UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputControl), Member = "get_currentStatePtr", ReturnType = typeof(Void*))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = "UnityEngine.Rendering.MousePositionDebug", Member = "GetMouseClickPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(InputState), Member = "Change", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Vector2), typeof(InputUpdateType), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputState), Member = "get_currentTime", ReturnType = typeof(double))]
	[Calls(Type = typeof(InputState), Member = "Change", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TState"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), "TState", typeof(InputUpdateType), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected void OnNextUpdate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Pointer), Member = "OnRemoved", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnRemoved() { }

	[CalledBy(Type = typeof(Touchscreen), Member = "UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Rendering.MousePositionDebug", Member = "GetMouseClickPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(InputState), Member = "Change", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TState"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), "TState", typeof(InputUpdateType), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchState), Member = "get_isInProgress", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchState), Member = "get_isOrphanedPrimaryTouch", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchState), Member = "get_isPrimaryTouch", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputState), Member = "Change", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TouchState)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(TouchState&), typeof(InputUpdateType), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchState), Member = "set_isOrphanedPrimaryTouch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TouchState), Member = "set_isPrimaryTouch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputEventPtr), Member = "get_time", ReturnType = typeof(double))]
	[Calls(Type = typeof(TouchState), Member = "get_isNoneEndedOrCanceled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchState), Member = "set_isTapRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StateEvent), Member = "get_state", ReturnType = typeof(Void*))]
	[Calls(Type = typeof(StateEvent), Member = "get_stateSizeInBytes", ReturnType = typeof(uint))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputControl), Member = "get_currentStatePtr", ReturnType = typeof(Void*))]
	[Calls(Type = typeof(TouchState), Member = "get_Format", ReturnType = typeof(FourCC))]
	[Calls(Type = typeof(InputEventPtr), Member = "get_type", ReturnType = typeof(FourCC))]
	[Calls(Type = typeof(Touchscreen), Member = "TriggerTap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TouchControl), typeof(TouchState&), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputState), Member = "Change", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputEventPtr), typeof(InputUpdateType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected void OnStateEvent(InputEventPtr eventPtr) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	internal static void set_current(Touchscreen value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_primaryTouch(TouchControl value) { }

	[CalledBy(Type = typeof(FastTouchscreen), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected void set_touchControlArray(TouchControl[] value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	protected void set_touches(ReadOnlyArray<TouchControl> value) { }

	[CalledBy(Type = typeof(Touchscreen), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TouchState), Member = "set_isTapRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputState), Member = "Change", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TouchState)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(TouchState&), typeof(InputUpdateType), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	private static void TriggerTap(TouchControl control, ref TouchState state, InputEventPtr eventPtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControl), Member = "get_currentStatePtr", ReturnType = typeof(Void*))]
	[Calls(Type = typeof(StateEvent), Member = "GetEventSizeWithPayload", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TState"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FourCC), typeof(int), typeof(int), typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StateEvent), Member = "get_state", ReturnType = typeof(Void*))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputState), Member = "Change", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), "System.Int32Enum", typeof(InputUpdateType), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private override void UnityEngine.InputSystem.LowLevel.ICustomDeviceReset.Reset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputEventPtr), Member = "get_type", ReturnType = typeof(FourCC))]
	[Calls(Type = typeof(TouchState), Member = "get_Format", ReturnType = typeof(FourCC))]
	[Calls(Type = typeof(StateEvent), Member = "get_state", ReturnType = typeof(Void*))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private override bool UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputEventPtr), Member = "IsA", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StateEvent)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TouchState), Member = "get_Format", ReturnType = typeof(FourCC))]
	[Calls(Type = typeof(InputControlExtensions), Member = "FindInParentChain", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = "TControl")]
	[Calls(Type = typeof(InputControl), Member = "get_currentStatePtr", ReturnType = typeof(Void*))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(StateEvent), Member = "get_state", ReturnType = typeof(Void*))]
	[Calls(Type = typeof(TouchState), Member = "get_isInProgress", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputStateBlock), Member = "get_alignedSizeInBytes", ReturnType = typeof(uint))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private override bool UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Touchscreen), Member = "OnNextUpdate", ReturnType = typeof(void))]
	private override void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Touchscreen), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	private override void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) { }

}

