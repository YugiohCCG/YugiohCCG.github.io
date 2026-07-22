namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
public class JsonTextWriter : JsonWriter
{
	[CompilerGenerated]
	private struct <CloseBufferAndWriterAsync>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x20
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BufferUtils), Member = "ReturnBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(Char[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter), typeof(<CloseBufferAndWriterAsync>d__9)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter&), typeof(<CloseBufferAndWriterAsync>d__9&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoCloseAsync>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextWriter), Member = "CloseBufferAndWriterAsync", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 7)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoWriteCommentAsync>d__115 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		public string text; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonWriter), Member = "AutoCompleteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 13)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoWritePropertyNameAsync>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Task task; //Field offset: 0x20
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x28
		[Nullable(0)]
		public string name; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextWriter), Member = "WriteEscapedStringAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 10)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoWritePropertyNameAsync>d__32 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x20
		[Nullable(0)]
		public string name; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		public bool escape; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonWriter), Member = "InternalWritePropertyNameAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(JsonTextWriter), Member = "WriteEscapedStringAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 15)]
		[CallsUnknownMethods(Count = 23)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoWriteRawValueAsync>d__121 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Task task; //Field offset: 0x20
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x28
		[Nullable(0)]
		public string json; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 6)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoWriteStartArrayAsync>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Task task; //Field offset: 0x20
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(char), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
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
	private struct <DoWriteStartConstructorAsync>d__40 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		public string name; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonWriter), Member = "InternalWriteStartAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(JsonContainerType), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 14)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoWriteStartObjectAsync>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Task task; //Field offset: 0x20
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(char), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
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
	private struct <DoWriteUndefinedAsync>d__43 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Task task; //Field offset: 0x20
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
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
	private struct <DoWriteValueAsync>d__60 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public DateTime value; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DateTimeUtils), Member = "EnsureDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTimeZoneHandling)}, ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(JsonTextWriter), Member = "WriteValueToBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(Char[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 12)]
		[CallsUnknownMethods(Count = 17)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoWriteValueAsync>d__64 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public DateTimeOffset value; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(DateTimeOffset), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(JsonTextWriter), Member = "WriteValueToBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(Char[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 12)]
		[CallsUnknownMethods(Count = 17)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoWriteValueAsync>d__78 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public Guid value; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(Guid), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallsUnknownMethods(Count = 15)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoWriteValueAsync>d__97 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Task task; //Field offset: 0x20
		[Nullable(0)]
		public string value; //Field offset: 0x28
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(JsonTextWriter), Member = "WriteEscapedStringAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoWriteValueAsync>d__99 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public TimeSpan value; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(char), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(TimeSpan), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 13)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteIndentAsync>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x20
		public int newLineLen; //Field offset: 0x28
		public int currentIndentCount; //Field offset: 0x2C
		public CancellationToken cancellationToken; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(Char[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
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

	[CompilerGenerated]
	private struct <WriteIntegerValueAsync>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Task task; //Field offset: 0x20
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x28
		public ulong uvalue; //Field offset: 0x30
		public bool negative; //Field offset: 0x38
		public CancellationToken cancellationToken; //Field offset: 0x40
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(JsonTextWriter), Member = "WriteDigitsAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
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
	private struct <WriteValueInternalAsync>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Task task; //Field offset: 0x20
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x28
		[Nullable(0)]
		public string value; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
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
	private struct <WriteValueNonNullAsync>d__54 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		public Byte[] value; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextWriter), Member = "get_Base64Encoder", ReturnType = typeof(Base64Encoder))]
		[Calls(Type = typeof(Base64Encoder), Member = "EncodeAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Base64Encoder), Member = "FlushAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 12)]
		[CallsUnknownMethods(Count = 21)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteValueNotNullAsync>d__110 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Task task; //Field offset: 0x20
		[Nullable(0)]
		public JsonTextWriter <>4__this; //Field offset: 0x28
		[Nullable(0)]
		public Uri value; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
		[Calls(Type = typeof(JsonTextWriter), Member = "WriteEscapedStringAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int IndentCharBufferSize = 12; //Field offset: 0x0
	private readonly bool _safeAsync; //Field offset: 0x60
	private readonly TextWriter _writer; //Field offset: 0x68
	[Nullable(2)]
	private Base64Encoder _base64Encoder; //Field offset: 0x70
	private char _indentChar; //Field offset: 0x78
	private int _indentation; //Field offset: 0x7C
	private char _quoteChar; //Field offset: 0x80
	private bool _quoteName; //Field offset: 0x82
	[Nullable(2)]
	private Boolean[] _charEscapeFlags; //Field offset: 0x88
	[Nullable(2)]
	private Char[] _writeBuffer; //Field offset: 0x90
	[Nullable(2)]
	private IArrayPool<Char> _arrayPool; //Field offset: 0x98
	[Nullable(2)]
	private Char[] _indentChars; //Field offset: 0xA0

	[Nullable(2)]
	public IArrayPool<Char> ArrayPool
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[NullableContext(2)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		[NullableContext(2)]
		 set { } //Length: 114
	}

	private Base64Encoder Base64Encoder
	{
		[CalledBy(Type = typeof(<WriteValueNonNullAsync>d__54), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Base64Encoder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 123
	}

	public int Indentation
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 98
	}

	public char IndentChar
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 36
	}

	public char QuoteChar
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonTextWriter), Member = "UpdateCharEscapeFlags", ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 116
	}

	public bool QuoteName
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	[CalledBy(Type = typeof(JsonConvert), Member = "SerializeObjectInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(JsonSerializer)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JToken), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Formatting), typeof(JsonConverter[])}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JRaw+<CreateAsync>d__0", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSchema), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TraceJsonWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JRaw), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(JRaw))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "WriteToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<Newtonsoft.Json.Schema.JsonSchemaModel>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializer), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializer), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TraceJsonReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(JsonWriter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextWriter), Member = "UpdateCharEscapeFlags", ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public JsonTextWriter(TextWriter textWriter) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "Close", ReturnType = typeof(void))]
	[Calls(Type = typeof(BufferUtils), Member = "ReturnBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(Char[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Close() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoCloseAsync>d__8)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoCloseAsync>d__8&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "CloseAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public virtual Task CloseAsync(CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BufferUtils), Member = "ReturnBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(Char[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void CloseBufferAndWriter() { }

	[AsyncStateMachine(typeof(<CloseBufferAndWriterAsync>d__9))]
	[CalledBy(Type = typeof(<DoCloseAsync>d__8), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CloseBufferAndWriterAsync>d__9)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CloseBufferAndWriterAsync>d__9&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private Task CloseBufferAndWriterAsync() { }

	[AsyncStateMachine(typeof(<DoCloseAsync>d__8))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoCloseAsync>d__8)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoCloseAsync>d__8&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal Task DoCloseAsync(CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncUtils), Member = "CancelIfRequestedAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal Task DoFlushAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoWriteCommentAsync>d__115))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteCommentAsync>d__115)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteCommentAsync>d__115&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal Task DoWriteCommentAsync(string text, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(char), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonWriterException))]
	[CallsUnknownMethods(Count = 5)]
	internal Task DoWriteEndAsync(JsonToken token, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "get_Top", ReturnType = typeof(int))]
	[Calls(Type = typeof(JsonTextWriter), Member = "SetIndentChars", ReturnType = typeof(int))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteIndentAsync>d__13)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteIndentAsync>d__13&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(Char[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal Task DoWriteIndentAsync(CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(char), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	internal Task DoWriteIndentSpaceAsync(CancellationToken cancellationToken) { }

	[CallerCount(Count = 30)]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteValueInternalAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	internal Task DoWriteNullAsync(CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWritePropertyNameAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncUtils), Member = "IsCompletedSuccessfully", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteEscapedStringAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JavaScriptUtils), Member = "WriteCharAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(TextWriter), typeof(char), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(char), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWritePropertyNameAsync>d__30)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWritePropertyNameAsync>d__30&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal Task DoWritePropertyNameAsync(string name, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoWritePropertyNameAsync>d__32))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWritePropertyNameAsync>d__32)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWritePropertyNameAsync>d__32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal Task DoWritePropertyNameAsync(string name, bool escape, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoWritePropertyNameAsync>d__30))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWritePropertyNameAsync>d__30)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWritePropertyNameAsync>d__30&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private Task DoWritePropertyNameAsync(Task task, string name, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	internal Task DoWriteRawAsync(string json, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoWriteRawValueAsync>d__121))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteRawValueAsync>d__121)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteRawValueAsync>d__121&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private Task DoWriteRawValueAsync(Task task, string json, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "UpdateScopeWithFinishedValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonWriter), Member = "AutoCompleteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncUtils), Member = "IsCompletedSuccessfully", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteRawValueAsync>d__121)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteRawValueAsync>d__121&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	internal Task DoWriteRawValueAsync(string json, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoWriteStartArrayAsync>d__35))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteStartArrayAsync>d__35)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteStartArrayAsync>d__35&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal Task DoWriteStartArrayAsync(Task task, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteStartAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(JsonContainerType), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncUtils), Member = "IsCompletedSuccessfully", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteStartArrayAsync>d__35)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteStartArrayAsync>d__35&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(char), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal Task DoWriteStartArrayAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoWriteStartConstructorAsync>d__40))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteStartConstructorAsync>d__40)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteStartConstructorAsync>d__40&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal Task DoWriteStartConstructorAsync(string name, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoWriteStartObjectAsync>d__38))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteStartObjectAsync>d__38)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteStartObjectAsync>d__38&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal Task DoWriteStartObjectAsync(Task task, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteStartAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(JsonContainerType), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncUtils), Member = "IsCompletedSuccessfully", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteStartObjectAsync>d__38)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteStartObjectAsync>d__38&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(char), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal Task DoWriteStartObjectAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoWriteUndefinedAsync>d__43))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteUndefinedAsync>d__43)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteUndefinedAsync>d__43&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private Task DoWriteUndefinedAsync(Task task, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncUtils), Member = "IsCompletedSuccessfully", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteUndefinedAsync>d__43)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteUndefinedAsync>d__43&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal Task DoWriteUndefinedAsync(CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteValueInternalAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	internal Task DoWriteValueAsync(decimal value, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteValueInternalAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	internal Task DoWriteValueAsync(Nullable<Decimal> value, CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Boolean>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteValueInternalAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	internal Task DoWriteValueAsync(bool value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoWriteValueAsync>d__64))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.DateTimeOffset>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "DoWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.DateTimeOffset>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteValueAsync>d__64)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteValueAsync>d__64&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal Task DoWriteValueAsync(DateTimeOffset value, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[ContainsInvalidInstructions]
	internal Task DoWriteValueAsync(Nullable<Boolean> value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoWriteValueAsync>d__78))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Guid>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "DoWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Guid>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteValueAsync>d__78)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteValueAsync>d__78&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal Task DoWriteValueAsync(Guid value, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	internal Task DoWriteValueAsync(Nullable<DateTime> value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoWriteValueAsync>d__60))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.DateTime>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "DoWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.DateTime>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteValueAsync>d__60)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteValueAsync>d__60&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal Task DoWriteValueAsync(DateTime value, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	internal Task DoWriteValueAsync(Nullable<Byte> value, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	internal Task DoWriteValueAsync(Nullable<DateTimeOffset> value, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	internal Task DoWriteValueAsync(Nullable<Int16> value, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncUtils), Member = "IsCompletedSuccessfully", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteValueAsync>d__97)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteValueAsync>d__97&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteEscapedStringAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal Task DoWriteValueAsync(string value, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	internal Task DoWriteValueAsync(Nullable<Int32> value, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	internal Task DoWriteValueAsync(Nullable<UInt16> value, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	internal Task DoWriteValueAsync(Nullable<UInt64> value, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	internal Task DoWriteValueAsync(Nullable<Guid> value, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	internal Task DoWriteValueAsync(Nullable<TimeSpan> value, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	internal Task DoWriteValueAsync(Nullable<UInt32> value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoWriteValueAsync>d__97))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteValueAsync>d__97)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteValueAsync>d__97&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private Task DoWriteValueAsync(Task task, string value, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	internal Task DoWriteValueAsync(Nullable<Char> value, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	internal Task DoWriteValueAsync(Nullable<SByte> value, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	internal Task DoWriteValueAsync(Nullable<Int64> value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoWriteValueAsync>d__99))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.TimeSpan>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "DoWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.TimeSpan>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteValueAsync>d__99)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteValueAsync>d__99&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal Task DoWriteValueAsync(TimeSpan value, CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Char>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "DoWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Char>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteValueInternalAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	internal Task DoWriteValueAsync(char value, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(char), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	internal Task DoWriteValueDelimiterAsync(CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal Task DoWriteWhitespaceAsync(string ws, CancellationToken cancellationToken) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.JavaScriptUtils+<WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__16", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BufferUtils), Member = "RentBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(int)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BufferUtils), Member = "ReturnBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(Char[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal Char[] EnsureWriteBuffer(int length, int copyTo) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BufferUtils), Member = "RentBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(int)}, ReturnType = typeof(Char[]))]
	[CallsUnknownMethods(Count = 1)]
	private void EnsureWriteBuffer() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void Flush() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncUtils), Member = "CancelIfRequestedAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "FlushAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Task FlushAsync(CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[NullableContext(2)]
	public IArrayPool<Char> get_ArrayPool() { }

	[CalledBy(Type = typeof(<WriteValueNonNullAsync>d__54), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Base64Encoder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private Base64Encoder get_Base64Encoder() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_Indentation() { }

	[CallerCount(Count = 0)]
	public char get_IndentChar() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public char get_QuoteChar() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_QuoteName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "UpdateCharEscapeFlags", ReturnType = typeof(void))]
	internal virtual void OnStringEscapeHandlingChanged() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[NullableContext(2)]
	public void set_ArrayPool(IArrayPool<Char> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_Indentation(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void set_IndentChar(char value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "UpdateCharEscapeFlags", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_QuoteChar(char value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_QuoteName(bool value) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteIndentAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "DoWriteIndentAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteIndent", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(Char[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private int SetIndentChars() { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "set_QuoteChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "OnStringEscapeHandlingChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(JavaScriptUtils), Member = "GetCharEscapeFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringEscapeHandling), typeof(char)}, ReturnType = typeof(Boolean[]))]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateCharEscapeFlags() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[NullableContext(2)]
	public virtual void WriteComment(string text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteCommentAsync>d__115)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteCommentAsync>d__115&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteCommentAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public virtual Task WriteCommentAsync(string text, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(<WriteIntegerValueAsync>d__24), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteNumberToBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(Char[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(char), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	private Task WriteDigitsAsync(ulong uvalue, bool negative, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonWriterException))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	protected virtual void WriteEnd(JsonToken token) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteEndAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContainerType), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteEndArrayAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	public virtual Task WriteEndArrayAsync(CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteEndAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[ContainsInvalidInstructions]
	public virtual Task WriteEndAsync(CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(char), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteEndAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonWriterException))]
	[CallsUnknownMethods(Count = 5)]
	protected virtual Task WriteEndAsync(JsonToken token, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteEndAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContainerType), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteEndConstructorAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	public virtual Task WriteEndConstructorAsync(CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteEndAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContainerType), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteEndObjectAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	public virtual Task WriteEndObjectAsync(CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WritePropertyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WritePropertyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BufferUtils), Member = "RentBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(int)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(JavaScriptUtils), Member = "WriteEscapedJavaScriptString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(string), typeof(char), typeof(bool), typeof(Boolean[]), typeof(StringEscapeHandling), typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(Char[]&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void WriteEscapedString(string value, bool quote) { }

	[CalledBy(Type = typeof(<DoWritePropertyNameAsync>d__30), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<DoWritePropertyNameAsync>d__32), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<DoWriteValueAsync>d__97), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<WriteValueNotNullAsync>d__110), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "DoWritePropertyNameAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "DoWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueNotNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(JavaScriptUtils), Member = "WriteEscapedJavaScriptStringAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(string), typeof(char), typeof(bool), typeof(Boolean[]), typeof(StringEscapeHandling), typeof(JsonTextWriter), typeof(Char[]), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	private Task WriteEscapedStringAsync(string value, bool quote, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "get_Top", ReturnType = typeof(int))]
	[Calls(Type = typeof(JsonTextWriter), Member = "SetIndentChars", ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void WriteIndent() { }

	[AsyncStateMachine(typeof(<WriteIndentAsync>d__13))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteIndentAsync>d__13)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteIndentAsync>d__13&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task WriteIndentAsync(int currentIndentCount, int newLineLen, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "get_Top", ReturnType = typeof(int))]
	[Calls(Type = typeof(JsonTextWriter), Member = "SetIndentChars", ReturnType = typeof(int))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteIndentAsync>d__13)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteIndentAsync>d__13&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(Char[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteIndentAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected virtual Task WriteIndentAsync(CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void WriteIndentSpace() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(char), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteIndentSpaceAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	protected virtual Task WriteIndentSpaceAsync(CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteNumberToBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void WriteIntegerValue(int value) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteIntegerValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteNumberToBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void WriteIntegerValue(ulong value, bool negative) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteNumberToBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void WriteIntegerValue(uint value, bool negative) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void WriteIntegerValue(long value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	internal Task WriteIntegerValueAsync(ulong uvalue, CancellationToken cancellationToken) { }

	[CallerCount(Count = 26)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncUtils), Member = "IsCompletedSuccessfully", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteIntegerValueAsync>d__24)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteIntegerValueAsync>d__24&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteNumberToBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(Char[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(char), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private Task WriteIntegerValueAsync(ulong uvalue, bool negative, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<WriteIntegerValueAsync>d__24))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteIntegerValueAsync>d__24)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteIntegerValueAsync>d__24&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private Task WriteIntegerValueAsync(Task task, ulong uvalue, bool negative, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	internal Task WriteIntegerValueAsync(long value, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteNull() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[ContainsInvalidInstructions]
	public virtual Task WriteNullAsync(CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteDigitsAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteIntegerValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteIntegerValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BufferUtils), Member = "RentBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(int)}, ReturnType = typeof(Char[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsInvalidInstructions]
	[ContainsUnimplementedInstructions]
	private int WriteNumberToBuffer(ulong value, bool negative) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteIntegerValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteIntegerValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BufferUtils), Member = "RentBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(int)}, ReturnType = typeof(Char[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private int WriteNumberToBuffer(uint value, bool negative) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteEscapedString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WritePropertyName(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteEscapedString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WritePropertyName(string name, bool escape) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WritePropertyNameAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[ContainsInvalidInstructions]
	public virtual Task WritePropertyNameAsync(string name, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWritePropertyNameAsync>d__32)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWritePropertyNameAsync>d__32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WritePropertyNameAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public virtual Task WritePropertyNameAsync(string name, bool escape, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[NullableContext(2)]
	public virtual void WriteRaw(string json) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteRawAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	public virtual Task WriteRawAsync(string json, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "UpdateScopeWithFinishedValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonWriter), Member = "AutoCompleteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncUtils), Member = "IsCompletedSuccessfully", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteRawValueAsync>d__121)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteRawValueAsync>d__121&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteRawValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public virtual Task WriteRawValueAsync(string json, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(JsonContainerType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteStartArray() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteStartAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(JsonContainerType), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncUtils), Member = "IsCompletedSuccessfully", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteStartArrayAsync>d__35)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteStartArrayAsync>d__35&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(char), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteStartArrayAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public virtual Task WriteStartArrayAsync(CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(JsonContainerType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteStartConstructor(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteStartConstructorAsync>d__40)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteStartConstructorAsync>d__40&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteStartConstructorAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public virtual Task WriteStartConstructorAsync(string name, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(JsonContainerType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteStartObject() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteStartAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(JsonContainerType), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncUtils), Member = "IsCompletedSuccessfully", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteStartObjectAsync>d__38)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteStartObjectAsync>d__38&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(char), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteStartObjectAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public virtual Task WriteStartObjectAsync(CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteUndefined() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncUtils), Member = "IsCompletedSuccessfully", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteUndefinedAsync>d__43)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteUndefinedAsync>d__43&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteUndefinedAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public virtual Task WriteUndefinedAsync(CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Guid), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(Guid value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonWriter), Member = "get_Culture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(DateTimeOffset), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(BufferUtils), Member = "RentBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(int)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_DateTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Offset", ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(DateTimeUtils), Member = "WriteDateTimeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(DateTime), typeof(System.Nullable`1<System.TimeSpan>), typeof(DateTimeKind), typeof(DateFormatHandling)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public virtual void WriteValue(DateTimeOffset value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextWriter), Member = "get_Base64Encoder", ReturnType = typeof(Base64Encoder))]
	[Calls(Type = typeof(Base64Encoder), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Base64Encoder), Member = "Flush", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[NullableContext(2)]
	public virtual void WriteValue(Byte[] value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(BigInteger), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[NullableContext(2)]
	public virtual void WriteValue(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeUtils), Member = "EnsureDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTimeZoneHandling)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonWriter), Member = "get_Culture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(BufferUtils), Member = "RentBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(int)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
	[Calls(Type = typeof(DateTimeUtils), Member = "WriteDateTimeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(DateTime), typeof(System.Nullable`1<System.TimeSpan>), typeof(DateTimeKind), typeof(DateFormatHandling)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public virtual void WriteValue(DateTime value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(decimal value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteEscapedString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[NullableContext(2)]
	public virtual void WriteValue(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public virtual void WriteValue(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public virtual void WriteValue(uint value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CLSCompliant(False)]
	public virtual void WriteValue(sbyte value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public virtual void WriteValue(byte value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(long value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool)}, ReturnType = typeof(void))]
	[CLSCompliant(False)]
	public virtual void WriteValue(ulong value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(FloatFormatHandling), typeof(char), typeof(bool)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(char value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CLSCompliant(False)]
	public virtual void WriteValue(ushort value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(FloatFormatHandling), typeof(char), typeof(bool)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(Nullable<Single> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(FloatFormatHandling), typeof(char), typeof(bool)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(double value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(FloatFormatHandling), typeof(char), typeof(bool)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(Nullable<Double> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public virtual void WriteValue(short value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteEscapedString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[NullableContext(2)]
	public virtual void WriteValue(Uri value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(TimeSpan), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(TimeSpan value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteValueInternalAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Decimal>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	public virtual Task WriteValueAsync(Nullable<Decimal> value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	public virtual Task WriteValueAsync(long value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Int64>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	public virtual Task WriteValueAsync(Nullable<Int64> value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(BigInteger), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteValueInternalAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	internal Task WriteValueAsync(BigInteger value, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.UInt16>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CLSCompliant(False)]
	public virtual Task WriteValueAsync(Nullable<UInt16> value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CLSCompliant(False)]
	public virtual Task WriteValueAsync(ushort value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ConvertUtils), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(PrimitiveTypeCode))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(PrimitiveTypeCode), typeof(object), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(BigInteger), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteValueInternalAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Task WriteValueAsync(object value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CLSCompliant(False)]
	public virtual Task WriteValueAsync(sbyte value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Int32>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	public virtual Task WriteValueAsync(Nullable<Int32> value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncUtils), Member = "IsCompletedSuccessfully", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteValueNotNullAsync>d__110)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteValueNotNullAsync>d__110&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteEscapedStringAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public virtual Task WriteValueAsync(Uri value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.UInt64>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CLSCompliant(False)]
	public virtual Task WriteValueAsync(Nullable<UInt64> value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CLSCompliant(False)]
	public virtual Task WriteValueAsync(ulong value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.UInt32>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CLSCompliant(False)]
	public virtual Task WriteValueAsync(Nullable<UInt32> value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CLSCompliant(False)]
	public virtual Task WriteValueAsync(uint value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	public virtual Task WriteValueAsync(short value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.TimeSpan>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	public virtual Task WriteValueAsync(Nullable<TimeSpan> value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Char>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	public virtual Task WriteValueAsync(Nullable<Char> value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Int16>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	public virtual Task WriteValueAsync(Nullable<Int16> value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.SByte>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CLSCompliant(False)]
	public virtual Task WriteValueAsync(Nullable<SByte> value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	public virtual Task WriteValueAsync(double value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[ContainsInvalidInstructions]
	public virtual Task WriteValueAsync(char value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	public virtual Task WriteValueAsync(int value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteValueInternalAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	public virtual Task WriteValueAsync(decimal value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[ContainsInvalidInstructions]
	public virtual Task WriteValueAsync(bool value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncUtils), Member = "IsCompletedSuccessfully", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteValueAsync>d__97)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoWriteValueAsync>d__97&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteEscapedStringAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public virtual Task WriteValueAsync(string value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Double>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(FloatFormatHandling), typeof(char), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteValueInternalAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	internal Task WriteValueAsync(double value, bool nullable, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Double>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual Task WriteValueAsync(Nullable<Double> value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.DateTimeOffset>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	public virtual Task WriteValueAsync(Nullable<DateTimeOffset> value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	public virtual Task WriteValueAsync(float value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(FloatFormatHandling), typeof(char), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteValueInternalAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	internal Task WriteValueAsync(float value, bool nullable, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteValueNonNullAsync>d__54)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteValueNonNullAsync>d__54&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public virtual Task WriteValueAsync(Byte[] value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Boolean>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	public virtual Task WriteValueAsync(Nullable<Boolean> value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	public virtual Task WriteValueAsync(byte value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.DateTime>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	public virtual Task WriteValueAsync(Nullable<DateTime> value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	public virtual Task WriteValueAsync(Nullable<Byte> value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual Task WriteValueAsync(Nullable<Single> value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[ContainsInvalidInstructions]
	public virtual Task WriteValueAsync(DateTime value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	public virtual Task WriteValueAsync(Guid value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Guid>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	public virtual Task WriteValueAsync(Nullable<Guid> value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = "DoWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	public virtual Task WriteValueAsync(DateTimeOffset value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[ContainsInvalidInstructions]
	public virtual Task WriteValueAsync(TimeSpan value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void WriteValueDelimiter() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(char), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValueDelimiterAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	protected virtual Task WriteValueDelimiterAsync(CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void WriteValueInternal(string value, JsonToken token) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "DoWriteNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "DoWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Decimal>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "DoWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "DoWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "DoWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Decimal>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncUtils), Member = "IsCompletedSuccessfully", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteValueInternalAsync>d__15)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteValueInternalAsync>d__15&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private Task WriteValueInternalAsync(JsonToken token, string value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<WriteValueInternalAsync>d__15))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteValueInternalAsync>d__15)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteValueInternalAsync>d__15&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private Task WriteValueInternalAsync(Task task, string value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<WriteValueNonNullAsync>d__54))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteValueNonNullAsync>d__54)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteValueNonNullAsync>d__54&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal Task WriteValueNonNullAsync(Byte[] value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<WriteValueNotNullAsync>d__110))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteValueNotNullAsync>d__110)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteValueNotNullAsync>d__110&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal Task WriteValueNotNullAsync(Task task, Uri value, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncUtils), Member = "IsCompletedSuccessfully", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteValueNotNullAsync>d__110)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteValueNotNullAsync>d__110&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonTextWriter), Member = "WriteEscapedStringAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal Task WriteValueNotNullAsync(Uri value, CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(<DoWriteValueAsync>d__60), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BufferUtils), Member = "RentBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(int)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
	[Calls(Type = typeof(DateTimeUtils), Member = "WriteDateTimeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(DateTime), typeof(System.Nullable`1<System.TimeSpan>), typeof(DateTimeKind), typeof(DateFormatHandling)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	private int WriteValueToBuffer(DateTime value) { }

	[CalledBy(Type = typeof(<DoWriteValueAsync>d__64), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BufferUtils), Member = "RentBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(int)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_DateTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Offset", ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(DateTimeUtils), Member = "WriteDateTimeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(DateTime), typeof(System.Nullable`1<System.TimeSpan>), typeof(DateTimeKind), typeof(DateFormatHandling)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private int WriteValueToBuffer(DateTimeOffset value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteWhitespace(string ws) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteWhitespaceAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual Task WriteWhitespaceAsync(string ws, CancellationToken cancellationToken = null) { }

}

