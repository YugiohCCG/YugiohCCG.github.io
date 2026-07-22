namespace Mono.Btls;

internal class MonoBtlsStream : MobileAuthenticatedStream
{

	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "CreateSslStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SslStream), typeof(Stream), typeof(bool), typeof(MonoTlsSettings)}, ReturnType = typeof(MobileAuthenticatedStream))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MobileAuthenticatedStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(SslStream), typeof(MonoTlsSettings), typeof(MobileTlsProvider)}, ReturnType = typeof(void))]
	public MonoBtlsStream(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MobileAuthenticatedStream), typeof(MonoSslAuthenticationOptions)}, ReturnType = typeof(void))]
	protected virtual MobileTlsContext CreateContext(MonoSslAuthenticationOptions options) { }

}

