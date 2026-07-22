namespace Mono.Globalization.Unicode;

internal class SimpleCollator : ISimpleCollator
{
	public struct Context
	{
		public readonly CompareOptions Option; //Field offset: 0x0
		public readonly Byte* NeverMatchFlags; //Field offset: 0x8
		public readonly Byte* AlwaysMatchFlags; //Field offset: 0x10
		public Byte* Buffer1; //Field offset: 0x18
		public Byte* Buffer2; //Field offset: 0x20
		public int PrevCode; //Field offset: 0x28
		public Byte* PrevSortKey; //Field offset: 0x30

		[CallerCount(Count = 0)]
		public Context(CompareOptions opt, Byte* alwaysMatchFlags, Byte* neverMatchFlags, Byte* buffer1, Byte* buffer2, Byte* prev1) { }

	}

	private struct Escape
	{
		public string Source; //Field offset: 0x0
		public int Index; //Field offset: 0x8
		public int Start; //Field offset: 0xC
		public int End; //Field offset: 0x10
		public int Optional; //Field offset: 0x14

	}

	private enum ExtenderType
	{
		None = 0,
		Simple = 1,
		Voiced = 2,
		Conditional = 3,
		Buggy = 4,
	}

	private struct PreviousInfo
	{
		public int Code; //Field offset: 0x0
		public Byte* SortKey; //Field offset: 0x8

		[CallerCount(Count = 0)]
		public PreviousInfo(bool dummy) { }

	}

