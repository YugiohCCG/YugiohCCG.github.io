namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
internal struct JsonPosition
{
	private static readonly Char[] SpecialCharacters; //Field offset: 0x0
	internal JsonContainerType Type; //Field offset: 0x0
	internal int Position; //Field offset: 0x4
	[Nullable(2)]
	internal string PropertyName; //Field offset: 0x8
	internal bool HasIndex; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static JsonPosition() { }

	[CalledBy(Type = typeof(JsonWriter), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonContainerType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonWriter), Member = "InternalWriteStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(JsonContainerType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JToken), Member = "get_Path", ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public JsonPosition(JsonContainerType type) { }

	[CalledBy(Type = typeof(JsonReader), Member = "get_Path", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonWriter), Member = "get_ContainerPath", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonWriter), Member = "get_Path", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JToken), Member = "get_Path", ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonPosition), Member = "WriteTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(StringWriter&), typeof(Char[]&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	internal static string BuildPath(List<JsonPosition> positions, Nullable<JsonPosition> currentPosition) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal int CalculateLength() { }

	[CallerCount(Count = 40)]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal static string FormatMessage(IJsonLineInfo lineInfo, string path, string message) { }

	[CallerCount(Count = 14)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal static bool TypeHasIndex(JsonContainerType type) { }

	[CalledBy(Type = typeof(JsonPosition), Member = "BuildPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Newtonsoft.Json.JsonPosition>), typeof(System.Nullable`1<Newtonsoft.Json.JsonPosition>)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JavaScriptUtils), Member = "WriteEscapedJavaScriptString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(string), typeof(char), typeof(bool), typeof(Boolean[]), typeof(StringEscapeHandling), typeof(Newtonsoft.Json.IArrayPool`1<System.Char>), typeof(Char[]&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[NullableContext(2)]
	internal void WriteTo(StringBuilder sb, ref StringWriter writer, ref Char[] buffer) { }

}

