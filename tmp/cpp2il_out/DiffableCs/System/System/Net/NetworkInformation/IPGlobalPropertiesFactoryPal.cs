namespace System.Net.NetworkInformation;

internal static class IPGlobalPropertiesFactoryPal
{

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public static IPGlobalProperties Create() { }

}

