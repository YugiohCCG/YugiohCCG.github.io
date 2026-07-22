namespace Mono.Nat.Upnp;

internal class GetGenericPortMappingEntry : RequestMessage
{
	[CompilerGenerated]
	private readonly int <Index>k__BackingField; //Field offset: 0x20

	private int Index
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 4
	}

	[CalledBy(Type = "Mono.Nat.Upnp.UpnpNatDevice+<GetAllMappingsAsync>d__17", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public GetGenericPortMappingEntry(int index, UpnpNatDevice device) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Encode(XmlWriter writer) { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private int get_Index() { }

}

