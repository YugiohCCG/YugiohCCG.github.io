namespace Newtonsoft.Json.Linq.JsonPath;

[Nullable(0)]
[NullableContext(2)]
internal abstract class PathFilter
{

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected PathFilter() { }

	[NullableContext(1)]
	public abstract IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }

	[CalledBy(Type = "Newtonsoft.Json.Linq.JsonPath.ScanFilter+<ExecuteFilter>d__2", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JsonPath.ScanMultipleFilter+<ExecuteFilter>d__2", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	protected static JToken GetNextScanValue(JToken originalParent, JToken container, JToken value) { }

	[CalledBy(Type = "Newtonsoft.Json.Linq.JsonPath.ArrayIndexFilter+<ExecuteFilter>d__4", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JsonPath.ArrayMultipleIndexFilter+<ExecuteFilter>d__2", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JContainer), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 21)]
	protected static JToken GetTokenIndex(JToken t, JsonSelectSettings settings, int index) { }

}

