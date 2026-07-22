namespace Mono;

internal class SystemCertificateProvider : ISystemCertificateProvider
{
	private static MonoTlsProvider provider; //Field offset: 0x0
	private static int initialized; //Field offset: 0x8
	private static X509PalImpl x509pal; //Field offset: 0x10
	private static object syncRoot; //Field offset: 0x18

	public X509PalImpl X509Pal
	{
		[CalledBy(Type = typeof(SystemCertificateProvider), Member = "Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Mono.CertificateImportFlags"}, ReturnType = "System.Security.Cryptography.X509Certificates.X509CertificateImpl")]
		[CalledBy(Type = typeof(SystemCertificateProvider), Member = "Mono.ISystemCertificateProvider.Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle", typeof(X509KeyStorageFlags), "Mono.CertificateImportFlags"}, ReturnType = "System.Security.Cryptography.X509Certificates.X509CertificateImpl")]
		[CalledBy(Type = typeof(SystemCertificateProvider), Member = "Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle", typeof(X509KeyStorageFlags), "Mono.CertificateImportFlags"}, ReturnType = typeof(X509Certificate2Impl))]
		[CalledBy(Type = typeof(SystemCertificateProvider), Member = "Mono.ISystemCertificateProvider.Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), "Mono.CertificateImportFlags"}, ReturnType = "System.Security.Cryptography.X509Certificates.X509CertificateImpl")]
		[CalledBy(Type = typeof(SystemCertificateProvider), Member = "Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), "Mono.CertificateImportFlags"}, ReturnType = typeof(X509Certificate2Impl))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(SystemCertificateProvider), Member = "EnsureInitialized", ReturnType = typeof(void))]
		 get { } //Length: 83
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static SystemCertificateProvider() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public SystemCertificateProvider() { }

	[CalledBy(Type = typeof(SystemCertificateProvider), Member = "get_X509Pal", ReturnType = typeof(X509PalImpl))]
	[CalledBy(Type = typeof(SystemDependencyProvider), Member = "get_X509Pal", ReturnType = typeof(X509PalImpl))]
	[CalledBy(Type = typeof(X509Pal), Member = "get_Instance", ReturnType = typeof(X509PalImpl))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(MonoTlsProviderFactory), Member = "GetProvider", ReturnType = typeof(MonoTlsProvider))]
	[Calls(Type = typeof(SystemCertificateProvider), Member = "GetX509Pal", ReturnType = typeof(X509PalImpl))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private static void EnsureInitialized() { }

	[CalledBy(Type = typeof(SystemCertificateProvider), Member = "Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Mono.CertificateImportFlags"}, ReturnType = "System.Security.Cryptography.X509Certificates.X509CertificateImpl")]
	[CalledBy(Type = typeof(SystemCertificateProvider), Member = "Mono.ISystemCertificateProvider.Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle", typeof(X509KeyStorageFlags), "Mono.CertificateImportFlags"}, ReturnType = "System.Security.Cryptography.X509Certificates.X509CertificateImpl")]
	[CalledBy(Type = typeof(SystemCertificateProvider), Member = "Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle", typeof(X509KeyStorageFlags), "Mono.CertificateImportFlags"}, ReturnType = typeof(X509Certificate2Impl))]
	[CalledBy(Type = typeof(SystemCertificateProvider), Member = "Mono.ISystemCertificateProvider.Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), "Mono.CertificateImportFlags"}, ReturnType = "System.Security.Cryptography.X509Certificates.X509CertificateImpl")]
	[CalledBy(Type = typeof(SystemCertificateProvider), Member = "Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), "Mono.CertificateImportFlags"}, ReturnType = typeof(X509Certificate2Impl))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(SystemCertificateProvider), Member = "EnsureInitialized", ReturnType = typeof(void))]
	public X509PalImpl get_X509Pal() { }

	[CalledBy(Type = typeof(SystemCertificateProvider), Member = "EnsureInitialized", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509PalImplBtls), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoTlsProvider)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	private static X509PalImpl GetX509Pal() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemCertificateProvider), Member = "get_X509Pal", ReturnType = typeof(X509PalImpl))]
	[Calls(Type = typeof(X509PalImpl), Member = "ImportFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(X509Certificate2Impl))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override X509CertificateImpl Import(Byte[] data, CertificateImportFlags importFlags = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemCertificateProvider), Member = "get_X509Pal", ReturnType = typeof(X509PalImpl))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public X509Certificate2Impl Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemCertificateProvider), Member = "get_X509Pal", ReturnType = typeof(X509PalImpl))]
	[Calls(Type = typeof(X509PalImpl), Member = "ImportFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(X509Certificate2Impl))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public X509Certificate2Impl Import(X509Certificate cert, CertificateImportFlags importFlags = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemCertificateProvider), Member = "get_X509Pal", ReturnType = typeof(X509PalImpl))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private override X509CertificateImpl Mono.ISystemCertificateProvider.Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemCertificateProvider), Member = "get_X509Pal", ReturnType = typeof(X509PalImpl))]
	[Calls(Type = typeof(X509PalImpl), Member = "ImportFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(X509Certificate2Impl))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private override X509CertificateImpl Mono.ISystemCertificateProvider.Import(X509Certificate cert, CertificateImportFlags importFlags) { }

}

