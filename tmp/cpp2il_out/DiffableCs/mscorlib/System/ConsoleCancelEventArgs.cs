namespace System;

public sealed class ConsoleCancelEventArgs : EventArgs
{
	private readonly ConsoleSpecialKey _type; //Field offset: 0x10
	[CompilerGenerated]
	private bool <Cancel>k__BackingField; //Field offset: 0x14

	public bool Cancel
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(Console), Member = "DoConsoleCancelEvent", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal ConsoleCancelEventArgs(ConsoleSpecialKey type) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal ConsoleCancelEventArgs() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_Cancel() { }

}

