namespace UnityEngine;

[NativeHeader("Modules/IMGUI/GUIManager.h")]
[NativeHeader("Modules/IMGUI/GUIUtility.h")]
[NativeHeader("Runtime/Input/InputManager.h")]
[NativeHeader("Runtime/Camera/RenderLayers/GUITexture.h")]
[NativeHeader("Runtime/Utilities/CopyPaste.h")]
[NativeHeader("Runtime/Input/InputBindings.h")]
public class GUIUtility
{
	internal static int s_ControlCount; //Field offset: 0x0
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static int s_SkinMode; //Field offset: 0x4
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static int s_OriginalID; //Field offset: 0x8
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static Action takeCapture; //Field offset: 0x10
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static Action releaseCapture; //Field offset: 0x18
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static Func<Int32, IntPtr, Boolean> processEvent; //Field offset: 0x20
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static Action cleanupRoots; //Field offset: 0x28
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static Func<Exception, Boolean> endContainerGUIFromException; //Field offset: 0x30
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static Action guiChanged; //Field offset: 0x38
	internal static Action<EventType, KeyCode, EventModifiers> beforeEventProcessed; //Field offset: 0x40
	private static Event m_Event; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static bool <guiIsExiting>k__BackingField; //Field offset: 0x50
	internal static Func<Boolean> s_HasCurrentWindowKeyFocusFunc; //Field offset: 0x58

