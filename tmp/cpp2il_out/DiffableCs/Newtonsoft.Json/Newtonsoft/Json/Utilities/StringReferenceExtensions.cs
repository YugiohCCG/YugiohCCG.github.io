namespace Newtonsoft.Json.Utilities;

[Extension]
[Nullable(0)]
[NullableContext(1)]
internal static class StringReferenceExtensions
{

	[CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(DateTimeZoneHandling), typeof(string), typeof(CultureInfo), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(string), typeof(CultureInfo), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static bool EndsWith(StringReference s, string text) { }

	[CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseMicrosoftDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(Int64&), typeof(TimeSpan&), typeof(DateTimeKind&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(char), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Extension]
	public static int IndexOf(StringReference s, char c, int startIndex, int length) { }

	[CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(DateTimeZoneHandling), typeof(string), typeof(CultureInfo), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringReference), typeof(string), typeof(CultureInfo), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static bool StartsWith(StringReference s, string text) { }

}

