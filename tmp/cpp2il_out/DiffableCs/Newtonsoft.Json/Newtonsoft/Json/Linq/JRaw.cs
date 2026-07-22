namespace Newtonsoft.Json.Linq;

[Nullable(0)]
[NullableContext(1)]
public class JRaw : JValue
{
	[CompilerGenerated]
	private struct <CreateAsync>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<JRaw> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonReader reader; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		private StringWriter <sw>5__2; //Field offset: 0x30
		[Nullable(0)]
		private JsonTextWriter <jsonWriter>5__3; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(StringWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JsonWriter), Member = "WriteTokenSyncReadingAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JTokenType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 16)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JValue), typeof(JsonCloneSettings)}, ReturnType = typeof(void))]
	public JRaw(JRaw other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JValue), typeof(JsonCloneSettings)}, ReturnType = typeof(void))]
	internal JRaw(JRaw other, JsonCloneSettings settings) { }

	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateValueInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(JsonContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JTokenType)}, ReturnType = typeof(void))]
	[NullableContext(2)]
	public JRaw(object rawJson) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JValue), typeof(JsonCloneSettings)}, ReturnType = typeof(void))]
	internal virtual JToken CloneToken(JsonCloneSettings settings) { }

	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateJToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonContract)}, ReturnType = typeof(JToken))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JTokenType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static JRaw Create(JsonReader reader) { }

	[AsyncStateMachine(typeof(<CreateAsync>d__0))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CreateAsync>d__0)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CreateAsync>d__0&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static Task<JRaw> CreateAsync(JsonReader reader, CancellationToken cancellationToken = null) { }

}

