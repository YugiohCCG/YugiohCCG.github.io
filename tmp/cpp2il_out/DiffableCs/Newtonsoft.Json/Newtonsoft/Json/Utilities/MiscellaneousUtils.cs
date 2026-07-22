namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
internal static class MiscellaneousUtils
{

	[CallerCount(Count = 13327)]
	[Conditional("DEBUG")]
	[DeduplicatedMethod]
	[NullableContext(2)]
	public static void Assert(bool condition, string message = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(byte), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public static int ByteArrayCompare(Byte[] a1, Byte[] a2) { }

	[CalledBy(Type = typeof(JsonWriter), Member = "WriteToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeUtils), Member = "ToSerializationMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeKind)}, ReturnType = typeof(XmlDateTimeSerializationMode))]
	[CalledBy(Type = typeof(JTokenReader), Member = "GetEndToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JContainer)}, ReturnType = typeof(System.Nullable`1<Newtonsoft.Json.JsonToken>))]
	[CalledBy(Type = typeof(JTokenReader), Member = "SetEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JContainer)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JTokenReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JValue), Member = "WriteToAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(CancellationToken), typeof(JsonConverter[])}, ReturnType = typeof(Task))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	public static ArgumentOutOfRangeException CreateArgumentOutOfRangeException(string paramName, object actualValue, string message) { }

	[CalledBy(Type = typeof(XDocumentWrapper), Member = "CreateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(IXmlElement))]
	[CalledBy(Type = typeof(XDocumentWrapper), Member = "CreateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(IXmlNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringUtils), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 4)]
	public static string GetLocalName(string qualifiedName) { }

	[CalledBy(Type = typeof(XmlNodeConverter), Member = "ReadElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(IXmlDocument), typeof(IXmlNode), typeof(string), typeof(XmlNamespaceManager)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNodeConverter), Member = "CreateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(IXmlDocument), typeof(IXmlNode), typeof(string), typeof(XmlNamespaceManager), typeof(string), typeof(System.Collections.Generic.Dictionary`2<System.String, System.String>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNodeConverter), Member = "ReadArrayElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(IXmlDocument), typeof(string), typeof(IXmlNode), typeof(XmlNamespaceManager)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StringUtils), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 4)]
	public static string GetPrefix(string qualifiedName) { }

	[CalledBy(Type = typeof(XmlNodeConverter), Member = "DeserializeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(IXmlDocument), typeof(XmlNamespaceManager), typeof(IXmlNode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringUtils), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 4)]
	public static void GetQualifiedNameParts(string qualifiedName, out string prefix, out string localName) { }

	[CalledBy(Type = typeof(BooleanQueryExpression), Member = "RegexEquals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JValue), typeof(JValue), typeof(JsonSelectSettings)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RegexConverter), Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RegexConverter), Member = "ReadRegexString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	internal static RegexOptions GetRegexOptions(string optionsText) { }

	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "EnsureType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(object), typeof(CultureInfo), typeof(JsonContract), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(JToken))]
	[CalledBy(Type = typeof(JArray), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JConstructor), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(JToken))]
	[CalledBy(Type = typeof(JConstructor), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JObject), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(JToken))]
	[CalledBy(Type = typeof(JObject), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StringEnumConverter), Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(object))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string ToString(object value) { }

	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "ShouldWriteDynamicProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "SetPropertyValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonProperty), typeof(JsonConverter), typeof(JsonContainerContract), typeof(JsonProperty), typeof(JsonReader), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CalculatePropertyDetails", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonProperty), typeof(JsonConverter&), typeof(JsonContainerContract), typeof(JsonProperty), typeof(JsonReader), typeof(object), typeof(Boolean&), typeof(Object&), typeof(JsonContract&), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ShouldSetPropertyValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonProperty), typeof(JsonObjectContract), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "ShouldWriteProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonObjectContract), typeof(JsonProperty)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "CalculatePropertyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonContainerContract), typeof(JsonProperty), typeof(JsonProperty), typeof(JsonContract&), typeof(Object&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDynamic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IDynamicMetaObjectProvider), typeof(JsonDynamicContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Decimal), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ConvertUtils), Member = "IsInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[NullableContext(2)]
	public static bool ValueEquals(object objA, object objB) { }

}

