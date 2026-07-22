namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
public class JsonSerializationException : JsonException
{
	[CompilerGenerated]
	private readonly int <LineNumber>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private readonly int <LinePosition>k__BackingField; //Field offset: 0x94
	[CompilerGenerated]
	[Nullable(2)]
	private readonly string <Path>k__BackingField; //Field offset: 0x98

	public int LineNumber
	{
		[CallerCount(Count = 33)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public int LinePosition
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	[Nullable(2)]
	public string Path
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[NullableContext(2)]
		 get { } //Length: 8
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Exception), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public JsonSerializationException() { }

	[CallerCount(Count = 90)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public JsonSerializationException(string message) { }

	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public JsonSerializationException(string message, Exception innerException) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public JsonSerializationException(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public JsonSerializationException(string message, string path, int lineNumber, int linePosition, Exception innerException) { }

	[CallerCount(Count = 118)]
	[Calls(Type = typeof(JsonPosition), Member = "FormatMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IJsonLineInfo), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal static JsonSerializationException Create(JsonReader reader, string message) { }

	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ResolveTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type&), typeof(JsonContract&), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "EnsureType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(object), typeof(CultureInfo), typeof(JsonContract), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "AddReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateDictionary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDictionary), typeof(JsonReader), typeof(JsonDictionaryContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateMultidimensionalArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(JsonReader), typeof(JsonArrayContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(JsonReader), typeof(JsonArrayContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "SetExtensionData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonObjectContract), typeof(JsonProperty), typeof(JsonReader), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StringEnumConverter), Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(VersionConverter), Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(object))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(JsonPosition), Member = "FormatMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IJsonLineInfo), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal static JsonSerializationException Create(JsonReader reader, string message, Exception ex) { }

	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ReadMetadataPropertiesToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JTokenReader), typeof(Type&), typeof(JsonContract&), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty), typeof(object), typeof(Object&), typeof(String&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "CheckForCircularReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonProperty), typeof(JsonContract), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "GetReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "CalculatePropertyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonContainerContract), typeof(JsonProperty), typeof(JsonProperty), typeof(JsonContract&), typeof(Object&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeISerializable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(ISerializable), typeof(JsonISerializableContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDynamic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IDynamicMetaObjectProvider), typeof(JsonDynamicContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StringEnumConverter), Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(JsonPosition), Member = "FormatMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IJsonLineInfo), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal static JsonSerializationException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex) { }

	[CallerCount(Count = 33)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_LineNumber() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_LinePosition() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[NullableContext(2)]
	public string get_Path() { }

}

