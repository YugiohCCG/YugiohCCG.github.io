namespace Mono.Nat;

public class DeviceEventUnknownArgs : EventArgs
{
	[CompilerGenerated]
	private readonly IPAddress <Address>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <Data>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly EndPoint <EndPoint>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly NatProtocol <Protocol>k__BackingField; //Field offset: 0x28

	public IPAddress Address
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string Data
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public EndPoint EndPoint
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public NatProtocol Protocol
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal DeviceEventUnknownArgs(IPAddress address, EndPoint endPoint, string data, NatProtocol protocol) { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public IPAddress get_Address() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_Data() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public EndPoint get_EndPoint() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public NatProtocol get_Protocol() { }

}

