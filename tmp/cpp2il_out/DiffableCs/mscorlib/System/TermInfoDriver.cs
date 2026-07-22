namespace System;

internal class TermInfoDriver : IConsoleDriver
{
	private static Int32* native_terminal_size; //Field offset: 0x0
	private static int terminal_size; //Field offset: 0x8
	private static readonly String[] locations; //Field offset: 0x10
	private static readonly Int32[] _consoleColorToAnsiCode; //Field offset: 0x18
	private TermInfoReader reader; //Field offset: 0x10
	private int cursorLeft; //Field offset: 0x18
	private int cursorTop; //Field offset: 0x1C
	private string title; //Field offset: 0x20
	private string titleFormat; //Field offset: 0x28
	private bool cursorVisible; //Field offset: 0x30
	private string csrVisible; //Field offset: 0x38
	private string csrInvisible; //Field offset: 0x40
	private string clear; //Field offset: 0x48
	private string bell; //Field offset: 0x50
	private string term; //Field offset: 0x58
	private StreamReader stdin; //Field offset: 0x60
	private CStreamWriter stdout; //Field offset: 0x68
	private int windowWidth; //Field offset: 0x70
	private int windowHeight; //Field offset: 0x74
	private int bufferHeight; //Field offset: 0x78
	private int bufferWidth; //Field offset: 0x7C
	private Char[] buffer; //Field offset: 0x80
	private int readpos; //Field offset: 0x88
	private int writepos; //Field offset: 0x8C
	private string keypadXmit; //Field offset: 0x90
	private string keypadLocal; //Field offset: 0x98
	private bool inited; //Field offset: 0xA0
	private object initLock; //Field offset: 0xA8
	private bool initKeys; //Field offset: 0xB0
	private string origPair; //Field offset: 0xB8
	private string origColors; //Field offset: 0xC0
	private string cursorAddress; //Field offset: 0xC8
	private ConsoleColor fgcolor; //Field offset: 0xD0
	private string setfgcolor; //Field offset: 0xD8
	private string setbgcolor; //Field offset: 0xE0
	private int maxColors; //Field offset: 0xE8
	private bool noGetPosition; //Field offset: 0xEC
	private Hashtable keymap; //Field offset: 0xF0
	private ByteMatcher rootmap; //Field offset: 0xF8
	private int rl_startx; //Field offset: 0x100
	private int rl_starty; //Field offset: 0x104
	private Byte[] control_characters; //Field offset: 0x108
	private Char[] echobuf; //Field offset: 0x110
	private int echon; //Field offset: 0x118

