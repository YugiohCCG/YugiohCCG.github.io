namespace Mono.Nat.Upnp;

internal sealed class GetSpecificPortMappingEntryMessage : RequestMessage
{
	[CompilerGenerated]
	private readonly int <ExternalPort>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly Protocol <Protocol>k__BackingField; //Field offset: 0x24

	private int ExternalPort
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 4
	}

	private Protocol Protocol
	{
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 4
	}

	[CalledBy(Type = "Mono.Nat.Upnp.UpnpNatDevice+<GetSpecificMappingAsync>d__19", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public GetSpecificPortMappingEntryMessage(Protocol protocol, int externalPort, UpnpNatDevice device) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Encode(XmlWriter writer) { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private int get_ExternalPort() { }

	[CallerCount(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private Protocol get_Protocol() { }

}

