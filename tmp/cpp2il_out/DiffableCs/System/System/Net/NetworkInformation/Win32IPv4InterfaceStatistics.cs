namespace System.Net.NetworkInformation;

internal class Win32IPv4InterfaceStatistics : IPv4InterfaceStatistics
{
	private Win32_MIB_IFROW info; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Win32IPv4InterfaceStatistics(Win32_MIB_IFROW info) { }

}

