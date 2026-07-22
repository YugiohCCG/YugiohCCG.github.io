namespace Newtonsoft.Json.Bson.Converters;

public class BsonDataObjectIdConverter : JsonConverter
{

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public BsonDataObjectIdConverter() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual bool CanConvert(Type objectType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 21)]
	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "SetWriteState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BsonDataWriter), Member = "AddToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionUtils), Member = "CreateJsonWriterException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonWriterException))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

