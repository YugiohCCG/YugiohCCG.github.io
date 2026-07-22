namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
public class XmlNodeConverter : JsonConverter
{
	internal static readonly List<IXmlNode> EmptyChildNodes; //Field offset: 0x0
	private const string TextName = "#text"; //Field offset: 0x0
	private const string CommentName = "#comment"; //Field offset: 0x0
	private const string CDataName = "#cdata-section"; //Field offset: 0x0
	private const string WhitespaceName = "#whitespace"; //Field offset: 0x0
	private const string SignificantWhitespaceName = "#significant-whitespace"; //Field offset: 0x0
	private const string DeclarationName = "?xml"; //Field offset: 0x0
	private const string JsonNamespaceUri = "http://james.newtonking.com/projects/json"; //Field offset: 0x0
	[CompilerGenerated]
	[Nullable(2)]
	private string <DeserializeRootElementName>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <WriteArrayAttribute>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <OmitRootObject>k__BackingField; //Field offset: 0x19
	[CompilerGenerated]
	private bool <EncodeSpecialCharacters>k__BackingField; //Field offset: 0x1A

	[Nullable(2)]
	public string DeserializeRootElementName
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[NullableContext(2)]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[NullableContext(2)]
		 set { } //Length: 13
	}

	public bool EncodeSpecialCharacters
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool OmitRootObject
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool WriteArrayAttribute
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static XmlNodeConverter() { }

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public XmlNodeConverter() { }

	[CalledBy(Type = typeof(XmlNodeConverter), Member = "ReadElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(IXmlDocument), typeof(IXmlNode), typeof(string), typeof(XmlNamespaceManager)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlConvert), Member = "EncodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlNodeConverter), Member = "ConvertTokenToXmlValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonSerializationException))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	private static void AddAttribute(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, string attributeName, XmlNamespaceManager manager, string attributePrefix) { }

	[CalledBy(Type = typeof(XmlNodeConverter), Member = "ReadArrayElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(IXmlDocument), typeof(string), typeof(IXmlNode), typeof(XmlNamespaceManager)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNodeConverter), Member = "DeserializeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(IXmlDocument), typeof(XmlNamespaceManager), typeof(IXmlNode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document) { }

	[CalledBy(Type = typeof(XmlNodeConverter), Member = "SerializeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IXmlNode), typeof(XmlNamespaceManager), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private static bool AllSameName(IXmlNode node) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypeExtensions), Member = "AssignableToTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlNodeConverter), Member = "IsXmlNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlNodeConverter), Member = "IsXObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	public virtual bool CanConvert(Type valueType) { }

	[CalledBy(Type = typeof(XmlNodeConverter), Member = "DeserializeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(IXmlDocument), typeof(XmlNamespaceManager), typeof(string), typeof(IXmlNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNodeConverter), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(IXmlDocument), typeof(IXmlNode), typeof(string), typeof(string), typeof(XmlNamespaceManager), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNodeConverter), Member = "ReadAttributeElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(XmlNamespaceManager)}, ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.String, System.String>))]
	[CalledBy(Type = typeof(XmlNodeConverter), Member = "CreateInstruction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(IXmlDocument), typeof(IXmlNode), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNodeConverter), Member = "CreateDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(IXmlDocument), typeof(IXmlNode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonSerializationException))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(XmlDateTimeSerializationMode)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeUtils), Member = "ToSerializationMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeKind)}, ReturnType = typeof(XmlDateTimeSerializationMode))]
	[Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
	[Calls(Type = typeof(Convert), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(BigInteger), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 16)]
	private static string ConvertTokenToXmlValue(JsonReader reader) { }

	[CalledBy(Type = typeof(XmlNodeConverter), Member = "DeserializeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(IXmlDocument), typeof(XmlNamespaceManager), typeof(string), typeof(IXmlNode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonReader), Member = "ReadAndAssert", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNodeConverter), Member = "ConvertTokenToXmlValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonSerializationException))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 14)]
	private void CreateDocumentType(JsonReader reader, IXmlDocument document, IXmlNode currentNode) { }

	[CalledBy(Type = typeof(XmlNodeConverter), Member = "CreateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(IXmlDocument), typeof(IXmlNode), typeof(string), typeof(XmlNamespaceManager), typeof(string), typeof(System.Collections.Generic.Dictionary`2<System.String, System.String>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNodeConverter), Member = "ReadArrayElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(IXmlDocument), typeof(string), typeof(IXmlNode), typeof(XmlNamespaceManager)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlConvert), Member = "EncodeLocalName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "EncodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private IXmlElement CreateElement(string elementName, IXmlDocument document, string elementPrefix, XmlNamespaceManager manager) { }

	[CalledBy(Type = typeof(XmlNodeConverter), Member = "ReadElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(IXmlDocument), typeof(IXmlNode), typeof(string), typeof(XmlNamespaceManager)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlNodeConverter), Member = "CreateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IXmlDocument), typeof(string), typeof(XmlNamespaceManager)}, ReturnType = typeof(IXmlElement))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlConvert), Member = "EncodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MiscellaneousUtils), Member = "GetPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsInvalidInstructions]
	private void CreateElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string elementName, XmlNamespaceManager manager, string elementPrefix, Dictionary<String, String> attributeNameValues) { }

	[CalledBy(Type = typeof(XmlNodeConverter), Member = "DeserializeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(IXmlDocument), typeof(XmlNamespaceManager), typeof(string), typeof(IXmlNode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlNodeConverter), Member = "ConvertTokenToXmlValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReader), Member = "ReadAndAssert", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonSerializationException))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 15)]
	private void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName) { }

	[CalledBy(Type = typeof(XmlNodeConverter), Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonReader), Member = "ReadAndAssert", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNodeConverter), Member = "DeserializeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(IXmlDocument), typeof(XmlNamespaceManager), typeof(string), typeof(IXmlNode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MiscellaneousUtils), Member = "GetQualifiedNameParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlNodeConverter), Member = "AddJsonArrayAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IXmlElement), typeof(IXmlDocument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonSerializationException))]
	[CallsDeduplicatedMethods(Count = 25)]
	[CallsUnknownMethods(Count = 21)]
	private void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode) { }

	[CalledBy(Type = typeof(XmlNodeConverter), Member = "ReadArrayElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(IXmlDocument), typeof(string), typeof(IXmlNode), typeof(XmlNamespaceManager)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNodeConverter), Member = "DeserializeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(IXmlDocument), typeof(XmlNamespaceManager), typeof(IXmlNode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlNodeConverter), Member = "ConvertTokenToXmlValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(XmlNodeConverter), Member = "CreateInstruction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(IXmlDocument), typeof(IXmlNode), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlNodeConverter), Member = "CreateDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(IXmlDocument), typeof(IXmlNode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNodeConverter), Member = "ReadElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(IXmlDocument), typeof(IXmlNode), typeof(string), typeof(XmlNamespaceManager)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNodeConverter), Member = "ReadArrayElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(IXmlDocument), typeof(string), typeof(IXmlNode), typeof(XmlNamespaceManager)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	private void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode) { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[NullableContext(2)]
	public string get_DeserializeRootElementName() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_EncodeSpecialCharacters() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_OmitRootObject() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_WriteArrayAttribute() { }

	[CalledBy(Type = typeof(XmlNodeConverter), Member = "SerializeGroupedNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IXmlNode), typeof(XmlNamespaceManager), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNodeConverter), Member = "SerializeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IXmlNode), typeof(XmlNamespaceManager), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XmlNodeConverter), Member = "ResolveFullName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IXmlNode), typeof(XmlNamespaceManager)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 15)]
	private string GetPropertyName(IXmlNode node, XmlNamespaceManager manager) { }

	[CalledBy(Type = typeof(XmlNodeConverter), Member = "WriteGroupedNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(XmlNamespaceManager), typeof(bool), typeof(System.Collections.Generic.List`1<Newtonsoft.Json.Converters.IXmlNode>), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNodeConverter), Member = "WriteGroupedNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(XmlNamespaceManager), typeof(bool), typeof(IXmlNode), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNodeConverter), Member = "SerializeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IXmlNode), typeof(XmlNamespaceManager), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlConvert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	private bool IsArray(IXmlNode node) { }

	[CalledBy(Type = typeof(XmlNodeConverter), Member = "ReadAttributeElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(XmlNamespaceManager)}, ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.String, System.String>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	private bool IsNamespaceAttribute(string attributeName, out string prefix) { }

	[CalledBy(Type = typeof(XmlNodeConverter), Member = "CanConvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool IsXmlNode(Type valueType) { }

	[CalledBy(Type = typeof(XmlNodeConverter), Member = "CanConvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool IsXObject(Type valueType) { }

	[CalledBy(Type = typeof(XmlNodeConverter), Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Reverse", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 15)]
	private void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager) { }

	[CalledBy(Type = typeof(XmlNodeConverter), Member = "DeserializeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(IXmlDocument), typeof(XmlNamespaceManager), typeof(string), typeof(IXmlNode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MiscellaneousUtils), Member = "GetPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlNodeConverter), Member = "CreateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IXmlDocument), typeof(string), typeof(XmlNamespaceManager)}, ReturnType = typeof(IXmlElement))]
	[Calls(Type = typeof(XmlNodeConverter), Member = "DeserializeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(IXmlDocument), typeof(XmlNamespaceManager), typeof(string), typeof(IXmlNode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNodeConverter), Member = "AddJsonArrayAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IXmlElement), typeof(IXmlDocument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	private void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager) { }

	[CalledBy(Type = typeof(XmlNodeConverter), Member = "ReadElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(IXmlDocument), typeof(IXmlNode), typeof(string), typeof(XmlNamespaceManager)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonSerializationException))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlNodeConverter), Member = "IsNamespaceAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlNodeConverter), Member = "ConvertTokenToXmlValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReader), Member = "ReadAndAssert", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Nullable`1<System.Int32>), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallsUnknownMethods(Count = 15)]
	private Dictionary<String, String> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager) { }

	[CalledBy(Type = typeof(XmlNodeConverter), Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlNodeConverter), Member = "DeserializeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(IXmlDocument), typeof(XmlNamespaceManager), typeof(string), typeof(IXmlNode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonReader), Member = "ReadAndAssert", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNodeConverter), Member = "CreateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(IXmlDocument), typeof(IXmlNode), typeof(string), typeof(XmlNamespaceManager), typeof(string), typeof(System.Collections.Generic.Dictionary`2<System.String, System.String>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNodeConverter), Member = "ReadAttributeElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(XmlNamespaceManager)}, ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.String, System.String>))]
	[Calls(Type = typeof(MiscellaneousUtils), Member = "GetPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlNodeConverter), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(IXmlDocument), typeof(IXmlNode), typeof(string), typeof(string), typeof(XmlNamespaceManager), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonSerializationException))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 6)]
	private void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NameTable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlDocument), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonReader), Member = "ReadAndAssert", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNodeConverter), Member = "DeserializeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(IXmlDocument), typeof(XmlNamespaceManager), typeof(IXmlNode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNodeConverter), Member = "ReadElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(IXmlDocument), typeof(IXmlNode), typeof(string), typeof(XmlNamespaceManager)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XNode), Member = "Remove", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonSerializationException))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 24)]
	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	[CalledBy(Type = typeof(XmlNodeConverter), Member = "GetPropertyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IXmlNode), typeof(XmlNamespaceManager)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlConvert), Member = "DecodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private string ResolveFullName(IXmlNode node, XmlNamespaceManager manager) { }

	[CalledBy(Type = typeof(XmlNodeConverter), Member = "SerializeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IXmlNode), typeof(XmlNamespaceManager), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlNodeConverter), Member = "GetPropertyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IXmlNode), typeof(XmlNamespaceManager)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlNodeConverter), Member = "WriteGroupedNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(XmlNamespaceManager), typeof(bool), typeof(System.Collections.Generic.List`1<Newtonsoft.Json.Converters.IXmlNode>), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNodeConverter), Member = "WriteGroupedNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(XmlNamespaceManager), typeof(bool), typeof(IXmlNode), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 17)]
	private void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) { }

	[CalledBy(Type = typeof(XmlNodeConverter), Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNodeConverter), Member = "WriteGroupedNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(XmlNamespaceManager), typeof(bool), typeof(System.Collections.Generic.List`1<Newtonsoft.Json.Converters.IXmlNode>), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNodeConverter), Member = "WriteGroupedNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(XmlNamespaceManager), typeof(bool), typeof(IXmlNode), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNodeConverter), Member = "SerializeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IXmlNode), typeof(XmlNamespaceManager), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlNodeConverter), Member = "SerializeGroupedNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IXmlNode), typeof(XmlNamespaceManager), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNodeConverter), Member = "SerializeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IXmlNode), typeof(XmlNamespaceManager), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNodeConverter), Member = "ValueAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Newtonsoft.Json.Converters.IXmlNode>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlConvert), Member = "DecodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(XmlNodeConverter), Member = "AllSameName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IXmlNode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlNodeConverter), Member = "IsArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IXmlNode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlNodeConverter), Member = "GetPropertyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IXmlNode), typeof(XmlNamespaceManager)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 42)]
	[CallsUnknownMethods(Count = 63)]
	private void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[NullableContext(2)]
	public void set_DeserializeRootElementName(string value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_EncodeSpecialCharacters(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_OmitRootObject(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_WriteArrayAttribute(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool ShouldReadInto(JsonReader reader) { }

	[CalledBy(Type = typeof(XmlNodeConverter), Member = "SerializeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IXmlNode), typeof(XmlNamespaceManager), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	private bool ValueAttributes(List<IXmlNode> c) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XContainerWrapper), Member = "WrapNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XObject)}, ReturnType = typeof(IXmlNode))]
	[Calls(Type = typeof(XmlNodeWrapper), Member = "WrapNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(IXmlNode))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private IXmlNode WrapXml(object value) { }

	[CalledBy(Type = typeof(XmlNodeConverter), Member = "SerializeGroupedNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IXmlNode), typeof(XmlNamespaceManager), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlNodeConverter), Member = "IsArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IXmlNode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlNodeConverter), Member = "SerializeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IXmlNode), typeof(XmlNamespaceManager), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, IXmlNode node, string elementNames) { }

	[CalledBy(Type = typeof(XmlNodeConverter), Member = "SerializeGroupedNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IXmlNode), typeof(XmlNamespaceManager), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlNodeConverter), Member = "IsArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IXmlNode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlNodeConverter), Member = "SerializeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IXmlNode), typeof(XmlNamespaceManager), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	private void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, List<IXmlNode> groupedNodes, string elementNames) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XContainerWrapper), Member = "WrapNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XObject)}, ReturnType = typeof(IXmlNode))]
	[Calls(Type = typeof(XmlNodeWrapper), Member = "WrapNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(IXmlNode))]
	[Calls(Type = typeof(NameTable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNodeConverter), Member = "PushParentNamespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IXmlNode), typeof(XmlNamespaceManager)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNodeConverter), Member = "SerializeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(IXmlNode), typeof(XmlNamespaceManager), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

