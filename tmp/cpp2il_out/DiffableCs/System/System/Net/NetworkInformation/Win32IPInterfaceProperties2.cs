namespace System.Net.NetworkInformation;

internal class Win32IPInterfaceProperties2 : IPInterfaceProperties
{
	private readonly Win32_IP_ADAPTER_ADDRESSES addr; //Field offset: 0x10
	private readonly Win32_MIB_IFROW mib4; //Field offset: 0x118
	private readonly Win32_MIB_IFROW mib6; //Field offset: 0x188

	public virtual IPAddressCollection DnsAddresses
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(IPAddressCollection), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(Win32_SOCKET_ADDRESS), Member = "GetIPAddress", ReturnType = typeof(IPAddress))]
		[Calls(Type = typeof(System.Collections.ObjectModel.Collection`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 439
	}

	public virtual GatewayIPAddressInformationCollection GatewayAddresses
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Collection`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(Win32_SOCKET_ADDRESS), Member = "GetIPAddress", ReturnType = typeof(IPAddress))]
		[Calls(Type = typeof(System.Collections.ObjectModel.Collection`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 553
	}

	public virtual UnicastIPAddressInformationCollection UnicastAddresses
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Win32IPInterfaceProperties2), Member = "Win32FromUnicast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(UnicastIPAddressInformationCollection))]
		[Calls(Type = typeof(UnicastIPAddressInformationCollection), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 64
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Win32IPInterfaceProperties2(Win32_IP_ADAPTER_ADDRESSES addr, Win32_MIB_IFROW mib4, Win32_MIB_IFROW mib6) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IPAddressCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Win32_SOCKET_ADDRESS), Member = "GetIPAddress", ReturnType = typeof(IPAddress))]
	[Calls(Type = typeof(System.Collections.ObjectModel.Collection`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual IPAddressCollection get_DnsAddresses() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Collection`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Win32_SOCKET_ADDRESS), Member = "GetIPAddress", ReturnType = typeof(IPAddress))]
	[Calls(Type = typeof(System.Collections.ObjectModel.Collection`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	public virtual GatewayIPAddressInformationCollection get_GatewayAddresses() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Win32IPInterfaceProperties2), Member = "Win32FromUnicast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(UnicastIPAddressInformationCollection))]
	[Calls(Type = typeof(UnicastIPAddressInformationCollection), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual UnicastIPAddressInformationCollection get_UnicastAddresses() { }

	[CalledBy(Type = typeof(Win32IPInterfaceProperties2), Member = "get_UnicastAddresses", ReturnType = typeof(UnicastIPAddressInformationCollection))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnicastIPAddressInformationCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Win32_SOCKET_ADDRESS), Member = "GetIPAddress", ReturnType = typeof(IPAddress))]
	[Calls(Type = typeof(IPAddress), Member = "get_AddressFamily", ReturnType = typeof(AddressFamily))]
	[Calls(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.ObjectModel.Collection`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private static UnicastIPAddressInformationCollection Win32FromUnicast(IntPtr ptr) { }

}

