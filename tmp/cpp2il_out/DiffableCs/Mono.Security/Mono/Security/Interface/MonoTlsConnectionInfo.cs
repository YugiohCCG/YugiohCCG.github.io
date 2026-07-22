namespace Mono.Security.Interface;

public class MonoTlsConnectionInfo
{
	[CompilerGenerated]
	private CipherSuiteCode <CipherSuiteCode>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private TlsProtocols <ProtocolVersion>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private string <PeerDomainName>k__BackingField; //Field offset: 0x18

	[CLSCompliant(False)]
	public CipherSuiteCode CipherSuiteCode
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public string PeerDomainName
	{
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public TlsProtocols ProtocolVersion
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public MonoTlsConnectionInfo() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public CipherSuiteCode get_CipherSuiteCode() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public TlsProtocols get_ProtocolVersion() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_CipherSuiteCode(CipherSuiteCode value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_PeerDomainName(string value) { }

	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_ProtocolVersion(TlsProtocols value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

