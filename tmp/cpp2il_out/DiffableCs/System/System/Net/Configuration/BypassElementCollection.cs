namespace System.Net.Configuration;

[ConfigurationCollection(typeof(BypassElement))]
[DefaultMember("Item")]
public sealed class BypassElementCollection : ConfigurationElementCollection
{

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public BypassElementCollection() { }

}

