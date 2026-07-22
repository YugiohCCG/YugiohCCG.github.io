namespace Newtonsoft.Json.Bson.Utilities;

internal static class ExceptionUtils
{

	[CalledBy(Type = typeof(BsonDataReader), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BsonDataReader), Member = "ReadReference", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BsonDataReader), Member = "ReadNormal", ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ExceptionUtils), Member = "FormatMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IJsonLineInfo), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	internal static JsonReaderException CreateJsonReaderException(JsonReader reader, string message) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionUtils), Member = "FormatMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IJsonLineInfo), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	internal static JsonReaderException CreateJsonReaderException(JsonReader reader, string message, Exception ex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionUtils), Member = "FormatMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IJsonLineInfo), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal static JsonReaderException CreateJsonReaderException(IJsonLineInfo lineInfo, string path, string message, Exception ex) { }

	[CalledBy(Type = typeof(BsonDataRegexConverter), Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BsonDataRegexConverter), Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(BsonDataRegexConverter), Member = "ReadRegexObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonSerializer)}, ReturnType = typeof(Regex))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ExceptionUtils), Member = "FormatMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IJsonLineInfo), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static JsonSerializationException CreateJsonSerializationException(IJsonLineInfo lineInfo, string path, string message, Exception ex) { }

	[CalledBy(Type = typeof(BsonDataWriter), Member = "WriteComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BsonDataWriter), Member = "WriteStartConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BsonDataWriter), Member = "WriteRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BsonDataWriter), Member = "WriteRawValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BsonDataWriter), Member = "AddToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BsonDataWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BsonDataWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BsonDataWriter), Member = "WriteObjectId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BsonDataObjectIdConverter), Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(JsonWriter), Member = "get_Path", ReturnType = typeof(string))]
	[Calls(Type = typeof(ExceptionUtils), Member = "FormatMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IJsonLineInfo), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonWriterException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal static JsonWriterException CreateJsonWriterException(JsonWriter writer, string message, Exception ex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionUtils), Member = "FormatMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IJsonLineInfo), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonWriterException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	internal static JsonWriterException CreateJsonWriterException(string path, string message, Exception ex) { }

	[CalledBy(Type = typeof(ExceptionUtils), Member = "CreateJsonReaderException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CalledBy(Type = typeof(ExceptionUtils), Member = "CreateJsonReaderException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonReaderException))]
	[CalledBy(Type = typeof(ExceptionUtils), Member = "CreateJsonReaderException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IJsonLineInfo), typeof(string), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonReaderException))]
	[CalledBy(Type = typeof(ExceptionUtils), Member = "CreateJsonWriterException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonWriterException))]
	[CalledBy(Type = typeof(ExceptionUtils), Member = "CreateJsonWriterException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonWriterException))]
	[CalledBy(Type = typeof(ExceptionUtils), Member = "CreateJsonSerializationException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IJsonLineInfo), typeof(string), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonSerializationException))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 25)]
	private static string FormatMessage(IJsonLineInfo lineInfo, string path, string message) { }

}

