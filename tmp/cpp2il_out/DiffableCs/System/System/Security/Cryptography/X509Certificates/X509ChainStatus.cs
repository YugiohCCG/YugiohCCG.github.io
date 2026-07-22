namespace System.Security.Cryptography.X509Certificates;

public struct X509ChainStatus
{
	private X509ChainStatusFlags status; //Field offset: 0x0
	private string info; //Field offset: 0x8

	public X509ChainStatusFlags Status
	{
		[CallerCount(Count = 173)]
		[DeduplicatedMethod]
		 get { } //Length: 3
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	public string StatusInformation
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CalledBy(Type = typeof(X509ChainImplUnityTls), Member = "AddStatus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainStatusFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509ChainImplBtls), Member = "AddStatus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainStatusFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(X509ChainStatus), Member = "GetInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainStatusFlags)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	internal X509ChainStatus(X509ChainStatusFlags flag) { }

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	public X509ChainStatusFlags get_Status() { }

	[CalledBy(Type = typeof(X509ChainElement), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainStatus[]), typeof(Int32&), typeof(X509ChainStatusFlags), typeof(X509ChainStatusFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509ChainElement), Member = "UncompressFlags", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(X509ChainStatus), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainStatusFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static string GetInformation(X509ChainStatusFlags flags) { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public void set_Status(X509ChainStatusFlags value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_StatusInformation(string value) { }

}

