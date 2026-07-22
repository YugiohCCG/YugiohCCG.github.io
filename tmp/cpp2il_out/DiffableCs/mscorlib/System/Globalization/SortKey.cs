namespace System.Globalization;

[ComVisible(True)]
public class SortKey
{
	private readonly string source; //Field offset: 0x10
	private readonly Byte[] key; //Field offset: 0x18
	private readonly CompareOptions options; //Field offset: 0x20
	private readonly int lcid; //Field offset: 0x24

	public override Byte[] KeyData
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override string OriginalString
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(CompareInfo), Member = "CreateSortKeyCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CompareOptions)}, ReturnType = typeof(SortKey))]
	[CalledBy(Type = typeof(CompareInfo), Member = "CreateSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CompareOptions)}, ReturnType = typeof(SortKey))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal SortKey(int lcid, string source, CompareOptions opt) { }

	[CalledBy(Type = typeof(SortKeyBuffer), Member = "GetResult", ReturnType = typeof(SortKey))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal SortKey(int lcid, string source, Byte[] buffer, CompareOptions opt, int lv1Length, int lv2Length, int lv3Length, int kanaSmallLength, int markTypeLength, int katakanaLength, int kanaWidthLength, int identLength) { }

	[CalledBy(Type = typeof(CompareInfo), Member = "InvariantCreateSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CompareOptions)}, ReturnType = typeof(SortKey))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal SortKey(string localeName, string str, CompareOptions options, Byte[] keyData) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal SortKey() { }

	[CalledBy(Type = typeof(SortKey), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	public static int Compare(SortKey sortkey1, SortKey sortkey2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SortKey), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortKey), typeof(SortKey)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object value) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public override Byte[] get_KeyData() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public override string get_OriginalString() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 8)]
	public virtual string ToString() { }

}

