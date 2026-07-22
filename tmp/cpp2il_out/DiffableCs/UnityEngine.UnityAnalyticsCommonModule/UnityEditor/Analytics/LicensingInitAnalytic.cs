namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
public class LicensingInitAnalytic : AnalyticsEventBase
{
	public string licensingProtocolVersion; //Field offset: 0x30
	public string licensingClientVersion; //Field offset: 0x38
	public string channelType; //Field offset: 0x40
	public double initTime; //Field offset: 0x48
	public bool isLegacy; //Field offset: 0x50
	public string sessionId; //Field offset: 0x58
	public string correlationId; //Field offset: 0x60

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	public LicensingInitAnalytic() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	[RequiredByNativeCode]
	internal static LicensingInitAnalytic CreateLicensingInitAnalytic() { }

}

