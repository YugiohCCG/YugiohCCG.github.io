namespace System.Net.NetworkInformation;

public abstract class GatewayIPAddressInformation
{

	public abstract IPAddress Address
	{
		 get { } //Length: 0
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected GatewayIPAddressInformation() { }

	public abstract IPAddress get_Address() { }

}

