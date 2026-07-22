namespace Newtonsoft.Json.Serialization;

public class KebabCaseNamingStrategy : NamingStrategy
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public KebabCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public KebabCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public KebabCaseNamingStrategy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringUtils), Member = "ToKebabCase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[NullableContext(1)]
	protected virtual string ResolvePropertyName(string name) { }

}

