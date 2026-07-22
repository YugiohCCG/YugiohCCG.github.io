namespace Newtonsoft.Json.Utilities;

[Extension]
[Nullable(0)]
[NullableContext(1)]
internal static class AsyncUtils
{
	[CompilerGenerated]
	private sealed class <>c
	{
		[Nullable(0)]
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(0)]
		public static Action <>9__5_0; //Field offset: 0x8

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
		internal void <FromCanceled>b__5_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__6
	{
		[Nullable(0)]
		public static readonly <>c__6<T> <>9; //Field offset: 0x0
		[Nullable(0)]
		public static Func<T> <>9__6_0; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		[DeduplicatedMethod]
		private static <>c__6`1() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__6`1() { }

		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		[NullableContext(0)]
		internal T <FromCanceled>b__6_0() { }

	}

	public static readonly Task<Boolean> False; //Field offset: 0x0
	public static readonly Task<Boolean> True; //Field offset: 0x8
	internal static readonly Task CompletedTask; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "FromResult", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[Calls(Type = typeof(Task), Member = "Delay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Task))]
	[CallsUnknownMethods(Count = 3)]
	private static AsyncUtils() { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "FlushAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "DoFlushAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Extension]
	[NullableContext(2)]
	public static Task CancelIfRequestedAsync(CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(JsonReader), Member = "ReadAsBooleanAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Nullable`1<System.Boolean>>))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsBooleanAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Nullable`1<System.Boolean>>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[NullableContext(2)]
	public static Task<T> CancelIfRequestedAsync(CancellationToken cancellationToken) { }

	[CallerCount(Count = 71)]
	[Calls(Type = typeof(Task), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(CancellationToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Task FromCanceled(CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(AsyncUtils), Member = "CancelIfRequestedAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Task`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<TResult>", typeof(CancellationToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	[Extension]
	public static Task<T> FromCanceled(CancellationToken cancellationToken) { }

	[CallerCount(Count = 24)]
	[Calls(Type = typeof(Task), Member = "get_Status", ReturnType = typeof(TaskStatus))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static bool IsCompletedSuccessfully(Task task) { }

	[CalledBy(Type = "Newtonsoft.Json.JsonTextReader+<ReadDataAsync>d__7", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Task<Int32> ReadAsync(TextReader reader, Char[] buffer, int index, int count, CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(JsonReader), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallerCount(Count = 2)]
	[Extension]
	internal static Task<Boolean> ToAsync(bool value) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteIntegerValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JavaScriptUtils), Member = "WriteEscapedJavaScriptStringWithDelimitersAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(string), typeof(char), typeof(Boolean[]), typeof(StringEscapeHandling), typeof(JsonTextWriter), typeof(Char[]), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.JavaScriptUtils+<WriteCharAsync>d__14", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "DoWriteStartObjectAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteStartObjectAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "DoWriteStartArrayAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteStartArrayAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "DoWritePropertyNameAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "DoWriteIndentSpaceAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteDigitsAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "DoWriteEndAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteEndAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "DoWriteValueDelimiterAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueDelimiterAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter+<DoWriteValueAsync>d__99", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter+<DoWriteStartObjectAsync>d__38", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter+<DoWriteStartArrayAsync>d__35", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteIndentSpaceAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Task WriteAsync(TextWriter writer, char value, CancellationToken cancellationToken) { }

	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Task WriteAsync(TextWriter writer, string value, CancellationToken cancellationToken) { }

	[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter+<DoWriteValueAsync>d__60", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter+<DoWriteValueAsync>d__64", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter+<WriteIndentAsync>d__13", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteIndentAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "DoWriteIndentAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteDigitsAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteIntegerValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(Base64Encoder), Member = "WriteCharsAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(Base64Encoder), Member = "FlushAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.JavaScriptUtils+<WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__16", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Task WriteAsync(TextWriter writer, Char[] value, int start, int count, CancellationToken cancellationToken) { }

}

