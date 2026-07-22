namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
public class PackageManagerResolvePackageAnalytic : PackageManagerBaseAnalytic
{
	public String[] packages; //Field offset: 0x60
	public String[] package_registries; //Field offset: 0x68
	public String[] package_signatures; //Field offset: 0x70
	public String[] package_sources; //Field offset: 0x78
	public String[] package_types; //Field offset: 0x80
	public String[] package_compliance_statuses; //Field offset: 0x88

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	public PackageManagerResolvePackageAnalytic() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	[RequiredByNativeCode]
	internal static PackageManagerResolvePackageAnalytic CreatePackageManagerResolvePackageAnalytic() { }

}

