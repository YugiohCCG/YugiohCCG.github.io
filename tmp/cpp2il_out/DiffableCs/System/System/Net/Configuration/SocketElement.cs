namespace System.Net.Configuration;

public sealed class SocketElement : ConfigurationElement
{

	protected virtual ConfigurationPropertyCollection Properties
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 44
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public SocketElement() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual ConfigurationPropertyCollection get_Properties() { }

}

