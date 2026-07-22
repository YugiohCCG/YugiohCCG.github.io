namespace System;

internal static class ConsoleDriver
{
	internal static IConsoleDriver driver; //Field offset: 0x0
	private static bool is_console; //Field offset: 0x8
	private static bool called_isatty; //Field offset: 0x9

	public static bool IsConsole
	{
		[CalledBy(Type = typeof(Console), Member = "SetupStreams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding), typeof(Encoding)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ConsoleDriver), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(MonoIO), Member = "get_ConsoleOutput", ReturnType = typeof(IntPtr))]
		[Calls(Type = typeof(MonoIO), Member = "get_ConsoleInput", ReturnType = typeof(IntPtr))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 346
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleDriver), Member = "get_IsConsole", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ConsoleDriver), Member = "CreateTermInfoDriver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IConsoleDriver))]
	[Calls(Type = typeof(ConsoleDriver), Member = "CreateNullConsoleDriver", ReturnType = typeof(IConsoleDriver))]
	[Calls(Type = typeof(ConsoleDriver), Member = "CreateWindowsConsoleDriver", ReturnType = typeof(IConsoleDriver))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static ConsoleDriver() { }

	[CalledBy(Type = typeof(ConsoleDriver), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	private static IConsoleDriver CreateNullConsoleDriver() { }

	[CalledBy(Type = typeof(ConsoleDriver), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TermInfoDriver), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	private static IConsoleDriver CreateTermInfoDriver(string term) { }

	[CalledBy(Type = typeof(ConsoleDriver), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WindowsConsoleDriver), Member = ".ctor", ReturnType = typeof(void))]
	private static IConsoleDriver CreateWindowsConsoleDriver() { }

	[CalledBy(Type = typeof(Console), Member = "SetupStreams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding), typeof(Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConsoleDriver), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MonoIO), Member = "get_ConsoleOutput", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(MonoIO), Member = "get_ConsoleInput", ReturnType = typeof(IntPtr))]
	[CallsUnknownMethods(Count = 2)]
	public static bool get_IsConsole() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal static int InternalKeyAvailable(int ms_timeout) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static bool Isatty(IntPtr handle) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static ConsoleKeyInfo ReadKey(bool intercept) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool SetEcho(bool wantEcho) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool TtySetup(string keypadXmit, string teardown, out Byte[] control_characters, out Int32* address) { }

}

