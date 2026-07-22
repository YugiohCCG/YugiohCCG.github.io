namespace System.Net.Configuration;

public sealed class HttpWebRequestElement : ConfigurationElement
{

	protected virtual ConfigurationPropertyCollection Properties
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 44
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public HttpWebRequestElement() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual ConfigurationPropertyCollection get_Properties() { }

}

