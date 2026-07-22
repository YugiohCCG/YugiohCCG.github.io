namespace System.Net.NetworkInformation;

public abstract class IPAddressInformation
{

	public abstract IPAddress Address
	{
		 get { } //Length: 0
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected IPAddressInformation() { }

	public abstract IPAddress get_Address() { }

}

