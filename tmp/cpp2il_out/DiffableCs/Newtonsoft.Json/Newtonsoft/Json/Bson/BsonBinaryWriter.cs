namespace Newtonsoft.Json.Bson;

internal class BsonBinaryWriter
{
	private static readonly Encoding Encoding; //Field offset: 0x0
	private readonly BinaryWriter _writer; //Field offset: 0x10
	private Byte[] _largeByteBuffer; //Field offset: 0x18
	[CompilerGenerated]
	private DateTimeKind <DateTimeKindHandling>k__BackingField; //Field offset: 0x20

	public DateTimeKind DateTimeKindHandling
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UTF8Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static BsonBinaryWriter() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public BsonBinaryWriter(BinaryWriter writer) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private int CalculateSize(int stringByteCount) { }

	[CalledBy(Type = typeof(BsonBinaryWriter), Member = "WriteToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BsonWriter), Member = "WriteEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	private int CalculateSize(BsonToken t) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private int CalculateSizeWithLength(int stringByteCount, bool includeSize) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void Close() { }

	[CallerCount(Count = 12)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void Flush() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public DateTimeKind get_DateTimeKindHandling() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_DateTimeKindHandling(DateTimeKind value) { }

	[CalledBy(Type = typeof(BsonBinaryWriter), Member = "WriteTokenInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	private void WriteString(string s, int byteCount, Nullable<Int32> calculatedlengthPrefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BsonBinaryWriter), Member = "CalculateSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BsonBinaryWriter), Member = "WriteTokenInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	public void WriteToken(BsonToken t) { }

	[CalledBy(Type = typeof(BsonBinaryWriter), Member = "WriteToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BsonBinaryWriter), Member = "WriteTokenInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BsonWriter), Member = "WriteEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ulong), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeUtils), Member = "ConvertDateTimeToJavaScriptTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(bool)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTime), Member = "ToUniversalTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTimeUtils), Member = "ConvertDateTimeToJavaScriptTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Offset", ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(BsonArray), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Bson.BsonToken>))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(BsonBinaryWriter), Member = "WriteTokenInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BsonObject), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.IEnumerator`1<Newtonsoft.Json.Bson.BsonProperty>))]
	[Calls(Type = typeof(BsonBinaryWriter), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 52)]
	[ContainsUnimplementedInstructions]
	private void WriteTokenInternal(BsonToken t) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public void WriteUtf8Bytes(string s, int byteCount) { }

}

