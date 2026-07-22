namespace Mono.Globalization.Unicode;

internal class MSCompatUnicodeTable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<Level2Map> <>9__17_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal int <BuildTailoringTables>b__17_0(Level2Map a, Level2Map b) { }

	}

	public static int MaxExpansionLength; //Field offset: 0x0
	private static readonly Byte* ignorableFlags; //Field offset: 0x8
	private static readonly Byte* categories; //Field offset: 0x10
	private static readonly Byte* level1; //Field offset: 0x18
	private static readonly Byte* level2; //Field offset: 0x20
	private static readonly Byte* level3; //Field offset: 0x28
	private static Byte* cjkCHScategory; //Field offset: 0x30
	private static Byte* cjkCHTcategory; //Field offset: 0x38
	private static Byte* cjkJAcategory; //Field offset: 0x40
	private static Byte* cjkKOcategory; //Field offset: 0x48
	private static Byte* cjkCHSlv1; //Field offset: 0x50
	private static Byte* cjkCHTlv1; //Field offset: 0x58
	private static Byte* cjkJAlv1; //Field offset: 0x60
	private static Byte* cjkKOlv1; //Field offset: 0x68
	private static Byte* cjkKOlv2; //Field offset: 0x70
	private static readonly Char[] tailoringArr; //Field offset: 0x78
	private static readonly TailoringInfo[] tailoringInfos; //Field offset: 0x80
	private static object forLock; //Field offset: 0x88
	public static readonly bool isReady; //Field offset: 0x90

	public static bool IsReady
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 82
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "GetResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	private static MSCompatUnicodeTable() { }

	[CalledBy(Type = typeof(SimpleCollator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Contraction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Char[]), typeof(string), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IComparer`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 16)]
	public static void BuildTailoringTables(CultureInfo culture, TailoringInfo t, ref Contraction[] contractions, ref Level2Map[] diacriticals) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "Category", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CodePointIndexer), Member = "ToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public static byte Category(int cp) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "SetCJKTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo), typeof(CodePointIndexer&), typeof(Byte*&), typeof(Byte*&), typeof(CodePointIndexer&), typeof(Byte*&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "FillCJKCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CodePointIndexer&), typeof(Byte*&), typeof(Byte*&), typeof(CodePointIndexer&), typeof(Byte*&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "SetCJKReferences", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CodePointIndexer&), typeof(Byte*&), typeof(Byte*&), typeof(CodePointIndexer&), typeof(Byte*&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void FillCJK(string culture, ref CodePointIndexer cjkIndexer, ref Byte* catTable, ref Byte* lv1Table, ref CodePointIndexer lv2Indexer, ref Byte* lv2Table) { }

	[CalledBy(Type = typeof(MSCompatUnicodeTable), Member = "FillCJK", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CodePointIndexer&), typeof(Byte*&), typeof(Byte*&), typeof(CodePointIndexer&), typeof(Byte*&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "GetResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 10)]
	private static void FillCJKCore(string culture, ref CodePointIndexer cjkIndexer, ref Byte* catTable, ref Byte* lv1Table, ref CodePointIndexer cjkLv2Indexer, ref Byte* lv2Table) { }

	[CallerCount(Count = 0)]
	public static bool get_IsReady() { }

	[CalledBy(Type = typeof(MSCompatUnicodeTable), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MSCompatUnicodeTable), Member = "FillCJKCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CodePointIndexer&), typeof(Byte*&), typeof(Byte*&), typeof(CodePointIndexer&), typeof(Byte*&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RuntimeAssembly), Member = "GetManifestResourceInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(Module&)}, ReturnType = typeof(IntPtr))]
	[CallsUnknownMethods(Count = 3)]
	private static IntPtr GetResource(string name) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static TailoringInfo GetTailoringInfo(int lcid) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "FilterExtender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Mono.Globalization.Unicode.SimpleCollator+ExtenderType", typeof(CompareOptions)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "FillSortKeyRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Mono.Globalization.Unicode.SimpleCollator+ExtenderType", typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompareOptions), typeof(Byte*), typeof(int), "Mono.Globalization.Unicode.SimpleCollator+ExtenderType", typeof(Byte*), typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[ContainsUnimplementedInstructions]
	public static bool HasSpecialWeight(char c) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool IsHalfWidthKana(char c) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool IsHiragana(char c) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "IsIgnorable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareOptions)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesBackwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(int), typeof(Byte*), typeof(bool), "Mono.Globalization.Unicode.SimpleCollator+ExtenderType", typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(char), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(UnicodeCategory))]
	[Calls(Type = typeof(CodePointIndexer), Member = "ToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool IsIgnorable(int cp, byte flag) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[ContainsInvalidInstructions]
	public static bool IsIgnorableNonSpacing(int cp) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "FillSortKeyRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Mono.Globalization.Unicode.SimpleCollator+ExtenderType", typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompareOptions), typeof(Byte*), typeof(int), "Mono.Globalization.Unicode.SimpleCollator+ExtenderType", typeof(Byte*), typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsJapaneseSmallLetter(char c) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "Level1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CodePointIndexer), Member = "ToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public static byte Level1(int cp) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "Level2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Mono.Globalization.Unicode.SimpleCollator+ExtenderType"}, ReturnType = typeof(byte))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CodePointIndexer), Member = "ToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public static byte Level2(int cp) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "FillSortKeyRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Mono.Globalization.Unicode.SimpleCollator+ExtenderType", typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesForwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(Byte*), typeof(bool), "Mono.Globalization.Unicode.SimpleCollator+ExtenderType", typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesBackwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(int), typeof(Byte*), typeof(bool), "Mono.Globalization.Unicode.SimpleCollator+ExtenderType", typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CodePointIndexer), Member = "ToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public static byte Level3(int cp) { }

	[CalledBy(Type = typeof(MSCompatUnicodeTable), Member = "FillCJK", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CodePointIndexer&), typeof(Byte*&), typeof(Byte*&), typeof(CodePointIndexer&), typeof(Byte*&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private static void SetCJKReferences(string name, ref CodePointIndexer cjkIndexer, ref Byte* catTable, ref Byte* lv1Table, ref CodePointIndexer lv2Indexer, ref Byte* lv2Table) { }

	[CallerCount(Count = 0)]
	public static int ToKanaTypeInsensitive(int i) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static int ToWidthCompat(int i) { }

	[CallerCount(Count = 0)]
	private static uint UInt32FromBytePtr(Byte* raw, uint idx) { }

}

