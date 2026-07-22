namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
public class JsonException : Exception
{

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Exception), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public JsonException() { }

	[CallerCount(Count = 90)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public JsonException(string message) { }

	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public JsonException(string message, Exception innerException) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public JsonException(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = typeof(JsonSchemaBuilder), Member = "BuildSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(JsonSchema))]
	[CalledBy(Type = typeof(JsonSchemaBuilder), Member = "ProcessEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSchemaBuilder), Member = "ProcessProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(System.Collections.Generic.IDictionary`2<System.String, Newtonsoft.Json.Schema.JsonSchema>))]
	[CalledBy(Type = typeof(JsonSchemaBuilder), Member = "ProcessItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSchemaBuilder), Member = "ProcessType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(System.Nullable`1<Newtonsoft.Json.Schema.JsonSchemaType>))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(JsonPosition), Member = "FormatMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IJsonLineInfo), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static JsonException Create(IJsonLineInfo lineInfo, string path, string message) { }

}

