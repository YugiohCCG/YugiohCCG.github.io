namespace System.Net.Configuration;

public sealed class Ipv6Element : ConfigurationElement
{

	protected virtual ConfigurationPropertyCollection Properties
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 44
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public Ipv6Element() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual ConfigurationPropertyCollection get_Properties() { }

}

