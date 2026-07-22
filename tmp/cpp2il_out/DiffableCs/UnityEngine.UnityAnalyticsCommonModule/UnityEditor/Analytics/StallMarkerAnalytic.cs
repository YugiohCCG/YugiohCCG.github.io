namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
internal class StallMarkerAnalytic : AnalyticsEventBase
{
	public string Name; //Field offset: 0x30
	public bool HasProgressMarkup; //Field offset: 0x38
	public double Duration; //Field offset: 0x40

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	public StallMarkerAnalytic() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	[RequiredByNativeCode]
	internal static StallMarkerAnalytic CreateStallMarkerAnalytic() { }

}

