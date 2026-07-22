namespace Newtonsoft.Json;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
public class JsonValidatingReader : JsonReader, IJsonLineInfo
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<JsonSchemaModel, Boolean> <>9__50_0; //Field offset: 0x8
		public static Func<JsonSchemaModel, Boolean> <>9__50_1; //Field offset: 0x10
		public static Func<JsonSchemaModel, Boolean> <>9__50_2; //Field offset: 0x18
		public static Func<Boolean, Boolean> <>9__51_0; //Field offset: 0x20
		public static Func<KeyValuePair`2<String, Boolean>, Boolean> <>9__51_1; //Field offset: 0x28
		public static Func<KeyValuePair`2<String, Boolean>, String> <>9__51_2; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		internal bool <ValidateEndObject>b__51_0(bool v) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal bool <ValidateEndObject>b__51_1(KeyValuePair<String, Boolean> kv) { }

		[CallerCount(Count = 0)]
		internal string <ValidateEndObject>b__51_2(KeyValuePair<String, Boolean> kv) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal bool <WriteToken>b__50_0(JsonSchemaModel s) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal bool <WriteToken>b__50_1(JsonSchemaModel s) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal bool <WriteToken>b__50_2(JsonSchemaModel s) { }

	}

	private class SchemaScope
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func<String, String> <>9__27_0; //Field offset: 0x8
			public static Func<String, Boolean> <>9__27_1; //Field offset: 0x10
			public static Func<JsonSchemaModel, Boolean> <>9__27_2; //Field offset: 0x18
			public static Func<KeyValuePair`2<String, JsonSchemaModel>, Boolean> <>9__28_0; //Field offset: 0x20
			public static Func<KeyValuePair`2<String, JsonSchemaModel>, String> <>9__28_1; //Field offset: 0x28

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private static <>c() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c() { }

			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			internal string <.ctor>b__27_0(string p) { }

			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			internal bool <.ctor>b__27_1(string p) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			internal bool <.ctor>b__27_2(JsonSchemaModel s) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal bool <GetRequiredProperties>b__28_0(KeyValuePair<String, JsonSchemaModel> p) { }

			[CallerCount(Count = 0)]
			internal string <GetRequiredProperties>b__28_1(KeyValuePair<String, JsonSchemaModel> p) { }

		}

		private readonly JTokenType _tokenType; //Field offset: 0x10
		private readonly IList<JsonSchemaModel> _schemas; //Field offset: 0x18
		private readonly Dictionary<String, Boolean> _requiredProperties; //Field offset: 0x20
		[CompilerGenerated]
		private string <CurrentPropertyName>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		private int <ArrayItemCount>k__BackingField; //Field offset: 0x30
		[CompilerGenerated]
		private readonly bool <IsUniqueArray>k__BackingField; //Field offset: 0x34
		[CompilerGenerated]
		private readonly IList<JToken> <UniqueArrayItems>k__BackingField; //Field offset: 0x38
		[CompilerGenerated]
		private JTokenWriter <CurrentItemWriter>k__BackingField; //Field offset: 0x40

		public int ArrayItemCount
		{
			[CallerCount(Count = 3)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 4
			[CallerCount(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 4
		}

		public JTokenWriter CurrentItemWriter
		{
			[CallerCount(Count = 12)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		public string CurrentPropertyName
		{
			[CallerCount(Count = 15)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		public bool IsUniqueArray
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public Dictionary<String, Boolean> RequiredProperties
		{
			[CallerCount(Count = 12)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public IList<JsonSchemaModel> Schemas
		{
			[CallerCount(Count = 31)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public JTokenType TokenType
		{
			[CallerCount(Count = 94)]
			[DeduplicatedMethod]
			 get { } //Length: 4
		}

		public IList<JToken> UniqueArrayItems
		{
			[CallerCount(Count = 38)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateCurrentToken", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Enumerable), Member = "Distinct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
		[Calls(Type = typeof(Enumerable), Member = "ToDictionary", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(bool)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Boolean>))]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 6)]
		public SchemaScope(JTokenType tokenType, IList<JsonSchemaModel> schemas) { }

		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public int get_ArrayItemCount() { }

		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public JTokenWriter get_CurrentItemWriter() { }

		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public string get_CurrentPropertyName() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public bool get_IsUniqueArray() { }

		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		public Dictionary<String, Boolean> get_RequiredProperties() { }

		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		public IList<JsonSchemaModel> get_Schemas() { }

		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		public JTokenType get_TokenType() { }

		[CallerCount(Count = 38)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public IList<JToken> get_UniqueArrayItems() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		private IEnumerable<String> GetRequiredProperties(JsonSchemaModel schema) { }

		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_ArrayItemCount(int value) { }

		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_CurrentItemWriter(JTokenWriter value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_CurrentPropertyName(string value) { }

	}

	private static readonly IList<JsonSchemaModel> EmptySchemaList; //Field offset: 0x0
	private readonly JsonReader _reader; //Field offset: 0x78
	private readonly Stack<SchemaScope> _stack; //Field offset: 0x80
	private JsonSchema _schema; //Field offset: 0x88
	private JsonSchemaModel _model; //Field offset: 0x90
	private SchemaScope _currentScope; //Field offset: 0x98
	[CompilerGenerated]
	private ValidationEventHandler ValidationEventHandler; //Field offset: 0xA0

	public event ValidationEventHandler ValidationEventHandler
	{
		[CalledBy(Type = typeof(Extensions), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken), typeof(JsonSchema), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 remove { } //Length: 146
	}

	private IList<JsonSchemaModel> CurrentMemberSchemas
	{
		[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateCurrentToken", ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 71)]
		private get { } //Length: 2500
	}

	private IList<JsonSchemaModel> CurrentSchemas
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 30
	}

	public virtual int Depth
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	private override int Newtonsoft.Json.IJsonLineInfo.LineNumber
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 89
	}

	private override int Newtonsoft.Json.IJsonLineInfo.LinePosition
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 89
	}

	public virtual string Path
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public private virtual char QuoteChar
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		private set { } //Length: 3
	}

	public JsonReader Reader
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public JsonSchema Schema
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CalledBy(Type = typeof(Extensions), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken), typeof(JsonSchema), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		 set { } //Length: 165
	}

	public virtual JsonToken TokenType
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public virtual object Value
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public virtual Type ValueType
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static JsonValidatingReader() { }

	[CalledBy(Type = typeof(Extensions), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken), typeof(JsonSchema), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonReader), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public JsonValidatingReader(JsonReader reader) { }

	[CalledBy(Type = typeof(Extensions), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken), typeof(JsonSchema), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonReader), Member = "Close", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void Close() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static double FloatingPointRemainder(double dividend, double divisor) { }

	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateCurrentToken", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 71)]
	private IList<JsonSchemaModel> get_CurrentMemberSchemas() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private IList<JsonSchemaModel> get_CurrentSchemas() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int get_Depth() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string get_Path() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual char get_QuoteChar() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public JsonReader get_Reader() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public JsonSchema get_Schema() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual JsonToken get_TokenType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual object get_Value() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual Type get_ValueType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	private Nullable<JsonSchemaType> GetCurrentNodeSchemaType() { }

	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateCurrentToken", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidatePropertyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private bool IsPropertyDefinied(JsonSchemaModel schema, string propertyName) { }

	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static bool IsZero(double value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private override int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private override int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private override bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValidationEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaException)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void OnValidationEvent(JsonSchemaException exception) { }

	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateCurrentToken", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(Stack`1), Member = "Peek", ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	private SchemaScope Pop() { }

	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateCurrentToken", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonValidatingReader), Member = "RaiseError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private void ProcessValue() { }

	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateCurrentToken", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void Push(SchemaScope scope) { }

	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateNotDisallowed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "TestType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel), typeof(JsonSchemaType)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ProcessValue", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidatePropertyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateEndArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateEndObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "WriteToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<Newtonsoft.Json.Schema.JsonSchemaModel>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateCurrentToken", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValidationEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaException)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private void RaiseError(string message, JsonSchemaModel schema) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonValidatingReader), Member = "ValidateCurrentToken", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Read() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonValidatingReader), Member = "ValidateCurrentToken", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Nullable<Boolean> ReadAsBoolean() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonValidatingReader), Member = "ValidateCurrentToken", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Byte[] ReadAsBytes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonValidatingReader), Member = "ValidateCurrentToken", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Nullable<DateTime> ReadAsDateTime() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonValidatingReader), Member = "ValidateCurrentToken", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonValidatingReader), Member = "ValidateCurrentToken", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Nullable<Decimal> ReadAsDecimal() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonValidatingReader), Member = "ValidateCurrentToken", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Nullable<Double> ReadAsDouble() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonValidatingReader), Member = "ValidateCurrentToken", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Nullable<Int32> ReadAsInt32() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonValidatingReader), Member = "ValidateCurrentToken", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ReadAsString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected private virtual void set_QuoteChar(char value) { }

	[CalledBy(Type = typeof(Extensions), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken), typeof(JsonSchema), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void set_Schema(JsonSchema value) { }

	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateCurrentToken", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(JsonSchemaGenerator), Member = "HasFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<Newtonsoft.Json.Schema.JsonSchemaType>), typeof(JsonSchemaType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonValidatingReader), Member = "RaiseError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool TestType(JsonSchemaModel currentSchema, JsonSchemaType currentType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonValidatingReader), Member = "TestType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel), typeof(JsonSchemaType)}, ReturnType = typeof(bool))]
	private bool ValidateArray(JsonSchemaModel schema) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonValidatingReader), Member = "TestType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel), typeof(JsonSchemaType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonValidatingReader), Member = "ValidateNotDisallowed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	private void ValidateBoolean(JsonSchemaModel schema) { }

	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ReadAsInt32", ReturnType = typeof(System.Nullable`1<System.Int32>))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ReadAsBytes", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ReadAsDecimal", ReturnType = typeof(System.Nullable`1<System.Decimal>))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ReadAsDouble", ReturnType = typeof(System.Nullable`1<System.Double>))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ReadAsBoolean", ReturnType = typeof(System.Nullable`1<System.Boolean>))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ReadAsString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ReadAsDateTime", ReturnType = typeof(System.Nullable`1<System.DateTime>))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ReadAsDateTimeOffset", ReturnType = typeof(System.Nullable`1<System.DateTimeOffset>))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "Read", ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonValidatingReader), Member = "RaiseError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonValidatingReader), Member = "ValidateInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonValidatingReader), Member = "ValidateFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonValidatingReader), Member = "ValidateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonValidatingReader), Member = "Pop", ReturnType = typeof(SchemaScope))]
	[Calls(Type = typeof(JsonValidatingReader), Member = "ValidateNotDisallowed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonValidatingReader), Member = "ValidateEndObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonValidatingReader), Member = "ValidateEndArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonValidatingReader), Member = "IsPropertyDefinied", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonValidatingReader), Member = "TestType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel), typeof(JsonSchemaType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Boolean>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(Convert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(JsonValidatingReader), Member = "WriteToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<Newtonsoft.Json.Schema.JsonSchemaModel>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(JsonValidatingReader), Member = "ProcessValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonValidatingReader), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaScope)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaScope), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JTokenType), typeof(System.Collections.Generic.IList`1<Newtonsoft.Json.Schema.JsonSchemaModel>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonValidatingReader), Member = "get_CurrentMemberSchemas", ReturnType = typeof(System.Collections.Generic.IList`1<Newtonsoft.Json.Schema.JsonSchemaModel>))]
	[Calls(Type = typeof(JsonTokenUtils), Member = "IsStartToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonSchemaModelBuilder), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchema)}, ReturnType = typeof(JsonSchemaModel))]
	[Calls(Type = typeof(JsonSchemaModelBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 77)]
	private void ValidateCurrentToken() { }

	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateCurrentToken", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonValidatingReader), Member = "RaiseError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void ValidateEndArray(JsonSchemaModel schema) { }

	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateCurrentToken", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonValidatingReader), Member = "RaiseError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void ValidateEndObject(JsonSchemaModel schema) { }

	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateCurrentToken", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonValidatingReader), Member = "TestType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel), typeof(JsonSchemaType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonValidatingReader), Member = "ValidateNotDisallowed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonValidatingReader), Member = "RaiseError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonValidatingReader), Member = "IsZero", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void ValidateFloat(JsonSchemaModel schema) { }

	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateCurrentToken", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Nullable`1<System.Double>), Member = "get_Value", ReturnType = typeof(double))]
	[Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(BigInteger), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(long)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BigInteger), Member = "op_Modulus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(double), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Math), Member = "Truncate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(JsonValidatingReader), Member = "RaiseError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonValidatingReader), Member = "IsZero", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(JValue), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JTokenType), typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(JsonValidatingReader), Member = "ValidateNotDisallowed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonValidatingReader), Member = "TestType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel), typeof(JsonSchemaType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private void ValidateInteger(JsonSchemaModel schema) { }

	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateCurrentToken", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(JsonSchemaGenerator), Member = "HasFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<Newtonsoft.Json.Schema.JsonSchemaType>), typeof(JsonSchemaType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonValidatingReader), Member = "RaiseError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 2)]
	private void ValidateNotDisallowed(JsonSchemaModel schema) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonValidatingReader), Member = "TestType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel), typeof(JsonSchemaType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonValidatingReader), Member = "ValidateNotDisallowed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	private void ValidateNull(JsonSchemaModel schema) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonValidatingReader), Member = "TestType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel), typeof(JsonSchemaType)}, ReturnType = typeof(bool))]
	private bool ValidateObject(JsonSchemaModel schema) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Boolean>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonValidatingReader), Member = "IsPropertyDefinied", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonValidatingReader), Member = "RaiseError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ValidatePropertyName(JsonSchemaModel schema) { }

	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateCurrentToken", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonValidatingReader), Member = "TestType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel), typeof(JsonSchemaType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonValidatingReader), Member = "ValidateNotDisallowed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonValidatingReader), Member = "RaiseError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	private void ValidateString(JsonSchemaModel schema) { }

	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateCurrentToken", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(JTokenWriter), Member = "get_Token", ReturnType = typeof(JToken))]
	[Calls(Type = typeof(JsonValidatingReader), Member = "RaiseError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CollectionUtils), Member = "ContainsValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "TSource", "System.Collections.Generic.IEqualityComparer`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JToken), Member = "get_EqualityComparer", ReturnType = typeof(JTokenEqualityComparer))]
	[Calls(Type = typeof(JsonWriter), Member = "get_Top", ReturnType = typeof(int))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JTokenWriter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonTokenUtils), Member = "IsEndToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Stack`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Stack`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(object), typeof(System.Collections.Generic.IEqualityComparer`1<System.Object>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 29)]
	[ContainsUnimplementedInstructions]
	private void WriteToken(IList<JsonSchemaModel> schemas) { }

}

