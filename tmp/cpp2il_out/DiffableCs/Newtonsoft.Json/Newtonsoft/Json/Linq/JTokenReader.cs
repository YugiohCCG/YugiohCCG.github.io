namespace Newtonsoft.Json.Linq;

[Nullable(0)]
[NullableContext(1)]
public class JTokenReader : JsonReader, IJsonLineInfo
{
	private readonly JToken _root; //Field offset: 0x78
	[Nullable(2)]
	private string _initialPath; //Field offset: 0x80
	[Nullable(2)]
	private JToken _parent; //Field offset: 0x88
	[Nullable(2)]
	private JToken _current; //Field offset: 0x90

	[Nullable(2)]
	public JToken CurrentToken
	{
		[CallerCount(Count = 57)]
		[DeduplicatedMethod]
		[NullableContext(2)]
		 get { } //Length: 8
	}

	private override int Newtonsoft.Json.IJsonLineInfo.LineNumber
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 85
	}

	private override int Newtonsoft.Json.IJsonLineInfo.LinePosition
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 85
	}

	public virtual string Path
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JsonReader), Member = "get_Path", ReturnType = typeof(string))]
		[Calls(Type = typeof(JToken), Member = "get_Path", ReturnType = typeof(string))]
		[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 244
	}

	[CalledBy(Type = typeof(JToken), Member = "CreateReader", ReturnType = typeof(JsonReader))]
	[CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(JsonSerializer)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JsonReader), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public JTokenReader(JToken token) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonReader), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public JTokenReader(JToken token, string initialPath) { }

	[CallerCount(Count = 57)]
	[DeduplicatedMethod]
	[NullableContext(2)]
	public JToken get_CurrentToken() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonReader), Member = "get_Path", ReturnType = typeof(string))]
	[Calls(Type = typeof(JToken), Member = "get_Path", ReturnType = typeof(string))]
	[Calls(Type = typeof(StringUtils), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual string get_Path() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MiscellaneousUtils), Member = "CreateArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(ArgumentOutOfRangeException))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	private Nullable<JsonToken> GetEndToken(JContainer c) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private override int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private override int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private override bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JTokenReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JTokenReader), Member = "ReadOver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsInvalidInstructions]
	public virtual bool Read() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JTokenReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JTokenReader), Member = "SetEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JContainer)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private bool ReadInto(JContainer c) { }

	[CalledBy(Type = typeof(JTokenReader), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JTokenReader), Member = "SetEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JContainer)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	private bool ReadOver(JToken t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool ReadToEnd() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[NullableContext(2)]
	private string SafeToString(object value) { }

	[CalledBy(Type = typeof(JTokenReader), Member = "ReadInto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JContainer)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JTokenReader), Member = "ReadOver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MiscellaneousUtils), Member = "CreateArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(ArgumentOutOfRangeException))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private bool SetEnd(JContainer c) { }

	[CalledBy(Type = typeof(JTokenReader), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JTokenReader), Member = "ReadInto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JContainer)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonToken), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeUtils), Member = "EnsureDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTimeZoneHandling)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[Calls(Type = typeof(MiscellaneousUtils), Member = "CreateArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(ArgumentOutOfRangeException))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 25)]
	private void SetToken(JToken token) { }

}

