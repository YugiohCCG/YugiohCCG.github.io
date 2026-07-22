namespace System.Net.Configuration;

[ConfigurationCollection(typeof(ConnectionManagementElement))]
[DefaultMember("Item")]
public sealed class ConnectionManagementElementCollection : ConfigurationElementCollection
{

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public ConnectionManagementElementCollection() { }

}

