namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
internal class JsonFormatterConverter : IFormatterConverter
{
	private readonly JsonSerializerInternalReader _reader; //Field offset: 0x10
	private readonly JsonISerializableContract _contract; //Field offset: 0x18
	[Nullable(2)]
	private readonly JsonProperty _member; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public JsonFormatterConverter(JsonSerializerInternalReader reader, JsonISerializableContract contract, JsonProperty member) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonSerializerInternalReader), Member = "GetContractSafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonContract))]
	[Calls(Type = typeof(JsonSerializer), Member = "GetMatchingConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(JsonConverter))]
	[Calls(Type = typeof(JToken), Member = "CreateReader", ReturnType = typeof(JsonReader))]
	[Calls(Type = typeof(JsonReader), Member = "set_MaxDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReader), Member = "ReadAndAssert", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonSerializerInternalReader), Member = "DeserializeConvertable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonConverter), typeof(JsonReader), typeof(Type), typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(JsonSerializerInternalReader), Member = "CreateValueInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(JsonContract), typeof(JsonProperty), typeof(JsonContainerContract), typeof(JsonProperty), typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public override object Convert(object value, Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(TypeCode), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override object Convert(object value, TypeCode typeCode) { }

	[CalledBy(Type = typeof(JsonFormatterConverter), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(sbyte))]
	[CalledBy(Type = typeof(JsonFormatterConverter), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonFormatterConverter), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(JsonFormatterConverter), Member = "ToChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(char))]
	[CalledBy(Type = typeof(JsonFormatterConverter), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(JsonFormatterConverter), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(short))]
	[CalledBy(Type = typeof(JsonFormatterConverter), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(JsonFormatterConverter), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(JsonFormatterConverter), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(JsonFormatterConverter), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(JsonFormatterConverter), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ulong))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Convert), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private T GetTokenValue(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonFormatterConverter), Member = "GetTokenValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	public override bool ToBoolean(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonFormatterConverter), Member = "GetTokenValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	public override byte ToByte(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonFormatterConverter), Member = "GetTokenValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	public override char ToChar(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonFormatterConverter), Member = "GetTokenValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	public override DateTime ToDateTime(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonFormatterConverter), Member = "GetTokenValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Decimal))]
	public override decimal ToDecimal(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonFormatterConverter), Member = "GetTokenValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(double))]
	public override double ToDouble(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonFormatterConverter), Member = "GetTokenValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	public override short ToInt16(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonFormatterConverter), Member = "GetTokenValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	public override int ToInt32(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonFormatterConverter), Member = "GetTokenValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	public override long ToInt64(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonFormatterConverter), Member = "GetTokenValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	public override sbyte ToSByte(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonFormatterConverter), Member = "GetTokenValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(float))]
	public override float ToSingle(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonFormatterConverter), Member = "GetTokenValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	public override string ToString(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonFormatterConverter), Member = "GetTokenValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	public override ushort ToUInt16(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonFormatterConverter), Member = "GetTokenValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	public override uint ToUInt32(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonFormatterConverter), Member = "GetTokenValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	public override ulong ToUInt64(object value) { }

}

