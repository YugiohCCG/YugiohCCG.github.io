namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
public class JsonTextReader : JsonReader, IJsonLineInfo
{
	[CompilerGenerated]
	private struct <DoReadAsBooleanAsync>d__40 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Nullable`1<Boolean>> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		private BigInteger <i>5__2; //Field offset: 0x40
		private bool <isTrue>5__3; //Field offset: 0x50
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x58

		[CalledBy(Type = typeof(AsyncTaskMethodBuilder`1), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TStateMachine&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextReader), Member = "EnsureBuffer", ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextReader), Member = "ParsePostValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextReader), Member = "HandleNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.Boolean>>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter), typeof(<DoReadAsBooleanAsync>d__40)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter&), typeof(<DoReadAsBooleanAsync>d__40&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextReader), Member = "MatchValueWithTrailingSeparatorAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextReader), Member = "ReadNullCharAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 15)]
		[ContainsInvalidInstructions]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoReadAsBytesAsync>d__42 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Byte[]> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private bool <isWrapped>5__2; //Field offset: 0x30
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x38
		[Nullable(0)]
		private Byte[] <data>5__3; //Field offset: 0x48
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x50
		[Nullable(new IL2CPP_TYPE_U1[] {0, 2})]
		private ConfiguredTaskAwaiter<Byte[]> <>u__3; //Field offset: 0x60

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
		[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(JsonTextReader), Member = "CreateUnexpectedCharacterException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(JsonReaderException))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextReader), Member = "ReadFinishedAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(JsonTextReader), Member = "ProcessLineFeed", ReturnType = typeof(void))]
		[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(JsonTextReader), Member = "ProcessCarriageReturnAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(JsonTextReader), Member = "ReadNullCharAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonReader), Member = "ReaderReadAndAssertAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(JsonTextReader), Member = "ParseStringAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(ReadType), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(JsonReader), Member = "ReadArrayIntoByteArrayAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<Byte[]>))]
		[Calls(Type = typeof(JsonTextReader), Member = "ParseCommentAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(JsonTextReader), Member = "ProcessValueComma", ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextReader), Member = "ReadIntoWrappedTypeObjectAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(JsonTextReader), Member = "HandleNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(JsonTextReader), Member = "ParsePostValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(JsonTextReader), Member = "EnsureBuffer", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 23)]
		[CallsUnknownMethods(Count = 58)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoReadAsDateTimeAsync>d__45 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Nullable`1<DateTime>> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(new IL2CPP_TYPE_U1[] {0, 2})]
		private ConfiguredTaskAwaiter<Object> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonTextReader), Member = "ReadStringValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.DateTime>>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.DateTime>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.DateTime>>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter<System.Object>), typeof(<DoReadAsDateTimeAsync>d__45)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter<Object>&), typeof(<DoReadAsDateTimeAsync>d__45&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.DateTime>>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoReadAsDateTimeOffsetAsync>d__47 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Nullable`1<DateTimeOffset>> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(new IL2CPP_TYPE_U1[] {0, 2})]
		private ConfiguredTaskAwaiter<Object> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonTextReader), Member = "ReadStringValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.DateTimeOffset>>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.DateTimeOffset>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.DateTimeOffset>>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter<System.Object>), typeof(<DoReadAsDateTimeOffsetAsync>d__47)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter<Object>&), typeof(<DoReadAsDateTimeOffsetAsync>d__47&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.DateTimeOffset>>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoReadAsDecimalAsync>d__49 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Nullable`1<Decimal>> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(new IL2CPP_TYPE_U1[] {0, 2})]
		private ConfiguredTaskAwaiter<Object> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonTextReader), Member = "ReadNumberValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.Decimal>>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Decimal>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.Decimal>>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter<System.Object>), typeof(<DoReadAsDecimalAsync>d__49)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter<Object>&), typeof(<DoReadAsDecimalAsync>d__49&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.Decimal>>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoReadAsDoubleAsync>d__51 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Nullable`1<Double>> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(new IL2CPP_TYPE_U1[] {0, 2})]
		private ConfiguredTaskAwaiter<Object> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonTextReader), Member = "ReadNumberValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.Double>>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Double>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.Double>>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter<System.Object>), typeof(<DoReadAsDoubleAsync>d__51)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter<Object>&), typeof(<DoReadAsDoubleAsync>d__51&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.Double>>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoReadAsInt32Async>d__53 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Nullable`1<Int32>> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(new IL2CPP_TYPE_U1[] {0, 2})]
		private ConfiguredTaskAwaiter<Object> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonTextReader), Member = "ReadNumberValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.Int32>>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.Int32>>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter<System.Object>), typeof(<DoReadAsInt32Async>d__53)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter<Object>&), typeof(<DoReadAsInt32Async>d__53&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.Int32>>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoReadAsStringAsync>d__55 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(new IL2CPP_TYPE_U1[] {0, 2})]
		private ConfiguredTaskAwaiter<Object> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonTextReader), Member = "ReadStringValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoReadAsync>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Task<Boolean> task; //Field offset: 0x20
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(JsonTextReader), Member = "DoReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EatWhitespaceAsync>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonTextReader), Member = "ReadDataAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextReader), Member = "ProcessLineFeed", ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextReader), Member = "ProcessCarriageReturnAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 8)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <HandleNullAsync>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonTextReader), Member = "EnsureCharsAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(JsonTextReader), Member = "ParseNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonReader), Member = "CreateUnexpectedEndException", ReturnType = typeof(JsonReaderException))]
		[Calls(Type = typeof(JsonTextReader), Member = "CreateUnexpectedCharacterException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(JsonReaderException))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 25)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <MatchAndSetAsync>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[Nullable(0)]
		public string value; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		public JsonToken newToken; //Field offset: 0x38
		[Nullable(0)]
		public object tokenValue; //Field offset: 0x40
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonTextReader), Member = "MatchValueWithTrailingSeparatorAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 12)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <MatchValueAsync>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[Nullable(0)]
		public string value; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonTextReader), Member = "EnsureCharsAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(JsonTextReader), Member = "MatchValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <MatchValueWithTrailingSeparatorAsync>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		[Nullable(0)]
		public string value; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonTextReader), Member = "MatchValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(JsonTextReader), Member = "EnsureCharsAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(JsonTextReader), Member = "IsSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 13)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ParseCommentAsync>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public bool setToken; //Field offset: 0x30
		private bool <singlelineComment>5__2; //Field offset: 0x31
		private int <initialPosition>5__3; //Field offset: 0x34
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x38
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Int32> <>u__2; //Field offset: 0x48
		private ConfiguredTaskAwaiter <>u__3; //Field offset: 0x58

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonTextReader), Member = "EnsureCharsAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextReader), Member = "ProcessCarriageReturnAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(JsonTextReader), Member = "EndComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextReader), Member = "ReadDataAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
		[Calls(Type = typeof(JsonTextReader), Member = "ProcessLineFeed", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 37)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ParseConstructorAsync>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		private int <initialPosition>5__2; //Field offset: 0x40
		private int <endPosition>5__3; //Field offset: 0x44
		[Nullable(0)]
		private string <constructorName>5__4; //Field offset: 0x48
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x50
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Int32> <>u__3; //Field offset: 0x60

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextReader), Member = "ReadDataAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextReader), Member = "ClearRecentString", ReturnType = typeof(void))]
		[Calls(Type = typeof(StringReference), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(JsonTextReader), Member = "ProcessLineFeed", ReturnType = typeof(void))]
		[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(char), Member = "IsLetterOrDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(JsonTextReader), Member = "EatWhitespaceAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(JsonTextReader), Member = "MatchValueWithTrailingSeparatorAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(JsonTextReader), Member = "ProcessCarriageReturnAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[CallsDeduplicatedMethods(Count = 11)]
		[CallsUnknownMethods(Count = 44)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ParseNumberAsync>d__29 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public ReadType readType; //Field offset: 0x30
		private char <firstChar>5__2; //Field offset: 0x34
		private int <initialPosition>5__3; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonTextReader), Member = "ShiftBufferIfNeeded", ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextReader), Member = "ReadNumberIntoBufferAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(JsonTextReader), Member = "ParseReadNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType), typeof(char), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ParseNumberNaNAsync>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Object> <>t__builder; //Field offset: 0x8
		public ReadType readType; //Field offset: 0x20
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private ReadType <>7__wrap1; //Field offset: 0x38
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonTextReader), Member = "MatchValueWithTrailingSeparatorAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(JsonTextReader), Member = "ParseNumberNaN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType), typeof(bool)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ParseNumberNegativeInfinityAsync>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Object> <>t__builder; //Field offset: 0x8
		public ReadType readType; //Field offset: 0x20
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private ReadType <>7__wrap1; //Field offset: 0x38
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonTextReader), Member = "MatchValueWithTrailingSeparatorAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(JsonTextReader), Member = "ParseNumberNegativeInfinity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType), typeof(bool)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ParseNumberPositiveInfinityAsync>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Object> <>t__builder; //Field offset: 0x8
		public ReadType readType; //Field offset: 0x20
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private ReadType <>7__wrap1; //Field offset: 0x38
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonTextReader), Member = "MatchValueWithTrailingSeparatorAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(JsonTextReader), Member = "ParseNumberPositiveInfinity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType), typeof(bool)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ParseObjectAsync>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x40
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__3; //Field offset: 0x50

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonTextReader), Member = "ParseCommentAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter), typeof(<ParseObjectAsync>d__15)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter&), typeof(<ParseObjectAsync>d__15&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextReader), Member = "ReadDataAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextReader), Member = "ProcessCarriageReturnAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(JsonTextReader), Member = "ParsePropertyAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(JsonTextReader), Member = "ProcessLineFeed", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 13)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ParsePostValueAsync>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public bool ignoreComments; //Field offset: 0x30
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter<System.Int32>), typeof(<ParsePostValueAsync>d__4)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter<Int32>&), typeof(<ParsePostValueAsync>d__4&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextReader), Member = "ProcessLineFeed", ReturnType = typeof(void))]
		[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(JsonTextReader), Member = "ProcessCarriageReturnAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(JsonTextReader), Member = "ReadDataAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter), typeof(<ParsePostValueAsync>d__4)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter&), typeof(<ParsePostValueAsync>d__4&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(JsonTextReader), Member = "ParseCommentAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(JsonReader), Member = "SetStateBasedOnCurrent", ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 17)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ParsePropertyAsync>d__31 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private char <quoteChar>5__2; //Field offset: 0x30
		[Nullable(0)]
		private string <propertyName>5__3; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
		[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextReader), Member = "ClearRecentString", ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextReader), Member = "EatWhitespaceAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(StringReference), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(JsonTextReader), Member = "ReadStringIntoBufferAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(JsonTextReader), Member = "ParseUnquotedPropertyAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(JsonTextReader), Member = "ShiftBufferIfNeeded", ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextReader), Member = "ValidIdentifierChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 38)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ParseStringAsync>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CancellationToken cancellationToken; //Field offset: 0x20
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x28
		public char quote; //Field offset: 0x30
		public ReadType readType; //Field offset: 0x34
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextReader), Member = "ShiftBufferIfNeeded", ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextReader), Member = "ReadStringIntoBufferAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(JsonTextReader), Member = "ParseReadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(ReadType)}, ReturnType = typeof(void))]
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
	private struct <ParseUnicodeAsync>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Char> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonTextReader), Member = "EnsureCharsAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(JsonTextReader), Member = "ConvertUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Char>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Char>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter<System.Boolean>), typeof(<ParseUnicodeAsync>d__12)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter<Boolean>&), typeof(<ParseUnicodeAsync>d__12&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Char>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ParseUnquotedPropertyAsync>d__33 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private int <initialPosition>5__2; //Field offset: 0x30
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonTextReader), Member = "ReadUnquotedPropertyReportIfDone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextReader), Member = "ReadDataAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 11)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ParseValueAsync>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x40
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__3; //Field offset: 0x50
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		private ConfiguredTaskAwaiter<Object> <>u__4; //Field offset: 0x60

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonTextReader), Member = "CreateUnexpectedCharacterException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(JsonReaderException))]
		[Calls(Type = typeof(JsonReader), Member = "CreateUnexpectedEndException", ReturnType = typeof(JsonReaderException))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextReader), Member = "ProcessLineFeed", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextReader), Member = "ProcessCarriageReturnAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(char), Member = "IsNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(JsonTextReader), Member = "ReadDataAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
		[Calls(Type = typeof(JsonTextReader), Member = "ParseStringAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(ReadType), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(JsonTextReader), Member = "ParseCommentAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(JsonTextReader), Member = "ParseNumberAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(JsonTextReader), Member = "ParseNumberNegativeInfinityAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
		[Calls(Type = typeof(JsonTextReader), Member = "ParseNumberPositiveInfinityAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
		[Calls(Type = typeof(JsonTextReader), Member = "ParseFalseAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(JsonTextReader), Member = "ParseTrueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextReader), Member = "ParseNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(JsonTextReader), Member = "ParseConstructorAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(JsonTextReader), Member = "EnsureCharsAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter), typeof(<ParseValueAsync>d__8)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter&), typeof(<ParseValueAsync>d__8&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(JsonTextReader), Member = "ParseUndefinedAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(JsonTextReader), Member = "ParseNumberNaNAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
		[CallsDeduplicatedMethods(Count = 33)]
		[CallsUnknownMethods(Count = 62)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ProcessCarriageReturnAsync>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Task<Boolean> task; //Field offset: 0x20
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x28
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(JsonTextReader), Member = "SetNewLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadCharsAsync>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public int relativePosition; //Field offset: 0x28
		public bool append; //Field offset: 0x2C
		public CancellationToken cancellationToken; //Field offset: 0x30
		private int <charsRequired>5__2; //Field offset: 0x38
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonTextReader), Member = "ReadDataAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadDataAsync>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public bool append; //Field offset: 0x28
		public int charsRequired; //Field offset: 0x2C
		public CancellationToken cancellationToken; //Field offset: 0x30
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonTextReader), Member = "PrepareBufferForReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncUtils), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(Char[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 9)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadFinishedAsync>d__36 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonTextReader), Member = "EnsureCharsAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextReader), Member = "EatWhitespaceAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(JsonTextReader), Member = "ParseCommentAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 22)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadFromFinishedAsync>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonTextReader), Member = "EnsureCharsAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextReader), Member = "EatWhitespaceAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(JsonTextReader), Member = "ParseCommentAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 23)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadIntoWrappedTypeObjectAsync>d__43 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonReader), Member = "ReaderReadAndAssertAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
		[CallsDeduplicatedMethods(Count = 16)]
		[CallsUnknownMethods(Count = 21)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadNullCharAsync>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonTextReader), Member = "ReadDataAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadNumberIntoBufferAsync>d__32 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private int <charPos>5__2; //Field offset: 0x30
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonTextReader), Member = "ReadNumberCharIntoBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(JsonTextReader), Member = "ReadDataAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadNumberValueAsync>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Object> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public ReadType readType; //Field offset: 0x30
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x48
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		private ConfiguredTaskAwaiter<Object> <>u__3; //Field offset: 0x58

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonTextReader), Member = "EnsureBuffer", ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextReader), Member = "ParsePostValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextReader), Member = "HandleNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter), typeof(<ReadNumberValueAsync>d__38)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConfiguredTaskAwaiter&), typeof(<ReadNumberValueAsync>d__38&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextReader), Member = "ParseNumberPositiveInfinityAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
		[Calls(Type = typeof(JsonTextReader), Member = "ParseNumberNaNAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
		[Calls(Type = typeof(JsonTextReader), Member = "ReadNullCharAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 11)]
		[CallsUnknownMethods(Count = 21)]
		[ContainsInvalidInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadStringIntoBufferAsync>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public char quote; //Field offset: 0x30
		private int <charPos>5__2; //Field offset: 0x34
		private int <initialPosition>5__3; //Field offset: 0x38
		private int <lastWritePosition>5__4; //Field offset: 0x3C
		private int <escapeStartPos>5__5; //Field offset: 0x40
		private char <writeChar>5__6; //Field offset: 0x44
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x48
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__2; //Field offset: 0x58
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Char> <>u__3; //Field offset: 0x68
		private bool <anotherHighSurrogate>5__7; //Field offset: 0x78
		private char <highSurrogate>5__8; //Field offset: 0x7A
		private ConfiguredTaskAwaiter <>u__4; //Field offset: 0x80

		[CallerCount(Count = 0)]
		[ContainsInvalidInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadStringValueAsync>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Object> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonTextReader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public ReadType readType; //Field offset: 0x30
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x38
		[Nullable(0)]
		private string <expected>5__2; //Field offset: 0x48
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x50
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		private ConfiguredTaskAwaiter<Object> <>u__3; //Field offset: 0x60

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
		[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(JsonTextReader), Member = "CreateUnexpectedCharacterException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(JsonReaderException))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextReader), Member = "ReadFinishedAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(JsonTextReader), Member = "ProcessLineFeed", ReturnType = typeof(void))]
		[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(JsonTextReader), Member = "ProcessCarriageReturnAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextReader), Member = "ReadNullCharAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(JsonTextReader), Member = "ParseNumberPositiveInfinityAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
		[Calls(Type = typeof(JsonTextReader), Member = "ParseCommentAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(JsonTextReader), Member = "ParseNumberAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(JsonTextReader), Member = "MatchValueWithTrailingSeparatorAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(JsonTextReader), Member = "EnsureCharsAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(JsonTextReader), Member = "ProcessValueComma", ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextReader), Member = "FinishReadQuotedStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(JsonTextReader), Member = "ParseStringAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(ReadType), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextReader), Member = "ParseNumberNaNAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
		[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextReader), Member = "ParseNumberNegativeInfinity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(JsonTextReader), Member = "HandleNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(JsonTextReader), Member = "ParsePostValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(JsonTextReader), Member = "EnsureBuffer", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 29)]
		[CallsUnknownMethods(Count = 78)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const char UnicodeReplacementChar = '\uFFFD'; //Field offset: 0x0
	private const int MaximumJavascriptIntegerCharacterLength = 380; //Field offset: 0x0
	private const int LargeBufferLength = 1073741823; //Field offset: 0x0
	private readonly bool _safeAsync; //Field offset: 0x78
	private readonly TextReader _reader; //Field offset: 0x80
	[Nullable(2)]
	private Char[] _chars; //Field offset: 0x88
	private int _charsUsed; //Field offset: 0x90
	private int _charPos; //Field offset: 0x94
	private int _lineStartPos; //Field offset: 0x98
	private int _lineNumber; //Field offset: 0x9C
	private bool _isEndOfFile; //Field offset: 0xA0
	private StringBuffer _stringBuffer; //Field offset: 0xA8
	private StringReference _stringReference; //Field offset: 0xB8
	[Nullable(2)]
	private IArrayPool<Char> _arrayPool; //Field offset: 0xC8
	[CompilerGenerated]
	[Nullable(2)]
	private JsonNameTable <PropertyNameTable>k__BackingField; //Field offset: 0xD0

	[Nullable(2)]
	public IArrayPool<Char> ArrayPool
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[NullableContext(2)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		[NullableContext(2)]
		 set { } //Length: 114
	}

	public override int LineNumber
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 70
	}

	public override int LinePosition
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 13
	}

	[Nullable(2)]
	public JsonNameTable PropertyNameTable
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[NullableContext(2)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[NullableContext(2)]
		 set { } //Length: 19
	}

	[CalledBy(Type = typeof(JsonConvert), Member = "DeserializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(JsonSerializerSettings)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonConvert), Member = "PopulateObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(JsonSerializerSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializer), Member = "Populate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializer), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSchema), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonSchemaResolver)}, ReturnType = typeof(JsonSchema))]
	[CalledBy(Type = typeof(JArray), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonLoadSettings)}, ReturnType = typeof(JArray))]
	[CalledBy(Type = typeof(JObject), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonLoadSettings)}, ReturnType = typeof(JObject))]
	[CalledBy(Type = typeof(JToken), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonLoadSettings)}, ReturnType = typeof(JToken))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public JsonTextReader(TextReader reader) { }

	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseReadNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType), typeof(char), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BigInteger), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(BigInteger))]
	private static object BigIntegerParse(string number, CultureInfo culture) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private static void BlockCopyChars(Char[] src, int srcOffset, Char[] dst, int dstOffset, int count) { }

	[CalledBy(Type = typeof(<ParseConstructorAsync>d__25), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParsePropertyAsync>d__31), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	private void ClearRecentString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BufferUtils), Member = "ReturnBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(Char[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuffer), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void Close() { }

	[CalledBy(Type = typeof(<ParseUnicodeAsync>d__12), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConvertUtils), Member = "TryHexTextToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Convert), Member = "ToChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 8)]
	private char ConvertUnicode(bool enoughChars) { }

	[CalledBy(Type = typeof(<DoReadAsBytesAsync>d__42), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<HandleNullAsync>d__35), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParseValueAsync>d__8), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadStringValueAsync>d__37), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsBytes", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsBoolean", ReturnType = typeof(System.Nullable`1<System.Boolean>))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ProcessValueComma", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadNumberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "HandleNull", ReturnType = typeof(void))]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonReaderException))]
	private JsonReaderException CreateUnexpectedCharacterException(char c) { }

	[AsyncStateMachine(typeof(<DoReadAsBooleanAsync>d__40))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TStateMachine&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "get_Task", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal Task<Nullable`1<Boolean>> DoReadAsBooleanAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoReadAsBytesAsync>d__42))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoReadAsBytesAsync>d__42)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoReadAsBytesAsync>d__42&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal Task<Byte[]> DoReadAsBytesAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoReadAsDateTimeAsync>d__45))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.DateTime>>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoReadAsDateTimeAsync>d__45)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoReadAsDateTimeAsync>d__45&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.DateTime>>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Nullable`1<System.DateTime>>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal Task<Nullable`1<DateTime>> DoReadAsDateTimeAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoReadAsDateTimeOffsetAsync>d__47))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.DateTimeOffset>>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoReadAsDateTimeOffsetAsync>d__47)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoReadAsDateTimeOffsetAsync>d__47&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.DateTimeOffset>>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Nullable`1<System.DateTimeOffset>>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal Task<Nullable`1<DateTimeOffset>> DoReadAsDateTimeOffsetAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoReadAsDecimalAsync>d__49))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.Decimal>>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoReadAsDecimalAsync>d__49)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoReadAsDecimalAsync>d__49&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.Decimal>>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Nullable`1<System.Decimal>>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal Task<Nullable`1<Decimal>> DoReadAsDecimalAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoReadAsDoubleAsync>d__51))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.Double>>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoReadAsDoubleAsync>d__51)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoReadAsDoubleAsync>d__51&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.Double>>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Nullable`1<System.Double>>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal Task<Nullable`1<Double>> DoReadAsDoubleAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoReadAsInt32Async>d__53))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.Int32>>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoReadAsInt32Async>d__53)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoReadAsInt32Async>d__53&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.Int32>>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Nullable`1<System.Int32>>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal Task<Nullable`1<Int32>> DoReadAsInt32Async(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoReadAsStringAsync>d__55))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoReadAsStringAsync>d__55)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoReadAsStringAsync>d__55&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal Task<String> DoReadAsStringAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<DoReadAsync>d__3))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoReadAsync>d__3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoReadAsync>d__3&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private Task<Boolean> DoReadAsync(Task<Boolean> task, CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(<DoReadAsync>d__3), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadFromFinishedAsync>d__5)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadFromFinishedAsync>d__5&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseValueAsync>d__8)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseValueAsync>d__8&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseObjectAsync>d__15)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseObjectAsync>d__15&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoReadAsync>d__3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoReadAsync>d__3&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task`1), Member = "get_Result", ReturnType = "TResult")]
	[Calls(Type = typeof(AsyncUtils), Member = "IsCompletedSuccessfully", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParsePostValueAsync>d__4)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParsePostValueAsync>d__4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BufferUtils), Member = "RentBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(int)}, ReturnType = typeof(Char[]))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 26)]
	internal Task<Boolean> DoReadAsync(CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsBytes", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsBoolean", ReturnType = typeof(System.Nullable`1<System.Boolean>))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadNumberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadFinished", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseProperty", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseConstructor", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(JsonTextReader), Member = "ReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(JsonTextReader), Member = "EnsureChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private void EatWhitespace() { }

	[AsyncStateMachine(typeof(<EatWhitespaceAsync>d__17))]
	[CalledBy(Type = typeof(<ParseConstructorAsync>d__25), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParsePropertyAsync>d__31), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadFinishedAsync>d__36), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadFromFinishedAsync>d__5), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<EatWhitespaceAsync>d__17)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<EatWhitespaceAsync>d__17&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task EatWhitespaceAsync(CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(<ParseCommentAsync>d__16), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	private void EndComment(bool setToken, int initialPosition, int endPosition) { }

	[CalledBy(Type = typeof(<DoReadAsBooleanAsync>d__40), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<DoReadAsBytesAsync>d__42), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadNumberValueAsync>d__38), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadStringValueAsync>d__37), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BufferUtils), Member = "RentBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(int)}, ReturnType = typeof(Char[]))]
	[CallsUnknownMethods(Count = 3)]
	private void EnsureBuffer() { }

	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadStringIntoBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void EnsureBufferNotEmpty() { }

	[CalledBy(Type = typeof(JsonTextReader), Member = "HandleNull", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadFinished", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadStringIntoBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseUnicode", ReturnType = typeof(char))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParsePostValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseObject", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ProcessCarriageReturn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "EatWhitespace", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "MatchValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "MatchValueWithTrailingSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "IsSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(JsonTextReader), Member = "PrepareBufferForReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool EnsureChars(int relativePosition, bool append) { }

	[CalledBy(Type = typeof(<HandleNullAsync>d__35), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<MatchValueAsync>d__19), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<MatchValueWithTrailingSeparatorAsync>d__20), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParseCommentAsync>d__16), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParseUnicodeAsync>d__12), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParseValueAsync>d__8), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadFinishedAsync>d__36), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadFromFinishedAsync>d__5), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadStringValueAsync>d__37), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadCharsAsync>d__14)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadCharsAsync>d__14&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task<Boolean> EnsureCharsAsync(int relativePosition, bool append, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringReference), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReader), Member = "ReadInt32String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Nullable`1<System.Int32>))]
	[Calls(Type = typeof(JsonReader), Member = "ReadDecimalString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Nullable`1<System.Decimal>))]
	[Calls(Type = typeof(JsonReader), Member = "ReadDoubleString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Nullable`1<System.Double>))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[NullableContext(2)]
	private object FinishReadQuotedNumber(ReadType readType) { }

	[CalledBy(Type = typeof(<ReadStringValueAsync>d__37), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JsonReader), Member = "ReadDateTimeOffsetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Nullable`1<System.DateTimeOffset>))]
	[Calls(Type = typeof(JsonReader), Member = "ReadDateTimeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Nullable`1<System.DateTime>))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	[NullableContext(2)]
	private object FinishReadQuotedStringValue(ReadType readType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuffer), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void FinishReadStringIntoBuffer(int charPos, int initialPosition, int lastWritePosition) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[NullableContext(2)]
	public IArrayPool<Char> get_ArrayPool() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override int get_LineNumber() { }

	[CallerCount(Count = 0)]
	public override int get_LinePosition() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[NullableContext(2)]
	public JsonNameTable get_PropertyNameTable() { }

	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsBytes", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsBoolean", ReturnType = typeof(System.Nullable`1<System.Boolean>))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadNumberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(JsonTextReader), Member = "EnsureChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonTextReader), Member = "ParseNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReader), Member = "CreateUnexpectedEndException", ReturnType = typeof(JsonReaderException))]
	[Calls(Type = typeof(JsonTextReader), Member = "CreateUnexpectedCharacterException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(JsonReaderException))]
	[CallsUnknownMethods(Count = 10)]
	private void HandleNull() { }

	[AsyncStateMachine(typeof(<HandleNullAsync>d__35))]
	[CalledBy(Type = typeof(<DoReadAsBooleanAsync>d__40), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<DoReadAsBytesAsync>d__42), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadNumberValueAsync>d__38), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadStringValueAsync>d__37), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<HandleNullAsync>d__35)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<HandleNullAsync>d__35&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task HandleNullAsync(CancellationToken cancellationToken) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public override bool HasLineInfo() { }

	[CalledBy(Type = typeof(<MatchValueWithTrailingSeparatorAsync>d__20), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonTextReader), Member = "EnsureChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private bool IsSeparator(char c) { }

	[AsyncStateMachine(typeof(<MatchAndSetAsync>d__21))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseTrueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseFalseAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseNullAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseUndefinedAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<MatchAndSetAsync>d__21)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<MatchAndSetAsync>d__21&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private Task MatchAndSetAsync(string value, JsonToken newToken, object tokenValue, CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(<MatchValueAsync>d__19), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(JsonReader), Member = "CreateUnexpectedEndException", ReturnType = typeof(JsonReaderException))]
	[CallsUnknownMethods(Count = 4)]
	private bool MatchValue(bool enoughChars, string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextReader), Member = "EnsureChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(JsonReader), Member = "CreateUnexpectedEndException", ReturnType = typeof(JsonReaderException))]
	[CallsUnknownMethods(Count = 4)]
	private bool MatchValue(string value) { }

	[AsyncStateMachine(typeof(<MatchValueAsync>d__19))]
	[CalledBy(Type = typeof(<MatchValueWithTrailingSeparatorAsync>d__20), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<MatchValueAsync>d__19)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<MatchValueAsync>d__19&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private Task<Boolean> MatchValueAsync(string value, CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseFalse", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsBoolean", ReturnType = typeof(System.Nullable`1<System.Boolean>))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseValue", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseConstructor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseTrue", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseNull", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseUndefined", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseNumberNegativeInfinity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseNumberPositiveInfinity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseNumberNaN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(JsonReader), Member = "CreateUnexpectedEndException", ReturnType = typeof(JsonReaderException))]
	[Calls(Type = typeof(JsonTextReader), Member = "EnsureChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private bool MatchValueWithTrailingSeparator(string value) { }

	[AsyncStateMachine(typeof(<MatchValueWithTrailingSeparatorAsync>d__20))]
	[CalledBy(Type = typeof(<DoReadAsBooleanAsync>d__40), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<MatchAndSetAsync>d__21), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParseConstructorAsync>d__25), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParseNumberNaNAsync>d__26), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParseNumberNegativeInfinityAsync>d__28), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParseNumberPositiveInfinityAsync>d__27), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadStringValueAsync>d__37), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<MatchValueWithTrailingSeparatorAsync>d__20)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<MatchValueWithTrailingSeparatorAsync>d__20&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private Task<Boolean> MatchValueWithTrailingSeparatorAsync(string value, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	private void OnNewLine(int pos) { }

	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsBytes", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsBoolean", ReturnType = typeof(System.Nullable`1<System.Boolean>))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadNumberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadFinished", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParsePostValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseObject", ReturnType = typeof(bool))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[Calls(Type = typeof(JsonTextReader), Member = "EndComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextReader), Member = "EnsureChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonTextReader), Member = "ReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 15)]
	private void ParseComment(bool setToken) { }

	[AsyncStateMachine(typeof(<ParseCommentAsync>d__16))]
	[CalledBy(Type = typeof(<DoReadAsBytesAsync>d__42), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParseObjectAsync>d__15), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParsePostValueAsync>d__4), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParseValueAsync>d__8), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadFinishedAsync>d__36), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadFromFinishedAsync>d__5), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadStringValueAsync>d__37), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseCommentAsync>d__16)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseCommentAsync>d__16&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task ParseCommentAsync(bool setToken, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextReader), Member = "MatchValueWithTrailingSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonTextReader), Member = "EatWhitespace", ReturnType = typeof(void))]
	[Calls(Type = typeof(char), Member = "IsLetterOrDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonTextReader), Member = "ReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonTextReader), Member = "ProcessCarriageReturn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringReference), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 23)]
	private void ParseConstructor() { }

	[AsyncStateMachine(typeof(<ParseConstructorAsync>d__25))]
	[CalledBy(Type = typeof(<ParseValueAsync>d__8), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseConstructorAsync>d__25)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseConstructorAsync>d__25&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task ParseConstructorAsync(CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextReader), Member = "MatchValueWithTrailingSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CallsUnknownMethods(Count = 3)]
	private void ParseFalse() { }

	[CalledBy(Type = typeof(<ParseValueAsync>d__8), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonTextReader), Member = "MatchAndSetAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonToken), typeof(object), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	private Task ParseFalseAsync(CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(JsonTextReader), Member = "HandleNull", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonTextReader), Member = "MatchValueWithTrailingSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CallsUnknownMethods(Count = 3)]
	private void ParseNull() { }

	[CalledBy(Type = typeof(<HandleNullAsync>d__35), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParseValueAsync>d__8), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JsonTextReader), Member = "MatchAndSetAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonToken), typeof(object), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	private Task ParseNullAsync(CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsBoolean", ReturnType = typeof(System.Nullable`1<System.Boolean>))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadNumberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(JsonTextReader), Member = "ShiftBufferIfNeeded", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextReader), Member = "ReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(JsonTextReader), Member = "ParseReadNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType), typeof(char), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	private void ParseNumber(ReadType readType) { }

	[AsyncStateMachine(typeof(<ParseNumberAsync>d__29))]
	[CalledBy(Type = typeof(<ParseValueAsync>d__8), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadStringValueAsync>d__37), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseNumberAsync>d__29)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseNumberAsync>d__29&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task ParseNumberAsync(ReadType readType, CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadNumberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseValue", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(JsonTextReader), Member = "MatchValueWithTrailingSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CallsUnknownMethods(Count = 6)]
	private object ParseNumberNaN(ReadType readType) { }

	[CalledBy(Type = typeof(<ParseNumberNaNAsync>d__26), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CallsUnknownMethods(Count = 6)]
	private object ParseNumberNaN(ReadType readType, bool matched) { }

	[AsyncStateMachine(typeof(<ParseNumberNaNAsync>d__26))]
	[CalledBy(Type = typeof(<ParseValueAsync>d__8), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadNumberValueAsync>d__38), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadStringValueAsync>d__37), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseNumberNaNAsync>d__26)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseNumberNaNAsync>d__26&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task<Object> ParseNumberNaNAsync(ReadType readType, CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(<ParseNumberNegativeInfinityAsync>d__28), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CallsUnknownMethods(Count = 6)]
	private object ParseNumberNegativeInfinity(ReadType readType, bool matched) { }

	[CalledBy(Type = typeof(<ReadStringValueAsync>d__37), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadNumberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(JsonTextReader), Member = "MatchValueWithTrailingSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CallsUnknownMethods(Count = 6)]
	private object ParseNumberNegativeInfinity(ReadType readType) { }

	[AsyncStateMachine(typeof(<ParseNumberNegativeInfinityAsync>d__28))]
	[CalledBy(Type = typeof(<ParseValueAsync>d__8), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseNumberNegativeInfinityAsync>d__28)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseNumberNegativeInfinityAsync>d__28&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task<Object> ParseNumberNegativeInfinityAsync(ReadType readType, CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadNumberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JsonTextReader), Member = "MatchValueWithTrailingSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CallsUnknownMethods(Count = 6)]
	private object ParseNumberPositiveInfinity(ReadType readType) { }

	[CalledBy(Type = typeof(<ParseNumberPositiveInfinityAsync>d__27), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CallsUnknownMethods(Count = 6)]
	private object ParseNumberPositiveInfinity(ReadType readType, bool matched) { }

	[AsyncStateMachine(typeof(<ParseNumberPositiveInfinityAsync>d__27))]
	[CalledBy(Type = typeof(<ParseValueAsync>d__8), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadNumberValueAsync>d__38), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadStringValueAsync>d__37), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseNumberPositiveInfinityAsync>d__27)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseNumberPositiveInfinityAsync>d__27&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task<Object> ParseNumberPositiveInfinityAsync(ReadType readType, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonTextReader), Member = "ReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(JsonTextReader), Member = "EnsureChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextReader), Member = "ParseComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextReader), Member = "ParseProperty", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private bool ParseObject() { }

	[AsyncStateMachine(typeof(<ParseObjectAsync>d__15))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseObjectAsync>d__15)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseObjectAsync>d__15&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task<Boolean> ParseObjectAsync(CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsBytes", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsBoolean", ReturnType = typeof(System.Nullable`1<System.Boolean>))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadNumberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonTextReader), Member = "ParseComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextReader), Member = "ReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(JsonTextReader), Member = "EnsureChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonReader), Member = "SetStateBasedOnCurrent", ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private bool ParsePostValue(bool ignoreComments) { }

	[AsyncStateMachine(typeof(<ParsePostValueAsync>d__4))]
	[CalledBy(Type = typeof(<DoReadAsBooleanAsync>d__40), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<DoReadAsBytesAsync>d__42), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadNumberValueAsync>d__38), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadStringValueAsync>d__37), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParsePostValueAsync>d__4)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParsePostValueAsync>d__4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task<Boolean> ParsePostValueAsync(bool ignoreComments, CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseObject", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(char), Member = "IsLetterOrDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonTextReader), Member = "ShiftBufferIfNeeded", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextReader), Member = "ParseUnquotedProperty", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextReader), Member = "ReadStringIntoBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringReference), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonTextReader), Member = "EatWhitespace", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	private bool ParseProperty() { }

	[AsyncStateMachine(typeof(<ParsePropertyAsync>d__31))]
	[CalledBy(Type = typeof(<ParseObjectAsync>d__15), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParsePropertyAsync>d__31)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParsePropertyAsync>d__31&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task<Boolean> ParsePropertyAsync(CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(<ParseNumberAsync>d__29), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BoxedPrimitives), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxedPrimitives), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(Decimal), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(BoxedPrimitives), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(JsonTextReader), Member = "BigIntegerParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CultureInfo)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ConvertUtils), Member = "DecimalTryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(Decimal&)}, ReturnType = typeof(ParseResult))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(double), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Double&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(ConvertUtils), Member = "Int64TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(Int64&)}, ReturnType = typeof(ParseResult))]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringReference), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(BoxedPrimitives), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ConvertUtils), Member = "Int32TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(ParseResult))]
	[Calls(Type = typeof(char), Member = "IsDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonTextReader), Member = "ThrowReaderError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(JsonReaderException))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 82)]
	[ContainsUnimplementedInstructions]
	private void ParseReadNumber(ReadType readType, char firstChar, int initialPosition) { }

	[CalledBy(Type = typeof(<ParseStringAsync>d__18), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(ReadType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsInvalidInstructions]
	private void ParseReadString(char quote, ReadType readType) { }

	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsBytes", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsBoolean", ReturnType = typeof(System.Nullable`1<System.Boolean>))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadNumberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(JsonTextReader), Member = "ShiftBufferIfNeeded", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextReader), Member = "ReadStringIntoBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextReader), Member = "ParseReadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(ReadType)}, ReturnType = typeof(void))]
	private void ParseString(char quote, ReadType readType) { }

	[AsyncStateMachine(typeof(<ParseStringAsync>d__18))]
	[CalledBy(Type = typeof(<DoReadAsBytesAsync>d__42), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParseValueAsync>d__8), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadStringValueAsync>d__37), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseStringAsync>d__18)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseStringAsync>d__18&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task ParseStringAsync(char quote, ReadType readType, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextReader), Member = "MatchValueWithTrailingSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CallsUnknownMethods(Count = 3)]
	private void ParseTrue() { }

	[CalledBy(Type = typeof(<ParseValueAsync>d__8), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonTextReader), Member = "MatchAndSetAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonToken), typeof(object), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	private Task ParseTrueAsync(CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextReader), Member = "MatchValueWithTrailingSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CallsUnknownMethods(Count = 3)]
	private void ParseUndefined() { }

	[CalledBy(Type = typeof(<ParseValueAsync>d__8), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonTextReader), Member = "MatchAndSetAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonToken), typeof(object), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	private Task ParseUndefinedAsync(CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadStringIntoBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JsonTextReader), Member = "EnsureChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ConvertUtils), Member = "TryHexTextToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Convert), Member = "ToChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 8)]
	private char ParseUnicode() { }

	[AsyncStateMachine(typeof(<ParseUnicodeAsync>d__12))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Char>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseUnicodeAsync>d__12)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseUnicodeAsync>d__12&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Char>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Char>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task<Char> ParseUnicodeAsync(CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseProperty", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(char), Member = "IsLetterOrDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonTextReader), Member = "ReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private void ParseUnquotedProperty() { }

	[AsyncStateMachine(typeof(<ParseUnquotedPropertyAsync>d__33))]
	[CalledBy(Type = typeof(<ParsePropertyAsync>d__31), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseUnquotedPropertyAsync>d__33)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseUnquotedPropertyAsync>d__33&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task ParseUnquotedPropertyAsync(CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonTextReader), Member = "MatchValueWithTrailingSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonTextReader), Member = "ParseNumberNaN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsInvalidInstructions]
	private bool ParseValue() { }

	[AsyncStateMachine(typeof(<ParseValueAsync>d__8))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseValueAsync>d__8)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseValueAsync>d__8&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task<Boolean> ParseValueAsync(CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(<ReadDataAsync>d__7), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "EnsureChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsBytes", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsBoolean", ReturnType = typeof(System.Nullable`1<System.Boolean>))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadNumberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BufferUtils), Member = "RentBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(int)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(BufferUtils), Member = "ReturnBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(Char[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	private void PrepareBufferForReadData(bool append, int charsRequired) { }

	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseConstructor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonTextReader), Member = "EnsureChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private void ProcessCarriageReturn(bool append) { }

	[AsyncStateMachine(typeof(<ProcessCarriageReturnAsync>d__11))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ProcessCarriageReturnAsync>d__11)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ProcessCarriageReturnAsync>d__11&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task ProcessCarriageReturnAsync(Task<Boolean> task) { }

	[CalledBy(Type = typeof(<DoReadAsBytesAsync>d__42), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<EatWhitespaceAsync>d__17), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParseCommentAsync>d__16), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParseConstructorAsync>d__25), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParseObjectAsync>d__15), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParsePostValueAsync>d__4), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParseValueAsync>d__8), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadStringValueAsync>d__37), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadCharsAsync>d__14)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadCharsAsync>d__14&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[Calls(Type = typeof(AsyncUtils), Member = "IsCompletedSuccessfully", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ProcessCarriageReturnAsync>d__11)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ProcessCarriageReturnAsync>d__11&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[Calls(Type = typeof(Task`1), Member = "get_Result", ReturnType = "TResult")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private Task ProcessCarriageReturnAsync(bool append, CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(<DoReadAsBytesAsync>d__42), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<EatWhitespaceAsync>d__17), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParseCommentAsync>d__16), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParseConstructorAsync>d__25), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParseObjectAsync>d__15), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParsePostValueAsync>d__4), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParseValueAsync>d__8), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadStringValueAsync>d__37), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	private void ProcessLineFeed() { }

	[CalledBy(Type = typeof(<DoReadAsBytesAsync>d__42), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadStringValueAsync>d__37), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsBoolean", ReturnType = typeof(System.Nullable`1<System.Boolean>))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadNumberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(JsonReader), Member = "SetStateBasedOnCurrent", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextReader), Member = "CreateUnexpectedCharacterException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(JsonReaderException))]
	[CallsUnknownMethods(Count = 3)]
	private void ProcessValueComma() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BufferUtils), Member = "RentBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(int)}, ReturnType = typeof(Char[]))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	public virtual bool Read() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BoxedPrimitives), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonTextReader), Member = "EatWhitespace", ReturnType = typeof(void))]
	[Calls(Type = typeof(Convert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(BigInteger), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(long)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonTextReader), Member = "ParseNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReader), Member = "ReadBooleanString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Nullable`1<System.Boolean>))]
	[Calls(Type = typeof(StringReference), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonTextReader), Member = "ParseString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(ReadType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextReader), Member = "MatchValueWithTrailingSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonTextReader), Member = "HandleNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextReader), Member = "PrepareBufferForReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextReader), Member = "ParseComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextReader), Member = "ProcessValueComma", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextReader), Member = "ReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonTextReader), Member = "ParsePostValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BufferUtils), Member = "RentBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(int)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[Calls(Type = typeof(JsonTextReader), Member = "CreateUnexpectedCharacterException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(JsonReaderException))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 27)]
	[ContainsUnimplementedInstructions]
	public virtual Nullable<Boolean> ReadAsBoolean() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TStateMachine&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "get_Task", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[Calls(Type = typeof(AsyncUtils), Member = "CancelIfRequestedAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[Calls(Type = typeof(Task), Member = "FromResult", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public virtual Task<Nullable`1<Boolean>> ReadAsBooleanAsync(CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextReader), Member = "PrepareBufferForReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(JsonTextReader), Member = "EatWhitespace", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReader), Member = "ReaderReadAndAssert", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReader), Member = "ReadArrayIntoByteArray", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(JsonTextReader), Member = "HandleNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextReader), Member = "CreateUnexpectedCharacterException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(JsonReaderException))]
	[Calls(Type = typeof(JsonTextReader), Member = "ReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonTextReader), Member = "ParseComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReader), Member = "SetStateBasedOnCurrent", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReader), Member = "ReadIntoWrappedTypeObject", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextReader), Member = "ParsePostValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BufferUtils), Member = "RentBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(int)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(JsonTextReader), Member = "ParseString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(ReadType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 33)]
	[NullableContext(2)]
	public virtual Byte[] ReadAsBytes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoReadAsBytesAsync>d__42)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoReadAsBytesAsync>d__42&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[Calls(Type = typeof(AsyncUtils), Member = "CancelIfRequestedAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[Calls(Type = typeof(Task), Member = "FromResult", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public virtual Task<Byte[]> ReadAsBytesAsync(CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextReader), Member = "ReadStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 2)]
	public virtual Nullable<DateTime> ReadAsDateTime() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.DateTime>>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoReadAsDateTimeAsync>d__45)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoReadAsDateTimeAsync>d__45&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.DateTime>>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Nullable`1<System.DateTime>>))]
	[Calls(Type = typeof(AsyncUtils), Member = "CancelIfRequestedAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.DateTime>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Nullable`1<System.DateTime>>))]
	[Calls(Type = typeof(Task), Member = "FromResult", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.DateTime>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.DateTime>)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Nullable`1<System.DateTime>>))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public virtual Task<Nullable`1<DateTime>> ReadAsDateTimeAsync(CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextReader), Member = "ReadStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 2)]
	public virtual Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.DateTimeOffset>>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoReadAsDateTimeOffsetAsync>d__47)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoReadAsDateTimeOffsetAsync>d__47&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.DateTimeOffset>>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Nullable`1<System.DateTimeOffset>>))]
	[Calls(Type = typeof(AsyncUtils), Member = "CancelIfRequestedAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.DateTimeOffset>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Nullable`1<System.DateTimeOffset>>))]
	[Calls(Type = typeof(Task), Member = "FromResult", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.DateTimeOffset>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.DateTimeOffset>)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Nullable`1<System.DateTimeOffset>>))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public virtual Task<Nullable`1<DateTimeOffset>> ReadAsDateTimeOffsetAsync(CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextReader), Member = "ReadNumberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 2)]
	public virtual Nullable<Decimal> ReadAsDecimal() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.Decimal>>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoReadAsDecimalAsync>d__49)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoReadAsDecimalAsync>d__49&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.Decimal>>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Nullable`1<System.Decimal>>))]
	[Calls(Type = typeof(AsyncUtils), Member = "CancelIfRequestedAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Decimal>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Nullable`1<System.Decimal>>))]
	[Calls(Type = typeof(Task), Member = "FromResult", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Decimal>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Decimal>)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Nullable`1<System.Decimal>>))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public virtual Task<Nullable`1<Decimal>> ReadAsDecimalAsync(CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextReader), Member = "ReadNumberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 2)]
	public virtual Nullable<Double> ReadAsDouble() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.Double>>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoReadAsDoubleAsync>d__51)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoReadAsDoubleAsync>d__51&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.Double>>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Nullable`1<System.Double>>))]
	[Calls(Type = typeof(Task), Member = "FromResult", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Double>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Double>)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Nullable`1<System.Double>>))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public virtual Task<Nullable`1<Double>> ReadAsDoubleAsync(CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextReader), Member = "ReadNumberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 2)]
	public virtual Nullable<Int32> ReadAsInt32() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.Int32>>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoReadAsInt32Async>d__53)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoReadAsInt32Async>d__53&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Nullable`1<System.Int32>>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Nullable`1<System.Int32>>))]
	[Calls(Type = typeof(AsyncUtils), Member = "CancelIfRequestedAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Int32>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Nullable`1<System.Int32>>))]
	[Calls(Type = typeof(Task), Member = "FromResult", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Int32>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Nullable`1<System.Int32>>))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public virtual Task<Nullable`1<Int32>> ReadAsInt32Async(CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextReader), Member = "ReadStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	[NullableContext(2)]
	public virtual string ReadAsString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoReadAsStringAsync>d__55)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DoReadAsStringAsync>d__55&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[Calls(Type = typeof(AsyncUtils), Member = "CancelIfRequestedAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[Calls(Type = typeof(Task), Member = "FromResult", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public virtual Task<String> ReadAsStringAsync(CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextReader), Member = "DoReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[Calls(Type = typeof(AsyncUtils), Member = "CancelIfRequestedAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[Calls(Type = typeof(AsyncUtils), Member = "ToAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual Task<Boolean> ReadAsync(CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextReader), Member = "PrepareBufferForReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool ReadChars(int relativePosition, bool append) { }

	[AsyncStateMachine(typeof(<ReadCharsAsync>d__14))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadCharsAsync>d__14)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadCharsAsync>d__14&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task<Boolean> ReadCharsAsync(int relativePosition, bool append, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	private int ReadData(bool append) { }

	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsBytes", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseConstructor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "EatWhitespace", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseObject", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseUnquotedProperty", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadStringIntoBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadNullChar", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadNumberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsBoolean", ReturnType = typeof(System.Nullable`1<System.Boolean>))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParsePostValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(JsonTextReader), Member = "PrepareBufferForReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private int ReadData(bool append, int charsRequired) { }

	[CalledBy(Type = typeof(<EatWhitespaceAsync>d__17), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParseCommentAsync>d__16), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParseConstructorAsync>d__25), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParseObjectAsync>d__15), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParsePostValueAsync>d__4), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParseUnquotedPropertyAsync>d__33), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParseValueAsync>d__8), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadNullCharAsync>d__34), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadNumberIntoBufferAsync>d__32), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadDataAsync>d__7)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadDataAsync>d__7&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task<Int32> ReadDataAsync(bool append, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<ReadDataAsync>d__7))]
	[CalledBy(Type = typeof(<ReadCharsAsync>d__14), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadDataAsync>d__7)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadDataAsync>d__7&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task<Int32> ReadDataAsync(bool append, int charsRequired, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextReader), Member = "EnsureChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonTextReader), Member = "EatWhitespace", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextReader), Member = "ParseComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CallsUnknownMethods(Count = 9)]
	private void ReadFinished() { }

	[AsyncStateMachine(typeof(<ReadFinishedAsync>d__36))]
	[CalledBy(Type = typeof(<DoReadAsBytesAsync>d__42), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadStringValueAsync>d__37), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadFinishedAsync>d__36)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadFinishedAsync>d__36&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task ReadFinishedAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<ReadFromFinishedAsync>d__5))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadFromFinishedAsync>d__5)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadFromFinishedAsync>d__5&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task<Boolean> ReadFromFinishedAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<ReadIntoWrappedTypeObjectAsync>d__43))]
	[CalledBy(Type = typeof(<DoReadAsBytesAsync>d__42), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadIntoWrappedTypeObjectAsync>d__43)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadIntoWrappedTypeObjectAsync>d__43&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task ReadIntoWrappedTypeObjectAsync(CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextReader), Member = "ReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int)}, ReturnType = typeof(int))]
	private bool ReadNullChar() { }

	[AsyncStateMachine(typeof(<ReadNullCharAsync>d__34))]
	[CalledBy(Type = typeof(<DoReadAsBooleanAsync>d__40), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<DoReadAsBytesAsync>d__42), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadNumberValueAsync>d__38), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ReadStringValueAsync>d__37), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadNullCharAsync>d__34)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadNullCharAsync>d__34&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Boolean>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task<Boolean> ReadNullCharAsync(CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(<ReadNumberIntoBufferAsync>d__32), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	private bool ReadNumberCharIntoBuffer(char currentChar, int charPos) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	private void ReadNumberIntoBuffer() { }

	[AsyncStateMachine(typeof(<ReadNumberIntoBufferAsync>d__32))]
	[CalledBy(Type = typeof(<ParseNumberAsync>d__29), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadNumberIntoBufferAsync>d__32)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadNumberIntoBufferAsync>d__32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task ReadNumberIntoBufferAsync(CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsInt32", ReturnType = typeof(System.Nullable`1<System.Int32>))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsDecimal", ReturnType = typeof(System.Nullable`1<System.Decimal>))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsDouble", ReturnType = typeof(System.Nullable`1<System.Double>))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(JsonTextReader), Member = "ParseNumberPositiveInfinity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(JsonTextReader), Member = "EatWhitespace", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextReader), Member = "ParseNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextReader), Member = "ParseNumberNegativeInfinity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(JsonReader), Member = "ReadDoubleString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Nullable`1<System.Double>))]
	[Calls(Type = typeof(JsonReader), Member = "ReadDecimalString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Nullable`1<System.Decimal>))]
	[Calls(Type = typeof(JsonReader), Member = "ReadInt32String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Nullable`1<System.Int32>))]
	[Calls(Type = typeof(StringReference), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonTextReader), Member = "ParseString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(ReadType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextReader), Member = "HandleNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextReader), Member = "CreateUnexpectedCharacterException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(JsonReaderException))]
	[Calls(Type = typeof(JsonTextReader), Member = "PrepareBufferForReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextReader), Member = "ParseComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextReader), Member = "ProcessValueComma", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextReader), Member = "ReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(JsonTextReader), Member = "ParseNumberNaN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonTextReader), Member = "ParsePostValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BufferUtils), Member = "RentBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(int)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 26)]
	[NullableContext(2)]
	private object ReadNumberValue(ReadType readType) { }

	[AsyncStateMachine(typeof(<ReadNumberValueAsync>d__38))]
	[CalledBy(Type = typeof(<DoReadAsDecimalAsync>d__49), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<DoReadAsDoubleAsync>d__51), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<DoReadAsInt32Async>d__53), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadNumberValueAsync>d__38)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadNumberValueAsync>d__38&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task<Object> ReadNumberValueAsync(ReadType readType, CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(ReadType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseProperty", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(JsonTextReader), Member = "ReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuffer), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextReader), Member = "EnsureBufferNotEmpty", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringUtils), Member = "IsHighSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringUtils), Member = "IsLowSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonTextReader), Member = "ParseUnicode", ReturnType = typeof(char))]
	[Calls(Type = typeof(JsonTextReader), Member = "EnsureChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuffer), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(char)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 22)]
	private void ReadStringIntoBuffer(char quote) { }

	[AsyncStateMachine(typeof(<ReadStringIntoBufferAsync>d__9))]
	[CalledBy(Type = typeof(<ParsePropertyAsync>d__31), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParseStringAsync>d__18), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadStringIntoBufferAsync>d__9)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadStringIntoBufferAsync>d__9&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task ReadStringIntoBufferAsync(char quote, CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsDateTime", ReturnType = typeof(System.Nullable`1<System.DateTime>))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsDateTimeOffset", ReturnType = typeof(System.Nullable`1<System.DateTimeOffset>))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(JsonTextReader), Member = "PrepareBufferForReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(JsonTextReader), Member = "EatWhitespace", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextReader), Member = "ParseNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextReader), Member = "ParseNumberNegativeInfinity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(JsonTextReader), Member = "FinishReadQuotedStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(JsonTextReader), Member = "ParseString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(ReadType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextReader), Member = "ParseNumberNaN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(JsonTextReader), Member = "MatchValueWithTrailingSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[Calls(Type = typeof(JsonTextReader), Member = "ReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(JsonTextReader), Member = "ParseNumberPositiveInfinity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(JsonTextReader), Member = "ParseComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextReader), Member = "ProcessValueComma", ReturnType = typeof(void))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonTextReader), Member = "ParsePostValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BufferUtils), Member = "RentBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(int)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(JsonTextReader), Member = "HandleNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextReader), Member = "CreateUnexpectedCharacterException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(JsonReaderException))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 32)]
	[NullableContext(2)]
	private object ReadStringValue(ReadType readType) { }

	[AsyncStateMachine(typeof(<ReadStringValueAsync>d__37))]
	[CalledBy(Type = typeof(<DoReadAsDateTimeAsync>d__45), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<DoReadAsDateTimeOffsetAsync>d__47), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<DoReadAsStringAsync>d__55), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadStringValueAsync>d__37)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadStringValueAsync>d__37&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task<Object> ReadStringValueAsync(ReadType readType, CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(<ParseUnquotedPropertyAsync>d__33), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(char), Member = "IsLetterOrDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private bool ReadUnquotedPropertyReportIfDone(char currentChar, int initialPosition) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[NullableContext(2)]
	public void set_ArrayPool(IArrayPool<Char> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[NullableContext(2)]
	public void set_PropertyNameTable(JsonNameTable value) { }

	[CalledBy(Type = typeof(<ProcessCarriageReturnAsync>d__11), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void SetNewLine(bool hasNextChar) { }

	[CalledBy(Type = typeof(<ParseNumberAsync>d__29), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParsePropertyAsync>d__31), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParseStringAsync>d__18), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(ReadType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseProperty", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void ShiftBufferIfNeeded() { }

	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseReadNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType), typeof(char), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonReaderException))]
	private JsonReaderException ThrowReaderError(string message, Exception ex = null) { }

	[CalledBy(Type = typeof(<ParsePropertyAsync>d__31), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(char), Member = "IsLetterOrDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	private bool ValidIdentifierChar(char value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuffer), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuffer), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(char)}, ReturnType = typeof(void))]
	private void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition) { }

}

