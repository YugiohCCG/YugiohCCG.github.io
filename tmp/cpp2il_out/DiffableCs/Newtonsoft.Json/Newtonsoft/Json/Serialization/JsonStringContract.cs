namespace Newtonsoft.Json.Serialization;

public class JsonStringContract : JsonPrimitiveContract
{

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateStringContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonStringContract))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonPrimitiveContract), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[NullableContext(1)]
	public JsonStringContract(Type underlyingType) { }

}

