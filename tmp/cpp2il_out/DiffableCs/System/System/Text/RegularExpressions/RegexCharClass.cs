namespace System.Text.RegularExpressions;

internal sealed class RegexCharClass
{
	[IsReadOnly]
	private struct LowerCaseMapping
	{
		public readonly char ChMin; //Field offset: 0x0
		public readonly char ChMax; //Field offset: 0x2
		public readonly int LcOp; //Field offset: 0x4
		public readonly int Data; //Field offset: 0x8

		[CallerCount(Count = 0)]
		internal LowerCaseMapping(char chMin, char chMax, int lcOp, int data) { }

	}

	[IsReadOnly]
	private struct SingleRange
	{
		public readonly char First; //Field offset: 0x0
		public readonly char Last; //Field offset: 0x2

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal SingleRange(char first, char last) { }

	}

	private sealed class SingleRangeComparer : IComparer<SingleRange>
	{
		public static readonly SingleRangeComparer Instance; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static SingleRangeComparer() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		private SingleRangeComparer() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public override int Compare(SingleRange x, SingleRange y) { }

	}

	private static readonly string s_internalRegexIgnoreCase; //Field offset: 0x0
	private static readonly string s_space; //Field offset: 0x8
	private static readonly string s_notSpace; //Field offset: 0x10
	private static readonly string s_word; //Field offset: 0x18
	private static readonly string s_notWord; //Field offset: 0x20
	public static readonly string SpaceClass; //Field offset: 0x28
	public static readonly string NotSpaceClass; //Field offset: 0x30
	public static readonly string WordClass; //Field offset: 0x38
	public static readonly string NotWordClass; //Field offset: 0x40
	public static readonly string DigitClass; //Field offset: 0x48
	public static readonly string NotDigitClass; //Field offset: 0x50
	private static readonly Dictionary<String, String> s_definedCategories; //Field offset: 0x58
	private static readonly String[][] s_propTable; //Field offset: 0x60
	private static readonly LowerCaseMapping[] s_lcTable; //Field offset: 0x68
	private List<SingleRange> _rangelist; //Field offset: 0x10
	private StringBuilder _categories; //Field offset: 0x18
	private bool _canonical; //Field offset: 0x20
	private bool _negate; //Field offset: 0x21
	private RegexCharClass _subtractor; //Field offset: 0x28

