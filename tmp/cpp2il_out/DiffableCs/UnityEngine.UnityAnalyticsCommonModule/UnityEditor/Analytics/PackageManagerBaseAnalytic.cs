namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
public class PackageManagerBaseAnalytic : AnalyticsEventBase
{
	public long start_ts; //Field offset: 0x30
	public long duration; //Field offset: 0x38
	public bool blocking; //Field offset: 0x40
	public string package_id; //Field offset: 0x48
	public int status_code; //Field offset: 0x50
	public string error_message; //Field offset: 0x58

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	public PackageManagerBaseAnalytic(string eventName) { }

}

