namespace UnityEngine.UIElements;

internal static class UIElementsRuntimeUtility
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<Panel> <>9__43_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "RenderOverlaysBeforePriority", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
		internal void <.cctor>b__3_0(int displayIndex, int sortOrder) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		internal int <SortPanels>b__43_0(Panel a, Panel b) { }

	}

	internal sealed class CreateRuntimePanelDelegate : MulticastDelegate
	{

		[CallerCount(Count = 39)]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		public CreateRuntimePanelDelegate(object object, IntPtr method) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override BaseRuntimePanel Invoke(ScriptableObject ownerObject) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<BaseRuntimePanel> onCreatePanel; //Field offset: 0x0
	private static bool s_RegisteredPlayerloopCallback; //Field offset: 0x8
	private static List<Panel> s_SortedRuntimePanels; //Field offset: 0x10
	private static bool s_PanelOrderingDirty; //Field offset: 0x18
	internal static int s_ResolvedSortingIndexMax; //Field offset: 0x1C
	internal static readonly string s_RepaintProfilerMarkerName; //Field offset: 0x20
	private static readonly ProfilerMarker s_RepaintProfilerMarker; //Field offset: 0x28
	private static int currentOverlayIndex; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static object <activeEventSystem>k__BackingField; //Field offset: 0x38
	private static DefaultEventSystem s_DefaultEventSystem; //Field offset: 0x40
	private static List<PanelSettings> s_PotentiallyEmptyPanelSettings; //Field offset: 0x48

	public static event Action<BaseRuntimePanel> onCreatePanel
	{
		[CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "StartTrackingUIToolkitPanels", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 add { } //Length: 259
		[CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "StopTrackingUIToolkitPanels", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "OnDisable", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 remove { } //Length: 259
	}

	internal static object activeEventSystem
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 79
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 110
	}

	internal static DefaultEventSystem defaultEventSystem
	{
		[CalledBy(Type = "UnityEngine.UIElements.RuntimePanel+<>c", Member = "<.ctor>b__5_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FocusEvent), typeof(RuntimePanel)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RuntimePanel), Member = "OnElementFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FocusEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "UpdatePanels", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(DefaultEventSystem), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 199
	}

	internal static bool useDefaultEventSystem
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		internal get { } //Length: 173
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private static UIElementsRuntimeUtility() { }

	[CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "StartTrackingUIToolkitPanels", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public static void add_onCreatePanel(Action<BaseRuntimePanel> value) { }

	[CallerCount(Count = 0)]
	internal static void BeginRenderOverlays(int displayIndex) { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+<>c", Member = "<SendIMGUIEvents>b__26_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EventBase))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+<>c", Member = "<SendIMGUIEvents>b__26_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Event)}, ReturnType = typeof(EventBase))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "SendKeyUpEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Focusable)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "SendKeyDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Focusable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Event), Member = "get_rawType", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(UIElementsUtility), Member = "CreateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(EventType)}, ReturnType = typeof(EventBase))]
	[CallsUnknownMethods(Count = 1)]
	public static EventBase CreateEvent(Event systemEvent) { }

	[CalledBy(Type = "UnityEngine.UIElements.PanelSettings+RuntimePanelAccess", Member = "DisposePanel", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelSettings+RuntimePanelAccess", Member = "DisposeRelatedPanel", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "RemoveCachedPanelInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void DisposeRuntimePanel(ScriptableObject ownerObject) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "RenderOverlaysBeforePriority", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	internal static void EndRenderOverlays(int displayIndex) { }

	[CalledBy(Type = "UnityEngine.UIElements.PanelSettings+RuntimePanelAccess", Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelSettings+RuntimePanelAccess", Member = "CreateRelatedRuntimePanel", ReturnType = typeof(BaseRuntimePanel))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "RemoveCachedPanelInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "RegisterCachedPanelInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IPanel)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static BaseRuntimePanel FindOrCreateRuntimePanel(ScriptableObject ownerObject, CreateRuntimePanelDelegate createDelegate) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static Vector2 FlipDeltaY(Vector2 delta) { }

	[CallerCount(Count = 0)]
	internal static Vector2 FlipY(Vector2 p, float displayHeight) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal static object get_activeEventSystem() { }

	[CalledBy(Type = "UnityEngine.UIElements.RuntimePanel+<>c", Member = "<.ctor>b__5_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FocusEvent), typeof(RuntimePanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimePanel), Member = "OnElementFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FocusEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "UpdatePanels", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DefaultEventSystem), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal static DefaultEventSystem get_defaultEventSystem() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	internal static bool get_useDefaultEventSystem() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Display), Member = "get_systemHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	private static float GetRuntimeDisplayHeight(int targetDisplay) { }

	[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendFocusBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TArg, EventBase>", "TArg"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendPositionBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(int), typeof(System.Nullable`1<System.Int32>), "System.Func`4<Vector3, Vector3, TArg, EventBase>", "TArg", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "RenderOffscreenPanels", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "RenderOverlaysBeforePriority", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "RepaintPanels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "UpdatePanels", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "StartTrackingUIToolkitPanels", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "SortPanels", ReturnType = typeof(void))]
	internal static List<Panel> GetSortedPlayerPanels() { }

	[CalledBy(Type = "UnityEngine.UIElements.PanelSettings+RuntimePanelAccess", Member = "MarkPotentiallyEmpty", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelSettings), Member = "DetachUIDocument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal static void MarkPotentiallyEmpty(PanelSettings settings) { }

	[CalledBy(Type = typeof(LegacyInputProcessor), Member = "SendIMGUIEvents", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ProcessMouseEvents", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Display), Member = "RelativeMouseAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Display), Member = "get_systemHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static Vector2 MultiDisplayBottomLeftToPanelPosition(Vector2 position, out Nullable<Int32>& targetDisplay) { }

	[CalledBy(Type = typeof(LegacyInputProcessor), Member = "SendIMGUIEvents", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Display), Member = "RelativeMouseAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static Vector2 MultiDisplayToLocalScreenPosition(Vector2 position, out Nullable<Int32>& targetDisplay) { }

	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "FindOrCreateRuntimePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(CreateRuntimePanelDelegate)}, ReturnType = typeof(BaseRuntimePanel))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIElementsRuntimeUtilityNative), Member = "RegisterPlayerloopCallback", ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "SetExternalCanvasEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private static void RegisterCachedPanelInternal(int instanceID, IPanel panel) { }

	[CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "SetUITookitEventSystemOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.EventSystem", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void RegisterEventSystem(object eventSystem) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIElementsRuntimeUtilityNative), Member = "RegisterPlayerloopCallback", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public static void RegisterPlayerloopCallback() { }

	[CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "StopTrackingUIToolkitPanels", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public static void remove_onCreatePanel(Action<BaseRuntimePanel> value) { }

	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "FindOrCreateRuntimePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(CreateRuntimePanelDelegate)}, ReturnType = typeof(BaseRuntimePanel))]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "DisposeRuntimePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIElementsUtility), Member = "GetAllPanels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Panel>), typeof(ContextType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIElementsRuntimeUtilityNative), Member = "UnregisterPlayerloopCallback", ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultEventSystem), Member = "set_isInputReady", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "SetExternalCanvasEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static void RemoveCachedPanelInternal(int instanceID) { }

	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "UpdatePanels", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	internal static void RemoveUnusedPanels() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "GetSortedPlayerPanels", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Panel>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "get_drawsInCameras", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "RenderPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "SetupCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	public static void RenderOffscreenPanels() { }

	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__3_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "EndRenderOverlays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "GetSortedPlayerPanels", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Panel>))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "get_drawsInCameras", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "RenderPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static void RenderOverlaysBeforePriority(int displayIndex, float maxPriority) { }

	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "RenderOffscreenPanels", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "RenderOverlaysBeforePriority", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "get_drawsInCameras", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "SetupCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public static void RenderPanel(BaseRuntimePanel panel, bool restoreState = true) { }

	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "RepaintPanels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_current", ReturnType = typeof(Event))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "SetupCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public static void RepaintPanel(BaseRuntimePanel panel) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "GetSortedPlayerPanels", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Panel>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "RepaintPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static void RepaintPanels(bool onlyOffscreen) { }

	[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	internal static Vector2 ScreenBottomLeftToPanelDelta(Vector2 delta) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Display), Member = "get_systemHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	internal static Vector2 ScreenBottomLeftToPanelPosition(Vector2 position, int targetDisplay) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private static void set_activeEventSystem(object value) { }

	[CalledBy(Type = typeof(BaseRuntimePanel), Member = "set_sortingPriority", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	internal static void SetPanelOrderingDirty() { }

	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "GetSortedPlayerPanels", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Panel>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIElementsUtility), Member = "GetAllPanels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Panel>), typeof(ContextType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static void SortPanels() { }

	[CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "SetUITookitEventSystemOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.EventSystem", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static void UnregisterEventSystem(object eventSystem) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIElementsRuntimeUtilityNative), Member = "UnregisterPlayerloopCallback", ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultEventSystem), Member = "set_isInputReady", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static void UnregisterPlayerloopCallback() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "RemoveUnusedPanels", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "ProcessDeviceFreeQueue", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "GetSortedPlayerPanels", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Panel>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DefaultEventSystem), Member = "set_isInputReady", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "get_defaultEventSystem", ReturnType = typeof(DefaultEventSystem))]
	[Calls(Type = typeof(DefaultEventSystem), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateMode)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public static void UpdatePanels() { }

}

