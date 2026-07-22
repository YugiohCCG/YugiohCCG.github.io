namespace Mono.Security.Interface;

public sealed class MonoTlsSettings
{
	private static MonoTlsSettings defaultSettings; //Field offset: 0x0
	[CompilerGenerated]
	private MonoRemoteCertificateValidationCallback <RemoteCertificateValidationCallback>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private MonoLocalCertificateSelectionCallback <ClientCertificateSelectionCallback>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Nullable<DateTime> <CertificateValidationTime>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private X509CertificateCollection <TrustAnchors>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private object <UserSettings>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private String[] <CertificateSearchPaths>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private bool <SendCloseNotify>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private String[] <ClientCertificateIssuers>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private bool <DisallowUnauthenticatedCertificateRequest>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private Nullable<TlsProtocols> <EnabledProtocols>k__BackingField; //Field offset: 0x5C
	[CompilerGenerated]
	private CipherSuiteCode[] <EnabledCiphers>k__BackingField; //Field offset: 0x68
	private bool cloned; //Field offset: 0x70
	private bool checkCertName; //Field offset: 0x71
	private bool checkCertRevocationStatus; //Field offset: 0x72
	private Nullable<Boolean> useServicePointManagerCallback; //Field offset: 0x73
	private bool skipSystemValidators; //Field offset: 0x75
	private bool callbackNeedsChain; //Field offset: 0x76
	private ICertificateValidator certificateValidator; //Field offset: 0x78

	public bool CallbackNeedsCertificateChain
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 5
	}

	internal String[] CertificateSearchPaths
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	public Nullable<DateTime> CertificateValidationTime
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	[Obsolete("Do not use outside System.dll!")]
	public ICertificateValidator CertificateValidator
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public String[] ClientCertificateIssuers
	{
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public MonoLocalCertificateSelectionCallback ClientCertificateSelectionCallback
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public static MonoTlsSettings DefaultSettings
	{
		[CalledBy(Type = "Mono.Btls.MonoBtlsProvider", Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Btls.MonoBtlsX509Chain", "Mono.Btls.MonoBtlsX509VerifyParam"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(HttpListener), Member = "CreateSslStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(RemoteCertificateValidationCallback)}, ReturnType = typeof(SslStream))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 135
	}

	public bool DisallowUnauthenticatedCertificateRequest
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CLSCompliant(False)]
	public CipherSuiteCode[] EnabledCiphers
	{
		[CallerCount(Count = 22)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public Nullable<TlsProtocols> EnabledProtocols
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	public MonoRemoteCertificateValidationCallback RemoteCertificateValidationCallback
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	internal bool SendCloseNotify
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	public X509CertificateCollection TrustAnchors
	{
		[CallerCount(Count = 62)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public object UserSettings
	{
		[CallerCount(Count = 38)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public Nullable<Boolean> UseServicePointManagerCallback
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		 set { } //Length: 5
	}

	[CalledBy(Type = typeof(MonoTlsSettings), Member = "CopyDefaultSettings", ReturnType = typeof(MonoTlsSettings))]
	[CalledBy(Type = typeof(MonoTlsSettings), Member = "CloneWithValidator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICertificateValidator)}, ReturnType = typeof(MonoTlsSettings))]
	[CalledBy(Type = typeof(MonoTlsSettings), Member = "Clone", ReturnType = typeof(MonoTlsSettings))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(X509CertificateCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private MonoTlsSettings(MonoTlsSettings other) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public MonoTlsSettings() { }

	[CalledBy(Type = typeof(HttpListener), Member = "CreateSslStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(RemoteCertificateValidationCallback)}, ReturnType = typeof(SslStream))]
	[CalledBy(Type = typeof(SslStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(MonoTlsProvider), typeof(MonoTlsSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MonoTlsSettings), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoTlsSettings)}, ReturnType = typeof(void))]
	public MonoTlsSettings Clone() { }

	[CalledBy(Type = "Mono.Net.Security.ChainValidationHelper", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SslStream), "Mono.Net.Security.MobileTlsProvider", typeof(MonoTlsSettings), typeof(bool), "Mono.Net.Security.MonoTlsStream"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoTlsSettings), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoTlsSettings)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[Obsolete("Do not use outside System.dll!")]
	public MonoTlsSettings CloneWithValidator(ICertificateValidator validator) { }

	[CalledBy(Type = "Mono.Net.Security.ChainValidationHelper", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SslStream), "Mono.Net.Security.MobileTlsProvider", typeof(MonoTlsSettings), typeof(bool), "Mono.Net.Security.MonoTlsStream"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Net.Security.MonoTlsStream", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpWebRequest), typeof(NetworkStream)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SslStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(RemoteCertificateValidationCallback), typeof(LocalCertificateSelectionCallback)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MonoTlsSettings), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoTlsSettings)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static MonoTlsSettings CopyDefaultSettings() { }

	[CallerCount(Count = 0)]
	public bool get_CallbackNeedsCertificateChain() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal String[] get_CertificateSearchPaths() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Nullable<DateTime> get_CertificateValidationTime() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public ICertificateValidator get_CertificateValidator() { }

	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public String[] get_ClientCertificateIssuers() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public MonoLocalCertificateSelectionCallback get_ClientCertificateSelectionCallback() { }

	[CalledBy(Type = "Mono.Btls.MonoBtlsProvider", Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Btls.MonoBtlsX509Chain", "Mono.Btls.MonoBtlsX509VerifyParam"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HttpListener), Member = "CreateSslStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(RemoteCertificateValidationCallback)}, ReturnType = typeof(SslStream))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static MonoTlsSettings get_DefaultSettings() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_DisallowUnauthenticatedCertificateRequest() { }

	[CallerCount(Count = 22)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public CipherSuiteCode[] get_EnabledCiphers() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Nullable<TlsProtocols> get_EnabledProtocols() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public MonoRemoteCertificateValidationCallback get_RemoteCertificateValidationCallback() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal bool get_SendCloseNotify() { }

	[CallerCount(Count = 62)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public X509CertificateCollection get_TrustAnchors() { }

	[CallerCount(Count = 38)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public object get_UserSettings() { }

	[CallerCount(Count = 0)]
	public Nullable<Boolean> get_UseServicePointManagerCallback() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_CertificateSearchPaths(String[] value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_CertificateValidationTime(Nullable<DateTime> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_ClientCertificateIssuers(String[] value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_ClientCertificateSelectionCallback(MonoLocalCertificateSelectionCallback value) { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_DisallowUnauthenticatedCertificateRequest(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_EnabledCiphers(CipherSuiteCode[] value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_EnabledProtocols(Nullable<TlsProtocols> value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_RemoteCertificateValidationCallback(MonoRemoteCertificateValidationCallback value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_SendCloseNotify(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_TrustAnchors(X509CertificateCollection value) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_UserSettings(object value) { }

	[CallerCount(Count = 0)]
	public void set_UseServicePointManagerCallback(Nullable<Boolean> value) { }

}

