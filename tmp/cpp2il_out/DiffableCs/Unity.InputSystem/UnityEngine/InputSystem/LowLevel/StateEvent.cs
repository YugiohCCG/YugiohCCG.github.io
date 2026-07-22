namespace UnityEngine.InputSystem.LowLevel;

public struct StateEvent : IInputEventTypeInfo
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <stateData>e__FixedBuffer
	{
		public byte FixedElementField; //Field offset: 0x0

	}

	public const int Type = 1398030676; //Field offset: 0x0
	internal const int kStateDataSizeToSubtract = 1; //Field offset: 0x0
	public InputEvent baseEvent; //Field offset: 0x0
	public FourCC stateFormat; //Field offset: 0x14
	[FixedBuffer(typeof(byte), 1)]
	internal <stateData>e__FixedBuffer stateData; //Field offset: 0x18

	public Void* state
	{
		[CallerCount(Count = 49)]
		 get { } //Length: 5
	}

	public uint stateSizeInBytes
	{
		[CalledBy(Type = typeof(InputEventControlEnumerator), Member = "Reset", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputControlExtensions), Member = "GetStatePtrFromStateEventUnchecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr), typeof(FourCC)}, ReturnType = typeof(Void*))]
		[CalledBy(Type = typeof(Touchscreen), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "UpdateState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputEvent*), typeof(InputUpdateType)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SwitchProControllerHID), Member = "PreProcessEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DualSenseGamepadHID), Member = "UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputEventPtr)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DualSenseGamepadHID), Member = "UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DualShock4GamepadHID), Member = "UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputEventPtr), Member = "get_stateSizeInBytes", ReturnType = typeof(uint))]
		[CalledBy(Type = typeof(StateEvent), Member = "GetState", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TState"}, ReturnType = "TState")]
		[CallerCount(Count = 16)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 19
	}

	public override FourCC typeStatic
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 6
	}

	[CalledBy(Type = typeof(InputEventPtr), Member = "get_stateSizeInBytes", ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(StateEvent), Member = "GetState", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TState"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = "TState")]
	[CalledBy(Type = typeof(InputStateHistory`1), Member = "RecordStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputControl`1<TValue>", "TValue", typeof(double)}, ReturnType = "UnityEngine.InputSystem.LowLevel.InputStateHistory`1<TValue>+Record<TValue>")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputEventPtr), Member = "IsA", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StateEvent)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputEventPtr), Member = "get_type", ReturnType = typeof(FourCC))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public static StateEvent* From(InputEventPtr ptr) { }

	[CalledBy(Type = typeof(InputControlExtensions), Member = "QueueValueChange", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputControl`1<TValue>", "TValue", typeof(double)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+NewEventsMsg", Member = "CreateStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(Message))]
	[CalledBy(Type = typeof(OnScreenControl), Member = "SetupInputControl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputStateHistory`1), Member = "RecordStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputControl`1<TValue>", "TValue", typeof(double)}, ReturnType = "UnityEngine.InputSystem.LowLevel.InputStateHistory`1<TValue>+Record<TValue>")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StateEvent), Member = "From", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputEventPtr&), typeof(Allocator), typeof(bool)}, ReturnType = typeof(Unity.Collections.NativeArray`1<System.Byte>))]
	public static NativeArray<Byte> From(InputDevice device, out InputEventPtr eventPtr, Allocator allocator = 2) { }

	[CalledBy(Type = typeof(StateEvent), Member = "From", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputEventPtr&), typeof(Allocator)}, ReturnType = typeof(Unity.Collections.NativeArray`1<System.Byte>))]
	[CalledBy(Type = typeof(StateEvent), Member = "FromDefaultStateFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputEventPtr&), typeof(Allocator)}, ReturnType = typeof(Unity.Collections.NativeArray`1<System.Byte>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputDevice), Member = "get_added", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControl), Member = "get_currentStatePtr", ReturnType = typeof(Void*))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FourCC), typeof(int), typeof(int), typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private static NativeArray<Byte> From(InputDevice device, out InputEventPtr eventPtr, Allocator allocator, bool useDefaultState) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StateEvent), Member = "From", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputEventPtr&), typeof(Allocator), typeof(bool)}, ReturnType = typeof(Unity.Collections.NativeArray`1<System.Byte>))]
	public static NativeArray<Byte> FromDefaultStateFor(InputDevice device, out InputEventPtr eventPtr, Allocator allocator = 2) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	internal static StateEvent* FromUnchecked(InputEventPtr ptr) { }

	[CallerCount(Count = 49)]
	public Void* get_state() { }

	[CalledBy(Type = typeof(InputEventControlEnumerator), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "GetStatePtrFromStateEventUnchecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr), typeof(FourCC)}, ReturnType = typeof(Void*))]
	[CalledBy(Type = typeof(Touchscreen), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "UpdateState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputEvent*), typeof(InputUpdateType)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SwitchProControllerHID), Member = "PreProcessEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DualSenseGamepadHID), Member = "UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputEventPtr)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DualSenseGamepadHID), Member = "UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DualShock4GamepadHID), Member = "UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputEventPtr), Member = "get_stateSizeInBytes", ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(StateEvent), Member = "GetState", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TState"}, ReturnType = "TState")]
	[CallerCount(Count = 16)]
	[CallsDeduplicatedMethods(Count = 1)]
	public uint get_stateSizeInBytes() { }

	[CallerCount(Count = 0)]
	public override FourCC get_typeStatic() { }

	[CalledBy(Type = typeof(Touchscreen), Member = "UnityEngine.InputSystem.LowLevel.ICustomDeviceReset.Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static int GetEventSizeWithPayload() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StateEvent), Member = "get_state", ReturnType = typeof(Void*))]
	[Calls(Type = typeof(StateEvent), Member = "get_stateSizeInBytes", ReturnType = typeof(uint))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 21)]
	[DeduplicatedMethod]
	public TState GetState() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StateEvent), Member = "From", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(StateEvent*))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public static TState GetState(InputEventPtr ptr) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public InputEventPtr ToEventPtr() { }

}

