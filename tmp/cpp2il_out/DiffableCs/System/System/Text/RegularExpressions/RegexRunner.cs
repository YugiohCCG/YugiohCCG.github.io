namespace System.Text.RegularExpressions;

public abstract class RegexRunner
{
	private const int TimeoutCheckFrequency = 1000; //Field offset: 0x0
	protected private int runtextbeg; //Field offset: 0x10
	protected private int runtextend; //Field offset: 0x14
	protected private int runtextstart; //Field offset: 0x18
	protected private string runtext; //Field offset: 0x20
	protected private int runtextpos; //Field offset: 0x28
	protected private Int32[] runtrack; //Field offset: 0x30
	protected private int runtrackpos; //Field offset: 0x38
	protected private Int32[] runstack; //Field offset: 0x40
	protected private int runstackpos; //Field offset: 0x48
	protected private Int32[] runcrawl; //Field offset: 0x50
	protected private int runcrawlpos; //Field offset: 0x58
	protected private int runtrackcount; //Field offset: 0x5C
	protected private Match runmatch; //Field offset: 0x60
	protected private Regex runregex; //Field offset: 0x68
	private int _timeout; //Field offset: 0x70
	private bool _ignoreTimeout; //Field offset: 0x74
	private int _timeoutOccursAt; //Field offset: 0x78
	private int _timeoutChecksToSkip; //Field offset: 0x7C

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected private RegexRunner() { }

	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RegexRunner), Member = "Crawl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected void Capture(int capnum, int start, int end) { }

	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TimeSpan), Member = "FromMilliseconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(RegexMatchTimeoutException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	protected void CheckTimeout() { }

	[CalledBy(Type = typeof(RegexRunner), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexRunner), Member = "TransferCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	protected void Crawl(int i) { }

	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	protected int Crawlpos() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TimeSpan), Member = "FromMilliseconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(RegexMatchTimeoutException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private void DoCheckTimeout() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	protected void DoubleCrawl() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	protected void DoubleStack() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	protected void DoubleTrack() { }

	[CalledBy(Type = typeof(RegexInterpreter), Member = "Goto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexInterpreter), Member = "Backtrack", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	protected void EnsureStorage() { }

	protected abstract bool FindFirstChar() { }

	protected abstract void Go() { }

	[CalledBy(Type = typeof(RegexRunner), Member = "Scan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(TimeSpan)}, ReturnType = typeof(Match))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Match), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MatchSparse), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(Hashtable), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void InitMatch() { }

	protected abstract void InitTrackCount() { }

	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(RegexCharClass), Member = "IsWordChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	protected bool IsBoundary(int index, int startpos, int endpos) { }

	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(RegexCharClass), Member = "IsECMAWordChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	protected bool IsECMABoundary(int index, int startpos, int endpos) { }

	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected bool IsMatched(int cap) { }

	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected int MatchIndex(int cap) { }

	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected int MatchLength(int cap) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	protected int Popcrawl() { }

	[CalledBy(Type = typeof(Regex), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Match))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Regex), Member = "ValidateMatchTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(RegexRunner), Member = "InitMatch", ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeSpan), Member = "FromMilliseconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(RegexMatchTimeoutException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	protected private Match Scan(Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, TimeSpan timeout) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	private void StartTimeoutWatch() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private Match TidyMatch(bool quick) { }

	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RegexRunner), Member = "Crawl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	protected void TransferCapture(int capnum, int uncapnum, int start, int end) { }

	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected void Uncapture() { }

}

