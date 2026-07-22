namespace UnityEngine.UIElements;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal abstract class BaseVisualElementPanel : IPanel, IDisposable, IGroupBox
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<BaseVisualElementPanel> panelDisposed; //Field offset: 0x10
	private UIElementsBridge m_UIElementsBridge; //Field offset: 0x18
	private float m_Scale; //Field offset: 0x20
	internal LayoutConfig layoutConfig; //Field offset: 0x28
	private float m_PixelsPerPoint; //Field offset: 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private float <referenceSpritePixelsPerUnit>k__BackingField; //Field offset: 0x5C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private PanelClearSettings <clearSettings>k__BackingField; //Field offset: 0x60
	internal IPanelRenderer panelRenderer; //Field offset: 0x78
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <duringLayoutPhase>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private RepaintData <repaintData>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ICursorManager <cursorManager>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ContextualMenuManager <contextualMenuManager>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private DataBindingManager <dataBindingManager>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposed>k__BackingField; //Field offset: 0xA8
	internal ElementUnderPointer m_TopElementUnderPointers; //Field offset: 0xB0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action isFlatChanged; //Field offset: 0xB8
	private bool m_IsFlat; //Field offset: 0xC0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action atlasChanged; //Field offset: 0xC8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private HierarchyEvent hierarchyChanged; //Field offset: 0xD0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<IPanel> beforeUpdate; //Field offset: 0xD8

	internal event Action atlasChanged
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

	internal event HierarchyEvent hierarchyChanged
	{
		[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "OnPanelChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "AttachToPanel", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		internal add { } //Length: 146
		[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "OnPanelChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "DetachFromPanel", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		internal remove { } //Length: 146
	}

	internal event Action isFlatChanged
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

	internal event Action<BaseVisualElementPanel> panelDisposed
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		internal add { } //Length: 160
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		internal remove { } //Length: 160
	}

	public abstract AtlasBase atlas
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	internal PanelClearSettings clearSettings
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 17
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal set { } //Length: 14
	}

	public abstract ContextType contextType
	{
		 get { } //Length: 0
	}

	public internal override ContextualMenuManager contextualMenuManager
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	internal override ICursorManager cursorManager
	{
		[CallerCount(Count = 57)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	internal override DataBindingManager dataBindingManager
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	public abstract EventDispatcher dispatcher
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	internal bool disposed
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 7
	}

	internal bool duringLayoutPhase
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	public abstract FocusController focusController
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public abstract GetViewDataDictionary getViewDataDictionary
	{
		 get { } //Length: 0
	}

	internal abstract uint hierarchyVersion
	{
		internal get { } //Length: 0
	}

	public abstract int IMGUIContainersCount
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public abstract EventInterests IMGUIEventInterests
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool isFlat
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseVisualElementPanel), Member = "SetSpecializedHierarchyFlagsUpdater", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 65
	}

	public abstract ScriptableObject ownerObject
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float referenceSpritePixelsPerUnit
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	internal override RepaintData repaintData
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	public abstract IMGUIContainer rootIMGUIContainer
	{
		 get { } //Length: 0
	}

	public abstract SavePersistentViewData saveViewData
	{
		 get { } //Length: 0
	}

	internal float scale
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LayoutConfig), Member = "get_PointScaleFactor", ReturnType = typeof(Single&))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		internal set { } //Length: 160
	}

	public override float scaledPixelsPerPoint
	{
		[CalledBy(Type = typeof(VisualElement), Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(VisualElement), Member = "get_scaledPixelsPerPoint_noChecks", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(VisualElement), Member = "Measure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(LayoutNode&), typeof(float), typeof(LayoutMeasureMode), typeof(float), typeof(LayoutMeasureMode), typeof(LayoutSize&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "AddStyleSheetPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualTreeStyleUpdater), Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualTreeStyleUpdater), Member = "ApplyStyles", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderChain), Member = "SerializeCommandsForCameras", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderChain), Member = "Render", ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		 get { } //Length: 13
	}

	internal abstract IScheduler scheduler
	{
		internal get { } //Length: 0
	}

	internal abstract IStylePropertyAnimationSystem styleAnimationSystem
	{
		internal get { } //Length: 0
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal set { } //Length: 0
	}

	internal UIElementsBridge uiElementsBridge
	{
		[CalledBy(Type = typeof(FieldMouseDragger`1), Member = "ProcessDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FieldMouseDragger`1), Member = "ProcessUpEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FieldMouseDragger`1), Member = "UpdateValueOnKeyDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyDownEvent)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		internal get { } //Length: 102
	}

	internal abstract uint version
	{
		internal get { } //Length: 0
	}

	public abstract VisualElement visualTree
	{
		 get { } //Length: 0
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ElementUnderPointer), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutManager), Member = "CreateConfig", ReturnType = typeof(LayoutConfig))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	protected BaseVisualElementPanel() { }

	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "AttachToPanel", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal void add_atlasChanged(Action value) { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "OnPanelChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "AttachToPanel", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal void add_hierarchyChanged(HierarchyEvent value) { }

	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "AttachToPanel", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal void add_isFlatChanged(Action value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	internal void add_panelDisposed(Action<BaseVisualElementPanel> value) { }

	public abstract void ApplyStyles() { }

	[CalledBy(Type = typeof(MouseLeaveWindowEvent), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ElementUnderPointer), Member = "SetTemporaryElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(EventBase)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void ClearCachedElementUnderPointer(int pointerId, EventBase triggerEvent) { }

	[CalledBy(Type = typeof(MouseEnterWindowEvent), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MouseLeaveWindowEvent), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerEventBase`1), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ElementUnderPointer), Member = "CommitElementUnderPointers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventDispatcher), typeof(ContextType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal void CommitElementUnderPointers() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GenericDropdownMenu), Member = ".ctor", ReturnType = typeof(void))]
	internal override IGenericMenu CreateMenu() { }

	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "DisposeRuntimePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(UIElementsUtility), Member = "RemoveCachedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerDeviceState), Member = "RemovePanelData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutManager), Member = "DestroyConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutConfig&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	protected override void Dispose(bool disposing) { }

	public abstract AtlasBase get_atlas() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal PanelClearSettings get_clearSettings() { }

	public abstract ContextType get_contextType() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override ContextualMenuManager get_contextualMenuManager() { }

	[CallerCount(Count = 57)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal override ICursorManager get_cursorManager() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal override DataBindingManager get_dataBindingManager() { }

	public abstract EventDispatcher get_dispatcher() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal bool get_disposed() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal bool get_duringLayoutPhase() { }

	public abstract FocusController get_focusController() { }

	public abstract GetViewDataDictionary get_getViewDataDictionary() { }

	internal abstract uint get_hierarchyVersion() { }

	public abstract int get_IMGUIContainersCount() { }

	public abstract EventInterests get_IMGUIEventInterests() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_isFlat() { }

	public abstract ScriptableObject get_ownerObject() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public float get_referenceSpritePixelsPerUnit() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal override RepaintData get_repaintData() { }

	public abstract IMGUIContainer get_rootIMGUIContainer() { }

	public abstract SavePersistentViewData get_saveViewData() { }

	[CallerCount(Count = 0)]
	internal float get_scale() { }

	[CalledBy(Type = typeof(VisualElement), Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_scaledPixelsPerPoint_noChecks", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(VisualElement), Member = "Measure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(LayoutNode&), typeof(float), typeof(LayoutMeasureMode), typeof(float), typeof(LayoutMeasureMode), typeof(LayoutSize&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "AddStyleSheetPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeStyleUpdater), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeStyleUpdater), Member = "ApplyStyles", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChain), Member = "SerializeCommandsForCameras", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChain), Member = "Render", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	public override float get_scaledPixelsPerPoint() { }

	internal abstract IScheduler get_scheduler() { }

	internal abstract IStylePropertyAnimationSystem get_styleAnimationSystem() { }

	[CalledBy(Type = typeof(FieldMouseDragger`1), Member = "ProcessDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldMouseDragger`1), Member = "ProcessUpEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldMouseDragger`1), Member = "UpdateValueOnKeyDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyDownEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal UIElementsBridge get_uiElementsBridge() { }

	internal abstract uint get_version() { }

	public abstract VisualElement get_visualTree() { }

	[CalledBy(Type = typeof(Clickable), Member = "ContainsPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClickDetector), Member = "ContainsPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IPointerEvent)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BasePopupField`2), Member = "OnPointerUpEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BasePopupField`2), Member = "ContainsPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EnumField), Member = "ContainsPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "DispatchToCachedElementUnderPointerOrPanelRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(int), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MouseLeaveWindowEvent), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleCursor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateHoverPseudoStateAfterCaptureChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "SetComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateCursorStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal VisualElement GetTopElementUnderPointer(int pointerId) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal abstract IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void InvokeAtlasChanged() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void InvokeBeforeUpdate() { }

	[CalledBy(Type = typeof(VisualElement), Member = "SetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "InvokeHierarchyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyChangeType), typeof(System.Collections.Generic.IReadOnlyList`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void InvokeHierarchyChanged(VisualElement ve, HierarchyChangeType changeType, IReadOnlyList<VisualElement> additionalContext = null) { }

	internal abstract void OnVersionChanged(VisualElement ele, VersionChangeType changeTypeFlag) { }

	public abstract VisualElement Pick(Vector2 point) { }

	public abstract VisualElement PickAll(Vector2 point, List<VisualElement> picked) { }

	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "DispatchToElementUnderPointerOrPanelRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(int), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "DispatchToCapturingElementOrElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(int), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PointerDeviceState), Member = "GetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ContextType)}, ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(PointerDeviceState), Member = "HasLocationFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ContextType), typeof(LocationFlag)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ElementUnderPointer), Member = "SetElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(EventBase)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	internal VisualElement RecomputeTopElementUnderPointer(int pointerId, Vector2 pointerPos, EventBase triggerEvent) { }

	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "DetachFromPanel", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal void remove_atlasChanged(Action value) { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "OnPanelChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "DetachFromPanel", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal void remove_hierarchyChanged(HierarchyEvent value) { }

	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "DetachFromPanel", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal void remove_isFlatChanged(Action value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	internal void remove_panelDisposed(Action<BaseVisualElementPanel> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override void Render() { }

	public abstract void Repaint(Event e) { }

	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.AxisEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "SendKeyDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Focusable)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "SendKeyUpEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Focusable)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "SendTabEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Direction), typeof(Focusable)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(Event)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnSubmit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnCancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIElementsUtility), Member = "DoDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualElement), Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnPointerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(EventDispatcher), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal void SendEvent(EventBase e, DispatchMode dispatchMode = 1) { }

	public abstract void set_atlas(AtlasBase value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal void set_clearSettings(PanelClearSettings value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_contextualMenuManager(ContextualMenuManager value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal override void set_cursorManager(ICursorManager value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal override void set_dataBindingManager(DataBindingManager value) { }

	public abstract void set_dispatcher(EventDispatcher value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_disposed(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_duringLayoutPhase(bool value) { }

	public abstract void set_focusController(FocusController value) { }

	public abstract void set_IMGUIContainersCount(int value) { }

	public abstract void set_IMGUIEventInterests(EventInterests value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "SetSpecializedHierarchyFlagsUpdater", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_isFlat(bool value) { }

	protected abstract void set_ownerObject(ScriptableObject value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_referenceSpritePixelsPerUnit(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal override void set_repaintData(RepaintData value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutConfig), Member = "get_PointScaleFactor", ReturnType = typeof(Single&))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal void set_scale(float value) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal abstract void set_styleAnimationSystem(IStylePropertyAnimationSystem value) { }

	[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVisualElementPanel), Member = "set_isFlat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(ContextType), typeof(EventDispatcher)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VisualTreeWorldSpaceHierarchyFlagsUpdater), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeHierarchyFlagsUpdater), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	internal void SetSpecializedHierarchyFlagsUpdater() { }

	internal abstract void SetUpdater(IVisualTreeUpdater updater, VisualTreeUpdatePhase phase) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private override void UnityEngine.UIElements.IGroupBox.OnOptionAdded(IGroupBoxOption option) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private override void UnityEngine.UIElements.IGroupBox.OnOptionRemoved(IGroupBoxOption option) { }

	public abstract void UpdateAnimations() { }

	public abstract void UpdateBindings() { }

	[CalledBy(Type = typeof(VisualTreeHierarchyFlagsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PointerDeviceState), Member = "GetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ContextType)}, ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(PointerDeviceState), Member = "HasLocationFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ContextType), typeof(LocationFlag)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerDeviceState), Member = "GetPointerPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ContextType)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(ElementUnderPointer), Member = "SetElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ElementUnderPointer), Member = "CommitElementUnderPointers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventDispatcher), typeof(ContextType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	internal void UpdateElementUnderPointers() { }

	public abstract void ValidateFocus() { }

	public abstract void ValidateLayout() { }

}

