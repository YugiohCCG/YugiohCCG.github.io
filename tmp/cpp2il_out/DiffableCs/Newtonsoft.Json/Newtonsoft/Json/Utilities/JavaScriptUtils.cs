namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
internal static class JavaScriptUtils
{
	[CompilerGenerated]
	private struct <WriteCharAsync>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Task task; //Field offset: 0x20
		[Nullable(0)]
		public TextWriter writer; //Field offset: 0x28
		public char c; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(char), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 5)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Char[] writeBuffer; //Field offset: 0x20
		public int lastWritePosition; //Field offset: 0x28
		[Nullable(0)]
		public JsonTextWriter client; //Field offset: 0x30
		[Nullable(0)]
		public string s; //Field offset: 0x38
		[Nullable(0)]
		public TextWriter writer; //Field offset: 0x40
		public CancellationToken cancellationToken; //Field offset: 0x48
		[Nullable(0)]
		public Boolean[] charEscapeFlags; //Field offset: 0x50
		public StringEscapeHandling stringEscapeHandling; //Field offset: 0x58
		private bool <isEscapedUnicodeText>5__2; //Field offset: 0x5C
		[Nullable(0)]
		private string <escapedValue>5__3; //Field offset: 0x60
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x68
		private int <i>5__4; //Field offset: 0x78

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonTextWriter), Member = "EnsureWriteBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Char[]))]
		[Calls(Type = typeof(string), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(Char[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 10)]
		[ContainsInvalidInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteEscapedJavaScriptStringWithDelimitersAsync>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Task task; //Field offset: 0x20
		[Nullable(0)]
		public string s; //Field offset: 0x28
		[Nullable(0)]
		public TextWriter writer; //Field offset: 0x30
		[Nullable(0)]
		public Boolean[] charEscapeFlags; //Field offset: 0x38
		public StringEscapeHandling stringEscapeHandling; //Field offset: 0x40
		[Nullable(0)]
		public JsonTextWriter client; //Field offset: 0x48
		[Nullable(0)]
		public Char[] writeBuffer; //Field offset: 0x50
		public CancellationToken cancellationToken; //Field offset: 0x58
		public char delimiter; //Field offset: 0x60
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x68

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(JavaScriptUtils), Member = "WriteEscapedJavaScriptStringWithoutDelimitersAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(string), typeof(Boolean[]), typeof(StringEscapeHandling), typeof(JsonTextWriter), typeof(Char[]), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 8)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal static readonly Boolean[] SingleQuoteCharEscapeFlags; //Field offset: 0x0
	private const int UnicodeTextLength = 6; //Field offset: 0x0
	private const string EscapedUnicodeText = "!"; //Field offset: 0x0
	internal static readonly Boolean[] DoubleQuoteCharEscapeFlags; //Field offset: 0x8
	internal static readonly Boolean[] HtmlCharEscapeFlags; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Union", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 36)]
	private static JavaScriptUtils() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 2)]
	private static int FirstCharToEscape(string s, Boolean[] charEscapeFlags, StringEscapeHandling stringEscapeHandling) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "UpdateCharEscapeFlags", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public static Boolean[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, char quoteChar) { }

	[CalledBy(Type = typeof(JsonProperty), Member = "set_PropertyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 2)]
	public static bool ShouldEscapeJavaScriptString(string s, Boolean[] charEscapeFlags) { }

	[CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(char)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(char), typeof(StringEscapeHandling)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(StringUtils), Member = "CreateStringWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringWriter))]
	[Calls(Type = typeof(JavaScriptUtils), Member = "WriteEscapedJavaScriptString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(string), typeof(char), typeof(bool), typeof(Boolean[]), typeof(StringEscapeHandling), typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(Char[]&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static string ToEscapedJavaScriptString(string value, char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling) { }

	[CalledBy(Type = typeof(JavaScriptUtils), Member = "TryGetDateFromConstructorJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(DateTime&), typeof(String&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	private static bool TryGetDateConstructorValue(JsonReader reader, out Nullable<Int64>& integer, out string errorMessage) { }

	[CalledBy(Type = typeof(JsonWriter), Member = "WriteToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonWriter), Member = "WriteConstructorDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JavaScriptDateTimeConverter), Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(JavaScriptUtils), Member = "TryGetDateConstructorValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Nullable`1<Int64>&), typeof(String&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(DateTimeUtils), Member = "ConvertJavaScriptTicksToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 7)]
	public static bool TryGetDateFromConstructorJson(JsonReader reader, out DateTime dateTime, out string errorMessage) { }

	[AsyncStateMachine(typeof(<WriteCharAsync>d__14))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "DoWritePropertyNameAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteCharAsync>d__14)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteCharAsync>d__14&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static Task WriteCharAsync(Task task, TextWriter writer, char c, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__16))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__16)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__16&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private static Task WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync(TextWriter writer, string s, int lastWritePosition, Boolean[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, Char[] writeBuffer, CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(JsonPosition), Member = "WriteTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(StringWriter&), typeof(Char[]&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteEscapedString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JavaScriptUtils), Member = "ToEscapedJavaScriptString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(char), typeof(bool), typeof(StringEscapeHandling)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsInvalidInstructions]
	[NullableContext(2)]
	public static void WriteEscapedJavaScriptString(TextWriter writer, string s, char delimiter, bool appendDelimiters, Boolean[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, IArrayPool<Char> bufferPool, ref Char[] writeBuffer) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteEscapedStringAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JavaScriptUtils), Member = "WriteEscapedJavaScriptStringWithoutDelimitersAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(string), typeof(Boolean[]), typeof(StringEscapeHandling), typeof(JsonTextWriter), typeof(Char[]), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(JavaScriptUtils), Member = "WriteEscapedJavaScriptStringWithDelimitersAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(string), typeof(char), typeof(Boolean[]), typeof(StringEscapeHandling), typeof(JsonTextWriter), typeof(Char[]), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	public static Task WriteEscapedJavaScriptStringAsync(TextWriter writer, string s, char delimiter, bool appendDelimiters, Boolean[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, Char[] writeBuffer, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(JavaScriptUtils), Member = "WriteEscapedJavaScriptStringAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(string), typeof(char), typeof(bool), typeof(Boolean[]), typeof(StringEscapeHandling), typeof(JsonTextWriter), typeof(Char[]), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(char), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(Task), Member = "get_Status", ReturnType = typeof(TaskStatus))]
	[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JavaScriptUtils), Member = "WriteEscapedJavaScriptStringWithoutDelimitersAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(string), typeof(Boolean[]), typeof(StringEscapeHandling), typeof(JsonTextWriter), typeof(Char[]), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteCharAsync>d__14)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteCharAsync>d__14&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteEscapedJavaScriptStringWithDelimitersAsync>d__13)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteEscapedJavaScriptStringWithDelimitersAsync>d__13&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	private static Task WriteEscapedJavaScriptStringWithDelimitersAsync(TextWriter writer, string s, char delimiter, Boolean[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, Char[] writeBuffer, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<WriteEscapedJavaScriptStringWithDelimitersAsync>d__13))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteEscapedJavaScriptStringWithDelimitersAsync>d__13)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteEscapedJavaScriptStringWithDelimitersAsync>d__13&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private static Task WriteEscapedJavaScriptStringWithDelimitersAsync(Task task, TextWriter writer, string s, char delimiter, Boolean[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, Char[] writeBuffer, CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(<WriteEscapedJavaScriptStringWithDelimitersAsync>d__13), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JavaScriptUtils), Member = "WriteEscapedJavaScriptStringAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(string), typeof(char), typeof(bool), typeof(Boolean[]), typeof(StringEscapeHandling), typeof(JsonTextWriter), typeof(Char[]), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JavaScriptUtils), Member = "WriteEscapedJavaScriptStringWithDelimitersAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(string), typeof(char), typeof(Boolean[]), typeof(StringEscapeHandling), typeof(JsonTextWriter), typeof(Char[]), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__16)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__16&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(string), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private static Task WriteEscapedJavaScriptStringWithoutDelimitersAsync(TextWriter writer, string s, Boolean[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, Char[] writeBuffer, CancellationToken cancellationToken) { }

}

