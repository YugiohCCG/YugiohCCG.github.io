namespace UnityEngineInternal.Input;

[NativeHeader("Modules/Input/Private/InputInternal.h")]
[NativeHeader("Modules/Input/Private/InputModuleBindings.h")]
internal class NativeInputSystem
{
	public static NativeUpdateCallback onUpdate; //Field offset: 0x0
	public static Action<NativeInputUpdateType> onBeforeUpdate; //Field offset: 0x8
	public static Func<NativeInputUpdateType, Boolean> onShouldRunUpdate; //Field offset: 0x10
	private static Action<Int32, String> s_OnDeviceDiscoveredCallback; //Field offset: 0x18

	[NativeProperty(IsThreadSafe = True)]
	public static double currentTime
	{
		[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime", Member = "get_currentTime", ReturnType = typeof(double))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
	}

	[NativeProperty(IsThreadSafe = True)]
	public static double currentTimeOffsetToRealtimeSinceStartup
	{
		[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime", Member = "get_currentTimeForFixedUpdate", ReturnType = typeof(double))]
		[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime", Member = "get_currentTimeOffsetToRealtimeSinceStartup", ReturnType = typeof(double))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
	}

	internal static bool hasDeviceDiscoveredCallback
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal set { } //Length: 51
	}

	[NativeProperty("NormalizeScrollWheelDelta")]
	internal static bool normalizeScrollWheelDelta
	{
		[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime", Member = "get_normalizeScrollWheelDelta", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 42
		[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime", Member = "set_normalizeScrollWheelDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal set { } //Length: 51
	}

	public static Action<Int32, String> onDeviceDiscovered
	{
		[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime", Member = "get_onDeviceDiscovered", ReturnType = "System.Action`2<Int32, String>")]
		[CallerCount(Count = 1)]
		 get { } //Length: 79
		[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime", Member = "set_onDeviceDiscovered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`2<Int32, String>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 168
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static NativeInputSystem() { }

	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime", Member = "AllocateDeviceId", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("AllocateInputDeviceId")]
	public static int AllocateDeviceId() { }

	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime", Member = "get_currentTime", ReturnType = typeof(double))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static double get_currentTime() { }

	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime", Member = "get_currentTimeForFixedUpdate", ReturnType = typeof(double))]
	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime", Member = "get_currentTimeOffsetToRealtimeSinceStartup", ReturnType = typeof(double))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static double get_currentTimeOffsetToRealtimeSinceStartup() { }

	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime", Member = "get_normalizeScrollWheelDelta", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static bool get_normalizeScrollWheelDelta() { }

	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime", Member = "get_onDeviceDiscovered", ReturnType = "System.Action`2<Int32, String>")]
	[CallerCount(Count = 1)]
	public static Action<Int32, String> get_onDeviceDiscovered() { }

	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime", Member = "get_scrollWheelDeltaPerTick", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static float GetScrollWheelDeltaPerTick() { }

	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime", Member = "DeviceCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.InputSystem.LowLevel.InputDeviceCommand*"}, ReturnType = typeof(long))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static long IOCTL(int deviceId, int code, IntPtr data, int sizeInBytes) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	internal static void NotifyBeforeUpdate(NativeInputUpdateType updateType) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	internal static void NotifyDeviceDiscovered(int deviceId, string deviceDescriptor) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	internal static void NotifyUpdate(NativeInputUpdateType updateType, IntPtr eventBuffer) { }

	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime", Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.LowLevel.InputEvent*"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(IsThreadSafe = True)]
	public static void QueueInputEvent(IntPtr inputEvent) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal static void set_hasDeviceDiscoveredCallback(bool value) { }

	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime", Member = "set_normalizeScrollWheelDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static void set_normalizeScrollWheelDelta(bool value) { }

	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime", Member = "set_onDeviceDiscovered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`2<Int32, String>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public static void set_onDeviceDiscovered(Action<Int32, String> value) { }

	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime", Member = "set_pollingFrequency", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void SetPollingFrequency(float hertz) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	internal static void ShouldRunUpdate(NativeInputUpdateType updateType, out bool retval) { }

	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.NativeInputRuntime", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.LowLevel.InputUpdateType"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void Update(NativeInputUpdateType updateType) { }

}