	public override bool Initialized
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public override int WindowHeight
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
		[Calls(Type = typeof(TermInfoDriver), Member = "CheckWindowDimensions", ReturnType = typeof(void))]
		 get { } //Length: 44
	}

	public override int WindowWidth
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
		[Calls(Type = typeof(TermInfoDriver), Member = "CheckWindowDimensions", ReturnType = typeof(void))]
		 get { } //Length: 44
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	private static TermInfoDriver() { }

	[CalledBy(Type = typeof(ConsoleDriver), Member = "CreateTermInfoDriver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IConsoleDriver))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TermInfoDriver), Member = "TryTermInfoDir", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TermInfoReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TermInfoReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Console), Member = "OpenStandardOutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Stream))]
	[Calls(Type = typeof(CStreamWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	public TermInfoDriver(string term) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "InternalBlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ByteMatcher), Member = "AddMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TermInfoStrings), typeof(Byte[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void AddStringMapping(TermInfoStrings s) { }

	[CalledBy(Type = typeof(TermInfoDriver), Member = "GetCursorPosition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "ReadKeyInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(ConsoleKeyInfo))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void AddToBuffer(int b) { }

	[CallerCount(Count = 0)]
	private void AdjustBuffer() { }

	[CalledBy(Type = typeof(TermInfoDriver), Member = "IncrementX", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "IsSpecialKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleKeyInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "get_WindowHeight", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "get_WindowWidth", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "SetCursorPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(TermInfoReader), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TermInfoNumbers)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private void CheckWindowDimensions() { }

	[CalledBy(Type = typeof(TermInfoDriver), Member = "WriteSpecialKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "IsSpecialKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "GetKeyFromBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ConsoleKeyInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(ConsoleKey), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private ConsoleKeyInfo CreateKeyInfoFromInt(int n, bool alt) { }

	[CalledBy(Type = typeof(TermInfoDriver), Member = "InitKeys", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ConsoleKeyInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(ConsoleKey), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 60)]
	[CallsUnknownMethods(Count = 3)]
	private void CreateKeyMap() { }

	[CalledBy(Type = typeof(TermInfoDriver), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "ReadKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConsoleKeyInfo))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "ReadUntilConditionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TermInfoDriver), Member = "IsSpecialKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleKeyInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CStreamWriter), Member = "InternalWriteChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TermInfoDriver), Member = "WriteSpecialKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleKeyInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StreamReader), Member = "DataAvailable", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	private void Echo(ConsoleKeyInfo key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CStreamWriter), Member = "InternalWriteChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void EchoFlush() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override bool get_Initialized() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(TermInfoDriver), Member = "CheckWindowDimensions", ReturnType = typeof(void))]
	public override int get_WindowHeight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(TermInfoDriver), Member = "CheckWindowDimensions", ReturnType = typeof(void))]
	public override int get_WindowWidth() { }

	[CalledBy(Type = typeof(TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "ReadUntilConditionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TermInfoDriver), Member = "AddToBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CStreamWriter), Member = "InternalWriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 4)]
	private void GetCursorPosition() { }

	[CalledBy(Type = typeof(TermInfoDriver), Member = "ReadKeyInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(ConsoleKeyInfo))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ByteMatcher), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(TermInfoStrings))]
	[Calls(Type = typeof(TermInfoDriver), Member = "CreateKeyInfoFromInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(ConsoleKeyInfo))]
	[Calls(Type = typeof(ConsoleKeyInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(ConsoleKey), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	private object GetKeyFromBuffer(bool cooked) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(TermInfoDriver), Member = "CheckWindowDimensions", ReturnType = typeof(void))]
	private void IncrementX() { }

	[CalledBy(Type = typeof(TermInfoDriver), Member = "IncrementX", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "IsSpecialKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleKeyInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "get_WindowHeight", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "get_WindowWidth", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "ReadKeyInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(ConsoleKeyInfo))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "ReadUntilConditionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "SetCursorPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TermInfoDriver), Member = "GetCursorPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Console), Member = "OpenStandardInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Stream))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CStreamWriter), Member = "InternalWriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TermInfoReader), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TermInfoNumbers)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TermInfoReader), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TermInfoStrings)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ConsoleDriver), Member = "get_IsConsole", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 44)]
	public override void Init() { }

	[CalledBy(Type = typeof(TermInfoDriver), Member = "ReadKeyInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(ConsoleKeyInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TermInfoDriver), Member = "CreateKeyMap", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "InternalBlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ByteMatcher), Member = "AddMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TermInfoStrings), typeof(Byte[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private void InitKeys() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StreamReader), Member = "DataAvailable", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool InputPending() { }

	[CalledBy(Type = typeof(CStreamWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CStreamWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TermInfoDriver), Member = "CreateKeyInfoFromInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(ConsoleKeyInfo))]
	[Calls(Type = typeof(TermInfoDriver), Member = "IsSpecialKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleKeyInfo)}, ReturnType = typeof(bool))]
	public bool IsSpecialKey(char c) { }

	[CalledBy(Type = typeof(TermInfoDriver), Member = "IsSpecialKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "Echo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleKeyInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(TermInfoDriver), Member = "CheckWindowDimensions", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public bool IsSpecialKey(ConsoleKeyInfo key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StreamReader), Member = "DataAvailable", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CStreamWriter), Member = "InternalWriteChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void QueueEcho(char c) { }

	[CalledBy(Type = typeof(CStreamReader), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TermInfoDriver), Member = "GetKeyFromBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(TermInfoDriver), Member = "ReadKeyInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(ConsoleKeyInfo))]
	[Calls(Type = typeof(TermInfoDriver), Member = "Echo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleKeyInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CStreamWriter), Member = "InternalWriteChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TermInfoDriver), Member = "AddToBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public int Read(out Char[] dest, int index, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TermInfoDriver), Member = "ReadKeyInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(ConsoleKeyInfo))]
	[Calls(Type = typeof(TermInfoDriver), Member = "Echo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleKeyInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CStreamWriter), Member = "InternalWriteChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override ConsoleKeyInfo ReadKey(bool intercept) { }

	[CalledBy(Type = typeof(TermInfoDriver), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "ReadKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConsoleKeyInfo))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "ReadUntilConditionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(TermInfoDriver), Member = "InitKeys", ReturnType = typeof(void))]
	[Calls(Type = typeof(TermInfoDriver), Member = "GetKeyFromBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(StreamReader), Member = "DataAvailable", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TermInfoDriver), Member = "AddToBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private ConsoleKeyInfo ReadKeyInternal(out bool fresh) { }

	[CalledBy(Type = typeof(CStreamReader), Member = "ReadLine", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TermInfoDriver), Member = "ReadUntilConditionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	public override string ReadLine() { }

	[CalledBy(Type = typeof(CStreamReader), Member = "ReadToEnd", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TermInfoDriver), Member = "ReadUntilConditionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	public string ReadToEnd() { }

	[CalledBy(Type = typeof(TermInfoDriver), Member = "ReadLine", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "ReadToEnd", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(TermInfoDriver), Member = "GetCursorPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TermInfoDriver), Member = "ReadKeyInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(ConsoleKeyInfo))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(TermInfoDriver), Member = "Echo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleKeyInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CStreamWriter), Member = "InternalWriteChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private string ReadUntilConditionInternal(bool haltOnNewLine) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TermInfoDriver), Member = "TryTermInfoDir", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static string SearchTerminfo(string term) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(TermInfoDriver), Member = "CheckWindowDimensions", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParameterizedStrings), Member = "EvaluateInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(FormatParam[]), "System.ParameterizedStrings+LowLevelStack", typeof(FormatParam[]&), typeof(FormatParam[]&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CStreamWriter), Member = "InternalWriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 25)]
	public override void SetCursorPosition(int left, int top) { }

	[CalledBy(Type = typeof(TermInfoDriver), Member = "SearchTerminfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(File), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private static string TryTermInfoDir(string dir, string term) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CStreamWriter), Member = "InternalWriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void WriteConsole(string str) { }

	[CalledBy(Type = typeof(CStreamWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CStreamWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TermInfoDriver), Member = "CreateKeyInfoFromInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(ConsoleKeyInfo))]
	[Calls(Type = typeof(TermInfoDriver), Member = "WriteSpecialKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleKeyInfo)}, ReturnType = typeof(void))]
	public void WriteSpecialKey(char c) { }

	[CalledBy(Type = typeof(TermInfoDriver), Member = "WriteSpecialKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "Echo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleKeyInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsInvalidInstructions]
	public void WriteSpecialKey(ConsoleKeyInfo key) { }

}

