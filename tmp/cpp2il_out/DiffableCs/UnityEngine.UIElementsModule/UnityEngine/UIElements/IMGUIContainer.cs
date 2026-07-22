namespace UnityEngine.UIElements;

public class IMGUIContainer : VisualElement, IDisposable
{
	private struct GUIGlobals
	{
		public Matrix4x4 matrix; //Field offset: 0x0
		public Color color; //Field offset: 0x40
		public Color contentColor; //Field offset: 0x50
		public Color backgroundColor; //Field offset: 0x60
		public bool enabled; //Field offset: 0x70
		public bool changed; //Field offset: 0x71
		public int displayIndex; //Field offset: 0x74
		public float pixelsPerPoint; //Field offset: 0x78

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlFactory : UxmlFactory<IMGUIContainer, UxmlTraits>
	{

		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : UxmlTraits
	{

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public UxmlTraits() { }

	}

	internal static readonly BindingId cullingEnabledProperty; //Field offset: 0x0
	internal static readonly BindingId contextTypeProperty; //Field offset: 0x98
	public static readonly string ussClassName; //Field offset: 0x130
	internal static readonly string ussFoldoutChildDepthClassName; //Field offset: 0x138
	internal static readonly List<String> ussFoldoutChildDepthClassNames; //Field offset: 0x140
	private static readonly ProfilerMarker k_OnGUIMarker; //Field offset: 0x148
	private static readonly ProfilerMarker k_ImmediateCallbackMarker; //Field offset: 0x150
	private static Event s_DefaultMeasureEvent; //Field offset: 0x158
	private static Event s_MeasureEvent; //Field offset: 0x160
	private static Event s_CurrentEvent; //Field offset: 0x168
	private Action m_OnGUIHandler; //Field offset: 0x4A8
	private ObjectGUIState m_ObjectGUIState; //Field offset: 0x4B0
	internal bool useOwnerObjectGUIState; //Field offset: 0x4B8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Rect <lastWorldClip>k__BackingField; //Field offset: 0x4BC
	private bool m_CullingEnabled; //Field offset: 0x4CC
	private bool m_IsFocusDelegated; //Field offset: 0x4CD
	private bool m_RefreshCachedLayout; //Field offset: 0x4CE
	private LayoutCache m_Cache; //Field offset: 0x4D0
	private Rect m_CachedClippingRect; //Field offset: 0x4D8
	private Matrix4x4 m_CachedTransform; //Field offset: 0x4E8
	private ContextType m_ContextType; //Field offset: 0x528
	private bool lostFocus; //Field offset: 0x52C
	private bool receivedFocus; //Field offset: 0x52D
	private FocusChangeDirection focusChangeDirection; //Field offset: 0x530
	private bool hasFocusableControls; //Field offset: 0x538
	private int newKeyboardFocusControlID; //Field offset: 0x53C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <focusOnlyIfHasFocusableControls>k__BackingField; //Field offset: 0x540
	private GUIGlobals m_GUIGlobals; //Field offset: 0x544

	private LayoutCache cache
	{
		[CalledBy(Type = typeof(IMGUIContainer), Member = "get_layoutMeasuredWidth", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(IMGUIContainer), Member = "get_layoutMeasuredHeight", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(IMGUIContainer), Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(IMGUIContainer), Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(IMGUIContainer), Member = "DoMeasure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 10)]
		[Calls(Type = "UnityEngine.GUILayoutUtility+LayoutCache", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 123
	}

	public virtual bool canGrabFocus
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_canGrabFocus", ReturnType = typeof(bool))]
		 get { } //Length: 41
	}

	[CreateProperty]
	public ContextType contextType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		 set { } //Length: 124
	}

	[CreateProperty]
	public bool cullingEnabled
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 10
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		 set { } //Length: 136
	}

	internal bool focusOnlyIfHasFocusableControls
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	internal ObjectGUIState guiState
	{
		[CalledBy(Type = typeof(UIElementsUtility), Member = "BeginContainerGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUILayoutUtility+LayoutCache", typeof(Event), typeof(IMGUIContainer)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.ObjectGUIState", Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 188
	}

	internal Rect lastWorldClip
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 14
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal set { } //Length: 11
	}

	private float layoutMeasuredHeight
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(IMGUIContainer), Member = "get_cache", ReturnType = "UnityEngine.GUILayoutUtility+LayoutCache")]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 44
	}

