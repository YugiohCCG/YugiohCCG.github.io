namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
internal class Base64Encoder
{
	[CompilerGenerated]
	private struct <EncodeAsync>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Base64Encoder <>4__this; //Field offset: 0x20
		[Nullable(0)]
		public Byte[] buffer; //Field offset: 0x28
		public int index; //Field offset: 0x30
		public int count; //Field offset: 0x34
		public CancellationToken cancellationToken; //Field offset: 0x38
		private int <num4>5__2; //Field offset: 0x40
		private int <length>5__3; //Field offset: 0x44
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Base64Encoder), Member = "ValidateEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Convert), Member = "ToBase64CharArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Char[]), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Base64Encoder), Member = "WriteCharsAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Base64Encoder), Member = "StoreLeftOverBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 12)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int Base64LineSize = 76; //Field offset: 0x0
	private const int LineSizeInBytes = 57; //Field offset: 0x0
	private readonly Char[] _charsLine; //Field offset: 0x10
	private readonly TextWriter _writer; //Field offset: 0x18
	[Nullable(2)]
	private Byte[] _leftOverBytes; //Field offset: 0x20
	private int _leftOverBytesCount; //Field offset: 0x28

	[CalledBy(Type = typeof(JsonTextWriter), Member = "get_Base64Encoder", ReturnType = typeof(Base64Encoder))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Base64Encoder(TextWriter writer) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Base64Encoder), Member = "ValidateEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Convert), Member = "ToBase64CharArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Char[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Base64Encoder), Member = "StoreLeftOverBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void Encode(Byte[] buffer, int index, int count) { }

	[AsyncStateMachine(typeof(<EncodeAsync>d__13))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter+<WriteValueNonNullAsync>d__54", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<EncodeAsync>d__13)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<EncodeAsync>d__13&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public Task EncodeAsync(Byte[] buffer, int index, int count, CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ToBase64CharArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Char[]), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Flush() { }

	[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter+<WriteValueNonNullAsync>d__54", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Convert), Member = "ToBase64CharArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Char[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(Char[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncUtils), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	public Task FlushAsync(CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private bool FulfillFromLeftover(Byte[] buffer, int index, ref int count) { }

	[CalledBy(Type = typeof(<EncodeAsync>d__13), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Base64Encoder), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private void StoreLeftOverBytes(Byte[] buffer, int index, ref int count) { }

	[CalledBy(Type = typeof(<EncodeAsync>d__13), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Base64Encoder), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 16)]
	private void ValidateEncode(Byte[] buffer, int index, int count) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void WriteChars(Char[] chars, int index, int count) { }

	[CalledBy(Type = typeof(<EncodeAsync>d__13), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncUtils), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(Char[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	private Task WriteCharsAsync(Char[] chars, int index, int count, CancellationToken cancellationToken) { }

}

