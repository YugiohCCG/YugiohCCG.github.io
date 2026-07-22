namespace UnityEngine;

[NativeHeader("Modules/IMGUI/GUISkin.bindings.h")]
[NativeHeader("Modules/IMGUI/GUI.bindings.h")]
public class GUI
{
	internal sealed class WindowFunction : MulticastDelegate
	{

		[CallerCount(Count = 79)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public WindowFunction(object object, IntPtr method) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(int id) { }

	}

	private static int s_HotTextField; //Field offset: 0x0
	private static readonly int s_BoxHash; //Field offset: 0x4
	private static readonly int s_ButonHash; //Field offset: 0x8
	private static readonly int s_RepeatButtonHash; //Field offset: 0xC
	private static readonly int s_ToggleHash; //Field offset: 0x10
	private static readonly int s_ButtonGridHash; //Field offset: 0x14
	private static readonly int s_SliderHash; //Field offset: 0x18
	private static readonly int s_BeginGroupHash; //Field offset: 0x1C
	private static readonly int s_ScrollviewHash; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static DateTime <nextScrollStepTime>k__BackingField; //Field offset: 0x28
	private static GUISkin s_Skin; //Field offset: 0x30
	internal static Rect s_ToolTipRect; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static GenericStack <scrollViewStates>k__BackingField; //Field offset: 0x48

