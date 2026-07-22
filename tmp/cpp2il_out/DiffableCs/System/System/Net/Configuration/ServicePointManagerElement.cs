namespace System.Net.Configuration;

public sealed class ServicePointManagerElement : ConfigurationElement
{

	protected virtual ConfigurationPropertyCollection Properties
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 44
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public ServicePointManagerElement() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual ConfigurationPropertyCollection get_Properties() { }

}

