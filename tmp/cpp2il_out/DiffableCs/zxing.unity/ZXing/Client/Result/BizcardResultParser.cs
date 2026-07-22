namespace ZXing.Client.Result;

internal sealed class BizcardResultParser : AbstractDoCoMoResultParser
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public BizcardResultParser() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	private static string buildName(string firstName, string lastName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SupportClass), Member = "toStringArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.ICollection`1<System.String>)}, ReturnType = typeof(String[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static String[] buildPhoneNumbers(string number1, string number2, string number3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AbstractDoCoMoResultParser), Member = "matchSingleDoCoMoPrefixedField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(AbstractDoCoMoResultParser), Member = "matchDoCoMoPrefixedField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(SupportClass), Member = "toStringArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.ICollection`1<System.String>)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(AddressBookParsedResult), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(String[]), typeof(string), typeof(String[]), typeof(String[]), typeof(String[]), typeof(String[]), typeof(string), typeof(string), typeof(String[]), typeof(String[]), typeof(string), typeof(string), typeof(string), typeof(String[]), typeof(String[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public virtual ParsedResult parse(Result result) { }

}

