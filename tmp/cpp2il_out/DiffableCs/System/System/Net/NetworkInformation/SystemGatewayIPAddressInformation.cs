namespace System.Net.NetworkInformation;

internal class SystemGatewayIPAddressInformation : GatewayIPAddressInformation
{
	private IPAddress address; //Field offset: 0x10

	public virtual IPAddress Address
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal SystemGatewayIPAddressInformation(IPAddress address) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public virtual IPAddress get_Address() { }

}

