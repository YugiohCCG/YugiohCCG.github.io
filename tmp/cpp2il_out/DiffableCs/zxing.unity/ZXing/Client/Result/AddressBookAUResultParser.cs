namespace ZXing.Client.Result;

internal sealed class AddressBookAUResultParser : ResultParser
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public AddressBookAUResultParser() { }

	[CalledBy(Type = typeof(AddressBookAUResultParser), Member = "parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(ParsedResult))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ResultParser), Member = "matchSinglePrefixedField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(char), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SupportClass), Member = "toStringArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.ICollection`1<System.String>)}, ReturnType = typeof(String[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static String[] matchMultipleValuePrefix(string prefix, int max, string rawText, bool trim) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ResultParser), Member = "matchSinglePrefixedField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(char), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(AddressBookAUResultParser), Member = "matchMultipleValuePrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(ResultParser), Member = "maybeWrap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(AddressBookParsedResult), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(String[]), typeof(string), typeof(String[]), typeof(String[]), typeof(String[]), typeof(String[]), typeof(string), typeof(string), typeof(String[]), typeof(String[]), typeof(string), typeof(string), typeof(string), typeof(String[]), typeof(String[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual ParsedResult parse(Result result) { }

}

