namespace Microsoft.Win32.SafeHandles;

internal sealed class SafePasswordHandle : SafeHandle
{

	public virtual bool IsInvalid
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 34
	}

	[CalledBy(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string), typeof(X509KeyStorageFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(X509KeyStorageFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509Certificate), Member = "Export", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ContentType), typeof(string)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = "Mono.X509PalImpl", Member = "ImportFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Impl")]
	[CalledBy(Type = "Mono.Btls.MonoBtlsContext", Member = "GetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = "Mono.Btls.X509CertificateImplBtls")]
	[CalledBy(Type = "Mono.Btls.MonoBtlsProvider", Member = "GetNativeCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(string), typeof(X509KeyStorageFlags)}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Impl")]
	[CalledBy(Type = "Mono.Btls.X509CertificateImplBtls", Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(SafePasswordHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "StringToHGlobalUni", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	public SafePasswordHandle(string password) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Marshal), Member = "StringToHGlobalUni", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	private IntPtr CreateHandle(string password) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SafeHandleCache`1), Member = "IsCachedInvalidHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SafeHandle), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	protected virtual void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Marshal), Member = "ZeroFreeGlobalAllocUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	private void FreeHandle() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool get_IsInvalid() { }

	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(SafePasswordHandle), typeof(X509KeyStorageFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(SafePasswordHandle)}, ReturnType = "Mono.Security.X509.X509Certificate")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplUnix", Member = "Export", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ContentType), typeof(SafePasswordHandle)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplUnix", Member = "ExportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafePasswordHandle)}, ReturnType = "System.Byte[]")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Marshal), Member = "PtrToStringUni", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(string))]
	internal string Mono_DangerousGetString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Marshal), Member = "ZeroFreeGlobalAllocUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual bool ReleaseHandle() { }

}

