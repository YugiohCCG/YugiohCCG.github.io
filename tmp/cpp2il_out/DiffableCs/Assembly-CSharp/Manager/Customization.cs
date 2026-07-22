namespace Manager;

[Extension]
public static class Customization
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<FileInfo, Boolean> <>9__35_0; //Field offset: 0x8
		public static Func<FileInfo, DateTime> <>9__35_1; //Field offset: 0x10
		public static Func<FileInfo, Boolean> <>9__35_2; //Field offset: 0x18
		public static Func<FileInfo, DateTime> <>9__35_3; //Field offset: 0x20
		public static Func<FileInfo, Boolean> <>9__46_0; //Field offset: 0x28
		public static Func<FileInfo, Boolean> <>9__54_0; //Field offset: 0x30
		public static Func<FileInfo, Boolean> <>9__55_0; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FileSystemInfo), Member = "get_Extension", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal bool <BackupPlayerData>b__35_0(FileInfo fi) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FileSystemInfo), Member = "get_CreationTimeUtc", ReturnType = typeof(DateTime))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal DateTime <BackupPlayerData>b__35_1(FileInfo fi) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FileSystemInfo), Member = "get_Extension", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal bool <BackupPlayerData>b__35_2(FileInfo fi) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FileSystemInfo), Member = "get_CreationTimeUtc", ReturnType = typeof(DateTime))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal DateTime <BackupPlayerData>b__35_3(FileInfo fi) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FileSystemInfo), Member = "get_Extension", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal bool <GetCustomDatabaseFiles>b__46_0(FileInfo fi) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal bool <GetCustomPlaymat>b__55_0(FileInfo fi) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal bool <GetCustomSleeve>b__54_0(FileInfo fi) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass48_0
	{
		public Action<Boolean, FileInfo[]> onFinish; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass48_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FileInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LockScreen), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		[ContainsUnimplementedInstructions]
		internal void <OpenFileBrowserDialogAsync>b__0(String[] paths) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LockScreen), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		internal void <OpenFileBrowserDialogAsync>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass70_0
	{
		public string sfx; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass70_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FileSystemInfo), Member = "get_Extension", ReturnType = typeof(string))]
		[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal bool <GetCustomSFX>b__0(FileInfo fi) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FileSystemInfo), Member = "get_Extension", ReturnType = typeof(string))]
		[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal bool <GetCustomSFX>b__1(FileInfo fi) { }

	}

	[CompilerGenerated]
	private struct <BackupPlayerData>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private string <timed>5__2; //Field offset: 0x20
		private string <tmpFile>5__3; //Field offset: 0x28
		private TaskAwaiter<String> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
		[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
		[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(DateTime)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.DateTime>)}, ReturnType = typeof(System.Linq.IOrderedEnumerable`1<System.Object>))]
		[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[Calls(Type = typeof(General), Member = "GetFileList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DirectoryInfo)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileInfo>))]
		[Calls(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(File), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.Customization+<ExportAllDecksToCSV>d__75"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ExportAllDecksToCSV>d__75&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(File), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(File), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(File), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 20)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ExportAllDecksToCSV>d__75 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public string fileName; //Field offset: 0x20
		private List<String> <headers>5__2; //Field offset: 0x28
		private List<String> <data>5__3; //Field offset: 0x30
		private Dictionary<String, ValueTuple`2<String, String>> <decks>5__4; //Field offset: 0x38
		private string <path>5__5; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "WriteAllText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Customization), Member = "WriteCSV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.String>), typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
		[Calls(Type = typeof(Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.Customization+<ExportSingleDeckToCSV>d__74"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ExportSingleDeckToCSV>d__74&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "System.Collections.Generic.KeyValuePair`2<TKey, TValue>")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(SortedDictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.SortedDictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Task), Member = "WhenAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)}, ReturnType = typeof(Task))]
		[CallsDeduplicatedMethods(Count = 12)]
		[CallsUnknownMethods(Count = 46)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ExportAllDecksToYDK>d__73 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public string fileName; //Field offset: 0x20
		private string <folder>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ZipFile), Member = "CreateFromDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task), Member = "WhenAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "WriteAllText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Deck), Member = "get_YDK", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(General), Member = "FixFileName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "System.Collections.Generic.KeyValuePair`2<TKey, TValue>")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(SortedDictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.SortedDictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
		[Calls(Type = typeof(Helper), Member = "StructureDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Directory), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Application), Member = "get_temporaryCachePath", ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 15)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ExportAllReplays>d__78 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string fileName; //Field offset: 0x20
		private List<String> <headers>5__2; //Field offset: 0x28
		private List<String> <data>5__3; //Field offset: 0x30
		private Dictionary<String, String> <rps>5__4; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "WriteAllText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Customization), Member = "WriteCSV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.String>), typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
		[Calls(Type = typeof(Task), Member = "WhenAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.Customization+<ExportSingleReplay>d__77"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ExportSingleReplay>d__77&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(General), Member = "GetNameWithoutExtension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileInfo)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(General), Member = "GetFileList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DirectoryInfo)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileInfo>))]
		[Calls(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 13)]
		[CallsUnknownMethods(Count = 43)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ExportSingleDeckToCSV>d__74 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Dictionary<String, ValueTuple`2<String, String>> decks; //Field offset: 0x20
		public KeyValuePair<String, Deck> kvp; //Field offset: 0x28
		private Dictionary<String, ValueTuple`2<String, String>> <>7__wrap1; //Field offset: 0x38
		private string <>7__wrap2; //Field offset: 0x40
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Deck), Member = "GetHash", ReturnType = typeof(System.Threading.Tasks.Task`1<System.String>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(Deck), Member = "get_Tags", ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.ValueTuple`2<System.Object, System.Object>>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(System.ValueTuple`2<System.Object, System.Object>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 10)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ExportSingleReplay>d__77 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Dictionary<String, String> rps; //Field offset: 0x20
		public string name; //Field offset: 0x28
		private Dictionary<String, String> <>7__wrap1; //Field offset: 0x30
		private string <>7__wrap2; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ClientReplay), Member = "ExportCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.String>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 8)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetCustomArt>d__56 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ValueTuple`2<Boolean, Sprite>> <>t__builder; //Field offset: 0x8
		public string name; //Field offset: 0x20
		private TaskAwaiter<ValueTuple`2<Boolean, Sprite>> <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Customization), Member = "GetCustomImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.ValueTuple`2<System.Boolean, UnityEngine.Sprite>>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`2<System.Boolean, System.Object>>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<System.Boolean, System.Object>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`2<System.Boolean, System.Object>>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetCustomCursor>d__43 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ValueTuple`2<Boolean, Texture2D>> <>t__builder; //Field offset: 0x8
		public string name; //Field offset: 0x20
		private Texture2D <t>5__2; //Field offset: 0x28
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(File), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Helper), Member = "ReadAllBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Threading.Tasks.Task`1<Byte[]>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ImageConversion), Member = "LoadImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Byte[])}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`2<System.Boolean, System.Object>>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<System.Boolean, System.Object>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`2<System.Boolean, System.Object>>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetCustomHologram>d__62 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ValueTuple`2<Boolean, Sprite>> <>t__builder; //Field offset: 0x8
		public string name; //Field offset: 0x20
		private TaskAwaiter<ValueTuple`2<Boolean, Sprite>> <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Customization), Member = "GetCustomImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.ValueTuple`2<System.Boolean, UnityEngine.Sprite>>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`2<System.Boolean, System.Object>>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<System.Boolean, System.Object>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`2<System.Boolean, System.Object>>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetCustomImage>d__61 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ValueTuple`2<Boolean, Sprite>> <>t__builder; //Field offset: 0x8
		public string path; //Field offset: 0x20
		public bool compress; //Field offset: 0x28
		public bool readable; //Field offset: 0x29
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(File), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Helper), Member = "ReadAllBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Threading.Tasks.Task`1<Byte[]>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(Customization), Member = "GetCustomImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string), typeof(bool), typeof(bool), typeof(Sprite&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`2<System.Boolean, System.Object>>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<System.Boolean, System.Object>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`2<System.Boolean, System.Object>>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetCustomPlaymat>d__55 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ValueTuple`2<Boolean, Sprite>> <>t__builder; //Field offset: 0x8
		private TaskAwaiter<ValueTuple`2<Boolean, Sprite>> <>u__1; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Customization), Member = "GetPrefered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileInfo&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Customization), Member = "GetRandomFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DirectoryInfo), typeof(System.Func`2<System.IO.FileInfo, System.Boolean>), typeof(FileInfo&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Customization), Member = "GetCustomImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.ValueTuple`2<System.Boolean, UnityEngine.Sprite>>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`2<System.Boolean, System.Object>>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<System.Boolean, System.Object>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`2<System.Boolean, System.Object>>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 6)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetCustomSleeve>d__54 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ValueTuple`2<Boolean, Sprite>> <>t__builder; //Field offset: 0x8
		private TaskAwaiter<ValueTuple`2<Boolean, Sprite>> <>u__1; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Customization), Member = "GetPrefered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileInfo&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Customization), Member = "GetRandomFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DirectoryInfo), typeof(System.Func`2<System.IO.FileInfo, System.Boolean>), typeof(FileInfo&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Customization), Member = "GetCustomImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.ValueTuple`2<System.Boolean, UnityEngine.Sprite>>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`2<System.Boolean, System.Object>>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<System.Boolean, System.Object>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`2<System.Boolean, System.Object>>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 6)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetLogText>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		private TaskAwaiter<String> <>u__1; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Customization), Member = "get_LogPath", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FileInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "ReadAllText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.String>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadCustomThemeFiles>d__42 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public bool otm; //Field offset: 0x20
		private IEnumerator<FileInfo> <>7__wrap1; //Field offset: 0x28
		private FileInfo <fi>5__3; //Field offset: 0x30
		private TaskAwaiter<ValueTuple`2<Boolean, Sprite>> <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(General), Member = "GetNameWithoutExtension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileInfo)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FileSystemInfo), Member = "get_Extension", ReturnType = typeof(string))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(Customization), Member = "GetCustomImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.ValueTuple`2<System.Boolean, UnityEngine.Sprite>>))]
		[Calls(Type = typeof(General), Member = "GetFileList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DirectoryInfo)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileInfo>))]
		[Calls(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 41)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadPlayerData>d__36 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter<PlayerCustomData> <>u__1; //Field offset: 0x20
		private TaskAwaiter <>u__2; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Manager.Customization+<BackupPlayerData>d__35"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<BackupPlayerData>d__35&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "System.Collections.Generic.KeyValuePair`2<TKey, TValue>")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(SortedDictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.SortedDictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
		[Calls(Type = typeof(PlayerCustomData), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(Helper), Member = "DeserializeFile", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[Calls(Type = typeof(Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 16)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OpenFileBrowserDialogAsync>d__48 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Action<Boolean, FileInfo[]> onFinish; //Field offset: 0x20
		public String[] filters; //Field offset: 0x28
		public String[] filterNames; //Field offset: 0x30
		private <>c__DisplayClass48_0 <>8__1; //Field offset: 0x38
		public string title; //Field offset: 0x40
		public string select; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LockScreen), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(Action), typeof(short)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Filter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(Filter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Collections.Generic.IEnumerable`1<SimpleFileBrowser.FileBrowser+Filter>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(String[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FileBrowser), Member = "ShowLoadDialog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OnSuccess), typeof(OnCancel), typeof(PickMode), typeof(bool), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 24)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SavePlayerData>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Helper), Member = "SerializeFile", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T"}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
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
	private struct <UnpackThemeFiles>d__44 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CustomTheme theme; //Field offset: 0x20
		private string <path>5__2; //Field offset: 0x28
		private Enumerator<String, Byte[]> <>7__wrap2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x58
		private Enumerator<String, Dictionary<String, Byte[]>> <>7__wrap3; //Field offset: 0x60

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Helper), Member = "StructureDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Customization), Member = "StructureThemeDirectories", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Helper), Member = "WriteAllBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[])}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CustomTheme), Member = "ClearTexturesData", ReturnType = typeof(void))]
		[Calls(Type = typeof(CustomTheme), Member = "ClearSoundData", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 36)]
		[CallsUnknownMethods(Count = 61)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const byte RARITY_MAX = 13; //Field offset: 0x0
	public static string BasePath; //Field offset: 0x0
	public const string BG_SUFIX = "Backgrounds"; //Field offset: 0x0
	public const string DUEL_SUFIX = "Duel"; //Field offset: 0x0
	public const string BGM_SUFIX = "BGM"; //Field offset: 0x0
	private const string PLAYER_DATA = "Player.data"; //Field offset: 0x0
	public static string BundlesPath; //Field offset: 0x8
	public static string GDataPath; //Field offset: 0x10
	public static string SleevesPath; //Field offset: 0x18
	public static string PlaymatPath; //Field offset: 0x20
	public static string BackgroundsPath; //Field offset: 0x28
	public static string ArtsPath; //Field offset: 0x30
	public static string HologramsPath; //Field offset: 0x38
	public static string BGMPath; //Field offset: 0x40
	public static string SFXPath; //Field offset: 0x48
	public static string ImportsPath; //Field offset: 0x50
	public static string ExportsPath; //Field offset: 0x58
	public static string DatabasesPath; //Field offset: 0x60
	public static string TexturesPath; //Field offset: 0x68
	public static string InterfaceTexturesPath; //Field offset: 0x70
	public static string FieldTexturesPath; //Field offset: 0x78
	public static string DuelBGPath; //Field offset: 0x80
	public static string DuelBGMPath; //Field offset: 0x88
	public static string BackupPath; //Field offset: 0x90
	public static string BanlistsPath; //Field offset: 0x98
	public static string PluginsPath; //Field offset: 0xA0
	public static string AnimationsPath; //Field offset: 0xA8
	public static PlayerCustomData PlayerData; //Field offset: 0xB0
	public static readonly Dictionary<String, Sprite> CustomInterfaceTextures; //Field offset: 0xB8
	public static readonly Dictionary<String, Sprite> CustomFieldTextures; //Field offset: 0xC0
	private static readonly Dictionary<String, Sprite> CustomTextureDictionary; //Field offset: 0xC8

	public static FileInfo LogFile
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Customization), Member = "get_LogPath", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FileInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		 get { } //Length: 181
	}

	public static string LogPath
	{
		[CalledBy(Type = typeof(<GetLogText>d__30), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Customization), Member = "get_LogFile", ReturnType = typeof(FileInfo))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Application), Member = "get_isMobilePlatform", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[Calls(Type = typeof(Application), Member = "get_companyName", ReturnType = typeof(string))]
		[Calls(Type = typeof(Application), Member = "get_productName", ReturnType = typeof(string))]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Environment), Member = "ExpandEnvironmentVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 16)]
		 get { } //Length: 1004
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private static Customization() { }

	[AsyncStateMachine(typeof(<BackupPlayerData>d__35))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<BackupPlayerData>d__35)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<BackupPlayerData>d__35&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task BackupPlayerData() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileSystemInfo), Member = "get_Extension", ReturnType = typeof(string))]
	[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static bool BGImageCheck(FileInfo fi) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileSystemInfo), Member = "get_Extension", ReturnType = typeof(string))]
	[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static bool BGMCheckDir(FileInfo fi) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileSystemInfo), Member = "get_Extension", ReturnType = typeof(string))]
	[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static bool BGVideoCheck(FileInfo fi) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static bool CanCompress(Texture2D tex) { }

	[CalledBy(Type = typeof(Customization), Member = "GetBGSTypeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Customization), Member = "GetCustomBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneType), typeof(FileInfo&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CustomTheme), Member = "get_IsDefaultTheme", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(General), Member = "GetFileList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DirectoryInfo)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileInfo>))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Background), Member = "get_IsDynamicBG", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private static bool CheckDirBG(string dir) { }

	[CalledBy(Type = typeof(Customization), Member = "GetSTypeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Customization), Member = "GetCustomBGM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneType), typeof(FileInfo&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(General), Member = "GetFileList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DirectoryInfo)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileInfo>))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	private static bool CheckDirBGM(string dir) { }

	[CalledBy(Type = "Data.CustomTheme+<LoadCurrentTheme>d__27", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "UnloadImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Sprite>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static void ClearCustomThemeFiles() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(General), Member = "GetFileList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DirectoryInfo)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileInfo>))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	public static void ClearImportFiles(Func<FileInfo, Boolean> check = null) { }

	[CalledBy(Type = typeof(Customization), Member = "GetCustomImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string), typeof(bool), typeof(bool), typeof(Sprite&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Game.CardAnimationPlayer+<GetTextures>d__34", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ImageConversion), Member = "LoadImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Byte[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Texture2D), Member = "Compress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static bool CreateTexture(Byte[] data, bool compress, bool readable, ref Texture2D newImg) { }

	[CalledBy(Type = typeof(Customization), Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Application), Member = "get_isMobilePlatform", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Application), Member = "get_dataPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(Application), Member = "get_persistentDataPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(Application), Member = "get_temporaryCachePath", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 29)]
	public static void DefinePaths() { }

	[AsyncStateMachine(typeof(<ExportAllDecksToCSV>d__75))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ExportAllDecksToCSV>d__75)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ExportAllDecksToCSV>d__75&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Task<String> ExportAllDecksToCSV(string fileName) { }

	[AsyncStateMachine(typeof(<ExportAllDecksToYDK>d__73))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ExportAllDecksToYDK>d__73)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ExportAllDecksToYDK>d__73&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Task<String> ExportAllDecksToYDK(string fileName) { }

	[AsyncStateMachine(typeof(<ExportAllReplays>d__78))]
	[CalledBy(Type = "Scenes.Menu.ReplayList+<>c+<<OnClickExportAll>b__51_0>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ExportAllReplays>d__78)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ExportAllReplays>d__78&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Task ExportAllReplays(string fileName) { }

	[AsyncStateMachine(typeof(<ExportSingleDeckToCSV>d__74))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ExportSingleDeckToCSV>d__74)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ExportSingleDeckToCSV>d__74&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static Task ExportSingleDeckToCSV(KeyValuePair<String, Deck> kvp, Dictionary<String, ValueTuple`2<String, String>> decks) { }

	[AsyncStateMachine(typeof(<ExportSingleReplay>d__77))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ExportSingleReplay>d__77)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ExportSingleReplay>d__77&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static Task ExportSingleReplay(string name, Dictionary<String, String> rps) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Customization), Member = "get_LogPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public static FileInfo get_LogFile() { }

	[CalledBy(Type = typeof(<GetLogText>d__30), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Customization), Member = "get_LogFile", ReturnType = typeof(FileInfo))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Application), Member = "get_isMobilePlatform", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(Application), Member = "get_companyName", ReturnType = typeof(string))]
	[Calls(Type = typeof(Application), Member = "get_productName", ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Environment), Member = "ExpandEnvironmentVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 16)]
	public static string get_LogPath() { }

	[CalledBy(Type = typeof(Customization), Member = "GetCustomBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneType), typeof(FileInfo&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Customization), Member = "CheckDirBG", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 4)]
	private static string GetBGSTypeString(string basePath, string stype, bool isBattle) { }

	[AsyncStateMachine(typeof(<GetCustomArt>d__56))]
	[CalledBy(Type = "Manager.Helper+<LoadAsset>d__65`1", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper+<LoadAsset>d__66`1", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`2<System.Boolean, System.Object>>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetCustomArt>d__56)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetCustomArt>d__56&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`2<System.Boolean, System.Object>>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.ValueTuple`2<System.Boolean, System.Object>>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Task<ValueTuple`2<Boolean, Sprite>> GetCustomArt(string name) { }

	[CalledBy(Type = typeof(Background), Member = "SetSceneBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetSceneName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneType)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(General), Member = "IsBattleScene", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CustomTheme), Member = "get_IsUsingCustomTheme", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Customization), Member = "GetBGSTypeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Customization), Member = "CheckDirBG", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Customization), Member = "GetRandomFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DirectoryInfo), typeof(System.Func`2<System.IO.FileInfo, System.Boolean>), typeof(FileInfo&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool GetCustomBackground(SceneType type, out FileInfo url) { }

	[CalledBy(Type = "Manager.Sound+<PlaySceneMusic>d__35", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(General), Member = "IsBattleScene", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Localization), Member = "GetSceneName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneType)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CustomTheme), Member = "get_IsUsingCustomTheme", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Customization), Member = "GetSTypeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Customization), Member = "CheckDirBGM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Customization), Member = "GetRandomFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DirectoryInfo), typeof(System.Func`2<System.IO.FileInfo, System.Boolean>), typeof(FileInfo&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool GetCustomBGM(SceneType type, out FileInfo url) { }

	[AsyncStateMachine(typeof(<GetCustomCursor>d__43))]
	[CalledBy(Type = "Manager.Helper+<LoadPointer>d__21", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`2<System.Boolean, System.Object>>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetCustomCursor>d__43)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetCustomCursor>d__43&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`2<System.Boolean, System.Object>>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.ValueTuple`2<System.Boolean, System.Object>>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Task<ValueTuple`2<Boolean, Texture2D>> GetCustomCursor(string name) { }

	[CalledBy(Type = "Card.Manager+<InitCardLocalization>d__47", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Manager+<LoadCustomDatabases>d__45", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(General), Member = "GetFileList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DirectoryInfo)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileInfo>))]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static IEnumerable<FileInfo> GetCustomDatabaseFiles() { }

	[CalledBy(Type = "Manager.Helper+<LoadAsset>d__66`1", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetCustomFieldTexture(string name, out Sprite texture) { }

	[AsyncStateMachine(typeof(<GetCustomHologram>d__62))]
	[CalledBy(Type = "Scenes.General.Hologram+<DefineHologram>d__16", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`2<System.Boolean, System.Object>>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetCustomHologram>d__62)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetCustomHologram>d__62&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`2<System.Boolean, System.Object>>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.ValueTuple`2<System.Boolean, System.Object>>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Task<ValueTuple`2<Boolean, Sprite>> GetCustomHologram(string name) { }

	[CalledBy(Type = typeof(<GetCustomImage>d__61), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Customization), Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool), typeof(bool), typeof(Texture2D&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Sprite), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Vector2)}, ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static bool GetCustomImage(Byte[] data, string name, bool compress, bool readable, out Sprite img) { }

	[AsyncStateMachine(typeof(<GetCustomImage>d__61))]
	[CalledBy(Type = "Manager.Background+<SetBG>d__28", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<GetCustomArt>d__56), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<GetCustomHologram>d__62), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<GetCustomPlaymat>d__55), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<GetCustomSleeve>d__54), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<LoadCustomThemeFiles>d__42), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`2<System.Boolean, System.Object>>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetCustomImage>d__61)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetCustomImage>d__61&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`2<System.Boolean, System.Object>>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.ValueTuple`2<System.Boolean, System.Object>>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Task<ValueTuple`2<Boolean, Sprite>> GetCustomImage(string path, bool compress, bool readable) { }

	[CalledBy(Type = "Manager.Helper+<LoadAsset>d__66`1", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetCustomInterfaceTexture(string name, out Sprite texture) { }

	[AsyncStateMachine(typeof(<GetCustomPlaymat>d__55))]
	[CalledBy(Type = "Data.Player+<UpdateMyPlaymat>d__57", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`2<System.Boolean, System.Object>>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetCustomPlaymat>d__55)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetCustomPlaymat>d__55&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`2<System.Boolean, System.Object>>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.ValueTuple`2<System.Boolean, System.Object>>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task<ValueTuple`2<Boolean, Sprite>> GetCustomPlaymat() { }

	[CalledBy(Type = "Manager.Sound+<PlaySound>d__41", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CustomTheme), Member = "get_IsUsingCustomTheme", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(General), Member = "GetFileList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DirectoryInfo)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileInfo>))]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public static bool GetCustomSFX(string sfx, out FileInfo url) { }

	[AsyncStateMachine(typeof(<GetCustomSleeve>d__54))]
	[CalledBy(Type = "Data.Player+<UpdateMySleeve>d__60", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`2<System.Boolean, System.Object>>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetCustomSleeve>d__54)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetCustomSleeve>d__54&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.ValueTuple`2<System.Boolean, System.Object>>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.ValueTuple`2<System.Boolean, System.Object>>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task<ValueTuple`2<Boolean, Sprite>> GetCustomSleeve() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(General), Member = "GetFileList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DirectoryInfo)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileInfo>))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public static bool GetImportFiles(out IEnumerable<FileInfo>& files) { }

	[AsyncStateMachine(typeof(<GetLogText>d__30))]
	[CalledBy(Type = "Manager.Hotkey+<CopyLogToClipboard>d__84", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetLogText>d__30)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetLogText>d__30&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task<String> GetLogText() { }

	[CalledBy(Type = typeof(<GetCustomPlaymat>d__55), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<GetCustomSleeve>d__54), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(File), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Path), Member = "GetInvalidPathChars", ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "get_Name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
	[Calls(Type = typeof(Enumerable), Member = "ElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(int)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	private static bool GetPrefered(string path, out FileInfo url) { }

	[CalledBy(Type = typeof(<GetCustomPlaymat>d__55), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<GetCustomSleeve>d__54), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Customization), Member = "GetCustomBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneType), typeof(FileInfo&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Customization), Member = "GetCustomBGM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneType), typeof(FileInfo&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(General), Member = "GetFileList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DirectoryInfo)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileInfo>))]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Enumerable), Member = "ElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(int)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static bool GetRandomFile(DirectoryInfo folder, Func<FileInfo, Boolean> filter, out FileInfo fi) { }

	[CalledBy(Type = typeof(Customization), Member = "GetCustomBGM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneType), typeof(FileInfo&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Customization), Member = "CheckDirBGM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 4)]
	private static string GetSTypeString(string basePath, string stype, bool isBattle) { }

	[CalledBy(Type = "Manager.Helper+<Init>d__98", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Customization), Member = "DefinePaths", ReturnType = typeof(void))]
	[Calls(Type = typeof(Helper), Member = "StructureDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(General), Member = "IsBattleScene", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Localization), Member = "GetSceneName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneType)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public static void Initialize() { }

	[AsyncStateMachine(typeof(<LoadCustomThemeFiles>d__42))]
	[CalledBy(Type = "Data.CustomTheme+<LoadCurrentTheme>d__27", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadCustomThemeFiles>d__42)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadCustomThemeFiles>d__42&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task LoadCustomThemeFiles(bool otm) { }

	[AsyncStateMachine(typeof(<LoadPlayerData>d__36))]
	[CalledBy(Type = "Card.Manager+<Init>d__38", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadPlayerData>d__36)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<LoadPlayerData>d__36&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task LoadPlayerData() { }

	[AsyncStateMachine(typeof(<OpenFileBrowserDialogAsync>d__48))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OpenFileBrowserDialogAsync>d__48)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OpenFileBrowserDialogAsync>d__48&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static Task OpenFileBrowserDialogAsync(string title, string select, String[] filterNames, String[] filters, Action<Boolean, FileInfo[]> onFinish) { }

	[AsyncStateMachine(typeof(<SavePlayerData>d__37))]
	[CalledBy(Type = "Card.Manager+<UpdateDeck>d__69", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Manager+<RenameDeck>d__72", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Manager+<RemoveFavoriteCard>d__66", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Manager+<DeleteDeck>d__67", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Manager+<DeleteAllDecks>d__68", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Manager+<AddFavoriteCard>d__64", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Manager+<CustomSleeveDeck>d__71", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Manager+<AddDeck>d__61", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Deck+<FixInvalids>d__54", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.P2PManager+<ReceiveSyncPacket>d__42", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckSelection+<OnChangeTags>d__55", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckSelection+<MassImportation>d__72", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckSelection+<>c__DisplayClass65_0+<<OnClickSleeve>b__0>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Manager+<AddDecks>d__60", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SavePlayerData>d__37)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SavePlayerData>d__37&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Task SavePlayerData() { }

	[CalledBy(Type = typeof(<UnpackThemeFiles>d__44), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Helper), Member = "StructureDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(General), Member = "IsBattleScene", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Localization), Member = "GetSceneName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneType)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private static void StructureThemeDirectories(string basePath) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileSystemInfo), Member = "get_Extension", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(General), Member = "GetNameWithoutExtension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileInfo)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Extension]
	public static string ToFileName(FileInfo fi) { }

	[AsyncStateMachine(typeof(<UnpackThemeFiles>d__44))]
	[CalledBy(Type = "Data.CustomTheme+<ApplyCurrentTheme>d__29", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<UnpackThemeFiles>d__44)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<UnpackThemeFiles>d__44&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Task UnpackThemeFiles(CustomTheme theme) { }

	[CalledBy(Type = typeof(<ExportAllDecksToCSV>d__75), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ExportAllReplays>d__78), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static string WriteCSV(List<String> headers, List<String> data) { }

}

