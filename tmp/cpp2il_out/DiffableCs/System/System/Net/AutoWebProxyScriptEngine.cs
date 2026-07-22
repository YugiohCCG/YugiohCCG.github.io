namespace System.Net;

internal class AutoWebProxyScriptEngine
{

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public bool GetProxies(Uri destination, out IList<String>& proxyList) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public bool GetProxies(Uri destination, out IList<String>& proxyList, ref int syncStatus) { }

}

