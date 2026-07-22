namespace System.Net.NetworkInformation;

internal struct Win32_IP_ADAPTER_GATEWAY_ADDRESS
{
	public Win32LengthFlagsUnion LengthFlags; //Field offset: 0x0
	public IntPtr Next; //Field offset: 0x8
	public Win32_SOCKET_ADDRESS Address; //Field offset: 0x10

}

