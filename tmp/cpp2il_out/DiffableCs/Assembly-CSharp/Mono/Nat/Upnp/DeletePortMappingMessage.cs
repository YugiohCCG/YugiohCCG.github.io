namespace Mono.Nat.Upnp;

internal sealed class DeletePortMappingMessage : RequestMessage
{
	[CompilerGenerated]
	private readonly Mapping <Mapping>k__BackingField; //Field offset: 0x20

	private Mapping Mapping
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	[CalledBy(Type = "Mono.Nat.Upnp.UpnpNatDevice+<DeletePortMapAsync>d__16", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public DeletePortMappingMessage(Mapping mapping, UpnpNatDevice device) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Encode(XmlWriter writer) { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private Mapping get_Mapping() { }

}

