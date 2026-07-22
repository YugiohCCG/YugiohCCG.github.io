namespace Mono;

internal class X509PalImplMono : X509PalImpl
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public X509PalImplMono() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509PalImpl), Member = "ImportFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(X509Certificate2Impl))]
	public virtual X509CertificateImpl Import(Byte[] data) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(X509Certificate2ImplMono), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle", typeof(X509KeyStorageFlags)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public virtual X509Certificate2Impl Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual X509Certificate2Impl Import(X509Certificate cert) { }

}

