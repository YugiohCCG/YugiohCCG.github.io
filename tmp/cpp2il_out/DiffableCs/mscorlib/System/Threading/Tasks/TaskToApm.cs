namespace System.Threading.Tasks;

internal static class TaskToApm
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public AsyncCallback callback; //Field offset: 0x10
		public IAsyncResult asyncResult; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass3_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal void <InvokeCallbackWhenTaskCompletes>b__0() { }

	}

	private sealed class TaskWrapperAsyncResult : IAsyncResult
	{
		internal readonly Task Task; //Field offset: 0x10
		private readonly object _state; //Field offset: 0x18
		private readonly bool _completedSynchronously; //Field offset: 0x20

		private override object System.IAsyncResult.AsyncState
		{
			[CallerCount(Count = 31)]
			[DeduplicatedMethod]
			private get { } //Length: 5
		}

		private override WaitHandle System.IAsyncResult.AsyncWaitHandle
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 2)]
			private get { } //Length: 184
		}

		private override bool System.IAsyncResult.CompletedSynchronously
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			private get { } //Length: 5
		}

		private override bool System.IAsyncResult.IsCompleted
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[ContainsUnimplementedInstructions]
			private get { } //Length: 92
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal TaskWrapperAsyncResult(Task task, object state, bool completedSynchronously) { }

		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		private override object System.IAsyncResult.get_AsyncState() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		private override WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private override bool System.IAsyncResult.get_CompletedSynchronously() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		private override bool System.IAsyncResult.get_IsCompleted() { }

	}


	[CalledBy(Type = typeof(CryptoStream), Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.Net.Security.SslStream", Member = "BeginWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.Net.Security.SslStream", Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.Net.Security.SslStream", Member = "BeginAuthenticateAsClient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Security.Cryptography.X509Certificates.X509CertificateCollection", "System.Security.Authentication.SslProtocols", typeof(bool), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.Net.WebConnectionStream", Member = "BeginWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.Net.WebConnectionStream", Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.Net.WebReadStream", Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.Net.HttpWebRequest", Member = "BeginGetRequestStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.IO.Compression.GZipStream", Member = "BeginWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.IO.Compression.GZipStream", Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(CryptoStream), Member = "BeginWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.Net.HttpWebRequest", Member = "BeginGetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(ConfiguredTaskAwaitable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConfiguredTaskAwaiter), Member = "OnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	public static IAsyncResult Begin(Task task, AsyncCallback callback, object state) { }

	[CalledBy(Type = typeof(CryptoStream), Member = "EndWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Compression.GZipStream", Member = "EndWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebConnectionStream", Member = "EndWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Security.SslStream", Member = "EndAuthenticateAsClient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Security.SslStream", Member = "EndWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static void End(IAsyncResult asyncResult) { }

	[CalledBy(Type = typeof(CryptoStream), Member = "EndRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.IO.Compression.GZipStream", Member = "EndRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.WebConnectionStream", Member = "EndRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.WebReadStream", Member = "EndRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.Security.SslStream", Member = "EndRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public static TResult End(IAsyncResult asyncResult) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConfiguredTaskAwaitable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConfiguredTaskAwaiter), Member = "OnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static void InvokeCallbackWhenTaskCompletes(Task antecedent, AsyncCallback callback, IAsyncResult asyncResult) { }

}

