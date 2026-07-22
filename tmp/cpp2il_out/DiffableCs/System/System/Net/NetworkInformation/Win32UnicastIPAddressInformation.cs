namespace System.Net.NetworkInformation;

internal class Win32UnicastIPAddressInformation : UnicastIPAddressInformation
{
	private Win32_IP_ADAPTER_UNICAST_ADDRESS info; //Field offset: 0x10
	private IPAddress ipv4Mask; //Field offset: 0x50

	public virtual IPAddress Address
	{
		[CallerCount(Count = 0)]
		[ContainsInvalidInstructions]
		 get { } //Length: 11
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Win32_SOCKET_ADDRESS), Member = "GetIPAddress", ReturnType = typeof(IPAddress))]
	[Calls(Type = typeof(IPAddress), Member = "get_AddressFamily", ReturnType = typeof(AddressFamily))]
	[Calls(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Win32UnicastIPAddressInformation(Win32_IP_ADAPTER_UNICAST_ADDRESS info) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	public virtual IPAddress get_Address() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static IPAddress PrefixLengthToSubnetMask(byte prefixLength, AddressFamily family) { }

}

