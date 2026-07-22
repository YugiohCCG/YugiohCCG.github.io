namespace Mono.Btls;

internal class MonoBtlsPkcs12 : MonoBtlsObject
{
	public class BoringPkcs12Handle : MonoBtlsHandle
	{

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BoringPkcs12Handle(IntPtr handle) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		protected virtual bool ReleaseHandle() { }

	}

	private MonoBtlsKey privateKey; //Field offset: 0x20

	public int Count
	{
		[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(MonoBtlsPkcs12), Member = "get_Handle", ReturnType = typeof(BoringPkcs12Handle))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 145
	}

	internal BoringPkcs12Handle Handle
	{
		[CalledBy(Type = typeof(MonoBtlsPkcs12), Member = "get_Count", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(MonoBtlsPkcs12), Member = "GetCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MonoBtlsX509))]
		[CalledBy(Type = typeof(MonoBtlsPkcs12), Member = "Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsPkcs12), Member = "get_HasPrivateKey", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(MonoBtlsPkcs12), Member = "GetPrivateKey", ReturnType = typeof(MonoBtlsKey))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 117
	}

	public bool HasPrivateKey
	{
		[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(MonoBtlsPkcs12), Member = "get_Handle", ReturnType = typeof(BoringPkcs12Handle))]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 154
	}

	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal MonoBtlsPkcs12() { }

	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MonoBtlsPkcs12), Member = "get_Handle", ReturnType = typeof(BoringPkcs12Handle))]
	[CallsUnknownMethods(Count = 3)]
	public int get_Count() { }

	[CalledBy(Type = typeof(MonoBtlsPkcs12), Member = "get_Count", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MonoBtlsPkcs12), Member = "GetCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MonoBtlsX509))]
	[CalledBy(Type = typeof(MonoBtlsPkcs12), Member = "Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsPkcs12), Member = "get_HasPrivateKey", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsPkcs12), Member = "GetPrivateKey", ReturnType = typeof(MonoBtlsKey))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal BoringPkcs12Handle get_Handle() { }

	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsPkcs12), Member = "get_Handle", ReturnType = typeof(BoringPkcs12Handle))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public bool get_HasPrivateKey() { }

	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MonoBtlsPkcs12), Member = "get_Handle", ReturnType = typeof(BoringPkcs12Handle))]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	public MonoBtlsX509 GetCertificate(int index) { }

	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsPkcs12), Member = "get_Handle", ReturnType = typeof(BoringPkcs12Handle))]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	public MonoBtlsKey GetPrivateKey() { }

	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MonoBtlsPkcs12), Member = "get_Handle", ReturnType = typeof(BoringPkcs12Handle))]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public void Import(Byte[] buffer, SafePasswordHandle password) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void mono_btls_pkcs12_free(IntPtr handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr mono_btls_pkcs12_get_cert(IntPtr Handle, int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int mono_btls_pkcs12_get_count(IntPtr handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr mono_btls_pkcs12_get_private_key(IntPtr pkcs12) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int mono_btls_pkcs12_has_private_key(IntPtr pkcs12) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static int mono_btls_pkcs12_import(IntPtr chain, Void* data, int len, SafePasswordHandle password) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr mono_btls_pkcs12_new() { }

}