	private static SimpleCollator invariant; //Field offset: 0x0
	private readonly TextInfo textInfo; //Field offset: 0x10
	private readonly CodePointIndexer cjkIndexer; //Field offset: 0x18
	private readonly Contraction[] contractions; //Field offset: 0x20
	private readonly Level2Map[] level2Maps; //Field offset: 0x28
	private readonly Byte[] unsafeFlags; //Field offset: 0x30
	private readonly Byte* cjkCatTable; //Field offset: 0x38
	private readonly Byte* cjkLv1Table; //Field offset: 0x40
	private readonly Byte* cjkLv2Table; //Field offset: 0x48
	private readonly CodePointIndexer cjkLv2Indexer; //Field offset: 0x50
	private readonly int lcid; //Field offset: 0x58
	private readonly bool frenchSort; //Field offset: 0x5C

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(SimpleCollator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static SimpleCollator() { }

	[CalledBy(Type = typeof(SimpleCollator), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CompareInfo), Member = "GetCollator", ReturnType = typeof(ISimpleCollator))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "FillCJK", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CodePointIndexer&), typeof(Byte*&), typeof(Byte*&), typeof(CodePointIndexer&), typeof(Byte*&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "GetTailoringInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TailoringInfo))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "BuildTailoringTables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo), typeof(TailoringInfo), typeof(Contraction[]&), typeof(Level2Map[]&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public SimpleCollator(CultureInfo culture) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "FillSortKeyRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExtenderType), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesForwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(ExtenderType), typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesBackwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(ExtenderType), typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CodePointIndexer), Member = "ToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "Category", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[CallsUnknownMethods(Count = 1)]
	private byte Category(int cp) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void ClearBuffer(Byte* buffer, int size) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "System.Globalization.ISimpleCollator.Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IsSuffix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(CompareOptions)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IsSuffix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(CompareOptions)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	internal int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options) { }

	[CallerCount(Count = 0)]
	private int CompareFlagPair(bool b1, bool b2) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IsPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(CompareOptions)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IsPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(bool), typeof(Context&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(SimpleCollator), Member = "IsSafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "HasSpecialWeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SimpleCollator), Member = "Level2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExtenderType)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(SimpleCollator), Member = "GetContraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(Contraction))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "Level3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(SimpleCollator), Member = "Level1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(SimpleCollator), Member = "FilterExtender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExtenderType), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SimpleCollator), Member = "Category", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "IsIgnorableNonSpacing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "IsJapaneseSmallLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SimpleCollator), Member = "IsIgnorable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareOptions)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SimpleCollator), Member = "GetExtenderType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ExtenderType))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(SimpleCollator), Member = "FilterOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SimpleCollator), Member = "IsHalfKana", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareOptions)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private int CompareInternal(string s1, int idx1, int len1, string s2, int idx2, int len2, out bool targetConsumed, out bool sourceConsumed, bool skipHeadingExtenders, bool immediateBreakup, ref Context ctx) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(char), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(UnicodeCategory))]
	[Calls(Type = typeof(SortKeyBuffer), Member = "AppendNormal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SimpleCollator), Member = "Level2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExtenderType)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "HasSpecialWeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SimpleCollator), Member = "Category", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(SimpleCollator), Member = "Level1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "Level3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "IsJapaneseSmallLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SimpleCollator), Member = "IsHalfKana", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareOptions)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SortKeyBuffer), Member = "AppendBufferPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(Byte[]&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void FillSortKeyRaw(int i, ExtenderType ext, SortKeyBuffer buf, CompareOptions opt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SortKeyBuffer), Member = "AppendNormal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void FillSurrogateSortKeyRaw(int i, SortKeyBuffer buf) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesForwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(ExtenderType), typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesBackwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(ExtenderType), typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "HasSpecialWeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SimpleCollator), Member = "IsHalfKana", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareOptions)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SimpleCollator), Member = "Level1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[ContainsUnimplementedInstructions]
	private int FilterExtender(int i, ExtenderType ext, CompareOptions opt) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesForwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(ExtenderType), typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesBackwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(ExtenderType), typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private int FilterOptions(int i, CompareOptions opt) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesForwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(ExtenderType), typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(SimpleCollator), Member = "GetContraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Contraction[])}, ReturnType = typeof(Contraction))]
	[CallsUnknownMethods(Count = 2)]
	private Contraction GetContraction(string s, int start, int end) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "GetContraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(Contraction))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 2)]
	private Contraction GetContraction(string s, int start, int end, Contraction[] clist) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesForward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(Context&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesBackward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(Context&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	private ExtenderType GetExtenderType(int i) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private static CultureInfo GetNeutralCulture(CultureInfo info) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SortKeyBuffer), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompareOptions), typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SortKeyBuffer), Member = "GetResult", ReturnType = typeof(SortKey))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override SortKey GetSortKey(string s, CompareOptions options) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SortKeyBuffer), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompareOptions), typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SortKeyBuffer), Member = "GetResult", ReturnType = typeof(SortKey))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public SortKey GetSortKey(string s, int start, int length, CompareOptions options) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CompareOptions)}, ReturnType = typeof(SortKey))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(CompareOptions)}, ReturnType = typeof(SortKey))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SimpleCollator), Member = "FilterExtender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExtenderType), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SortKeyBuffer), Member = "AppendNormal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "Level3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(SimpleCollator), Member = "Level2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExtenderType)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(SimpleCollator), Member = "GetContraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(Contraction))]
	[Calls(Type = typeof(SimpleCollator), Member = "FillSortKeyRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExtenderType), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SimpleCollator), Member = "FilterOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SimpleCollator), Member = "IsIgnorable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareOptions)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SimpleCollator), Member = "GetExtenderType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ExtenderType))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "IsIgnorableNonSpacing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private void GetSortKey(string s, int start, int end, SortKeyBuffer buf, CompareOptions opt) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "GetTailContraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(Contraction))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesBackwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(ExtenderType), typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private Contraction GetTailContraction(string s, int start, int end, Contraction[] clist) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleCollator), Member = "GetTailContraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Contraction[])}, ReturnType = typeof(Contraction))]
	[CallsUnknownMethods(Count = 1)]
	private Contraction GetTailContraction(string s, int start, int end) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(SimpleCollator), Member = "IsIgnorable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareOptions)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SimpleCollator), Member = "GetContraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(Contraction))]
	[Calls(Type = typeof(SimpleCollator), Member = "FilterOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SimpleCollator), Member = "Category", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(SimpleCollator), Member = "Level1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(SimpleCollator), Member = "Level2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExtenderType)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "Level3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "HasSpecialWeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SimpleCollator), Member = "MatchesForward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(Context&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SimpleCollator), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	private int IndexOf(string s, string target, int start, int length, Byte* targetSortKey, ref Context ctx) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(SimpleCollator), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public override int IndexOf(string s, string target, int start, int length, CompareOptions opt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	private int IndexOfOrdinal(string s, char target, int start, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	private int IndexOfOrdinal(string s, string target, int start, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleCollator), Member = "MatchesForward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(Context&)}, ReturnType = typeof(bool))]
	private int IndexOfSortKey(string s, int start, int length, Byte* sortkey, char target, int ti, bool noLv4, ref Context ctx) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "FilterExtender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExtenderType), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "FillSortKeyRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExtenderType), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompareOptions), typeof(Byte*), typeof(int), typeof(ExtenderType), typeof(Byte*), typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	private static bool IsHalfKana(int cp, CompareOptions opt) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "IsIgnorable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(byte)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	private static bool IsIgnorable(int i, CompareOptions opt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleCollator), Member = "IsPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(CompareOptions)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public override bool IsPrefix(string src, string target, CompareOptions opt) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "IsPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(CompareOptions)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public bool IsPrefix(string s, string target, int start, int length, CompareOptions opt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private bool IsPrefix(string s, string target, int start, int length, bool skipHeadingExtenders, ref Context ctx) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private bool IsSafe(int i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SimpleCollator), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool IsSuffix(string s, string target, int start, int length, CompareOptions opt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SimpleCollator), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool IsSuffix(string src, string target, CompareOptions opt) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "IsSuffix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(CompareOptions)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IsSuffix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(CompareOptions)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public override int LastIndexOf(string s, string target, int start, int length, CompareOptions opt) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(SimpleCollator), Member = "IsIgnorable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareOptions)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SimpleCollator), Member = "GetContraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(Contraction))]
	[Calls(Type = typeof(SimpleCollator), Member = "FilterOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SimpleCollator), Member = "Category", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(SimpleCollator), Member = "Level1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(SimpleCollator), Member = "Level2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExtenderType)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "Level3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "HasSpecialWeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SimpleCollator), Member = "MatchesBackward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(Context&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	private int LastIndexOf(string s, string target, int start, int length, Byte* targetSortKey, ref Context ctx) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	private int LastIndexOfOrdinal(string s, string target, int start, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleCollator), Member = "MatchesBackward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(Context&)}, ReturnType = typeof(bool))]
	private int LastIndexOfSortKey(string s, int start, int orgStart, int length, Byte* sortkey, int ti, bool noLv4, ref Context ctx) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "FilterExtender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExtenderType), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "FillSortKeyRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExtenderType), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesForwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(ExtenderType), typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesBackwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(ExtenderType), typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CodePointIndexer), Member = "ToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "Level1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[CallsUnknownMethods(Count = 1)]
	private byte Level1(int cp) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "FillSortKeyRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExtenderType), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesForwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(ExtenderType), typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesBackwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(ExtenderType), typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(CodePointIndexer), Member = "ToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "Level2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[CallsUnknownMethods(Count = 2)]
	private byte Level2(int cp, ExtenderType ext) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "LastIndexOfSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int), typeof(Byte*), typeof(int), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesBackwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(ExtenderType), typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(SimpleCollator), Member = "GetExtenderType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ExtenderType))]
	[Calls(Type = typeof(SimpleCollator), Member = "MatchesBackwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(ExtenderType), typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool MatchesBackward(string s, ref int idx, int end, int orgStart, int ti, Byte* sortkey, bool noLv4, ref Context ctx) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesBackward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(Context&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "IsIgnorable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(byte)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SimpleCollator), Member = "FilterOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SimpleCollator), Member = "Category", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(SimpleCollator), Member = "Level2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExtenderType)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(SimpleCollator), Member = "FilterExtender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExtenderType), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SimpleCollator), Member = "Level1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "Level3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(SimpleCollator), Member = "GetTailContraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Contraction[])}, ReturnType = typeof(Contraction))]
	[Calls(Type = typeof(SimpleCollator), Member = "MatchesBackward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(Context&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SimpleCollator), Member = "MatchesPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompareOptions), typeof(Byte*), typeof(int), typeof(ExtenderType), typeof(Byte*), typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private bool MatchesBackwardCore(string s, ref int idx, int end, int orgStart, int ti, Byte* sortkey, bool noLv4, ExtenderType ext, ref Contraction ct, ref Context ctx) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "IndexOfSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(char), typeof(int), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesForwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(ExtenderType), typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(SimpleCollator), Member = "GetExtenderType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ExtenderType))]
	[Calls(Type = typeof(SimpleCollator), Member = "MatchesForwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(ExtenderType), typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool MatchesForward(string s, ref int idx, int end, int ti, Byte* sortkey, bool noLv4, ref Context ctx) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesForward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(Context&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SimpleCollator), Member = "FilterExtender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExtenderType), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SimpleCollator), Member = "GetContraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(Contraction))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(SimpleCollator), Member = "FilterOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SimpleCollator), Member = "Category", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(SimpleCollator), Member = "Level1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(SimpleCollator), Member = "Level2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExtenderType)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "Level3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(SimpleCollator), Member = "MatchesForward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(Context&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SimpleCollator), Member = "MatchesPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompareOptions), typeof(Byte*), typeof(int), typeof(ExtenderType), typeof(Byte*), typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private bool MatchesForwardCore(string s, ref int idx, int end, int ti, Byte* sortkey, bool noLv4, ExtenderType ext, ref Contraction ct, ref Context ctx) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesForwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(ExtenderType), typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesBackwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(ExtenderType), typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "HasSpecialWeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "IsJapaneseSmallLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SimpleCollator), Member = "IsHalfKana", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareOptions)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	private bool MatchesPrimitive(CompareOptions opt, Byte* source, int si, ExtenderType ext, Byte* target, int ti, bool noLv4) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	private int QuickIndexOf(string s, string target, int start, int length, out bool testWasUnable) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "FillCJK", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CodePointIndexer&), typeof(Byte*&), typeof(Byte*&), typeof(CodePointIndexer&), typeof(Byte*&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	private void SetCJKTable(CultureInfo culture, ref CodePointIndexer cjkIndexer, ref Byte* catTable, ref Byte* lv1Table, ref CodePointIndexer lv2Indexer, ref Byte* lv2Table) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleCollator), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(CompareOptions)}, ReturnType = typeof(int))]
	private override int System.Globalization.ISimpleCollator.Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static byte ToDashTypeValue(ExtenderType ext, CompareOptions opt) { }

}

