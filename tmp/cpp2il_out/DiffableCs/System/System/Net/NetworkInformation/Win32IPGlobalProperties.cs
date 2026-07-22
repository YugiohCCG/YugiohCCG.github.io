namespace System.Net.NetworkInformation;

internal class Win32IPGlobalProperties : IPGlobalProperties
{

	public virtual string DomainName
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Win32NetworkInterface), Member = "get_FixedInfo", ReturnType = typeof(Win32_FIXED_INFO))]
		 get { } //Length: 31
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Win32IPGlobalProperties() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Win32NetworkInterface), Member = "get_FixedInfo", ReturnType = typeof(Win32_FIXED_INFO))]
	public virtual string get_DomainName() { }

}

