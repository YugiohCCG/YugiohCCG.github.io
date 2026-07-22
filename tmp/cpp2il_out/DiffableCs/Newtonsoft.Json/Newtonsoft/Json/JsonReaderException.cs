namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
public class JsonReaderException : JsonException
{
	[CompilerGenerated]
	private readonly int <LineNumber>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private readonly int <LinePosition>k__BackingField; //Field offset: 0x94
	[CompilerGenerated]
	[Nullable(2)]
	private readonly string <Path>k__BackingField; //Field offset: 0x98

	public int LineNumber
	{
		[CallerCount(Count = 33)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public int LinePosition
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	[Nullable(2)]
	public string Path
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[NullableContext(2)]
		 get { } //Length: 8
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Exception), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public JsonReaderException() { }

	[CallerCount(Count = 90)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public JsonReaderException(string message) { }

	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public JsonReaderException(string message, Exception innerException) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public JsonReaderException(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public JsonReaderException(string message, string path, int lineNumber, int linePosition, Exception innerException) { }

	[CallerCount(Count = 122)]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string), typeof(Exception)}, ReturnType = typeof(JsonReaderException))]
	internal static JsonReaderException Create(JsonReader reader, string message) { }

	[CalledBy(Type = typeof(JsonReader), Member = "ReadAsInt32", ReturnType = typeof(System.Nullable`1<System.Int32>))]
	[CalledBy(Type = typeof(JsonReader), Member = "ReadAsDecimal", ReturnType = typeof(System.Nullable`1<System.Decimal>))]
	[CalledBy(Type = typeof(JsonReader), Member = "CreateUnexpectedEndException", ReturnType = typeof(JsonReaderException))]
	[CalledBy(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "CreateUnexpectedCharacterException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(JsonReaderException))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ThrowReaderError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(JsonReaderException))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(JsonPosition), Member = "FormatMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IJsonLineInfo), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal static JsonReaderException Create(JsonReader reader, string message, Exception ex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonPosition), Member = "FormatMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IJsonLineInfo), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal static JsonReaderException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex) { }

	[CallerCount(Count = 33)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_LineNumber() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_LinePosition() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[NullableContext(2)]
	public string get_Path() { }

}

