namespace System.Text.RegularExpressions;

internal sealed class RegexInterpreter : RegexRunner
{
	private readonly RegexCode _code; //Field offset: 0x80
	private readonly CultureInfo _culture; //Field offset: 0x88
	private int _operator; //Field offset: 0x90
	private int _codepos; //Field offset: 0x94
	private bool _rightToLeft; //Field offset: 0x98
	private bool _caseInsensitive; //Field offset: 0x99

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public RegexInterpreter(RegexCode code, CultureInfo culture) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void Advance(int i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RegexRunner), Member = "EnsureStorage", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void Backtrack() { }

	[CallerCount(Count = 0)]
	private void Backwardnext() { }

	[CallerCount(Count = 0)]
	private int Bump() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	private char CharAt(int j) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(RegexInterpreter), Member = "Forwardcharnext", ReturnType = typeof(char))]
	[Calls(Type = typeof(RegexCharClass), Member = "CharInClassRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexBoyerMoore), Member = "Scan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RegexBoyerMoore), Member = "MatchPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual bool FindFirstChar() { }

	[CalledBy(Type = typeof(RegexInterpreter), Member = "FindFirstChar", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private char Forwardcharnext() { }

	[CallerCount(Count = 0)]
	private int Forwardchars() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RegexInterpreter), Member = "TrackPush2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexInterpreter), Member = "TrackPush2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexCharClass), Member = "CharInClassRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexRunner), Member = "IsECMABoundary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexRunner), Member = "Uncapture", ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexRunner), Member = "Crawlpos", ReturnType = typeof(int))]
	[Calls(Type = typeof(RegexRunner), Member = "TransferCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexRunner), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexInterpreter), Member = "StackPush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexInterpreter), Member = "TrackPush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexRunner), Member = "EnsureStorage", ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexRunner), Member = "IsBoundary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexRunner), Member = "MatchLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RegexRunner), Member = "MatchIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RegexRunner), Member = "IsMatched", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(RegexInterpreter), Member = "TrackPush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexCharClass), Member = "CharInClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexInterpreter), Member = "Forwardcharnext", ReturnType = typeof(char))]
	[Calls(Type = typeof(RegexRunner), Member = "CheckTimeout", ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexInterpreter), Member = "Goto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexInterpreter), Member = "Refmatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NotImplemented), Member = "ByDesignWithMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	protected virtual void Go() { }

	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RegexRunner), Member = "EnsureStorage", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void Goto(int newpos) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void InitTrackCount() { }

	[CallerCount(Count = 0)]
	private int Leftchars() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private int Operand(int i) { }

	[CallerCount(Count = 33)]
	[DeduplicatedMethod]
	private int Operator() { }

	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private bool Refmatch(int index, int len) { }

	[CallerCount(Count = 0)]
	private int Rightchars() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private void SetOperator(int op) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private int StackPeek(int i) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private int StackPeek() { }

	[CallerCount(Count = 0)]
	private void StackPop() { }

	[CallerCount(Count = 0)]
	private void StackPop(int framesize) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void StackPush(int I1) { }

	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void StackPush(int I1, int I2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private bool Stringmatch(string str) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	private int Textpos() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	private int Textstart() { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	private void Textto(int newpos) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private int TrackPeek() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private int TrackPeek(int i) { }

	[CallerCount(Count = 0)]
	private void TrackPop(int framesize) { }

	[CallerCount(Count = 0)]
	private void TrackPop() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private int Trackpos() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void TrackPush(int I1, int I2, int I3) { }

	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 2)]
	private void TrackPush(int I1, int I2) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void TrackPush() { }

	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void TrackPush(int I1) { }

	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void TrackPush2(int I1, int I2) { }

	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	private void TrackPush2(int I1) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void Trackto(int newpos) { }

}

