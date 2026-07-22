namespace Mono.Nat.Upnp;

internal class GetSpecificPortMappingEntryResponseMessage : ResponseMessage
{
	[CompilerGenerated]
	private readonly bool <Enabled>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <InternalClient>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly int <InternalPort>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly int <LeaseDuration>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private readonly string <PortMappingDescription>k__BackingField; //Field offset: 0x28

	public bool Enabled
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
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

	[CalledBy(Type = typeof(ResponseMessage), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpnpNatDevice), typeof(string)}, ReturnType = typeof(ResponseMessage))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 3)]
	public GetSpecificPortMappingEntryResponseMessage(XmlNode data) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_Enabled() { }

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

}

