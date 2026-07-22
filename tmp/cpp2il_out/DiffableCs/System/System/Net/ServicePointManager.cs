namespace System.Net;

public class ServicePointManager
{
	public class SPKey
	{
		private Uri uri; //Field offset: 0x10
		private Uri proxy; //Field offset: 0x18
		private bool use_connect; //Field offset: 0x20

		public bool UsesProxy
		{
			[CalledBy(Type = typeof(SPKey), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
			[CallerCount(Count = 3)]
			[Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
			 get { } //Length: 80
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public SPKey(Uri uri, Uri proxy, bool use_connect) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SPKey), Member = "get_UsesProxy", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public virtual bool Equals(object obj) { }

		[CalledBy(Type = typeof(SPKey), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
		public bool get_UsesProxy() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public virtual int GetHashCode() { }

	}

	private static ConcurrentDictionary<SPKey, ServicePoint> servicePoints; //Field offset: 0x0
	private static ICertificatePolicy policy; //Field offset: 0x8
	private static int defaultConnectionLimit; //Field offset: 0x10
	private static int maxServicePointIdleTime; //Field offset: 0x14
	private static int maxServicePoints; //Field offset: 0x18
	private static int dnsRefreshTimeout; //Field offset: 0x1C
	private static bool _checkCRL; //Field offset: 0x20
	private static SecurityProtocolType _securityProtocol; //Field offset: 0x24
	private static bool expectContinue; //Field offset: 0x28
	private static bool useNagle; //Field offset: 0x29
	private static ServerCertValidationCallback server_cert_cb; //Field offset: 0x30
	private static bool tcp_keepalive; //Field offset: 0x38
	private static int tcp_keepalive_time; //Field offset: 0x3C
	private static int tcp_keepalive_interval; //Field offset: 0x40

	[MonoTODO("CRL checks not implemented")]
	public static bool CheckCertificateRevocationList
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	public static int DnsRefreshTimeout
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 78
	}

	public static SecurityProtocolType SecurityProtocol
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 78
	}

	public static RemoteCertificateValidationCallback ServerCertificateValidationCallback
	{
		[CalledBy(Type = typeof(TlsStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkStream), typeof(Socket), typeof(string), typeof(X509CertificateCollection)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 132
	}

	internal static ServerCertValidationCallback ServerCertValidationCallback
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 79
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static ServicePointManager() { }

	[CalledBy(Type = typeof(HttpWebRequest), Member = "GetServicePoint", ReturnType = typeof(ServicePoint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = "GetOrAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ServicePointScheduler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ServicePoint), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "get_Authority", ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 40)]
	public static ServicePoint FindServicePoint(Uri address, IWebProxy proxy) { }

	[CallerCount(Count = 0)]
	public static bool get_CheckCertificateRevocationList() { }

	[CallerCount(Count = 0)]
	public static int get_DnsRefreshTimeout() { }

	[CallerCount(Count = 0)]
	public static SecurityProtocolType get_SecurityProtocol() { }

	[CalledBy(Type = typeof(TlsStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkStream), typeof(Socket), typeof(string), typeof(X509CertificateCollection)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static RemoteCertificateValidationCallback get_ServerCertificateValidationCallback() { }

	[CallerCount(Count = 0)]
	internal static ServerCertValidationCallback get_ServerCertValidationCallback() { }

	[CallerCount(Count = 0)]
	internal static ICertificatePolicy GetLegacyCertificatePolicy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = "TryRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal static void RemoveServicePoint(ServicePoint sp) { }

}

