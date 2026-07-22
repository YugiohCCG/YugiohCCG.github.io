namespace System.Text.RegularExpressions;

public class Match : Group
{
	[CompilerGenerated]
	private static readonly Match <Empty>k__BackingField; //Field offset: 0x0
	internal GroupCollection _groupcoll; //Field offset: 0x40
	internal Regex _regex; //Field offset: 0x48
	internal int _textbeg; //Field offset: 0x50
	internal int _textpos; //Field offset: 0x54
	internal int _textend; //Field offset: 0x58
	internal int _textstart; //Field offset: 0x5C
	internal Int32[][] _matches; //Field offset: 0x60
	internal Int32[] _matchcount; //Field offset: 0x68
	internal bool _balancing; //Field offset: 0x70

	public static Match Empty
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 78
	}

	public override GroupCollection Groups
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 140
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Match), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static Match() { }

	[CalledBy(Type = typeof(Match), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MatchSparse), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(Hashtable), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexRunner), Member = "InitMatch", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	internal Match(Regex regex, int capcount, string text, int begpos, int len, int startpos) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal Match() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	internal override void AddMatch(int cap, int start, int len) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal override void BalanceMatch(int cap) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static Match get_Empty() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public override GroupCollection get_Groups() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ExceptionArgument"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsUnknownMethods(Count = 2)]
	internal override ReadOnlySpan<Char> GroupToStringImpl(int groupnum) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal override bool IsMatched(int cap) { }

	[CalledBy(Type = typeof(RegexReplacement), Member = "ReplacementImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(Match)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexReplacement), Member = "ReplacementImplRTL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.String>), typeof(Match)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexReplacement), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal ReadOnlySpan<Char> LastGroupToStringImpl() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal override int MatchIndex(int cap) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal override int MatchLength(int cap) { }

	[CalledBy(Type = typeof(RegexReplacement), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Regex), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Match))]
	public Match NextMatch() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal override void RemoveMatch(int cap) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	internal override void Reset(Regex regex, string text, int textbeg, int textend, int textstart) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal override void Tidy(int textpos) { }

}

