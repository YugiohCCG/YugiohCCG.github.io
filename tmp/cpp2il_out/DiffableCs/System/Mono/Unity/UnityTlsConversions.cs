namespace Mono.Unity;

internal static class UnityTlsConversions
{

	[CallerCount(Count = 0)]
	public static TlsProtocols ConvertProtocolVersion(unitytls_protocol protocol) { }

	[CallerCount(Count = 0)]
	public static unitytls_protocol GetMaxProtocol(SslProtocols protocols) { }

	[CallerCount(Count = 0)]
	public static unitytls_protocol GetMinProtocol(SslProtocols protocols) { }

	[CalledBy(Type = typeof(Debug), Member = "CheckAndThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_errorstate), typeof(unitytls_x509verify_result), typeof(string), typeof(AlertDescription)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityTlsContext), Member = "ProcessHandshake", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static AlertDescription VerifyResultToAlertDescription(unitytls_x509verify_result verifyResult, AlertDescription defaultAlert = 80) { }

	[CallerCount(Count = 0)]
	public static X509ChainStatusFlags VerifyResultToChainStatus(unitytls_x509verify_result verifyResult) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static SslPolicyErrors VerifyResultToPolicyErrror(unitytls_x509verify_result verifyResult) { }

}

