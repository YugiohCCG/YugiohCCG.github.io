namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
internal class AssetImportAnalytic : AnalyticsEventBase
{
	public string package_name; //Field offset: 0x30
	public int package_import_choice; //Field offset: 0x38

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	public AssetImportAnalytic() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	[RequiredByNativeCode]
	public static AssetImportAnalytic CreateAssetImportAnalytic() { }

}

