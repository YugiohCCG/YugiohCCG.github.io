namespace System.Net;

internal class ServiceNameStore
{
	private List<String> serviceNames; //Field offset: 0x10
	private ServiceNameCollection serviceNameCollection; //Field offset: 0x18

	[CalledBy(Type = typeof(HttpListener), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public ServiceNameStore() { }

}

