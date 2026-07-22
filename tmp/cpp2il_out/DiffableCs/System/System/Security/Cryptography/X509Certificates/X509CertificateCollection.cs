namespace System.Security.Cryptography.X509Certificates;

[DefaultMember("Item")]
public class X509CertificateCollection : CollectionBase
{
	internal class X509CertificateEnumerator : IEnumerator
	{
		private IEnumerator enumerator; //Field offset: 0x10

		public X509Certificate Current
		{
			[CalledBy(Type = typeof(CertHelper), Member = "AddCertificatesToNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_x509list*), typeof(X509CertificateCollection), typeof(unitytls_errorstate*)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection)}, ReturnType = typeof(MonoBtlsX509Chain))]
			[CallerCount(Count = 2)]
			[CallsUnknownMethods(Count = 3)]
			 get { } //Length: 149
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			private get { } //Length: 73
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		public X509CertificateEnumerator(X509CertificateCollection mappings) { }

		[CalledBy(Type = typeof(CertHelper), Member = "AddCertificatesToNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_x509list*), typeof(X509CertificateCollection), typeof(unitytls_errorstate*)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection)}, ReturnType = typeof(MonoBtlsX509Chain))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		public X509Certificate get_Current() { }

		[CalledBy(Type = typeof(CertHelper), Member = "AddCertificatesToNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_x509list*), typeof(X509CertificateCollection), typeof(unitytls_errorstate*)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection)}, ReturnType = typeof(MonoBtlsX509Chain))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private override object System.Collections.IEnumerator.get_Current() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private override bool System.Collections.IEnumerator.MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private override void System.Collections.IEnumerator.Reset() { }

	}


	public X509Certificate Item
	{
		[CalledBy(Type = typeof(ChainValidationHelper), Member = "DefaultSelectionCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(X509CertificateCollection), typeof(X509Certificate), typeof(String[])}, ReturnType = typeof(X509Certificate))]
		[CalledBy(Type = typeof(MobileTlsContext), Member = "SelectClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(X509Certificate))]
		[CalledBy(Type = typeof(MonoBtlsX509LookupMonoCollection), Member = "Initialize", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 149
	}

	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public X509CertificateCollection() { }

	[CalledBy(Type = typeof(MonoTlsSettings), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoTlsSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public X509CertificateCollection(X509CertificateCollection value) { }

	[CalledBy(Type = typeof(MobileTlsContext), Member = "SelectServerCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(X509Certificate))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public int Add(X509Certificate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public void AddRange(X509CertificateCollection value) { }

	[CalledBy(Type = typeof(ChainValidationHelper), Member = "DefaultSelectionCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(X509CertificateCollection), typeof(X509Certificate), typeof(String[])}, ReturnType = typeof(X509Certificate))]
	[CalledBy(Type = typeof(MobileTlsContext), Member = "SelectClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(X509Certificate))]
	[CalledBy(Type = typeof(MonoBtlsX509LookupMonoCollection), Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public X509Certificate get_Item(int index) { }

	[CalledBy(Type = typeof(CertHelper), Member = "AddCertificatesToNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_x509list*), typeof(X509CertificateCollection), typeof(unitytls_errorstate*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection)}, ReturnType = typeof(MonoBtlsX509Chain))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public X509CertificateEnumerator GetEnumerator() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

}

