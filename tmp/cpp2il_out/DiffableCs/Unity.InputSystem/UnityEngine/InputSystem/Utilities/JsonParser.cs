namespace UnityEngine.InputSystem.Utilities;

internal struct JsonParser
{
	internal struct JsonString : IEquatable<JsonString>
	{
		public Substring text; //Field offset: 0x0
		public bool hasEscapes; //Field offset: 0x10

		[CalledBy(Type = typeof(JsonString), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(JsonString), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonString), typeof(JsonString)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(JsonString), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonString), typeof(JsonString)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(JsonValue), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(JsonValue), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonValue)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(Substring), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(char), Member = "ToUpperInvariant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(Substring), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Substring), typeof(Substring), typeof(StringComparison)}, ReturnType = typeof(int))]
		[ContainsUnimplementedInstructions]
		public override bool Equals(JsonString other) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonString), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonString)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		public virtual bool Equals(object obj) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Substring), Member = "GetHashCode", ReturnType = typeof(int))]
		[Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
		public virtual int GetHashCode() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonString), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonString)}, ReturnType = typeof(bool))]
		public static bool op_Equality(JsonString left, JsonString right) { }

		[CalledBy(Type = typeof(InputManager), Member = "TryMatchDisconnectedDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputDevice))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Substring), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Substring))]
		[CallsUnknownMethods(Count = 1)]
		public static JsonString op_Implicit(string str) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonString), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonString)}, ReturnType = typeof(bool))]
		public static bool op_Inequality(JsonString left, JsonString right) { }

		[CalledBy(Type = typeof(JsonValue), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Substring), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(Substring), Member = "ToString", ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public virtual string ToString() { }

	}

	internal struct JsonValue : IEquatable<JsonValue>
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func<JsonValue, String> <>9__11_0; //Field offset: 0x8
			public static Func<KeyValuePair`2<String, JsonValue>, String> <>9__11_1; //Field offset: 0x10

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private static <>c() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(JsonValue), Member = "ToString", ReturnType = typeof(string))]
			internal string <ToString>b__11_0(JsonValue x) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
			internal string <ToString>b__11_1(KeyValuePair<String, JsonValue> pair) { }

		}

		public JsonValueType type; //Field offset: 0x0
		public bool boolValue; //Field offset: 0x4
		public double realValue; //Field offset: 0x8
		public long integerValue; //Field offset: 0x10
		public JsonString stringValue; //Field offset: 0x18
		public List<JsonValue> arrayValue; //Field offset: 0x30
		public Dictionary<String, JsonValue> objectValue; //Field offset: 0x38
		public object anyValue; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonValue), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		public virtual bool Equals(object obj) { }

		[CalledBy(Type = typeof(JsonValue), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(JsonValue), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Substring), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Substring))]
		[Calls(Type = typeof(JsonString), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonString)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(long), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int64&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(double), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Double&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(float), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Single&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(Enum), Member = "GetName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(long))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 16)]
		[ContainsUnimplementedInstructions]
		private static bool Equals(object obj, JsonValue value) { }

		[CalledBy(Type = typeof(JsonValue), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(JsonValue), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue), typeof(JsonValue)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(JsonValue), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue), typeof(JsonValue)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(JsonParser), Member = "CurrentPropertyHasValueEqualTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(JsonValue), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonValue)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(JsonString), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonString)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 9)]
		[ContainsUnimplementedInstructions]
		public override bool Equals(JsonValue other) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
		[Calls(Type = typeof(Substring), Member = "GetHashCode", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 4)]
		public virtual int GetHashCode() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonValue), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue)}, ReturnType = typeof(bool))]
		public static bool op_Equality(JsonValue left, JsonValue right) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public static JsonValue op_Implicit(JsonString str) { }

		[CallerCount(Count = 0)]
		public static JsonValue op_Implicit(bool val) { }

		[CallerCount(Count = 0)]
		public static JsonValue op_Implicit(long val) { }

		[CallerCount(Count = 0)]
		public static JsonValue op_Implicit(double val) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Substring), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Substring))]
		[CallsUnknownMethods(Count = 2)]
		public static JsonValue op_Implicit(string str) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public static JsonValue op_Implicit(List<JsonValue> array) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public static JsonValue op_Implicit(Dictionary<String, JsonValue> obj) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public static JsonValue op_Implicit(Enum val) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonValue), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue)}, ReturnType = typeof(bool))]
		public static bool op_Inequality(JsonValue left, JsonValue right) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonValue), Member = "ToString", ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public bool ToBoolean() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonValue), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(Convert), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
		[ContainsUnimplementedInstructions]
		public double ToDouble() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonValue), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
		[ContainsUnimplementedInstructions]
		public long ToInteger() { }

		[CalledBy(Type = typeof(<>c), Member = "<ToString>b__11_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(JsonValue), Member = "ToBoolean", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(JsonValue), Member = "ToInteger", ReturnType = typeof(long))]
		[CalledBy(Type = typeof(JsonValue), Member = "ToDouble", ReturnType = typeof(double))]
		[CalledBy(Type = typeof(JsonValue), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonValue)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(ValueType), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(double), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(long), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(JsonString), Member = "ToString", ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		public virtual string ToString() { }

	}

	internal enum JsonValueType
	{
		None = 0,
		Bool = 1,
		Real = 2,
		Integer = 3,
		String = 4,
		Array = 5,
		Object = 6,
		Any = 7,
	}

	private readonly string m_Text; //Field offset: 0x0
	private readonly int m_Length; //Field offset: 0x8
	private int m_Position; //Field offset: 0xC
	private bool m_MatchAnyElementInArray; //Field offset: 0x10
	private bool m_DryRun; //Field offset: 0x11

	public bool isAtEnd
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 10
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public JsonParser(string json) { }

	[CalledBy(Type = typeof(InputDeviceDescription), Member = "ComparePropertyToDeviceDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonString), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputDeviceMatcher), Member = "MatchPercentage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JsonParser), Member = "ParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(JsonValue), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool CurrentPropertyHasValueEqualTo(JsonValue expectedValue) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_isAtEnd() { }

	[CalledBy(Type = typeof(InputDeviceDescription), Member = "ComparePropertyToDeviceDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonString), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputDeviceMatcher), Member = "MatchPercentage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonParser), Member = "ParseToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonParser), Member = "SkipWhitespace", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(JsonParser), Member = "SkipToValue", ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonParser), Member = "ParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	public bool NavigateToProperty(string path) { }

	[CalledBy(Type = typeof(JsonParser), Member = "ParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonParser), Member = "SkipWhitespace", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(JsonParser), Member = "ParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public bool ParseArrayValue(out JsonValue result) { }

	[CalledBy(Type = typeof(JsonParser), Member = "ParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonParser), Member = "SkipWhitespace", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 2)]
	public bool ParseBooleanValue(out JsonValue result) { }

	[CalledBy(Type = typeof(JsonParser), Member = "ParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonParser), Member = "SkipWhitespace", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	public bool ParseNullValue(out JsonValue result) { }

	[CalledBy(Type = typeof(JsonParser), Member = "ParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonParser), Member = "SkipWhitespace", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public bool ParseNumber(out JsonValue result) { }

	[CalledBy(Type = typeof(JsonParser), Member = "ParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonParser), Member = "ParseToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(JsonParser), Member = "ParseStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonParser), Member = "SkipToValue", ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonParser), Member = "ParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonParser), Member = "SkipWhitespace", ReturnType = typeof(void))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public bool ParseObjectValue(out JsonValue result) { }

	[CalledBy(Type = typeof(JsonParser), Member = "ParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonParser), Member = "ParseObjectValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JsonParser), Member = "SkipWhitespace", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public bool ParseStringValue(out JsonValue result) { }

	[CalledBy(Type = typeof(JsonParser), Member = "NavigateToProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonParser), Member = "ParseObjectValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(JsonParser), Member = "SkipWhitespace", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool ParseToken(char token) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonParser), Member = "ParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue&)}, ReturnType = typeof(bool))]
	public bool ParseValue() { }

	[CalledBy(Type = typeof(JsonParser), Member = "NavigateToProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonParser), Member = "CurrentPropertyHasValueEqualTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonParser), Member = "ParseValue", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonParser), Member = "ParseArrayValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonParser), Member = "ParseObjectValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(JsonParser), Member = "SkipWhitespace", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(JsonParser), Member = "ParseNullValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonParser), Member = "ParseObjectValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonParser), Member = "ParseStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonParser), Member = "ParseArrayValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonParser), Member = "ParseBooleanValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonParser), Member = "ParseNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool ParseValue(out JsonValue result) { }

	[CallerCount(Count = 0)]
	public void Reset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonParser), Member = "SkipWhitespace", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	private bool SkipString(string text) { }

	[CalledBy(Type = typeof(JsonParser), Member = "NavigateToProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonParser), Member = "ParseObjectValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(JsonParser), Member = "SkipWhitespace", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool SkipToValue() { }

	[CalledBy(Type = typeof(JsonParser), Member = "NavigateToProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonParser), Member = "ParseToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonParser), Member = "ParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonParser), Member = "ParseStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonParser), Member = "ParseArrayValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonParser), Member = "ParseObjectValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonParser), Member = "ParseNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonParser), Member = "ParseBooleanValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonParser), Member = "ParseNullValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonParser), Member = "SkipToValue", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonParser), Member = "SkipString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private void SkipWhitespace() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueType), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

}