	[StaticAccessor("InputBindings", StaticAccessorType::DoubleColon (2))]
	internal static Vector2 compositionCursorPos
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal set { } //Length: 101
	}

	[StaticAccessor("InputBindings", StaticAccessorType::DoubleColon (2))]
	internal static string compositionString
	{
		[CalledBy(Type = typeof(TextEditingUtilities), Member = "UpdateImeState", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextEditingUtilities), Member = "GeneratePreviewString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(TextEditingUtilities), Member = "EnableCursorPreviewState", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = "UnityEngine.Bindings.OutStringMarshaller", Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bindings.ManagedSpanWrapper"}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 3)]
		internal get { } //Length: 222
	}

	[NativeProperty("GetGUIState().m_OnGUIDepth", True, TargetType::Field (1))]
	internal static int guiDepth
	{
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal get { } //Length: 42
	}

	internal static bool guiIsExiting
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal set { } //Length: 84
	}

	public static int hotControl
	{
		[CalledBy(Type = "UnityEngine.UIElements.PointerCaptureHelper", Member = "CapturePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IEventHandler", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PointerDispatchState", Member = "CapturePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IEventHandler", typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 91
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.PointerCaptureHelper", Member = "CapturePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IEventHandler", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PointerDispatchState", Member = "CapturePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IEventHandler", typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 98
	}

	[StaticAccessor("InputBindings", StaticAccessorType::DoubleColon (2))]
	internal static IMECompositionMode imeCompositionMode
	{
		[CalledBy(Type = "UnityEngine.UIElements.KeyboardTextEditorEventHandler", Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.KeyboardTextEditorEventHandler", Member = "OnFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.FocusEvent"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.KeyboardTextEditorEventHandler", Member = "OnBlur", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BlurEvent"}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal set { } //Length: 49
	}

	public static int keyboardControl
	{
		[CalledBy(Type = "UnityEngine.UIElements.WheelEvent", Member = "set_delta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 15)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 91
		[CalledBy(Type = "UnityEngine.UIElements.WheelEvent", Member = "set_delta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 98
	}

	[NativeProperty("GetGUIState().m_PixelsPerPoint", True, TargetType::Field (1))]
	internal static float pixelsPerPoint
	{
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "SaveGlobals", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "get_scaledPixelsPerPoint_noChecks", ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "Measure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", "UnityEngine.UIElements.Layout.LayoutNode&", typeof(float), "UnityEngine.UIElements.Layout.LayoutMeasureMode", typeof(float), "UnityEngine.UIElements.Layout.LayoutMeasureMode", "UnityEngine.UIElements.Layout.LayoutSize&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "AddStyleSheetPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "GetGraphicalLineStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "GetGraphicalLineEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[CallerCount(Count = 8)]
		[CallsUnknownMethods(Count = 2)]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal get { } //Length: 42
		[CalledBy(Type = "UnityEngine.UIElements.WheelEvent", Member = "set_delta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "RestoreGlobals", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal set { } //Length: 58
	}

	public static string systemCopyBuffer
	{
		[CalledBy(Type = "Manager.Helper", Member = "get_Clipboard", ReturnType = typeof(string))]
		[CalledBy(Type = "Manager.Hotkey+<PasteDeckFromClipboard>d__88", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "get_clipboard", ReturnType = typeof(string))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "TMPro.TMP_InputField+EditState")]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "get_clipboard", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextEditingUtilities), Member = "CanPaste", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextEditingUtilities), Member = "Paste", ReturnType = typeof(bool))]
		[CallerCount(Count = 8)]
		[Calls(Type = "UnityEngine.Bindings.OutStringMarshaller", Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bindings.ManagedSpanWrapper"}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 3)]
		[FreeFunction("GetCopyBuffer")]
		 get { } //Length: 222
		[CalledBy(Type = "Manager.Helper", Member = "set_Clipboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "set_clipboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "set_clipboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextSelectOp)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "Copy", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 3)]
		[FreeFunction("SetCopyBuffer")]
		 set { } //Length: 409
	}

	[StaticAccessor("GetInputManager()", StaticAccessorType::Dot (0))]
	internal static bool textFieldInput
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 42
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static GUIUtility() { }

	[CalledBy(Type = "UnityEngine.UIElements.Image", Member = "OnGenerateVisualContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Rect AlignRectToDevice(Rect rect) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static Rect AlignRectToDevice(Rect rect, out int widthInPixels, out int heightInPixels) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void AlignRectToDevice_Injected(in Rect rect, out int widthInPixels, out int heightInPixels, out Rect ret) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIElementsUtility", Member = "BeginContainerGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutCache), typeof(Event), "UnityEngine.UIElements.IMGUIContainer"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void BeginContainer(ObjectGUIState objectGUIState) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void BeginContainer_Injected(IntPtr objectGUIState) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIElementsUtility", Member = "BeginContainerGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutCache), typeof(Event), "UnityEngine.UIElements.IMGUIContainer"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void BeginContainerFromOwner(ScriptableObject owner) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void BeginContainerFromOwner_Injected(IntPtr owner) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIUtility), Member = "CheckOnGUI", ReturnType = typeof(void))]
	[Calls(Type = typeof(GUI), Member = "DoSetSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUISkin)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUILayoutUtility), Member = "Begin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[RequiredByNativeCode]
	internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout) { }

	[CalledBy(Type = "UnityEngine.UIElements.WheelEvent", Member = "set_delta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static int CheckForTabEvent(Event evt) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int CheckForTabEvent_Injected(IntPtr evt) { }

	[CalledBy(Type = typeof(GUI), Member = "set_skin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUISkin)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "get_skin", ReturnType = typeof(GUISkin))]
	[CalledBy(Type = typeof(GUI), Member = "Label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "Label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(GUIStyle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(GUIStyle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "CallWindowDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WindowFunction), typeof(int), typeof(int), typeof(GUISkin), typeof(int), typeof(float), typeof(float), typeof(GUIStyle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIUtility), Member = "BeginGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIUtility), Member = "ResetGlobalState", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	internal static void CheckOnGUI() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	internal static void DestroyGUI(int instanceID) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIElementsUtility", Member = "UnityEngine.UIElements.IUIElementsUtility.EndContainerGUIFromException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsUtility", Member = "EndContainerGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Rect)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void EndContainer() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	internal static bool EndContainerGUIFromException(Exception exception) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUILayoutUtility), Member = "LayoutFromEditorWindow", ReturnType = typeof(void))]
	[Calls(Type = typeof(GUILayoutUtility), Member = "Layout", ReturnType = typeof(void))]
	[Calls(Type = typeof(GUILayoutUtility), Member = "SelectIDList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(LayoutCache))]
	[CallsUnknownMethods(Count = 25)]
	[RequiredByNativeCode]
	internal static void EndGUI(int layoutType) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[RequiredByNativeCode]
	internal static bool EndGUIFromException(Exception exception) { }

	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExitGUIException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static void ExitGUI() { }

	[CalledBy(Type = typeof(TextEditingUtilities), Member = "UpdateImeState", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "GeneratePreviewString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "EnableCursorPreviewState", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = "UnityEngine.Bindings.OutStringMarshaller", Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bindings.ManagedSpanWrapper"}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	internal static string get_compositionString() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_compositionString_Injected(out ManagedSpanWrapper ret) { }

	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static int get_guiDepth() { }

	[CalledBy(Type = "UnityEngine.UIElements.PointerCaptureHelper", Member = "CapturePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IEventHandler", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PointerDispatchState", Member = "CapturePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IEventHandler", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static int get_hotControl() { }

	[CalledBy(Type = "UnityEngine.UIElements.WheelEvent", Member = "set_delta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[CallsUnknownMethods(Count = 2)]
	public static int get_keyboardControl() { }

	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "SaveGlobals", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "get_scaledPixelsPerPoint_noChecks", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "Measure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", "UnityEngine.UIElements.Layout.LayoutNode&", typeof(float), "UnityEngine.UIElements.Layout.LayoutMeasureMode", typeof(float), "UnityEngine.UIElements.Layout.LayoutMeasureMode", "UnityEngine.UIElements.Layout.LayoutSize&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "AddStyleSheetPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "GetGraphicalLineStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "GetGraphicalLineEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static float get_pixelsPerPoint() { }

	[CalledBy(Type = "Manager.Helper", Member = "get_Clipboard", ReturnType = typeof(string))]
	[CalledBy(Type = "Manager.Hotkey+<PasteDeckFromClipboard>d__88", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "get_clipboard", ReturnType = typeof(string))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "TMPro.TMP_InputField+EditState")]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "get_clipboard", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "CanPaste", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "Paste", ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = "UnityEngine.Bindings.OutStringMarshaller", Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bindings.ManagedSpanWrapper"}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("GetCopyBuffer")]
	public static string get_systemCopyBuffer() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_systemCopyBuffer_Injected(out ManagedSpanWrapper ret) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal static bool get_textFieldInput() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static int GetControlID(int hint, FocusType focus) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static int GetControlID(int hint, FocusType focusType, Rect rect) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal static GUISkin GetDefaultSkin() { }

	[CalledBy(Type = "UnityEngine.UIElements.WheelEvent", Member = "set_delta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static bool HasFocusableControls() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	internal static bool HasKeyFocus(int controlID) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal static bool HitTest(Rect rect, Vector2 point, int offset) { }

	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "IsEventInsideLocalWindow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static bool HitTest(Rect rect, Vector2 point, bool isDirectManipulationDevice) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod("EndContainer")]
	internal static void Internal_EndContainer() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_ExitGUI() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("GetGUIState().GetControlID")]
	private static int Internal_GetControlID(int hint, FocusType focusType, Rect rect) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int Internal_GetControlID_Injected(int hint, FocusType focusType, in Rect rect) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static object Internal_GetDefaultSkin(int skinMode) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int Internal_GetHotControl() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int Internal_GetKeyboardControl() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_SetHotControl(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_SetKeyboardControl(int value) { }

	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChain", Member = "Render", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static bool IsExitGUIException(Exception exception) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	private static void MarkGUIChanged() { }

	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static bool OwnsId(int id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_keyCode", ReturnType = typeof(KeyCode))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	[RequiredByNativeCode]
	internal static void ProcessEvent(int instanceID, IntPtr nativeEventPtr, out bool result) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	internal static void RemoveCapture() { }

	[CalledBy(Type = "UnityEngine.UIElements.UIElementsUtility", Member = "BeginContainerGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutCache), typeof(Event), "UnityEngine.UIElements.IMGUIContainer"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GUIUtility), Member = "CheckOnGUI", ReturnType = typeof(void))]
	[Calls(Type = typeof(GUI), Member = "DoSetSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUISkin)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void ResetGlobalState() { }

	[CalledBy(Type = "UnityEngine.UIElements.ScrollView", Member = "UpdateContentViewTransform", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static float RoundToPixelGrid(float v) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal static void set_compositionCursorPos(Vector2 value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_compositionCursorPos_Injected(in Vector2 value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal static void set_guiIsExiting(bool value) { }

	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.PointerCaptureHelper", Member = "CapturePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IEventHandler", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PointerDispatchState", Member = "CapturePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IEventHandler", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_hotControl(int value) { }

	[CalledBy(Type = "UnityEngine.UIElements.KeyboardTextEditorEventHandler", Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.KeyboardTextEditorEventHandler", Member = "OnFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.FocusEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.KeyboardTextEditorEventHandler", Member = "OnBlur", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BlurEvent"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void set_imeCompositionMode(IMECompositionMode value) { }

	[CalledBy(Type = "UnityEngine.UIElements.WheelEvent", Member = "set_delta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_keyboardControl(int value) { }

	[CalledBy(Type = "UnityEngine.UIElements.WheelEvent", Member = "set_delta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "RestoreGlobals", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void set_pixelsPerPoint(float value) { }

	[CalledBy(Type = "Manager.Helper", Member = "set_Clipboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "set_clipboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "set_clipboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextSelectOp)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "Copy", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("SetCopyBuffer")]
	public static void set_systemCopyBuffer(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_systemCopyBuffer_Injected(ref ManagedSpanWrapper value) { }

	[CalledBy(Type = "UnityEngine.UIElements.WheelEvent", Member = "set_delta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void SetKeyboardControlToFirstControlId() { }

	[CalledBy(Type = "UnityEngine.UIElements.WheelEvent", Member = "set_delta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void SetKeyboardControlToLastControlId() { }

	[CalledBy(Type = "UnityEngine.UIElements.UIEventRegistration", Member = "EndContainerGUIFromException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static bool ShouldRethrowException(Exception exception) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	internal static void TakeCapture() { }

}

