namespace Mono.Security.Interface;

public sealed class TlsException : Exception
{
	private Alert alert; //Field offset: 0x90

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TlsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alert), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public TlsException(Alert alert) { }

	[CalledBy(Type = typeof(TlsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alert)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TlsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AlertDescription)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TlsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AlertDescription), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public TlsException(Alert alert, string message) { }

	[CalledBy(Type = "Mono.Btls.MonoBtlsContext", Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Btls.MonoBtlsSslError"}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsContext", Member = "InitializeSession", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Alert), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AlertDescription)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TlsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alert), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public TlsException(AlertDescription description) { }

	[CalledBy(Type = "Mono.Unity.Debug", Member = "CheckAndThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Unity.UnityTls+unitytls_errorstate", typeof(string), typeof(AlertDescription)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Unity.Debug", Member = "CheckAndThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Unity.UnityTls+unitytls_errorstate", "Mono.Unity.UnityTls+unitytls_x509verify_result", typeof(string), typeof(AlertDescription)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Unity.UnityTlsContext", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Net.Security.MobileAuthenticatedStream", "Mono.Net.Security.MonoSslAuthenticationOptions"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Unity.UnityTlsContext", Member = "StartHandshake", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Unity.UnityTlsContext", Member = "ProcessHandshake", ReturnType = typeof(bool))]
	[CalledBy(Type = "Mono.Unity.UnityTlsContext", Member = "CertificateCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_tlsctx*), typeof(Byte*), typeof(IntPtr), typeof(unitytls_x509name*), typeof(IntPtr), typeof(unitytls_x509list_ref*), typeof(unitytls_key_ref*), typeof(unitytls_errorstate*)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Net.Security.MobileTlsContext", Member = "SelectClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(X509Certificate))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Alert), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AlertDescription)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TlsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alert), typeof(string)}, ReturnType = typeof(void))]
	public TlsException(AlertDescription description, string message) { }

}

