namespace System.Net.NetworkInformation;

public abstract class IPInterfaceProperties
{

	public abstract IPAddressCollection DnsAddresses
	{
		 get { } //Length: 0
	}

	public abstract GatewayIPAddressInformationCollection GatewayAddresses
	{
		 get { } //Length: 0
	}

	public abstract UnicastIPAddressInformationCollection UnicastAddresses
	{
		 get { } //Length: 0
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected IPInterfaceProperties() { }

	public abstract IPAddressCollection get_DnsAddresses() { }

	public abstract GatewayIPAddressInformationCollection get_GatewayAddresses() { }

	public abstract UnicastIPAddressInformationCollection get_UnicastAddresses() { }

}

