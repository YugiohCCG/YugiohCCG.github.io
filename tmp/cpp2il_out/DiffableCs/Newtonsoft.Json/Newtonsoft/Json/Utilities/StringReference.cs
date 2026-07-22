namespace Newtonsoft.Json.Utilities;

[DefaultMember("Item")]
[IsReadOnly]
[Nullable(0)]
[NullableContext(1)]
internal struct StringReference
{
	private readonly Char[] _chars; //Field offset: 0x0
	private readonly int _startIndex; //Field offset: 0x8
	private readonly int _length; //Field offset: 0xC

	public Char[] Chars
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public char Item
	{
		[CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(DateTimeZoneHandling), typeof(string), typeof(CultureInfo), typeof(DateTime&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(string), typeof(CultureInfo), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeUtils), Member = "TryReadOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(int), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 7)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 43
	}

	public int Length
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int StartIndex
	{
		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 94)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public StringReference(Char[] chars, int startIndex, int length) { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public Char[] get_Chars() { }

	[CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(DateTimeZoneHandling), typeof(string), typeof(CultureInfo), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(string), typeof(CultureInfo), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeUtils), Member = "TryReadOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(int), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	public char get_Item(int i) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public int get_Length() { }

	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	public int get_StartIndex() { }

	[CalledBy(Type = "Newtonsoft.Json.JsonTextReader+<ParseConstructorAsync>d__25", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextReader+<ParsePropertyAsync>d__31", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsBoolean", ReturnType = typeof(System.Nullable`1<System.Boolean>))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadNumberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "FinishReadQuotedNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseProperty", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseConstructor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseReadNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType), typeof(char), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(DateTimeZoneHandling), typeof(string), typeof(CultureInfo), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(string), typeof(CultureInfo), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 29)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

