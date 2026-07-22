namespace Newtonsoft.Json.Linq;

public class JTokenEqualityComparer : IEqualityComparer<JToken>
{

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public JTokenEqualityComparer() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JToken), Member = "DeepEquals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken), typeof(JToken)}, ReturnType = typeof(bool))]
	[NullableContext(2)]
	public override bool Equals(JToken x, JToken y) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[NullableContext(1)]
	public override int GetHashCode(JToken obj) { }

}

