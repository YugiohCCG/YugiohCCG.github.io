namespace System.Net.Configuration;

[ConfigurationCollection(typeof(WebRequestModuleElement))]
[DefaultMember("Item")]
public sealed class WebRequestModuleElementCollection : ConfigurationElementCollection
{

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public WebRequestModuleElementCollection() { }

}

