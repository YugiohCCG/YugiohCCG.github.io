namespace Mono.Btls;

internal class MonoBtlsX509LookupMonoCollection : MonoBtlsX509LookupMono
{
	private Int64[] hashes; //Field offset: 0x48
	private MonoBtlsX509[] certificates; //Field offset: 0x50
	private X509CertificateCollection collection; //Field offset: 0x58
	private MonoBtlsX509TrustKind trust; //Field offset: 0x60

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsX509LookupMono), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal MonoBtlsX509LookupMonoCollection(X509CertificateCollection collection, MonoBtlsX509TrustKind trust) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsX509LookupMono), Member = "Close", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	protected virtual void Close() { }

	[CalledBy(Type = typeof(MonoBtlsX509LookupMonoCollection), Member = "OnGetBySubject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Name)}, ReturnType = typeof(MonoBtlsX509))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(X509CertificateCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(X509Certificate))]
	[Calls(Type = typeof(MonoBtlsX509), Member = "LoadFromData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(MonoBtlsX509Format)}, ReturnType = typeof(MonoBtlsX509))]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsX509), Member = "get_Handle", ReturnType = typeof(BoringX509Handle))]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsX509), Member = "GetSubjectNameHash", ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	private void Initialize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsX509LookupMonoCollection), Member = "Initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsX509Name), Member = "GetHash", ReturnType = typeof(long))]
	[Calls(Type = typeof(MonoBtlsX509LookupMono), Member = "AddCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	protected virtual MonoBtlsX509 OnGetBySubject(MonoBtlsX509Name name) { }

}

