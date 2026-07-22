namespace UnityEngine.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
public class VRDeviceActiveControllersAnalytic : VRDeviceAnalyticBase
{
	public String[] vr_active_controllers; //Field offset: 0x30

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public VRDeviceActiveControllersAnalytic() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	[RequiredByNativeCode]
	internal static VRDeviceActiveControllersAnalytic CreateVRDeviceActiveControllersAnalytic() { }

}

