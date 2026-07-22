namespace UnityEngine.Rendering;

public sealed class DebugManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Boolean> <>9__69_0; //Field offset: 0x8
		public static Action <>9__69_1; //Field offset: 0x10
		public static Func<Widget, Int32> <>9__80_0; //Field offset: 0x18

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DebugManager), Member = ".ctor", ReturnType = typeof(void))]
		internal DebugManager <.cctor>b__95_0() { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		internal void <.ctor>b__69_0(bool <p0>) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		internal void <.ctor>b__69_1() { }

		[CallerCount(Count = 0)]
		internal int <TogglePersistent>b__80_0(Widget w) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass87_0
	{
		public string displayName; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass87_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal bool <FindPanelIndex>b__0(Panel p) { }

	}

	internal enum UIMode
	{
		EditorMode = 0,
		RuntimeMode = 1,
	}

	private class UIState
	{
		public UIMode mode; //Field offset: 0x10
		[SerializeField]
		private bool m_Open; //Field offset: 0x14

		public bool open
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CalledBy(Type = typeof(DebugManager), Member = "set_displayEditorUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(DebugManager), Member = "set_displayRuntimeUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(DebugManager), Member = "ToggleEditorUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
			[CallerCount(Count = 3)]
			[CallsDeduplicatedMethods(Count = 1)]
			 set { } //Length: 131
		}

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public UIState() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public bool get_open() { }

		[CalledBy(Type = typeof(DebugManager), Member = "set_displayEditorUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DebugManager), Member = "set_displayRuntimeUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DebugManager), Member = "ToggleEditorUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		public void set_open(bool value) { }

	}

	private const string kEnableDebugBtn1 = "Enable Debug Button 1"; //Field offset: 0x0
	private const string kEnableDebug = "Enable Debug"; //Field offset: 0x0
	private const string kResetBtn = "Debug Reset"; //Field offset: 0x0
	private const string kMultiplierBtn = "Debug Multiplier"; //Field offset: 0x0
	private const string kDPadHorizontal = "Debug Horizontal"; //Field offset: 0x0
	private const string kDPadVertical = "Debug Vertical"; //Field offset: 0x0
	[CompilerGenerated]
	private static Action<UIMode, Boolean> windowStateChanged; //Field offset: 0x0
	private const string kValidateBtn = "Debug Validate"; //Field offset: 0x0
	private const string kDebugNextBtn = "Debug Next"; //Field offset: 0x0
	private const string kDebugPreviousBtn = "Debug Previous"; //Field offset: 0x0
	private const string kEnableDebugBtn2 = "Enable Debug Button 2"; //Field offset: 0x0
	private const string kPersistentBtn = "Debug Persistent"; //Field offset: 0x0
	private static readonly Lazy<DebugManager> s_Instance; //Field offset: 0x8
	private DebugActionDesc[] m_DebugActions; //Field offset: 0x10
	private DebugActionState[] m_DebugActionStates; //Field offset: 0x18
	private InputActionMap debugActionMap; //Field offset: 0x20
	private UIState editorUIState; //Field offset: 0x28
	private bool m_EnableRuntimeUI; //Field offset: 0x30
	private UIState runtimeUIState; //Field offset: 0x38
	private ReadOnlyCollection<Panel> m_ReadOnlyPanels; //Field offset: 0x40
	private readonly List<Panel> m_Panels; //Field offset: 0x48
	[CompilerGenerated]
	private Action<Boolean> onDisplayRuntimeUIChanged; //Field offset: 0x50
	[CompilerGenerated]
	private Action onSetDirty; //Field offset: 0x58
	[CompilerGenerated]
	private Action resetData; //Field offset: 0x60
	public bool refreshEditorRequested; //Field offset: 0x68
	private Nullable<Int32> m_RequestedPanelIndex; //Field offset: 0x6C
	private GameObject m_Root; //Field offset: 0x78
	private DebugUIHandlerCanvas m_RootUICanvas; //Field offset: 0x80
	private GameObject m_PersistentRoot; //Field offset: 0x88
	private DebugUIHandlerPersistentCanvas m_RootUIPersistentCanvas; //Field offset: 0x90

	public event Action<Boolean> onDisplayRuntimeUIChanged
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 add { } //Length: 160
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 remove { } //Length: 160
	}

	public event Action onSetDirty
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 remove { } //Length: 146
	}

	private event Action resetData
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		private add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		private remove { } //Length: 146
	}

	public static event Action<UIMode, Boolean> windowStateChanged
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 add { } //Length: 259
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 remove { } //Length: 259
	}

	public bool displayEditorUI
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 27
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIState), Member = "set_open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 30
	}

	public bool displayPersistentRuntimeUI
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 131
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CoreUtils), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DebugManager), Member = "EnsurePersistentCanvas", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 161
	}

	public bool displayRuntimeUI
	{
		[CalledBy(Type = typeof(FreeCamera), Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsVolume+WidgetFactory+<>c__DisplayClass7_0", Member = "<CreateVolumeTable>b__0", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SettingsPanel), Member = "Refresh", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DebugManager), Member = "get_isAnyDebugUIActive", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DebugManager), Member = "Reset", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DebugManager), Member = "ReDrawOnScreenDebug", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugUpdater+<RefreshRuntimeUINextFrame>d__15", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DebugUpdater), Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 125
		[CalledBy(Type = typeof(DebugUpdater), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DebugUpdater), Member = "DisableRuntime", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DebugUpdater), Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UIState), Member = "set_open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DebugUpdater), Member = "HandleInternalEventSystemComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
		[Calls(Type = typeof(CoreUtils), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 640
	}

	public bool enableRuntimeUI
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DebugUpdater), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		 set { } //Length: 22
	}

	public static DebugManager instance
	{
		[CallerCount(Count = 57)]
		[Calls(Type = typeof(System.Lazy`1<System.Object>), Member = "get_Value", ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 112
	}

	public bool isAnyDebugUIActive
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DebugManager), Member = "get_displayRuntimeUI", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 146
	}

	public ReadOnlyCollection<Panel> panels
	{
		[CalledBy(Type = typeof(DebugUIHandlerCanvas), Member = "Rebuild", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DebugManager), Member = "UpdateReadOnlyCollection", ReturnType = typeof(void))]
		 get { } //Length: 43
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Lazy`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Object>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static DebugManager() { }

	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__95_0", ReturnType = typeof(DebugManager))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputActionMap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 9)]
	private DebugManager() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public void add_onDisplayRuntimeUIChanged(Action<Boolean> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void add_onSetDirty(Action value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	private void add_resetData(Action value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public static void add_windowStateChanged(Action<UIMode, Boolean> value) { }

	[CalledBy(Type = typeof(DebugManager), Member = "RegisterActions", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private void AddAction(DebugAction action, DebugActionDesc desc) { }

	[CalledBy(Type = typeof(DebugUIHandlerBitField), Member = "OnSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(DebugUIHandlerWidget)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DebugUIHandlerColor), Member = "OnSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(DebugUIHandlerWidget)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DebugUIHandlerFoldout), Member = "OnSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(DebugUIHandlerWidget)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DebugUIHandlerGroup), Member = "OnSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(DebugUIHandlerWidget)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DebugUIHandlerHBox), Member = "OnSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(DebugUIHandlerWidget)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DebugUIHandlerRenderingLayerField), Member = "OnSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(DebugUIHandlerWidget)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DebugUIHandlerVBox), Member = "OnSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(DebugUIHandlerWidget)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DebugUIHandlerVector2), Member = "OnSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(DebugUIHandlerWidget)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DebugUIHandlerVector3), Member = "OnSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(DebugUIHandlerWidget)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DebugUIHandlerVector4), Member = "OnSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(DebugUIHandlerWidget)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(DebugUIHandlerCanvas), Member = "ChangeSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugUIHandlerWidget), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void ChangeSelection(DebugUIHandlerWidget widget, bool fromNext) { }

	[CalledBy(Type = typeof(DebugUpdater), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugUpdater), Member = "EnableRuntime", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputAction), Member = "Enable", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	internal void EnableInputActions() { }

	[CalledBy(Type = typeof(DebugManager), Member = "set_displayPersistentRuntimeUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugManager), Member = "TogglePersistent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Widget), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "FindFirstObjectByType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 4)]
	private void EnsurePersistentCanvas() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Predicate`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "FindIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public int FindPanelIndex(string displayName) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool get_displayEditorUI() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_displayPersistentRuntimeUI() { }

	[CalledBy(Type = typeof(FreeCamera), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsVolume+WidgetFactory+<>c__DisplayClass7_0", Member = "<CreateVolumeTable>b__0", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SettingsPanel), Member = "Refresh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugManager), Member = "get_isAnyDebugUIActive", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DebugManager), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugManager), Member = "ReDrawOnScreenDebug", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugUpdater+<RefreshRuntimeUINextFrame>d__15", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DebugUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_displayRuntimeUI() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public bool get_enableRuntimeUI() { }

	[CallerCount(Count = 57)]
	[Calls(Type = typeof(System.Lazy`1<System.Object>), Member = "get_Value", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	public static DebugManager get_instance() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugManager), Member = "get_displayRuntimeUI", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_isAnyDebugUIActive() { }

	[CalledBy(Type = typeof(DebugUIHandlerCanvas), Member = "Rebuild", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DebugManager), Member = "UpdateReadOnlyCollection", ReturnType = typeof(void))]
	public ReadOnlyCollection<Panel> get_panels() { }

	[CalledBy(Type = typeof(DebugUIHandlerCanvas), Member = "ChangeSelectionValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugUIHandlerCanvas), Member = "HandleInput", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	internal float GetAction(DebugAction action) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<UnityEngine.Vector2>), Member = "ReadValue", ReturnType = typeof(Vector2))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool GetActionReleaseScrollTarget() { }

	[CalledBy(Type = typeof(DebugUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EnhancedTouchSupport), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Touch), Member = "get_activeTouches", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.EnhancedTouch.Touch>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[Calls(Type = typeof(Touch), Member = "get_phase", ReturnType = typeof(TouchPhase))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(Touch), Member = "get_tapCount", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool GetActionToggleDebugMenuWithTouch() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugManager), Member = "GetItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IContainer)}, ReturnType = typeof(Widget))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public Widget GetItem(string queryPath) { }

	[CalledBy(Type = typeof(DebugManager), Member = "GetItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Widget))]
	[CalledBy(Type = typeof(DebugManager), Member = "GetItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IContainer)}, ReturnType = typeof(Widget))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ObservableList`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
	[Calls(Type = typeof(DebugManager), Member = "GetItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IContainer)}, ReturnType = typeof(Widget))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	private Widget GetItem(string queryPath, IContainer container) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsCommon+SettingsPanel", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugManager), Member = "GetItemsFromContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags), typeof(IContainer)}, ReturnType = typeof(Widget[]))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(PooledObject), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public Widget[] GetItems(Flags flags) { }

	[CalledBy(Type = typeof(DebugManager), Member = "GetItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(Widget[]))]
	[CalledBy(Type = typeof(DebugManager), Member = "GetItemsFromContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags), typeof(IContainer)}, ReturnType = typeof(Widget[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ObservableList`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
	[Calls(Type = typeof(DebugManager), Member = "GetItemsFromContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags), typeof(IContainer)}, ReturnType = typeof(Widget[]))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(PooledObject), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	internal Widget[] GetItemsFromContainer(Flags flags, IContainer container) { }

	[CalledBy(Type = typeof(CameraSwitcher), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsUI+<>c__DisplayClass3_0", Member = "<RegisterDebug>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDebugDisplaySettingsData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugDisplaySettingsUI), Member = "UnregisterDebug", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SettingsPanel), Member = "Refresh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "RegisterDebug", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UnregisterDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "InitProbeReferenceVolume", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphDebugParams), Member = "RegisterDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Panel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "RegisterDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Panel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Panel), Member = "remove_onSetDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.Rendering.DebugUI+Panel>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugManager), Member = "UpdateReadOnlyCollection", ReturnType = typeof(void))]
	[Calls(Type = typeof(Panel), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	public Panel GetPanel(string displayName, bool createIfNull = false, int groupIndex = 0, bool overrideIfExist = false) { }

	[CallerCount(Count = 0)]
	internal Nullable<Int32> GetRequestedEditorWindowPanelIndex() { }

	[CalledBy(Type = typeof(DebugUIHandlerCanvas), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugUIHandlerCanvas), Member = "Rebuild", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public int GetState() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnPanelDirty(Panel panel) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string PanelDiplayName(int panelIndex) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsCommon+SettingsPanel+<>c__DisplayClass3_0", Member = "<.ctor>b__0", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int PanelIndex(string displayName) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+WidgetFactory+<>c", Member = "<CreateMaterialValidationMode>b__2_4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugUI+Field`1<Int32>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+WidgetFactory+<>c", Member = "<CreateAlbedoPreset>b__6_4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugUI+Field`1<Int32>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory+<>c", Member = "<CreateAdditionalWireframeShaderViews>b__3_4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugUI+Field`1<Int32>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory+<>c", Member = "<CreateTaaDebugMode>b__16_4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugUI+Field`1<Int32>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory+<>c", Member = "<CreatePixelValidationMode>b__17_4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugUI+Field`1<Int32>", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DebugManager), Member = "get_displayRuntimeUI", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ReDrawOnScreenDebug() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public void RefreshEditor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionMap), Member = "FindAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(DebugManager), Member = "AddAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugAction), typeof(DebugActionDesc)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 12)]
	private void RegisterActions() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "RegisterDebug", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 4)]
	public void RegisterData(IDebugData data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionSetupExtensions), Member = "AddAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(string), typeof(InputActionType), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputActionSetupExtensions), Member = "AddCompositeBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(CompositeSyntax))]
	[Calls(Type = typeof(CompositeSyntax), Member = "With", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(CompositeSyntax))]
	[Calls(Type = typeof(InputActionSetupExtensions), Member = "AddBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(BindingSyntax))]
	private void RegisterInputs() { }

	[CalledBy(Type = typeof(DebugUIHandlerCanvas), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[CallsUnknownMethods(Count = 3)]
	internal void RegisterRootCanvas(DebugUIHandlerCanvas root) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public void remove_onDisplayRuntimeUIChanged(Action<Boolean> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void remove_onSetDirty(Action value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	private void remove_resetData(Action value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public static void remove_windowStateChanged(Action<UIMode, Boolean> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugManager), Member = "UpdateReadOnlyCollection", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void RemovePanel(Panel panel) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "CleanupDebug", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UnregisterDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "Cleanup", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Panel), Member = "remove_onSetDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.Rendering.DebugUI+Panel>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugManager), Member = "UpdateReadOnlyCollection", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	public void RemovePanel(string displayName) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsCommon+SettingsPanel+<>c__DisplayClass3_0", Member = "<.ctor>b__0", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void RequestEditorWindowPanelIndex(int index) { }

	[CalledBy(Type = typeof(DebugUIHandlerPanel), Member = "ResetDebugManager", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DebugManager), Member = "get_displayRuntimeUI", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Reset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(InputAction), Member = "get_bindings", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputBinding>))]
	[CallsUnknownMethods(Count = 5)]
	private void SampleAction(int actionIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIState), Member = "set_open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_displayEditorUI(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CoreUtils), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugManager), Member = "EnsurePersistentCanvas", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void set_displayPersistentRuntimeUI(bool value) { }

	[CalledBy(Type = typeof(DebugUpdater), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugUpdater), Member = "DisableRuntime", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CoreUtils), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugUpdater), Member = "HandleInternalEventSystemComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIState), Member = "set_open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void set_displayRuntimeUI(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUpdater), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	public void set_enableRuntimeUI(bool value) { }

	[CalledBy(Type = typeof(DebugUIHandlerPanel), Member = "OnScrollbarClicked", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugUIHandlerCanvas), Member = "SetScrollTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugUIHandlerWidget)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void SetScrollTarget(DebugUIHandlerWidget widget) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIState), Member = "set_open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Obsolete("Use DebugManager.instance.displayEditorUI property instead. #from(23.1)")]
	public void ToggleEditorUI(bool open) { }

	[CalledBy(Type = typeof(DebugManager), Member = "TogglePersistent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Widget), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugUIHandlerCanvas), Member = "HandleInput", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DebugManager), Member = "EnsurePersistentCanvas", ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugUIHandlerPersistentCanvas), Member = "Toggle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Value), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugUIHandlerPersistentCanvas), Member = "Toggle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueTuple), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Max", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Int32>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ObservableList`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
	[Calls(Type = typeof(DebugManager), Member = "TogglePersistent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Widget), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	internal void TogglePersistent(Widget widget, Nullable<Int32> forceTupleIndex = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 4)]
	public void UnregisterData(IDebugData data) { }

	[CalledBy(Type = typeof(DebugManager), Member = "UpdateActions", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(InputAction), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateAction(int actionIndex) { }

	[CalledBy(Type = typeof(DebugUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DebugManager), Member = "UpdateAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(InputAction), Member = "get_bindings", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputBinding>))]
	[CallsUnknownMethods(Count = 5)]
	internal void UpdateActions() { }

	[CalledBy(Type = typeof(DebugManager), Member = "get_panels", ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<UnityEngine.Rendering.DebugUI+Panel>))]
	[CalledBy(Type = typeof(DebugManager), Member = "GetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(Panel))]
	[CalledBy(Type = typeof(DebugManager), Member = "RemovePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugManager), Member = "RemovePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Panel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AsReadOnly", ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateReadOnlyCollection() { }

}

