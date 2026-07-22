namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
public class ValidationEventArgs : EventArgs
{
	private readonly JsonSchemaException _ex; //Field offset: 0x10

	public JsonSchemaException Exception
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string Message
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public string Path
	{
		[CallerCount(Count = 0)]
		[Calls(Type = "Newtonsoft.Json.Linq.JObject+<GetEnumerator>d__64", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = "Newtonsoft.Json.Linq.JContainer+<GetDescendants>d__36", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 339
	}

	[CalledBy(Type = typeof(JsonValidatingReader), Member = "RaiseError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonValidatingReader), Member = "OnValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaException)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal ValidationEventArgs(JsonSchemaException ex) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public JsonSchemaException get_Exception() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public string get_Message() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "Newtonsoft.Json.Linq.JObject+<GetEnumerator>d__64", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = "Newtonsoft.Json.Linq.JContainer+<GetDescendants>d__36", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public string get_Path() { }

}

