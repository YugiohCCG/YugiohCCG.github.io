namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
internal class TraceJsonWriter : JsonWriter
{
	private readonly JsonWriter _innerWriter; //Field offset: 0x60
	private readonly JsonTextWriter _textWriter; //Field offset: 0x68
	private readonly StringWriter _sw; //Field offset: 0x70

	[CalledBy(Type = typeof(JsonSerializer), Member = "SerializeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonWriter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonWriter), Member = "set_Formatting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Formatting)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonWriter), Member = "get_Culture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(JsonWriter), Member = "set_DateFormatHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateFormatHandling)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonWriter), Member = "set_DateTimeZoneHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeZoneHandling)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonWriter), Member = "set_FloatFormatHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FloatFormatHandling)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public TraceJsonWriter(JsonWriter innerWriter) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "Close", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Close() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Flush() { }

	[CalledBy(Type = typeof(JsonSerializer), Member = "SerializeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string GetSerializedJsonMessage() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[NullableContext(2)]
	public virtual void WriteComment(string text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteEndArray", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteEndArray() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteEndConstructor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteEndConstructor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteEndObject", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteEndObject() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteUndefined", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteNull() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WritePropertyName(string name, bool escape) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WritePropertyName(string name) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[NullableContext(2)]
	public virtual void WriteRaw(string json) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[NullableContext(2)]
	public virtual void WriteRawValue(string json) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteStartArray", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteStartArray() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteStartConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteStartConstructor(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteStartObject", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteStartObject() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteUndefined", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteUndefined() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(TimeSpan value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteUndefined", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(Nullable<Decimal> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteUndefined", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(Nullable<TimeSpan> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[NullableContext(2)]
	public virtual void WriteValue(string value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(uint value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(ushort value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(ulong value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteUndefined", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(Nullable<UInt64> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteUndefined", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[NullableContext(2)]
	public virtual void WriteValue(Uri value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteUndefined", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(Nullable<Int16> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteUndefined", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(Nullable<UInt16> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteUndefined", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(Nullable<UInt32> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(short value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteUndefined", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(Nullable<SByte> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(sbyte value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteUndefined", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(Nullable<Boolean> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(byte value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteUndefined", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(Nullable<Byte> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(char value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteUndefined", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(Nullable<Char> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteUndefined", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[NullableContext(2)]
	public virtual void WriteValue(Byte[] value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(DateTime value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteUndefined", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(Nullable<DateTime> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(DateTimeOffset value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(decimal value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteUndefined", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(Nullable<DateTimeOffset> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(double value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteUndefined", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(Nullable<Double> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteUndefined", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(Nullable<Single> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(Guid value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteUndefined", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(Nullable<Guid> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteUndefined", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(Nullable<Int32> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(long value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteUndefined", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(Nullable<Int64> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteUndefined", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[NullableContext(2)]
	public virtual void WriteValue(object value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteWhitespace(string ws) { }

}

