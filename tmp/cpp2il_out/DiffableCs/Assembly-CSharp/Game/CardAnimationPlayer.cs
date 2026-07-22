namespace Game;

public class CardAnimationPlayer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public FileInfo fi; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass28_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal bool <FileMatch>b__0(string fn) { }

	}

	[CompilerGenerated]
	private struct <Animate>d__55 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public int id; //Field offset: 0x28
		public int extraData; //Field offset: 0x2C
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(CardAnimationPlayer), Member = "ReleaseSemaphore", ReturnType = typeof(void))]
		[Calls(Type = typeof(CardAnimationPlayer), Member = "Play", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.CardAnimationPlayer+<LoadSkeleton>d__38"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadSkeleton>d__38&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.CardAnimationPlayer+<BuildSkeleton>d__39"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<BuildSkeleton>d__39&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CardAnimationPlayer), Member = "InitData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SemaphoreSlim), Member = "WaitAsync", ReturnType = typeof(Task))]
		[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 26)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <BuildSkeleton>d__39 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public CardAnimationPlayer <>4__this; //Field offset: 0x20
		private TextAsset <atlasTxt>5__2; //Field offset: 0x28
		private TextAsset <skeletonJson>5__3; //Field offset: 0x30
		private TaskAwaiter<TextAsset> <>u__1; //Field offset: 0x38
		private TaskAwaiter<Texture2D[]> <>u__2; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(SkeletonDataAsset), Member = "CreateRuntimeInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAsset), typeof(AtlasAssetBase), typeof(bool), typeof(float)}, ReturnType = typeof(SkeletonDataAsset))]
		[Calls(Type = typeof(SpineAtlasAsset), Member = "CreateRuntimeInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAsset), typeof(Texture2D[]), typeof(Material), typeof(bool)}, ReturnType = typeof(SpineAtlasAsset))]
		[Calls(Type = typeof(CardAnimationPlayer), Member = "GetTextures", ReturnType = typeof(System.Threading.Tasks.Task`1<Texture2D[]>))]
		[Calls(Type = typeof(CardAnimationPlayer), Member = "GetSkeletonJson", ReturnType = typeof(System.Threading.Tasks.Task`1<UnityEngine.TextAsset>))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(CardAnimationPlayer), Member = "GetAtlasText", ReturnType = typeof(System.Threading.Tasks.Task`1<UnityEngine.TextAsset>))]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 20)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetAtlasText>d__32 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<TextAsset> <>t__builder; //Field offset: 0x8
		public CardAnimationPlayer <>4__this; //Field offset: 0x20
		private TaskAwaiter<TextAsset> <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CardAnimationPlayer), Member = "get_SpineDir", ReturnType = typeof(DirectoryInfo))]
		[Calls(Type = typeof(DirectoryInfo), Member = "EnumerateFiles", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileInfo>))]
		[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "TSource")]
		[Calls(Type = typeof(CardAnimationPlayer), Member = "GetTextAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileInfo)}, ReturnType = typeof(System.Threading.Tasks.Task`1<UnityEngine.TextAsset>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 6)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetSkeletonJson>d__33 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<TextAsset> <>t__builder; //Field offset: 0x8
		public CardAnimationPlayer <>4__this; //Field offset: 0x20
		private TaskAwaiter<TextAsset> <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CardAnimationPlayer), Member = "get_SpineDir", ReturnType = typeof(DirectoryInfo))]
		[Calls(Type = typeof(DirectoryInfo), Member = "EnumerateFiles", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileInfo>))]
		[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "TSource")]
		[Calls(Type = typeof(CardAnimationPlayer), Member = "GetTextAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileInfo)}, ReturnType = typeof(System.Threading.Tasks.Task`1<UnityEngine.TextAsset>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 6)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetTextAsset>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<TextAsset> <>t__builder; //Field offset: 0x8
		public FileInfo file; //Field offset: 0x20
		private TaskAwaiter<String> <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Helper), Member = "ReadAllText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.String>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(TextAsset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetTextures>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Texture2D[]> <>t__builder; //Field offset: 0x8
		public CardAnimationPlayer <>4__this; //Field offset: 0x20
		private FileInfo[] <files>5__2; //Field offset: 0x28
		private TaskAwaiter<Byte[][]> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(General), Member = "GetNameWithoutExtension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileInfo)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Customization), Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool), typeof(bool), typeof(Texture2D&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task), Member = "WhenAll", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.Tasks.Task`1<TResult>[]"}, ReturnType = "System.Threading.Tasks.Task`1<TResult[]>")]
		[Calls(Type = typeof(Helper), Member = "ReadAllBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Threading.Tasks.Task`1<Byte[]>))]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
		[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[Calls(Type = typeof(DirectoryInfo), Member = "EnumerateFiles", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileInfo>))]
		[Calls(Type = typeof(CardAnimationPlayer), Member = "get_SpineDir", ReturnType = typeof(DirectoryInfo))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 27)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadSkeleton>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public Card c; //Field offset: 0x20
		public CardAnimationPlayer <>4__this; //Field offset: 0x28
		private AssetBundleRequest <req>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CardAnimationPlayer), Member = "GetSkeletonDataAssetPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(AssetBundle), Member = "LoadAssetWithSubAssetsAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(AssetBundleRequest))]
		[Calls(Type = typeof(AsyncExtensions), Member = "Await", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AssetBundleRequest), Member = "get_allAssets", ReturnType = typeof(Object[]))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 19)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public static bool EnableCardAnimations; //Field offset: 0x0
	private const string TEXTURE_EXT = ".png"; //Field offset: 0x0
	private const string ANIM_EXT = ".json"; //Field offset: 0x0
	private const string ATLAS_EXT = ".txt"; //Field offset: 0x0
	public static bool IsPlaying; //Field offset: 0x1
	private static readonly Color FadeColor; //Field offset: 0x4
	private static CardAnimationPlayer Instance; //Field offset: 0x18
	private static readonly SemaphoreSlim Semaphore; //Field offset: 0x20
	[SerializeField]
	private Material MaterialRef; //Field offset: 0x20
	[SerializeField]
	private SkeletonAnimation SKAnim; //Field offset: 0x28
	[SerializeField]
	private TextMeshProUGUI NameLabel; //Field offset: 0x30
	[SerializeField]
	private Canvas DataCanvas; //Field offset: 0x38
	[SerializeField]
	private Image DataFade; //Field offset: 0x40
	[SerializeField]
	private Image ScreenRaycaster; //Field offset: 0x48
	[SerializeField]
	private Canvas OverlayCanvas; //Field offset: 0x50
	private MeshRenderer RenderMesh; //Field offset: 0x58
	private int CardID; //Field offset: 0x60
	private int KoID; //Field offset: 0x64
	private String[] FileNames; //Field offset: 0x68
	private Card Data; //Field offset: 0x70
	private SkeletonDataAsset SkeletonData; //Field offset: 0x78
	private int ExtraData; //Field offset: 0x80

	private string CardIDPath
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		private get { } //Length: 201
	}

	private string CardPath
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		private get { } //Length: 157
	}

	private string KoIDPath
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		private get { } //Length: 201
	}

	private DirectoryInfo SpineDir
	{
		[CalledBy(Type = typeof(<GetAtlasText>d__32), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<GetSkeletonJson>d__33), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<GetTextures>d__34), Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CardAnimationPlayer), Member = "get_SpinePath", ReturnType = typeof(string))]
		[Calls(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		private get { } //Length: 97
	}

	private string SpinePath
	{
		[CalledBy(Type = typeof(CardAnimationPlayer), Member = "get_SpineDir", ReturnType = typeof(DirectoryInfo))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		private get { } //Length: 671
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SemaphoreSlim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static CardAnimationPlayer() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public CardAnimationPlayer() { }

	[AsyncStateMachine(typeof(<Animate>d__55))]
	[CalledBy(Type = typeof(ChatWindow), Member = "ParseChatCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSpSummoned>d__204", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSummoned>d__202", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Animate>d__55)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Animate>d__55&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void Animate(int id, int extraData = -1) { }

	[CalledBy(Type = typeof(CardAnimationPlayer), Member = "Play", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DOTweenModuleUI), Member = "DOColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Graphic), typeof(Color), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>))]
	[Calls(Type = typeof(DOTweenModuleUI), Member = "DOColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Image), typeof(Color), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void AnimateCanvasData() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CardAnimationPlayer), Member = "FileMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileInfo), typeof(string)}, ReturnType = typeof(bool))]
	private bool AnimationMatch(FileInfo fi) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CardAnimationPlayer), Member = "FileMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileInfo), typeof(string)}, ReturnType = typeof(bool))]
	private bool AtlasMatch(FileInfo fi) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Renderer), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Helper), Member = "get_MainCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Canvas), Member = "set_worldCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(General), Member = "AddTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour), typeof(EventTriggerType), typeof(System.Action`1<UnityEngine.EventSystems.PointerEventData>)}, ReturnType = typeof(EventTrigger))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void Awake() { }

	[AsyncStateMachine(typeof(<BuildSkeleton>d__39))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<BuildSkeleton>d__39)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<BuildSkeleton>d__39&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private Task<Boolean> BuildSkeleton() { }

	[CalledBy(Type = typeof(CardAnimationPlayer), Member = "Play", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardAnimationPlayer), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Helper), Member = "get_MainCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Transform), Member = "set_rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(General), Member = "ToCenterOfScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void CalculateCamera() { }

	[CalledBy(Type = typeof(CardAnimationPlayer), Member = "Play", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Card), Member = "HasAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardAttribute)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour), typeof(float), "System.Action`2<T, Object>", typeof(object), typeof(string), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private void DefineGFX() { }

	[CalledBy(Type = typeof(CardAnimationPlayer), Member = "TextureMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CardAnimationPlayer), Member = "AtlasMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CardAnimationPlayer), Member = "AnimationMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FileSystemInfo), Member = "get_Extension", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private bool FileMatch(FileInfo fi, string ext) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	private string get_CardIDPath() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	private string get_CardPath() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	private string get_KoIDPath() { }

	[CalledBy(Type = typeof(<GetAtlasText>d__32), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<GetSkeletonJson>d__33), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<GetTextures>d__34), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CardAnimationPlayer), Member = "get_SpinePath", ReturnType = typeof(string))]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	private DirectoryInfo get_SpineDir() { }

	[CalledBy(Type = typeof(CardAnimationPlayer), Member = "get_SpineDir", ReturnType = typeof(DirectoryInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	private string get_SpinePath() { }

	[AsyncStateMachine(typeof(<GetAtlasText>d__32))]
	[CalledBy(Type = typeof(<BuildSkeleton>d__39), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetAtlasText>d__32)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetAtlasText>d__32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private Task<TextAsset> GetAtlasText() { }

	[CalledBy(Type = typeof(Helper), Member = "IndexBundles", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static string GetSkeletonDataAssetName(Card c) { }

	[CalledBy(Type = typeof(<LoadSkeleton>d__38), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private string GetSkeletonDataAssetPath(Card c) { }

	[AsyncStateMachine(typeof(<GetSkeletonJson>d__33))]
	[CalledBy(Type = typeof(<BuildSkeleton>d__39), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetSkeletonJson>d__33)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetSkeletonJson>d__33&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private Task<TextAsset> GetSkeletonJson() { }

	[AsyncStateMachine(typeof(<GetTextAsset>d__27))]
	[CalledBy(Type = typeof(<GetAtlasText>d__32), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<GetSkeletonJson>d__33), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetTextAsset>d__27)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetTextAsset>d__27&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private Task<TextAsset> GetTextAsset(FileInfo file) { }

	[AsyncStateMachine(typeof(<GetTextures>d__34))]
	[CalledBy(Type = typeof(<BuildSkeleton>d__39), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetTextures>d__34)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetTextures>d__34&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private Task<Texture2D[]> GetTextures() { }

	[CalledBy(Type = typeof(<Animate>d__55), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[Calls(Type = typeof(Card), Member = "get_Alias", ReturnType = typeof(int))]
	[Calls(Type = typeof(Card), Member = "HasCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Category)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private bool InitData(int cardId) { }

	[AsyncStateMachine(typeof(<LoadSkeleton>d__38))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadSkeleton>d__38)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadSkeleton>d__38&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task<Boolean> LoadSkeleton(Card c) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(General), Member = "IsLeftTap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(bool))]
	[ContainsInvalidInstructions]
	private void OnClick(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CardAnimationPlayer), Member = "OnStop", ReturnType = typeof(void))]
	private void OnPlayCompleted(TrackEntry trackEntry) { }

	[CalledBy(Type = typeof(CardAnimationPlayer), Member = "OnPlayCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SkeletonAnimation), Member = "get_AnimationState", ReturnType = typeof(AnimationState))]
	[Calls(Type = typeof(AnimationState), Member = "remove_Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntryDelegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardAnimationPlayer), Member = "ReleaseSemaphore", ReturnType = typeof(void))]
	[Calls(Type = typeof(EffectsManager), Member = "RemoveAllEffects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour), typeof(string)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void OnStop() { }

	[CalledBy(Type = typeof(<Animate>d__55), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CardAnimationPlayer), Member = "CalculateCamera", ReturnType = typeof(void))]
	[Calls(Type = typeof(CardAnimationPlayer), Member = "DefineGFX", ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(SkeletonAnimation), Member = "get_AnimationState", ReturnType = typeof(AnimationState))]
	[Calls(Type = typeof(AnimationState), Member = "SetAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(TrackEntry))]
	[Calls(Type = typeof(AnimationState), Member = "add_Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntryDelegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardAnimationPlayer), Member = "AnimateCanvasData", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsInvalidInstructions]
	private void Play() { }

	[CalledBy(Type = typeof(<Animate>d__55), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardAnimationPlayer), Member = "OnStop", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SemaphoreSlim), Member = "get_CurrentCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private static void ReleaseSemaphore() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CardAnimationPlayer), Member = "FileMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileInfo), typeof(string)}, ReturnType = typeof(bool))]
	private bool TextureMatch(FileInfo fi) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CardAnimationPlayer), Member = "CalculateCamera", ReturnType = typeof(void))]
	private void Update() { }

}

