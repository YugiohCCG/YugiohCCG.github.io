namespace Newtonsoft.Json.Bson.Converters;

public class BsonDataRegexConverter : JsonConverter
{
	private const string PatternName = "Pattern"; //Field offset: 0x0
	private const string OptionsName = "Options"; //Field offset: 0x0

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public BsonDataRegexConverter() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual bool CanConvert(Type objectType) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool HasFlag(RegexOptions options, RegexOptions flag) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionUtils), Member = "CreateJsonSerializationException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IJsonLineInfo), typeof(string), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonSerializationException))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsInvalidInstructions]
	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonReader), Member = "Skip", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSerializer), Member = "Deserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = "T")]
	[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionUtils), Member = "CreateJsonSerializationException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IJsonLineInfo), typeof(string), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonSerializationException))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 23)]
	private Regex ReadRegexObject(JsonReader reader, JsonSerializer serializer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private object ReadRegexString(JsonReader reader) { }

	[CalledBy(Type = typeof(BsonDataRegexConverter), Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonWriter), Member = "SetWriteState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsInvalidInstructions]
	private void WriteBson(BsonDataWriter writer, Regex regex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BsonDataRegexConverter), Member = "WriteBson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonDataWriter), typeof(Regex)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonWriter), Member = "get_Path", ReturnType = typeof(string))]
	[Calls(Type = typeof(ExceptionUtils), Member = "CreateJsonSerializationException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IJsonLineInfo), typeof(string), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonSerializationException))]
	[CallsUnknownMethods(Count = 7)]
	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

