namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(2)]
public abstract class JsonReader : IDisposable
{
	[CompilerGenerated]
	private struct <MoveToContentFromNonContentAsync>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 6)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadAndMoveToContentAsync>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader+<MoveToContentFromNonContentAsync>d__14"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<MoveToContentFromNonContentAsync>d__14&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 11)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadArrayIntoByteArrayAsync>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Byte[]> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		private List<Byte> <buffer>5__2; //Field offset: 0x30
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonReader), Member = "ReadArrayElementIntoByteArrayReportDone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Byte>)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 11)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReaderReadAndAssertAsync>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonReader), Member = "CreateUnexpectedEndException", ReturnType = typeof(JsonReaderException))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SkipAsync>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		private int <depth>5__2; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTokenUtils), Member = "IsStartToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallsUnknownMethods(Count = 8)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[NullableContext(0)]
	private enum State
	{
		Start = 0,
		Complete = 1,
		Property = 2,
		ObjectStart = 3,
		Object = 4,
		ArrayStart = 5,
		Array = 6,
		Closed = 7,
		PostValue = 8,
		ConstructorStart = 9,
		Constructor = 10,
		Error = 11,
		Finished = 12,
	}

	private JsonToken _tokenType; //Field offset: 0x10
	private object _value; //Field offset: 0x18
	internal char _quoteChar; //Field offset: 0x20
	internal State _currentState; //Field offset: 0x24
	private JsonPosition _currentPosition; //Field offset: 0x28
	private CultureInfo _culture; //Field offset: 0x40
	private DateTimeZoneHandling _dateTimeZoneHandling; //Field offset: 0x48
	private Nullable<Int32> _maxDepth; //Field offset: 0x4C
	private bool _hasExceededMaxDepth; //Field offset: 0x54
	internal DateParseHandling _dateParseHandling; //Field offset: 0x58
	internal FloatParseHandling _floatParseHandling; //Field offset: 0x5C
	private string _dateFormatString; //Field offset: 0x60
	private List<JsonPosition> _stack; //Field offset: 0x68
	[CompilerGenerated]
	private bool <CloseInput>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private bool <SupportMultipleContent>k__BackingField; //Field offset: 0x71

	public bool CloseInput
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

	[Nullable(1)]
	public CultureInfo Culture
	{
		[CalledBy(Type = typeof(JsonReader), Member = "ReadAsString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(JsonContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty), typeof(object)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "EnsureType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(object), typeof(CultureInfo), typeof(JsonContract), typeof(Type)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateDictionary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDictionary), typeof(JsonReader), typeof(JsonDictionaryContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[NullableContext(1)]
		 get { } //Length: 84
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[NullableContext(1)]
		 set { } //Length: 13
	}

	protected State CurrentState
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public string DateFormatString
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public DateParseHandling DateParseHandling
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CalledBy(Type = typeof(JsonSerializer), Member = "SetupReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(CultureInfo&), typeof(Nullable`1<DateTimeZoneHandling>&), typeof(Nullable`1<DateParseHandling>&), typeof(Nullable`1<FloatParseHandling>&), typeof(Nullable`1<Int32>&), typeof(String&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(JsonContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty), typeof(object)}, ReturnType = typeof(object))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 99
	}

	public DateTimeZoneHandling DateTimeZoneHandling
	{
		[CallerCount(Count = 26)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CalledBy(Type = typeof(JsonSerializer), Member = "SetupReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(CultureInfo&), typeof(Nullable`1<DateTimeZoneHandling>&), typeof(Nullable`1<DateParseHandling>&), typeof(Nullable`1<FloatParseHandling>&), typeof(Nullable`1<Int32>&), typeof(String&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(JsonContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty), typeof(object)}, ReturnType = typeof(object))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 99
	}

	public override int Depth
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonTokenUtils), Member = "IsStartToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 108
	}

	public FloatParseHandling FloatParseHandling
	{
		[CallerCount(Count = 26)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CalledBy(Type = typeof(JsonSerializer), Member = "SetupReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(CultureInfo&), typeof(Nullable`1<DateTimeZoneHandling>&), typeof(Nullable`1<DateParseHandling>&), typeof(Nullable`1<FloatParseHandling>&), typeof(Nullable`1<Int32>&), typeof(String&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(JsonContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty), typeof(object)}, ReturnType = typeof(object))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 99
	}

	public Nullable<Int32> MaxDepth
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(JsonSerializer), Member = "SetupReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(CultureInfo&), typeof(Nullable`1<DateTimeZoneHandling>&), typeof(Nullable`1<DateParseHandling>&), typeof(Nullable`1<FloatParseHandling>&), typeof(Nullable`1<Int32>&), typeof(String&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializer), Member = "ResetReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(CultureInfo), typeof(System.Nullable`1<Newtonsoft.Json.DateTimeZoneHandling>), typeof(System.Nullable`1<Newtonsoft.Json.DateParseHandling>), typeof(System.Nullable`1<Newtonsoft.Json.FloatParseHandling>), typeof(System.Nullable`1<System.Int32>), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonFormatterConverter), Member = "Convert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateISerializableItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken), typeof(Type), typeof(JsonISerializableContract), typeof(JsonProperty)}, ReturnType = typeof(object))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 179
	}

	[Nullable(1)]
	public override string Path
	{
		[CalledBy(Type = typeof(JTokenReader), Member = "get_Path", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(System.Nullable`1<Newtonsoft.Json.JsonPosition>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonPosition)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonPosition), Member = "BuildPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Newtonsoft.Json.JsonPosition>), typeof(System.Nullable`1<Newtonsoft.Json.JsonPosition>)}, ReturnType = typeof(string))]
		[NullableContext(1)]
		 get { } //Length: 259
	}

	public private override char QuoteChar
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private set { } //Length: 5
	}

	public bool SupportMultipleContent
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

	public override JsonToken TokenType
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public override object Value
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override Type ValueType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		 get { } //Length: 19
	}

	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonDataReader", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonDataReader", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonDataReader", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonDataReader", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TraceJsonReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BsonReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BsonReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BsonReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BsonReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected JsonReader() { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonDataReader", Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BsonReader), Member = "Close", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public override void Close() { }

	[CalledBy(Type = typeof(<ReaderReadAndAssertAsync>d__2), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonReader), Member = "ReadAsBytes", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(JsonReader), Member = "ReaderReadAndAssert", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonReader), Member = "ReadIntoWrappedTypeObject", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextReader+<HandleNullAsync>d__35", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextReader+<ParseValueAsync>d__8", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "HandleNull", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "MatchValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "MatchValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "MatchValueWithTrailingSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonReaderException))]
	[NullableContext(1)]
	internal JsonReaderException CreateUnexpectedEndException() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_CloseInput() { }

	[CalledBy(Type = typeof(JsonReader), Member = "ReadAsString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(JsonContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "EnsureType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(object), typeof(CultureInfo), typeof(JsonContract), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateDictionary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDictionary), typeof(JsonReader), typeof(JsonDictionaryContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[NullableContext(1)]
	public CultureInfo get_Culture() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	protected State get_CurrentState() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	public string get_DateFormatString() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public DateParseHandling get_DateParseHandling() { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTokenUtils), Member = "IsStartToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override int get_Depth() { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	public FloatParseHandling get_FloatParseHandling() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Nullable<Int32> get_MaxDepth() { }

	[CalledBy(Type = typeof(JTokenReader), Member = "get_Path", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Nullable`1<Newtonsoft.Json.JsonPosition>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonPosition)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonPosition), Member = "BuildPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Newtonsoft.Json.JsonPosition>), typeof(System.Nullable`1<Newtonsoft.Json.JsonPosition>)}, ReturnType = typeof(string))]
	[NullableContext(1)]
	public override string get_Path() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override char get_QuoteChar() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_SupportMultipleContent() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public override JsonToken get_TokenType() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public override object get_Value() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	public override Type get_ValueType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	private JsonToken GetContentToken() { }

	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateMultidimensionalArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(JsonReader), typeof(JsonArrayContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(JsonReader), typeof(JsonArrayContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	internal JsonPosition GetPosition(int depth) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CallsUnknownMethods(Count = 6)]
	private JsonContainerType GetTypeForCloseToken(JsonToken token) { }

	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "Populate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JArray), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonLoadSettings)}, ReturnType = typeof(JArray))]
	[CalledBy(Type = typeof(JConstructor), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonLoadSettings)}, ReturnType = typeof(JConstructor))]
	[CalledBy(Type = typeof(JObject), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonLoadSettings)}, ReturnType = typeof(JObject))]
	[CalledBy(Type = typeof(JProperty), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonLoadSettings)}, ReturnType = typeof(JProperty))]
	[CalledBy(Type = typeof(ExpandoObjectConverter), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(object))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal bool MoveToContent() { }

	[CalledBy(Type = "Newtonsoft.Json.Linq.JArray+<LoadAsync>d__2", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JConstructor+<LoadAsync>d__2", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JObject+<LoadAsync>d__2", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JProperty+<LoadAsync>d__4", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<MoveToContentFromNonContentAsync>d__14)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<MoveToContentFromNonContentAsync>d__14&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[NullableContext(1)]
	internal Task<Boolean> MoveToContentAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<MoveToContentFromNonContentAsync>d__14))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<MoveToContentFromNonContentAsync>d__14)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<MoveToContentFromNonContentAsync>d__14&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[NullableContext(1)]
	private Task<Boolean> MoveToContentFromNonContentAsync(CancellationToken cancellationToken) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	private JsonContainerType Peek() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private JsonContainerType Pop() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	private void Push(JsonContainerType value) { }

	public abstract bool Read() { }

	[CalledBy(Type = typeof(JsonFormatterConverter), Member = "Convert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlNodeConverter), Member = "DeserializeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(IXmlDocument), typeof(XmlNamespaceManager), typeof(IXmlNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNodeConverter), Member = "CreateDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(IXmlDocument), typeof(IXmlNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNodeConverter), Member = "CreateInstruction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(IXmlDocument), typeof(IXmlNode), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNodeConverter), Member = "ReadAttributeElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(XmlNamespaceManager)}, ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.String, System.String>))]
	[CalledBy(Type = typeof(XmlNodeConverter), Member = "ReadElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(IXmlDocument), typeof(IXmlNode), typeof(string), typeof(XmlNamespaceManager)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNodeConverter), Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(KeyValuePairConverter), Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(EntityKeyMemberConverter), Member = "ReadAndAssertProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntityKeyMemberConverter), Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DataTableConverter), Member = "CreateRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(DataTable), typeof(JsonSerializer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTableConverter), Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DataSetConverter), Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateISerializableItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken), typeof(Type), typeof(JsonISerializableContract), typeof(JsonProperty)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ReadMetadataProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type&), typeof(JsonContract&), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty), typeof(object), typeof(Object&), typeof(String&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ReadMetadataPropertiesToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JTokenReader), typeof(Type&), typeof(JsonContract&), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty), typeof(object), typeof(Object&), typeof(String&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(JsonContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "Populate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DiscriminatedUnionConverter), Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(object))]
	[CallerCount(Count = 59)]
	[Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonSerializationException))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal void ReadAndAssert() { }

	[CalledBy(Type = typeof(JsonReader), Member = "ReadForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContract), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateJObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(JToken))]
	[CalledBy(Type = typeof(JToken), Member = "ReadFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonLoadSettings)}, ReturnType = typeof(JToken))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal bool ReadAndMoveToContent() { }

	[AsyncStateMachine(typeof(<ReadAndMoveToContentAsync>d__12))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken+<ReadFromAsync>d__3", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadAndMoveToContentAsync>d__12)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadAndMoveToContentAsync>d__12&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[NullableContext(1)]
	internal Task<Boolean> ReadAndMoveToContentAsync(CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(<ReadArrayIntoByteArrayAsync>d__5), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonReader), Member = "ReadArrayIntoByteArray", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	[NullableContext(1)]
	private bool ReadArrayElementIntoByteArrayReportDone(List<Byte> buffer) { }

	[CalledBy(Type = typeof(JsonReader), Member = "ReadAsBytes", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsBytes", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReader), Member = "ReadArrayElementIntoByteArrayReportDone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Byte>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[NullableContext(1)]
	internal Byte[] ReadArrayIntoByteArray() { }

	[AsyncStateMachine(typeof(<ReadArrayIntoByteArrayAsync>d__5))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextReader+<DoReadAsBytesAsync>d__42", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadArrayIntoByteArrayAsync>d__5)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadArrayIntoByteArrayAsync>d__5&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal Task<Byte[]> ReadArrayIntoByteArrayAsync(CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(long)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReader), Member = "ReadBooleanString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Nullable`1<System.Boolean>))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 11)]
	public override Nullable<Boolean> ReadAsBoolean() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncUtils), Member = "CancelIfRequestedAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[Calls(Type = typeof(Task), Member = "FromResult", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CallsDeduplicatedMethods(Count = 1)]
	[NullableContext(1)]
	public override Task<Nullable`1<Boolean>> ReadAsBooleanAsync(CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Guid), Member = "ToByteArray", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(ConvertUtils), Member = "TryConvertGuid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Guid&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Convert), Member = "FromBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(JsonReader), Member = "ReadArrayIntoByteArray", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(JsonReader), Member = "ReadIntoWrappedTypeObject", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[Calls(Type = typeof(JsonReader), Member = "CreateUnexpectedEndException", ReturnType = typeof(JsonReaderException))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 21)]
	public override Byte[] ReadAsBytes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncUtils), Member = "CancelIfRequestedAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[Calls(Type = typeof(Task), Member = "FromResult", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task<Byte[]> ReadAsBytesAsync(CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_DateTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReader), Member = "ReadDateTimeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Nullable`1<System.DateTime>))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 11)]
	public override Nullable<DateTime> ReadAsDateTime() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncUtils), Member = "CancelIfRequestedAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.DateTime>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Nullable`1<System.DateTime>>))]
	[Calls(Type = typeof(Task), Member = "FromResult", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.DateTime>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.DateTime>)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Nullable`1<System.DateTime>>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[NullableContext(1)]
	public override Task<Nullable`1<DateTime>> ReadAsDateTimeAsync(CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReader), Member = "ReadDateTimeOffsetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Nullable`1<System.DateTimeOffset>))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	public override Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncUtils), Member = "CancelIfRequestedAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.DateTimeOffset>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Nullable`1<System.DateTimeOffset>>))]
	[Calls(Type = typeof(Task), Member = "FromResult", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.DateTimeOffset>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.DateTimeOffset>)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Nullable`1<System.DateTimeOffset>>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[NullableContext(1)]
	public override Task<Nullable`1<DateTimeOffset>> ReadAsDateTimeOffsetAsync(CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReader), Member = "ReadDecimalString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Nullable`1<System.Decimal>))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonReaderException))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 17)]
	public override Nullable<Decimal> ReadAsDecimal() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncUtils), Member = "CancelIfRequestedAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Decimal>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Nullable`1<System.Decimal>>))]
	[Calls(Type = typeof(Task), Member = "FromResult", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Decimal>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Decimal>)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Nullable`1<System.Decimal>>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[NullableContext(1)]
	public override Task<Nullable`1<Decimal>> ReadAsDecimalAsync(CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(System.Nullable`1<System.Double>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReader), Member = "ReadDoubleString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Nullable`1<System.Double>))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	public override Nullable<Double> ReadAsDouble() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "FromResult", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Double>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Double>)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Nullable`1<System.Double>>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[NullableContext(1)]
	public override Task<Nullable`1<Double>> ReadAsDoubleAsync(CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReader), Member = "ReadInt32String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Nullable`1<System.Int32>))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonReaderException))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 16)]
	public override Nullable<Int32> ReadAsInt32() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncUtils), Member = "CancelIfRequestedAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Int32>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Nullable`1<System.Int32>>))]
	[Calls(Type = typeof(Task), Member = "FromResult", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Int32>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Nullable`1<System.Int32>>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[NullableContext(1)]
	public override Task<Nullable`1<Int32>> ReadAsInt32Async(CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReader), Member = "get_Culture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public override string ReadAsString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncUtils), Member = "CancelIfRequestedAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[Calls(Type = typeof(Task), Member = "FromResult", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Task<String> ReadAsStringAsync(CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncUtils), Member = "CancelIfRequestedAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[Calls(Type = typeof(AsyncUtils), Member = "ToAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[NullableContext(1)]
	public override Task<Boolean> ReadAsync(CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JsonReader), Member = "ReadAsBoolean", ReturnType = typeof(System.Nullable`1<System.Boolean>))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsBoolean", ReturnType = typeof(System.Nullable`1<System.Boolean>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(bool), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal Nullable<Boolean> ReadBooleanString(string s) { }

	[CalledBy(Type = typeof(JsonReader), Member = "ReadAsDateTimeOffset", ReturnType = typeof(System.Nullable`1<System.DateTimeOffset>))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "FinishReadQuotedStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(CultureInfo), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeOffset), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CallsUnknownMethods(Count = 5)]
	internal Nullable<DateTimeOffset> ReadDateTimeOffsetString(string s) { }

	[CalledBy(Type = typeof(JsonReader), Member = "ReadAsDateTime", ReturnType = typeof(System.Nullable`1<System.DateTime>))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "FinishReadQuotedStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(DateTimeUtils), Member = "TryParseDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTimeZoneHandling), typeof(string), typeof(CultureInfo), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeUtils), Member = "EnsureDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTimeZoneHandling)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal Nullable<DateTime> ReadDateTimeString(string s) { }

	[CalledBy(Type = typeof(JsonReader), Member = "ReadAsDecimal", ReturnType = typeof(System.Nullable`1<System.Decimal>))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadNumberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "FinishReadQuotedNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Decimal), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Decimal&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(ConvertUtils), Member = "DecimalTryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(Decimal&)}, ReturnType = typeof(ParseResult))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CallsUnknownMethods(Count = 6)]
	internal Nullable<Decimal> ReadDecimalString(string s) { }

	[CalledBy(Type = typeof(JsonReader), Member = "ReadAsDouble", ReturnType = typeof(System.Nullable`1<System.Double>))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadNumberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "FinishReadQuotedNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(double), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Double&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Nullable`1<System.Double>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CallsUnknownMethods(Count = 5)]
	internal Nullable<Double> ReadDoubleString(string s) { }

	[CalledBy(Type = typeof(JsonReader), Member = "ReadIntoWrappedTypeObject", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsBytes", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JsonReader), Member = "CreateUnexpectedEndException", ReturnType = typeof(JsonReaderException))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void ReaderReadAndAssert() { }

	[AsyncStateMachine(typeof(<ReaderReadAndAssertAsync>d__2))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextReader+<DoReadAsBytesAsync>d__42", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextReader+<ReadIntoWrappedTypeObjectAsync>d__43", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReaderReadAndAssertAsync>d__2)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReaderReadAndAssertAsync>d__2&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[NullableContext(1)]
	internal Task ReaderReadAndAssertAsync(CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(JsonReader), Member = "ReadForTypeAndAssert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContract), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateDictionary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDictionary), typeof(JsonReader), typeof(JsonDictionaryContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateMultidimensionalArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(JsonReader), typeof(JsonArrayContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(JsonReader), typeof(JsonArrayContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ResolvePropertyAndCreatorValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonObjectContract), typeof(JsonProperty), typeof(JsonReader), typeof(Type)}, ReturnType = typeof(System.Collections.Generic.List`1<Newtonsoft.Json.Serialization.JsonSerializerInternalReader+CreatorPropertyContext>))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonReader), typeof(JsonObjectContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(JsonReader), Member = "ReadAndMoveToContent", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	internal bool ReadForType(JsonContract contract, bool hasConverter) { }

	[CalledBy(Type = typeof(KeyValuePairConverter), Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JsonReader), Member = "ReadForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContract), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonSerializationException))]
	[CallsUnknownMethods(Count = 3)]
	internal void ReadForTypeAndAssert(JsonContract contract, bool hasConverter) { }

	[CalledBy(Type = typeof(JsonReader), Member = "ReadAsInt32", ReturnType = typeof(System.Nullable`1<System.Int32>))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadNumberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "FinishReadQuotedNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal Nullable<Int32> ReadInt32String(string s) { }

	[CalledBy(Type = typeof(JsonReader), Member = "ReadAsBytes", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsBytes", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonReader), Member = "ReaderReadAndAssert", ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[Calls(Type = typeof(JsonReader), Member = "CreateUnexpectedEndException", ReturnType = typeof(JsonReaderException))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 11)]
	internal void ReadIntoWrappedTypeObject() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_CloseInput(bool value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NullableContext(1)]
	public void set_Culture(CultureInfo value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_DateFormatString(string value) { }

	[CalledBy(Type = typeof(JsonSerializer), Member = "SetupReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(CultureInfo&), typeof(Nullable`1<DateTimeZoneHandling>&), typeof(Nullable`1<DateParseHandling>&), typeof(Nullable`1<FloatParseHandling>&), typeof(Nullable`1<Int32>&), typeof(String&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(JsonContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty), typeof(object)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_DateParseHandling(DateParseHandling value) { }

	[CalledBy(Type = typeof(JsonSerializer), Member = "SetupReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(CultureInfo&), typeof(Nullable`1<DateTimeZoneHandling>&), typeof(Nullable`1<DateParseHandling>&), typeof(Nullable`1<FloatParseHandling>&), typeof(Nullable`1<Int32>&), typeof(String&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(JsonContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty), typeof(object)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	[CalledBy(Type = typeof(JsonSerializer), Member = "SetupReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(CultureInfo&), typeof(Nullable`1<DateTimeZoneHandling>&), typeof(Nullable`1<DateParseHandling>&), typeof(Nullable`1<FloatParseHandling>&), typeof(Nullable`1<Int32>&), typeof(String&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(JsonContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty), typeof(object)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_FloatParseHandling(FloatParseHandling value) { }

	[CalledBy(Type = typeof(JsonSerializer), Member = "SetupReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(CultureInfo&), typeof(Nullable`1<DateTimeZoneHandling>&), typeof(Nullable`1<DateParseHandling>&), typeof(Nullable`1<FloatParseHandling>&), typeof(Nullable`1<Int32>&), typeof(String&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializer), Member = "ResetReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(CultureInfo), typeof(System.Nullable`1<Newtonsoft.Json.DateTimeZoneHandling>), typeof(System.Nullable`1<Newtonsoft.Json.DateParseHandling>), typeof(System.Nullable`1<Newtonsoft.Json.FloatParseHandling>), typeof(System.Nullable`1<System.Int32>), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonFormatterConverter), Member = "Convert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateISerializableItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken), typeof(Type), typeof(JsonISerializableContract), typeof(JsonProperty)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public void set_MaxDepth(Nullable<Int32> value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected private override void set_QuoteChar(char value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_SupportMultipleContent(bool value) { }

	[CallerCount(Count = 0)]
	private void SetFinished() { }

	[CallerCount(Count = 0)]
	internal void SetPostValueState(bool updateIndex) { }

	[CalledBy(Type = "Newtonsoft.Json.JsonTextReader+<ParsePostValueAsync>d__4", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsBytes", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ProcessValueComma", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParsePostValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CallsUnknownMethods(Count = 6)]
	protected void SetStateBasedOnCurrent() { }

	[CallerCount(Count = 51)]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	protected void SetToken(JsonToken newToken) { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonDataReader", Member = "ReadCodeWScope", ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonDataReader", Member = "ReadReference", ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonDataReader", Member = "ReadNormal", ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonDataReader", Member = "ReadType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Bson.BsonType"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextReader+<DoReadAsBooleanAsync>d__40", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextReader+<MatchAndSetAsync>d__21", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextReader+<ParseConstructorAsync>d__25", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextReader+<ParsePropertyAsync>d__31", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextReader+<ReadStringValueAsync>d__37", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BsonReader), Member = "ReadCodeWScope", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BsonReader), Member = "ReadReference", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BsonReader), Member = "ReadNormal", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BsonReader), Member = "ReadType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 34)]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	protected void SetToken(JsonToken newToken, object value) { }

	[CallerCount(Count = 85)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	protected void SetToken(JsonToken newToken, object value, bool updateIndex) { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.Converters.BsonDataRegexConverter", Member = "ReadRegexObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonSerializer)}, ReturnType = typeof(Regex))]
	[CalledBy(Type = typeof(RegexConverter), Member = "ReadRegexObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonSerializer)}, ReturnType = typeof(Regex))]
	[CalledBy(Type = typeof(KeyValuePairConverter), Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "HandleError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "EndProcessProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonReader), typeof(JsonObjectContract), typeof(int), typeof(JsonProperty), typeof(PropertyPresence), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "SetExtensionData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonObjectContract), typeof(JsonProperty), typeof(JsonReader), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CheckPropertyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ResolvePropertyAndCreatorValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonObjectContract), typeof(JsonProperty), typeof(JsonReader), typeof(Type)}, ReturnType = typeof(System.Collections.Generic.List`1<Newtonsoft.Json.Serialization.JsonSerializerInternalReader+CreatorPropertyContext>))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateDynamic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonDynamicContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(JsonReader), typeof(JsonArrayContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateMultidimensionalArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(JsonReader), typeof(JsonArrayContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateDictionary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDictionary), typeof(JsonReader), typeof(JsonDictionaryContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ReadMetadataPropertiesToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JTokenReader), typeof(Type&), typeof(JsonContract&), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty), typeof(object), typeof(Object&), typeof(String&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonReader), typeof(JsonObjectContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(JsonTokenUtils), Member = "IsStartToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	public void Skip() { }

	[AsyncStateMachine(typeof(<SkipAsync>d__1))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JContainer+<ReadContentFromAsync>d__1", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SkipAsync>d__1)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SkipAsync>d__1&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[NullableContext(1)]
	public Task SkipAsync(CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private override void System.IDisposable.Dispose() { }

	[CallerCount(Count = 0)]
	private void UpdateScopeWithFinishedValue() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	[ContainsUnimplementedInstructions]
	private void ValidateEnd(JsonToken endToken) { }

}

