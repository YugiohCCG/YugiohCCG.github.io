namespace UnityEngine.Analytics;

[RequiredByNativeCode(GenerateProxy = True)]
internal class UaaLApplicationLaunchAnalytic : AnalyticsEventBase
{
	public int launch_type; //Field offset: 0x30
	public int launch_process_type; //Field offset: 0x34

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public UaaLApplicationLaunchAnalytic() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[RequiredByNativeCode]
	public static UaaLApplicationLaunchAnalytic CreateUaaLApplicationLaunchAnalytic() { }

}

