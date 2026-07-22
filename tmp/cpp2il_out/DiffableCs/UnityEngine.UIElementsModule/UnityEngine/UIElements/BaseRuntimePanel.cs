namespace UnityEngine.UIElements;

internal abstract class BaseRuntimePanel : Panel
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
		[DeduplicatedMethod]
		internal Vector2 <.cctor>b__52_0(Vector2 p) { }

	}

	private static int s_CurrentRuntimePanelCounter; //Field offset: 0x0
	internal static readonly Func<Vector2, Vector2> DefaultScreenToPanelSpace; //Field offset: 0x8
	private GameObject m_SelectableGameObject; //Field offset: 0x1B8
	internal readonly int m_RuntimePanelCreationIndex; //Field offset: 0x1C0
	private float m_SortingPriority; //Field offset: 0x1C4
	internal int resolvedSortingIndex; //Field offset: 0x1C8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action destroyed; //Field offset: 0x1D0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action drawsInCamerasChanged; //Field offset: 0x1D8
	private bool m_DrawsInCameras; //Field offset: 0x1E0
	private float m_PixelsPerUnit; //Field offset: 0x1E4
	internal RenderTexture targetTexture; //Field offset: 0x1E8
	internal int worldSpaceLayer; //Field offset: 0x1F0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <targetDisplay>k__BackingField; //Field offset: 0x1F4
	private Func<Vector2, Vector2> m_ScreenToPanelSpace; //Field offset: 0x1F8

	public event Action destroyed
	{
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "RegisterCallbacks", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelRaycaster", Member = "set_panel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelRaycaster", Member = "RegisterCallbacks", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelRaycaster", Member = "OnPanelDestroyed", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "CreateUIToolkitPanelGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 add { } //Length: 146
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "UnregisterCallbacks", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelRaycaster", Member = "set_panel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelRaycaster", Member = "UnregisterCallbacks", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelRaycaster", Member = "OnPanelDestroyed", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 remove { } //Length: 146
	}

	internal event Action drawsInCamerasChanged
	{
		[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "AttachToPanel", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		internal add { } //Length: 146
		[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "DetachFromPanel", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		internal remove { } //Length: 146
	}

	internal bool drawsInCameras
	{
		[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "RenderOffscreenPanels", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "RenderPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "RenderOverlaysBeforePriority", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderChain), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel), typeof(UIRenderDevice), typeof(AtlasBase), typeof(VectorImageManager)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		internal get { } //Length: 10
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal set { } //Length: 46
	}

	internal float pixelsPerUnit
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 11
		[CallerCount(Count = 0)]
		internal set { } //Length: 9
	}

	internal int screenRenderingHeight
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseRuntimePanel), Member = "getScreenRenderingHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		internal get { } //Length: 78
	}

	internal int screenRenderingWidth
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseRuntimePanel), Member = "getScreenRenderingWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		internal get { } //Length: 78
	}

	public Func<Vector2, Vector2> screenToPanelSpace
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 132
	}

	public override GameObject selectableGameObject
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "CreateUIToolkitPanelGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BaseRuntimePanel), Member = "AssignPanelToComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 160
	}

	public float sortingPriority
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
		[CalledBy(Type = "UnityEngine.UIElements.PanelSettings+RuntimePanelAccess", Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelSettings+RuntimePanelAccess", Member = "SetSortingPriority", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PanelSettings), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PanelSettings), Member = "ApplySortingOrder", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "SetPanelOrderingDirty", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 137
	}

	internal int targetDisplay
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 7
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal set { } //Length: 7
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Func`2<UnityEngine.Vector2, UnityEngine.Vector2>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static BaseRuntimePanel() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(ContextType), typeof(EventDispatcher)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	protected BaseRuntimePanel(ScriptableObject ownerObject, EventDispatcher dispatcher = null) { }

	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "RegisterCallbacks", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelRaycaster", Member = "set_panel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelRaycaster", Member = "RegisterCallbacks", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelRaycaster", Member = "OnPanelDestroyed", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "CreateUIToolkitPanelGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void add_destroyed(Action value) { }

	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "AttachToPanel", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal void add_drawsInCamerasChanged(Action value) { }

	[CalledBy(Type = typeof(BaseRuntimePanel), Member = "set_selectableGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "GetComponents", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PooledObject`1), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void AssignPanelToComponents(BaseRuntimePanel panel) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void Dispose(bool disposing) { }

	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "RenderOffscreenPanels", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "RenderPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "RenderOverlaysBeforePriority", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChain), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel), typeof(UIRenderDevice), typeof(AtlasBase), typeof(VectorImageManager)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	internal bool get_drawsInCameras() { }

	[CallerCount(Count = 0)]
	internal float get_pixelsPerUnit() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "getScreenRenderingHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	internal int get_screenRenderingHeight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "getScreenRenderingWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	internal int get_screenRenderingWidth() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Func<Vector2, Vector2> get_screenToPanelSpace() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override GameObject get_selectableGameObject() { }

	[CallerCount(Count = 0)]
	public float get_sortingPriority() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal int get_targetDisplay() { }

	[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelSettings), Member = "GetDisplayRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(BaseRuntimePanel), Member = "get_screenRenderingHeight", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(BaseRuntimePanel), Member = "Render", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Display), Member = "get_renderingHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	internal static int getScreenRenderingHeight(int display) { }

	[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelSettings), Member = "GetDisplayRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(BaseRuntimePanel), Member = "get_screenRenderingWidth", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(BaseRuntimePanel), Member = "Render", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Display), Member = "get_renderingWidth", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	internal static int getScreenRenderingWidth(int display) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void InvokeDrawsInCamerasChanged() { }

	[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendPositionBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(int), typeof(System.Nullable`1<System.Int32>), "System.Func`4<Vector3, Vector3, TArg, EventBase>", "TArg", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PointerDeviceState), Member = "SavePointerPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector2), typeof(IPanel), typeof(ContextType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void PointerEntersPanel(int pointerId, Vector2 position) { }

	[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendPositionBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(int), typeof(System.Nullable`1<System.Int32>), "System.Func`4<Vector3, Vector3, TArg, EventBase>", "TArg", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnPointerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ElementUnderPointer), Member = "SetTemporaryElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ElementUnderPointer), Member = "CommitElementUnderPointers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventDispatcher), typeof(ContextType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerDeviceState), Member = "SavePointerPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector2), typeof(IPanel), typeof(ContextType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal void PointerLeavesPanel(int pointerId, Vector2 position) { }

	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "UnregisterCallbacks", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelRaycaster", Member = "set_panel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelRaycaster", Member = "UnregisterCallbacks", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelRaycaster", Member = "OnPanelDestroyed", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void remove_destroyed(Action value) { }

	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "DetachFromPanel", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal void remove_drawsInCamerasChanged(Action value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "SetupCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GL), Member = "Viewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "getScreenRenderingWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "getScreenRenderingHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 3)]
	public virtual void Render() { }

	[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendPositionBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(int), typeof(System.Nullable`1<System.Int32>), "System.Func`4<Vector3, Vector3, TArg, EventBase>", "TArg", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal Vector2 ScreenToPanel(Vector2 screen) { }

	[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendPositionBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(int), typeof(System.Nullable`1<System.Int32>), "System.Func`4<Vector3, Vector3, TArg, EventBase>", "TArg", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "ReadPointerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PanelEventHandler+PointerEvent", "UnityEngine.EventSystems.PointerEventData", "UnityEngine.UIElements.PanelEventHandler+PointerEventType"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool ScreenToPanel(Vector2 screenPosition, Vector2 screenDelta, out Vector2 panelPosition, out Vector2 panelDelta, bool allowOutside = false) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void set_drawsInCameras(bool value) { }

	[CallerCount(Count = 0)]
	internal void set_pixelsPerUnit(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void set_screenToPanelSpace(Func<Vector2, Vector2> value) { }

	[CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "CreateUIToolkitPanelGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "AssignPanelToComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void set_selectableGameObject(GameObject value) { }

	[CalledBy(Type = "UnityEngine.UIElements.PanelSettings+RuntimePanelAccess", Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelSettings+RuntimePanelAccess", Member = "SetSortingPriority", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelSettings), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelSettings), Member = "ApplySortingOrder", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "SetPanelOrderingDirty", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void set_sortingPriority(float value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal void set_targetDisplay(int value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	internal override void Update() { }

}

