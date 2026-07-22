namespace Mono.Btls;

internal static class MonoBtlsX509StoreManager
{
	private static bool initialized; //Field offset: 0x0
	private static string machineTrustedRootPath; //Field offset: 0x8
	private static string machineIntermediateCAPath; //Field offset: 0x10
	private static string machineUntrustedPath; //Field offset: 0x18
	private static string userTrustedRootPath; //Field offset: 0x20
	private static string userIntermediateCAPath; //Field offset: 0x28
	private static string userUntrustedPath; //Field offset: 0x30

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509StoreManager), Member = "get_NewCurrentUserPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(X509StoreManager), Member = "get_NewLocalMachinePath", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 6)]
	private static void DoInitialize() { }

	[CalledBy(Type = typeof(MonoBtlsContext), Member = "InitializeConnection", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainValidationHelper), typeof(string), typeof(bool), typeof(X509CertificateCollection), typeof(bool), typeof(X509Chain&), typeof(SslPolicyErrors&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Chain), typeof(MonoBtlsX509VerifyParam)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "SetupCertificateStore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Store), typeof(MonoTlsSettings), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "SetupDefaultCertificateStore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Store)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "AddUserStore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Store)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "AddMachineStore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Store)}, ReturnType = typeof(void))]
	[CallerCount(Count = 28)]
	[Calls(Type = typeof(MonoBtlsX509StoreManager), Member = "Initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static string GetStorePath(MonoBtlsX509StoreType type) { }

	[CalledBy(Type = typeof(MonoBtlsX509StoreManager), Member = "GetStorePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509StoreType)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(X509StoreManager), Member = "get_NewCurrentUserPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(X509StoreManager), Member = "get_NewLocalMachinePath", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private static void Initialize() { }

}

