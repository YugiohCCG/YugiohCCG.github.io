namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
public class JsonWriterException : JsonException
{
	[CompilerGenerated]
	[Nullable(2)]
	private readonly string <Path>k__BackingField; //Field offset: 0x90

	[Nullable(2)]
	public string Path
	{
		[CallerCount(Count = 57)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[NullableContext(2)]
		 get { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public JsonWriterException() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public JsonWriterException(string message) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public JsonWriterException(string message, Exception innerException) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public JsonWriterException(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.ExceptionUtils", Member = "CreateJsonWriterException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonWriterException))]
	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.ExceptionUtils", Member = "CreateJsonWriterException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonWriterException))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public JsonWriterException(string message, string path, Exception innerException) { }

	[CallerCount(Count = 30)]
	[Calls(Type = typeof(JsonWriter), Member = "get_ContainerPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonPosition), Member = "FormatMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IJsonLineInfo), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static JsonWriterException Create(JsonWriter writer, string message, Exception ex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonPosition), Member = "FormatMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IJsonLineInfo), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static JsonWriterException Create(string path, string message, Exception ex) { }

	[CallerCount(Count = 57)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[NullableContext(2)]
	public string get_Path() { }

}

