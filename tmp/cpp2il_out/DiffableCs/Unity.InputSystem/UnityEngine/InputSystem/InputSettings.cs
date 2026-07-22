namespace UnityEngine.InputSystem;

public class InputSettings : ScriptableObject
{
	internal enum BackgroundBehavior
	{
		ResetAndDisableNonBackgroundDevices = 0,
		ResetAndDisableAllDevices = 1,
		IgnoreFocus = 2,
	}

	internal enum EditorInputBehaviorInPlayMode
	{
		PointersAndKeyboardsRespectGameViewFocus = 0,
		AllDevicesRespectGameViewFocus = 1,
		AllDeviceInputAlwaysGoesToGameView = 2,
	}

	internal enum InputActionPropertyDrawerMode
	{
		Compact = 0,
		MultilineEffective = 1,
		MultilineBoth = 2,
	}

	internal enum ScrollDeltaBehavior
	{
		UniformAcrossAllPlatforms = 0,
		KeepPlatformSpecificInputRange = 1,
	}

	internal enum UpdateMode
	{
		ProcessEventsInDynamicUpdate = 1,
		ProcessEventsInFixedUpdate = 2,
		ProcessEventsManually = 3,
	}

	internal const int s_OldUnsupportedFixedAndDynamicUpdateSetting = 0; //Field offset: 0x0
	[SerializeField]
	[Tooltip("Determine which type of devices are used by the application. By default, this is empty meaning that all devices recognized by Unity will be used. Restricting the set of supported devices will make only those devices appear in the input system.")]
	private String[] m_SupportedDevices; //Field offset: 0x18
	[SerializeField]
	[Tooltip("Determine when Unity processes events. By default, accumulated input events are flushed out before each fixed update and before each dynamic update. This setting can be used to restrict event processing to only where the application needs it.")]
	private UpdateMode m_UpdateMode; //Field offset: 0x20
	[SerializeField]
	private ScrollDeltaBehavior m_ScrollDeltaBehavior; //Field offset: 0x24
	[SerializeField]
	private int m_MaxEventBytesPerUpdate; //Field offset: 0x28
	[SerializeField]
	private int m_MaxQueuedEventsPerUpdate; //Field offset: 0x2C
	[SerializeField]
	private bool m_CompensateForScreenOrientation; //Field offset: 0x30
	[SerializeField]
	private BackgroundBehavior m_BackgroundBehavior; //Field offset: 0x34
	[SerializeField]
	private EditorInputBehaviorInPlayMode m_EditorInputBehaviorInPlayMode; //Field offset: 0x38
	[SerializeField]
	private InputActionPropertyDrawerMode m_InputActionPropertyDrawerMode; //Field offset: 0x3C
	[SerializeField]
	private float m_DefaultDeadzoneMin; //Field offset: 0x40
	[SerializeField]
	private float m_DefaultDeadzoneMax; //Field offset: 0x44
	[Min(0.0001)]
	[SerializeField]
	private float m_DefaultButtonPressPoint; //Field offset: 0x48
	[SerializeField]
	private float m_ButtonReleaseThreshold; //Field offset: 0x4C
	[SerializeField]
	private float m_DefaultTapTime; //Field offset: 0x50
	[SerializeField]
	private float m_DefaultSlowTapTime; //Field offset: 0x54
	[SerializeField]
	private float m_DefaultHoldTime; //Field offset: 0x58
	[SerializeField]
	private float m_TapRadius; //Field offset: 0x5C
	[SerializeField]
	private float m_MultiTapDelayTime; //Field offset: 0x60
	[SerializeField]
	private bool m_DisableRedundantEventsMerging; //Field offset: 0x64
	[SerializeField]
	private bool m_ShortcutKeysConsumeInputs; //Field offset: 0x65
	internal HashSet<String> m_FeatureFlags; //Field offset: 0x68

