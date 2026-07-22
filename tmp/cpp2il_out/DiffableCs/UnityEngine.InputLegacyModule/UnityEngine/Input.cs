namespace UnityEngine;

[NativeHeader("Runtime/Input/InputBindings.h")]
public class Input
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static bool <simulateTouchEnabled>k__BackingField; //Field offset: 0x0

	[NativeThrows]
	public static bool anyKey
	{
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+Input", Member = "get_anyKey", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
	}

	public static Vector2 compositionCursorPos
	{
		[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "get_compositionCursorPos", ReturnType = typeof(Vector2))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 59
		[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "set_compositionCursorPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 52
	}

	public static string compositionString
	{
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "get_compositionString", ReturnType = typeof(string))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "get_compositionString", ReturnType = typeof(string))]
		[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "get_compositionString", ReturnType = typeof(string))]
		[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Input", Member = "get_compositionString", ReturnType = typeof(string))]
		[CallerCount(Count = 4)]
		[Calls(Type = "UnityEngine.Bindings.OutStringMarshaller", Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bindings.ManagedSpanWrapper"}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 164
	}

	public static IMECompositionMode imeCompositionMode
	{
		[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "get_imeCompositionMode", ReturnType = typeof(IMECompositionMode))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
		[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "set_imeCompositionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMECompositionMode)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 49
	}

	[NativeThrows]
	public static Vector3 mousePosition
	{
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+Input", Member = "get_mousePosition", ReturnType = typeof(Vector3))]
		[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "get_mousePosition", ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Input", Member = "get_mousePosition", ReturnType = typeof(Vector3))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 62
	}

	public static bool mousePresent
	{
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+Input", Member = "get_mousePresent", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "get_mousePresent", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Input", Member = "get_mousePresent", ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 109
	}

	[NativeThrows]
	public static Vector2 mouseScrollDelta
	{
		[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "get_mouseScrollDelta", ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Input", Member = "get_mouseScrollDelta", ReturnType = typeof(Vector2))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 59
	}

	internal static bool simulateTouchEnabled
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 54
	}

	public static int touchCount
	{
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+Input", Member = "get_touchCount", ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "get_touchCount", ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Input", Member = "get_touchCount", ReturnType = typeof(int))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[FreeFunction("GetTouchCount")]
		 get { } //Length: 42
	}

	public static bool touchSupported
	{
		[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "get_touchSupported", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Input", Member = "get_touchSupported", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 112
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal static bool CheckDisabled() { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+Input", Member = "ClearLastPenContactEvent", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[NativeThrows]
	public static void ClearLastPenContactEvent() { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+Input", Member = "get_anyKey", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static bool get_anyKey() { }

	[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "get_compositionCursorPos", ReturnType = typeof(Vector2))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Vector2 get_compositionCursorPos() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_compositionCursorPos_Injected(out Vector2 ret) { }

	[CalledBy(Type = "TMPro.TMP_InputField", Member = "get_compositionString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "get_compositionString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "get_compositionString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Input", Member = "get_compositionString", ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = "UnityEngine.Bindings.OutStringMarshaller", Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bindings.ManagedSpanWrapper"}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	public static string get_compositionString() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_compositionString_Injected(out ManagedSpanWrapper ret) { }

	[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "get_imeCompositionMode", ReturnType = typeof(IMECompositionMode))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static IMECompositionMode get_imeCompositionMode() { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+Input", Member = "get_mousePosition", ReturnType = typeof(Vector3))]
	[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "get_mousePosition", ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Input", Member = "get_mousePosition", ReturnType = typeof(Vector3))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static Vector3 get_mousePosition() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_mousePosition_Injected(out Vector3 ret) { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+Input", Member = "get_mousePresent", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "get_mousePresent", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Input", Member = "get_mousePresent", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool get_mousePresent() { }

	[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "get_mouseScrollDelta", ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Input", Member = "get_mouseScrollDelta", ReturnType = typeof(Vector2))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static Vector2 get_mouseScrollDelta() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_mouseScrollDelta_Injected(out Vector2 ret) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal static bool get_simulateTouchEnabled() { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+Input", Member = "get_touchCount", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "get_touchCount", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Input", Member = "get_touchCount", ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("GetTouchCount")]
	public static int get_touchCount() { }

	[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "get_touchSupported", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Input", Member = "get_touchSupported", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool get_touchSupported() { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+Input", Member = "GetAxisRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputUnsafeUtility), Member = "GetAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	public static float GetAxis(string axisName) { }

	[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "GetAxisRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Input", Member = "GetAxisRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputUnsafeUtility), Member = "GetAxisRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	public static float GetAxisRaw(string axisName) { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+Input", Member = "GetButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "GetButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Input", Member = "GetButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputUnsafeUtility), Member = "GetButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	public static bool GetButtonDown(string buttonName) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static bool GetKey(KeyCode key) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[NativeThrows]
	private static bool GetKeyInt(KeyCode key) { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+Input", Member = "GetLastPenContactEvent", ReturnType = typeof(PenData))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Input", Member = "GetLastPenContactEvent", ReturnType = typeof(PenData))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[NativeThrows]
	public static PenData GetLastPenContactEvent() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetLastPenContactEvent_Injected(out PenData ret) { }

	[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "GetMouseButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Input", Member = "GetMouseButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[NativeThrows]
	public static bool GetMouseButton(int button) { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+Input", Member = "GetMouseButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "GetMouseButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Input", Member = "GetMouseButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[NativeThrows]
	public static bool GetMouseButtonDown(int button) { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+Input", Member = "GetMouseButtonUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "GetMouseButtonUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Input", Member = "GetMouseButtonUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[NativeThrows]
	public static bool GetMouseButtonUp(int button) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("GetMousePresent")]
	private static bool GetMousePresentInternal() { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+Input", Member = "GetTouch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Touch))]
	[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "GetTouch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Touch))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Input", Member = "GetTouch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Touch))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[NativeThrows]
	public static Touch GetTouch(int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetTouch_Injected(int index, out Touch ret) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("IsTouchSupported")]
	private static bool GetTouchSupportedInternal() { }

	[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "set_compositionCursorPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_compositionCursorPos(Vector2 value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_compositionCursorPos_Injected(in Vector2 value) { }

	[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "set_imeCompositionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMECompositionMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_imeCompositionMode(IMECompositionMode value) { }

}

