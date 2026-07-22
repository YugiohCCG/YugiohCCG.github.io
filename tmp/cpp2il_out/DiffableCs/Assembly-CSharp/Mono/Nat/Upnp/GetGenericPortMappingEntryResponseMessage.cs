namespace Mono.Nat.Upnp;

internal class GetGenericPortMappingEntryResponseMessage : ResponseMessage
{
	[CompilerGenerated]
	private readonly bool <Enabled>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly int <ExternalPort>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private readonly string <InternalClient>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly int <InternalPort>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly int <LeaseDuration>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private readonly string <PortMappingDescription>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly Protocol <Protocol>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly string <RemoteHost>k__BackingField; //Field offset: 0x38

	public bool Enabled
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public int ExternalPort
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public string InternalClient
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public int InternalPort
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int LeaseDuration
	{
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public string PortMappingDescription
	{
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public Protocol Protocol
	{
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public string RemoteHost
	{
		[CallerCount(Count = 38)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(ResponseMessage), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpnpNatDevice), typeof(string)}, ReturnType = typeof(ResponseMessage))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 4)]
	public GetGenericPortMappingEntryResponseMessage(XmlNode data) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_Enabled() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_ExternalPort() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_InternalClient() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_InternalPort() { }

	[CallerCount(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_LeaseDuration() { }

	[CallerCount(Count = 15)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_PortMappingDescription() { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Protocol get_Protocol() { }

	[CallerCount(Count = 38)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_RemoteHost() { }

}

