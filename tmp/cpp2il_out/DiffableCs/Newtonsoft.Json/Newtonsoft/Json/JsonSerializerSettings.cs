namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(2)]
public class JsonSerializerSettings
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass93_0
	{
		[Nullable(0)]
		public IReferenceResolver value; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass93_0() { }

		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal IReferenceResolver <set_ReferenceResolver>b__0() { }

	}

	internal const ReferenceLoopHandling DefaultReferenceLoopHandling = 0; //Field offset: 0x0
	internal const int DefaultMaxDepth = 64; //Field offset: 0x0
	[Nullable(1)]
	internal const string DefaultDateFormatString = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK"; //Field offset: 0x0
	internal const bool DefaultCheckAdditionalContent = False; //Field offset: 0x0
	internal const TypeNameAssemblyFormatHandling DefaultTypeNameAssemblyFormatHandling = 0; //Field offset: 0x0
	internal const StringEscapeHandling DefaultStringEscapeHandling = 0; //Field offset: 0x0
	internal const FloatFormatHandling DefaultFloatFormatHandling = 0; //Field offset: 0x0
	internal const FloatParseHandling DefaultFloatParseHandling = 0; //Field offset: 0x0
	internal const DateParseHandling DefaultDateParseHandling = 1; //Field offset: 0x0
	internal const DateFormatHandling DefaultDateFormatHandling = 0; //Field offset: 0x0
	internal const DateTimeZoneHandling DefaultDateTimeZoneHandling = 3; //Field offset: 0x0
	internal static readonly StreamingContext DefaultContext; //Field offset: 0x0
	internal const MetadataPropertyHandling DefaultMetadataPropertyHandling = 0; //Field offset: 0x0
	internal const TypeNameHandling DefaultTypeNameHandling = 0; //Field offset: 0x0
	internal const ConstructorHandling DefaultConstructorHandling = 0; //Field offset: 0x0
	internal const PreserveReferencesHandling DefaultPreserveReferencesHandling = 0; //Field offset: 0x0
	internal const ObjectCreationHandling DefaultObjectCreationHandling = 0; //Field offset: 0x0
	internal const DefaultValueHandling DefaultDefaultValueHandling = 0; //Field offset: 0x0
	internal const NullValueHandling DefaultNullValueHandling = 0; //Field offset: 0x0
	internal const MissingMemberHandling DefaultMissingMemberHandling = 0; //Field offset: 0x0
	internal const Formatting DefaultFormatting = 0; //Field offset: 0x0
	[Nullable(1)]
	internal static readonly CultureInfo DefaultCulture; //Field offset: 0x10
	internal Nullable<Formatting> _formatting; //Field offset: 0x10
	internal Nullable<DateFormatHandling> _dateFormatHandling; //Field offset: 0x18
	internal Nullable<DateTimeZoneHandling> _dateTimeZoneHandling; //Field offset: 0x20
	internal Nullable<DateParseHandling> _dateParseHandling; //Field offset: 0x28
	internal Nullable<FloatFormatHandling> _floatFormatHandling; //Field offset: 0x30
	internal Nullable<FloatParseHandling> _floatParseHandling; //Field offset: 0x38
	internal Nullable<StringEscapeHandling> _stringEscapeHandling; //Field offset: 0x40
	internal CultureInfo _culture; //Field offset: 0x48
	internal Nullable<Boolean> _checkAdditionalContent; //Field offset: 0x50
	internal Nullable<Int32> _maxDepth; //Field offset: 0x54
	internal bool _maxDepthSet; //Field offset: 0x5C
	internal string _dateFormatString; //Field offset: 0x60
	internal bool _dateFormatStringSet; //Field offset: 0x68
	internal Nullable<TypeNameAssemblyFormatHandling> _typeNameAssemblyFormatHandling; //Field offset: 0x6C
	internal Nullable<DefaultValueHandling> _defaultValueHandling; //Field offset: 0x74
	internal Nullable<PreserveReferencesHandling> _preserveReferencesHandling; //Field offset: 0x7C
	internal Nullable<NullValueHandling> _nullValueHandling; //Field offset: 0x84
	internal Nullable<ObjectCreationHandling> _objectCreationHandling; //Field offset: 0x8C
	internal Nullable<MissingMemberHandling> _missingMemberHandling; //Field offset: 0x94
	internal Nullable<ReferenceLoopHandling> _referenceLoopHandling; //Field offset: 0x9C
	internal Nullable<StreamingContext> _context; //Field offset: 0xA8
	internal Nullable<ConstructorHandling> _constructorHandling; //Field offset: 0xC0
	internal Nullable<TypeNameHandling> _typeNameHandling; //Field offset: 0xC8
	internal Nullable<MetadataPropertyHandling> _metadataPropertyHandling; //Field offset: 0xD0
	[CompilerGenerated]
	[Nullable(1)]
	private IList<JsonConverter> <Converters>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private IContractResolver <ContractResolver>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private IEqualityComparer <EqualityComparer>k__BackingField; //Field offset: 0xE8
	[CompilerGenerated]
	private Func<IReferenceResolver> <ReferenceResolverProvider>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private ITraceWriter <TraceWriter>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	private ISerializationBinder <SerializationBinder>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private EventHandler<ErrorEventArgs> <Error>k__BackingField; //Field offset: 0x108

	[Obsolete("Binder is obsolete. Use SerializationBinder instead.")]
	public SerializationBinder Binder
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 188
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 135
	}

	public bool CheckAdditionalContent
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 57
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 91
	}

	public ConstructorHandling ConstructorHandling
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 61
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 94
	}

	public StreamingContext Context
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 183
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 140
	}

	public IContractResolver ContractResolver
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	[Nullable(1)]
	public IList<JsonConverter> Converters
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[NullableContext(1)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[NullableContext(1)]
		 set { } //Length: 19
	}

	[Nullable(1)]
	public CultureInfo Culture
	{
		[CallerCount(Count = 0)]
		[NullableContext(1)]
		 get { } //Length: 94
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[NullableContext(1)]
		 set { } //Length: 13
	}

	public DateFormatHandling DateFormatHandling
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 55
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 91
	}

	[Nullable(1)]
	public string DateFormatString
	{
		[CallerCount(Count = 0)]
		[NullableContext(1)]
		 get { } //Length: 61
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[NullableContext(1)]
		 set { } //Length: 32
	}

	public DateParseHandling DateParseHandling
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 78
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 91
	}

	public DateTimeZoneHandling DateTimeZoneHandling
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 78
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 91
	}

	public DefaultValueHandling DefaultValueHandling
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 55
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 91
	}

	public IEqualityComparer EqualityComparer
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public EventHandler<ErrorEventArgs> Error
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public FloatFormatHandling FloatFormatHandling
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 55
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 91
	}

	public FloatParseHandling FloatParseHandling
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 55
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 91
	}

	public Formatting Formatting
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 55
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 91
	}

	public Nullable<Int32> MaxDepth
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 95
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 183
	}

	public MetadataPropertyHandling MetadataPropertyHandling
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 61
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 94
	}

	public MissingMemberHandling MissingMemberHandling
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 61
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 94
	}

	public NullValueHandling NullValueHandling
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 61
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 94
	}

	public ObjectCreationHandling ObjectCreationHandling
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 61
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 94
	}

	public PreserveReferencesHandling PreserveReferencesHandling
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 61
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 91
	}

	public ReferenceLoopHandling ReferenceLoopHandling
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 61
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 94
	}

	[Obsolete("ReferenceResolver property is obsolete. Use the ReferenceResolverProvider property to set the IReferenceResolver: settings.ReferenceResolverProvider = () => resolver")]
	public IReferenceResolver ReferenceResolver
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 25
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 213
	}

	public Func<IReferenceResolver> ReferenceResolverProvider
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public ISerializationBinder SerializationBinder
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public StringEscapeHandling StringEscapeHandling
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 55
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 91
	}

	public ITraceWriter TraceWriter
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	[Obsolete("TypeNameAssemblyFormat is obsolete. Use TypeNameAssemblyFormatHandling instead.")]
	public FormatterAssemblyStyle TypeNameAssemblyFormat
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 55
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 91
	}

	public TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 55
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 91
	}

	public TypeNameHandling TypeNameHandling
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 61
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 94
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[CallsUnknownMethods(Count = 1)]
	private static JsonSerializerSettings() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	[NullableContext(1)]
	public JsonSerializerSettings(JsonSerializerSettings original) { }

	[CalledBy(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonConverter[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Formatting), typeof(JsonConverter[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonConvert), Member = "DeserializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(JsonConverter[])}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DebuggerStepThrough]
	public JsonSerializerSettings() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public SerializationBinder get_Binder() { }

	[CallerCount(Count = 0)]
	public bool get_CheckAdditionalContent() { }

	[CallerCount(Count = 0)]
	public ConstructorHandling get_ConstructorHandling() { }

	[CallerCount(Count = 0)]
	public StreamingContext get_Context() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public IContractResolver get_ContractResolver() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[NullableContext(1)]
	public IList<JsonConverter> get_Converters() { }

	[CallerCount(Count = 0)]
	[NullableContext(1)]
	public CultureInfo get_Culture() { }

	[CallerCount(Count = 0)]
	public DateFormatHandling get_DateFormatHandling() { }

	[CallerCount(Count = 0)]
	[NullableContext(1)]
	public string get_DateFormatString() { }

	[CallerCount(Count = 0)]
	public DateParseHandling get_DateParseHandling() { }

	[CallerCount(Count = 0)]
	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	[CallerCount(Count = 0)]
	public DefaultValueHandling get_DefaultValueHandling() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public IEqualityComparer get_EqualityComparer() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public EventHandler<ErrorEventArgs> get_Error() { }

	[CallerCount(Count = 0)]
	public FloatFormatHandling get_FloatFormatHandling() { }

	[CallerCount(Count = 0)]
	public FloatParseHandling get_FloatParseHandling() { }

	[CallerCount(Count = 0)]
	public Formatting get_Formatting() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Nullable<Int32> get_MaxDepth() { }

	[CallerCount(Count = 0)]
	public MetadataPropertyHandling get_MetadataPropertyHandling() { }

	[CallerCount(Count = 0)]
	public MissingMemberHandling get_MissingMemberHandling() { }

	[CallerCount(Count = 0)]
	public NullValueHandling get_NullValueHandling() { }

	[CallerCount(Count = 0)]
	public ObjectCreationHandling get_ObjectCreationHandling() { }

	[CallerCount(Count = 0)]
	public PreserveReferencesHandling get_PreserveReferencesHandling() { }

	[CallerCount(Count = 0)]
	public ReferenceLoopHandling get_ReferenceLoopHandling() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public IReferenceResolver get_ReferenceResolver() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Func<IReferenceResolver> get_ReferenceResolverProvider() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ISerializationBinder get_SerializationBinder() { }

	[CallerCount(Count = 0)]
	public StringEscapeHandling get_StringEscapeHandling() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ITraceWriter get_TraceWriter() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public FormatterAssemblyStyle get_TypeNameAssemblyFormat() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TypeNameAssemblyFormatHandling get_TypeNameAssemblyFormatHandling() { }

	[CallerCount(Count = 0)]
	public TypeNameHandling get_TypeNameHandling() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void set_Binder(SerializationBinder value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_CheckAdditionalContent(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_ConstructorHandling(ConstructorHandling value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_Context(StreamingContext value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_ContractResolver(IContractResolver value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[NullableContext(1)]
	public void set_Converters(IList<JsonConverter> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NullableContext(1)]
	public void set_Culture(CultureInfo value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_DateFormatHandling(DateFormatHandling value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[NullableContext(1)]
	public void set_DateFormatString(string value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_DateParseHandling(DateParseHandling value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_DefaultValueHandling(DefaultValueHandling value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_EqualityComparer(IEqualityComparer value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Error(EventHandler<ErrorEventArgs> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_FloatFormatHandling(FloatFormatHandling value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_FloatParseHandling(FloatParseHandling value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_Formatting(Formatting value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public void set_MaxDepth(Nullable<Int32> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_MissingMemberHandling(MissingMemberHandling value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_NullValueHandling(NullValueHandling value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void set_ReferenceResolver(IReferenceResolver value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_ReferenceResolverProvider(Func<IReferenceResolver> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_SerializationBinder(ISerializationBinder value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_StringEscapeHandling(StringEscapeHandling value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_TraceWriter(ITraceWriter value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_TypeNameAssemblyFormat(FormatterAssemblyStyle value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_TypeNameAssemblyFormatHandling(TypeNameAssemblyFormatHandling value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_TypeNameHandling(TypeNameHandling value) { }

}

