namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
internal class TraceJsonReader : JsonReader, IJsonLineInfo
{
	private readonly JsonReader _innerReader; //Field offset: 0x78
	private readonly JsonTextWriter _textWriter; //Field offset: 0x80
	private readonly StringWriter _sw; //Field offset: 0x88

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
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 39
	}

	public virtual JsonToken TokenType
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	[Nullable(2)]
	public virtual object Value
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[NullableContext(2)]
		 get { } //Length: 39
	}

	[Nullable(2)]
	public virtual Type ValueType
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[NullableContext(2)]
		 get { } //Length: 39
	}

	[CalledBy(Type = typeof(JsonSerializer), Member = "PopulateInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializer), Member = "DeserializeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializer), Member = "CreateTraceJsonReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(TraceJsonReader))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(JsonReader), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonWriter), Member = "set_Formatting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Formatting)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public TraceJsonReader(JsonReader innerReader) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Close() { }

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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual JsonToken get_TokenType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NullableContext(2)]
	public virtual object get_Value() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NullableContext(2)]
	public virtual Type get_ValueType() { }

	[CalledBy(Type = typeof(JsonSerializer), Member = "PopulateInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializer), Member = "DeserializeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string GetDeserializedJsonMessage() { }

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
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Read() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Nullable<Boolean> ReadAsBoolean() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[NullableContext(2)]
	public virtual Byte[] ReadAsBytes() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Nullable<DateTime> ReadAsDateTime() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Nullable<Decimal> ReadAsDecimal() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Nullable<Double> ReadAsDouble() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Nullable<Int32> ReadAsInt32() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[NullableContext(2)]
	public virtual string ReadAsString() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected private virtual void set_QuoteChar(char value) { }

	[CalledBy(Type = typeof(JsonSerializer), Member = "PopulateInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonSerializer), Member = "DeserializeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonSerializer), Member = "CreateTraceJsonReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(TraceJsonReader))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void WriteCurrentToken() { }

}

