namespace Newtonsoft.Json.Serialization;

public class JsonLinqContract : JsonContract
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonContract), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[NullableContext(1)]
	public JsonLinqContract(Type underlyingType) { }

}

