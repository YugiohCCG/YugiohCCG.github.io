namespace System.Net.Sockets;

public class MulticastOption
{
	private IPAddress group; //Field offset: 0x10
	private IPAddress localAddress; //Field offset: 0x18
	private int ifIndex; //Field offset: 0x20

	public IPAddress Group
	{
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public IPAddress LocalAddress
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 20
	}

	[CalledBy(Type = "Mono.Nat.Upnp.UpnpSearcher", Member = "Create", ReturnType = "Mono.Nat.Upnp.UpnpSearcher")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public MulticastOption(IPAddress group, IPAddress mcint) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Group(IPAddress value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void set_LocalAddress(IPAddress value) { }

}

