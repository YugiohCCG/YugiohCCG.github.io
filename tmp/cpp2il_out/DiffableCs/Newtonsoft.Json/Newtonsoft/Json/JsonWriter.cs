namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
public abstract class JsonWriter : IDisposable
{
	[CompilerGenerated]
	private struct <<InternalWriteEndAsync>g__AwaitEnd|11_2>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Task task; //Field offset: 0x20
		[Nullable(0)]
		public JsonWriter <>4__this; //Field offset: 0x28
		public int LevelsToComplete; //Field offset: 0x30
		public CancellationToken CancellationToken; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(JsonWriter), Member = "UpdateCurrentState", ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonWriter), Member = "<InternalWriteEndAsync>g__AwaitRemaining|11_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
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
	private struct <<InternalWriteEndAsync>g__AwaitIndent|11_1>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Task task; //Field offset: 0x20
		[Nullable(0)]
		public JsonWriter <>4__this; //Field offset: 0x28
		public JsonToken token; //Field offset: 0x30
		public CancellationToken CancellationToken; //Field offset: 0x38
		public int LevelsToComplete; //Field offset: 0x40
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonWriter), Member = "UpdateCurrentState", ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonWriter), Member = "<InternalWriteEndAsync>g__AwaitRemaining|11_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 9)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<InternalWriteEndAsync>g__AwaitProperty|11_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Task task; //Field offset: 0x20
		[Nullable(0)]
		public JsonWriter <>4__this; //Field offset: 0x28
		public CancellationToken CancellationToken; //Field offset: 0x30
		public JsonToken token; //Field offset: 0x38
		public int LevelsToComplete; //Field offset: 0x3C
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonWriter), Member = "UpdateCurrentState", ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonWriter), Member = "<InternalWriteEndAsync>g__AwaitRemaining|11_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallsUnknownMethods(Count = 12)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<InternalWriteEndAsync>g__AwaitRemaining|11_3>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonWriter <>4__this; //Field offset: 0x20
		public CancellationToken CancellationToken; //Field offset: 0x28
		public int LevelsToComplete; //Field offset: 0x30
		private JsonToken <token>5__2; //Field offset: 0x34
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonWriter), Member = "UpdateCurrentState", ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonWriter), Member = "Pop", ReturnType = typeof(JsonContainerType))]
		[Calls(Type = typeof(JsonWriter), Member = "GetCloseTokenForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContainerType)}, ReturnType = typeof(JsonToken))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 11)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AutoCompleteAsync>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonWriter <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InternalWriteStartAsync>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonWriter <>4__this; //Field offset: 0x20
		public JsonToken token; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		public JsonContainerType container; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonWriter), Member = "UpdateScopeWithFinishedValue", ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonWriter), Member = "AutoCompleteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(JsonWriter), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContainerType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteConstructorDateAsync>d__32 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonReader reader; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		public JsonWriter <>4__this; //Field offset: 0x30
		private DateTime <date>5__2; //Field offset: 0x38
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x40
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x50

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DateTimeUtils), Member = "ConvertJavaScriptTicksToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonWriterException))]
		[CallsDeduplicatedMethods(Count = 12)]
		[CallsUnknownMethods(Count = 35)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteTokenAsync>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonWriter <>4__this; //Field offset: 0x20
		[Nullable(0)]
		public JsonReader reader; //Field offset: 0x28
		public bool writeDateConstructorAsDate; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		public bool writeComments; //Field offset: 0x40
		public bool writeChildren; //Field offset: 0x41
		private int <initialDepth>5__2; //Field offset: 0x44
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__2; //Field offset: 0x58

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonWriter), Member = "CalculateWriteTokenInitialDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(JsonWriter), Member = "WriteConstructorDateAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonWriter), Member = "WriteTokenAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(JsonWriter), Member = "IsWriteTokenIncomplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(bool), typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonWriterException))]
		[CallsDeduplicatedMethods(Count = 15)]
		[CallsUnknownMethods(Count = 22)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteTokenSyncReadingAsync>d__31 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonWriter <>4__this; //Field offset: 0x20
		[Nullable(0)]
		public JsonReader reader; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private int <initialDepth>5__2; //Field offset: 0x38
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonWriter), Member = "CalculateWriteTokenInitialDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(JsonWriter), Member = "WriteConstructorDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonWriter), Member = "WriteToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(JsonWriter), Member = "CalculateWriteTokenFinalDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonWriterException))]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallsUnknownMethods(Count = 17)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[NullableContext(0)]
	public enum State
	{
		Start = 0,
		Property = 1,
		ObjectStart = 2,
		Object = 3,
		ArrayStart = 4,
		Array = 5,
		ConstructorStart = 6,
		Constructor = 7,
		Closed = 8,
		Error = 9,
	}

	private static readonly State[][] StateArray; //Field offset: 0x0
	internal static readonly State[][] StateArrayTemplate; //Field offset: 0x8
	[Nullable(2)]
	private List<JsonPosition> _stack; //Field offset: 0x10
	private JsonPosition _currentPosition; //Field offset: 0x18
	private State _currentState; //Field offset: 0x30
	private Formatting _formatting; //Field offset: 0x34
	[CompilerGenerated]
	private bool <CloseOutput>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private bool <AutoCompleteOnClose>k__BackingField; //Field offset: 0x39
	private DateFormatHandling _dateFormatHandling; //Field offset: 0x3C
	private DateTimeZoneHandling _dateTimeZoneHandling; //Field offset: 0x40
	private StringEscapeHandling _stringEscapeHandling; //Field offset: 0x44
	private FloatFormatHandling _floatFormatHandling; //Field offset: 0x48
	[Nullable(2)]
	private string _dateFormatString; //Field offset: 0x50
	[Nullable(2)]
	private CultureInfo _culture; //Field offset: 0x58

	public bool AutoCompleteOnClose
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool CloseOutput
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	internal string ContainerPath
	{
		[CalledBy(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonWriterException))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "CheckForCircularReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonProperty), typeof(JsonContract), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "GetReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonObjectContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "CalculatePropertyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonContainerContract), typeof(JsonProperty), typeof(JsonProperty), typeof(JsonContract&), typeof(Object&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IEnumerable), typeof(JsonArrayContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeMultidimensionalArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(Array), typeof(JsonArrayContract), typeof(JsonProperty), typeof(int), typeof(Int32[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeISerializable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(ISerializable), typeof(JsonISerializableContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDynamic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IDynamicMetaObjectProvider), typeof(JsonDynamicContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDictionary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IDictionary), typeof(JsonDictionaryContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StringEnumConverter), Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(JsonPosition), Member = "BuildPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Newtonsoft.Json.JsonPosition>), typeof(System.Nullable`1<Newtonsoft.Json.JsonPosition>)}, ReturnType = typeof(string))]
		internal get { } //Length: 143
	}

	public CultureInfo Culture
	{
		[CalledBy(Type = typeof(JsonSerializer), Member = "SerializeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "GetPropertyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonContract), typeof(Boolean&)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(TraceJsonWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		 get { } //Length: 84
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public DateFormatHandling DateFormatHandling
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CalledBy(Type = typeof(JsonSerializer), Member = "SerializeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TraceJsonWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 99
	}

	[Nullable(2)]
	public string DateFormatString
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[NullableContext(2)]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[NullableContext(2)]
		 set { } //Length: 13
	}

	public DateTimeZoneHandling DateTimeZoneHandling
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CalledBy(Type = typeof(JsonSerializer), Member = "SerializeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TraceJsonWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 99
	}

	public FloatFormatHandling FloatFormatHandling
	{
		[CallerCount(Count = 26)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CalledBy(Type = typeof(JsonSerializer), Member = "SerializeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TraceJsonWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 99
	}

	public Formatting Formatting
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CalledBy(Type = typeof(JsonConvert), Member = "SerializeObjectInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(JsonSerializer)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(JsonSerializer), Member = "SerializeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TraceJsonReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TraceJsonWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSchema), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(JToken), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Formatting), typeof(JsonConverter[])}, ReturnType = typeof(string))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 99
	}

	public string Path
	{
		[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.ExceptionUtils", Member = "CreateJsonWriterException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonWriterException))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "IsSpecified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(JsonProperty), typeof(object)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "ShouldSerialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(JsonProperty), typeof(object)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDynamic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IDynamicMetaObjectProvider), typeof(JsonDynamicContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeConvertable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(JsonConverter), typeof(object), typeof(JsonContract), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "WriteTypeProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(Type)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "CalculatePropertyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonContainerContract), typeof(JsonProperty), typeof(JsonProperty), typeof(JsonContract&), typeof(Object&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "WriteReferenceIdProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(Type), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "OnSerializing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(JsonContract), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "WriteReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "CheckForCircularReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonProperty), typeof(JsonContract), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Newtonsoft.Json.Bson.Converters.BsonDataRegexConverter", Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "OnSerialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(JsonContract), typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(System.Nullable`1<Newtonsoft.Json.JsonPosition>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonPosition)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonPosition), Member = "BuildPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Newtonsoft.Json.JsonPosition>), typeof(System.Nullable`1<Newtonsoft.Json.JsonPosition>)}, ReturnType = typeof(string))]
		 get { } //Length: 259
	}

	public StringEscapeHandling StringEscapeHandling
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CalledBy(Type = typeof(JsonSerializer), Member = "SerializeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 115
	}

	protected private int Top
	{
		[CalledBy(Type = "Newtonsoft.Json.Bson.BsonDataWriter", Member = "WriteEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteIndentAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[CalledBy(Type = typeof(JsonTextWriter), Member = "DoWriteIndentAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteIndent", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonValidatingReader), Member = "WriteToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<Newtonsoft.Json.Schema.JsonSchemaModel>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonObjectContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IEnumerable), typeof(JsonArrayContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeMultidimensionalArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(Array), typeof(JsonArrayContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeMultidimensionalArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(Array), typeof(JsonArrayContract), typeof(JsonProperty), typeof(int), typeof(Int32[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDynamic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IDynamicMetaObjectProvider), typeof(JsonDynamicContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDictionary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IDictionary), typeof(JsonDictionaryContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "HandleError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BsonWriter), Member = "WriteEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
		[CallerCount(Count = 19)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 75
	}

	public WriteState WriteState
	{
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonObjectContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IEnumerable), typeof(JsonArrayContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeMultidimensionalArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(Array), typeof(JsonArrayContract), typeof(JsonProperty), typeof(int), typeof(Int32[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDynamic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IDynamicMetaObjectProvider), typeof(JsonDynamicContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDictionary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IDictionary), typeof(JsonDictionaryContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "HandleError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[ContainsInvalidInstructions]
		 get { } //Length: 28
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonWriter), Member = "BuildStateArray", ReturnType = typeof(State[][]))]
	[CallsUnknownMethods(Count = 12)]
	private static JsonWriter() { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonDataWriter", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonDataWriter", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TraceJsonWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JContainer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BsonWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BsonWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected JsonWriter() { }

	[AsyncStateMachine(typeof(<<InternalWriteEndAsync>g__AwaitEnd|11_2>d))]
	[CalledBy(Type = typeof(JsonWriter), Member = "InternalWriteEndAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContainerType), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<<InternalWriteEndAsync>g__AwaitEnd|11_2>d)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<<InternalWriteEndAsync>g__AwaitEnd|11_2>d&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[CompilerGenerated]
	private Task <InternalWriteEndAsync>g__AwaitEnd|11_2(Task task, int LevelsToComplete, CancellationToken CancellationToken) { }

	[AsyncStateMachine(typeof(<<InternalWriteEndAsync>g__AwaitIndent|11_1>d))]
	[CalledBy(Type = typeof(JsonWriter), Member = "InternalWriteEndAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContainerType), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<<InternalWriteEndAsync>g__AwaitIndent|11_1>d)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<<InternalWriteEndAsync>g__AwaitIndent|11_1>d&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[CompilerGenerated]
	private Task <InternalWriteEndAsync>g__AwaitIndent|11_1(Task task, int LevelsToComplete, JsonToken token, CancellationToken CancellationToken) { }

	[AsyncStateMachine(typeof(<<InternalWriteEndAsync>g__AwaitProperty|11_0>d))]
	[CalledBy(Type = typeof(JsonWriter), Member = "InternalWriteEndAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContainerType), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<<InternalWriteEndAsync>g__AwaitProperty|11_0>d)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<<InternalWriteEndAsync>g__AwaitProperty|11_0>d&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[CompilerGenerated]
	private Task <InternalWriteEndAsync>g__AwaitProperty|11_0(Task task, int LevelsToComplete, JsonToken token, CancellationToken CancellationToken) { }

	[AsyncStateMachine(typeof(<<InternalWriteEndAsync>g__AwaitRemaining|11_3>d))]
	[CalledBy(Type = typeof(<<InternalWriteEndAsync>g__AwaitEnd|11_2>d), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<<InternalWriteEndAsync>g__AwaitIndent|11_1>d), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<<InternalWriteEndAsync>g__AwaitProperty|11_0>d), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<<InternalWriteEndAsync>g__AwaitRemaining|11_3>d)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<<InternalWriteEndAsync>g__AwaitRemaining|11_3>d&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	private Task <InternalWriteEndAsync>g__AwaitRemaining|11_3(int LevelsToComplete, CancellationToken CancellationToken) { }

	[CallerCount(Count = 32)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonWriterException))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	internal void AutoComplete(JsonToken tokenBeingWritten) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void AutoCompleteAll() { }

	[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter+<DoWriteCommentAsync>d__115", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteRawValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "DoWriteRawValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(<InternalWriteStartAsync>d__20), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonWriter), Member = "InternalWritePropertyNameAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonWriter), Member = "InternalWriteCommentAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonWriter), Member = "InternalWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonWriter), Member = "SetWriteStateAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 8)]
	[ContainsInvalidInstructions]
	internal Task AutoCompleteAsync(JsonToken tokenBeingWritten, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<AutoCompleteAsync>d__1))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<AutoCompleteAsync>d__1)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<AutoCompleteAsync>d__1&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task AutoCompleteAsync(CancellationToken cancellationToken) { }

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(JsonWriter), Member = "CalculateLevelsToComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContainerType)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(JsonWriter), Member = "Pop", ReturnType = typeof(JsonContainerType))]
	[Calls(Type = typeof(JsonWriter), Member = "GetCloseTokenForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContainerType)}, ReturnType = typeof(JsonToken))]
	[Calls(Type = typeof(JsonWriter), Member = "UpdateCurrentState", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	private void AutoCompleteClose(JsonContainerType type) { }

	[CalledBy(Type = typeof(JsonWriter), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(EnumUtils), Member = "GetEnumValuesAndNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(EnumInfo))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsUnknownMethods(Count = 3)]
	internal static State[][] BuildStateArray() { }

	[CalledBy(Type = typeof(JsonWriter), Member = "InternalWriteEndAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContainerType), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonWriter), Member = "AutoCompleteClose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContainerType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonWriter), Member = "InternalWriteEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContainerType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonWriterException))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private int CalculateLevelsToComplete(JsonContainerType type) { }

	[CalledBy(Type = typeof(<WriteTokenSyncReadingAsync>d__31), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonTokenUtils), Member = "IsEndToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private int CalculateWriteTokenFinalDepth(JsonReader reader) { }

	[CalledBy(Type = typeof(<WriteTokenAsync>d__30), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<WriteTokenSyncReadingAsync>d__31), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JsonTokenUtils), Member = "IsStartToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private int CalculateWriteTokenInitialDepth(JsonReader reader) { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonDataWriter", Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TraceJsonWriter), Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BsonWriter), Member = "Close", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override void Close() { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "CloseAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task CloseAsync(CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(PrimitiveTypeCode), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonWriterException))]
	[CallsUnknownMethods(Count = 1)]
	private static JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, object value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void Dispose(bool disposing) { }

	public abstract void Flush() { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "FlushAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task FlushAsync(CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_AutoCompleteOnClose() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_CloseOutput() { }

	[CalledBy(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonWriterException))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "CheckForCircularReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonProperty), typeof(JsonContract), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "GetReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonObjectContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "CalculatePropertyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonContainerContract), typeof(JsonProperty), typeof(JsonProperty), typeof(JsonContract&), typeof(Object&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IEnumerable), typeof(JsonArrayContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeMultidimensionalArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(Array), typeof(JsonArrayContract), typeof(JsonProperty), typeof(int), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeISerializable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(ISerializable), typeof(JsonISerializableContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDynamic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IDynamicMetaObjectProvider), typeof(JsonDynamicContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDictionary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IDictionary), typeof(JsonDictionaryContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StringEnumConverter), Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(JsonPosition), Member = "BuildPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Newtonsoft.Json.JsonPosition>), typeof(System.Nullable`1<Newtonsoft.Json.JsonPosition>)}, ReturnType = typeof(string))]
	internal string get_ContainerPath() { }

	[CalledBy(Type = typeof(JsonSerializer), Member = "SerializeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "GetPropertyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonContract), typeof(Boolean&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TraceJsonWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	public CultureInfo get_Culture() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public DateFormatHandling get_DateFormatHandling() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[NullableContext(2)]
	public string get_DateFormatString() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	public FloatFormatHandling get_FloatFormatHandling() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public Formatting get_Formatting() { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.ExceptionUtils", Member = "CreateJsonWriterException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonWriterException))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "OnSerialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(JsonContract), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.Converters.BsonDataRegexConverter", Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "CheckForCircularReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonProperty), typeof(JsonContract), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "WriteReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "WriteReferenceIdProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(Type), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "OnSerializing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(JsonContract), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "WriteTypeProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeConvertable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(JsonConverter), typeof(object), typeof(JsonContract), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDynamic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IDynamicMetaObjectProvider), typeof(JsonDynamicContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "ShouldSerialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(JsonProperty), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "IsSpecified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(JsonProperty), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "CalculatePropertyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonContainerContract), typeof(JsonProperty), typeof(JsonProperty), typeof(JsonContract&), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(System.Nullable`1<Newtonsoft.Json.JsonPosition>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonPosition)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonPosition), Member = "BuildPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Newtonsoft.Json.JsonPosition>), typeof(System.Nullable`1<Newtonsoft.Json.JsonPosition>)}, ReturnType = typeof(string))]
	public string get_Path() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public StringEscapeHandling get_StringEscapeHandling() { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonDataWriter", Member = "WriteEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteIndentAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "DoWriteIndentAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteIndent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "WriteToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<Newtonsoft.Json.Schema.JsonSchemaModel>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonObjectContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IEnumerable), typeof(JsonArrayContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeMultidimensionalArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(Array), typeof(JsonArrayContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeMultidimensionalArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(Array), typeof(JsonArrayContract), typeof(JsonProperty), typeof(int), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDynamic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IDynamicMetaObjectProvider), typeof(JsonDynamicContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDictionary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IDictionary), typeof(JsonDictionaryContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "HandleError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BsonWriter), Member = "WriteEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[ContainsUnimplementedInstructions]
	protected private int get_Top() { }

	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonObjectContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IEnumerable), typeof(JsonArrayContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeMultidimensionalArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(Array), typeof(JsonArrayContract), typeof(JsonProperty), typeof(int), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDynamic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IDynamicMetaObjectProvider), typeof(JsonDynamicContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDictionary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IDictionary), typeof(JsonDictionaryContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "HandleError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[ContainsInvalidInstructions]
	public WriteState get_WriteState() { }

	[CalledBy(Type = typeof(<<InternalWriteEndAsync>g__AwaitRemaining|11_3>d), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonWriter), Member = "InternalWriteEndAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContainerType), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonWriter), Member = "AutoCompleteClose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContainerType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonWriter), Member = "InternalWriteEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContainerType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonWriterException))]
	[CallsUnknownMethods(Count = 5)]
	private JsonToken GetCloseTokenForType(JsonContainerType type) { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal void InternalWriteComment() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "AutoCompleteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	internal Task InternalWriteCommentAsync(CancellationToken cancellationToken) { }

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(JsonWriter), Member = "CalculateLevelsToComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContainerType)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(JsonWriter), Member = "Pop", ReturnType = typeof(JsonContainerType))]
	[Calls(Type = typeof(JsonWriter), Member = "GetCloseTokenForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContainerType)}, ReturnType = typeof(JsonToken))]
	[Calls(Type = typeof(JsonWriter), Member = "UpdateCurrentState", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	internal void InternalWriteEnd(JsonContainerType container) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteEndArrayAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteEndConstructorAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteEndObjectAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonWriter), Member = "SetWriteStateAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonWriter), Member = "CalculateLevelsToComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContainerType)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(JsonWriter), Member = "Pop", ReturnType = typeof(JsonContainerType))]
	[Calls(Type = typeof(JsonWriter), Member = "GetCloseTokenForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContainerType)}, ReturnType = typeof(JsonToken))]
	[Calls(Type = typeof(AsyncUtils), Member = "IsCompletedSuccessfully", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonWriter), Member = "UpdateCurrentState", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonWriter), Member = "<InternalWriteEndAsync>g__AwaitProperty|11_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(int), typeof(JsonToken), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "<InternalWriteEndAsync>g__AwaitIndent|11_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(int), typeof(JsonToken), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "<InternalWriteEndAsync>g__AwaitEnd|11_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 3)]
	internal Task InternalWriteEndAsync(JsonContainerType type, CancellationToken cancellationToken) { }

	[CallerCount(Count = 7)]
	[Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void InternalWritePropertyName(string name) { }

	[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter+<DoWritePropertyNameAsync>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "DoWritePropertyNameAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonWriter), Member = "SetWriteStateAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonWriter), Member = "AutoCompleteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsUnknownMethods(Count = 1)]
	internal Task InternalWritePropertyNameAsync(string name, CancellationToken cancellationToken) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal void InternalWriteRaw() { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteStartObject", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteStartArray", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteStartConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonWriter), Member = "WriteStartObject", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonWriter), Member = "WriteStartArray", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonWriter), Member = "WriteStartConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonWriter), Member = "SetWriteState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonPosition), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContainerType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal void InternalWriteStart(JsonToken token, JsonContainerType container) { }

	[AsyncStateMachine(typeof(<InternalWriteStartAsync>d__20))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter+<DoWriteStartConstructorAsync>d__40", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteStartArrayAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "DoWriteStartArrayAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteStartObjectAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "DoWriteStartObjectAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonWriter), Member = "SetWriteStateAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<InternalWriteStartAsync>d__20)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<InternalWriteStartAsync>d__20&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal Task InternalWriteStartAsync(JsonToken token, JsonContainerType container, CancellationToken cancellationToken) { }

	[CallerCount(Count = 30)]
	[Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	internal void InternalWriteValue(JsonToken token) { }

	[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter+<DoWriteValueAsync>d__60", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonWriter), Member = "SetWriteStateAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueNotNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "DoWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteUndefinedAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "DoWriteUndefinedAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueInternalAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter+<WriteValueNonNullAsync>d__54", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter+<DoWriteValueAsync>d__99", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter+<DoWriteValueAsync>d__78", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter+<DoWriteValueAsync>d__64", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteIntegerValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(JsonWriter), Member = "AutoCompleteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	internal Task InternalWriteValueAsync(JsonToken token, CancellationToken cancellationToken) { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StringUtils), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonWriterException))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	internal void InternalWriteWhitespace(string ws) { }

	[CalledBy(Type = typeof(<WriteTokenAsync>d__30), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonTokenUtils), Member = "IsEndToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonTokenUtils), Member = "IsStartToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private bool IsWriteTokenIncomplete(JsonReader reader, bool writeChildren, int initialDepth) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal override void OnStringEscapeHandlingChanged() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	private JsonContainerType Peek() { }

	[CalledBy(Type = typeof(<<InternalWriteEndAsync>g__AwaitRemaining|11_3>d), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonWriter), Member = "InternalWriteEndAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContainerType), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonWriter), Member = "AutoCompleteClose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContainerType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonWriter), Member = "InternalWriteEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContainerType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private JsonContainerType Pop() { }

	[CalledBy(Type = typeof(<InternalWriteStartAsync>d__20), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonPosition), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContainerType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void Push(JsonContainerType value) { }

	[CalledBy(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(PrimitiveTypeCode), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConvertUtils), Member = "GetTypeInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConvertible)}, ReturnType = typeof(TypeInformation))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static void ResolveConvertibleValue(IConvertible convertible, out PrimitiveTypeCode typeCode, out object value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_AutoCompleteOnClose(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_CloseOutput(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Culture(CultureInfo value) { }

	[CalledBy(Type = typeof(JsonSerializer), Member = "SerializeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TraceJsonWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_DateFormatHandling(DateFormatHandling value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NullableContext(2)]
	public void set_DateFormatString(string value) { }

	[CalledBy(Type = typeof(JsonSerializer), Member = "SerializeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TraceJsonWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	[CalledBy(Type = typeof(JsonSerializer), Member = "SerializeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TraceJsonWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_FloatFormatHandling(FloatFormatHandling value) { }

	[CalledBy(Type = typeof(JsonConvert), Member = "SerializeObjectInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(JsonSerializer)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonSerializer), Member = "SerializeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TraceJsonReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TraceJsonWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSchema), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JToken), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Formatting), typeof(JsonConverter[])}, ReturnType = typeof(string))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_Formatting(Formatting value) { }

	[CalledBy(Type = typeof(JsonSerializer), Member = "SerializeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void set_StringEscapeHandling(StringEscapeHandling value) { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonDataWriter", Member = "WriteObjectId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonDataWriter", Member = "WriteRegex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.Converters.BsonDataObjectIdConverter", Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.Converters.BsonDataRegexConverter", Member = "WriteBson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Bson.BsonDataWriter", typeof(Regex)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BsonWriter), Member = "WriteObjectId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BsonWriter), Member = "WriteRegex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(JsonContainerType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	protected void SetWriteState(JsonToken token, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteStartAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(JsonContainerType), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWritePropertyNameAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "AutoCompleteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteEndAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContainerType), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	protected Task SetWriteStateAsync(JsonToken token, object value, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private override void System.IDisposable.Dispose() { }

	[CalledBy(Type = typeof(<<InternalWriteEndAsync>g__AwaitEnd|11_2>d), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<<InternalWriteEndAsync>g__AwaitIndent|11_1>d), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<<InternalWriteEndAsync>g__AwaitProperty|11_0>d), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<<InternalWriteEndAsync>g__AwaitRemaining|11_3>d), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonWriter), Member = "InternalWriteEndAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContainerType), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonWriter), Member = "AutoCompleteClose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContainerType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonWriter), Member = "InternalWriteEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContainerType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonWriterException))]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateCurrentState() { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteRawValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "DoWriteRawValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(<InternalWriteStartAsync>d__20), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	internal void UpdateScopeWithFinishedValue() { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[NullableContext(2)]
	public override void WriteComment(string text) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteCommentAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteCommentAsync(string text, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(<WriteTokenSyncReadingAsync>d__31), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JavaScriptUtils), Member = "TryGetDateFromConstructorJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(DateTime&), typeof(String&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonWriterException))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void WriteConstructorDate(JsonReader reader) { }

	[AsyncStateMachine(typeof(<WriteConstructorDateAsync>d__32))]
	[CalledBy(Type = typeof(<WriteTokenAsync>d__30), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteConstructorDateAsync>d__32)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteConstructorDateAsync>d__32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private Task WriteConstructorDateAsync(JsonReader reader, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonWriterException))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void WriteEnd(JsonContainerType type) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void WriteEnd(JsonToken token) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonWriterException))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public override void WriteEnd() { }

	[CalledBy(Type = typeof(TraceJsonWriter), Member = "WriteEndArray", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void WriteEndArray() { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteEndArrayAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteEndArrayAsync(CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteEndAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override Task WriteEndAsync(JsonToken token, CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteEndAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteEndAsync(CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(TraceJsonWriter), Member = "WriteEndConstructor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void WriteEndConstructor() { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteEndConstructorAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteEndConstructorAsync(CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonWriterException))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	internal Task WriteEndInternalAsync(CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(TraceJsonWriter), Member = "WriteEndObject", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void WriteEndObject() { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteEndObjectAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteEndObjectAsync(CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void WriteIndent() { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteIndentAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override Task WriteIndentAsync(CancellationToken cancellationToken) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void WriteIndentSpace() { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteIndentSpaceAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override Task WriteIndentSpaceAsync(CancellationToken cancellationToken) { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonDataWriter", Member = "WriteNull", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteNull", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BsonWriter), Member = "WriteNull", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	public override void WriteNull() { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteNullAsync(CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 7)]
	[Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void WritePropertyName(string name) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void WritePropertyName(string name, bool escape) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WritePropertyNameAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WritePropertyNameAsync(string name, bool escape, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WritePropertyNameAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WritePropertyNameAsync(string name, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	[NullableContext(2)]
	public override void WriteRaw(string json) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteRawAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteRawAsync(string json, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[NullableContext(2)]
	public override void WriteRawValue(string json) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteRawValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteRawValueAsync(string json, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonDataWriter", Member = "WriteStartArray", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TraceJsonWriter), Member = "WriteStartArray", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteStartArray", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BsonWriter), Member = "WriteStartArray", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(JsonContainerType)}, ReturnType = typeof(void))]
	public override void WriteStartArray() { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteStartArrayAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteStartArrayAsync(CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(TraceJsonWriter), Member = "WriteStartConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteStartConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(JsonContainerType)}, ReturnType = typeof(void))]
	public override void WriteStartConstructor(string name) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteStartConstructorAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteStartConstructorAsync(string name, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonDataWriter", Member = "WriteStartObject", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TraceJsonWriter), Member = "WriteStartObject", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteStartObject", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BsonWriter), Member = "WriteStartObject", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(JsonContainerType)}, ReturnType = typeof(void))]
	public override void WriteStartObject() { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteStartObjectAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteStartObjectAsync(CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(<WriteTokenSyncReadingAsync>d__31), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonWriter), Member = "WriteToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(Convert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Convert), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(MiscellaneousUtils), Member = "CreateArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(ArgumentOutOfRangeException))]
	[CallsDeduplicatedMethods(Count = 28)]
	[CallsUnknownMethods(Count = 15)]
	[NullableContext(2)]
	public void WriteToken(JsonToken token, object value) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	public void WriteToken(JsonToken token) { }

	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonTokenUtils), Member = "IsStartToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JavaScriptUtils), Member = "TryGetDateFromConstructorJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(DateTime&), typeof(String&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTokenUtils), Member = "IsEndToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonWriterException))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 10)]
	internal override void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }

	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateJToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonContract)}, ReturnType = typeof(JToken))]
	[CalledBy(Type = typeof(JRaw), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(JRaw))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void WriteToken(JsonReader reader) { }

	[CalledBy(Type = typeof(JsonValidatingReader), Member = "WriteToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<Newtonsoft.Json.Schema.JsonSchemaModel>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void WriteToken(JsonReader reader, bool writeChildren) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public Task WriteTokenAsync(JsonReader reader, bool writeChildren, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteTokenAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	public Task WriteTokenAsync(JsonToken token, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(<WriteTokenAsync>d__30), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonWriter), Member = "WriteTokenAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[ContainsInvalidInstructions]
	public Task WriteTokenAsync(JsonToken token, object value, CancellationToken cancellationToken = null) { }

	[AsyncStateMachine(typeof(<WriteTokenAsync>d__30))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteTokenAsync>d__30)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteTokenAsync>d__30&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal override Task WriteTokenAsync(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public Task WriteTokenAsync(JsonReader reader, CancellationToken cancellationToken = null) { }

	[AsyncStateMachine(typeof(<WriteTokenSyncReadingAsync>d__31))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JRaw+<CreateAsync>d__0", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteTokenAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(bool), typeof(bool), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteTokenSyncReadingAsync>d__31)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteTokenSyncReadingAsync>d__31&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal Task WriteTokenSyncReadingAsync(JsonReader reader, CancellationToken cancellationToken) { }

	[CallerCount(Count = 25)]
	[Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	public override void WriteUndefined() { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteUndefinedAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteUndefinedAsync(CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CLSCompliant(False)]
	public override void WriteValue(Nullable<SByte> value) { }

	[CallerCount(Count = 19)]
	[Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[NullableContext(2)]
	public override void WriteValue(string value) { }

	[CallerCount(Count = 40)]
	[Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public override void WriteValue(int value) { }

	[CallerCount(Count = 40)]
	[Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	public override void WriteValue(uint value) { }

	[CallerCount(Count = 40)]
	[Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public override void WriteValue(long value) { }

	[CallerCount(Count = 40)]
	[Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	public override void WriteValue(ulong value) { }

	[CallerCount(Count = 15)]
	[Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public override void WriteValue(float value) { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonDataWriter", Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TraceJsonWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TraceJsonWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	public override void WriteValue(bool value) { }

	[CallerCount(Count = 40)]
	[Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public override void WriteValue(short value) { }

	[CallerCount(Count = 40)]
	[Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	public override void WriteValue(ushort value) { }

	[CallerCount(Count = 19)]
	[Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public override void WriteValue(char value) { }

	[CallerCount(Count = 40)]
	[Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public override void WriteValue(byte value) { }

	[CallerCount(Count = 40)]
	[Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	public override void WriteValue(sbyte value) { }

	[CallerCount(Count = 15)]
	[Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public override void WriteValue(decimal value) { }

	[CallerCount(Count = 9)]
	[Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public override void WriteValue(DateTime value) { }

	[CallerCount(Count = 9)]
	[Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public override void WriteValue(DateTimeOffset value) { }

	[CallerCount(Count = 19)]
	[Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public override void WriteValue(Guid value) { }

	[CallerCount(Count = 15)]
	[Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public override void WriteValue(double value) { }

	[CalledBy(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializePrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonPrimitiveContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(JsonWriter), Member = "ResolveConvertibleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConvertible), typeof(PrimitiveTypeCode&), typeof(Object&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Nullable`1<System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Nullable`1<System.Double>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonWriter), Member = "CreateUnsupportedTypeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object)}, ReturnType = typeof(JsonWriterException))]
	[CallsDeduplicatedMethods(Count = 51)]
	[CallsUnknownMethods(Count = 53)]
	internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override void WriteValue(Nullable<Int32> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override void WriteValue(Nullable<Byte> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override void WriteValue(Nullable<Decimal> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override void WriteValue(Nullable<DateTime> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override void WriteValue(Nullable<Char> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override void WriteValue(Nullable<DateTimeOffset> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override void WriteValue(Nullable<Guid> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override void WriteValue(Nullable<TimeSpan> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CLSCompliant(False)]
	public override void WriteValue(Nullable<UInt16> value) { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonDataWriter", Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TraceJsonWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[NullableContext(2)]
	public override void WriteValue(Byte[] value) { }

	[CallerCount(Count = 19)]
	[Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public override void WriteValue(TimeSpan value) { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonDataWriter", Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TraceJsonWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[NullableContext(2)]
	public override void WriteValue(Uri value) { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonDataWriter", Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ConvertUtils), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(PrimitiveTypeCode))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(PrimitiveTypeCode), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonWriter), Member = "CreateUnsupportedTypeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object)}, ReturnType = typeof(JsonWriterException))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[NullableContext(2)]
	public override void WriteValue(object value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override void WriteValue(Nullable<Int16> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override void WriteValue(Nullable<Boolean> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override void WriteValue(Nullable<Double> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override void WriteValue(Nullable<Single> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CLSCompliant(False)]
	public override void WriteValue(Nullable<UInt64> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override void WriteValue(Nullable<Int64> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CLSCompliant(False)]
	public override void WriteValue(Nullable<UInt32> value) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.TimeSpan>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteValueAsync(Nullable<TimeSpan> value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteValueAsync(short value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Int16>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteValueAsync(Nullable<Int16> value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteValueAsync(string value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteValueAsync(TimeSpan value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteValueAsync(long value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CLSCompliant(False)]
	public override Task WriteValueAsync(uint value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteValueAsync(DateTimeOffset value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	internal static Task WriteValueAsync(JsonWriter writer, PrimitiveTypeCode typeCode, object value, CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.DateTimeOffset>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteValueAsync(Nullable<DateTimeOffset> value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteValueAsync(decimal value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Decimal>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteValueAsync(Nullable<Decimal> value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Int64>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteValueAsync(Nullable<Int64> value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteValueAsync(object value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteValueAsync(double value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteValueAsync(float value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteValueAsync(Nullable<Single> value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteValueAsync(Guid value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Guid>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteValueAsync(Nullable<Guid> value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteValueAsync(int value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Int32>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteValueAsync(Nullable<Int32> value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Double>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteValueAsync(Nullable<Double> value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteValueAsync(DateTime value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.DateTime>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteValueAsync(Nullable<DateTime> value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteValueAsync(bool value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.UInt32>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CLSCompliant(False)]
	public override Task WriteValueAsync(Nullable<UInt32> value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CLSCompliant(False)]
	public override Task WriteValueAsync(sbyte value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CLSCompliant(False)]
	public override Task WriteValueAsync(ulong value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.UInt64>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CLSCompliant(False)]
	public override Task WriteValueAsync(Nullable<UInt64> value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteValueAsync(Uri value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CLSCompliant(False)]
	public override Task WriteValueAsync(ushort value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.UInt16>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CLSCompliant(False)]
	public override Task WriteValueAsync(Nullable<UInt16> value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.SByte>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CLSCompliant(False)]
	public override Task WriteValueAsync(Nullable<SByte> value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteValueAsync(byte value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteValueAsync(Nullable<Byte> value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteValueAsync(Byte[] value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteValueAsync(char value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Char>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteValueAsync(Nullable<Char> value, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Boolean>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteValueAsync(Nullable<Boolean> value, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void WriteValueDelimiter() { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueDelimiterAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override Task WriteValueDelimiterAsync(CancellationToken cancellationToken) { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StringUtils), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonWriterException))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override void WriteWhitespace(string ws) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteWhitespaceAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task WriteWhitespaceAsync(string ws, CancellationToken cancellationToken = null) { }

}

