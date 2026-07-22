namespace Manager;

public static class Updater
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<UpdateType, List`1<CachedAssetBundle>>, Int32> <>9__35_0; //Field offset: 0x8
		public static Func<String, Task> <>9__51_0; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal int <DoUpdate>b__35_0(KeyValuePair<UpdateType, List`1<CachedAssetBundle>> ab) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.Updater+<CheckForDatasUpdate>d__50"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CheckForDatasUpdate>d__50&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal Task <UpdateDatas>b__51_0(string d) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public UnityWebRequestAsyncOperation uwrao; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass32_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncOperation), Member = "get_progress", ReturnType = typeof(float))]
		[Calls(Type = typeof(LoadingInfo), Member = "UpdateMinorProgress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_downloadedBytes", ReturnType = typeof(ulong))]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_downloadProgress", ReturnType = typeof(float))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void <DownloadAssetBundle>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass97_0
	{
		public Action onEnd; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass97_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.Updater+<HandleGameUpdate>d__98"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<HandleGameUpdate>d__98&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void <CheckForClientUpdate>b__0(bool r) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass99_0
	{
		public bool showBar; //Field offset: 0x10
		public UnityWebRequestAsyncOperation uwrao; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass99_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncOperation), Member = "get_progress", ReturnType = typeof(float))]
		[Calls(Type = typeof(LoadingInfo), Member = "UpdateMinorProgress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LoadingInfo), Member = "UpdateMajorProgress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_downloadedBytes", ReturnType = typeof(ulong))]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_downloadProgress", ReturnType = typeof(float))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void <DownloadFile>b__0() { }

	}

	[CompilerGenerated]
	private struct <CheckForClientUpdate>d__97 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public Action onEnd; //Field offset: 0x28
		private <>c__DisplayClass97_0 <>8__1; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.Updater+<DetermineDownloadLink>d__76"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DetermineDownloadLink>d__76&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(Updater), Member = "HandleLauncherUpdate", ReturnType = typeof(Task))]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[Calls(Type = typeof(Updater), Member = "get_UpdateAPKPath", ReturnType = typeof(string))]
		[Calls(Type = typeof(FileInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetClientMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(OptionBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>), typeof(string), typeof(Template)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 13)]
		[CallsUnknownMethods(Count = 12)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CheckForDatasUpdate>d__50 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string file; //Field offset: 0x20
		public bool force; //Field offset: 0x28
		private string <hash>5__2; //Field offset: 0x30
		private FileInfo <hashFile>5__3; //Field offset: 0x38
		private FileInfo <dataFile>5__4; //Field offset: 0x40
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48
		private string <>7__wrap4; //Field offset: 0x50
		private TaskAwaiter <>u__2; //Field offset: 0x58

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FileInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.Updater+<GetHash>d__46"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetHash>d__46&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Helper), Member = "ReadAllText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.String>))]
		[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.Updater+<UpdateDatasFile>d__47"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<UpdateDatasFile>d__47&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 12)]
		[CallsUnknownMethods(Count = 28)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DetermineDownloadLink>d__76 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.Updater+<GatherDownloadLinks>d__73"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GatherDownloadLinks>d__73&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(SystemInfo), Member = "get_processorType", ReturnType = typeof(string))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 13)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoUpdate>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public bool showLoading; //Field offset: 0x20
		private int <total>5__2; //Field offset: 0x24
		private int <idx>5__3; //Field offset: 0x28
		private Dictionary<UpdateType, List`1<CachedAssetBundle>> <abs>5__4; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private Enumerator<UpdateType, String> <>7__wrap4; //Field offset: 0x40
		private KeyValuePair<UpdateType, String> <manifest>5__6; //Field offset: 0x68
		private TaskAwaiter<List`1<CachedAssetBundle>> <>u__2; //Field offset: 0x78
		private Enumerator<UpdateType, List<CachedAssetBundle>> <>7__wrap6; //Field offset: 0x80
		private KeyValuePair<UpdateType, List`1<CachedAssetBundle>> <ab>5__8; //Field offset: 0xA8
		private Enumerator<CachedAssetBundle> <>7__wrap8; //Field offset: 0xB8

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(Updater), Member = "DownloadAssetBundle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedAssetBundle), typeof(UpdateType)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Enumerable), Member = "Sum", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Int32>"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LoadingInfo), Member = "UpdateMajorProgress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(LoadingInfo), Member = "SetActionText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.TaskAwaiter`1<System.Object>), typeof(<DoUpdate>d__35)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter`1<Object>&), typeof(<DoUpdate>d__35&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.Updater+<LoadManifest>d__34"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadManifest>d__34&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Updater), Member = "get_ManifestFileName", ReturnType = typeof(string))]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Caching), Member = "set_currentCacheForWriting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cache)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Caching), Member = "AddCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Cache))]
		[Calls(Type = typeof(Cache), Member = "get_valid", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Caching), Member = "GetCacheByPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Cache))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter), typeof(<DoUpdate>d__35)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter&), typeof(<DoUpdate>d__35&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LoadingInfo), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Task))]
		[CallsDeduplicatedMethods(Count = 19)]
		[CallsUnknownMethods(Count = 66)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DownloadAssetBundle>d__32 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CachedAssetBundle cachedBundle; //Field offset: 0x20
		public UpdateType type; //Field offset: 0x38
		private <>c__DisplayClass32_0 <>8__1; //Field offset: 0x40
		private object <>u__1; //Field offset: 0x48
		private byte <tries>5__2; //Field offset: 0x50
		private UnityWebRequest <request>5__3; //Field offset: 0x58
		private TaskAwaiter <>u__2; //Field offset: 0x60

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Caching), Member = "ClearOtherCachedVersions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Hash128)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CachedAssetBundle), Member = "get_hash", ReturnType = typeof(Hash128))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Caching), Member = "GetCachedVersions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.List`1<UnityEngine.Hash128>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DownloadHandlerAssetBundle), Member = "GetContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest)}, ReturnType = typeof(AssetBundle))]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_result", ReturnType = typeof(Result))]
		[Calls(Type = typeof(AsyncExtensions), Member = "Await", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation), typeof(Action)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
		[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Updater), Member = "get_UserAgent", ReturnType = typeof(string))]
		[Calls(Type = typeof(UnityWebRequestAssetBundle), Member = "GetAssetBundle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CachedAssetBundle), typeof(uint)}, ReturnType = typeof(UnityWebRequest))]
		[Calls(Type = typeof(Updater), Member = "GetUpdateURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UpdateType)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(AssetBundle), Member = "Unload", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(<DownloadAssetBundle>d__32)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(<DownloadAssetBundle>d__32&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SimpleCoroutineAwaiter`1), Member = "GetResult", ReturnType = "T")]
		[Calls(Type = typeof(AwaiterExtensions), Member = "GetAwaiter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetBundleCreateRequest)}, ReturnType = typeof(Utilities.Async.SimpleCoroutineAwaiter`1<UnityEngine.AssetBundle>))]
		[Calls(Type = typeof(AssetBundle), Member = "LoadFromFileAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(AssetBundleCreateRequest))]
		[Calls(Type = typeof(File), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 13)]
		[CallsUnknownMethods(Count = 26)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DownloadFile>d__99 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public bool showBar; //Field offset: 0x20
		public Uri url; //Field offset: 0x28
		private <>c__DisplayClass99_0 <>8__1; //Field offset: 0x30
		public string destination; //Field offset: 0x38
		private int <retries>5__2; //Field offset: 0x40
		private UnityWebRequest <request>5__3; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LoadingInfo), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(UnityWebRequest))]
		[Calls(Type = typeof(Updater), Member = "get_UserAgent", ReturnType = typeof(string))]
		[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
		[Calls(Type = typeof(AsyncExtensions), Member = "Await", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation), typeof(Action)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_result", ReturnType = typeof(Result))]
		[Calls(Type = typeof(Helper), Member = "WriteAllBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[])}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(LoadingInfo), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 13)]
		[CallsUnknownMethods(Count = 35)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DownloadManifestAssetBundle>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string manifestFile; //Field offset: 0x20
		public string filePath; //Field offset: 0x28
		public UpdateType type; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Updater), Member = "DownloadManifestPart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(UpdateType)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Task), Member = "WhenAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task[])}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 14)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DownloadManifestPart>d__29 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string fileName; //Field offset: 0x20
		public UpdateType type; //Field offset: 0x28
		public string manifestFile; //Field offset: 0x30
		private UnityWebRequest <request>5__2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Updater), Member = "GetUpdateURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UpdateType)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
		[Calls(Type = typeof(Updater), Member = "DefineRequestHeaders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
		[Calls(Type = typeof(AsyncExtensions), Member = "Await", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_result", ReturnType = typeof(Result))]
		[Calls(Type = typeof(Helper), Member = "WriteAllBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[])}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_error", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 14)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DownloadUpdaterToTemp>d__78 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<FileInfo> <>t__builder; //Field offset: 0x8
		private string <zipped>5__2; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Path), Member = "GetTempPath", ReturnType = typeof(string))]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Updater), Member = "DownloadFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(FileInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GatherDownloadLinks>d__73 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[Calls(Type = typeof(Enumerable), Member = "ElementAtOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
		[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(Convert), Member = "FromBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(StringReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.Updater+<GatherResourcesLinks>d__72"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GatherResourcesLinks>d__72&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[CallsDeduplicatedMethods(Count = 18)]
		[CallsUnknownMethods(Count = 42)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GatherResourcesLinks>d__72 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter<String> <>u__1; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Helper), Member = "DoGetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.String>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
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

	[CompilerGenerated]
	private struct <GetHash>d__46 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public string file; //Field offset: 0x20
		private TaskAwaiter<String> <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Updater), Member = "GetUpdateURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UpdateType)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "DoGetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.String>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "TrimEnd", ReturnType = typeof(string))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 13)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <HandleGameUpdate>d__98 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		private string <apk>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(OmegaAndroidPlugin), Member = "InstallAPK", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(MainMenu), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "ChangeScene", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneType)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LoadingInfo), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Helper), Member = "get_IsMac", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Updater), Member = "FindFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(FileSystemInfo))]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Path), Member = "GetTempPath", ReturnType = typeof(string))]
		[Calls(Type = typeof(Updater), Member = "DownloadFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Updater), Member = "get_UpdateAPKPath", ReturnType = typeof(string))]
		[Calls(Type = typeof(Helper), Member = "QuitGame", ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "OpenURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Updater), Member = "HandleLauncherUpdate", ReturnType = typeof(Task))]
		[Calls(Type = typeof(Helper), Member = "CloseAllScreens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "ShowLoadingScreen", ReturnType = typeof(void))]
		[Calls(Type = typeof(Application), Member = "get_isMobilePlatform", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 13)]
		[CallsUnknownMethods(Count = 19)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <HandleLauncherUpdate>d__92 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter<FileInfo> <>u__1; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LoadingInfo), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(PlayerPrefs), Member = "SetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.Updater+<UnpackUpdate>d__93"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<UnpackUpdate>d__93&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.Updater+<DownloadUpdaterToTemp>d__78"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DownloadUpdaterToTemp>d__78&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Updater), Member = "get_UpdaterFile", ReturnType = typeof(FileSystemInfo))]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(PlayerPrefs), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Application), Member = "get_isMobilePlatform", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 15)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadManifest>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<List`1<CachedAssetBundle>> <>t__builder; //Field offset: 0x8
		public string manifestName; //Field offset: 0x20
		public UpdateType type; //Field offset: 0x28
		private List<CachedAssetBundle> <output>5__2; //Field offset: 0x30
		private string <manifestFile>5__3; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40
		private AssetBundleCreateRequest <abcr>5__4; //Field offset: 0x48
		private AssetBundleRequest <req>5__5; //Field offset: 0x50
		private Awaiter <>u__2; //Field offset: 0x58

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "AwaitOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Awaiter), typeof(<LoadManifest>d__34)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Awaiter&), typeof(<LoadManifest>d__34&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Awaitable), Member = "PropagateExceptionAndRelease", ReturnType = typeof(void))]
		[Calls(Type = typeof(Awaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Awaitable), Member = "FromAsyncOperationInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(IntPtr))]
		[Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
		[Calls(Type = typeof(AssetBundle), Member = "UnloadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(AssetBundleUnloadOperation))]
		[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AssetBundleManifest), Member = "GetAssetBundleHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Hash128))]
		[Calls(Type = typeof(AssetBundleManifest), Member = "GetAllAssetBundles", ReturnType = typeof(String[]))]
		[Calls(Type = typeof(AssetBundle), Member = "LoadAssetAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(AssetBundleRequest))]
		[Calls(Type = typeof(AssetBundleCreateRequest), Member = "get_assetBundle", ReturnType = typeof(AssetBundle))]
		[Calls(Type = typeof(AsyncExtensions), Member = "Await", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AssetBundle), Member = "LoadFromFileAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(AssetBundleCreateRequest))]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.Updater+<DownloadManifestAssetBundle>d__25"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DownloadManifestAssetBundle>d__25&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter), typeof(<LoadManifest>d__34)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter&), typeof(<LoadManifest>d__34&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SemaphoreSlim), Member = "WaitAsync", ReturnType = typeof(Task))]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 18)]
		[CallsUnknownMethods(Count = 54)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnpackUpdate>d__93 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public FileInfo file; //Field offset: 0x20
		private UnauthorizedAccessException <ex>5__2; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "QuitGame", ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(WindowsPermissionSetup), Member = "HandleLackOfPermissions", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[Calls(Type = typeof(DirectoryInfo), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Updater), Member = "MoveUpdaterFromTemp", ReturnType = typeof(DirectoryInfo))]
		[Calls(Type = typeof(ZipFile), Member = "ExtractToDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "StructureDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Directory), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Updater), Member = "get_TempZipPath", ReturnType = typeof(string))]
		[Calls(Type = typeof(Updater), Member = "SetLinuxPermissions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Updater), Member = "SetMacPermissions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Application), Member = "get_temporaryCachePath", ReturnType = typeof(string))]
		[Calls(Type = typeof(Helper), Member = "get_IsMac", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Helper), Member = "get_IsLinux", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 20)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateBadWords>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter<String> <>u__1; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "DoGetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.String>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(JsonConvert), Member = "DeserializeObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
		[Calls(Type = typeof(Helper), Member = "DefineFilterWords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 6)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateBundles>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public bool showLoading; //Field offset: 0x28
		public Action onFinish; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Helper), Member = "ShowLoadingScreen", ReturnType = typeof(void))]
		[Calls(Type = typeof(Updater), Member = "UpdateDatas", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.Updater+<DoUpdate>d__35"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoUpdate>d__35&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "WhenAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task[])}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 18)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateDatas>d__51 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[Calls(Type = typeof(Task), Member = "WhenAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateDatasFile>d__47 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public FileInfo dataFile; //Field offset: 0x20
		public FileInfo hashFile; //Field offset: 0x28
		public string hash; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(General), Member = "GetNameWithoutExtension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileInfo)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Updater), Member = "GetUpdateURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UpdateType)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Updater), Member = "DownloadFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Helper), Member = "WriteAllText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "WhenAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task[])}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 18)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum UpdateType
	{
		Default = 0,
		Datas = 1,
		Ext = 2,
		Anm = 3,
	}

	private static string _updateServer; //Field offset: 0x0
	private const string OMEGA3DB = "https://github.com/duelists-unite/omega-3/releases/download/data/omega.db"; //Field offset: 0x0
	private const string DATA_EXT = ""; //Field offset: 0x0
	private const string HASH_EXT = ".meta"; //Field offset: 0x0
	public const string UPDATER_NAME = "OmegaUpdater"; //Field offset: 0x0
	private static readonly String[] UpData; //Field offset: 0x8
	private static string _ua; //Field offset: 0x10
	private static readonly SemaphoreSlim BundleSem; //Field offset: 0x18
	public static bool IsUpdatingBundles; //Field offset: 0x20
	private static readonly String[] DATA_FILES; //Field offset: 0x28
	public static bool IsUpdatingGame; //Field offset: 0x30
	private static readonly Uri ResourcesLink; //Field offset: 0x38
	private static readonly Uri SecondaryResourcesLink; //Field offset: 0x40
	private static Uri Windows64DownloadLink; //Field offset: 0x48
	private static Uri Windows32DownloadLink; //Field offset: 0x50
	private static Uri LinuxDownloadLink; //Field offset: 0x58
	private static Uri MacDownloadLink; //Field offset: 0x60
	private static Uri AndroidLink; //Field offset: 0x68
	private static Uri iOSLink; //Field offset: 0x70
	private static Uri DownloadLink; //Field offset: 0x78
	private static string LauncherRev; //Field offset: 0x80
	private static Uri LauncherWin; //Field offset: 0x88
	private static Uri LauncherLin; //Field offset: 0x90
	private static Uri LauncherMac; //Field offset: 0x98
	private static Uri LauncherMacARM; //Field offset: 0xA0
	private static Uri LauncherLink; //Field offset: 0xA8
	private static string DownloadedString; //Field offset: 0xB0
	private static int ClientRev; //Field offset: 0xB8

	private static bool AnmAt
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "ElementAtOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
		[CallsDeduplicatedMethods(Count = 1)]
		private get { } //Length: 153
	}

	private static string AnmGit
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "ElementAtOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
		private get { } //Length: 104
	}

	private static string AnmTagRepo
	{
		[CalledBy(Type = typeof(Updater), Member = "GetUpdateURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UpdateType)}, ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Enumerable), Member = "ElementAtOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
		private get { } //Length: 104
	}

	private static string BdlRepo
	{
		[CalledBy(Type = typeof(Updater), Member = "GetUpdateURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UpdateType)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Enumerable), Member = "ElementAtOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
		private get { } //Length: 104
	}

	private static string DatasTag
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "ElementAtOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
		private get { } //Length: 104
	}

	private static string DefUpdt
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "ElementAtOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
		private get { } //Length: 104
	}

	private static string DUGit
	{
		[CalledBy(Type = typeof(Updater), Member = "GetUpdateURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UpdateType)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Enumerable), Member = "ElementAtOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
		private get { } //Length: 101
	}

	private static string ExtTag
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "ElementAtOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
		private get { } //Length: 104
	}

	public static bool HasLatestClient
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 234
	}

	private static bool IsARMCPU
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(SystemInfo), Member = "get_processorType", ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 178
	}

	public static string ManifestFileName
	{
		[CalledBy(Type = typeof(<DoUpdate>d__35), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Updater), Member = "GetUpdateURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UpdateType)}, ReturnType = typeof(string))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Application), Member = "get_isMobilePlatform", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		 get { } //Length: 166
	}

	public static bool RequiresUpdaterUpdate
	{
		[CalledBy(Type = "Plugins.WindowsPermissionSetup+<HandleLackOfPermissions>d__3", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Application), Member = "get_isMobilePlatform", ReturnType = typeof(bool))]
		[Calls(Type = typeof(PlayerPrefs), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Updater), Member = "get_UpdaterFile", ReturnType = typeof(FileSystemInfo))]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 326
	}

	public static string TempZipPath
	{
		[CalledBy(Type = "Plugins.WindowsPermissionSetup+<HandleLackOfPermissions>d__3", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(WindowsPermissionSetup), Member = "get_UpdaterTempFile", ReturnType = typeof(FileInfo))]
		[CalledBy(Type = typeof(<UnpackUpdate>d__93), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Updater), Member = "ExtractUpdaterInTemp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileInfo)}, ReturnType = typeof(DirectoryInfo))]
		[CalledBy(Type = typeof(Updater), Member = "MoveUpdaterFromTemp", ReturnType = typeof(DirectoryInfo))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Application), Member = "get_temporaryCachePath", ReturnType = typeof(string))]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		 get { } //Length: 133
	}

	public static string UpdateAPKPath
	{
		[CalledBy(Type = typeof(<CheckForClientUpdate>d__97), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<HandleGameUpdate>d__98), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Updater), Member = "ClearAndroidCachedUpdateAPK", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Application), Member = "get_temporaryCachePath", ReturnType = typeof(string))]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		 get { } //Length: 133
	}

	public static FileSystemInfo UpdaterFile
	{
		[CalledBy(Type = "Plugins.WindowsPermissionSetup+<HandleLackOfPermissions>d__3", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<HandleLauncherUpdate>d__92), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Updater), Member = "get_RequiresUpdaterUpdate", ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Updater), Member = "FindFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(FileSystemInfo))]
		 get { } //Length: 83
	}

	public static string UpdateServer
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 78
		[CalledBy(Type = "Scenes.Menu.SettingsMenu+<ApplyOthers>d__139", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Helper), Member = "LoadPrefs", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 226
	}

	public static string UserAgent
	{
		[CalledBy(Type = typeof(<DownloadAssetBundle>d__32), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<DownloadFile>d__99), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Updater), Member = "DefineRequestHeaders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Application), Member = "get_productName", ReturnType = typeof(string))]
		[Calls(Type = typeof(Application), Member = "get_version", ReturnType = typeof(string))]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 392
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SemaphoreSlim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 31)]
	private static Updater() { }

	[AsyncStateMachine(typeof(<CheckForClientUpdate>d__97))]
	[CalledBy(Type = "Manager.Helper+<Start>d__108", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CheckForClientUpdate>d__97)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CheckForClientUpdate>d__97&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void CheckForClientUpdate(Action onEnd) { }

	[AsyncStateMachine(typeof(<CheckForDatasUpdate>d__50))]
	[CalledBy(Type = "Manager.Helper+<TryUnpackDB>d__124", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Localization+<LoadNewLanguage>d__16", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CheckForDatasUpdate>d__50)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CheckForDatasUpdate>d__50&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Task CheckForDatasUpdate(string file, bool force) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(Updater), Member = "get_UpdateAPKPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(FileInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void ClearAndroidCachedUpdateAPK() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Caching), Member = "GetCacheByPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Cache))]
	[Calls(Type = typeof(Cache), Member = "get_valid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Caching), Member = "AddCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Cache))]
	[Calls(Type = typeof(Caching), Member = "set_currentCacheForWriting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cache)}, ReturnType = typeof(void))]
	public static void DefineCachePath() { }

	[CalledBy(Type = typeof(<DownloadManifestPart>d__29), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Updater), Member = "get_UserAgent", ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void DefineRequestHeaders(UnityWebRequest request) { }

	[AsyncStateMachine(typeof(<DetermineDownloadLink>d__76))]
	[CalledBy(Type = "Plugins.WindowsPermissionSetup+<HandleLackOfPermissions>d__3", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DetermineDownloadLink>d__76)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DetermineDownloadLink>d__76&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task DetermineDownloadLink() { }

	[AsyncStateMachine(typeof(<DoUpdate>d__35))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoUpdate>d__35)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoUpdate>d__35&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Task DoUpdate(bool showLoading) { }

	[AsyncStateMachine(typeof(<DownloadAssetBundle>d__32))]
	[CalledBy(Type = typeof(<DoUpdate>d__35), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DownloadAssetBundle>d__32)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DownloadAssetBundle>d__32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static Task DownloadAssetBundle(CachedAssetBundle cachedBundle, UpdateType type) { }

	[AsyncStateMachine(typeof(<DownloadFile>d__99))]
	[CalledBy(Type = typeof(<DownloadUpdaterToTemp>d__78), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<HandleGameUpdate>d__98), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<UpdateDatasFile>d__47), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.TextDataManager+<ReadFileForLanguage>d__19", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DownloadFile>d__99)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DownloadFile>d__99&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static Task DownloadFile(Uri url, string destination, bool showBar) { }

	[AsyncStateMachine(typeof(<DownloadManifestAssetBundle>d__25))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DownloadManifestAssetBundle>d__25)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DownloadManifestAssetBundle>d__25&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static Task DownloadManifestAssetBundle(string manifestFile, string filePath, UpdateType type) { }

	[AsyncStateMachine(typeof(<DownloadManifestPart>d__29))]
	[CalledBy(Type = typeof(<DownloadManifestAssetBundle>d__25), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DownloadManifestPart>d__29)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DownloadManifestPart>d__29&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static Task DownloadManifestPart(string fileName, string manifestFile, UpdateType type) { }

	[AsyncStateMachine(typeof(<DownloadUpdaterToTemp>d__78))]
	[CalledBy(Type = "Plugins.WindowsPermissionSetup+<HandleLackOfPermissions>d__3", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DownloadUpdaterToTemp>d__78)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DownloadUpdaterToTemp>d__78&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task<FileInfo> DownloadUpdaterToTemp() { }

	[CalledBy(Type = "Plugins.WindowsPermissionSetup+<HandleLackOfPermissions>d__3", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Updater), Member = "get_TempZipPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Directory), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Helper), Member = "StructureDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ZipFile), Member = "ExtractToDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Helper), Member = "get_IsLinux", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Helper), Member = "get_IsMac", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Updater), Member = "SetMacPermissions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Updater), Member = "SetLinuxPermissions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static DirectoryInfo ExtractUpdaterInTemp(FileInfo file) { }

	[CalledBy(Type = typeof(<HandleGameUpdate>d__98), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Updater), Member = "get_UpdaterFile", ReturnType = typeof(FileSystemInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Helper), Member = "get_IsMac", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(General), Member = "GetFileList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DirectoryInfo)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileInfo>))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DirectoryInfo), Member = "GetDirectories", ReturnType = typeof(DirectoryInfo[]))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	public static FileSystemInfo FindFile(string name) { }

	[AsyncStateMachine(typeof(<GatherDownloadLinks>d__73))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GatherDownloadLinks>d__73)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GatherDownloadLinks>d__73&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task GatherDownloadLinks() { }

	[AsyncStateMachine(typeof(<GatherResourcesLinks>d__72))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GatherResourcesLinks>d__72)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GatherResourcesLinks>d__72&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task GatherResourcesLinks() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "ElementAtOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static bool get_AnmAt() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "ElementAtOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
	private static string get_AnmGit() { }

	[CalledBy(Type = typeof(Updater), Member = "GetUpdateURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UpdateType)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enumerable), Member = "ElementAtOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
	private static string get_AnmTagRepo() { }

	[CalledBy(Type = typeof(Updater), Member = "GetUpdateURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UpdateType)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "ElementAtOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
	private static string get_BdlRepo() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "ElementAtOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
	private static string get_DatasTag() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "ElementAtOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
	private static string get_DefUpdt() { }

	[CalledBy(Type = typeof(Updater), Member = "GetUpdateURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UpdateType)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "ElementAtOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
	private static string get_DUGit() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "ElementAtOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
	private static string get_ExtTag() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool get_HasLatestClient() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(SystemInfo), Member = "get_processorType", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static bool get_IsARMCPU() { }

	[CalledBy(Type = typeof(<DoUpdate>d__35), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Updater), Member = "GetUpdateURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UpdateType)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Application), Member = "get_isMobilePlatform", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	public static string get_ManifestFileName() { }

	[CalledBy(Type = "Plugins.WindowsPermissionSetup+<HandleLackOfPermissions>d__3", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Application), Member = "get_isMobilePlatform", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Updater), Member = "get_UpdaterFile", ReturnType = typeof(FileSystemInfo))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool get_RequiresUpdaterUpdate() { }

	[CalledBy(Type = "Plugins.WindowsPermissionSetup+<HandleLackOfPermissions>d__3", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WindowsPermissionSetup), Member = "get_UpdaterTempFile", ReturnType = typeof(FileInfo))]
	[CalledBy(Type = typeof(<UnpackUpdate>d__93), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Updater), Member = "ExtractUpdaterInTemp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileInfo)}, ReturnType = typeof(DirectoryInfo))]
	[CalledBy(Type = typeof(Updater), Member = "MoveUpdaterFromTemp", ReturnType = typeof(DirectoryInfo))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Application), Member = "get_temporaryCachePath", ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	public static string get_TempZipPath() { }

	[CalledBy(Type = typeof(<CheckForClientUpdate>d__97), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<HandleGameUpdate>d__98), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Updater), Member = "ClearAndroidCachedUpdateAPK", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Application), Member = "get_temporaryCachePath", ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	public static string get_UpdateAPKPath() { }

	[CalledBy(Type = "Plugins.WindowsPermissionSetup+<HandleLackOfPermissions>d__3", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<HandleLauncherUpdate>d__92), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Updater), Member = "get_RequiresUpdaterUpdate", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Updater), Member = "FindFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(FileSystemInfo))]
	public static FileSystemInfo get_UpdaterFile() { }

	[CallerCount(Count = 0)]
	public static string get_UpdateServer() { }

	[CalledBy(Type = typeof(<DownloadAssetBundle>d__32), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<DownloadFile>d__99), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Updater), Member = "DefineRequestHeaders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Application), Member = "get_productName", ReturnType = typeof(string))]
	[Calls(Type = typeof(Application), Member = "get_version", ReturnType = typeof(string))]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	public static string get_UserAgent() { }

	[CalledBy(Type = "Manager.Helper+<TryUnpackDB>d__124", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Localization+<LoadNewLanguage>d__16", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.TextDataManager+<ReadFileForLanguage>d__19", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	public static string GetDatasFilePath(string file) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	public static string GetDatasHashPath(string file) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Updater), Member = "GetUpdateURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UpdateType)}, ReturnType = typeof(string))]
	private static string GetDataURL(string file) { }

	[AsyncStateMachine(typeof(<GetHash>d__46))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetHash>d__46)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetHash>d__46&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Task<String> GetHash(string file) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Updater), Member = "GetUpdateURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UpdateType)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	private static string GetHashURL(string file) { }

	[CalledBy(Type = typeof(<DownloadAssetBundle>d__32), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<DownloadManifestPart>d__29), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<GetHash>d__46), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<UpdateDatasFile>d__47), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Updater), Member = "GetHashURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Updater), Member = "GetDataURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "ElementAtOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
	[Calls(Type = typeof(General), Member = "ReplaceLast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Updater), Member = "get_ManifestFileName", ReturnType = typeof(string))]
	[Calls(Type = typeof(Updater), Member = "get_AnmTagRepo", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Updater), Member = "get_BdlRepo", ReturnType = typeof(string))]
	[Calls(Type = typeof(Updater), Member = "get_DUGit", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string GetUpdateURL(string file, UpdateType type) { }

	[AsyncStateMachine(typeof(<HandleGameUpdate>d__98))]
	[CalledBy(Type = typeof(Network), Member = "<HandlePacket>g__doUpdate|73_0", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<HandleGameUpdate>d__98)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<HandleGameUpdate>d__98&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void HandleGameUpdate() { }

	[AsyncStateMachine(typeof(<HandleLauncherUpdate>d__92))]
	[CalledBy(Type = typeof(<CheckForClientUpdate>d__97), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<HandleGameUpdate>d__98), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<HandleLauncherUpdate>d__92)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<HandleLauncherUpdate>d__92&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task HandleLauncherUpdate() { }

	[AsyncStateMachine(typeof(<LoadManifest>d__34))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadManifest>d__34)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadManifest>d__34&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static Task<List`1<CachedAssetBundle>> LoadManifest(string manifestName, UpdateType type) { }

	[CalledBy(Type = typeof(<UnpackUpdate>d__93), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Updater), Member = "get_TempZipPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(General), Member = "GetFileList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DirectoryInfo)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileInfo>))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FileInfo), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(FileInfo))]
	[Calls(Type = typeof(Helper), Member = "get_IsLinux", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Helper), Member = "get_IsMac", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Updater), Member = "SetMacPermissions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Updater), Member = "SetLinuxPermissions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public static DirectoryInfo MoveUpdaterFromTemp() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "TrimEnd", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public static string ParseMD5(string raw) { }

	[CalledBy(Type = typeof(Updater), Member = "SetLinuxPermissions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "get_IsLinux", ReturnType = typeof(bool))]
	[Calls(Type = typeof(OmegaUnixPlugin), Member = "StartProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Console), Member = "WriteLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void RunLinuxBashCommand(string cmd, string args) { }

	[CalledBy(Type = typeof(Updater), Member = "SetMacPermissions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "get_IsMac", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(OmegaUnixPlugin), Member = "StartProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Console), Member = "WriteLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void RunMacBashCommand(string cmd) { }

	[CalledBy(Type = "Scenes.Menu.SettingsMenu+<ApplyOthers>d__139", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Helper), Member = "LoadPrefs", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	public static void set_UpdateServer(string value) { }

	[CalledBy(Type = typeof(<UnpackUpdate>d__93), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Updater), Member = "ExtractUpdaterInTemp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileInfo)}, ReturnType = typeof(DirectoryInfo))]
	[CalledBy(Type = typeof(Updater), Member = "MoveUpdaterFromTemp", ReturnType = typeof(DirectoryInfo))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Updater), Member = "RunLinuxBashCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void SetLinuxPermissions(string path = ".", bool recursive = true) { }

	[CalledBy(Type = typeof(<UnpackUpdate>d__93), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Updater), Member = "ExtractUpdaterInTemp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileInfo)}, ReturnType = typeof(DirectoryInfo))]
	[CalledBy(Type = typeof(Updater), Member = "MoveUpdaterFromTemp", ReturnType = typeof(DirectoryInfo))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Updater), Member = "RunMacBashCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void SetMacPermissions(string path = ".", bool recursive = true) { }

	[AsyncStateMachine(typeof(<UnpackUpdate>d__93))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<UnpackUpdate>d__93)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<UnpackUpdate>d__93&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Task<Boolean> UnpackUpdate(FileInfo file) { }

	[AsyncStateMachine(typeof(<UpdateBadWords>d__37))]
	[CalledBy(Type = "Manager.Helper+<Preload>d__115", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<UpdateBadWords>d__37)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<UpdateBadWords>d__37&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task UpdateBadWords() { }

	[AsyncStateMachine(typeof(<UpdateBundles>d__38))]
	[CalledBy(Type = typeof(Helper), Member = "<Start>b__108_1", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<UpdateBundles>d__38)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<UpdateBundles>d__38&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void UpdateBundles(bool showLoading, Action onFinish) { }

	[AsyncStateMachine(typeof(<UpdateDatas>d__51))]
	[CalledBy(Type = typeof(<UpdateBundles>d__38), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<UpdateDatas>d__51)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<UpdateDatas>d__51&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task UpdateDatas() { }

	[AsyncStateMachine(typeof(<UpdateDatasFile>d__47))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<UpdateDatasFile>d__47)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<UpdateDatasFile>d__47&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static Task UpdateDatasFile(FileInfo dataFile, FileInfo hashFile, string hash) { }

}

