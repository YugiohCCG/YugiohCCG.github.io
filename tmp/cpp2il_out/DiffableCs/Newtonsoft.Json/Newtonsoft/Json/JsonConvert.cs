namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
public static class JsonConvert
{
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private static Func<JsonSerializerSettings> <DefaultSettings>k__BackingField; //Field offset: 0x0
	public static readonly string True; //Field offset: 0x8
	public static readonly string False; //Field offset: 0x10
	public static readonly string Null; //Field offset: 0x18
	public static readonly string Undefined; //Field offset: 0x20
	public static readonly string PositiveInfinity; //Field offset: 0x28
	public static readonly string NegativeInfinity; //Field offset: 0x30
	public static readonly string NaN; //Field offset: 0x38

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public static Func<JsonSerializerSettings> DefaultSettings
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 78
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		 set { } //Length: 105
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	private static JsonConvert() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DebuggerStepThrough]
	[DeduplicatedMethod]
	public static T DeserializeAnonymousType(string value, T anonymousTypeObject) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DebuggerStepThrough]
	[DeduplicatedMethod]
	public static T DeserializeAnonymousType(string value, T anonymousTypeObject, JsonSerializerSettings settings) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonConvert), Member = "DeserializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(JsonSerializerSettings)}, ReturnType = typeof(object))]
	[DebuggerStepThrough]
	public static object DeserializeObject(string value) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	[DebuggerStepThrough]
	public static object DeserializeObject(string value, JsonSerializerSettings settings) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonConvert), Member = "DeserializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(JsonSerializerSettings)}, ReturnType = typeof(object))]
	[DebuggerStepThrough]
	public static object DeserializeObject(string value, Type type) { }

	[CalledBy(Type = "Manager.Updater+<UpdateBadWords>d__37", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(JsonConvert), Member = "DeserializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(JsonSerializerSettings)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 5)]
	[DebuggerStepThrough]
	[DeduplicatedMethod]
	[NullableContext(2)]
	public static T DeserializeObject(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(JsonConvert), Member = "DeserializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(JsonConverter[])}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 5)]
	[DebuggerStepThrough]
	[DeduplicatedMethod]
	public static T DeserializeObject(string value, JsonConverter[] converters) { }

	[CalledBy(Type = typeof(JsonConvert), Member = "DeserializeObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonConverter[])}, ReturnType = "T")]
	[CalledBy(Type = typeof(JsonConvert), Member = "DeserializeXmlNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(XmlDocument))]
	[CalledBy(Type = typeof(JsonConvert), Member = "DeserializeXmlNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(XmlDocument))]
	[CalledBy(Type = typeof(JsonConvert), Member = "DeserializeXNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(XDocument))]
	[CalledBy(Type = typeof(JsonConvert), Member = "DeserializeXNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(XDocument))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(JsonSerializerSettings), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsInvalidInstructions]
	[DebuggerStepThrough]
	public static object DeserializeObject(string value, Type type, JsonConverter[] converters) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(JsonConvert), Member = "DeserializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(JsonSerializerSettings)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 4)]
	[DebuggerStepThrough]
	[DeduplicatedMethod]
	[NullableContext(2)]
	public static T DeserializeObject(string value, JsonSerializerSettings settings) { }

	[CalledBy(Type = typeof(JsonConvert), Member = "DeserializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonConvert), Member = "DeserializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonConvert), Member = "DeserializeObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[CalledBy(Type = typeof(JsonConvert), Member = "DeserializeObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonSerializerSettings)}, ReturnType = "T")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSerializer), Member = "CreateDefault", ReturnType = typeof(JsonSerializer))]
	[Calls(Type = typeof(JsonSerializer), Member = "ApplySerializerSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSerializer), typeof(JsonSerializerSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[NullableContext(2)]
	public static object DeserializeObject(string value, Type type, JsonSerializerSettings settings) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonConvert), Member = "DeserializeXmlNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(XmlDocument))]
	public static XmlDocument DeserializeXmlNode(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonConvert), Member = "DeserializeXmlNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(XmlDocument))]
	[NullableContext(2)]
	public static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName) { }

	[CalledBy(Type = typeof(JsonConvert), Member = "DeserializeXmlNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlDocument))]
	[CalledBy(Type = typeof(JsonConvert), Member = "DeserializeXmlNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlDocument))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(JsonConvert), Member = "DeserializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(JsonConverter[])}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[NullableContext(2)]
	public static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName, bool writeArrayAttribute) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(JsonConvert), Member = "DeserializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(JsonConverter[])}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[NullableContext(2)]
	public static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName, bool writeArrayAttribute, bool encodeSpecialCharacters) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonConvert), Member = "DeserializeXNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(XDocument))]
	public static XDocument DeserializeXNode(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonConvert), Member = "DeserializeXNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(XDocument))]
	[NullableContext(2)]
	public static XDocument DeserializeXNode(string value, string deserializeRootElementName) { }

	[CalledBy(Type = typeof(JsonConvert), Member = "DeserializeXNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XDocument))]
	[CalledBy(Type = typeof(JsonConvert), Member = "DeserializeXNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XDocument))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(JsonConvert), Member = "DeserializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(JsonConverter[])}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[NullableContext(2)]
	public static XDocument DeserializeXNode(string value, string deserializeRootElementName, bool writeArrayAttribute) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(JsonConvert), Member = "DeserializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(JsonConverter[])}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[NullableContext(2)]
	public static XDocument DeserializeXNode(string value, string deserializeRootElementName, bool writeArrayAttribute, bool encodeSpecialCharacters) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringUtils), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	private static string EnsureDecimalPlace(string text) { }

	[CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(FloatFormatHandling), typeof(char), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(FloatFormatHandling), typeof(char), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(StringUtils), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	private static string EnsureDecimalPlace(double value, string text) { }

	[CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(FloatFormatHandling), typeof(char), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(FloatFormatHandling), typeof(char), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	private static string EnsureFloatFormat(double value, string text, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static Func<JsonSerializerSettings> get_DefaultSettings() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonConvert), Member = "PopulateObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(JsonSerializerSettings)}, ReturnType = typeof(void))]
	[DebuggerStepThrough]
	public static void PopulateObject(string value, object target) { }

	[CalledBy(Type = typeof(JsonConvert), Member = "PopulateObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonSerializer), Member = "CreateDefault", ReturnType = typeof(JsonSerializer))]
	[Calls(Type = typeof(JsonSerializer), Member = "ApplySerializerSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSerializer), typeof(JsonSerializerSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonSerializationException))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public static void PopulateObject(string value, object target, JsonSerializerSettings settings) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonSerializer), Member = "CreateDefault", ReturnType = typeof(JsonSerializer))]
	[Calls(Type = typeof(JsonConvert), Member = "SerializeObjectInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(JsonSerializer)}, ReturnType = typeof(string))]
	[DebuggerStepThrough]
	public static string SerializeObject(object value) { }

	[CalledBy(Type = typeof(JsonConvert), Member = "SerializeXmlNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "SerializeXmlNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(Formatting)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "SerializeXmlNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(Formatting), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "SerializeXNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XObject)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "SerializeXNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XObject), typeof(Formatting)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "SerializeXNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XObject), typeof(Formatting), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(JsonSerializerSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSerializer), Member = "CreateDefault", ReturnType = typeof(JsonSerializer))]
	[Calls(Type = typeof(JsonSerializer), Member = "ApplySerializerSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSerializer), typeof(JsonSerializerSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonConvert), Member = "SerializeObjectInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(JsonSerializer)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DebuggerStepThrough]
	public static string SerializeObject(object value, Formatting formatting, JsonConverter[] converters) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonSerializerSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSerializer), Member = "CreateDefault", ReturnType = typeof(JsonSerializer))]
	[Calls(Type = typeof(JsonSerializer), Member = "ApplySerializerSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSerializer), typeof(JsonSerializerSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonConvert), Member = "SerializeObjectInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(JsonSerializer)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	[DebuggerStepThrough]
	public static string SerializeObject(object value, JsonConverter[] converters) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonSerializer), Member = "CreateDefault", ReturnType = typeof(JsonSerializer))]
	[Calls(Type = typeof(JsonConvert), Member = "SerializeObjectInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(JsonSerializer)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DebuggerStepThrough]
	public static string SerializeObject(object value, Formatting formatting) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonSerializer), Member = "CreateDefault", ReturnType = typeof(JsonSerializer))]
	[Calls(Type = typeof(JsonSerializer), Member = "ApplySerializerSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSerializer), typeof(JsonSerializerSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonConvert), Member = "SerializeObjectInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(JsonSerializer)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DebuggerStepThrough]
	[NullableContext(2)]
	public static string SerializeObject(object value, Formatting formatting, JsonSerializerSettings settings) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonSerializer), Member = "CreateDefault", ReturnType = typeof(JsonSerializer))]
	[Calls(Type = typeof(JsonSerializer), Member = "ApplySerializerSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSerializer), typeof(JsonSerializerSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonConvert), Member = "SerializeObjectInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(JsonSerializer)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DebuggerStepThrough]
	[NullableContext(2)]
	public static string SerializeObject(object value, Type type, Formatting formatting, JsonSerializerSettings settings) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonSerializer), Member = "CreateDefault", ReturnType = typeof(JsonSerializer))]
	[Calls(Type = typeof(JsonSerializer), Member = "ApplySerializerSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSerializer), typeof(JsonSerializerSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonConvert), Member = "SerializeObjectInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(JsonSerializer)}, ReturnType = typeof(string))]
	[DebuggerStepThrough]
	[NullableContext(2)]
	public static string SerializeObject(object value, JsonSerializerSettings settings) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonSerializer), Member = "CreateDefault", ReturnType = typeof(JsonSerializer))]
	[Calls(Type = typeof(JsonSerializer), Member = "ApplySerializerSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSerializer), typeof(JsonSerializerSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonConvert), Member = "SerializeObjectInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(JsonSerializer)}, ReturnType = typeof(string))]
	[DebuggerStepThrough]
	[NullableContext(2)]
	public static string SerializeObject(object value, Type type, JsonSerializerSettings settings) { }

	[CalledBy(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Formatting)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonConverter[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Formatting), typeof(JsonConverter[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonSerializerSettings)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(JsonSerializerSettings)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Formatting), typeof(JsonSerializerSettings)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(Formatting), typeof(JsonSerializerSettings)}, ReturnType = typeof(string))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(IFormatProvider)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonWriter), Member = "set_Formatting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Formatting)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private static string SerializeObjectInternal(object value, Type type, JsonSerializer jsonSerializer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Formatting), typeof(JsonConverter[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static string SerializeXmlNode(XmlNode node, Formatting formatting, bool omitRootObject) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Formatting), typeof(JsonConverter[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static string SerializeXmlNode(XmlNode node, Formatting formatting) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Formatting), typeof(JsonConverter[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static string SerializeXmlNode(XmlNode node) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Formatting), typeof(JsonConverter[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static string SerializeXNode(XObject node) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Formatting), typeof(JsonConverter[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static string SerializeXNode(XObject node, Formatting formatting) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Formatting), typeof(JsonConverter[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static string SerializeXNode(XObject node, Formatting formatting, bool omitRootObject) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	public static void set_DefaultSettings(Func<JsonSerializerSettings> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public static string ToString(Enum value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	public static string ToString(byte value) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "DoWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(char), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	public static string ToString(char value) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "DoWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	public static string ToString(bool value) { }

	[CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringUtils), Member = "CreateStringWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringWriter))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(DateTimeUtils), Member = "WriteDateTimeOffsetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(DateTimeOffset), typeof(DateFormatHandling), typeof(string), typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public static string ToString(DateTimeOffset value, DateFormatHandling format) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), typeof(DateFormatHandling)}, ReturnType = typeof(string))]
	public static string ToString(DateTimeOffset value) { }

	[CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTimeUtils), Member = "EnsureDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTimeZoneHandling)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(StringUtils), Member = "CreateStringWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringWriter))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(DateTimeUtils), Member = "WriteDateTimeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(DateTime), typeof(DateFormatHandling), typeof(string), typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public static string ToString(DateTime value, DateFormatHandling format, DateTimeZoneHandling timeZoneHandling) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateFormatHandling), typeof(DateTimeZoneHandling)}, ReturnType = typeof(string))]
	public static string ToString(DateTime value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	public static string ToString(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(short), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	public static string ToString(short value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(ulong), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CLSCompliant(False)]
	public static string ToString(ulong value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(uint), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CLSCompliant(False)]
	public static string ToString(uint value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(sbyte), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CLSCompliant(False)]
	public static string ToString(sbyte value) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "DoWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Decimal>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "DoWriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Decimal>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Decimal), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringUtils), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	public static string ToString(decimal value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Guid), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string ToString(Guid value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Guid), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static string ToString(Guid value, char quoteChar) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeSpan), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(JavaScriptUtils), Member = "ToEscapedJavaScriptString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(char), typeof(bool), typeof(StringEscapeHandling)}, ReturnType = typeof(string))]
	public static string ToString(TimeSpan value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeSpan), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(char)}, ReturnType = typeof(string))]
	internal static string ToString(TimeSpan value, char quoteChar) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[Calls(Type = typeof(JavaScriptUtils), Member = "ToEscapedJavaScriptString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(char), typeof(bool), typeof(StringEscapeHandling)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public static string ToString(Uri value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(char)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	internal static string ToString(Uri value, char quoteChar) { }

	[CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JavaScriptUtils), Member = "ToEscapedJavaScriptString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(char), typeof(bool), typeof(StringEscapeHandling)}, ReturnType = typeof(string))]
	public static string ToString(string value) { }

	[CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(char)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(char)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JavaScriptUtils), Member = "ToEscapedJavaScriptString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(char), typeof(bool), typeof(StringEscapeHandling)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static string ToString(string value, char delimiter) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JavaScriptUtils), Member = "ToEscapedJavaScriptString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(char), typeof(bool), typeof(StringEscapeHandling)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static string ToString(string value, char delimiter, StringEscapeHandling stringEscapeHandling) { }

	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(double), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonConvert), Member = "EnsureDecimalPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(string)}, ReturnType = typeof(string))]
	public static string ToString(double value) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonConvert), Member = "EnsureDecimalPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonConvert), Member = "EnsureFloatFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(string), typeof(FloatFormatHandling), typeof(char), typeof(bool)}, ReturnType = typeof(string))]
	[ContainsUnimplementedInstructions]
	internal static string ToString(float value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonConvert), Member = "EnsureDecimalPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(string)}, ReturnType = typeof(string))]
	[ContainsUnimplementedInstructions]
	public static string ToString(float value) { }

	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValueAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Double>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(double), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonConvert), Member = "EnsureDecimalPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonConvert), Member = "EnsureFloatFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(string), typeof(FloatFormatHandling), typeof(char), typeof(bool)}, ReturnType = typeof(string))]
	internal static string ToString(double value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(long), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	public static string ToString(long value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(ushort), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CLSCompliant(False)]
	public static string ToString(ushort value) { }

	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), typeof(DateFormatHandling)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Decimal), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringUtils), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Guid), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TimeSpan), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(JavaScriptUtils), Member = "ToEscapedJavaScriptString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(char), typeof(bool), typeof(StringEscapeHandling)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(BigInteger), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateFormatHandling), typeof(DateTimeZoneHandling)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(double), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonConvert), Member = "EnsureDecimalPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ulong), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(long), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(uint), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ushort), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(short), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(sbyte), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(char), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ConvertUtils), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(PrimitiveTypeCode))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 28)]
	public static string ToString(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(BigInteger), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	private static string ToStringInternal(BigInteger value) { }

}

