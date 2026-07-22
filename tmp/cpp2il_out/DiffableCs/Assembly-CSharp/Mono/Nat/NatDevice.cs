namespace Mono.Nat;

internal abstract class NatDevice : INatDevice
{
	[CompilerGenerated]
	private DateTime <LastSeen>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly IPEndPoint <DeviceEndpoint>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly NatProtocol <NatProtocol>k__BackingField; //Field offset: 0x20

	public override IPEndPoint DeviceEndpoint
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public internal override DateTime LastSeen
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 5
	}

	public override NatProtocol NatProtocol
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = typeof(UpnpNatDevice), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(IPEndPoint), typeof(Uri), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PmpNatDevice), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPEndPoint), typeof(IPAddress)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PmpSearcher), Member = "HandleMessageReceived", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(Byte[]), typeof(IPEndPoint), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected NatDevice(IPEndPoint deviceEndpoint, NatProtocol natProtocol) { }

	public abstract Task<Mapping> CreatePortMapAsync(Mapping mapping) { }

	public abstract Task<Mapping> DeletePortMapAsync(Mapping mapping) { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override IPEndPoint get_DeviceEndpoint() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override DateTime get_LastSeen() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override NatProtocol get_NatProtocol() { }

	public abstract Task<Mapping[]> GetAllMappingsAsync() { }

	public abstract Task<IPAddress> GetExternalIPAsync() { }

	public abstract Task<Mapping> GetSpecificMappingAsync(Protocol protocol, int publicPort) { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_LastSeen(DateTime value) { }

}

