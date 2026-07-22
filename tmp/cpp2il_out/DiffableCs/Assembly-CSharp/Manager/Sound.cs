namespace Manager;

public class Sound : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public AudioSource source; //Field offset: 0x10
		public AudioClip sound; //Field offset: 0x18
		public float vol; //Field offset: 0x20

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass31_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AudioSource), Member = "get_clip", ReturnType = typeof(AudioClip))]
		[Calls(Type = typeof(Sound), Member = "DefineTimeForNextTrack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AudioSource), Member = "Play", ReturnType = typeof(void))]
		[Calls(Type = typeof(DOTweenModuleAudio), Member = "DOFade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioSource), typeof(float), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>))]
		[Calls(Type = typeof(Sound), Member = "RemoveClipFromMemory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void <PlayBGM>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass42_0
	{
		public string name; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass42_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal bool <CanPlaySFX>b__0(string sfx) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass43_0
	{
		public string sn; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass43_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal bool <EnumerateBGM>b__0(string x) { }

	}

	[CompilerGenerated]
	private struct <LoadCustomClip>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<AudioClip> <>t__builder; //Field offset: 0x8
		public string url; //Field offset: 0x20
		public string name; //Field offset: 0x28
		private UnityWebRequest <www>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sound), Member = "GetClipType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(AudioType))]
		[Calls(Type = typeof(UnityWebRequestMultimedia), Member = "GetAudioClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(AudioType)}, ReturnType = typeof(UnityWebRequest))]
		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
		[Calls(Type = typeof(AsyncExtensions), Member = "Await", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_result", ReturnType = typeof(Result))]
		[Calls(Type = typeof(DownloadHandlerAudioClip), Member = "GetContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest)}, ReturnType = typeof(AudioClip))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_error", ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 15)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadCustomClip>d__39 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<AudioClip> <>t__builder; //Field offset: 0x8
		public FileInfo url; //Field offset: 0x20
		private TaskAwaiter<AudioClip> <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(HttpUtility), Member = "UrlPathEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Sound), Member = "LoadCustomClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(System.Threading.Tasks.Task`1<UnityEngine.AudioClip>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 6)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PlaySceneMusic>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public bool force; //Field offset: 0x28
		private TaskAwaiter<AudioClip> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Customization), Member = "GetCustomBGM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneType), typeof(FileInfo&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ByteEnum, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ByteEnum", typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Enumerable), Member = "ElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(int)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.Sound+<PlaySound>d__41"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<PlaySound>d__41&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Sound), Member = "LoadCustomClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileInfo)}, ReturnType = typeof(System.Threading.Tasks.Task`1<UnityEngine.AudioClip>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(Sound), Member = "PlayBGM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 6)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PlaySound>d__41 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public SoundTypes type; //Field offset: 0x28
		public string name; //Field offset: 0x30
		private TaskAwaiter<AudioClip> <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Customization), Member = "GetCustomSFX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileInfo&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Sound), Member = "LoadCustomClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileInfo)}, ReturnType = typeof(System.Threading.Tasks.Task`1<UnityEngine.AudioClip>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(Sound), Member = "PlaySFX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 10)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PlayStreamedSound>d__40 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public string media; //Field offset: 0x28
		public SoundTypes type; //Field offset: 0x30
		private TaskAwaiter<AudioClip> <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sound), Member = "LoadCustomClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(System.Threading.Tasks.Task`1<UnityEngine.AudioClip>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(Sound), Member = "PlayBGM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Sound), Member = "PlaySFX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnloadSong>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public float wait; //Field offset: 0x28
		public AudioClip sound; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitForSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Sound), Member = "RemoveClipFromMemory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const string CUSTOM_PREFIX = "[Custom]"; //Field offset: 0x0
	private const byte SFX_FRAME_SIZE = 3; //Field offset: 0x0
	public static AudioListener MainListener; //Field offset: 0x0
	public static Sound Instance; //Field offset: 0x8
	private static bool _soundDisabled; //Field offset: 0x10
	private static readonly Dictionary<SceneType, String[]> BGMList; //Field offset: 0x18
	public static bool SoundDisabledOnBackground; //Field offset: 0x20
	private static bool _soundMuted; //Field offset: 0x21
	public static readonly String[] SoundFormatExtensions; //Field offset: 0x28
	public static SceneType CurrentBGM; //Field offset: 0x30
	public static bool DisableSFX; //Field offset: 0x31
	private static List<String> SFXOnThisFrame; //Field offset: 0x38
	private static DateTime NextTrackTime; //Field offset: 0x40
	public static bool KeepBGMLoopingSameTrack; //Field offset: 0x48
	public static TrackMix BGMMix; //Field offset: 0x49
	private static readonly float FadeTime; //Field offset: 0x4C
	public AudioSource SFXSource; //Field offset: 0x20
	public AudioSource BGMSource; //Field offset: 0x28
	private byte SFXFrameCount; //Field offset: 0x30

	private static bool HasSFXPlayedOnThisFrame
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
		private get { } //Length: 99
	}

	public static bool SoundDisabled
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
		[CalledBy(Type = typeof(SettingsMenu), Member = "ApplySound", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Helper), Member = "LoadPrefs", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AudioSource), Member = "set_mute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Sound), Member = "PlaySceneMusic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AudioSource), Member = "Stop", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 764
	}

	public static bool SoundMuted
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
		[CalledBy(Type = typeof(Helper), Member = "OnFocusChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AudioSource), Member = "set_mute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 494
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	private static Sound() { }

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Sound() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(AudioSource), Member = "set_volume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void Awake() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static bool CanPlaySFX(string name) { }

	[CalledBy(Type = typeof(<>c__DisplayClass31_0), Member = "<PlayBGM>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sound), Member = "PlayBGM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(AudioClip), Member = "get_length", ReturnType = typeof(float))]
	[Calls(Type = typeof(DateTime), Member = "AddSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
	[CallsUnknownMethods(Count = 1)]
	private static void DefineTimeForNextTrack(AudioClip clip) { }

	[CalledBy(Type = "Manager.Helper+<PostLoading>d__113", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetAssetTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AssetBundle), Member = "GetAllAssetNames", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(Localization), Member = "GetSceneName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneType)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ByteEnum, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ByteEnum", typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 14)]
	public static void EnumerateBGM() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
	[Calls(Type = typeof(Sound), Member = "PlaySceneMusic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	private void FixedUpdate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	private static bool get_HasSFXPlayedOnThisFrame() { }

	[CallerCount(Count = 0)]
	public static bool get_SoundDisabled() { }

	[CallerCount(Count = 0)]
	public static bool get_SoundMuted() { }

	[CalledBy(Type = typeof(Sound), Member = "SetVolume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sound), Member = "GetVolume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static AudioSource GetAudioSource(SoundTypes type) { }

	[CalledBy(Type = typeof(<LoadCustomClip>d__38), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sound), Member = "GetClipType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileInfo)}, ReturnType = typeof(AudioType))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	private static AudioType GetClipType(string ext) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileSystemInfo), Member = "get_Extension", ReturnType = typeof(string))]
	[Calls(Type = typeof(Sound), Member = "GetClipType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(AudioType))]
	[CallsUnknownMethods(Count = 1)]
	private static AudioType GetClipType(FileInfo file) { }

	[CalledBy(Type = typeof(SettingsMenu), Member = "InitSound", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Sound), Member = "GetAudioSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes)}, ReturnType = typeof(AudioSource))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(AudioSource), Member = "get_volume", ReturnType = typeof(float))]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	public static float GetVolume(SoundTypes type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void LateUpdate() { }

	[AsyncStateMachine(typeof(<LoadCustomClip>d__38))]
	[CalledBy(Type = typeof(<LoadCustomClip>d__39), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<PlayStreamedSound>d__40), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadCustomClip>d__38)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadCustomClip>d__38&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static Task<AudioClip> LoadCustomClip(string url, string name) { }

	[AsyncStateMachine(typeof(<LoadCustomClip>d__39))]
	[CalledBy(Type = typeof(<PlaySceneMusic>d__35), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<PlaySound>d__41), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadCustomClip>d__39)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadCustomClip>d__39&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Task<AudioClip> LoadCustomClip(FileInfo url) { }

	[CalledBy(Type = typeof(<PlaySceneMusic>d__35), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<PlayStreamedSound>d__40), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AudioSource), Member = "get_clip", ReturnType = typeof(AudioClip))]
	[Calls(Type = typeof(General), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip), typeof(AudioClip), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(AudioSource), Member = "get_volume", ReturnType = typeof(float))]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(DOTweenModuleAudio), Member = "DOFade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioSource), typeof(float), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>))]
	[Calls(Type = typeof(Sound), Member = "RemoveClipFromMemory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Sound), Member = "DefineTimeForNextTrack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private static void PlayBGM(AudioClip sound, object callBack = null) { }

	[AsyncStateMachine(typeof(<PlaySceneMusic>d__35))]
	[CalledBy(Type = "Manager.Helper+<ChangeScene>d__79", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sound), Member = "set_SoundDisabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sound), Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Data.CustomTheme+<PostThemeSelectionOperations>d__30", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<PlaySceneMusic>d__35)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<PlaySceneMusic>d__35&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void PlaySceneMusic(bool force = false) { }

	[CalledBy(Type = typeof(<PlaySound>d__41), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<PlayStreamedSound>d__40), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AudioSource), Member = "PlayOneShot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AudioClip), Member = "get_length", ReturnType = typeof(float))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<UnloadSong>d__24)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<UnloadSong>d__24&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private static void PlaySFX(AudioClip sound, object callBack = null) { }

	[AsyncStateMachine(typeof(<PlaySound>d__41))]
	[CallerCount(Count = 68)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<PlaySound>d__41)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<PlaySound>d__41&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void PlaySound(SoundTypes type, string name) { }

	[AsyncStateMachine(typeof(<PlayStreamedSound>d__40))]
	[CalledBy(Type = "Manager.Network+<HandlePacket>d__73", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<PlayStreamedSound>d__40)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<PlayStreamedSound>d__40&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void PlayStreamedSound(SoundTypes type, string media) { }

	[CalledBy(Type = typeof(<>c__DisplayClass31_0), Member = "<PlayBGM>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<UnloadSong>d__24), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sound), Member = "PlayBGM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Resources), Member = "UnloadAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void RemoveClipFromMemory(AudioClip sound) { }

	[CalledBy(Type = typeof(SettingsMenu), Member = "ApplySound", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Helper), Member = "LoadPrefs", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AudioSource), Member = "set_mute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Sound), Member = "PlaySceneMusic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AudioSource), Member = "Stop", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void set_SoundDisabled(bool value) { }

	[CalledBy(Type = typeof(Helper), Member = "OnFocusChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AudioSource), Member = "set_mute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void set_SoundMuted(bool value) { }

	[CalledBy(Type = typeof(SettingsMenu), Member = "<Start>b__126_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SettingsMenu), Member = "<Start>b__126_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Sound), Member = "GetAudioSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes)}, ReturnType = typeof(AudioSource))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ShortcutExtensions), Member = "DOComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AudioSource), Member = "set_volume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void SetVolume(SoundTypes type, float volume) { }

	[AsyncStateMachine(typeof(<UnloadSong>d__24))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<UnloadSong>d__24)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<UnloadSong>d__24&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static void UnloadSong(AudioClip sound, float wait = 0) { }

}

