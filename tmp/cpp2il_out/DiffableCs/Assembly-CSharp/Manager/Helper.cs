namespace Manager;

public class Helper : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<String, Action`1<SpriteAtlas>> <>9__108_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		internal void <Start>b__108_0(string name, Action<SpriteAtlas> callback) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass100_0
	{
		public string ext; //Field offset: 0x0
		public Func<FileInfo, Boolean> <>9__0; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass100_0`1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FileSystemInfo), Member = "get_Extension", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal bool <ReserializeAllData>b__0(FileInfo fi) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass102_0
	{
		public int answer; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass102_0() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal void <NetworkCheck>b__0(bool r) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal bool <NetworkCheck>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass113_0
	{
		public Helper <>4__this; //Field offset: 0x10
		public byte done; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass113_0() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal void <PostLoading>b__0(SpriteAtlas caa, object o) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal void <PostLoading>b__1(object r, object o) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal void <PostLoading>b__2(object r, object o) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal bool <PostLoading>b__3() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass77_0
	{
		public string url; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass77_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Application), Member = "OpenURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		internal void <OpenURL>b__0(bool r) { }

	}

	[CompilerGenerated]
	private struct <BinaryDeserialize>d__120 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		public Byte[] data; //Field offset: 0x0
		public string path; //Field offset: 0x0
		private MemoryStream <ms>5__2; //Field offset: 0x0
		private T <result>5__3; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BinaryFormatter), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(Helper), Member = "ReserializeSingleData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T"}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 29)]
		[DeduplicatedMethod]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <BsonDeserializeAsync>d__119 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		public Byte[] data; //Field offset: 0x0
		private object <>7__wrap1; //Field offset: 0x0
		private int <>7__wrap2; //Field offset: 0x0
		private T <>7__wrap3; //Field offset: 0x0
		private ValueTaskAwaiter <>u__1; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BsonDataReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonSerializer), Member = "Deserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 24)]
		[DeduplicatedMethod]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ChangeScene>d__79 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SceneType type; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "WaitAsync", ReturnType = typeof(Task))]
		[Calls(Type = typeof(Background), Member = "SetSceneBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Sound), Member = "PlaySceneMusic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 8)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CleanMemory>d__132 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Resources), Member = "UnloadUnusedAssets", ReturnType = typeof(AsyncOperation))]
		[Calls(Type = typeof(AsyncExtensions), Member = "Await", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(GC), Member = "get_MaxGeneration", ReturnType = typeof(int))]
		[Calls(Type = typeof(GC), Member = "Collect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(GCCollectionMode), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GC), Member = "WaitForPendingFinalizers", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CloseScreen>d__129 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public float timer; //Field offset: 0x28
		public Object[] screens; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitForSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
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

	[CompilerGenerated]
	private struct <DatabaseDeserialize>d__126 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public bool isUpdate; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28
		private TaskAwaiter <>u__2; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "OnCorruptedState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[Calls(Type = typeof(CoreAPI), Member = "Init", ReturnType = typeof(void))]
		[Calls(Type = typeof(BotCore), Member = "Init", ReturnType = typeof(void))]
		[Calls(Type = typeof(Task), Member = "WhenAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task[])}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Localization), Member = "Init", ReturnType = typeof(Task))]
		[Calls(Type = typeof(Manager), Member = "LoadMainDatabase", ReturnType = typeof(Task))]
		[Calls(Type = typeof(Manager), Member = "Init", ReturnType = typeof(Task))]
		[Calls(Type = typeof(Helper), Member = "CleanTempDB", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(Helper), Member = "TryUnpackDB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(File), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Manager), Member = "get_TemporaryDBPath", ReturnType = typeof(string))]
		[Calls(Type = typeof(Localization), Member = "CardLocaleInit", ReturnType = typeof(Task))]
		[CallsDeduplicatedMethods(Count = 11)]
		[CallsUnknownMethods(Count = 28)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DeserializeFile>d__118 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		public string fileName; //Field offset: 0x0
		public bool binaryOnly; //Field offset: 0x0
		private string <path>5__2; //Field offset: 0x0
		private Byte[] <data>5__3; //Field offset: 0x0
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x0
		private TaskAwaiter<T> <>u__2; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(File), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Helper), Member = "ReadAllBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Threading.Tasks.Task`1<Byte[]>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(PackedBinaryData), Member = "DecompressData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(System.Threading.Tasks.Task`1<Byte[]>))]
		[Calls(Type = typeof(Helper), Member = "BsonDeserializeAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "BinaryDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string)}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 11)]
		[CallsUnknownMethods(Count = 52)]
		[DeduplicatedMethod]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoCFGHit>d__143 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		private bool <isOn>5__2; //Field offset: 0x28
		private TaskAwaiter<String> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Helper), Member = "DoGetStrings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.String>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(bool), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Boolean&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoGetRequest>d__144 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		public string url; //Field offset: 0x0
		private TaskAwaiter<String> <>u__1; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "DoGetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.String>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(JsonUtility), Member = "FromJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 12)]
		[DeduplicatedMethod]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoGetString>d__142 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public Uri url; //Field offset: 0x20
		private UnityWebRequest <www>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(UnityWebRequest))]
		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
		[Calls(Type = typeof(AsyncExtensions), Member = "Await", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_result", ReturnType = typeof(Result))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_error", ReturnType = typeof(string))]
		[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 19)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoGetStrings>d__141 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public string url; //Field offset: 0x20
		private TaskAwaiter<String> <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.Helper+<DoGetString>d__142"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoGetString>d__142&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
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
	private struct <DoPostRequest>d__140 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		public string url; //Field offset: 0x0
		public string post; //Field offset: 0x0
		private UnityWebRequest <www>5__2; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityWebRequest), Member = "PostWwwForm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(UnityWebRequest))]
		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
		[Calls(Type = typeof(AsyncExtensions), Member = "Await", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_result", ReturnType = typeof(Result))]
		[Calls(Type = typeof(JsonUtility), Member = "FromJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_error", ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 25)]
		[DeduplicatedMethod]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetAsset>d__76 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public AssetType bundle; //Field offset: 0x0
		public string name; //Field offset: 0x0
		public Action<T, Object> onFinish; //Field offset: 0x0
		public object callBack; //Field offset: 0x0
		public object cb2; //Field offset: 0x0
		private ResourceRequest <rr>5__2; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0
		private AssetBundleRequest <assetRequest>5__3; //Field offset: 0x0

		[CalledBy(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TStateMachine&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetAssetTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Resources), Member = "LoadAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ResourceRequest))]
		[Calls(Type = typeof(AsyncExtensions), Member = "Await", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AssetBundle), Member = "LoadAssetWithSubAssetsAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(AssetBundleRequest))]
		[Calls(Type = typeof(AssetBundleRequest), Member = "get_allAssets", ReturnType = typeof(Object[]))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 14)]
		[CallsUnknownMethods(Count = 73)]
		[DeduplicatedMethod]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetAssetFromBundle>d__75 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x0
		public Helper <>4__this; //Field offset: 0x0
		public AssetType bundle; //Field offset: 0x0
		public string name; //Field offset: 0x0
		public Action<T, Object> onFinish; //Field offset: 0x0
		public object callBack; //Field offset: 0x0
		public object cb2; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Helper), Member = "GetAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object), typeof(object)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetTextureFromWeb>d__145 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder; //Field offset: 0x8
		public string url; //Field offset: 0x20
		private UnityWebRequest <www>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityWebRequestTexture), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
		[Calls(Type = typeof(AsyncExtensions), Member = "Await", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_result", ReturnType = typeof(Result))]
		[Calls(Type = typeof(Texture2D), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_error", ReturnType = typeof(string))]
		[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 30)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Init>d__98 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public Helper <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28
		private String[] <>7__wrap1; //Field offset: 0x30
		private int <>7__wrap2; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Directory), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Application), Member = "get_temporaryCachePath", ReturnType = typeof(string))]
		[Calls(Type = typeof(Caching), Member = "GetAllCachePaths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Application), Member = "get_streamingAssetsPath", ReturnType = typeof(string))]
		[Calls(Type = typeof(Application), Member = "get_consoleLogPath", ReturnType = typeof(string))]
		[Calls(Type = typeof(Application), Member = "get_dataPath", ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CustomTheme), Member = "CreateThemeFromSource", ReturnType = typeof(Task))]
		[Calls(Type = typeof(PlayerPrefs), Member = "Save", ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "ReserializeAllData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Helper), Member = "QuitGame", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Application), Member = "get_persistentDataPath", ReturnType = typeof(string))]
		[Calls(Type = typeof(PlayerPrefs), Member = "DeleteAll", ReturnType = typeof(void))]
		[Calls(Type = typeof(Environment), Member = "GetCommandLineArgs", ReturnType = typeof(String[]))]
		[Calls(Type = typeof(NATHandler), Member = "Start", ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Application), Member = "set_runInBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[Calls(Type = typeof(Application), Member = "add_deepLinkActivated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.String>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[Calls(Type = typeof(OmegaWindowsPlugin), Member = "Start", ReturnType = typeof(void))]
		[Calls(Type = typeof(Permission), Member = "HasUserAuthorizedPermission", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Permission), Member = "RequestUserPermission", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Customization), Member = "Initialize", ReturnType = typeof(void))]
		[Calls(Type = typeof(WindowsPermissionSetup), Member = "HandleLackOfPermissions", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Application), Member = "get_isMobilePlatform", ReturnType = typeof(bool))]
		[Calls(Type = typeof(OmegaAndroidPlugin), Member = "Start", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 25)]
		[CallsUnknownMethods(Count = 39)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadAsset>d__65 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x0
		public Helper <>4__this; //Field offset: 0x0
		public AssetType type; //Field offset: 0x0
		public int id; //Field offset: 0x0
		public Action<T, Object> onFinish; //Field offset: 0x0
		public object callBack; //Field offset: 0x0
		private TaskAwaiter<ValueTuple`2<Boolean, Sprite>> <>u__1; //Field offset: 0x0
		private TaskAwaiter<Sprite> <>u__2; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ImageHandler), Member = "GetArt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Threading.Tasks.Task`1<UnityEngine.Sprite>))]
		[Calls(Type = typeof(ImageHandler), Member = "GetHolo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Threading.Tasks.Task`1<UnityEngine.Sprite>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(Customization), Member = "GetCustomArt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.ValueTuple`2<System.Boolean, UnityEngine.Sprite>>))]
		[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
		[Calls(Type = typeof(Card), Member = "get_Alias", ReturnType = typeof(int))]
		[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(int), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 18)]
		[CallsUnknownMethods(Count = 44)]
		[DeduplicatedMethod]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadAsset>d__66 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x0
		public AssetType type; //Field offset: 0x0
		public string name; //Field offset: 0x0
		public Action<T, Object> onFinish; //Field offset: 0x0
		public object callBack; //Field offset: 0x0
		public Helper <>4__this; //Field offset: 0x0
		private string <path>5__2; //Field offset: 0x0
		private TaskAwaiter<ValueTuple`2<Boolean, Sprite>> <>u__1; //Field offset: 0x0
		private TaskAwaiter <>u__2; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(Helper), Member = "GetAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object), typeof(object)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Customization), Member = "GetCustomFieldTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Sprite&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Background), Member = "get_IsRenderedBG", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CustomTheme), Member = "get_IsUsingCustomTheme", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Helper), Member = "GetSpriteFromAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(AssetType)}, ReturnType = typeof(Sprite))]
		[Calls(Type = typeof(Customization), Member = "GetCustomInterfaceTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Sprite&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(Card), Member = "get_Alias", ReturnType = typeof(int))]
		[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Helper), Member = "FindAssetInBundles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(Customization), Member = "GetCustomArt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.ValueTuple`2<System.Boolean, UnityEngine.Sprite>>))]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Localization), Member = "GetAssetTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 15)]
		[CallsUnknownMethods(Count = 78)]
		[DeduplicatedMethod]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadPointer>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x28
		private TaskAwaiter<ValueTuple`2<Boolean, Texture2D>> <>u__2; //Field offset: 0x30
		private ResourceRequest <rr>5__2; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "WaitAsync", ReturnType = typeof(Task))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Customization), Member = "GetCustomCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.ValueTuple`2<System.Boolean, UnityEngine.Texture2D>>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Resources), Member = "LoadAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ResourceRequest))]
		[Calls(Type = typeof(AsyncExtensions), Member = "Await", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperation)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Cursor), Member = "SetCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Vector2), typeof(CursorMode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 11)]
		[CallsUnknownMethods(Count = 21)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <NetworkCheck>d__102 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		private <>c__DisplayClass102_0 <>8__1; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Application), Member = "get_internetReachability", ReturnType = typeof(NetworkReachability))]
		[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(OptionBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>), typeof(string), typeof(Template)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 8)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PostLoading>d__113 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public Helper <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(MainMenu), Member = "ToMainMenu", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.Helper+<DoCFGHit>d__143"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoCFGHit>d__143&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.Helper+<Preload>d__115"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Preload>d__115&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "IndexBundles", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.ImageHandler+<Initialize>d__5"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Initialize>d__5&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task), Member = "WhenAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task[])}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(CustomTheme), Member = "InitTheme", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.Helper+<DatabaseDeserialize>d__126"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DatabaseDeserialize>d__126&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Sound), Member = "EnumerateBGM", ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "GetAssetFromBundle", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Template), Member = "ResetLayouts", ReturnType = typeof(void))]
		[Calls(Type = typeof(SpriteAtlas), Member = "GetSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Sprite))]
		[Calls(Type = typeof(DOTween), Member = "SetTweensCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(Task))]
		[CallsDeduplicatedMethods(Count = 17)]
		[CallsUnknownMethods(Count = 31)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Preload>d__115 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CardPool), Member = "SetPooledCardAmount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ChatWindow), Member = "Create", ReturnType = typeof(Task))]
		[Calls(Type = typeof(LobbyScreen), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DeckEdit), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<Card.Deck>), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DeckSelection), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.String>), typeof(Action), typeof(Banlist), typeof(GameSettings), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ReplayList), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Updater), Member = "UpdateBadWords", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadAllBytes>d__147 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Byte[]> <>t__builder; //Field offset: 0x8
		public string path; //Field offset: 0x20
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(File), Member = "ReadAllBytesAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<Byte[]>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadAllLines>d__149 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String[]> <>t__builder; //Field offset: 0x8
		public string path; //Field offset: 0x20
		private TaskAwaiter<String[]> <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(File), Member = "ReadAllLinesAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<String[]>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadAllText>d__148 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public string path; //Field offset: 0x20
		private TaskAwaiter<String> <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(File), Member = "ReadAllTextAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.String>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReserializeAllData>d__100 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public string ext; //Field offset: 0x0
		public string path; //Field offset: 0x0
		private IEnumerator<FileInfo> <>7__wrap1; //Field offset: 0x0
		private TaskAwaiter<T> <>u__1; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DirectoryInfo), Member = "GetFiles", ReturnType = typeof(FileInfo[]))]
		[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[Calls(Type = typeof(Helper), Member = "DeserializeFile", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 29)]
		[DeduplicatedMethod]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReserializeSingleData>d__101 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public string path; //Field offset: 0x0
		public T data; //Field offset: 0x0
		private string <tmpFile>5__2; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Helper), Member = "SerializeFile", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T"}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(File), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(File), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(File), Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 8)]
		[DeduplicatedMethod]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SerializeData>d__121 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Byte[]> <>t__builder; //Field offset: 0x0
		public T target; //Field offset: 0x0
		private MemoryStream <ms>5__2; //Field offset: 0x0
		private BsonDataWriter <w>5__3; //Field offset: 0x0
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(BsonDataWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonSerializer), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(PackedBinaryData), Member = "CompressData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CompressionLevel), typeof(Byte[])}, ReturnType = typeof(System.Threading.Tasks.Task`1<Byte[]>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 22)]
		[DeduplicatedMethod]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SerializeFile>d__122 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public T target; //Field offset: 0x0
		public string fileName; //Field offset: 0x0
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x0
		private TaskAwaiter <>u__2; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Helper), Member = "SerializeData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(System.Threading.Tasks.Task`1<Byte[]>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Helper), Member = "WriteAllBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[])}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 8)]
		[DeduplicatedMethod]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Start>d__108 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public Helper <>4__this; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(Application), Member = "Quit", ReturnType = typeof(void))]
		[Calls(Type = typeof(PlayerPrefs), Member = "Save", ReturnType = typeof(void))]
		[Calls(Type = typeof(Updater), Member = "CheckForClientUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.Helper+<NetworkCheck>d__102"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<NetworkCheck>d__102&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Background), Member = "SetSceneBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SpriteAtlasManager), Member = "add_atlasRequested", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.String, System.Action`1<UnityEngine.U2D.SpriteAtlas>>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Graphics), Member = "set_activeTier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsTier)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(Application), Member = "add_focusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "set_Pointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.Helper+<Init>d__98"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Init>d__98&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "LoadPrefs", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 13)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryUnpackDB>d__124 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public bool retry; //Field offset: 0x20
		private string <packedDb>5__2; //Field offset: 0x28
		private int <>7__wrap2; //Field offset: 0x30
		private string <>7__wrap3; //Field offset: 0x38
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x40
		private TaskAwaiter <>u__2; //Field offset: 0x48
		private TaskAwaiter<Boolean> <>u__3; //Field offset: 0x50

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "TryUnpackDB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Updater), Member = "CheckForDatasUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(File), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(File), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter), typeof(<TryUnpackDB>d__124)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter&), typeof(<TryUnpackDB>d__124&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.Helper+<WriteAllBytes>d__150"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteAllBytes>d__150&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(PackedBinaryData), Member = "DecompressData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(System.Threading.Tasks.Task`1<Byte[]>))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.Helper+<ReadAllBytes>d__147"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadAllBytes>d__147&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FileInfo), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(FileInfo))]
		[Calls(Type = typeof(Manager), Member = "get_TemporaryDBPath", ReturnType = typeof(string))]
		[Calls(Type = typeof(FileInfo), Member = "get_Length", ReturnType = typeof(long))]
		[Calls(Type = typeof(FileInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Updater), Member = "GetDatasFilePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 15)]
		[CallsUnknownMethods(Count = 23)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteAllBytes>d__150 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string path; //Field offset: 0x20
		public Byte[] data; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(File), Member = "WriteAllBytesAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[]), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 5)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteAllText>d__151 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string path; //Field offset: 0x20
		public string text; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(File), Member = "WriteAllTextAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const float SCROLL_MULT_FIX = 1; //Field offset: 0x0
	private const long PACKED_DB_SIZE = 52428800; //Field offset: 0x0
	public const string DONATE_URL = "https://paypal.me/DUnite"; //Field offset: 0x0
	public const string DISCORD_SERVER_URL = "https://discord.gg/duelistsunite"; //Field offset: 0x0
	public const string HELP_FAQ_URL = "https://forum.duelistsunite.org/t/ygo-omega-guide/519"; //Field offset: 0x0
	public const string STARTER_DECKS_URL = "https://raw.githubusercontent.com/duelists-unite/omega-bundles/main/starter.json"; //Field offset: 0x0
	public const string TCG_PLAYER_PARTNER_URL = "https://partner.tcgplayer.com/c/4924450/1830156/21018"; //Field offset: 0x0
	public const string TCGPINF_ART_URL = "https://partner.tcgplayer.com/c/4924450/1830156/21018?u=https://infinite.tcgplayer.com/yugioh/articles"; //Field offset: 0x0
	public static Helper Instance; //Field offset: 0x0
	public const string DEF_SV_AD = "game.duelistsunite.org"; //Field offset: 0x0
	public static SceneType CurrentScene; //Field offset: 0x8
	private static string _pointer; //Field offset: 0x10
	private static Texture2D _customCursor; //Field offset: 0x18
	public static bool HidePrices; //Field offset: 0x20
	public static bool InvertPrompts; //Field offset: 0x21
	private static readonly SemaphoreSlim CursorSem; //Field offset: 0x28
	private static SpriteAtlas ArtifactAtlas; //Field offset: 0x30
	private static Sprite Missing; //Field offset: 0x38
	public static readonly Dictionary<String, AssetBundle> AssetBundles; //Field offset: 0x40
	public static readonly Dictionary<Int32, String> ArtIndexer; //Field offset: 0x48
	public static readonly Dictionary<Int32, String> HoloIndexer; //Field offset: 0x50
	public static readonly Dictionary<Int32, String> SkeletonIndexer; //Field offset: 0x58
	private static Thread MainThread; //Field offset: 0x60
	public static string BaseReplayPath; //Field offset: 0x68
	public static string ServerReplayPath; //Field offset: 0x70
	public static string ClientReplayPath; //Field offset: 0x78
	private static float _at; //Field offset: 0x80
	[CompilerGenerated]
	private static bool <NoPopupNotifications>k__BackingField; //Field offset: 0x84
	private static bool _specMode; //Field offset: 0x85
	public static readonly bool USE_BUNDLES; //Field offset: 0x86
	private static readonly SemaphoreSlim SceneChangeSemaphore; //Field offset: 0x88
	public static bool ALLOW_TIME_SCALE; //Field offset: 0x90
	public static bool KeepDB; //Field offset: 0x91
	private static int LastScreenWidth; //Field offset: 0x94
	private static int LastScreenHeight; //Field offset: 0x98
	private static readonly BinaryFormatter BinarySerializator; //Field offset: 0xA0
	private static readonly JsonSerializer JsonSerializator; //Field offset: 0xA8
	public static bool IsCorruptedState; //Field offset: 0xB0
	private static Filter WordFilter; //Field offset: 0xB8
	[SerializeField]
	public bool DISABLE_UPDATES; //Field offset: 0x20
	public SpriteAtlas BaseAtlas; //Field offset: 0x28
	public SpriteAtlas DuelAtlas; //Field offset: 0x30
	public Texture2D DefaultDuelistAvatar; //Field offset: 0x38
	public Texture DefaultFieldMask; //Field offset: 0x40
	public Texture DefaultPlaymatMask; //Field offset: 0x48
	public float animTimer; //Field offset: 0x50
	[SerializeField]
	private Camera _mainCamera; //Field offset: 0x58
	[SerializeField]
	private Camera _baseCamera; //Field offset: 0x60

	public static float ANIMATION_TIMER
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 83
		[CallerCount(Count = 0)]
		 set { } //Length: 96
	}

	public static Camera BaseCamera
	{
		[CalledBy(Type = typeof(DuelField), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DuelField), Member = "OnDisable", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 92
	}

	public static string Clipboard
	{
		[CalledBy(Type = "Scenes.Menu.ReplayList+<<OnClickPlay>g__playClipboard|43_1>d", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ReplayList), Member = "OnClickImport", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(GUIUtility), Member = "get_systemCopyBuffer", ReturnType = typeof(string))]
		 get { } //Length: 64
		[CalledBy(Type = "Scenes.Menu.ReplayList+<OnClickExport>d__52", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.General.ChatWindow+<OnClickRoomPwd>d__48", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LifePoints), Member = "OnClickLPBar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Deck.DeckSelection+<DeckSync>d__52", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeckSelection), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Hotkey+<CopyDeckToClipboard>d__85", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Hotkey+<CopyLogToClipboard>d__84", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CopyableCardText), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(GUIUtility), Member = "set_systemCopyBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Localization), Member = "GetClientMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		 set { } //Length: 157
	}

	public static float DEF_AT
	{
		[CalledBy(Type = "Scenes.Battle.DuelZone+<DoParse>d__145", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 201
	}

	private static bool HasResolutionChanged
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
		[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 159
	}

	public static bool IsLinux
	{
		[CalledBy(Type = "Manager.Updater+<UnpackUpdate>d__93", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Updater), Member = "RunLinuxBashCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Updater), Member = "ExtractUpdaterInTemp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileInfo)}, ReturnType = typeof(DirectoryInfo))]
		[CalledBy(Type = typeof(Updater), Member = "MoveUpdaterFromTemp", ReturnType = typeof(DirectoryInfo))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 144
	}

	public static bool IsMac
	{
		[CalledBy(Type = "Manager.Updater+<HandleGameUpdate>d__98", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Updater+<UnpackUpdate>d__93", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Updater), Member = "FindFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(FileSystemInfo))]
		[CalledBy(Type = typeof(Updater), Member = "RunMacBashCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Updater), Member = "ExtractUpdaterInTemp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileInfo)}, ReturnType = typeof(DirectoryInfo))]
		[CalledBy(Type = typeof(Updater), Member = "MoveUpdaterFromTemp", ReturnType = typeof(DirectoryInfo))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 108
	}

	public static bool IsMainThread
	{
		[CalledBy(Type = typeof(OmegaAndroidPlugin), Member = "RunJavaTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 92
	}

	public static bool IsSpectatorMode
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 82
		[CalledBy(Type = "Scenes.Menu.MainMenu+<Start>d__43", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Lobby.LobbyScreen+<SpectateRandomRoom>d__132", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Helper), Member = "LoadPrefs", ReturnType = typeof(void))]
		[CalledBy(Type = "ClientAPI.WebServer+<OnSpectatorMode>d__28", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InfoBox), Member = "OnClickConfirm", ReturnType = typeof(void))]
		[Calls(Type = typeof(LobbyScreen), Member = "get_IsActive", ReturnType = typeof(bool))]
		[Calls(Type = typeof(MainMenu), Member = "get_IsActive", ReturnType = typeof(bool))]
		[Calls(Type = typeof(MainMenu), Member = "OnClickOnline", ReturnType = typeof(void))]
		[Calls(Type = typeof(LobbyScreen), Member = "SpectateRandomRoom", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 661
	}

	public static bool IsWindows
	{
		[CalledBy(Type = typeof(CoreAPI), Member = "DefineNativeCore", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 111
	}

	public static Camera MainCamera
	{
		[CallerCount(Count = 44)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 92
	}

	public static bool NoPopupNotifications
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 82
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 87
	}

	public static string Pointer
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
		[CalledBy(Type = typeof(ChatWindow), Member = "OnDragBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DraggableFrame), Member = "ResetCursor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DraggableFrame), Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DragClone), Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DragClone), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DuelManager), Member = "PostInternalOnSelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Card.ClientCard>), typeof(System.Collections.Generic.List`1<Card.ClientCard>), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<OnSelectCard>d__164", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DragClone), Member = "ResetCursor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<Start>d__108), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DuelZone), Member = "DragDisplayCardBorderEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DuelZone), Member = "DragDisplayCardBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DuelZone), Member = "SetUpOptimizedView", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.DuelZone+<CloseAllDuelWindows>d__79", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ChatWindow), Member = "OnEndDragBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass164_0", Member = "<OnSelectCard>g__finishClick|0", ReturnType = typeof(void))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadPointer>d__21)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadPointer>d__21&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 557
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SemaphoreSlim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(BinaryFormatter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSerializer), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	private static Helper() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Helper() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Updater), Member = "UpdateBundles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CompilerGenerated]
	private void <Start>b__108_1() { }

	[AsyncStateMachine(typeof(<BinaryDeserialize>d__120`1))]
	[CalledBy(Type = typeof(<DeserializeFile>d__118`1), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Manager.Helper+<BinaryDeserialize>d__120`1<System.Object>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<BinaryDeserialize>d__120`1<Object>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private static Task<T> BinaryDeserialize(Byte[] data, string path) { }

	[AsyncStateMachine(typeof(<BsonDeserializeAsync>d__119`1))]
	[CalledBy(Type = "Scenes.Menu.ReplayList+<<OnClickPlay>g__playClipboard|43_1>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<DeserializeFile>d__118`1), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.P2PManager+<OnNetworkPacket>d__57", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Manager.Helper+<BsonDeserializeAsync>d__119`1<System.Object>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<BsonDeserializeAsync>d__119`1<Object>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static Task<T> BsonDeserializeAsync(Byte[] data) { }

	[AsyncStateMachine(typeof(<ChangeScene>d__79))]
	[CalledBy(Type = "Game.DuelManager+<OnWin>d__113", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<HandleGameUpdate>d__98", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<OnWaitingSide>d__67", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<OnSelectTp>d__60", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<OnSelectHand>d__58", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<OnJoinGame>d__56", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<OnHandResult>d__59", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelZone+<PrepareDuel>d__77", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelZone+<OnExit>d__90", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<EndConnection>d__39", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelEnd+<GoBackToGameRoom>d__44", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit+<CreateEditor>d__305", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.LifePoints+<CheckLPTrigger>d__27", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Lobby.LobbyScreen+<OnDeckEdit>d__139", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Lobby.LobbyScreen+<GoToLobby>d__135", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Lobby.GameRoom+<LoadGameRoomBack>d__85", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Menu.MainMenu+<ToMainMenu>d__35", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Menu.MainMenu+<OnClickDeckEdit>d__36", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelEnd+<OnLeave>d__41", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ChangeScene>d__79)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ChangeScene>d__79&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Task ChangeScene(SceneType type) { }

	[AsyncStateMachine(typeof(<CleanMemory>d__132))]
	[CalledBy(Type = "Data.CustomTheme+<PostThemeSelectionOperations>d__30", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CleanMemory>d__132)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CleanMemory>d__132&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task CleanMemory() { }

	[CalledBy(Type = typeof(<DatabaseDeserialize>d__126), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Localization+<CardLocaleInit>d__37", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Manager), Member = "get_TemporaryDBPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(File), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(File), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public static void CleanTempDB() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "FindObjectsByType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FindObjectsSortMode)}, ReturnType = "T[]")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public static void CloseAllMessageBoxes() { }

	[CalledBy(Type = typeof(DuelEnd), Member = "GoBackToLobby", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DiscordController), Member = "OnActivityJoin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Helper), Member = "OnCorruptedState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<EndConnection>d__39", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<OnChangeSide>d__66", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<OnDuelStart>d__71", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<OnJoinGame>d__56", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Network), Member = "OnLeaveGame", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.P2PManager+<DisconnectP2P>d__27", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<HandleGameUpdate>d__98", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CardOptionList), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CardListDisplay), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(AttributeSelection), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(DuelEnd), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(DisplayCard), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "FindObjectsByType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FindObjectsSortMode)}, ReturnType = "T[]")]
	[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Janken), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(DeckEdit), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(SelectCardPosition), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(ManualStatus), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(RaceSelection), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(InfoBox), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(DuelZone), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(DeckSelection), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(OptionBox), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(TextBox), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameRoom), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(LobbyScreen), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Shop), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(ReplayList), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(SettingsMenu), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(MainMenu), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(MultiPick), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GeneralSelection), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[CallsUnknownMethods(Count = 98)]
	public static void CloseAllScreens(bool keepSiding = false, bool keepEditor = false) { }

	[CallerCount(Count = 143)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Helper), Member = "IsPreloaded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(General), Member = "ClearTweens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Helper), Member = "UnloadImages", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public static void CloseScreen(Object[] screens) { }

	[AsyncStateMachine(typeof(<CloseScreen>d__129))]
	[CalledBy(Type = "Game.DuelManager+<OnHandResult>d__193", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CloseScreen>d__129)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CloseScreen>d__129&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void CloseScreen(float timer = 0, Object[] screens) { }

	[AsyncStateMachine(typeof(<DatabaseDeserialize>d__126))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DatabaseDeserialize>d__126)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DatabaseDeserialize>d__126&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task DatabaseDeserialize(bool isUpdate) { }

	[CalledBy(Type = "Manager.Updater+<UpdateBadWords>d__37", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void DefineFilterWords(String[] filters) { }

	[CalledBy(Type = typeof(ReplayList), Member = "SetButtonArt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	public static bool DefineImageSprite(Sprite sprite, object target) { }

	[CalledBy(Type = "Scenes.Menu.SettingsMenu+<ApplyGraphics>d__131", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Screen), Member = "SetResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Helper), Member = "SaveResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	public static void DefineResolution(int width, int height, bool fullScreen, bool save) { }

	[AsyncStateMachine(typeof(<DeserializeFile>d__118`1))]
	[CalledBy(Type = "Scenes.Menu.ReplayList+<<OnClickPlay>g__playSelected|43_0>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Menu.ReplayList+<OnGetDecks>d__54", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Customization+<LoadPlayerData>d__36", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReserializeAllData>d__100`1), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.ImageHandler+<Initialize>d__5", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Data.CustomTheme+<ApplyCurrentTheme>d__29", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Manager.Helper+<DeserializeFile>d__118`1<System.Object>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DeserializeFile>d__118`1<Object>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static Task<T> DeserializeFile(string fileName, bool binaryOnly = false) { }

	[AsyncStateMachine(typeof(<DoCFGHit>d__143))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoCFGHit>d__143)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoCFGHit>d__143&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void DoCFGHit() { }

	[AsyncStateMachine(typeof(<DoGetRequest>d__144`1))]
	[CalledBy(Type = "Card.DeckAPI+<RequestAPIDeck>d__12", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.DeckAPI+<RequestURLDecks>d__14", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Manager.Helper+<DoGetRequest>d__144`1<System.Object>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoGetRequest>d__144`1<Object>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static Task<T> DoGetRequest(string url) { }

	[AsyncStateMachine(typeof(<DoGetString>d__142))]
	[CalledBy(Type = "Scenes.Menu.AboutScreen+<UpdateCredits>d__12", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Menu.MainMenu+<Start>d__43", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<DoGetRequest>d__144`1), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.NATHandler+<GetExternalAddress>d__3", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<GatherResourcesLinks>d__72", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<GetHash>d__46", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<UpdateBadWords>d__37", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoGetString>d__142)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoGetString>d__142&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Task<String> DoGetString(Uri url) { }

	[AsyncStateMachine(typeof(<DoGetStrings>d__141))]
	[CalledBy(Type = typeof(<DoCFGHit>d__143), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoGetStrings>d__141)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoGetStrings>d__141&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Task<String> DoGetStrings(string url) { }

	[AsyncStateMachine(typeof(<DoPostRequest>d__140`1))]
	[CalledBy(Type = "Card.DeckAPI+<RequestAutoDeck>d__13", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Manager.Helper+<DoPostRequest>d__140`1<System.Object>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoPostRequest>d__140`1<Object>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public static Task<T> DoPostRequest(string url, string post) { }

	[CalledBy(Type = typeof(Network), Member = "OnChatMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(UserRank), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RoomCard), Member = "PostSetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Player), Member = "get_Username", ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Filter), Member = "Censor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public static string FilterStringWords(string str) { }

	[CalledBy(Type = typeof(<LoadAsset>d__66`1), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Helper), Member = "IndexBundles", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AssetBundle), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private string FindAssetInBundles(string bundlePartialName, string assetName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(P2PManager), Member = "FixedUpdateTick", ReturnType = typeof(void))]
	[Calls(Type = typeof(Application), Member = "get_isMobilePlatform", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SettingsMenu), Member = "UpdateResolutions", ReturnType = typeof(void))]
	[Calls(Type = typeof(Screen), Member = "get_fullScreen", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Helper), Member = "SaveResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void FixedUpdate() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public static void GameVersionChangedFirstStartup() { }

	[CallerCount(Count = 0)]
	public static float get_ANIMATION_TIMER() { }

	[CalledBy(Type = typeof(DuelField), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelField), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static Camera get_BaseCamera() { }

	[CalledBy(Type = "Scenes.Menu.ReplayList+<<OnClickPlay>g__playClipboard|43_1>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReplayList), Member = "OnClickImport", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GUIUtility), Member = "get_systemCopyBuffer", ReturnType = typeof(string))]
	public static string get_Clipboard() { }

	[CalledBy(Type = "Scenes.Battle.DuelZone+<DoParse>d__145", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static float get_DEF_AT() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	private static bool get_HasResolutionChanged() { }

	[CalledBy(Type = "Manager.Updater+<UnpackUpdate>d__93", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Updater), Member = "RunLinuxBashCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Updater), Member = "ExtractUpdaterInTemp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileInfo)}, ReturnType = typeof(DirectoryInfo))]
	[CalledBy(Type = typeof(Updater), Member = "MoveUpdaterFromTemp", ReturnType = typeof(DirectoryInfo))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[ContainsUnimplementedInstructions]
	public static bool get_IsLinux() { }

	[CalledBy(Type = "Manager.Updater+<HandleGameUpdate>d__98", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<UnpackUpdate>d__93", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Updater), Member = "FindFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(FileSystemInfo))]
	[CalledBy(Type = typeof(Updater), Member = "RunMacBashCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Updater), Member = "ExtractUpdaterInTemp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileInfo)}, ReturnType = typeof(DirectoryInfo))]
	[CalledBy(Type = typeof(Updater), Member = "MoveUpdaterFromTemp", ReturnType = typeof(DirectoryInfo))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[ContainsUnimplementedInstructions]
	public static bool get_IsMac() { }

	[CalledBy(Type = typeof(OmegaAndroidPlugin), Member = "RunJavaTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[ContainsUnimplementedInstructions]
	public static bool get_IsMainThread() { }

	[CallerCount(Count = 0)]
	public static bool get_IsSpectatorMode() { }

	[CalledBy(Type = typeof(CoreAPI), Member = "DefineNativeCore", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[ContainsUnimplementedInstructions]
	public static bool get_IsWindows() { }

	[CallerCount(Count = 44)]
	[CallsUnknownMethods(Count = 1)]
	public static Camera get_MainCamera() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static bool get_NoPopupNotifications() { }

	[CallerCount(Count = 0)]
	public static string get_Pointer() { }

	[AsyncStateMachine(typeof(<GetAsset>d__76`1))]
	[CalledBy(Type = typeof(<GetAssetFromBundle>d__75`1), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<LoadAsset>d__66`1), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TStateMachine&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	private Task GetAsset(AssetType bundle, string name, Action<T, Object> onFinish, object callBack, object cb2 = null) { }

	[AsyncStateMachine(typeof(<GetAssetFromBundle>d__75`1))]
	[CalledBy(Type = typeof(<PostLoading>d__113), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Manager.Helper+<GetAssetFromBundle>d__75`1<System.Object>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetAssetFromBundle>d__75`1<Object>&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	private void GetAssetFromBundle(AssetType bundle, string name, Action<T, Object> onFinish, object callBack = null, object cb2 = null) { }

	[CalledBy(Type = typeof(FieldSlot), Member = "UpdateSlotInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SpriteAtlas), Member = "GetSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Helper), Member = "SetImageSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void GetCounterImage(ushort counter, ref Image target) { }

	[CalledBy(Type = typeof(<LoadAsset>d__66`1), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DuelField), Member = "GetReplacementSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SpriteAtlas), Member = "GetSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Sprite))]
	[CallsUnknownMethods(Count = 1)]
	private Sprite GetSpriteFromAtlas(string name, AssetType type) { }

	[AsyncStateMachine(typeof(<GetTextureFromWeb>d__145))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetTextureFromWeb>d__145)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetTextureFromWeb>d__145&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Task<Texture2D> GetTextureFromWeb(string url) { }

	[CalledBy(Type = typeof(Shop), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Localization), Member = "GetSpellTrapTypeSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Template), Member = "BuildCardDescription", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Template), Member = "DefineStars", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	public static string GetTMProSprite(string name, int idx = 0) { }

	[CalledBy(Type = "Game.DuelManager+<OnSelectSum>d__182", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	public static string GetTMProSprite(string name, string color, int idx = 0) { }

	[CalledBy(Type = typeof(<PostLoading>d__113), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Manager), Member = "GetAllCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(System.Func`2<Card.Card, System.Boolean>)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<Card.Card>))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Helper), Member = "FindAssetInBundles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CardAnimationPlayer), Member = "GetSkeletonDataAssetName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 16)]
	private static void IndexBundles() { }

	[AsyncStateMachine(typeof(<Init>d__98))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Init>d__98)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Init>d__98&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private Task<Boolean> Init() { }

	[CalledBy(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DeckEdit), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LobbyScreen), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(DeckSelection), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(MainMenu), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(ReplayList), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	public static bool IsPreloaded(GameObject g) { }

	[AsyncStateMachine(typeof(<LoadAsset>d__66`1))]
	[CallerCount(Count = 122)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Manager.Helper+<LoadAsset>d__66`1<System.Object>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadAsset>d__66`1<Object>&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public void LoadAsset(AssetType type, string name, Action<T, Object> onFinish, object callBack = null) { }

	[AsyncStateMachine(typeof(<LoadAsset>d__65`1))]
	[CalledBy(Type = "Card.Template+<DefineArt>d__151", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<LoadAsset>d__65`1), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardDataLog), Member = "LoadArt", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogCardEntry), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardDataLog)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.ArtDisplay+<ProcessEvent>d__28", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "DefineDeckCardButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit+<OnEnable>d__310", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit+<OnSaveButton>d__372", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.Hologram+<DefineHologram>d__16", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "OnRoomSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(RoomCard)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "DefineMMArts", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "ShowCurrentDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameRoom), Member = "SetSelectedDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hologram), Member = "SetHologram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Manager.Helper+<LoadAsset>d__65`1<System.Object>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadAsset>d__65`1<Object>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public void LoadAsset(AssetType type, int id, Action<T, Object> onFinish, object callBack = null) { }

	[AsyncStateMachine(typeof(<LoadPointer>d__21))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadPointer>d__21)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadPointer>d__21&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void LoadPointer() { }

	[CalledBy(Type = typeof(SettingsMenu), Member = "<OnResetButton>b__148_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<Start>d__108), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CameraController), Member = "InitCameraDefaults", ReturnType = typeof(void))]
	[Calls(Type = typeof(QualitySettings), Member = "set_vSyncCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Application), Member = "set_targetFrameRate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FPSData), Member = "DefineDisplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FPSMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WebServer), Member = "set_EnableClientAPI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Helper), Member = "set_IsSpectatorMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelZone), Member = "set_FieldSpellBG", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldBGMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SettingsMenu), Member = "ApplyQuality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelManager), Member = "set_GameSpeed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Time), Member = "set_timeScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Tooltip), Member = "set_EnableTooltips", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelZone), Member = "set_DisplayCardSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hologram), Member = "DefineScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Updater), Member = "set_UpdateServer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(DuelField), Member = "SetCurrentField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedField)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Player), Member = "set_SafeOpt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClientCard), Member = "set_ShowLevelInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Application), Member = "get_isMobilePlatform", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Screen), Member = "set_sleepTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Screen), Member = "set_autorotateToLandscapeRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Screen), Member = "set_autorotateToLandscapeLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Screen), Member = "set_autorotateToPortraitUpsideDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Screen), Member = "set_autorotateToPortrait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DiscordController), Member = "get_IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Screen), Member = "SetResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Screen), Member = "set_orientation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScreenOrientation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Sound), Member = "set_SoundDisabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void LoadPrefs() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void LoadSpriteAtlas(SpriteAtlas atlas, AssetType type) { }

	[AsyncStateMachine(typeof(<NetworkCheck>d__102))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<NetworkCheck>d__102)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<NetworkCheck>d__102&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private Task<Boolean> NetworkCheck() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WebServer), Member = "Close", ReturnType = typeof(void))]
	private void OnApplicationQuit() { }

	[CalledBy(Type = typeof(<DatabaseDeserialize>d__126), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "CloseAllScreens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	public static void OnCorruptedState(bool forceClose) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sound), Member = "set_SoundMuted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	private void OnFocusChange(bool focused) { }

	[CalledBy(Type = typeof(AboutScreen), Member = "OnClickDonate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DisplayCard), Member = "OnTapBuy", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<HandleGameUpdate>d__98", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DiscordController), Member = "RequestAuthentication", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AuthMethod), typeof(System.Action`1<System.String>)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckSelection+<OnClickStatistics>d__67", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Shop), Member = "OnThemes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "<UpdateSelectedRoomInfo>b__120_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "OnTournamentButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChatWindow), Member = "ParseChatCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "OnRankingButton", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Menu.SettingsMenu+<>c", Member = "<Start>b__126_0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MainMenu), Member = "OnClickPartnerTCGPlayer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "OnPlayerInfo", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MainMenu), Member = "OnHelpClicked", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MainMenu), Member = "OnDiscordClicked", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AboutScreen), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AboutScreen), Member = "OnClickDiscord", ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(OmegaAndroidPlugin), Member = "OpenPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(OptionBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>), typeof(string), typeof(Template)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Application), Member = "OpenURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void OpenURL(string url, bool direct = false) { }

	[AsyncStateMachine(typeof(<PostLoading>d__113))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<PostLoading>d__113)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<PostLoading>d__113&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void PostLoading() { }

	[AsyncStateMachine(typeof(<Preload>d__115))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Preload>d__115)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Preload>d__115&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task Preload() { }

	[CalledBy(Type = typeof(MainMenu), Member = "<OnClickExit>b__28_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LoadingInfo), Member = "<OnClickQuitButton>b__16_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<Init>d__98), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<HandleGameUpdate>d__98", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<UnpackUpdate>d__93", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(PlayerPrefs), Member = "Save", ReturnType = typeof(void))]
	[Calls(Type = typeof(Application), Member = "Quit", ReturnType = typeof(void))]
	public static void QuitGame() { }

	[AsyncStateMachine(typeof(<ReadAllBytes>d__147))]
	[CalledBy(Type = "Manager.Customization+<GetCustomCursor>d__43", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Customization+<GetCustomImage>d__61", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<DeserializeFile>d__118`1), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Localization+<LoadNewLanguage>d__16", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.CardAnimationPlayer+<GetTextures>d__34", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Data.ClientReplay+<ExportCode>d__16", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Data.CustomTheme+<LoadFiles>d__37", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Data.CustomTheme+<LoadThemeResourcesFromDisk>d__38", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadAllBytes>d__147)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadAllBytes>d__147&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Task<Byte[]> ReadAllBytes(string path) { }

	[AsyncStateMachine(typeof(<ReadAllLines>d__149))]
	[CalledBy(Type = "Scenes.Deck.DeckSelection+<ImportFromCSV>d__74", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadAllLines>d__149)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadAllLines>d__149&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Task<String[]> ReadAllLines(string path) { }

	[AsyncStateMachine(typeof(<ReadAllText>d__148))]
	[CalledBy(Type = "Manager.Customization+<GetLogText>d__30", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<CheckForDatasUpdate>d__50", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.CardAnimationPlayer+<GetTextAsset>d__27", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Deck+<ParseYDK>d__64", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadAllText>d__148)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadAllText>d__148&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Task<String> ReadAllText(string path) { }

	[AsyncStateMachine(typeof(<ReserializeAllData>d__100`1))]
	[CalledBy(Type = typeof(<Init>d__98), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Manager.Helper+<ReserializeAllData>d__100`1<System.Object>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReserializeAllData>d__100`1<Object>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static Task ReserializeAllData(string path, string ext) { }

	[AsyncStateMachine(typeof(<ReserializeSingleData>d__101`1))]
	[CalledBy(Type = typeof(<BinaryDeserialize>d__120`1), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Manager.Helper+<ReserializeSingleData>d__101`1<System.Object>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReserializeSingleData>d__101`1<Object>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static Task ReserializeSingleData(string path, T data) { }

	[CalledBy(Type = typeof(Helper), Member = "DefineResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Helper), Member = "FixedUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	public static void SaveResolution(int width, int height, bool fullScreen) { }

	[AsyncStateMachine(typeof(<SerializeData>d__121`1))]
	[CalledBy(Type = typeof(<SerializeFile>d__122`1), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Data.Banlist+<CreateBanlistPacket>d__78", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Manager.Helper+<SerializeData>d__121`1<System.Object>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SerializeData>d__121`1<Object>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public static Task<Byte[]> SerializeData(T target) { }

	[AsyncStateMachine(typeof(<SerializeFile>d__122`1))]
	[CalledBy(Type = "Scenes.Battle.DuelEnd+<StoreReplayOnDisk>d__47", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Customization+<SavePlayerData>d__37", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReserializeSingleData>d__101`1), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.ImageHandler+<SerializeHashSet>d__9", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Data.CustomTheme+<SaveToDisk>d__36", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Manager.Helper+<SerializeFile>d__122`1<System.Object>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SerializeFile>d__122`1<Object>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static Task SerializeFile(string fileName, T target) { }

	[CallerCount(Count = 0)]
	public static void set_ANIMATION_TIMER(float value) { }

	[CalledBy(Type = "Scenes.Menu.ReplayList+<OnClickExport>d__52", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.ChatWindow+<OnClickRoomPwd>d__48", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LifePoints), Member = "OnClickLPBar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckSelection+<DeckSync>d__52", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckSelection), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Hotkey+<CopyDeckToClipboard>d__85", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Hotkey+<CopyLogToClipboard>d__84", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CopyableCardText), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(GUIUtility), Member = "set_systemCopyBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Localization), Member = "GetClientMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	public static void set_Clipboard(string value) { }

	[CalledBy(Type = "Scenes.Menu.MainMenu+<Start>d__43", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Lobby.LobbyScreen+<SpectateRandomRoom>d__132", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Helper), Member = "LoadPrefs", ReturnType = typeof(void))]
	[CalledBy(Type = "ClientAPI.WebServer+<OnSpectatorMode>d__28", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InfoBox), Member = "OnClickConfirm", ReturnType = typeof(void))]
	[Calls(Type = typeof(LobbyScreen), Member = "get_IsActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MainMenu), Member = "get_IsActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MainMenu), Member = "OnClickOnline", ReturnType = typeof(void))]
	[Calls(Type = typeof(LobbyScreen), Member = "SpectateRandomRoom", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static void set_IsSpectatorMode(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static void set_NoPopupNotifications(bool value) { }

	[CalledBy(Type = typeof(ChatWindow), Member = "OnDragBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass164_0", Member = "<OnSelectCard>g__finishClick|0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChatWindow), Member = "OnEndDragBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelZone+<CloseAllDuelWindows>d__79", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "SetUpOptimizedView", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "DragDisplayCardBorderEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<Start>d__108), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "DragDisplayCardBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSelectCard>d__164", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelManager), Member = "PostInternalOnSelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Card.ClientCard>), typeof(System.Collections.Generic.List`1<Card.ClientCard>), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DragClone), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DragClone), Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DraggableFrame), Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DraggableFrame), Member = "ResetCursor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DragClone), Member = "ResetCursor", ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadPointer>d__21)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadPointer>d__21&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static void set_Pointer(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static void SetButtonArt(Sprite spr, object tgt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Selectable), Member = "set_spriteState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteState)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void SetButtonSpriteState(Sprite sprite, object target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Screen), Member = "set_sleepTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public static void SetDisplayNeverSleep(bool enabled) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void SetFontMaterial(Material mtr, object target) { }

	[CalledBy(Type = "Scenes.Menu.SettingsMenu+<ApplyGraphics>d__131", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QualitySettings), Member = "set_vSyncCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Application), Member = "set_targetFrameRate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public static void SetFPS(int fps) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void SetImageMaterial(Material mtr, object target) { }

	[CalledBy(Type = typeof(Hologram), Member = "SetHologram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogAddCounter), Member = "CounterLoaded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogRemoveCounter), Member = "CounterLoaded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Helper), Member = "GetCounterImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(Image&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Helper), Member = "SetImageSpriteAndEnable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "set_type", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void SetImageSprite(Sprite sprite, object target) { }

	[CalledBy(Type = typeof(Template), Member = "DefineCover", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "SetImageSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void SetImageSpriteAndEnable(Sprite sprite, object target) { }

	[CalledBy(Type = typeof(SettingsMenu), Member = "ApplyGameplay", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "set_timeScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	public static void SetTimeScale(int rate, bool save = true) { }

	[CalledBy(Type = typeof(MainMenu), Member = "OnClickOnline", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MainMenu), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<HandleGameUpdate>d__98", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<UpdateBundles>d__38", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Background), Member = "SetSceneBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	public void ShowLoadingScreen() { }

	[AsyncStateMachine(typeof(<Start>d__108))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Start>d__108)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Start>d__108&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void Start() { }

	[CalledBy(Type = typeof(ReplayList), Member = "<OnClickDeleteAll>b__46_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Customization+<ExportAllDecksToYDK>d__73", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Customization+<UnpackThemeFiles>d__44", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Customization), Member = "StructureThemeDirectories", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Customization), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<UnpackUpdate>d__93", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Updater), Member = "ExtractUpdaterInTemp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileInfo)}, ReturnType = typeof(DirectoryInfo))]
	[CallerCount(Count = 45)]
	[Calls(Type = typeof(Application), Member = "get_isMobilePlatform", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DirectoryInfo))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void StructureDirectory(string dir) { }

	[CalledBy(Type = "Scenes.Menu.SettingsMenu+<ApplyGraphics>d__131", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ToggleBatterySaving(bool enabled) { }

	[AsyncStateMachine(typeof(<TryUnpackDB>d__124))]
	[CalledBy(Type = typeof(<DatabaseDeserialize>d__126), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<TryUnpackDB>d__124), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Localization+<CardLocaleInit>d__37", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<TryUnpackDB>d__124)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<TryUnpackDB>d__124&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task<Boolean> TryUnpackDB(bool retry) { }

	[CalledBy(Type = typeof(Customization), Member = "ClearCustomThemeFiles", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Helper), Member = "UnloadImages", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public static void UnloadImage(IEnumerable<Sprite> imgs) { }

	[CalledBy(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "UnloadImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Sprite>)}, ReturnType = typeof(void))]
	public static void UnloadImages(Sprite[] imgs) { }

	[CalledBy(Type = typeof(CameraController), Member = "InitCameraDefaults", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraController), Member = "SetCameraToSliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DuelField), Member = "ConfigureCamera", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void UpdateCamera(Vector3 position, Vector3 rotation) { }

	[AsyncStateMachine(typeof(<WriteAllBytes>d__150))]
	[CalledBy(Type = "Scenes.Menu.ReplayList+<>c__DisplayClass49_0+<<ImportReplay>b__0>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Customization+<UnpackThemeFiles>d__44", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<SerializeFile>d__122`1), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<>c__DisplayClass68_0+<<OnReceiveServerReplay>b__1>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<DownloadFile>d__99", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<DownloadManifestPart>d__29", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteAllBytes>d__150)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteAllBytes>d__150&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static Task WriteAllBytes(string path, Byte[] data) { }

	[AsyncStateMachine(typeof(<WriteAllText>d__151))]
	[CalledBy(Type = "Manager.Customization+<ExportAllDecksToCSV>d__75", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Customization+<ExportAllDecksToYDK>d__73", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Customization+<ExportAllReplays>d__78", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<UpdateDatasFile>d__47", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteAllText>d__151)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteAllText>d__151&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static Task WriteAllText(string path, string text) { }

}

