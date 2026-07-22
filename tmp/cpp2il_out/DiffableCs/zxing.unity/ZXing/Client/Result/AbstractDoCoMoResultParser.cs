namespace ZXing.Client.Result;

internal abstract class AbstractDoCoMoResultParser : ResultParser
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected AbstractDoCoMoResultParser() { }

	[CalledBy(Type = typeof(AddressBookDoCoMoResultParser), Member = "parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(ParsedResult))]
	[CalledBy(Type = typeof(BizcardResultParser), Member = "parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(ParsedResult))]
	[CalledBy(Type = typeof(BookmarkDoCoMoResultParser), Member = "parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(ParsedResult))]
	[CalledBy(Type = typeof(EmailDoCoMoResultParser), Member = "parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(ParsedResult))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ResultParser), Member = "matchPrefixedField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(char), typeof(bool)}, ReturnType = typeof(String[]))]
	internal static String[] matchDoCoMoPrefixedField(string prefix, string rawText, bool trim) { }

	[CalledBy(Type = typeof(AddressBookDoCoMoResultParser), Member = "parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(ParsedResult))]
	[CalledBy(Type = typeof(BizcardResultParser), Member = "parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(ParsedResult))]
	[CalledBy(Type = typeof(BookmarkDoCoMoResultParser), Member = "parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(ParsedResult))]
	[CalledBy(Type = typeof(EmailDoCoMoResultParser), Member = "parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(ParsedResult))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(ResultParser), Member = "matchSinglePrefixedField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(char), typeof(bool)}, ReturnType = typeof(string))]
	internal static string matchSingleDoCoMoPrefixedField(string prefix, string rawText, bool trim) { }

}

