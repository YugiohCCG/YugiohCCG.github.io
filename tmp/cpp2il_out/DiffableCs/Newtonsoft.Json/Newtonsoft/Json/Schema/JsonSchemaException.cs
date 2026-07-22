namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
public class JsonSchemaException : JsonException
{
	[CompilerGenerated]
	private readonly int <LineNumber>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private readonly int <LinePosition>k__BackingField; //Field offset: 0x94
	[CompilerGenerated]
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

	public string Path
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public JsonSchemaException() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public JsonSchemaException(string message) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public JsonSchemaException(string message, Exception innerException) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public JsonSchemaException(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = typeof(JsonValidatingReader), Member = "RaiseError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal JsonSchemaException(string message, Exception innerException, string path, int lineNumber, int linePosition) { }

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
	public string get_Path() { }

}

