namespace System;

public sealed class UnhandledExceptionEventHandler : MulticastDelegate
{

	[CallerCount(Count = 290)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public UnhandledExceptionEventHandler(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Invoke(object sender, UnhandledExceptionEventArgs e) { }

}