	public static Color backgroundColor
	{
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "SaveGlobals", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 109
		[CalledBy(Type = "UnityEngine.UIElements.WheelEvent", Member = "set_delta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "RestoreGlobals", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 100
	}

	public static bool changed
	{
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "SaveGlobals", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
		[CalledBy(Type = "UnityEngine.UIElements.WheelEvent", Member = "set_delta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "RestoreGlobals", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 51
	}

	public static Color color
	{
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "SaveGlobals", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 109
		[CalledBy(Type = "UnityEngine.UIElements.WheelEvent", Member = "set_delta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "RestoreGlobals", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 100
	}

	public static Color contentColor
	{
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "SaveGlobals", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 109
		[CalledBy(Type = "UnityEngine.UIElements.WheelEvent", Member = "set_delta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "RestoreGlobals", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 100
	}

	public static bool enabled
	{
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "SaveGlobals", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
		[CalledBy(Type = "UnityEngine.UIElements.WheelEvent", Member = "set_delta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "RestoreGlobals", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIElementsUtility", Member = "BeginContainerGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutCache), typeof(Event), "UnityEngine.UIElements.IMGUIContainer"}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 51
	}

	public static Matrix4x4 matrix
	{
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "SaveGlobals", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 129
		[CalledBy(Type = "UnityEngine.UIElements.WheelEvent", Member = "set_delta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "RestoreGlobals", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 82
	}

	internal static DateTime nextScrollStepTime
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal set { } //Length: 85
	}

	internal static GenericStack scrollViewStates
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 79
	}

	public static GUISkin skin
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GUIUtility), Member = "CheckOnGUI", ReturnType = typeof(void))]
		 get { } //Length: 119
		[CalledBy(Type = typeof(GUI), Member = "CallWindowDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WindowFunction), typeof(int), typeof(int), typeof(GUISkin), typeof(int), typeof(float), typeof(float), typeof(GUIStyle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(GUIUtility), Member = "CheckOnGUI", ReturnType = typeof(void))]
		[Calls(Type = typeof(GUI), Member = "DoSetSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUISkin)}, ReturnType = typeof(void))]
		 set { } //Length: 113
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GenericStack), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	private static GUI() { }

	[CalledBy(Type = typeof(GUI), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GUIUtility), Member = "CheckOnGUI", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIStyle), Member = "Draw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	public static void Box(Rect position, GUIContent content, GUIStyle style) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChain", Member = "DrawStats", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GUIContent), Member = "Temp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(GUIContent))]
	[Calls(Type = typeof(GUI), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(GUIStyle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void Box(Rect position, string text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUILayoutUtility), Member = "SelectIDList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(LayoutCache))]
	[Calls(Type = typeof(GUIUtility), Member = "CheckOnGUI", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIStyle), Member = "get_none", ReturnType = typeof(GUIStyle))]
	[Calls(Type = typeof(GUILayoutUtility), Member = "BeginWindow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUI), Member = "set_skin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUISkin)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUILayoutUtility), Member = "Layout", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	[RequiredByNativeCode]
	internal static void CallWindowDelegate(WindowFunction func, int id, int instanceID, GUISkin _skin, int forceRect, float width, float height, GUIStyle style) { }

	[CalledBy(Type = typeof(GUI), Member = "Label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "Label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(GUIStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GUIStyle), Member = "IsTooltipActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GUIStyle), Member = "SetMouseTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	private static void DoLabel(Rect position, GUIContent content, GUIStyle style) { }

	[CalledBy(Type = typeof(GUI), Member = "set_skin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUISkin)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIUtility), Member = "BeginGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIUtility), Member = "ResetGlobalState", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	internal static void DoSetSkin(GUISkin newSkin) { }

	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "SaveGlobals", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static Color get_backgroundColor() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_backgroundColor_Injected(out Color ret) { }

	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "SaveGlobals", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static bool get_changed() { }

	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "SaveGlobals", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static Color get_color() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_color_Injected(out Color ret) { }

	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "SaveGlobals", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static Color get_contentColor() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_contentColor_Injected(out Color ret) { }

	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "SaveGlobals", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static bool get_enabled() { }

	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "SaveGlobals", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static Matrix4x4 get_matrix() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal static GenericStack get_scrollViewStates() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIUtility), Member = "CheckOnGUI", ReturnType = typeof(void))]
	public static GUISkin get_skin() { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChain", Member = "DrawStats", ReturnType = typeof(void))]
	[CallerCount(Count = 31)]
	[Calls(Type = typeof(GUIContent), Member = "Temp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(GUIContent))]
	[Calls(Type = typeof(GUIUtility), Member = "CheckOnGUI", ReturnType = typeof(void))]
	[Calls(Type = typeof(GUI), Member = "DoLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(GUIStyle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void Label(Rect position, string text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIUtility), Member = "CheckOnGUI", ReturnType = typeof(void))]
	[Calls(Type = typeof(GUI), Member = "DoLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(GUIStyle)}, ReturnType = typeof(void))]
	public static void Label(Rect position, GUIContent content, GUIStyle style) { }

	[CalledBy(Type = "UnityEngine.UIElements.WheelEvent", Member = "set_delta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "RestoreGlobals", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_backgroundColor(Color value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_backgroundColor_Injected(in Color value) { }

	[CalledBy(Type = "UnityEngine.UIElements.WheelEvent", Member = "set_delta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "RestoreGlobals", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_changed(bool value) { }

	[CalledBy(Type = "UnityEngine.UIElements.WheelEvent", Member = "set_delta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "RestoreGlobals", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_color(Color value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_color_Injected(in Color value) { }

	[CalledBy(Type = "UnityEngine.UIElements.WheelEvent", Member = "set_delta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "RestoreGlobals", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_contentColor(Color value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_contentColor_Injected(in Color value) { }

	[CalledBy(Type = "UnityEngine.UIElements.WheelEvent", Member = "set_delta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "RestoreGlobals", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsUtility", Member = "BeginContainerGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutCache), typeof(Event), "UnityEngine.UIElements.IMGUIContainer"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_enabled(bool value) { }

	[CalledBy(Type = "UnityEngine.UIElements.WheelEvent", Member = "set_delta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "RestoreGlobals", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_matrix(Matrix4x4 value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal static void set_nextScrollStepTime(DateTime value) { }

	[CalledBy(Type = typeof(GUI), Member = "CallWindowDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WindowFunction), typeof(int), typeof(int), typeof(GUISkin), typeof(int), typeof(float), typeof(float), typeof(GUIStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GUIUtility), Member = "CheckOnGUI", ReturnType = typeof(void))]
	[Calls(Type = typeof(GUI), Member = "DoSetSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUISkin)}, ReturnType = typeof(void))]
	public static void set_skin(GUISkin value) { }

}

