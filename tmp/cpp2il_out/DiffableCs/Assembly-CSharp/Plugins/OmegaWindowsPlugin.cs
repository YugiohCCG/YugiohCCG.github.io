namespace Plugins;

public static class OmegaWindowsPlugin
{
	internal struct PROCESS_INFORMATION
	{
		public IntPtr hProcess; //Field offset: 0x0
		public IntPtr hThread; //Field offset: 0x8
		public uint dwProcessId; //Field offset: 0x10
		public uint dwThreadId; //Field offset: 0x14

	}

	internal struct STARTUPINFO
	{
		public uint cb; //Field offset: 0x0
		public string lpReserved; //Field offset: 0x8
		public string lpDesktop; //Field offset: 0x10
		public string lpTitle; //Field offset: 0x18
		public uint dwX; //Field offset: 0x20
		public uint dwY; //Field offset: 0x24
		public uint dwXSize; //Field offset: 0x28
		public uint dwYSize; //Field offset: 0x2C
		public uint dwXCountChars; //Field offset: 0x30
		public uint dwYCountChars; //Field offset: 0x34
		public uint dwFillAttribute; //Field offset: 0x38
		public uint dwFlags; //Field offset: 0x3C
		public short wShowWindow; //Field offset: 0x40
		public short cbReserved2; //Field offset: 0x42
		public IntPtr lpReserved2; //Field offset: 0x48
		public IntPtr hStdInput; //Field offset: 0x50
		public IntPtr hStdOutput; //Field offset: 0x58
		public IntPtr hStdError; //Field offset: 0x60

	}

	private static IntPtr UnityWindow; //Field offset: 0x0
	private const uint SW_RESTORE = 9; //Field offset: 0x0
	private const uint SW_SHOW = 5; //Field offset: 0x0
	private const byte ALT = 164; //Field offset: 0x0
	private const int EXTENDEDKEY = 1; //Field offset: 0x0
	private const int KEYUP = 2; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	public static bool CreateProcess(string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, in STARTUPINFO lpStartupInfo, out PROCESS_INFORMATION lpProcessInformation) { }

	[CalledBy(Type = "ClientAPI.WebServer+<OnFocus>d__26", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void FocusApp() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr GetActiveWindow() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static bool SetForegroundWindow(IntPtr hWnd) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int ShowWindow(IntPtr hWnd, uint Msg) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int ShowWindowAsync(IntPtr hWnd, uint Msg) { }

	[CalledBy(Type = "Manager.Helper+<Init>d__98", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void Start() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	public static bool StartProcess(string applicationName, string commandLine) { }

}

