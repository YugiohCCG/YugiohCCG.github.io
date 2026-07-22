namespace System.Net.NetworkInformation;

internal struct Win32_IP_ADAPTER_UNICAST_ADDRESS
{
	public Win32LengthFlagsUnion LengthFlags; //Field offset: 0x0
	public IntPtr Next; //Field offset: 0x8
	public Win32_SOCKET_ADDRESS Address; //Field offset: 0x10
	public PrefixOrigin PrefixOrigin; //Field offset: 0x20
	public SuffixOrigin SuffixOrigin; //Field offset: 0x24
	public DuplicateAddressDetectionState DadState; //Field offset: 0x28
	public uint ValidLifetime; //Field offset: 0x2C
	public uint PreferredLifetime; //Field offset: 0x30
	public uint LeaseLifetime; //Field offset: 0x34
	public byte OnLinkPrefixLength; //Field offset: 0x38

}

