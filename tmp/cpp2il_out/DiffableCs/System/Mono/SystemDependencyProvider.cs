namespace Mono;

internal class SystemDependencyProvider : ISystemDependencyProvider
{
	private static SystemDependencyProvider instance; //Field offset: 0x0
	private static object syncRoot; //Field offset: 0x8
	[CompilerGenerated]
	private readonly SystemCertificateProvider <CertificateProvider>k__BackingField; //Field offset: 0x10

	public SystemCertificateProvider CertificateProvider
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public static SystemDependencyProvider Instance
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SystemDependencyProvider), Member = "Initialize", ReturnType = typeof(void))]
		 get { } //Length: 82
	}

	private override ISystemCertificateProvider Mono.ISystemDependencyProvider.CertificateProvider
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	public X509PalImpl X509Pal
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SystemCertificateProvider), Member = "EnsureInitialized", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 95
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static SystemDependencyProvider() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "Mono.DependencyInjector", Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.ISystemDependencyProvider"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private SystemDependencyProvider() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public SystemCertificateProvider get_CertificateProvider() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemDependencyProvider), Member = "Initialize", ReturnType = typeof(void))]
	public static SystemDependencyProvider get_Instance() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemCertificateProvider), Member = "EnsureInitialized", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public X509PalImpl get_X509Pal() { }

	[CalledBy(Type = typeof(SystemDependencyProvider), Member = "get_Instance", ReturnType = typeof(SystemDependencyProvider))]
	[CalledBy(Type = typeof(X509Pal), Member = "get_Instance", ReturnType = typeof(X509PalImpl))]
	[CalledBy(Type = typeof(MonoTlsProviderFactory), Member = "InitializeInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = "Mono.DependencyInjector", Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.ISystemDependencyProvider"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal static void Initialize() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	private override ISystemCertificateProvider Mono.ISystemDependencyProvider.get_CertificateProvider() { }

}

