namespace Mono.Nat.Upnp;

internal sealed class CreatePortMappingMessage : RequestMessage
{
	[CompilerGenerated]
	private readonly IPAddress <LocalIpAddress>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly Mapping <Mapping>k__BackingField; //Field offset: 0x28

	private IPAddress LocalIpAddress
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	private Mapping Mapping
	{
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	[CalledBy(Type = "Mono.Nat.Upnp.UpnpNatDevice+<CreatePortMapAsync>d__15", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public CreatePortMappingMessage(Mapping mapping, IPAddress localIpAddress, UpnpNatDevice device) { }

	[CalledBy(Type = typeof(CreatePortMappingMessage), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Process), Member = "GetCurrentProcess", ReturnType = typeof(Process))]
	[Calls(Type = typeof(Process), Member = "get_ProcessName", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 23)]
	internal static string CreateDefaultDescription(Mapping mapping) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CreatePortMappingMessage), Member = "CreateDefaultDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mapping)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Encode(XmlWriter writer) { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private IPAddress get_LocalIpAddress() { }

	[CallerCount(Count = 15)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private Mapping get_Mapping() { }

}

