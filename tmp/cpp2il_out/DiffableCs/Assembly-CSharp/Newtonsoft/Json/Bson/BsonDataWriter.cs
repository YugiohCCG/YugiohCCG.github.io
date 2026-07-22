namespace Newtonsoft.Json.Bson;

public class BsonDataWriter : JsonWriter
{
	private readonly BsonBinaryWriter _writer; //Field offset: 0x60
	private BsonToken _root; //Field offset: 0x68
	private BsonToken _parent; //Field offset: 0x70
	private string _propertyName; //Field offset: 0x78

	public DateTimeKind DateTimeKindHandling
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 26
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 26
	}

	[CalledBy(Type = "Manager.Helper+<SerializeData>d__121`1", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonWriter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public BsonDataWriter(Stream stream) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public BsonDataWriter(BinaryWriter writer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BsonDataWriter), Member = "AddToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void AddParent(BsonToken container) { }

	[CallerCount(Count = 28)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ExceptionUtils), Member = "CreateJsonWriterException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonWriterException))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 19)]
	internal void AddToken(BsonToken token) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BsonDataWriter), Member = "AddToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void AddValue(object value, BsonType type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "Close", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Close() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void Flush() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public DateTimeKind get_DateTimeKindHandling() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void RemoveParent() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_DateTimeKindHandling(DateTimeKind value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionUtils), Member = "CreateJsonWriterException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonWriterException))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void WriteComment(string text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "get_Top", ReturnType = typeof(int))]
	[Calls(Type = typeof(BsonBinaryWriter), Member = "CalculateSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BsonBinaryWriter), Member = "WriteTokenInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void WriteEnd(JsonToken token) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(BsonDataWriter), Member = "AddToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void WriteNull() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "SetWriteState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BsonDataWriter), Member = "AddToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionUtils), Member = "CreateJsonWriterException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonWriterException))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void WriteObjectId(Byte[] value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void WritePropertyName(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionUtils), Member = "CreateJsonWriterException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonWriterException))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void WriteRaw(string json) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionUtils), Member = "CreateJsonWriterException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonWriterException))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void WriteRawValue(string json) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "SetWriteState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BsonDataWriter), Member = "AddToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public void WriteRegex(string pattern, string options) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteStartArray", ReturnType = typeof(void))]
	[Calls(Type = typeof(BsonDataWriter), Member = "AddToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void WriteStartArray() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionUtils), Member = "CreateJsonWriterException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonWriterException))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void WriteStartConstructor(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteStartObject", ReturnType = typeof(void))]
	[Calls(Type = typeof(BsonDataWriter), Member = "AddToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void WriteStartObject() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteUndefined", ReturnType = typeof(void))]
	[Calls(Type = typeof(BsonDataWriter), Member = "AddToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void WriteUndefined() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BsonDataWriter), Member = "AddToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void WriteValue(Uri value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeSpan), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(BsonDataWriter), Member = "AddToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(TimeSpan value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Guid), Member = "ToByteArray", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(BsonDataWriter), Member = "AddToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(Guid value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BsonDataWriter), Member = "AddToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(Byte[] value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTimeUtils), Member = "EnsureDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTimeZoneHandling)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(BsonDataWriter), Member = "AddToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(DateTime value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BsonDataWriter), Member = "AddToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(decimal value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BsonDataWriter), Member = "AddToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public virtual void WriteValue(sbyte value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BsonDataWriter), Member = "AddToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(byte value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BsonDataWriter), Member = "AddToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(char value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BsonDataWriter), Member = "AddToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(short value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BsonDataWriter), Member = "AddToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void WriteValue(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BsonDataWriter), Member = "AddToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(double value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BsonDataWriter), Member = "AddToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BsonDataWriter), Member = "AddToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionUtils), Member = "CreateJsonWriterException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonWriterException))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[CLSCompliant(False)]
	public virtual void WriteValue(ulong value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BsonDataWriter), Member = "AddToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(long value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BsonDataWriter), Member = "AddToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionUtils), Member = "CreateJsonWriterException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonWriterException))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[CLSCompliant(False)]
	public virtual void WriteValue(uint value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BsonDataWriter), Member = "AddToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValue(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BsonDataWriter), Member = "AddToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void WriteValue(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BsonDataWriter), Member = "AddToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public virtual void WriteValue(ushort value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	public virtual void WriteValue(object value) { }

}

