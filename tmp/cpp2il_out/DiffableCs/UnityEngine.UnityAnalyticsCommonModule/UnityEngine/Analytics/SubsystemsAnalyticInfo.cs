namespace UnityEngine.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
public class SubsystemsAnalyticInfo : SubsystemsAnalyticBase
{
	private string id; //Field offset: 0x38
	private string plugin_name; //Field offset: 0x40
	private string version; //Field offset: 0x48
	private string library_name; //Field offset: 0x50

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	public SubsystemsAnalyticInfo() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	[RequiredByNativeCode]
	internal static SubsystemsAnalyticInfo CreateSubsystemsAnalyticInfo() { }

}

