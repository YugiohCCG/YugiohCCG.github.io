namespace Manager;

public class Background : MonoBehaviour
{
	[CompilerGenerated]
	private struct <LoadLiveEnv>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string name; //Field offset: 0x20
		private ResourceRequest <rr>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Resources), Member = "LoadAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ResourceRequest))]
		[Calls(Type = typeof(AsyncExtensions), Member = "Await", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Object), Member = "Instantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(Object))]
		[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Transform), Member = "SetSiblingIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 9)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetBG>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public FileInfo url; //Field offset: 0x28
		private TaskAwaiter<ValueTuple`2<Boolean, Sprite>> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Customization), Member = "GetCustomImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.ValueTuple`2<System.Boolean, UnityEngine.Sprite>>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(Localization), Member = "GetSceneName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneType)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Background), Member = "DefineRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Background), Member = "DefineDynamicBG", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 6)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public static VideoPlayer DynamicBG; //Field offset: 0x0
	private const string SKYBOX_ROT = "_Rotation"; //Field offset: 0x0
	public static BackgroundType BGMethod; //Field offset: 0x8
	public static Image StaticBG; //Field offset: 0x10
	public static Canvas StaticCanvas; //Field offset: 0x18
	public static CanvasRenderer StaticRenderer; //Field offset: 0x20
	public static CanvasScaler StaticScaler; //Field offset: 0x28
	public static Background Instance; //Field offset: 0x30
	public static readonly String[] VideoFormatExtensions; //Field offset: 0x38
	public static readonly String[] ImageFormatExtensions; //Field offset: 0x40
	private static Dictionary<SceneType, FullScreenAnimation> RENDERED_BGS; //Field offset: 0x48
	public static SceneType CurrentBG; //Field offset: 0x50
	private static BackgroundType DefinedBGMethod; //Field offset: 0x54
	[Header("Rendered BGs")]
	public Canvas CameraCanvas; //Field offset: 0x20
	public FullScreenAnimation LoadingBG; //Field offset: 0x28
	public FullScreenAnimation MenuBG; //Field offset: 0x30
	public FullScreenAnimation SidingBG; //Field offset: 0x38
	public FullScreenAnimation DeckBG; //Field offset: 0x40
	private Material DefaultSkybox; //Field offset: 0x48

	public static bool IsDynamicBG
	{
		[CalledBy(Type = typeof(Customization), Member = "CheckDirBG", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 82
	}

	public static bool IsNoneBG
	{
		[CalledBy(Type = typeof(DuelField), Member = "GetReplacementSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Sprite))]
		[CalledBy(Type = typeof(DuelField), Member = "GetTextureReplaceName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CallerCount(Count = 3)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 82
	}

	public static bool IsRenderedBG
	{
		[CalledBy(Type = typeof(DuelField), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DuelField), Member = "get_CanEnable", ReturnType = typeof(bool))]
		[CalledBy(Type = "Manager.Helper+<LoadAsset>d__66`1", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 82
	}

	public static bool IsRenderingBG
	{
		[CalledBy(Type = typeof(DuelField), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DuelField), Member = "get_CanEnable", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 82
	}

	public static bool IsStaticBG
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 82
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 19)]
	private static Background() { }

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Background() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ByteEnum, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ByteEnum", typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	private void Awake() { }

	[CalledBy(Type = typeof(<SetBG>d__28), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Background), Member = "SetBG", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VideoClip), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VideoPlayer), Member = "set_targetCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Helper), Member = "get_MainCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VideoPlayer), Member = "set_clip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VideoClip)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VideoClip), Member = "get_originalPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(VideoPlayer), Member = "set_url", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VideoPlayer), Member = "set_source", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VideoSource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VideoPlayer), Member = "get_url", ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VideoPlayer), Member = "get_clip", ReturnType = typeof(VideoClip))]
	[Calls(Type = typeof(VideoPlayer), Member = "get_source", ReturnType = typeof(VideoSource))]
	[Calls(Type = typeof(VideoPlayer), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VideoPlayer), Member = "Play", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void DefineDynamicBG(object video) { }

	[CalledBy(Type = typeof(<SetBG>d__28), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Background), Member = "SetBG", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VideoClip), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Background), Member = "SetBG", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Background), Member = "SetRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundType), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Background), Member = "SetSceneBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Background), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VideoPlayer), Member = "Stop", ReturnType = typeof(void))]
	[Calls(Type = typeof(Background), Member = "SetRenderedState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CustomTheme), Member = "ReloadTexturizables", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static void DefineRender(BackgroundType render) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderSettings), Member = "get_skybox", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "GetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void FixedUpdate() { }

	[CalledBy(Type = typeof(Customization), Member = "CheckDirBG", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool get_IsDynamicBG() { }

	[CalledBy(Type = typeof(DuelField), Member = "GetReplacementSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Sprite))]
	[CalledBy(Type = typeof(DuelField), Member = "GetTextureReplaceName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	public static bool get_IsNoneBG() { }

	[CalledBy(Type = typeof(DuelField), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelField), Member = "get_CanEnable", ReturnType = typeof(bool))]
	[CalledBy(Type = "Manager.Helper+<LoadAsset>d__66`1", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	public static bool get_IsRenderedBG() { }

	[CalledBy(Type = typeof(DuelField), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelField), Member = "get_CanEnable", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool get_IsRenderingBG() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool get_IsStaticBG() { }

	[AsyncStateMachine(typeof(<LoadLiveEnv>d__24))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadLiveEnv>d__24)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadLiveEnv>d__24&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Task LoadLiveEnv(string name) { }

	[AsyncStateMachine(typeof(<SetBG>d__28))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SetBG>d__28)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SetBG>d__28&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void SetBG(FileInfo url) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Background), Member = "DefineRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void SetBG(Sprite bg, object callback = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Background), Member = "DefineRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Background), Member = "DefineDynamicBG", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	public static void SetBG(VideoClip video, object callback = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VideoPlayer), Member = "Stop", ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void SetDynamicState(bool state) { }

	[CalledBy(Type = typeof(Background), Member = "DefineRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Background), Member = "SetSceneBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelField), Member = "ToggleState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private static void SetRenderedState(bool state) { }

	[CalledBy(Type = "Scenes.Menu.SettingsMenu+<ApplyGraphics>d__131", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Background), Member = "DefineRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Background), Member = "SetSceneBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	public static void SetRenderer(BackgroundType renderType, bool startUp = false) { }

	[CalledBy(Type = typeof(Background), Member = "SetRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundType), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Background), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper+<ChangeScene>d__79", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper+<Start>d__108", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Helper), Member = "ShowLoadingScreen", ReturnType = typeof(void))]
	[CalledBy(Type = "Data.CustomTheme+<PostThemeSelectionOperations>d__30", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Customization), Member = "GetCustomBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneType), typeof(FileInfo&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Background), Member = "DefineRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Background), Member = "SetRenderedState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SetBG>d__28)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SetBG>d__28&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void SetSceneBackground(bool force = false) { }

	[CalledBy(Type = typeof(DuelField), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelField), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderSettings), Member = "set_skybox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	public void SetSkybox(Material sb = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void SetStaticState(bool state) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderSettings), Member = "get_skybox", ReturnType = typeof(Material))]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Background), Member = "DefineRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Background), Member = "SetSceneBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void Start() { }

}

