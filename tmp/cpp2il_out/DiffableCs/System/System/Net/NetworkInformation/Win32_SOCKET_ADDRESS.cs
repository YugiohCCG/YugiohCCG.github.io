namespace System.Net.NetworkInformation;

internal struct Win32_SOCKET_ADDRESS
{
	public IntPtr Sockaddr; //Field offset: 0x0
	public int SockaddrLength; //Field offset: 0x8

	[CalledBy(Type = typeof(Win32IPAddressCollection), Member = "FromDnsServer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(Win32IPAddressCollection))]
	[CalledBy(Type = typeof(Win32IPInterfaceProperties2), Member = "get_DnsAddresses", ReturnType = typeof(IPAddressCollection))]
	[CalledBy(Type = typeof(Win32IPInterfaceProperties2), Member = "get_GatewayAddresses", ReturnType = typeof(GatewayIPAddressInformationCollection))]
	[CalledBy(Type = typeof(Win32IPInterfaceProperties2), Member = "Win32FromUnicast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(UnicastIPAddressInformationCollection))]
	[CalledBy(Type = typeof(Win32UnicastIPAddressInformation), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Win32_IP_ADAPTER_UNICAST_ADDRESS)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public IPAddress GetIPAddress() { }

}

