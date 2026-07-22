namespace Newtonsoft.Json.Linq;

[Nullable(0)]
[NullableContext(2)]
public class JTokenWriter : JsonWriter
{
	private JContainer _token; //Field offset: 0x60
	private JContainer _parent; //Field offset: 0x68
	private JValue _value; //Field offset: 0x70
	private JToken _current; //Field offset: 0x78

	public JToken CurrentToken
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public JToken Token
	{
		[CalledBy(Type = typeof(JsonValidatingReader), Member = "WriteToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<Newtonsoft.Json.Schema.JsonSchemaModel>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateJToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonContract)}, ReturnType = typeof(JToken))]
		[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateJObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(JToken))]
		[CalledBy(Type = typeof(JToken), Member = "FromObjectInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(JToken))]
		[CallerCount(Count = 4)]
		 get { } //Length: 17
	}

	[CalledBy(Type = typeof(JContainer), Member = "CreateWriter", ReturnType = typeof(JsonWriter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonWriter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[NullableContext(1)]
	public JTokenWriter(JContainer container) { }

	[CalledBy(Type = typeof(JsonValidatingReader), Member = "WriteToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<Newtonsoft.Json.Schema.JsonSchemaModel>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateJToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonContract)}, ReturnType = typeof(JToken))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateJObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(JToken))]
	[CalledBy(Type = typeof(JToken), Member = "FromObjectInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(JToken))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(JsonWriter), Member = ".ctor", ReturnType = typeof(void))]
	public JTokenWriter() { }

	[CalledBy(Type = typeof(JTokenWriter), Member = "AddRawValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JTokenType), typeof(JsonToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteUndefined", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteNull", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(JValue), Member = "CreateNull", ReturnType = typeof(JValue))]
	[Calls(Type = typeof(JContainer), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	internal void AddJValue(JValue value, JsonToken token) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JContainer), Member = "AddAndSkipParentCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NullableContext(1)]
	private void AddParent(JContainer container) { }

	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(JTokenWriter), Member = "AddJValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JValue), typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void AddRawValue(object value, JTokenType type, JsonToken token) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "Close", ReturnType = typeof(void))]
	public virtual void Close() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void Flush() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public JToken get_CurrentToken() { }

	[CalledBy(Type = typeof(JsonValidatingReader), Member = "WriteToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<Newtonsoft.Json.Schema.JsonSchemaModel>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateJToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonContract)}, ReturnType = typeof(JToken))]
	[CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateJObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(JToken))]
	[CalledBy(Type = typeof(JToken), Member = "FromObjectInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(JToken))]
	[CallerCount(Count = 4)]
	public JToken get_Token() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	private void RemoveParent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JTokenWriter), Member = "AddJValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JValue), typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteComment(string text) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	protected virtual void WriteEnd(JsonToken token) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(JValue), Member = "CreateNull", ReturnType = typeof(JValue))]
	[Calls(Type = typeof(JTokenWriter), Member = "AddJValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JValue), typeof(JsonToken)}, ReturnType = typeof(void))]
	public virtual void WriteNull() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JObject), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JProperty), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JContainer), Member = "AddAndSkipParentCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[NullableContext(1)]
	public virtual void WritePropertyName(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JRaw), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JTokenWriter), Member = "AddJValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JValue), typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void WriteRaw(string json) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteStartArray", ReturnType = typeof(void))]
	[Calls(Type = typeof(JArray), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(JContainer), Member = "AddAndSkipParentCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void WriteStartArray() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteStartConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JConstructor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JContainer), Member = "AddAndSkipParentCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NullableContext(1)]
	public virtual void WriteStartConstructor(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteStartObject", ReturnType = typeof(void))]
	[Calls(Type = typeof(JObject), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(JContainer), Member = "AddAndSkipParentCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void WriteStartObject() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonReader), Member = "Skip", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	[NullableContext(1)]
	internal virtual void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteTokenSyncReadingAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[NullableContext(1)]
	internal virtual Task WriteTokenAsync(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments, CancellationToken cancellationToken) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteUndefined", ReturnType = typeof(void))]
	[Calls(Type = typeof(JTokenWriter), Member = "AddJValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JValue), typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteUndefined() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JTokenWriter), Member = "AddJValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JValue), typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(Guid value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JTokenWriter), Member = "AddJValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JValue), typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(TimeSpan value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JTokenWriter), Member = "AddJValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JValue), typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(Byte[] value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JTokenWriter), Member = "AddJValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JValue), typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(DateTimeOffset value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTimeUtils), Member = "EnsureDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTimeZoneHandling)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(JTokenWriter), Member = "AddJValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JValue), typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(DateTime value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BoxedPrimitives), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(JTokenWriter), Member = "AddJValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JValue), typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(decimal value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JTokenWriter), Member = "AddRawValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JTokenType), typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CLSCompliant(False)]
	public virtual void WriteValue(sbyte value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JTokenWriter), Member = "AddRawValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JTokenType), typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void WriteValue(byte value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(JTokenWriter), Member = "AddJValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JValue), typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(char value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JTokenWriter), Member = "AddRawValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JTokenType), typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CLSCompliant(False)]
	public virtual void WriteValue(ushort value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxedPrimitives), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(JTokenWriter), Member = "AddJValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JValue), typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BoxedPrimitives), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(JTokenWriter), Member = "AddJValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JValue), typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(double value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JTokenWriter), Member = "AddJValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JValue), typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JTokenWriter), Member = "AddJValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JValue), typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public virtual void WriteValue(ulong value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BoxedPrimitives), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(JTokenWriter), Member = "AddJValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JValue), typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(long value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JTokenWriter), Member = "AddRawValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JTokenType), typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CLSCompliant(False)]
	public virtual void WriteValue(uint value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JTokenWriter), Member = "AddRawValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JTokenType), typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void WriteValue(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JTokenWriter), Member = "AddJValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JValue), typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JTokenWriter), Member = "AddJValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JValue), typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(Uri value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JTokenWriter), Member = "AddRawValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JTokenType), typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void WriteValue(short value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JTokenWriter), Member = "AddRawValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JTokenType), typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	public virtual void WriteValue(object value) { }

}

