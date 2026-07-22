namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
public class LicensingErrorAnalytic : AnalyticsEventBase
{
	public string licensingErrorType; //Field offset: 0x30
	public string additionalData; //Field offset: 0x38
	public string errorMessage; //Field offset: 0x40
	public string correlationId; //Field offset: 0x48
	public string sessionId; //Field offset: 0x50

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	public LicensingErrorAnalytic() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	[RequiredByNativeCode]
	internal static LicensingErrorAnalytic CreateLicensingErrorAnalytic() { }

}

