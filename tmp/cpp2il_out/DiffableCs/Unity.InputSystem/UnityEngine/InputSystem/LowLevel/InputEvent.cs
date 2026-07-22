namespace UnityEngine.InputSystem.LowLevel;

public struct InputEvent
{
	private const uint kHandledMask = 2147483648; //Field offset: 0x0
	private const uint kIdMask = 2147483647; //Field offset: 0x0
	internal const int kBaseEventSize = 20; //Field offset: 0x0
	public const int InvalidEventId = 0; //Field offset: 0x0
	internal const int kAlignment = 4; //Field offset: 0x0
	private NativeInputEvent m_Event; //Field offset: 0x0

	public int deviceId
	{
		[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		 get { } //Length: 5
		[CalledBy(Type = typeof(InputManager), Member = "ResetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(System.Nullable`1<System.Boolean>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 set { } //Length: 5
	}

	public int eventId
	{
		[CalledBy(Type = typeof(InputActionState), Member = "ProcessControlStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(double), typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionState), Member = "ShouldIgnoreInputOnCompositeBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingState*), typeof(InputEvent*)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 8
		[CalledBy(Type = typeof(InputManager), Member = "ResetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(System.Nullable`1<System.Boolean>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 set { } //Length: 14
	}

	public bool handled
	{
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CalledBy(Type = typeof(InputManager), Member = "FireStateChangeNotifications", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(double), typeof(InputEvent*)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 28
	}

	internal double internalTime
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		internal get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 6
	}

	public uint sizeInBytes
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(InputManager), Member = "ResetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(System.Nullable`1<System.Boolean>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputEventBuffer), Member = "AllocateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Allocator)}, ReturnType = typeof(InputEvent*))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ushort), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 166
	}

	public double time
	{
		[CalledBy(Type = typeof(ActionEventPtr), Member = "get_time", ReturnType = typeof(double))]
		[CalledBy(Type = typeof(ActionEventPtr), Member = "get_duration", ReturnType = typeof(double))]
		[CalledBy(Type = typeof(ActionEventPtr), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 4)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 67
		[CalledBy(Type = typeof(InputManager), Member = "ResetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(System.Nullable`1<System.Boolean>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionTrace), Member = "RecordAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 80
	}

	public FourCC type
	{
		[CallerCount(Count = 173)]
		[DeduplicatedMethod]
		 get { } //Length: 3
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	[CalledBy(Type = typeof(InputSystem), Member = "QueueStateEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TState"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), "TState", typeof(double)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystem), Member = "QueueDeltaStateEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDelta"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), "TDelta", typeof(double)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Touchscreen), Member = "UnityEngine.InputSystem.LowLevel.ICustomDeviceReset.Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "FireStateChangeNotifications", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(double), typeof(InputEvent*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeltaStateEvent), Member = "From", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr&), typeof(Allocator)}, ReturnType = typeof(Unity.Collections.NativeArray`1<System.Byte>))]
	[CalledBy(Type = typeof(StateEvent), Member = "From", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputEventPtr&), typeof(Allocator), typeof(bool)}, ReturnType = typeof(Unity.Collections.NativeArray`1<System.Byte>))]
	[CalledBy(Type = typeof(TextEvent), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(double)}, ReturnType = typeof(TextEvent))]
	[CalledBy(Type = typeof(TextEvent), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(double)}, ReturnType = typeof(TextEvent))]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public InputEvent(FourCC type, int sizeInBytes, int deviceId, double time = -1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public static bool Equals(InputEvent* first, InputEvent* second) { }

	[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	public int get_deviceId() { }

	[CalledBy(Type = typeof(InputActionState), Member = "ProcessControlStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(double), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "ShouldIgnoreInputOnCompositeBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingState*), typeof(InputEvent*)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public int get_eventId() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public bool get_handled() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	internal double get_internalTime() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public uint get_sizeInBytes() { }

	[CalledBy(Type = typeof(ActionEventPtr), Member = "get_time", ReturnType = typeof(double))]
	[CalledBy(Type = typeof(ActionEventPtr), Member = "get_duration", ReturnType = typeof(double))]
	[CalledBy(Type = typeof(ActionEventPtr), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	public double get_time() { }

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	public FourCC get_type() { }

	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.InputActionTrace+Enumerator", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	internal static InputEvent* GetNextInMemory(InputEvent* currentPtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	internal static InputEvent* GetNextInMemoryChecked(InputEvent* currentPtr, ref InputEventBuffer buffer) { }

	[CalledBy(Type = typeof(InputManager), Member = "ResetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(System.Nullable`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public void set_deviceId(int value) { }

	[CalledBy(Type = typeof(InputManager), Member = "ResetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(System.Nullable`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public void set_eventId(int value) { }

	[CalledBy(Type = typeof(InputManager), Member = "FireStateChangeNotifications", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(double), typeof(InputEvent*)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void set_handled(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_internalTime(double value) { }

	[CalledBy(Type = typeof(InputManager), Member = "ResetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(System.Nullable`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputEventBuffer), Member = "AllocateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Allocator)}, ReturnType = typeof(InputEvent*))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ushort), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void set_sizeInBytes(uint value) { }

	[CalledBy(Type = typeof(InputManager), Member = "ResetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(System.Nullable`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = "RecordAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void set_time(double value) { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public void set_type(FourCC value) { }

	[CalledBy(Type = typeof(InputEventPtr), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 22)]
	[ContainsUnimplementedInstructions]
	public virtual string ToString() { }

}

