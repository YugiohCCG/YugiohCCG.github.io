namespace System.Security.Cryptography.X509Certificates;

public class X509ChainElement
{
	private X509Certificate2 certificate; //Field offset: 0x10
	private X509ChainStatus[] status; //Field offset: 0x18
	private string info; //Field offset: 0x20
	private X509ChainStatusFlags compressed_status_flags; //Field offset: 0x28

	public X509Certificate2 Certificate
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public X509ChainStatus[] ChainElementStatus
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	internal X509ChainStatusFlags StatusFlags
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal X509ChainElement(X509Certificate2 certificate) { }

	[CallerCount(Count = 0)]
	private int Count(X509ChainStatusFlags flags) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public X509Certificate2 get_Certificate() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public X509ChainStatus[] get_ChainElementStatus() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal X509ChainStatusFlags get_StatusFlags() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509ChainStatus), Member = "GetInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainStatusFlags)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	private void Set(X509ChainStatus[] status, ref int position, X509ChainStatusFlags flags, X509ChainStatusFlags mask) { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	internal void set_StatusFlags(X509ChainStatusFlags value) { }

	[CalledBy(Type = typeof(X509ChainImplMono), Member = "ValidateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainStatusFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "WrapUp", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(X509ChainStatus), Member = "GetInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainStatusFlags)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallsUnknownMethods(Count = 26)]
	internal void UncompressFlags() { }

}

