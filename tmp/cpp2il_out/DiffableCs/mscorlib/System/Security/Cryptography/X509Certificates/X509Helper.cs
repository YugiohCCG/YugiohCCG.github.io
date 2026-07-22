namespace System.Security.Cryptography.X509Certificates;

internal static class X509Helper
{

	private static ISystemCertificateProvider CertificateProvider
	{
		[CalledBy(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(X509Helper), Member = "InitFromCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(X509CertificateImpl))]
		[CalledBy(Type = typeof(X509Helper), Member = "Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(X509CertificateImpl))]
		[CalledBy(Type = typeof(X509Helper), Member = "Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(SafePasswordHandle), typeof(X509KeyStorageFlags)}, ReturnType = typeof(X509CertificateImpl))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(DependencyInjector), Member = "get_SystemProvider", ReturnType = typeof(ISystemDependencyProvider))]
		[Calls(Type = typeof(AppDomain), Member = "InternalSetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Context)}, ReturnType = typeof(Context))]
		[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BinaryFormatter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = "System.Security.Claims.ClaimsIdentity+<get_Claims>d__51", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 6)]
		private get { } //Length: 1125
	}

	[CalledBy(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509Helper), Member = "InitFromCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(X509CertificateImpl))]
	[CalledBy(Type = typeof(X509Helper), Member = "Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(X509CertificateImpl))]
	[CalledBy(Type = typeof(X509Helper), Member = "Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(SafePasswordHandle), typeof(X509KeyStorageFlags)}, ReturnType = typeof(X509CertificateImpl))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DependencyInjector), Member = "get_SystemProvider", ReturnType = typeof(ISystemDependencyProvider))]
	[Calls(Type = typeof(AppDomain), Member = "InternalSetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Context)}, ReturnType = typeof(Context))]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryFormatter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = "System.Security.Claims.ClaimsIdentity+<get_Claims>d__51", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private static ISystemCertificateProvider get_CertificateProvider() { }

	[CalledBy(Type = typeof(X509Certificate), Member = "get_Issuer", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509Helper), Member = "ThrowIfContextInvalid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImpl)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509CertificateImpl), Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509Certificate), Member = "ThrowIfInvalid", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509Certificate), Member = "GetNotBefore", ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(X509Certificate), Member = "GetNotAfter", ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(X509Certificate), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509Certificate), Member = "GetSerialNumber", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(X509Certificate), Member = "GetSerialNumberString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509Certificate), Member = "GetKeyAlgorithmParameters", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(X509Certificate), Member = "GetKeyAlgorithm", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509Certificate), Member = "GetRawCertData", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(X509Certificate), Member = "GetCertHashString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509Certificate), Member = "GetCertHash", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(X509Certificate), Member = "get_Subject", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509Certificate), Member = "GetPublicKey", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static Exception GetInvalidContextException() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Helper), Member = "get_CertificateProvider", ReturnType = typeof(ISystemCertificateProvider))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static X509CertificateImpl Import(Byte[] rawData) { }

	[CalledBy(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string), typeof(X509KeyStorageFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(X509KeyStorageFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(X509Helper), Member = "get_CertificateProvider", ReturnType = typeof(ISystemCertificateProvider))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static X509CertificateImpl Import(Byte[] rawData, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Helper), Member = "get_CertificateProvider", ReturnType = typeof(ISystemCertificateProvider))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static X509CertificateImpl InitFromCertificate(X509Certificate cert) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static X509CertificateImpl InitFromCertificate(X509CertificateImpl impl) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public static bool IsValid(X509CertificateImpl impl) { }

	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "get_Impl", ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Impl")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(X509Helper), Member = "GetInvalidContextException", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static void ThrowIfContextInvalid(X509CertificateImpl impl) { }

}

