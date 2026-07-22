namespace UI.Dates;

public static class DatePickerTimer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__10_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		internal void <OnLoad>b__10_0() { }

	}

	private static DatePickerTimerComponent _timerComponent; //Field offset: 0x0
	[CompilerGenerated]
	private static bool <IsQuitting>k__BackingField; //Field offset: 0x8

	public static bool IsFirstFrame
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Time), Member = "get_frameCount", ReturnType = typeof(int))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 22
	}

	private static bool IsQuitting
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private get { } //Length: 55
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set { } //Length: 60
	}

	private static DatePickerTimerComponent timerComponent
	{
		[CalledBy(Type = typeof(DatePickerTimer), Member = "StartCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerator)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePickerTimer), Member = "DelayedCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Action), typeof(MonoBehaviour), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "FindFirstObjectByType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(Object), Member = "DontDestroyOnLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		private get { } //Length: 459
	}

	[CalledBy(Type = typeof(DatePicker_InputField), Member = "ShowCalendar", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DatePickerTimer), Member = "DelayedCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Action), typeof(MonoBehaviour), typeof(bool)}, ReturnType = typeof(void))]
	public static void AtEndOfFrame(Action action, MonoBehaviour actionTarget, bool forceEvenIfObjectIsInactive = false) { }

	[CalledBy(Type = typeof(DatePicker), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "_UpdateDisplay", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "SetPositionAdjacentToInputFieldContainer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePickerTimer), Member = "AtEndOfFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(MonoBehaviour), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_DateRange), Member = "DateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DatePickerTimer), Member = "get_timerComponent", ReturnType = typeof(DatePickerTimerComponent))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static void DelayedCall(float delay, Action action, MonoBehaviour actionTarget, bool forceEvenIfObjectIsInactive = false) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private static void EditorUpdate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_frameCount", ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public static bool get_IsFirstFrame() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private static bool get_IsQuitting() { }

	[CalledBy(Type = typeof(DatePickerTimer), Member = "StartCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerator)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePickerTimer), Member = "DelayedCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Action), typeof(MonoBehaviour), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "FindFirstObjectByType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "DontDestroyOnLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private static DatePickerTimerComponent get_timerComponent() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static WaitForSeconds GetWaitForSecondsInstruction(float seconds) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WaitForSecondsRealtime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	public static WaitForSecondsRealtime GetWaitForSecondsRealtimeInstruction(float seconds) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Application), Member = "add_quitting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[RuntimeInitializeOnLoadMethod]
	public static void OnLoad() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private static void set_IsQuitting(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DatePickerTimer), Member = "get_timerComponent", ReturnType = typeof(DatePickerTimerComponent))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void StartCoroutine(IEnumerator coroutine) { }

}

