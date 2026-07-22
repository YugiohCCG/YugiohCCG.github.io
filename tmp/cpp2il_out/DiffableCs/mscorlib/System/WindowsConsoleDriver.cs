namespace System;

internal class WindowsConsoleDriver : IConsoleDriver
{
	private IntPtr inputHandle; //Field offset: 0x10
	private IntPtr outputHandle; //Field offset: 0x18
	private short defaultAttribute; //Field offset: 0x20

	[CalledBy(Type = typeof(ConsoleDriver), Member = "CreateWindowsConsoleDriver", ReturnType = typeof(IConsoleDriver))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WindowsConsoleDriver), Member = "GetStdHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Handles)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public WindowsConsoleDriver() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static bool GetConsoleScreenBufferInfo(IntPtr handle, out ConsoleScreenBufferInfo info) { }

	[CalledBy(Type = typeof(WindowsConsoleDriver), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static IntPtr GetStdHandle(Handles handle) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool IsModifierKey(short virtualKeyCode) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static bool ReadConsoleInput(IntPtr handle, out InputRecord record, int length, out int nread) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleKeyInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(ConsoleKey), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "GetLastWin32Error", ReturnType = typeof(int))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	public override ConsoleKeyInfo ReadKey(bool intercept) { }

}

