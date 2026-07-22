namespace UnityEngine.InputSystem.EnhancedTouch;

public static class EnhancedTouchSupport
{
	private static int s_Enabled; //Field offset: 0x0
	private static UpdateMode s_UpdateMode; //Field offset: 0x4

	public static bool enabled
	{
		[CalledBy(Type = "UnityEngine.Rendering.DebugManager", Member = "GetActionToggleDebugMenuWithTouch", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 57
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	internal static void CheckEnabled() { }

	[CalledBy(Type = "Manager.Hotkey", Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "remove_onDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "remove_onBeforeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "remove_onSettingsChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EnhancedTouchSupport), Member = "TearDownState", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void Disable() { }

	[CalledBy(Type = "Manager.Hotkey", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugUpdater", Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugUpdater", Member = "EnableRuntime", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "add_onDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "add_onBeforeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "add_onSettingsChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EnhancedTouchSupport), Member = "SetUpState", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void Enable() { }

	[CalledBy(Type = "UnityEngine.Rendering.DebugManager", Member = "GetActionToggleDebugMenuWithTouch", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool get_enabled() { }

	[CalledBy(Type = typeof(EnhancedTouchSupport), Member = "SetUpState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EnhancedTouchSupport), Member = "TearDownState", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "AppendWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(FingerAndTouchState), Member = "AddFingers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touchscreen)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputArrayExtensions), Member = "IndexOfReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.InlinedArray`1<TValue>", "TValue"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "RemoveAtWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FingerAndTouchState), Member = "RemoveFingers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touchscreen)}, ReturnType = typeof(void))]
	private static void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
	[Calls(Type = typeof(EnhancedTouchSupport), Member = "TearDownState", ReturnType = typeof(void))]
	[Calls(Type = typeof(EnhancedTouchSupport), Member = "SetUpState", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void OnSettingsChange() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FingerAndTouchState), Member = "Destroy", ReturnType = typeof(void))]
	internal static void Reset() { }

	[CalledBy(Type = typeof(EnhancedTouchSupport), Member = "Enable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EnhancedTouchSupport), Member = "OnSettingsChange", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
	[Calls(Type = typeof(InputSystem), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[Calls(Type = typeof(EnhancedTouchSupport), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetUpState() { }

	[CalledBy(Type = typeof(EnhancedTouchSupport), Member = "Disable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EnhancedTouchSupport), Member = "OnSettingsChange", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputSystem), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[Calls(Type = typeof(EnhancedTouchSupport), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputStateHistory), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	internal static void TearDownState() { }

}

