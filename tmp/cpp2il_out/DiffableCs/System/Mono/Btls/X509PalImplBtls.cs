namespace Mono.Btls;

internal class X509PalImplBtls : X509PalImpl
{
	[CompilerGenerated]
	private readonly MonoBtlsProvider <Provider>k__BackingField; //Field offset: 0x10

	private MonoBtlsProvider Provider
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	[CalledBy(Type = typeof(SystemCertificateProvider), Member = "GetX509Pal", ReturnType = typeof(X509PalImpl))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Regex), Member = "GetCachedCodeEntryInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedCodeEntryKey), typeof(bool)}, ReturnType = typeof(CachedCodeEntry))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	public X509PalImplBtls(MonoTlsProvider provider) { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private MonoBtlsProvider get_Provider() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsProvider), Member = "GetNativeCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string), typeof(X509KeyStorageFlags)}, ReturnType = typeof(X509Certificate2Impl))]
	[CallsUnknownMethods(Count = 1)]
	public virtual X509CertificateImpl Import(Byte[] data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsProvider), Member = "GetNativeCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle", typeof(X509KeyStorageFlags)}, ReturnType = typeof(X509Certificate2Impl))]
	[CallsUnknownMethods(Count = 1)]
	public virtual X509Certificate2Impl Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsProvider), Member = "GetNativeCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(X509Certificate2Impl))]
	[CallsUnknownMethods(Count = 1)]
	public virtual X509Certificate2Impl Import(X509Certificate cert) { }

}

