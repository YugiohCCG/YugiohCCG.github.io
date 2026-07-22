namespace System.Security.Cryptography.X509Certificates;

internal abstract class X509CertificateImpl : IDisposable
{

	public abstract bool HasPrivateKey
	{
		 get { } //Length: 0
	}

	public abstract string Issuer
	{
		 get { } //Length: 0
	}

	public abstract bool IsValid
	{
		 get { } //Length: 0
	}

	public abstract string KeyAlgorithm
	{
		 get { } //Length: 0
	}

	public abstract Byte[] KeyAlgorithmParameters
	{
		 get { } //Length: 0
	}

	public abstract DateTime NotAfter
	{
		 get { } //Length: 0
	}

	public abstract DateTime NotBefore
	{
		 get { } //Length: 0
	}

	public abstract Byte[] PublicKeyValue
	{
		 get { } //Length: 0
	}

	public abstract Byte[] RawData
	{
		 get { } //Length: 0
	}

	public abstract Byte[] SerialNumber
	{
		 get { } //Length: 0
	}

	public abstract string Subject
	{
		 get { } //Length: 0
	}

	public abstract Byte[] Thumbprint
	{
		 get { } //Length: 0
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected X509CertificateImpl() { }

	public abstract X509CertificateImpl Clone() { }

	public abstract X509CertificateImpl CopyWithPrivateKey(RSA privateKey) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void Dispose(bool disposing) { }

	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImplCollection", Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public virtual bool Equals(object obj) { }

	public abstract Byte[] Export(X509ContentType contentType, SafePasswordHandle password) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected virtual void Finalize() { }

	public abstract bool get_HasPrivateKey() { }

	public abstract string get_Issuer() { }

	public abstract bool get_IsValid() { }

	public abstract string get_KeyAlgorithm() { }

	public abstract Byte[] get_KeyAlgorithmParameters() { }

	public abstract DateTime get_NotAfter() { }

	public abstract DateTime get_NotBefore() { }

	public abstract Byte[] get_PublicKeyValue() { }

	public abstract Byte[] get_RawData() { }

	public abstract Byte[] get_SerialNumber() { }

	public abstract string get_Subject() { }

	public abstract Byte[] get_Thumbprint() { }

	public abstract DSA GetDSAPrivateKey() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public virtual int GetHashCode() { }

	public abstract RSA GetRSAPrivateKey() { }

	[CalledBy(Type = "Mono.Btls.X509CertificateImplBtls", Member = "get_X509", ReturnType = "Mono.Btls.MonoBtlsX509")]
	[CalledBy(Type = "Mono.Btls.X509CertificateImplBtls", Member = "get_NativePrivateKey", ReturnType = "Mono.Btls.MonoBtlsKey")]
	[CalledBy(Type = "Mono.Btls.X509CertificateImplBtls", Member = "Clone", ReturnType = typeof(X509CertificateImpl))]
	[CalledBy(Type = "Mono.Btls.X509CertificateImplBtls", Member = "GetRawCertData", ReturnType = "System.Byte[]")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "Clone", ReturnType = typeof(X509CertificateImpl))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "get_Cert", ReturnType = "Mono.Security.X509.X509Certificate")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "GetRawCertData", ReturnType = "System.Byte[]")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplUnix", Member = "EnsureCertData", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplUnix", Member = "Export", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ContentType), typeof(SafePasswordHandle)}, ReturnType = "System.Byte[]")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(X509Helper), Member = "GetInvalidContextException", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected void ThrowIfContextInvalid() { }

}

