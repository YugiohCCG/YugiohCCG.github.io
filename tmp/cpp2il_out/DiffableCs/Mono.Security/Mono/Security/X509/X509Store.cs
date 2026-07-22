namespace Mono.Security.X509;

public class X509Store
{
	private string _storePath; //Field offset: 0x10
	private X509CertificateCollection _certificates; //Field offset: 0x18
	private ArrayList _crls; //Field offset: 0x20
	private bool _crl; //Field offset: 0x28
	private bool _newFormat; //Field offset: 0x29

	public X509CertificateCollection Certificates
	{
		[CalledBy(Type = typeof(X509Store), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpenFlags)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(X509Store), Member = "BuildCertificatesCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(X509CertificateCollection))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 64
	}

	public ArrayList Crls
	{
		[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "CheckCrls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(X509Store)}, ReturnType = typeof(X509Crl))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(X509Store), Member = "BuildCrlsCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ArrayList))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 142
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal X509Store(string path, bool crl, bool newFormat) { }

	[CalledBy(Type = typeof(X509Store), Member = "get_Certificates", ReturnType = typeof(X509CertificateCollection))]
	[CalledBy(Type = typeof(X509StoreManager), Member = "get_TrustedRootCertificates", ReturnType = typeof(X509CertificateCollection))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(X509Store), Member = "CheckStore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Directory), Member = "GetFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(X509Store), Member = "LoadCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(X509Certificate))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private X509CertificateCollection BuildCertificatesCollection(string storeName) { }

	[CalledBy(Type = typeof(X509Store), Member = "get_Crls", ReturnType = typeof(ArrayList))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(X509Store), Member = "CheckStore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Directory), Member = "GetFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(X509Store), Member = "LoadCrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(X509Crl))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private ArrayList BuildCrlsCollection(string storeName) { }

	[CalledBy(Type = typeof(X509Store), Member = "BuildCertificatesCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(X509CertificateCollection))]
	[CalledBy(Type = typeof(X509Store), Member = "BuildCrlsCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ArrayList))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DirectoryInfo))]
	[CallsUnknownMethods(Count = 2)]
	private bool CheckStore(string path, bool throwException) { }

	[CalledBy(Type = typeof(X509Store), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpenFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(X509Store), Member = "BuildCertificatesCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(X509CertificateCollection))]
	[CallsUnknownMethods(Count = 1)]
	public X509CertificateCollection get_Certificates() { }

	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "CheckCrls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(X509Store)}, ReturnType = typeof(X509Crl))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Store), Member = "BuildCrlsCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ArrayList))]
	[CallsUnknownMethods(Count = 2)]
	public ArrayList get_Crls() { }

	[CalledBy(Type = typeof(X509Store), Member = "LoadCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(X509Certificate))]
	[CalledBy(Type = typeof(X509Store), Member = "LoadCrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(X509Crl))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(File), Member = "OpenRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(FileStream))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private Byte[] Load(string filename) { }

	[CalledBy(Type = typeof(X509Store), Member = "BuildCertificatesCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(X509CertificateCollection))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(X509Store), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	private X509Certificate LoadCertificate(string filename) { }

	[CalledBy(Type = typeof(X509Store), Member = "BuildCrlsCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ArrayList))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(X509Store), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(X509Crl), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private X509Crl LoadCrl(string filename) { }

}