	public bool CanMerge
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 18
	}

	public bool Negate
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 352)]
	private static RegexCharClass() { }

	[CalledBy(Type = typeof(RegexFC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexFC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexNode), Member = "ReduceAlternation", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(RegexCharClass))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public RegexCharClass() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private RegexCharClass(bool negate, List<SingleRange> ranges, StringBuilder categories, RegexCharClass subtraction) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 1)]
	private void AddCategory(string category) { }

	[CalledBy(Type = typeof(RegexCharClass), Member = "AddDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(RegexCharClass))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = "System.Text.StringBuilderCache", Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = "System.Text.StringBuilderCache", Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(RegexCharClass), Member = "SetFromProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RegexCharClass), Member = "AddSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern) { }

	[CalledBy(Type = typeof(RegexNode), Member = "ReduceAlternation", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(RegexCharClass))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RegexCharClass), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(void))]
	public void AddChar(char c) { }

	[CalledBy(Type = typeof(RegexFC), Member = "AddFC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexFC), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RegexNode), Member = "ReduceAlternation", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RegexCharClass), Member = "GetRangeAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(SingleRange))]
	[Calls(Type = typeof(RegexCharClass), Member = "RangeCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void AddCharClass(RegexCharClass cc) { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(RegexCharClass))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RegexCharClass), Member = "AddCategoryFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexCharClass), Member = "AddSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public void AddDigit(bool ecma, bool negate, string pattern) { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(RegexCharClass))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(RegexCharClass), Member = "AddLowercaseRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(CultureInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void AddLowercase(CultureInfo culture) { }

	[CalledBy(Type = typeof(RegexCharClass), Member = "AddLowercase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexFCD), Member = "FirstChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(System.Nullable`1<System.Text.RegularExpressions.RegexPrefix>))]
	[CalledBy(Type = typeof(RegexFC), Member = "GetFirstChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RegexCharClass), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void AddLowercaseRange(char chMin, char chMax, CultureInfo culture) { }

	[CalledBy(Type = typeof(RegexCharClass), Member = "AddChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexCharClass), Member = "AddLowercaseRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexFC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(RegexCharClass))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	public void AddRange(char first, char last) { }

	[CalledBy(Type = typeof(RegexCharClass), Member = "AddCategoryFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexCharClass), Member = "AddWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexCharClass), Member = "AddSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexCharClass), Member = "AddDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(RegexCharClass), Member = "GetRangeAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(SingleRange))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void AddSet(string set) { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(RegexCharClass))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(RegexCharClass), Member = "AddSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void AddSpace(bool ecma, bool negate) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void AddSubtraction(RegexCharClass sub) { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(RegexCharClass))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(RegexCharClass), Member = "AddSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void AddWord(bool ecma, bool negate) { }

	[CalledBy(Type = typeof(RegexCharClass), Member = "ToStringClass", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Text.RegularExpressions.RegexCharClass+SingleRange>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IComparer`1<System.Text.RegularExpressions.RegexCharClass+SingleRange>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void Canonicalize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(UnicodeCategory))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexCharClass), Member = "CharInCategoryGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(UnicodeCategory), typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static bool CharInCategory(char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	[CalledBy(Type = typeof(RegexCharClass), Member = "CharInClassInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RegexCharClass), Member = "CharInCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool CharInCategoryGroup(char ch, UnicodeCategory chcategory, string category, ref int i) { }

	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RegexCharClass), Member = "CharInClassRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	public static bool CharInClass(char ch, string set) { }

	[CalledBy(Type = typeof(RegexCharClass), Member = "CharInClassRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(UnicodeCategory))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexCharClass), Member = "CharInCategoryGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(UnicodeCategory), typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static bool CharInClassInternal(char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	[CalledBy(Type = typeof(RegexCharClass), Member = "IsECMAWordChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RegexCharClass), Member = "IsWordChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RegexCharClass), Member = "CharInClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RegexCharClass), Member = "CharInClassRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RegexInterpreter), Member = "FindFirstChar", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(RegexCharClass), Member = "CharInClassRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexCharClass), Member = "CharInClassInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static bool CharInClassRecursive(char ch, string set, int start) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_CanMerge() { }

	[CalledBy(Type = typeof(RegexCharClass), Member = "AddCharClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexCharClass)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexCharClass), Member = "AddSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	private SingleRange GetRangeAt(int i) { }

	[CalledBy(Type = typeof(RegexRunner), Member = "IsECMABoundary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RegexCharClass), Member = "CharInClassRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	public static bool IsECMAWordChar(char ch) { }

	[CalledBy(Type = typeof(RegexNode), Member = "Reduce", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexNode), Member = "ReduceSet", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool IsEmpty(string charClass) { }

	[CalledBy(Type = typeof(RegexNode), Member = "ReduceAlternation", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool IsMergeable(string charClass) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[ContainsUnimplementedInstructions]
	private static bool IsNegated(string set) { }

	[CalledBy(Type = typeof(RegexNode), Member = "Reduce", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexNode), Member = "ReduceSet", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool IsSingleton(string set) { }

	[CalledBy(Type = typeof(RegexNode), Member = "Reduce", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexNode), Member = "ReduceSet", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool IsSingletonInverse(string set) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool IsSubtraction(string charClass) { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanGroupOpen", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanBasicBackslash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanDollar", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanCapname", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(RegexParser), Member = "ParseProperty", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(RegexParser), Member = "CountCaptures", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexRunner), Member = "IsBoundary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(RegexCharClass), Member = "CharInClassRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	public static bool IsWordChar(char ch) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.Text.StringBuilderCache", Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = "System.Text.StringBuilderCache", Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private static string NegateCategory(string category) { }

	[CalledBy(Type = typeof(RegexNode), Member = "ReduceAlternation", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RegexCharClass), Member = "ParseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(RegexCharClass))]
	public static RegexCharClass Parse(string charClass) { }

	[CalledBy(Type = typeof(RegexCharClass), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(RegexCharClass))]
	[CalledBy(Type = typeof(RegexCharClass), Member = "ParseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(RegexCharClass))]
	[CalledBy(Type = typeof(RegexFC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexCharClass), Member = "ParseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(RegexCharClass))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private static RegexCharClass ParseRecursive(string charClass, int start) { }

	[CalledBy(Type = typeof(RegexCharClass), Member = "AddCharClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexCharClass)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private int RangeCount() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Negate(bool value) { }

	[CalledBy(Type = typeof(RegexCharClass), Member = "AddCategoryFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	private static string SetFromProperty(string capname, bool invert, string pattern) { }

	[CalledBy(Type = typeof(RegexNode), Member = "Reduce", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexNode), Member = "ReduceSet", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	public static char SingletonChar(string set) { }

	[CalledBy(Type = typeof(RegexCharClass), Member = "ToStringClass", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(RegexFCD), Member = "FirstChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(System.Nullable`1<System.Text.RegularExpressions.RegexPrefix>))]
	[CalledBy(Type = typeof(RegexFC), Member = "GetFirstChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(RegexNode), Member = "ReduceAlternation", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 5)]
	[Calls(Type = "System.Text.StringBuilderCache", Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(RegexCharClass), Member = "Canonicalize", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(StringBuilder), Member = "set_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(RegexCharClass), Member = "ToStringClass", ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = "System.Text.StringBuilderCache", Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public string ToStringClass() { }

}

