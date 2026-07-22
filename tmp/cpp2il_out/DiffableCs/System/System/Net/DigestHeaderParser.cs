namespace System.Net;

internal class DigestHeaderParser
{
	private static String[] keywords; //Field offset: 0x0
	private string header; //Field offset: 0x10
	private int length; //Field offset: 0x18
	private int pos; //Field offset: 0x1C
	private String[] values; //Field offset: 0x20

	public string Algorithm
	{
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public string Nonce
	{
		[CallerCount(Count = 6)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public string Opaque
	{
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public string QOP
	{
		[CallerCount(Count = 8)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	public string Realm
	{
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	private static DigestHeaderParser() { }

	[CalledBy(Type = typeof(DigestSession), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public DigestHeaderParser(string header) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public string get_Algorithm() { }

	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public string get_Nonce() { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public string get_Opaque() { }

	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public string get_QOP() { }

	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public string get_Realm() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private string GetKey() { }

	[CalledBy(Type = typeof(DigestHeaderParser), Member = "Parse", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
	[Calls(Type = typeof(DigestHeaderParser), Member = "SkipWhitespace", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private bool GetKeywordAndValue(out string key, out string value) { }

	[CalledBy(Type = typeof(DigestSession), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DigestHeaderParser), Member = "GetKeywordAndValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&), typeof(String&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DigestHeaderParser), Member = "SkipWhitespace", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	public bool Parse() { }

	[CalledBy(Type = typeof(DigestHeaderParser), Member = "Parse", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DigestHeaderParser), Member = "GetKeywordAndValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&), typeof(String&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void SkipWhitespace() { }

}

