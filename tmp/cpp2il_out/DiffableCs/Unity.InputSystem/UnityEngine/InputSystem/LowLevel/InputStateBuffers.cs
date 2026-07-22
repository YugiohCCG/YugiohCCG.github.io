namespace UnityEngine.InputSystem.LowLevel;

internal struct InputStateBuffers
{
	public struct DoubleBuffers
	{
		public Void** deviceToBufferMapping; //Field offset: 0x0
		public int deviceCount; //Field offset: 0x8

		public bool valid
		{
			[CallerCount(Count = 19)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			 get { } //Length: 8
		}

		[CallerCount(Count = 19)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public bool get_valid() { }

		[CalledBy(Type = typeof(InputManager), Member = "InitializeDefaultState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "InitializeDeviceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "WriteStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DoubleBuffers), typeof(int), typeof(InputStateBlock&), typeof(uint), typeof(Void*), typeof(uint), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		public Void* GetBackBuffer(int deviceIndex) { }

		[CalledBy(Type = typeof(InputManager), Member = "InitializeDefaultState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "InitializeDeviceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "WriteStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DoubleBuffers), typeof(int), typeof(InputStateBlock&), typeof(uint), typeof(Void*), typeof(uint), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		public Void* GetFrontBuffer(int deviceIndex) { }

		[CallerCount(Count = 0)]
		public void SetBackBuffer(int deviceIndex, Void* ptr) { }

		[CallerCount(Count = 0)]
		public void SetFrontBuffer(int deviceIndex, Void* ptr) { }

		[CalledBy(Type = typeof(InputManager), Member = "UpdateState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputUpdateType), typeof(Void*), typeof(uint), typeof(uint), typeof(double), typeof(InputEventPtr)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputManager), Member = "FlipBuffersForDeviceIfNecessary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputUpdateType)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		public void SwapBuffers(int deviceIndex) { }

	}

	internal static Void* s_DefaultStateBuffer; //Field offset: 0x0
	internal static Void* s_NoiseMaskBuffer; //Field offset: 0x8
	internal static Void* s_ResetMaskBuffer; //Field offset: 0x10
	internal static DoubleBuffers s_CurrentBuffers; //Field offset: 0x18
	public uint sizePerBuffer; //Field offset: 0x0
	public uint totalSize; //Field offset: 0x4
	public Void* defaultStateBuffer; //Field offset: 0x8
	public Void* noiseMaskBuffer; //Field offset: 0x10
	public Void* resetMaskBuffer; //Field offset: 0x18
	private Void* m_AllBuffers; //Field offset: 0x20
	internal DoubleBuffers m_PlayerStateBuffers; //Field offset: 0x28

	[CalledBy(Type = typeof(InputManager), Member = "ReallocateStateBuffers", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputStateBuffers), Member = "NextDeviceOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(InputDevice)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(UnsafeUtility), Member = "Malloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(Allocator)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void AllocateAll(InputDevice[] devices, int deviceCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputStateBuffers), Member = "NextDeviceOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(InputDevice)}, ReturnType = typeof(uint))]
	[CallsUnknownMethods(Count = 2)]
	private static uint ComputeSizeOfSingleStateBuffer(InputDevice[] devices, int deviceCount) { }

	[CalledBy(Type = typeof(InputManager), Member = "RemoveDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "Destroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "ReallocateStateBuffers", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Allocator)}, ReturnType = typeof(void))]
	public void FreeAll() { }

	[CalledBy(Type = typeof(InputControl), Member = "get_previousFrameStatePtr", ReturnType = typeof(Void*))]
	[CallerCount(Count = 1)]
	public static Void* GetBackBufferForDevice(int deviceIndex) { }

	[CalledBy(Type = typeof(InputStateBuffers), Member = "SwitchTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputStateBuffers), typeof(InputUpdateType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public DoubleBuffers GetDoubleBuffersFor(InputUpdateType updateType) { }

	[CalledBy(Type = typeof(InputControl), Member = "get_magnitude", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "GetFirstButtonPressOrNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(float), typeof(bool)}, ReturnType = typeof(InputControl))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "HasValueChangeInEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InputEventPtr)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "HasValueChangeInState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Void*)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "CompareState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Void*), typeof(Void*)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "CompareStateIgnoringNoise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Void*)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "CheckStateIsAtDefaultIgnoringNoise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "CheckStateIsAtDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "CopyState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "WriteValueIntoState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Void*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "ReadValueIntoBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "ReadValueAsObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "IsActuated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(float)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "IsPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(float)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputEventControlEnumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice), typeof(Enumerate), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputControl), Member = "get_currentStatePtr", ReturnType = typeof(Void*))]
	[CalledBy(Type = typeof(InputControl), Member = "EvaluateMagnitude", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(InputControl), Member = "DebuggerDisplay", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputManager), Member = "UpdateState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputUpdateType), typeof(Void*), typeof(uint), typeof(uint), typeof(double), typeof(InputEventPtr)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 21)]
	public static Void* GetFrontBufferForDevice(int deviceIndex) { }

	[CalledBy(Type = typeof(InputManager), Member = "ReallocateStateBuffers", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputStateBuffers), Member = "MigrateDoubleBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DoubleBuffers), typeof(InputDevice[]), typeof(int), typeof(DoubleBuffers)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputStateBuffers), Member = "MigrateSingleBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(InputDevice[]), typeof(int), typeof(Void*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputControl), Member = "BakeOffsetIntoStateBlockRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputStateBuffers), Member = "NextDeviceOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(InputDevice)}, ReturnType = typeof(uint))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void MigrateAll(InputDevice[] devices, int deviceCount, InputStateBuffers oldBuffers) { }

	[CalledBy(Type = typeof(InputStateBuffers), Member = "MigrateAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice[]), typeof(int), typeof(InputStateBuffers)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputStateBlock), Member = "get_alignedSizeInBytes", ReturnType = typeof(uint))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputStateBuffers), Member = "NextDeviceOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(InputDevice)}, ReturnType = typeof(uint))]
	[CallsUnknownMethods(Count = 2)]
	private static void MigrateDoubleBuffer(DoubleBuffers newBuffer, InputDevice[] devices, int deviceCount, DoubleBuffers oldBuffer) { }

	[CalledBy(Type = typeof(InputStateBuffers), Member = "MigrateAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice[]), typeof(int), typeof(InputStateBuffers)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputStateBlock), Member = "get_alignedSizeInBytes", ReturnType = typeof(uint))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputStateBuffers), Member = "NextDeviceOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(InputDevice)}, ReturnType = typeof(uint))]
	[CallsUnknownMethods(Count = 2)]
	private static void MigrateSingleBuffer(Void* newBuffer, InputDevice[] devices, int deviceCount, Void* oldBuffer) { }

	[CalledBy(Type = typeof(InputStateBuffers), Member = "AllocateAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputStateBuffers), Member = "MigrateAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice[]), typeof(int), typeof(InputStateBuffers)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputStateBuffers), Member = "MigrateDoubleBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DoubleBuffers), typeof(InputDevice[]), typeof(int), typeof(DoubleBuffers)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputStateBuffers), Member = "MigrateSingleBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(InputDevice[]), typeof(int), typeof(Void*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputStateBuffers), Member = "ComputeSizeOfSingleStateBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice[]), typeof(int)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static uint NextDeviceOffset(uint currentOffset, InputDevice device) { }

	[CallerCount(Count = 0)]
	private static DoubleBuffers SetUpDeviceToBufferMappings(int deviceCount, ref Byte* bufferPtr, uint sizePerBuffer, uint mappingTableSizePerBuffer) { }

	[CalledBy(Type = typeof(InputManager), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputRuntime), typeof(InputSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "InstallGlobals", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "ReallocateStateBuffers", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "OnBeforeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(InputStateBuffers), Member = "GetDoubleBuffersFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType)}, ReturnType = typeof(DoubleBuffers))]
	public static void SwitchTo(InputStateBuffers buffers, InputUpdateType update) { }

}

