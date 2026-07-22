namespace System.Text.RegularExpressions;

[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
internal struct RegexWriter
{
	private ValueListBuilder<Int32> _emitted; //Field offset: 0x0
	private ValueListBuilder<Int32> _intStack; //Field offset: 0x20
	private readonly Dictionary<String, Int32> _stringHash; //Field offset: 0x40
	private readonly List<String> _stringTable; //Field offset: 0x48
	private Hashtable _caps; //Field offset: 0x50
	private int _trackCount; //Field offset: 0x58

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	private RegexWriter(Span<Int32> emittedSpan, Span<Int32> intStackSpan) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void Dispose() { }

	[CalledBy(Type = typeof(RegexWriter), Member = "EmitFragment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RegexNode), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(RegexCode), Member = "OpcodeBacktracks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private void Emit(int op) { }

	[CalledBy(Type = typeof(RegexWriter), Member = "EmitFragment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RegexNode), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(RegexCode), Member = "OpcodeBacktracks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private void Emit(int op, int opd1) { }

	[CalledBy(Type = typeof(RegexWriter), Member = "EmitFragment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RegexNode), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(RegexCode), Member = "OpcodeBacktracks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	private void Emit(int op, int opd1, int opd2) { }

	[CalledBy(Type = typeof(RegexWriter), Member = "RegexCodeFromRegexTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(RegexCode))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RegexWriter), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexWriter), Member = "StringCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RegexWriter), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexWriter), Member = "MapCapnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RegexWriter), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValueListBuilder`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(RegexWriter), Member = "PatchJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexCode), Member = "OpcodeBacktracks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 22)]
	[ContainsUnimplementedInstructions]
	private void EmitFragment(int nodetype, RegexNode node, int curIndex) { }

	[CalledBy(Type = typeof(RegexWriter), Member = "EmitFragment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RegexNode), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private int MapCapnum(int capnum) { }

	[CalledBy(Type = typeof(RegexWriter), Member = "EmitFragment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RegexNode), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ValueListBuilder`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	private void PatchJump(int offset, int jumpDest) { }

	[CalledBy(Type = typeof(RegexWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(RegexCode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RegexCode), Member = "OpcodeBacktracks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexWriter), Member = "EmitFragment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RegexNode), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValueListBuilder`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(RegexFCD), Member = "FirstChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(System.Nullable`1<System.Text.RegularExpressions.RegexPrefix>))]
	[Calls(Type = typeof(RegexFCD), Member = "Prefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(RegexPrefix))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(RegexBoyerMoore), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(CultureInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexFCD), Member = "Anchors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ReadOnlySpan`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(RegexCode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(System.Collections.Generic.List`1<System.String>), typeof(int), typeof(Hashtable), typeof(int), typeof(RegexBoyerMoore), typeof(System.Nullable`1<System.Text.RegularExpressions.RegexPrefix>), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	public RegexCode RegexCodeFromRegexTree(RegexTree tree) { }

	[CalledBy(Type = typeof(RegexWriter), Member = "EmitFragment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RegexNode), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private int StringCode(string str) { }

	[CalledBy(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexWriter), Member = "RegexCodeFromRegexTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(RegexCode))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public static RegexCode Write(RegexTree tree) { }

}

