namespace System.Net.NetworkInformation;

public abstract class NetworkInterface
{

	public override OperationalStatus OperationalStatus
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 62
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected NetworkInterface() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override OperationalStatus get_OperationalStatus() { }

	[CalledBy(Type = "Mono.Nat.Upnp.UpnpSearcher", Member = "Create", ReturnType = "Mono.Nat.Upnp.UpnpSearcher")]
	[CalledBy(Type = "Mono.Nat.Pmp.PmpSearcher", Member = "Create", ReturnType = "Mono.Nat.Pmp.PmpSearcher")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SystemNetworkInterface), Member = "GetNetworkInterfaces", ReturnType = typeof(NetworkInterface[]))]
	public static NetworkInterface[] GetAllNetworkInterfaces() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override IPInterfaceProperties GetIPProperties() { }

}

