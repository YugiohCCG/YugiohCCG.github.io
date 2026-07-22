namespace Mono.Security.Interface;

public static class MonoTlsProviderFactory
{

	[CalledBy(Type = "Mono.SystemCertificateProvider", Member = "EnsureInitialized", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpListener), Member = "CreateSslStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(RemoteCertificateValidationCallback)}, ReturnType = typeof(SslStream))]
	[CalledBy(Type = typeof(SslStream), Member = "GetProvider", ReturnType = "Mono.Net.Security.MobileTlsProvider")]
	[CalledBy(Type = typeof(SslStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(RemoteCertificateValidationCallback), typeof(LocalCertificateSelectionCallback)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = "Mono.Net.Security.NoReflectionHelper", Member = "GetProvider", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	public static MonoTlsProvider GetProvider() { }

}

