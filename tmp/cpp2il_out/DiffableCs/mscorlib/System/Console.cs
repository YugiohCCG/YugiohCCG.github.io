namespace System;

public static class Console
{
	private class WindowsConsole
	{
		private sealed class WindowsCancelHandler : MulticastDelegate
		{

			[CallerCount(Count = 45)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public WindowsCancelHandler(object object, IntPtr method) { }

			[CallerCount(Count = 3)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override bool Invoke(int keyCode) { }

		}

		public static bool ctrlHandlerAdded; //Field offset: 0x0
		private static WindowsCancelHandler cancelHandler; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Monitor), Member = "ThrowLockTakenException", ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SpinLock), Member = "ExitSlowPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Thread), Member = "EndCriticalRegion", ReturnType = typeof(void))]
		[Calls(Type = typeof(ManualResetEventSlim), Member = "set_Waiters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CancellationTokenRegistration), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(Interlocked), Member = "MemoryBarrier", ReturnType = typeof(void))]
		[Calls(Type = typeof(ThreadPoolWorkQueue), Member = "Dequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadPoolWorkQueueThreadLocals), typeof(IThreadPoolWorkItem&), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ThreadPoolWorkQueue), Member = "EnsureThreadRequested", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 24)]
		private static WindowsConsole() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Console), Member = "DoConsoleCancelEvent", ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		private static bool DoWindowsConsoleCancelEvent(int keyCode) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private static int GetConsoleCP() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private static int GetConsoleOutputCP() { }

		[CalledBy(Type = typeof(Console), Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public static int GetInputCodePage() { }

		[CalledBy(Type = typeof(Console), Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public static int GetOutputCodePage() { }

	}

	internal static TextWriter stdout; //Field offset: 0x0
	private static TextWriter stderr; //Field offset: 0x8
	private static TextReader stdin; //Field offset: 0x10
	internal static bool IsRunningOnAndroid; //Field offset: 0x18
	private static Encoding inputEncoding; //Field offset: 0x20
	private static Encoding outputEncoding; //Field offset: 0x28
	private static ConsoleCancelEventHandler cancel_event; //Field offset: 0x30

	public static TextWriter Error
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	public static Encoding InputEncoding
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	public static TextWriter Out
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 78
	}

	public static Encoding OutputEncoding
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(File), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EncodingHelper), Member = "InternalCodePage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(EncodingHelper), Member = "get_UTF8Unmarked", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Encoding), Member = "get_Default", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(WindowsConsole), Member = "GetInputCodePage", ReturnType = typeof(int))]
	[Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(WindowsConsole), Member = "GetOutputCodePage", ReturnType = typeof(int))]
	[Calls(Type = typeof(Console), Member = "SetupStreams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding), typeof(Encoding)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	private static Console() { }

	[CalledBy(Type = typeof(WindowsConsole), Member = "DoWindowsConsoleCancelEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConsoleCancelEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleSpecialKey)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private static void DoConsoleCancelEvent() { }

	[CallerCount(Count = 0)]
	public static TextWriter get_Error() { }

	[CallerCount(Count = 0)]
	public static Encoding get_InputEncoding() { }

	[CallerCount(Count = 0)]
	public static TextWriter get_Out() { }

	[CallerCount(Count = 0)]
	public static Encoding get_OutputEncoding() { }

	[CalledBy(Type = typeof(Console), Member = "OpenStandardError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Stream))]
	[CalledBy(Type = typeof(Console), Member = "OpenStandardInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Stream))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(FileAccess), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static Stream Open(IntPtr handle, FileAccess access, int bufferSize) { }

	[CalledBy(Type = typeof(Console), Member = "SetupStreams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding), typeof(Encoding)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MonoIO), Member = "get_ConsoleError", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(Console), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(FileAccess), typeof(int)}, ReturnType = typeof(Stream))]
	public static Stream OpenStandardError(int bufferSize) { }

	[CalledBy(Type = typeof(Console), Member = "SetupStreams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding), typeof(Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MonoIO), Member = "get_ConsoleInput", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(Console), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(FileAccess), typeof(int)}, ReturnType = typeof(Stream))]
	public static Stream OpenStandardInput(int bufferSize) { }

	[CalledBy(Type = typeof(Console), Member = "SetupStreams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding), typeof(Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MonoIO), Member = "get_ConsoleOutput", ReturnType = typeof(IntPtr))]
	[ContainsInvalidInstructions]
	public static Stream OpenStandardOutput(int bufferSize) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static ConsoleKeyInfo ReadKey(bool intercept) { }

	[CalledBy(Type = typeof(CStreamReader), Member = "Read", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static ConsoleKeyInfo ReadKey() { }

	[CalledBy(Type = "UnityEngine.UnityLogWriter", Member = "Init", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextWriter), Member = "Synchronized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(TextWriter))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static void SetError(TextWriter newError) { }

	[CalledBy(Type = "UnityEngine.UnityLogWriter", Member = "Init", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextWriter), Member = "Synchronized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(TextWriter))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static void SetOut(TextWriter newOut) { }

	[CalledBy(Type = typeof(Console), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConsoleDriver), Member = "get_IsConsole", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Console), Member = "OpenStandardInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Stream))]
	[Calls(Type = typeof(CStreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Console), Member = "OpenStandardOutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Stream))]
	[Calls(Type = typeof(CStreamWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextWriter), Member = "Synchronized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(TextWriter))]
	[Calls(Type = typeof(Console), Member = "OpenStandardError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Stream))]
	[Calls(Type = typeof(UnexceptionalStreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextReader), Member = "Synchronized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(TextReader))]
	[Calls(Type = typeof(UnexceptionalStreamWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private static void SetupStreams(Encoding inputEncoding, Encoding outputEncoding) { }

	[CalledBy(Type = "Manager.Updater", Member = "RunMacBashCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater", Member = "RunLinuxBashCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalDuel", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), "Game.Local.LocalGame"}, ReturnType = "Game.Local.LocalDuel")]
	[CalledBy(Type = "DuelBot.Game.AI.Decks.VirtualWorldExecutor", Member = "OnChainEnd", ReturnType = typeof(void))]
	[CalledBy(Type = "DuelBot.Game.AI.Decks.VirtualWorldExecutor", Member = "OnNewTurn", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void WriteLine(string value) { }

	[CalledBy(Type = "Mono.Btls.MonoBtlsX509LookupMono", Member = "OnGetBySubject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr&)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Unity.Collections.CollectionHelper", Member = "WriteLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void WriteLine(string format, object arg0) { }

	[CalledBy(Type = "Unity.Collections.CollectionHelper", Member = "WriteLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void WriteLine(string format, object arg0, object arg1, object arg2) { }

}

