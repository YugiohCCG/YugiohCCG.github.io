namespace Scenes.General;

public class LoadingInfo : MonoBehaviour
{
	[CompilerGenerated]
	private struct <Create>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public bool forLogin; //Field offset: 0x20
		private ResourceRequest <rr>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter<LoadingInfo> <>u__2; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Resources), Member = "LoadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ResourceRequest))]
		[Calls(Type = typeof(AsyncExtensions), Member = "Await", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncExtensions), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Transform), typeof(bool)}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 11)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public static LoadingInfo Instance; //Field offset: 0x0
	private static object LoadingInfoPrefab; //Field offset: 0x8
	public Button QuitButton; //Field offset: 0x20
	public Image BaseFrame; //Field offset: 0x28
	public Image MajorBar; //Field offset: 0x30
	public Image MinorBar; //Field offset: 0x38
	public TextMeshProUGUI MajorProgress; //Field offset: 0x40
	public TextMeshProUGUI MinorProgress; //Field offset: 0x48
	public TextMeshProUGUI ActionProgress; //Field offset: 0x50
	public int TotalCount; //Field offset: 0x58
	public int CurrentCount; //Field offset: 0x5C
	public bool ForLogin; //Field offset: 0x60

	public static GameObject ObjectInstance
	{
		[CalledBy(Type = "Manager.ImageHandler+<Initialize>d__5", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Network+<>c", Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Network+<EndConnection>d__39", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Network+<HandlePacket>d__73", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Updater+<DownloadFile>d__99", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Updater+<HandleGameUpdate>d__98", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Updater+<HandleLauncherUpdate>d__92", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 148
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public LoadingInfo() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "QuitGame", ReturnType = typeof(void))]
	[Calls(Type = typeof(Network), Member = "EndConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <OnClickQuitButton>b__16_0(bool o) { }

	[CallerCount(Count = 0)]
	private float CalculateProgress(float cur, float max) { }

	[AsyncStateMachine(typeof(<Create>d__14))]
	[CalledBy(Type = "Manager.ImageHandler+<Initialize>d__5", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<PostConnection>d__34", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<DoUpdate>d__35", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<DownloadFile>d__99", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__14)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__14&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task Create(bool forLogin = false) { }

	[CalledBy(Type = "Manager.ImageHandler+<Initialize>d__5", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<>c", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<EndConnection>d__39", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<HandlePacket>d__73", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<DownloadFile>d__99", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<HandleGameUpdate>d__98", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<HandleLauncherUpdate>d__92", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[CallsUnknownMethods(Count = 1)]
	public static GameObject get_ObjectInstance() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "GetClientMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(OptionBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>), typeof(string), typeof(Template)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnClickQuitButton() { }

	[CalledBy(Type = "Manager.Updater+<DoUpdate>d__35", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetActionText(string text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEvent), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LoadingInfo), Member = "UpdateMajorProgress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LoadingInfo), Member = "UpdateMinorProgress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private void Start() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public void UpdateActionProgress(ulong cur, float amt) { }

	[CalledBy(Type = "Manager.ImageHandler+<Initialize>d__5", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LoadingInfo), Member = "UpdateMajorProgress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	public void UpdateMajorProgress(float cur) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	public void UpdateMajorProgress() { }

	[CalledBy(Type = "Manager.Updater+<DoUpdate>d__35", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LoadingInfo), Member = "UpdateMajorProgress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	public void UpdateMajorProgress(float cur, float max) { }

	[CalledBy(Type = typeof(LoadingInfo), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LoadingInfo), Member = "UpdateMajorProgress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LoadingInfo), Member = "UpdateMajorProgress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<>c__DisplayClass99_0", Member = "<DownloadFile>b__0", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Image), Member = "set_fillAmount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void UpdateMajorProgress(float progress, bool checking) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LoadingInfo), Member = "UpdateMinorProgress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	public void UpdateMinorProgress() { }

	[CalledBy(Type = "Manager.ImageHandler+<InitialUpdateAsset>d__10", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	public void UpdateMinorProgress(float cur, float max) { }

	[CalledBy(Type = typeof(LoadingInfo), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LoadingInfo), Member = "UpdateMinorProgress", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<>c__DisplayClass32_0", Member = "<DownloadAssetBundle>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<>c__DisplayClass99_0", Member = "<DownloadFile>b__0", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Image), Member = "set_fillAmount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateMinorProgress(float progress) { }

}

