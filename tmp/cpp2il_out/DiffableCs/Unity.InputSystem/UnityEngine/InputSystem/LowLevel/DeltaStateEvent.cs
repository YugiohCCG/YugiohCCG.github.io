namespace UnityEngine.InputSystem.LowLevel;

public struct DeltaStateEvent : IInputEventTypeInfo
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <stateData>e__FixedBuffer
	{
		public byte FixedElementField; //Field offset: 0x0

	}

	public const int Type = 1145852993; //Field offset: 0x0
	public InputEvent baseEvent; //Field offset: 0x0
	public FourCC stateFormat; //Field offset: 0x14
	public uint stateOffset; //Field offset: 0x18
	[FixedBuffer(typeof(byte), 1)]
	internal <stateData>e__FixedBuffer stateData; //Field offset: 0x1C

	public Void* deltaState
	{
		[CalledBy(Type = typeof(InputEventControlEnumerator), Member = "Reset", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputControlExtensions), Member = "GetStatePtrFromStateEventUnchecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr), typeof(FourCC)}, ReturnType = typeof(Void*))]
		[CalledBy(Type = typeof(InputManager), Member = "UpdateState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputEvent*), typeof(InputUpdateType)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		 get { } //Length: 5
	}

	public uint deltaStateSizeInBytes
	{
		[CalledBy(Type = typeof(InputEventControlEnumerator), Member = "Reset", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputControlExtensions), Member = "GetStatePtrFromStateEventUnchecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr), typeof(FourCC)}, ReturnType = typeof(Void*))]
		[CalledBy(Type = typeof(InputManager), Member = "UpdateState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputEvent*), typeof(InputUpdateType)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		 get { } //Length: 8
	}

	public override FourCC typeStatic
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 6
	}

	[CalledBy(Type = typeof(InputEventPtr), Member = "get_stateSizeInBytes", ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(InputEventPtr), Member = "get_stateOffset", ReturnType = typeof(uint))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputEventPtr), Member = "IsA", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeltaStateEvent)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputEventPtr), Member = "get_type", ReturnType = typeof(FourCC))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public static DeltaStateEvent* From(InputEventPtr ptr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputDevice), Member = "get_added", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControl), Member = "get_currentStatePtr", ReturnType = typeof(Void*))]
	[Calls(Type = typeof(InputStateBlock), Member = "get_alignedSizeInBytes", ReturnType = typeof(uint))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FourCC), typeof(int), typeof(int), typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	public static NativeArray<Byte> From(InputControl control, out InputEventPtr eventPtr, Allocator allocator = 2) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	internal static DeltaStateEvent* FromUnchecked(InputEventPtr ptr) { }

	[CalledBy(Type = typeof(InputEventControlEnumerator), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "GetStatePtrFromStateEventUnchecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr), typeof(FourCC)}, ReturnType = typeof(Void*))]
	[CalledBy(Type = typeof(InputManager), Member = "UpdateState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputEvent*), typeof(InputUpdateType)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	public Void* get_deltaState() { }

	[CalledBy(Type = typeof(InputEventControlEnumerator), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "GetStatePtrFromStateEventUnchecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr), typeof(FourCC)}, ReturnType = typeof(Void*))]
	[CalledBy(Type = typeof(InputManager), Member = "UpdateState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputEvent*), typeof(InputUpdateType)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	public uint get_deltaStateSizeInBytes() { }

	[CallerCount(Count = 0)]
	public override FourCC get_typeStatic() { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public InputEventPtr ToEventPtr() { }

}

