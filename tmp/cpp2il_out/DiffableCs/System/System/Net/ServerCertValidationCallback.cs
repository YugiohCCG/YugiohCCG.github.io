namespace System.Net;

internal class ServerCertValidationCallback
{
	private class CallbackContext
	{
		internal readonly object request; //Field offset: 0x10
		internal readonly X509Certificate certificate; //Field offset: 0x18
		internal readonly X509Chain chain; //Field offset: 0x20
		internal readonly SslPolicyErrors sslPolicyErrors; //Field offset: 0x28
		internal bool result; //Field offset: 0x2C

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		internal CallbackContext(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

	}

	private readonly RemoteCertificateValidationCallback m_ValidationCallback; //Field offset: 0x10
	private readonly ExecutionContext m_Context; //Field offset: 0x18

	internal RemoteCertificateValidationCallback ValidationCallback
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CalledBy(Type = typeof(ChainValidationHelper), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SslStream), typeof(MobileTlsProvider), typeof(MonoTlsSettings), typeof(bool), typeof(MonoTlsStream)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChainValidationHelper), Member = "GetValidationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoTlsSettings)}, ReturnType = typeof(ServerCertValidationCallback))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExecutionContext), Member = "Capture", ReturnType = typeof(ExecutionContext))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal ServerCertValidationCallback(RemoteCertificateValidationCallback validationCallback) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void Callback(object state) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal RemoteCertificateValidationCallback get_ValidationCallback() { }

	[CalledBy(Type = typeof(ChainValidationHelper), Member = "InvokeCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(X509Chain), typeof(SslPolicyErrors)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExecutionContext), Member = "CreateCopy", ReturnType = typeof(ExecutionContext))]
	[Calls(Type = typeof(ExecutionContext), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ContextCallback), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	internal bool Invoke(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}

