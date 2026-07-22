namespace System.Net;

[DefaultMember("Item")]
internal class HeaderInfoTable
{
	private static Hashtable HeaderHashTable; //Field offset: 0x0
	private static HeaderInfo UnknownHeaderInfo; //Field offset: 0x8
	private static HeaderParser SingleParser; //Field offset: 0x10
	private static HeaderParser MultiParser; //Field offset: 0x18

	internal HeaderInfo Item
	{
		[CalledBy(Type = typeof(WebHeaderCollection), Member = "AllowMultiValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(WebHeaderCollection), Member = "ThrowOnRestrictedHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(WebHeaderCollection), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(String[]))]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 230
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IEqualityComparer)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 54)]
	[CallsUnknownMethods(Count = 330)]
	private static HeaderInfoTable() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public HeaderInfoTable() { }

	[CalledBy(Type = typeof(WebHeaderCollection), Member = "AllowMultiValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WebHeaderCollection), Member = "ThrowOnRestrictedHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebHeaderCollection), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal HeaderInfo get_Item(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(StringCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static String[] ParseMultiValue(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private static String[] ParseSingleValue(string value) { }

}

