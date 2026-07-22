namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
public class JsonSerializer
{
	internal TypeNameHandling _typeNameHandling; //Field offset: 0x10
	internal TypeNameAssemblyFormatHandling _typeNameAssemblyFormatHandling; //Field offset: 0x14
	internal PreserveReferencesHandling _preserveReferencesHandling; //Field offset: 0x18
	internal ReferenceLoopHandling _referenceLoopHandling; //Field offset: 0x1C
	internal MissingMemberHandling _missingMemberHandling; //Field offset: 0x20
	internal ObjectCreationHandling _objectCreationHandling; //Field offset: 0x24
	internal NullValueHandling _nullValueHandling; //Field offset: 0x28
	internal DefaultValueHandling _defaultValueHandling; //Field offset: 0x2C
	internal ConstructorHandling _constructorHandling; //Field offset: 0x30
	internal MetadataPropertyHandling _metadataPropertyHandling; //Field offset: 0x34
	[Nullable(2)]
	internal JsonConverterCollection _converters; //Field offset: 0x38
	internal IContractResolver _contractResolver; //Field offset: 0x40
	[Nullable(2)]
	internal ITraceWriter _traceWriter; //Field offset: 0x48
	[Nullable(2)]
	internal IEqualityComparer _equalityComparer; //Field offset: 0x50
	internal ISerializationBinder _serializationBinder; //Field offset: 0x58
	internal StreamingContext _context; //Field offset: 0x60
	[Nullable(2)]
	private IReferenceResolver _referenceResolver; //Field offset: 0x70
	private Nullable<Formatting> _formatting; //Field offset: 0x78
	private Nullable<DateFormatHandling> _dateFormatHandling; //Field offset: 0x80
	private Nullable<DateTimeZoneHandling> _dateTimeZoneHandling; //Field offset: 0x88
	private Nullable<DateParseHandling> _dateParseHandling; //Field offset: 0x90
	private Nullable<FloatFormatHandling> _floatFormatHandling; //Field offset: 0x98
	private Nullable<FloatParseHandling> _floatParseHandling; //Field offset: 0xA0
	private Nullable<StringEscapeHandling> _stringEscapeHandling; //Field offset: 0xA8
	private CultureInfo _culture; //Field offset: 0xB0
	private Nullable<Int32> _maxDepth; //Field offset: 0xB8
	private bool _maxDepthSet; //Field offset: 0xC0
	private Nullable<Boolean> _checkAdditionalContent; //Field offset: 0xC1
	[Nullable(2)]
	private string _dateFormatString; //Field offset: 0xC8
	private bool _dateFormatStringSet; //Field offset: 0xD0
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private EventHandler<ErrorEventArgs> Error; //Field offset: 0xD8

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public override event EventHandler<ErrorEventArgs> Error
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 add { } //Length: 160
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 remove { } //Length: 160
	}

	[Obsolete("Binder is obsolete. Use SerializationBinder instead.")]
	public override SerializationBinder Binder
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 225
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		 set { } //Length: 250
	}

	public override bool CheckAdditionalContent
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 63
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 94
	}

	public override ConstructorHandling ConstructorHandling
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 99
	}

	public override StreamingContext Context
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 18
	}

	public override IContractResolver ContractResolver
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 171
	}

	public override JsonConverterCollection Converters
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Collection`1), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 138
	}

	public override CultureInfo Culture
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 97
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public override DateFormatHandling DateFormatHandling
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 61
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 94
	}

	public override string DateFormatString
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 64
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 41
	}

	public override DateParseHandling DateParseHandling
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 81
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 94
	}

	public override DateTimeZoneHandling DateTimeZoneHandling
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 81
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 94
	}

	public override DefaultValueHandling DefaultValueHandling
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 99
	}

	[Nullable(2)]
	public override IEqualityComparer EqualityComparer
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[NullableContext(2)]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[NullableContext(2)]
		 set { } //Length: 13
	}

	public override FloatFormatHandling FloatFormatHandling
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 61
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 94
	}

	public override FloatParseHandling FloatParseHandling
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 61
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 94
	}

	public override Formatting Formatting
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 55
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 91
	}

	public override Nullable<Int32> MaxDepth
	{
		[CallerCount(Count = 17)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 189
	}

	public override MetadataPropertyHandling MetadataPropertyHandling
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 99
	}

	public override MissingMemberHandling MissingMemberHandling
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 99
	}

	public override NullValueHandling NullValueHandling
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 99
	}

	public override ObjectCreationHandling ObjectCreationHandling
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 99
	}

	public override PreserveReferencesHandling PreserveReferencesHandling
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 99
	}

	public override ReferenceLoopHandling ReferenceLoopHandling
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 99
	}

	[Nullable(2)]
	public override IReferenceResolver ReferenceResolver
	{
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[NullableContext(2)]
		 get { } //Length: 105
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		[NullableContext(2)]
		 set { } //Length: 136
	}

	public override ISerializationBinder SerializationBinder
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		 set { } //Length: 136
	}

	public override StringEscapeHandling StringEscapeHandling
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 61
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 94
	}

	[Nullable(2)]
	public override ITraceWriter TraceWriter
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		[NullableContext(2)]
		 get { } //Length: 254
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[NullableContext(2)]
		 set { } //Length: 13
	}

	[Obsolete("TypeNameAssemblyFormat is obsolete. Use TypeNameAssemblyFormatHandling instead.")]
	public override FormatterAssemblyStyle TypeNameAssemblyFormat
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 99
	}

	public override TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 99
	}

	public override TypeNameHandling TypeNameHandling
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 99
	}

	[CalledBy(Type = "Manager.Helper", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "GetInternalSerializer", ReturnType = typeof(JsonSerializerProxy))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeConvertable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(JsonConverter), typeof(object), typeof(JsonContract), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerProxy), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSerializerInternalReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerProxy), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSerializerInternalWriter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public JsonSerializer() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public override void add_Error(EventHandler<ErrorEventArgs> value) { }

	[CalledBy(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonConverter[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Formatting), typeof(JsonConverter[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonSerializerSettings)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(JsonSerializerSettings)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Formatting), typeof(JsonSerializerSettings)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(Formatting), typeof(JsonSerializerSettings)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "DeserializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(JsonSerializerSettings)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonConvert), Member = "PopulateObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(JsonSerializerSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializer), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSerializerSettings)}, ReturnType = typeof(JsonSerializer))]
	[CalledBy(Type = typeof(JsonSerializer), Member = "CreateDefault", ReturnType = typeof(JsonSerializer))]
	[CalledBy(Type = typeof(JsonSerializer), Member = "CreateDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSerializerSettings)}, ReturnType = typeof(JsonSerializer))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CollectionUtils), Member = "IsNullOrEmpty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.ICollection`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.ObjectModel.Collection`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallsUnknownMethods(Count = 5)]
	private static void ApplySerializerSettings(JsonSerializer serializer, JsonSerializerSettings settings) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static JsonSerializer Create() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonSerializer), Member = "ApplySerializerSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSerializer), typeof(JsonSerializerSettings)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static JsonSerializer Create(JsonSerializerSettings settings) { }

	[CalledBy(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JValue), Member = "WriteTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(JsonConverter[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JValue), Member = "WriteToAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(CancellationToken), typeof(JsonConverter[])}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JToken), Member = "FromObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(JToken))]
	[CalledBy(Type = typeof(JObject), Member = "FromObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(JObject))]
	[CalledBy(Type = typeof(JArray), Member = "FromObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(JArray))]
	[CalledBy(Type = typeof(JsonConvert), Member = "PopulateObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(JsonSerializerSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializer), Member = "CreateDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSerializerSettings)}, ReturnType = typeof(JsonSerializer))]
	[CalledBy(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(Formatting), typeof(JsonSerializerSettings)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Formatting), typeof(JsonSerializerSettings)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(JsonSerializerSettings)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonSerializerSettings)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Formatting), typeof(JsonConverter[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonConverter[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Formatting)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "DeserializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(JsonSerializerSettings)}, ReturnType = typeof(object))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(JsonSerializer), Member = "ApplySerializerSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSerializer), typeof(JsonSerializerSettings)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static JsonSerializer CreateDefault() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonSerializer), Member = "CreateDefault", ReturnType = typeof(JsonSerializer))]
	[Calls(Type = typeof(JsonSerializer), Member = "ApplySerializerSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSerializer), typeof(JsonSerializerSettings)}, ReturnType = typeof(void))]
	public static JsonSerializer CreateDefault(JsonSerializerSettings settings) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TraceJsonReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TraceJsonReader), Member = "WriteCurrentToken", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private TraceJsonReader CreateTraceJsonReader(JsonReader reader) { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.Converters.BsonDataRegexConverter", Member = "ReadRegexObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonSerializer)}, ReturnType = typeof(Regex))]
	[CalledBy(Type = typeof(RegexConverter), Member = "ReadRegexObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonSerializer)}, ReturnType = typeof(Regex))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(JsonSerializer), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 4)]
	[DebuggerStepThrough]
	[DeduplicatedMethod]
	[NullableContext(2)]
	public T Deserialize(JsonReader reader) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DebuggerStepThrough]
	public object Deserialize(JsonReader reader) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DebuggerStepThrough]
	public object Deserialize(TextReader reader, Type objectType) { }

	[CalledBy(Type = typeof(JsonSerializer), Member = "Deserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = "T")]
	[CalledBy(Type = typeof(JsonSerializerProxy), Member = "DeserializeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(JsonSerializer)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DataTableConverter), Member = "CreateRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(DataTable), typeof(JsonSerializer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntityKeyMemberConverter), Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(KeyValuePairConverter), Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(object))]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DebuggerStepThrough]
	[NullableContext(2)]
	public object Deserialize(JsonReader reader, Type objectType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSerializer), Member = "SetupReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(CultureInfo&), typeof(Nullable`1<DateTimeZoneHandling>&), typeof(Nullable`1<DateParseHandling>&), typeof(Nullable`1<FloatParseHandling>&), typeof(Nullable`1<Int32>&), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TraceJsonReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TraceJsonReader), Member = "WriteCurrentToken", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSerializerInternalReader), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(TraceJsonReader), Member = "GetDeserializedJsonMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonSerializer), Member = "ResetReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(CultureInfo), typeof(System.Nullable`1<Newtonsoft.Json.DateTimeZoneHandling>), typeof(System.Nullable`1<Newtonsoft.Json.DateParseHandling>), typeof(System.Nullable`1<Newtonsoft.Json.FloatParseHandling>), typeof(System.Nullable`1<System.Int32>), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 3)]
	[NullableContext(2)]
	internal override object DeserializeInternal(JsonReader reader, Type objectType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override SerializationBinder get_Binder() { }

	[CallerCount(Count = 0)]
	public override bool get_CheckAdditionalContent() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public override ConstructorHandling get_ConstructorHandling() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override StreamingContext get_Context() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public override IContractResolver get_ContractResolver() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Collection`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override JsonConverterCollection get_Converters() { }

	[CallerCount(Count = 0)]
	public override CultureInfo get_Culture() { }

	[CallerCount(Count = 0)]
	public override DateFormatHandling get_DateFormatHandling() { }

	[CallerCount(Count = 0)]
	public override string get_DateFormatString() { }

	[CallerCount(Count = 0)]
	public override DateParseHandling get_DateParseHandling() { }

	[CallerCount(Count = 0)]
	public override DateTimeZoneHandling get_DateTimeZoneHandling() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override DefaultValueHandling get_DefaultValueHandling() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[NullableContext(2)]
	public override IEqualityComparer get_EqualityComparer() { }

	[CallerCount(Count = 0)]
	public override FloatFormatHandling get_FloatFormatHandling() { }

	[CallerCount(Count = 0)]
	public override FloatParseHandling get_FloatParseHandling() { }

	[CallerCount(Count = 0)]
	public override Formatting get_Formatting() { }

	[CallerCount(Count = 17)]
	[DeduplicatedMethod]
	public override Nullable<Int32> get_MaxDepth() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public override MetadataPropertyHandling get_MetadataPropertyHandling() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public override MissingMemberHandling get_MissingMemberHandling() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public override NullValueHandling get_NullValueHandling() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public override ObjectCreationHandling get_ObjectCreationHandling() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public override PreserveReferencesHandling get_PreserveReferencesHandling() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public override ReferenceLoopHandling get_ReferenceLoopHandling() { }

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NullableContext(2)]
	public override IReferenceResolver get_ReferenceResolver() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public override ISerializationBinder get_SerializationBinder() { }

	[CallerCount(Count = 0)]
	public override StringEscapeHandling get_StringEscapeHandling() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	[NullableContext(2)]
	public override ITraceWriter get_TraceWriter() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public override FormatterAssemblyStyle get_TypeNameAssemblyFormat() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public override TypeNameAssemblyFormatHandling get_TypeNameAssemblyFormatHandling() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public override TypeNameHandling get_TypeNameHandling() { }

	[CalledBy(Type = typeof(JsonFormatterConverter), Member = "Convert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "GetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContract), typeof(JsonConverter), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(JsonConverter))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CalculatePropertyDetails", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonProperty), typeof(JsonConverter&), typeof(JsonContainerContract), typeof(JsonProperty), typeof(JsonReader), typeof(object), typeof(Boolean&), typeof(Object&), typeof(JsonContract&), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateDictionary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDictionary), typeof(JsonReader), typeof(JsonDictionaryContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateMultidimensionalArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(JsonReader), typeof(JsonArrayContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(JsonReader), typeof(JsonArrayContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateISerializableItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken), typeof(Type), typeof(JsonISerializableContract), typeof(JsonProperty)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateDynamic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonDynamicContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ResolvePropertyAndCreatorValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonObjectContract), typeof(JsonProperty), typeof(JsonReader), typeof(Type)}, ReturnType = typeof(System.Collections.Generic.List`1<Newtonsoft.Json.Serialization.JsonSerializerInternalReader+CreatorPropertyContext>))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonReader), typeof(JsonObjectContract), typeof(JsonProperty), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal JsonConverter GetMatchingConverter(Type type) { }

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "InitializeContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContract)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JValue), Member = "WriteToAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(CancellationToken), typeof(JsonConverter[])}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(JValue), Member = "WriteTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(JsonConverter[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal static JsonConverter GetMatchingConverter(IList<JsonConverter> converters, Type objectType) { }

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal IReferenceResolver GetReferenceResolver() { }

	[CallerCount(Count = 0)]
	internal bool IsCheckAdditionalContentSet() { }

	[CalledBy(Type = typeof(JsonSerializerInternalBase), Member = "IsErrorHandled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonContract), typeof(object), typeof(IJsonLineInfo), typeof(string), typeof(Exception)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void OnError(ErrorEventArgs e) { }

	[CalledBy(Type = typeof(JsonSerializerProxy), Member = "PopulateInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CustomCreationConverter`1), Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DebuggerStepThrough]
	public void Populate(JsonReader reader, object target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DebuggerStepThrough]
	public void Populate(TextReader reader, object target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSerializer), Member = "SetupReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(CultureInfo&), typeof(Nullable`1<DateTimeZoneHandling>&), typeof(Nullable`1<DateParseHandling>&), typeof(Nullable`1<FloatParseHandling>&), typeof(Nullable`1<Int32>&), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TraceJsonReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TraceJsonReader), Member = "WriteCurrentToken", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSerializerInternalReader), Member = "Populate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TraceJsonReader), Member = "GetDeserializedJsonMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonSerializer), Member = "ResetReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(CultureInfo), typeof(System.Nullable`1<Newtonsoft.Json.DateTimeZoneHandling>), typeof(System.Nullable`1<Newtonsoft.Json.DateParseHandling>), typeof(System.Nullable`1<Newtonsoft.Json.FloatParseHandling>), typeof(System.Nullable`1<System.Int32>), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 3)]
	internal override void PopulateInternal(JsonReader reader, object target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public override void remove_Error(EventHandler<ErrorEventArgs> value) { }

	[CalledBy(Type = typeof(JsonSerializer), Member = "PopulateInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializer), Member = "DeserializeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JsonReader), Member = "set_MaxDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	[NullableContext(2)]
	private void ResetReader(JsonReader reader, CultureInfo previousCulture, Nullable<DateTimeZoneHandling> previousDateTimeZoneHandling, Nullable<DateParseHandling> previousDateParseHandling, Nullable<FloatParseHandling> previousFloatParseHandling, Nullable<Int32> previousMaxDepth, string previousDateFormatString) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Serialize(TextWriter textWriter, object value) { }

	[CalledBy(Type = typeof(KeyValuePairConverter), Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[NullableContext(2)]
	public void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Serialize(TextWriter textWriter, object value, Type objectType) { }

	[CalledBy(Type = "Manager.Helper+<SerializeData>d__121`1", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerProxy), Member = "SerializeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JToken), Member = "FromObjectInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(JToken))]
	[CalledBy(Type = typeof(DataTableConverter), Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DiscriminatedUnionConverter), Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexConverter), Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexConverter), Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(Regex), typeof(JsonSerializer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Serialize(JsonWriter jsonWriter, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "set_StringEscapeHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringEscapeHandling)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TraceJsonWriter), Member = "GetSerializedJsonMessage", ReturnType = typeof(string))]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonWriter), Member = "set_Formatting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Formatting)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonWriter), Member = "set_DateFormatHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateFormatHandling)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonWriter), Member = "set_DateTimeZoneHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeZoneHandling)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonWriter), Member = "set_FloatFormatHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FloatFormatHandling)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonWriter), Member = "get_Culture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TraceJsonWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSerializerInternalWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSerializer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSerializerInternalWriter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	[NullableContext(2)]
	internal override void SerializeInternal(JsonWriter jsonWriter, object value, Type objectType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public override void set_Binder(SerializationBinder value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void set_CheckAdditionalContent(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override void set_ConstructorHandling(ConstructorHandling value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override void set_Context(StreamingContext value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override void set_ContractResolver(IContractResolver value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void set_Culture(CultureInfo value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void set_DateFormatHandling(DateFormatHandling value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override void set_DateFormatString(string value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void set_DateParseHandling(DateParseHandling value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override void set_DefaultValueHandling(DefaultValueHandling value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NullableContext(2)]
	public override void set_EqualityComparer(IEqualityComparer value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void set_FloatFormatHandling(FloatFormatHandling value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void set_FloatParseHandling(FloatParseHandling value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void set_Formatting(Formatting value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public override void set_MaxDepth(Nullable<Int32> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override void set_MissingMemberHandling(MissingMemberHandling value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override void set_NullValueHandling(NullValueHandling value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[NullableContext(2)]
	public override void set_ReferenceResolver(IReferenceResolver value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public override void set_SerializationBinder(ISerializationBinder value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void set_StringEscapeHandling(StringEscapeHandling value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NullableContext(2)]
	public override void set_TraceWriter(ITraceWriter value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override void set_TypeNameAssemblyFormat(FormatterAssemblyStyle value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override void set_TypeNameAssemblyFormatHandling(TypeNameAssemblyFormatHandling value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override void set_TypeNameHandling(TypeNameHandling value) { }

	[CalledBy(Type = typeof(JsonSerializer), Member = "PopulateInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializer), Member = "DeserializeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(JsonSerializer)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(JsonReader), Member = "set_DateTimeZoneHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeZoneHandling)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReader), Member = "set_DateParseHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateParseHandling)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReader), Member = "set_FloatParseHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FloatParseHandling)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReader), Member = "set_MaxDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	[NullableContext(2)]
	internal void SetupReader(JsonReader reader, out CultureInfo previousCulture, out Nullable<DateTimeZoneHandling>& previousDateTimeZoneHandling, out Nullable<DateParseHandling>& previousDateParseHandling, out Nullable<FloatParseHandling>& previousFloatParseHandling, out Nullable<Int32>& previousMaxDepth, out string previousDateFormatString) { }

}