	public BackgroundBehavior backgroundBehavior
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
		 set { } //Length: 16
	}

	public float buttonReleaseThreshold
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 25
	}

	public bool compensateForScreenOrientation
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
		 set { } //Length: 16
	}

	public float defaultButtonPressPoint
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 54
	}

	public float defaultDeadzoneMax
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 25
	}

	public float defaultDeadzoneMin
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 25
	}

	public float defaultHoldTime
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 25
	}

	public float defaultSlowTapTime
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 25
	}

	public float defaultTapTime
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 25
	}

	public bool disableRedundantEventsMerging
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
		 set { } //Length: 16
	}

	public EditorInputBehaviorInPlayMode editorInputBehaviorInPlayMode
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
		 set { } //Length: 16
	}

	[Obsolete("filterNoiseOnCurrent is deprecated, filtering of noise is always enabled now.", False)]
	public bool filterNoiseOnCurrent
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	public InputActionPropertyDrawerMode inputActionPropertyDrawerMode
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
		 set { } //Length: 16
	}

	public int maxEventBytesPerUpdate
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
		 set { } //Length: 16
	}

	public int maxQueuedEventsPerUpdate
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
		 set { } //Length: 16
	}

	public float multiTapDelayTime
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 25
	}

	public ScrollDeltaBehavior scrollDeltaBehavior
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
		 set { } //Length: 16
	}

	public bool shortcutKeysConsumeInput
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
		 set { } //Length: 16
	}

	public ReadOnlyArray<String> supportedDevices
	{
		[CalledBy(Type = typeof(InputManager), Member = "IsDeviceLayoutMarkedAsSupportedInSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputManager), Member = "OnNativeDeviceDiscovered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "ApplySettings", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
		 get { } //Length: 83
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = "ToArray", ReturnType = "TValue[]")]
		[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 343
	}

	public float tapRadius
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 25
	}

	public UpdateMode updateMode
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CalledBy(Type = typeof(InputManager), Member = "ApplySettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
		 set { } //Length: 16
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	public InputSettings() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSettings), Member = "CompareSets", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<T>", "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "ToUpperInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputSettings), Member = "IsFeatureEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool AreEqual(InputSettings a, InputSettings b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToUpperInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static bool CompareFeatureFlag(InputSettings a, InputSettings b, string featureName) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool CompareFloats(float a, float b) { }

	[CalledBy(Type = typeof(InputSettings), Member = "AreEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputSettings), typeof(InputSettings)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private static bool CompareSets(ReadOnlyArray<T> a, ReadOnlyArray<T> b) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public BackgroundBehavior get_backgroundBehavior() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_buttonReleaseThreshold() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public bool get_compensateForScreenOrientation() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_defaultButtonPressPoint() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float get_defaultDeadzoneMax() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float get_defaultDeadzoneMin() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_defaultHoldTime() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_defaultSlowTapTime() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_defaultTapTime() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_disableRedundantEventsMerging() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public EditorInputBehaviorInPlayMode get_editorInputBehaviorInPlayMode() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public bool get_filterNoiseOnCurrent() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public InputActionPropertyDrawerMode get_inputActionPropertyDrawerMode() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_maxEventBytesPerUpdate() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_maxQueuedEventsPerUpdate() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_multiTapDelayTime() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public ScrollDeltaBehavior get_scrollDeltaBehavior() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_shortcutKeysConsumeInput() { }

	[CalledBy(Type = typeof(InputManager), Member = "IsDeviceLayoutMarkedAsSupportedInSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputManager), Member = "OnNativeDeviceDiscovered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "ApplySettings", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
	public ReadOnlyArray<String> get_supportedDevices() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_tapRadius() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public UpdateMode get_updateMode() { }

	[CalledBy(Type = typeof(InputManager), Member = "ApplySettings", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSettings), Member = "AreEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputSettings), typeof(InputSettings)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "ToUpperInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal bool IsFeatureEnabled(string featureName) { }

	[CallerCount(Count = 21)]
	[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManager), Member = "ApplySettings", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void OnChange() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
	public void set_backgroundBehavior(BackgroundBehavior value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public void set_buttonReleaseThreshold(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
	public void set_compensateForScreenOrientation(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public void set_defaultButtonPressPoint(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public void set_defaultDeadzoneMax(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public void set_defaultDeadzoneMin(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public void set_defaultHoldTime(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public void set_defaultSlowTapTime(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public void set_defaultTapTime(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
	public void set_disableRedundantEventsMerging(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
	public void set_editorInputBehaviorInPlayMode(EditorInputBehaviorInPlayMode value) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public void set_filterNoiseOnCurrent(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
	public void set_inputActionPropertyDrawerMode(InputActionPropertyDrawerMode value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
	public void set_maxEventBytesPerUpdate(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
	public void set_maxQueuedEventsPerUpdate(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public void set_multiTapDelayTime(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
	public void set_scrollDeltaBehavior(ScrollDeltaBehavior value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
	public void set_shortcutKeysConsumeInput(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "ToArray", ReturnType = "TValue[]")]
	[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_supportedDevices(ReadOnlyArray<String> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public void set_tapRadius(float value) { }

	[CalledBy(Type = typeof(InputManager), Member = "ApplySettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
	public void set_updateMode(UpdateMode value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "ToUpperInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void SetInternalFeatureFlag(string featureName, bool enabled) { }

}

