namespace Newtonsoft.Json.Serialization;

public class CamelCaseNamingStrategy : NamingStrategy
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public CamelCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public CamelCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) { }

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public CamelCaseNamingStrategy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringUtils), Member = "ToCamelCase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[NullableContext(1)]
	protected virtual string ResolvePropertyName(string name) { }

}

