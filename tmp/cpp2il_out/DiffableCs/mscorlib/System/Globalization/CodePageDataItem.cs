namespace System.Globalization;

internal class CodePageDataItem
{
	private static readonly Char[] sep; //Field offset: 0x0
	internal int m_dataIndex; //Field offset: 0x10
	internal int m_uiFamilyCodePage; //Field offset: 0x14
	internal string m_webName; //Field offset: 0x18
	internal uint m_flags; //Field offset: 0x20

	public string WebName
	{
		[CalledBy(Type = typeof(Encoding), Member = "get_WebName", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 325
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private static CodePageDataItem() { }

	[CalledBy(Type = typeof(EncodingTable), Member = "GetCodePageDataItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CodePageDataItem))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal CodePageDataItem(int dataIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[CallsUnknownMethods(Count = 2)]
	internal static string CreateString(string pStrings, uint index) { }

	[CalledBy(Type = typeof(Encoding), Member = "get_WebName", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[CallsUnknownMethods(Count = 3)]
	public string get_WebName() { }

}

