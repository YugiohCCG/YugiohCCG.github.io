namespace System.Text.RegularExpressions;

internal sealed class RegexParser
{
	private static readonly Byte[] s_category; //Field offset: 0x0
	private RegexNode _stack; //Field offset: 0x10
	private RegexNode _group; //Field offset: 0x18
	private RegexNode _alternation; //Field offset: 0x20
	private RegexNode _concatenation; //Field offset: 0x28
	private RegexNode _unit; //Field offset: 0x30
	private string _pattern; //Field offset: 0x38
	private int _currentPos; //Field offset: 0x40
	private CultureInfo _culture; //Field offset: 0x48
	private int _autocap; //Field offset: 0x50
	private int _capcount; //Field offset: 0x54
	private int _captop; //Field offset: 0x58
	private int _capsize; //Field offset: 0x5C
	private Hashtable _caps; //Field offset: 0x60
	private Hashtable _capnames; //Field offset: 0x68
	private Int32[] _capnumlist; //Field offset: 0x70
	private List<String> _capnamelist; //Field offset: 0x78
	private RegexOptions _options; //Field offset: 0x80
	private List<RegexOptions> _optionsStack; //Field offset: 0x88
	private bool _ignoreNextParen; //Field offset: 0x90

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static RegexParser() { }

	[CalledBy(Type = typeof(RegexParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions)}, ReturnType = typeof(RegexTree))]
	[CalledBy(Type = typeof(RegexParser), Member = "ParseReplacement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Hashtable), typeof(int), typeof(Hashtable), typeof(RegexOptions)}, ReturnType = typeof(RegexReplacement))]
	[CalledBy(Type = typeof(RegexReplacement), Member = "GetOrCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.WeakReference`1<System.Text.RegularExpressions.RegexReplacement>), typeof(string), typeof(Hashtable), typeof(int), typeof(Hashtable), typeof(RegexOptions)}, ReturnType = typeof(RegexReplacement))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private RegexParser(CultureInfo culture) { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RegexNode), Member = "ReverseLeft", ReturnType = typeof(RegexNode))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Reverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexNode), Member = "AddChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexNode)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void AddAlternate() { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanReplacement", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = "System.Text.StringBuilderCache", Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = "System.Text.StringBuilderCache", Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RegexNode), Member = "AddChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexNode)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	private void AddConcatenate(int pos, int cch, bool isReplacement) { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RegexNode), Member = "AddChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexNode)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void AddConcatenate() { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RegexNode), Member = "AddChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexNode)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void AddConcatenate(bool lazy, int min, int max) { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RegexNode), Member = "ReverseLeft", ReturnType = typeof(RegexNode))]
	[Calls(Type = typeof(RegexNode), Member = "AddChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexNode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Reverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexParser), Member = "MakeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ArgumentException))]
	[CallsUnknownMethods(Count = 5)]
	private void AddGroup() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void AddUnitNode(RegexNode node) { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void AddUnitNotone(char ch) { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void AddUnitOne(char ch) { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void AddUnitSet(string cc) { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void AddUnitType(int type) { }

	[CalledBy(Type = typeof(RegexParser), Member = "CountCaptures", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RegexParser), Member = "NoteCaptureSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.Int32>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.Int32>))]
	[Calls(Type = typeof(Array), Member = "Sort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Convert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 16)]
	[ContainsUnimplementedInstructions]
	private void AssignNameSlots() { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanGroupOpen", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanBasicBackslash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanDollar", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private int CaptureSlotFromName(string capname) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	private char CharAt(int i) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private int CharsRight() { }

	[CalledBy(Type = typeof(RegexParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions)}, ReturnType = typeof(RegexTree))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RegexParser), Member = "PopKeepOptions", ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexParser), Member = "ScanOptions", ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexParser), Member = "NoteCaptureName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexParser), Member = "ScanCapname", ReturnType = typeof(string))]
	[Calls(Type = typeof(RegexParser), Member = "ScanDecimal", ReturnType = typeof(int))]
	[Calls(Type = typeof(RegexCharClass), Member = "IsWordChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexParser), Member = "PushOptions", ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexParser), Member = "ScanBlank", ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexParser), Member = "ScanBackslash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(RegexNode))]
	[Calls(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(RegexCharClass))]
	[Calls(Type = typeof(RegexParser), Member = "PopOptions", ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexParser), Member = "EmptyOptionsStack", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(RegexParser), Member = "NoteCaptureSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexParser), Member = "AssignNameSlots", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void CountCaptures() { }

	[CalledBy(Type = typeof(RegexParser), Member = "CountCaptures", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool EmptyOptionsStack() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool EmptyStack() { }

	[CalledBy(Type = typeof(Regex), Member = "Escape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(RegexParser), Member = "IsMetachar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = "System.Text.StringBuilderCache", Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = "System.Text.StringBuilderCache", Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public static string Escape(string input) { }

	[CallerCount(Count = 0)]
	private static int HexDigit(char ch) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool IsCaptureName(string capname) { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanGroupOpen", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanBasicBackslash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanDollar", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool IsCaptureSlot(int i) { }

	[CalledBy(Type = typeof(RegexParser), Member = "Escape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static bool IsMetachar(char ch) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool IsOnlyTopOption(RegexOptions option) { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static bool IsQuantifier(char ch) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static bool IsSpace(char ch) { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static bool IsSpecial(char ch) { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static bool IsStopperX(char ch) { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private bool IsTrueQuantifier() { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(RegexCharClass))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanGroupOpen", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanBlank", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanBasicBackslash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanDollar", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanDecimal", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanControl", ReturnType = typeof(char))]
	[CalledBy(Type = typeof(RegexParser), Member = "ParseProperty", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(RegexParser), Member = "PopGroup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexParser), Member = "AddGroup", ReturnType = typeof(void))]
	[CallerCount(Count = 46)]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	private ArgumentException MakeException(string message) { }

	[CallerCount(Count = 0)]
	private void MoveLeft() { }

	[CallerCount(Count = 0)]
	private void MoveRight(int i) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	private void MoveRight() { }

	[CalledBy(Type = typeof(RegexParser), Member = "CountCaptures", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void NoteCaptureName(string name, int pos) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void NoteCaptures(Hashtable caps, int capsize, Hashtable capnames) { }

	[CalledBy(Type = typeof(RegexParser), Member = "CountCaptures", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexParser), Member = "AssignNameSlots", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void NoteCaptureSlot(int i, int pos) { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanOptions", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static RegexOptions OptionFromCode(char ch) { }

	[CalledBy(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(RegexParser), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexParser), Member = "CountCaptures", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	public static RegexTree Parse(string re, RegexOptions op) { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(RegexCharClass))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(RegexCharClass), Member = "IsWordChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RegexParser), Member = "MakeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ArgumentException))]
	[CallsUnknownMethods(Count = 10)]
	private string ParseProperty() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(RegexParser), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexParser), Member = "ScanReplacement", ReturnType = typeof(RegexNode))]
	[Calls(Type = typeof(RegexReplacement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexNode), typeof(Hashtable)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public static RegexReplacement ParseReplacement(string rep, Hashtable caps, int capsize, Hashtable capnames, RegexOptions op) { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RegexNode), Member = "AddChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexNode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexParser), Member = "MakeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ArgumentException))]
	[CallsUnknownMethods(Count = 9)]
	private void PopGroup() { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "CountCaptures", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void PopKeepOptions() { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "CountCaptures", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void PopOptions() { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void PushGroup() { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "CountCaptures", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void PushOptions() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "RemoveRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void Reset(RegexOptions topopts) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	private char RightChar(int i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	internal char RightChar() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	private char RightCharMoveRight() { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "CountCaptures", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(RegexParser), Member = "ScanBasicBackslash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(RegexNode))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsInvalidInstructions]
	private RegexNode ScanBackslash(bool scanOnly) { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanBackslash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(RegexParser), Member = "ScanDecimal", ReturnType = typeof(int))]
	[Calls(Type = typeof(RegexParser), Member = "IsCaptureSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexCharClass), Member = "IsWordChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexParser), Member = "ScanCapname", ReturnType = typeof(string))]
	[Calls(Type = typeof(RegexParser), Member = "CaptureSlotFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RegexParser), Member = "ScanCharEscape", ReturnType = typeof(char))]
	[Calls(Type = typeof(RegexParser), Member = "MakeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ArgumentException))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 22)]
	[ContainsUnimplementedInstructions]
	private RegexNode ScanBasicBackslash(bool scanOnly) { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "CountCaptures", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(RegexParser), Member = "MakeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ArgumentException))]
	[CallsUnknownMethods(Count = 8)]
	private void ScanBlank() { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(RegexCharClass))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanGroupOpen", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanBasicBackslash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanDollar", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "CountCaptures", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(RegexCharClass), Member = "IsWordChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private string ScanCapname() { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(RegexCharClass))]
	[CalledBy(Type = typeof(RegexParser), Member = "CountCaptures", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(RegexCharClass), Member = "AddCategoryFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexCharClass), Member = "AddLowercase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexCharClass), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(RegexCharClass))]
	[Calls(Type = typeof(RegexCharClass), Member = "AddChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexParser), Member = "ScanCapname", ReturnType = typeof(string))]
	[Calls(Type = typeof(RegexCharClass), Member = "AddDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexParser), Member = "ParseProperty", ReturnType = typeof(string))]
	[Calls(Type = typeof(RegexParser), Member = "MakeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ArgumentException))]
	[Calls(Type = typeof(RegexCharClass), Member = "AddWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexParser), Member = "ScanCharEscape", ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(RegexCharClass), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexCharClass), Member = "AddSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 31)]
	[ContainsUnimplementedInstructions]
	private RegexCharClass ScanCharClass(bool caseInsensitive, bool scanOnly) { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(RegexCharClass))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanBasicBackslash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	private char ScanCharEscape() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(RegexParser), Member = "MakeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ArgumentException))]
	[CallsUnknownMethods(Count = 7)]
	private char ScanControl() { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanGroupOpen", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanBasicBackslash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanDollar", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "CountCaptures", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(RegexParser), Member = "MakeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ArgumentException))]
	[CallsUnknownMethods(Count = 4)]
	private int ScanDecimal() { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanReplacement", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(RegexParser), Member = "IsCaptureSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexParser), Member = "ScanDecimal", ReturnType = typeof(int))]
	[Calls(Type = typeof(RegexCharClass), Member = "IsWordChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexParser), Member = "ScanCapname", ReturnType = typeof(string))]
	[Calls(Type = typeof(RegexParser), Member = "CaptureSlotFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RegexParser), Member = "MakeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ArgumentException))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	private RegexNode ScanDollar() { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(RegexCharClass), Member = "IsWordChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexParser), Member = "ScanCapname", ReturnType = typeof(string))]
	[Calls(Type = typeof(RegexParser), Member = "CaptureSlotFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RegexParser), Member = "ScanDecimal", ReturnType = typeof(int))]
	[Calls(Type = typeof(RegexParser), Member = "IsCaptureSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexParser), Member = "ScanOptions", ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RegexParser), Member = "MakeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ArgumentException))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 50)]
	private RegexNode ScanGroupOpen() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(RegexParser), Member = "MakeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ArgumentException))]
	[CallsUnknownMethods(Count = 4)]
	private char ScanHex(int c) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	private char ScanOctal() { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanGroupOpen", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "CountCaptures", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(RegexParser), Member = "OptionFromCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(RegexOptions))]
	[CallsUnknownMethods(Count = 1)]
	private void ScanOptions() { }

	[CalledBy(Type = typeof(RegexParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions)}, ReturnType = typeof(RegexTree))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RegexCharClass), Member = "ToStringClass", ReturnType = typeof(string))]
	[Calls(Type = typeof(RegexParser), Member = "AddConcatenate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexParser), Member = "AddConcatenate", ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexParser), Member = "ScanDecimal", ReturnType = typeof(int))]
	[Calls(Type = typeof(RegexParser), Member = "AddUnitNotone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexParser), Member = "PopOptions", ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexParser), Member = "PopGroup", ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexParser), Member = "AddGroup", ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexParser), Member = "PopKeepOptions", ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexParser), Member = "PushGroup", ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexParser), Member = "ScanGroupOpen", ReturnType = typeof(RegexNode))]
	[Calls(Type = typeof(RegexParser), Member = "PushOptions", ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexParser), Member = "AddUnitSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(RegexCharClass))]
	[Calls(Type = typeof(RegexParser), Member = "ScanBackslash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(RegexNode))]
	[Calls(Type = typeof(RegexParser), Member = "AddUnitType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexParser), Member = "AddAlternate", ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexParser), Member = "AddUnitOne", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexParser), Member = "AddConcatenate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexParser), Member = "IsQuantifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexParser), Member = "IsStopperX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexParser), Member = "IsTrueQuantifier", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexParser), Member = "IsSpecial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(RegexParser), Member = "ScanBlank", ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexParser), Member = "StartGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexNode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexParser), Member = "MakeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ArgumentException))]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 24)]
	[ContainsUnimplementedInstructions]
	private RegexNode ScanRegex() { }

	[CalledBy(Type = typeof(RegexParser), Member = "ParseReplacement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Hashtable), typeof(int), typeof(Hashtable), typeof(RegexOptions)}, ReturnType = typeof(RegexReplacement))]
	[CalledBy(Type = typeof(RegexReplacement), Member = "GetOrCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.WeakReference`1<System.Text.RegularExpressions.RegexReplacement>), typeof(string), typeof(Hashtable), typeof(int), typeof(Hashtable), typeof(RegexOptions)}, ReturnType = typeof(RegexReplacement))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(RegexParser), Member = "AddConcatenate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexParser), Member = "ScanDollar", ReturnType = typeof(RegexNode))]
	[Calls(Type = typeof(RegexNode), Member = "AddChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexNode)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private RegexNode ScanReplacement() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void SetPattern(string Re) { }

	[CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void StartGroup(RegexNode openGroup) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	private int Textpos() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void Textto(int pos) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private int TypeFromCode(char ch) { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	private RegexNode Unit() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool UseOptionE() { }

	[CallerCount(Count = 0)]
	private bool UseOptionI() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool UseOptionM() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool UseOptionN() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool UseOptionS() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool UseOptionX() { }

}

