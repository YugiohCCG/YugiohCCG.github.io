namespace System.Net.NetworkInformation;

internal class Win32NetworkInterfaceAPI : NetworkInterfaceFactory
{

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Win32NetworkInterfaceAPI() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private static int GetAdaptersAddresses(uint family, uint flags, IntPtr reserved, IntPtr info, ref int size) { }

	[CalledBy(Type = typeof(Win32NetworkInterfaceAPI), Member = "GetAllNetworkInterfaces", ReturnType = typeof(NetworkInterface[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Marshal), Member = "SizeOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Win32_IP_ADAPTER_ADDRESSES)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(Win32_IP_ADAPTER_ADDRESSES))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Net.NetworkInformation.Win32_IP_ADAPTER_ADDRESSES>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Win32_IP_ADAPTER_ADDRESSES)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(NetworkInformationException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	private static Win32_IP_ADAPTER_ADDRESSES[] GetAdaptersAddresses() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Win32NetworkInterfaceAPI), Member = "GetAdaptersAddresses", ReturnType = typeof(Win32_IP_ADAPTER_ADDRESSES[]))]
	[Calls(Type = typeof(Win32NetworkInterface2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Win32_IP_ADAPTER_ADDRESSES)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public virtual NetworkInterface[] GetAllNetworkInterfaces() { }

}

