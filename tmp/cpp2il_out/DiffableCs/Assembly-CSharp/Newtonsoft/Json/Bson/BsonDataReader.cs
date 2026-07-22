namespace Newtonsoft.Json.Bson;

public class BsonDataReader : JsonReader
{
	private enum BsonReaderState
	{
		Normal = 0,
		ReferenceStart = 1,
		ReferenceRef = 2,
		ReferenceId = 3,
		CodeWScopeStart = 4,
		CodeWScopeCode = 5,
		CodeWScopeScope = 6,
		CodeWScopeScopeObject = 7,
		CodeWScopeScopeEnd = 8,
	}

	private class ContainerContext
	{
		public readonly BsonType Type; //Field offset: 0x10
		public int Length; //Field offset: 0x14
		public int Position; //Field offset: 0x18

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public ContainerContext(BsonType type) { }

	}

	private const int MaxCharBytesSize = 128; //Field offset: 0x0
	private static readonly Byte[] SeqRange1; //Field offset: 0x0
	private static readonly Byte[] SeqRange2; //Field offset: 0x8
	private static readonly Byte[] SeqRange3; //Field offset: 0x10
	private static readonly Byte[] SeqRange4; //Field offset: 0x18
	private readonly BinaryReader _reader; //Field offset: 0x78
	private readonly List<ContainerContext> _stack; //Field offset: 0x80
	private Byte[] _byteBuffer; //Field offset: 0x88
	private Char[] _charBuffer; //Field offset: 0x90
	private BsonType _currentElementType; //Field offset: 0x98
	private BsonReaderState _bsonReaderState; //Field offset: 0x9C
	private ContainerContext _currentContext; //Field offset: 0xA0
	private bool _readRootValueAsArray; //Field offset: 0xA8
	private bool _jsonNet35BinaryCompatibility; //Field offset: 0xA9
	private DateTimeKind _dateTimeKindHandling; //Field offset: 0xAC

	public DateTimeKind DateTimeKindHandling
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	[Obsolete("JsonNet35BinaryCompatibility will be removed in a future version of Json.NET.")]
	public bool JsonNet35BinaryCompatibility
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	public bool ReadRootValueAsArray
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	private static BsonDataReader() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonReader), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public BsonDataReader(BinaryReader reader, bool readRootValueAsArray, DateTimeKind dateTimeKindHandling) { }

	[CalledBy(Type = "Manager.Helper+<BsonDeserializeAsync>d__119`1", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonReader), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public BsonDataReader(Stream stream) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonReader), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public BsonDataReader(BinaryReader reader) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonReader), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public BsonDataReader(Stream stream, bool readRootValueAsArray, DateTimeKind dateTimeKindHandling) { }

	[CalledBy(Type = typeof(BsonDataReader), Member = "ReadString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BsonDataReader), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BsonDataReader), Member = "GetLastFullCharStop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private int BytesInSequence(byte b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonReader), Member = "Close", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void Close() { }

	[CalledBy(Type = typeof(BsonDataReader), Member = "ReadString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BsonDataReader), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void EnsureBuffers() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public DateTimeKind get_DateTimeKindHandling() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_JsonNet35BinaryCompatibility() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_ReadRootValueAsArray() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BsonDataReader), Member = "BytesInSequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	private int GetLastFullCharStop(int start) { }

	[CalledBy(Type = typeof(BsonDataReader), Member = "ReadLengthString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BsonDataReader), Member = "EnsureBuffers", ReturnType = typeof(void))]
	[Calls(Type = typeof(BsonDataReader), Member = "BytesInSequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(EndOfStreamException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private string GetString(int length) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void MovePosition(int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void PopContext() { }

	[CalledBy(Type = typeof(BsonDataReader), Member = "ReadCodeWScope", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BsonDataReader), Member = "ReadNormal", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BsonDataReader), Member = "ReadType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private void PushContext(ContainerContext newContext) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BsonDataReader), Member = "ReadNormal", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BsonDataReader), Member = "ReadReference", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BsonDataReader), Member = "ReadCodeWScope", ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ExceptionUtils), Member = "CreateJsonReaderException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CallsUnknownMethods(Count = 7)]
	public virtual bool Read() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private Byte[] ReadBinary(out BsonBinaryType binaryType) { }

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private byte ReadByte() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private Byte[] ReadBytes(int count) { }

	[CalledBy(Type = typeof(BsonDataReader), Member = "Read", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BsonDataReader), Member = "ReadNormal", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BsonDataReader), Member = "PushContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContainerContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BsonDataReader), Member = "ReadLengthString", ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private bool ReadCodeWScope() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private double ReadDouble() { }

	[CalledBy(Type = typeof(BsonDataReader), Member = "ReadNormal", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BsonDataReader), Member = "ReadString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private string ReadElement() { }

	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private int ReadInt32() { }

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private long ReadInt64() { }

	[CalledBy(Type = typeof(BsonDataReader), Member = "ReadCodeWScope", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BsonDataReader), Member = "ReadReference", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BsonDataReader), Member = "ReadType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BsonDataReader), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private string ReadLengthString() { }

	[CalledBy(Type = typeof(BsonDataReader), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BsonDataReader), Member = "ReadCodeWScope", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BsonDataReader), Member = "ReadType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BsonDataReader), Member = "ReadElement", ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BsonDataReader), Member = "PushContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContainerContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionUtils), Member = "CreateJsonReaderException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	private bool ReadNormal() { }

	[CalledBy(Type = typeof(BsonDataReader), Member = "Read", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BsonDataReader), Member = "ReadLengthString", ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ExceptionUtils), Member = "CreateJsonReaderException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	private bool ReadReference() { }

	[CalledBy(Type = typeof(BsonDataReader), Member = "ReadElement", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BsonDataReader), Member = "ReadType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BsonType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BsonDataReader), Member = "EnsureBuffers", ReturnType = typeof(void))]
	[Calls(Type = typeof(BsonDataReader), Member = "BytesInSequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private string ReadString() { }

	[CalledBy(Type = typeof(BsonDataReader), Member = "ReadNormal", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(BsonDataReader), Member = "ReadLengthString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(BsonDataReader), Member = "ReadString", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "SpecifyKind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTimeKind)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTimeUtils), Member = "ConvertJavaScriptTicksToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BsonDataReader), Member = "PushContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContainerContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 9)]
	private void ReadType(BsonType type) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private BsonType ReadType() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_DateTimeKindHandling(DateTimeKind value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_JsonNet35BinaryCompatibility(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_ReadRootValueAsArray(bool value) { }

}

