namespace System.Net.NetworkInformation;

internal sealed class Win32NetworkInterface2 : NetworkInterface
{
	private Win32_IP_ADAPTER_ADDRESSES addr; //Field offset: 0x10
	private Win32_MIB_IFROW mib4; //Field offset: 0x118
	private Win32_MIB_IFROW mib6; //Field offset: 0x188
	private Win32IPv4InterfaceStatistics ip4stats; //Field offset: 0x1F8
	private IPInterfaceProperties ip_if_props; //Field offset: 0x200

	public virtual OperationalStatus OperationalStatus
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = typeof(Win32NetworkInterfaceAPI), Member = "GetAllNetworkInterfaces", ReturnType = typeof(NetworkInterface[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Win32NetworkInterface2), Member = "GetIfEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Win32_MIB_IFROW&)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	internal Win32NetworkInterface2(Win32_IP_ADAPTER_ADDRESSES addr) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual OperationalStatus get_OperationalStatus() { }

	[CalledBy(Type = typeof(Win32NetworkInterface2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Win32_IP_ADAPTER_ADDRESSES)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private static int GetIfEntry(ref Win32_MIB_IFROW row) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual IPInterfaceProperties GetIPProperties() { }

}

