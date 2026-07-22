namespace Mono.Nat.Pmp;

internal abstract class PortMappingMessage
{
	[CompilerGenerated]
	private readonly bool <Create>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Mapping <Mapping>k__BackingField; //Field offset: 0x18

	private bool Create
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	public Mapping Mapping
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public PortMappingMessage(Mapping mapping, bool create) { }

	[CalledBy(Type = "Mono.Nat.Pmp.PmpNatDevice+<SendMessageAsync>d__12", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IPAddress), Member = "HostToNetworkOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(IPAddress), Member = "HostToNetworkOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public Byte[] Encode() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private bool get_Create() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Mapping get_Mapping() { }

}

