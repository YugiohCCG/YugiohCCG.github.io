namespace UnityEngine.UIElements;

public class WheelEvent : MouseEventBase<WheelEvent>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MouseEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
		internal WheelEvent <.cctor>b__1_0() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Vector3 <delta>k__BackingField; //Field offset: 0xA0

	public private Vector3 delta
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 25
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GUIUtility), Member = "HasFocusableControls", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Event), Member = "set_displayIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUI), Member = "set_changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUI), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUI), Member = "set_backgroundColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUI), Member = "set_contentColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUI), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUI), Member = "set_matrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UIElementsUtility), Member = "EndContainerGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Rect)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUIUtility), Member = "SetKeyboardControlToLastControlId", ReturnType = typeof(void))]
		[Calls(Type = typeof(GUIUtility), Member = "SetKeyboardControlToFirstControlId", ReturnType = typeof(void))]
		[Calls(Type = typeof(GUIUtility), Member = "set_keyboardControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FocusController), Member = "FocusNextInDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection)}, ReturnType = typeof(Focusable))]
		[Calls(Type = typeof(FocusController), Member = "SyncIMGUIFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Focusable), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
		[Calls(Type = typeof(GUIUtility), Member = "CheckForTabEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(GUIUtility), Member = "get_keyboardControl", ReturnType = typeof(int))]
		[Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
		[Calls(Type = typeof(Event), Member = "get_current", ReturnType = typeof(Event))]
		[Calls(Type = "UnityEngine.GUIClip", Member = "Internal_Pop", ReturnType = typeof(void))]
		[Calls(Type = typeof(GUIUtility), Member = "set_pixelsPerPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.GUIClip", Member = "Internal_GetCount", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallsUnknownMethods(Count = 5)]
		[CompilerGenerated]
		[ContainsUnimplementedInstructions]
		private set { } //Length: 2494
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventBase`1), Member = "SetCreateFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private static WheelEvent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MouseEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	public WheelEvent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "DispatchToElementUnderPointerOrPanelRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(int), typeof(Vector2)}, ReturnType = typeof(void))]
	internal virtual void Dispatch(BaseVisualElementPanel panel) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public Vector3 get_delta() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MouseEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
	[Calls(Type = typeof(Event), Member = "get_delta", ReturnType = typeof(Vector2))]
	[CallsUnknownMethods(Count = 1)]
	public static WheelEvent GetPooled(Event systemEvent) { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor+<>c", Member = "<ProcessPointerEvent>b__9_4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(System.ValueTuple`2<UnityEngine.EventModifiers, UnityEngine.Vector2>)}, ReturnType = typeof(EventBase))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+<>c", Member = "<SendIMGUIEvents>b__26_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(System.ValueTuple`2<UnityEngine.EventModifiers, UnityEngine.Vector2>)}, ReturnType = typeof(EventBase))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EventBase`1), Member = "GetPooled", ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	internal static WheelEvent GetPooled(Vector3 delta, Vector3 mousePosition, EventModifiers modifiers = 0) { }

	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MouseEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	internal static WheelEvent GetPooled(Vector3 delta, IPointerEvent pointerEvent) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MouseEventBase`1), Member = "Init", ReturnType = typeof(void))]
	protected virtual void Init() { }

	[CallerCount(Count = 0)]
	private void LocalInit() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.GUIClip", Member = "Internal_GetCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(GUIUtility), Member = "set_pixelsPerPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.GUIClip", Member = "Internal_Pop", ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_current", ReturnType = typeof(Event))]
	[Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(GUIUtility), Member = "get_keyboardControl", ReturnType = typeof(int))]
	[Calls(Type = typeof(GUIUtility), Member = "CheckForTabEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
	[Calls(Type = typeof(FocusController), Member = "SyncIMGUIFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Focusable), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIUtility), Member = "set_keyboardControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FocusController), Member = "FocusNextInDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection)}, ReturnType = typeof(Focusable))]
	[Calls(Type = typeof(GUIUtility), Member = "SetKeyboardControlToLastControlId", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIElementsUtility), Member = "EndContainerGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUI), Member = "set_matrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUI), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUI), Member = "set_contentColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUI), Member = "set_backgroundColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUI), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUI), Member = "set_changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "set_displayIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIUtility), Member = "HasFocusableControls", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GUIUtility), Member = "SetKeyboardControlToFirstControlId", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 5)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	private void set_delta(Vector3 value) { }

}

