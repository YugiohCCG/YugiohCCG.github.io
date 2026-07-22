namespace System;

internal class NullConsoleDriver : IConsoleDriver
{
	private static readonly ConsoleKeyInfo EmptyConsoleKeyInfo; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleKeyInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(ConsoleKey), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	private static NullConsoleDriver() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public NullConsoleDriver() { }

	[CallerCount(Count = 0)]
	public override ConsoleKeyInfo ReadKey(bool intercept) { }

}

