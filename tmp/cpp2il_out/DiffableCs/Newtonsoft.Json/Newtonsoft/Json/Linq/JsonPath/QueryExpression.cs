namespace Newtonsoft.Json.Linq.JsonPath;

[Nullable(0)]
[NullableContext(1)]
internal abstract class QueryExpression
{
	internal QueryOperator Operator; //Field offset: 0x10

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public QueryExpression(QueryOperator operator) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsMatch(JToken root, JToken t) { }

	public abstract bool IsMatch(JToken root, JToken t, JsonSelectSettings settings) { }

}