	private float layoutMeasuredWidth
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(IMGUIContainer), Member = "get_cache", ReturnType = "UnityEngine.GUILayoutUtility+LayoutCache")]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 44
	}

	public Action onGUIHandler
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 10
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 100
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(Event), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "set_type", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	private static IMGUIContainer() { }

	[CalledBy(Type = typeof(IMGUIContainer), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_requireMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public IMGUIContainer(Action onGUIHandler) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IMGUIContainer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	public IMGUIContainer() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <DoOnGUI>b__59_0() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.ObjectGUIState", Member = "Dispose", ReturnType = typeof(void))]
	protected override void Dispose(bool disposeManaged) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Utility), Member = "DisableScissor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldTransform", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldClip", ReturnType = typeof(Rect))]
	[Calls(Type = "UnityEngine.GUIClip+ParentClipScope", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "ComputeAAAlignedBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Matrix4x4)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(IMGUIContainer), Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.GUIClip+ParentClipScope", Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void DoIMGUIRepaint() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Event), Member = "get_current", ReturnType = typeof(Event))]
	[Calls(Type = typeof(Event), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(IMGUIContainer), Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IMGUIContainer), Member = "get_cache", ReturnType = "UnityEngine.GUILayoutUtility+LayoutCache")]
	[CallsUnknownMethods(Count = 4)]
	protected private virtual Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	[CalledBy(Type = typeof(IMGUIContainer), Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "DoMeasure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GUI), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(GUIUtility), Member = "get_keyboardControl", ReturnType = typeof(int))]
	[Calls(Type = typeof(GUIUtility), Member = "OwnsId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GUIUtility), Member = "set_keyboardControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIUtility), Member = "SetKeyboardControlToFirstControlId", ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_character", ReturnType = typeof(char))]
	[Calls(Type = typeof(Event), Member = "Use", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.GUIClip+ParentClipScope", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIUtility), Member = "set_pixelsPerPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.GUIClip+ParentClipScope", Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIUtility), Member = "IsExitGUIException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIUtility), Member = "SetKeyboardControlToLastControlId", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = typeof(VisualElement), Member = "get_playModeTintColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = "UnityEngine.GUIClip", Member = "Internal_GetCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(GUIUtility), Member = "get_guiDepth", ReturnType = typeof(int))]
	[Calls(Type = typeof(GUI), Member = "get_matrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(GUI), Member = "get_color", ReturnType = typeof(Color))]
	[Calls(Type = typeof(GUI), Member = "get_contentColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(GUI), Member = "get_backgroundColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(GUI), Member = "get_changed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Event), Member = "get_current", ReturnType = typeof(Event))]
	[Calls(Type = typeof(Event), Member = "get_displayIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(GUIUtility), Member = "get_pixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = typeof(IMGUIContainer), Member = "get_cache", ReturnType = "UnityEngine.GUILayoutUtility+LayoutCache")]
	[Calls(Type = typeof(UIElementsUtility), Member = "BeginContainerGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUILayoutUtility+LayoutCache", typeof(Event), typeof(IMGUIContainer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUI), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 25)]
	[ContainsUnimplementedInstructions]
	private void DoOnGUI(Event evt, Matrix4x4 parentTransform, Rect clippingRect, bool isComputingLayout, Rect layoutSize, Action onGUIHandler, bool canAffectFocus = true) { }

	[CalledBy(Type = typeof(IMGUIContainer), Member = "get_layoutMeasuredWidth", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "get_layoutMeasuredHeight", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "DoMeasure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 10)]
	[Calls(Type = "UnityEngine.GUILayoutUtility+LayoutCache", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private LayoutCache get_cache() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_canGrabFocus", ReturnType = typeof(bool))]
	public virtual bool get_canGrabFocus() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ContextType get_contextType() { }

	[CallerCount(Count = 0)]
	public bool get_cullingEnabled() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal bool get_focusOnlyIfHasFocusableControls() { }

	[CalledBy(Type = typeof(UIElementsUtility), Member = "BeginContainerGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUILayoutUtility+LayoutCache", typeof(Event), typeof(IMGUIContainer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.ObjectGUIState", Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal ObjectGUIState get_guiState() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal Rect get_lastWorldClip() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IMGUIContainer), Member = "get_cache", ReturnType = "UnityEngine.GUILayoutUtility+LayoutCache")]
	[CallsUnknownMethods(Count = 2)]
	private float get_layoutMeasuredHeight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IMGUIContainer), Member = "get_cache", ReturnType = "UnityEngine.GUILayoutUtility+LayoutCache")]
	[CallsUnknownMethods(Count = 2)]
	private float get_layoutMeasuredWidth() { }

	[CallerCount(Count = 0)]
	public Action get_onGUIHandler() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[ContainsUnimplementedInstructions]
	private Rect GetCurrentClipRect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldTransform", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Event), Member = "get_rawType", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static void GetCurrentTransformAndClip(IMGUIContainer container, Event evt, out Matrix4x4 transform, out Rect clipRect) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventBase), Member = "get_imguiEvent", ReturnType = typeof(Event))]
	[Calls(Type = typeof(IMGUIContainer), Member = "SendEventToIMGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventBase`1), Member = "TypeId", ReturnType = typeof(long))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementUtils), Member = "GetFoldoutDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "set_processedByFocusController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 4)]
	[EventInterest(EventInterestOptionsInternal::TriggeredByOS (426094))]
	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(NavigationMoveEvent), typeof(NavigationSubmitEvent), typeof(NavigationCancelEvent), typeof(BlurEvent), typeof(FocusEvent), typeof(DetachFromPanelEvent), typeof(AttachToPanelEvent)})]
	protected virtual void HandleEventBubbleUp(EventBase evt) { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(NavigationMoveEvent), typeof(NavigationSubmitEvent), typeof(NavigationCancelEvent), typeof(BlurEvent), typeof(FocusEvent), typeof(DetachFromPanelEvent), typeof(AttachToPanelEvent)})]
	[EventInterest(EventInterestOptionsInternal::TriggeredByOS (426094))]
	internal virtual void HandleEventBubbleUpDisabled(EventBase evt) { }

	[CalledBy(Type = typeof(IMGUIContainer), Member = "SendEventToIMGUIRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldTransform", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Event), Member = "get_rawType", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(IMGUIContainer), Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool HandleIMGUIEvent(Event e, bool canAffectFocus) { }

	[CalledBy(Type = typeof(IMGUIContainer), Member = "DoIMGUIRepaint", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GUIUtility), Member = "ExitGUI", ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIUtility), Member = "set_hotControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "HasPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(IMGUIContainer), Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Event), Member = "set_commandName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(IMGUIContainer), Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "set_type", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventType)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.GUILayoutUtility+LayoutCache", Member = "ResetCursor", ReturnType = typeof(void))]
	[Calls(Type = typeof(IMGUIContainer), Member = "get_cache", ReturnType = "UnityEngine.GUILayoutUtility+LayoutCache")]
	[Calls(Type = "UnityEngine.EventInterests", Member = "WantsLayoutPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventType)}, ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.EventInterests", Member = "WantsEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Event), Member = "get_rawType", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private bool HandleIMGUIEvent(Event e, Matrix4x4 worldTransform, Rect clippingRect, Action onGUIHandler, bool canAffectFocus) { }

	[CalledBy(Type = typeof(IMGUIContainer), Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldTransform", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Event), Member = "get_rawType", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(IMGUIContainer), Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool HandleIMGUIEvent(Event e, Action onGUIHandler, bool canAffectFocus) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private bool IsContainerCapturingTheMouse() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventBase`1), Member = "TypeId", ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool IsDockAreaMouseUp(EventBase evt) { }

	[CalledBy(Type = typeof(IMGUIContainer), Member = "VerifyBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(GUIUtility), Member = "HitTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Vector2), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private bool IsEventInsideLocalWindow(EventBase evt) { }

	[CalledBy(Type = typeof(IMGUIContainer), Member = "VerifyBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventBase`1), Member = "TypeId", ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool IsLocalEvent(EventBase evt) { }

	[CalledBy(Type = typeof(UIElementsUtility), Member = "UnityEngine.UIElements.IUIElementsUtility.MakeCurrentIMGUIContainerDirty", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	public void MarkDirtyLayout() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EntryRecorder), Member = "DrawImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnGenerateVisualContent(MeshGenerationContext mgc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUI), Member = "set_matrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUI), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUI), Member = "set_contentColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUI), Member = "set_backgroundColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUI), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUI), Member = "set_changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_current", ReturnType = typeof(Event))]
	[Calls(Type = typeof(Event), Member = "set_displayIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIUtility), Member = "set_pixelsPerPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void RestoreGlobals() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUI), Member = "get_matrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(GUI), Member = "get_color", ReturnType = typeof(Color))]
	[Calls(Type = typeof(GUI), Member = "get_contentColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(GUI), Member = "get_backgroundColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(GUI), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GUI), Member = "get_changed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Event), Member = "get_current", ReturnType = typeof(Event))]
	[Calls(Type = typeof(Event), Member = "get_displayIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(GUIUtility), Member = "get_pixelsPerPoint", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	private void SaveGlobals() { }

	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "PropagateToRemainingIMGUIContainerRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(IMGUIContainer), Member = "SendEventToIMGUIRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventBase), Member = "get_imguiEvent", ReturnType = typeof(Event))]
	[Calls(Type = typeof(Event), Member = "get_isDirectManipulationDevice", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Event), Member = "get_rawType", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(Event), Member = "set_type", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal bool SendEventToIMGUI(EventBase evt, bool canAffectFocus = true, bool verifyBounds = true) { }

	[CalledBy(Type = typeof(IMGUIContainer), Member = "SendEventToIMGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(IMGUIContainer), Member = "VerifyBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventBase), Member = "get_imguiEvent", ReturnType = typeof(Event))]
	[Calls(Type = typeof(IMGUIContainer), Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private bool SendEventToIMGUIRaw(EventBase evt, bool canAffectFocus, bool verifyBounds) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	public void set_contextType(ContextType value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	public void set_cullingEnabled(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal void set_lastWorldClip(Rect value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_onGUIHandler(Action value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementUtils), Member = "GetFoldoutDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void SetFoldoutDepthClass() { }

	[CalledBy(Type = typeof(IMGUIContainer), Member = "SendEventToIMGUIRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(IMGUIContainer), Member = "IsLocalEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(IMGUIContainer), Member = "IsEventInsideLocalWindow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventBase`1), Member = "TypeId", ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private bool VerifyBounds(EventBase evt) { }

}

