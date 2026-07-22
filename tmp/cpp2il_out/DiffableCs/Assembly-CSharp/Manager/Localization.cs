namespace Manager;

[Extension]
public static class Localization
{
	[CompilerGenerated]
	private struct <>c__DisplayClass26_0
	{
		public bool dynamic; //Field offset: 0x0
		public Template c; //Field offset: 0x8

	}

	[CompilerGenerated]
	private struct <CardLocaleInit>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x20
		private TaskAwaiter <>u__2; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Manager), Member = "get_TemporaryDBPath", ReturnType = typeof(string))]
		[Calls(Type = typeof(File), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Helper), Member = "TryUnpackDB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.Localization+<PostInitCards>d__39"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<PostInitCards>d__39&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(Template), Member = "RefreshAllCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RefreshCardTemplateAction), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "CleanTempDB", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 6)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ChangeCardLocale>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Locale lang; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.Localization+<CardLocaleInit>d__37"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CardLocaleInit>d__37&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ChangeLocale>d__36 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Locale lang; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.Localization+<Init>d__15"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Init>d__15&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Init>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Localization), Member = "GetLocaleName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Locale), typeof(byte)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.Localization+<LoadNewLanguage>d__16"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadNewLanguage>d__16&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Catalog), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Tips), Member = "Init", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 6)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadNewLanguage>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string lang; //Field offset: 0x20
		private string <path>5__2; //Field offset: 0x28
		private Byte[] <data>5__3; //Field offset: 0x30
		private int <>7__wrap3; //Field offset: 0x38
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x40
		private TaskAwaiter <>u__2; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Updater), Member = "GetDatasFilePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Helper), Member = "ReadAllBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Threading.Tasks.Task`1<Byte[]>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(File), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(File), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Updater), Member = "CheckForDatasUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.Localization+<StringsInit>d__27"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<StringsInit>d__27&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 11)]
		[CallsUnknownMethods(Count = 19)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PostInitCards>d__39 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private Locale <curLang>5__2; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Manager), Member = "InitCardLocalization", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 5)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StringsInit>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Byte[] moFile; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.Localization+<ChangeLocale>d__36"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ChangeLocale>d__36&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Catalog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Catalog), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Tips), Member = "Init", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public static readonly Locale DefaultLanguage; //Field offset: 0x0
	public static Locale CurrentLanguage; //Field offset: 0x4
	public static Locale CurrentCardLanguage; //Field offset: 0x8
	[CompilerGenerated]
	private static Catalog <Strings>k__BackingField; //Field offset: 0x10

	public static List<String> DuelRuleNames
	{
		[CalledBy(Type = typeof(HostSettings), Member = "ResetSelectors", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HostSettings), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Localization), Member = "get_DuelRuleNamesLocal", ReturnType = typeof(System.Collections.Generic.List`1<System.String>))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Localization), Member = "GetCrudeLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(General), Member = "ReplaceFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 10)]
		 get { } //Length: 1058
	}

	public static List<String> DuelRuleNamesLocal
	{
		[CalledBy(Type = typeof(HostSettings), Member = "ResetSelectors", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HostSettings), Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Localization), Member = "get_DuelRuleNames", ReturnType = typeof(System.Collections.Generic.List`1<System.String>))]
		[Calls(Type = typeof(Localization), Member = "GetCrudeLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(General), Member = "ReplaceFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 330
	}

	public static List<String> GameModeNames
	{
		[CalledBy(Type = typeof(HostSettings), Member = "ResetSelectors", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HostSettings), Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Localization), Member = "GetCrudeLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(General), Member = "ReplaceFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 10)]
		 get { } //Length: 1058
	}

	public static bool IsLanguageUsingRTL
	{
		[CalledBy(Type = typeof(Template), Member = "DefineCardStrings", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Template), Member = "HandleRTL", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 58
	}

	public private static Catalog Strings
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 55
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 86
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	internal static bool <GetTypeLineString>g__hasType|26_0(CardType type, ref <>c__DisplayClass26_0 unnamed_param_1) { }

	[AsyncStateMachine(typeof(<CardLocaleInit>d__37))]
	[CalledBy(Type = "Manager.Helper+<DatabaseDeserialize>d__126", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CardLocaleInit>d__37)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CardLocaleInit>d__37&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task CardLocaleInit() { }

	[AsyncStateMachine(typeof(<ChangeCardLocale>d__38))]
	[CalledBy(Type = "Scenes.Menu.SettingsMenu+<ApplyOthers>d__139", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ChangeCardLocale>d__38)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ChangeCardLocale>d__38&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task ChangeCardLocale(Locale lang) { }

	[AsyncStateMachine(typeof(<ChangeLocale>d__36))]
	[CalledBy(Type = "Scenes.Menu.SettingsMenu+<ApplyOthers>d__139", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ChangeLocale>d__36)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ChangeLocale>d__36&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task ChangeLocale(Locale lang) { }

	[CalledBy(Type = typeof(Template), Member = "DefineCardStrings", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "HandleRTL", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TMP_Text), Member = "set_isRightToLeftText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "set_alignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAlignmentOptions)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void DefineRTLText(TextMeshProUGUI txt, bool enabled) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(General), Member = "ReplaceFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private static string FillLocale(string text, String[] args) { }

	[CalledBy(Type = typeof(HostSettings), Member = "ResetSelectors", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HostSettings), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Localization), Member = "get_DuelRuleNamesLocal", ReturnType = typeof(System.Collections.Generic.List`1<System.String>))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "GetCrudeLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(General), Member = "ReplaceFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public static List<String> get_DuelRuleNames() { }

	[CalledBy(Type = typeof(HostSettings), Member = "ResetSelectors", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HostSettings), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "get_DuelRuleNames", ReturnType = typeof(System.Collections.Generic.List`1<System.String>))]
	[Calls(Type = typeof(Localization), Member = "GetCrudeLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(General), Member = "ReplaceFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static List<String> get_DuelRuleNamesLocal() { }

	[CalledBy(Type = typeof(HostSettings), Member = "ResetSelectors", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HostSettings), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "GetCrudeLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(General), Member = "ReplaceFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public static List<String> get_GameModeNames() { }

	[CalledBy(Type = typeof(Template), Member = "DefineCardStrings", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "HandleRTL", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool get_IsLanguageUsingRTL() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static Catalog get_Strings() { }

	[CalledBy(Type = "Manager.Helper+<GetAsset>d__76`1", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper+<LoadAsset>d__66`1", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sound), Member = "EnumerateBGM", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[ContainsInvalidInstructions]
	public static string GetAssetTypeName(AssetType type) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "UpdateLanguage", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AttributeSelection), Member = "SetAttributeState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle), typeof(CardAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "UpdateSlotInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogCardHintAttribute), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogDeclareAttribute), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnDeclareAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnCardHint>d__92", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnHint>d__108", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "BuildPlainEntireCardText", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Template), Member = "BuildCardDescription", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Template), Member = "AttributeDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Template), Member = "DefineAttribute", ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	public static string GetAttributeName(CardAttribute atTribute, bool normalized = false) { }

	[CalledBy(Type = typeof(LobbyScreen), Member = "DisplayQueueRank", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(User), Member = "GetBadgeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardSet)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(User), Member = "get_OCGBadgeName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(User), Member = "get_TCGBadgeName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(User), Member = "get_DuelLinksBadgeName", ReturnType = typeof(string))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 8)]
	public static string GetBracketName(Bracket b, bool translate = true) { }

	[CalledBy(Type = typeof(LobbyScreen), Member = "UpdateSelectedRoomInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(RoomCard)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RoomData), Member = "GetFormatString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 5)]
	public static string GetCardSetString(CardSet cs) { }

	[CalledBy(Type = "Scenes.Battle.DuelZone+<>c", Member = "<GetRadialChainLabels>b__108_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainMethod)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DuelZone), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "OnClickChainIcon", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "OnCyclicChain", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "DefineChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool), typeof(ChainMethod)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "DefineChainIcon", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "<Start>b__88_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 5)]
	public static string GetChainMethodName(ChainMethod m) { }

	[CallerCount(Count = 83)]
	[ContainsInvalidInstructions]
	public static string GetClientMessage(byte code) { }

	[CalledBy(Type = typeof(ManualStatus), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManualStatus), Member = "SetCounterTab", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnAddCounter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(CounterTypes), typeof(ushort), typeof(ushort)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnRemoveCounter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(CounterTypes), typeof(ushort), typeof(ushort)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSelectCounter>d__169", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetCrudeLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(General), Member = "ReplaceFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 94)]
	public static string GetCounterName(CounterTypes type, bool appendCounter = true) { }

	[CalledBy(Type = typeof(Localization), Member = "get_DuelRuleNames", ReturnType = typeof(System.Collections.Generic.List`1<System.String>))]
	[CalledBy(Type = typeof(Localization), Member = "get_DuelRuleNamesLocal", ReturnType = typeof(System.Collections.Generic.List`1<System.String>))]
	[CalledBy(Type = typeof(Localization), Member = "get_GameModeNames", ReturnType = typeof(System.Collections.Generic.List`1<System.String>))]
	[CalledBy(Type = typeof(Localization), Member = "GetSpellTrapTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Localization), Member = "GetTypeLineString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Localization), Member = "GetDescriptionForGoods", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Localization), Member = "GetRarityName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Localization), Member = "GetTournamentMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TournyMode)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Localization), Member = "GetCounterName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CounterTypes), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Localization), Member = "GetRPSLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
	[CallerCount(Count = 39)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static string GetCrudeLocale(string text) { }

	[CalledBy(Type = "Scenes.Lobby.Shop+ShopItemData", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(string), typeof(ushort), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Shop), Member = "InitData", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "GetCrudeLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(General), Member = "ReplaceFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	public static string GetDescriptionForGoods(ushort goodId) { }

	[CalledBy(Type = typeof(LobbyScreen), Member = "UpdateSelectedRoomInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(RoomCard)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 4)]
	public static string GetDuelMode(DuelMode mode) { }

	[CalledBy(Type = typeof(Localization), Member = "GetExtraRuleName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 53)]
	public static string GetExtraRuleName(ExtraRules rule) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "GetExtraRuleName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExtraRules)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	public static string GetExtraRuleName(Enum rule) { }

	[CalledBy(Type = typeof(CardOptionList), Member = "OnActivate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnCardShuffled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Localization), Member = "GetLocationName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation), typeof(sbyte)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Game.DuelManager+<OnSelectEffectYn>d__171", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelManager), Member = "PostSelectChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<Card.ClientCard, System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>>), typeof(bool), typeof(bool), typeof(ClientCard), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	public static string GetFieldZoneName(CardLocation loc) { }

	[CalledBy(Type = typeof(CardOptionList), Member = "OnActivate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnCardAttack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(ClientCard)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnCardTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(ClientCard)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(String[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
	[CalledBy(Type = "Game.DuelManager+<OnAttack>d__135", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelManager), Member = "PostSelectChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<Card.ClientCard, System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>>), typeof(bool), typeof(bool), typeof(ClientCard), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(General), Member = "ReplaceFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CardLocalization), Member = "GetCardString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(String&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[Calls(Type = typeof(ChatWindow), Member = "ParseCardInMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card), typeof(String&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static string GetGameDescription(int description, int number = -1, int number2 = -1, String[] text) { }

	[CalledBy(Type = typeof(LogManager), Member = "GetChainingEventString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Game.DuelManager+<OnSelectEffectYn>d__171", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSelectCounter>d__169", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnRecover>d__131", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnDraw>d__114", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnDamage>d__130", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnAttackDisabled>d__137", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnAnnounceNumber>d__189", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnChaining", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(ClientCard), typeof(int), typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnMissedTiming", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnCardAttackDisabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnLPUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnLPRecover", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnLPDamage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(int), typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnCardDraw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(bool), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnDeclareCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
	public static string GetGameDescription(int description, int number, String[] text) { }

	[CalledBy(Type = typeof(LogManager), Member = "OnCardAttack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(ClientCard)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnAttack>d__135", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnChained>d__103", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnReloadField>d__76", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSelectPlace>d__176", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelManager), Member = "ManualSelectPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(bool), typeof(Action)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
	public static string GetGameDescription(int description, String[] text) { }

	[CalledBy(Type = typeof(LifePoints), Member = "OnClickLPBar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "BuildCardDescription", ReturnType = typeof(string))]
	[CalledBy(Type = "Game.DuelManager+<OnSelectYesNo>d__184", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSelectSum>d__182", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSelectOption>d__173", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSelectCard>d__164", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnAnnounceRace>d__190", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnHint>d__108", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnAnnounceAttrib>d__185", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogOpSelection), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnChaining", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(ClientCard), typeof(int), typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnOpSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "GetChainingEventString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Game.DuelManager+<OnAnnounceCard>d__188", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public static string GetGameDescription(int description) { }

	[CallerCount(Count = 188)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsInvalidInstructions]
	public static string GetGameMessage(int msgId) { }

	[CalledBy(Type = typeof(RoomCard), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPooledData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RoomData), Member = "GetModeString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 4)]
	public static string GetGameModeName(DuelMode mode) { }

	[CalledBy(Type = typeof(HotkeyInput), Member = "UpdateData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys), typeof(int), typeof(HotkeyType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	public static string GetHotkeyName(Hotkeys hotkey) { }

	[CalledBy(Type = typeof(Template), Member = "DefineArrows", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	public static string GetLinkMarkerName(CardLinkMarker marker) { }

	[CalledBy(Type = typeof(Shop), Member = "OnBuy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "DefineCardStrings", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSelectSum>d__182", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSelectPlace>d__176", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass182_0", Member = "<OnSelectSum>b__3", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass164_0", Member = "<OnSelectCard>g__finishClick|0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogNewTurn), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Network), Member = "OnSystemMsg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnAddCounter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(CounterTypes), typeof(ushort), typeof(ushort)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnNewTurn", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnCardShuffled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnCardDraw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(bool), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldCenter), Member = "UpdateTurn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldCenter), Member = "OnLeftPhaseButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnRemoveCounter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(CounterTypes), typeof(ushort), typeof(ushort)}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(General), Member = "ReplaceFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetCrudeLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public static string GetLocale(string text, int val, String[] args) { }

	[CallerCount(Count = 916)]
	[Calls(Type = typeof(Localization), Member = "GetCrudeLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(General), Member = "ReplaceFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public static string GetLocale(string text, String[] args) { }

	[CalledBy(Type = typeof(SettingsMenu), Member = "InitOthers", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<Init>d__15), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Manager+<InitCardLocalization>d__47", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public static string GetLocaleName(Locale loc, byte mode) { }

	[CalledBy(Type = "Game.DuelManager+<OnCardTarget>d__195", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnMove>d__133", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetFieldZoneName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ClientCard), Member = "IsUnplayableZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(sbyte), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	public static string GetLocationName(CardLocation loc, sbyte seq) { }

	[CalledBy(Type = typeof(LogNewPhase), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	public static string GetPhaseIconName(DuelPhase ph, bool opp) { }

	[CalledBy(Type = typeof(PhaseChange), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PhaseSelect), Member = "UpdateLanguage", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PhaseSelect), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnNewPhase", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogNewPhase), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 6)]
	public static string GetPhaseName(DuelPhase ph, bool appendPhase) { }

	[CalledBy(Type = "Game.DuelManager+<OnSelectChain>d__166", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	public static string GetPhaseString(DuelPhase ph) { }

	[CalledBy(Type = typeof(LogManager), Member = "OnCardPositionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(CardPosition), typeof(CardPosition)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnMove>d__133", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[ContainsInvalidInstructions]
	public static string GetPositionString(CardPosition pos) { }

	[CalledBy(Type = typeof(ClientCard), Member = "GetParsedValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Template), Member = "DefineStatus", ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	public static string GetPowerString(int power) { }

	[CalledBy(Type = typeof(LobbyScreen), Member = "FixedUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 4)]
	public static string GetQueueName(DuelQueue q) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "UpdateLanguage", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldSlot), Member = "UpdateSlotInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RaceSelection), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogCardEntry), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardDataLog)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogCardHintRace), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogDeclareRace), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnDeclareRace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardRace)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Localization), Member = "GetTypeLineString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Game.DuelManager+<OnCardHint>d__92", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnHint>d__108", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "BuildCardDescription", ReturnType = typeof(string))]
	[CallerCount(Count = 42)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 8)]
	public static string GetRaceName(CardRace race, bool normalized = false) { }

	[CalledBy(Type = typeof(BoxSlot), Member = "SetRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DisplayCard), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsInvalidInstructions]
	public static string GetRarityIconName(Rarity rar) { }

	[CalledBy(Type = typeof(Shop), Member = "InitData", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckSelection), Member = "OnClickSleeve", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetCrudeLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(General), Member = "ReplaceFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 16)]
	public static string GetRarityName(Rarity rar) { }

	[CalledBy(Type = typeof(LogManager), Member = "OnJankenResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "GetCrudeLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(General), Member = "ReplaceFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 4)]
	public static string GetRPSLocale(byte rps) { }

	[CalledBy(Type = typeof(GameRoom), Member = "UpdateRoomInfo", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "UpdateSelectedRoomInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(RoomCard)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RoomCard), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPooledData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 5)]
	public static string GetRuleName(DuelRules rule) { }

	[CalledBy(Type = "Manager.Background+<SetBG>d__28", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Customization), Member = "StructureThemeDirectories", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Customization), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Customization), Member = "GetCustomBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneType), typeof(FileInfo&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Customization), Member = "GetCustomBGM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneType), typeof(FileInfo&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Sound), Member = "EnumerateBGM", ReturnType = typeof(void))]
	[CalledBy(Type = "Data.CustomTheme+<LoadThemeResourcesFromDisk>d__38", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[ContainsInvalidInstructions]
	public static string GetSceneName(SceneType type) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "UpdateLanguage", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnSortTypeButton", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsInvalidInstructions]
	public static string GetSortName(SortTypes type) { }

	[CalledBy(Type = typeof(Localization), Member = "GetSpellTrapTypeNameSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Localization), Member = "GetTypeLineString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetCrudeLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(General), Member = "ReplaceFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public static string GetSpellTrapTypeName(CardType type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "GetSpellTrapTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetSpellTrapTypeSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	public static string GetSpellTrapTypeNameSprite(CardType type) { }

	[CalledBy(Type = typeof(Localization), Member = "GetSpellTrapTypeNameSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Localization), Member = "GetTypeLineString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Template), Member = "DefineStars", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Helper), Member = "GetTMProSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(string))]
	[ContainsUnimplementedInstructions]
	public static string GetSpellTrapTypeSprite(CardType type) { }

	[CalledBy(Type = typeof(Network), Member = "OnSystemMsg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	public static string GetSystemMessage(byte msgId) { }

	[CalledBy(Type = typeof(LobbyScreen), Member = "UpdateSelectedRoomInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(RoomCard)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetCrudeLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(General), Member = "ReplaceFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	public static string GetTournamentMode(TournyMode tm) { }

	[CalledBy(Type = typeof(DisplayCard), Member = "SetupBox", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "DefineCardTypes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "BuildPlainEntireCardText", ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StringBuilder), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CardArchetype), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardArchetype)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(Localization), Member = "GetRaceName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardRace), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(General), Member = "ReplaceFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetCrudeLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TextDataManager), Member = "TryGetCharName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(String&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetSpellTrapTypeSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetSpellTrapTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Card), Member = "HasCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Category)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(ClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 48)]
	public static string GetTypeLineString(Template c, bool dynamic) { }

	[CalledBy(Type = typeof(DuelEnd), Member = "UpdateLanguage", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	public static string GetVictoryMessage(DuelEndReason reason) { }

	[AsyncStateMachine(typeof(<Init>d__15))]
	[CalledBy(Type = "Manager.Helper+<DatabaseDeserialize>d__126", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Init>d__15)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Init>d__15&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task Init() { }

	[AsyncStateMachine(typeof(<LoadNewLanguage>d__16))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadNewLanguage>d__16)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadNewLanguage>d__16&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Task LoadNewLanguage(string lang) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Tips), Member = "Init", ReturnType = typeof(void))]
	private static void PostInit() { }

	[AsyncStateMachine(typeof(<PostInitCards>d__39))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<PostInitCards>d__39)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<PostInitCards>d__39&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static Task PostInitCards() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private static void set_Strings(Catalog value) { }

	[AsyncStateMachine(typeof(<StringsInit>d__27))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<StringsInit>d__27)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<StringsInit>d__27&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Task StringsInit(Byte[] moFile) { }

}

