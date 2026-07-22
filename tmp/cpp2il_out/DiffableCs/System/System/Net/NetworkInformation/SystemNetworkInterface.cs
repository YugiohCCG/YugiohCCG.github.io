namespace System.Net.NetworkInformation;

internal static class SystemNetworkInterface
{
	private static readonly NetworkInterfaceFactory nif; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Version), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "get_OSVersion", ReturnType = typeof(OperatingSystem))]
	[Calls(Type = typeof(Version), Member = "op_GreaterThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version), typeof(Version)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private static SystemNetworkInterface() { }

	[CalledBy(Type = typeof(NetworkInterface), Member = "GetAllNetworkInterfaces", ReturnType = typeof(NetworkInterface[]))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static NetworkInterface[] GetNetworkInterfaces() { }

}

