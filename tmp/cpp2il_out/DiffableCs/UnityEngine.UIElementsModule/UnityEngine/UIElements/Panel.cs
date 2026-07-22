namespace UnityEngine.UIElements;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class Panel : BaseVisualElementPanel
{
	internal const int k_DefaultPixelsPerUnit = 100; //Field offset: 0x0
	private static ProfilerMarker s_MarkerPickAll; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static LoadResourceFunction <loadResourceFunc>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static TimeMsFunction <TimeSinceStartup>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Panel> beforeAnyRepaint; //Field offset: 0x18
	private VisualElement m_RootContainer; //Field offset: 0xE0
	private VisualTreeUpdater m_VisualTreeUpdater; //Field offset: 0xE8
	private IStylePropertyAnimationSystem m_StylePropertyAnimationSystem; //Field offset: 0xF0
	private string m_PanelName; //Field offset: 0xF8
	private uint m_Version; //Field offset: 0x100
	private uint m_RepaintVersion; //Field offset: 0x104
	private uint m_HierarchyVersion; //Field offset: 0x108
	private ProfilerMarker m_MarkerBeforeUpdate; //Field offset: 0x110
	private ProfilerMarker m_MarkerUpdate; //Field offset: 0x118
	private ProfilerMarker m_MarkerRender; //Field offset: 0x120
	private ProfilerMarker m_MarkerLayout; //Field offset: 0x128
	private ProfilerMarker m_MarkerBindings; //Field offset: 0x130
	private ProfilerMarker m_MarkerDataBinding; //Field offset: 0x138
	private ProfilerMarker m_MarkerAnimations; //Field offset: 0x140
	private ProfilerMarker m_MarkerPanelChangeReceiver; //Field offset: 0x148
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventDispatcher <dispatcher>k__BackingField; //Field offset: 0x150
	private TimerEventScheduler m_Scheduler; //Field offset: 0x158
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ScriptableObject <ownerObject>k__BackingField; //Field offset: 0x160
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly ContextType <contextType>k__BackingField; //Field offset: 0x168
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private SavePersistentViewData <saveViewData>k__BackingField; //Field offset: 0x170
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private GetViewDataDictionary <getViewDataDictionary>k__BackingField; //Field offset: 0x178
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private FocusController <focusController>k__BackingField; //Field offset: 0x180
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventInterests <IMGUIEventInterests>k__BackingField; //Field offset: 0x188
	private bool m_JustReceivedFocus; //Field offset: 0x18B
	private IDebugPanelChangeReceiver m_PanelChangeReceiver; //Field offset: 0x190
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <IMGUIContainersCount>k__BackingField; //Field offset: 0x198
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private IMGUIContainer <rootIMGUIContainer>k__BackingField; //Field offset: 0x1A0
	private AtlasBase m_Atlas; //Field offset: 0x1A8
	private bool m_ValidatingLayout; //Field offset: 0x1B0

	public virtual AtlasBase atlas
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 10
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 127
	}

	public virtual ContextType contextType
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public virtual EventDispatcher dispatcher
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public virtual FocusController focusController
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public virtual GetViewDataDictionary getViewDataDictionary
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	internal virtual uint hierarchyVersion
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 7
	}

	public virtual int IMGUIContainersCount
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	public virtual EventInterests IMGUIEventInterests
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 24
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 21
	}

	private static LoadResourceFunction loadResourceFunc
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private get { } //Length: 79
	}

	internal string name
	{
		[CalledBy(Type = typeof(DataBindingManager), Member = "ProcessBindingRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "LogResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingResult&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "CreateUIToolkitPanelGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		internal get { } //Length: 10
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Panel), Member = "CreateMarkers", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal set { } //Length: 43
	}

	public virtual ScriptableObject ownerObject
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public IDebugPanelChangeReceiver panelChangeReceiver
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 169
	}

	public virtual IMGUIContainer rootIMGUIContainer
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public virtual SavePersistentViewData saveViewData
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	internal virtual IScheduler scheduler
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TimerEventScheduler), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 115
	}

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal virtual IStylePropertyAnimationSystem styleAnimationSystem
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal set { } //Length: 115
	}

	public TimerEventScheduler timerEventScheduler
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TimerEventScheduler), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 115
	}

	private static TimeMsFunction TimeSinceStartup
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private get { } //Length: 79
	}

	internal virtual uint version
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 7
	}

	public virtual VisualElement visualTree
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 10
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	private static Panel() { }

	[CalledBy(Type = typeof(RuntimePanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseRuntimePanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(EventDispatcher)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "SetSpecializedHierarchyFlagsUpdater", ReturnType = typeof(void))]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(FocusController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFocusRing)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementFocusRing), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(DefaultFocusOrder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PanelRootElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeUpdater), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Panel), Member = "CreateMarkers", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataBindingManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutManager), Member = "CreateConfig", ReturnType = typeof(LayoutConfig))]
	[Calls(Type = typeof(ElementUnderPointer), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicAtlas), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	public Panel(ScriptableObject ownerObject, ContextType contextType, EventDispatcher dispatcher) { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal static Vector2Int <Pick>g__PixelOf|105_0(Vector2 p) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualTreeUpdater), Member = "UpdateVisualTreePhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeUpdatePhase)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void ApplyStyles() { }

	[CalledBy(Type = typeof(DefaultEventSystem), Member = "set_focusedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "OnFocusEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimePanel), typeof(FocusEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "UpdateFocusedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnDeselect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	internal void Blur() { }

	[CalledBy(Type = typeof(RuntimePanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(ContextType), typeof(EventDispatcher)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	private void CreateMarkers() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	internal static long DefaultTimeSinceStartupMs() { }

	[CalledBy(Type = typeof(BaseRuntimePanel), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeUpdater), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(UIElementsUtility), Member = "RemoveCachedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerDeviceState), Member = "RemovePanelData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutManager), Member = "DestroyConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutConfig&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Dispose(bool disposing) { }

	[CalledBy(Type = typeof(DefaultEventSystem), Member = "set_focusedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "OnFocusEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimePanel), typeof(FocusEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "UpdateFocusedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	internal void Focus() { }

	[CallerCount(Count = 0)]
	public virtual AtlasBase get_atlas() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public virtual ContextType get_contextType() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public virtual EventDispatcher get_dispatcher() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public virtual FocusController get_focusController() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public virtual GetViewDataDictionary get_getViewDataDictionary() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal virtual uint get_hierarchyVersion() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public virtual int get_IMGUIContainersCount() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public virtual EventInterests get_IMGUIEventInterests() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private static LoadResourceFunction get_loadResourceFunc() { }

	[CalledBy(Type = typeof(DataBindingManager), Member = "ProcessBindingRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "LogResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingResult&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "CreateUIToolkitPanelGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	internal string get_name() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public virtual ScriptableObject get_ownerObject() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public IDebugPanelChangeReceiver get_panelChangeReceiver() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public virtual IMGUIContainer get_rootIMGUIContainer() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public virtual SavePersistentViewData get_saveViewData() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimerEventScheduler), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual IScheduler get_scheduler() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal virtual IStylePropertyAnimationSystem get_styleAnimationSystem() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimerEventScheduler), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public TimerEventScheduler get_timerEventScheduler() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private static TimeMsFunction get_TimeSinceStartup() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal virtual uint get_version() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual VisualElement get_visualTree() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualTreeUpdater), Member = "GetUpdater", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeUpdatePhase)}, ReturnType = typeof(IVisualTreeUpdater))]
	[CallsUnknownMethods(Count = 1)]
	internal virtual IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase) { }

	[CalledBy(Type = typeof(VisualElement), Member = "AddStyleSheetPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeAsset+<get_stylesheets>d__31", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeAsset+<get_templateDependencies>d__27", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "ResolveTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(VisualTreeAsset))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadFontDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(FontDefinition))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadFont", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Font))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "TryGetImageSourceFromValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyValue), typeof(float), typeof(ImageSource&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Resources), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(Object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal static object LoadResource(string pathName, Type type, float dpiScaling) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualTreeUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[CalledBy(Type = typeof(Panel), Member = "PickAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>), typeof(bool)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(Panel), Member = "PerformPick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>), typeof(bool)}, ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBoundingBox", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(VisualElement), Member = "ShouldClip", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Panel), Member = "PerformPick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>), typeof(bool)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "get_visible", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static VisualElement PerformPick(VisualElement root, Vector2 point, List<VisualElement> picked = null, bool includeIgnoredElement = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ElementUnderPointer), Member = "GetTopElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector2&), typeof(Boolean&)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(Panel), Member = "PickAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>), typeof(bool)}, ReturnType = typeof(VisualElement))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public virtual VisualElement Pick(Vector2 point) { }

	[CalledBy(Type = typeof(Panel), Member = "PickAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(Panel), Member = "Pick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel), Member = "PerformPick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>), typeof(bool)}, ReturnType = typeof(VisualElement))]
	private static VisualElement PickAll(VisualElement root, Vector2 point, List<VisualElement> picked = null, bool includeIgnoredElement = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Panel), Member = "PickAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>), typeof(bool)}, ReturnType = typeof(VisualElement))]
	[CallsDeduplicatedMethods(Count = 2)]
	public virtual VisualElement PickAll(Vector2 point, List<VisualElement> picked) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public virtual void Render() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeUpdater), Member = "UpdateVisualTreePhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeUpdatePhase)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	public virtual void Repaint(Event e) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void set_atlas(AtlasBase value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public virtual void set_dispatcher(EventDispatcher value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public virtual void set_focusController(FocusController value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public virtual void set_IMGUIContainersCount(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public virtual void set_IMGUIEventInterests(EventInterests value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel), Member = "CreateMarkers", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void set_name(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected virtual void set_ownerObject(ScriptableObject value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_panelChangeReceiver(IDebugPanelChangeReceiver value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal virtual void set_styleAnimationSystem(IStylePropertyAnimationSystem value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualTreeUpdater), Member = "SetUpdater", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IVisualTreeUpdater), typeof(VisualTreeUpdatePhase)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal virtual void SetUpdater(IVisualTreeUpdater updater, VisualTreeUpdatePhase phase) { }

	[CalledBy(Type = typeof(TimerEventScheduler), Member = "UpdateScheduledEvents", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementAnimationSystem), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesDiscrete`1", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueAnimation`1), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScheduledItem), Member = "ResetStartTime", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventBase), Member = "LocalInit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeViewReorderableDragAndDropController), Member = "ExpandDropItem", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeViewReorderableDragAndDropController), Member = "HandleAutoExpand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "ShouldProcessBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "CurrentTime", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(ScheduledItem), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static long TimeSinceStartupMs() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualTreeUpdater), Member = "UpdateVisualTreePhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeUpdatePhase)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void UpdateAnimations() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualTreeUpdater), Member = "UpdateVisualTreePhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeUpdatePhase)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void UpdateBindings() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualTreeUpdater), Member = "UpdateVisualTreePhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeUpdatePhase)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateForRepaint() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public virtual void ValidateFocus() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualTreeUpdater), Member = "UpdateVisualTreePhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeUpdatePhase)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void ValidateLayout() { }

}

